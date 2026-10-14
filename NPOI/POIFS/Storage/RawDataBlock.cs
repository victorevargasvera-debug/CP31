using System;
using System.IO;
using NPOI.Util;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002B1 RID: 689
	public class RawDataBlock : global::NPOI.POIFS.Storage.ListManagedBlock
	{
		// Token: 0x06001302 RID: 4866 RVA: 0x000392CF File Offset: 0x000374CF
		public RawDataBlock(global::System.IO.Stream stream) : this(stream, 512)
		{
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000392E0 File Offset: 0x000374E0
		public RawDataBlock(global::System.IO.Stream stream, int blockSize)
		{
			this._data = new byte[blockSize];
			int num = global::NPOI.Util.IOUtils.ReadFully(stream, this._data);
			this._hasData = (num > 0);
			if (num == -1)
			{
				this._eof = true;
				return;
			}
			if (num != blockSize)
			{
				this._eof = true;
				string text = " byte" + ((num == 1) ? "" : "s");
				global::NPOI.POIFS.Storage.RawDataBlock.log.Log(7, string.Concat(new string[]
				{
					"Unable to read entire block; ",
					num.ToString(),
					text,
					" read before EOF; expected ",
					blockSize.ToString(),
					" bytes. Your document was either written by software that ignores the spec, or has been truncated!"
				}));
				return;
			}
			this._eof = false;
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00039396 File Offset: 0x00037596
		public bool EOF
		{
			get
			{
				return this._eof;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x0003939E File Offset: 0x0003759E
		public bool HasData
		{
			get
			{
				return this._hasData;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x000393A6 File Offset: 0x000375A6
		public byte[] Data
		{
			get
			{
				if (!this.HasData)
				{
					throw new global::System.IO.IOException("Cannot return empty data");
				}
				return this._data;
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000393C4 File Offset: 0x000375C4
		public override string ToString()
		{
			return "RawDataBlock of size " + this._data.Length.ToString();
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x000393EB File Offset: 0x000375EB
		public int BigBlockSize
		{
			get
			{
				return this._data.Length;
			}
		}

		// Token: 0x040007E0 RID: 2016
		private byte[] _data;

		// Token: 0x040007E1 RID: 2017
		private bool _eof;

		// Token: 0x040007E2 RID: 2018
		private bool _hasData;

		// Token: 0x040007E3 RID: 2019
		private static global::NPOI.Util.POILogger log = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.POIFS.Storage.RawDataBlock));
	}
}
