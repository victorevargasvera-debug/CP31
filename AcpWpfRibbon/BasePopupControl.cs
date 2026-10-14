using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200000D RID: 13
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class BasePopupControl : global::System.Windows.Controls.ItemsControl, global::DevComponents.WpfRibbon.IPopupParentControl
	{
		// Token: 0x060001AF RID: 431 RVA: 0x0002A968 File Offset: 0x00028B68
		static BasePopupControl()
		{
			int a_ = 3;
			short num = (short)272695297;
			if (num != 0)
			{
			}
			num = (short)2130448352;
			short num2 = num;
			num = (short)926814176;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1783496704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)570425344;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.BasePopupControl.IsSelectedChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ቚ⹜౞ѠརdѦᵨ๪६Ɱᥰቲ᭴ၶᱸὺ", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<bool>), typeof(global::DevComponents.WpfRibbon.BasePopupControl));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.BasePopupControl), global::DevComponents.WpfRibbon.ButtonDropDown.PreviewClickEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfRibbon.BasePopupControl.OnButtonDropDownPreviewClick));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.BasePopupControl), global::System.Windows.Input.Mouse.MouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::DevComponents.WpfRibbon.BasePopupControl.OnMouseButtonDown));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.BasePopupControl), global::System.Windows.Input.Mouse.MouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::DevComponents.WpfRibbon.BasePopupControl.OnMouseButtonUp));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.BasePopupControl), global::System.Windows.Input.Mouse.LostMouseCaptureEvent, new global::System.Windows.Input.MouseEventHandler(global::DevComponents.WpfRibbon.BasePopupControl.OnLostMouseCapture));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfRibbon.BasePopupControl), global::DevComponents.WpfRibbon.BasePopupControl.IsSelectedChangedEvent, new global::System.Windows.RoutedPropertyChangedEventHandler<bool>(global::DevComponents.WpfRibbon.BasePopupControl.OnIsSelectedChanged));
			global::System.Windows.Input.InputMethod.IsInputMethodSuspendedProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.BasePopupControl), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0002AB0C File Offset: 0x00028D0C
		public BasePopupControl()
		{
			this.m_PopupHandler = new global::DevComponents.WpfRibbon.ParentPopupControlImpl(this);
			this.m_PopupHandler.InternalMenuModeChanged += this.PopupHandlerMenuModeChanged;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0002AB44 File Offset: 0x00028D44
		private void PopupHandlerMenuModeChanged(object sender, global::System.EventArgs e)
		{
			short num = (short)780141040;
			short num2 = num;
			num = (short)1146356208;
			switch (num2 == num)
			{
			}
			num = (short)112066560;
			short num3 = num;
			num = (short)1901658113;
			if (num != 0)
			{
			}
			num = (short)290062336;
			if (num != 0)
			{
			}
			this.OnInternalMenuModeChanged(e);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0002ABF8 File Offset: 0x00028DF8
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			short num = (short)122967296;
			short num2 = num;
			num = (short)121656576;
			switch (num2 == num)
			{
			}
			num = (short)1127153664;
			short num3 = num;
			num = (short)1115619328;
			if (num != 0)
			{
			}
			num = (short)988479489;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfRibbon.ButtonDropDown();
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		private static void OnIsSelectedChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<bool> e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::DevComponents.WpfRibbon.BasePopupControl basePopupControl;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_C4;
				case 1:
					return;
				case 2:
					if (basePopupControl != null)
					{
						num2 = (short)1232076800;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_C4:
			num2 = (short)370868224;
			short num3 = num2;
			basePopupControl.OnSelectedChanged(sender, e);
			goto IL_F6;
			IL_1C:
			num2 = (short)1749876737;
			if (num2 != 0)
			{
			}
			basePopupControl = (global::DevComponents.WpfRibbon.BasePopupControl)sender;
			num2 = (short)400059638;
			short num4 = num2;
			num2 = (short)743009526;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F6:
				num2 = (short)2105540609;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1132462080;
				if (num2 != 0)
				{
				}
				num2 = (short)468975618;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0002ADC4 File Offset: 0x00028FC4
		private void OnSelectedChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<bool> e)
		{
			short num = (short)1523936778;
			short num2 = num;
			num = (short)46624266;
			switch (num2 == num)
			{
			}
			num = (short)2028929024;
			short num3 = num;
			num = (short)1300758529;
			if (num != 0)
			{
			}
			num = (short)1190592512;
			if (num != 0)
			{
			}
			this.m_PopupHandler.OnIsSelectedChanged(sender, e);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0002AE78 File Offset: 0x00029078
		private static void OnButtonDropDownPreviewClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2133248122;
			short num2 = num;
			num = (short)209504378;
			switch (num2 == num)
			{
			}
			num = (short)22675456;
			short num3 = num;
			num = (short)1525874689;
			if (num != 0)
			{
			}
			num = (short)1572143104;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ParentPopupControlImpl.OnButtonDropDownPreviewClick(sender, e);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0002AF28 File Offset: 0x00029128
		private static void OnMouseButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)2023942501;
			short num2 = num;
			num = (short)1215359333;
			switch (num2 == num)
			{
			}
			num = (short)1385889792;
			short num3 = num;
			num = (short)244973569;
			if (num != 0)
			{
			}
			num = (short)1231880192;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.BasePopupControl)sender).InternalMouseButtonDown(e);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0002AFE4 File Offset: 0x000291E4
		protected virtual void InternalMouseButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)22541194;
			short num2 = num;
			num = (short)259191690;
			switch (num2 == num)
			{
			}
			num = (short)944308224;
			short num3 = num;
			num = (short)392691713;
			if (num != 0)
			{
			}
			num = (short)236847104;
			if (num != 0)
			{
			}
			this.m_PopupHandler.ClosePopupOnMouseEvent(e);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0002B098 File Offset: 0x00029298
		private static void OnMouseButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)477626369;
			if (num != 0)
			{
			}
			num = (short)2039140313;
			short num2 = num;
			num = (short)30330841;
			switch (num2 == num)
			{
			default:
			{
				num = (short)654835712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1401946112;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.BasePopupControl)sender).InternalMouseButtonUp(e);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0002B154 File Offset: 0x00029354
		protected virtual void InternalMouseButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)639762433;
			if (num != 0)
			{
			}
			num = (short)1488226569;
			short num2 = num;
			num = (short)955287817;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1211957248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1396572160;
			if (num != 0)
			{
			}
			this.m_PopupHandler.ClosePopupOnMouseEvent(e);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0002B20C File Offset: 0x0002940C
		private static void OnLostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)672882968;
			short num2 = num;
			num = (short)69624088;
			switch (num2 == num)
			{
			}
			num = (short)2061762560;
			short num3 = num;
			num = (short)1580204033;
			if (num != 0)
			{
			}
			num = (short)651755520;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.ParentPopupControlImpl.OnLostMouseCapture(sender, e);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0002B2C0 File Offset: 0x000294C0
		protected internal virtual void OnInternalMenuModeChanged(global::System.EventArgs e)
		{
			short num = (short)1250052;
			short num2 = num;
			num = (short)154014468;
			switch (num2 == num)
			{
			}
			num = (short)96010240;
			short num3 = num;
			num = (short)1164115969;
			if (num != 0)
			{
			}
			num = (short)100270080;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0002B36C File Offset: 0x0002956C
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0002B424 File Offset: 0x00029624
		bool global::DevComponents.WpfRibbon.IPopupParentControl.IsPopupMode
		{
			get
			{
				short num = (short)432406529;
				if (num != 0)
				{
				}
				num = (short)935348499;
				short num2 = num;
				num = (short)1056590099;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1396178944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)147587072;
				if (num != 0)
				{
				}
				return this.m_PopupHandler.IsPopupMode;
			}
			set
			{
				short num = (short)629536663;
				short num2 = num;
				num = (short)1800796055;
				switch (num2 == num)
				{
				}
				num = (short)1196949504;
				short num3 = num;
				num = (short)143720449;
				if (num != 0)
				{
				}
				num = (short)755564544;
				if (num != 0)
				{
				}
				this.m_PopupHandler.IsPopupMode = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0002B4DC File Offset: 0x000296DC
		internal global::DevComponents.WpfRibbon.ButtonDropDown CurrentSelection
		{
			get
			{
				short num = (short)1487106387;
				short num2 = num;
				num = (short)175337811;
				switch (num2 == num)
				{
				}
				num = (short)1975713792;
				short num3 = num;
				num = (short)270598144;
				if (num != 0)
				{
				}
				num = (short)380698625;
				if (num != 0)
				{
				}
				return this.m_PopupHandler.CurrentSelection;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0002B590 File Offset: 0x00029790
		bool global::DevComponents.WpfRibbon.IPopupParentControl.QueryMouseCapturePopupClose(global::System.Windows.DependencyObject sourceObject)
		{
			short num = (short)1500544970;
			short num2 = num;
			num = (short)868581322;
			switch (num2 == num)
			{
			}
			num = (short)2077360128;
			short num3 = num;
			num = (short)2006777857;
			if (num != 0)
			{
			}
			num = (short)1326317568;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x04000097 RID: 151
		private global::DevComponents.WpfRibbon.ParentPopupControlImpl m_PopupHandler;

		// Token: 0x04000098 RID: 152
		internal static readonly global::System.Windows.RoutedEvent IsSelectedChangedEvent;
	}
}
