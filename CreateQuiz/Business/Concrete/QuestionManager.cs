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
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;
        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public IResult Add(Question question)
        {
            _questionDal.Add(question);
            return new SuccessResult(Messages.QuestionAdded);
        }

        public List<Question> GetAll()
        {
            return _questionDal.GetAll();
        }

        public List<QuestionDetailDto> GetQuestionDetails()
        {
            return _questionDal.GetQuestionDetails();
        }
    }
}
