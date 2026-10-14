using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace Gibraltar
{
	// Token: 0x020000B4 RID: 180
	internal static class FileSystemTools
	{
		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
		public static global::System.IFormatProvider UICultureFormat
		{
			get
			{
				global::System.Threading.Thread currentThread = global::System.Threading.Thread.CurrentThread;
				global::System.Globalization.CultureInfo currentUICulture = currentThread.CurrentUICulture;
				if (!currentUICulture.IsNeutralCulture)
				{
					return currentUICulture;
				}
				return currentThread.CurrentCulture;
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0000E308 File Offset: 0x0000C508
		public static string SanitizeDirectoryName(string directoryName)
		{
			return global::Gibraltar.FileSystemTools.SanitizeDirectoryName(directoryName, '_');
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0000E314 File Offset: 0x0000C514
		public static string SanitizeDirectoryName(string directoryName, char replaceChar)
		{
			if (string.IsNullOrEmpty(directoryName))
			{
				throw new global::System.ArgumentNullException(directoryName);
			}
			string text = directoryName;
			foreach (char oldChar in global::System.IO.Path.GetInvalidPathChars())
			{
				text = text.Replace(oldChar, replaceChar);
			}
			return text;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0000E360 File Offset: 0x0000C560
		public static string SanitizeFileName(string fileName)
		{
			return global::Gibraltar.FileSystemTools.SanitizeFileName(fileName, '_');
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0000E36C File Offset: 0x0000C56C
		public static string SanitizeFileName(string fileName, char replaceChar)
		{
			string text = fileName;
			foreach (char oldChar in global::System.IO.Path.GetInvalidFileNameChars())
			{
				text = text.Replace(oldChar, replaceChar);
			}
			return text;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0000E3A4 File Offset: 0x0000C5A4
		public static string MakeFileNamePathUnique(string path)
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(path);
			if (!fileInfo.Exists)
			{
				return path;
			}
			string directoryName = fileInfo.DirectoryName;
			string fileNameWithoutExtension = global::System.IO.Path.GetFileNameWithoutExtension(path);
			string extension = fileInfo.Extension;
			string searchPattern = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}-{1}{2}", new object[]
			{
				fileNameWithoutExtension,
				"*",
				extension
			});
			string[] files = global::System.IO.Directory.GetFiles(directoryName, searchPattern, global::System.IO.SearchOption.TopDirectoryOnly);
			int num = fileNameWithoutExtension.Length + 1;
			int num2 = num + extension.Length + 1;
			int num3 = 0;
			foreach (string text in files)
			{
				int length = text.Length - num2;
				int num4;
				int.TryParse(text.Substring(num, length), out num4);
				if (num4 > num3)
				{
					num3 = num4;
				}
			}
			num3++;
			string path2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}-{1}{2}", new object[]
			{
				fileNameWithoutExtension,
				num3,
				extension
			});
			return global::System.IO.Path.Combine(directoryName, path2);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0000E4AC File Offset: 0x0000C6AC
		public static void EnsurePathExists(string fileNamePath)
		{
			string directoryName = global::System.IO.Path.GetDirectoryName(fileNamePath);
			if (!global::System.IO.Directory.Exists(directoryName))
			{
				global::System.IO.Directory.CreateDirectory(directoryName);
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		public static void MakeFileWriteable(string fileNamePath)
		{
			global::System.IO.FileAttributes attributes = global::System.IO.File.GetAttributes(fileNamePath);
			if ((attributes & global::System.IO.FileAttributes.ReadOnly) == global::System.IO.FileAttributes.ReadOnly)
			{
				global::System.IO.File.SetAttributes(fileNamePath, attributes ^ global::System.IO.FileAttributes.ReadOnly);
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0000E504 File Offset: 0x0000C704
		public static long GetFileSize(string fileNamePath)
		{
			long result = 0L;
			if (global::System.IO.File.Exists(fileNamePath))
			{
				result = new global::System.IO.FileInfo(fileNamePath).Length;
			}
			return result;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0000E530 File Offset: 0x0000C730
		public static global::System.IO.FileStream GetTempFileStream(out string fileName, bool deleteOnClose)
		{
			fileName = global::System.IO.Path.GetTempFileName();
			global::System.IO.FileOptions options = deleteOnClose ? global::System.IO.FileOptions.DeleteOnClose : global::System.IO.FileOptions.None;
			return new global::System.IO.FileStream(fileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.Read, 32768, options);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000E56C File Offset: 0x0000C76C
		public static global::System.IO.FileStream GetTempFileStream()
		{
			string text;
			return global::Gibraltar.FileSystemTools.GetTempFileStream(out text, true);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0000E588 File Offset: 0x0000C788
		public static global::System.IO.FileStream GetTempFileStream(out string fileName)
		{
			return global::Gibraltar.FileSystemTools.GetTempFileStream(out fileName, false);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0000E594 File Offset: 0x0000C794
		public static global::System.IO.FileStream GetTempFileStreamCopy(global::System.IO.Stream contentStream, out string fileName, bool deleteOnClose)
		{
			global::System.IO.FileStream tempFileStream = global::Gibraltar.FileSystemTools.GetTempFileStream(out fileName, deleteOnClose);
			global::Gibraltar.FileSystemTools.StreamContentPump(contentStream, tempFileStream);
			tempFileStream.Position = 0L;
			return tempFileStream;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
		public static global::System.IO.FileStream GetTempFileStreamCopy(global::System.IO.Stream contentStream)
		{
			string text;
			return global::Gibraltar.FileSystemTools.GetTempFileStreamCopy(contentStream, out text, true);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		public static global::System.IO.FileStream GetTempFileStreamCopy(global::System.IO.Stream contentStream, out string fileName)
		{
			return global::Gibraltar.FileSystemTools.GetTempFileStreamCopy(contentStream, out fileName, false);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		public static long StreamContentPump(global::System.IO.Stream sourceStream, global::System.IO.Stream destinationStream)
		{
			byte[] buffer = new byte[32768];
			long num = 0L;
			int num2;
			while ((num2 = sourceStream.Read(buffer, 0, 32768)) > 0)
			{
				destinationStream.Write(buffer, 0, num2);
				num += (long)num2;
			}
			destinationStream.Flush();
			return num;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0000E634 File Offset: 0x0000C834
		public static long StreamContentPump(global::System.IO.Stream sourceStream, global::System.IO.Stream destinationStream, long maxCount)
		{
			if (maxCount <= 0L)
			{
				return 0L;
			}
			byte[] buffer = new byte[32768];
			long num = maxCount - 32768L;
			long num2;
			int num3;
			for (num2 = 0L; num2 <= num; num2 += (long)num3)
			{
				if ((num3 = sourceStream.Read(buffer, 0, 32768)) <= 0)
				{
					break;
				}
				destinationStream.Write(buffer, 0, num3);
			}
			while (num2 < maxCount && (num3 = sourceStream.Read(buffer, 0, (int)(maxCount - num2))) > 0)
			{
				destinationStream.Write(buffer, 0, num3);
				num2 += (long)num3;
			}
			destinationStream.Flush();
			return num2;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		public static long StreamContentCopy(global::System.IO.Stream sourceStream, global::System.IO.Stream destinationStream)
		{
			return global::Gibraltar.FileSystemTools.StreamContentCopy(sourceStream, destinationStream, false);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
		public static long StreamContentCopy(global::System.IO.Stream sourceStream, global::System.IO.Stream destinationStream, bool resetDestinationToOriginalPosition)
		{
			long position = sourceStream.Position;
			long position2 = destinationStream.Position;
			if (sourceStream.CanSeek)
			{
				sourceStream.Position = 0L;
			}
			long result = global::Gibraltar.FileSystemTools.StreamContentPump(sourceStream, destinationStream);
			if (sourceStream.CanSeek)
			{
				sourceStream.Position = position;
			}
			if (resetDestinationToOriginalPosition)
			{
				destinationStream.Position = position2;
			}
			return result;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0000E72C File Offset: 0x0000C92C
		public static void CopyIfNewer(string sourceFileNamePath, string targetFileNamePath)
		{
			if (global::System.IO.File.Exists(targetFileNamePath))
			{
				global::System.DateTime lastWriteTimeUtc = global::System.IO.File.GetLastWriteTimeUtc(sourceFileNamePath);
				if (global::System.IO.File.GetLastWriteTimeUtc(targetFileNamePath) < lastWriteTimeUtc)
				{
					global::System.IO.File.Copy(sourceFileNamePath, targetFileNamePath, true);
					return;
				}
			}
			else
			{
				global::System.IO.File.Copy(sourceFileNamePath, targetFileNamePath);
			}
		}

		// Token: 0x04000177 RID: 375
		private const int DefaultFileBufferSize = 32768;
	}
}
