namespace ModOS.Interface {
	public interface IFilesystem {
		bool ValidateDirectory(string dir);
        void CreateDirectory(string dir);
		void SetCurrentDirectory(string dir);
		string GetCurrentDirectory();
	}
}
