using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200001B RID: 27
	public class ButtonEx : global::DevComponents.WpfRibbon.ButtonDropDown, global::DevComponents.WpfRibbon.IPopupParentControl
	{
		// Token: 0x0600024D RID: 589 RVA: 0x00034864 File Offset: 0x00032A64
		static ButtonEx()
		{
			int a_ = 11;
			short num = (short)68085037;
			short num2 = num;
			num = (short)1601037613;
			switch (num2 == num)
			{
			}
			num = (short)852426753;
			if (num != 0)
			{
			}
			num = (short)780402688;
			short num3 = num;
			num = (short)929300480;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ButtonEx), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.ButtonEx)));
			global::DevComponents.WpfRibbon.ButtonEx.IsDefaultProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩢ᙤ⍦౨൪౬ᩮᵰݲ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonEx), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonEx.OnIsDefaultChanged)));
			global::DevComponents.WpfRibbon.ButtonEx.IsCancelProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⩢ᙤ⑦ࡨժ๬੮ᵰ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ButtonEx), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ButtonEx.OnIsCancelChanged)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.ButtonEx), global::DevComponents.WpfRibbon.ButtonDropDown.PreviewClickEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfRibbon.ButtonEx.OnButtonDropDownPreviewClick));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.ButtonEx), global::System.Windows.Input.Mouse.MouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::DevComponents.WpfRibbon.ButtonEx.OnMouseButtonDown));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.ButtonEx), global::System.Windows.Input.Mouse.MouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::DevComponents.WpfRibbon.ButtonEx.OnMouseButtonUp));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.ButtonEx), global::System.Windows.Input.Mouse.LostMouseCaptureEvent, new global::System.Windows.Input.MouseEventHandler(global::DevComponents.WpfRibbon.ButtonEx.OnLostMouseCapture));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.ButtonEx), global::DevComponents.WpfRibbon.BasePopupControl.IsSelectedChangedEvent, new global::System.Windows.RoutedPropertyChangedEventHandler<bool>(global::DevComponents.WpfRibbon.ButtonEx.OnIsSelectedChanged));
			global::System.Windows.Input.InputMethod.IsInputMethodSuspendedProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ButtonEx), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00034A80 File Offset: 0x00032C80
		public ButtonEx()
		{
			this.m_PopupHandler = new global::DevComponents.WpfRibbon.ParentPopupControlImpl(this);
			this.m_PopupHandler.InternalMenuModeChanged += this.PopupHandlerMenuModeChanged;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00034AB8 File Offset: 0x00032CB8
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00034B70 File Offset: 0x00032D70
		public bool IsCancel
		{
			get
			{
				short num = (short)2042103160;
				short num2 = num;
				num = (short)208864632;
				switch (num2 == num)
				{
				}
				num = (short)1158152192;
				if (num != 0)
				{
				}
				num = (short)350355456;
				short num3 = num;
				num = (short)1154613249;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonEx.IsCancelProperty);
			}
			set
			{
				short num = (short)638390523;
				short num2 = num;
				num = (short)412094715;
				switch (num2 == num)
				{
				}
				num = (short)960888833;
				if (num != 0)
				{
				}
				num = (short)1249443840;
				short num3 = num;
				num = (short)1536491520;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonEx.IsCancelProperty, value);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00034C28 File Offset: 0x00032E28
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00034CE4 File Offset: 0x00032EE4
		public bool IsDefault
		{
			get
			{
				short num = (short)137218865;
				short num2 = num;
				num = (short)1528417073;
				switch (num2 == num)
				{
				}
				num = (short)1275789312;
				if (num != 0)
				{
				}
				num = (short)2818048;
				short num3 = num;
				num = (short)2086076417;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ButtonEx.IsDefaultProperty);
			}
			set
			{
				short num = (short)1835206418;
				short num2 = num;
				num = (short)993920786;
				switch (num2 == num)
				{
				}
				num = (short)443219968;
				if (num != 0)
				{
				}
				num = (short)367591424;
				short num3 = num;
				num = (short)1378549761;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ButtonEx.IsDefaultProperty, value);
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00034DA0 File Offset: 0x00032FA0
		private static void OnIsDefaultChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			int a_ = 4;
			global::DevComponents.WpfRibbon.ButtonEx element = d as global::DevComponents.WpfRibbon.ButtonEx;
			short num;
			if ((bool)e.NewValue)
			{
				num = (short)1841236649;
				short num2 = num;
				num = (short)1802701481;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1109458945;
					if (num != 0)
					{
					}
					num = (short)1328676864;
					if (num != 0)
					{
					}
					break;
				}
				global::System.Windows.Input.AccessKeyManager.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("兛", a_), element);
				return;
			}
			num = (short)1563885568;
			short num3 = num;
			global::System.Windows.Input.AccessKeyManager.Unregister(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("兛", a_), element);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00034E98 File Offset: 0x00033098
		private static void OnIsCancelChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			int a_ = 2;
			global::DevComponents.WpfRibbon.ButtonEx element = d as global::DevComponents.WpfRibbon.ButtonEx;
			short num;
			if ((bool)e.NewValue)
			{
				num = (short)813658147;
				short num2 = num;
				num = (short)2122346531;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2107310080;
					if (num != 0)
					{
					}
					num = (short)511246337;
					if (num != 0)
					{
					}
					break;
				}
				global::System.Windows.Input.AccessKeyManager.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("䅙", a_), element);
				return;
			}
			num = (short)883556352;
			short num3 = num;
			global::System.Windows.Input.AccessKeyManager.Unregister(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("䅙", a_), element);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00034F8C File Offset: 0x0003318C
		protected override void SetPopupMode(bool popupMode)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					((global::DevComponents.WpfRibbon.IPopupParentControl)this).IsPopupMode = popupMode;
					num2 = (short)20774913;
					if (num2 != 0)
					{
					}
					num2 = (short)387579906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					IL_32:
					if (((global::DevComponents.WpfRibbon.IPopupParentControl)this).IsPopupMode != popupMode)
					{
						num2 = (short)789577728;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_98;
				case 2:
					goto IL_98;
				}
				goto IL_1C;
				IL_98:
				num2 = (short)588330403;
				short num3 = num2;
				num2 = (short)1662793123;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_32;
				default:
					goto IL_CC;
				}
			}
			IL_CC:
			num2 = (short)1972043776;
			if (num2 != 0)
			{
			}
			num2 = (short)75169792;
			short num4 = num2;
			return;
			IL_1C:
			num2 = (short)1618804737;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000350A4 File Offset: 0x000332A4
		private void PopupHandlerMenuModeChanged(object sender, global::System.EventArgs e)
		{
			short num = (short)1232077931;
			short num2 = num;
			num = (short)1080624235;
			switch (num2 == num)
			{
			}
			num = (short)1031471104;
			if (num != 0)
			{
			}
			num = (short)1862139904;
			short num3 = num;
			num = (short)1304625153;
			if (num != 0)
			{
			}
			this.OnInternalMenuModeChanged(e);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00035154 File Offset: 0x00033354
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			short num = (short)2068119554;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)464425491;
					short num3 = num;
					num = (short)1081709075;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1959133185;
						if (num != 0)
						{
						}
						num = (short)1271726080;
						if (num != 0)
						{
						}
						num = (short)1259012097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (item is global::System.Windows.Controls.Separator)
					{
						num = (short)853934083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					goto IL_12D;
				}
				IL_34:
				if (item is global::DevComponents.WpfRibbon.ButtonDropDown)
				{
					break;
				}
				num = (short)662306816;
				short num4 = num;
				num = (short)2007957504;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_12D:
			return true;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00035294 File Offset: 0x00033494
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			short num = (short)1753818402;
			short num2 = num;
			num = (short)124265762;
			switch (num2 == num)
			{
			}
			num = (short)88014849;
			if (num != 0)
			{
			}
			num = (short)1646919680;
			short num3 = num;
			num = (short)2136932352;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfRibbon.ButtonDropDown();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00035344 File Offset: 0x00033544
		private static void OnIsSelectedChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<bool> e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfRibbon.ButtonEx buttonEx;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					buttonEx.OnSelectedChanged(sender, e);
					num2 = (short)317784066;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					IL_37:
					if (buttonEx != null)
					{
						num2 = (short)506331136;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6E;
				case 2:
					goto IL_6E;
				}
				goto IL_1C;
				IL_6E:
				num2 = (short)609263022;
				short num3 = num2;
				num2 = (short)839032238;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_37;
				default:
					goto IL_A3;
				}
			}
			IL_A3:
			num2 = (short)209846273;
			if (num2 != 0)
			{
			}
			num2 = (short)533921792;
			if (num2 != 0)
			{
			}
			num2 = (short)386269184;
			short num4 = num2;
			return;
			IL_1C:
			buttonEx = (global::DevComponents.WpfRibbon.ButtonEx)sender;
			num2 = (short)1033437185;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0003545C File Offset: 0x0003365C
		private void OnSelectedChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<bool> e)
		{
			short num = (short)198552260;
			short num2 = num;
			num = (short)475441860;
			switch (num2 == num)
			{
			}
			num = (short)210632704;
			if (num != 0)
			{
			}
			num = (short)2144796672;
			short num3 = num;
			num = (short)1959198721;
			if (num != 0)
			{
			}
			this.m_PopupHandler.OnIsSelectedChanged(sender, e);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00035514 File Offset: 0x00033714
		private static void OnButtonDropDownPreviewClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)892631647;
			short num2 = num;
			num = (short)1947040351;
			switch (num2 == num)
			{
			}
			num = (short)2071265280;
			if (num != 0)
			{
			}
			num = (short)1164050432;
			short num3 = num;
			num = (short)1860894721;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ParentPopupControlImpl.OnButtonDropDownPreviewClick(sender, e);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000355C4 File Offset: 0x000337C4
		private static void OnMouseButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1154267524;
			short num2 = num;
			num = (short)1485289860;
			switch (num2 == num)
			{
			}
			num = (short)475987969;
			if (num != 0)
			{
			}
			num = (short)270532608;
			short num3 = num;
			num = (short)215678976;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ButtonEx)sender).InternalMouseButtonDown(e);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00035678 File Offset: 0x00033878
		protected virtual void InternalMouseButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)861681201;
			short num2 = num;
			num = (short)1100559921;
			switch (num2 == num)
			{
			}
			num = (short)1953759233;
			if (num != 0)
			{
			}
			num = (short)986644480;
			short num3 = num;
			num = (short)1280638976;
			if (num != 0)
			{
			}
			this.m_PopupHandler.ClosePopupOnMouseEvent(e);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00035734 File Offset: 0x00033934
		private static void OnMouseButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)835321856;
			short num2 = num;
			num = (short)1042117881;
			short num3 = num;
			num = (short)43480313;
			switch (num3 == num)
			{
			}
			num = (short)1763246080;
			if (num != 0)
			{
			}
			num = (short)774307841;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ButtonEx)sender).InternalMouseButtonUp(e);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000357EC File Offset: 0x000339EC
		protected virtual void InternalMouseButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::System.Windows.FrameworkElement frameworkElement;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (frameworkElement == null)
					{
						goto IL_175;
					}
					num2 = (short)850934144;
					short num3 = num2;
					num2 = (short)228211072;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15C;
					default:
						num2 = (short)238551040;
						if (num2 != 0)
						{
						}
						num2 = (short)2114322433;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)413466625;
					if (num2 != 0)
					{
					}
					num2 = (short)1040777216;
					short num4 = num2;
					num2 = (short)1626275843;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (frameworkElement.TemplatedParent == this)
					{
						num2 = (short)667746309;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_175;
				case 3:
					if (frameworkElement != this)
					{
						goto IL_15C;
					}
					return;
				case 4:
					num2 = (short)1637023746;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_13F;
				}
				goto IL_28;
				IL_15C:
				num2 = (short)367788036;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_13F:
			return;
			IL_175:
			this.m_PopupHandler.ClosePopupOnMouseEvent(e);
			return;
			IL_28:
			frameworkElement = (e.OriginalSource as global::System.Windows.FrameworkElement);
			num2 = (short)1700003840;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0003597C File Offset: 0x00033B7C
		private static void OnLostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1274609664;
			short num2 = num;
			num = (short)1257843955;
			short num3 = num;
			num = (short)1258106099;
			switch (num3 == num)
			{
			}
			num = (short)1905459201;
			if (num != 0)
			{
			}
			num = (short)1579745280;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ParentPopupControlImpl.OnLostMouseCapture(sender, e);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00035A30 File Offset: 0x00033C30
		protected internal virtual void OnInternalMenuModeChanged(global::System.EventArgs e)
		{
			short num = (short)707264512;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
					num = (short)1766719492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1542586369;
					if (num != 0)
					{
					}
					base.IsPopupOpen = false;
					num = (short)1599733763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					if (base.IsPopupOpen)
					{
						num = (short)1113718786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_38:
				num = (short)300434513;
				short num3 = num;
				num = (short)62276689;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1985347584;
					if (num != 0)
					{
					}
					num = (short)1719140352;
					short num4 = num;
					if (this.m_PopupHandler.IsPopupMode)
					{
						return;
					}
					break;
				}
				}
				num = (short)1175715841;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00035B9C File Offset: 0x00033D9C
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00035C50 File Offset: 0x00033E50
		bool global::DevComponents.WpfRibbon.IPopupParentControl.IsPopupMode
		{
			get
			{
				short num = (short)795869184;
				short num2 = num;
				num = (short)817073277;
				short num3 = num;
				num = (short)1755352189;
				switch (num3 == num)
				{
				}
				num = (short)676331521;
				if (num != 0)
				{
				}
				num = (short)1102249984;
				if (num != 0)
				{
				}
				return this.m_PopupHandler.IsPopupMode;
			}
			set
			{
				short num = (short)656015360;
				short num2 = num;
				num = (short)1430330772;
				short num3 = num;
				num = (short)1147870612;
				switch (num3 == num)
				{
				}
				num = (short)1495793664;
				if (num != 0)
				{
				}
				num = (short)206503937;
				if (num != 0)
				{
				}
				this.m_PopupHandler.IsPopupMode = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00035D04 File Offset: 0x00033F04
		internal global::DevComponents.WpfRibbon.ButtonDropDown CurrentSelection
		{
			get
			{
				short num = (short)1129840640;
				short num2 = num;
				num = (short)2007152205;
				short num3 = num;
				num = (short)1561245261;
				switch (num3 == num)
				{
				}
				num = (short)1206517760;
				if (num != 0)
				{
				}
				num = (short)1508769793;
				if (num != 0)
				{
				}
				return this.m_PopupHandler.CurrentSelection;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00035DB8 File Offset: 0x00033FB8
		bool global::DevComponents.WpfRibbon.IPopupParentControl.QueryMouseCapturePopupClose(global::System.Windows.DependencyObject sourceObject)
		{
			short num = (short)523370496;
			short num2 = num;
			num = (short)1089320584;
			short num3 = num;
			num = (short)217560712;
			switch (num3 == num)
			{
			}
			num = (short)1312292864;
			if (num != 0)
			{
			}
			num = (short)1032060929;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00035E64 File Offset: 0x00034064
		protected override global::DevComponents.WpfRibbon.eButtonRenderingState GetBorderRenderState()
		{
			short num = (short)1719402497;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			global::DevComponents.WpfRibbon.eButtonRenderingState eButtonRenderingState;
			for (;;)
			{
				IL_30:
				int num2;
				switch (num2)
				{
				case 0:
					eButtonRenderingState = global::DevComponents.WpfRibbon.eButtonRenderingState.Normal;
					num = (short)82182156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_FB;
				case 2:
				{
					num = (short)291897344;
					short num3 = num;
					num = (short)379322372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					num = (short)1016856582;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (eButtonRenderingState != global::DevComponents.WpfRibbon.eButtonRenderingState.CheckedHover)
					{
						num = (short)1386086411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13A;
				case 5:
					if (!base.IsHighlighted)
					{
						num = (short)138543104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return eButtonRenderingState;
				case 6:
				{
					global::System.Windows.Rect rect;
					if (!rect.Contains(global::System.Windows.Input.Mouse.GetPosition(this)))
					{
						num = (short)1560412161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return eButtonRenderingState;
				}
				case 7:
					if (base.IsKeyboardFocusWithin)
					{
						num = (short)1895825410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return eButtonRenderingState;
				case 8:
					if (base.IsMouseOver)
					{
						num = (short)237568003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FB;
				case 9:
					goto IL_23B;
				case 10:
					if (eButtonRenderingState == global::DevComponents.WpfRibbon.eButtonRenderingState.Hover)
					{
						num = (short)114688009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return eButtonRenderingState;
				case 11:
					num = (short)726532106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_205;
				}
				goto IL_6A;
				IL_FB:
				num = (short)1167589381;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_205:
			return eButtonRenderingState;
			IL_23B:
			goto IL_13A;
			IL_6A:
			num = (short)1370637239;
			short num4 = num;
			num = (short)792740791;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_13A:
				global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
				num = (short)423100424;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			default:
			{
				num = (short)1019609088;
				if (num != 0)
				{
				}
				eButtonRenderingState = base.GetBorderRenderState();
				num = (short)1965555719;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x040000D1 RID: 209
		public static readonly global::System.Windows.DependencyProperty IsCancelProperty;

		// Token: 0x040000D2 RID: 210
		public static readonly global::System.Windows.DependencyProperty IsDefaultProperty;

		// Token: 0x040000D3 RID: 211
		private global::DevComponents.WpfRibbon.ParentPopupControlImpl m_PopupHandler;
	}
}
