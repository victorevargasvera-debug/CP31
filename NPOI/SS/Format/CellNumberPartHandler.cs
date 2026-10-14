using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace NPOI.SS.Format
{
	// Token: 0x02000241 RID: 577
	public class CellNumberPartHandler : global::NPOI.SS.Format.CellFormatPart.IPartHandler
	{
		// Token: 0x06000E0B RID: 3595 RVA: 0x00027F7C File Offset: 0x0002617C
		public string HandlePart(global::System.Text.RegularExpressions.Match m, string part, global::NPOI.SS.Format.CellFormatType type, global::System.Text.StringBuilder descBuf)
		{
			int num = descBuf.Length;
			char c = part[0];
			if (c <= '0')
			{
				if (c != '#')
				{
					if (c == '%')
					{
						this.scale *= 100.0;
						return part;
					}
					switch (c)
					{
					case '.':
						if (this.decimalPoint == null && this.specials.Count > 0)
						{
							this.decimalPoint = new global::NPOI.SS.Format.CellNumberFormatter.Special('.', num);
							this.specials.Add(this.decimalPoint);
							return part;
						}
						return part;
					case '/':
						if (this.slash == null && this.specials.Count > 0)
						{
							this.numerator = this.PreviousNumber();
							this.improperFraction |= (this.numerator == global::NPOI.SS.Format.CellNumberPartHandler.FirstDigit(this.specials));
							this.slash = new global::NPOI.SS.Format.CellNumberFormatter.Special('.', num);
							this.specials.Add(this.slash);
							return part;
						}
						return part;
					case '0':
						break;
					default:
						goto IL_1C4;
					}
				}
			}
			else if (c != '?')
			{
				if (c != 'E' && c != 'e')
				{
					goto IL_1C4;
				}
				if (this.exponent == null && this.specials.Count > 0)
				{
					this.exponent = new global::NPOI.SS.Format.CellNumberFormatter.Special('.', num);
					this.specials.Add(this.exponent);
					this.insertSignForExponent = part[1];
					return part.Substring(0, 1);
				}
				return part;
			}
			if (this.insertSignForExponent != '\0')
			{
				this.specials.Add(new global::NPOI.SS.Format.CellNumberFormatter.Special(this.insertSignForExponent, num));
				descBuf.Append(this.insertSignForExponent);
				this.insertSignForExponent = '\0';
				num++;
			}
			for (int i = 0; i < part.Length; i++)
			{
				char ch = part[i];
				this.specials.Add(new global::NPOI.SS.Format.CellNumberFormatter.Special(ch, num + i));
			}
			return part;
			IL_1C4:
			return null;
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x00028150 File Offset: 0x00026350
		public double Scale
		{
			get
			{
				return this.scale;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00028158 File Offset: 0x00026358
		public global::NPOI.SS.Format.CellNumberFormatter.Special DecimalPoint
		{
			get
			{
				return this.decimalPoint;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x00028160 File Offset: 0x00026360
		public global::NPOI.SS.Format.CellNumberFormatter.Special Slash
		{
			get
			{
				return this.slash;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00028168 File Offset: 0x00026368
		public global::NPOI.SS.Format.CellNumberFormatter.Special Exponent
		{
			get
			{
				return this.exponent;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x00028170 File Offset: 0x00026370
		public global::NPOI.SS.Format.CellNumberFormatter.Special Numerator
		{
			get
			{
				return this.numerator;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00028178 File Offset: 0x00026378
		public global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> Specials
		{
			get
			{
				return this.specials;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00028180 File Offset: 0x00026380
		public bool IsImproperFraction
		{
			get
			{
				return this.improperFraction;
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00028188 File Offset: 0x00026388
		private global::NPOI.SS.Format.CellNumberFormatter.Special PreviousNumber()
		{
			for (int i = this.specials.Count - 1; i >= 0; i--)
			{
				global::NPOI.SS.Format.CellNumberFormatter.Special special = this.specials[i];
				if (global::NPOI.SS.Format.CellNumberPartHandler.IsDigitFmt(special))
				{
					global::NPOI.SS.Format.CellNumberFormatter.Special special2 = special;
					while (i >= 0)
					{
						special = this.specials[i];
						if (special2.pos - special.pos > 1 || !global::NPOI.SS.Format.CellNumberPartHandler.IsDigitFmt(special))
						{
							break;
						}
						special2 = special;
						i--;
					}
					return special2;
				}
			}
			return null;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000281F8 File Offset: 0x000263F8
		private static bool IsDigitFmt(global::NPOI.SS.Format.CellNumberFormatter.Special s)
		{
			return s.ch == '0' || s.ch == '?' || s.ch == '#';
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0002821C File Offset: 0x0002641C
		private static global::NPOI.SS.Format.CellNumberFormatter.Special FirstDigit(global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> specials)
		{
			foreach (global::NPOI.SS.Format.CellNumberFormatter.Special special in specials)
			{
				if (global::NPOI.SS.Format.CellNumberPartHandler.IsDigitFmt(special))
				{
					return special;
				}
			}
			return null;
		}

		// Token: 0x0400063E RID: 1598
		private char insertSignForExponent;

		// Token: 0x0400063F RID: 1599
		private double scale = 1.0;

		// Token: 0x04000640 RID: 1600
		private global::NPOI.SS.Format.CellNumberFormatter.Special decimalPoint;

		// Token: 0x04000641 RID: 1601
		private global::NPOI.SS.Format.CellNumberFormatter.Special slash;

		// Token: 0x04000642 RID: 1602
		private global::NPOI.SS.Format.CellNumberFormatter.Special exponent;

		// Token: 0x04000643 RID: 1603
		private global::NPOI.SS.Format.CellNumberFormatter.Special numerator;

		// Token: 0x04000644 RID: 1604
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> specials = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>();

		// Token: 0x04000645 RID: 1605
		private bool improperFraction;
	}
}
