using System;
using System.Text;
using NPOI.Util;

namespace NPOI.SS.Format
{
	// Token: 0x02000250 RID: 592
	public class CellGeneralFormatter : global::NPOI.SS.Format.CellFormatter
	{
		// Token: 0x06000E71 RID: 3697 RVA: 0x00029CF5 File Offset: 0x00027EF5
		public CellGeneralFormatter() : base("General")
		{
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00029D04 File Offset: 0x00027F04
		public override void FormatValue(global::System.Text.StringBuilder toAppendTo, object value)
		{
			if (global::NPOI.Util.Number.IsNumber(value))
			{
				double num;
				double.TryParse(value.ToString(), out num);
				if (num == 0.0)
				{
					toAppendTo.Append('0');
					return;
				}
				double num2 = global::System.Math.Log10(global::System.Math.Abs(num));
				bool flag = true;
				string text;
				if (num2 > 10.0 || num2 < -9.0)
				{
					text = "E5";
				}
				else if ((double)((long)num) != num)
				{
					text = "F9";
				}
				else
				{
					text = "F0";
					flag = false;
				}
				toAppendTo.Append(num.ToString(text));
				if (flag)
				{
					int num3;
					if (text.StartsWith("E"))
					{
						num3 = toAppendTo.ToString().LastIndexOf("E") - 1;
					}
					else
					{
						num3 = toAppendTo.Length - 1;
					}
					while (toAppendTo[num3] == '0')
					{
						toAppendTo.Remove(num3--, 1);
					}
					if (toAppendTo[num3] == '.')
					{
						toAppendTo.Remove(num3--, 1);
					}
					string text2 = toAppendTo.ToString();
					num3 = toAppendTo.ToString().LastIndexOf("E");
					if (num3 > 0)
					{
						num3++;
						if (text2[num3] == '+' || text2[num3] == '-')
						{
							num3++;
						}
						int num4 = 0;
						while (num3 + num4 < text2.Length && text2[num3 + num4] == '0')
						{
							num4++;
						}
						toAppendTo.Remove(num3, num4);
						return;
					}
				}
			}
			else
			{
				if (value is bool)
				{
					toAppendTo.Append(value.ToString().ToUpper());
					return;
				}
				toAppendTo.Append(value.ToString());
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00028888 File Offset: 0x00026A88
		public override void SimpleValue(global::System.Text.StringBuilder toAppendTo, object value)
		{
			this.FormatValue(toAppendTo, value);
		}
	}
}
