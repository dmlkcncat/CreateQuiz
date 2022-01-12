using Core.Ultities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IQuestionService
    {
        List<Question> GetAll();
        List<QuestionDetailDto> GetQuestionDetails();
        IResult Add(Question question);
    }
}
