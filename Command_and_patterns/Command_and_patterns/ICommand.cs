using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
