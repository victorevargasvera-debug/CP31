using System;
using System.Globalization;
using System.Text;
using NLog.Common;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000BD RID: 189
	[global::NLog.Config.NLogConfigurationItem]
	public abstract class LayoutRenderer : global::NLog.Internal.ISupportsInitialize, global::NLog.Internal.IRenderable, global::System.IDisposable
	{
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x0001BC61 File Offset: 0x00019E61
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x0001BC69 File Offset: 0x00019E69
		private protected global::NLog.Config.LoggingConfiguration LoggingConfiguration { protected get; private set; }

		// Token: 0x06000AFB RID: 2811 RVA: 0x0001BC74 File Offset: 0x00019E74
		public override string ToString()
		{
			global::NLog.LayoutRenderers.LayoutRendererAttribute customAttribute = base.GetType().GetCustomAttribute<global::NLog.LayoutRenderers.LayoutRendererAttribute>();
			if (customAttribute != null)
			{
				return string.Format("Layout Renderer: ${{{0}}}", customAttribute.Name);
			}
			return base.GetType().Name;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0001BCAC File Offset: 0x00019EAC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0001BCBC File Offset: 0x00019EBC
		public string Render(global::NLog.LogEventInfo logEvent)
		{
			int num = this._maxRenderedLength;
			if (num > 16384)
			{
				num = 16384;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(num);
			this.RenderAppendBuilder(logEvent, stringBuilder);
			if (stringBuilder.Length > this._maxRenderedLength)
			{
				this._maxRenderedLength = stringBuilder.Length;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0001BD0D File Offset: 0x00019F0D
		void global::NLog.Internal.ISupportsInitialize.Initialize(global::NLog.Config.LoggingConfiguration configuration)
		{
			this.Initialize(configuration);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0001BD16 File Offset: 0x00019F16
		void global::NLog.Internal.ISupportsInitialize.Close()
		{
			this.Close();
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0001BD1E File Offset: 0x00019F1E
		internal void Initialize(global::NLog.Config.LoggingConfiguration configuration)
		{
			if (this.LoggingConfiguration == null)
			{
				this.LoggingConfiguration = configuration;
			}
			if (!this._isInitialized)
			{
				this._isInitialized = true;
				this.InitializeLayoutRenderer();
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0001BD44 File Offset: 0x00019F44
		internal void Close()
		{
			if (this._isInitialized)
			{
				this.LoggingConfiguration = null;
				this._isInitialized = false;
				this.CloseLayoutRenderer();
			}
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0001BD64 File Offset: 0x00019F64
		internal void RenderAppendBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder)
		{
			if (!this._isInitialized)
			{
				this._isInitialized = true;
				this.InitializeLayoutRenderer();
			}
			try
			{
				this.Append(builder, logEvent);
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Exception in layout renderer.");
				if (ex.MustBeRethrown())
				{
					throw;
				}
			}
		}

		// Token: 0x06000B03 RID: 2819
		protected abstract void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent);

		// Token: 0x06000B04 RID: 2820 RVA: 0x0001BDB8 File Offset: 0x00019FB8
		protected virtual void InitializeLayoutRenderer()
		{
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0001BDBA File Offset: 0x00019FBA
		protected virtual void CloseLayoutRenderer()
		{
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0001BDBC File Offset: 0x00019FBC
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Close();
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0001BDC8 File Offset: 0x00019FC8
		protected global::System.IFormatProvider GetFormatProvider(global::NLog.LogEventInfo logEvent, global::System.IFormatProvider layoutCulture = null)
		{
			global::System.IFormatProvider formatProvider = logEvent.FormatProvider ?? layoutCulture;
			if (formatProvider == null && this.LoggingConfiguration != null)
			{
				formatProvider = this.LoggingConfiguration.DefaultCultureInfo;
			}
			return formatProvider;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0001BDFC File Offset: 0x00019FFC
		protected global::System.Globalization.CultureInfo GetCulture(global::NLog.LogEventInfo logEvent, global::System.Globalization.CultureInfo layoutCulture = null)
		{
			global::System.Globalization.CultureInfo cultureInfo = (logEvent.FormatProvider as global::System.Globalization.CultureInfo) ?? layoutCulture;
			if (cultureInfo == null && this.LoggingConfiguration != null)
			{
				cultureInfo = this.LoggingConfiguration.DefaultCultureInfo;
			}
			return cultureInfo;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0001BE34 File Offset: 0x0001A034
		public static void Register<T>(string name) where T : global::NLog.LayoutRenderers.LayoutRenderer
		{
			global::System.Type typeFromHandle = typeof(T);
			global::NLog.LayoutRenderers.LayoutRenderer.Register(name, typeFromHandle);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0001BE53 File Offset: 0x0001A053
		public static void Register(string name, global::System.Type layoutRendererType)
		{
			global::NLog.Config.ConfigurationItemFactory.Default.LayoutRenderers.RegisterDefinition(name, layoutRendererType);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0001BE68 File Offset: 0x0001A068
		public static void Register(string name, global::System.Func<global::NLog.LogEventInfo, object> func)
		{
			global::NLog.LayoutRenderers.LayoutRenderer.Register(name, (global::NLog.LogEventInfo info, global::NLog.Config.LoggingConfiguration configuration) => func(info));
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0001BE94 File Offset: 0x0001A094
		public static void Register(string name, global::System.Func<global::NLog.LogEventInfo, global::NLog.Config.LoggingConfiguration, object> func)
		{
			global::NLog.LayoutRenderers.FuncLayoutRenderer renderer = new global::NLog.LayoutRenderers.FuncLayoutRenderer(name, func);
			global::NLog.Config.ConfigurationItemFactory.Default.GetLayoutRenderers().RegisterFuncLayout(name, renderer);
		}

		// Token: 0x040002C7 RID: 711
		private const int MaxInitialRenderBufferLength = 16384;

		// Token: 0x040002C8 RID: 712
		private int _maxRenderedLength;

		// Token: 0x040002C9 RID: 713
		private bool _isInitialized;
	}
}
