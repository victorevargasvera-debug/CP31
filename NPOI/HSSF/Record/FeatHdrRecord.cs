using System;
using System.Text;
using NPOI.HSSF.Record.Common;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003A2 RID: 930
	public class FeatHdrRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002014 RID: 8212 RVA: 0x00062AB3 File Offset: 0x00060CB3
		public FeatHdrRecord()
		{
			this.futureHeader = new global::NPOI.HSSF.Record.Common.FtrHeader();
			this.futureHeader.RecordType = 2151;
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x00062AD6 File Offset: 0x00060CD6
		public override short Sid
		{
			get
			{
				return 2151;
			}
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00062AE0 File Offset: 0x00060CE0
		public FeatHdrRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.futureHeader = new global::NPOI.HSSF.Record.Common.FtrHeader(in1);
			this.isf_sharedFeatureType = (int)in1.ReadShort();
			this.reserved = (byte)in1.ReadByte();
			this.cbHdrData = (long)in1.ReadInt();
			this.rgbHdrData = in1.ReadRemainder();
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00062B31 File Offset: 0x00060D31
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FEATURE HEADER]\n");
			stringBuilder.Append("[/FEATURE HEADER]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00062B55 File Offset: 0x00060D55
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			this.futureHeader.Serialize(out1);
			out1.WriteShort(this.isf_sharedFeatureType);
			out1.WriteByte((int)this.reserved);
			out1.WriteInt((int)this.cbHdrData);
			out1.Write(this.rgbHdrData);
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x00062B94 File Offset: 0x00060D94
		protected override int DataSize
		{
			get
			{
				return 19 + this.rgbHdrData.Length;
			}
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00062BA1 File Offset: 0x00060DA1
		public override object Clone()
		{
			return base.CloneViaReserialise();
		}

		// Token: 0x04000C6E RID: 3182
		public const int SHAREDFEATURES_ISFPROTECTION = 2;

		// Token: 0x04000C6F RID: 3183
		public const int SHAREDFEATURES_ISFFEC2 = 3;

		// Token: 0x04000C70 RID: 3184
		public const int SHAREDFEATURES_ISFFACTOID = 4;

		// Token: 0x04000C71 RID: 3185
		public const int SHAREDFEATURES_ISFLIST = 5;

		// Token: 0x04000C72 RID: 3186
		public const short sid = 2151;

		// Token: 0x04000C73 RID: 3187
		private global::NPOI.HSSF.Record.Common.FtrHeader futureHeader;

		// Token: 0x04000C74 RID: 3188
		private int isf_sharedFeatureType;

		// Token: 0x04000C75 RID: 3189
		private byte reserved;

		// Token: 0x04000C76 RID: 3190
		private long cbHdrData;

		// Token: 0x04000C77 RID: 3191
		private byte[] rgbHdrData;
	}
}
