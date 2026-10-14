using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using NLog.MessageTemplates;

namespace NLog.Internal
{
	// Token: 0x0200010E RID: 270
	internal sealed class LogMessageTemplateFormatter : global::NLog.Internal.ILogMessageFormatter
	{
		// Token: 0x06000D03 RID: 3331 RVA: 0x0001FCEE File Offset: 0x0001DEEE
		private LogMessageTemplateFormatter(bool forceTemplateRenderer, bool singleTargetOnly)
		{
			this._forceTemplateRenderer = forceTemplateRenderer;
			this._singleTargetOnly = singleTargetOnly;
			this.MessageFormatter = new global::NLog.LogMessageFormatter(this.FormatMessage);
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0001FD17 File Offset: 0x0001DF17
		public global::NLog.LogMessageFormatter MessageFormatter { get; }

		// Token: 0x06000D05 RID: 3333 RVA: 0x0001FD20 File Offset: 0x0001DF20
		public bool HasProperties(global::NLog.LogEventInfo logEvent)
		{
			if (!this.HasParameters(logEvent))
			{
				return false;
			}
			if (this._singleTargetOnly)
			{
				global::NLog.MessageTemplates.TemplateEnumerator templateEnumerator = new global::NLog.MessageTemplates.TemplateEnumerator(logEvent.Message);
				if (templateEnumerator.MoveNext())
				{
					global::NLog.MessageTemplates.LiteralHole literalHole = templateEnumerator.Current;
					if (literalHole.MaybePositionalTemplate)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0001FD6A File Offset: 0x0001DF6A
		private bool HasParameters(global::NLog.LogEventInfo logEvent)
		{
			return logEvent.Parameters != null && !string.IsNullOrEmpty(logEvent.Message) && logEvent.Parameters.Length != 0;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0001FD90 File Offset: 0x0001DF90
		public void AppendFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder)
		{
			if (!this.HasParameters(logEvent))
			{
				builder.Append(logEvent.Message ?? string.Empty);
				return;
			}
			global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> list;
			logEvent.Message.Render(logEvent.FormatProvider ?? global::System.Globalization.CultureInfo.CurrentCulture, logEvent.Parameters, this._forceTemplateRenderer, builder, out list);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
		public string FormatMessage(global::NLog.LogEventInfo logEvent)
		{
			if (!this.HasParameters(logEvent))
			{
				return logEvent.Message;
			}
			string result;
			using (global::NLog.Internal.StringBuilderPool.ItemHolder itemHolder = global::NLog.Internal.LogMessageTemplateFormatter._builderPool.Acquire())
			{
				this.AppendToBuilder(logEvent, itemHolder.Item);
				result = itemHolder.Item.ToString();
			}
			return result;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0001FE4C File Offset: 0x0001E04C
		private void AppendToBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder)
		{
			global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> list;
			logEvent.Message.Render(logEvent.FormatProvider ?? global::System.Globalization.CultureInfo.CurrentCulture, logEvent.Parameters, this._forceTemplateRenderer, builder, out list);
			logEvent.CreateOrUpdatePropertiesInternal(false, list ?? global::NLog.Internal.ArrayHelper.Empty<global::NLog.MessageTemplates.MessageTemplateParameter>());
		}

		// Token: 0x04000397 RID: 919
		public static readonly global::NLog.Internal.LogMessageTemplateFormatter DefaultAuto = new global::NLog.Internal.LogMessageTemplateFormatter(false, false);

		// Token: 0x04000398 RID: 920
		public static readonly global::NLog.Internal.LogMessageTemplateFormatter Default = new global::NLog.Internal.LogMessageTemplateFormatter(true, false);

		// Token: 0x04000399 RID: 921
		public static readonly global::NLog.Internal.LogMessageTemplateFormatter DefaultAutoSingleTarget = new global::NLog.Internal.LogMessageTemplateFormatter(false, true);

		// Token: 0x0400039A RID: 922
		private static readonly global::NLog.Internal.StringBuilderPool _builderPool = new global::NLog.Internal.StringBuilderPool(global::System.Environment.ProcessorCount * 2, 16384, 524288);

		// Token: 0x0400039B RID: 923
		private readonly bool _forceTemplateRenderer;

		// Token: 0x0400039C RID: 924
		private readonly bool _singleTargetOnly;
	}
}
