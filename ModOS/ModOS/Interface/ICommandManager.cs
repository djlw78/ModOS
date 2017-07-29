using ModOS.System;

namespace ModOS.Interface {
    public interface ICommandManager {
        void Evaluate(string cmd, string[] args, IShell currentShell);
        void AddCommand(Command command);
    }
}
