using System;
using System.Text;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000481 RID: 1153
	public class LinkedDataRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002AB8 RID: 10936 RVA: 0x0005FE49 File Offset: 0x0005E049
		public LinkedDataRecord()
		{
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0007F97C File Offset: 0x0007DB7C
		public LinkedDataRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_linkType = (byte)in1.ReadByte();
			this.field_2_referenceType = (byte)in1.ReadByte();
			this.field_3_options = in1.ReadShort();
			this.field_4_indexNumberFmtRecord = in1.ReadShort();
			int encodedTokenLen = in1.ReadUShort();
			this.field_5_formulaOfLink = global::NPOI.SS.Formula.Formula.Read(encodedTokenLen, in1);
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x0007F9D8 File Offset: 0x0007DBD8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AI]\n");
			stringBuilder.Append("    .linkType             = ").Append(global::NPOI.Util.HexDump.ByteToHex((int)this.LinkType)).Append('\n');
			stringBuilder.Append("    .referenceType        = ").Append(global::NPOI.Util.HexDump.ByteToHex((int)this.ReferenceType)).Append('\n');
			stringBuilder.Append("    .options              = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.Options)).Append('\n');
			stringBuilder.Append("    .customNumberFormat   = ").Append(this.IsCustomNumberFormat).Append('\n');
			stringBuilder.Append("    .indexNumberFmtRecord = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.IndexNumberFmtRecord)).Append('\n');
			stringBuilder.Append("    .FormulaOfLink        = ").Append('\n');
			foreach (global::NPOI.SS.Formula.PTG.Ptg ptg in this.field_5_formulaOfLink.Tokens)
			{
				stringBuilder.Append(ptg.ToString()).Append(ptg.RVAType).Append('\n');
			}
			stringBuilder.Append("[/AI]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0007FB03 File Offset: 0x0007DD03
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)this.field_1_linkType);
			out1.WriteByte((int)this.field_2_referenceType);
			out1.WriteShort((int)this.field_3_options);
			out1.WriteShort((int)this.field_4_indexNumberFmtRecord);
			this.field_5_formulaOfLink.Serialize(out1);
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x0007FB41 File Offset: 0x0007DD41
		protected override int DataSize
		{
			get
			{
				return 6 + this.field_5_formulaOfLink.EncodedSize;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x0007FB50 File Offset: 0x0007DD50
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.LinkedDataRecord.sid;
			}
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x0007FB58 File Offset: 0x0007DD58
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.LinkedDataRecord
			{
				field_1_linkType = this.field_1_linkType,
				field_2_referenceType = this.field_2_referenceType,
				field_3_options = this.field_3_options,
				field_4_indexNumberFmtRecord = this.field_4_indexNumberFmtRecord,
				field_5_formulaOfLink = this.field_5_formulaOfLink.Copy()
			};
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x0007FBAB File Offset: 0x0007DDAB
		// (set) Token: 0x06002AC0 RID: 10944 RVA: 0x0007FBB3 File Offset: 0x0007DDB3
		public byte LinkType
		{
			get
			{
				return this.field_1_linkType;
			}
			set
			{
				this.field_1_linkType = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x0007FBBC File Offset: 0x0007DDBC
		// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x0007FBC4 File Offset: 0x0007DDC4
		public byte ReferenceType
		{
			get
			{
				return this.field_2_referenceType;
			}
			set
			{
				this.field_2_referenceType = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x0007FBCD File Offset: 0x0007DDCD
		// (set) Token: 0x06002AC4 RID: 10948 RVA: 0x0007FBD5 File Offset: 0x0007DDD5
		public short Options
		{
			get
			{
				return this.field_3_options;
			}
			set
			{
				this.field_3_options = value;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x0007FBDE File Offset: 0x0007DDDE
		// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x0007FBE6 File Offset: 0x0007DDE6
		public short IndexNumberFmtRecord
		{
			get
			{
				return this.field_4_indexNumberFmtRecord;
			}
			set
			{
				this.field_4_indexNumberFmtRecord = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0007FBEF File Offset: 0x0007DDEF
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0007FBFC File Offset: 0x0007DDFC
		public global::NPOI.SS.Formula.PTG.Ptg[] FormulaOfLink
		{
			get
			{
				return this.field_5_formulaOfLink.Tokens;
			}
			set
			{
				this.field_5_formulaOfLink = global::NPOI.SS.Formula.Formula.Create(value);
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0007FC0A File Offset: 0x0007DE0A
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x0007FC1C File Offset: 0x0007DE1C
		public bool IsCustomNumberFormat
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.LinkedDataRecord.customNumberFormat.IsSet((int)this.field_3_options);
			}
			set
			{
				this.field_3_options = global::NPOI.HSSF.Record.Chart.LinkedDataRecord.customNumberFormat.SetShortBoolean(this.field_3_options, value);
			}
		}

		// Token: 0x04001272 RID: 4722
		public static short sid = 4177;

		// Token: 0x04001273 RID: 4723
		private static global::NPOI.Util.BitField customNumberFormat = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001274 RID: 4724
		private byte field_1_linkType;

		// Token: 0x04001275 RID: 4725
		public static byte LINK_TYPE_TITLE_OR_TEXT = 0;

		// Token: 0x04001276 RID: 4726
		public static byte LINK_TYPE_VALUES = 1;

		// Token: 0x04001277 RID: 4727
		public static byte LINK_TYPE_CATEGORIES = 2;

		// Token: 0x04001278 RID: 4728
		public static byte LINK_TYPE_SECONDARY_CATEGORIES = 3;

		// Token: 0x04001279 RID: 4729
		private byte field_2_referenceType;

		// Token: 0x0400127A RID: 4730
		public static byte REFERENCE_TYPE_DEFAULT_CATEGORIES = 0;

		// Token: 0x0400127B RID: 4731
		public static byte REFERENCE_TYPE_DIRECT = 1;

		// Token: 0x0400127C RID: 4732
		public static byte REFERENCE_TYPE_WORKSHEET = 2;

		// Token: 0x0400127D RID: 4733
		public static byte REFERENCE_TYPE_NOT_USED = 3;

		// Token: 0x0400127E RID: 4734
		public static byte REFERENCE_TYPE_ERROR_REPORTED = 4;

		// Token: 0x0400127F RID: 4735
		private short field_3_options;

		// Token: 0x04001280 RID: 4736
		private short field_4_indexNumberFmtRecord;

		// Token: 0x04001281 RID: 4737
		private global::NPOI.SS.Formula.Formula field_5_formulaOfLink;
	}
}
