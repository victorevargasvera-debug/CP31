using System;
using System.Collections.Generic;
using System.Text;

namespace NLog.MessageTemplates
{
	// Token: 0x02000080 RID: 128
	internal class Template
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00016865 File Offset: 0x00014A65
		public string Value { get; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0001686D File Offset: 0x00014A6D
		public global::NLog.MessageTemplates.Literal[] Literals { get; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00016875 File Offset: 0x00014A75
		public global::NLog.MessageTemplates.Hole[] Holes { get; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0001687D File Offset: 0x00014A7D
		public bool IsPositional { get; }

		// Token: 0x060008AF RID: 2223 RVA: 0x00016885 File Offset: 0x00014A85
		public Template(string template, bool isPositional, global::System.Collections.Generic.List<global::NLog.MessageTemplates.Literal> literals, global::System.Collections.Generic.List<global::NLog.MessageTemplates.Hole> holes)
		{
			this.Value = template;
			this.IsPositional = isPositional;
			this.Literals = literals.ToArray();
			this.Holes = holes.ToArray();
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000168B4 File Offset: 0x00014AB4
		public Template(string template, bool isPositional, global::NLog.MessageTemplates.Literal[] literals, global::NLog.MessageTemplates.Hole[] holes)
		{
			this.Value = template;
			this.IsPositional = isPositional;
			this.Literals = literals;
			this.Holes = holes;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000168DC File Offset: 0x00014ADC
		public string Rebuild()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(this.Value.Length);
			int num = 0;
			int num2 = 0;
			foreach (global::NLog.MessageTemplates.Literal literal in this.Literals)
			{
				stringBuilder.Append(this.Value, num, literal.Print);
				num += literal.Print;
				if (literal.Skip == 0)
				{
					if (num < this.Value.Length)
					{
						stringBuilder.Append(this.Value[num++]);
					}
				}
				else
				{
					num += (int)literal.Skip;
					global::NLog.MessageTemplates.Template.RebuildHole(stringBuilder, ref this.Holes[num2++]);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0001699C File Offset: 0x00014B9C
		private static void RebuildHole(global::System.Text.StringBuilder sb, ref global::NLog.MessageTemplates.Hole hole)
		{
			if (hole.CaptureType == global::NLog.MessageTemplates.CaptureType.Normal)
			{
				sb.Append('{');
			}
			else if (hole.CaptureType == global::NLog.MessageTemplates.CaptureType.Serialize)
			{
				sb.Append("{@");
			}
			else
			{
				sb.Append("{$");
			}
			sb.Append(hole.Name);
			if (hole.Alignment != 0)
			{
				sb.Append(',').Append(hole.Alignment);
			}
			if (hole.Format != null)
			{
				sb.Append(':').Append(hole.Format.Replace("{", "{{").Replace("}", "}}"));
			}
			sb.Append('}');
		}
	}
}
