using Business.Abstract;
using Business.Constans;
using Core.Ultities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _answerDal;
        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = answerDal;
        }

        public IResult Add(Answer answer)
        {
            _answerDal.Add(answer);
            return new SuccessResult(Messages.QuestionAdded);
        }

        public List<Answer> GetAll()
        {
            return _answerDal.GetAll();
        }

        public List<AnswerDetailDto> GetAnswerDetails()
        {
            return _answerDal.GetAnswerDetails();
        }
    }
}
