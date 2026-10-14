using System;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.Util;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002AE RID: 686
	public class HeaderBlockWriter : global::NPOI.POIFS.Storage.HeaderBlockConstants, global::NPOI.POIFS.Storage.BlockWritable
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x00038FC9 File Offset: 0x000371C9
		public HeaderBlockWriter(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize)
		{
			this._header_block = new global::NPOI.POIFS.Storage.HeaderBlock(bigBlockSize);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00038FDD File Offset: 0x000371DD
		public HeaderBlockWriter(global::NPOI.POIFS.Storage.HeaderBlock headerBlock)
		{
			this._header_block = headerBlock;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00038FEC File Offset: 0x000371EC
		public global::NPOI.POIFS.Storage.BATBlock[] SetBATBlocks(int blockCount, int startBlock)
		{
			global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize = this._header_block.BigBlockSize;
			this._header_block.BATCount = blockCount;
			int num = global::System.Math.Min(blockCount, 109);
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = startBlock + i;
			}
			this._header_block.BATArray = array;
			global::NPOI.POIFS.Storage.BATBlock[] array3;
			if (blockCount > 109)
			{
				int num2 = blockCount - 109;
				int[] array2 = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					array2[j] = startBlock + j + 109;
				}
				array3 = global::NPOI.POIFS.Storage.BATBlock.CreateXBATBlocks(bigBlockSize, array2, startBlock + blockCount);
				this._header_block.XBATStart = startBlock + blockCount;
			}
			else
			{
				array3 = global::NPOI.POIFS.Storage.BATBlock.CreateXBATBlocks(bigBlockSize, new int[0], 0);
				this._header_block.XBATStart = -2;
			}
			this._header_block.XBATCount = array3.Length;
			return array3;
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x000390BC File Offset: 0x000372BC
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x000390C9 File Offset: 0x000372C9
		public int PropertyStart
		{
			get
			{
				return this._header_block.PropertyStart;
			}
			set
			{
				this._header_block.PropertyStart = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x000390D7 File Offset: 0x000372D7
		// (set) Token: 0x060012F5 RID: 4853 RVA: 0x000390E4 File Offset: 0x000372E4
		public int SBAStart
		{
			get
			{
				return this._header_block.SBATStart;
			}
			set
			{
				this._header_block.SBATStart = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x000390D7 File Offset: 0x000372D7
		// (set) Token: 0x060012F7 RID: 4855 RVA: 0x000390E4 File Offset: 0x000372E4
		public int SBATStart
		{
			get
			{
				return this._header_block.SBATStart;
			}
			set
			{
				this._header_block.SBATStart = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x000390F2 File Offset: 0x000372F2
		// (set) Token: 0x060012F9 RID: 4857 RVA: 0x000390FF File Offset: 0x000372FF
		public int SBATBlockCount
		{
			get
			{
				return this._header_block.SBATBlockCount;
			}
			set
			{
				this._header_block.SBATBlockCount = value;
			}
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0003910D File Offset: 0x0003730D
		public static int CalculateXBATStorageRequirements(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, int blockCount)
		{
			if (blockCount <= 109)
			{
				return 0;
			}
			return global::NPOI.POIFS.Storage.BATBlock.CalculateXBATStorageRequirements(bigBlockSize, blockCount - 109);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00039120 File Offset: 0x00037320
		public void WriteBlocks(global::System.IO.Stream stream)
		{
			try
			{
				this._header_block.WriteData(stream);
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0003914C File Offset: 0x0003734C
		public void WriteBlock(global::NPOI.Util.ByteBuffer block)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(this._header_block.BigBlockSize.GetBigBlockSize());
			this._header_block.WriteData(memoryStream);
			block.Write(memoryStream.ToArray());
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00039188 File Offset: 0x00037388
		public void WriteBlock(byte[] block)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(this._header_block.BigBlockSize.GetBigBlockSize());
			this._header_block.WriteData(memoryStream);
			byte[] array = memoryStream.ToArray();
			global::System.Array.Copy(array, 0, block, 0, array.Length);
		}

		// Token: 0x040007DE RID: 2014
		private global::NPOI.POIFS.Storage.HeaderBlock _header_block;
	}
}
