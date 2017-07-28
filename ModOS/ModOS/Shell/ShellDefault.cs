using System;

using ModOS.Extensions;
using ModOS.Interface;
using ModOS.Commands;
using ModOS.Filesystem;

namespace ModOS.Shell {
	public class ShellDefault : IShell, IFeature {
		IFilesystem filesystem;
		Information feature;

		internal string output;

		public void SetFilesystem(IFilesystem fs) {
			filesystem = fs;
		}

		public ShellDefault() {
			feature.Name = "Default Shell";
			feature.Description = "The default shell for ModOS";
			feature.Version = "0.0.1";
		}

		public IFilesystem GetFilesystem() {
			return filesystem;
		}

		public void Evaluate(string command) {
			try {
				string[] lexed = command.Lex();
				((CommandManager)Kernel.features[Kernel.currentManager]).Evaluate(lexed[0], lexed.RemoveFirst(), this);
				lexed = null;
			} catch(Exception e) {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.ToString());
			}
		}

		public void Display() {
			Evaluate($"echo {Kernel.currentUser}@ModOS: {filesystem.GetCurrentDirectory()} /b");
			string cmd = Console.ReadLine();
			
			Evaluate(cmd);
		}

		public Information GetInformation() {
			return feature;
		}

		public void Update() {
			Display();
		}

		public char[] GetOutput() {
			char[] outp = output.ToCharArray();
			output = "";
			return outp;
		}

		public void Initialise() {
			output = "";
			SetFilesystem((FAT)Kernel.features["FAT"]);
			GetFilesystem().SetCurrentDirectory("0:\\");
		}
	}
}
