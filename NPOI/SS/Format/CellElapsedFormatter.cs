using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NPOI.SS.Format
{
	// Token: 0x02000244 RID: 580
	public class CellElapsedFormatter : global::NPOI.SS.Format.CellFormatter
	{
		// Token: 0x06000E27 RID: 3623 RVA: 0x00028578 File Offset: 0x00026778
		public CellElapsedFormatter(string pattern) : base(pattern)
		{
			this.specs = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellElapsedFormatter.TimeSpec>();
			global::System.Text.StringBuilder stringBuilder = global::NPOI.SS.Format.CellFormatPart.ParseFormat(pattern, global::NPOI.SS.Format.CellFormatType.ELAPSED, new global::NPOI.SS.Format.CellElapsedFormatter.ElapsedPartHandler(this));
			for (int i = this.specs.Count - 1; i >= 0; i--)
			{
				global::NPOI.SS.Format.CellElapsedFormatter.TimeSpec timeSpec = this.specs[i];
				stringBuilder.Remove(timeSpec.pos, timeSpec.len);
				stringBuilder.Insert(timeSpec.pos, "D" + timeSpec.len.ToString());
				if (timeSpec.type != this.topmost.type)
				{
					timeSpec.modBy = global::NPOI.SS.Format.CellElapsedFormatter.modFor(timeSpec.type, timeSpec.len);
				}
			}
			this.printfFmt = stringBuilder.ToString();
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0002863C File Offset: 0x0002683C
		private global::NPOI.SS.Format.CellElapsedFormatter.TimeSpec AssignSpec(char type, int pos, int len)
		{
			global::NPOI.SS.Format.CellElapsedFormatter.TimeSpec timeSpec = new global::NPOI.SS.Format.CellElapsedFormatter.TimeSpec(type, pos, len, global::NPOI.SS.Format.CellElapsedFormatter.factorFor(type, len));
			this.specs.Add(timeSpec);
			return timeSpec;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00028668 File Offset: 0x00026868
		private static double factorFor(char type, int len)
		{
			if (type <= 'h')
			{
				if (type == '0')
				{
					return 1.1574074074074073E-05 / global::System.Math.Pow(10.0, (double)len);
				}
				if (type == 'h')
				{
					return 0.041666666666666664;
				}
			}
			else
			{
				if (type == 'm')
				{
					return 0.0006944444444444444;
				}
				if (type == 's')
				{
					return 1.1574074074074073E-05;
				}
			}
			throw new global::System.ArgumentException("Uknown elapsed time spec: " + type.ToString());
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000286E4 File Offset: 0x000268E4
		private static double modFor(char type, int len)
		{
			if (type <= 'h')
			{
				if (type == '0')
				{
					return global::System.Math.Pow(10.0, (double)len);
				}
				if (type == 'h')
				{
					return 24.0;
				}
			}
			else
			{
				if (type == 'm')
				{
					return 60.0;
				}
				if (type == 's')
				{
					return 60.0;
				}
			}
			throw new global::System.ArgumentException("Uknown elapsed time spec: " + type.ToString());
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00028754 File Offset: 0x00026954
		public override void FormatValue(global::System.Text.StringBuilder toAppendTo, object value)
		{
			double num = (double)value;
			if (num < 0.0)
			{
				toAppendTo.Append('-');
				num = -num;
			}
			long[] array = new long[this.specs.Count];
			for (int i = 0; i < this.specs.Count; i++)
			{
				array[i] = this.specs[i].ValueFor(num);
			}
			string[] array2 = this.printfFmt.Split(":. []".ToCharArray());
			string value2 = string.Empty;
			int num2 = 0;
			int num3 = 0;
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("D\\d+");
			foreach (string text in array2)
			{
				num2 += text.Length;
				if (num2 < this.printfFmt.Length)
				{
					value2 = this.printfFmt[num2].ToString();
					num2++;
				}
				else
				{
					value2 = string.Empty;
				}
				if (regex.IsMatch(text))
				{
					toAppendTo.Append(array[num3].ToString(text)).Append(value2);
					num3++;
				}
				else
				{
					toAppendTo.Append(text).Append(value2);
				}
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00028888 File Offset: 0x00026A88
		public override void SimpleValue(global::System.Text.StringBuilder toAppendTo, object value)
		{
			this.FormatValue(toAppendTo, value);
		}

		// Token: 0x04000658 RID: 1624
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellElapsedFormatter.TimeSpec> specs;

		// Token: 0x04000659 RID: 1625
		private global::NPOI.SS.Format.CellElapsedFormatter.TimeSpec topmost;

		// Token: 0x0400065A RID: 1626
		private string printfFmt;

		// Token: 0x0400065B RID: 1627
		private static readonly global::System.Text.RegularExpressions.Regex PERCENTS = new global::System.Text.RegularExpressions.Regex("%", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x0400065C RID: 1628
		private const double HOUR__FACTOR = 0.041666666666666664;

		// Token: 0x0400065D RID: 1629
		private const double MIN__FACTOR = 0.0006944444444444444;

		// Token: 0x0400065E RID: 1630
		private const double SEC__FACTOR = 1.1574074074074073E-05;

		// Token: 0x02000595 RID: 1429
		private class TimeSpec
		{
			// Token: 0x06003456 RID: 13398 RVA: 0x000A2FF4 File Offset: 0x000A11F4
			public TimeSpec(char type, int pos, int len, double factor)
			{
				this.type = type;
				this.pos = pos;
				this.len = len;
				this.factor = factor;
				this.modBy = 0.0;
			}

			// Token: 0x06003457 RID: 13399 RVA: 0x000A3028 File Offset: 0x000A1228
			public long ValueFor(double elapsed)
			{
				double num;
				if (this.modBy == 0.0)
				{
					num = elapsed / this.factor;
				}
				else
				{
					num = elapsed / this.factor % this.modBy;
				}
				if (this.type == '0')
				{
					return (long)global::System.Math.Round(num);
				}
				return (long)num;
			}

			// Token: 0x0400190D RID: 6413
			internal char type;

			// Token: 0x0400190E RID: 6414
			internal int pos;

			// Token: 0x0400190F RID: 6415
			internal int len;

			// Token: 0x04001910 RID: 6416
			internal double factor;

			// Token: 0x04001911 RID: 6417
			internal double modBy;
		}

		// Token: 0x02000596 RID: 1430
		private class ElapsedPartHandler : global::NPOI.SS.Format.CellFormatPart.IPartHandler
		{
			// Token: 0x06003458 RID: 13400 RVA: 0x000A3075 File Offset: 0x000A1275
			public ElapsedPartHandler(global::NPOI.SS.Format.CellElapsedFormatter formatter)
			{
				this._formatter = formatter;
			}

			// Token: 0x06003459 RID: 13401 RVA: 0x000A3084 File Offset: 0x000A1284
			public string HandlePart(global::System.Text.RegularExpressions.Match m, string part, global::NPOI.SS.Format.CellFormatType type, global::System.Text.StringBuilder desc)
			{
				int length = desc.Length;
				char c = part[0];
				if (c <= '0')
				{
					if (c <= '"')
					{
						if (c == '\n')
						{
							return "%n";
						}
						if (c != '"')
						{
							return part;
						}
						return part.Substring(1, part.Length - 2);
					}
					else if (c != '*')
					{
						if (c != '0')
						{
							return part;
						}
					}
					else
					{
						if (part.Length > 1)
						{
							return global::NPOI.SS.Format.CellFormatPart.ExpandChar(part);
						}
						return part;
					}
				}
				else if (c <= 'h')
				{
					switch (c)
					{
					case '[':
					{
						if (part.Length < 3)
						{
							return part;
						}
						if (this._formatter.topmost != null)
						{
							throw new global::System.ArgumentException("Duplicate '[' times in format");
						}
						part = part.ToLower();
						int num = part.Length - 2;
						this._formatter.topmost = this._formatter.AssignSpec(part[1], length, num);
						return part.Substring(1, num);
					}
					case '\\':
						return part.Substring(1);
					case ']':
					case '^':
						return part;
					case '_':
						return null;
					default:
						if (c != 'h')
						{
							return part;
						}
						break;
					}
				}
				else if (c != 'm' && c != 's')
				{
					return part;
				}
				part = part.ToLower();
				this._formatter.AssignSpec(part[0], length, part.Length);
				return part;
			}

			// Token: 0x04001912 RID: 6418
			private global::NPOI.SS.Format.CellElapsedFormatter _formatter;
		}
	}
}
