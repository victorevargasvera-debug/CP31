using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;
using NLog.Internal.Fakeables;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000A7 RID: 167
	[global::NLog.LayoutRenderers.LayoutRenderer("appdomain")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class AppDomainLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000A47 RID: 2631 RVA: 0x0001A6B6 File Offset: 0x000188B6
		public AppDomainLayoutRenderer() : this(global::NLog.LogFactory.CurrentAppDomain)
		{
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0001A6C3 File Offset: 0x000188C3
		public AppDomainLayoutRenderer(global::NLog.Internal.Fakeables.IAppDomain currentDomain)
		{
			this._currentDomain = currentDomain;
			this.Format = "Long";
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0001A6DD File Offset: 0x000188DD
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0001A6E5 File Offset: 0x000188E5
		[global::NLog.Config.DefaultParameter]
		[global::System.ComponentModel.DefaultValue("Long")]
		public string Format { get; set; }

		// Token: 0x06000A4B RID: 2635 RVA: 0x0001A6EE File Offset: 0x000188EE
		protected override void InitializeLayoutRenderer()
		{
			this._assemblyName = null;
			base.InitializeLayoutRenderer();
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0001A6FD File Offset: 0x000188FD
		protected override void CloseLayoutRenderer()
		{
			this._assemblyName = null;
			base.CloseLayoutRenderer();
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0001A70C File Offset: 0x0001890C
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (this._assemblyName == null)
			{
				string formattingString = global::NLog.LayoutRenderers.AppDomainLayoutRenderer.GetFormattingString(this.Format);
				this._assemblyName = string.Format(formattingString, this._currentDomain.Id, this._currentDomain.FriendlyName);
			}
			builder.Append(this._assemblyName);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0001A764 File Offset: 0x00018964
		private static string GetFormattingString(string format)
		{
			string result;
			if (format.Equals("Long", global::System.StringComparison.OrdinalIgnoreCase))
			{
				result = "{0:0000}:{1}";
			}
			else if (format.Equals("Short", global::System.StringComparison.OrdinalIgnoreCase))
			{
				result = "{0:00}";
			}
			else
			{
				result = format;
			}
			return result;
		}

		// Token: 0x04000276 RID: 630
		private const string ShortFormat = "{0:00}";

		// Token: 0x04000277 RID: 631
		private const string LongFormat = "{0:0000}:{1}";

		// Token: 0x04000278 RID: 632
		private const string LongFormatCode = "Long";

		// Token: 0x04000279 RID: 633
		private const string ShortFormatCode = "Short";

		// Token: 0x0400027A RID: 634
		private readonly global::NLog.Internal.Fakeables.IAppDomain _currentDomain;

		// Token: 0x0400027C RID: 636
		private string _assemblyName;
	}
}
