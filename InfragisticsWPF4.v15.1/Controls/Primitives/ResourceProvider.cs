using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using Infragistics.Collections;
using Microsoft.Win32;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x0200008E RID: 142
	public abstract class ResourceProvider : global::Infragistics.PropertyChangeNotifierExtended
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x00015770 File Offset: 0x00013970
		static ResourceProvider()
		{
			global::Infragistics.Controls.Primitives.ResourceProvider._CachedIsHighContrastDirty = true;
			global::Infragistics.Controls.Primitives.ResourceProvider._Providers = new global::Infragistics.Collections.WeakSet<global::Infragistics.Controls.Primitives.ResourceProvider>();
			try
			{
				global::Infragistics.Controls.Primitives.ResourceProvider.InitUserPreferenceChanged();
				global::Infragistics.Controls.Primitives.ResourceProvider._UserPreferenceEventWired = true;
			}
			catch
			{
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000157E4 File Offset: 0x000139E4
		internal ResourceProvider()
		{
			if (global::Infragistics.Controls.Primitives.ResourceProvider._DistpatherOwer == null)
			{
				global::Infragistics.Controls.Primitives.ResourceProvider._DistpatherOwer = new global::System.Windows.DependencyObject();
			}
			if (!global::Infragistics.Controls.Primitives.ResourceProvider._UserPreferenceEventWired)
			{
				global::Infragistics.Controls.Primitives.ResourceProvider.VeriftyCachedIsHighContrast();
			}
			lock (global::Infragistics.Controls.Primitives.ResourceProvider._Providers)
			{
				global::Infragistics.Controls.Primitives.ResourceProvider._Providers.Add(this);
			}
		}

		// Token: 0x170000D1 RID: 209
		public abstract object this[object key]
		{
			get;
		}

		// Token: 0x170000D2 RID: 210
		public virtual object this[string key]
		{
			get
			{
				return this[key];
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00015855 File Offset: 0x00013A55
		private void SetIsHighContrastInternal(bool isHighContrast)
		{
			this.IsHighContrast = isHighContrast;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001585E File Offset: 0x00013A5E
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00015866 File Offset: 0x00013A66
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsHighContrast
		{
			get
			{
				return this._isHighContrast;
			}
			private set
			{
				if (this._isHighContrast != value)
				{
					this._isHighContrast = value;
					this.InvalidateResources();
					base.RaisePropertyChangedEvent("IsHighContrast");
				}
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0001588C File Offset: 0x00013A8C
		private static void OnResourceProviderChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.IResourceProviderClient resourceProviderClient = d as global::Infragistics.Controls.Primitives.IResourceProviderClient;
			if (resourceProviderClient != null)
			{
				resourceProviderClient.OnResourcesChanged();
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000158A9 File Offset: 0x00013AA9
		public static global::Infragistics.Controls.Primitives.ResourceProvider GetResourceProvider(global::System.Windows.DependencyObject target)
		{
			return (global::Infragistics.Controls.Primitives.ResourceProvider)target.GetValue(global::Infragistics.Controls.Primitives.ResourceProvider.ResourceProviderProperty);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000158BB File Offset: 0x00013ABB
		public static void SetResourceProvider(global::System.Windows.DependencyObject target, global::Infragistics.Controls.Primitives.ResourceProvider value)
		{
			target.SetValue(global::Infragistics.Controls.Primitives.ResourceProvider.ResourceProviderProperty, value);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x000158C9 File Offset: 0x00013AC9
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x000158D1 File Offset: 0x00013AD1
		public int ResourceVersion
		{
			get
			{
				return this._resourceVersion;
			}
			private set
			{
				if (this._resourceVersion != value)
				{
					this._resourceVersion = value;
					base.RaisePropertyChangedEvent("ResourceVersion");
				}
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x000158F0 File Offset: 0x00013AF0
		private static bool IsHighContrastStatic
		{
			get
			{
				if (global::Infragistics.Controls.Primitives.ResourceProvider._CachedIsHighContrastDirty)
				{
					global::Infragistics.Controls.Primitives.ResourceProvider._CachedIsHighContrastDirty = false;
					global::Infragistics.Controls.Primitives.ResourceProvider._CachedIsHighContrast = (global::System.Windows.SystemParameters.HighContrast || (global::System.Windows.SystemColors.ControlColor == global::System.Windows.Media.Colors.Black && global::System.Windows.SystemColors.ControlTextColor == global::System.Windows.Media.Colors.White) || (global::System.Windows.SystemColors.ControlColor == global::System.Windows.Media.Colors.White && global::System.Windows.SystemColors.ControlTextColor == global::System.Windows.Media.Colors.Black));
				}
				return global::Infragistics.Controls.Primitives.ResourceProvider._CachedIsHighContrast;
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00015963 File Offset: 0x00013B63
		public virtual void InvalidateResources()
		{
			this.BumpResourceVersion();
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0001596B File Offset: 0x00013B6B
		protected virtual void OnSystemColorsChanged()
		{
			this.InvalidateResources();
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00015973 File Offset: 0x00013B73
		internal void BumpResourceVersion()
		{
			this.ResourceVersion++;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00015984 File Offset: 0x00013B84
		internal void OnSystemColorsChangedInternal()
		{
			if (!global::Infragistics.Controls.Primitives.ResourceProvider._DistpatherOwer.CheckAccess())
			{
				global::Infragistics.Controls.Primitives.ResourceProvider._DistpatherOwer.Dispatcher.BeginInvoke(new global::System.Action(this.OnSystemColorsChangedInternal), new object[0]);
				return;
			}
			this.SetIsHighContrastInternal(global::Infragistics.Controls.Primitives.ResourceProvider.IsHighContrastStatic);
			this.OnSystemColorsChanged();
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000159D1 File Offset: 0x00013BD1
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void InitUserPreferenceChanged()
		{
			global::Microsoft.Win32.SystemEvents.UserPreferenceChanged += global::Infragistics.Controls.Primitives.ResourceProvider.OnUserPreferenceChanged;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000159E4 File Offset: 0x00013BE4
		private static void OnUserPreferenceChanged(object sender, global::Microsoft.Win32.UserPreferenceChangedEventArgs e)
		{
			if (e.Category == global::Microsoft.Win32.UserPreferenceCategory.Color)
			{
				global::Infragistics.Controls.Primitives.ResourceProvider.VeriftyCachedIsHighContrast();
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000159F4 File Offset: 0x00013BF4
		private static void VeriftyCachedIsHighContrast()
		{
			bool isHighContrastStatic = global::Infragistics.Controls.Primitives.ResourceProvider.IsHighContrastStatic;
			global::Infragistics.Controls.Primitives.ResourceProvider._CachedIsHighContrastDirty = true;
			if (isHighContrastStatic != global::Infragistics.Controls.Primitives.ResourceProvider.IsHighContrastStatic)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.ResourceProvider> list = null;
				lock (global::Infragistics.Controls.Primitives.ResourceProvider._Providers)
				{
					list = global::Infragistics.Controls.Primitives.ResourceProvider._Providers.ToList();
				}
				foreach (global::Infragistics.Controls.Primitives.ResourceProvider resourceProvider in list)
				{
					resourceProvider.OnSystemColorsChangedInternal();
				}
			}
		}

		// Token: 0x04000207 RID: 519
		private static readonly bool _UserPreferenceEventWired;

		// Token: 0x04000208 RID: 520
		[global::System.ThreadStatic]
		private static global::System.Windows.DependencyObject _DistpatherOwer;

		// Token: 0x04000209 RID: 521
		private bool _isHighContrast;

		// Token: 0x0400020A RID: 522
		private int _resourceVersion;

		// Token: 0x0400020B RID: 523
		private static bool _CachedIsHighContrastDirty;

		// Token: 0x0400020C RID: 524
		private static bool _CachedIsHighContrast;

		// Token: 0x0400020D RID: 525
		private static global::Infragistics.Collections.WeakSet<global::Infragistics.Controls.Primitives.ResourceProvider> _Providers;

		// Token: 0x0400020E RID: 526
		public static readonly global::System.Windows.DependencyProperty ResourceProviderProperty = global::Infragistics.DependencyPropertyUtilities.RegisterAttached("ResourceProvider", typeof(global::Infragistics.Controls.Primitives.ResourceProvider), typeof(global::Infragistics.Controls.Primitives.ResourceProvider), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.ResourceProvider.OnResourceProviderChanged)));

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060005AA RID: 1450
		internal delegate void MethodInvoker();
	}
}
