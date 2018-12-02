using System;
using System.Collections.Generic;
using System.Text;

namespace Gympass_Kart.Application.Model
{
    public class KartModel
    {
        public TimeSpan Hora { get; set; }
        public string Piloto { get; set; }
        public int NumVolta { get; set; }
        public TimeSpan TempoVolta { get; set; }
        public decimal VelMediaVolta { get; set; }
    }

    public class Podium
    {
        public int Posicao { get; set; }
        public int CodigoPiloto { get; set; }
        public string NomePiloto { get; set; }
        public int QtdVoltas { get; set; }
        public TimeSpan TempoProva { get; set; }

    }

    public class Bestlap
    {
        public int CodigoPiloto { get; set; }
        public string NomePiloto { get; set; }
        public TimeSpan MelhorVolta { get; set; }
    }

    public class AverageSpeed
    {
        public int CodigoPiloto { get; set; }
        public string NomePiloto { get; set; }
        public string VelMedia { get; set; }
    }


    public class InvertvalPosition
    {
        public int Posicao { get; set; }
        public int CodigoPiloto { get; set; }
        public string NomePiloto { get; set; }
        public int QtdVoltas { get; set; }
        public TimeSpan TempoProva { get; set; }
        public TimeSpan Interval { get; set; }
    }
}
