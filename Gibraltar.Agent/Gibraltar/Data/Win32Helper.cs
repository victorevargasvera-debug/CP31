using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Gibraltar.Data
{
	// Token: 0x020000E4 RID: 228
	internal static class Win32Helper
	{
		// Token: 0x06000970 RID: 2416
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		internal static extern global::Microsoft.Win32.SafeHandles.SafeFileHandle CreateFile(string fileName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U4)] global::System.IO.FileAccess fileAccess, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U4)] global::System.IO.FileShare fileShare, global::System.IntPtr securityAttributes, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U4)] global::System.IO.FileMode creationDisposition, uint flags, global::System.IntPtr template);

		// Token: 0x06000971 RID: 2417
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern bool DeleteFile(string path);

		// Token: 0x06000972 RID: 2418 RVA: 0x000169D8 File Offset: 0x00014BD8
		public static global::System.IO.FileStream OpenFileStream(string fileName, global::System.IO.FileMode creationMode, global::System.IO.FileAccess fileAccess, global::System.IO.FileShare fileShare)
		{
			global::System.IO.FileStream result = null;
			if (global::Gibraltar.CommonCentralLogic.IsMonoRuntime)
			{
				try
				{
					return new global::System.IO.FileStream(fileName, creationMode, fileAccess, fileShare);
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
					return null;
				}
			}
			global::Microsoft.Win32.SafeHandles.SafeFileHandle safeFileHandle = global::Gibraltar.Data.Win32Helper.CreateFile(fileName, fileAccess, fileShare, global::System.IntPtr.Zero, creationMode, 0U, global::System.IntPtr.Zero);
			if (safeFileHandle != null && !safeFileHandle.IsInvalid && !safeFileHandle.IsClosed)
			{
				try
				{
					result = new global::System.IO.FileStream(safeFileHandle, fileAccess);
				}
				catch (global::System.Exception obj2)
				{
					global::System.GC.KeepAlive(obj2);
					safeFileHandle.Dispose();
				}
			}
			return result;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00016A78 File Offset: 0x00014C78
		public static bool SafeDeleteFile(string fileName)
		{
			if (global::Gibraltar.CommonCentralLogic.IsMonoRuntime)
			{
				bool result = false;
				try
				{
					global::System.IO.File.Delete(fileName);
					result = true;
				}
				catch (global::System.Exception)
				{
				}
				return result;
			}
			return global::Gibraltar.Data.Win32Helper.DeleteFile(fileName);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00016ABC File Offset: 0x00014CBC
		public static global::Gibraltar.Data.FileLock GetFileLock(string fileName, global::System.IO.FileMode creationMode, global::System.IO.FileAccess fileAccess, global::System.IO.FileShare fileShare)
		{
			global::Gibraltar.Data.FileLock result = null;
			if (global::Gibraltar.CommonCentralLogic.IsMonoRuntime)
			{
				global::System.IO.FileStream fileStream;
				try
				{
					fileStream = new global::System.IO.FileStream(fileName, creationMode, fileAccess, fileShare);
				}
				catch
				{
					fileStream = null;
				}
				if (fileStream != null)
				{
					result = new global::Gibraltar.Data.FileLock(fileStream, fileName, creationMode, fileAccess, fileShare, false);
				}
			}
			else
			{
				global::Microsoft.Win32.SafeHandles.SafeFileHandle safeFileHandle = global::Gibraltar.Data.Win32Helper.CreateFile(fileName, fileAccess, fileShare, global::System.IntPtr.Zero, creationMode, 0U, global::System.IntPtr.Zero);
				if (safeFileHandle != null && (safeFileHandle.IsInvalid || safeFileHandle.IsClosed))
				{
					safeFileHandle.Dispose();
					safeFileHandle = null;
				}
				if (safeFileHandle != null)
				{
					result = new global::Gibraltar.Data.FileLock(safeFileHandle, fileName, creationMode, fileAccess, fileShare, false);
				}
			}
			return result;
		}
	}
}
