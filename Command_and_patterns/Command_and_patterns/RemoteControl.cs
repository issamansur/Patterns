using System;
using System.Collections.Generic;
using System.Text;

namespace Command_and_patterns
{
    public class RemoteControl
    {
        public OnOffCommand[] commands;
        public ICommand undoCommand;

        public RemoteControl(OnOffCommand[] commands) {
            this.commands = commands;
        }

        public void OnButtonWasPressed(int slot)
        {
            commands[slot].onCommand.Execute();
            undoCommand = commands[slot].onCommand;
        }

        public void OffButtonWasPressed(int slot)
        {
            commands[slot].offCommand.Execute();
            undoCommand = commands[slot].offCommand;
        }

        public void UndoButtonWasPressed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < commands.Length; i++)
            {
                stringBuff.Append($"[slot {i}] {commands[i].onCommand.GetType().Name} {commands[i].offCommand.GetType().Name}\n");
            }
            return stringBuff.ToString();
        }
    }
}
