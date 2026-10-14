using System;
using System.Collections;
using NPOI.HSSF.Record;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x02000017 RID: 23
	public class CellRangeAddressList
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x000052A9 File Offset: 0x000034A9
		public CellRangeAddressList()
		{
			this._list = new global::System.Collections.ArrayList();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000052BC File Offset: 0x000034BC
		public CellRangeAddressList(int firstRow, int lastRow, int firstCol, int lastCol) : this()
		{
			this.AddCellRangeAddress(firstRow, firstCol, lastRow, lastCol);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000052D0 File Offset: 0x000034D0
		public CellRangeAddressList(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			int num = in1.ReadUShort();
			this._list = new global::System.Collections.ArrayList(num);
			for (int i = 0; i < num; i++)
			{
				this._list.Add(new global::NPOI.SS.Util.CellRangeAddress(in1));
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005314 File Offset: 0x00003514
		public int CountRanges()
		{
			return this._list.Count;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005324 File Offset: 0x00003524
		public void AddCellRangeAddress(int firstRow, int firstCol, int lastRow, int lastCol)
		{
			global::NPOI.SS.Util.CellRangeAddress cra = new global::NPOI.SS.Util.CellRangeAddress(firstRow, lastRow, firstCol, lastCol);
			this.AddCellRangeAddress(cra);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005343 File Offset: 0x00003543
		public void AddCellRangeAddress(global::NPOI.SS.Util.CellRangeAddress cra)
		{
			this._list.Add(cra);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005354 File Offset: 0x00003554
		public global::NPOI.SS.Util.CellRangeAddress Remove(int rangeIndex)
		{
			if (this._list.Count == 0)
			{
				throw new global::System.Exception("List is empty");
			}
			if (rangeIndex < 0 || rangeIndex >= this._list.Count)
			{
				throw new global::System.Exception(string.Concat(new string[]
				{
					"Range index (",
					rangeIndex.ToString(),
					") is outside allowable range (0..",
					(this._list.Count - 1).ToString(),
					")"
				}));
			}
			global::NPOI.SS.Util.CellRangeAddress result = (global::NPOI.SS.Util.CellRangeAddress)this._list[rangeIndex];
			this._list.Remove(rangeIndex);
			return result;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000053F8 File Offset: 0x000035F8
		public global::NPOI.SS.Util.CellRangeAddress GetCellRangeAddress(int index)
		{
			return (global::NPOI.SS.Util.CellRangeAddress)this._list[index];
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000540C File Offset: 0x0000360C
		public int Serialize(int offset, byte[] data)
		{
			int size = this.Size;
			this.Serialize(new global::NPOI.Util.LittleEndianByteArrayOutputStream(data, offset, size));
			return size;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005430 File Offset: 0x00003630
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			int count = this._list.Count;
			out1.WriteShort(count);
			for (int i = 0; i < count; i++)
			{
				((global::NPOI.SS.Util.CellRangeAddress)this._list[i]).Serialize(out1);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00005473 File Offset: 0x00003673
		public int Size
		{
			get
			{
				return global::NPOI.SS.Util.CellRangeAddressList.GetEncodedSize(this._list.Count);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005485 File Offset: 0x00003685
		public static int GetEncodedSize(int numberOfRanges)
		{
			return 2 + global::NPOI.SS.Util.CellRangeAddress.GetEncodedSize(numberOfRanges);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005490 File Offset: 0x00003690
		public global::NPOI.SS.Util.CellRangeAddressList Copy()
		{
			global::NPOI.SS.Util.CellRangeAddressList cellRangeAddressList = new global::NPOI.SS.Util.CellRangeAddressList();
			int count = this._list.Count;
			for (int i = 0; i < count; i++)
			{
				global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = (global::NPOI.SS.Util.CellRangeAddress)this._list[i];
				cellRangeAddressList.AddCellRangeAddress(cellRangeAddress.Copy());
			}
			return cellRangeAddressList;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000054DA File Offset: 0x000036DA
		public global::NPOI.SS.Util.CellRangeAddress[] CellRangeAddresses
		{
			get
			{
				return (global::NPOI.SS.Util.CellRangeAddress[])this._list.ToArray(typeof(global::NPOI.SS.Util.CellRangeAddress));
			}
		}

		// Token: 0x04000037 RID: 55
		private global::System.Collections.ArrayList _list;
	}
}
