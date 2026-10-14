using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000499 RID: 1177
	public class PieFormatRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002BAB RID: 11179 RVA: 0x0005FE49 File Offset: 0x0005E049
		public PieFormatRecord()
		{
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x00081D2E File Offset: 0x0007FF2E
		public PieFormatRecord(global::NPOI.HSSF.Record.RecordInputStream ris)
		{
			this.field_1_pcExplode = ris.ReadShort();
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00081D42 File Offset: 0x0007FF42
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_pcExplode);
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002BAF RID: 11183 RVA: 0x00081D50 File Offset: 0x0007FF50
		public override short Sid
		{
			get
			{
				return 4107;
			}
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00081D57 File Offset: 0x0007FF57
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.PieFormatRecord
			{
				Explode = this.Explode
			};
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00081D6C File Offset: 0x0007FF6C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PIEFORMAT]").AppendLine().Append("   .pcExplode = ").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_pcExplode)).Append("(").Append(this.field_1_pcExplode).AppendLine(")").AppendLine("[/PIEFORMAT]");
			return stringBuilder.ToString();
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x00081DD7 File Offset: 0x0007FFD7
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x00081DDF File Offset: 0x0007FFDF
		public int Explode
		{
			get
			{
				return (int)this.field_1_pcExplode;
			}
			set
			{
				this.field_1_pcExplode = (short)value;
			}
		}

		// Token: 0x040012F2 RID: 4850
		public const short sid = 4107;

		// Token: 0x040012F3 RID: 4851
		private short field_1_pcExplode;
	}
}
