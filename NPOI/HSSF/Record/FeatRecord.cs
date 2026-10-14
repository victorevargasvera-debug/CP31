using System;
using System.Text;
using NPOI.HSSF.Record.Common;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003A3 RID: 931
	public class FeatRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600201B RID: 8219 RVA: 0x00062BA9 File Offset: 0x00060DA9
		public FeatRecord()
		{
			this.futureHeader = new global::NPOI.HSSF.Record.Common.FtrHeader();
			this.futureHeader.RecordType = 2152;
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x00062BCC File Offset: 0x00060DCC
		public override short Sid
		{
			get
			{
				return 2152;
			}
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00062BD4 File Offset: 0x00060DD4
		public FeatRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.futureHeader = new global::NPOI.HSSF.Record.Common.FtrHeader(in1);
			this.isf_sharedFeatureType = (int)in1.ReadShort();
			this.reserved1 = (byte)in1.ReadByte();
			this.reserved2 = (long)in1.ReadInt();
			int num = in1.ReadUShort();
			this.cbFeatData = (long)in1.ReadInt();
			this.reserved3 = (int)in1.ReadShort();
			this.cellRefs = new global::NPOI.SS.Util.CellRangeAddress[num];
			for (int i = 0; i < this.cellRefs.Length; i++)
			{
				this.cellRefs[i] = new global::NPOI.SS.Util.CellRangeAddress(in1);
			}
			switch (this.isf_sharedFeatureType)
			{
			case 2:
				this.sharedFeature = new global::NPOI.HSSF.Record.Common.FeatProtection(in1);
				return;
			case 3:
				this.sharedFeature = new global::NPOI.HSSF.Record.Common.FeatFormulaErr2(in1);
				return;
			case 4:
				this.sharedFeature = new global::NPOI.HSSF.Record.Common.FeatSmartTag(in1);
				return;
			default:
				global::NPOI.HSSF.Record.FeatRecord.logger.Log(7, "Unknown Shared Feature " + this.isf_sharedFeatureType.ToString() + " found!");
				return;
			}
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00062CCF File Offset: 0x00060ECF
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SHARED FEATURE]\n");
			stringBuilder.Append("[/SHARED FEATURE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00062CF4 File Offset: 0x00060EF4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			this.futureHeader.Serialize(out1);
			out1.WriteShort(this.isf_sharedFeatureType);
			out1.WriteByte((int)this.reserved1);
			out1.WriteInt((int)this.reserved2);
			out1.WriteShort(this.cellRefs.Length);
			out1.WriteInt((int)this.cbFeatData);
			out1.WriteShort(this.reserved3);
			for (int i = 0; i < this.cellRefs.Length; i++)
			{
				this.cellRefs[i].Serialize(out1);
			}
			this.sharedFeature.Serialize(out1);
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x00062D86 File Offset: 0x00060F86
		protected override int DataSize
		{
			get
			{
				return 27 + this.cellRefs.Length * 8 + this.sharedFeature.DataSize;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002021 RID: 8225 RVA: 0x00062DA1 File Offset: 0x00060FA1
		public int Isf_sharedFeatureType
		{
			get
			{
				return this.isf_sharedFeatureType;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00062DA9 File Offset: 0x00060FA9
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x00062DB1 File Offset: 0x00060FB1
		public long CbFeatData
		{
			get
			{
				return this.cbFeatData;
			}
			set
			{
				this.cbFeatData = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x00062DBA File Offset: 0x00060FBA
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x00062DC2 File Offset: 0x00060FC2
		public global::NPOI.SS.Util.CellRangeAddress[] CellRefs
		{
			get
			{
				return this.cellRefs;
			}
			set
			{
				this.cellRefs = value;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x00062DCB File Offset: 0x00060FCB
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x00062DD4 File Offset: 0x00060FD4
		public global::NPOI.HSSF.Record.Common.SharedFeature SharedFeature
		{
			get
			{
				return this.sharedFeature;
			}
			set
			{
				this.sharedFeature = value;
				if (value is global::NPOI.HSSF.Record.Common.FeatProtection)
				{
					this.isf_sharedFeatureType = 2;
				}
				if (value is global::NPOI.HSSF.Record.Common.FeatFormulaErr2)
				{
					this.isf_sharedFeatureType = 3;
				}
				if (value is global::NPOI.HSSF.Record.Common.FeatSmartTag)
				{
					this.isf_sharedFeatureType = 4;
				}
				if (this.isf_sharedFeatureType == 3)
				{
					this.cbFeatData = (long)this.sharedFeature.DataSize;
					return;
				}
				this.cbFeatData = 0L;
			}
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00062BA1 File Offset: 0x00060DA1
		public override object Clone()
		{
			return base.CloneViaReserialise();
		}

		// Token: 0x04000C78 RID: 3192
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.Record.FeatRecord));

		// Token: 0x04000C79 RID: 3193
		public const short sid = 2152;

		// Token: 0x04000C7A RID: 3194
		public const short v11_sid = 2162;

		// Token: 0x04000C7B RID: 3195
		public const short v12_sid = 2168;

		// Token: 0x04000C7C RID: 3196
		private global::NPOI.HSSF.Record.Common.FtrHeader futureHeader;

		// Token: 0x04000C7D RID: 3197
		private int isf_sharedFeatureType;

		// Token: 0x04000C7E RID: 3198
		private byte reserved1;

		// Token: 0x04000C7F RID: 3199
		private long reserved2;

		// Token: 0x04000C80 RID: 3200
		private long cbFeatData;

		// Token: 0x04000C81 RID: 3201
		private int reserved3;

		// Token: 0x04000C82 RID: 3202
		private global::NPOI.SS.Util.CellRangeAddress[] cellRefs;

		// Token: 0x04000C83 RID: 3203
		private global::NPOI.HSSF.Record.Common.SharedFeature sharedFeature;
	}
}
