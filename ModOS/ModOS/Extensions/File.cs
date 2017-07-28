namespace ModOS.Extensions {
	public static partial class Extension {
		public static string Up(this string directory) {
			return directory.Split('\\').RemoveLast().Join(@"\");
		}
	}
}
