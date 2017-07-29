using ModOS.Extensions;
using ModOS.Shell;
using ModOS.System;

namespace ModOS.Commands {
	public class Echo : Command {
		public override string id {
			get {
				return "echo";
			}
		}

		public override void Main(string[] args) {
			string output = args.Join(" ");
			if (output.EndsWith("/b")) {
				output = output.Substring(0, output.Length - 2);
			} else {
				output += "\n";
			}

			((ShellDefault)currentShell).output += output;
			Kernel.Update((byte)Kernel.Call.UpdateDisplay);
		}

        public override void Manual() { }
    }
}
