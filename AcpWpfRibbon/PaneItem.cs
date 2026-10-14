using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000069 RID: 105
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PaneItem : global::System.Windows.Controls.HeaderedContentControl
	{
		// Token: 0x060004DA RID: 1242 RVA: 0x00069AA4 File Offset: 0x00067CA4
		static PaneItem()
		{
			int a_ = 6;
			short num = (short)1620691153;
			short num2 = num;
			num = (short)300927185;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1224802304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)681377793;
			if (num != 0)
			{
			}
			num = (short)369098752;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.PaneItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.PaneItem)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.PaneItem), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.PaneItem.VisibilityChanged)));
			global::DevComponents.WpfRibbon.PaneItem.IsSelectedProperty = global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.PaneItem), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.PaneItem.OnIsSelectedChanged)));
			global::DevComponents.WpfRibbon.PaneItem.ImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝝ൟͣͥ͡", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.PaneItem), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfRibbon.PaneItem.ImageSourceProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝝ൟͣͥ͡㭧թᥫᱭ፯᝱", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.PaneItem), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.PaneItem.ImageSourceChanged)));
			global::DevComponents.WpfRibbon.PaneItem.ImageSmallProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝝ൟͣͥ͡㭧ݩ൫ɭᱯ", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.PaneItem), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfRibbon.PaneItem.ImageSmallSourceProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝝ൟͣͥ͡㭧ݩ൫ɭᱯⅱ᭳͵੷᥹᥻", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.PaneItem), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.PaneItem.ImageSmallSourceChanged)));
			global::DevComponents.WpfRibbon.PaneItem.TitleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("੝य़ᙡࡣͥ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.PaneItem), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.PaneItem.SmallStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝ൟ͡ࡣ੥㭧ṩ൫ᩭᕯ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.PaneItem), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.PaneItem.SmallStateChanged)));
			global::DevComponents.WpfRibbon.PaneItem.PaneExpandedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("๝şౡţ⍥ၧᩩ൫mᑯ᝱ၳ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.PaneItem), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.PaneItem.PaneExpandedChanged)));
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00069D70 File Offset: 0x00067F70
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)960511632;
			short num2 = num;
			num = (short)202653328;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1884225536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1845559297;
			if (num != 0)
			{
			}
			num = (short)290717696;
			if (num != 0)
			{
			}
			this._MouseLeftButtonDown = true;
			base.CaptureMouse();
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00069E2C File Offset: 0x0006802C
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)353632260;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!global::DevComponents.WpfRibbon.WinApi.KeyValidated)
					{
						num = (short)1780613121;
						if (num != 0)
						{
						}
						num = (short)2078801928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1504706560;
					short num3 = num;
					num = (short)19529733;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::System.Windows.Rect rect;
					if (rect.Contains(e.GetPosition(this)))
					{
						num = (short)623706119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_217;
				}
				case 2:
					goto IL_107;
				case 3:
					goto IL_C4;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 5:
				{
					if (!this._MouseLeftButtonDown)
					{
						goto IL_217;
					}
					num = (short)94225387;
					short num4 = num;
					num = (short)1892402155;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C4;
					default:
						num = (short)958005248;
						if (num != 0)
						{
						}
						num = (short)579862534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
				{
					global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
					num = (short)1913782273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					this.IsSelected = true;
					num = (short)1234698249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return;
				case 9:
					goto IL_102;
				}
				IL_4C:
				if (base.IsMouseCaptured)
				{
					num = (short)1110048771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_107;
				IL_C4:
				base.ReleaseMouseCapture();
				num = (short)663289858;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_107:
				num = (short)332988416;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_102:
			IL_217:
			this._MouseLeftButtonDown = false;
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0006A060 File Offset: 0x00068260
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x0006A11C File Offset: 0x0006831C
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsSelected
		{
			get
			{
				short num = (short)1492516864;
				short num2 = num;
				num = (short)1899650143;
				short num3 = num;
				num = (short)753884255;
				switch (num3 == num)
				{
				}
				num = (short)493420545;
				if (num != 0)
				{
				}
				num = (short)547356672;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.PaneItem.IsSelectedProperty);
			}
			set
			{
				short num = (short)2097086464;
				short num2 = num;
				num = (short)1492517046;
				short num3 = num;
				num = (short)1150419126;
				switch (num3 == num)
				{
				}
				num = (short)1476001792;
				if (num != 0)
				{
				}
				num = (short)1501036545;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.PaneItem.IsSelectedProperty, value);
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0006A1D8 File Offset: 0x000683D8
		private static void OnIsSelectedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::DevComponents.WpfRibbon.PaneItem paneItem;
			short num;
			for (;;)
			{
				paneItem = (d as global::DevComponents.WpfRibbon.PaneItem);
				if (!(bool)e.NewValue)
				{
					goto IL_C9;
				}
				num = (short)2062942208;
				short num2 = num;
				num = (short)1661120845;
				short num3 = num;
				num = (short)1400287565;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_79;
				}
			}
			IL_79:
			num = (short)1948450816;
			if (num != 0)
			{
			}
			num = (short)1410138113;
			if (num != 0)
			{
			}
			paneItem.OnSelected(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.Primitives.Selector.SelectedEvent, paneItem));
			return;
			IL_C9:
			paneItem.OnUnselected(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.Primitives.Selector.UnselectedEvent, paneItem));
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0006A2C0 File Offset: 0x000684C0
		protected virtual void OnSelected(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1716322304;
			short num2 = num;
			num = (short)906904641;
			short num3 = num;
			num = (short)1720796225;
			switch (num3 == num)
			{
			}
			num = (short)1923940352;
			if (num != 0)
			{
			}
			num = (short)1756495873;
			if (num != 0)
			{
			}
			this.RaiseSelectedEvents(true, e);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0006A374 File Offset: 0x00068574
		protected virtual void OnUnselected(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1770848256;
			short num2 = num;
			num = (short)1836495090;
			short num3 = num;
			num = (short)1156296946;
			switch (num3 == num)
			{
			}
			num = (short)363397120;
			if (num != 0)
			{
			}
			num = (short)1799028737;
			if (num != 0)
			{
			}
			this.RaiseSelectedEvents(false, e);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0006A424 File Offset: 0x00068624
		private void RaiseSelectedEvents(bool newValue, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)161087488;
			short num2 = num;
			num = (short)1729549611;
			short num3 = num;
			num = (short)893900075;
			switch (num3 == num)
			{
			}
			num = (short)934871041;
			if (num != 0)
			{
			}
			num = (short)353566720;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0006A4D4 File Offset: 0x000686D4
		private static void VisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1488977920;
			short num2 = num;
			num = (short)377337984;
			short num3 = num;
			num = (short)345946240;
			switch (num3 == num)
			{
			}
			num = (short)1180696577;
			if (num != 0)
			{
			}
			num = (short)57016320;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.PaneItem)d).VisibilityChanged();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0006A588 File Offset: 0x00068788
		private void VisibilityChanged()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			global::DevComponents.WpfRibbon.NavigationPane navigationPane;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1013907457;
					if (num2 != 0)
					{
					}
					if (navigationPane != null)
					{
						num2 = (short)458227714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EA;
				case 1:
					goto IL_E8;
				case 2:
					goto IL_C9;
				}
				goto IL_1C;
			}
			IL_C9:
			goto IL_CB;
			IL_E8:
			IL_EA:
			num2 = (short)765722624;
			short num3 = num2;
			navigationPane.ItemVisibilityChanged(this);
			return;
			IL_1C:
			num2 = (short)2119704379;
			short num4 = num2;
			num2 = (short)228597563;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_CB:
				navigationPane.UpdateItemsState();
				num2 = (short)2076573697;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1296891904;
				if (num2 != 0)
				{
				}
				navigationPane = (base.Parent as global::DevComponents.WpfRibbon.NavigationPane);
				num2 = (short)1620574208;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0006A6B0 File Offset: 0x000688B0
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x0006A764 File Offset: 0x00068964
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.DefaultValue(null)]
		public object Image
		{
			get
			{
				short num = (short)202178560;
				short num2 = num;
				num = (short)319947994;
				short num3 = num;
				num = (short)722142426;
				switch (num3 == num)
				{
				}
				num = (short)1503854593;
				if (num != 0)
				{
				}
				num = (short)633602048;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.PaneItem.ImageProperty);
			}
			set
			{
				short num = (short)1074855936;
				short num2 = num;
				num = (short)1757165208;
				short num3 = num;
				num = (short)289486488;
				switch (num3 == num)
				{
				}
				num = (short)1535639552;
				if (num != 0)
				{
				}
				num = (short)1927086081;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.PaneItem.ImageProperty, value);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0006A81C File Offset: 0x00068A1C
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x0006A8D8 File Offset: 0x00068AD8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.DefaultValue(null)]
		public string ImageSource
		{
			get
			{
				short num = (short)52035584;
				short num2 = num;
				num = (short)1200511027;
				short num3 = num;
				num = (short)1597003827;
				switch (num3 == num)
				{
				}
				num = (short)1367998465;
				if (num != 0)
				{
				}
				num = (short)1465778176;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.PaneItem.ImageSourceProperty);
			}
			set
			{
				short num = (short)1669332992;
				short num2 = num;
				num = (short)998585300;
				short num3 = num;
				num = (short)417870804;
				switch (num3 == num)
				{
				}
				num = (short)466550785;
				if (num != 0)
				{
				}
				num = (short)1183383552;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.PaneItem.ImageSourceProperty, value);
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0006A98C File Offset: 0x00068B8C
		private static void ImageSourceChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)143589376;
			short num2 = num;
			num = (short)120476392;
			short num3 = num;
			num = (short)1431524072;
			switch (num3 == num)
			{
			}
			num = (short)1992294400;
			if (num != 0)
			{
			}
			num = (short)1809383425;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.PaneItem)d).ImageSourceChanged();
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0006AA44 File Offset: 0x00068C44
		private void ImageSourceChanged()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					num2 = (short)1838874625;
					if (num2 != 0)
					{
					}
					if (this.ImageSmall == null)
					{
						num2 = (short)841809924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					global::System.Windows.Controls.Image image = (global::System.Windows.Controls.Image)this.ImageSmall;
					image.Stretch = global::System.Windows.Media.Stretch.Fill;
					image.Width = 16.0;
					image.Height = 16.0;
					goto IL_D1;
				}
				case 3:
					this.ImageSmall = this.LoadImage(this.ImageSource);
					num2 = (short)1584594950;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)746127365;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)424542208;
					short num3 = num2;
					if (this.Image == null)
					{
						return;
					}
					num2 = (short)1200818606;
					short num4 = num2;
					num2 = (short)1881737646;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D1;
					default:
						num2 = (short)1742667776;
						if (num2 != 0)
						{
						}
						num2 = (short)544866307;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					if (this.ImageSmall is global::System.Windows.Controls.Image)
					{
						num2 = (short)167575554;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_2C;
				IL_D1:
				num2 = (short)1592655872;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			this.Image = this.LoadImage(this.ImageSource);
			num2 = (short)1822883841;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0006AC48 File Offset: 0x00068E48
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x0006ACFC File Offset: 0x00068EFC
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.Bindable(true)]
		public object ImageSmall
		{
			get
			{
				short num = (short)354942976;
				short num2 = num;
				num = (short)308846903;
				short num3 = num;
				num = (short)1524736311;
				switch (num3 == num)
				{
				}
				num = (short)870842369;
				if (num != 0)
				{
				}
				num = (short)2134769664;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.PaneItem.ImageSmallProperty);
			}
			set
			{
				short num = (short)12124160;
				short num2 = num;
				num = (short)1779694504;
				short num3 = num;
				num = (short)1243020200;
				switch (num3 == num)
				{
				}
				num = (short)387514368;
				if (num != 0)
				{
				}
				num = (short)1113260033;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.PaneItem.ImageSmallProperty, value);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0006ADB4 File Offset: 0x00068FB4
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0006AE6C File Offset: 0x0006906C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.DefaultValue(null)]
		public string ImageSmallSource
		{
			get
			{
				short num = (short)1242497024;
				short num2 = num;
				num = (short)691599637;
				short num3 = num;
				num = (short)1071053077;
				switch (num3 == num)
				{
				}
				num = (short)1683161088;
				if (num != 0)
				{
				}
				num = (short)1793327105;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.PaneItem.ImageSmallSourceProperty);
			}
			set
			{
				short num = (short)1186988032;
				short num2 = num;
				num = (short)1417358299;
				short num3 = num;
				num = (short)1103244251;
				switch (num3 == num)
				{
				}
				num = (short)2074214401;
				if (num != 0)
				{
				}
				num = (short)683540480;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.PaneItem.ImageSmallSourceProperty, value);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0006AF24 File Offset: 0x00069124
		private static void ImageSmallSourceChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1526464512;
			short num2 = num;
			num = (short)242722825;
			short num3 = num;
			num = (short)1809885193;
			switch (num3 == num)
			{
			}
			num = (short)1861943296;
			if (num != 0)
			{
			}
			num = (short)1038876673;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.PaneItem)d).ImageSmallSourceChanged();
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0006AFDC File Offset: 0x000691DC
		private void ImageSmallSourceChanged()
		{
			short num = (short)199557120;
			short num2 = num;
			num = (short)1498755575;
			short num3 = num;
			num = (short)148582903;
			switch (num3 == num)
			{
			}
			num = (short)1543503873;
			if (num != 0)
			{
			}
			num = (short)1619197952;
			if (num != 0)
			{
			}
			this.ImageSmall = this.LoadImage(this.ImageSmallSource);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0006B098 File Offset: 0x00069298
		private global::System.Windows.Controls.Image LoadImage(string imageSource)
		{
			short num = (short)1529872384;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					goto IL_D5;
				case 2:
					num = (short)49414147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					if (imageSource.Length == 0)
					{
						num = (short)1590689793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)387317761;
					if (num != 0)
					{
					}
					global::System.Windows.Controls.Image image = null;
					num = (short)621281284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_96;
				}
				goto IL_39;
				IL_3F:
				num = (short)1128267778;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D5:
				num = (short)2090444367;
				short num3 = num;
				num = (short)1126082127;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3F;
				default:
					goto IL_10A;
				}
				IL_39:
				if (imageSource != null)
				{
					goto IL_3F;
				}
				goto IL_D5;
			}
			IL_96:
			global::System.Windows.Controls.Image result;
			try
			{
				global::System.Windows.Media.Imaging.BitmapImage source = new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(imageSource, global::System.UriKind.RelativeOrAbsolute));
				global::System.Windows.Controls.Image image = new global::System.Windows.Controls.Image();
				image.Source = source;
				image.Stretch = global::System.Windows.Media.Stretch.None;
				return image;
			}
			catch
			{
				result = null;
			}
			return result;
			IL_10A:
			num = (short)1954938880;
			short num4 = num;
			num = (short)640221184;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0006B22C File Offset: 0x0006942C
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x0006B2E4 File Offset: 0x000694E4
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.Bindable(true)]
		public string Title
		{
			get
			{
				short num = (short)2097217536;
				short num2 = num;
				num = (short)134449631;
				short num3 = num;
				num = (short)1072597471;
				switch (num3 == num)
				{
				}
				num = (short)2106327041;
				if (num != 0)
				{
				}
				num = (short)1806893056;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.PaneItem.TitleProperty);
			}
			set
			{
				short num = (short)1879375872;
				short num2 = num;
				num = (short)1735524353;
				if (num != 0)
				{
				}
				num = (short)979623580;
				short num3 = num;
				num = (short)956161692;
				switch (num3 == num)
				{
				}
				num = (short)222625792;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.PaneItem.TitleProperty, value);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0006B39C File Offset: 0x0006959C
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			short num = (short)651952128;
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
					((global::DevComponents.WpfRibbon.NavigationPane)base.Parent).UpdateSelectedContent();
					num = (short)1800601604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)972848094;
					short num3 = num;
					num = (short)1007909854;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1519058944;
						if (num != 0)
						{
						}
						num = (short)621412353;
						if (num != 0)
						{
						}
						num = (short)780206083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (base.Parent is global::DevComponents.WpfRibbon.NavigationPane)
					{
						num = (short)1491468289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
				case 4:
					goto IL_A9;
				}
				IL_38:
				num = (short)1869021184;
				short num4 = num;
				if (!base.IsInitialized)
				{
					break;
				}
				num = (short)873857026;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A9:
			IL_161:
			base.OnContentChanged(oldContent, newContent);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0006B514 File Offset: 0x00069714
		protected override void OnHeaderChanged(object oldHeader, object newHeader)
		{
			short num = (short)790495232;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					((global::DevComponents.WpfRibbon.NavigationPane)base.Parent).UpdateSelectedHeader();
					num = (short)676724740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)2104098817;
					if (num != 0)
					{
					}
					num = (short)1790943549;
					short num3 = num;
					num = (short)376348989;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)181207040;
						if (num != 0)
						{
						}
						num = (short)2104623107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (base.Parent is global::DevComponents.WpfRibbon.NavigationPane)
					{
						num = (short)1352531969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_163;
				case 4:
					goto IL_D1;
				}
				IL_39:
				num = (short)62259200;
				short num4 = num;
				if (!base.IsInitialized)
				{
					break;
				}
				num = (short)633995266;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D1:
			IL_163:
			base.OnHeaderChanged(oldHeader, newHeader);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0006B68C File Offset: 0x0006988C
		public bool FocusContent()
		{
			short num = (short)499449856;
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
					base.UpdateLayout();
					((global::System.Windows.UIElement)base.Content).MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
					num = (short)1034616836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1116907165;
					short num3 = num;
					num = (short)883009181;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1547894785;
						if (num != 0)
						{
						}
						num = (short)2123890688;
						if (num != 0)
						{
						}
						num = (short)564592643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (base.Content is global::System.Windows.UIElement)
					{
						num = (short)553910273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					return true;
				}
				IL_38:
				num = (short)1459486720;
				short num4 = num;
				if (base.IsKeyboardFocusWithin)
				{
					break;
				}
				num = (short)1997733890;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0006B80C File Offset: 0x00069A0C
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (!e.Handled)
					{
						num2 = (short)311296004;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					this.IsSelected = true;
					num2 = (short)1112143563;
					short num3 = num2;
					num2 = (short)1059780299;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_186;
					case 1:
						break;
					default:
					{
						num2 = (short)831848448;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)527237120;
					if (num2 != 0)
					{
					}
					num2 = (short)1815674880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)1822162950;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)17825797;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (e.NewFocus == this)
					{
						goto IL_186;
					}
					return;
				case 6:
					if (!this.IsSelected)
					{
						num2 = (short)1020067842;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_2C;
				IL_186:
				num2 = (short)201261059;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			num2 = (short)785776641;
			if (num2 != 0)
			{
			}
			base.OnGotKeyboardFocus(e);
			num2 = (short)2144206849;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0006B9BC File Offset: 0x00069BBC
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x0006BA78 File Offset: 0x00069C78
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.Bindable(true)]
		public bool SmallState
		{
			get
			{
				short num = (short)967835648;
				short num2 = num;
				num = (short)2145943944;
				short num3 = num;
				num = (short)1058439560;
				switch (num3 == num)
				{
				}
				num = (short)1364852736;
				if (num != 0)
				{
				}
				num = (short)644546561;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.PaneItem.SmallStateProperty);
			}
			set
			{
				short num = (short)964952064;
				short num2 = num;
				num = (short)1461308261;
				short num3 = num;
				num = (short)213764965;
				switch (num3 == num)
				{
				}
				num = (short)347013120;
				if (num != 0)
				{
				}
				num = (short)1348993025;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.PaneItem.SmallStateProperty, value);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0006BB30 File Offset: 0x00069D30
		private static void SmallStateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1839661056;
			short num2 = num;
			num = (short)840738364;
			short num3 = num;
			num = (short)255764028;
			switch (num3 == num)
			{
			}
			num = (short)460980225;
			if (num != 0)
			{
			}
			num = (short)600113152;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.PaneItem)d).SmallStateChanged();
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0006BBE8 File Offset: 0x00069DE8
		private void SmallStateChanged()
		{
			short num = (short)2105497400;
			short num2 = num;
			num = (short)677140280;
			switch (num2 == num)
			{
			}
			num = (short)2123563008;
			if (num != 0)
			{
			}
			num = (short)466354176;
			short num3 = num;
			num = (short)859439105;
			if (num != 0)
			{
			}
			this.UpdateToolTip();
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0006BC94 File Offset: 0x00069E94
		private void UpdateToolTip()
		{
			short num = (short)1938030597;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (base.Header is string)
					{
						num = (short)348782601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75;
				case 1:
					goto IL_1A4;
				case 2:
				{
					base.ToolTip = null;
					num = (short)571539456;
					short num3 = num;
					num = (short)609615878;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (!this.PaneExpanded)
					{
						num = (short)1945960449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75;
				case 4:
					if (this._ToolTipSet)
					{
						num = (short)1753743362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 6:
					return;
				case 7:
					num = (short)93388803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)2105142221;
					short num4 = num;
					num = (short)948497357;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)619708416;
						if (num != 0)
						{
						}
						if (base.ToolTip == null)
						{
							num = (short)908853258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_75;
					}
					break;
				}
				case 9:
					goto IL_ED;
				case 10:
					num = (short)997720064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_51:
				if (!this.SmallState)
				{
					num = (short)846659591;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1A4;
				IL_75:
				num = (short)796590084;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A4:
				num = (short)1207697416;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_ED:
			num = (short)1476526081;
			if (num != 0)
			{
			}
			base.ToolTip = base.Header.ToString();
			this._ToolTipSet = true;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0006BEE8 File Offset: 0x0006A0E8
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x0006BFA4 File Offset: 0x0006A1A4
		public bool PaneExpanded
		{
			get
			{
				short num = (short)670997349;
				short num2 = num;
				num = (short)828676965;
				switch (num2 == num)
				{
				}
				num = (short)497483776;
				if (num != 0)
				{
				}
				num = (short)1815871488;
				short num3 = num;
				num = (short)684720129;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.PaneItem.PaneExpandedProperty);
			}
			set
			{
				short num = (short)1781285546;
				short num2 = num;
				num = (short)1727480490;
				switch (num2 == num)
				{
				}
				num = (short)972226560;
				if (num != 0)
				{
				}
				num = (short)1750335488;
				short num3 = num;
				num = (short)1527840769;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.PaneItem.PaneExpandedProperty, value);
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0006C060 File Offset: 0x0006A260
		private static void PaneExpandedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1451292694;
			short num2 = num;
			num = (short)115800086;
			switch (num2 == num)
			{
			}
			num = (short)2039152641;
			if (num != 0)
			{
			}
			num = (short)347209728;
			short num3 = num;
			num = (short)390529024;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.PaneItem)d).PaneExpandedChanged();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0006C114 File Offset: 0x0006A314
		private void PaneExpandedChanged()
		{
			short num = (short)706117742;
			short num2 = num;
			num = (short)357531758;
			switch (num2 == num)
			{
			}
			num = (short)172097537;
			if (num != 0)
			{
			}
			num = (short)656474112;
			short num3 = num;
			num = (short)168493056;
			if (num != 0)
			{
			}
			this.UpdateToolTip();
		}

		// Token: 0x04000284 RID: 644
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty;

		// Token: 0x04000285 RID: 645
		public static readonly global::System.Windows.DependencyProperty ImageProperty;

		// Token: 0x04000286 RID: 646
		public static readonly global::System.Windows.DependencyProperty ImageSourceProperty;

		// Token: 0x04000287 RID: 647
		public static readonly global::System.Windows.DependencyProperty ImageSmallProperty;

		// Token: 0x04000288 RID: 648
		public static readonly global::System.Windows.DependencyProperty ImageSmallSourceProperty;

		// Token: 0x04000289 RID: 649
		public static readonly global::System.Windows.DependencyProperty TitleProperty;

		// Token: 0x0400028A RID: 650
		public static readonly global::System.Windows.DependencyProperty SmallStateProperty;

		// Token: 0x0400028B RID: 651
		public static readonly global::System.Windows.DependencyProperty PaneExpandedProperty;

		// Token: 0x0400028C RID: 652
		private bool _MouseLeftButtonDown;

		// Token: 0x0400028D RID: 653
		private bool _ToolTipSet;
	}
}
