namespace ModOS.Extensions {
	public static partial class Extension {
		public static T[] RemoveFirst<T>(this T[] item) {
			T[] ret = new T[item.Length > 1 ? item.Length - 1 : 0];

            for (int i = 1; i < item.Length; i++) {
                ret[i - 1] = item[i];
            }

			return ret;
		}
		public static T[] RemoveLast<T>(this T[] item) {
			T[] ret = new T[item.Length > 1 ? item.Length - 1 : 0];

            for (int i = 0; i < item.Length - 1; i++) {
                ret[i] = item[i];
            }

			return ret;
		}
	}
}
