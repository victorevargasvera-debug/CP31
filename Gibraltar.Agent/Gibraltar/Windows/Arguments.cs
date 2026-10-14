using System;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace Gibraltar.Windows
{
	// Token: 0x020000C7 RID: 199
	internal class Arguments
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x00011E1C File Offset: 0x0001001C
		public Arguments(string[] args)
		{
			this.m_Parameters = new global::System.Collections.Specialized.StringDictionary();
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("^-{1,2}|^/|=|:", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled);
			global::System.Text.RegularExpressions.Regex regex2 = new global::System.Text.RegularExpressions.Regex("^['\"]?(.*?)['\"]?$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Compiled);
			string text = null;
			foreach (string input in args)
			{
				string[] array = regex.Split(input, 3);
				switch (array.Length)
				{
				case 1:
					if (text != null)
					{
						if (!this.m_Parameters.ContainsKey(text))
						{
							array[0] = regex2.Replace(array[0], "$1");
							this.m_Parameters.Add(text, array[0]);
						}
						text = null;
					}
					break;
				case 2:
					if (text != null && !this.m_Parameters.ContainsKey(text))
					{
						this.m_Parameters.Add(text, "true");
					}
					text = array[1];
					break;
				case 3:
					if (text != null && !this.m_Parameters.ContainsKey(text))
					{
						this.m_Parameters.Add(text, "true");
					}
					text = array[1];
					if (!this.m_Parameters.ContainsKey(text))
					{
						array[2] = regex2.Replace(array[2], "$1");
						this.m_Parameters.Add(text, array[2]);
					}
					text = null;
					break;
				}
			}
			if (text != null && !this.m_Parameters.ContainsKey(text))
			{
				this.m_Parameters.Add(text, "true");
			}
		}

		// Token: 0x170003BC RID: 956
		public string this[string argumentName]
		{
			get
			{
				return this.m_Parameters[argumentName];
			}
		}

		// Token: 0x040001D2 RID: 466
		private readonly global::System.Collections.Specialized.StringDictionary m_Parameters;
	}
}
