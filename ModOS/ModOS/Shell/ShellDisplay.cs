using System;
using ModOS.Interface;
using ModOS.Shell;

namespace ModOS.Shell {
	public class ShellDisplay : IFeature {
        Information feature;

        public ShellDisplay() {
            feature.Name = "Display Shell";
            feature.Description = "Writes text from the shell to the console.";
            feature.Version = "0.0.1";
		}
        
		public Information GetInformation() {
			return feature;
		}

		public void Initialise() { }

		public void Update() {
			Console.Write(new string(((ShellDefault)Kernel.features[Kernel.currentShell]).GetOutput()));
		}
	}
}
