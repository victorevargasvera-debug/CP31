using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003B3 RID: 947
	public abstract class CellRecord : global::NPOI.HSSF.Record.StandardRecord, global::NPOI.HSSF.Record.CellValueRecordInterface, global::System.IComparable
	{
		// Token: 0x060020D3 RID: 8403 RVA: 0x0005FE49 File Offset: 0x0005E049
		protected CellRecord()
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x000646BA File Offset: 0x000628BA
		protected CellRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._rowIndex = in1.ReadUShort();
			this._columnIndex = in1.ReadUShort();
			this._formatIndex = in1.ReadUShort();
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x000646E6 File Offset: 0x000628E6
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x000646EE File Offset: 0x000628EE
		public int Row
		{
			get
			{
				return this._rowIndex;
			}
			set
			{
				this._rowIndex = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x000646F7 File Offset: 0x000628F7
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x000646FF File Offset: 0x000628FF
		public int Column
		{
			get
			{
				return this._columnIndex;
			}
			set
			{
				this._columnIndex = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x00064708 File Offset: 0x00062908
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x00064711 File Offset: 0x00062911
		public short XFIndex
		{
			get
			{
				return (short)this._formatIndex;
			}
			set
			{
				this._formatIndex = (int)value;
			}
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0006471C File Offset: 0x0006291C
		public int CompareTo(object obj)
		{
			global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecordInterface = (global::NPOI.HSSF.Record.CellValueRecordInterface)obj;
			if (this.Row == cellValueRecordInterface.Row && this.Column == cellValueRecordInterface.Column)
			{
				return 0;
			}
			if (this.Row < cellValueRecordInterface.Row)
			{
				return -1;
			}
			if (this.Row > cellValueRecordInterface.Row)
			{
				return 1;
			}
			if (this.Column < cellValueRecordInterface.Column)
			{
				return -1;
			}
			if (this.Column > cellValueRecordInterface.Column)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00064790 File Offset: 0x00062990
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string recordName = this.RecordName;
			stringBuilder.Append("[").Append(recordName).Append("]\n");
			stringBuilder.Append("    .row    = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.Row)).Append("\n");
			stringBuilder.Append("    .col    = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.Column)).Append("\n");
			stringBuilder.Append("    .xfindex= ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.XFIndex)).Append("\n");
			this.AppendValueText(stringBuilder);
			stringBuilder.Append("\n");
			stringBuilder.Append("[/").Append(recordName).Append("]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060020DD RID: 8413
		protected abstract void AppendValueText(global::System.Text.StringBuilder sb);

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060020DE RID: 8414
		protected abstract string RecordName { get; }

		// Token: 0x060020DF RID: 8415
		protected abstract void SerializeValue(global::NPOI.Util.ILittleEndianOutput out1);

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060020E0 RID: 8416
		protected abstract int ValueDataSize { get; }

		// Token: 0x060020E1 RID: 8417 RVA: 0x0006486D File Offset: 0x00062A6D
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.Row);
			out1.WriteShort(this.Column);
			out1.WriteShort((int)this.XFIndex);
			this.SerializeValue(out1);
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x0006489A File Offset: 0x00062A9A
		protected override int DataSize
		{
			get
			{
				return 6 + this.ValueDataSize;
			}
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x000648A4 File Offset: 0x00062AA4
		protected void CopyBaseFields(global::NPOI.HSSF.Record.CellRecord rec)
		{
			rec._rowIndex = this._rowIndex;
			rec._columnIndex = this._columnIndex;
			rec._formatIndex = this._formatIndex;
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x000648CC File Offset: 0x00062ACC
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.HSSF.Record.CellValueRecordInterface))
			{
				return false;
			}
			global::NPOI.HSSF.Record.CellValueRecordInterface cellValueRecordInterface = (global::NPOI.HSSF.Record.CellValueRecordInterface)obj;
			return this.Row == cellValueRecordInterface.Row && this.Column == cellValueRecordInterface.Column;
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00064909 File Offset: 0x00062B09
		public override int GetHashCode()
		{
			return this.Row ^ this.Column;
		}

		// Token: 0x04000CCE RID: 3278
		private int _rowIndex;

		// Token: 0x04000CCF RID: 3279
		private int _columnIndex;

		// Token: 0x04000CD0 RID: 3280
		private int _formatIndex;
	}
}
