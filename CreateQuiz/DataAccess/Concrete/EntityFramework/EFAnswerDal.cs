using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFAnswerDal : EFEntityRepositoryBase<Answer, DatabaseContext>, IAnswerDal
    {
        public List<AnswerDetailDto> GetAnswerDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from a in context.Answer
                             join q in context.Question
                             on a.QuestionId equals q.Id
                             join p in context.Article
                             on a.ArticleId equals p.Id
                             join e in context.Exam
                             on a.ExamId equals e.Id
                             select new AnswerDetailDto
                             {
                                 Id = a.Id,
                                 ArticleId = a.ArticleId,
                                 ExamId = a.ExamId,
                                 ExamName = e.ExamName,
                                 ArticleName = p.ArticleName,
                                 Contents = p.Contents,
                                 QuestionContent = q.QuestionContent,
                                 AnswerKey = a.AnswerKey,
                                 AnswerContent = a.AnswerContent,
                                 QuestionId = a.QuestionId

                             };
                return result.ToList();
            }
        }
    }
}
