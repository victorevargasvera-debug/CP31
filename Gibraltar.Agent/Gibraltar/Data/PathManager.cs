using System;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Gibraltar.Data
{
	// Token: 0x020000E2 RID: 226
	internal static class PathManager
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x00016634 File Offset: 0x00014834
		public static string FindBestPath(global::Gibraltar.Data.PathType pathType)
		{
			return global::Gibraltar.Data.PathManager.FindBestPath(pathType, null);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00016640 File Offset: 0x00014840
		public static string FindBestPath(global::Gibraltar.Data.PathType pathType, string preferredPath)
		{
			string text = null;
			if (!string.IsNullOrEmpty(preferredPath))
			{
				text = preferredPath;
				if (!global::Gibraltar.Data.PathManager.PathIsUsable(text))
				{
					text = null;
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				string folderName = global::Gibraltar.Data.PathManager.PathTypeToFolderName(pathType);
				if (pathType != global::Gibraltar.Data.PathType.Repository && pathType != global::Gibraltar.Data.PathType.ServerRepository)
				{
					text = global::Gibraltar.Data.PathManager.CreatePath(global::System.Environment.SpecialFolder.CommonApplicationData, folderName);
				}
				if (string.IsNullOrEmpty(text))
				{
					if (pathType != global::Gibraltar.Data.PathType.Licensing)
					{
						text = global::Gibraltar.Data.PathManager.CreatePath(global::System.Environment.SpecialFolder.LocalApplicationData, folderName);
					}
				}
				else if (pathType == global::Gibraltar.Data.PathType.Licensing)
				{
					try
					{
						global::System.IO.FileAttributes fileAttributes = global::System.IO.File.GetAttributes(text);
						if ((fileAttributes & global::System.IO.FileAttributes.Hidden) == (global::System.IO.FileAttributes)0)
						{
							fileAttributes |= global::System.IO.FileAttributes.Hidden;
							global::System.IO.File.SetAttributes(text, fileAttributes);
						}
					}
					catch (global::System.Exception obj)
					{
						global::System.GC.KeepAlive(obj);
					}
				}
			}
			return text;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000166F4 File Offset: 0x000148F4
		public static string FindFilePath(global::Gibraltar.Data.PathType pathType, string preferredPath, string fileName)
		{
			string text = null;
			if (!string.IsNullOrEmpty(preferredPath))
			{
				text = global::System.IO.Path.Combine(preferredPath, fileName);
				if (!global::System.IO.File.Exists(text))
				{
					text = null;
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				string folderName = global::Gibraltar.Data.PathManager.PathTypeToFolderName(pathType);
				if (pathType != global::Gibraltar.Data.PathType.Repository && pathType != global::Gibraltar.Data.PathType.ServerRepository)
				{
					text = global::Gibraltar.Data.PathManager.ComputePath(global::System.Environment.SpecialFolder.CommonApplicationData, folderName);
					text = global::System.IO.Path.Combine(text, fileName);
					if (!global::System.IO.File.Exists(text))
					{
						text = null;
					}
				}
				if (string.IsNullOrEmpty(text) && pathType != global::Gibraltar.Data.PathType.Licensing)
				{
					text = global::Gibraltar.Data.PathManager.ComputePath(global::System.Environment.SpecialFolder.LocalApplicationData, folderName);
					text = global::System.IO.Path.Combine(text, fileName);
					if (!global::System.IO.File.Exists(text))
					{
						text = null;
					}
				}
			}
			return text;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00016798 File Offset: 0x00014998
		public static string CreatePath(global::System.Environment.SpecialFolder specialFolder, string folderName)
		{
			string text = global::Gibraltar.Data.PathManager.ComputePath(specialFolder, folderName);
			if (!global::Gibraltar.Data.PathManager.PathIsUsable(text))
			{
				text = null;
			}
			return text;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000167C0 File Offset: 0x000149C0
		public static string ComputePath(global::System.Environment.SpecialFolder specialFolder, string folderName)
		{
			return global::System.IO.Path.Combine(global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(specialFolder), "Gibraltar"), folderName);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000167D8 File Offset: 0x000149D8
		public static bool PathIsUsable(string path)
		{
			bool result = true;
			string path2 = global::System.IO.Path.Combine(path, global::System.Guid.NewGuid().ToString() + ".txt");
			try
			{
				if (!global::System.IO.Directory.Exists(path))
				{
					global::System.IO.DirectoryInfo directoryInfo = global::System.IO.Directory.CreateDirectory(path);
					if (!global::Gibraltar.CommonCentralLogic.IsMonoRuntime)
					{
						try
						{
							global::System.Security.AccessControl.DirectorySecurity accessControl = directoryInfo.GetAccessControl();
							global::System.Security.Principal.SecurityIdentifier identity = new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.BuiltinUsersSid, null);
							accessControl.AddAccessRule(new global::System.Security.AccessControl.FileSystemAccessRule(identity, global::System.Security.AccessControl.FileSystemRights.Modify, global::System.Security.AccessControl.InheritanceFlags.ContainerInherit | global::System.Security.AccessControl.InheritanceFlags.ObjectInherit, global::System.Security.AccessControl.PropagationFlags.None, global::System.Security.AccessControl.AccessControlType.Allow));
							directoryInfo.SetAccessControl(accessControl);
						}
						catch (global::System.Exception ex)
						{
							if (!global::Gibraltar.CommonCentralLogic.SilentMode)
							{
								global::System.Diagnostics.Trace.TraceWarning("Unable to set proper permissions on new directory\r\nAn attempt to set necessary all-users write permission on a new folder failed.\r\nIf the directory does not already have sufficient permission then it may cause failures, and an administrator may have to adjust the permissions on the folder to fix it.\r\nPath: {0}\r\nException: {1} {2}", new object[]
								{
									path,
									ex,
									ex.Message
								});
							}
						}
					}
				}
				using (global::System.IO.StreamWriter streamWriter = global::System.IO.File.CreateText(path2))
				{
					streamWriter.WriteLine("This is a test file created by Loupe to verify that the directory is writable.");
					streamWriter.Flush();
				}
				using (global::System.IO.StreamReader streamReader = global::System.IO.File.OpenText(path2))
				{
					streamReader.ReadToEnd();
				}
			}
			catch
			{
				result = false;
			}
			try
			{
				global::System.IO.File.Delete(path2);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00016944 File Offset: 0x00014B44
		private static string PathTypeToFolderName(global::Gibraltar.Data.PathType pathType)
		{
			string result;
			switch (pathType)
			{
			case global::Gibraltar.Data.PathType.Collection:
				result = "Local Logs";
				break;
			case global::Gibraltar.Data.PathType.Repository:
				result = "Repository";
				break;
			case global::Gibraltar.Data.PathType.Licensing:
				result = "Licensing";
				break;
			case global::Gibraltar.Data.PathType.Configuration:
				result = "Configuration";
				break;
			case global::Gibraltar.Data.PathType.Extensions:
				result = "Extensions";
				break;
			case global::Gibraltar.Data.PathType.Discovery:
				result = "Discovery";
				break;
			case global::Gibraltar.Data.PathType.ServerRepository:
				result = "Server Repositories";
				break;
			default:
				throw new global::System.IO.InvalidDataException("The current path type is unknown, indicating a programming error.");
			}
			return result;
		}

		// Token: 0x0400023D RID: 573
		public const string RepositoryFolder = "Repository";

		// Token: 0x0400023E RID: 574
		public const string ServerRepositoryFolder = "Server Repositories";

		// Token: 0x0400023F RID: 575
		public const string CollectionFolder = "Local Logs";

		// Token: 0x04000240 RID: 576
		public const string LicensingFolder = "Licensing";

		// Token: 0x04000241 RID: 577
		public const string ConfigurationFolder = "Configuration";

		// Token: 0x04000242 RID: 578
		public const string ExtensionsFolder = "Extensions";

		// Token: 0x04000243 RID: 579
		public const string DiscoveryFolder = "Discovery";
	}
}
