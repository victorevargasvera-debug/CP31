using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Format
{
	// Token: 0x02000251 RID: 593
	public class CellNumberFormatter : global::NPOI.SS.Format.CellFormatter
	{
		// Token: 0x06000E74 RID: 3700 RVA: 0x00029EA4 File Offset: 0x000280A4
		public CellNumberFormatter(string format) : base(format)
		{
			global::NPOI.SS.Format.CellNumberPartHandler cellNumberPartHandler = new global::NPOI.SS.Format.CellNumberPartHandler();
			global::System.Text.StringBuilder stringBuilder = global::NPOI.SS.Format.CellFormatPart.ParseFormat(format, global::NPOI.SS.Format.CellFormatType.NUMBER, cellNumberPartHandler);
			this.exponent = cellNumberPartHandler.Exponent;
			this.specials.AddRange(cellNumberPartHandler.Specials);
			this.improperFraction = cellNumberPartHandler.IsImproperFraction;
			if ((cellNumberPartHandler.DecimalPoint != null || cellNumberPartHandler.Exponent != null) && cellNumberPartHandler.Slash != null)
			{
				this.slash = null;
				this.numerator = null;
			}
			else
			{
				this.slash = cellNumberPartHandler.Slash;
				this.numerator = cellNumberPartHandler.Numerator;
			}
			int num = global::NPOI.SS.Format.CellNumberFormatter.interpretPrecision(cellNumberPartHandler.DecimalPoint, this.specials);
			if (cellNumberPartHandler.DecimalPoint != null)
			{
				if (num == 0)
				{
					this.specials.Remove(cellNumberPartHandler.DecimalPoint);
					this.decimalPoint = null;
				}
				else
				{
					this.decimalPoint = cellNumberPartHandler.DecimalPoint;
				}
			}
			else
			{
				this.decimalPoint = null;
			}
			if (this.decimalPoint != null)
			{
				this.afterInteger = this.decimalPoint;
			}
			else if (this.exponent != null)
			{
				this.afterInteger = this.exponent;
			}
			else if (this.numerator != null)
			{
				this.afterInteger = this.numerator;
			}
			else
			{
				this.afterInteger = null;
			}
			if (this.exponent != null)
			{
				this.afterFractional = this.exponent;
			}
			else if (this.numerator != null)
			{
				this.afterFractional = this.numerator;
			}
			else
			{
				this.afterFractional = null;
			}
			double[] array = new double[]
			{
				cellNumberPartHandler.Scale
			};
			this.integerCommas = global::NPOI.SS.Format.CellNumberFormatter.interpretIntegerCommas(stringBuilder, this.specials, this.decimalPoint, this.integerEnd(), this.fractionalEnd(), array);
			if (this.exponent == null)
			{
				this.scale = array[0];
			}
			else
			{
				this.scale = 1.0;
			}
			if (num != 0)
			{
				int num2 = this.specials.IndexOf(this.decimalPoint) + 1;
				this.fractionalSpecials.AddRange(this.specials.GetRange(num2, this.fractionalEnd() - num2));
			}
			if (this.exponent != null)
			{
				int num3 = this.specials.IndexOf(this.exponent);
				this.exponentSpecials.AddRange(this.specialsFor(num3, 2));
				this.exponentDigitSpecials.AddRange(this.specialsFor(num3 + 2));
			}
			if (this.slash != null)
			{
				if (this.numerator != null)
				{
					this.numeratorSpecials.AddRange(this.specialsFor(this.specials.IndexOf(this.numerator)));
				}
				this.denominatorSpecials.AddRange(this.specialsFor(this.specials.IndexOf(this.slash) + 1));
				if (this.denominatorSpecials.Count == 0)
				{
					this.numeratorSpecials.Clear();
					this.maxDenominator = 1;
					this.numeratorFmt = null;
					this.denominatorFmt = null;
				}
				else
				{
					this.maxDenominator = global::NPOI.SS.Format.CellNumberFormatter.maxValue(this.denominatorSpecials);
					this.numeratorFmt = global::NPOI.SS.Format.CellNumberFormatter.SingleNumberFormat(this.numeratorSpecials);
					this.denominatorFmt = global::NPOI.SS.Format.CellNumberFormatter.SingleNumberFormat(this.denominatorSpecials);
				}
			}
			else
			{
				this.maxDenominator = 1;
				this.numeratorFmt = null;
				this.denominatorFmt = null;
			}
			this.integerSpecials.AddRange(this.specials.GetRange(0, this.integerEnd()));
			if (this.exponent == null)
			{
				global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
				int repeatCount = this.calculateintPartWidth();
				stringBuilder2.Append('0', repeatCount).Append('.').Append('0', num);
				this.printfFmt = stringBuilder2.ToString();
				this.decimalFmt = null;
			}
			else
			{
				global::System.Text.StringBuilder stringBuilder3 = new global::System.Text.StringBuilder();
				bool flag = true;
				global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> list = this.integerSpecials;
				if (this.integerSpecials.Count == 1)
				{
					stringBuilder3.Append("0");
					flag = false;
				}
				else
				{
					using (global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (global::NPOI.SS.Format.CellNumberFormatter.IsDigitFmt(enumerator.Current))
							{
								stringBuilder3.Append(flag ? '#' : '0');
								flag = false;
							}
						}
					}
				}
				if (this.fractionalSpecials.Count > 0)
				{
					stringBuilder3.Append('.');
					using (global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>.Enumerator enumerator = this.fractionalSpecials.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (global::NPOI.SS.Format.CellNumberFormatter.IsDigitFmt(enumerator.Current))
							{
								if (!flag)
								{
									stringBuilder3.Append('0');
								}
								flag = false;
							}
						}
					}
				}
				stringBuilder3.Append('E');
				global::NPOI.SS.Format.CellNumberFormatter.placeZeros(stringBuilder3, this.exponentSpecials.GetRange(2, this.exponentSpecials.Count - 2));
				this.decimalFmt = new global::NPOI.SS.Util.DecimalFormat(stringBuilder3.ToString());
				this.printfFmt = null;
			}
			this.desc = stringBuilder.ToString();
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0002A39C File Offset: 0x0002859C
		private static void placeZeros(global::System.Text.StringBuilder sb, global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> specials)
		{
			using (global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>.Enumerator enumerator = specials.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (global::NPOI.SS.Format.CellNumberFormatter.IsDigitFmt(enumerator.Current))
					{
						sb.Append('0');
					}
				}
			}
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0002A3F4 File Offset: 0x000285F4
		private static global::NPOI.SS.Format.CellNumberFormatter.Special firstDigit(global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> specials)
		{
			foreach (global::NPOI.SS.Format.CellNumberFormatter.Special special in specials)
			{
				if (global::NPOI.SS.Format.CellNumberFormatter.IsDigitFmt(special))
				{
					return special;
				}
			}
			return null;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0002A44C File Offset: 0x0002864C
		private static global::NPOI.SS.Format.CellNumberStringMod insertMod(global::NPOI.SS.Format.CellNumberFormatter.Special special, string toAdd, int where)
		{
			return new global::NPOI.SS.Format.CellNumberStringMod(special, toAdd, where);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0002A456 File Offset: 0x00028656
		private static global::NPOI.SS.Format.CellNumberStringMod deleteMod(global::NPOI.SS.Format.CellNumberFormatter.Special start, bool startInclusive, global::NPOI.SS.Format.CellNumberFormatter.Special end, bool endInclusive)
		{
			return new global::NPOI.SS.Format.CellNumberStringMod(start, startInclusive, end, endInclusive);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0002A461 File Offset: 0x00028661
		private static global::NPOI.SS.Format.CellNumberStringMod ReplaceMod(global::NPOI.SS.Format.CellNumberFormatter.Special start, bool startInclusive, global::NPOI.SS.Format.CellNumberFormatter.Special end, bool endInclusive, char withChar)
		{
			return new global::NPOI.SS.Format.CellNumberStringMod(start, startInclusive, end, endInclusive, withChar);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0002A470 File Offset: 0x00028670
		private static string SingleNumberFormat(global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> numSpecials)
		{
			return "D" + numSpecials.Count.ToString();
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0002A495 File Offset: 0x00028695
		private static int maxValue(global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> s)
		{
			return (int)global::System.Math.Round(global::System.Math.Pow(10.0, (double)s.Count) - 1.0);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0002A4BC File Offset: 0x000286BC
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> specialsFor(int pos, int takeFirst)
		{
			if (pos >= this.specials.Count)
			{
				return global::NPOI.SS.Format.CellNumberFormatter.EmptySpecialList;
			}
			global::System.Collections.Generic.IEnumerator<global::NPOI.SS.Format.CellNumberFormatter.Special> enumerator = this.specials.GetRange(pos + takeFirst, this.specials.Count - pos - takeFirst).GetEnumerator();
			enumerator.MoveNext();
			global::NPOI.SS.Format.CellNumberFormatter.Special special = enumerator.Current;
			int num = pos + takeFirst;
			while (enumerator.MoveNext())
			{
				global::NPOI.SS.Format.CellNumberFormatter.Special special2 = enumerator.Current;
				if (!global::NPOI.SS.Format.CellNumberFormatter.IsDigitFmt(special2) || special2.pos - special.pos > 1)
				{
					break;
				}
				num++;
				special = special2;
			}
			return this.specials.GetRange(pos, num + 1 - pos);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0002A557 File Offset: 0x00028757
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> specialsFor(int pos)
		{
			return this.specialsFor(pos, 0);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x000281F8 File Offset: 0x000263F8
		private static bool IsDigitFmt(global::NPOI.SS.Format.CellNumberFormatter.Special s)
		{
			return s.ch == '0' || s.ch == '?' || s.ch == '#';
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0002A564 File Offset: 0x00028764
		private int calculateintPartWidth()
		{
			int num = 0;
			foreach (global::NPOI.SS.Format.CellNumberFormatter.Special special in this.specials)
			{
				if (special == this.afterInteger)
				{
					break;
				}
				if (global::NPOI.SS.Format.CellNumberFormatter.IsDigitFmt(special))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0002A5CC File Offset: 0x000287CC
		private static int interpretPrecision(global::NPOI.SS.Format.CellNumberFormatter.Special decimalPoint, global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> specials)
		{
			int num = specials.IndexOf(decimalPoint);
			int num2 = 0;
			if (num != -1)
			{
				global::System.Collections.Generic.IEnumerator<global::NPOI.SS.Format.CellNumberFormatter.Special> enumerator = specials.GetRange(num + 1, specials.Count - num - 1).GetEnumerator();
				while (enumerator.MoveNext() && global::NPOI.SS.Format.CellNumberFormatter.IsDigitFmt(enumerator.Current))
				{
					num2++;
				}
			}
			return num2;
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0002A624 File Offset: 0x00028824
		private static bool interpretIntegerCommas(global::System.Text.StringBuilder sb, global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> specials, global::NPOI.SS.Format.CellNumberFormatter.Special decimalPoint, int integerEnd, int fractionalEnd, double[] scale)
		{
			global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> range = specials.GetRange(0, integerEnd);
			bool flag = true;
			bool result = false;
			for (int i = range.Count - 1; i >= 0; i--)
			{
				if (range[i].ch != ',')
				{
					flag = false;
				}
				else if (flag)
				{
					scale[0] /= 1000.0;
				}
				else
				{
					result = true;
				}
			}
			if (decimalPoint != null)
			{
				range = specials.GetRange(0, fractionalEnd);
				int num = range.Count - 1;
				while (num >= 0 && range[num].ch == ',')
				{
					scale[0] /= 1000.0;
					num--;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::NPOI.SS.Format.CellNumberFormatter.Special> enumerator = specials.GetEnumerator();
			int num2 = 0;
			global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> list = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>();
			while (enumerator.MoveNext())
			{
				global::NPOI.SS.Format.CellNumberFormatter.Special special = enumerator.Current;
				special.pos -= num2;
				if (special.ch == ',')
				{
					num2++;
					list.Add(special);
					sb.Remove(special.pos, 1);
				}
			}
			foreach (global::NPOI.SS.Format.CellNumberFormatter.Special item in list)
			{
				specials.Remove(item);
			}
			return result;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0002A778 File Offset: 0x00028978
		private int integerEnd()
		{
			if (this.afterInteger != null)
			{
				return this.specials.IndexOf(this.afterInteger);
			}
			return this.specials.Count;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0002A79F File Offset: 0x0002899F
		private int fractionalEnd()
		{
			if (this.afterFractional != null)
			{
				return this.specials.IndexOf(this.afterFractional);
			}
			return this.specials.Count;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0002A7C8 File Offset: 0x000289C8
		public override void FormatValue(global::System.Text.StringBuilder toAppendTo, object valueObject)
		{
			double num = (double)valueObject;
			num *= this.scale;
			bool flag = num < 0.0;
			if (flag)
			{
				num = -num;
			}
			double fractional = 0.0;
			if (this.slash != null)
			{
				if (this.improperFraction)
				{
					fractional = num;
					num = 0.0;
				}
				else
				{
					fractional = num % 1.0;
					num = (double)((long)num);
				}
			}
			global::System.Collections.Generic.SortedList<global::NPOI.SS.Format.CellNumberStringMod, object> sortedList = new global::System.Collections.Generic.SortedList<global::NPOI.SS.Format.CellNumberStringMod, object>();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(this.desc);
			if (this.exponent != null)
			{
				this.WriteScientific(num, stringBuilder, sortedList);
			}
			else if (this.improperFraction)
			{
				this.WriteFraction(num, null, fractional, stringBuilder, sortedList);
			}
			else
			{
				global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
				stringBuilder2.Append(num.ToString(this.printfFmt));
				if (this.numerator == null)
				{
					this.WriteFractional(stringBuilder2, stringBuilder);
					this.Writeint(stringBuilder2, stringBuilder, this.integerSpecials, sortedList, this.integerCommas);
				}
				else
				{
					this.WriteFraction(num, stringBuilder2, fractional, stringBuilder, sortedList);
				}
			}
			this.specials.GetEnumerator();
			global::System.Collections.IEnumerator enumerator = sortedList.Keys.GetEnumerator();
			global::NPOI.SS.Format.CellNumberStringMod cellNumberStringMod = enumerator.MoveNext() ? ((global::NPOI.SS.Format.CellNumberStringMod)enumerator.Current) : null;
			int num2 = 0;
			global::System.Collections.BitArray bitArray = new global::System.Collections.BitArray(1024);
			foreach (global::NPOI.SS.Format.CellNumberFormatter.Special special in this.specials)
			{
				int num3 = special.pos + num2;
				if (!bitArray[special.pos] && stringBuilder[num3] == '#')
				{
					stringBuilder.Remove(num3, 1);
					num2--;
					bitArray.Set(special.pos, true);
				}
				while (cellNumberStringMod != null && special == cellNumberStringMod.GetSpecial())
				{
					int length = stringBuilder.Length;
					int num4 = special.pos + num2;
					switch (cellNumberStringMod.Op)
					{
					case 1:
						stringBuilder.Insert(num4, cellNumberStringMod.ToAdd);
						break;
					case 2:
						if (!cellNumberStringMod.ToAdd.Equals(",") || !bitArray.Get(special.pos))
						{
							stringBuilder.Insert(num4 + 1, cellNumberStringMod.ToAdd);
						}
						break;
					case 3:
					{
						int num5 = special.pos;
						if (!cellNumberStringMod.IsStartInclusive)
						{
							num5++;
							num4++;
						}
						while (bitArray.Get(num5))
						{
							num5++;
							num4++;
						}
						int num6 = cellNumberStringMod.End.pos;
						if (cellNumberStringMod.IsEndInclusive)
						{
							num6++;
						}
						int num7 = num6 + num2;
						if (num4 < num7)
						{
							if (cellNumberStringMod.ToAdd == "")
							{
								stringBuilder.Remove(num4, num7 - num4);
							}
							else
							{
								char value = cellNumberStringMod.ToAdd[0];
								for (int i = num4; i < num7; i++)
								{
									stringBuilder[i] = value;
								}
							}
							for (int j = num5; j < num6; j++)
							{
								bitArray.Set(j, true);
							}
						}
						break;
					}
					default:
						throw new global::System.InvalidOperationException("Unknown op: " + cellNumberStringMod.Op.ToString());
					}
					num2 += stringBuilder.Length - length;
					if (enumerator.MoveNext())
					{
						cellNumberStringMod = (global::NPOI.SS.Format.CellNumberStringMod)enumerator.Current;
					}
					else
					{
						cellNumberStringMod = null;
					}
				}
			}
			if (flag)
			{
				toAppendTo.Append('-');
			}
			toAppendTo.Append(stringBuilder);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0002AB7C File Offset: 0x00028D7C
		private void WriteScientific(double value, global::System.Text.StringBuilder output, global::System.Collections.Generic.SortedList<global::NPOI.SS.Format.CellNumberStringMod, object> mods)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string text = this.decimalFmt.Pattern;
			int num = 0;
			while (text[num] == '#' || text[num] == '0')
			{
				num++;
			}
			int num2 = num;
			if (text[0] == '#')
			{
				num2--;
			}
			if (num2 >= 6 && value > 1.0)
			{
				text = text.Substring(1);
				stringBuilder.Append(value.ToString(text));
			}
			else
			{
				stringBuilder.Append(value.ToString("E"));
			}
			this.Writeint(stringBuilder, output, this.integerSpecials, mods, this.integerCommas);
			this.WriteFractional(stringBuilder, output);
			string text2 = stringBuilder.ToString();
			int num3 = text2.IndexOf("E");
			int num4 = num3 + 1;
			char c = stringBuilder[num4];
			if (c != '-')
			{
				c = '+';
				if (text2.IndexOf(c, num3) < 0)
				{
					stringBuilder.Insert(num4, '+');
				}
			}
			object obj = this.exponentSpecials.GetEnumerator();
			((global::System.Collections.IEnumerator)obj).MoveNext();
			((global::System.Collections.IEnumerator)obj).MoveNext();
			global::NPOI.SS.Format.CellNumberFormatter.Special special = ((global::System.Collections.Generic.IEnumerator<global::NPOI.SS.Format.CellNumberFormatter.Special>)obj).Current;
			char ch = special.ch;
			if (c == '-' || ch == '+')
			{
				mods.Add(global::NPOI.SS.Format.CellNumberFormatter.ReplaceMod(special, true, special, true, c), null);
			}
			else
			{
				mods.Add(global::NPOI.SS.Format.CellNumberFormatter.deleteMod(special, true, special, true), null);
			}
			global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder(stringBuilder.ToString().Substring(num4 + 1));
			if (stringBuilder2.Length > 2 && stringBuilder2[0] == '0')
			{
				stringBuilder2.Remove(0, 1);
			}
			this.Writeint(stringBuilder2, output, this.exponentDigitSpecials, mods, false);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0002AD18 File Offset: 0x00028F18
		private void WriteFraction(double value, global::System.Text.StringBuilder result, double fractional, global::System.Text.StringBuilder output, global::System.Collections.Generic.SortedList<global::NPOI.SS.Format.CellNumberStringMod, object> mods)
		{
			if (!this.improperFraction)
			{
				if (fractional == 0.0 && !global::NPOI.SS.Format.CellNumberFormatter.HasChar('0', new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>[]
				{
					this.numeratorSpecials
				}))
				{
					this.Writeint(result, output, this.integerSpecials, mods, false);
					global::NPOI.SS.Format.CellNumberFormatter.Special start = global::NPOI.SS.Format.CellNumberFormatter.lastSpecial(this.integerSpecials);
					global::NPOI.SS.Format.CellNumberFormatter.Special end = global::NPOI.SS.Format.CellNumberFormatter.lastSpecial(this.denominatorSpecials);
					if (global::NPOI.SS.Format.CellNumberFormatter.HasChar('?', new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>[]
					{
						this.integerSpecials,
						this.numeratorSpecials,
						this.denominatorSpecials
					}))
					{
						mods.Add(global::NPOI.SS.Format.CellNumberFormatter.ReplaceMod(start, false, end, true, ' '), null);
						return;
					}
					mods.Add(global::NPOI.SS.Format.CellNumberFormatter.deleteMod(start, false, end, true), null);
					return;
				}
				else
				{
					bool flag = !global::NPOI.SS.Format.CellNumberFormatter.HasChar('0', new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>[]
					{
						this.numeratorSpecials
					});
					bool flag2 = !global::NPOI.SS.Format.CellNumberFormatter.HasChar('0', new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>[]
					{
						this.integerSpecials
					});
					bool flag3 = this.integerSpecials.Count == 0 || (this.integerSpecials.Count == 1 && global::NPOI.SS.Format.CellNumberFormatter.HasChar('#', new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>[]
					{
						this.integerSpecials
					}));
					bool flag4 = fractional == 0.0 && (flag3 || flag);
					bool flag5 = fractional != 0.0 && flag2;
					if (value == 0.0 && (flag4 || flag5))
					{
						global::NPOI.SS.Format.CellNumberFormatter.Special start2 = global::NPOI.SS.Format.CellNumberFormatter.lastSpecial(this.integerSpecials);
						global::NPOI.SS.Format.CellNumberStringMod key = global::NPOI.SS.Format.CellNumberFormatter.HasChar('?', new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>[]
						{
							this.integerSpecials,
							this.numeratorSpecials
						}) ? global::NPOI.SS.Format.CellNumberFormatter.ReplaceMod(start2, true, this.numerator, false, ' ') : global::NPOI.SS.Format.CellNumberFormatter.deleteMod(start2, true, this.numerator, false);
						mods.Add(key, null);
					}
					else
					{
						this.Writeint(result, output, this.integerSpecials, mods, false);
					}
				}
			}
			try
			{
				int num;
				int num2;
				if (fractional == 0.0 || (this.improperFraction && fractional % 1.0 == 0.0))
				{
					num = (int)global::System.Math.Round(fractional);
					num2 = 1;
				}
				else
				{
					global::NPOI.SS.Format.SimpleFraction simpleFraction = global::NPOI.SS.Format.SimpleFraction.BuildFractionMaxDenominator(fractional, this.maxDenominator);
					num = simpleFraction.Numerator;
					num2 = simpleFraction.Denominator;
				}
				if (this.improperFraction)
				{
					num += (int)global::System.Math.Round(value * (double)num2);
				}
				this.WriteSingleint(this.numeratorFmt, num, output, this.numeratorSpecials, mods);
				this.WriteSingleint(this.denominatorFmt, num2, output, this.denominatorSpecials, mods);
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine(ex.StackTrace);
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0002AFA4 File Offset: 0x000291A4
		private static bool HasChar(char ch, params global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>[] numSpecials)
		{
			for (int i = 0; i < numSpecials.Length; i++)
			{
				using (global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>.Enumerator enumerator = numSpecials[i].GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.ch == ch)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0002B00C File Offset: 0x0002920C
		private void WriteSingleint(string fmt, int num, global::System.Text.StringBuilder output, global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> numSpecials, global::System.Collections.Generic.SortedList<global::NPOI.SS.Format.CellNumberStringMod, object> mods)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(num.ToString(fmt));
			this.Writeint(stringBuilder, output, numSpecials, mods, false);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0002B03C File Offset: 0x0002923C
		private void Writeint(global::System.Text.StringBuilder result, global::System.Text.StringBuilder output, global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> numSpecials, global::System.Collections.Generic.SortedList<global::NPOI.SS.Format.CellNumberStringMod, object> mods, bool ShowCommas)
		{
			int i = result.ToString().IndexOf(".") - 1;
			if (i < 0)
			{
				if (this.exponent != null && numSpecials == this.integerSpecials)
				{
					i = result.ToString().IndexOf("E") - 1;
				}
				else
				{
					i = result.Length - 1;
				}
			}
			int j;
			for (j = 0; j < i; j++)
			{
				char c = result[j];
				if (c != '0' && c != ',')
				{
					break;
				}
			}
			global::NPOI.SS.Format.CellNumberFormatter.Special special = null;
			int num = 0;
			for (int k = numSpecials.Count - 1; k >= 0; k--)
			{
				char c2;
				if (i >= 0)
				{
					c2 = result[i];
				}
				else
				{
					c2 = '0';
				}
				global::NPOI.SS.Format.CellNumberFormatter.Special special2 = numSpecials[k];
				bool flag = ShowCommas && num > 0 && num % 3 == 0;
				bool flag2 = false;
				if (c2 != '0' || special2.ch == '0' || special2.ch == '?' || i >= j)
				{
					flag2 = (special2.ch == '?' && i < j);
					output[special2.pos] = (flag2 ? ' ' : c2);
					special = special2;
				}
				if (flag)
				{
					mods.Add(global::NPOI.SS.Format.CellNumberFormatter.insertMod(special2, flag2 ? " " : ",", 2), null);
				}
				num++;
				i--;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (i >= 0)
			{
				i++;
				stringBuilder = new global::System.Text.StringBuilder(result.ToString().Substring(0, i));
				if (ShowCommas)
				{
					while (i > 0)
					{
						if (num > 0 && num % 3 == 0)
						{
							stringBuilder.Insert(i, ',');
						}
						num++;
						i--;
					}
				}
				mods.Add(global::NPOI.SS.Format.CellNumberFormatter.insertMod(special, stringBuilder.ToString(), 1), null);
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0002B1DC File Offset: 0x000293DC
		private void WriteFractional(global::System.Text.StringBuilder result, global::System.Text.StringBuilder output)
		{
			if (this.fractionalSpecials.Count > 0)
			{
				int num = result.ToString().IndexOf(".") + 1;
				int num2;
				if (this.exponent != null)
				{
					num2 = result.ToString().IndexOf("E") - 1;
				}
				else
				{
					num2 = result.Length - 1;
				}
				while (num2 > num && result[num2] == '0')
				{
					num2--;
				}
				foreach (global::NPOI.SS.Format.CellNumberFormatter.Special special in this.fractionalSpecials)
				{
					if (num >= result.Length)
					{
						break;
					}
					char c = result[num];
					if (c != '0' || special.ch == '0' || num < num2)
					{
						output[special.pos] = c;
					}
					else if (special.ch == '?')
					{
						output[special.pos] = ' ';
					}
					num++;
				}
			}
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0002B2DC File Offset: 0x000294DC
		public override void SimpleValue(global::System.Text.StringBuilder toAppendTo, object value)
		{
			global::NPOI.SS.Format.CellNumberFormatter.SIMPLE_NUMBER.FormatValue(toAppendTo, value);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0002B2EA File Offset: 0x000294EA
		private static global::NPOI.SS.Format.CellNumberFormatter.Special lastSpecial(global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> s)
		{
			return s[s.Count - 1];
		}

		// Token: 0x0400068B RID: 1675
		private string desc;

		// Token: 0x0400068C RID: 1676
		private string printfFmt;

		// Token: 0x0400068D RID: 1677
		private double scale;

		// Token: 0x0400068E RID: 1678
		private global::NPOI.SS.Format.CellNumberFormatter.Special decimalPoint;

		// Token: 0x0400068F RID: 1679
		private global::NPOI.SS.Format.CellNumberFormatter.Special slash;

		// Token: 0x04000690 RID: 1680
		private global::NPOI.SS.Format.CellNumberFormatter.Special exponent;

		// Token: 0x04000691 RID: 1681
		private global::NPOI.SS.Format.CellNumberFormatter.Special numerator;

		// Token: 0x04000692 RID: 1682
		private global::NPOI.SS.Format.CellNumberFormatter.Special afterInteger;

		// Token: 0x04000693 RID: 1683
		private global::NPOI.SS.Format.CellNumberFormatter.Special afterFractional;

		// Token: 0x04000694 RID: 1684
		private bool integerCommas;

		// Token: 0x04000695 RID: 1685
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> specials = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>();

		// Token: 0x04000696 RID: 1686
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> integerSpecials = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>();

		// Token: 0x04000697 RID: 1687
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> fractionalSpecials = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>();

		// Token: 0x04000698 RID: 1688
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> numeratorSpecials = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>();

		// Token: 0x04000699 RID: 1689
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> denominatorSpecials = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>();

		// Token: 0x0400069A RID: 1690
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> exponentSpecials = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>();

		// Token: 0x0400069B RID: 1691
		private global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> exponentDigitSpecials = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>();

		// Token: 0x0400069C RID: 1692
		private int maxDenominator;

		// Token: 0x0400069D RID: 1693
		private string numeratorFmt;

		// Token: 0x0400069E RID: 1694
		private string denominatorFmt;

		// Token: 0x0400069F RID: 1695
		private bool improperFraction;

		// Token: 0x040006A0 RID: 1696
		private global::NPOI.SS.Util.DecimalFormat decimalFmt;

		// Token: 0x040006A1 RID: 1697
		private static global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special> EmptySpecialList = new global::System.Collections.Generic.List<global::NPOI.SS.Format.CellNumberFormatter.Special>();

		// Token: 0x040006A2 RID: 1698
		private static readonly global::NPOI.SS.Format.CellFormatter SIMPLE_NUMBER = new global::NPOI.SS.Format.CellNumberFormatter.SimpleNumberCellFormatter("General");

		// Token: 0x040006A3 RID: 1699
		private static readonly global::NPOI.SS.Format.CellFormatter SIMPLE_INT = new global::NPOI.SS.Format.CellNumberFormatter("#");

		// Token: 0x040006A4 RID: 1700
		private static readonly global::NPOI.SS.Format.CellFormatter SIMPLE_FLOAT = new global::NPOI.SS.Format.CellNumberFormatter("#.#");

		// Token: 0x020005A0 RID: 1440
		private class GeneralNumberFormatter : global::NPOI.SS.Format.CellFormatter
		{
			// Token: 0x0600346C RID: 13420 RVA: 0x00029CF5 File Offset: 0x00027EF5
			private GeneralNumberFormatter() : base("General")
			{
			}

			// Token: 0x0600346D RID: 13421 RVA: 0x000A32AC File Offset: 0x000A14AC
			public override void FormatValue(global::System.Text.StringBuilder toAppendTo, object value)
			{
				if (value == null)
				{
					return;
				}
				global::NPOI.SS.Format.CellFormatter cellFormatter;
				if (global::NPOI.Util.Number.IsNumber(value))
				{
					double num;
					double.TryParse(value.ToString(), out num);
					cellFormatter = ((num % 1.0 == 0.0) ? global::NPOI.SS.Format.CellNumberFormatter.SIMPLE_INT : global::NPOI.SS.Format.CellNumberFormatter.SIMPLE_FLOAT);
				}
				else
				{
					cellFormatter = global::NPOI.SS.Format.CellTextFormatter.SIMPLE_TEXT;
				}
				cellFormatter.FormatValue(toAppendTo, value);
			}

			// Token: 0x0600346E RID: 13422 RVA: 0x00028888 File Offset: 0x00026A88
			public override void SimpleValue(global::System.Text.StringBuilder toAppendTo, object value)
			{
				this.FormatValue(toAppendTo, value);
			}
		}

		// Token: 0x020005A1 RID: 1441
		private class SimpleNumberCellFormatter : global::NPOI.SS.Format.CellFormatter
		{
			// Token: 0x0600346F RID: 13423 RVA: 0x000A3306 File Offset: 0x000A1506
			public SimpleNumberCellFormatter(string format) : base(format)
			{
			}

			// Token: 0x06003470 RID: 13424 RVA: 0x000A3310 File Offset: 0x000A1510
			public override void FormatValue(global::System.Text.StringBuilder toAppendTo, object value)
			{
				if (value == null)
				{
					return;
				}
				if (!global::NPOI.Util.Number.IsNumber(value))
				{
					global::NPOI.SS.Format.CellTextFormatter.SIMPLE_TEXT.FormatValue(toAppendTo, value);
					return;
				}
				double num;
				double.TryParse(value.ToString(), out num);
				if (num % 1.0 == 0.0)
				{
					global::NPOI.SS.Format.CellNumberFormatter.SIMPLE_INT.FormatValue(toAppendTo, value);
					return;
				}
				global::NPOI.SS.Format.CellNumberFormatter.SIMPLE_FLOAT.FormatValue(toAppendTo, value);
			}

			// Token: 0x06003471 RID: 13425 RVA: 0x00028888 File Offset: 0x00026A88
			public override void SimpleValue(global::System.Text.StringBuilder toAppendTo, object value)
			{
				this.FormatValue(toAppendTo, value);
			}
		}

		// Token: 0x020005A2 RID: 1442
		public class Special
		{
			// Token: 0x06003472 RID: 13426 RVA: 0x000A3373 File Offset: 0x000A1573
			public Special(char ch, int pos)
			{
				this.ch = ch;
				this.pos = pos;
			}

			// Token: 0x06003473 RID: 13427 RVA: 0x000A3389 File Offset: 0x000A1589
			public override string ToString()
			{
				return "'" + this.ch.ToString() + "' @ " + this.pos.ToString();
			}

			// Token: 0x04001919 RID: 6425
			internal char ch;

			// Token: 0x0400191A RID: 6426
			internal int pos;
		}
	}
}
