using System;
using System.Collections.Generic;

using ModOS.Commands;
using ModOS.Interface;

namespace ModOS.System {
	public class CommandManager : IFeature, ICommandManager {
		Information feature;
		public List<Command> commands;

		public CommandManager() {
			feature.Name = "Command Manager";
			feature.Description = "Manages the commands";
			feature.Version = "0.0.1";

			commands = new List<Command>();
		}

		public void Initialise() {
			AddCommand(new Reboot());
            AddCommand(new Echo());
            AddCommand(new Mkdir());
            AddCommand(new Cd());
            AddCommand(new Test());
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

        public void AddCommand(Command command) {
            commands.Add(command);
        }
    }
}
