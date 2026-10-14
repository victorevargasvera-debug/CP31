using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000003 RID: 3
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class AdvWindow : global::System.Windows.Window
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000021D4 File Offset: 0x000003D4
		public global::DevComponents.WpfRibbon.eRibbonVisualStyle VisualStyle
		{
			get
			{
				short num = (short)1396387460;
				short num2 = num;
				num = (short)1347825284;
				switch (num2 == num)
				{
				}
				num = (short)1940455425;
				if (num != 0)
				{
				}
				num = (short)258080768;
				short num3 = num;
				num = (short)538771456;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eRibbonVisualStyle)base.GetValue(global::DevComponents.WpfRibbon.AdvWindow.VisualStyleProperty);
			}
			set
			{
				short num = (short)454714959;
				short num2 = num;
				num = (short)1426548303;
				switch (num2 == num)
				{
				}
				num = (short)590217217;
				if (num != 0)
				{
				}
				num = (short)1340211200;
				short num3 = num;
				num = (short)1336803328;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.AdvWindow.VisualStyleProperty, value);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000228C File Offset: 0x0000048C
		private static void OnVisualStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)2129904205;
			short num2 = num;
			num = (short)1808581197;
			switch (num2 == num)
			{
			}
			num = (short)332005376;
			if (num != 0)
			{
			}
			num = (short)1097662465;
			if (num != 0)
			{
			}
			num = (short)1776156672;
			short num3 = num;
			((global::DevComponents.WpfRibbon.AdvWindow)o).OnVisualStyleChanged((global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.OldValue, (global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.NewValue);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002358 File Offset: 0x00000558
		private void OnVisualStyleChanged(global::DevComponents.WpfRibbon.eRibbonVisualStyle oldValue, global::DevComponents.WpfRibbon.eRibbonVisualStyle newValue)
		{
			short num = (short)1982005253;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1572339714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Black)
					{
						num = (short)687931395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B1;
				case 2:
					if (newValue != global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Blue)
					{
						num = (short)1004666884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_120;
				case 3:
					goto IL_E6;
				case 4:
					num = (short)548208641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 6:
					goto IL_16A;
				case 7:
				{
					num = (short)385857858;
					short num3 = num;
					num = (short)598980930;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16A;
					default:
						goto IL_97;
					}
					break;
				}
				}
				IL_44:
				if (this.IsDesignMode)
				{
					num = (short)1465319431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1277820928;
				short num4 = num;
				num = (short)1945829382;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16A:
				num = (short)413401089;
				if (num != 0)
				{
				}
				if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Silver)
				{
					goto IL_120;
				}
				num = (short)1606811648;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_97:
			num = (short)786104320;
			if (num != 0)
			{
			}
			return;
			IL_E6:
			IL_120:
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010;
			return;
			IL_1B1:
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002520 File Offset: 0x00000720
		private bool IsDesignMode
		{
			get
			{
				short num = (short)1938051311;
				short num2 = num;
				num = (short)1829064943;
				switch (num2 == num)
				{
				}
				num = (short)1206255616;
				short num3 = num;
				num = (short)380305409;
				if (num != 0)
				{
				}
				num = (short)1092222976;
				if (num != 0)
				{
				}
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000025CC File Offset: 0x000007CC
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002684 File Offset: 0x00000884
		public global::DevComponents.WpfRibbon.eEffectiveStyle EffectiveStyle
		{
			get
			{
				short num = (short)485615834;
				short num2 = num;
				num = (short)845015258;
				switch (num2 == num)
				{
				}
				num = (short)109641728;
				short num3 = num;
				num = (short)1201405953;
				if (num != 0)
				{
				}
				num = (short)1361641472;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eEffectiveStyle)base.GetValue(global::DevComponents.WpfRibbon.AdvWindow.EffectiveStyleProperty);
			}
			internal set
			{
				short num = (short)1294933666;
				short num2 = num;
				num = (short)840965794;
				switch (num2 == num)
				{
				}
				num = (short)897581056;
				short num3 = num;
				num = (short)1332150273;
				if (num != 0)
				{
				}
				num = (short)1687289856;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.AdvWindow.EffectiveStylePropertyKey, value);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000273C File Offset: 0x0000093C
		private static void OnEffectiveStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfRibbon.AdvWindow advWindow;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					advWindow.OnEffectiveStyleChanged((global::DevComponents.WpfRibbon.eEffectiveStyle)e.OldValue, (global::DevComponents.WpfRibbon.eEffectiveStyle)e.NewValue);
					num2 = (short)1353383937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_FF;
				case 2:
				{
					if (advWindow == null)
					{
						goto IL_101;
					}
					num2 = (short)1076139973;
					short num3 = num2;
					num2 = (short)278501317;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_101;
					default:
						num2 = (short)226820096;
						if (num2 != 0)
						{
						}
						num2 = (short)2102394881;
						if (num2 != 0)
						{
						}
						num2 = (short)2106195968;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_FF:
			IL_101:
			num2 = (short)1648820224;
			short num4 = num2;
			return;
			IL_1C:
			advWindow = (o as global::DevComponents.WpfRibbon.AdvWindow);
			num2 = (short)103677954;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002874 File Offset: 0x00000A74
		protected virtual void OnEffectiveStyleChanged(global::DevComponents.WpfRibbon.eEffectiveStyle oldValue, global::DevComponents.WpfRibbon.eEffectiveStyle newValue)
		{
			short num = (short)611346147;
			short num2 = num;
			num = (short)698967779;
			switch (num2 == num)
			{
			}
			num = (short)393740288;
			short num3 = num;
			num = (short)2004680705;
			if (num != 0)
			{
			}
			num = (short)715128832;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000291C File Offset: 0x00000B1C
		static AdvWindow()
		{
			int a_ = 12;
			short num = (short)332138053;
			short num2 = num;
			num = (short)741082693;
			switch (num2 == num)
			{
			}
			num = (short)627834880;
			short num3 = num;
			num = (short)800325632;
			if (num != 0)
			{
			}
			num = (short)1921843201;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.AdvWindow.VisualStyleProperty = global::DevComponents.WpfRibbon.Ribbon.VisualStyleProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.AdvWindow), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Blue, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.AdvWindow.OnVisualStyleChanged)));
			global::DevComponents.WpfRibbon.AdvWindow.EffectiveStylePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅳe๧ཀྵཫᩭ᥯ѱᅳ╵౷͹ၻ᭽", a_), typeof(global::DevComponents.WpfRibbon.eEffectiveStyle), typeof(global::DevComponents.WpfRibbon.AdvWindow), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.AdvWindow.OnEffectiveStyleChanged)));
			global::DevComponents.WpfRibbon.AdvWindow.EffectiveStyleProperty = global::DevComponents.WpfRibbon.AdvWindow.EffectiveStylePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.AdvWindow.CloseWindow = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❣੥ݧᥩ५㥭᥯ᱱၳ᥵ཷ", a_), typeof(global::DevComponents.WpfRibbon.AdvWindow));
			global::DevComponents.WpfRibbon.AdvWindow.MinimizeWindow = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⥣ཥ٧ͩūݭ੯᝱⍳ήᙷṹ፻ॽ", a_), typeof(global::DevComponents.WpfRibbon.AdvWindow));
			global::DevComponents.WpfRibbon.AdvWindow.MaximizeWindow = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⥣ݥၧͩūݭ੯᝱⍳ήᙷṹ፻ॽ", a_), typeof(global::DevComponents.WpfRibbon.AdvWindow));
			global::DevComponents.WpfRibbon.AdvWindow.RestoreWindow = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㙣ͥ᭧ṩͫᱭᕯ╱ᵳᡵᱷᕹ୻", a_), typeof(global::DevComponents.WpfRibbon.AdvWindow));
			global::DevComponents.WpfRibbon.AdvWindow.EnableSystemCaptionMenuProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅳࡥ१ࡩk୭⍯ୱݳɵᵷ᝹㽻ώ잉", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.AdvWindow), new global::System.Windows.UIPropertyMetadata(true));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.AdvWindow), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.AdvWindow)));
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002B34 File Offset: 0x00000D34
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002BF0 File Offset: 0x00000DF0
		public bool EnableSystemCaptionMenu
		{
			get
			{
				short num = (short)328466433;
				if (num != 0)
				{
				}
				num = (short)1104366938;
				short num2 = num;
				num = (short)92097882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1874198528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)645660672;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.AdvWindow.EnableSystemCaptionMenuProperty);
			}
			set
			{
				short num = (short)73478422;
				short num2 = num;
				num = (short)1957376278;
				switch (num2 == num)
				{
				}
				num = (short)2029060096;
				short num3 = num;
				num = (short)1795293185;
				if (num != 0)
				{
				}
				num = (short)1387397120;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.AdvWindow.EnableSystemCaptionMenuProperty, value);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002CAC File Offset: 0x00000EAC
		public AdvWindow()
		{
			base.WindowStyle = global::System.Windows.WindowStyle.None;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002CD0 File Offset: 0x00000ED0
		public override void OnApplyTemplate()
		{
			int a_ = 2;
			short num = (short)1303709307;
			short num2 = num;
			num = (short)1953236603;
			switch (num2 == num)
			{
			}
			num = (short)1792802816;
			short num3 = num;
			num = (short)612106241;
			if (num != 0)
			{
			}
			num = (short)1392574464;
			if (num != 0)
			{
			}
			this._WindowBorder = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ਖ਼ᵛౝ㑟㵡㍣ཥ٧๩ͫᥭ㉯ᵱٳትᵷࡹ", a_)) as global::System.Windows.Controls.Border);
			this._ResizeGrip = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൙㕛そџൡ፣㑥൧ᥩիᑭᕯ㕱ٳήࡷ", a_)) as global::System.Windows.Controls.Primitives.ResizeGrip);
			base.OnApplyTemplate();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002DC8 File Offset: 0x00000FC8
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			int a_ = 8;
			short num = (short)1669988358;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)758185994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (base.ResizeMode != global::System.Windows.ResizeMode.NoResize)
					{
						num = (short)279642130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51A;
				case 2:
					goto IL_2DC;
				case 3:
					goto IL_3B0;
				case 4:
					num = (short)1549664257;
					if (num != 0)
					{
					}
					if (((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝟ୡ੣ɥݧᵩ㡫ݭѯṱᅳ", a_))
					{
						num = (short)1204879362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_48D;
				case 5:
					if (this.EnableSystemCaptionMenu)
					{
						num = (short)739311642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_290;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 7:
					num = (short)69337097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					global::DevComponents.WpfRibbon.AdvWindow.CloseWindow.Execute(null, null);
					num = (short)1511325717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (e.ClickCount == 2)
					{
						num = (short)1443233800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)877985797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝟ୡ੣⽥୧թɫ", a_))
					{
						num = (short)1879375879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51A;
				case 11:
					global::DevComponents.WpfRibbon.AdvWindow.RestoreWindow.Execute(null, null);
					num = (short)1004863491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_290;
				case 13:
					IL_429:
					if (base.WindowState == global::System.Windows.WindowState.Maximized)
					{
						num = (short)1882521611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)656605199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)418643969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (base.WindowState == global::System.Windows.WindowState.Normal)
					{
						num = (short)1824063508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51A;
				case 16:
					if (!(((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝟ୡ੣ɥݧᵩ㡫ݭѯṱᅳ≵ᵷɹࡻ", a_)))
					{
						num = (short)1462960147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DC;
				case 17:
					if (e.ClickCount == 2)
					{
						num = (short)1439825934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.StartWindowDragMove();
					e.Handled = true;
					num = (short)789708822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					num = (short)1257373709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1912143876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					global::DevComponents.WpfRibbon.AdvWindow.MaximizeWindow.Execute(null, null);
					num = (short)14614551;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_290;
				case 22:
					goto IL_12E;
				case 23:
					goto IL_2D7;
				case 24:
					if (e.OriginalSource is global::System.Windows.FrameworkElement)
					{
						num = (short)510394368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51A;
				case 25:
					goto IL_2AE;
				case 26:
				{
					global::System.Windows.FrameworkElement frameworkElement = e.OriginalSource as global::System.Windows.FrameworkElement;
					global::System.Windows.Point screenPos = frameworkElement.PointToScreen(new global::System.Windows.Point(0.0, frameworkElement.ActualHeight));
					this.ShowTitleContextMenu(screenPos);
					num = (short)1391722508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 27:
					num = (short)696320016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9D:
				if (e.OriginalSource is global::System.Windows.FrameworkElement)
				{
					num = (short)266403867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_48D;
				IL_290:
				e.Handled = true;
				num = (short)660602905;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2DC:
				num = (short)1043136529;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48D:
				num = (short)878864295;
				short num3 = num;
				num = (short)1271031719;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_429;
				default:
					num = (short)306380800;
					if (num != 0)
					{
					}
					num = (short)1712979992;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_12E:
			IL_2AE:
			IL_2D7:
			IL_3B0:
			IL_51A:
			num = (short)283705344;
			short num4 = num;
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003320 File Offset: 0x00001520
		private void StartWindowDragMove()
		{
			short num = (short)1651226760;
			short num2 = num;
			num = (short)325236872;
			switch (num2 == num)
			{
			}
			num = (short)1303052289;
			if (num != 0)
			{
			}
			num = (short)255262720;
			short num3 = num;
			num = (short)1297022976;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Windows.Threading.DispatcherOperationCallback(this.DispatcherStartWindowDragMove), null);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000033E4 File Offset: 0x000015E4
		private object DispatcherStartWindowDragMove(object arg)
		{
			short num;
			for (;;)
			{
				num = (short)112459777;
				if (num != 0)
				{
				}
				if (global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
				{
					try
					{
						this.DragMove();
					}
					catch (global::System.InvalidOperationException)
					{
					}
				}
				num = (short)1691090944;
				short num2 = num;
				num = (short)1597609354;
				short num3 = num;
				num = (short)1721406858;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_9D;
				}
			}
			IL_9D:
			num = (short)91619328;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000034B8 File Offset: 0x000016B8
		protected override void OnMouseRightButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			int a_ = 4;
			short num = (short)1135345664;
			short num2 = num;
			num = (short)16121863;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					IL_F5:
					goto IL_193;
				case 1:
					num = (short)2056388612;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1CA;
				case 3:
					num = (short)1443954693;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!(((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("୛㝝๟١ୣᅥ㱧ͩᡫɭᕯ♱ᅳ๵౷", a_)))
					{
						num = (short)1788805128;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_193;
				case 5:
					if (e.OriginalSource is global::System.Windows.FrameworkElement)
					{
						num = (short)1807089665;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CA;
				case 6:
					if (((global::System.Windows.FrameworkElement)e.OriginalSource).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("୛㝝๟⭡ݣ॥٧", a_))
					{
						num = (short)1357053952;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CA;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				case 8:
					num = (short)47906822;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7B:
				if (this.EnableSystemCaptionMenu)
				{
					num = (short)1046085635;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1CA;
				IL_193:
				global::System.Windows.Point point = e.GetPosition(this);
				point = base.PointToScreen(point);
				this.ShowTitleContextMenu(point);
				e.Handled = true;
				num = (short)1804664834;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CA:
				num = (short)1091764225;
				if (num != 0)
				{
				}
				num = (short)938496810;
				short num4 = num;
				num = (short)93279018;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F5;
				default:
					goto IL_225;
				}
			}
			IL_225:
			num = (short)1024393216;
			if (num != 0)
			{
			}
			base.OnMouseRightButtonUp(e);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003708 File Offset: 0x00001908
		private void ShowTitleContextMenu(global::System.Windows.Point screenPos)
		{
			short num = (short)1801478160;
			short num2 = num;
			num = (short)825909264;
			switch (num2 == num)
			{
			}
			num = (short)845021185;
			if (num != 0)
			{
			}
			num = (short)1814102016;
			if (num != 0)
			{
			}
			num = (short)2124480512;
			short num3 = num;
			global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
			byte[] bytes = global::System.BitConverter.GetBytes((int)screenPos.X);
			byte[] bytes2 = global::System.BitConverter.GetBytes((int)screenPos.Y);
			int lParam = global::System.BitConverter.ToInt32(new byte[]
			{
				bytes[0],
				bytes[1],
				bytes2[0],
				bytes2[1]
			}, 0);
			global::DevComponents.WpfRibbon.WinApi.SendMessage(handle, 274, global::DevComponents.WpfRibbon.WinApi.TrackPopupMenu(global::DevComponents.WpfRibbon.WinApi.GetSystemMenu(handle, false), 256U, (int)screenPos.X, (int)screenPos.Y, 0, handle, global::System.IntPtr.Zero), lParam);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003834 File Offset: 0x00001A34
		protected override void OnPreviewMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)682164224;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)886505472;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_B6;
					}
					continue;
				}
				case 1:
					goto IL_2D1;
				case 2:
					if (base.Cursor != null)
					{
						num = (short)2035679247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				case 3:
					num = (short)1685979137;
					if (num != 0)
					{
					}
					goto IL_2D1;
				case 4:
					if (e.RightButton == global::System.Windows.Input.MouseButtonState.Released)
					{
						num = (short)1120862216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				case 5:
					goto IL_1FB;
				case 6:
				{
					global::System.Windows.Input.Cursor cursor;
					if (cursor != null)
					{
						num = (short)770572313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				}
				case 7:
					goto IL_2D1;
				case 8:
				{
					global::System.Windows.Point position = e.GetPosition(this);
					global::DevComponents.WpfRibbon.WinApi.SizingCommand sizingCommandFromPoint = this.GetSizingCommandFromPoint(position);
					num = (short)1766391822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					num = (short)1844117508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this._SizingWindow)
					{
						num = (short)2055667728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_492;
				case 11:
					goto IL_2D1;
				case 12:
					if (this.m_CursorIsSet)
					{
						num = (short)73007124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FB;
				case 13:
					goto IL_329;
				case 14:
				{
					global::DevComponents.WpfRibbon.WinApi.SizingCommand sizingCommandFromPoint;
					if (sizingCommandFromPoint == global::DevComponents.WpfRibbon.WinApi.SizingCommand.None)
					{
						num = (short)328663062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Input.Cursor cursor = null;
					num = (short)2094727187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					num = (short)622460940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_30A;
				case 17:
				{
					num = (short)1303882227;
					short num4 = num;
					num = (short)869509619;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_30A;
					default:
						num = (short)1161691136;
						if (num != 0)
						{
						}
						goto IL_1FB;
					}
					break;
				}
				case 18:
					goto IL_2D1;
				case 19:
				{
					global::DevComponents.WpfRibbon.WinApi.SizingCommand sizingCommandFromPoint;
					switch (sizingCommandFromPoint)
					{
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.West:
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.East:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeWE;
						num = (short)2134638603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.North:
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.South:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeNS;
						num = (short)1987837959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.NorthWest:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeNWSE;
						num = (short)963182595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.NorthEast:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeNESW;
						num = (short)2044723218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthWest:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeNESW;
						num = (short)1878523927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthEast:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeNWSE;
						num = (short)1865154584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					default:
						num = (short)2037448725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 20:
					base.Cursor = null;
					this.m_CursorIsSet = false;
					num = (short)1964179473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)945356801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)801243138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_2D1;
				case 24:
					goto IL_2D1;
				case 25:
				{
					this.m_CursorIsSet = true;
					global::System.Windows.Input.Cursor cursor;
					base.Cursor = cursor;
					e.Handled = true;
					num = (short)95813637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_B6:
				if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
				{
					num = (short)116064265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1FB:
				num = (short)840433674;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D1:
				num = (short)10747910;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30A:
				e.Handled = true;
				num = (short)1205731341;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_329:
			IL_492:
			base.OnPreviewMouseMove(e);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003CDC File Offset: 0x00001EDC
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfRibbon.WinApi.SizingCommand sizingCommandFromPoint;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_123;
				case 1:
					if (sizingCommandFromPoint != global::DevComponents.WpfRibbon.WinApi.SizingCommand.None)
					{
						num2 = (short)470482944;
						short num3 = num2;
						num2 = (short)2134441986;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_125;
				case 2:
				{
					this.StartResize(sizingCommandFromPoint);
					e.Handled = true;
					num2 = (short)568441789;
					short num4 = num2;
					num2 = (short)1140112317;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_125;
					default:
						num2 = (short)1220935680;
						if (num2 != 0)
						{
						}
						num2 = (short)1843134464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_123:
			IL_125:
			base.OnPreviewMouseLeftButtonDown(e);
			return;
			IL_1C:
			num2 = (short)1019478017;
			if (num2 != 0)
			{
			}
			global::System.Windows.Point position = e.GetPosition(this);
			sizingCommandFromPoint = this.GetSizingCommandFromPoint(position);
			num2 = (short)403767297;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003E18 File Offset: 0x00002018
		private global::DevComponents.WpfRibbon.WinApi.SizingCommand GetSizingCommandFromPoint(global::System.Windows.Point p)
		{
			short num = (short)1489895424;
			switch (num)
			{
			default:
			{
				num = (short)1618673688;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Rect rect;
					global::System.Windows.Thickness resizeBorderThickness;
					switch (num2)
					{
					case 0:
						num = (short)447545355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.East;
					case 2:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.Y >= base.Height - resizeCornerRadius.BottomLeft)
						{
							num = (short)1295646754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_986;
					}
					case 3:
						num = (short)1725431835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthEast;
					case 5:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthWest;
					case 6:
						if (base.ResizeMode != global::System.Windows.ResizeMode.NoResize)
						{
							num = (short)725024788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
					case 7:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.Y >= base.Height - resizeCornerRadius.BottomRight)
						{
							num = (short)2006974464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB8;
					}
					case 8:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.North;
					case 9:
					{
						if (rect.Contains(p))
						{
							num = (short)1638203418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.CornerRadius resizeCornerRadius = this.GetResizeCornerRadius();
						num = (short)1039204413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (base.ResizeMode == global::System.Windows.ResizeMode.CanMinimize)
						{
							num = (short)1248198705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						rect = default(global::System.Windows.Rect);
						num = (short)805568569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (p.Y <= base.Height)
						{
							num = (short)184811539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB8;
					case 12:
						if (p.X <= base.Width)
						{
							num = (short)1394147332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB8;
					case 13:
						num = (short)35192838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)2020933673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.West;
					case 16:
						if (p.X >= 0.0)
						{
							num = (short)20250629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_986;
					case 17:
						num = (short)81592353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1387397174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						num = (short)982122496;
						short num3 = num;
						num = (short)733151271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)936771594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							num = (short)998244410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthEast;
					case 22:
						num = (short)1821048857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)500629556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						switch (0)
						{
						case 0:
							goto IL_13C;
						}
						continue;
					case 25:
						if (p.Y <= base.Height)
						{
							num = (short)712048684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
					case 26:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
					case 27:
						if (p.X >= 0.0)
						{
							num = (short)231211023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_349;
					case 28:
						if (p.Y <= base.Height)
						{
							num = (short)1809711122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_986;
					case 29:
						if (p.X >= base.Width - resizeBorderThickness.Right)
						{
							goto IL_37B;
						}
						goto IL_8A7;
					case 30:
						if (p.Y >= 0.0)
						{
							num = (short)135266312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_678;
					case 31:
						num = (short)898367539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1191772190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (p.X >= 0.0)
						{
							num = (short)1219231781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 34:
						num = (short)1862402076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)1869611009;
						if (num != 0)
						{
						}
						if (this._ResizeGrip.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)276103221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D6;
					case 36:
					{
						global::System.Windows.Point point = base.PointToScreen(p);
						point = this._ResizeGrip.PointFromScreen(point);
						rect = new global::System.Windows.Rect(this._ResizeGrip.RenderSize);
						num = (short)1122304040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.NorthWest;
					case 38:
						if (p.X <= resizeBorderThickness.Left)
						{
							num = (short)236716035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_349;
					case 39:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.X >= base.Width - resizeCornerRadius.BottomRight)
						{
							num = (short)544669746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB8;
					}
					case 40:
					{
						num = (short)28105995;
						short num4 = num;
						num = (short)2144525579;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37B;
						default:
						{
							num = (short)1674117120;
							if (num != 0)
							{
							}
							global::System.Windows.Point point;
							if (rect.Contains(point))
							{
								num = (short)867893307;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2D6;
						}
						}
						break;
					}
					case 41:
						if (p.Y >= 0.0)
						{
							num = (short)638844951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 42:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.NorthEast;
					case 43:
						if (p.X <= base.Width)
						{
							num = (short)1801715713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A7;
					case 44:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.South;
					case 45:
						if (p.Y <= resizeBorderThickness.Top)
						{
							num = (short)601948192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_678;
					case 46:
						if (p.Y >= base.Height - resizeBorderThickness.Bottom)
						{
							num = (short)1489109014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
					case 47:
						num = (short)942735376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.Y < resizeCornerRadius.TopRight)
						{
							num = (short)1148190751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_857;
					}
					case 49:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
					case 50:
						num = (short)1297219596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.X >= base.Width - resizeCornerRadius.TopRight)
						{
							num = (short)1925185578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_857;
					}
					case 52:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.X <= resizeCornerRadius.TopLeft)
						{
							num = (short)1787428881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					}
					case 53:
						num = (short)1197932604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.X <= resizeCornerRadius.BottomLeft)
						{
							num = (short)364052527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_986;
					}
					case 55:
						num = (short)1814102051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						num = (short)350486571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (this._ResizeGrip != null)
						{
							num = (short)1210449975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D6;
					case 58:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthWest;
					case 59:
						num = (short)1845559317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (base.ResizeMode == global::System.Windows.ResizeMode.CanResizeWithGrip)
						{
							num = (short)509214756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D6;
					case 61:
						if (p.Y <= resizeBorderThickness.Top)
						{
							num = (short)2121596942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					}
					IL_13C:
					if (base.WindowState == global::System.Windows.WindowState.Normal)
					{
						num = (short)216137741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
					IL_2D6:
					resizeBorderThickness = this.GetResizeBorderThickness();
					rect = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(new global::System.Windows.Rect(0.0, 0.0, base.Width, base.Height), resizeBorderThickness);
					num = (short)1468268553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_349:
					num = (short)1063714845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37B:
					num = (short)1026228280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39B:
					num = (short)1996554288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_678:
					num = (short)894238758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_857:
					num = (short)139788290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8A7:
					num = (short)1781727278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_986:
					num = (short)673775623;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB8:
					num = (short)1394671661;
					num2 = (int)((global::System.IntPtr)num);
				}
				return global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthWest;
			}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004928 File Offset: 0x00002B28
		private global::System.Windows.Thickness GetResizeBorderThickness()
		{
			short num = (short)1461583872;
			short num2 = num;
			num = (short)1533868860;
			short num3 = num;
			num = (short)1684142908;
			switch (num3 == num)
			{
			}
			num = (short)1277100032;
			if (num != 0)
			{
			}
			num = (short)399310849;
			if (num != 0)
			{
			}
			return new global::System.Windows.Thickness(6.0, 6.0, 6.0, 6.0);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000049F8 File Offset: 0x00002BF8
		private global::System.Windows.CornerRadius GetResizeCornerRadius()
		{
			short num = (short)749731840;
			short num2 = num;
			num = (short)1542193153;
			if (num != 0)
			{
			}
			num = (short)1892951640;
			short num3 = num;
			num = (short)746595928;
			switch (num3 == num)
			{
			}
			num = (short)1801715712;
			if (num != 0)
			{
			}
			return new global::System.Windows.CornerRadius(7.0, 7.0, 7.0, 7.0);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004ACC File Offset: 0x00002CCC
		private void StartResize(global::DevComponents.WpfRibbon.WinApi.SizingCommand cmd)
		{
			short num = (short)841351168;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1947282027;
				short num3 = num;
				num = (short)59976299;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1534787584;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 1:
					{
						num = (short)331612161;
						if (num != 0)
						{
						}
						global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
						global::DevComponents.WpfRibbon.WinApi.SendMessage(handle, 274, (int)(61440 + cmd), 0);
						global::DevComponents.WpfRibbon.WinApi.SendMessage(handle, 514, 0, 0);
						num = (short)432996354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					}
					IL_7C:
					if (global::System.Windows.Input.Mouse.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
					{
						return;
					}
					num = (short)1874460672;
					short num4 = num;
					num = (short)508952577;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004C10 File Offset: 0x00002E10
		protected override void OnInitialized(global::System.EventArgs e)
		{
			short num = (short)1036058624;
			short num2 = num;
			num = (short)1475289303;
			short num3 = num;
			num = (short)251994327;
			switch (num3 == num)
			{
			}
			num = (short)1489895424;
			if (num != 0)
			{
			}
			num = (short)824705025;
			if (num != 0)
			{
			}
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfRibbon.AdvWindow.CloseWindow, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteCloseWindow), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteCloseWindow)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfRibbon.AdvWindow.MinimizeWindow, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteMinimizeWindow), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteMinimizeWindow)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfRibbon.AdvWindow.MaximizeWindow, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteMaximizeWindow), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteMaximizeWindow)));
			base.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfRibbon.AdvWindow.RestoreWindow, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteRestoreWindow), new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteRestoreWindow)));
			base.OnInitialized(e);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004D74 File Offset: 0x00002F74
		private void ExecuteCloseWindow(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			short num = (short)470220800;
			short num2 = num;
			num = (short)1203092989;
			short num3 = num;
			num = (short)2036186621;
			switch (num3 == num)
			{
			}
			num = (short)294912000;
			if (num != 0)
			{
			}
			num = (short)1781727233;
			if (num != 0)
			{
			}
			base.Close();
			e.Handled = true;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004E2C File Offset: 0x0000302C
		private void CanExecuteCloseWindow(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			short num = (short)136118272;
			short num2 = num;
			num = (short)1950496644;
			short num3 = num;
			num = (short)357775236;
			switch (num3 == num)
			{
			}
			num = (short)275120129;
			if (num != 0)
			{
			}
			num = (short)78708736;
			if (num != 0)
			{
			}
			e.CanExecute = true;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004EDC File Offset: 0x000030DC
		private void ExecuteMinimizeWindow(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			short num = (short)1450049536;
			short num2 = num;
			num = (short)2058700909;
			short num3 = num;
			num = (short)2045397101;
			switch (num3 == num)
			{
			}
			num = (short)726925312;
			if (num != 0)
			{
			}
			num = (short)613089281;
			if (num != 0)
			{
			}
			base.WindowState = global::System.Windows.WindowState.Minimized;
			e.Handled = true;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004F90 File Offset: 0x00003190
		private void CanExecuteMinimizeWindow(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			short num = (short)655753216;
			short num2 = num;
			num = (short)1055561430;
			short num3 = num;
			num = (short)1423021782;
			switch (num3 == num)
			{
			}
			num = (short)1351090176;
			if (num != 0)
			{
			}
			num = (short)1650589697;
			if (num != 0)
			{
			}
			e.CanExecute = (base.WindowState != global::System.Windows.WindowState.Minimized);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000504C File Offset: 0x0000324C
		private void ExecuteMaximizeWindow(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			short num = (short)1757020160;
			short num2 = num;
			num = (short)254300958;
			short num3 = num;
			num = (short)1060328222;
			switch (num3 == num)
			{
			}
			num = (short)1393033217;
			if (num != 0)
			{
			}
			num = (short)2048393216;
			if (num != 0)
			{
			}
			base.WindowState = global::System.Windows.WindowState.Maximized;
			e.Handled = true;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005104 File Offset: 0x00003304
		private void CanExecuteMaximizeWindow(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			short num = (short)2044198912;
			short num2 = num;
			num = (short)278659073;
			if (num != 0)
			{
			}
			num = (short)1368971757;
			short num3 = num;
			num = (short)658233837;
			switch (num3 == num)
			{
			}
			num = (short)165412864;
			if (num != 0)
			{
			}
			e.CanExecute = (base.WindowState != global::System.Windows.WindowState.Maximized);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000051C0 File Offset: 0x000033C0
		private void ExecuteRestoreWindow(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			short num = (short)162463744;
			short num2 = num;
			num = (short)1631985547;
			short num3 = num;
			num = (short)877010827;
			switch (num3 == num)
			{
			}
			num = (short)974454785;
			if (num != 0)
			{
			}
			num = (short)2084438016;
			if (num != 0)
			{
			}
			base.WindowState = global::System.Windows.WindowState.Normal;
			e.Handled = true;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005278 File Offset: 0x00003478
		private void CanExecuteRestoreWindow(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			short num = (short)400359424;
			short num2 = num;
			num = (short)1908601674;
			short num3 = num;
			num = (short)1264776010;
			switch (num3 == num)
			{
			}
			num = (short)73662465;
			if (num != 0)
			{
			}
			num = (short)1986396160;
			if (num != 0)
			{
			}
			e.CanExecute = (base.WindowState > global::System.Windows.WindowState.Normal);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005330 File Offset: 0x00003530
		protected override void OnSourceInitialized(global::System.EventArgs e)
		{
			short num = (short)2083389440;
			short num2 = num;
			num = (short)600116461;
			short num3 = num;
			num = (short)983174381;
			switch (num3 == num)
			{
			}
			num = (short)669253633;
			if (num != 0)
			{
			}
			num = (short)674693120;
			if (num != 0)
			{
			}
			base.OnSourceInitialized(e);
			this._SourceInitialized = true;
			global::System.Windows.Interop.HwndSource.FromHwnd(new global::System.Windows.Interop.WindowInteropHelper(this).Handle).AddHook(new global::System.Windows.Interop.HwndSourceHook(this.WindowMessageHandler));
			this.UpdateWindowStyle();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005410 File Offset: 0x00003610
		private void UpdateWindowStyle()
		{
			short num = (short)1559953409;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					goto IL_14B;
				case 3:
					IL_169:
					goto IL_1CF;
				case 4:
					num = (short)1122959361;
					if (num != 0)
					{
					}
					if (base.WindowStyle != global::System.Windows.WindowStyle.None)
					{
						num = (short)1407909890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CF;
				case 5:
					try
					{
						num = (short)543096832;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_95;
								}
								continue;
							case 1:
								base.WindowStyle = global::System.Windows.WindowStyle.None;
								num = (short)1164181506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_D1;
							case 3:
								goto IL_13E;
							}
							IL_95:
							if (base.WindowStyle != global::System.Windows.WindowStyle.None)
							{
								num = (short)428343297;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_D1:
							global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
							global::System.Windows.Interop.HwndSource.FromHwnd(handle).CompositionTarget.BackgroundColor = global::System.Windows.Media.Colors.Black;
							int num3 = global::DevComponents.WpfRibbon.WinApi.GetWindowLong(handle, -16);
							num3 &= ~(num3 & 262144);
							global::DevComponents.WpfRibbon.WinApi.SetWindowLong(handle, -16, num3);
							global::DevComponents.WpfRibbon.WinApi.SetWindowPos(handle, global::System.IntPtr.Zero, 0, 0, 0, 0, 39);
							this.UpdateRegion(false);
							num = (short)649527299;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_13E:
						return;
					}
					finally
					{
						this._UpdatingWindowStyle = false;
					}
					goto IL_14B;
				}
				IL_3C:
				if (!this._SourceInitialized)
				{
					num = (short)1398407168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1151926276;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14B:
				base.WindowStyle = global::System.Windows.WindowStyle.None;
				num = (short)1101332483;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CF:
				num = (short)1334706176;
				short num4 = num;
				num = (short)1427488961;
				short num5 = num;
				num = (short)481018049;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_169;
				default:
					num = (short)2065170432;
					if (num != 0)
					{
					}
					this._UpdatingWindowStyle = true;
					num = (short)301137925;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005694 File Offset: 0x00003894
		private void UpdateRegion(bool redraw, global::System.Windows.WindowState windowState)
		{
			short num = (short)1835991040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BA;
				}
				global::System.IntPtr handle;
				int num3;
				int num4;
				for (;;)
				{
					IL_27:
					global::DevComponents.WpfRibbon.WinApi.RECT rect;
					switch (num2)
					{
					case 0:
						if (base.SizeToContent == global::System.Windows.SizeToContent.WidthAndHeight)
						{
							num = (short)1453916184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_671;
					case 1:
						if (base.SizeToContent == global::System.Windows.SizeToContent.Height)
						{
							num = (short)693305362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_604;
					case 2:
						rect = default(global::DevComponents.WpfRibbon.WinApi.RECT);
						global::DevComponents.WpfRibbon.WinApi.GetWindowRect(handle, ref rect);
						num = (short)1879703574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (base.SizeToContent == global::System.Windows.SizeToContent.WidthAndHeight)
						{
							num = (short)55836682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57D;
					case 4:
						goto IL_57D;
					case 5:
						goto IL_604;
					case 6:
						if (base.SizeToContent == global::System.Windows.SizeToContent.Width)
						{
							num = (short)164036628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)560070657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (base.SizeToContent != global::System.Windows.SizeToContent.Manual)
						{
							num = (short)1787756574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_604;
					case 8:
						if (base.WindowStyle == global::System.Windows.WindowStyle.None)
						{
							num = (short)1862795296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_671;
					case 9:
						goto IL_604;
					case 10:
						goto IL_143;
					case 11:
						goto IL_649;
					case 12:
						if (base.SizeToContent == global::System.Windows.SizeToContent.WidthAndHeight)
						{
							num = (short)1182859275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C1;
					case 13:
						goto IL_5C1;
					case 14:
						goto IL_348;
					case 15:
						if (base.SizeToContent != global::System.Windows.SizeToContent.Width)
						{
							num = (short)358416409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_649;
					case 16:
						if (handle != global::System.IntPtr.Zero)
						{
							num = (short)608829474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_671;
					case 17:
						if (base.SizeToContent == global::System.Windows.SizeToContent.Manual)
						{
							num = (short)302907394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_671;
					case 18:
						num3 = (int)global::System.Math.Ceiling(base.ActualHeight) + 1;
						num = (short)1619591173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (base.SizeToContent == global::System.Windows.SizeToContent.WidthAndHeight)
						{
							num = (short)441253911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1641152518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num4 = (int)global::System.Math.Ceiling(base.ActualWidth) + 1;
						num = (short)1375141889;
						if (num != 0)
						{
						}
						num = (short)1253900297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)44302339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (base.SizeToContent != global::System.Windows.SizeToContent.Manual)
						{
							num = (short)118554657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = rect.Width + 1;
						num3 = rect.Height + 1;
						num = (short)2131230746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num3 = (int)global::System.Math.Ceiling(base.ActualHeight) + 1;
						num4 = (int)global::System.Math.Ceiling(base.ActualWidth) + 1;
						num = (short)1672085535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						num = (short)689440399;
						short num5 = num;
						num = (short)126682767;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_442;
						default:
							num = (short)2134835200;
							if (num != 0)
							{
							}
							num = (short)543227931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 25:
						num = (short)1220411404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_43D;
					case 27:
						if (this._IsFirstLoad)
						{
							num = (short)926089245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_671;
					case 28:
						if (base.SizeToContent != global::System.Windows.SizeToContent.Height)
						{
							num = (short)625082389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143;
					case 29:
						num = (short)1215168520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)2130771987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_604;
					case 32:
						num4 -= (int)global::System.Windows.SystemParameters.ResizeFrameVerticalBorderWidth * 2 - 1;
						num3 -= (int)global::System.Windows.SystemParameters.ResizeFrameHorizontalBorderHeight * 2 - 1;
						num = (short)757071886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)785448975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_442;
					}
					goto IL_BA;
					IL_143:
					num4 = rect.Width + 1;
					num = (short)1449525252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_442:
					num = (short)643629073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57D:
					num = (short)1518272512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C1:
					num = (short)1247412252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_604:
					num = (short)857931792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_649:
					num3 = rect.Height + 1;
					num = (short)69861389;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_348:
				IL_43D:
				IL_671:
				this.UpdateRegion(redraw, num4, num3, windowState);
				return;
				IL_BA:
				num = (short)531103744;
				short num6 = num;
				handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
				num4 = (int)base.Width + 1;
				num3 = (int)base.Height + 1;
				num = (short)1662910471;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005D1C File Offset: 0x00003F1C
		private void UpdateRegion(bool redraw)
		{
			short num = (short)952875770;
			short num2 = num;
			num = (short)1007860474;
			switch (num2 == num)
			{
			}
			num = (short)994181120;
			short num3 = num;
			num = (short)1572405249;
			if (num != 0)
			{
			}
			num = (short)1019412480;
			if (num != 0)
			{
			}
			this.UpdateRegion(redraw, base.WindowState);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005DD4 File Offset: 0x00003FD4
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			short num = (short)774504449;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_42;
			}
			int num2;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
				{
					num = (short)1462478433;
					short num3 = num;
					num = (short)798271073;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)934412288;
						if (num != 0)
						{
						}
						this.UpdateRegion(false);
						num = (short)317849602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (base.SizeToContent != global::System.Windows.SizeToContent.Manual)
					{
						num = (short)563412992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_42;
			}
			return;
			IL_42:
			base.OnRenderSizeChanged(sizeInfo);
			num = (short)388300800;
			short num4 = num;
			num = (short)702349313;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005EF4 File Offset: 0x000040F4
		private void UpdateRegion(bool redraw, int width, int height, global::System.Windows.WindowState windowState)
		{
			short num = (short)22216704;
			switch (num)
			{
			default:
			{
				for (;;)
				{
					IL_1E:
					num = (short)783155214;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_345;
						case 1:
							goto IL_2CC;
						case 2:
							goto IL_165;
						case 3:
							num = (short)599523334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_207;
						case 5:
						{
							num = (short)668382711;
							short num3 = num;
							num = (short)1660466679;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E;
							default:
							{
								num = (short)1570963456;
								if (num != 0)
								{
								}
								global::System.Windows.CornerRadius cornerRadius;
								double num4 = cornerRadius.TopLeft;
								cornerRadius.TopLeft = num4 + 1.0;
								num = (short)1679818753;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 6:
						{
							if (this._WindowBorder == null)
							{
								num = (short)916258831;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.CornerRadius cornerRadius = this._WindowBorder.CornerRadius;
							num = (short)1426128907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Windows.CornerRadius cornerRadius;
							double num4 = cornerRadius.TopRight;
							cornerRadius.TopRight = num4 + 1.0;
							num = (short)2020605952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::System.Windows.CornerRadius cornerRadius;
							double num4 = cornerRadius.BottomLeft;
							cornerRadius.BottomLeft = num4 + 1.0;
							num = (short)371392514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::System.Windows.CornerRadius cornerRadius;
							if (cornerRadius.BottomRight > 0.0)
							{
								num = (short)585695242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_207;
						}
						case 10:
						{
							global::System.Windows.CornerRadius cornerRadius;
							double num4 = cornerRadius.BottomRight;
							cornerRadius.BottomRight = num4 + 1.0;
							num = (short)308936705;
							if (num != 0)
							{
							}
							num = (short)1913192452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
						{
							global::System.Windows.CornerRadius cornerRadius;
							if (cornerRadius.BottomLeft > 0.0)
							{
								num = (short)2004090888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_165;
						}
						case 12:
						{
							global::System.Windows.CornerRadius cornerRadius;
							if (cornerRadius.TopLeft > 0.0)
							{
								num = (short)1534984197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2CC;
						}
						case 13:
							goto IL_388;
						case 14:
							switch (0)
							{
							case 0:
								goto IL_89;
							}
							continue;
						case 15:
							return;
						case 16:
						{
							global::System.Windows.CornerRadius cornerRadius;
							if (cornerRadius.TopRight > 0.0)
							{
								num = (short)1982464007;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_345;
						}
						}
						IL_89:
						if (windowState != global::System.Windows.WindowState.Minimized)
						{
							num = (short)1260781571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
						IL_165:
						num = (short)1229848585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_207:
						num = (short)1914503180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2CC:
						num = (short)2140012560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_345:
						num = (short)1353580544;
						short num5 = num;
						num = (short)360316941;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_388:
				global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
				global::System.IntPtr intPtr = global::System.IntPtr.Zero;
				if (windowState != global::System.Windows.WindowState.Maximized)
				{
					global::System.Windows.CornerRadius cornerRadius;
					if (cornerRadius.BottomLeft == cornerRadius.BottomRight && cornerRadius.BottomLeft == cornerRadius.TopLeft && cornerRadius.BottomLeft == cornerRadius.TopRight && cornerRadius.BottomLeft >= 1.0)
					{
						intPtr = global::DevComponents.WpfRibbon.WinApi.CreateRoundRectRgn(0, 0, width, height, (int)cornerRadius.BottomLeft, (int)cornerRadius.BottomLeft);
					}
					else if (cornerRadius.BottomLeft >= 1.0 || cornerRadius.BottomRight >= 1.0 || cornerRadius.TopLeft >= 1.0 || cornerRadius.TopRight >= 1.0)
					{
						global::System.IntPtr intPtr2 = global::System.IntPtr.Zero;
						global::System.IntPtr intPtr3 = global::System.IntPtr.Zero;
						global::System.IntPtr intPtr4 = global::System.IntPtr.Zero;
						global::System.IntPtr intPtr5 = global::System.IntPtr.Zero;
						int num6 = width - (int)global::System.Math.Max(cornerRadius.TopRight, cornerRadius.BottomRight);
						int num7 = height - (int)global::System.Math.Max(global::System.Math.Max(cornerRadius.BottomLeft, cornerRadius.BottomRight), global::System.Math.Max(cornerRadius.TopLeft, cornerRadius.TopRight));
						if ((int)cornerRadius.TopLeft >= 1)
						{
							intPtr2 = global::DevComponents.WpfRibbon.WinApi.CreateRoundRectRgn(0, 0, num6, num7, (int)cornerRadius.TopLeft, (int)cornerRadius.TopLeft);
						}
						else
						{
							intPtr2 = global::DevComponents.WpfRibbon.WinApi.CreateRectRgn(0, 0, num6, num7);
						}
						num6 = width - (int)global::System.Math.Max(cornerRadius.TopLeft, cornerRadius.BottomLeft);
						if ((int)cornerRadius.TopRight >= 1)
						{
							intPtr3 = global::DevComponents.WpfRibbon.WinApi.CreateRoundRectRgn(width - num6, 0, width, num7, (int)cornerRadius.TopRight, (int)cornerRadius.TopRight);
						}
						else
						{
							intPtr3 = global::DevComponents.WpfRibbon.WinApi.CreateRectRgn(width - num6, 0, width, num7);
						}
						num6 = width - (int)global::System.Math.Max(cornerRadius.TopRight, cornerRadius.BottomRight);
						num7 = height - (int)global::System.Math.Max(cornerRadius.TopLeft, cornerRadius.TopRight);
						if ((int)cornerRadius.BottomLeft >= 1)
						{
							intPtr4 = global::DevComponents.WpfRibbon.WinApi.CreateRoundRectRgn(0, height - num7, num6, height, (int)cornerRadius.BottomLeft, (int)cornerRadius.BottomLeft);
						}
						else
						{
							intPtr4 = global::DevComponents.WpfRibbon.WinApi.CreateRectRgn(0, height - num7, num6, height);
						}
						num6 = width - (int)global::System.Math.Max(cornerRadius.TopLeft, cornerRadius.BottomLeft);
						if ((int)cornerRadius.BottomRight >= 1)
						{
							intPtr5 = global::DevComponents.WpfRibbon.WinApi.CreateRoundRectRgn(width - num6, height - num7, width, height, (int)cornerRadius.BottomRight, (int)cornerRadius.BottomRight);
						}
						else
						{
							intPtr5 = global::DevComponents.WpfRibbon.WinApi.CreateRectRgn(width - num6, height - num7, width, height);
						}
						intPtr = global::DevComponents.WpfRibbon.WinApi.CreateRectRgn(0, 0, 0, 0);
						global::System.IntPtr intPtr6 = global::DevComponents.WpfRibbon.WinApi.CreateRectRgn(0, 0, 0, 0);
						global::System.IntPtr intPtr7 = global::DevComponents.WpfRibbon.WinApi.CreateRectRgn(0, 0, 0, 0);
						global::DevComponents.WpfRibbon.WinApi.CombineRgn(intPtr6, intPtr2, intPtr3, 2);
						global::DevComponents.WpfRibbon.WinApi.CombineRgn(intPtr7, intPtr4, intPtr5, 2);
						global::DevComponents.WpfRibbon.WinApi.CombineRgn(intPtr, intPtr6, intPtr7, 2);
						global::DevComponents.WpfRibbon.WinApi.DeleteObject(intPtr6);
						global::DevComponents.WpfRibbon.WinApi.DeleteObject(intPtr7);
						global::DevComponents.WpfRibbon.WinApi.DeleteObject(intPtr2);
						global::DevComponents.WpfRibbon.WinApi.DeleteObject(intPtr3);
						global::DevComponents.WpfRibbon.WinApi.DeleteObject(intPtr4);
						global::DevComponents.WpfRibbon.WinApi.DeleteObject(intPtr5);
					}
				}
				global::DevComponents.WpfRibbon.WinApi.SetWindowRgn(handle, intPtr, redraw);
				return;
			}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000659C File Offset: 0x0000479C
		private global::System.IntPtr WindowMessageHandler(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			global::System.IntPtr result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (msg != 562)
						{
							num2 = (short)736231429;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)282872334;
						short num3 = num2;
						num2 = (short)452020750;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1549860864;
							if (num2 != 0)
							{
							}
							num2 = (short)909705218;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						return result;
					case 2:
						result = this.WmExitSizeMove(hwnd, msg, wParam, lParam, ref handled);
						num2 = (short)1472004107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)1683161089;
						if (num2 != 0)
						{
						}
						result = this.WmEnterSizeMove(hwnd, msg, wParam, lParam, ref handled);
						num2 = (short)1599733769;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						result = this.WmSize(hwnd, msg, wParam, lParam, ref handled);
						num2 = (short)1560215553;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (msg == 561)
						{
							num2 = (short)900988931;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1544290314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						result = this.WmGetMinMaxInfo(hwnd, msg, wParam, lParam, ref handled);
						num2 = (short)319356941;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						if (msg == 132)
						{
							num2 = (short)1941241864;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 8:
					{
						num2 = (short)341180416;
						short num4 = num2;
						result = this.WmNcHitTest(hwnd, msg, wParam, lParam, ref handled);
						num2 = (short)1547632654;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 9:
						return result;
					case 10:
						if (msg == 36)
						{
							num2 = (short)717881350;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1021706247;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						return result;
					case 12:
						if (msg == 5)
						{
							num2 = (short)1948188676;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1116864512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 13:
						return result;
					case 14:
						return result;
					}
					break;
				}
				IL_4C:
				result = global::System.IntPtr.Zero;
				num2 = (short)2135228428;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00006898 File Offset: 0x00004A98
		private global::System.IntPtr WmGetMinMaxInfo(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)249823232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::DevComponents.WpfRibbon.WinApi.MINMAXINFO structure;
				global::System.IntPtr intPtr;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::DevComponents.WpfRibbon.WinApi.RECT rcWork;
						global::DevComponents.WpfRibbon.WinApi.RECT rcMonitor;
						structure.ptMaxSize.y = global::System.Math.Abs(rcWork.Bottom - rcWork.Top) + ((rcMonitor.Height == rcWork.Height) ? 2 : 5);
						num = (short)286785540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_140;
					case 2:
						goto IL_246;
					case 3:
						if (intPtr != global::System.IntPtr.Zero)
						{
							num = (short)899153921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D;
					case 4:
						goto IL_22D;
					}
					goto IL_43;
					IL_22D:
					num = (short)484114434;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_140:
				goto IL_142;
				IL_246:
				structure.ptMinTrackSize = new global::DevComponents.WpfRibbon.WinApi.POINT((int)((base.MinWidth > 0.0) ? base.MinWidth : 160.0), (int)((base.MinHeight > 0.0) ? base.MinHeight : 38.0));
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::DevComponents.WpfRibbon.WinApi.MINMAXINFO>(structure, lParam, true);
				handled = true;
				return global::System.IntPtr.Zero;
				IL_43:
				structure = (global::DevComponents.WpfRibbon.WinApi.MINMAXINFO)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::DevComponents.WpfRibbon.WinApi.MINMAXINFO));
				int flags = 2;
				intPtr = global::DevComponents.WpfRibbon.WinApi.MonitorFromWindow(hwnd, flags);
				num = (short)300613633;
				if (num != 0)
				{
				}
				num = (short)1181230856;
				short num3 = num;
				num = (short)414197512;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_142:
					global::DevComponents.WpfRibbon.WinApi.MONITORINFO monitorinfo = new global::DevComponents.WpfRibbon.WinApi.MONITORINFO();
					global::DevComponents.WpfRibbon.WinApi.GetMonitorInfo(intPtr, monitorinfo);
					global::DevComponents.WpfRibbon.WinApi.RECT rcWork = monitorinfo.rcWork;
					global::DevComponents.WpfRibbon.WinApi.RECT rcMonitor = monitorinfo.rcMonitor;
					structure.ptMaxPosition.x = global::System.Math.Abs(rcWork.Left - rcMonitor.Left);
					structure.ptMaxPosition.y = global::System.Math.Abs(rcWork.Top - rcMonitor.Top) - 3;
					structure.ptMaxSize.x = global::System.Math.Abs(rcWork.Right - rcWork.Left);
					num = (short)20054016;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				default:
				{
					num = (short)1748959232;
					short num4 = num;
					num = (short)3276800;
					if (num != 0)
					{
					}
					num = (short)1691549699;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00006B58 File Offset: 0x00004D58
		private global::System.IntPtr WmSizing(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)73992901;
			short num2 = num;
			num = (short)824249029;
			switch (num2 == num)
			{
			}
			num = (short)575078400;
			short num3 = num;
			num = (short)1394147329;
			if (num != 0)
			{
			}
			num = (short)1911947264;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.WinApi.RECT rect = (global::DevComponents.WpfRibbon.WinApi.RECT)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::DevComponents.WpfRibbon.WinApi.RECT));
			this.UpdateRegion(true, rect.Width + 1, rect.Height + 1, base.WindowState);
			return global::System.IntPtr.Zero;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00006C3C File Offset: 0x00004E3C
		private global::System.IntPtr WmEnterSizeMove(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)484716507;
			short num2 = num;
			num = (short)1689399259;
			switch (num2 == num)
			{
			}
			num = (short)1918107648;
			short num3 = num;
			num = (short)1849884673;
			if (num != 0)
			{
			}
			num = (short)563019776;
			if (num != 0)
			{
			}
			this._SizingWindow = true;
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00006CF8 File Offset: 0x00004EF8
		private global::System.IntPtr WmExitSizeMove(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)576331264;
			short num2 = num;
			num = (short)289480192;
			switch (num2 == num)
			{
			}
			num = (short)949485568;
			short num3 = num;
			num = (short)1289355265;
			if (num != 0)
			{
			}
			num = (short)1125580800;
			if (num != 0)
			{
			}
			this._SizingWindow = false;
			this.UpdateRegion(true);
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00006DB0 File Offset: 0x00004FB0
		private global::System.IntPtr WmSize(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_34;
				}
				int num;
				int num2;
				short num3;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (num2 == 0)
						{
							num3 = (short)1693450248;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1F4;
					case 1:
						this.UpdateRegion(true, global::DevComponents.WpfRibbon.WinApi.WindowStateFromParam(wParam));
						this._IsFirstLoad = false;
						num3 = (short)1924268035;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 2:
						if (!this._UpdatingWindowStyle)
						{
							num3 = (short)2016346113;
							if (num3 != 0)
							{
							}
							num3 = (short)1424293889;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1F4;
					case 3:
						goto IL_1F2;
					case 4:
						if (this._SourceInitialized)
						{
							num3 = (short)1270022149;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1F4;
					case 5:
						num3 = (short)1486618626;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 6:
					{
						if (num2 == 2)
						{
							goto IL_125;
						}
						num3 = (short)1275606522;
						short num4 = num3;
						num3 = (short)225785338;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num3 = (short)2052128768;
							if (num3 != 0)
							{
							}
							num3 = (short)576716807;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						break;
					}
					case 7:
						num3 = (short)583139328;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 8:
					{
						num3 = (short)946405376;
						short num5 = num3;
						goto IL_125;
					}
					}
					break;
					IL_125:
					num3 = (short)1891827716;
					num = (int)((global::System.IntPtr)num3);
				}
				IL_34:
				num2 = wParam.ToInt32();
				num3 = (short)245694470;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			IL_1F2:
			IL_1F4:
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006FB8 File Offset: 0x000051B8
		private global::System.IntPtr WmNcHitTest(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)784859136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_57;
				}
				int num3;
				int num4;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_160;
					case 1:
						if (base.WindowState == global::System.Windows.WindowState.Normal)
						{
							num = (short)1961361413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 2:
					{
						global::System.Windows.Rect rect;
						global::System.Windows.Point point;
						if (rect.Contains(point))
						{
							num = (short)2109603843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					}
					case 3:
						goto IL_134;
					case 4:
						if (base.ResizeMode == global::System.Windows.ResizeMode.CanResizeWithGrip)
						{
							num = (short)904921088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 5:
					{
						global::System.Windows.Point point = this._ResizeGrip.PointFromScreen(new global::System.Windows.Point((double)num3, (double)num4));
						global::System.Windows.Rect rect = new global::System.Windows.Rect(this._ResizeGrip.RenderSize);
						num = (short)1904738306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (this._ResizeGrip.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)305397769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 7:
						if (this._ResizeGrip != null)
						{
							num = (short)1642004488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 8:
						num = (short)937164806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)2024706;
						short num5 = num;
						num = (short)851371266;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_160;
						default:
							num = (short)605093888;
							if (num != 0)
							{
							}
							num = (short)295239684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_57;
					IL_160:
					num = (short)419364865;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_134:
				num = (short)1692073985;
				if (num != 0)
				{
				}
				handled = true;
				return new global::System.IntPtr(1);
				IL_27A:
				return global::System.IntPtr.Zero;
				IL_57:
				num = (short)1954283520;
				short num6 = num;
				num3 = global::DevComponents.WpfRibbon.WinApi.LOWORD(lParam);
				num4 = global::DevComponents.WpfRibbon.WinApi.HIWORD(lParam);
				num = (short)957546503;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x04000003 RID: 3
		public static readonly global::System.Windows.DependencyProperty VisualStyleProperty;

		// Token: 0x04000004 RID: 4
		private static readonly global::System.Windows.DependencyPropertyKey EffectiveStylePropertyKey;

		// Token: 0x04000005 RID: 5
		public static readonly global::System.Windows.DependencyProperty EffectiveStyleProperty;

		// Token: 0x04000006 RID: 6
		public static global::System.Windows.Input.RoutedCommand CloseWindow;

		// Token: 0x04000007 RID: 7
		public static global::System.Windows.Input.RoutedCommand MinimizeWindow;

		// Token: 0x04000008 RID: 8
		public static global::System.Windows.Input.RoutedCommand MaximizeWindow;

		// Token: 0x04000009 RID: 9
		public static global::System.Windows.Input.RoutedCommand RestoreWindow;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Controls.Border _WindowBorder;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Controls.Primitives.ResizeGrip _ResizeGrip;

		// Token: 0x0400000C RID: 12
		private bool _SourceInitialized;

		// Token: 0x0400000D RID: 13
		private bool _SizingWindow;

		// Token: 0x0400000E RID: 14
		private const string PartWindowBorder = "PART_WindowBorder";

		// Token: 0x0400000F RID: 15
		private const string PartWindowResizeGrip = "WindowResizeGrip";

		// Token: 0x04000010 RID: 16
		public static readonly global::System.Windows.DependencyProperty EnableSystemCaptionMenuProperty;

		// Token: 0x04000011 RID: 17
		private bool m_CursorIsSet;

		// Token: 0x04000012 RID: 18
		private bool _UpdatingWindowStyle;

		// Token: 0x04000013 RID: 19
		private bool _IsFirstLoad = true;
	}
}
