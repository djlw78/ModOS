using System.Collections.Generic;

namespace ModOS.Extensions {
	public static partial class Extension {
		public static string[] Lex(this string str) {
			bool isinquotes = false;

			List<string> tokens = new List<string> {
                ""
            };

			foreach (char character in str) {
				if (character == '"') {
					isinquotes = !isinquotes;
				} else if (char.IsWhiteSpace(character) && isinquotes == false) {
					tokens.Add("");
				} else {
					tokens[tokens.Count - 1] += character;
				}
			}

			return tokens.ToArray();
		}
	}
}
