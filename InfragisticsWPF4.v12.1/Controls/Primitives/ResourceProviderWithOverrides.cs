using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using Infragistics.Windows.Themes;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x0200007B RID: 123
	public abstract class ResourceProviderWithOverrides<T> : global::Infragistics.Controls.Primitives.ResourceProvider<T>, global::System.ComponentModel.ISupportInitialize, global::Infragistics.Windows.Themes.IResourceWasherTarget where T : struct
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x00013378 File Offset: 0x00011578
		protected override object GetResource(T id)
		{
			int num = ((global::System.IConvertible)((object)id)).ToInt32(null);
			if (num >= 0 && num < global::Infragistics.Controls.Primitives.ResourceProvider<T>._Ids.Length)
			{
				object obj;
				if (this._values != null)
				{
					obj = this._values[num];
					if (obj != null)
					{
						if (obj == global::Infragistics.Controls.Primitives.ResourceProviderWithOverrides<T>.NullEntry)
						{
							return null;
						}
						return obj;
					}
				}
				if (this._values == null)
				{
					this._values = new object[global::Infragistics.Controls.Primitives.ResourceProvider<T>._Count];
				}
				global::System.Windows.ResourceDictionary resourceDictionary = null;
				bool isHighContrast = base.IsHighContrast;
				global::System.Windows.ResourceDictionary rd;
				if (isHighContrast && this.IsHighContrastSupported)
				{
					resourceDictionary = this._defaultResourcesHighContrast;
					rd = this.ResourceOverridesHighContrast;
				}
				else
				{
					rd = this.ResourceOverrides;
				}
				if (resourceDictionary == null)
				{
					resourceDictionary = (this._washedDefaultResources ?? this._defaultResources);
					if (resourceDictionary != null && this._resourceWasher != null && this._washedDefaultResources == null)
					{
						resourceDictionary = (this._washedDefaultResources = (global::System.Windows.ResourceDictionary)this._resourceWasher.CreateWashedResource(resourceDictionary));
					}
				}
				string text = id.ToString();
				obj = this.GetResourceHelper(rd, id, num, text, false);
				if (obj != null)
				{
					return obj;
				}
				obj = this.GetResourceHelper(resourceDictionary, id, num, text, true);
				if (obj != null)
				{
					return obj;
				}
				if (resourceDictionary != null)
				{
					global::Infragistics.Controls.Primitives.ResourceProviderWithOverrides<T>.LogDebuggerWarning(global::SR.GetString("Provider_MissingResource", new object[]
					{
						text,
						this
					}));
				}
			}
			return null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000134B1 File Offset: 0x000116B1
		public sealed override void InvalidateResources()
		{
			this._values = null;
			this._washedDefaultResources = null;
			this.OnPropertyChanged("Item[]");
			base.InvalidateResources();
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x000134D2 File Offset: 0x000116D2
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x000134DA File Offset: 0x000116DA
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsHighContrastSupported
		{
			get
			{
				return this._isHighContrastSupported;
			}
			set
			{
				if (this._isHighContrastSupported != value)
				{
					this._isHighContrastSupported = value;
					this.InvalidateResources();
					base.RaisePropertyChangedEvent("IsHighContrastSupported");
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x000134FD File Offset: 0x000116FD
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00013505 File Offset: 0x00011705
		public global::System.Windows.ResourceDictionary ResourceOverrides
		{
			get
			{
				return this._resourceOverrides;
			}
			set
			{
				if (this._resourceOverrides != value)
				{
					this._resourceOverrides = value;
					this.InvalidateResources();
					base.RaisePropertyChangedEvent("ResourceOverrides");
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00013528 File Offset: 0x00011728
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00013530 File Offset: 0x00011730
		public global::System.Windows.ResourceDictionary ResourceOverridesHighContrast
		{
			get
			{
				return this._resourceOverridesHighContrast;
			}
			set
			{
				if (this._resourceOverridesHighContrast != value)
				{
					this._resourceOverridesHighContrast = value;
					this.InvalidateResources();
					base.RaisePropertyChangedEvent("ResourceOverridesHighContrast");
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00013553 File Offset: 0x00011753
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x0001355B File Offset: 0x0001175B
		protected global::System.Windows.ResourceDictionary DefaultResources
		{
			get
			{
				return this._defaultResources;
			}
			set
			{
				if (value != this._defaultResources)
				{
					this._defaultResources = value;
					this.InvalidateResources();
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00013573 File Offset: 0x00011773
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x0001357B File Offset: 0x0001177B
		protected global::System.Windows.ResourceDictionary DefaultResourcesHighContrast
		{
			get
			{
				return this._defaultResourcesHighContrast;
			}
			set
			{
				if (value != this._defaultResourcesHighContrast)
				{
					this._defaultResourcesHighContrast = value;
					this.InvalidateResources();
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00013593 File Offset: 0x00011793
		protected internal bool IsLoading
		{
			get
			{
				return this._isLoading;
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001359B File Offset: 0x0001179B
		public virtual void BeginInit()
		{
			this._isLoading = true;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000135A4 File Offset: 0x000117A4
		public virtual void EndInit()
		{
			this._isLoading = false;
		}

		// Token: 0x06000505 RID: 1285
		protected abstract bool IsResourceValid(T id, object resource);

		// Token: 0x06000506 RID: 1286 RVA: 0x000135B0 File Offset: 0x000117B0
		private object GetResourceHelper(global::System.Windows.ResourceDictionary rd, T id, int index, string idName, bool isDefault)
		{
			if (rd == null)
			{
				return null;
			}
			object obj = null;
			if (rd.Contains(idName))
			{
				obj = rd[idName];
			}
			else if (rd.Contains(id))
			{
				obj = rd[id];
			}
			else if (!isDefault)
			{
				return null;
			}
			if (this.IsResourceValid(id, obj))
			{
				if (obj == null)
				{
					obj = global::Infragistics.Controls.Primitives.ResourceProviderWithOverrides<T>.NullEntry;
				}
				this._values[index] = obj;
				return obj;
			}
			global::Infragistics.Controls.Primitives.ResourceProviderWithOverrides<T>.LogDebuggerWarning(global::SR.GetString("Provider_InvalidResource", new object[]
			{
				id,
				this,
				(obj != null) ? obj.GetType().ToString() : "[null]"
			}));
			return null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00013659 File Offset: 0x00011859
		internal static void LogDebuggerWarning(string warning)
		{
			if (global::System.Diagnostics.Debugger.IsAttached && global::System.Diagnostics.Debugger.IsLogging())
			{
				global::System.Diagnostics.Debugger.Log(40, "Global", warning + global::System.Environment.NewLine);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00013680 File Offset: 0x00011880
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00013688 File Offset: 0x00011888
		global::Infragistics.Windows.Themes.ResourceWasher global::Infragistics.Windows.Themes.IResourceWasherTarget.ResourceWasher
		{
			get
			{
				return this._resourceWasher;
			}
			set
			{
				this._resourceWasher = value;
				this.InvalidateResources();
			}
		}

		// Token: 0x0400019F RID: 415
		private object[] _values;

		// Token: 0x040001A0 RID: 416
		private bool _isLoading;

		// Token: 0x040001A1 RID: 417
		private bool _isHighContrastSupported = true;

		// Token: 0x040001A2 RID: 418
		private global::System.Windows.ResourceDictionary _defaultResources;

		// Token: 0x040001A3 RID: 419
		private global::System.Windows.ResourceDictionary _defaultResourcesHighContrast;

		// Token: 0x040001A4 RID: 420
		private global::System.Windows.ResourceDictionary _resourceOverrides;

		// Token: 0x040001A5 RID: 421
		private global::System.Windows.ResourceDictionary _resourceOverridesHighContrast;

		// Token: 0x040001A6 RID: 422
		private global::Infragistics.Windows.Themes.ResourceWasher _resourceWasher;

		// Token: 0x040001A7 RID: 423
		private global::System.Windows.ResourceDictionary _washedDefaultResources;

		// Token: 0x040001A8 RID: 424
		private static object NullEntry = new object();
	}
}
