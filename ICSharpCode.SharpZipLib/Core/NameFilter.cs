using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200006A RID: 106
	public class NameFilter : global::ICSharpCode.SharpZipLib.Core.IScanFilter
	{
		// Token: 0x0600046D RID: 1133 RVA: 0x00013882 File Offset: 0x00011A82
		public NameFilter(string filter)
		{
			this.filter_ = filter;
			this.inclusions_ = new global::System.Collections.Generic.List<global::System.Text.RegularExpressions.Regex>();
			this.exclusions_ = new global::System.Collections.Generic.List<global::System.Text.RegularExpressions.Regex>();
			this.Compile();
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000138B0 File Offset: 0x00011AB0
		public static bool IsValidExpression(string expression)
		{
			bool result = true;
			try
			{
				new global::System.Text.RegularExpressions.Regex(expression, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Singleline);
			}
			catch (global::System.ArgumentException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000138E0 File Offset: 0x00011AE0
		public static bool IsValidFilterExpression(string toTest)
		{
			bool result = true;
			try
			{
				if (toTest != null)
				{
					string[] array = global::ICSharpCode.SharpZipLib.Core.NameFilter.SplitQuoted(toTest);
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i] != null && array[i].Length > 0)
						{
							string pattern;
							if (array[i][0] == '+')
							{
								pattern = array[i].Substring(1, array[i].Length - 1);
							}
							else if (array[i][0] == '-')
							{
								pattern = array[i].Substring(1, array[i].Length - 1);
							}
							else
							{
								pattern = array[i];
							}
							new global::System.Text.RegularExpressions.Regex(pattern, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Singleline);
						}
					}
				}
			}
			catch (global::System.ArgumentException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00013984 File Offset: 0x00011B84
		public static string[] SplitQuoted(string original)
		{
			char c = '\\';
			char[] array = new char[]
			{
				';'
			};
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (!string.IsNullOrEmpty(original))
			{
				int i = -1;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				while (i < original.Length)
				{
					i++;
					if (i >= original.Length)
					{
						list.Add(stringBuilder.ToString());
					}
					else if (original[i] == c)
					{
						i++;
						if (i >= original.Length)
						{
							throw new global::System.ArgumentException("Missing terminating escape character", "original");
						}
						if (global::System.Array.IndexOf<char>(array, original[i]) < 0)
						{
							stringBuilder.Append(c);
						}
						stringBuilder.Append(original[i]);
					}
					else if (global::System.Array.IndexOf<char>(array, original[i]) >= 0)
					{
						list.Add(stringBuilder.ToString());
						stringBuilder.Length = 0;
					}
					else
					{
						stringBuilder.Append(original[i]);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00013A77 File Offset: 0x00011C77
		public override string ToString()
		{
			return this.filter_;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00013A80 File Offset: 0x00011C80
		public bool IsIncluded(string name)
		{
			bool result = false;
			if (this.inclusions_.Count == 0)
			{
				result = true;
			}
			else
			{
				using (global::System.Collections.Generic.List<global::System.Text.RegularExpressions.Regex>.Enumerator enumerator = this.inclusions_.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsMatch(name))
						{
							result = true;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00013AEC File Offset: 0x00011CEC
		public bool IsExcluded(string name)
		{
			bool result = false;
			using (global::System.Collections.Generic.List<global::System.Text.RegularExpressions.Regex>.Enumerator enumerator = this.exclusions_.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsMatch(name))
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00013B48 File Offset: 0x00011D48
		public bool IsMatch(string name)
		{
			return this.IsIncluded(name) && !this.IsExcluded(name);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00013B60 File Offset: 0x00011D60
		private void Compile()
		{
			if (this.filter_ == null)
			{
				return;
			}
			string[] array = global::ICSharpCode.SharpZipLib.Core.NameFilter.SplitQuoted(this.filter_);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null && array[i].Length > 0)
				{
					bool flag = array[i][0] != '-';
					string pattern;
					if (array[i][0] == '+')
					{
						pattern = array[i].Substring(1, array[i].Length - 1);
					}
					else if (array[i][0] == '-')
					{
						pattern = array[i].Substring(1, array[i].Length - 1);
					}
					else
					{
						pattern = array[i];
					}
					if (flag)
					{
						this.inclusions_.Add(new global::System.Text.RegularExpressions.Regex(pattern, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.Singleline));
					}
					else
					{
						this.exclusions_.Add(new global::System.Text.RegularExpressions.Regex(pattern, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.Singleline));
					}
				}
			}
		}

		// Token: 0x0400029E RID: 670
		private string filter_;

		// Token: 0x0400029F RID: 671
		private global::System.Collections.Generic.List<global::System.Text.RegularExpressions.Regex> inclusions_;

		// Token: 0x040002A0 RID: 672
		private global::System.Collections.Generic.List<global::System.Text.RegularExpressions.Regex> exclusions_;
	}
}
