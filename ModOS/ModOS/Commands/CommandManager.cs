using System.Collections.Generic;

using ModOS.Interface;

namespace ModOS.Commands {
	class CommandManager : IFeature {
		Information feature;
		public List<Command> commands;

		public CommandManager() {
			feature.Name = "Command Manager";
			feature.Description = "Manages the commands";
			feature.Version = "0.0.1";

			commands = new List<Command>();
		}

		public void Initialise() {
			commands.Add(new Reboot());
			commands.Add(new Echo());
			commands.Add(new Mkdir());
            commands.Add(new Cd());
        }

		public void Evaluate(string cmd, string[] args, IShell currentShell) {
			foreach (Command c in commands) {
				if (c.id.ToLower() == cmd.ToLower()) {
					c.SetShell(currentShell);
					c.Main(args);
					break;
				}
			}
		}

		public Information GetInformation() {
			return feature;
		}

		public void Update() { }
	}
}
