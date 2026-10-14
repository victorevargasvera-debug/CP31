using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Practices.Prism
{
	// Token: 0x0200008D RID: 141
	public class UriQuery : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>>, global::System.Collections.IEnumerable
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x0000A74A File Offset: 0x0000894A
		public UriQuery()
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000A760 File Offset: 0x00008960
		public UriQuery(string query)
		{
			if (query != null)
			{
				int length = query.Length;
				for (int i = (query.Length > 0 && query[0] == '?') ? 1 : 0; i < length; i++)
				{
					int num = i;
					int num2 = -1;
					while (i < length)
					{
						char c = query[i];
						if (c == '=')
						{
							if (num2 < 0)
							{
								num2 = i;
							}
						}
						else if (c == '&')
						{
							break;
						}
						i++;
					}
					string text = null;
					string stringToUnescape;
					if (num2 >= 0)
					{
						text = query.Substring(num, num2 - num);
						stringToUnescape = query.Substring(num2 + 1, i - num2 - 1);
					}
					else
					{
						stringToUnescape = query.Substring(num, i - num);
					}
					this.Add((text != null) ? global::System.Uri.UnescapeDataString(text) : null, global::System.Uri.UnescapeDataString(stringToUnescape));
					if (i == length - 1 && query[i] == '&')
					{
						this.Add(null, "");
					}
				}
			}
		}

		// Token: 0x170000D5 RID: 213
		public string this[string key]
		{
			get
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in this.entries)
				{
					if (string.Compare(keyValuePair.Key, key, global::System.StringComparison.Ordinal) == 0)
					{
						return keyValuePair.Value;
					}
				}
				return null;
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000A8B8 File Offset: 0x00008AB8
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator()
		{
			return this.entries.GetEnumerator();
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000A8CA File Offset: 0x00008ACA
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000A8D2 File Offset: 0x00008AD2
		public void Add(string key, string value)
		{
			this.entries.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(key, value));
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000A8E8 File Offset: 0x00008AE8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (this.entries.Count > 0)
			{
				stringBuilder.Append('?');
				bool flag = true;
				foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in this.entries)
				{
					if (!flag)
					{
						stringBuilder.Append('&');
					}
					else
					{
						flag = false;
					}
					stringBuilder.Append(global::System.Uri.EscapeDataString(keyValuePair.Key));
					stringBuilder.Append('=');
					stringBuilder.Append(global::System.Uri.EscapeDataString(keyValuePair.Value));
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040000DE RID: 222
		private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> entries = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();
	}
}
