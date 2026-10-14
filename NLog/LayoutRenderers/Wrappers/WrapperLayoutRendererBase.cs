using System;
using System.Text;
using NLog.Config;
using NLog.Layouts;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000F3 RID: 243
	public abstract class WrapperLayoutRendererBase : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0001EAE7 File Offset: 0x0001CCE7
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x0001EAEF File Offset: 0x0001CCEF
		[global::NLog.Config.DefaultParameter]
		public global::NLog.Layouts.Layout Inner { get; set; }

		// Token: 0x06000C77 RID: 3191 RVA: 0x0001EAF8 File Offset: 0x0001CCF8
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			int length = builder.Length;
			try
			{
				this.RenderInnerAndTransform(logEvent, builder, length);
			}
			catch
			{
				builder.Length = length;
				throw;
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0001EB34 File Offset: 0x0001CD34
		protected virtual void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			string text = this.RenderInner(logEvent);
			builder.Append(this.Transform(logEvent, text));
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0001EB58 File Offset: 0x0001CD58
		protected virtual string Transform(global::NLog.LogEventInfo logEvent, string text)
		{
			return this.Transform(text);
		}

		// Token: 0x06000C7A RID: 3194
		protected abstract string Transform(string text);

		// Token: 0x06000C7B RID: 3195 RVA: 0x0001EB61 File Offset: 0x0001CD61
		protected virtual string RenderInner(global::NLog.LogEventInfo logEvent)
		{
			return this.Inner.Render(logEvent);
		}
	}
}
