using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class LightOffCommand : ICommand
    {
        public Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    }
}
