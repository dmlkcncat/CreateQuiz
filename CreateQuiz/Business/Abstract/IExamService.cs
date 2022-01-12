using Core.Ultities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IExamService
    {
        List<Exam> GetAll();
        List<ExamDetailDto> GetExamDetails();
        IResult Add(Exam exam);
        IResult Delete(Exam exam);
    }
}
