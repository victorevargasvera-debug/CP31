using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000EB RID: 235
	[global::NLog.LayoutRenderers.LayoutRenderer("replace-newlines")]
	[global::NLog.LayoutRenderers.AmbientProperty("ReplaceNewLines")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public sealed class ReplaceNewLinesLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBuilderBase
	{
		// Token: 0x06000C41 RID: 3137 RVA: 0x0001E57C File Offset: 0x0001C77C
		public ReplaceNewLinesLayoutRendererWrapper()
		{
			this.Replacement = " ";
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0001E58F File Offset: 0x0001C78F
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x0001E597 File Offset: 0x0001C797
		[global::System.ComponentModel.DefaultValue(" ")]
		public string Replacement { get; set; }

		// Token: 0x06000C44 RID: 3140 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			base.Inner.RenderAppendBuilder(logEvent, builder, false);
			if (builder.Length > orgLength)
			{
				string newLine = global::System.Environment.NewLine;
				if (!string.IsNullOrEmpty(newLine) && builder.IndexOf(newLine[newLine.Length - 1], orgLength) >= 0)
				{
					string text = builder.ToString(orgLength, builder.Length - orgLength);
					text = text.Replace(newLine, this.Replacement);
					if (newLine != "\n")
					{
						string replacement = this.Replacement;
						if ((replacement == null || replacement.IndexOf('\n') < 0) && text.IndexOf('\n') >= 0)
						{
							text = text.Replace("\n", this.Replacement);
						}
					}
					builder.Length = orgLength;
					builder.Append(text);
				}
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0001E663 File Offset: 0x0001C863
		protected override void TransformFormattedMesssage(global::System.Text.StringBuilder target)
		{
		}
	}
}
