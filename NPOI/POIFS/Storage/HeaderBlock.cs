using System;
using System.IO;
using NPOI.HSSF;
using NPOI.POIFS.Common;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002A1 RID: 673
	public class HeaderBlock : global::NPOI.POIFS.Storage.HeaderBlockConstants
	{
		// Token: 0x06001265 RID: 4709 RVA: 0x00037254 File Offset: 0x00035454
		public HeaderBlock(global::System.IO.Stream stream)
		{
			try
			{
				stream.Position = 0L;
				this.PrivateHeaderBlock(global::NPOI.POIFS.Storage.HeaderBlock.ReadFirst512(stream));
				if (this.bigBlockSize.GetBigBlockSize() != 512)
				{
					byte[] b = new byte[this.bigBlockSize.GetBigBlockSize() - 512];
					global::NPOI.Util.IOUtils.ReadFully(stream, b);
				}
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000372C0 File Offset: 0x000354C0
		public HeaderBlock(global::NPOI.Util.ByteBuffer buffer) : this(global::NPOI.Util.IOUtils.ToByteArray(buffer, 512))
		{
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000372D4 File Offset: 0x000354D4
		public HeaderBlock(byte[] buffer)
		{
			try
			{
				this.PrivateHeaderBlock(buffer);
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00037304 File Offset: 0x00035504
		public void PrivateHeaderBlock(byte[] data)
		{
			this._data = data;
			long @long = global::NPOI.Util.LittleEndian.GetLong(this._data, 0);
			if (@long == -2226271756974174256L)
			{
				if (this._data[30] == 12)
				{
					this.bigBlockSize = global::NPOI.POIFS.Common.POIFSConstants.LARGER_BIG_BLOCK_SIZE_DETAILS;
				}
				else
				{
					if (this._data[30] != 9)
					{
						throw new global::System.IO.IOException("Unsupported blocksize  (2^" + this._data[30].ToString() + "). Expected 2^9 or 2^12.");
					}
					this.bigBlockSize = global::NPOI.POIFS.Common.POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS;
				}
				this._bat_count = new global::NPOI.Util.IntegerField(44, this._data).Value;
				this._property_start = new global::NPOI.Util.IntegerField(48, this._data).Value;
				this._sbat_start = new global::NPOI.Util.IntegerField(60, this._data).Value;
				this._sbat_count = new global::NPOI.Util.IntegerField(64, this._data).Value;
				this._xbat_start = new global::NPOI.Util.IntegerField(68, this._data).Value;
				this._xbat_count = new global::NPOI.Util.IntegerField(72, this._data).Value;
				return;
			}
			if (global::NPOI.POIFS.Storage.HeaderBlock.cmp(global::NPOI.POIFS.Common.POIFSConstants.OOXML_FILE_HEADER, data))
			{
				throw new global::NPOI.POIFS.FileSystem.OfficeXmlFileException("The supplied data appears to be in the Office 2007+ XML. You are calling the part of POI that deals with OLE2 Office Documents. You need to call a different part of POI to process this data (eg XSSF instead of HSSF)");
			}
			if (global::NPOI.POIFS.Storage.HeaderBlock.cmp(global::NPOI.POIFS.Common.POIFSConstants.RAW_XML_FILE_HEADER, data))
			{
				throw new global::NPOI.POIFS.FileSystem.NotOLE2FileException("The supplied data appears to be a raw XML file. Formats such as Office 2003 XML are not supported");
			}
			if (global::NPOI.POIFS.Storage.HeaderBlock.cmp(global::NPOI.POIFS.Storage.HeaderBlock.MAGIC_BIFF2, data))
			{
				throw new global::NPOI.HSSF.OldExcelFormatException("The supplied data appears to be in BIFF2 format. HSSF only supports the BIFF8 format, try OldExcelExtractor");
			}
			if (global::NPOI.POIFS.Storage.HeaderBlock.cmp(global::NPOI.POIFS.Storage.HeaderBlock.MAGIC_BIFF3, data))
			{
				throw new global::NPOI.HSSF.OldExcelFormatException("The supplied data appears to be in BIFF3 format. HSSF only supports the BIFF8 format, try OldExcelExtractor");
			}
			if (global::NPOI.POIFS.Storage.HeaderBlock.cmp(global::NPOI.POIFS.Storage.HeaderBlock.MAGIC_BIFF4a, data) || global::NPOI.POIFS.Storage.HeaderBlock.cmp(global::NPOI.POIFS.Storage.HeaderBlock.MAGIC_BIFF4b, data))
			{
				throw new global::NPOI.HSSF.OldExcelFormatException("The supplied data appears to be in BIFF4 format. HSSF only supports the BIFF8 format, try OldExcelExtractor");
			}
			throw new global::NPOI.POIFS.FileSystem.NotOLE2FileException(string.Concat(new string[]
			{
				"Invalid header signature; read ",
				new string(global::NPOI.Util.HexDump.LongToHex(@long)),
				", expected ",
				new string(global::NPOI.Util.HexDump.LongToHex(-2226271756974174256L)),
				" - Your file appears not to be a valid OLE2 document"
			}));
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x000374F4 File Offset: 0x000356F4
		public HeaderBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize)
		{
			this.bigBlockSize = bigBlockSize;
			this._data = new byte[512];
			for (int i = 0; i < this._data.Length; i++)
			{
				this._data[i] = global::NPOI.POIFS.Storage.HeaderBlock._default_value;
			}
			new global::NPOI.Util.LongField(0, -2226271756974174256L, this._data);
			new global::NPOI.Util.IntegerField(8, 0, this._data);
			new global::NPOI.Util.IntegerField(12, 0, this._data);
			new global::NPOI.Util.IntegerField(16, 0, this._data);
			new global::NPOI.Util.IntegerField(20, 0, this._data);
			new global::NPOI.Util.ShortField(24, 59, ref this._data);
			new global::NPOI.Util.ShortField(26, 3, ref this._data);
			new global::NPOI.Util.ShortField(28, -2, ref this._data);
			new global::NPOI.Util.ShortField(30, bigBlockSize.GetHeaderValue(), ref this._data);
			new global::NPOI.Util.IntegerField(32, 6, this._data);
			new global::NPOI.Util.IntegerField(36, 0, this._data);
			new global::NPOI.Util.IntegerField(40, 0, this._data);
			new global::NPOI.Util.IntegerField(52, 0, this._data);
			new global::NPOI.Util.IntegerField(56, 4096, this._data);
			this._bat_count = 0;
			this._sbat_count = 0;
			this._xbat_count = 0;
			this._property_start = -2;
			this._sbat_start = -2;
			this._xbat_start = -2;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00037650 File Offset: 0x00035850
		private static byte[] ReadFirst512(global::System.IO.Stream stream)
		{
			byte[] array = new byte[512];
			int num = global::NPOI.Util.IOUtils.ReadFully(stream, array);
			if (num != 512)
			{
				global::NPOI.POIFS.Storage.HeaderBlock.AlertShortRead(num, 512);
			}
			return array;
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00037688 File Offset: 0x00035888
		private static global::System.IO.IOException AlertShortRead(int read, int expectedReadSize)
		{
			if (read < 0)
			{
				read = 0;
			}
			string text = " byte" + ((read == 1) ? "" : "s");
			return new global::System.IO.IOException(string.Concat(new string[]
			{
				"Unable to Read entire header; ",
				read.ToString(),
				text,
				" Read; expected ",
				expectedReadSize.ToString(),
				" bytes"
			}));
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x000376F7 File Offset: 0x000358F7
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x000376FF File Offset: 0x000358FF
		public int PropertyStart
		{
			get
			{
				return this._property_start;
			}
			set
			{
				this._property_start = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x00037708 File Offset: 0x00035908
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x00037710 File Offset: 0x00035910
		public int SBATStart
		{
			get
			{
				return this._sbat_start;
			}
			set
			{
				this._sbat_start = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x00037719 File Offset: 0x00035919
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x00037721 File Offset: 0x00035921
		public int SBATCount
		{
			get
			{
				return this._sbat_count;
			}
			set
			{
				this._sbat_count = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x00037719 File Offset: 0x00035919
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x00037721 File Offset: 0x00035921
		public int SBATBlockCount
		{
			get
			{
				return this._sbat_count;
			}
			set
			{
				this._sbat_count = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x0003772A File Offset: 0x0003592A
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x00037732 File Offset: 0x00035932
		public int BATCount
		{
			get
			{
				return this._bat_count;
			}
			set
			{
				this._bat_count = value;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x0003773C File Offset: 0x0003593C
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x00037784 File Offset: 0x00035984
		public int[] BATArray
		{
			get
			{
				int[] array = new int[global::System.Math.Min(this._bat_count, 109)];
				int num = 76;
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = global::NPOI.Util.LittleEndian.GetInt(this._data, num);
					num += 4;
				}
				return array;
			}
			set
			{
				int num = global::System.Math.Min(value.Length, 109);
				int num2 = 109 - num;
				int num3 = 76;
				for (int i = 0; i < num; i++)
				{
					global::NPOI.Util.LittleEndian.PutInt(this._data, num3, value[i]);
					num3 += 4;
				}
				for (int j = 0; j < num2; j++)
				{
					global::NPOI.Util.LittleEndian.PutInt(this._data, num3, -1);
					num3 += 4;
				}
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x000377E4 File Offset: 0x000359E4
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x000377EC File Offset: 0x000359EC
		public int XBATCount
		{
			get
			{
				return this._xbat_count;
			}
			set
			{
				this._xbat_count = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x000377F5 File Offset: 0x000359F5
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x000377EC File Offset: 0x000359EC
		public int XBATIndex
		{
			get
			{
				return this._xbat_start;
			}
			set
			{
				this._xbat_count = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x000377FD File Offset: 0x000359FD
		public int XBATStart
		{
			set
			{
				this._xbat_start = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x00037806 File Offset: 0x00035A06
		public global::NPOI.POIFS.Common.POIFSBigBlockSize BigBlockSize
		{
			get
			{
				return this.bigBlockSize;
			}
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00037810 File Offset: 0x00035A10
		public void WriteData(global::System.IO.Stream stream)
		{
			try
			{
				new global::NPOI.Util.IntegerField(44, this._bat_count, this._data);
				new global::NPOI.Util.IntegerField(48, this._property_start, this._data);
				new global::NPOI.Util.IntegerField(60, this._sbat_start, this._data);
				new global::NPOI.Util.IntegerField(64, this._sbat_count, this._data);
				new global::NPOI.Util.IntegerField(68, this._xbat_start, this._data);
				new global::NPOI.Util.IntegerField(72, this._xbat_count, this._data);
				stream.Write(this._data, 0, 512);
				for (int i = 512; i < this.bigBlockSize.GetBigBlockSize(); i++)
				{
					stream.WriteByte(0);
				}
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000378DC File Offset: 0x00035ADC
		private static bool cmp(byte[] magic, byte[] data)
		{
			int num = 0;
			foreach (byte b in magic)
			{
				byte b2 = data[num++];
				if (b2 != b && (b != 112 || (b2 != 16 && b2 != 32 && b2 != 64)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040007A2 RID: 1954
		private static byte[] MAGIC_BIFF2 = new byte[]
		{
			9,
			0,
			4,
			0,
			0,
			0,
			112,
			0
		};

		// Token: 0x040007A3 RID: 1955
		private static byte[] MAGIC_BIFF3 = new byte[]
		{
			9,
			2,
			6,
			0,
			0,
			0,
			112,
			0
		};

		// Token: 0x040007A4 RID: 1956
		private static byte[] MAGIC_BIFF4a = new byte[]
		{
			9,
			4,
			6,
			0,
			0,
			0,
			112,
			0
		};

		// Token: 0x040007A5 RID: 1957
		private static byte[] MAGIC_BIFF4b = new byte[]
		{
			9,
			4,
			6,
			0,
			0,
			0,
			0,
			1
		};

		// Token: 0x040007A6 RID: 1958
		private static byte _default_value = byte.MaxValue;

		// Token: 0x040007A7 RID: 1959
		private global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize;

		// Token: 0x040007A8 RID: 1960
		private int _bat_count;

		// Token: 0x040007A9 RID: 1961
		private int _property_start;

		// Token: 0x040007AA RID: 1962
		private int _sbat_start;

		// Token: 0x040007AB RID: 1963
		private int _sbat_count;

		// Token: 0x040007AC RID: 1964
		private int _xbat_start;

		// Token: 0x040007AD RID: 1965
		private int _xbat_count;

		// Token: 0x040007AE RID: 1966
		private byte[] _data;
	}
}
