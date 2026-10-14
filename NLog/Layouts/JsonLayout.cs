using System;
using System.Collections.Generic;
using System.Text;
using NLog.Config;
using NLog.MessageTemplates;
using NLog.Targets;

namespace NLog.Layouts
{
	// Token: 0x0200009E RID: 158
	[global::NLog.Layouts.Layout("JsonLayout")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class JsonLayout : global::NLog.Layouts.Layout
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x00018C9C File Offset: 0x00016E9C
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x00018CD1 File Offset: 0x00016ED1
		private global::NLog.Layouts.JsonLayout.LimitRecursionJsonConvert JsonConverter
		{
			get
			{
				global::NLog.Layouts.JsonLayout.LimitRecursionJsonConvert result;
				if ((result = this._jsonConverter) == null)
				{
					result = (this._jsonConverter = new global::NLog.Layouts.JsonLayout.LimitRecursionJsonConvert(this.MaxRecursionLimit, global::NLog.Config.ConfigurationItemFactory.Default.JsonConverter));
				}
				return result;
			}
			set
			{
				this._jsonConverter = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x00018CDC File Offset: 0x00016EDC
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x00018D06 File Offset: 0x00016F06
		private global::NLog.IValueFormatter ValueFormatter
		{
			get
			{
				global::NLog.IValueFormatter result;
				if ((result = this._valueFormatter) == null)
				{
					result = (this._valueFormatter = global::NLog.Config.ConfigurationItemFactory.Default.ValueFormatter);
				}
				return result;
			}
			set
			{
				this._valueFormatter = value;
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00018D0F File Offset: 0x00016F0F
		public JsonLayout()
		{
			this.Attributes = new global::System.Collections.Generic.List<global::NLog.Layouts.JsonAttribute>();
			this.RenderEmptyObject = true;
			this.IncludeAllProperties = false;
			this.ExcludeProperties = new global::System.Collections.Generic.HashSet<string>();
			this.MaxRecursionLimit = 0;
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00018D42 File Offset: 0x00016F42
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x00018D4A File Offset: 0x00016F4A
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Layouts.JsonAttribute), "attribute")]
		public global::System.Collections.Generic.IList<global::NLog.Layouts.JsonAttribute> Attributes { get; private set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00018D53 File Offset: 0x00016F53
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x00018D5B File Offset: 0x00016F5B
		public bool SuppressSpaces { get; set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00018D64 File Offset: 0x00016F64
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x00018D6C File Offset: 0x00016F6C
		public bool RenderEmptyObject { get; set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00018D75 File Offset: 0x00016F75
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x00018D7D File Offset: 0x00016F7D
		public bool IncludeMdc { get; set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00018D86 File Offset: 0x00016F86
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00018D8E File Offset: 0x00016F8E
		public bool IncludeMdlc { get; set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00018D97 File Offset: 0x00016F97
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00018D9F File Offset: 0x00016F9F
		public bool IncludeAllProperties { get; set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00018DA8 File Offset: 0x00016FA8
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x00018DB0 File Offset: 0x00016FB0
		public global::System.Collections.Generic.ISet<string> ExcludeProperties { get; set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00018DB9 File Offset: 0x00016FB9
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x00018DC1 File Offset: 0x00016FC1
		public int MaxRecursionLimit { get; set; }

		// Token: 0x060009D0 RID: 2512 RVA: 0x00018DCA File Offset: 0x00016FCA
		protected override void InitializeLayout()
		{
			base.InitializeLayout();
			if (this.IncludeMdc)
			{
				base.ThreadAgnostic = false;
			}
			if (this.IncludeMdlc)
			{
				base.ThreadAgnostic = false;
			}
			if (this.IncludeAllProperties)
			{
				base.MutableUnsafe = true;
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00018DFF File Offset: 0x00016FFF
		protected override void CloseLayout()
		{
			this.JsonConverter = null;
			this.ValueFormatter = null;
			base.CloseLayout();
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00018E15 File Offset: 0x00017015
		internal override void PrecalculateBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			base.PrecalculateBuilderInternal(logEvent, target);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00018E20 File Offset: 0x00017020
		protected override void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			int length = target.Length;
			this.RenderJsonFormattedMessage(logEvent, target);
			if (target.Length == length && this.RenderEmptyObject)
			{
				target.Append(this.SuppressSpaces ? "{}" : "{  }");
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00018E68 File Offset: 0x00017068
		protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
		{
			return base.RenderAllocateBuilder(logEvent, null);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00018E74 File Offset: 0x00017074
		private void RenderJsonFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder sb)
		{
			int length = sb.Length;
			for (int i = 0; i < this.Attributes.Count; i++)
			{
				global::NLog.Layouts.JsonAttribute attrib = this.Attributes[i];
				int length2 = sb.Length;
				if (!this.RenderAppendJsonPropertyValue(attrib, logEvent, sb, sb.Length == length))
				{
					sb.Length = length2;
				}
			}
			if (this.IncludeMdc)
			{
				foreach (string text in global::NLog.MappedDiagnosticsContext.GetNames())
				{
					if (!string.IsNullOrEmpty(text))
					{
						object @object = global::NLog.MappedDiagnosticsContext.GetObject(text);
						this.AppendJsonPropertyValue(text, @object, null, null, global::NLog.MessageTemplates.CaptureType.Unknown, sb, sb.Length == length);
					}
				}
			}
			if (this.IncludeMdlc)
			{
				foreach (string text2 in global::NLog.MappedDiagnosticsLogicalContext.GetNames())
				{
					if (!string.IsNullOrEmpty(text2))
					{
						object object2 = global::NLog.MappedDiagnosticsLogicalContext.GetObject(text2);
						this.AppendJsonPropertyValue(text2, object2, null, null, global::NLog.MessageTemplates.CaptureType.Unknown, sb, sb.Length == length);
					}
				}
			}
			if (this.IncludeAllProperties && logEvent.HasProperties)
			{
				foreach (global::NLog.MessageTemplates.MessageTemplateParameter messageTemplateParameter in ((global::System.Collections.Generic.IEnumerable<global::NLog.MessageTemplates.MessageTemplateParameter>)logEvent.CreateOrUpdatePropertiesInternal(true, null)))
				{
					if (!string.IsNullOrEmpty(messageTemplateParameter.Name) && !this.ExcludeProperties.Contains(messageTemplateParameter.Name))
					{
						this.AppendJsonPropertyValue(messageTemplateParameter.Name, messageTemplateParameter.Value, messageTemplateParameter.Format, logEvent.FormatProvider, messageTemplateParameter.CaptureType, sb, sb.Length == length);
					}
				}
			}
			if (sb.Length > length)
			{
				this.CompleteJsonMessage(sb);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00019060 File Offset: 0x00017260
		private void BeginJsonProperty(global::System.Text.StringBuilder sb, string propName, bool beginJsonMessage)
		{
			if (beginJsonMessage)
			{
				sb.Append(this.SuppressSpaces ? "{" : "{ ");
			}
			else
			{
				sb.Append(',');
				if (!this.SuppressSpaces)
				{
					sb.Append(' ');
				}
			}
			sb.Append('"');
			sb.Append(propName);
			sb.Append('"');
			sb.Append(':');
			if (!this.SuppressSpaces)
			{
				sb.Append(' ');
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000190DB File Offset: 0x000172DB
		private void CompleteJsonMessage(global::System.Text.StringBuilder sb)
		{
			sb.Append(this.SuppressSpaces ? "}" : " }");
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000190F8 File Offset: 0x000172F8
		private void AppendJsonPropertyValue(string propName, object propertyValue, string format, global::System.IFormatProvider formatProvider, global::NLog.MessageTemplates.CaptureType captureType, global::System.Text.StringBuilder sb, bool beginJsonMessage)
		{
			this.BeginJsonProperty(sb, propName, beginJsonMessage);
			if (this.MaxRecursionLimit <= 1 && captureType == global::NLog.MessageTemplates.CaptureType.Serialize)
			{
				this.JsonConverter.SerializeObjectNoLimit(propertyValue, sb);
				return;
			}
			if (captureType == global::NLog.MessageTemplates.CaptureType.Stringify)
			{
				int length = sb.Length;
				this.ValueFormatter.FormatValue(propertyValue, format, captureType, formatProvider, sb);
				global::NLog.Layouts.JsonLayout.PerformJsonEscapeIfNeeded(sb, length);
				return;
			}
			this.JsonConverter.SerializeObject(propertyValue, sb);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00019168 File Offset: 0x00017368
		private static void PerformJsonEscapeIfNeeded(global::System.Text.StringBuilder sb, int valueStart)
		{
			if (sb.Length - valueStart <= 2)
			{
				return;
			}
			for (int i = valueStart + 1; i < sb.Length - 1; i++)
			{
				if (global::NLog.Targets.DefaultJsonSerializer.RequiresJsonEscape(sb[i], false))
				{
					string text = sb.ToString(valueStart + 1, sb.Length - valueStart - 2);
					sb.Length = valueStart;
					sb.Append('"');
					global::NLog.Targets.DefaultJsonSerializer.AppendStringEscape(sb, text, false);
					sb.Append('"');
					return;
				}
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000191DC File Offset: 0x000173DC
		private bool RenderAppendJsonPropertyValue(global::NLog.Layouts.JsonAttribute attrib, global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder sb, bool beginJsonMessage)
		{
			this.BeginJsonProperty(sb, attrib.Name, beginJsonMessage);
			if (attrib.Encode)
			{
				sb.Append('"');
			}
			int length = sb.Length;
			attrib.LayoutWrapper.RenderAppendBuilder(logEvent, sb);
			if (!attrib.IncludeEmptyValue && length == sb.Length)
			{
				return false;
			}
			if (attrib.Encode)
			{
				sb.Append('"');
			}
			return true;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00019242 File Offset: 0x00017442
		public override string ToString()
		{
			return base.ToStringWithNestedItems<global::NLog.Layouts.JsonAttribute>(this.Attributes, delegate(global::NLog.Layouts.JsonAttribute a)
			{
				string name = a.Name;
				string str = "-";
				global::NLog.Layouts.Layout layout = a.Layout;
				return name + str + ((layout != null) ? layout.ToString() : null);
			});
		}

		// Token: 0x04000253 RID: 595
		private global::NLog.Layouts.JsonLayout.LimitRecursionJsonConvert _jsonConverter;

		// Token: 0x04000254 RID: 596
		private global::NLog.IValueFormatter _valueFormatter;

		// Token: 0x020001F8 RID: 504
		private class LimitRecursionJsonConvert : global::NLog.IJsonConverter
		{
			// Token: 0x0600129F RID: 4767 RVA: 0x0003090C File Offset: 0x0002EB0C
			public LimitRecursionJsonConvert(int maxRecursionLimit, global::NLog.IJsonConverter converter)
			{
				this._converter = converter;
				this._serializer = (converter as global::NLog.Targets.DefaultJsonSerializer);
				this._serializerOptions = new global::NLog.Targets.JsonSerializeOptions
				{
					MaxRecursionLimit = global::System.Math.Max(0, maxRecursionLimit)
				};
			}

			// Token: 0x060012A0 RID: 4768 RVA: 0x0003093F File Offset: 0x0002EB3F
			public bool SerializeObject(object value, global::System.Text.StringBuilder builder)
			{
				if (this._serializer != null)
				{
					return this._serializer.SerializeObject(value, builder, this._serializerOptions);
				}
				return this._converter.SerializeObject(value, builder);
			}

			// Token: 0x060012A1 RID: 4769 RVA: 0x0003096A File Offset: 0x0002EB6A
			public bool SerializeObjectNoLimit(object value, global::System.Text.StringBuilder builder)
			{
				return this._converter.SerializeObject(value, builder);
			}

			// Token: 0x040005A9 RID: 1449
			private readonly global::NLog.IJsonConverter _converter;

			// Token: 0x040005AA RID: 1450
			private readonly global::NLog.Targets.DefaultJsonSerializer _serializer;

			// Token: 0x040005AB RID: 1451
			private readonly global::NLog.Targets.JsonSerializeOptions _serializerOptions;
		}
	}
}
