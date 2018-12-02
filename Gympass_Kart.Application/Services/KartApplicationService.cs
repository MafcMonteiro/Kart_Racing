using Gympass_Kart.Application.Interfaces;
using Gympass_Kart.Application.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Gympass_Kart.Application.Services
{
    public class KartApplicationService : IKartApplicationService
    {

        private readonly IUtilsApplicationService utilsApplicationService;

        public KartApplicationService(IUtilsApplicationService utilsApplicationService)
        {
            this.utilsApplicationService = utilsApplicationService;
        }

        public List<Podium> GetkartResult()
        {
            //Busca os dados na base 
            var list = utilsApplicationService.ResumeDataBase();

            var podium = new List<Podium>();

            //Busca a Ordem do podium
            var query = list.GroupBy(x => x.Piloto).Select(g => new
            {
                Piloto = g.Key,
                NumVolta = g.Max(x => x.NumVolta),
                Hora = g.Max(x => x.Hora)
            }).ToList();

            var orderyQuery = query.OrderBy(x => x.Hora).ToList();

            var position = 1;

            foreach (var item in orderyQuery)
            {
                //Filtra por piloto para chegar no cálculo entre a primeira volta e a ultima volta
                var calc = list.Where(x => x.Piloto == item.Piloto).ToList();
                var tempoProva = calc.LastOrDefault().Hora - calc.FirstOrDefault().Hora;

                podium.Add(new Podium
                {
                    Posicao = position,
                    CodigoPiloto = Convert.ToInt32(item.Piloto.Substring(0, 3)),
                    NomePiloto = item.Piloto.Substring(5).Trim(),
                    QtdVoltas = item.NumVolta,
                    TempoProva = tempoProva
                });
                position++;
            }

            return podium.ToList();
        }

        public List<Bestlap> FindBestLapAllPilots()
        {
            var bestLap = new List<Bestlap>();

            //Busca lista da corrida
            var list = utilsApplicationService.ResumeDataBase();

            var query = list.GroupBy(x => x.Piloto).ToList();

            foreach (var item in query)
            {
                bestLap.Add(new Bestlap
                {
                    CodigoPiloto = Convert.ToInt32(item.Key.Substring(0, 3)),
                    NomePiloto = item.Key.Substring(5).Trim(),
                    MelhorVolta = list.Where(x => x.Piloto == item.Key).Min(x => x.TempoVolta)
                });
            }

            return bestLap;
        }

        public Bestlap FindBestLap()
        {
            var bestLap = new Bestlap();
            //Busca lista da corrida
            var list = utilsApplicationService.ResumeDataBase();

            var query = list.OrderBy(x => x.TempoVolta).FirstOrDefault();

            bestLap.CodigoPiloto = Convert.ToInt32(query.Piloto.Substring(0, 3));
            bestLap.NomePiloto = query.Piloto.Substring(5).Trim();
            bestLap.MelhorVolta = query.TempoVolta;

            return bestLap;
        }

        public List<AverageSpeed> AverageSpeed()
        {

            var Speed = new List<AverageSpeed>();

            var list = utilsApplicationService.ResumeDataBase();

            var query = list.GroupBy(x => x.Piloto).ToList();

            foreach (var item in query)
            {
                Speed.Add(new AverageSpeed
                {
                    CodigoPiloto = Convert.ToInt32(item.Key.Substring(0, 3)),
                    NomePiloto = item.Key.Substring(5).Trim(),
                    VelMedia = String.Format("{0:#,0.000}",list.Where(x => x.Piloto == item.Key).Sum(x => x.VelMediaVolta) / list.Where(x => x.Piloto == item.Key).Max(x => x.NumVolta))

                });
            }

            return Speed;
        }



    }
}
