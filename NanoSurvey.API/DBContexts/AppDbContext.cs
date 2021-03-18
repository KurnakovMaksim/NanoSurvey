﻿using Microsoft.EntityFrameworkCore;
using NanoSurvey.API.Entities;

namespace NanoSurvey.API.DBContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Result> Results { get; set; }
       // public DbSet<ResultAnswer> ResultAnswers { get; set; }
    }
}
