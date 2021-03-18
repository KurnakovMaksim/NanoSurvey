﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NanoSurvey.API.Entities
{
    public class Question
    {
        public Question()
        {
            Answers = new List<Answer>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        public Survey Survey { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
