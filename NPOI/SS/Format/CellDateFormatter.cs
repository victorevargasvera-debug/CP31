using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Format
{
	// Token: 0x02000243 RID: 579
	public class CellDateFormatter : global::NPOI.SS.Format.CellFormatter
	{
		// Token: 0x06000E23 RID: 3619 RVA: 0x000283C4 File Offset: 0x000265C4
		static CellDateFormatter()
		{
			global::System.DateTime excel_EPOCH_DATE = new global::System.DateTime(1904, 1, 1);
			global::NPOI.SS.Format.CellDateFormatter.EXCEL_EPOCH_DATE = excel_EPOCH_DATE;
			global::NPOI.SS.Format.CellDateFormatter.EXCEL_EPOCH_TIME = excel_EPOCH_DATE.TimeOfDay;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00028400 File Offset: 0x00026600
		public CellDateFormatter(string format) : base(format)
		{
			global::NPOI.SS.Format.CellDateFormatter.DatePartHandler datePartHandler = new global::NPOI.SS.Format.CellDateFormatter.DatePartHandler(this);
			global::System.Text.StringBuilder stringBuilder = global::NPOI.SS.Format.CellFormatPart.ParseFormat(format, global::NPOI.SS.Format.CellFormatType.DATE, datePartHandler);
			datePartHandler.Finish(stringBuilder);
			this.dateFmt = new global::NPOI.SS.Util.SimpleDateFormat(stringBuilder.ToString());
			string pattern = global::System.Text.RegularExpressions.Regex.Replace(stringBuilder.ToString(), "((y)(?!y))(?<!yy)", "yy");
			this.dateFmt = new global::NPOI.SS.Util.SimpleDateFormat(pattern);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00028464 File Offset: 0x00026664
		public override void FormatValue(global::System.Text.StringBuilder toAppendTo, object value)
		{
			if (value == null)
			{
				value = 0.0;
			}
			if (global::NPOI.Util.Number.IsNumber(value))
			{
				double num;
				double.TryParse(value.ToString(), out num);
				if (num == 0.0)
				{
					value = global::NPOI.SS.Format.CellDateFormatter.EXCEL_EPOCH_DATE;
				}
				else
				{
					value = new global::System.DateTime((long)((double)global::NPOI.SS.Format.CellDateFormatter.EXCEL_EPOCH_TIME.Ticks + num));
				}
			}
			global::System.DateTime dateTime = (global::System.DateTime)value;
			if (this.millisecondPartLength > 0)
			{
				double num2 = (double)dateTime.Millisecond / 1000.0 * global::System.Math.Pow(10.0, (double)this.millisecondPartLength);
				num2 -= global::System.Math.Truncate(num2);
				if (num2 >= 0.5)
				{
					dateTime = dateTime.AddMilliseconds((1.0 - num2) / global::System.Math.Pow(10.0, (double)this.millisecondPartLength) * 1000.0);
				}
			}
			this.dateFmt.Format(dateTime, toAppendTo, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0002856A File Offset: 0x0002676A
		public override void SimpleValue(global::System.Text.StringBuilder toAppendTo, object value)
		{
			global::NPOI.SS.Format.CellDateFormatter.SIMPLE_DATE.FormatValue(toAppendTo, value);
		}

		// Token: 0x0400064F RID: 1615
		private bool amPmUpper;

		// Token: 0x04000650 RID: 1616
		private bool ShowM;

		// Token: 0x04000651 RID: 1617
		private bool ShowAmPm;

		// Token: 0x04000652 RID: 1618
		private global::NPOI.SS.Util.FormatBase dateFmt;

		// Token: 0x04000653 RID: 1619
		private string sFmt;

		// Token: 0x04000654 RID: 1620
		private int millisecondPartLength;

		// Token: 0x04000655 RID: 1621
		private static readonly global::System.TimeSpan EXCEL_EPOCH_TIME;

		// Token: 0x04000656 RID: 1622
		private static readonly global::System.DateTime EXCEL_EPOCH_DATE;

		// Token: 0x04000657 RID: 1623
		private static readonly global::NPOI.SS.Format.CellFormatter SIMPLE_DATE = new global::NPOI.SS.Format.CellDateFormatter("mm/d/y");

		// Token: 0x02000594 RID: 1428
		private class DatePartHandler : global::NPOI.SS.Format.CellFormatPart.IPartHandler
		{
			// Token: 0x06003453 RID: 13395 RVA: 0x000A2D2D File Offset: 0x000A0F2D
			public DatePartHandler(global::NPOI.SS.Format.CellDateFormatter formatter)
			{
				this._formatter = formatter;
			}

			// Token: 0x06003454 RID: 13396 RVA: 0x000A2D4C File Offset: 0x000A0F4C
			public string HandlePart(global::System.Text.RegularExpressions.Match m, string part, global::NPOI.SS.Format.CellFormatType type, global::System.Text.StringBuilder desc)
			{
				int length = desc.Length;
				char c = part[0];
				if (c > 'S')
				{
					if (c <= 'h')
					{
						if (c <= 'a')
						{
							if (c != 'Y')
							{
								if (c != 'a')
								{
									goto IL_255;
								}
								goto IL_1DC;
							}
						}
						else
						{
							if (c == 'd')
							{
								goto IL_11A;
							}
							if (c != 'h')
							{
								goto IL_255;
							}
							goto IL_F9;
						}
					}
					else if (c <= 'p')
					{
						if (c == 'm')
						{
							goto IL_128;
						}
						if (c != 'p')
						{
							goto IL_255;
						}
						goto IL_1DC;
					}
					else
					{
						if (c == 's')
						{
							goto IL_C0;
						}
						if (c != 'y')
						{
							goto IL_255;
						}
					}
					this.mStart = -1;
					if (part.Length == 3)
					{
						part = "yyyy";
					}
					return part.ToLower();
				}
				if (c <= 'D')
				{
					if (c == '0')
					{
						this.mStart = -1;
						int length2 = part.Length;
						this._formatter.sFmt = string.Concat(new string[]
						{
							"%0",
							(length2 + 2).ToString(),
							".",
							length2.ToString(),
							"f"
						});
						this._formatter.millisecondPartLength = length2;
						return part.Replace('0', 'f');
					}
					if (c == 'A')
					{
						goto IL_1DC;
					}
					if (c != 'D')
					{
						goto IL_255;
					}
					goto IL_11A;
				}
				else if (c <= 'M')
				{
					if (c == 'H')
					{
						goto IL_F9;
					}
					if (c != 'M')
					{
						goto IL_255;
					}
					goto IL_128;
				}
				else
				{
					if (c == 'P')
					{
						goto IL_1DC;
					}
					if (c != 'S')
					{
						goto IL_255;
					}
				}
				IL_C0:
				if (this.mStart >= 0)
				{
					for (int i = 0; i < this.mLen; i++)
					{
						desc[this.mStart + i] = 'm';
					}
					this.mStart = -1;
				}
				return part.ToLower();
				IL_F9:
				this.mStart = -1;
				this.hStart = length;
				this.hLen = part.Length;
				return part.ToLower();
				IL_11A:
				this.mStart = -1;
				return part.ToLower();
				IL_128:
				this.mStart = length;
				this.mLen = part.Length;
				if (this.hStart >= 0)
				{
					return part.ToLower();
				}
				return part.ToUpper();
				IL_1DC:
				if (part.Length <= 1)
				{
					return null;
				}
				this.mStart = -1;
				this._formatter.ShowAmPm = true;
				this._formatter.ShowM = (char.ToLower(part[1]) == 'm');
				this._formatter.amPmUpper = (this._formatter.ShowM || char.IsUpper(part[0]));
				if (this._formatter.ShowM)
				{
					return "tt";
				}
				return "t";
				IL_255:
				return null;
			}

			// Token: 0x06003455 RID: 13397 RVA: 0x000A2FB0 File Offset: 0x000A11B0
			public void Finish(global::System.Text.StringBuilder toAppendTo)
			{
				if (this.hStart >= 0 && !this._formatter.ShowAmPm)
				{
					for (int i = 0; i < this.hLen; i++)
					{
						toAppendTo[this.hStart + i] = 'H';
					}
				}
			}

			// Token: 0x04001908 RID: 6408
			private global::NPOI.SS.Format.CellDateFormatter _formatter;

			// Token: 0x04001909 RID: 6409
			private int mStart = -1;

			// Token: 0x0400190A RID: 6410
			private int mLen;

			// Token: 0x0400190B RID: 6411
			private int hStart = -1;

			// Token: 0x0400190C RID: 6412
			private int hLen;
		}
	}
}
