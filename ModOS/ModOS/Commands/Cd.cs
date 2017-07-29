using ModOS.Extensions;
using ModOS.System;

namespace ModOS.Commands {
	public class Cd : Command {

        public override string id {
            get {
                return "cd";
            }
        }

		public override void Main(string[] args) {
            string directory = args.Join(" ");

            switch(directory) {
                case "~":
                    currentShell.GetFilesystem().SetCurrentDirectory(Kernel.directoryHome);
                    break;

                case "/":
                    currentShell.GetFilesystem().SetCurrentDirectory(Kernel.directoryRoot);
                    break;

                case "..":
                    currentShell.GetFilesystem().SetCurrentDirectory(currentShell.GetFilesystem().GetCurrentDirectory().Up());
                    break;

                default:
                    currentShell.GetFilesystem().SetCurrentDirectory(directory);
                    break;
            }
		}

        public override void Manual() { }
    }
}
