using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFQuestionDal : EFEntityRepositoryBase<Question, DatabaseContext>, IQuestionDal
    {
        public List<QuestionDetailDto> GetQuestionDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from q in context.Question
                             join e in context.Exam
                             on q.ExamId equals e.Id
                             join a in context.Article
                             on q.ArticleId equals a.Id
                             select new QuestionDetailDto
                             {
                                 Id = q.Id,
                                 ArticleId = q.ArticleId,
                                 ExamId = q.ExamId,
                                 QuestionContent = q.QuestionContent,
                                 ExamName = e.ExamName,
                                 ArticleName = a.ArticleName,
                                 Contents = a.Contents,
                             };
                return result.ToList();
            }
        }
    }
}
