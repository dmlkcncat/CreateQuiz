using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DamlaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        IExamService _examService;
        public ExamsController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpGet]
        public List<ExamDetailDto> Get()
        {
            var result = _examService.GetExamDetails();
            return result;
        }

        [HttpPost]
        public IActionResult Post(Exam exam)
        {
            var result = _examService.Add(exam);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Exam exam)
        {
            var result = _examService.Delete(exam);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
