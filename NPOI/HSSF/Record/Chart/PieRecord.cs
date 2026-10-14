using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200049A RID: 1178
	public class PieRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002BB4 RID: 11188 RVA: 0x00081DE9 File Offset: 0x0007FFE9
		public PieRecord()
		{
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x00081E0C File Offset: 0x0008000C
		public PieRecord(global::NPOI.HSSF.Record.RecordInputStream ris)
		{
			this.field_1_anStart = ris.ReadShort();
			this.field_2_pcDonut = ris.ReadShort();
			this.field_3_option = ris.ReadShort();
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x00017F5F File Offset: 0x0001615F
		protected override int DataSize
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00081E5B File Offset: 0x0008005B
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_anStart);
			out1.WriteShort((int)this.field_2_pcDonut);
			out1.WriteShort((int)this.field_3_option);
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x00081E81 File Offset: 0x00080081
		public override short Sid
		{
			get
			{
				return 4121;
			}
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x00081E88 File Offset: 0x00080088
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.PieRecord
			{
				Dount = this.Dount,
				HasShadow = this.HasShadow,
				ShowLdrLines = this.ShowLdrLines,
				Start = this.Start
			};
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x00081EC0 File Offset: 0x000800C0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PIE]").AppendLine().Append("   .anStart             =").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_anStart)).Append("(").Append(this.field_1_anStart).AppendLine(")").Append("   .anDount             =").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_pcDonut)).Append("(").Append(this.field_2_pcDonut).AppendLine(")").Append("   .option              =").Append(global::NPOI.Util.HexDump.ToHex(this.field_3_option)).Append("(").Append(this.field_3_option).AppendLine(")").Append("       .fHasShadow         =").Append(this.HasShadow).AppendLine().Append("       .fShowLdrLines      =").Append(this.ShowLdrLines).AppendLine().AppendLine("[/PIE]");
			return stringBuilder.ToString();
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x00081FD1 File Offset: 0x000801D1
		// (set) Token: 0x06002BBC RID: 11196 RVA: 0x00081FD9 File Offset: 0x000801D9
		public int Start
		{
			get
			{
				return (int)this.field_1_anStart;
			}
			set
			{
				this.field_1_anStart = (short)value;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x00081FE3 File Offset: 0x000801E3
		// (set) Token: 0x06002BBE RID: 11198 RVA: 0x00081FEB File Offset: 0x000801EB
		public int Dount
		{
			get
			{
				return (int)this.field_2_pcDonut;
			}
			set
			{
				this.field_2_pcDonut = (short)value;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x00081FF5 File Offset: 0x000801F5
		// (set) Token: 0x06002BC0 RID: 11200 RVA: 0x00082008 File Offset: 0x00080208
		public bool HasShadow
		{
			get
			{
				return this.fHasShadow.IsSet((int)this.field_3_option);
			}
			set
			{
				this.field_3_option = this.fHasShadow.SetShortBoolean(this.field_3_option, value);
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x00082022 File Offset: 0x00080222
		// (set) Token: 0x06002BC2 RID: 11202 RVA: 0x00082035 File Offset: 0x00080235
		public bool ShowLdrLines
		{
			get
			{
				return this.fShowLdrLines.IsSet((int)this.field_3_option);
			}
			set
			{
				this.field_3_option = this.fShowLdrLines.SetShortBoolean(this.field_3_option, value);
			}
		}

		// Token: 0x040012F4 RID: 4852
		public const short sid = 4121;

		// Token: 0x040012F5 RID: 4853
		private short field_1_anStart;

		// Token: 0x040012F6 RID: 4854
		private short field_2_pcDonut;

		// Token: 0x040012F7 RID: 4855
		private short field_3_option;

		// Token: 0x040012F8 RID: 4856
		private global::NPOI.Util.BitField fHasShadow = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040012F9 RID: 4857
		private global::NPOI.Util.BitField fShowLdrLines = global::NPOI.Util.BitFieldFactory.GetInstance(2);
	}
}
