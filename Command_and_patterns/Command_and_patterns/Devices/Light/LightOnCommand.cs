using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class LightOnCommand : ICommand
    {
        public Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }
}
