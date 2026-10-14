using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200053E RID: 1342
	public class EscherOptRecord : global::NPOI.DDF.AbstractEscherOptRecord
	{
		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060032B5 RID: 12981 RVA: 0x0009CFF9 File Offset: 0x0009B1F9
		public override short Instance
		{
			get
			{
				this.Instance = (short)this.properties.Count;
				return base.Instance;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x0009D013 File Offset: 0x0009B213
		internal override short Options
		{
			get
			{
				short instance = this.Instance;
				short version = this.Version;
				return base.Options;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060032B7 RID: 12983 RVA: 0x0009D029 File Offset: 0x0009B229
		public override string RecordName
		{
			get
			{
				return "Opt";
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x0009D030 File Offset: 0x0009B230
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x0009D03F File Offset: 0x0009B23F
		public override short Version
		{
			get
			{
				this.Version = 3;
				return base.Version;
			}
			set
			{
				if (value != 3)
				{
					throw new global::System.ArgumentException("msofbtOPT can have only '0x3' version");
				}
				base.Version = value;
			}
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x0009D058 File Offset: 0x0009B258
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance)));
			foreach (global::NPOI.DDF.EscherProperty escherProperty in base.EscherProperties)
			{
				stringBuilder.Append(escherProperty.ToXml(tab + "\t"));
			}
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x040016A4 RID: 5796
		public const short RECORD_ID = -4085;

		// Token: 0x040016A5 RID: 5797
		public const string RECORD_DESCRIPTION = "msofbtOPT";
	}
}
