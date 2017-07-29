using ModOS.System;
using ModOS.Extensions;
using ModOS.Interface;

namespace ModOS.Commands {
    public class Test : Command {
        public override string id {
            get {
                return "test";
            }
        }

        public override void Main(string[] args) {
            string str = args.Join(" ");
            var arr = str.Lex();

            foreach(string s in arr) {
                ((IShell)Kernel.features[Kernel.currentShell]).Evaluate($"echo { s } /b");
            }
        }

        public override void Manual() { }
    }
}
