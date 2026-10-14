using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000475 RID: 1141
	public class DefaultDataLabelTextPropertiesRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002A62 RID: 10850 RVA: 0x0005FE49 File Offset: 0x0005E049
		public DefaultDataLabelTextPropertiesRecord()
		{
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x0007F134 File Offset: 0x0007D334
		public DefaultDataLabelTextPropertiesRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_categoryDataType = in1.ReadShort();
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x0007F148 File Offset: 0x0007D348
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[DEFAULTTEXT]\n");
			stringBuilder.Append("    .categoryDataType     = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.CategoryDataType)).Append(" (").Append(this.CategoryDataType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/DEFAULTTEXT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x0007F1C8 File Offset: 0x0007D3C8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_categoryDataType);
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002A66 RID: 10854 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x0007F1D6 File Offset: 0x0007D3D6
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.DefaultDataLabelTextPropertiesRecord.sid;
			}
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x0007F1DD File Offset: 0x0007D3DD
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.DefaultDataLabelTextPropertiesRecord
			{
				field_1_categoryDataType = this.field_1_categoryDataType
			};
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x0007F1F0 File Offset: 0x0007D3F0
		// (set) Token: 0x06002A6A RID: 10858 RVA: 0x0007F1F8 File Offset: 0x0007D3F8
		public short CategoryDataType
		{
			get
			{
				return this.field_1_categoryDataType;
			}
			set
			{
				this.field_1_categoryDataType = value;
			}
		}

		// Token: 0x04001252 RID: 4690
		public static short sid = 4132;

		// Token: 0x04001253 RID: 4691
		private short field_1_categoryDataType;

		// Token: 0x04001254 RID: 4692
		public static short CATEGORY_DATA_TYPE_SHOW_LABELS_CHARACTERISTIC = 0;

		// Token: 0x04001255 RID: 4693
		public static short CATEGORY_DATA_TYPE_VALUE_AND_PERCENTAGE_CHARACTERISTIC = 1;

		// Token: 0x04001256 RID: 4694
		public static short CATEGORY_DATA_TYPE_ALL_TEXT_CHARACTERISTIC = 2;
	}
}
