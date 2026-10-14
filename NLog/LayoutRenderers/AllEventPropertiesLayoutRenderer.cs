using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000A5 RID: 165
	[global::NLog.LayoutRenderers.LayoutRenderer("all-event-properties")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	[global::NLog.Config.MutableUnsafe]
	public class AllEventPropertiesLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000A3C RID: 2620 RVA: 0x0001A388 File Offset: 0x00018588
		public AllEventPropertiesLayoutRenderer()
		{
			this.Separator = ", ";
			this.Format = "[key]=[value]";
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0001A3A6 File Offset: 0x000185A6
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x0001A3AE File Offset: 0x000185AE
		public string Separator { get; set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0001A3B7 File Offset: 0x000185B7
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0001A3BF File Offset: 0x000185BF
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IncludeCallerInformation { get; set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0001A3C8 File Offset: 0x000185C8
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0001A3D0 File Offset: 0x000185D0
		public string Format
		{
			get
			{
				return this._format;
			}
			set
			{
				if (!value.Contains("[key]"))
				{
					throw new global::System.ArgumentException("Invalid format: [key] placeholder is missing.");
				}
				if (!value.Contains("[value]"))
				{
					throw new global::System.ArgumentException("Invalid format: [value] placeholder is missing.");
				}
				this._format = value;
				string[] array = this._format.Split(new string[]
				{
					"[key]",
					"[value]"
				}, global::System.StringSplitOptions.None);
				if (array.Length == 3)
				{
					this._beforeKey = array[0];
					this._afterKey = array[1];
					this._afterValue = array[2];
					return;
				}
				this._beforeKey = null;
				this._afterKey = null;
				this._afterValue = null;
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0001A470 File Offset: 0x00018670
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (logEvent.HasProperties)
			{
				global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, null);
				bool flag = true;
				foreach (global::System.Collections.Generic.KeyValuePair<object, object> keyValuePair in this.GetProperties(logEvent))
				{
					if (!flag)
					{
						builder.Append(this.Separator);
					}
					flag = false;
					if (this._beforeKey == null || this._afterKey == null || this._afterValue == null)
					{
						string newValue = global::System.Convert.ToString(keyValuePair.Key, formatProvider);
						string newValue2 = global::System.Convert.ToString(keyValuePair.Value, formatProvider);
						string value = this.Format.Replace("[key]", newValue).Replace("[value]", newValue2);
						builder.Append(value);
					}
					else
					{
						builder.Append(this._beforeKey);
						builder.AppendFormattedValue(keyValuePair.Key, null, formatProvider);
						builder.Append(this._afterKey);
						builder.AppendFormattedValue(keyValuePair.Value, null, formatProvider);
						builder.Append(this._afterValue);
					}
				}
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0001A58C File Offset: 0x0001878C
		private global::System.Collections.Generic.IDictionary<object, object> GetProperties(global::NLog.LogEventInfo logEvent)
		{
			if (this.IncludeCallerInformation)
			{
				return logEvent.Properties;
			}
			if (logEvent.CallSiteInformation != null)
			{
				foreach (string key in global::NLog.LayoutRenderers.AllEventPropertiesLayoutRenderer.CallerInformationAttributeNames)
				{
					if (logEvent.Properties.ContainsKey(key))
					{
						return (from p in logEvent.Properties
						where !global::NLog.LayoutRenderers.AllEventPropertiesLayoutRenderer.CallerInformationAttributeNames.Contains(p.Key)
						select p).ToDictionary((global::System.Collections.Generic.KeyValuePair<object, object> p) => p.Key, (global::System.Collections.Generic.KeyValuePair<object, object> p) => p.Value);
					}
				}
			}
			return logEvent.Properties;
		}

		// Token: 0x0400026F RID: 623
		private string _format;

		// Token: 0x04000270 RID: 624
		private string _beforeKey;

		// Token: 0x04000271 RID: 625
		private string _afterKey;

		// Token: 0x04000272 RID: 626
		private string _afterValue;

		// Token: 0x04000275 RID: 629
		private static global::System.Collections.Generic.List<string> CallerInformationAttributeNames = new global::System.Collections.Generic.List<string>
		{
			"CallerMemberName",
			"CallerFilePath",
			"CallerLineNumber"
		};
	}
}
