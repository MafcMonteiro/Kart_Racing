using Gympass_Kart.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gympass_Kart.Application.Interfaces
{
    public interface IKartApplicationService
    {
        List<Podium> GetkartResult();
        List<Bestlap> FindBestLap();

    }
}
