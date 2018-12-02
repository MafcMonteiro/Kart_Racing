using Gympass_Kart.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gympass_Kart.Application.Interfaces
{
    public interface IUtilsApplicationService
    {
        List<KartModel> ResumeDataBase();
        TimeSpan CalculaTempoProva(List<KartModel> kartModels, string Piloto);
    }
}
