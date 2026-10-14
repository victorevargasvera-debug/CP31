using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200002B RID: 43
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CrumbBarItem : global::System.Windows.Controls.HeaderedItemsControl
	{
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00045F1C File Offset: 0x0004411C
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00045FD0 File Offset: 0x000441D0
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Bindable(true)]
		public object Image
		{
			get
			{
				short num = (short)1595741217;
				short num2 = num;
				num = (short)193074209;
				switch (num2 == num)
				{
				default:
				{
					num = (short)854523904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1601110017;
				if (num != 0)
				{
				}
				num = (short)1776025600;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItem.ImageProperty);
			}
			set
			{
				short num = (short)1129887693;
				short num2 = num;
				num = (short)1048819661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1667170304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)245170177;
				if (num != 0)
				{
				}
				num = (short)604635136;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItem.ImageProperty, value);
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00046084 File Offset: 0x00044284
		private static void OnImageSourceChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)72205326;
					short num3 = num2;
					num2 = (short)1744552974;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1165688832;
						if (num2 != 0)
						{
						}
						crumbBarItem.OnImageSourceChanged((string)e.OldValue, (string)e.NewValue);
						num2 = (short)324927489;
						if (num2 != 0)
						{
						}
						num2 = (short)275120130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)1574240256;
					short num4 = num2;
					if (crumbBarItem != null)
					{
						num2 = (short)1842872320;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			crumbBarItem = (o as global::DevComponents.WpfRibbon.CrumbBarItem);
			num2 = (short)2037972993;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000461B8 File Offset: 0x000443B8
		protected virtual void OnImageSourceChanged(string oldValue, string newValue)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			string imageSource;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::System.Windows.Controls.Image image;
					try
					{
						global::System.Windows.Media.Imaging.BitmapImage source = new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(imageSource, global::System.UriKind.RelativeOrAbsolute));
						image = new global::System.Windows.Controls.Image();
						image.Source = source;
						image.Stretch = global::System.Windows.Media.Stretch.None;
						image.SnapsToDevicePixels = true;
						goto IL_10A;
					}
					catch
					{
						this.Image = null;
					}
					return;
					IL_10A:
					this.Image = image;
					num2 = (short)36507558;
					short num3 = num2;
					num2 = (short)266538918;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						num2 = (short)1556873216;
						if (num2 != 0)
						{
						}
						num2 = (short)122355717;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_108;
				case 2:
					num2 = (short)2013593603;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_96;
				case 4:
					if (imageSource != null)
					{
						num2 = (short)1276706818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_177;
				case 5:
					goto IL_175;
				}
				goto IL_28;
				IL_96:
				num2 = (short)1953628161;
				if (num2 != 0)
				{
				}
				num2 = (short)1701576704;
				short num4 = num2;
				if (imageSource.Length == 0)
				{
					num2 = (short)189333505;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					global::System.Windows.Controls.Image image = null;
					num2 = (short)632815616;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_108:
			goto IL_177;
			IL_175:
			return;
			IL_177:
			this.Image = null;
			return;
			IL_28:
			imageSource = this.ImageSource;
			num2 = (short)55115780;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0004638C File Offset: 0x0004458C
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00046444 File Offset: 0x00044644
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.DefaultValue(null)]
		public string ImageSource
		{
			get
			{
				short num = (short)754536199;
				short num2 = num;
				num = (short)648564487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1583087616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)277544961;
				if (num != 0)
				{
				}
				num = (short)1093795840;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItem.ImageSourceProperty);
			}
			set
			{
				short num = (short)1515347359;
				short num2 = num;
				num = (short)148790687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2140274688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)757923841;
				if (num != 0)
				{
				}
				num = (short)583991296;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItem.ImageSourceProperty, value);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000464F8 File Offset: 0x000446F8
		private static object OnCoerceIsPopupOpen(global::System.Windows.DependencyObject o, object value)
		{
			global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem = o as global::DevComponents.WpfRibbon.CrumbBarItem;
			if (crumbBarItem != null)
			{
				short num;
				for (;;)
				{
					num = (short)2048153959;
					short num2 = num;
					num = (short)1976129895;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_43;
					}
				}
				IL_43:
				num = (short)775618560;
				short num3 = num;
				num = (short)936902657;
				if (num != 0)
				{
				}
				num = (short)1907294208;
				if (num != 0)
				{
				}
				return crumbBarItem.OnCoerceIsPopupOpen((bool)value);
			}
			return value;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000465C0 File Offset: 0x000447C0
		private static void OnIsPopupOpenChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1114233075;
					short num3 = num2;
					num2 = (short)560322803;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1863581697;
						if (num2 != 0)
						{
						}
						num2 = (short)482279424;
						if (num2 != 0)
						{
						}
						crumbBarItem.OnIsPopupOpenChanged((bool)e.OldValue, (bool)e.NewValue);
						num2 = (short)673447938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)940834816;
					short num4 = num2;
					if (crumbBarItem != null)
					{
						num2 = (short)679804928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			crumbBarItem = (o as global::DevComponents.WpfRibbon.CrumbBarItem);
			num2 = (short)584122369;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000466F8 File Offset: 0x000448F8
		protected virtual bool OnCoerceIsPopupOpen(bool value)
		{
			short num = (short)952493017;
			short num2 = num;
			num = (short)854778841;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1992687616;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1228275712;
			if (num != 0)
			{
			}
			num = (short)6946817;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000467A4 File Offset: 0x000449A4
		protected virtual void OnIsPopupOpenChanged(bool oldValue, bool newValue)
		{
			short num = (short)1765993044;
			short num2 = num;
			num = (short)1906764372;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1503330304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1112211457;
			if (num != 0)
			{
			}
			num = (short)2013265920;
			if (num != 0)
			{
			}
			this.UpdatePressed();
			this.UpdateIsMouseOverState();
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0004685C File Offset: 0x00044A5C
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00046918 File Offset: 0x00044B18
		public bool IsPopupOpen
		{
			get
			{
				short num = (short)1160472764;
				short num2 = num;
				num = (short)877160636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1715798016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2129068033;
				if (num != 0)
				{
				}
				num = (short)103415808;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItem.IsPopupOpenProperty);
			}
			set
			{
				short num = (short)1493247419;
				short num2 = num;
				num = (short)2112955835;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1198587904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1235615744;
				if (num != 0)
				{
				}
				num = (short)1394868225;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItem.IsPopupOpenProperty, value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600031A RID: 794 RVA: 0x000469D0 File Offset: 0x00044BD0
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00046A8C File Offset: 0x00044C8C
		public bool IsPressed
		{
			get
			{
				short num = (short)13023579;
				short num2 = num;
				num = (short)2087827803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)694616064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1463812097;
				if (num != 0)
				{
				}
				num = (short)484704256;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItem.IsPressedProperty);
			}
			set
			{
				short num = (short)1284241601;
				short num2 = num;
				num = (short)1019738305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)563937280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1371471873;
				if (num != 0)
				{
				}
				num = (short)2145583104;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItem.IsPressedProperty, value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00046B48 File Offset: 0x00044D48
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00046C00 File Offset: 0x00044E00
		public bool IsMouseOverState
		{
			get
			{
				short num = (short)108028083;
				short num2 = num;
				num = (short)299131059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1225392128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1675296769;
				if (num != 0)
				{
				}
				num = (short)875560960;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItem.IsMouseOverStateProperty);
			}
			set
			{
				short num = (short)1283419169;
				short num2 = num;
				num = (short)482372641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)778633216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1909915648;
				if (num != 0)
				{
				}
				num = (short)421658625;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItem.IsMouseOverStateProperty, value);
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00046CBC File Offset: 0x00044EBC
		static CrumbBarItem()
		{
			int a_ = 9;
			short num = (short)307047107;
			short num2 = num;
			num = (short)201730755;
			switch (num2 == num)
			{
			default:
			{
				num = (short)340787200;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1837629441;
			if (num != 0)
			{
			}
			num = (short)2025259008;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.CrumbBarItem.ImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⡠๢Ѥf౨", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.CrumbBarItem), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfRibbon.CrumbBarItem.ImageSourceProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⡠๢Ѥf౨㡪ɬᩮͰၲၴ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.CrumbBarItem), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.CrumbBarItem.OnImageSourceChanged)));
			global::DevComponents.WpfRibbon.CrumbBarItem.IsPopupOpenProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⡠ၢ㕤ࡦᥨṪᵬ⁮Űᙲ᭴", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBarItem), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.CrumbBarItem.OnIsPopupOpenChanged), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.CrumbBarItem.OnCoerceIsPopupOpen)));
			global::DevComponents.WpfRibbon.CrumbBarItem.IsPressedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⡠ၢ㕤ᕦ౨ᡪṬ੮ᕰ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBarItem), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfRibbon.CrumbBarItem.IsMouseOverStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⡠ၢ⡤ࡦᱨᡪ࡬⁮ݰᙲݴ⑶൸᩺ॼ᩾", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBarItem), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.CrumbBarItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.CrumbBarItem)));
			global::DevComponents.WpfRibbon.CrumbBarItem.IsSelectedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⡠ၢ㙤ɦը๪๬᭮ᑰᝲ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBarItem), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.CrumbBarItem.IsSelectedProperty = global::DevComponents.WpfRibbon.CrumbBarItem.IsSelectedPropertyKey.DependencyProperty;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00046F0C File Offset: 0x0004510C
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			short num = (short)186961372;
			short num2 = num;
			num = (short)922799580;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1965817856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)683147265;
			if (num != 0)
			{
			}
			num = (short)189988864;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfRibbon.CrumbBarItem();
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00046FBC File Offset: 0x000451BC
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			short num = (short)1203234996;
			short num2 = num;
			num = (short)1771825332;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1285554176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1804206081;
			if (num != 0)
			{
			}
			num = (short)383385600;
			if (num != 0)
			{
			}
			return item is global::DevComponents.WpfRibbon.CrumbBarItem;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00047070 File Offset: 0x00045270
		internal global::System.Windows.Controls.ItemsControl ParentItemsControl
		{
			get
			{
				short num = (short)796660205;
				short num2 = num;
				num = (short)962728429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1202520064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)434110465;
				if (num != 0)
				{
				}
				num = (short)1351942144;
				if (num != 0)
				{
				}
				return global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00047120 File Offset: 0x00045320
		internal global::DevComponents.WpfRibbon.CrumbBar ParentCrumbBar
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				short num2;
				global::System.Windows.Controls.ItemsControl itemsControl;
				global::DevComponents.WpfRibbon.CrumbBar crumbBar;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_B1;
					case 1:
					{
						num2 = (short)1715362914;
						short num3 = num2;
						num2 = (short)1394498658;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B1;
						default:
							num2 = (short)1351352320;
							if (num2 != 0)
							{
							}
							if (itemsControl == null)
							{
								num2 = (short)1023475717;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							crumbBar = (itemsControl as global::DevComponents.WpfRibbon.CrumbBar);
							num2 = (short)1257963520;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_F9;
					case 3:
						return crumbBar;
					case 4:
						goto IL_F9;
					case 5:
						goto IL_17A;
					}
					goto IL_28;
					IL_B1:
					num2 = (short)449380352;
					short num4 = num2;
					if (crumbBar != null)
					{
						num2 = (short)1879834627;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1297874945;
					if (num2 != 0)
					{
					}
					itemsControl = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(itemsControl);
					num2 = (short)896860162;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_F9:
					num2 = (short)160301057;
					num = (int)((global::System.IntPtr)num2);
				}
				return crumbBar;
				IL_17A:
				return null;
				IL_28:
				itemsControl = this.ParentItemsControl;
				num2 = (short)827850756;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000472AC File Offset: 0x000454AC
		private void UpdatePressed()
		{
			short num = (short)866994634;
			short num2 = num;
			num = (short)899697098;
			switch (num2 == num)
			{
			default:
			{
				num = (short)534380544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1853227009;
			if (num != 0)
			{
			}
			num = (short)1468268544;
			if (num != 0)
			{
			}
			this.IsPressed = (this.IsPopupOpen || this._IsLeftMouseButtonDown);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00047370 File Offset: 0x00045570
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00047420 File Offset: 0x00045620
		private bool IsLeftMouseButtonDown
		{
			get
			{
				short num = (short)1138346118;
				short num2 = num;
				num = (short)1092470918;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1148518400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)907739136;
				if (num != 0)
				{
				}
				num = (short)1402929153;
				if (num != 0)
				{
				}
				return this._IsLeftMouseButtonDown;
			}
			set
			{
				short num = (short)1278148609;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E7;
					case 1:
					{
						num = (short)1433772647;
						short num3 = num;
						num = (short)2009768551;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E7;
						default:
							num = (short)2025717760;
							if (num != 0)
							{
							}
							num = (short)1366228993;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					IL_A1:
					if (this._IsLeftMouseButtonDown != value)
					{
						num = (short)1772224512;
						short num4 = num;
						num = (short)1649737728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_E7:
					this._IsLeftMouseButtonDown = value;
					this.UpdatePressed();
					num = (short)532938754;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0004753C File Offset: 0x0004573C
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Windows.Rect rect;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1892323902;
					short num3 = num2;
					num2 = (short)805868094;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1759051776;
						if (num2 != 0)
						{
						}
						num2 = (short)99483649;
						if (num2 != 0)
						{
						}
						this.IsLeftMouseButtonDown = true;
						num2 = (short)2000879618;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)614072320;
					short num4 = num2;
					if (rect.Contains(e.GetPosition(this)))
					{
						num2 = (short)438763520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_122;
				}
				case 2:
					goto IL_120;
				}
				goto IL_1C;
			}
			IL_120:
			IL_122:
			base.OnMouseLeftButtonDown(e);
			return;
			IL_1C:
			rect = new global::System.Windows.Rect(base.RenderSize);
			num2 = (short)46661633;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00047674 File Offset: 0x00045874
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Windows.Rect rect;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)779773544;
					short num3 = num2;
					num2 = (short)2139907688;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1074593792;
						if (num2 != 0)
						{
						}
						this.Select();
						e.Handled = true;
						num2 = (short)77987842;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (rect.Contains(e.GetPosition(this)))
					{
						num2 = (short)1807613952;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_137;
				case 2:
					goto IL_135;
				}
				goto IL_1C;
			}
			IL_135:
			IL_137:
			base.OnMouseLeftButtonUp(e);
			return;
			IL_1C:
			num2 = (short)1977548801;
			if (num2 != 0)
			{
			}
			this.IsLeftMouseButtonDown = false;
			rect = new global::System.Windows.Rect(base.RenderSize);
			num2 = (short)848297984;
			short num4 = num2;
			num2 = (short)2118975489;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000477C0 File Offset: 0x000459C0
		public void Select()
		{
			short num = (short)1990459392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_78;
				}
				global::DevComponents.WpfRibbon.CrumbBar tree;
				for (;;)
				{
					IL_29:
					bool flag;
					switch (num2)
					{
					case 0:
					{
						object obj;
						if (obj != null)
						{
							goto IL_318;
						}
						goto IL_253;
					}
					case 1:
						goto IL_186;
					case 2:
						if (tree != null)
						{
							num = (short)1555562512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						global::System.Windows.Controls.ItemsControl itemsControl;
						if (itemsControl != null)
						{
							num = (short)843907084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F8;
					}
					case 4:
						if (tree.SelectedItem != this)
						{
							num = (short)514129927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_186;
					case 5:
						num = (short)1350828043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						object obj;
						if (obj != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1793261573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_253;
					}
					case 7:
						tree.SelectedItem = this;
						flag = true;
						num = (short)1192951818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (flag)
						{
							num = (short)301989902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						return;
					case 10:
					{
						num = (short)30605312;
						short num3 = num;
						goto IL_186;
					}
					case 11:
					{
						object obj;
						if (tree.SelectedItem != obj)
						{
							num = (short)567607313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_186;
					}
					case 12:
					{
						global::System.Windows.Controls.ItemsControl itemsControl;
						object obj = itemsControl.ItemContainerGenerator.ItemFromContainer(this);
						num = (short)450887681;
						if (num != 0)
						{
						}
						num = (short)1552613389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_2F8;
					case 14:
						tree.SetOpenedViewItem(null);
						num = (short)1354366985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1889861638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						object obj = null;
						global::System.Windows.Controls.ItemsControl itemsControl = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this);
						num = (short)628948995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						object obj;
						tree.SelectedItem = obj;
						tree.SetSelectedItem(obj, this);
						flag = true;
						num = (short)536018945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_78;
					IL_186:
					num = (short)358620753;
					short num4 = num;
					num = (short)989929041;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_318:
						num = (short)830078991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)668205056;
						if (num != 0)
						{
						}
						num = (short)404422664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_253:
					num = (short)1772158980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F8:
					flag = false;
					num = (short)1056178176;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_78:
				tree = this.GetTree();
				num = (short)1076297730;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00047B44 File Offset: 0x00045D44
		private global::DevComponents.WpfRibbon.CrumbBar GetTree()
		{
			short num = (short)1683357698;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Controls.ItemsControl itemsControl;
			global::System.Windows.FrameworkElement frameworkElement;
			for (;;)
			{
				global::DevComponents.WpfRibbon.CrumbBar crumbBar;
				switch (num2)
				{
				case 0:
					num = (short)1651245059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_203;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 3:
					if (itemsControl.TemplatedParent is global::DevComponents.WpfRibbon.CrumbBarItemView)
					{
						num = (short)1446117388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D9;
				case 4:
					if (itemsControl != null)
					{
						num = (short)973144064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_293;
				case 5:
				{
					if (frameworkElement == null)
					{
						num = (short)1538260999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)77111899;
					short num3 = num;
					num = (short)597205595;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2D9;
					default:
						num = (short)161284096;
						if (num != 0)
						{
						}
						num = (short)776667144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_132;
				case 7:
					goto IL_238;
				case 8:
				{
					num = (short)553451521;
					if (num != 0)
					{
					}
					if (frameworkElement is global::DevComponents.WpfRibbon.CrumbBar)
					{
						num = (short)2058682374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					frameworkElement = (frameworkElement.Parent as global::System.Windows.FrameworkElement);
					num = (short)155451392;
					short num4 = num;
					num = (short)1207631883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (itemsControl is global::DevComponents.WpfRibbon.CrumbBarItemsControl)
					{
						num = (short)277217295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_293;
				case 10:
					if (crumbBar != null)
					{
						num = (short)1693450253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					frameworkElement = (base.Parent as global::System.Windows.FrameworkElement);
					num = (short)105250817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_203;
				case 12:
					goto IL_1D7;
				case 13:
					return crumbBar;
				case 14:
					itemsControl = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this);
					num = (short)1035993092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_310;
				}
				IL_65:
				if (base.Parent == null)
				{
					num = (short)1454112782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_293;
				IL_203:
				num = (short)452919301;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_293:
				crumbBar = (base.Parent as global::DevComponents.WpfRibbon.CrumbBar);
				num = (short)1905065994;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D9:
				num = (short)490405897;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_132:
			return (global::DevComponents.WpfRibbon.CrumbBar)frameworkElement;
			IL_1D7:
			return ((global::DevComponents.WpfRibbon.CrumbBarItemView)itemsControl.TemplatedParent).ParentTree;
			IL_238:
			return null;
			IL_310:
			return ((global::DevComponents.WpfRibbon.CrumbBarItemsControl)itemsControl).ParentViewItem.ParentTree;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00047E68 File Offset: 0x00046068
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Windows.Rect rect;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)723739944;
					short num3 = num2;
					num2 = (short)1449682216;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)753926144;
						if (num2 != 0)
						{
						}
						this.MouseOverInternal = true;
						num2 = (short)1790377986;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (rect.Contains(e.GetPosition(this)))
					{
						num2 = (short)1363935232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_128;
				case 2:
					goto IL_126;
				}
				goto IL_1C;
			}
			IL_126:
			IL_128:
			base.OnMouseEnter(e);
			return;
			IL_1C:
			num2 = (short)1845690369;
			if (num2 != 0)
			{
			}
			rect = new global::System.Windows.Rect(base.RenderSize);
			num2 = (short)815661056;
			short num4 = num2;
			num2 = (short)1387659265;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00047FA4 File Offset: 0x000461A4
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1548025856;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num3;
			global::System.Windows.Rect rect;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					goto IL_126;
				case 1:
					this.MouseOverInternal = true;
					num = (short)339804163;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (rect.Contains(e.GetPosition(this)))
					{
						num = (short)1316552705;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.MouseOverInternal = false;
					num = (short)90556792;
					short num4 = num;
					num = (short)1151846776;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_126;
					default:
						num = (short)23527425;
						if (num != 0)
						{
						}
						num = (short)888078336;
						if (num != 0)
						{
						}
						num = (short)1727987712;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_147;
				}
				goto IL_49;
			}
			IL_126:
			IL_147:
			base.OnMouseMove(e);
			return;
			IL_49:
			rect = new global::System.Windows.Rect(base.RenderSize);
			num = (short)1984495618;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00048104 File Offset: 0x00046304
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000481B8 File Offset: 0x000463B8
		private bool MouseOverInternal
		{
			get
			{
				short num = (short)933167105;
				if (num != 0)
				{
				}
				num = (short)864926782;
				short num2 = num;
				num = (short)2041494590;
				switch (num2 == num)
				{
				default:
				{
					num = (short)378011648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1634795520;
				if (num != 0)
				{
				}
				return this._MouseOverInternal;
			}
			set
			{
				short num = (short)1377763328;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)264175617;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					case 1:
						goto IL_E8;
					case 2:
						this._MouseOverInternal = value;
						this.UpdateIsMouseOverState();
						num = (short)319815681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_56:
					if (this._MouseOverInternal == value)
					{
						break;
					}
					num = (short)1908470985;
					short num3 = num;
					num = (short)1574237385;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)356122624;
						if (num != 0)
						{
						}
						num = (short)595918850;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_E8:
				num = (short)1569521664;
				short num4 = num;
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000482D8 File Offset: 0x000464D8
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1619595978;
			short num2 = num;
			num = (short)1972441802;
			switch (num2 == num)
			{
			}
			num = (short)1837432832;
			short num3 = num;
			num = (short)1976107009;
			if (num != 0)
			{
			}
			num = (short)696647680;
			if (num != 0)
			{
			}
			this.MouseOverInternal = false;
			base.OnMouseLeave(e);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00048394 File Offset: 0x00046594
		private void UpdateIsMouseOverState()
		{
			short num = (short)2017157251;
			short num2 = num;
			num = (short)1786929283;
			switch (num2 == num)
			{
			}
			num = (short)745603072;
			short num3 = num;
			num = (short)160301057;
			if (num != 0)
			{
			}
			num = (short)157810688;
			if (num != 0)
			{
			}
			this.IsMouseOverState = (this._MouseOverInternal | this.IsPopupOpen);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00048450 File Offset: 0x00046650
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00048508 File Offset: 0x00046708
		[global::System.ComponentModel.Browsable(false)]
		public bool IsSelected
		{
			get
			{
				short num = (short)638864305;
				short num2 = num;
				num = (short)1108691889;
				switch (num2 == num)
				{
				}
				num = (short)2018902016;
				short num3 = num;
				num = (short)2071199745;
				if (num != 0)
				{
				}
				num = (short)670040064;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItem.IsSelectedProperty);
			}
			internal set
			{
				short num = (short)561840129;
				if (num != 0)
				{
				}
				num = (short)604621237;
				short num2 = num;
				num = (short)1301006773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1008074752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1030881280;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItem.IsSelectedPropertyKey, value);
			}
		}

		// Token: 0x04000122 RID: 290
		public static readonly global::System.Windows.DependencyProperty ImageProperty;

		// Token: 0x04000123 RID: 291
		public static readonly global::System.Windows.DependencyProperty ImageSourceProperty;

		// Token: 0x04000124 RID: 292
		public static readonly global::System.Windows.DependencyProperty IsPopupOpenProperty;

		// Token: 0x04000125 RID: 293
		public static readonly global::System.Windows.DependencyProperty IsPressedProperty;

		// Token: 0x04000126 RID: 294
		public static readonly global::System.Windows.DependencyProperty IsMouseOverStateProperty;

		// Token: 0x04000127 RID: 295
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty;

		// Token: 0x04000128 RID: 296
		private static readonly global::System.Windows.DependencyPropertyKey IsSelectedPropertyKey;

		// Token: 0x04000129 RID: 297
		private bool _IsLeftMouseButtonDown;

		// Token: 0x0400012A RID: 298
		private bool _MouseOverInternal;
	}
}
