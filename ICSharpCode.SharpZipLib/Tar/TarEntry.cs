using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000046 RID: 70
	public class TarEntry
	{
		// Token: 0x06000325 RID: 805 RVA: 0x0000F9E4 File Offset: 0x0000DBE4
		private TarEntry()
		{
			this.header = new global::ICSharpCode.SharpZipLib.Tar.TarHeader();
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000F9F7 File Offset: 0x0000DBF7
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public TarEntry(byte[] headerBuffer) : this(headerBuffer, null)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000FA01 File Offset: 0x0000DC01
		public TarEntry(byte[] headerBuffer, global::System.Text.Encoding nameEncoding)
		{
			this.header = new global::ICSharpCode.SharpZipLib.Tar.TarHeader();
			this.header.ParseBuffer(headerBuffer, nameEncoding);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000FA21 File Offset: 0x0000DC21
		public TarEntry(global::ICSharpCode.SharpZipLib.Tar.TarHeader header)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			this.header = (global::ICSharpCode.SharpZipLib.Tar.TarHeader)header.Clone();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000FA48 File Offset: 0x0000DC48
		public object Clone()
		{
			return new global::ICSharpCode.SharpZipLib.Tar.TarEntry
			{
				file = this.file,
				header = (global::ICSharpCode.SharpZipLib.Tar.TarHeader)this.header.Clone(),
				Name = this.Name
			};
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000FA7D File Offset: 0x0000DC7D
		public static global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateTarEntry(string name)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarEntry tarEntry = new global::ICSharpCode.SharpZipLib.Tar.TarEntry();
			global::ICSharpCode.SharpZipLib.Tar.TarEntry.NameTarHeader(tarEntry.header, name);
			return tarEntry;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000FA90 File Offset: 0x0000DC90
		public static global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarEntry tarEntry = new global::ICSharpCode.SharpZipLib.Tar.TarEntry();
			tarEntry.GetFileTarHeader(tarEntry.header, fileName);
			return tarEntry;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000FAA4 File Offset: 0x0000DCA4
		public override bool Equals(object obj)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarEntry tarEntry = obj as global::ICSharpCode.SharpZipLib.Tar.TarEntry;
			return tarEntry != null && this.Name.Equals(tarEntry.Name);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000FACE File Offset: 0x0000DCCE
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000FADB File Offset: 0x0000DCDB
		public bool IsDescendent(global::ICSharpCode.SharpZipLib.Tar.TarEntry toTest)
		{
			if (toTest == null)
			{
				throw new global::System.ArgumentNullException("toTest");
			}
			return toTest.Name.StartsWith(this.Name, global::System.StringComparison.Ordinal);
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000FAFD File Offset: 0x0000DCFD
		public global::ICSharpCode.SharpZipLib.Tar.TarHeader TarHeader
		{
			get
			{
				return this.header;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000FB05 File Offset: 0x0000DD05
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0000FB12 File Offset: 0x0000DD12
		public string Name
		{
			get
			{
				return this.header.Name;
			}
			set
			{
				this.header.Name = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000FB20 File Offset: 0x0000DD20
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000FB2D File Offset: 0x0000DD2D
		public int UserId
		{
			get
			{
				return this.header.UserId;
			}
			set
			{
				this.header.UserId = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000FB3B File Offset: 0x0000DD3B
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0000FB48 File Offset: 0x0000DD48
		public int GroupId
		{
			get
			{
				return this.header.GroupId;
			}
			set
			{
				this.header.GroupId = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000FB56 File Offset: 0x0000DD56
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000FB63 File Offset: 0x0000DD63
		public string UserName
		{
			get
			{
				return this.header.UserName;
			}
			set
			{
				this.header.UserName = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000FB71 File Offset: 0x0000DD71
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000FB7E File Offset: 0x0000DD7E
		public string GroupName
		{
			get
			{
				return this.header.GroupName;
			}
			set
			{
				this.header.GroupName = value;
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000FB8C File Offset: 0x0000DD8C
		public void SetIds(int userId, int groupId)
		{
			this.UserId = userId;
			this.GroupId = groupId;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		public void SetNames(string userName, string groupName)
		{
			this.UserName = userName;
			this.GroupName = groupName;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000FBAC File Offset: 0x0000DDAC
		// (set) Token: 0x0600033D RID: 829 RVA: 0x0000FBB9 File Offset: 0x0000DDB9
		public global::System.DateTime ModTime
		{
			get
			{
				return this.header.ModTime;
			}
			set
			{
				this.header.ModTime = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000FBC7 File Offset: 0x0000DDC7
		public string File
		{
			get
			{
				return this.file;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000FBCF File Offset: 0x0000DDCF
		// (set) Token: 0x06000340 RID: 832 RVA: 0x0000FBDC File Offset: 0x0000DDDC
		public long Size
		{
			get
			{
				return this.header.Size;
			}
			set
			{
				this.header.Size = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000FBEC File Offset: 0x0000DDEC
		public bool IsDirectory
		{
			get
			{
				if (this.file != null)
				{
					return global::System.IO.Directory.Exists(this.file);
				}
				return this.header != null && (this.header.TypeFlag == 53 || this.Name.EndsWith("/", global::System.StringComparison.Ordinal));
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		public void GetFileTarHeader(global::ICSharpCode.SharpZipLib.Tar.TarHeader header, string file)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			if (file == null)
			{
				throw new global::System.ArgumentNullException("file");
			}
			this.file = file;
			string text = file;
			if (text.IndexOf(global::System.IO.Directory.GetCurrentDirectory(), global::System.StringComparison.Ordinal) == 0)
			{
				text = text.Substring(global::System.IO.Directory.GetCurrentDirectory().Length);
			}
			text = text.Replace(global::System.IO.Path.DirectorySeparatorChar, '/');
			while (text.StartsWith("/", global::System.StringComparison.Ordinal))
			{
				text = text.Substring(1);
			}
			header.LinkName = string.Empty;
			header.Name = text;
			if (global::System.IO.Directory.Exists(file))
			{
				header.Mode = 1003;
				header.TypeFlag = 53;
				if (header.Name.Length == 0 || header.Name[header.Name.Length - 1] != '/')
				{
					header.Name += "/";
				}
				header.Size = 0L;
			}
			else
			{
				header.Mode = 33216;
				header.TypeFlag = 48;
				header.Size = new global::System.IO.FileInfo(file.Replace('/', global::System.IO.Path.DirectorySeparatorChar)).Length;
			}
			header.ModTime = global::System.IO.File.GetLastWriteTime(file.Replace('/', global::System.IO.Path.DirectorySeparatorChar)).ToUniversalTime();
			header.DevMajor = 0;
			header.DevMinor = 0;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000FD88 File Offset: 0x0000DF88
		public global::ICSharpCode.SharpZipLib.Tar.TarEntry[] GetDirectoryEntries()
		{
			if (this.file == null || !global::System.IO.Directory.Exists(this.file))
			{
				return global::ICSharpCode.SharpZipLib.Core.Empty.Array<global::ICSharpCode.SharpZipLib.Tar.TarEntry>();
			}
			string[] fileSystemEntries = global::System.IO.Directory.GetFileSystemEntries(this.file);
			global::ICSharpCode.SharpZipLib.Tar.TarEntry[] array = new global::ICSharpCode.SharpZipLib.Tar.TarEntry[fileSystemEntries.Length];
			for (int i = 0; i < fileSystemEntries.Length; i++)
			{
				array[i] = global::ICSharpCode.SharpZipLib.Tar.TarEntry.CreateEntryFromFile(fileSystemEntries[i]);
			}
			return array;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000FDDF File Offset: 0x0000DFDF
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public void WriteEntryHeader(byte[] outBuffer)
		{
			this.WriteEntryHeader(outBuffer, null);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000FDE9 File Offset: 0x0000DFE9
		public void WriteEntryHeader(byte[] outBuffer, global::System.Text.Encoding nameEncoding)
		{
			this.header.WriteHeader(outBuffer, nameEncoding);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public static void AdjustEntryName(byte[] buffer, string newName)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarEntry.AdjustEntryName(buffer, newName, null);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000FE02 File Offset: 0x0000E002
		public static void AdjustEntryName(byte[] buffer, string newName, global::System.Text.Encoding nameEncoding)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(newName, buffer, 0, 100, nameEncoding);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000FE10 File Offset: 0x0000E010
		public static void NameTarHeader(global::ICSharpCode.SharpZipLib.Tar.TarHeader header, string name)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			bool flag = name.EndsWith("/", global::System.StringComparison.Ordinal);
			header.Name = name;
			header.Mode = (flag ? 1003 : 33216);
			header.UserId = 0;
			header.GroupId = 0;
			header.Size = 0L;
			header.ModTime = global::System.DateTime.UtcNow;
			header.TypeFlag = (flag ? 53 : 48);
			header.LinkName = string.Empty;
			header.UserName = string.Empty;
			header.GroupName = string.Empty;
			header.DevMajor = 0;
			header.DevMinor = 0;
		}

		// Token: 0x040001DF RID: 479
		private string file;

		// Token: 0x040001E0 RID: 480
		private global::ICSharpCode.SharpZipLib.Tar.TarHeader header;
	}
}
