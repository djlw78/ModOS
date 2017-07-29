using ModOS.System;

namespace ModOS.Commands {
	public class Mkdir : Command {
        public override string id {
			get {
				return "mkdir";
			}
		}

		public override void Main(string[] args) {
            var option = args[0];

            if(args.Length > 1) {
                if(option == "" || option == "") {

                }
            } else {
                if(currentShell.GetFilesystem().ValidateDirectory(currentShell.GetFilesystem().GetCurrentDirectory() + args[0])) {
                    currentShell.Evaluate($"echo {currentShell.GetFilesystem().GetCurrentDirectory() } {args[0] } already exists!");
                } else {
                    currentShell.GetFilesystem().CreateDirectory(args[0]);
                    currentShell.GetFilesystem().SetCurrentDirectory(args[0]);
                }
            }
		}

        public override void Manual() { }
    }
}
