using System;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.Util;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002AB RID: 683
	public class DocumentBlock : global::NPOI.POIFS.Storage.BigBlock
	{
		// Token: 0x060012D8 RID: 4824 RVA: 0x00038A21 File Offset: 0x00036C21
		public DocumentBlock(global::NPOI.POIFS.Storage.RawDataBlock block) : base((block.BigBlockSize == 512) ? global::NPOI.POIFS.Common.POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS : global::NPOI.POIFS.Common.POIFSConstants.LARGER_BIG_BLOCK_SIZE_DETAILS)
		{
			this._data = block.Data;
			this._bytes_Read = this._data.Length;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00038A5C File Offset: 0x00036C5C
		public DocumentBlock(global::System.IO.Stream stream, global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize) : this(bigBlockSize)
		{
			int num = global::NPOI.Util.IOUtils.ReadFully(stream, this._data);
			this._bytes_Read = ((num == -1) ? 0 : num);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00038A8B File Offset: 0x00036C8B
		public DocumentBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize) : base(bigBlockSize)
		{
			this._data = new byte[512];
			global::NPOI.Util.Arrays.Fill(this._data, global::NPOI.POIFS.Storage.DocumentBlock._default_value);
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00038AB4 File Offset: 0x00036CB4
		public int Size
		{
			get
			{
				return this._bytes_Read;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x00038ABC File Offset: 0x00036CBC
		public bool PartiallyRead
		{
			get
			{
				return this._bytes_Read != 512;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00038ACE File Offset: 0x00036CCE
		public static byte FillByte
		{
			get
			{
				return global::NPOI.POIFS.Storage.DocumentBlock._default_value;
			}
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00038AD8 File Offset: 0x00036CD8
		public static global::NPOI.POIFS.Storage.DocumentBlock[] Convert(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, byte[] array, int size)
		{
			global::NPOI.POIFS.Storage.DocumentBlock[] array2 = new global::NPOI.POIFS.Storage.DocumentBlock[(size + 512 - 1) / 512];
			int num = 0;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = new global::NPOI.POIFS.Storage.DocumentBlock(bigBlockSize);
				if (num < array.Length)
				{
					int num2 = global::System.Math.Min(512, array.Length - num);
					global::System.Array.Copy(array, num, array2[i]._data, 0, num2);
					if (num2 != 512)
					{
						for (int j = (num2 > 0) ? (num2 - 1) : num2; j < 512; j++)
						{
							array2[i]._data[j] = global::NPOI.POIFS.Storage.DocumentBlock._default_value;
						}
					}
				}
				else
				{
					for (int k = 0; k < array2[i]._data.Length; k++)
					{
						array2[i]._data[k] = global::NPOI.POIFS.Storage.DocumentBlock._default_value;
					}
				}
				num += 512;
			}
			return array2;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00038BAC File Offset: 0x00036DAC
		public static void Read(global::NPOI.POIFS.Storage.DocumentBlock[] blocks, byte[] buffer, int offset)
		{
			int num = offset / 512;
			int num2 = offset % 512;
			int num3 = (offset + buffer.Length - 1) / 512;
			if (num == num3)
			{
				global::System.Array.Copy(blocks[num]._data, num2, buffer, 0, buffer.Length);
				return;
			}
			int num4 = 0;
			global::System.Array.Copy(blocks[num]._data, num2, buffer, num4, 512 - num2);
			num4 += 512 - num2;
			for (int i = num + 1; i < num3; i++)
			{
				global::System.Array.Copy(blocks[i]._data, 0, buffer, num4, 512);
				num4 += 512;
			}
			global::System.Array.Copy(blocks[num3]._data, 0, buffer, num4, buffer.Length - num4);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00038C58 File Offset: 0x00036E58
		public static global::NPOI.POIFS.Storage.DataInputBlock GetDataInputBlock(global::NPOI.POIFS.Storage.DocumentBlock[] blocks, int offset)
		{
			if (blocks == null || blocks.Length == 0)
			{
				return null;
			}
			global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize = blocks[0].bigBlockSize;
			int headerValue = (int)bigBlockSize.GetHeaderValue();
			int num = bigBlockSize.GetBigBlockSize() - 1;
			int num2 = offset >> headerValue;
			int startOffset = offset & num;
			return new global::NPOI.POIFS.Storage.DataInputBlock(blocks[num2]._data, startOffset);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00038C9E File Offset: 0x00036E9E
		public override void WriteData(global::System.IO.Stream stream)
		{
			base.WriteData(stream, this._data);
		}

		// Token: 0x040007C9 RID: 1993
		private static byte _default_value = byte.MaxValue;

		// Token: 0x040007CA RID: 1994
		private byte[] _data;

		// Token: 0x040007CB RID: 1995
		private int _bytes_Read;
	}
}
