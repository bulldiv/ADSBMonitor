using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualRadar.Interface.Adsb;

namespace ADSBSharp
{
    class AircraftSummary
    {
        public string IcaoCode { get; set; }

        public string Registration { get; set; }

        public byte? SIL { get; set; }

        public SystemDesignAssurance? SDA { get; set; }

        public double? Airspeed { get; set; }

        public override string ToString()
        {
            return string.Format("ICAO: {0}, Registration: {1}, SIL: {2}, SDA: {3}, Airspeed: {4}", IcaoCode, Registration, SIL, SDA, Airspeed);
        }
    }
}
