using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class OnOffCommand
    {
        public readonly ICommand onCommand;
        public readonly ICommand offCommand;

        public OnOffCommand(ICommand onCommand, ICommand offCommand)
        {
            if (onCommand != null && offCommand != null)
            {
                this.onCommand = onCommand;
                this.offCommand = offCommand;
            }
            else
                throw new ArgumentNullException();
        }
    }
}
