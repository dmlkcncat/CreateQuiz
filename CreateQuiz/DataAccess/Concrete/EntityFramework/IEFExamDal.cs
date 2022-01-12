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
    public class IEFExamDal : EFEntityRepositoryBase<Exam, DatabaseContext>, IExamDal
    {
        public List<ExamDetailDto> GetExamDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from e in context.Exam
                             join a in context.Article
                             on e.ArticleId equals a.Id
                             join u in context.User
                             on e.UserId equals u.Id
                             select new ExamDetailDto
                             {
                                 Id = e.Id,
                                 ArticleId = e.ArticleId,
                                 ExamName = e.ExamName,
                                 Date = e.Date,
                                 ArticleName = a.ArticleName,
                                 Contents = a.Contents,
                                 UserId = e.UserId,
                                 UserName = u.UserName,
                                 Password = u.Password,
                             };
                return result.ToList();
            }
        }
    }
}
