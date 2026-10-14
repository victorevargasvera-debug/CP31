using System;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace DevAge.Configuration
{
	// Token: 0x02000292 RID: 658
	internal class CommandLineArgs : global::System.Collections.Specialized.StringDictionary
	{
		// Token: 0x06002184 RID: 8580 RVA: 0x000776EC File Offset: 0x000758EC
		public CommandLineArgs(string Args)
		{
			if (Args == null || Args == "")
			{
				this.Extract(new string[0]);
				return;
			}
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("(['\"][^\"]+['\"])\\s*|([^\\s]+)\\s*", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled);
			global::System.Text.RegularExpressions.MatchCollection matchCollection = regex.Matches(Args);
			string[] array = new string[matchCollection.Count - 1];
			for (int i = 1; i < matchCollection.Count; i++)
			{
				array[i - 1] = matchCollection[i].Value.Trim();
			}
			this.Extract(array);
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x00077780 File Offset: 0x00075980
		public CommandLineArgs(string[] Args)
		{
			this.Extract(Args);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00077790 File Offset: 0x00075990
		private void Extract(string[] Args)
		{
			this.Clear();
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("^([/-]|--){1}(?<name>\\w+)([:=])?(?<value>.+)?$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled);
			char[] trimChars = new char[]
			{
				'"',
				'\''
			};
			string text = null;
			foreach (string text2 in Args)
			{
				global::System.Text.RegularExpressions.Match match = regex.Match(text2);
				if (!match.Success)
				{
					if (text != null)
					{
						this[text] = text2.Trim(trimChars);
					}
				}
				else
				{
					text = match.Groups["name"].Value;
					this.Add(text, match.Groups["value"].Value.Trim(trimChars));
				}
			}
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x0007785C File Offset: 0x00075A5C
		public override string ToString()
		{
			string text = "";
			foreach (object obj in this.Keys)
			{
				string text2 = (string)obj;
				string text3 = text;
				text = string.Concat(new string[]
				{
					text3,
					text2,
					"='",
					this[text2],
					"'\n"
				});
			}
			return text;
		}
	}
}
