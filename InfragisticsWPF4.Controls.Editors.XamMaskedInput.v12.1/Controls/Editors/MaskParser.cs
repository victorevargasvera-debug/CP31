using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002E RID: 46
	internal class MaskParser
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00009618 File Offset: 0x00007818
		private MaskParser(global::System.IFormatProvider formatProvider)
		{
			this.formatProvider = formatProvider;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00009633 File Offset: 0x00007833
		private global::System.IFormatProvider FormatProvider
		{
			get
			{
				return this.formatProvider;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000963C File Offset: 0x0000783C
		private char[] DateSeperators
		{
			get
			{
				char cultureChar = global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('/', this.FormatProvider);
				string text = "-/.";
				if (cultureChar != '\0')
				{
					text = cultureChar + text;
				}
				return text.ToCharArray();
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00009674 File Offset: 0x00007874
		private char[] TimeSeperators
		{
			get
			{
				char cultureChar = global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(':', this.FormatProvider);
				string text = ":.";
				if (cultureChar != '\0')
				{
					text = cultureChar + text;
				}
				return text.ToCharArray();
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000096AB File Offset: 0x000078AB
		private char CultureDecimalSeperator
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar('.', this.FormatProvider);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000096BA File Offset: 0x000078BA
		private global::Infragistics.Controls.Editors.SectionsCollection Sections
		{
			get
			{
				if (this.sections == null)
				{
					this.sections = new global::Infragistics.Controls.Editors.SectionsCollection();
				}
				return this.sections;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000096D8 File Offset: 0x000078D8
		private string SafeSubstring(string str, int startIndex, int length)
		{
			if (startIndex < 0)
			{
				startIndex = 0;
			}
			if (startIndex >= str.Length)
			{
				return string.Empty;
			}
			if (length <= 0)
			{
				return string.Empty;
			}
			if (startIndex + length - 1 >= str.Length)
			{
				length = str.Length - startIndex;
			}
			if (length <= 0)
			{
				return string.Empty;
			}
			return str.Substring(startIndex, length);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000972E File Offset: 0x0000792E
		private int SafeIndexOfAny(string str, char[] array, int startIndex, int count)
		{
			if (startIndex < 0)
			{
				startIndex = 0;
			}
			if (startIndex >= str.Length)
			{
				return -1;
			}
			if (1 + startIndex + count >= str.Length)
			{
				count = str.Length - startIndex;
			}
			if (count <= 0)
			{
				return -1;
			}
			return str.IndexOfAny(array, startIndex, count);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000976C File Offset: 0x0000796C
		private int GetOffset(string mask, string currentSection, string targetSection, int index, bool moveForward)
		{
			int num = moveForward ? currentSection.Length : targetSection.Length;
			if (moveForward)
			{
				if (index + num >= mask.Length)
				{
					return 0;
				}
				if (mask[index + num] == '\\')
				{
					num += 2;
				}
				else
				{
					num++;
				}
			}
			else
			{
				if (index - 2 < 0)
				{
					return 0;
				}
				if (mask[index - 2] == '\\')
				{
					num += 2;
				}
				else
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000097DC File Offset: 0x000079DC
		private void AdjustNonstandardForeignDateMask(ref string mask)
		{
			string[] array = new string[]
			{
				"dd/mm/yyyy",
				"dd/yyyy/mm",
				"mm/dd/yyyy",
				"mm/yyyy/dd",
				"yyyy/mm/dd",
				"yyyy/dd/mm",
				"dd/mm/yy",
				"dd/yy/mm",
				"mm/dd/yy",
				"mm/yy/dd",
				"yy/mm/dd",
				"yy/dd/mm",
				"dd/mm",
				"dd/yyyy",
				"mm/dd",
				"mm/yyyy",
				"yyyy/dd",
				"yyyy/mm",
				"dd/mm",
				"dd/yy",
				"mm/dd",
				"mm/yy",
				"yy/dd",
				"yy/mm"
			};
			string[] array2 = array;
			int i = 0;
			while (i < array2.Length)
			{
				string text = array2[i];
				int num = mask.IndexOf(text);
				if (-1 < num)
				{
					int num2 = num + text.Length;
					if (num2 < mask.Length)
					{
						mask = mask.Insert(num2, "/");
						return;
					}
					mask += "/";
					return;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000993C File Offset: 0x00007B3C
		internal int GetNumberOfDigitsRequired(double val)
		{
			if (val < 0.0)
			{
				val = -val;
			}
			double d = global::System.Math.Log10(val);
			return 1 + (int)global::System.Math.Floor(d);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000996C File Offset: 0x00007B6C
		private static int IndexOf(string str, int startIndex, int endIndex, char c, bool skipEscapedChars, char escapeChar)
		{
			for (int i = startIndex; i <= endIndex; i++)
			{
				char c2 = str[i];
				if (skipEscapedChars && escapeChar == c2)
				{
					i++;
				}
				else if (c2 == c)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000099A4 File Offset: 0x00007BA4
		private void Analyze(string mask)
		{
			this.PreProcessMask(ref mask);
			int i = 0;
			global::Infragistics.Controls.Editors.SectionBase sectionBase = null;
			global::Infragistics.Controls.Editors.FilterType filterType = global::Infragistics.Controls.Editors.FilterType.Unchanged;
			char[] timeSeperators = this.TimeSeperators;
			char[] dateSeperators = this.DateSeperators;
			bool flag = false;
			if (mask.StartsWith("{LOC}"))
			{
				flag = true;
				i = "{LOC}".Length;
			}
			global::System.Collections.Generic.Dictionary<global::System.Type, char> dictionary = null;
			global::Infragistics.Controls.Editors.XamMaskedInput.GetNonstandardForeignDateMaskAndPostfixSymbols(this.FormatProvider, ref dictionary);
			bool flag2 = dictionary != null && flag;
			global::Infragistics.Controls.Editors.SectionBase sectionBase2 = null;
			if (flag2)
			{
				this.AdjustNonstandardForeignDateMask(ref mask);
			}
			while (i < mask.Length)
			{
				global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = null;
				global::Infragistics.Controls.Editors.DisplayCharBase[] array = null;
				if ('\n' == mask[i] || '\r' == mask[i])
				{
					i++;
				}
				else
				{
					if (global::Infragistics.Controls.Editors.State.LiteralEscape != this.state && "\\".Equals(this.SafeSubstring(mask, i, 1)) && mask.Length > 1 + i)
					{
						this.state = global::Infragistics.Controls.Editors.State.LiteralEscape;
						i++;
					}
					else if (global::Infragistics.Controls.Editors.State.LiteralEscape == this.state)
					{
						displayCharBase = new global::Infragistics.Controls.Editors.LiteralChar(mask[i]);
						displayCharBase.Required = false;
						i++;
						this.state = global::Infragistics.Controls.Editors.State.Initial;
					}
					else if (this.state == global::Infragistics.Controls.Editors.State.Initial && ('{' == mask[i] || '[' == mask[i]))
					{
						char c = mask[i];
						int num = global::Infragistics.Controls.Editors.MaskParser.IndexOf(mask, 1 + i, mask.Length - 1, ('{' == c) ? '}' : ']', true, '\\');
						bool flag3 = false;
						if (num > 0)
						{
							string input = this.SafeSubstring(mask, 1 + i, num - i - 1);
							global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(input, "^(number)(?:\\: *(-?\\d+) *- *(-?\\d+))?$");
							if (match.Success)
							{
								string value = match.Groups[1].Value;
								string value2 = match.Groups[2].Value;
								string value3 = match.Groups[3].Value;
								decimal num2 = -2147483648m;
								decimal num3 = 2147483647m;
								if (value2 != null && value3 != null && value2.Length > 0 && value3.Length > 0)
								{
									num2 = decimal.Parse(value2);
									num3 = decimal.Parse(value3);
								}
								int numberOfDigitsRequired = this.GetNumberOfDigitsRequired((double)num2);
								int numberOfDigitsRequired2 = this.GetNumberOfDigitsRequired((double)num3);
								int digits = global::System.Math.Max(numberOfDigitsRequired, numberOfDigitsRequired2);
								sectionBase = new global::Infragistics.Controls.Editors.NumberSection(digits, null, (num2 < 0m) ? global::Infragistics.Controls.Editors.SignDisplayType.ShowWhenNegative : global::Infragistics.Controls.Editors.SignDisplayType.None)
								{
									MinValue = num2,
									MaxValue = num3
								};
								flag3 = true;
							}
							if (!match.Success)
							{
								match = global::System.Text.RegularExpressions.Regex.Match(input, "^(char)\\:(\\d+)\\:(.+)$");
								if (match.Success)
								{
									string value4 = match.Groups[1].Value;
									string value5 = match.Groups[2].Value;
									string value6 = match.Groups[3].Value;
									int num4 = int.Parse(value5);
									global::Infragistics.Controls.Editors.CharacterSet.ICharSet charSet = global::Infragistics.Controls.Editors.CharacterSet.ParseSet(value6);
									if (charSet != null && num4 > 0)
									{
										array = new global::Infragistics.Controls.Editors.DisplayCharBase[num4];
										for (int j = 0; j < array.Length; j++)
										{
											global::Infragistics.Controls.Editors.CharacterSet characterSet = new global::Infragistics.Controls.Editors.CharacterSet();
											characterSet.InitializeSet(charSet);
											characterSet.FilterType = filterType;
											array[j] = characterSet;
										}
										flag3 = true;
									}
								}
							}
						}
						if (flag3)
						{
							i = 1 + num;
						}
						else
						{
							displayCharBase = new global::Infragistics.Controls.Editors.LiteralChar(c);
							i++;
						}
					}
					else if (global::Infragistics.Controls.Editors.State.Date != this.state && (global::Infragistics.Controls.Editors.State.Time != this.state || global::Infragistics.Controls.Editors.XamMaskedInput.GetSection(this.sections, typeof(global::Infragistics.Controls.Editors.MinuteSection)) != null) && "mm".Equals(this.SafeSubstring(mask, i, 2)) && ("dd".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "mm", "dd", i, true), 2)) || "yy".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "mm", "yy", i, true), 2))))
					{
						this.state = global::Infragistics.Controls.Editors.State.Date;
					}
					else if (this.state == global::Infragistics.Controls.Editors.State.Initial && "mm".Equals(this.SafeSubstring(mask, i, 2)) && ("dd".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "mm", "dd", i, false), 2)) || "yy".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "mm", "yy", i, false), 2))))
					{
						this.state = global::Infragistics.Controls.Editors.State.Date;
					}
					else if ((this.state == global::Infragistics.Controls.Editors.State.Initial || global::Infragistics.Controls.Editors.State.Time == this.state) && "d".Equals(this.SafeSubstring(mask, i, 1)) && ("mm".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "d", "mm", i, true), 2)) || "yy".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "d", "yy", i, true), 2))))
					{
						this.state = global::Infragistics.Controls.Editors.State.Date;
					}
					else if (this.state == global::Infragistics.Controls.Editors.State.Initial && "d".Equals(this.SafeSubstring(mask, i, 1)) && ("mm".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "d", "mm", i, false), 2)) || "yy".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "d", "yy", i, false), 2))))
					{
						this.state = global::Infragistics.Controls.Editors.State.Date;
					}
					else if ((this.state == global::Infragistics.Controls.Editors.State.Initial || global::Infragistics.Controls.Editors.State.Time == this.state) && "dd".Equals(this.SafeSubstring(mask, i, 2)) && ("mm".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "dd", "mm", i, true), 2)) || "yy".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "dd", "yy", i, true), 2))))
					{
						this.state = global::Infragistics.Controls.Editors.State.Date;
					}
					else if (this.state == global::Infragistics.Controls.Editors.State.Initial && "dd".Equals(this.SafeSubstring(mask, i, 2)) && ("mm".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "dd", "mm", i, false), 2)) || "yy".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "dd", "yy", i, false), 2))))
					{
						this.state = global::Infragistics.Controls.Editors.State.Date;
					}
					else if ((this.state == global::Infragistics.Controls.Editors.State.Initial || global::Infragistics.Controls.Editors.State.Time == this.state) && "yy".Equals(this.SafeSubstring(mask, i, 2)) && ("mm".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "yy", "mm", i, true), 2)) || "dd".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "yy", "dd", i, true), 2))))
					{
						this.state = global::Infragistics.Controls.Editors.State.Date;
					}
					else if ((this.state == global::Infragistics.Controls.Editors.State.Initial || global::Infragistics.Controls.Editors.State.Time == this.state) && "yyyy".Equals(this.SafeSubstring(mask, i, 4)) && ("mm".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "yyyy", "mm", i, true), 2)) || "dd".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "yyyy", "dd", i, true), 2))))
					{
						this.state = global::Infragistics.Controls.Editors.State.Date;
					}
					else if (this.state == global::Infragistics.Controls.Editors.State.Initial && "yyyy".Equals(this.SafeSubstring(mask, i, 4)) && ("mm".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "yyyy", "mm", i, false), 2)) || "dd".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "yyyy", "dd", i, false), 2))))
					{
						this.state = global::Infragistics.Controls.Editors.State.Date;
					}
					else if (global::Infragistics.Controls.Editors.State.Date == this.state && "mm".Equals(this.SafeSubstring(mask, i, 2)))
					{
						sectionBase = new global::Infragistics.Controls.Editors.MonthSection();
						global::Infragistics.Controls.Editors.MonthSection.InitializeMinMax((global::Infragistics.Controls.Editors.MonthSection)sectionBase, global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureCalendar(this.FormatProvider));
						i += 2;
					}
					else if (global::Infragistics.Controls.Editors.State.Date == this.state && "yyyy".Equals(this.SafeSubstring(mask, i, 4)))
					{
						sectionBase = new global::Infragistics.Controls.Editors.YearSection(true);
						global::Infragistics.Controls.Editors.YearSection.InitializeMinMax((global::Infragistics.Controls.Editors.YearSection)sectionBase, global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureCalendar(this.FormatProvider));
						i += 4;
					}
					else if (global::Infragistics.Controls.Editors.State.Date == this.state && "yy".Equals(this.SafeSubstring(mask, i, 2)))
					{
						sectionBase = new global::Infragistics.Controls.Editors.YearSection(false);
						global::Infragistics.Controls.Editors.YearSection.InitializeMinMax((global::Infragistics.Controls.Editors.YearSection)sectionBase, global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureCalendar(this.FormatProvider));
						i += 2;
					}
					else if (global::Infragistics.Controls.Editors.State.Date == this.state && "dd".Equals(this.SafeSubstring(mask, i, 2)))
					{
						sectionBase = new global::Infragistics.Controls.Editors.DaySection();
						i += 2;
					}
					else if (this.state == global::Infragistics.Controls.Editors.State.Initial && "hh".Equals(this.SafeSubstring(mask, i, 2)) && "mm".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "hh", "mm", i, true), 2)))
					{
						this.state = global::Infragistics.Controls.Editors.State.Time;
					}
					else if (this.state == global::Infragistics.Controls.Editors.State.Initial && "h".Equals(this.SafeSubstring(mask, i, 1)) && "mm".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "h", "mm", i, true), 2)))
					{
						this.state = global::Infragistics.Controls.Editors.State.Time;
					}
					else if (this.state == global::Infragistics.Controls.Editors.State.Initial && "mm".Equals(this.SafeSubstring(mask, i, 2)) && ("ss".Equals(this.SafeSubstring(mask, i + this.GetOffset(mask, "mm", "ss", i, true), 2)) || "hh".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "mm", "hh", i, false), 2)) || "h".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "mm", "h", i, false), 1))))
					{
						this.state = global::Infragistics.Controls.Editors.State.Time;
					}
					else if (this.state == global::Infragistics.Controls.Editors.State.Initial && "ss".Equals(this.SafeSubstring(mask, i, 2)) && "mm".Equals(this.SafeSubstring(mask, i - this.GetOffset(mask, "ss", "mm", i, false), 2)))
					{
						this.state = global::Infragistics.Controls.Editors.State.Time;
					}
					else if (global::Infragistics.Controls.Editors.State.Time == this.state && "mm".Equals(this.SafeSubstring(mask, i, 2)))
					{
						sectionBase = new global::Infragistics.Controls.Editors.MinuteSection();
						i += 2;
					}
					else if (global::Infragistics.Controls.Editors.State.Time == this.state && "hh".Equals(this.SafeSubstring(mask, i, 2)))
					{
						sectionBase = new global::Infragistics.Controls.Editors.HourSection();
						i += 2;
					}
					else if (global::Infragistics.Controls.Editors.State.Time == this.state && "h".Equals(this.SafeSubstring(mask, i, 1)))
					{
						sectionBase = new global::Infragistics.Controls.Editors.HourSection();
						i++;
					}
					else if (global::Infragistics.Controls.Editors.State.Time == this.state && "ss".Equals(this.SafeSubstring(mask, i, 2)))
					{
						sectionBase = new global::Infragistics.Controls.Editors.SecondSection();
						i += 2;
					}
					else if (global::Infragistics.Controls.Editors.State.Time == this.state && " ".Equals(this.SafeSubstring(mask, i, 1)))
					{
						displayCharBase = new global::Infragistics.Controls.Editors.LiteralChar(' ');
						i++;
					}
					else if (global::Infragistics.Controls.Editors.State.Date == this.state && " hh".Equals(this.SafeSubstring(mask, i, 3)) && !"h".Equals(this.SafeSubstring(mask, 3 + i, 1)))
					{
						this.state = global::Infragistics.Controls.Editors.State.Time;
						displayCharBase = new global::Infragistics.Controls.Editors.LiteralChar(' ');
						i++;
					}
					else if (global::Infragistics.Controls.Editors.State.Time == this.state && "tt".Equals(this.SafeSubstring(mask, i, 2)))
					{
						string cultureAMPMDesignator = global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureAMPMDesignator(true, this.FormatProvider);
						string cultureAMPMDesignator2 = global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureAMPMDesignator(false, this.FormatProvider);
						i += 2;
						if (cultureAMPMDesignator == null || cultureAMPMDesignator.Length == 0 || cultureAMPMDesignator2 == null || cultureAMPMDesignator2.Length == 0)
						{
							continue;
						}
						sectionBase = new global::Infragistics.Controls.Editors.AMPMSection(cultureAMPMDesignator, cultureAMPMDesignator2);
					}
					else if (global::Infragistics.Controls.Editors.State.Time == this.state && this.SafeIndexOfAny(mask, timeSeperators, i, 1) >= 0)
					{
						char literal = (flag && ':' == mask[i]) ? global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(mask[i], this.FormatProvider) : mask[i];
						displayCharBase = new global::Infragistics.Controls.Editors.LiteralChar(literal);
						i++;
					}
					else
					{
						if (global::Infragistics.Controls.Editors.State.Date == this.state && this.SafeIndexOfAny(mask, dateSeperators, i, 1) >= 0)
						{
							char literal2 = '\0';
							if (!flag2)
							{
								goto IL_CB8;
							}
							if (sectionBase2 != null)
							{
								object obj = dictionary[sectionBase2.GetType()];
								if (obj != null)
								{
									try
									{
										literal2 = global::System.Convert.ToChar(obj);
										goto IL_CE4;
									}
									catch (global::System.Exception)
									{
										literal2 = '/';
										goto IL_CE4;
									}
									goto IL_CB8;
								}
							}
							IL_CE4:
							displayCharBase = new global::Infragistics.Controls.Editors.LiteralChar(literal2);
							i++;
							goto IL_1243;
							IL_CB8:
							literal2 = ((flag && '/' == mask[i]) ? global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(mask[i], this.FormatProvider) : mask[i]);
							goto IL_CE4;
						}
						if ("#".Equals(this.SafeSubstring(mask, i, 1)))
						{
							displayCharBase = new global::Infragistics.Controls.Editors.DigitChar();
							displayCharBase.FilterType = filterType;
							displayCharBase.Required = true;
							i++;
							this.state = global::Infragistics.Controls.Editors.State.Initial;
						}
						else if ("9".Equals(this.SafeSubstring(mask, i, 1)))
						{
							displayCharBase = new global::Infragistics.Controls.Editors.DigitChar();
							displayCharBase.FilterType = filterType;
							displayCharBase.Required = false;
							i++;
							this.state = global::Infragistics.Controls.Editors.State.Initial;
						}
						else if (i < mask.Length && ('h' == mask[i] || 'H' == mask[i]))
						{
							displayCharBase = new global::Infragistics.Controls.Editors.HexDigitChar();
							displayCharBase.FilterType = (('h' == mask[i]) ? global::Infragistics.Controls.Editors.FilterType.LowerCase : global::Infragistics.Controls.Editors.FilterType.UpperCase);
							displayCharBase.Required = true;
							i++;
							this.state = global::Infragistics.Controls.Editors.State.Initial;
						}
						else if (global::Infragistics.Controls.Editors.State.Number == this.state && ".".Equals(this.SafeSubstring(mask, i, 1)) && "n".Equals(this.SafeSubstring(mask, 1 + i, 1)))
						{
							displayCharBase = new global::Infragistics.Controls.Editors.DecimalSeperatorChar(this.CultureDecimalSeperator);
							i++;
							this.state = global::Infragistics.Controls.Editors.State.FractionPart;
							sectionBase = null;
						}
						else if (global::Infragistics.Controls.Editors.State.FractionPart == this.state && "n".Equals(this.SafeSubstring(mask, i, 1)))
						{
							int num5 = i;
							while (num5 < mask.Length && 'n' == mask[num5])
							{
								num5++;
							}
							global::Infragistics.Controls.Editors.FractionPart fractionPart = (this.hasContinuousNumericMask == true) ? new global::Infragistics.Controls.Editors.FractionPartContinuous(num5 - i) : new global::Infragistics.Controls.Editors.FractionPart(num5 - i);
							sectionBase = fractionPart;
							i = num5;
							this.state = global::Infragistics.Controls.Editors.State.Initial;
						}
						else if (this.state == global::Infragistics.Controls.Editors.State.Initial && ".n".Equals(this.SafeSubstring(mask, i, 2)))
						{
							this.state = global::Infragistics.Controls.Editors.State.Number;
						}
						else if ("n".Equals(this.SafeSubstring(mask, i, 1)) || "-n".Equals(this.SafeSubstring(mask, i, 2)) || "+n".Equals(this.SafeSubstring(mask, i, 2)))
						{
							global::Infragistics.Controls.Editors.SignDisplayType signType = global::Infragistics.Controls.Editors.SignDisplayType.None;
							if ('-' == mask[i])
							{
								signType = global::Infragistics.Controls.Editors.SignDisplayType.ShowWhenNegative;
								i++;
							}
							else if ('+' == mask[i])
							{
								signType = global::Infragistics.Controls.Editors.SignDisplayType.ShowAlways;
								i++;
							}
							int num6 = i;
							global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>(5);
							while (num6 < mask.Length && ('n' == mask[num6] || ',' == mask[num6]))
							{
								if (',' == mask[num6] && 1 + num6 < mask.Length)
								{
									if (1 + num6 >= mask.Length || 'n' != mask[1 + num6])
									{
										break;
									}
									list.Add(num6 - i - list.Count - 1);
								}
								num6++;
							}
							global::Infragistics.Controls.Editors.NumberSection numberSection = new global::Infragistics.Controls.Editors.NumberSection(num6 - i - list.Count, list.ToArray(), signType);
							sectionBase = numberSection;
							i = num6;
							this.state = global::Infragistics.Controls.Editors.State.Number;
						}
						else if (flag && ('$' == mask[i] || '/' == mask[i] || ':' == mask[i] || ',' == mask[i] || (global::Infragistics.Controls.Editors.State.Date != this.state && global::Infragistics.Controls.Editors.State.Time != this.state && '.' == mask[i]) || '+' == mask[i] || '-' == mask[i]))
						{
							if ('$' == mask[i])
							{
								global::System.Globalization.NumberFormatInfo numberFormatInfo = global::Infragistics.Controls.Editors.XamMaskedInput.GetNumberFormatInfo(this.FormatProvider);
								string text = (numberFormatInfo != null) ? numberFormatInfo.CurrencySymbol : null;
								if (text != null)
								{
									array = new global::Infragistics.Controls.Editors.DisplayCharBase[text.Length];
									for (int k = 0; k < text.Length; k++)
									{
										array[k] = new global::Infragistics.Controls.Editors.LiteralChar(text[k]);
										array[k].FilterType = filterType;
									}
								}
							}
							else
							{
								char cultureChar = global::Infragistics.Controls.Editors.XamMaskedInput.GetCultureChar(mask[i], this.FormatProvider);
								displayCharBase = new global::Infragistics.Controls.Editors.LiteralChar(cultureChar);
								displayCharBase.FilterType = filterType;
							}
							i++;
							this.state = global::Infragistics.Controls.Editors.State.Initial;
						}
						else if ("A".Equals(this.SafeSubstring(mask, i, 1)))
						{
							displayCharBase = new global::Infragistics.Controls.Editors.AlphanumericChar();
							displayCharBase.FilterType = filterType;
							displayCharBase.Required = true;
							i++;
							this.state = global::Infragistics.Controls.Editors.State.Initial;
						}
						else if ("a".Equals(this.SafeSubstring(mask, i, 1)))
						{
							displayCharBase = new global::Infragistics.Controls.Editors.AlphanumericChar();
							displayCharBase.FilterType = filterType;
							displayCharBase.Required = false;
							i++;
							this.state = global::Infragistics.Controls.Editors.State.Initial;
						}
						else if ("?".Equals(this.SafeSubstring(mask, i, 1)))
						{
							displayCharBase = new global::Infragistics.Controls.Editors.AlphaChar();
							displayCharBase.FilterType = filterType;
							displayCharBase.Required = false;
							i++;
							this.state = global::Infragistics.Controls.Editors.State.Initial;
						}
						else if ("&".Equals(this.SafeSubstring(mask, i, 1)) || "C".Equals(this.SafeSubstring(mask, i, 1)))
						{
							displayCharBase = new global::Infragistics.Controls.Editors.KeyboardAndForeignChar();
							displayCharBase.FilterType = filterType;
							displayCharBase.Required = false;
							i++;
							this.state = global::Infragistics.Controls.Editors.State.Initial;
						}
						else if ("<".Equals(this.SafeSubstring(mask, i, 1)))
						{
							filterType = global::Infragistics.Controls.Editors.FilterType.LowerCase;
							i++;
						}
						else if (">".Equals(this.SafeSubstring(mask, i, 1)))
						{
							filterType = global::Infragistics.Controls.Editors.FilterType.UpperCase;
							i++;
						}
						else
						{
							displayCharBase = new global::Infragistics.Controls.Editors.LiteralChar(mask[i]);
							displayCharBase.Required = false;
							this.state = global::Infragistics.Controls.Editors.State.Initial;
							i++;
						}
					}
					IL_1243:
					if (sectionBase != null && ((!(sectionBase is global::Infragistics.Controls.Editors.DisplayCharsEditSection) && !(sectionBase is global::Infragistics.Controls.Editors.LiteralSection)) || sectionBase is global::Infragistics.Controls.Editors.AMPMSection))
					{
						this.Sections.Add(sectionBase);
						sectionBase.SetFilterToAllChars(filterType);
						sectionBase2 = sectionBase;
						sectionBase = null;
					}
					else if (displayCharBase != null || (array != null && array.Length != 0))
					{
						if (displayCharBase != null)
						{
							array = new global::Infragistics.Controls.Editors.DisplayCharBase[]
							{
								displayCharBase
							};
						}
						int num7 = 0;
						while (array != null && num7 < array.Length)
						{
							displayCharBase = array[num7];
							if (displayCharBase is global::Infragistics.Controls.Editors.LiteralChar)
							{
								if (sectionBase == null || !(sectionBase is global::Infragistics.Controls.Editors.LiteralSection))
								{
									sectionBase = new global::Infragistics.Controls.Editors.LiteralSection();
									this.Sections.Add(sectionBase);
								}
							}
							else if (sectionBase == null || !(sectionBase is global::Infragistics.Controls.Editors.DisplayCharsEditSection))
							{
								sectionBase = new global::Infragistics.Controls.Editors.DisplayCharsEditSection();
								this.Sections.Add(sectionBase);
							}
							if (sectionBase != null)
							{
								sectionBase.DisplayChars.Add(displayCharBase);
								displayCharBase.Initialize(sectionBase);
							}
							num7++;
						}
					}
				}
			}
			bool flag4 = false;
			global::Infragistics.Controls.Editors.HourSection hourSection = null;
			global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase2 = null;
			for (int l = 0; l < this.Sections.Count; l++)
			{
				global::Infragistics.Controls.Editors.SectionBase sectionBase3 = this.Sections[l];
				if (typeof(global::Infragistics.Controls.Editors.AMPMSection) == sectionBase3.GetType())
				{
					flag4 = true;
				}
				if (typeof(global::Infragistics.Controls.Editors.HourSection) == sectionBase3.GetType())
				{
					hourSection = (sectionBase3 as global::Infragistics.Controls.Editors.HourSection);
				}
				for (int m = 0; m < sectionBase3.DisplayChars.Count; m++)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase3 = sectionBase3.DisplayChars[m];
					if (displayCharBase3 is global::Infragistics.Controls.Editors.LiteralChar && (displayCharBase3.Char == this.CultureDecimalSeperator || '.' == displayCharBase3.Char))
					{
						global::Infragistics.Controls.Editors.DisplayCharBase nextDisplayChar = displayCharBase3.NextDisplayChar;
						if (nextDisplayChar != null && (nextDisplayChar is global::Infragistics.Controls.Editors.DigitChar || nextDisplayChar.Section is global::Infragistics.Controls.Editors.NumberSection) && this.state != global::Infragistics.Controls.Editors.State.Date && displayCharBase2 == null)
						{
							displayCharBase2 = displayCharBase3;
							displayCharBase3.IncludeMethod = global::Infragistics.Controls.Editors.DisplayCharIncludeMethod.Always;
						}
						if (displayCharBase2 != null && displayCharBase2 != displayCharBase3)
						{
							displayCharBase2.IncludeMethod = global::Infragistics.Controls.Editors.DisplayCharIncludeMethod.Default;
							break;
						}
						if (displayCharBase2 == null)
						{
							displayCharBase2 = displayCharBase3;
						}
					}
				}
			}
			if (flag4 && hourSection != null)
			{
				hourSection.MinValue = 1m;
				hourSection.MaxValue = 12m;
			}
			int count = this.Sections.Count;
			for (int n = 0; n < count; n++)
			{
				if ((this.Sections[n].IsDateSection || this.Sections[n].IsTimeSection) && n + 1 < count)
				{
					this.Sections[n + 1].IsDateTimeSeperatorSection = true;
				}
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000AE94 File Offset: 0x00009094
		private void PreProcessMask(ref string mask)
		{
			global::System.IFormatProvider formatProvider = this.FormatProvider;
			if (mask.IndexOf("{date}") >= 0)
			{
				string newValue = global::Infragistics.Controls.Editors.XamMaskedInput.CalcDefaultDateMask(formatProvider);
				mask = mask.Replace("{date}", newValue);
			}
			if (mask.IndexOf("{date:s}") >= 0)
			{
				string newValue2 = global::Infragistics.Controls.Editors.XamMaskedInput.CalcDefaultDateMask(formatProvider, false);
				mask = mask.Replace("{date:s}", newValue2);
			}
			if (mask.IndexOf("{time}") >= 0)
			{
				string newValue3 = global::Infragistics.Controls.Editors.XamMaskedInput.CalcDefaultTimeMask(formatProvider);
				mask = mask.Replace("{time}", newValue3);
			}
			if (mask.IndexOf("{longtime}") >= 0)
			{
				string newValue4 = global::Infragistics.Controls.Editors.XamMaskedInput.CalcDefaultLongTimeMask(formatProvider);
				mask = mask.Replace("{longtime}", newValue4);
			}
			global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(mask, "\\{(double|currency)(?:\\:(\\-|\\+)?(\\d+)(?:\\.(\\d+))?)?(?:\\:(c))?(?:\\:(no_symbol))?\\}");
			if (match != null && match.Success && match.Groups.Count > 4)
			{
				string value = match.Groups[1].Value;
				string value2 = match.Groups[2].Value;
				char c = (value2 != null && value2.Length > 0) ? value2[0] : '\0';
				value2 = match.Groups[3].Value;
				int num = (value2 != null && value2.Length > 0) ? int.Parse(value2) : -1;
				value2 = match.Groups[4].Value;
				int num2 = (value2 != null && value2.Length > 0) ? int.Parse(value2) : -1;
				this.hasContinuousNumericMask = new bool?("c" == match.Groups[5].Value && num > 0 && num2 > 0);
				bool flag = "no_symbol" == match.Groups[6].Value;
				if (c == '\0' && -1 == num)
				{
					c = '-';
				}
				string newValue5 = ("double" == value) ? global::Infragistics.Controls.Editors.XamMaskedInput.CalcDefaultDoubleMask(formatProvider, num, num2, c) : global::Infragistics.Controls.Editors.XamMaskedInput.CalcDefaultCurrencyMask(formatProvider, num, num2, c, !flag);
				mask = mask.Replace(match.Value, newValue5);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000B0B4 File Offset: 0x000092B4
		internal static void Parse(string mask, out global::Infragistics.Controls.Editors.SectionsCollection sections, global::System.IFormatProvider formatProvider)
		{
			global::Infragistics.Controls.Editors.MaskParser maskParser = new global::Infragistics.Controls.Editors.MaskParser(formatProvider);
			maskParser.Analyze(mask);
			sections = maskParser.sections;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000B0D8 File Offset: 0x000092D8
		internal static void EscapeLiteralsInString(string baseString, out string escapedString)
		{
			if (baseString == null || baseString.Length == 0)
			{
				escapedString = string.Empty;
				return;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(baseString.Length * 2);
			for (int i = 0; i < baseString.Length; i++)
			{
				stringBuilder.AppendFormat("\\{0}", baseString[i]);
			}
			escapedString = stringBuilder.ToString();
		}

		// Token: 0x040000A8 RID: 168
		internal const char ESCAPE_CHAR = '\\';

		// Token: 0x040000A9 RID: 169
		internal const string ESCAPE_CHAR_STRING = "\\";

		// Token: 0x040000AA RID: 170
		internal static string LOCALIZED_ESCAPE_SEQUENCE = "{LOC}";

		// Token: 0x040000AB RID: 171
		private global::Infragistics.Controls.Editors.State state;

		// Token: 0x040000AC RID: 172
		private global::Infragistics.Controls.Editors.SectionsCollection sections;

		// Token: 0x040000AD RID: 173
		private global::System.IFormatProvider formatProvider;

		// Token: 0x040000AE RID: 174
		private bool? hasContinuousNumericMask = null;
	}
}
