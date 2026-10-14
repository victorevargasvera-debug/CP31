using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002B5 RID: 693
	public class SmallDocumentBlock : global::NPOI.POIFS.Storage.BlockWritable, global::NPOI.POIFS.Storage.ListManagedBlock
	{
		// Token: 0x06001316 RID: 4886 RVA: 0x00039630 File Offset: 0x00037830
		public SmallDocumentBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, byte[] data, int index)
		{
			this._bigBlockSize = bigBlockSize;
			global::NPOI.POIFS.Storage.SmallDocumentBlock._blocks_per_big_block = global::NPOI.POIFS.Storage.SmallDocumentBlock.GetBlocksPerBigBlock(bigBlockSize);
			this._data = new byte[64];
			global::System.Array.Copy(data, index * 64, this._data, 0, 64);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0003966A File Offset: 0x0003786A
		public SmallDocumentBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize)
		{
			this._bigBlockSize = bigBlockSize;
			global::NPOI.POIFS.Storage.SmallDocumentBlock._blocks_per_big_block = global::NPOI.POIFS.Storage.SmallDocumentBlock.GetBlocksPerBigBlock(bigBlockSize);
			this._data = new byte[64];
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00039691 File Offset: 0x00037891
		private static int GetBlocksPerBigBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize)
		{
			return bigBlockSize.GetBigBlockSize() / 64;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0003969C File Offset: 0x0003789C
		public static global::NPOI.POIFS.Storage.SmallDocumentBlock[] Convert(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, byte[] array, int size)
		{
			global::NPOI.POIFS.Storage.SmallDocumentBlock[] array2 = new global::NPOI.POIFS.Storage.SmallDocumentBlock[(size + 64 - 1) / 64];
			int num = 0;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = new global::NPOI.POIFS.Storage.SmallDocumentBlock(bigBlockSize);
				if (num < array.Length)
				{
					int num2 = global::System.Math.Min(64, array.Length - num);
					global::System.Array.Copy(array, num, array2[i]._data, 0, num2);
					if (num2 != 64)
					{
						for (int j = num2; j < 64; j++)
						{
							array2[i]._data[j] = byte.MaxValue;
						}
					}
				}
				else
				{
					for (int k = 0; k < array2[i]._data.Length; k++)
					{
						array2[i]._data[k] = byte.MaxValue;
					}
				}
				num += 64;
			}
			return array2;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00039754 File Offset: 0x00037954
		public static int Fill(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::System.Collections.Generic.IList<global::NPOI.POIFS.Storage.SmallDocumentBlock> blocks)
		{
			int blocksPerBigBlock = global::NPOI.POIFS.Storage.SmallDocumentBlock.GetBlocksPerBigBlock(bigBlockSize);
			int i = blocks.Count;
			int num = (i + blocksPerBigBlock - 1) / blocksPerBigBlock;
			int num2 = num * blocksPerBigBlock;
			while (i < num2)
			{
				blocks.Add(global::NPOI.POIFS.Storage.SmallDocumentBlock.MakeEmptySmallDocumentBlock(bigBlockSize));
				i++;
			}
			return num;
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00039794 File Offset: 0x00037994
		public static global::NPOI.POIFS.Storage.SmallDocumentBlock[] Convert(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlocksSize, global::NPOI.POIFS.Storage.BlockWritable[] store, int size)
		{
			global::NPOI.POIFS.Storage.SmallDocumentBlock[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				for (int i = 0; i < store.Length; i++)
				{
					store[i].WriteBlocks(memoryStream);
				}
				byte[] data = memoryStream.ToArray();
				global::NPOI.POIFS.Storage.SmallDocumentBlock[] array = new global::NPOI.POIFS.Storage.SmallDocumentBlock[global::NPOI.POIFS.Storage.SmallDocumentBlock.ConvertToBlockCount(size)];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = new global::NPOI.POIFS.Storage.SmallDocumentBlock(bigBlocksSize, data, j);
				}
				result = array;
			}
			return result;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00039814 File Offset: 0x00037A14
		public static global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.SmallDocumentBlock> Extract(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.Storage.ListManagedBlock[] blocks)
		{
			int blocksPerBigBlock = global::NPOI.POIFS.Storage.SmallDocumentBlock.GetBlocksPerBigBlock(bigBlockSize);
			global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.SmallDocumentBlock> list = new global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.SmallDocumentBlock>();
			for (int i = 0; i < blocks.Length; i++)
			{
				byte[] data = blocks[i].Data;
				for (int j = 0; j < blocksPerBigBlock; j++)
				{
					list.Add(new global::NPOI.POIFS.Storage.SmallDocumentBlock(bigBlockSize, data, j));
				}
			}
			return list;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00039868 File Offset: 0x00037A68
		public static void Read(global::NPOI.POIFS.Storage.BlockWritable[] blocks, byte[] buffer, int offset)
		{
			int num = offset / 64;
			int num2 = offset % 64;
			int num3 = (offset + buffer.Length - 1) / 64;
			if (num == num3)
			{
				global::System.Array.Copy(((global::NPOI.POIFS.Storage.SmallDocumentBlock)blocks[num])._data, num2, buffer, 0, buffer.Length);
				return;
			}
			int num4 = 0;
			global::System.Array.Copy(((global::NPOI.POIFS.Storage.SmallDocumentBlock)blocks[num])._data, num2, buffer, num4, 64 - num2);
			num4 += 64 - num2;
			for (int i = num + 1; i < num3; i++)
			{
				global::System.Array.Copy(((global::NPOI.POIFS.Storage.SmallDocumentBlock)blocks[i])._data, 0, buffer, num4, 64);
				num4 += 64;
			}
			global::System.Array.Copy(((global::NPOI.POIFS.Storage.SmallDocumentBlock)blocks[num3])._data, 0, buffer, num4, buffer.Length - num4);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00039914 File Offset: 0x00037B14
		public static global::NPOI.POIFS.Storage.DataInputBlock GetDataInputBlock(global::NPOI.POIFS.Storage.SmallDocumentBlock[] blocks, int offset)
		{
			int num = offset >> 6;
			int startOffset = offset & 63;
			return new global::NPOI.POIFS.Storage.DataInputBlock(blocks[num]._data, startOffset);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00039938 File Offset: 0x00037B38
		public static int CalcSize(int size)
		{
			return size * 64;
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x0003993E File Offset: 0x00037B3E
		protected int SmallBlocksPerBigBlock
		{
			get
			{
				return global::NPOI.POIFS.Storage.SmallDocumentBlock._blocks_per_big_block;
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00039948 File Offset: 0x00037B48
		private static global::NPOI.POIFS.Storage.SmallDocumentBlock MakeEmptySmallDocumentBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize)
		{
			global::NPOI.POIFS.Storage.SmallDocumentBlock smallDocumentBlock = new global::NPOI.POIFS.Storage.SmallDocumentBlock(bigBlockSize);
			for (int i = 0; i < smallDocumentBlock._data.Length; i++)
			{
				smallDocumentBlock._data[i] = byte.MaxValue;
			}
			return smallDocumentBlock;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0003997D File Offset: 0x00037B7D
		private static int ConvertToBlockCount(int size)
		{
			return (size + 64 - 1) / 64;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00039988 File Offset: 0x00037B88
		public void WriteBlocks(global::System.IO.Stream stream)
		{
			stream.Write(this._data, 0, this._data.Length);
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x0003999F File Offset: 0x00037B9F
		public byte[] Data
		{
			get
			{
				return this._data;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x000399A7 File Offset: 0x00037BA7
		public global::NPOI.POIFS.Common.POIFSBigBlockSize BigBlockSize
		{
			get
			{
				return this._bigBlockSize;
			}
		}

		// Token: 0x040007E8 RID: 2024
		private const int BLOCK_SHIFT = 6;

		// Token: 0x040007E9 RID: 2025
		private byte[] _data;

		// Token: 0x040007EA RID: 2026
		private const byte _default_fill = 255;

		// Token: 0x040007EB RID: 2027
		private const int _block_size = 64;

		// Token: 0x040007EC RID: 2028
		private const int BLOCK_MASK = 63;

		// Token: 0x040007ED RID: 2029
		private static int _blocks_per_big_block = 8;

		// Token: 0x040007EE RID: 2030
		private global::NPOI.POIFS.Common.POIFSBigBlockSize _bigBlockSize;
	}
}
