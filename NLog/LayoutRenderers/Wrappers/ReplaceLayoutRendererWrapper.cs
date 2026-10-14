using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NLog.Config;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000EA RID: 234
	[global::NLog.LayoutRenderers.LayoutRenderer("replace")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class ReplaceLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBase
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0001E361 File Offset: 0x0001C561
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x0001E369 File Offset: 0x0001C569
		public string SearchFor { get; set; }

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0001E372 File Offset: 0x0001C572
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x0001E37A File Offset: 0x0001C57A
		public bool Regex { get; set; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0001E383 File Offset: 0x0001C583
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x0001E38B File Offset: 0x0001C58B
		public string ReplaceWith { get; set; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0001E394 File Offset: 0x0001C594
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x0001E39C File Offset: 0x0001C59C
		public string ReplaceGroupName { get; set; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0001E3A5 File Offset: 0x0001C5A5
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x0001E3AD File Offset: 0x0001C5AD
		public bool IgnoreCase { get; set; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0001E3B6 File Offset: 0x0001C5B6
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x0001E3BE File Offset: 0x0001C5BE
		public bool WholeWords { get; set; }

		// Token: 0x06000C3D RID: 3133 RVA: 0x0001E3C8 File Offset: 0x0001C5C8
		protected override void InitializeLayoutRenderer()
		{
			base.InitializeLayoutRenderer();
			string text = this.SearchFor;
			if (!this.Regex)
			{
				text = global::System.Text.RegularExpressions.Regex.Escape(text);
			}
			global::System.Text.RegularExpressions.RegexOptions regexOptions = global::System.Text.RegularExpressions.RegexOptions.Compiled;
			if (this.IgnoreCase)
			{
				regexOptions |= global::System.Text.RegularExpressions.RegexOptions.IgnoreCase;
			}
			if (this.WholeWords)
			{
				text = "\\b" + text + "\\b";
			}
			this._regex = new global::System.Text.RegularExpressions.Regex(text, regexOptions);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0001E428 File Offset: 0x0001C628
		protected override string Transform(string text)
		{
			if (string.IsNullOrEmpty(this.ReplaceGroupName))
			{
				return this._regex.Replace(text, this.ReplaceWith);
			}
			global::NLog.LayoutRenderers.Wrappers.ReplaceLayoutRendererWrapper.Replacer @object = new global::NLog.LayoutRenderers.Wrappers.ReplaceLayoutRendererWrapper.Replacer(text, this.ReplaceGroupName, this.ReplaceWith);
			return this._regex.Replace(text, new global::System.Text.RegularExpressions.MatchEvaluator(@object.EvaluateMatch));
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0001E480 File Offset: 0x0001C680
		public static string ReplaceNamedGroup(string input, string groupName, string replacement, global::System.Text.RegularExpressions.Match match)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(input);
			int index = match.Index;
			int num = match.Length;
			foreach (global::System.Text.RegularExpressions.Capture capture in from c in match.Groups[groupName].Captures.OfType<global::System.Text.RegularExpressions.Capture>()
			orderby c.Index descending
			select c)
			{
				if (capture != null)
				{
					num += replacement.Length - capture.Length;
					stringBuilder.Remove(capture.Index, capture.Length);
					stringBuilder.Insert(capture.Index, replacement);
				}
			}
			int num2 = index + num;
			stringBuilder.Remove(num2, stringBuilder.Length - num2);
			stringBuilder.Remove(0, index);
			return stringBuilder.ToString();
		}

		// Token: 0x04000365 RID: 869
		private global::System.Text.RegularExpressions.Regex _regex;

		// Token: 0x02000203 RID: 515
		[global::NLog.Config.ThreadAgnostic]
		public class Replacer
		{
			// Token: 0x060012BF RID: 4799 RVA: 0x00030B04 File Offset: 0x0002ED04
			internal Replacer(string text, string replaceGroupName, string replaceWith)
			{
				this._text = text;
				this._replaceGroupName = replaceGroupName;
				this._replaceWith = replaceWith;
			}

			// Token: 0x060012C0 RID: 4800 RVA: 0x00030B21 File Offset: 0x0002ED21
			internal string EvaluateMatch(global::System.Text.RegularExpressions.Match match)
			{
				return global::NLog.LayoutRenderers.Wrappers.ReplaceLayoutRendererWrapper.ReplaceNamedGroup(this._text, this._replaceGroupName, this._replaceWith, match);
			}

			// Token: 0x040005C5 RID: 1477
			private readonly string _text;

			// Token: 0x040005C6 RID: 1478
			private readonly string _replaceGroupName;

			// Token: 0x040005C7 RID: 1479
			private readonly string _replaceWith;
		}
	}
}
