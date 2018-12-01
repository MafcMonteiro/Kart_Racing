using Gympass_Kart.Application.Interfaces;
using Gympass_Kart.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gympass_Kart.Dependency.Injection
{
    public class DependencyInjection
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddScoped<IKartApplicationService, KartApplicationService>();
            services.AddScoped<IUtilsApplicationService, UtilsApplicationService>();
        }
    }
}
