using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.OpenXml4Net.Exceptions;

namespace NPOI.OpenXml4Net.OPC.Internal
{
	// Token: 0x02000020 RID: 32
	public class ContentType : global::System.IComparable
	{
		// Token: 0x06000163 RID: 355 RVA: 0x00007348 File Offset: 0x00005548
		static ContentType()
		{
			string text = "[\\x21\\x23-\\x27\\x2A\\x2B\\x2D\\x2E0-9A-Z\\x5E\\x5F\\x60a-z\\x7E]";
			string text2 = string.Concat(new string[]
			{
				"(",
				text,
				"+)=(\"?",
				text,
				"+\"?)"
			});
			global::NPOI.OpenXml4Net.OPC.Internal.ContentType.patternTypeSubType = new global::System.Text.RegularExpressions.Regex(string.Concat(new string[]
			{
				"^(",
				text,
				"+)/(",
				text,
				"+)$"
			}));
			global::NPOI.OpenXml4Net.OPC.Internal.ContentType.patternTypeSubTypeParams = new global::System.Text.RegularExpressions.Regex(string.Concat(new string[]
			{
				"^(",
				text,
				"+)/(",
				text,
				"+)(;",
				text2,
				")*$"
			}));
			global::NPOI.OpenXml4Net.OPC.Internal.ContentType.patternParams = new global::System.Text.RegularExpressions.Regex(";" + text2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00007414 File Offset: 0x00005614
		public ContentType(string contentType)
		{
			global::System.Text.RegularExpressions.Match match = global::NPOI.OpenXml4Net.OPC.Internal.ContentType.patternTypeSubType.Match(contentType);
			if (!match.Success)
			{
				match = global::NPOI.OpenXml4Net.OPC.Internal.ContentType.patternTypeSubTypeParams.Match(contentType);
			}
			if (!match.Success)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("The specified content type '" + contentType + "' is not compliant with RFC 2616: malformed content type.");
			}
			if (match.Groups.Count >= 2)
			{
				this.type = match.Groups[1].Value;
				this.subType = match.Groups[2].Value;
				this.parameters = new global::System.Collections.Generic.Dictionary<string, string>();
				if (match.Groups.Count >= 5)
				{
					global::System.Text.RegularExpressions.Match match2 = global::NPOI.OpenXml4Net.OPC.Internal.ContentType.patternParams.Match(contentType.Substring(match.Groups[2].Index + match.Groups[2].Length));
					while (match2.Success)
					{
						this.parameters.Add(match2.Groups[1].Value, match2.Groups[2].Value);
						match2 = match2.NextMatch();
					}
					return;
				}
			}
			else
			{
				this.type = "";
				this.subType = "";
				this.parameters = new global::System.Collections.Generic.Dictionary<string, string>();
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00007554 File Offset: 0x00005754
		public override string ToString()
		{
			return this.ToString(true);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007560 File Offset: 0x00005760
		public string ToString(bool withParameters)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(this.Type);
			stringBuilder.Append("/");
			stringBuilder.Append(this.SubType);
			if (withParameters)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in this.parameters)
				{
					stringBuilder.Append(";");
					stringBuilder.Append(keyValuePair.Key);
					stringBuilder.Append("=");
					stringBuilder.Append(keyValuePair.Value);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00007618 File Offset: 0x00005818
		public string ToStringWithParameters()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(this.ToString());
			foreach (string text in this.parameters.Keys)
			{
				stringBuilder.Append(";");
				stringBuilder.Append(text);
				stringBuilder.Append("=");
				stringBuilder.Append(this.parameters[text]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000076B8 File Offset: 0x000058B8
		public override bool Equals(object obj)
		{
			return !(obj is global::NPOI.OpenXml4Net.OPC.Internal.ContentType) || this.ToString().Equals(obj.ToString(), global::System.StringComparison.InvariantCultureIgnoreCase);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000076D6 File Offset: 0x000058D6
		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000076E3 File Offset: 0x000058E3
		public string SubType
		{
			get
			{
				return this.subType;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000076EB File Offset: 0x000058EB
		public string Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000076F3 File Offset: 0x000058F3
		public bool HasParameters()
		{
			return this.parameters != null && this.parameters.Count != 0;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000770D File Offset: 0x0000590D
		public string[] GetParameterKeys()
		{
			if (this.parameters == null)
			{
				return new string[0];
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.AddRange(this.parameters.Keys);
			return list.ToArray();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007739 File Offset: 0x00005939
		public string GetParameter(string key)
		{
			return this.parameters[key];
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00007747 File Offset: 0x00005947
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return -1;
			}
			if (this.Equals(obj))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x04000096 RID: 150
		private string type;

		// Token: 0x04000097 RID: 151
		private string subType;

		// Token: 0x04000098 RID: 152
		private global::System.Collections.Hashtable p;

		// Token: 0x04000099 RID: 153
		private global::System.Collections.Generic.Dictionary<string, string> parameters;

		// Token: 0x0400009A RID: 154
		private static global::System.Text.RegularExpressions.Regex patternTypeSubType;

		// Token: 0x0400009B RID: 155
		private static global::System.Text.RegularExpressions.Regex patternTypeSubTypeParams;

		// Token: 0x0400009C RID: 156
		private static global::System.Text.RegularExpressions.Regex patternParams;
	}
}
