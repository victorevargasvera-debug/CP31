using System;
using System.Text;
using NLog.Internal;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000F4 RID: 244
	public abstract class WrapperLayoutRendererBuilderBase : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBase
	{
		// Token: 0x06000C7D RID: 3197 RVA: 0x0001EB77 File Offset: 0x0001CD77
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			base.Append(builder, logEvent);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0001EB84 File Offset: 0x0001CD84
		protected override void RenderInnerAndTransform(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder, int orgLength)
		{
			using (global::NLog.Internal.AppendBuilderCreator appendBuilderCreator = new global::NLog.Internal.AppendBuilderCreator(builder, true))
			{
				this.RenderFormattedMessage(logEvent, appendBuilderCreator.Builder);
				this.TransformFormattedMesssage(logEvent, appendBuilderCreator.Builder);
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0001EBD8 File Offset: 0x0001CDD8
		protected virtual void TransformFormattedMesssage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			this.TransformFormattedMesssage(target);
		}

		// Token: 0x06000C80 RID: 3200
		protected abstract void TransformFormattedMesssage(global::System.Text.StringBuilder target);

		// Token: 0x06000C81 RID: 3201 RVA: 0x0001EBE1 File Offset: 0x0001CDE1
		protected virtual void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			base.Inner.RenderAppendBuilder(logEvent, target, false);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0001EBF1 File Offset: 0x0001CDF1
		protected sealed override string Transform(string text)
		{
			throw new global::System.NotSupportedException("Use TransformFormattedMesssage");
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0001EBFD File Offset: 0x0001CDFD
		protected sealed override string RenderInner(global::NLog.LogEventInfo logEvent)
		{
			throw new global::System.NotSupportedException("Use RenderFormattedMessage");
		}
	}
}
