using System;
using System.Collections.Generic;
using NLog.LayoutRenderers;

namespace NLog.Config
{
	// Token: 0x02000160 RID: 352
	internal class LayoutRendererFactory : global::NLog.Config.Factory<global::NLog.LayoutRenderers.LayoutRenderer, global::NLog.LayoutRenderers.LayoutRendererAttribute>
	{
		// Token: 0x06000F66 RID: 3942 RVA: 0x000279CF File Offset: 0x00025BCF
		public LayoutRendererFactory(global::NLog.Config.ConfigurationItemFactory parentFactory) : base(parentFactory)
		{
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x000279D8 File Offset: 0x00025BD8
		public void ClearFuncLayouts()
		{
			this._funcRenderers = null;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000279E1 File Offset: 0x00025BE1
		public void RegisterFuncLayout(string name, global::NLog.LayoutRenderers.FuncLayoutRenderer renderer)
		{
			this._funcRenderers = (this._funcRenderers ?? new global::System.Collections.Generic.Dictionary<string, global::NLog.LayoutRenderers.FuncLayoutRenderer>(global::System.StringComparer.OrdinalIgnoreCase));
			this._funcRenderers[name] = renderer;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00027A0C File Offset: 0x00025C0C
		public override bool TryCreateInstance(string itemName, out global::NLog.LayoutRenderers.LayoutRenderer result)
		{
			global::NLog.LayoutRenderers.FuncLayoutRenderer funcLayoutRenderer;
			if (this._funcRenderers != null && this._funcRenderers.TryGetValue(itemName, out funcLayoutRenderer))
			{
				result = funcLayoutRenderer;
				return true;
			}
			return base.TryCreateInstance(itemName, out result);
		}

		// Token: 0x04000450 RID: 1104
		private global::System.Collections.Generic.Dictionary<string, global::NLog.LayoutRenderers.FuncLayoutRenderer> _funcRenderers;
	}
}
