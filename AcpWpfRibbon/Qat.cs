using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200006C RID: 108
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class Qat : global::DevComponents.WpfRibbon.BasePopupControl
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x00070500 File Offset: 0x0006E700
		static Qat()
		{
			int a_ = 16;
			short num = (short)6553601;
			if (num != 0)
			{
			}
			num = (short)1972436992;
			short num2 = num;
			num = (short)72969317;
			short num3 = num;
			num = (short)1755016293;
			switch (num3 == num)
			{
			}
			num = (short)1673068544;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.Qat), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.Qat)));
			global::DevComponents.WpfRibbon.Qat.IsOverflowItemPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅷᥩ⍫ᡭᕯqታ᩵᝷൹㕻੽", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Qat), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.Qat.IsOverflowItemProperty = global::DevComponents.WpfRibbon.Qat.IsOverflowItemPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Qat.HasOverflowItemsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁧୩ὫⅭٯ᝱ٳၵᑷᕹ୻㝽", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Qat), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.Qat.HasOverflowItemsProperty = global::DevComponents.WpfRibbon.Qat.HasOverflowItemsPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Qat.IsOverflowOpenProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅷᥩ⍫ᡭᕯqታ᩵᝷൹㍻๽", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Qat), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Qat.OnIsOverflowOpenChanged), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.Qat.CoerceIsOverflowOpen)));
			global::DevComponents.WpfRibbon.Qat.IsAboveRibbonPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅷᥩ⵫౭Ὧѱᅳ⑵ᅷ᡹ṻᅽ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Qat), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfRibbon.Qat.IsAboveRibbonProperty = global::DevComponents.WpfRibbon.Qat.IsAboveRibbonPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Qat.IsActiveProperty = global::DevComponents.WpfRibbon.Ribbon.IsActiveProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.Qat), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfRibbon.Qat.IsGlassEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅷᥩ⭫ɭᅯűݳ㍵ᙷ᭹ṻች", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Qat), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.Qat), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::System.Windows.Controls.Control.IsTabStopProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.Qat), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00070798 File Offset: 0x0006E998
		public override void OnApplyTemplate()
		{
			int a_ = 17;
			short num = (short)206280815;
			short num2 = num;
			num = (short)861378671;
			switch (num2 == num)
			{
			default:
			{
				num = (short)562823168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1633157121;
			if (num != 0)
			{
			}
			num = (short)1240399872;
			if (num != 0)
			{
			}
			this.m_OverflowPanel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㥨⩪㽬㭮⹰㱲ʹቶ୸ᵺᅼၾ펂", a_)) as global::DevComponents.WpfRibbon.QatOverflowPanel);
			base.OnApplyTemplate();
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00070870 File Offset: 0x0006EA70
		internal static void SetIsOverflowItem(global::System.Windows.DependencyObject element, object value)
		{
			short num = (short)1811415041;
			if (num != 0)
			{
			}
			num = (short)1512570880;
			short num2 = num;
			num = (short)599724094;
			short num3 = num;
			num = (short)1298927678;
			switch (num3 == num)
			{
			}
			num = (short)249561088;
			if (num != 0)
			{
			}
			element.SetValue(global::DevComponents.WpfRibbon.Qat.IsOverflowItemPropertyKey, value);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00070928 File Offset: 0x0006EB28
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1112080384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)725614596;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
						{
							num = (short)1684275201;
							if (num != 0)
							{
							}
							num = (short)1864368130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_487;
					case 1:
					{
						num = (short)1886715904;
						short num3 = num;
						goto IL_2F4;
					}
					case 2:
						enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
						num = (short)1979777027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_CE;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 5:
						try
						{
							num = (short)1641283589;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
									if (buttonDropDown != null)
									{
										num = (short)1717239812;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)369950723;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = enumerator.Current as global::DevComponents.WpfRibbon.ButtonDropDown;
									num = (short)962920448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)144572422;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
									buttonDropDown.UseSmallImage = true;
									goto IL_186;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_17D;
									}
									continue;
								case 6:
									goto IL_27C;
								}
								goto IL_17D;
								IL_186:
								num = (short)134086658;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D9:
								num = (short)1033048472;
								short num4 = num;
								num = (short)1402474904;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_186;
								default:
									num = (short)1865678848;
									if (num != 0)
									{
									}
									num = (short)1506672641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17D:
								goto IL_1D9;
							}
							IL_27C:
							goto IL_487;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_29E;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_28B:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)177864706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)1487798272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2F3;
								case 2:
									goto IL_2F1;
								}
								goto IL_29E;
							}
							IL_2F1:
							IL_2F3:
							goto EndFinally_14;
							IL_29E:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1971912705;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_28B;
							EndFinally_14:;
						}
						goto IL_2F4;
					}
					IL_5B:
					if (e.NewItems != null)
					{
						num = (short)879886337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1311637504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F4:
					enumerator = e.NewItems.GetEnumerator();
					num = (short)775487493;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CE:
				try
				{
					num = (short)1478033413;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1693974534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown2;
							buttonDropDown2.UseSmallImage = true;
							num = (short)1147469827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1486159872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown2 = enumerator.Current as global::DevComponents.WpfRibbon.ButtonDropDown;
							num = (short)75300868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown2;
							if (buttonDropDown2 != null)
							{
								num = (short)1067843585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_360;
							}
							continue;
						case 6:
							goto IL_412;
						}
						IL_362:
						num = (short)1191772162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_360:
						goto IL_362;
					}
					IL_412:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_431;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_41E:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)2002124802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (disposable != null)
							{
								num = (short)2116354048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_486;
						case 2:
							goto IL_484;
						}
						goto IL_431;
					}
					IL_484:
					IL_486:
					goto EndFinally_13;
					IL_431:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)698482689;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_41E;
					EndFinally_13:;
				}
				IL_487:
				base.OnItemsChanged(e);
				return;
			}
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00070DF8 File Offset: 0x0006EFF8
		public static bool GetIsOverflowItem(global::System.Windows.DependencyObject element)
		{
			int a_ = 1;
			short num;
			if (element == null)
			{
				for (;;)
				{
					num = (short)192413696;
					short num2 = num;
					num = (short)871702728;
					short num3 = num;
					num = (short)1503207624;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6E;
					}
				}
				IL_6E:
				num = (short)1151795200;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㱘㝚㡜㉞", a_));
			}
			num = (short)1099890689;
			if (num != 0)
			{
			}
			return (bool)element.GetValue(global::DevComponents.WpfRibbon.Qat.IsOverflowItemProperty);
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00070ED8 File Offset: 0x0006F0D8
		internal global::DevComponents.WpfRibbon.QatOverflowPanel OverflowPanel
		{
			get
			{
				short num = (short)1289379141;
				short num2 = num;
				num = (short)879779141;
				switch (num2 == num)
				{
				default:
				{
					num = (short)173015040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1445527553;
				if (num != 0)
				{
				}
				num = (short)1362558976;
				if (num != 0)
				{
				}
				return this.m_OverflowPanel;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00070F88 File Offset: 0x0006F188
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00071040 File Offset: 0x0006F240
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsAboveRibbon
		{
			get
			{
				short num = (short)1677908359;
				short num2 = num;
				num = (short)273144199;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1017184256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1775370241;
				if (num != 0)
				{
				}
				num = (short)1091305472;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Qat.IsAboveRibbonProperty);
			}
			internal set
			{
				short num = (short)1891815903;
				short num2 = num;
				num = (short)302567903;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1254621184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)662896640;
				if (num != 0)
				{
				}
				num = (short)1378877441;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Qat.IsAboveRibbonPropertyKey, value);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x000710F8 File Offset: 0x0006F2F8
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x000711B0 File Offset: 0x0006F3B0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasOverflowItems
		{
			get
			{
				short num = (short)1968512880;
				short num2 = num;
				num = (short)1779965808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)401997824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2011561984;
				if (num != 0)
				{
				}
				num = (short)1164509185;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Qat.HasOverflowItemsProperty);
			}
			internal set
			{
				short num = (short)334876460;
				short num2 = num;
				num = (short)1131859756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)855244800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)141426689;
				if (num != 0)
				{
				}
				num = (short)702545920;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Qat.HasOverflowItemsPropertyKey, value);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0007126C File Offset: 0x0006F46C
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00071324 File Offset: 0x0006F524
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsOverflowOpen
		{
			get
			{
				short num = (short)1042754715;
				short num2 = num;
				num = (short)805121179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1428357120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1397489665;
				if (num != 0)
				{
				}
				num = (short)1808465920;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Qat.IsOverflowOpenProperty);
			}
			set
			{
				short num = (short)1266618796;
				short num2 = num;
				num = (short)1903628716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)961806336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1928200193;
				if (num != 0)
				{
				}
				num = (short)1767636992;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Qat.IsOverflowOpenProperty, value);
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000713DC File Offset: 0x0006F5DC
		private void RegisterToOpenOnLoad()
		{
			short num = (short)1245312092;
			short num2 = num;
			num = (short)954266716;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1590362112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)221118464;
			if (num != 0)
			{
			}
			num = (short)1076953089;
			if (num != 0)
			{
			}
			base.Loaded += this.OpenOnLoad;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0007149C File Offset: 0x0006F69C
		private void OpenOnLoad(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1028805666;
			short num2 = num;
			num = (short)1919833122;
			switch (num2 == num)
			{
			default:
			{
				num = (short)254410752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)449642497;
			if (num != 0)
			{
			}
			num = (short)312737792;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::System.Windows.Threading.DispatcherOperationCallback(this.OpenPopupOnLoad), null);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0007155C File Offset: 0x0006F75C
		private object OpenPopupOnLoad(object arg)
		{
			short num = (short)252914426;
			short num2 = num;
			num = (short)1862150906;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1969094656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1329987585;
			if (num != 0)
			{
			}
			num = (short)1177485312;
			if (num != 0)
			{
			}
			base.CoerceValue(global::DevComponents.WpfRibbon.Qat.IsOverflowOpenProperty);
			return null;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00071614 File Offset: 0x0006F814
		private static void OnIsOverflowOpenChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::DevComponents.WpfRibbon.Qat qat = (global::DevComponents.WpfRibbon.Qat)d;
			if ((bool)e.NewValue)
			{
				short num;
				for (;;)
				{
					num = (short)42074112;
					short num2 = num;
					num = (short)1231689579;
					short num3 = num;
					num = (short)1378490219;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_77;
					}
				}
				IL_77:
				num = (short)2088894464;
				if (num != 0)
				{
				}
				num = (short)546439169;
				if (num != 0)
				{
				}
				((global::DevComponents.WpfRibbon.IPopupParentControl)qat).IsPopupMode = true;
				qat.FocusOverflowPanel();
				return;
			}
			((global::DevComponents.WpfRibbon.IPopupParentControl)qat).IsPopupMode = false;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000716E8 File Offset: 0x0006F8E8
		private void FocusOverflowPanel()
		{
			short num = (short)853428196;
			short num2 = num;
			num = (short)619202532;
			switch (num2 == num)
			{
			default:
			{
				num = (short)418185216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)720371712;
			if (num != 0)
			{
			}
			num = (short)1079836673;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::System.Windows.Threading.DispatcherOperationCallback(this.FocusOverflowPanel), null);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000717AC File Offset: 0x0006F9AC
		private object FocusOverflowPanel(object arg)
		{
			short num = (short)1728184321;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1058069087;
				short num3 = num;
				num = (short)191683167;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1721696256;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						this.OverflowPanel.Focus();
						num = (short)1333002242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 2:
						goto IL_BE;
					}
					IL_7A:
					if (this.OverflowPanel == null)
					{
						goto IL_110;
					}
					break;
				}
				num = (short)870187008;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BE:
			num = (short)1942355968;
			short num4 = num;
			num = (short)601096193;
			if (num != 0)
			{
			}
			IL_110:
			return null;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000718CC File Offset: 0x0006FACC
		private static object CoerceIsOverflowOpen(global::System.Windows.DependencyObject d, object value)
		{
			short num = (short)2117795842;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfRibbon.Qat qat;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (qat.IsLoaded)
					{
						return value;
					}
					num = (short)369132052;
					short num3 = num;
					num = (short)879329812;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						num = (short)428277760;
						if (num != 0)
						{
						}
						num = (short)879296515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					qat = (global::DevComponents.WpfRibbon.Qat)d;
					num = (short)1657798656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				case 3:
					goto IL_11A;
				}
				IL_36:
				if (!(bool)value)
				{
					return value;
				}
				num = (short)410648576;
				short num4 = num;
				num = (short)866516993;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_80:
			qat.RegisterToOpenOnLoad();
			return false;
			IL_11A:
			num = (short)1488650241;
			if (num != 0)
			{
			}
			goto IL_80;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00071A20 File Offset: 0x0006FC20
		protected internal override void OnInternalMenuModeChanged(global::System.EventArgs e)
		{
			short num = (short)86376451;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A1;
				case 1:
				{
					if (!this.IsOverflowOpen)
					{
						return;
					}
					num = (short)583467008;
					short num3 = num;
					num = (short)583186139;
					short num4 = num;
					num = (short)1432008411;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A1;
					default:
						num = (short)717684736;
						if (num != 0)
						{
						}
						num = (short)1761804292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				case 3:
					num = (short)414384129;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 4:
					this.IsOverflowOpen = false;
					num = (short)513343490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5F:
				if (!((global::DevComponents.WpfRibbon.IPopupParentControl)this).IsPopupMode)
				{
					num = (short)672333824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A1:
				num = (short)943521793;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00071B84 File Offset: 0x0006FD84
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00071C40 File Offset: 0x0006FE40
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsActive
		{
			get
			{
				short num = (short)848166913;
				if (num != 0)
				{
				}
				num = (short)1194393600;
				short num2 = num;
				num = (short)149020902;
				short num3 = num;
				num = (short)1905320166;
				switch (num3 == num)
				{
				}
				num = (short)2055602176;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Qat.IsActiveProperty);
			}
			set
			{
				short num = (short)43843585;
				if (num != 0)
				{
				}
				num = (short)110297088;
				short num2 = num;
				num = (short)1627769606;
				short num3 = num;
				num = (short)1716308742;
				switch (num3 == num)
				{
				}
				num = (short)1940324352;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Qat.IsActiveProperty, value);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00071CF8 File Offset: 0x0006FEF8
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00071DB0 File Offset: 0x0006FFB0
		public bool IsGlassEnabled
		{
			get
			{
				short num = (short)1589546700;
				short num2 = num;
				num = (short)1661505228;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1665990656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1260650497;
				if (num != 0)
				{
				}
				num = (short)1684406272;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Qat.IsGlassEnabledProperty);
			}
			set
			{
				short num = (short)505881869;
				short num2 = num;
				num = (short)294987021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)880607232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1385758721;
				if (num != 0)
				{
				}
				num = (short)1530593280;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Qat.IsGlassEnabledProperty, value);
			}
		}

		// Token: 0x04000292 RID: 658
		public static readonly global::System.Windows.DependencyProperty IsOverflowItemProperty;

		// Token: 0x04000293 RID: 659
		internal static readonly global::System.Windows.DependencyPropertyKey IsOverflowItemPropertyKey;

		// Token: 0x04000294 RID: 660
		public static readonly global::System.Windows.DependencyProperty HasOverflowItemsProperty;

		// Token: 0x04000295 RID: 661
		internal static readonly global::System.Windows.DependencyPropertyKey HasOverflowItemsPropertyKey;

		// Token: 0x04000296 RID: 662
		public static readonly global::System.Windows.DependencyProperty IsOverflowOpenProperty;

		// Token: 0x04000297 RID: 663
		public static readonly global::System.Windows.DependencyProperty IsAboveRibbonProperty;

		// Token: 0x04000298 RID: 664
		internal static readonly global::System.Windows.DependencyPropertyKey IsAboveRibbonPropertyKey;

		// Token: 0x04000299 RID: 665
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty;

		// Token: 0x0400029A RID: 666
		public static readonly global::System.Windows.DependencyProperty IsGlassEnabledProperty;

		// Token: 0x0400029B RID: 667
		private const string OverflowButtonName = "PART_OverflowButton";

		// Token: 0x0400029C RID: 668
		private const string OverflowPanelName = "PART_OverflowPanel";

		// Token: 0x0400029D RID: 669
		private global::DevComponents.WpfRibbon.QatOverflowPanel m_OverflowPanel;
	}
}
