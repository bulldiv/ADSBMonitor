using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using VirtualRadar.Interface.Adsb;
using VirtualRadar.Library;
using VirtualRadar.Library.Adsb;
using VirtualRadar.Library.ModeS;

namespace ADSBSharp
{
    public unsafe partial class MainForm : Form
    {        
        private readonly AdsbBitDecoder _decoder = new AdsbBitDecoder();
        private readonly RtlSdrIO _rtlDevice = new RtlSdrIO();        
        private bool _isDecoding;        
        private bool _initialized;
        private int _frameCount;
        private float _avgFps;

        private DataTable _dataSet = new DataTable();

        public MainForm()
        {
            InitializeComponent();

            _dataSet.Columns.Add("ICAO", typeof(string));
            _dataSet.Columns.Add("LastUpdate", typeof(DateTime));
            _dataSet.Columns.Add("Identification", typeof(string));
            _dataSet.Columns.Add("AirborneVelocity", typeof(string));
            _dataSet.Columns.Add("Sil", typeof(string));
            _dataSet.Columns.Add("SystemDesignAssurance", typeof(string));
            _dataSet.Columns.Add("BarometricAltitude", typeof(string));
            _dataSet.Columns.Add("Lattitude", typeof(string));
            _dataSet.Columns.Add("Longitude", typeof(string));

            dataGridView1.DataSource = _dataSet;
            dataGridView1.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            //dataGridView1.Columns[3].DefaultCellStyle.Format = "0.##";

            var adsbTranslator = new AdsbTranslator();
            adsbTranslator.Statistics = new Statistics();

            Text = "ADSB# v" + Assembly.GetExecutingAssembly().GetName().Version;

            _decoder.FrameReceived += delegate(byte[] frame, int length)
            {
                Interlocked.Increment(ref _frameCount);

                var t = new ModeSTranslator();
                t.Statistics = new Statistics();
                var modeSMessage = t.Translate(frame, 0, null, false);

                AdsbTranslator t2 = new AdsbTranslator();
                t2.Statistics = new Statistics();
                AdsbMessage adsbMessage = t2.Translate(modeSMessage);

                if (adsbMessage != null)
                {
                    BeginInvoke(new Action(delegate
                    {
                        Debug.Print(adsbMessage.ToString());
                        UpdateView(adsbMessage);
                    }));

                }
            };

            confidenceNumericUpDown_ValueChanged(null, null);
            timeoutNumericUpDown_ValueChanged(null, null);

            try
            {
                _rtlDevice.Open();

                var devices = DeviceDisplay.GetActiveDevices();
                deviceComboBox.Items.Clear();
                deviceComboBox.Items.AddRange(devices);

                //_initialized = true;
                deviceComboBox.SelectedIndex = 0;
                deviceComboBox_SelectedIndexChanged(null, null);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void UpdateViewModelField(string icao, string fieldName, string fieldValue)
        {

            var rows = _dataSet.Select(string.Format("ICAO = '{0}'", icao));
            if (rows.Any())
            {
                foreach (var row in rows)
                {
                    row[fieldName] = fieldValue;
                    row["LastUpdate"] = DateTime.UtcNow;
                }
            }
            else
            {
                _dataSet.LoadDataRow(
                    new object[]
                    {
                        icao, DateTime.UtcNow, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                        string.Empty
                    }, LoadOption.Upsert);
            }
        }

        private void UpdateView(AdsbMessage message)
        {
            string key = message.ModeSMessage.FormattedIcao24;

            switch (message.MessageFormat)
            {
                case MessageFormat.IdentificationAndCategory:
                    UpdateViewModelField(key, "Identification", message.IdentifierAndCategory.Identification);
                    break;
                case MessageFormat.AirborneVelocity:
                    if (message.AirborneVelocity.VectorVelocity != null)
                    {
                        UpdateViewModelField(key, "AirborneVelocity", message.AirborneVelocity.VectorVelocity.Speed.ToString());
                    }
                    break;
                case MessageFormat.AircraftOperationalStatus:
                    UpdateViewModelField(key, "Sil", message.AircraftOperationalStatus.Sil.ToString());
                    UpdateViewModelField(key, "SystemDesignAssurance",
                        message.AircraftOperationalStatus.SystemDesignAssurance.ToString());
                    break;
                case MessageFormat.AirbornePosition:
                    UpdateViewModelField(key, "BarometricAltitude", message.AirbornePosition.BarometricAltitude.ToString());
                    UpdateViewModelField(key, "Lattitude", message.AirbornePosition.CompactPosition.Latitude.ToString());
                    UpdateViewModelField(key, "Longitude", message.AirbornePosition.CompactPosition.Longitude.ToString());
                    break;
            }
        }

        #region GUI Controls

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!_isDecoding)
            {
                StartDecoding();
            }
            else
            {
                StopDecoding();
            }

            startBtn.Text = _isDecoding ? "Stop" : "Start";
            deviceComboBox.Enabled = !_rtlDevice.Device.IsStreaming;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isDecoding)
            {
                StopDecoding();
            }
        }
       
        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var deviceDisplay = (DeviceDisplay) deviceComboBox.SelectedItem;
            if (deviceDisplay != null)
            {
                try
                {
                    _rtlDevice.SelectDevice(deviceDisplay.Index);                    
                    _rtlDevice.Frequency = 1090000000;
                    _rtlDevice.Device.Samplerate = 2000000;
                    _initialized = true;
                }
                catch (Exception ex)
                {
                    deviceComboBox.SelectedIndex = -1;
                    _initialized = false;
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ConfigureDevice();
                ConfigureGUI();
            }
        }

        private void tunerGainTrackBar_Scroll(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                return;
            }
            var gain = _rtlDevice.Device.SupportedGains[tunerGainTrackBar.Value];
            _rtlDevice.Device.TunerGain = gain;
            gainLabel.Text = gain / 10.0 + " dB";            
        }
        
        private void tunerAgcCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                return;
            }
            tunerGainTrackBar.Enabled = tunerAgcCheckBox.Enabled && !tunerAgcCheckBox.Checked;
            _rtlDevice.Device.UseTunerAGC = tunerAgcCheckBox.Checked;
            gainLabel.Visible = tunerAgcCheckBox.Enabled && !tunerAgcCheckBox.Checked;
            if (!tunerAgcCheckBox.Checked)
            {
                tunerGainTrackBar_Scroll(null, null);
            }
        }

        private void frequencyCorrectionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                return;
            }
            _rtlDevice.Device.FrequencyCorrection = (int) frequencyCorrectionNumericUpDown.Value;
        }

        private void rtlAgcCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                return;
            }
            _rtlDevice.Device.UseRtlAGC = rtlAgcCheckBox.Checked;            
        }

        #endregion

        #region Private Methods

        private void ConfigureGUI()
        {
            startBtn.Enabled = _initialized;
            if (!_initialized)
            {
                return;
            }
            
            tunerTypeLabel.Text = _rtlDevice.Device.TunerType.ToString();
            tunerGainTrackBar.Maximum = _rtlDevice.Device.SupportedGains.Length - 1;
            tunerGainTrackBar.Value = tunerGainTrackBar.Maximum;
            
            for (var i = 0; i < deviceComboBox.Items.Count; i++)
            {
                var deviceDisplay = (DeviceDisplay)deviceComboBox.Items[i];
                if (deviceDisplay.Index == _rtlDevice.Device.Index)
                {
                    deviceComboBox.SelectedIndex = i;
                    break;
                }
            }            
        }

        private void ConfigureDevice()
        {                        
            frequencyCorrectionNumericUpDown_ValueChanged(null, null);
            rtlAgcCheckBox_CheckedChanged(null, null);
            tunerAgcCheckBox_CheckedChanged(null, null);
            if (!tunerAgcCheckBox.Checked)
            {
                tunerGainTrackBar_Scroll(null, null);
            }
        }

        private void StartDecoding()
        {                        
            try
            {
                _rtlDevice.Start(rtl_SamplesAvailable);
            }
            catch (Exception e)
            {
                StopDecoding();
                MessageBox.Show("Unable to start RTL device\n" + e.Message);
                return;
            }

            _isDecoding = true;
        }

        private void StopDecoding()
        {
            _rtlDevice.Stop();
            _isDecoding = false;
            _avgFps = 0f;
            _frameCount = 0;
        }

        #endregion

        #region Samples Callback

        private void rtl_SamplesAvailable(object sender, Complex* buf, int length)
        {
            for (var i = 0; i < length; i++)
            {
                var real = buf[i].Real;
                var imag = buf[i].Imag;

                var mag = real * real + imag * imag;

                _decoder.ProcessSample(mag);
            }
        }

        #endregion

        private void fpsTimer_Tick(object sender, EventArgs e)
        {
            var fps = (_frameCount) * 1000.0f / fpsTimer.Interval;
            _frameCount = 0;

            _avgFps = 0.9f * _avgFps + 0.1f * fps;

            fpsLabel.Text = ((int) _avgFps).ToString();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
            }
            else
            {
                ShowInTaskbar = true;
            }
        }

        private void confidenceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _decoder.ConfidenceLevel = (int) confidenceNumericUpDown.Value;
        }

        private void timeoutNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _decoder.Timeout = (int) timeoutNumericUpDown.Value;
        }
    }

    public class DeviceDisplay
    {
        public uint Index { get; private set; }
        public string Name { get; set; }

        public static DeviceDisplay[] GetActiveDevices()
        {
            var count = NativeMethods.rtlsdr_get_device_count();
            var result = new DeviceDisplay[count];

            for (var i = 0u; i < count; i++)
            {
                var name = NativeMethods.rtlsdr_get_device_name(i);
                result[i] = new DeviceDisplay { Index = i, Name = name };
            }

            return result;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
