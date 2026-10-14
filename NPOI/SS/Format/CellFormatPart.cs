using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.HSSF.Util;

namespace NPOI.SS.Format
{
	// Token: 0x02000247 RID: 583
	public class CellFormatPart
	{
		// Token: 0x06000E3D RID: 3645 RVA: 0x00029050 File Offset: 0x00027250
		static CellFormatPart()
		{
			global::NPOI.SS.Format.CellFormatPart.NAMED_COLORS = new global::System.Collections.Generic.Dictionary<string, global::System.Drawing.Color>(global::NPOI.SS.Format.CellFormatPart.CASE_INSENSITIVE_ORDER);
			foreach (global::NPOI.HSSF.Util.HSSFColor hssfcolor in global::NPOI.HSSF.Util.HSSFColor.GetIndexHash().Values)
			{
				global::NPOI.HSSF.Util.HSSFColor hssfcolor2 = (global::NPOI.HSSF.Util.HSSFColor)hssfcolor;
				string name = hssfcolor2.GetType().Name;
				if (name.Equals(name.ToUpper()))
				{
					byte[] rgb = hssfcolor2.RGB;
					global::System.Drawing.Color value = global::System.Drawing.Color.FromArgb((int)rgb[0], (int)rgb[1], (int)rgb[2]);
					if (!global::NPOI.SS.Format.CellFormatPart.NAMED_COLORS.ContainsKey(name))
					{
						global::NPOI.SS.Format.CellFormatPart.NAMED_COLORS.Add(name, value);
					}
					if (name.IndexOf('_') > 0 && !global::NPOI.SS.Format.CellFormatPart.NAMED_COLORS.ContainsKey(name.Replace('_', ' ')))
					{
						global::NPOI.SS.Format.CellFormatPart.NAMED_COLORS.Add(name.Replace('_', ' '), value);
					}
					if (name.IndexOf("_PERCENT") > 0 && !global::NPOI.SS.Format.CellFormatPart.NAMED_COLORS.ContainsKey(name.Replace("_PERCENT", "%").Replace('_', ' ')))
					{
						global::NPOI.SS.Format.CellFormatPart.NAMED_COLORS.Add(name.Replace("_PERCENT", "%").Replace('_', ' '), value);
					}
				}
			}
			string text = "([<>=]=?|!=|<>)    # The operator\n  \\s*([0-9]+(?:\\.[0-9]*)?)\\s*  # The constant to test against\n";
			string text2 = "(\\[\\$.{0,3}-[0-9a-f]{3}\\])";
			string text3 = "\\[(black|blue|cyan|green|magenta|red|white|yellow|color [0-9]+)\\]";
			string text4 = "\\\\.                 # Quoted single character\n|\"([^\\\\\"]|\\\\.)*\"         # Quoted string of characters (handles escaped quotes like \\\") \n|" + text2 + "               # Currency symbol in a given locale\n|_.                             # Space as wide as a given character\n|\\*.                           # Repeating fill character\n|@                              # Text: cell text\n|([0?\\#](?:[0?\\#,]*))         # Number: digit + other digits and commas\n|e[-+]                          # Number: Scientific: Exponent\n|m{1,5}                         # Date: month or minute spec\n|d{1,4}                         # Date: day/date spec\n|y{2,4}                         # Date: year spec\n|h{1,2}                         # Date: hour spec\n|s{1,2}                         # Date: second spec\n|am?/pm?                        # Date: am/pm spec\n|\\[h{1,2}\\]                   # Elapsed time: hour spec\n|\\[m{1,2}\\]                   # Elapsed time: minute spec\n|\\[s{1,2}\\]                   # Elapsed time: second spec\n|[^;]                           # A character\n";
			string pattern = string.Concat(new string[]
			{
				"(?:",
				text3,
				")?                  # Text color\n(?:\\[",
				text,
				"\\])?                # Condition\n(?:\\[\\$-[0-9a-fA-F]+\\])?                # Optional locale id, ignored currently\n((?:",
				text4,
				")+)                        # Format spec\n"
			});
			global::System.Text.RegularExpressions.RegexOptions options = global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace;
			global::NPOI.SS.Format.CellFormatPart.COLOR_PAT = new global::System.Text.RegularExpressions.Regex(text3, options);
			global::NPOI.SS.Format.CellFormatPart.CONDITION_PAT = new global::System.Text.RegularExpressions.Regex(text, options);
			global::NPOI.SS.Format.CellFormatPart.SPECIFICATION_PAT = new global::System.Text.RegularExpressions.Regex(text4, options);
			global::NPOI.SS.Format.CellFormatPart.CURRENCY_PAT = new global::System.Text.RegularExpressions.Regex(text2, options);
			global::NPOI.SS.Format.CellFormatPart.FORMAT_PAT = new global::System.Text.RegularExpressions.Regex(pattern, options);
			global::NPOI.SS.Format.CellFormatPart.COLOR_GROUP = global::NPOI.SS.Format.CellFormatPart.FindGroup(global::NPOI.SS.Format.CellFormatPart.FORMAT_PAT, "[Blue]@", "Blue");
			global::NPOI.SS.Format.CellFormatPart.CONDITION_OPERATOR_GROUP = global::NPOI.SS.Format.CellFormatPart.FindGroup(global::NPOI.SS.Format.CellFormatPart.FORMAT_PAT, "[>=1]@", ">=");
			global::NPOI.SS.Format.CellFormatPart.CONDITION_VALUE_GROUP = global::NPOI.SS.Format.CellFormatPart.FindGroup(global::NPOI.SS.Format.CellFormatPart.FORMAT_PAT, "[>=1]@", "1");
			global::NPOI.SS.Format.CellFormatPart.SPECIFICATION_GROUP = global::NPOI.SS.Format.CellFormatPart.FindGroup(global::NPOI.SS.Format.CellFormatPart.FORMAT_PAT, "[Blue][>1]\\a ?", "\\a ?");
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x000292C4 File Offset: 0x000274C4
		public CellFormatPart(string desc)
		{
			global::System.Text.RegularExpressions.Match match = global::NPOI.SS.Format.CellFormatPart.FORMAT_PAT.Match(desc);
			if (!match.Success)
			{
				throw new global::System.ArgumentException("Unrecognized format: \"" + desc + "\"");
			}
			this.color = global::NPOI.SS.Format.CellFormatPart.GetColor(match);
			this.condition = this.GetCondition(match);
			this.type = this.GetCellFormatType(match);
			this.format = this.GetFormatter(match);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00029334 File Offset: 0x00027534
		public bool Applies(object valueObject)
		{
			if (this.condition != null && valueObject.GetType().IsPrimitive)
			{
				double value = (double)valueObject;
				return this.condition.Pass(value);
			}
			if (valueObject == null)
			{
				throw new global::System.NullReferenceException("valueObject");
			}
			return true;
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0002937C File Offset: 0x0002757C
		private static int FindGroup(global::System.Text.RegularExpressions.Regex pat, string str, string marker)
		{
			global::System.Text.RegularExpressions.Match match = pat.Match(str);
			if (!match.Success)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Pattern \"",
					pat.ToString(),
					"\" doesn't match \"",
					str,
					"\""
				}));
			}
			for (int i = 1; i <= match.Groups.Count; i++)
			{
				string value = match.Groups[i].Value;
				if (value != null && value.Equals(marker))
				{
					return i;
				}
			}
			throw new global::System.ArgumentException(string.Concat(new string[]
			{
				"\"",
				marker,
				"\" not found in \"",
				pat.ToString(),
				"\""
			}));
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0002943C File Offset: 0x0002763C
		private static global::System.Drawing.Color GetColor(global::System.Text.RegularExpressions.Match m)
		{
			string text = m.Groups[global::NPOI.SS.Format.CellFormatPart.COLOR_GROUP].Value.ToUpper();
			if (text == null || text.Length == 0)
			{
				return global::System.Drawing.Color.Empty;
			}
			global::System.Drawing.Color result = global::System.Drawing.Color.Empty;
			if (global::NPOI.SS.Format.CellFormatPart.NAMED_COLORS.ContainsKey(text))
			{
				result = global::NPOI.SS.Format.CellFormatPart.NAMED_COLORS[text];
			}
			return result;
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00029498 File Offset: 0x00027698
		private global::NPOI.SS.Format.CellFormatCondition GetCondition(global::System.Text.RegularExpressions.Match m)
		{
			string value = m.Groups[global::NPOI.SS.Format.CellFormatPart.CONDITION_OPERATOR_GROUP].Value;
			if (value == null || value.Length == 0)
			{
				return null;
			}
			return global::NPOI.SS.Format.CellFormatCondition.GetInstance(m.Groups[global::NPOI.SS.Format.CellFormatPart.CONDITION_OPERATOR_GROUP].Value, m.Groups[global::NPOI.SS.Format.CellFormatPart.CONDITION_VALUE_GROUP].Value);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x000294F8 File Offset: 0x000276F8
		private global::NPOI.SS.Format.CellFormatType GetCellFormatType(global::System.Text.RegularExpressions.Match matcher)
		{
			string value = matcher.Groups[global::NPOI.SS.Format.CellFormatPart.SPECIFICATION_GROUP].Value;
			return this.formatType(value);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00029524 File Offset: 0x00027724
		private global::NPOI.SS.Format.CellFormatter GetFormatter(global::System.Text.RegularExpressions.Match matcher)
		{
			string text = matcher.Groups[global::NPOI.SS.Format.CellFormatPart.SPECIFICATION_GROUP].Value;
			global::System.Text.RegularExpressions.Match match = global::NPOI.SS.Format.CellFormatPart.CURRENCY_PAT.Match(text);
			if (match.Success)
			{
				string value = match.Groups[1].Value;
				string newValue;
				if (value.StartsWith("[$-"))
				{
					newValue = "$";
				}
				else
				{
					newValue = value.Substring(2, value.LastIndexOf('-') - 2);
				}
				text = text.Replace(value, newValue);
			}
			return this.type.Formatter(text);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x000295AC File Offset: 0x000277AC
		private global::NPOI.SS.Format.CellFormatType formatType(string fdesc)
		{
			fdesc = fdesc.Trim();
			if (fdesc.Equals("") || fdesc.Equals("General", global::System.StringComparison.InvariantCultureIgnoreCase))
			{
				return global::NPOI.SS.Format.CellFormatType.GENERAL;
			}
			global::System.Text.RegularExpressions.MatchCollection matchCollection = global::NPOI.SS.Format.CellFormatPart.SPECIFICATION_PAT.Matches(fdesc);
			bool flag = false;
			bool flag2 = false;
			foreach (object obj in matchCollection)
			{
				string value = ((global::System.Text.RegularExpressions.Match)obj).Groups[0].Value;
				if (value.Length > 0)
				{
					char c = value[0];
					char c2 = '\0';
					if (value.Length > 1)
					{
						c2 = char.ToLower(value[1]);
					}
					if (c <= 'M')
					{
						if (c <= '?')
						{
							if (c != '#')
							{
								if (c == '0')
								{
									flag2 = true;
									continue;
								}
								if (c != '?')
								{
									continue;
								}
							}
							return global::NPOI.SS.Format.CellFormatType.NUMBER;
						}
						if (c <= 'D')
						{
							if (c == '@')
							{
								return global::NPOI.SS.Format.CellFormatType.TEXT;
							}
							if (c != 'D')
							{
								continue;
							}
							goto IL_144;
						}
						else if (c != 'H' && c != 'M')
						{
							continue;
						}
					}
					else if (c <= 'd')
					{
						if (c <= 'Y')
						{
							if (c != 'S')
							{
								if (c != 'Y')
								{
									continue;
								}
								goto IL_144;
							}
						}
						else if (c != '[')
						{
							if (c != 'd')
							{
								continue;
							}
							goto IL_144;
						}
						else
						{
							if (c2 == 'h' || c2 == 'm' || c2 == 's')
							{
								return global::NPOI.SS.Format.CellFormatType.ELAPSED;
							}
							if (c2 == '$')
							{
								return global::NPOI.SS.Format.CellFormatType.NUMBER;
							}
							throw new global::System.ArgumentException(string.Concat(new string[]
							{
								"Unsupported [] format block '",
								value,
								"' in '",
								fdesc,
								"' with c2: ",
								c2.ToString()
							}));
						}
					}
					else if (c <= 'm')
					{
						if (c != 'h' && c != 'm')
						{
							continue;
						}
					}
					else if (c != 's')
					{
						if (c != 'y')
						{
							continue;
						}
						goto IL_144;
					}
					flag = true;
					continue;
					IL_144:
					return global::NPOI.SS.Format.CellFormatType.DATE;
				}
			}
			if (flag)
			{
				return global::NPOI.SS.Format.CellFormatType.DATE;
			}
			if (flag2)
			{
				return global::NPOI.SS.Format.CellFormatType.NUMBER;
			}
			return global::NPOI.SS.Format.CellFormatType.TEXT;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x000297DC File Offset: 0x000279DC
		private static string QuoteSpecial(string repl, global::NPOI.SS.Format.CellFormatType type)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (char c in repl)
			{
				if (c == '\'' && type.IsSpecial('\''))
				{
					stringBuilder.Append('\0');
				}
				else
				{
					bool flag = type.IsSpecial(c);
					if (flag)
					{
						stringBuilder.Append("'");
					}
					stringBuilder.Append(c);
					if (flag)
					{
						stringBuilder.Append("'");
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00029854 File Offset: 0x00027A54
		public global::NPOI.SS.Format.CellFormatResult Apply(object value)
		{
			bool flag = this.Applies(value);
			string text;
			global::System.Drawing.Color empty;
			if (flag)
			{
				text = this.format.Format(value);
				empty = this.color;
			}
			else
			{
				text = this.format.SimpleFormat(value);
				empty = global::System.Drawing.Color.Empty;
			}
			return new global::NPOI.SS.Format.CellFormatResult(flag, text, empty);
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0002989B File Offset: 0x00027A9B
		internal global::NPOI.SS.Format.CellFormatType CellFormatType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x000298A3 File Offset: 0x00027AA3
		internal bool HasCondition
		{
			get
			{
				return this.condition != null;
			}
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x000298B0 File Offset: 0x00027AB0
		public static global::System.Text.StringBuilder ParseFormat(string fdesc, global::NPOI.SS.Format.CellFormatType type, global::NPOI.SS.Format.CellFormatPart.IPartHandler partHandler)
		{
			global::System.Text.RegularExpressions.MatchCollection matchCollection = global::NPOI.SS.Format.CellFormatPart.SPECIFICATION_PAT.Matches(fdesc);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Text.RegularExpressions.Match match = null;
			foreach (object obj in matchCollection)
			{
				global::System.Text.RegularExpressions.Match match2 = (global::System.Text.RegularExpressions.Match)obj;
				string text = global::NPOI.SS.Format.CellFormatPart.Group(match2, 0);
				if (text.Length > 0)
				{
					string text2 = partHandler.HandlePart(match2, text, type, stringBuilder);
					if (text2 == null)
					{
						char c = text[0];
						if (c <= '*')
						{
							if (c == '"')
							{
								text2 = global::NPOI.SS.Format.CellFormatPart.QuoteSpecial(text.Substring(1, text.Length - 2), type);
								goto IL_C2;
							}
							if (c == '*')
							{
								text2 = global::NPOI.SS.Format.CellFormatPart.ExpandChar(text);
								goto IL_C2;
							}
						}
						else
						{
							if (c == '\\')
							{
								text2 = global::NPOI.SS.Format.CellFormatPart.QuoteSpecial(text.Substring(1), type);
								goto IL_C2;
							}
							if (c == '_')
							{
								text2 = " ";
								goto IL_C2;
							}
						}
						text2 = text;
					}
					IL_C2:
					stringBuilder.Append(text.Replace(match2.Captures[0].Value, text2));
					if (match2.NextMatch().Index - (match2.Index + text.Length) > 0)
					{
						stringBuilder.Append(fdesc.Substring(match2.Index + text.Length, match2.NextMatch().Index - (match2.Index + text.Length)));
					}
					match = match2;
				}
			}
			if (match != null)
			{
				stringBuilder.Append(fdesc.Substring(match.Index + match.Groups[0].Value.Length));
			}
			if (type.IsSpecial('\''))
			{
				int num = 0;
				while ((num = stringBuilder.ToString().IndexOf("''", num)) >= 0)
				{
					stringBuilder.Remove(num, 2);
				}
				num = 0;
				while ((num = stringBuilder.ToString().IndexOf('\0', num)) >= 0)
				{
					stringBuilder.Remove(num, 1);
					stringBuilder.Insert(num, "''");
				}
			}
			return stringBuilder;
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00029AC4 File Offset: 0x00027CC4
		public static string QuoteReplacement(string s)
		{
			if (s.IndexOf('\\') == -1 && s.IndexOf('$') == -1)
			{
				return s;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (char c in s)
			{
				if (c == '\\' || c == '$')
				{
					stringBuilder.Append('\\');
				}
				stringBuilder.Append(c);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00029B2C File Offset: 0x00027D2C
		internal static string ExpandChar(string part)
		{
			char c = part[1];
			return c.ToString() + c.ToString() + c.ToString();
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00029B5C File Offset: 0x00027D5C
		public static string Group(global::System.Text.RegularExpressions.Match m, int g)
		{
			string value = m.Groups[g].Value;
			if (value != null)
			{
				return value;
			}
			return "";
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00029B85 File Offset: 0x00027D85
		public override string ToString()
		{
			return this.format.ToString();
		}

		// Token: 0x04000672 RID: 1650
		private global::System.Drawing.Color color;

		// Token: 0x04000673 RID: 1651
		private global::NPOI.SS.Format.CellFormatCondition condition;

		// Token: 0x04000674 RID: 1652
		private global::NPOI.SS.Format.CellFormatter format;

		// Token: 0x04000675 RID: 1653
		private global::NPOI.SS.Format.CellFormatType type;

		// Token: 0x04000676 RID: 1654
		private static global::System.Collections.Generic.Dictionary<string, global::System.Drawing.Color> NAMED_COLORS;

		// Token: 0x04000677 RID: 1655
		public static global::System.Collections.Generic.IEqualityComparer<string> CASE_INSENSITIVE_ORDER = new global::NPOI.SS.Format.CellFormatPart.CaseInsensitiveComparator();

		// Token: 0x04000678 RID: 1656
		public static global::System.Text.RegularExpressions.Regex COLOR_PAT;

		// Token: 0x04000679 RID: 1657
		public static global::System.Text.RegularExpressions.Regex CONDITION_PAT;

		// Token: 0x0400067A RID: 1658
		public static global::System.Text.RegularExpressions.Regex SPECIFICATION_PAT;

		// Token: 0x0400067B RID: 1659
		public static global::System.Text.RegularExpressions.Regex CURRENCY_PAT;

		// Token: 0x0400067C RID: 1660
		public static global::System.Text.RegularExpressions.Regex FORMAT_PAT;

		// Token: 0x0400067D RID: 1661
		public static int COLOR_GROUP;

		// Token: 0x0400067E RID: 1662
		public static int CONDITION_OPERATOR_GROUP;

		// Token: 0x0400067F RID: 1663
		public static int CONDITION_VALUE_GROUP;

		// Token: 0x04000680 RID: 1664
		public static int SPECIFICATION_GROUP;

		// Token: 0x0200059E RID: 1438
		private class CaseInsensitiveComparator : global::System.Collections.Generic.IEqualityComparer<string>
		{
			// Token: 0x06003468 RID: 13416 RVA: 0x000A32A2 File Offset: 0x000A14A2
			public bool Equals(string x, string y)
			{
				return x.Equals(y, global::System.StringComparison.InvariantCultureIgnoreCase);
			}

			// Token: 0x06003469 RID: 13417 RVA: 0x00015E16 File Offset: 0x00014016
			public int GetHashCode(string obj)
			{
				return obj.GetHashCode();
			}
		}

		// Token: 0x0200059F RID: 1439
		public interface IPartHandler
		{
			// Token: 0x0600346B RID: 13419
			string HandlePart(global::System.Text.RegularExpressions.Match m, string part, global::NPOI.SS.Format.CellFormatType type, global::System.Text.StringBuilder desc);
		}
	}
}
