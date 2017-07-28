﻿namespace ModOS.Interface {
	public interface IExecutable {
		void Main(string[] args);
		void SetShell(IShell shell);
	}
}
