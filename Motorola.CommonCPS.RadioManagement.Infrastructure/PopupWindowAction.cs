using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Controls.Editors;
using Infragistics.Controls.Editors.Primitives;
using Infragistics.Windows.Editors;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Win32;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200002A RID: 42
	public class PopupWindowAction : global::System.Windows.Interactivity.TriggerAction<global::System.Windows.FrameworkElement>
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00008F24 File Offset: 0x00007124
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00008FE0 File Offset: 0x000071E0
		public global::System.Windows.FrameworkElement Content
		{
			get
			{
				short num = (short)1935246972;
				short num2 = num;
				num = (short)1393198716;
				switch (num2 == num)
				{
				}
				num = (short)1397161985;
				if (num != 0)
				{
				}
				num = (short)981729280;
				if (num != 0)
				{
				}
				num = (short)1554448384;
				short num3 = num;
				return (global::System.Windows.FrameworkElement)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.ContentProperty);
			}
			set
			{
				short num = (short)1962662554;
				short num2 = num;
				num = (short)552524442;
				switch (num2 == num)
				{
				}
				num = (short)735838209;
				if (num != 0)
				{
				}
				num = (short)610205696;
				if (num != 0)
				{
				}
				num = (short)1473183744;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.ContentProperty, value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00009094 File Offset: 0x00007294
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000914C File Offset: 0x0000734C
		public bool IsBorderless
		{
			get
			{
				short num = (short)589837961;
				short num2 = num;
				num = (short)306132617;
				switch (num2 == num)
				{
				}
				num = (short)2042560512;
				if (num != 0)
				{
				}
				num = (short)1030160385;
				if (num != 0)
				{
				}
				num = (short)13762560;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsBorderlessProperty);
			}
			set
			{
				short num = (short)2111153946;
				short num2 = num;
				num = (short)1896720154;
				switch (num2 == num)
				{
				}
				num = (short)1993146369;
				if (num != 0)
				{
				}
				num = (short)1301610496;
				if (num != 0)
				{
				}
				num = (short)2111700992;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsBorderlessProperty, value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00009208 File Offset: 0x00007408
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000092C4 File Offset: 0x000074C4
		public bool IsCentered
		{
			get
			{
				short num = (short)1701068427;
				short num2 = num;
				num = (short)1721843339;
				switch (num2 == num)
				{
				}
				num = (short)1610481664;
				if (num != 0)
				{
				}
				num = (short)1363148801;
				if (num != 0)
				{
				}
				num = (short)1254948864;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsCenteredProperty);
			}
			set
			{
				short num = (short)1671456262;
				short num2 = num;
				num = (short)1458660870;
				switch (num2 == num)
				{
				}
				num = (short)949157889;
				if (num != 0)
				{
				}
				num = (short)340525056;
				if (num != 0)
				{
				}
				num = (short)663486464;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsCenteredProperty, value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000937C File Offset: 0x0000757C
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00009434 File Offset: 0x00007634
		public bool IsTopMost
		{
			get
			{
				short num = (short)1675833850;
				short num2 = num;
				num = (short)177484282;
				switch (num2 == num)
				{
				}
				num = (short)362610689;
				if (num != 0)
				{
				}
				num = (short)1952710656;
				if (num != 0)
				{
				}
				num = (short)1031864320;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsTopMostProperty);
			}
			set
			{
				short num = (short)272391484;
				short num2 = num;
				num = (short)1421040956;
				switch (num2 == num)
				{
				}
				num = (short)218628097;
				if (num != 0)
				{
				}
				num = (short)685899776;
				if (num != 0)
				{
				}
				num = (short)29818880;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsModalProperty, value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000094EC File Offset: 0x000076EC
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000095A8 File Offset: 0x000077A8
		public bool IsModal
		{
			get
			{
				short num = (short)451831732;
				short num2 = num;
				num = (short)627140532;
				switch (num2 == num)
				{
				}
				num = (short)52232193;
				if (num != 0)
				{
				}
				num = (short)1733623808;
				if (num != 0)
				{
				}
				num = (short)572588032;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsModalProperty);
			}
			set
			{
				short num = (short)1638362713;
				short num2 = num;
				num = (short)256274009;
				switch (num2 == num)
				{
				}
				num = (short)991166464;
				if (num != 0)
				{
				}
				num = (short)1943928833;
				if (num != 0)
				{
				}
				num = (short)539754496;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsModalProperty, value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00009660 File Offset: 0x00007860
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00009718 File Offset: 0x00007918
		public bool IsMaximizationEnabled
		{
			get
			{
				short num = (short)1082654720;
				short num2 = num;
				num = (short)1099362465;
				short num3 = num;
				num = (short)1479340193;
				switch (num3 == num)
				{
				}
				num = (short)2095382529;
				if (num != 0)
				{
				}
				num = (short)748158976;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsMaximizationEnabledProperty);
			}
			set
			{
				short num = (short)2079260672;
				short num2 = num;
				num = (short)32336987;
				short num3 = num;
				num = (short)1842310235;
				switch (num3 == num)
				{
				}
				num = (short)2065629184;
				if (num != 0)
				{
				}
				num = (short)1336737793;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsMaximizationEnabledProperty, value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000097D0 File Offset: 0x000079D0
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000988C File Offset: 0x00007A8C
		public bool IsCloseable
		{
			get
			{
				short num = (short)1073676288;
				short num2 = num;
				num = (short)1413480449;
				if (num != 0)
				{
				}
				num = (short)269687915;
				short num3 = num;
				num = (short)1206983787;
				switch (num3 == num)
				{
				}
				num = (short)834732032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsCloseableProperty);
			}
			set
			{
				short num = (short)1496580096;
				short num2 = num;
				num = (short)2113132027;
				short num3 = num;
				num = (short)539874811;
				switch (num3 == num)
				{
				}
				num = (short)667549697;
				if (num != 0)
				{
				}
				num = (short)553844736;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsCloseableProperty, value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00009948 File Offset: 0x00007B48
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00009A04 File Offset: 0x00007C04
		public int Width
		{
			get
			{
				short num = (short)1403322368;
				short num2 = num;
				num = (short)785171358;
				short num3 = num;
				num = (short)610124702;
				switch (num3 == num)
				{
				}
				num = (short)1552220160;
				if (num != 0)
				{
				}
				num = (short)153550849;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.WidthProperty);
			}
			set
			{
				short num = (short)715915264;
				short num2 = num;
				num = (short)263811608;
				short num3 = num;
				num = (short)1959621144;
				switch (num3 == num)
				{
				}
				num = (short)947847169;
				if (num != 0)
				{
				}
				num = (short)795344896;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.WidthProperty, value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00009ABC File Offset: 0x00007CBC
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00009B74 File Offset: 0x00007D74
		public int Height
		{
			get
			{
				short num = (short)8650752;
				short num2 = num;
				num = (short)1600214975;
				short num3 = num;
				num = (short)1966888895;
				switch (num3 == num)
				{
				}
				num = (short)1877606401;
				if (num != 0)
				{
				}
				num = (short)781778944;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.HeigthProperty);
			}
			set
			{
				short num = (short)927727616;
				short num2 = num;
				num = (short)1729042025;
				short num3 = num;
				num = (short)2047153769;
				switch (num3 == num)
				{
				}
				num = (short)656408576;
				if (num != 0)
				{
				}
				num = (short)143327233;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.HeigthProperty, value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00009C30 File Offset: 0x00007E30
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00009CEC File Offset: 0x00007EEC
		public bool DisableMinimalizingButtonInWindow
		{
			get
			{
				short num = (short)293470208;
				short num2 = num;
				num = (short)1942917652;
				short num3 = num;
				num = (short)1279037972;
				switch (num3 == num)
				{
				}
				num = (short)259784705;
				if (num != 0)
				{
				}
				num = (short)699924480;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.DisableMinimalizingButtonInWindowProperty);
			}
			set
			{
				short num = (short)795738112;
				short num2 = num;
				num = (short)724157339;
				short num3 = num;
				num = (short)834978715;
				switch (num3 == num)
				{
				}
				num = (short)843841537;
				if (num != 0)
				{
				}
				num = (short)907149312;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.DisableMinimalizingButtonInWindowProperty, value);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00009DA8 File Offset: 0x00007FA8
		public PopupWindowAction()
		{
			this.a = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>();
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00009DCC File Offset: 0x00007FCC
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00009E88 File Offset: 0x00008088
		public bool ResizeWindow
		{
			get
			{
				short num = (short)1284440064;
				short num2 = num;
				num = (short)148997602;
				short num3 = num;
				num = (short)1909491170;
				switch (num3 == num)
				{
				}
				num = (short)1443168257;
				if (num != 0)
				{
				}
				num = (short)924778496;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.ResizeWindowProperty);
			}
			set
			{
				short num = (short)261292032;
				short num2 = num;
				num = (short)1696000178;
				short num3 = num;
				num = (short)1444341938;
				switch (num3 == num)
				{
				}
				num = (short)228655105;
				if (num != 0)
				{
				}
				num = (short)98893824;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.ResizeWindowProperty, value);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00009F44 File Offset: 0x00008144
		protected override void Invoke(object parameter)
		{
			short num = (short)2043740160;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification context;
				for (;;)
				{
					IL_27:
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_9AD;
					case 1:
						goto IL_466;
					case 2:
						this.b.WindowStyle = global::System.Windows.WindowStyle.None;
						this.b.AllowsTransparency = true;
						this.b.Background = global::System.Windows.Media.Brushes.Transparent;
						num = (short)32243717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1597440001;
						if (num != 0)
						{
						}
						num = (short)127139854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_9AD;
					case 5:
						goto IL_44B;
					case 6:
						flag = false;
						goto IL_354;
					case 7:
						goto IL_44B;
					case 8:
						goto IL_3A1;
					case 9:
						num = (short)12910611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						this.b.ResizeMode = global::System.Windows.ResizeMode.CanResizeWithGrip;
						this.b.Width = (double)this.Width;
						this.b.Height = (double)this.Height;
						this.b.MinWidth = (double)this.Width;
						this.b.MinHeight = (double)this.Height;
						num = (short)131072000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						try
						{
							num = (short)1013776385;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_AD1;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A5E;
									}
									continue;
								case 2:
									this.b.Topmost = true;
									num = (short)720699395;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_AA1;
								}
								IL_A5E:
								if (this.IsTopMost)
								{
									num = (short)349110274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_AA1:
								global::System.Windows.Input.Mouse.OverrideCursor = global::System.Windows.Input.Cursors.Arrow;
								this.b.ShowDialog();
								num = (short)183631872;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_AD1:
							return;
						}
						finally
						{
							global::System.Windows.Input.Cursor overrideCursor;
							global::System.Windows.Input.Mouse.OverrideCursor = overrideCursor;
						}
						goto IL_ADB;
					case 12:
						return;
					case 13:
					{
						global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase popoupViewModelBase = ((global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequestedEventArgs)parameter).Context as global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase;
						if (this.Content == null)
						{
							if (context is global::Motorola.CommonCPS.RadioManagement.UIModels.RetryConfirmation)
							{
								this.b = new global::Motorola.CommonCPS.RadioManagement.Controls.RMRetryWindow();
							}
							else if (context is global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Confirmation)
							{
								this.b = new global::Motorola.CommonCPS.RadioManagement.Controls.RMConfirmationWindow();
							}
							else
							{
								this.b = new global::Motorola.CommonCPS.RadioManagement.Controls.RMNotificationWindow();
							}
							this.b.DataContext = context;
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FlowDirectionHelper.SetUIFlowDirection(this.b);
						}
						else
						{
							if (this.b != null && this.b.IsVisible && !this.d)
							{
								this.b.Close();
							}
							global::Motorola.CommonCPS.RadioManagement.Controls.RMConfirmationWindow rmconfirmationWindow;
							if (!this.IsCloseable)
							{
								(rmconfirmationWindow = new global::Motorola.CommonCPS.RadioManagement.Controls.RMConfirmationWindow()).CanBeClose = false;
							}
							else
							{
								rmconfirmationWindow = new global::System.Windows.Window();
							}
							this.b = rmconfirmationWindow;
							if (this.DisableMinimalizingButtonInWindow)
							{
								this.b = new global::Motorola.CommonCPS.RadioManagement.Controls.RMDisableMinimalizeButtonWindow();
							}
							this.b.Content = this.Content;
							this.b.DataContext = context;
							if (this.ResizeWindow)
							{
								if (!double.IsNaN(this.Content.Width) && !double.IsNaN(this.Content.Height))
								{
									this.Width = (int)global::System.Convert.ToInt16(this.Content.Width);
									this.Height = (int)global::System.Convert.ToInt16(this.Content.Height);
								}
								this.Content.Height = double.NaN;
								this.Content.Width = double.NaN;
							}
							this.c = this.IsCloseable;
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FlowDirectionHelper.SetUIFlowDirection(this.b);
							if (!(this.Content.GetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionManagerProperty) is global::Microsoft.Practices.Prism.Regions.IRegionManager))
							{
								global::Microsoft.Practices.Prism.Regions.IRegionManager value = new global::Microsoft.Practices.Prism.Regions.RegionManager();
								this.Content.SetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionManagerProperty, value);
							}
							global::Motorola.CommonCPS.RadioManagement.Infrastructure.IPopupWindowActionAware popupWindowActionAware = this.Content.DataContext as global::Motorola.CommonCPS.RadioManagement.Infrastructure.IPopupWindowActionAware;
							if (popupWindowActionAware != null)
							{
								popupWindowActionAware.Notification = context;
								popupWindowActionAware.Window = this.b;
							}
						}
						this.b.Title = context.Title;
						this.b.WindowStartupLocation = global::System.Windows.WindowStartupLocation.CenterOwner;
						this.b.Closing += this.a;
						this.b.Loaded += new global::System.Windows.RoutedEventHandler(this.a);
						global::Microsoft.Win32.SystemEvents.DisplaySettingsChanged += this.b;
						if (popoupViewModelBase == null)
						{
							num = (short)1798766598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = popoupViewModelBase.SetFocusOnFirstTextControl;
						goto IL_354;
					}
					case 14:
						if (this.Height != 0)
						{
							num = (short)247988234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D9;
					case 15:
						if (this.IsModal)
						{
							num = (short)718864401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ADB;
					case 16:
						goto IL_9AD;
					case 17:
					{
						this.b.ShowInTaskbar = false;
						this.b.Topmost = global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.b();
						global::System.Windows.Input.Cursor overrideCursor = global::System.Windows.Input.Mouse.OverrideCursor;
						num = (short)1507721227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (this.IsBorderless)
						{
							num = (short)2002714626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b.Icon = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ApplicationIcon;
						num = (short)2121662471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						num = (short)870444148;
						short num3 = num;
						num = (short)1782967412;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_466;
						default:
							num = (short)1722810368;
							if (num != 0)
							{
							}
							if (this.Width != 0)
							{
								num = (short)2060648451;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8D9;
						}
						break;
					}
					case 20:
						if (!this.IsMaximizationEnabled)
						{
							num = (short)288030729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b.ResizeMode = global::System.Windows.ResizeMode.CanResizeWithGrip;
						this.b.Width = (double)((int)(global::System.Windows.SystemParameters.PrimaryScreenWidth * 0.9));
						this.b.Height = (double)((int)(global::System.Windows.SystemParameters.PrimaryScreenHeight * 0.9));
						this.b.MinWidth = this.b.Width / 2.0;
						this.b.MinHeight = this.b.Height / 2.0;
						num = (short)363724816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						this.b.IsVisibleChanged += this.a;
						num = (short)414449672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_86;
					IL_354:
					if (flag)
					{
						num = (short)1342767125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3A1:
					num = (short)1458372626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44B:
					num = (short)1212088321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_466:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_4BD;
						}
						global::System.Windows.Window window;
						for (;;)
						{
							IL_472:
							switch (num2)
							{
							case 0:
								if (global::System.Windows.Application.Current.MainWindow.IsVisible)
								{
									num = (short)1740308485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_56D;
							case 1:
								num = (short)553123854;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_71B;
							case 3:
								num = (short)1347420160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								this.b.Owner = global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a(window);
								num = (short)28246031;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								window = global::System.Windows.Application.Current.MainWindow;
								num = (short)620101641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (window != null)
								{
									num = (short)652017668;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_695;
							case 7:
								goto IL_734;
							case 8:
								if (global::System.Windows.Application.Current != null)
								{
									num = (short)797769744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_56D;
							case 9:
								goto IL_56D;
							case 10:
								new global::System.Windows.Interop.WindowInteropHelper(this.b).Owner = global::Motorola.CommonCPS.RadioManagement.Infrastructure.b.GetActiveWindow();
								num = (short)151715842;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								if (this.b.Owner == null)
								{
									num = (short)2029256714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_71B;
							case 12:
								if (window == null)
								{
									num = (short)2136735747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_56D;
							case 13:
								if (global::System.Windows.Application.Current.MainWindow != null)
								{
									num = (short)1101725697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_56D;
							case 14:
								window = global::System.Windows.Application.Current.Windows.OfType<global::System.Windows.Window>().SingleOrDefault(new global::System.Func<global::System.Windows.Window, bool>(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.<>c.<>9.a));
								num = (short)439025676;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
								goto IL_695;
							case 16:
								num = (short)1494548493;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4BD;
							IL_56D:
							num = (short)2007105542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_695:
							num = (short)421462027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_71B:
							num = (short)1173946375;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_734:
						goto IL_739;
						IL_4BD:
						window = null;
						num = (short)1134100488;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_472;
					}
					catch (global::System.Exception)
					{
					}
					IL_739:
					num = (short)1973092372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D9:
					this.b.SizeToContent = global::System.Windows.SizeToContent.WidthAndHeight;
					this.b.ResizeMode = global::System.Windows.ResizeMode.NoResize;
					num = (short)1120337924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9AD:
					num = (short)994836495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ADB:
					this.b.Show();
					this.b.Activate();
					num = (short)1531117580;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_86:
				num = (short)69468160;
				short num4 = num;
				context = ((global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.InteractionRequestedEventArgs)parameter).Context;
				num = (short)219021325;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000AA94 File Offset: 0x00008C94
		private static bool b()
		{
			short num = (short)703040874;
			short num2 = num;
			num = (short)1233751402;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1852178432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1300037632;
			if (num != 0)
			{
			}
			num = (short)1100677121;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.IsGlueWindowWorkingNow;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000AB44 File Offset: 0x00008D44
		private static global::System.Windows.Window a(global::System.Windows.Window A_0)
		{
			short num = (short)1842085891;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (A_0.Owner == null)
					{
						num = (short)1658716160;
						short num3 = num;
						num = (short)1185611777;
						if (num != 0)
						{
						}
						num = (short)312803329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_0 = A_0.Owner;
					num = (short)1072258823;
					short num4 = num;
					num = (short)19685127;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return A_0;
					default:
						num = (short)762576896;
						if (num != 0)
						{
						}
						num = (short)713293826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return A_0;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_37:
				num = (short)1512177664;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35:
				goto IL_37;
			}
			return A_0;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000AC84 File Offset: 0x00008E84
		private void a(string A_0)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1266089984;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				int num3;
				string[] source;
				for (;;)
				{
					IL_34:
					switch (num3)
					{
					case 0:
						if (this.b is global::Motorola.CommonCPS.RadioManagement.Controls.RMConfirmationWindow)
						{
							num = (short)872742916;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_198;
					case 1:
						return;
					case 2:
						goto IL_153;
					case 3:
						if (!A_0.StartsWith(source.Last<string>(), global::System.StringComparison.Ordinal))
						{
							num = (short)1285685249;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1561591808;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1659542163;
						short num4 = num;
						num = (short)1766169235;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1481179137;
							if (num != 0)
							{
							}
							num = (short)1487339520;
							if (num != 0)
							{
							}
							((global::Motorola.CommonCPS.RadioManagement.Controls.RMConfirmationWindow)this.b).CanBeClose = (this.c = true);
							num = (short)853540866;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_4E:
				source = this.b.Content.ToString().Split(new char[]
				{
					'.'
				});
				num = (short)520355843;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
			return;
			IL_153:
			IL_198:
			this.b.Close();
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ClosePopupWindowRequestedEvent>().Unsubscribe(new global::System.Action<string>(this.a));
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000AE50 File Offset: 0x00009050
		private void b(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)535560193;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)488112129;
				if (num != 0)
				{
				}
				num = (short)55312384;
				short num3 = num;
				switch (num2)
				{
				case 0:
					this.b.MaxHeight = global::System.Windows.SystemParameters.PrimaryScreenHeight;
					this.b.MaxWidth = global::System.Windows.SystemParameters.PrimaryScreenWidth;
					num = (short)691273730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				case 2:
					return;
				}
				IL_81:
				num = (short)1165402954;
				short num4 = num;
				num = (short)2105713482;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)84017152;
					if (num != 0)
					{
					}
					if (this.b == null)
					{
						return;
					}
					num = (short)2037383168;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000AF84 File Offset: 0x00009184
		private void a(object A_0, global::System.ComponentModel.CancelEventArgs A_1)
		{
			short num;
			while (this.a())
			{
				num = (short)690920233;
				short num2 = num;
				num = (short)478649129;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)678756353;
					if (num != 0)
					{
					}
					num = (short)345767936;
					if (num != 0)
					{
					}
					this.d = true;
					this.b.Closing -= this.a;
					this.b.Loaded -= new global::System.Windows.RoutedEventHandler(this.a);
					global::Microsoft.Win32.SystemEvents.DisplaySettingsChanged -= this.b;
					string[] source = this.b.Content.ToString().Split(new char[]
					{
						'.'
					});
					this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PopupWindowClosedEvent>().Publish(source.Last<string>());
					this.d = false;
					return;
				}
				}
			}
			num = (short)159776768;
			short num3 = num;
			A_1.Cancel = true;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000B0C8 File Offset: 0x000092C8
		private bool a()
		{
			short num = (short)1066729472;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 1:
					goto IL_ED;
				case 2:
					num = (short)1770258436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)982344604;
					short num3 = num;
					num = (short)186934172;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_159;
					default:
						goto IL_98;
					}
					break;
				}
				case 4:
					if (!this.c)
					{
						num = (short)677249025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					goto IL_159;
				}
				IL_3C:
				if (!(this.b is global::Motorola.CommonCPS.RadioManagement.Controls.RMConfirmationWindow))
				{
					num = (short)543031299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1487798272;
				short num4 = num;
				num = (short)218300421;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_159:
				if (((global::Motorola.CommonCPS.RadioManagement.Controls.RMConfirmationWindow)this.b).CanBeClose)
				{
					return true;
				}
				num = (short)57081858;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_98:
			num = (short)1966538752;
			if (num != 0)
			{
			}
			return true;
			IL_ED:
			num = (short)1352335361;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000B264 File Offset: 0x00009464
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)182918466;
			short num2 = num;
			num = (short)1283726658;
			switch (num2 == num)
			{
			}
			num = (short)935264256;
			short num3 = num;
			num = (short)1955594240;
			if (num != 0)
			{
			}
			num = (short)1678180353;
			if (num != 0)
			{
			}
			this.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ClosePopupWindowRequestedEvent>().Subscribe(new global::System.Action<string>(this.a));
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000B32C File Offset: 0x0000952C
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1701249025;
			if (num != 0)
			{
			}
			if (!(bool)A_1.NewValue)
			{
				num = (short)2092806542;
				short num2 = num;
				num = (short)1579528590;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)513277952;
					short num3 = num;
					num = (short)1171193856;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.c((global::System.Windows.Window)A_0);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000B3F4 File Offset: 0x000095F4
		// Note: this type is marked as 'beforefieldinit'.
		static PopupWindowAction()
		{
			int a_ = 9;
			short num = (short)446496768;
			short num2 = num;
			num = (short)1802404658;
			short num3 = num;
			num = (short)197165874;
			switch (num3 == num)
			{
			}
			num = (short)792592385;
			if (num != 0)
			{
			}
			num = (short)386334720;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.ContentProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("戠䰢䬤匦䰨䔪夬", a_), typeof(global::System.Windows.FrameworkElement), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsBorderlessProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("栠倢朤䠦嬨伪䠬崮崰嘲䘴䐶", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsCenteredProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("栠倢昤䈦䜨弪䠬崮吰圲", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsTopMostProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("栠倢焤䠦夨昪䈬尮䔰", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsModalProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("栠倢栤䠦䴨䨪䄬", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsMaximizationEnabledProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("栠倢栤䘦儨䈪䀬䘮䬰刲䄴帶嘸唺砼儾⁀⅂⥄≆ⵈ", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.IsCloseableProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("栠倢昤䬦䘨堪䠬丮匰弲倴", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction), new global::System.Windows.PropertyMetadata(true));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.WidthProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("瘠䨢䄤匦䄨", a_), typeof(int), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.HeigthProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("椠䘢䰤䀦䄨弪", a_), typeof(int), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.DisableMinimalizingButtonInWindowProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("攠䨢嘤䘦䬨䜪䠬戮堰崲尴娶堸场吼䔾⡀ⵂ≄Ն㱈㽊㥌⁎㽐ᩒ㭔Vじ㕚㥜ぞᙠ", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.ResizeWindowProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("猠䘢嘤並匨个稬䘮弰圲娴䀶", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction));
		}

		// Token: 0x04000028 RID: 40
		private readonly global::Microsoft.Practices.Prism.Events.IEventAggregator a;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Window b;

		// Token: 0x0400002A RID: 42
		private bool c;

		// Token: 0x0400002B RID: 43
		private bool d;

		// Token: 0x0400002C RID: 44
		public static readonly global::System.Windows.DependencyProperty ContentProperty;

		// Token: 0x0400002D RID: 45
		public static readonly global::System.Windows.DependencyProperty IsBorderlessProperty;

		// Token: 0x0400002E RID: 46
		public static readonly global::System.Windows.DependencyProperty IsCenteredProperty;

		// Token: 0x0400002F RID: 47
		public static readonly global::System.Windows.DependencyProperty IsTopMostProperty;

		// Token: 0x04000030 RID: 48
		public static readonly global::System.Windows.DependencyProperty IsModalProperty;

		// Token: 0x04000031 RID: 49
		public static readonly global::System.Windows.DependencyProperty IsMaximizationEnabledProperty;

		// Token: 0x04000032 RID: 50
		public static readonly global::System.Windows.DependencyProperty IsCloseableProperty;

		// Token: 0x04000033 RID: 51
		public static readonly global::System.Windows.DependencyProperty WidthProperty;

		// Token: 0x04000034 RID: 52
		public static readonly global::System.Windows.DependencyProperty HeigthProperty;

		// Token: 0x04000035 RID: 53
		public static readonly global::System.Windows.DependencyProperty DisableMinimalizingButtonInWindowProperty;

		// Token: 0x04000036 RID: 54
		public static readonly global::System.Windows.DependencyProperty ResizeWindowProperty;

		// Token: 0x0200002B RID: 43
		private static class a
		{
			// Token: 0x060000A5 RID: 165 RVA: 0x0000B698 File Offset: 0x00009898
			internal static void c(global::System.Windows.Window A_0)
			{
				short num = (short)325124096;
				short num2 = num;
				num = (short)1491213164;
				short num3 = num;
				num = (short)1351359340;
				switch (num3 == num)
				{
				}
				num = (short)52101121;
				if (num != 0)
				{
				}
				num = (short)621740032;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a a = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a();
				a.a = A_0;
				a.a.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.ApplicationIdle, new global::System.Action(a.b));
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x0000B770 File Offset: 0x00009970
			private static void b(global::System.Windows.Window A_0)
			{
				short num = (short)1236499855;
				short num2 = num;
				num = (short)856456591;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1157955584;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a.Clear();
					if (A_0.IsLoaded)
					{
						num = (short)1370161152;
						short num3 = num;
						global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a(A_0);
						return;
					}
					break;
				}
				num = (short)1580662785;
				if (num != 0)
				{
				}
				b2.b = null;
				b2.b = new global::System.Windows.RoutedEventHandler(b2.c);
				b2.a.Loaded += b2.b;
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x0000B874 File Offset: 0x00009A74
			private static void a(global::System.Windows.Window A_0)
			{
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				global::System.Windows.IInputElement focusedElement;
				short num2;
				global::System.Windows.Input.TraversalRequest traversalRequest;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_E9;
					case 1:
						goto IL_19F;
					case 2:
						goto IL_1DE;
					case 3:
						focusedElement = global::System.Windows.Input.FocusManager.GetFocusedElement(A_0);
						num2 = (short)1608056837;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_19F;
					case 5:
						if (global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a.Contains(focusedElement))
						{
							num2 = (short)1319960576;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a.Add(focusedElement);
						num2 = (short)526450692;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						return;
					case 7:
						num2 = (short)699006984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						if (global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a(focusedElement, traversalRequest))
						{
							num2 = (short)888668163;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_19F;
					case 9:
					{
						if (global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a(focusedElement))
						{
							return;
						}
						num2 = (short)2060343886;
						short num3 = num2;
						num2 = (short)1870813774;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DE;
						default:
							num2 = (short)1905721344;
							if (num2 != 0)
							{
							}
							num2 = (short)2141716487;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_38;
					IL_1DE:
					if (focusedElement == null)
					{
						num2 = (short)1342963718;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1277624329;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_19F:
					num2 = (short)1637482497;
					if (num2 != 0)
					{
					}
					num2 = (short)867827714;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E9:
				num2 = (short)363790336;
				short num4 = num2;
				global::System.Windows.IInputElement focusedElement2;
				global::System.Windows.Input.FocusManager.SetFocusedElement(A_0, focusedElement2);
				return;
				IL_38:
				focusedElement2 = global::System.Windows.Input.FocusManager.GetFocusedElement(A_0);
				traversalRequest = new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First);
				A_0.MoveFocus(traversalRequest);
				focusedElement = global::System.Windows.Input.FocusManager.GetFocusedElement(A_0);
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a.Add(focusedElement);
				traversalRequest = new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Next);
				num2 = (short)714604545;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x0000BAC4 File Offset: 0x00009CC4
			private static bool a(global::System.Windows.IInputElement A_0, global::System.Windows.Input.TraversalRequest A_1)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				global::System.Windows.ContentElement contentElement;
				short num2;
				global::System.Windows.UIElement uielement;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (contentElement == null)
						{
							return false;
						}
						num2 = (short)1346515760;
						short num3 = num2;
						num2 = (short)732377904;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13D;
						default:
							num2 = (short)1053949952;
							if (num2 != 0)
							{
							}
							num2 = (short)1113784321;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_138;
					case 2:
						goto IL_7B;
					case 3:
					{
						if (uielement != null)
						{
							num2 = (short)2080571394;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)880410624;
						short num4 = num2;
						contentElement = (A_0 as global::System.Windows.ContentElement);
						num2 = (short)1471873024;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_20;
				}
				IL_7B:
				goto IL_13D;
				IL_138:
				return contentElement.MoveFocus(A_1);
				IL_13D:
				return uielement.MoveFocus(A_1);
				IL_20:
				num2 = (short)2138374145;
				if (num2 != 0)
				{
				}
				uielement = (A_0 as global::System.Windows.UIElement);
				num2 = (short)1064435715;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x0000BC18 File Offset: 0x00009E18
			private static bool a(global::System.Windows.IInputElement A_0)
			{
				short num = (short)1251147792;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Controls.Control control;
					switch (num2)
					{
					case 0:
						goto IL_26A;
					case 1:
						num = (short)1321664521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)524353543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!control.Focusable)
						{
							num = (short)467337230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						control.Focus();
						num = (short)1255931910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)397049552;
						short num3 = num;
						num = (short)982220496;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26A;
						default:
							num = (short)1880752128;
							if (num != 0)
							{
							}
							num = (short)406650883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_229;
					case 6:
						num = (short)1494024193;
						if (num != 0)
						{
						}
						if (A_0 is global::Infragistics.Controls.Editors.Primitives.MaskedInputTextBox)
						{
							num = (short)984678411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
						if (A_0 is global::Infragistics.Windows.Editors.SectionsList)
						{
							num = (short)1016528896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						if (control.IsEnabled)
						{
							num = (short)1401094148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						if (!(A_0 is global::System.Windows.Controls.Primitives.TextBoxBase))
						{
							num = (short)1488715789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A;
					case 10:
						num = (short)547160072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						control.RaiseEvent(new global::System.Windows.Input.KeyEventArgs(global::System.Windows.Input.Keyboard.PrimaryDevice, global::System.Windows.PresentationSource.FromVisual(control), 0, global::System.Windows.Input.Key.End)
						{
							RoutedEvent = global::System.Windows.Input.Keyboard.KeyDownEvent
						});
						num = (short)1288372229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (control.IsVisible)
						{
							num = (short)1553530890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						num = (short)1589182479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_1A7;
					case 15:
						if (!(A_0 is global::Infragistics.Controls.Editors.ValueInput))
						{
							num = (short)2117009410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A;
					case 16:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					}
					IL_69:
					if (A_0 != null)
					{
						num = (short)1471610880;
						short num4 = num;
						num = (short)1026228225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_26A:
					control = (global::System.Windows.Controls.Control)A_0;
					num = (short)1253048332;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A7:
				return false;
				IL_229:
				return true;
			}

			// Token: 0x060000AA RID: 170 RVA: 0x0000BF48 File Offset: 0x0000A148
			// Note: this type is marked as 'beforefieldinit'.
			static a()
			{
				short num = (short)1346410288;
				short num2 = num;
				num = (short)1184798512;
				switch (num2 == num)
				{
				}
				num = (short)1200357377;
				if (num != 0)
				{
				}
				num = (short)641269760;
				if (num != 0)
				{
				}
				num = (short)945618944;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a = new global::System.Collections.Generic.List<global::System.Windows.IInputElement>();
			}

			// Token: 0x04000037 RID: 55
			private static readonly global::System.Collections.Generic.List<global::System.Windows.IInputElement> a;

			// Token: 0x0200002C RID: 44
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private sealed class a
			{
				// Token: 0x060000AC RID: 172 RVA: 0x0000C010 File Offset: 0x0000A210
				internal void b()
				{
					short num = (short)1094038473;
					short num2 = num;
					num = (short)1563931593;
					switch (num2 == num)
					{
					}
					num = (short)1180499968;
					if (num != 0)
					{
					}
					num = (short)1769144321;
					if (num != 0)
					{
					}
					num = (short)536805376;
					short num3 = num;
					global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.b(this.a);
				}

				// Token: 0x04000038 RID: 56
				public global::System.Windows.Window a;
			}

			// Token: 0x0200002D RID: 45
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private sealed class b
			{
				// Token: 0x060000AE RID: 174 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
				internal void c(object A_0, global::System.Windows.RoutedEventArgs A_1)
				{
					short num = (short)1750058895;
					short num2 = num;
					num = (short)2142750607;
					switch (num2 == num)
					{
					}
					num = (short)684589057;
					if (num != 0)
					{
					}
					num = (short)2015297536;
					if (num != 0)
					{
					}
					num = (short)130154496;
					short num3 = num;
					global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopupWindowAction.a.a(this.a);
					this.a.Loaded -= this.b;
				}

				// Token: 0x04000039 RID: 57
				public global::System.Windows.Window a;

				// Token: 0x0400003A RID: 58
				public global::System.Windows.RoutedEventHandler b;
			}
		}
	}
}
