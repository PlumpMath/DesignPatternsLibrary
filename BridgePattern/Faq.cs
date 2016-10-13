﻿using System;
using System.Collections.Generic;

namespace BridgePattern
{
    public class Faq : Manuscript
    {
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public Faq(IFormatter formatter) : base(formatter)
        {
            Questions = new Dictionary<string, string>();
        }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            foreach (var question in Questions)
            {
                Console.WriteLine(formatter.Format("   Question", question.Key));
                Console.WriteLine(formatter.Format("   Answer", question.Value));
            }
            Console.WriteLine();
        }
    }
}
