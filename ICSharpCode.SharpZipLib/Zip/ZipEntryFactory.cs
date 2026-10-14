using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000014 RID: 20
	public class ZipEntryFactory : global::ICSharpCode.SharpZipLib.Zip.IEntryFactory
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00003E23 File Offset: 0x00002023
		public ZipEntryFactory()
		{
			this.nameTransform_ = new global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform();
			this.isUnicodeText_ = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.UseUnicode;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003E53 File Offset: 0x00002053
		public ZipEntryFactory(global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting timeSetting) : this()
		{
			this.timeSetting_ = timeSetting;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003E62 File Offset: 0x00002062
		public ZipEntryFactory(global::System.DateTime time) : this()
		{
			this.timeSetting_ = global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed;
			this.FixedDateTime = time;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003E78 File Offset: 0x00002078
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00003E80 File Offset: 0x00002080
		public global::ICSharpCode.SharpZipLib.Core.INameTransform NameTransform
		{
			get
			{
				return this.nameTransform_;
			}
			set
			{
				if (value == null)
				{
					this.nameTransform_ = new global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform();
					return;
				}
				this.nameTransform_ = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003E98 File Offset: 0x00002098
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00003EA0 File Offset: 0x000020A0
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting Setting
		{
			get
			{
				return this.timeSetting_;
			}
			set
			{
				this.timeSetting_ = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003EA9 File Offset: 0x000020A9
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00003EB1 File Offset: 0x000020B1
		public global::System.DateTime FixedDateTime
		{
			get
			{
				return this.fixedDateTime_;
			}
			set
			{
				if (value.Year < 1970)
				{
					throw new global::System.ArgumentException("Value is too old to be valid", "value");
				}
				this.fixedDateTime_ = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003ED8 File Offset: 0x000020D8
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00003EE0 File Offset: 0x000020E0
		public int GetAttributes
		{
			get
			{
				return this.getAttributes_;
			}
			set
			{
				this.getAttributes_ = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00003EE9 File Offset: 0x000020E9
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00003EF1 File Offset: 0x000020F1
		public int SetAttributes
		{
			get
			{
				return this.setAttributes_;
			}
			set
			{
				this.setAttributes_ = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00003EFA File Offset: 0x000020FA
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00003F02 File Offset: 0x00002102
		public bool IsUnicodeText
		{
			get
			{
				return this.isUnicodeText_;
			}
			set
			{
				this.isUnicodeText_ = value;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003F0B File Offset: 0x0000210B
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName)
		{
			return this.MakeFileEntry(fileName, null, true);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003F16 File Offset: 0x00002116
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName, bool useFileSystem)
		{
			return this.MakeFileEntry(fileName, null, useFileSystem);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003F24 File Offset: 0x00002124
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeFileEntry(string fileName, string entryName, bool useFileSystem)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(this.nameTransform_.TransformFile((!string.IsNullOrEmpty(entryName)) ? entryName : fileName));
			zipEntry.IsUnicodeText = this.isUnicodeText_;
			int num = 0;
			bool flag = this.setAttributes_ != 0;
			global::System.IO.FileInfo fileInfo = null;
			if (useFileSystem)
			{
				fileInfo = new global::System.IO.FileInfo(fileName);
			}
			if (fileInfo != null && fileInfo.Exists)
			{
				switch (this.timeSetting_)
				{
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTime:
					zipEntry.DateTime = fileInfo.LastWriteTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTimeUtc:
					zipEntry.DateTime = fileInfo.LastWriteTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTime:
					zipEntry.DateTime = fileInfo.CreationTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTimeUtc:
					zipEntry.DateTime = fileInfo.CreationTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTime:
					zipEntry.DateTime = fileInfo.LastAccessTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTimeUtc:
					zipEntry.DateTime = fileInfo.LastAccessTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed:
					zipEntry.DateTime = this.fixedDateTime_;
					break;
				default:
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unhandled time setting in MakeFileEntry");
				}
				zipEntry.Size = fileInfo.Length;
				flag = true;
				num = (int)(fileInfo.Attributes & (global::System.IO.FileAttributes)this.getAttributes_);
			}
			else if (this.timeSetting_ == global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed)
			{
				zipEntry.DateTime = this.fixedDateTime_;
			}
			if (flag)
			{
				num |= this.setAttributes_;
				zipEntry.ExternalFileAttributes = num;
			}
			return zipEntry;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004064 File Offset: 0x00002264
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName)
		{
			return this.MakeDirectoryEntry(directoryName, true);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004070 File Offset: 0x00002270
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(this.nameTransform_.TransformDirectory(directoryName));
			zipEntry.IsUnicodeText = this.isUnicodeText_;
			zipEntry.Size = 0L;
			int num = 0;
			global::System.IO.DirectoryInfo directoryInfo = null;
			if (useFileSystem)
			{
				directoryInfo = new global::System.IO.DirectoryInfo(directoryName);
			}
			if (directoryInfo != null && directoryInfo.Exists)
			{
				switch (this.timeSetting_)
				{
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTime:
					zipEntry.DateTime = directoryInfo.LastWriteTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTimeUtc:
					zipEntry.DateTime = directoryInfo.LastWriteTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTime:
					zipEntry.DateTime = directoryInfo.CreationTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTimeUtc:
					zipEntry.DateTime = directoryInfo.CreationTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTime:
					zipEntry.DateTime = directoryInfo.LastAccessTime;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTimeUtc:
					zipEntry.DateTime = directoryInfo.LastAccessTimeUtc;
					break;
				case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed:
					zipEntry.DateTime = this.fixedDateTime_;
					break;
				default:
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unhandled time setting in MakeDirectoryEntry");
				}
				num = (int)(directoryInfo.Attributes & (global::System.IO.FileAttributes)this.getAttributes_);
			}
			else if (this.timeSetting_ == global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed)
			{
				zipEntry.DateTime = this.fixedDateTime_;
			}
			num |= (this.setAttributes_ | 16);
			zipEntry.ExternalFileAttributes = num;
			return zipEntry;
		}

		// Token: 0x040000A2 RID: 162
		private global::ICSharpCode.SharpZipLib.Core.INameTransform nameTransform_;

		// Token: 0x040000A3 RID: 163
		private global::System.DateTime fixedDateTime_ = global::System.DateTime.Now;

		// Token: 0x040000A4 RID: 164
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting timeSetting_;

		// Token: 0x040000A5 RID: 165
		private bool isUnicodeText_;

		// Token: 0x040000A6 RID: 166
		private int getAttributes_ = -1;

		// Token: 0x040000A7 RID: 167
		private int setAttributes_;

		// Token: 0x0200007E RID: 126
		public enum TimeSetting
		{
			// Token: 0x04000331 RID: 817
			LastWriteTime,
			// Token: 0x04000332 RID: 818
			LastWriteTimeUtc,
			// Token: 0x04000333 RID: 819
			CreateTime,
			// Token: 0x04000334 RID: 820
			CreateTimeUtc,
			// Token: 0x04000335 RID: 821
			LastAccessTime,
			// Token: 0x04000336 RID: 822
			LastAccessTimeUtc,
			// Token: 0x04000337 RID: 823
			Fixed
		}
	}
}
