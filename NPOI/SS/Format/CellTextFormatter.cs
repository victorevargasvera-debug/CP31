using System;
using System.Text;
using System.Text.RegularExpressions;

namespace NPOI.SS.Format
{
	// Token: 0x02000252 RID: 594
	public class CellTextFormatter : global::NPOI.SS.Format.CellFormatter
	{
		// Token: 0x06000E8E RID: 3726 RVA: 0x0002B334 File Offset: 0x00029534
		public CellTextFormatter(string format) : base(format)
		{
			global::NPOI.SS.Format.CellTextFormatter.PartHandler partHandler = new global::NPOI.SS.Format.CellTextFormatter.PartHandler((new int[1])[0]);
			this.desc = global::NPOI.SS.Format.CellFormatPart.ParseFormat(format, global::NPOI.SS.Format.CellFormatType.TEXT, partHandler).ToString();
			this.textPos = new int[partHandler.NumPlace];
			int startIndex = this.desc.Length - 1;
			for (int i = 0; i < this.textPos.Length; i++)
			{
				this.textPos[i] = this.desc.LastIndexOf("\0", startIndex);
				startIndex = this.textPos[i] - 1;
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0002B3C4 File Offset: 0x000295C4
		public override void FormatValue(global::System.Text.StringBuilder toAppendTo, object obj)
		{
			int length = toAppendTo.Length;
			string text = obj.ToString();
			if (obj is bool)
			{
				text = text.ToUpper();
			}
			toAppendTo.Append(this.desc);
			for (int i = 0; i < this.textPos.Length; i++)
			{
				int num = length + this.textPos[i];
				toAppendTo.Remove(num, 1).Insert(num, text);
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0002B429 File Offset: 0x00029629
		public override void SimpleValue(global::System.Text.StringBuilder toAppendTo, object value)
		{
			global::NPOI.SS.Format.CellTextFormatter.SIMPLE_TEXT.FormatValue(toAppendTo, value);
		}

		// Token: 0x040006A5 RID: 1701
		private int[] textPos;

		// Token: 0x040006A6 RID: 1702
		private string desc;

		// Token: 0x040006A7 RID: 1703
		internal static global::NPOI.SS.Format.CellFormatter SIMPLE_TEXT = new global::NPOI.SS.Format.CellTextFormatter("@");

		// Token: 0x020005A3 RID: 1443
		private class PartHandler : global::NPOI.SS.Format.CellFormatPart.IPartHandler
		{
			// Token: 0x17000DB5 RID: 3509
			// (get) Token: 0x06003474 RID: 13428 RVA: 0x000A33B0 File Offset: 0x000A15B0
			public int NumPlace
			{
				get
				{
					return this.numplace;
				}
			}

			// Token: 0x06003475 RID: 13429 RVA: 0x000A33B8 File Offset: 0x000A15B8
			public PartHandler(int numPlace)
			{
				this.numplace = numPlace;
			}

			// Token: 0x06003476 RID: 13430 RVA: 0x000A33C7 File Offset: 0x000A15C7
			public string HandlePart(global::System.Text.RegularExpressions.Match m, string part, global::NPOI.SS.Format.CellFormatType type, global::System.Text.StringBuilder desc)
			{
				if (part.Equals("@"))
				{
					this.numplace++;
					return "\0";
				}
				return null;
			}

			// Token: 0x0400191B RID: 6427
			private int numplace;
		}
	}
}
