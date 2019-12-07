using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.SkillFlow.CoreExtensions
{
    public class Time:SceneInstruction
    {
        public override string Type => nameof(Time);

        public Uri Uri { get; set; }
    }
}
