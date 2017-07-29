using ModOS.Interface;

namespace ModOS.System {
	public abstract class Command : IFeature, IExecutable {
		internal Information feature;
		internal IShell currentShell;

		public abstract string id { get; }

		public Command() {
			feature.Name = "command";
			feature.Description = "An internal Command";
			feature.Version = "0.0.1";
		}

		public Information GetInformation() {
			return feature;
		}

		public void Initialise() { }

        public abstract void Manual();

		public abstract void Main(string[] args);

		public void SetShell(IShell shell) {
			currentShell = shell;
		}

		public void Update() {
			Main(new string[1]);
		}
	}
}
