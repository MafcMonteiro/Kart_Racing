﻿using Gympass_Kart.Application.Interfaces;
using Gympass_Kart.Application.Model;
using Gympass_Kart.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gympass_Kart.Controllers
{

    
    [ApiController]
    public class KartController : ApiControllerBase
    {
        private readonly IKartApplicationService kartApplicationService;

        public KartController(IKartApplicationService kartApplicationService)
        {
            this.kartApplicationService = kartApplicationService;
        }

        //public ActionResult<IEnumerable<string>> Get()

        [HttpGet]
        public IActionResult Get()
        {

            var t = "";
            return CreateResponse(() => kartApplicationService.GetkartResult());
        }


        [HttpGet("FindBestLapAllPilots")]
        public IActionResult FindBestLapAllPilots()
        {
            return CreateResponse(() => kartApplicationService.FindBestLapAllPilots());
        }

        [HttpGet("FindBestLap")]
        public IActionResult FindBestLap()
        {
            return CreateResponse(() => kartApplicationService.FindBestLap());
        }

        [HttpGet("AverageSpeed")]
        public IActionResult AverageSpeed()
        {
            return CreateResponse(() => kartApplicationService.AverageSpeed());
        }

        [HttpGet("IntervalFirstPostiion")]
        public IActionResult IntervalFirstPostiion()
        {
            return CreateResponse(() => kartApplicationService.InvertvalPosition());
        }
    }
}


