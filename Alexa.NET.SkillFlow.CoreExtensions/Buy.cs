using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.SkillFlow.CoreExtensions
{
    public class Buy:SceneInstruction
    {
        public override string Type => nameof(Buy);

        public string Item { get; set; }
        public string SuccessScene { get; set; }
        public string FailureScene { get; set; }
        public string DeclinedScene { get; set; }
        public string AlreadyPurchasedScene { get; set; }
        public string ErrorScene { get; set; }

    }
}
