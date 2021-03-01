using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.service;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificationController : ControllerBase
    {
        private ICertificationService _certificationService;

        public CertificationController(ICertificationService certificationService)
        {
            _certificationService = certificationService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> test()
        {
            return Ok(3);
        }

        //Get: http://localhost/api/certification/getCertifications
        [HttpGet("getCertifications")]
        public async Task<IActionResult> GetCertifications()
        {
            var certifications = await _certificationService.GetCertifications();
            return Ok(certifications);
        }
    }
}
