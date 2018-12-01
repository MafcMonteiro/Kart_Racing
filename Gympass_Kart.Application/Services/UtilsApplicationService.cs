using Gympass_Kart.Application.Interfaces;
using Gympass_Kart.Application.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Gympass_Kart.Application.Services
{
    public class UtilsApplicationService: IUtilsApplicationService
    {
        public List<KartModel> ResumeDataBase()
        {
            string[] allLines = File.ReadAllLines(@".\DataBase\PlacarKart.csv");

            var list = new List<KartModel>();

            foreach (var item in allLines)
            {
                var split = item.Split(",");

                #region Tratando o TimeSpan para o campo de Hora
                var splitHora = split[0].Split(":");
                var milliseconds = splitHora[2].Substring(3, 3);
                splitHora[2] = splitHora[2].Remove(2);

                TimeSpan thora = new TimeSpan(
                    0,
                    Convert.ToInt32(splitHora[0]),
                    Convert.ToInt32(splitHora[1]),
                    Convert.ToInt32(splitHora[2]),
                    Convert.ToInt32(milliseconds)
                );
                #endregion


                #region Tratando o TimeSpan para o Campo Tempo da Volta

                var splitHoraVolta = split[3].Split(":");
                var millisecondsVolta = splitHoraVolta[1].Substring(3, 3);
                splitHoraVolta[1] = splitHoraVolta[1].Remove(2);

                TimeSpan thoraVolta = new TimeSpan(
                    0,
                    0,
                    Convert.ToInt32(splitHoraVolta[0]),
                    Convert.ToInt32(splitHoraVolta[1]),
                    Convert.ToInt32(millisecondsVolta)
                );

                #endregion

                var velMedia = split[4].Replace("\\", "").Trim();

                list.Add(new KartModel
                {
                    Hora = thora,
                    Piloto = split[1],
                    NumVolta = Convert.ToInt32(split[2]),
                    TempoVolta = thoraVolta,
                    VelMediaVolta = decimal.Parse(velMedia, CultureInfo.InvariantCulture)
                });
            }

            return list;
        }
    }
}
