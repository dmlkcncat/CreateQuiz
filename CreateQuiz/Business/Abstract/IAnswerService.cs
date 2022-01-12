using Core.Ultities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnswerService
    {
        List<Answer> GetAll();
        List<AnswerDetailDto> GetAnswerDetails();
        IResult Add(Answer answer);
    }
}
