using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004A4 RID: 1188
	public class ChartFRTInfoRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002C39 RID: 11321 RVA: 0x0008355C File Offset: 0x0008175C
		public ChartFRTInfoRecord()
		{
			this.rt = 2128;
			this.grbitFrt = 0;
			this.verOriginator = 10;
			this.verWriter = 10;
			this.rgCFRTID = new global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord.CFRTID[3];
			this.rgCFRTID[0] = new global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord.CFRTID(2128, 2138);
			this.rgCFRTID[1] = new global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord.CFRTID(2145, 2145);
			this.rgCFRTID[2] = new global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord.CFRTID(2154, 2155);
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000835E4 File Offset: 0x000817E4
		public ChartFRTInfoRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rt = in1.ReadShort();
			this.grbitFrt = in1.ReadShort();
			this.verOriginator = (byte)in1.ReadByte();
			this.verWriter = (byte)in1.ReadByte();
			int num = (int)in1.ReadShort();
			this.rgCFRTID = new global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord.CFRTID[num];
			for (int i = 0; i < num; i++)
			{
				this.rgCFRTID[i] = new global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord.CFRTID(in1);
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x00083656 File Offset: 0x00081856
		protected override int DataSize
		{
			get
			{
				return 8 + this.rgCFRTID.Length * 4;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002C3C RID: 11324 RVA: 0x00083664 File Offset: 0x00081864
		public override short Sid
		{
			get
			{
				return 2128;
			}
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x0008366C File Offset: 0x0008186C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.rt);
			out1.WriteShort((int)this.grbitFrt);
			out1.WriteByte((int)this.verOriginator);
			out1.WriteByte((int)this.verWriter);
			int num = this.rgCFRTID.Length;
			out1.WriteShort(num);
			for (int i = 0; i < num; i++)
			{
				this.rgCFRTID[i].Serialize(out1);
			}
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x000836D4 File Offset: 0x000818D4
		public override object Clone()
		{
			global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord chartFRTInfoRecord = new global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord();
			chartFRTInfoRecord.grbitFrt = this.grbitFrt;
			chartFRTInfoRecord.rgCFRTID = new global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord.CFRTID[this.rgCFRTID.Length];
			chartFRTInfoRecord.rt = this.rt;
			chartFRTInfoRecord.verOriginator = this.verOriginator;
			chartFRTInfoRecord.verWriter = this.verWriter;
			for (int i = 0; i < this.rgCFRTID.Length; i++)
			{
				chartFRTInfoRecord.rgCFRTID[i] = (global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord.CFRTID)this.rgCFRTID[i].Clone();
			}
			return chartFRTInfoRecord;
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00083758 File Offset: 0x00081958
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CHARTFRTINFO]\n");
			stringBuilder.Append("    .rt           =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.rt)).Append('\n');
			stringBuilder.Append("    .grbitFrt     =").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.grbitFrt)).Append('\n');
			stringBuilder.Append("    .verOriginator=").Append(global::NPOI.Util.HexDump.ByteToHex((int)this.verOriginator)).Append('\n');
			stringBuilder.Append("    .verWriter    =").Append(global::NPOI.Util.HexDump.ByteToHex((int)this.verOriginator)).Append('\n');
			stringBuilder.Append("    .nCFRTIDs     =").Append(global::NPOI.Util.HexDump.ShortToHex(this.rgCFRTID.Length)).Append('\n');
			stringBuilder.Append("[/CHARTFRTINFO]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001347 RID: 4935
		public const short sid = 2128;

		// Token: 0x04001348 RID: 4936
		private short rt;

		// Token: 0x04001349 RID: 4937
		private short grbitFrt;

		// Token: 0x0400134A RID: 4938
		private byte verOriginator;

		// Token: 0x0400134B RID: 4939
		private byte verWriter;

		// Token: 0x0400134C RID: 4940
		private global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord.CFRTID[] rgCFRTID;

		// Token: 0x0200061B RID: 1563
		private class CFRTID : global::System.ICloneable
		{
			// Token: 0x060036A8 RID: 13992 RVA: 0x000A6D44 File Offset: 0x000A4F44
			public CFRTID(int first, int last)
			{
				this.rtFirst = first;
				this.rtLast = last;
			}

			// Token: 0x060036A9 RID: 13993 RVA: 0x000A6D5A File Offset: 0x000A4F5A
			public CFRTID(global::NPOI.HSSF.Record.RecordInputStream in1)
			{
				this.rtFirst = (int)in1.ReadShort();
				this.rtLast = (int)in1.ReadShort();
			}

			// Token: 0x060036AA RID: 13994 RVA: 0x000A6D7A File Offset: 0x000A4F7A
			public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
			{
				out1.WriteShort(this.rtFirst);
				out1.WriteShort(this.rtLast);
			}

			// Token: 0x060036AB RID: 13995 RVA: 0x000A6D94 File Offset: 0x000A4F94
			public object Clone()
			{
				return new global::NPOI.HSSF.Record.Chart.ChartFRTInfoRecord.CFRTID(this.rtFirst, this.rtLast);
			}

			// Token: 0x04001A93 RID: 6803
			public const int ENCODED_SIZE = 4;

			// Token: 0x04001A94 RID: 6804
			private int rtFirst;

			// Token: 0x04001A95 RID: 6805
			private int rtLast;
		}
	}
}
