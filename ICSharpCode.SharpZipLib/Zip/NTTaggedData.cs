using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000019 RID: 25
	public class NTTaggedData : global::ICSharpCode.SharpZipLib.Zip.ITaggedData
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00004564 File Offset: 0x00002764
		public short TagID
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004568 File Offset: 0x00002768
		public void SetData(byte[] data, int index, int count)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data, index, count, false))
			{
				using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(memoryStream))
				{
					zipHelperStream.ReadLEInt();
					while (zipHelperStream.Position < zipHelperStream.Length)
					{
						int num = zipHelperStream.ReadLEShort();
						int num2 = zipHelperStream.ReadLEShort();
						if (num == 1)
						{
							if (num2 >= 24)
							{
								long fileTime = zipHelperStream.ReadLELong();
								this._lastModificationTime = global::System.DateTime.FromFileTimeUtc(fileTime);
								long fileTime2 = zipHelperStream.ReadLELong();
								this._lastAccessTime = global::System.DateTime.FromFileTimeUtc(fileTime2);
								long fileTime3 = zipHelperStream.ReadLELong();
								this._createTime = global::System.DateTime.FromFileTimeUtc(fileTime3);
								break;
							}
							break;
						}
						else
						{
							zipHelperStream.Seek((long)num2, global::System.IO.SeekOrigin.Current);
						}
					}
				}
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004630 File Offset: 0x00002830
		public byte[] GetData()
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(memoryStream))
				{
					zipHelperStream.IsStreamOwner = false;
					zipHelperStream.WriteLEInt(0);
					zipHelperStream.WriteLEShort(1);
					zipHelperStream.WriteLEShort(24);
					zipHelperStream.WriteLELong(this._lastModificationTime.ToFileTimeUtc());
					zipHelperStream.WriteLELong(this._lastAccessTime.ToFileTimeUtc());
					zipHelperStream.WriteLELong(this._createTime.ToFileTimeUtc());
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000046D4 File Offset: 0x000028D4
		public static bool IsValidValue(global::System.DateTime value)
		{
			bool result = true;
			try
			{
				value.ToFileTimeUtc();
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00004704 File Offset: 0x00002904
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000470C File Offset: 0x0000290C
		public global::System.DateTime LastModificationTime
		{
			get
			{
				return this._lastModificationTime;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.NTTaggedData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._lastModificationTime = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00004728 File Offset: 0x00002928
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00004730 File Offset: 0x00002930
		public global::System.DateTime CreateTime
		{
			get
			{
				return this._createTime;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.NTTaggedData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._createTime = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000474C File Offset: 0x0000294C
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00004754 File Offset: 0x00002954
		public global::System.DateTime LastAccessTime
		{
			get
			{
				return this._lastAccessTime;
			}
			set
			{
				if (!global::ICSharpCode.SharpZipLib.Zip.NTTaggedData.IsValidValue(value))
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._lastAccessTime = value;
			}
		}

		// Token: 0x040000AE RID: 174
		private global::System.DateTime _lastAccessTime = global::System.DateTime.FromFileTimeUtc(0L);

		// Token: 0x040000AF RID: 175
		private global::System.DateTime _lastModificationTime = global::System.DateTime.FromFileTimeUtc(0L);

		// Token: 0x040000B0 RID: 176
		private global::System.DateTime _createTime = global::System.DateTime.FromFileTimeUtc(0L);
	}
}
