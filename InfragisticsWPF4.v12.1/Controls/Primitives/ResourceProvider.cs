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
	// Token: 0x02000077 RID: 119
	public abstract class ResourceProvider : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x00012DBC File Offset: 0x00010FBC
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

		// Token: 0x060004D4 RID: 1236 RVA: 0x00012E30 File Offset: 0x00011030
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

		// Token: 0x170000C3 RID: 195
		public abstract object this[object key]
		{
			get;
		}

		// Token: 0x170000C4 RID: 196
		public virtual object this[string key]
		{
			get
			{
				return this[key];
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00012EA1 File Offset: 0x000110A1
		private void SetIsHighContrastInternal(bool isHighContrast)
		{
			this.IsHighContrast = isHighContrast;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00012EAA File Offset: 0x000110AA
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00012EB2 File Offset: 0x000110B2
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x060004DA RID: 1242 RVA: 0x00012ED8 File Offset: 0x000110D8
		private static void OnResourceProviderChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.IResourceProviderClient resourceProviderClient = d as global::Infragistics.Controls.Primitives.IResourceProviderClient;
			if (resourceProviderClient != null)
			{
				resourceProviderClient.OnResourcesChanged();
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00012EF5 File Offset: 0x000110F5
		public static global::Infragistics.Controls.Primitives.ResourceProvider GetResourceProvider(global::System.Windows.DependencyObject target)
		{
			return (global::Infragistics.Controls.Primitives.ResourceProvider)target.GetValue(global::Infragistics.Controls.Primitives.ResourceProvider.ResourceProviderProperty);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00012F07 File Offset: 0x00011107
		public static void SetResourceProvider(global::System.Windows.DependencyObject target, global::Infragistics.Controls.Primitives.ResourceProvider value)
		{
			target.SetValue(global::Infragistics.Controls.Primitives.ResourceProvider.ResourceProviderProperty, value);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00012F15 File Offset: 0x00011115
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00012F1D File Offset: 0x0001111D
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

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00012F3C File Offset: 0x0001113C
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

		// Token: 0x060004E0 RID: 1248 RVA: 0x00012FAF File Offset: 0x000111AF
		public virtual void InvalidateResources()
		{
			this.BumpResourceVersion();
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00012FB7 File Offset: 0x000111B7
		protected virtual void OnSystemColorsChanged()
		{
			this.InvalidateResources();
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00012FBF File Offset: 0x000111BF
		internal void BumpResourceVersion()
		{
			this.ResourceVersion++;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00012FD0 File Offset: 0x000111D0
		internal void OnSystemColorsChangedInternal()
		{
			if (!global::Infragistics.Controls.Primitives.ResourceProvider._DistpatherOwer.CheckAccess())
			{
				global::Infragistics.Controls.Primitives.ResourceProvider._DistpatherOwer.Dispatcher.BeginInvoke(new global::Infragistics.Controls.Primitives.ResourceProvider.MethodInvoker(this.OnSystemColorsChangedInternal), new object[0]);
				return;
			}
			this.SetIsHighContrastInternal(global::Infragistics.Controls.Primitives.ResourceProvider.IsHighContrastStatic);
			this.OnSystemColorsChanged();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0001301D File Offset: 0x0001121D
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void InitUserPreferenceChanged()
		{
			global::Microsoft.Win32.SystemEvents.UserPreferenceChanged += global::Infragistics.Controls.Primitives.ResourceProvider.OnUserPreferenceChanged;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00013030 File Offset: 0x00011230
		private static void OnUserPreferenceChanged(object sender, global::Microsoft.Win32.UserPreferenceChangedEventArgs e)
		{
			if (e.Category == global::Microsoft.Win32.UserPreferenceCategory.Color)
			{
				global::Infragistics.Controls.Primitives.ResourceProvider.VeriftyCachedIsHighContrast();
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00013040 File Offset: 0x00011240
		private static void VeriftyCachedIsHighContrast()
		{
			bool isHighContrastStatic = global::Infragistics.Controls.Primitives.ResourceProvider.IsHighContrastStatic;
			global::Infragistics.Controls.Primitives.ResourceProvider._CachedIsHighContrastDirty = true;
			if (isHighContrastStatic != global::Infragistics.Controls.Primitives.ResourceProvider.IsHighContrastStatic)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.ResourceProvider> list = null;
				lock (global::Infragistics.Controls.Primitives.ResourceProvider._Providers)
				{
					list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Primitives.ResourceProvider>(global::Infragistics.Controls.Primitives.ResourceProvider._Providers);
				}
				foreach (global::Infragistics.Controls.Primitives.ResourceProvider resourceProvider in list)
				{
					resourceProvider.OnSystemColorsChangedInternal();
				}
			}
		}

		// Token: 0x04000192 RID: 402
		private static readonly bool _UserPreferenceEventWired;

		// Token: 0x04000193 RID: 403
		[global::System.ThreadStatic]
		private static global::System.Windows.DependencyObject _DistpatherOwer;

		// Token: 0x04000194 RID: 404
		private bool _isHighContrast;

		// Token: 0x04000195 RID: 405
		private int _resourceVersion;

		// Token: 0x04000196 RID: 406
		private static bool _CachedIsHighContrastDirty;

		// Token: 0x04000197 RID: 407
		private static bool _CachedIsHighContrast;

		// Token: 0x04000198 RID: 408
		private static global::Infragistics.Collections.WeakSet<global::Infragistics.Controls.Primitives.ResourceProvider> _Providers;

		// Token: 0x04000199 RID: 409
		public static readonly global::System.Windows.DependencyProperty ResourceProviderProperty = global::Infragistics.DependencyPropertyUtilities.RegisterAttached("ResourceProvider", typeof(global::Infragistics.Controls.Primitives.ResourceProvider), typeof(global::Infragistics.Controls.Primitives.ResourceProvider), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.ResourceProvider.OnResourceProviderChanged)));

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060004E8 RID: 1256
		internal delegate void MethodInvoker();
	}
}
