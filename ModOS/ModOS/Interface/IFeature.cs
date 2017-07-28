namespace ModOS.Interface {
	public interface IFeature {
        Information GetInformation();
		void Initialise();
		void Update();
	}

	public struct Information {
		public string Name;
		public string Description;
		public string Version;
	}
}
