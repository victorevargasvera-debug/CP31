using System;
using System.Collections.Generic;
using System.Linq;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000242 RID: 578
	public class Headers : global::System.Collections.Generic.Dictionary<string, string>
	{
		// Token: 0x06001202 RID: 4610 RVA: 0x000138DD File Offset: 0x00011ADD
		public Headers() : base(global::System.StringComparer.OrdinalIgnoreCase)
		{
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x000138EA File Offset: 0x00011AEA
		public global::System.Collections.Generic.Dictionary<string, string> ToDictionary()
		{
			return this;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x000138F0 File Offset: 0x00011AF0
		public bool TryGetValues(string key, out string[] values)
		{
			values = null;
			string text;
			if (base.TryGetValue(key, out text))
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				int num = -1;
				int num2 = -1;
				bool flag = false;
				for (int i = 0; i < text.Length; i++)
				{
					char c = text[i];
					if (c == '"')
					{
						flag = !flag;
					}
					else if (flag || !char.IsWhiteSpace(c))
					{
						if (num == -1)
						{
							num = i;
						}
						if (!flag && c == ',')
						{
							if (num2 == -1)
							{
								list.Add(string.Empty);
							}
							else
							{
								list.Add(text.Substring(num, num2 + 1 - num));
							}
							num = -1;
							num2 = -1;
						}
						else
						{
							num2 = i;
						}
					}
				}
				if (num2 == -1)
				{
					list.Add(string.Empty);
				}
				else
				{
					list.Add(text.Substring(num, num2 + 1 - num));
				}
				values = list.ToArray();
				return true;
			}
			return false;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x000139C4 File Offset: 0x00011BC4
		public string[] GetCommaSeparatedValues(string key)
		{
			string[] result;
			if (this.TryGetValues(key, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x000139E0 File Offset: 0x00011BE0
		public void AppendCommaSeparatedValues(string key, params string[] values)
		{
			string str;
			if (base.TryGetValue(key, out str))
			{
				base[key] = str + "," + string.Join(",", values.Select(new global::System.Func<string, string>(global::CefSharp.DevTools.Network.Headers.QuoteIfNeeded)));
				return;
			}
			this.SetCommaSeparatedValues(key, values);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00013A2F File Offset: 0x00011C2F
		public void SetCommaSeparatedValues(string key, params string[] values)
		{
			base[key] = string.Join(",", values.Select(new global::System.Func<string, string>(global::CefSharp.DevTools.Network.Headers.QuoteIfNeeded)));
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00013A54 File Offset: 0x00011C54
		private static string QuoteIfNeeded(string value)
		{
			if (!string.IsNullOrEmpty(value) && value.Contains(',') && (value[0] != '"' || value[value.Length - 1] != '"'))
			{
				return "\"" + value + "\"";
			}
			return value;
		}
	}
}
