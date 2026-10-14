using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Collections;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x0200007C RID: 124
	public abstract class ResourceStringBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x0600050C RID: 1292 RVA: 0x000136B2 File Offset: 0x000118B2
		protected ResourceStringBase()
		{
			if (global::Infragistics.Controls.Primitives.ResourceStringBase._ResourceStrings == null)
			{
				global::Infragistics.Controls.Primitives.ResourceStringBase._ResourceStrings = new global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Primitives.ResourceStringBase>();
			}
			global::Infragistics.Controls.Primitives.ResourceStringBase._ResourceStrings.Add(this);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000136D7 File Offset: 0x000118D7
		public override string ToString()
		{
			return this.Value;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000136DF File Offset: 0x000118DF
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x000136E7 File Offset: 0x000118E7
		public string ResourceName
		{
			get
			{
				return this._resourceName;
			}
			set
			{
				if (value != this._resourceName)
				{
					this._resourceName = value;
					this._isLoaded = false;
					base.RaisePropertyChangedEvent("Value");
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00013710 File Offset: 0x00011910
		public string Value
		{
			get
			{
				if (!this._isLoaded)
				{
					this._isLoaded = true;
					this._resourceString = (global::Infragistics.Controls.Primitives.ResourceStringBase.ResourceCache.GetResource(this) as string);
				}
				return this._resourceString;
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00013738 File Offset: 0x00011938
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static void InvalidateCachedResources()
		{
			global::Infragistics.Controls.Primitives.ResourceStringBase.ResourceCache.ClearCache();
			if (global::Infragistics.Controls.Primitives.ResourceStringBase._ResourceStrings != null)
			{
				foreach (global::Infragistics.Controls.Primitives.ResourceStringBase resourceStringBase in global::Infragistics.Controls.Primitives.ResourceStringBase._ResourceStrings)
				{
					resourceStringBase.InvalidateResource();
				}
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00013790 File Offset: 0x00011990
		private void InvalidateResource()
		{
			this._isLoaded = false;
			this._resourceString = null;
			base.RaisePropertyChangedEvent("Value");
		}

		// Token: 0x06000513 RID: 1299
		internal abstract string LoadResourceString();

		// Token: 0x040001A9 RID: 425
		private bool _isLoaded;

		// Token: 0x040001AA RID: 426
		private string _resourceName;

		// Token: 0x040001AB RID: 427
		private string _resourceString;

		// Token: 0x040001AC RID: 428
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Primitives.ResourceStringBase> _ResourceStrings;

		// Token: 0x0200007D RID: 125
		private static class ResourceCache
		{
			// Token: 0x06000514 RID: 1300 RVA: 0x000137AB File Offset: 0x000119AB
			internal static void ClearCache()
			{
				if (global::Infragistics.Controls.Primitives.ResourceStringBase.ResourceCache.s_resourceMap != null)
				{
					global::Infragistics.Controls.Primitives.ResourceStringBase.ResourceCache.s_resourceMap.Clear();
				}
			}

			// Token: 0x06000515 RID: 1301 RVA: 0x000137C0 File Offset: 0x000119C0
			internal static object GetResource(global::Infragistics.Controls.Primitives.ResourceStringBase rs)
			{
				object obj = null;
				if (global::Infragistics.Controls.Primitives.ResourceStringBase.ResourceCache.s_resourceMap == null)
				{
					global::Infragistics.Controls.Primitives.ResourceStringBase.ResourceCache.s_resourceMap = new global::System.Collections.Generic.Dictionary<string, object>();
				}
				else
				{
					global::Infragistics.Controls.Primitives.ResourceStringBase.ResourceCache.s_resourceMap.TryGetValue(rs.ResourceName, out obj);
				}
				if (obj == null)
				{
					obj = rs.LoadResourceString();
					if (obj == null)
					{
						obj = "";
					}
					global::Infragistics.Controls.Primitives.ResourceStringBase.ResourceCache.s_resourceMap[rs.ResourceName] = obj;
				}
				return obj;
			}

			// Token: 0x040001AD RID: 429
			[global::System.ThreadStatic]
			private static global::System.Collections.Generic.Dictionary<string, object> s_resourceMap;
		}
	}
}
