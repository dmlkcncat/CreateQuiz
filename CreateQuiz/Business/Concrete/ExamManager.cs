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
    public class ExamManager : IExamService
    {
        IExamDal _examDal;
        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }

        public void Add(Exam exam)
        {
            _examDal.Add(exam);
        }

        public void Delete(Exam exam)
        {
            _examDal.Delete(exam);
        }

        public List<Exam> GetAll()
        {
            return _examDal.GetAll();
        }

        public List<ExamDetailDto> GetExamDetails()
        {
            return _examDal.GetExamDetails();
        }

        IResult IExamService.Add(Exam exam)
        {
            _examDal.Add(exam);
            return new SuccessResult(Messages.ExamAdded);
        }

        IResult IExamService.Delete(Exam exam)
        {
            _examDal.Delete(exam);
            return new SuccessResult(Messages.ExamDeleted);
        }
    }
}
