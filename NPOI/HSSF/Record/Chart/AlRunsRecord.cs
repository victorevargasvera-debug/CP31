using System;
using System.Collections;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000463 RID: 1123
	public class AlRunsRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002986 RID: 10630 RVA: 0x0005FE49 File Offset: 0x0005E049
		public AlRunsRecord()
		{
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x0007CF84 File Offset: 0x0007B184
		public AlRunsRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.m_recs = in1.ReadUShort();
			if (this.m_formats == null)
			{
				this.m_formats = new global::System.Collections.ArrayList(this.m_recs);
			}
			for (int i = 0; i < this.m_recs; i++)
			{
				global::NPOI.HSSF.Record.Chart.AlRunsRecord.CTFormat value = new global::NPOI.HSSF.Record.Chart.AlRunsRecord.CTFormat(in1.ReadShort(), in1.ReadShort());
				this.m_formats.Add(value);
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x0007CFEC File Offset: 0x0007B1EC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.m_formats.Count);
			for (int i = 0; i < this.m_formats.Count; i++)
			{
				((global::NPOI.HSSF.Record.Chart.AlRunsRecord.CTFormat)this.m_formats[i]).Serialize(out1);
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x0007D037 File Offset: 0x0007B237
		protected override int DataSize
		{
			get
			{
				return 2 + 4 * this.m_formats.Count;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x0007D048 File Offset: 0x0007B248
		public override short Sid
		{
			get
			{
				return 4176;
			}
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x0007D04F File Offset: 0x0007B24F
		public int GetFormatCount()
		{
			return this.m_formats.Count;
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x0007D05C File Offset: 0x0007B25C
		public void ModifyFormatRun(short oldPos, short newLen)
		{
			short num = 0;
			for (int i = 0; i < this.m_formats.Count; i++)
			{
				global::NPOI.HSSF.Record.Chart.AlRunsRecord.CTFormat ctformat = (global::NPOI.HSSF.Record.Chart.AlRunsRecord.CTFormat)this.m_formats[i];
				if (num != 0)
				{
					ctformat.Offset += num;
				}
				else if (oldPos == ctformat.Offset && i < this.m_formats.Count - 1)
				{
					global::NPOI.HSSF.Record.Chart.AlRunsRecord.CTFormat ctformat2 = (global::NPOI.HSSF.Record.Chart.AlRunsRecord.CTFormat)this.m_formats[i + 1];
					num = newLen - (ctformat2.Offset - ctformat.Offset);
				}
			}
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x0007D0E8 File Offset: 0x0007B2E8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[ALRUNS]\n");
			stringBuilder.Append("    .format_runs       = ").Append(this.m_recs).Append("\n");
			for (int i = 0; i < this.m_formats.Count; i++)
			{
				global::NPOI.HSSF.Record.Chart.AlRunsRecord.CTFormat ctformat = (global::NPOI.HSSF.Record.Chart.AlRunsRecord.CTFormat)this.m_formats[i];
				stringBuilder.Append("       .char_offset= ").Append(ctformat.Offset);
				stringBuilder.Append(",.fontidx= ").Append(ctformat.FontIndex);
				stringBuilder.Append("\n");
			}
			stringBuilder.Append("[/ALRUNS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x040011F4 RID: 4596
		public const short sid = 4176;

		// Token: 0x040011F5 RID: 4597
		private int m_recs;

		// Token: 0x040011F6 RID: 4598
		private global::System.Collections.ArrayList m_formats;

		// Token: 0x0200061A RID: 1562
		private class CTFormat
		{
			// Token: 0x060036A3 RID: 13987 RVA: 0x000A6CFB File Offset: 0x000A4EFB
			public CTFormat(short offset, short fontIdx)
			{
				this.m_offset = offset;
				this.m_fontIndex = fontIdx;
			}

			// Token: 0x17000E27 RID: 3623
			// (get) Token: 0x060036A4 RID: 13988 RVA: 0x000A6D11 File Offset: 0x000A4F11
			// (set) Token: 0x060036A5 RID: 13989 RVA: 0x000A6D19 File Offset: 0x000A4F19
			public short Offset
			{
				get
				{
					return this.m_offset;
				}
				set
				{
					this.m_offset = value;
				}
			}

			// Token: 0x17000E28 RID: 3624
			// (get) Token: 0x060036A6 RID: 13990 RVA: 0x000A6D22 File Offset: 0x000A4F22
			public short FontIndex
			{
				get
				{
					return this.m_fontIndex;
				}
			}

			// Token: 0x060036A7 RID: 13991 RVA: 0x000A6D2A File Offset: 0x000A4F2A
			public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
			{
				out1.WriteShort((int)this.m_offset);
				out1.WriteShort((int)this.m_fontIndex);
			}

			// Token: 0x04001A91 RID: 6801
			private short m_offset;

			// Token: 0x04001A92 RID: 6802
			private short m_fontIndex;
		}
	}
}
