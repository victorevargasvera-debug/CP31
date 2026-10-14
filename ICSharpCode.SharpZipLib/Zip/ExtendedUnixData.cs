using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000018 RID: 24
	public class ExtendedUnixData : global::ICSharpCode.SharpZipLib.Zip.ITaggedData
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000421C File Offset: 0x0000241C
		public short TagID
		{
			get
			{
				return 21589;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004224 File Offset: 0x00002424
		public void SetData(byte[] data, int index, int count)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data, index, count, false))
			{
				using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(memoryStream))
				{
					this._flags = (global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags)zipHelperStream.ReadByte();
					if ((this._flags & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.ModificationTime) != (global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags)0)
					{
						int seconds = zipHelperStream.ReadLEInt();
						this._modificationTime = new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0, global::System.DateTimeKind.Utc) + new global::System.TimeSpan(0, 0, 0, seconds, 0);
						if (count <= 5)
						{
							return;
						}
					}
					if ((this._flags & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.AccessTime) != (global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags)0)
					{
						int seconds2 = zipHelperStream.ReadLEInt();
						this._lastAccessTime = new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0, global::System.DateTimeKind.Utc) + new global::System.TimeSpan(0, 0, 0, seconds2, 0);
					}
					if ((this._flags & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.CreateTime) != (global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags)0)
					{
						int seconds3 = zipHelperStream.ReadLEInt();
						this._createTime = new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0, global::System.DateTimeKind.Utc) + new global::System.TimeSpan(0, 0, 0, seconds3, 0);
					}
				}
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004334 File Offset: 0x00002534
		public byte[] GetData()
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(memoryStream))
				{
					zipHelperStream.IsStreamOwner = false;
					zipHelperStream.WriteByte((byte)this._flags);
					if ((this._flags & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.ModificationTime) != (global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags)0)
					{
						int value = (int)(this._modificationTime - new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0, global::System.DateTimeKind.Utc)).TotalSeconds;
						zipHelperStream.WriteLEInt(value);
					}
					if ((this._flags & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.AccessTime) != (global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags)0)
					{
						int value2 = (int)(this._lastAccessTime - new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0, global::System.DateTimeKind.Utc)).TotalSeconds;
						zipHelperStream.WriteLEInt(value2);
					}
					if ((this._flags & global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.CreateTime) != (global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags)0)
					{
						int value3 = (int)(this._createTime - new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0, global::System.DateTimeKind.Utc)).TotalSeconds;
						zipHelperStream.WriteLEInt(value3);
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004448 File Offset: 0x00002648
		public static bool IsValidValue(global::System.DateTime value)
		{
			return value >= new global::System.DateTime(1901, 12, 13, 20, 45, 52) || value <= new global::System.DateTime(2038, 1, 19, 3, 14, 7);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000447F File Offset: 0x0000267F
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00004487 File Offset: 0x00002687
		public global::System.DateTime ModificationTime
		{
			get
			{
				return this._modificationTime;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._flags |= global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.ModificationTime;
				this._modificationTime = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000044B1 File Offset: 0x000026B1
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x000044B9 File Offset: 0x000026B9
		public global::System.DateTime AccessTime
		{
			get
			{
				return this._lastAccessTime;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._flags |= global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.AccessTime;
				this._lastAccessTime = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000044E3 File Offset: 0x000026E3
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x000044EB File Offset: 0x000026EB
		public global::System.DateTime CreateTime
		{
			get
			{
				return this._createTime;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._flags |= global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.CreateTime;
				this._createTime = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00004515 File Offset: 0x00002715
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000451D File Offset: 0x0000271D
		public global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags Include
		{
			get
			{
				return this._flags;
			}
			set
			{
				this._flags = value;
			}
		}

		// Token: 0x040000AA RID: 170
		private global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags _flags;

		// Token: 0x040000AB RID: 171
		private global::System.DateTime _modificationTime = new global::System.DateTime(1970, 1, 1);

		// Token: 0x040000AC RID: 172
		private global::System.DateTime _lastAccessTime = new global::System.DateTime(1970, 1, 1);

		// Token: 0x040000AD RID: 173
		private global::System.DateTime _createTime = new global::System.DateTime(1970, 1, 1);

		// Token: 0x0200007F RID: 127
		[global::System.Flags]
		public enum Flags : byte
		{
			// Token: 0x04000339 RID: 825
			ModificationTime = 1,
			// Token: 0x0400033A RID: 826
			AccessTime = 2,
			// Token: 0x0400033B RID: 827
			CreateTime = 4
		}
	}
}
