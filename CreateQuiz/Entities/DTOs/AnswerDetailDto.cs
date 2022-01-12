using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AnswerDetailDto : IDto
    {
        public int Id  { get; set; }
        public int QuestionId { get; set; }
        public string QuestionContent { get; set; }
        public string AnswerContent { get; set; }
        public int AnswerKey { get; set; }
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string Contents { get; set; }
        public int ExamId { get; set; }
        public string ExamName { get; set; }

    }
}
