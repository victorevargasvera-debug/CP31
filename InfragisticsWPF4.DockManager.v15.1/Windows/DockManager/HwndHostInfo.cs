using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using Infragistics.Collections;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000073 RID: 115
	internal class HwndHostInfo
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00015258 File Offset: 0x00013458
		static HwndHostInfo()
		{
			global::Infragistics.Windows.DockManager.HwndHostInfo.WebBrowserType = global::System.Type.GetType("System.Windows.Controls.WebBrowser, " + typeof(global::System.Windows.Controls.Control).Assembly.FullName);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000152D0 File Offset: 0x000134D0
		internal HwndHostInfo(global::Infragistics.Windows.DockManager.IHwndHostInfoOwner owner)
		{
			this._owner = owner;
			this._hosts = new global::Infragistics.Collections.WeakList<global::System.Windows.Interop.HwndHost>();
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x000152EC File Offset: 0x000134EC
		internal bool HasHwndHost
		{
			get
			{
				bool flag = false;
				if (this._hosts.Count > 0)
				{
					flag = true;
				}
				else if (this._containers != null)
				{
					foreach (global::Infragistics.Windows.DockManager.IHwndHostContainer hwndHostContainer in this._containers)
					{
						if (hwndHostContainer.HasHwndHost)
						{
							flag = true;
							break;
						}
					}
				}
				this._lastHasHwndHostResult = new bool?(flag);
				return flag;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00015368 File Offset: 0x00013568
		internal bool HasWebBrowser
		{
			get
			{
				if (global::Infragistics.Windows.DockManager.HwndHostInfo.WebBrowserType != null)
				{
					foreach (global::System.Windows.Interop.HwndHost host in this.GetHosts())
					{
						if (global::Infragistics.Windows.DockManager.HwndHostInfo.IsWebBrowser(host))
						{
							return true;
						}
					}
					return false;
				}
				return false;
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000153CC File Offset: 0x000135CC
		internal static global::Infragistics.Windows.DockManager.HwndHostInfo GetHwndHost(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DockManager.HwndHostInfo)d.GetValue(global::Infragistics.Windows.DockManager.HwndHostInfo.HwndHostProperty);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000153DE File Offset: 0x000135DE
		internal static void SetHwndHost(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DockManager.HwndHostInfo value)
		{
			d.SetValue(global::Infragistics.Windows.DockManager.HwndHostInfo.HwndHostProperty, value);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000153EC File Offset: 0x000135EC
		private static void OnHwndHostChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Interop.HwndHost hwndHost = d as global::System.Windows.Interop.HwndHost;
			if (hwndHost != null)
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo hwndHostInfo = e.OldValue as global::Infragistics.Windows.DockManager.HwndHostInfo;
				global::Infragistics.Windows.DockManager.HwndHostInfo hwndHostInfo2 = e.NewValue as global::Infragistics.Windows.DockManager.HwndHostInfo;
				if (hwndHostInfo != null)
				{
					hwndHostInfo.Remove(hwndHost);
				}
				if (hwndHostInfo2 != null)
				{
					hwndHostInfo2.Add(hwndHost);
				}
			}
			global::Infragistics.Windows.DockManager.IHwndHostContainer hwndHostContainer = d as global::Infragistics.Windows.DockManager.IHwndHostContainer;
			if (hwndHostContainer != null)
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo hwndHostInfo3 = e.OldValue as global::Infragistics.Windows.DockManager.HwndHostInfo;
				global::Infragistics.Windows.DockManager.HwndHostInfo hwndHostInfo4 = e.NewValue as global::Infragistics.Windows.DockManager.HwndHostInfo;
				if (hwndHostInfo3 != null)
				{
					hwndHostInfo3.Remove(hwndHostContainer);
				}
				if (hwndHostInfo4 != null)
				{
					hwndHostInfo4.Add(hwndHostContainer);
				}
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0001546F File Offset: 0x0001366F
		internal global::Infragistics.Windows.DockManager.IHwndHostInfoOwner Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00015478 File Offset: 0x00013678
		internal void Add(global::System.Windows.Interop.HwndHost host)
		{
			this._hosts.Add(host);
			if (1 == this._hosts.Count && this._lastHasHwndHostResult != true)
			{
				this._owner.OnHasHostsChanged();
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000154CC File Offset: 0x000136CC
		internal void Remove(global::System.Windows.Interop.HwndHost host)
		{
			this._hosts.Remove(host);
			this._hosts.Compact();
			if (this._hosts.Count == 0 && this._lastHasHwndHostResult == true && !this.HasHwndHost)
			{
				this._owner.OnHasHostsChanged();
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00015530 File Offset: 0x00013730
		internal void Add(global::Infragistics.Windows.DockManager.IHwndHostContainer container)
		{
			if (this._containers == null)
			{
				this._containers = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DockManager.IHwndHostContainer>();
			}
			this._containers.Add(container);
			if (1 == this._containers.Count && this._lastHasHwndHostResult != true && container.HasHwndHost)
			{
				this._owner.OnHasHostsChanged();
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000155A0 File Offset: 0x000137A0
		internal void Remove(global::Infragistics.Windows.DockManager.IHwndHostContainer container)
		{
			if (this._containers != null)
			{
				this._containers.Remove(container);
				this._containers.Compact();
				if (this._containers.Count == 0 && this._lastHasHwndHostResult == true && !this.HasHwndHost)
				{
					this._owner.OnHasHostsChanged();
				}
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0001560C File Offset: 0x0001380C
		internal global::System.Windows.FrameworkElement GetFocusedHwndHost()
		{
			if (global::Infragistics.Windows.DockManager.HwndHostInfo._canCheckHasFocus)
			{
				try
				{
					foreach (global::System.Windows.Interop.HwndHost hwndHost in this.GetHosts())
					{
						if (((global::System.Windows.Interop.IKeyboardInputSink)hwndHost).HasFocusWithin())
						{
							return hwndHost;
						}
					}
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.DockManager.HwndHostInfo._canCheckHasFocus = false;
				}
			}
			return null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00015988 File Offset: 0x00013B88
		internal global::System.Collections.Generic.IEnumerable<global::System.Windows.Interop.HwndHost> GetHosts()
		{
			foreach (global::System.Windows.Interop.HwndHost host in this._hosts)
			{
				if (host != null)
				{
					yield return host;
				}
			}
			if (this._containers != null)
			{
				foreach (global::Infragistics.Windows.DockManager.IHwndHostContainer container in this._containers)
				{
					foreach (global::System.Windows.Interop.HwndHost host2 in container.GetHosts())
					{
						if (host2 != null)
						{
							yield return host2;
						}
					}
				}
			}
			yield break;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000159A8 File Offset: 0x00013BA8
		internal void HideAll()
		{
			if (!global::Infragistics.Windows.DockManager.HwndHostInfo._canHideAll)
			{
				return;
			}
			if (this._hosts.Count == 0 && (this._containers == null || this._containers.Count == 0))
			{
				return;
			}
			try
			{
				this.HideAllImpl();
			}
			catch (global::System.Security.SecurityException)
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo._canHideAll = false;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00015A04 File Offset: 0x00013C04
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private void HideAllImpl()
		{
			foreach (global::System.Windows.Interop.HwndHost hwndHost in this.GetHosts())
			{
				if (hwndHost != null)
				{
					global::System.IntPtr handle = hwndHost.Handle;
					if (global::System.IntPtr.Zero != handle)
					{
						global::Infragistics.Windows.DockManager.NativeWindowMethods.ShowWindow(handle, 0);
					}
				}
			}
			this._hosts.Compact();
			if (!this.HasHwndHost)
			{
				this._owner.OnHasHostsChanged();
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00015A88 File Offset: 0x00013C88
		internal bool HasFocusWithin()
		{
			return this.GetFocusedHwndHost() != null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00015A96 File Offset: 0x00013C96
		private static bool IsWebBrowser(global::System.Windows.Interop.HwndHost host)
		{
			return host != null && global::Infragistics.Windows.DockManager.HwndHostInfo.WebBrowserType.IsAssignableFrom(host.GetType());
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00015AB0 File Offset: 0x00013CB0
		internal static void OnHasHwndHostChanged(global::Infragistics.Windows.DockManager.IHwndHostContainer container)
		{
			global::System.Windows.DependencyObject dependencyObject = container as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(dependencyObject);
				if (hwndHost != null)
				{
					bool hasHwndHost = container.HasHwndHost;
					if (hwndHost._lastHasHwndHostResult != hasHwndHost)
					{
						hwndHost._owner.OnHasHostsChanged();
					}
				}
			}
		}

		// Token: 0x04000287 RID: 647
		private global::Infragistics.Windows.DockManager.IHwndHostInfoOwner _owner;

		// Token: 0x04000288 RID: 648
		private global::Infragistics.Collections.WeakList<global::System.Windows.Interop.HwndHost> _hosts;

		// Token: 0x04000289 RID: 649
		private static bool _canHideAll = true;

		// Token: 0x0400028A RID: 650
		private static bool _canCheckHasFocus = true;

		// Token: 0x0400028B RID: 651
		internal static readonly global::System.Type WebBrowserType;

		// Token: 0x0400028C RID: 652
		private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DockManager.IHwndHostContainer> _containers;

		// Token: 0x0400028D RID: 653
		private bool? _lastHasHwndHostResult;

		// Token: 0x0400028E RID: 654
		internal static readonly global::System.Windows.DependencyProperty HwndHostProperty = global::System.Windows.DependencyProperty.RegisterAttached("HwndHost", typeof(global::Infragistics.Windows.DockManager.HwndHostInfo), typeof(global::Infragistics.Windows.DockManager.HwndHostInfo), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits | global::System.Windows.FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.HwndHostInfo.OnHwndHostChanged)));
	}
}
