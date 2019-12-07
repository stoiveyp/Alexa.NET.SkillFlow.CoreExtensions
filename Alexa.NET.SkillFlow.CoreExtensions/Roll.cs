using System;
using System.Collections.Generic;
using System.Text;

namespace Alexa.NET.SkillFlow.CoreExtensions
{
    public class Roll:SceneInstruction
    {
        public override string Type => nameof(Roll);
        public int Dice { get; set; }
        public int Sides { get; set; }
        public int Modifier { get; set; }
        public int Top { get; set; }
    }
}
