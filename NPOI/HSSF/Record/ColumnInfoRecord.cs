using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003BC RID: 956
	public class ColumnInfoRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600217F RID: 8575 RVA: 0x00066443 File Offset: 0x00064643
		public ColumnInfoRecord()
		{
			this.ColumnWidth = 2275;
			this._options = 2;
			this._xf_index = 15;
			this.field_6_reserved = 2;
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x0006646C File Offset: 0x0006466C
		public ColumnInfoRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._first_col = in1.ReadUShort();
			this._last_col = in1.ReadUShort();
			this._col_width = in1.ReadUShort();
			this._xf_index = in1.ReadUShort();
			this._options = in1.ReadUShort();
			switch (in1.Remaining)
			{
			case 0:
				this.field_6_reserved = 0;
				return;
			case 1:
				this.field_6_reserved = in1.ReadByte();
				return;
			case 2:
				this.field_6_reserved = in1.ReadUShort();
				return;
			default:
				throw new global::System.Exception("Unusual record size remaining=(" + in1.Remaining.ToString() + ")");
			}
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x0006651A File Offset: 0x0006471A
		public bool FormatMatches(global::NPOI.HSSF.Record.ColumnInfoRecord other)
		{
			return this._xf_index == other._xf_index && this._options == other._options && this._col_width == other._col_width;
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0006654D File Offset: 0x0006474D
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x00066555 File Offset: 0x00064755
		public int FirstColumn
		{
			get
			{
				return this._first_col;
			}
			set
			{
				this._first_col = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x0006655E File Offset: 0x0006475E
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x00066566 File Offset: 0x00064766
		public int LastColumn
		{
			get
			{
				return this._last_col;
			}
			set
			{
				this._last_col = value;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x0006656F File Offset: 0x0006476F
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x00066577 File Offset: 0x00064777
		public int ColumnWidth
		{
			get
			{
				return this._col_width;
			}
			set
			{
				this._col_width = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x00066580 File Offset: 0x00064780
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x00066588 File Offset: 0x00064788
		public int XFIndex
		{
			get
			{
				return this._xf_index;
			}
			set
			{
				this._xf_index = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x00066591 File Offset: 0x00064791
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x00066599 File Offset: 0x00064799
		public int Options
		{
			get
			{
				return this._options;
			}
			set
			{
				this._options = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x000665A2 File Offset: 0x000647A2
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x000665B4 File Offset: 0x000647B4
		public bool IsHidden
		{
			get
			{
				return global::NPOI.HSSF.Record.ColumnInfoRecord.hidden.IsSet(this._options);
			}
			set
			{
				this._options = global::NPOI.HSSF.Record.ColumnInfoRecord.hidden.SetBoolean(this._options, value);
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x000665CD File Offset: 0x000647CD
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x000665DF File Offset: 0x000647DF
		public int OutlineLevel
		{
			get
			{
				return global::NPOI.HSSF.Record.ColumnInfoRecord.outlevel.GetValue(this._options);
			}
			set
			{
				this._options = global::NPOI.HSSF.Record.ColumnInfoRecord.outlevel.SetValue(this._options, value);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x000665F8 File Offset: 0x000647F8
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x0006660A File Offset: 0x0006480A
		public bool IsCollapsed
		{
			get
			{
				return global::NPOI.HSSF.Record.ColumnInfoRecord.collapsed.IsSet(this._options);
			}
			set
			{
				this._options = global::NPOI.HSSF.Record.ColumnInfoRecord.collapsed.SetBoolean(this._options, value);
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x00066623 File Offset: 0x00064823
		public override short Sid
		{
			get
			{
				return 125;
			}
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00066627 File Offset: 0x00064827
		public bool ContainsColumn(int columnIndex)
		{
			return this._first_col <= columnIndex && columnIndex <= this._last_col;
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00066640 File Offset: 0x00064840
		public bool IsAdjacentBefore(global::NPOI.HSSF.Record.ColumnInfoRecord other)
		{
			return this._last_col == other._first_col - 1;
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x000184AD File Offset: 0x000166AD
		protected override int DataSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00066654 File Offset: 0x00064854
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.FirstColumn);
			out1.WriteShort(this.LastColumn);
			out1.WriteShort(this.ColumnWidth);
			out1.WriteShort(this.XFIndex);
			out1.WriteShort(this._options);
			out1.WriteShort(this.field_6_reserved);
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x000666AC File Offset: 0x000648AC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[COLINFO]\n");
			stringBuilder.Append("colfirst       = ").Append(this.FirstColumn).Append("\n");
			stringBuilder.Append("collast        = ").Append(this.LastColumn).Append("\n");
			stringBuilder.Append("colwidth       = ").Append(this.ColumnWidth).Append("\n");
			stringBuilder.Append("xFindex        = ").Append(this.XFIndex).Append("\n");
			stringBuilder.Append("options        = ").Append(this.Options).Append("\n");
			stringBuilder.Append("  hidden       = ").Append(this.IsHidden).Append("\n");
			stringBuilder.Append("  olevel       = ").Append(this.OutlineLevel).Append("\n");
			stringBuilder.Append("  collapsed    = ").Append(this.IsCollapsed).Append("\n");
			stringBuilder.Append("[/COLINFO]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x000667E4 File Offset: 0x000649E4
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.ColumnInfoRecord
			{
				_first_col = this._first_col,
				_last_col = this._last_col,
				_col_width = this._col_width,
				_xf_index = this._xf_index,
				_options = this._options,
				field_6_reserved = this.field_6_reserved
			};
		}

		// Token: 0x04000D29 RID: 3369
		public const short sid = 125;

		// Token: 0x04000D2A RID: 3370
		private int _first_col;

		// Token: 0x04000D2B RID: 3371
		private int _last_col;

		// Token: 0x04000D2C RID: 3372
		private int _col_width;

		// Token: 0x04000D2D RID: 3373
		private int _xf_index;

		// Token: 0x04000D2E RID: 3374
		private int _options;

		// Token: 0x04000D2F RID: 3375
		private static global::NPOI.Util.BitField hidden = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000D30 RID: 3376
		private static global::NPOI.Util.BitField outlevel = global::NPOI.Util.BitFieldFactory.GetInstance(1792);

		// Token: 0x04000D31 RID: 3377
		private static global::NPOI.Util.BitField collapsed = global::NPOI.Util.BitFieldFactory.GetInstance(4096);

		// Token: 0x04000D32 RID: 3378
		private int field_6_reserved;
	}
}
