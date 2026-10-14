using System;
using System.ComponentModel;
using NLog.Config;
using NLog.Layouts;

namespace NLog.LayoutRenderers.Wrappers
{
	// Token: 0x020000E3 RID: 227
	[global::NLog.LayoutRenderers.LayoutRenderer("cached")]
	[global::NLog.LayoutRenderers.AmbientProperty("Cached")]
	[global::NLog.LayoutRenderers.AmbientProperty("ClearCache")]
	[global::NLog.Config.ThreadAgnostic]
	public sealed class CachedLayoutRendererWrapper : global::NLog.LayoutRenderers.Wrappers.WrapperLayoutRendererBase
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x0001DF66 File Offset: 0x0001C166
		public CachedLayoutRendererWrapper()
		{
			this.Cached = true;
			this.ClearCache = (global::NLog.LayoutRenderers.Wrappers.CachedLayoutRendererWrapper.ClearCacheOption.OnInit | global::NLog.LayoutRenderers.Wrappers.CachedLayoutRendererWrapper.ClearCacheOption.OnClose);
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0001DF7C File Offset: 0x0001C17C
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x0001DF84 File Offset: 0x0001C184
		[global::System.ComponentModel.DefaultValue(true)]
		public bool Cached { get; set; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0001DF8D File Offset: 0x0001C18D
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x0001DF95 File Offset: 0x0001C195
		public global::NLog.LayoutRenderers.Wrappers.CachedLayoutRendererWrapper.ClearCacheOption ClearCache { get; set; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0001DF9E File Offset: 0x0001C19E
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x0001DFA6 File Offset: 0x0001C1A6
		public global::NLog.Layouts.Layout CacheKey { get; set; }

		// Token: 0x06000C09 RID: 3081 RVA: 0x0001DFAF File Offset: 0x0001C1AF
		protected override void InitializeLayoutRenderer()
		{
			base.InitializeLayoutRenderer();
			if ((this.ClearCache & global::NLog.LayoutRenderers.Wrappers.CachedLayoutRendererWrapper.ClearCacheOption.OnInit) == global::NLog.LayoutRenderers.Wrappers.CachedLayoutRendererWrapper.ClearCacheOption.OnInit)
			{
				this._cachedValue = null;
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0001DFC9 File Offset: 0x0001C1C9
		protected override void CloseLayoutRenderer()
		{
			base.CloseLayoutRenderer();
			if ((this.ClearCache & global::NLog.LayoutRenderers.Wrappers.CachedLayoutRendererWrapper.ClearCacheOption.OnClose) == global::NLog.LayoutRenderers.Wrappers.CachedLayoutRendererWrapper.ClearCacheOption.OnClose)
			{
				this._cachedValue = null;
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0001DFE3 File Offset: 0x0001C1E3
		protected override string Transform(string text)
		{
			return text;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0001DFE8 File Offset: 0x0001C1E8
		protected override string RenderInner(global::NLog.LogEventInfo logEvent)
		{
			if (this.Cached)
			{
				global::NLog.Layouts.Layout cacheKey = this.CacheKey;
				string text = (cacheKey != null) ? cacheKey.Render(logEvent) : null;
				if (this._cachedValue == null || this._renderedCacheKey != text)
				{
					this._cachedValue = base.RenderInner(logEvent);
					this._renderedCacheKey = text;
				}
				return this._cachedValue;
			}
			return base.RenderInner(logEvent);
		}

		// Token: 0x04000354 RID: 852
		private string _cachedValue;

		// Token: 0x04000355 RID: 853
		private string _renderedCacheKey;

		// Token: 0x02000202 RID: 514
		[global::System.Flags]
		public enum ClearCacheOption
		{
			// Token: 0x040005C2 RID: 1474
			None = 0,
			// Token: 0x040005C3 RID: 1475
			OnInit = 1,
			// Token: 0x040005C4 RID: 1476
			OnClose = 2
		}
	}
}
