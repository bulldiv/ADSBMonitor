using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ADSBMonitor.App.Annotations;
using VirtualRadar.Interface.Adsb;

namespace ADSBMonitor.App
{
    public class MonitorViewModel : INotifyPropertyChanged
    {
        private string _identification;
        private double? _airborneVelocity;
        private MessageFormat _messageFormat;
        private byte? _sil;
        private SystemDesignAssurance? _systemDesignAssurance;
        private int? _barometricAltitude;
        private int _lattitude;
        private int _longitude;

        public int? BarometricAltitude
        {
            get { return _barometricAltitude; }
            set { _barometricAltitude = value; OnPropertyChanged("BarometricAltitude"); }
        }

        public int Lattitude
        {
            get { return _lattitude; }
            set { _lattitude = value;OnPropertyChanged("Lattitude"); }
        }

        public int Longitude
        {
            get { return _longitude; }
            set { _longitude = value;OnPropertyChanged("Longitude"); }
        }

        public SystemDesignAssurance? SystemDesignAssurance
        {
            get { return _systemDesignAssurance; }
            set { _systemDesignAssurance = value; OnPropertyChanged("SystemDesignAssurance"); }
        }

        public byte? Sil
        {
            get { return _sil; }
            set { _sil = value; OnPropertyChanged("Sil"); }
        }

        public MonitorViewModel()
        {
            Identification = String.Empty;
        }

        public string Identification
        {
            get { return _identification; }
            set { _identification = value; OnPropertyChanged("Identification"); }
        }

        public MessageFormat MessageFormat
        {
            get { return _messageFormat; }
            set { _messageFormat = value; OnPropertyChanged("MessageFormat"); }
        }

        public double? AirborneVelocity
        {
            get { return _airborneVelocity; }
            set { _airborneVelocity = value; OnPropertyChanged("AirborneVelocity"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
