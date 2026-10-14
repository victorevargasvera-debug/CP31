using System;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002AD RID: 685
	public class HeaderBlockReader
	{
		// Token: 0x060012E4 RID: 4836 RVA: 0x00038CBC File Offset: 0x00036EBC
		public HeaderBlockReader(global::System.IO.Stream stream)
		{
			stream.Position = 0L;
			this._data = this.ReadFirst512(stream);
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
				if (this.bigBlockSize.GetBigBlockSize() != 512)
				{
					byte[] b = new byte[this.bigBlockSize.GetBigBlockSize() - 512];
					global::NPOI.Util.IOUtils.ReadFully(stream, b);
				}
				return;
			}
			byte[] ooxml_FILE_HEADER = global::NPOI.POIFS.Common.POIFSConstants.OOXML_FILE_HEADER;
			if (this._data[0] == ooxml_FILE_HEADER[0] && this._data[1] == ooxml_FILE_HEADER[1] && this._data[2] == ooxml_FILE_HEADER[2] && this._data[3] == ooxml_FILE_HEADER[3])
			{
				throw new global::NPOI.POIFS.FileSystem.OfficeXmlFileException("The supplied data appears to be in the Office 2007+ XML. POI only supports OLE2 Office documents");
			}
			if ((@long & -31525197391593473L) == 4503608217567241L)
			{
				throw new global::System.ArgumentException("The supplied data appears to be in BIFF2 format.  POI only supports BIFF8 format");
			}
			throw new global::System.IO.IOException("Invalid header signature; Read " + global::NPOI.POIFS.Storage.HeaderBlockReader.LongToHex(@long) + ", expected " + global::NPOI.POIFS.Storage.HeaderBlockReader.LongToHex(-2226271756974174256L));
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00038EAC File Offset: 0x000370AC
		private byte[] ReadFirst512(global::System.IO.Stream stream)
		{
			byte[] array = new byte[512];
			int num = global::NPOI.Util.IOUtils.ReadFully(stream, array);
			if (num != 512)
			{
				this.AlertShortRead(num, 512);
			}
			return array;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00038EE1 File Offset: 0x000370E1
		private static string LongToHex(long value)
		{
			return new string(global::NPOI.Util.HexDump.LongToHex(value));
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00038EF0 File Offset: 0x000370F0
		private void AlertShortRead(int read, int expectedReadSize)
		{
			if (read < 0)
			{
				read = 0;
			}
			string text = " byte" + ((read == 1) ? "" : "s");
			throw new global::System.IO.IOException(string.Concat(new string[]
			{
				"Unable to Read entire header; ",
				read.ToString(),
				text,
				" Read; expected ",
				expectedReadSize.ToString(),
				" bytes"
			}));
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00038F5F File Offset: 0x0003715F
		public int PropertyStart
		{
			get
			{
				return this._property_start;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00038F67 File Offset: 0x00037167
		public int SBATStart
		{
			get
			{
				return this._sbat_start;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x00038F6F File Offset: 0x0003716F
		public int BATCount
		{
			get
			{
				return this._bat_count;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00038F78 File Offset: 0x00037178
		public int[] BATArray
		{
			get
			{
				int[] array = new int[109];
				int num = 76;
				for (int i = 0; i < 109; i++)
				{
					array[i] = global::NPOI.Util.LittleEndian.GetInt(this._data, num);
					num += 4;
				}
				return array;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x00038FB1 File Offset: 0x000371B1
		public int XBATCount
		{
			get
			{
				return this._xbat_count;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00038FB9 File Offset: 0x000371B9
		public int XBATIndex
		{
			get
			{
				return this._xbat_start;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x00038FC1 File Offset: 0x000371C1
		public global::NPOI.POIFS.Common.POIFSBigBlockSize BigBlockSize
		{
			get
			{
				return this.bigBlockSize;
			}
		}

		// Token: 0x040007D6 RID: 2006
		private global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize;

		// Token: 0x040007D7 RID: 2007
		private int _bat_count;

		// Token: 0x040007D8 RID: 2008
		private int _property_start;

		// Token: 0x040007D9 RID: 2009
		private int _sbat_start;

		// Token: 0x040007DA RID: 2010
		private int _sbat_count;

		// Token: 0x040007DB RID: 2011
		private int _xbat_start;

		// Token: 0x040007DC RID: 2012
		private int _xbat_count;

		// Token: 0x040007DD RID: 2013
		private byte[] _data;
	}
}
