using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200049E RID: 1182
	public class AxisRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002BFA RID: 11258 RVA: 0x0005FE49 File Offset: 0x0005E049
		public AxisRecord()
		{
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000829B0 File Offset: 0x00080BB0
		public AxisRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_axisType = in1.ReadShort();
			this.field_2_reserved1 = in1.ReadInt();
			this.field_3_reserved2 = in1.ReadInt();
			this.field_4_reserved3 = in1.ReadInt();
			this.field_5_reserved4 = in1.ReadInt();
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x00082A00 File Offset: 0x00080C00
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AXIS]\n");
			stringBuilder.Append("    .axisType             = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.AxisType)).Append(" (").Append(this.AxisType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .reserved1            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Reserved1)).Append(" (").Append(this.Reserved1).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .reserved2            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Reserved2)).Append(" (").Append(this.Reserved2).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .reserved3            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Reserved3)).Append(" (").Append(this.Reserved3).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .reserved4            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Reserved4)).Append(" (").Append(this.Reserved4).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/AXIS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x00082BC4 File Offset: 0x00080DC4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_axisType);
			out1.WriteInt(this.field_2_reserved1);
			out1.WriteInt(this.field_3_reserved2);
			out1.WriteInt(this.field_4_reserved3);
			out1.WriteInt(this.field_5_reserved4);
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x000199E4 File Offset: 0x00017BE4
		protected override int DataSize
		{
			get
			{
				return 18;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x00082C02 File Offset: 0x00080E02
		public override short Sid
		{
			get
			{
				return 4125;
			}
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00082C0C File Offset: 0x00080E0C
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.AxisRecord
			{
				field_1_axisType = this.field_1_axisType,
				field_2_reserved1 = this.field_2_reserved1,
				field_3_reserved2 = this.field_3_reserved2,
				field_4_reserved3 = this.field_4_reserved3,
				field_5_reserved4 = this.field_5_reserved4
			};
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x00082C5A File Offset: 0x00080E5A
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x00082C62 File Offset: 0x00080E62
		public short AxisType
		{
			get
			{
				return this.field_1_axisType;
			}
			set
			{
				this.field_1_axisType = value;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x00082C6B File Offset: 0x00080E6B
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x00082C73 File Offset: 0x00080E73
		public int Reserved1
		{
			get
			{
				return this.field_2_reserved1;
			}
			set
			{
				this.field_2_reserved1 = value;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x00082C7C File Offset: 0x00080E7C
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x00082C84 File Offset: 0x00080E84
		public int Reserved2
		{
			get
			{
				return this.field_3_reserved2;
			}
			set
			{
				this.field_3_reserved2 = value;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x00082C8D File Offset: 0x00080E8D
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x00082C95 File Offset: 0x00080E95
		public int Reserved3
		{
			get
			{
				return this.field_4_reserved3;
			}
			set
			{
				this.field_4_reserved3 = value;
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x00082C9E File Offset: 0x00080E9E
		// (set) Token: 0x06002C0A RID: 11274 RVA: 0x00082CA6 File Offset: 0x00080EA6
		public int Reserved4
		{
			get
			{
				return this.field_5_reserved4;
			}
			set
			{
				this.field_5_reserved4 = value;
			}
		}

		// Token: 0x04001323 RID: 4899
		public const short sid = 4125;

		// Token: 0x04001324 RID: 4900
		private short field_1_axisType;

		// Token: 0x04001325 RID: 4901
		public const short AXIS_TYPE_CATEGORY_OR_X_AXIS = 0;

		// Token: 0x04001326 RID: 4902
		public const short AXIS_TYPE_VALUE_AXIS = 1;

		// Token: 0x04001327 RID: 4903
		public const short AXIS_TYPE_SERIES_AXIS = 2;

		// Token: 0x04001328 RID: 4904
		private int field_2_reserved1;

		// Token: 0x04001329 RID: 4905
		private int field_3_reserved2;

		// Token: 0x0400132A RID: 4906
		private int field_4_reserved3;

		// Token: 0x0400132B RID: 4907
		private int field_5_reserved4;
	}
}
