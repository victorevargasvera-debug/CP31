using System;
using System.Collections;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003F5 RID: 1013
	public class MergeCellsRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600248C RID: 9356 RVA: 0x0006DCD8 File Offset: 0x0006BED8
		public MergeCellsRecord(global::NPOI.SS.Util.CellRangeAddress[] regions, int startIndex, int numberOfRegions)
		{
			this._regions = regions;
			this._startIndex = startIndex;
			this._numberOfRegions = numberOfRegions;
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x0006DCF8 File Offset: 0x0006BEF8
		public MergeCellsRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			int num = in1.ReadUShort();
			global::NPOI.SS.Util.CellRangeAddress[] array = new global::NPOI.SS.Util.CellRangeAddress[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new global::NPOI.SS.Util.CellRangeAddress(in1);
			}
			this._numberOfRegions = num;
			this._startIndex = 0;
			this._regions = array;
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x0006DD43 File Offset: 0x0006BF43
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._regions.GetEnumerator();
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x0006DD50 File Offset: 0x0006BF50
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x00008C75 File Offset: 0x00006E75
		public short NumAreas
		{
			get
			{
				return (short)this._numberOfRegions;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0006DD59 File Offset: 0x0006BF59
		public global::NPOI.SS.Util.CellRangeAddress GetAreaAt(int index)
		{
			return this._regions[this._startIndex + index];
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x0006DD6A File Offset: 0x0006BF6A
		protected override int DataSize
		{
			get
			{
				return global::NPOI.SS.Util.CellRangeAddressList.GetEncodedSize(this._numberOfRegions);
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x0006DD77 File Offset: 0x0006BF77
		public override short Sid
		{
			get
			{
				return 229;
			}
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x0006DD80 File Offset: 0x0006BF80
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			int numberOfRegions = this._numberOfRegions;
			out1.WriteShort(numberOfRegions);
			for (int i = 0; i < this._numberOfRegions; i++)
			{
				this._regions[this._startIndex + i].Serialize(out1);
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x0006DDC4 File Offset: 0x0006BFC4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[MERGEDCELLS]").Append("\n");
			stringBuilder.Append("     .numregions =").Append(this.NumAreas).Append("\n");
			for (int i = 0; i < this._numberOfRegions; i++)
			{
				global::NPOI.SS.Util.CellRangeAddress cellRangeAddress = this._regions[this._startIndex + i];
				stringBuilder.Append("     .rowfrom    =").Append(cellRangeAddress.FirstRow).Append("\n");
				stringBuilder.Append("     .rowto      =").Append(cellRangeAddress.LastRow).Append("\n");
				stringBuilder.Append("     .colfrom    =").Append(cellRangeAddress.FirstColumn).Append("\n");
				stringBuilder.Append("     .colto      =").Append(cellRangeAddress.LastColumn).Append("\n");
			}
			stringBuilder.Append("[MERGEDCELLS]").Append("\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x0006DED8 File Offset: 0x0006C0D8
		public override object Clone()
		{
			int numberOfRegions = this._numberOfRegions;
			global::NPOI.SS.Util.CellRangeAddress[] array = new global::NPOI.SS.Util.CellRangeAddress[numberOfRegions];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = this._regions[this._startIndex + i].Copy();
			}
			return new global::NPOI.HSSF.Record.MergeCellsRecord(array, 0, numberOfRegions);
		}

		// Token: 0x04000F56 RID: 3926
		public const short sid = 229;

		// Token: 0x04000F57 RID: 3927
		private global::NPOI.SS.Util.CellRangeAddress[] _regions;

		// Token: 0x04000F58 RID: 3928
		private int _startIndex;

		// Token: 0x04000F59 RID: 3929
		private int _numberOfRegions;
	}
}
