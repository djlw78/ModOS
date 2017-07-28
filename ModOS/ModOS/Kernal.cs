using Sys = Cosmos.System;

using ModOS.Shell;
using ModOS.Commands;
using ModOS.Filesystem;

namespace ModOS {
	public class Kernel: Sys.Kernel {
		public static Features features = new Features();

		public static string currentShell = "Default Shell";
		public static string currentDisplay = "Display Shell";
		public static string currentManager = "Command Manager";
		public static string currentUser = "root";

        public static string directoryRoot = "0://";
        public static string directoryHome = $"0://users/ { currentUser } /home/";

        public enum Call {
			UpdateDisplay = 0
		}

		public static void Update(byte call) {
			switch (call) {
				case 0:
					features[currentDisplay].Update();
					break;
			}
		}

		protected override void BeforeRun() {
			features.addFeature(new CommandManager());
			features.addFeature(new FAT());
			features.addFeature(new ShellDefault());
			features.addFeature(new ShellDisplay());
		}
        
		protected override void Run() {
			features[currentShell].Update();
		}
	}
}
