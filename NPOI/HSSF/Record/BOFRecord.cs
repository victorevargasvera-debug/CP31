using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003AC RID: 940
	public class BOFRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600207A RID: 8314 RVA: 0x0005FE49 File Offset: 0x0005E049
		public BOFRecord()
		{
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00063C12 File Offset: 0x00061E12
		private BOFRecord(global::NPOI.HSSF.Record.BOFRecordType type)
		{
			this.field_1_version = 6;
			this.field_2_type = (int)type;
			this.field_3_build = 4307;
			this.field_4_year = 1996;
			this.field_5_history = 1;
			this.field_6_rversion = 6;
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00063C4C File Offset: 0x00061E4C
		public static global::NPOI.HSSF.Record.BOFRecord CreateSheetBOF()
		{
			return new global::NPOI.HSSF.Record.BOFRecord(global::NPOI.HSSF.Record.BOFRecordType.Worksheet);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00063C58 File Offset: 0x00061E58
		public BOFRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_version = (int)in1.ReadShort();
			this.field_2_type = (int)in1.ReadShort();
			if (in1.Remaining >= 2)
			{
				this.field_3_build = (int)in1.ReadShort();
			}
			if (in1.Remaining >= 2)
			{
				this.field_4_year = (int)in1.ReadShort();
			}
			if (in1.Remaining >= 4)
			{
				this.field_5_history = in1.ReadInt();
			}
			if (in1.Remaining >= 4)
			{
				this.field_6_rversion = in1.ReadInt();
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x00063CE0 File Offset: 0x00061EE0
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x00063CD7 File Offset: 0x00061ED7
		public int Version
		{
			get
			{
				return this.field_1_version;
			}
			set
			{
				this.field_1_version = value;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x00063CF1 File Offset: 0x00061EF1
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x00063CE8 File Offset: 0x00061EE8
		public int HistoryBitMask
		{
			get
			{
				return this.field_5_history;
			}
			set
			{
				this.field_5_history = value;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x00063D02 File Offset: 0x00061F02
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x00063CF9 File Offset: 0x00061EF9
		public int RequiredVersion
		{
			get
			{
				return this.field_6_rversion;
			}
			set
			{
				this.field_6_rversion = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x00063D0A File Offset: 0x00061F0A
		// (set) Token: 0x06002085 RID: 8325 RVA: 0x00063D12 File Offset: 0x00061F12
		public global::NPOI.HSSF.Record.BOFRecordType Type
		{
			get
			{
				return (global::NPOI.HSSF.Record.BOFRecordType)this.field_2_type;
			}
			set
			{
				this.field_2_type = (int)value;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x00063D1C File Offset: 0x00061F1C
		private string TypeName
		{
			get
			{
				global::NPOI.HSSF.Record.BOFRecordType type = this.Type;
				if (type <= global::NPOI.HSSF.Record.BOFRecordType.Worksheet)
				{
					if (type == global::NPOI.HSSF.Record.BOFRecordType.Workbook)
					{
						return "workbook";
					}
					if (type == global::NPOI.HSSF.Record.BOFRecordType.VBModule)
					{
						return "vb module";
					}
					if (type == global::NPOI.HSSF.Record.BOFRecordType.Worksheet)
					{
						return "worksheet";
					}
				}
				else
				{
					if (type == global::NPOI.HSSF.Record.BOFRecordType.Chart)
					{
						return "chart";
					}
					if (type == global::NPOI.HSSF.Record.BOFRecordType.Excel4Macro)
					{
						return "excel 4 macro";
					}
					if (type == global::NPOI.HSSF.Record.BOFRecordType.WorkspaceFile)
					{
						return "workspace file";
					}
				}
				return "#error unknown type#";
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x00063D81 File Offset: 0x00061F81
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x00063D89 File Offset: 0x00061F89
		public int Build
		{
			get
			{
				return this.field_3_build;
			}
			set
			{
				this.field_3_build = value;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x00063D92 File Offset: 0x00061F92
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x00063D9A File Offset: 0x00061F9A
		public int BuildYear
		{
			get
			{
				return this.field_4_year;
			}
			set
			{
				this.field_4_year = value;
			}
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00063DA4 File Offset: 0x00061FA4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[BOF RECORD]\n");
			stringBuilder.Append("    .version         = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Version)).Append("\n");
			stringBuilder.Append("    .type            = ").Append(global::NPOI.Util.StringUtil.ToHexString((int)this.Type)).Append("\n");
			stringBuilder.Append(" (").Append(this.TypeName).Append(")").Append("\n");
			stringBuilder.Append("    .build           = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Build)).Append("\n");
			stringBuilder.Append("    .buildyear       = ").Append(this.BuildYear).Append("\n");
			stringBuilder.Append("    .history         = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.HistoryBitMask)).Append("\n");
			stringBuilder.Append("    .requiredversion = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.RequiredVersion)).Append("\n");
			stringBuilder.Append("[/BOF RECORD]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00063EE0 File Offset: 0x000620E0
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.Version);
			out1.WriteShort((int)this.Type);
			out1.WriteShort(this.Build);
			out1.WriteShort(this.BuildYear);
			out1.WriteInt(this.HistoryBitMask);
			out1.WriteInt(this.RequiredVersion);
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		protected override int DataSize
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x00063F35 File Offset: 0x00062135
		public override short Sid
		{
			get
			{
				return 2057;
			}
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00063F3C File Offset: 0x0006213C
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.BOFRecord
			{
				field_1_version = this.field_1_version,
				field_2_type = this.field_2_type,
				field_3_build = this.field_3_build,
				field_4_year = this.field_4_year,
				field_5_history = this.field_5_history,
				field_6_rversion = this.field_6_rversion
			};
		}

		// Token: 0x04000CAA RID: 3242
		public const short sid = 2057;

		// Token: 0x04000CAB RID: 3243
		public const short biff2_sid = 9;

		// Token: 0x04000CAC RID: 3244
		public const short biff3_sid = 521;

		// Token: 0x04000CAD RID: 3245
		public const short biff4_sid = 1033;

		// Token: 0x04000CAE RID: 3246
		public const short biff5_sid = 2057;

		// Token: 0x04000CAF RID: 3247
		private int field_1_version;

		// Token: 0x04000CB0 RID: 3248
		private int field_2_type;

		// Token: 0x04000CB1 RID: 3249
		private int field_3_build;

		// Token: 0x04000CB2 RID: 3250
		private int field_4_year;

		// Token: 0x04000CB3 RID: 3251
		private int field_5_history;

		// Token: 0x04000CB4 RID: 3252
		private int field_6_rversion;

		// Token: 0x04000CB5 RID: 3253
		public const short VERSION = 6;

		// Token: 0x04000CB6 RID: 3254
		public const short BUILD = 4307;

		// Token: 0x04000CB7 RID: 3255
		public const short BUILD_YEAR = 1996;

		// Token: 0x04000CB8 RID: 3256
		public const short HISTORY_MASK = 65;
	}
}
