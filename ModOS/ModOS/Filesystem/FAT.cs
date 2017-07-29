using System.IO;
using System;

using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using ModOS.Interface;

namespace ModOS.Filesystem {
	public class FAT : IFilesystem, IFeature {
		Information feature;
		public static bool isLoaded = false;

		private static CosmosVFS fs;
		private string currentDir = "0://";

		public void Initialise() {
			if (!isLoaded) {
				isLoaded = true;
				fs = new CosmosVFS();
				VFSManager.RegisterVFS(fs);
			}
		}

		public void Update() { }

		public FAT() {
			Initialise();
			
			feature.Description = "The FAT filesystem.";
			feature.Name = "FAT";
			feature.Version = "0.0.1";
		}

		public string GetCurrentDirectory() {
			return currentDir;
		}

		public bool ValidateDirectory(string dir) {
			return Directory.Exists(dir);
		}

		public void SetCurrentDirectory(string dir) {
			if (ValidateDirectory(currentDir + dir)) {
                currentDir += dir;
				return;
			}
			if (ValidateDirectory(currentDir + "\\" + dir)) {
                currentDir += "\\" + dir;
				return;
			}

			if (ValidateDirectory(dir)) {
                currentDir = dir;
				return;
			}
		}

		public Information GetInformation() {
			return feature;
		}

        public void CreateDirectory(string dir) {
            if(!ValidateDirectory(dir)) {
                Directory.CreateDirectory(currentDir + "/" + dir);
            } else {
                
            }
        }
    }
}
