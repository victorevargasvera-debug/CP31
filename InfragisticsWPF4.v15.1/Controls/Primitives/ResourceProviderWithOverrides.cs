using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows.Themes;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000092 RID: 146
	public abstract class ResourceProviderWithOverrides<T> : global::Infragistics.Controls.Primitives.ResourceProvider<T>, global::System.ComponentModel.ISupportInitialize, global::Infragistics.Windows.Themes.IResourceWasherTarget where T : struct
	{
		// Token: 0x060005B9 RID: 1465 RVA: 0x00015D34 File Offset: 0x00013F34
		protected override object GetResource(T id)
		{
			int num = global::Infragistics.Controls.Primitives.ResourceProvider<T>.KeyToInt32(id);
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
				global::System.Windows.ResourceDictionary resourceDictionary2;
				if (isHighContrast && this.IsHighContrastSupported)
				{
					resourceDictionary = this._defaultResourcesHighContrast;
					resourceDictionary2 = this.ResourceOverridesHighContrast;
				}
				else
				{
					resourceDictionary2 = this.ResourceOverrides;
				}
				if (resourceDictionary == null)
				{
					resourceDictionary = (this._washedDefaultResources ?? this._defaultResources);
					if (resourceDictionary != null && this._resourceWasher != null && this._washedDefaultResources == null)
					{
						resourceDictionary = (this._washedDefaultResources = (global::System.Windows.ResourceDictionary)this._resourceWasher.CreateWashedResource(resourceDictionary));
					}
					resourceDictionary2 = (this._washedOverrideResources ?? resourceDictionary2);
					if (resourceDictionary2 != null && this._resourceWasher != null && this._washedOverrideResources == null)
					{
						resourceDictionary2 = (this._washedOverrideResources = (global::System.Windows.ResourceDictionary)this._resourceWasher.CreateWashedResource(resourceDictionary2));
					}
				}
				string text = id.ToString();
				obj = this.GetResourceHelper(resourceDictionary2, id, num, text, false);
				if (obj != null)
				{
					return obj;
				}
				obj = this.GetResourceHelper(resourceDictionary, id, num, text, true);
				if (obj != null)
				{
					return obj;
				}
				if (resourceDictionary != null && !this.IsResourceValid(id, null))
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

		// Token: 0x060005BA RID: 1466 RVA: 0x00015EA8 File Offset: 0x000140A8
		public sealed override void InvalidateResources()
		{
			this._values = null;
			this._washedDefaultResources = null;
			this._washedOverrideResources = null;
			this.OnPropertyChanged("Item[]");
			base.InvalidateResources();
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00015ED0 File Offset: 0x000140D0
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00015ED8 File Offset: 0x000140D8
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00015EFB File Offset: 0x000140FB
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00015F03 File Offset: 0x00014103
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00015F26 File Offset: 0x00014126
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00015F2E File Offset: 0x0001412E
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00015F51 File Offset: 0x00014151
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00015F59 File Offset: 0x00014159
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00015F71 File Offset: 0x00014171
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00015F79 File Offset: 0x00014179
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00015F91 File Offset: 0x00014191
		protected internal bool IsLoading
		{
			get
			{
				return this._isLoading;
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00015F99 File Offset: 0x00014199
		public virtual void BeginInit()
		{
			this._isLoading = true;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00015FA2 File Offset: 0x000141A2
		public virtual void EndInit()
		{
			this._isLoading = false;
		}

		// Token: 0x060005C8 RID: 1480
		protected abstract bool IsResourceValid(T id, object resource);

		// Token: 0x060005C9 RID: 1481 RVA: 0x00015FAC File Offset: 0x000141AC
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
					this._values[index] = global::Infragistics.Controls.Primitives.ResourceProviderWithOverrides<T>.NullEntry;
				}
				else
				{
					this._values[index] = obj;
				}
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

		// Token: 0x060005CA RID: 1482 RVA: 0x0001605E File Offset: 0x0001425E
		internal static void LogDebuggerWarning(string warning)
		{
			if (global::Infragistics.CoreUtilities.IsDebuggerLogging())
			{
				global::Infragistics.CoreUtilities.DebuggerLog(40, "Global", warning + global::System.Environment.NewLine);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0001607E File Offset: 0x0001427E
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00016086 File Offset: 0x00014286
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

		// Token: 0x04000214 RID: 532
		private object[] _values;

		// Token: 0x04000215 RID: 533
		private bool _isLoading;

		// Token: 0x04000216 RID: 534
		private bool _isHighContrastSupported = true;

		// Token: 0x04000217 RID: 535
		private global::System.Windows.ResourceDictionary _defaultResources;

		// Token: 0x04000218 RID: 536
		private global::System.Windows.ResourceDictionary _defaultResourcesHighContrast;

		// Token: 0x04000219 RID: 537
		private global::System.Windows.ResourceDictionary _resourceOverrides;

		// Token: 0x0400021A RID: 538
		private global::System.Windows.ResourceDictionary _resourceOverridesHighContrast;

		// Token: 0x0400021B RID: 539
		private global::Infragistics.Windows.Themes.ResourceWasher _resourceWasher;

		// Token: 0x0400021C RID: 540
		private global::System.Windows.ResourceDictionary _washedDefaultResources;

		// Token: 0x0400021D RID: 541
		private global::System.Windows.ResourceDictionary _washedOverrideResources;

		// Token: 0x0400021E RID: 542
		private static object NullEntry = new object();
	}
}
