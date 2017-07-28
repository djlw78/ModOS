namespace ModOS.Interface {
	public interface IShell {
		void Display();
		IFilesystem GetFilesystem();
		void SetFilesystem(IFilesystem fs);
		void Evaluate(string command);
		char[] GetOutput();
	}
}
