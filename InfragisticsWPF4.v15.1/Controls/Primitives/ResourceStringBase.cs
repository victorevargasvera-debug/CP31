using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Collections;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000093 RID: 147
	public abstract class ResourceStringBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x060005CF RID: 1487 RVA: 0x000160B0 File Offset: 0x000142B0
		protected ResourceStringBase()
		{
			if (global::Infragistics.Controls.Primitives.ResourceStringBase._ResourceStrings == null)
			{
				global::Infragistics.Controls.Primitives.ResourceStringBase._ResourceStrings = new global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Primitives.ResourceStringBase>();
			}
			global::Infragistics.Controls.Primitives.ResourceStringBase._ResourceStrings.Add(this);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000160D5 File Offset: 0x000142D5
		public override string ToString()
		{
			return this.Value;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x000160DD File Offset: 0x000142DD
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x000160E5 File Offset: 0x000142E5
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0001610E File Offset: 0x0001430E
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

		// Token: 0x060005D4 RID: 1492 RVA: 0x00016138 File Offset: 0x00014338
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

		// Token: 0x060005D5 RID: 1493 RVA: 0x00016190 File Offset: 0x00014390
		private void InvalidateResource()
		{
			this._isLoaded = false;
			this._resourceString = null;
			base.RaisePropertyChangedEvent("Value");
		}

		// Token: 0x060005D6 RID: 1494
		internal abstract string LoadResourceString();

		// Token: 0x0400021F RID: 543
		private bool _isLoaded;

		// Token: 0x04000220 RID: 544
		private string _resourceName;

		// Token: 0x04000221 RID: 545
		private string _resourceString;

		// Token: 0x04000222 RID: 546
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Controls.Primitives.ResourceStringBase> _ResourceStrings;

		// Token: 0x02000094 RID: 148
		private static class ResourceCache
		{
			// Token: 0x060005D7 RID: 1495 RVA: 0x000161AB File Offset: 0x000143AB
			internal static void ClearCache()
			{
				if (global::Infragistics.Controls.Primitives.ResourceStringBase.ResourceCache.s_resourceMap != null)
				{
					global::Infragistics.Controls.Primitives.ResourceStringBase.ResourceCache.s_resourceMap.Clear();
				}
			}

			// Token: 0x060005D8 RID: 1496 RVA: 0x000161C0 File Offset: 0x000143C0
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

			// Token: 0x04000223 RID: 547
			[global::System.ThreadStatic]
			private static global::System.Collections.Generic.Dictionary<string, object> s_resourceMap;
		}
	}
}
