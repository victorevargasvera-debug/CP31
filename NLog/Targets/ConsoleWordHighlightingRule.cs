using System;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using NLog.Config;

namespace NLog.Targets
{
	// Token: 0x0200002E RID: 46
	[global::NLog.Config.NLogConfigurationItem]
	public class ConsoleWordHighlightingRule
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x0000A16F File Offset: 0x0000836F
		public ConsoleWordHighlightingRule()
		{
			this.BackgroundColor = global::NLog.Targets.ConsoleOutputColor.NoChange;
			this.ForegroundColor = global::NLog.Targets.ConsoleOutputColor.NoChange;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000A187 File Offset: 0x00008387
		public ConsoleWordHighlightingRule(string text, global::NLog.Targets.ConsoleOutputColor foregroundColor, global::NLog.Targets.ConsoleOutputColor backgroundColor)
		{
			this.Text = text;
			this.ForegroundColor = foregroundColor;
			this.BackgroundColor = backgroundColor;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0000A1A4 File Offset: 0x000083A4
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x0000A1AC File Offset: 0x000083AC
		public string Regex { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0000A1B5 File Offset: 0x000083B5
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x0000A1BD File Offset: 0x000083BD
		[global::System.ComponentModel.DefaultValue(false)]
		public bool CompileRegex { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0000A1C6 File Offset: 0x000083C6
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x0000A1CE File Offset: 0x000083CE
		public string Text { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0000A1D7 File Offset: 0x000083D7
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0000A1DF File Offset: 0x000083DF
		[global::System.ComponentModel.DefaultValue(false)]
		public bool WholeWords { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0000A1E8 File Offset: 0x000083E8
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x0000A1F0 File Offset: 0x000083F0
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IgnoreCase { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0000A1F9 File Offset: 0x000083F9
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x0000A201 File Offset: 0x00008401
		[global::System.ComponentModel.DefaultValue("NoChange")]
		public global::NLog.Targets.ConsoleOutputColor ForegroundColor { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x0000A20A File Offset: 0x0000840A
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x0000A212 File Offset: 0x00008412
		[global::System.ComponentModel.DefaultValue("NoChange")]
		public global::NLog.Targets.ConsoleOutputColor BackgroundColor { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x0000A21C File Offset: 0x0000841C
		public global::System.Text.RegularExpressions.Regex CompiledRegex
		{
			get
			{
				if (this._compiledRegex == null)
				{
					string regexExpression = this.GetRegexExpression();
					if (regexExpression == null)
					{
						return null;
					}
					global::System.Text.RegularExpressions.RegexOptions regexOptions = this.GetRegexOptions(global::System.Text.RegularExpressions.RegexOptions.Compiled);
					this._compiledRegex = new global::System.Text.RegularExpressions.Regex(regexExpression, regexOptions);
				}
				return this._compiledRegex;
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000A258 File Offset: 0x00008458
		private global::System.Text.RegularExpressions.RegexOptions GetRegexOptions(global::System.Text.RegularExpressions.RegexOptions regexOptions)
		{
			if (this.IgnoreCase)
			{
				regexOptions |= global::System.Text.RegularExpressions.RegexOptions.IgnoreCase;
			}
			return regexOptions;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000A268 File Offset: 0x00008468
		private string GetRegexExpression()
		{
			string text = this.Regex;
			if (text == null && this.Text != null)
			{
				text = global::System.Text.RegularExpressions.Regex.Escape(this.Text);
				if (this.WholeWords)
				{
					text = "\\b" + text + "\\b";
				}
			}
			return text;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000A2B0 File Offset: 0x000084B0
		private string MatchEvaluator(global::System.Text.RegularExpressions.Match m)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(m.Value.Length + 5);
			stringBuilder.Append('\a');
			stringBuilder.Append((char)(this.ForegroundColor + 65));
			stringBuilder.Append((char)(this.BackgroundColor + 65));
			stringBuilder.Append(m.Value);
			stringBuilder.Append('\a');
			stringBuilder.Append('X');
			return stringBuilder.ToString();
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000A31C File Offset: 0x0000851C
		internal string ReplaceWithEscapeSequences(string message)
		{
			if (this.CompileRegex)
			{
				global::System.Text.RegularExpressions.Regex compiledRegex = this.CompiledRegex;
				if (compiledRegex == null)
				{
					return message;
				}
				return compiledRegex.Replace(message, new global::System.Text.RegularExpressions.MatchEvaluator(this.MatchEvaluator));
			}
			else
			{
				string regexExpression = this.GetRegexExpression();
				if (regexExpression != null)
				{
					global::System.Text.RegularExpressions.RegexOptions regexOptions = this.GetRegexOptions(global::System.Text.RegularExpressions.RegexOptions.None);
					return global::System.Text.RegularExpressions.Regex.Replace(message, regexExpression, new global::System.Text.RegularExpressions.MatchEvaluator(this.MatchEvaluator), regexOptions);
				}
				return message;
			}
		}

		// Token: 0x0400007F RID: 127
		private global::System.Text.RegularExpressions.Regex _compiledRegex;
	}
}
