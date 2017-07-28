using Cosmos.System;

namespace ModOS.Commands {
	public class Reboot : Command {
		public override string id {
			get {
				return "reboot";
			}
		}

		public override void Main(string[] args) {
			Power.Reboot();
		}

        public override void Manual() { }
    }
}
