using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Manoli.Utils.CSharpFormat
{
	// Token: 0x02000478 RID: 1144
	internal abstract class SourceFormat
	{
		// Token: 0x06003291 RID: 12945 RVA: 0x000B8B70 File Offset: 0x000B6D70
		protected SourceFormat()
		{
			this._tabSpaces = 4;
			this._lineNumbers = false;
			this._alternate = false;
			this._embedStyleSheet = false;
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x000B8B94 File Offset: 0x000B6D94
		// (set) Token: 0x06003293 RID: 12947 RVA: 0x000B8B9C File Offset: 0x000B6D9C
		public byte TabSpaces
		{
			get
			{
				return this._tabSpaces;
			}
			set
			{
				this._tabSpaces = value;
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06003294 RID: 12948 RVA: 0x000B8BA8 File Offset: 0x000B6DA8
		// (set) Token: 0x06003295 RID: 12949 RVA: 0x000B8BB0 File Offset: 0x000B6DB0
		public bool LineNumbers
		{
			get
			{
				return this._lineNumbers;
			}
			set
			{
				this._lineNumbers = value;
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06003296 RID: 12950 RVA: 0x000B8BBC File Offset: 0x000B6DBC
		// (set) Token: 0x06003297 RID: 12951 RVA: 0x000B8BC4 File Offset: 0x000B6DC4
		public bool Alternate
		{
			get
			{
				return this._alternate;
			}
			set
			{
				this._alternate = value;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06003298 RID: 12952 RVA: 0x000B8BD0 File Offset: 0x000B6DD0
		// (set) Token: 0x06003299 RID: 12953 RVA: 0x000B8BD8 File Offset: 0x000B6DD8
		public bool EmbedStyleSheet
		{
			get
			{
				return this._embedStyleSheet;
			}
			set
			{
				this._embedStyleSheet = value;
			}
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000B8BE4 File Offset: 0x000B6DE4
		public string FormatCode(global::System.IO.Stream source)
		{
			global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(source);
			string source2 = streamReader.ReadToEnd();
			streamReader.Close();
			return this.FormatCode(source2, this._lineNumbers, this._alternate, this._embedStyleSheet, false);
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000B8C24 File Offset: 0x000B6E24
		public string FormatCode(string source)
		{
			return this.FormatCode(source, this._lineNumbers, this._alternate, this._embedStyleSheet, false);
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000B8C40 File Offset: 0x000B6E40
		public string FormatSubCode(string source)
		{
			return this.FormatCode(source, false, false, false, true);
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x000B8C50 File Offset: 0x000B6E50
		public static global::System.IO.Stream GetCssStream()
		{
			return global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Manoli.Utils.CSharpFormat.csharp.css");
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000B8C64 File Offset: 0x000B6E64
		public static string GetCssString()
		{
			global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(global::Manoli.Utils.CSharpFormat.SourceFormat.GetCssStream());
			return streamReader.ReadToEnd();
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x0600329F RID: 12959 RVA: 0x000B8C88 File Offset: 0x000B6E88
		// (set) Token: 0x060032A0 RID: 12960 RVA: 0x000B8C90 File Offset: 0x000B6E90
		protected global::System.Text.RegularExpressions.Regex CodeRegex
		{
			get
			{
				return this.codeRegex;
			}
			set
			{
				this.codeRegex = value;
			}
		}

		// Token: 0x060032A1 RID: 12961
		protected abstract string MatchEval(global::System.Text.RegularExpressions.Match match);

		// Token: 0x060032A2 RID: 12962 RVA: 0x000B8C9C File Offset: 0x000B6E9C
		private string FormatCode(string source, bool lineNumbers, bool alternate, bool embedStyleSheet, bool subCode)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(source);
			if (!subCode)
			{
				stringBuilder.Replace("&", "&amp;");
				stringBuilder.Replace("<", "&lt;");
				stringBuilder.Replace(">", "&gt;");
				stringBuilder.Replace("\t", string.Empty.PadRight((int)this._tabSpaces));
			}
			source = this.codeRegex.Replace(stringBuilder.ToString(), new global::System.Text.RegularExpressions.MatchEvaluator(this.MatchEval));
			stringBuilder = new global::System.Text.StringBuilder();
			if (embedStyleSheet)
			{
				stringBuilder.Append("<style type=\"text/css\">\n");
				stringBuilder.Append(global::Manoli.Utils.CSharpFormat.SourceFormat.GetCssString());
				stringBuilder.Append("</style>\n");
			}
			if (lineNumbers || alternate)
			{
				if (!subCode)
				{
					stringBuilder.Append("<div class=\"csharpcode\">\n");
				}
				global::System.IO.StringReader stringReader = new global::System.IO.StringReader(source);
				int num = 0;
				string text = "    ";
				string text2;
				while ((text2 = stringReader.ReadLine()) != null)
				{
					num++;
					if (alternate && num % 2 == 1)
					{
						stringBuilder.AppendFormat("<pre class=\"alt\" Id='line{0}'>", num);
					}
					else
					{
						stringBuilder.AppendFormat("<pre Id='line{0}'>", num);
					}
					if (lineNumbers)
					{
						int num2 = (int)global::System.Math.Log10((double)num);
						stringBuilder.Append("<span class=\"lnum\">" + text.Substring(0, 3 - num2) + num.ToString() + ":  </span>");
					}
					if (text2.Length == 0)
					{
						stringBuilder.Append("&nbsp;");
					}
					else
					{
						stringBuilder.Append(text2);
					}
					stringBuilder.Append("</pre>\r\n");
				}
				stringReader.Close();
				if (!subCode)
				{
					stringBuilder.Append("</div>");
				}
			}
			else
			{
				if (!subCode)
				{
					stringBuilder.Append("<pre class=\"csharpcode\">\n");
				}
				stringBuilder.Append(source);
				if (!subCode)
				{
					stringBuilder.Append("</pre>");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x040012D6 RID: 4822
		private byte _tabSpaces;

		// Token: 0x040012D7 RID: 4823
		private bool _lineNumbers;

		// Token: 0x040012D8 RID: 4824
		private bool _alternate;

		// Token: 0x040012D9 RID: 4825
		private bool _embedStyleSheet;

		// Token: 0x040012DA RID: 4826
		private global::System.Text.RegularExpressions.Regex codeRegex;
	}
}
