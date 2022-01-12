using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ExamDetailDto : IDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public string ExamName { get; set; }
        public string Date { get; set; }

        public string ArticleName { get; set; }
        public string Contents { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
