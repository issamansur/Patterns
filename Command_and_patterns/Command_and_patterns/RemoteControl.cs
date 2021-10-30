using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class RemoteControl
    {
        public ICommand[] onCommands;
        public ICommand[] offCommands;

        public RemoteControl() {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            onCommands[slot].Execute();
        }

        public void OffButtonWasPressed(int slot)
        {
            offCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append($"[slot {i}] {onCommands[i].GetType().Name} {offCommands[i].GetType().Name}\n");
            }
            return stringBuff.ToString();
        }
    }
}
