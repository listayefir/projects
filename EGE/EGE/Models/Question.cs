using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EGE.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Quest { get; set; }
        public string Answer1 { get; set; }
        public string Answer2  { get; set; }
        public string RightAnswer { get; set; }
    }

    public class QuestionDBContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
    }
}