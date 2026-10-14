using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000D0 RID: 208
	[global::NLog.LayoutRenderers.LayoutRenderer("processinfo")]
	[global::NLog.Config.ThreadSafe]
	public class ProcessInfoLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000B96 RID: 2966 RVA: 0x0001D11F File Offset: 0x0001B31F
		public ProcessInfoLayoutRenderer()
		{
			this.Property = global::NLog.LayoutRenderers.ProcessInfoProperty.Id;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0001D12E File Offset: 0x0001B32E
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x0001D136 File Offset: 0x0001B336
		[global::System.ComponentModel.DefaultValue("Id")]
		[global::NLog.Config.DefaultParameter]
		public global::NLog.LayoutRenderers.ProcessInfoProperty Property { get; set; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x0001D13F File Offset: 0x0001B33F
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x0001D147 File Offset: 0x0001B347
		[global::System.ComponentModel.DefaultValue(null)]
		public string Format { get; set; }

		// Token: 0x06000B9B RID: 2971 RVA: 0x0001D150 File Offset: 0x0001B350
		protected override void InitializeLayoutRenderer()
		{
			base.InitializeLayoutRenderer();
			global::System.Reflection.PropertyInfo property = typeof(global::System.Diagnostics.Process).GetProperty(this.Property.ToString());
			if (property == null)
			{
				throw new global::System.ArgumentException(string.Format("Property '{0}' not found in System.Diagnostics.Process", this.Property));
			}
			this._lateBoundPropertyGet = global::NLog.Internal.ReflectionHelpers.CreateLateBoundMethod(property.GetGetMethod());
			this._process = global::System.Diagnostics.Process.GetCurrentProcess();
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0001D1C7 File Offset: 0x0001B3C7
		protected override void CloseLayoutRenderer()
		{
			if (this._process != null)
			{
				this._process.Close();
				this._process = null;
			}
			base.CloseLayoutRenderer();
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0001D1EC File Offset: 0x0001B3EC
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (this._lateBoundPropertyGet != null)
			{
				global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, null);
				object value = this._lateBoundPropertyGet(this._process, null);
				builder.AppendFormattedValue(value, this.Format, formatProvider);
			}
		}

		// Token: 0x04000302 RID: 770
		private global::System.Diagnostics.Process _process;

		// Token: 0x04000303 RID: 771
		private global::NLog.Internal.ReflectionHelpers.LateBoundMethod _lateBoundPropertyGet;
	}
}
