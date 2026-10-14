using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200048D RID: 1165
	public class ShtPropsRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002AFD RID: 11005 RVA: 0x0007FDA4 File Offset: 0x0007DFA4
		public ShtPropsRecord()
		{
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x0007FDF4 File Offset: 0x0007DFF4
		public ShtPropsRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_flags = in1.ReadShort();
			this.field_2_mdBlank = (byte)in1.ReadByte();
			this.field_3_reserved = (byte)in1.ReadByte();
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x0007FE6C File Offset: 0x0007E06C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SHTPROPS]\n");
			stringBuilder.Append("    .flags                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Flags)).Append(" (").Append(this.Flags).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .chartTypeManuallyFormatted     = ").Append(this.IsManSerAlloc).Append('\n');
			stringBuilder.Append("         .plotVisibleOnly          = ").Append(this.IsPlotVisibleOnly).Append('\n');
			stringBuilder.Append("         .doNotSizeWithWindow      = ").Append(this.IsNotSizeWithWindow).Append('\n');
			stringBuilder.Append("         .defaultPlotDimensions     = ").Append(this.IsManPlotArea).Append('\n');
			stringBuilder.Append("         .autoPlotArea             = ").Append(this.IsAlwaysAutoPlotArea).Append('\n');
			stringBuilder.Append("    .empty                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Blank)).Append(" (").Append(this.Blank).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/SHTPROPS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x0007FFD3 File Offset: 0x0007E1D3
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_flags);
			out1.WriteByte((int)this.field_2_mdBlank);
			out1.WriteByte(0);
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x00018498 File Offset: 0x00016698
		protected override int DataSize
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002B02 RID: 11010 RVA: 0x0007FFF4 File Offset: 0x0007E1F4
		public override short Sid
		{
			get
			{
				return 4164;
			}
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0007FFFB File Offset: 0x0007E1FB
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.ShtPropsRecord
			{
				field_1_flags = this.field_1_flags,
				field_2_mdBlank = this.field_2_mdBlank,
				field_3_reserved = this.field_3_reserved
			};
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x00080026 File Offset: 0x0007E226
		// (set) Token: 0x06002B05 RID: 11013 RVA: 0x0008002E File Offset: 0x0007E22E
		public short Flags
		{
			get
			{
				return this.field_1_flags;
			}
			set
			{
				this.field_1_flags = value;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002B06 RID: 11014 RVA: 0x00080037 File Offset: 0x0007E237
		// (set) Token: 0x06002B07 RID: 11015 RVA: 0x0008003F File Offset: 0x0007E23F
		public byte Blank
		{
			get
			{
				return this.field_2_mdBlank;
			}
			set
			{
				this.field_2_mdBlank = value;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x00080048 File Offset: 0x0007E248
		// (set) Token: 0x06002B09 RID: 11017 RVA: 0x0008005B File Offset: 0x0007E25B
		public bool IsManSerAlloc
		{
			get
			{
				return this.manSerAlloc.IsSet((int)this.field_1_flags);
			}
			set
			{
				this.field_1_flags = this.manSerAlloc.SetShortBoolean(this.field_1_flags, value);
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002B0A RID: 11018 RVA: 0x00080075 File Offset: 0x0007E275
		// (set) Token: 0x06002B0B RID: 11019 RVA: 0x00080088 File Offset: 0x0007E288
		public bool IsPlotVisibleOnly
		{
			get
			{
				return this.plotVisibleOnly.IsSet((int)this.field_1_flags);
			}
			set
			{
				this.field_1_flags = this.plotVisibleOnly.SetShortBoolean(this.field_1_flags, value);
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002B0C RID: 11020 RVA: 0x000800A2 File Offset: 0x0007E2A2
		// (set) Token: 0x06002B0D RID: 11021 RVA: 0x000800B5 File Offset: 0x0007E2B5
		public bool IsNotSizeWithWindow
		{
			get
			{
				return this.doNotSizeWithWindow.IsSet((int)this.field_1_flags);
			}
			set
			{
				this.field_1_flags = this.doNotSizeWithWindow.SetShortBoolean(this.field_1_flags, value);
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002B0E RID: 11022 RVA: 0x000800CF File Offset: 0x0007E2CF
		// (set) Token: 0x06002B0F RID: 11023 RVA: 0x000800E2 File Offset: 0x0007E2E2
		public bool IsManPlotArea
		{
			get
			{
				return this.manPlotArea.IsSet((int)this.field_1_flags);
			}
			set
			{
				this.field_1_flags = this.manPlotArea.SetShortBoolean(this.field_1_flags, value);
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x000800FC File Offset: 0x0007E2FC
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x0008010F File Offset: 0x0007E30F
		public bool IsAlwaysAutoPlotArea
		{
			get
			{
				return this.alwaysAutoPlotArea.IsSet((int)this.field_1_flags);
			}
			set
			{
				this.field_1_flags = this.alwaysAutoPlotArea.SetShortBoolean(this.field_1_flags, value);
				if (value)
				{
					this.IsManPlotArea = value;
				}
			}
		}

		// Token: 0x0400128E RID: 4750
		public const short sid = 4164;

		// Token: 0x0400128F RID: 4751
		private short field_1_flags;

		// Token: 0x04001290 RID: 4752
		private global::NPOI.Util.BitField manSerAlloc = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001291 RID: 4753
		private global::NPOI.Util.BitField plotVisibleOnly = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04001292 RID: 4754
		private global::NPOI.Util.BitField doNotSizeWithWindow = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04001293 RID: 4755
		private global::NPOI.Util.BitField manPlotArea = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04001294 RID: 4756
		private global::NPOI.Util.BitField alwaysAutoPlotArea = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04001295 RID: 4757
		private byte field_2_mdBlank;

		// Token: 0x04001296 RID: 4758
		private byte field_3_reserved;

		// Token: 0x04001297 RID: 4759
		public const byte EMPTY_NOT_PLOTTED = 0;

		// Token: 0x04001298 RID: 4760
		public const byte EMPTY_ZERO = 1;

		// Token: 0x04001299 RID: 4761
		public const byte EMPTY_INTERPOLATED = 2;
	}
}
