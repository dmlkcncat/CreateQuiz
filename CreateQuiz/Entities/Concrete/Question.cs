using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int ArticleId { get; set; }
        public  string QuestionContent { get; set; }

    }
}
