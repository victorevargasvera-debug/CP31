using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200002D RID: 45
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CrumbBarItemView : global::System.Windows.Controls.Control
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000338 RID: 824 RVA: 0x000488B4 File Offset: 0x00046AB4
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00048968 File Offset: 0x00046B68
		public object Header
		{
			get
			{
				short num = (short)1255559208;
				short num2 = num;
				num = (short)1993297960;
				switch (num2 == num)
				{
				}
				num = (short)1099104256;
				short num3 = num;
				num = (short)1184694272;
				if (num != 0)
				{
				}
				num = (short)1180762113;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.HeaderProperty);
			}
			set
			{
				short num = (short)1208702639;
				short num2 = num;
				num = (short)105207471;
				switch (num2 == num)
				{
				}
				num = (short)1134952448;
				short num3 = num;
				num = (short)1979645952;
				if (num != 0)
				{
				}
				num = (short)1682309121;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.HeaderProperty, value);
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00048A1C File Offset: 0x00046C1C
		private static void OnCrumbBarItemChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (crumbBarItemView == null)
					{
						return;
					}
					num2 = (short)590161477;
					short num3 = num2;
					num2 = (short)2039031365;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)928186369;
						if (num2 != 0)
						{
						}
						num2 = (short)1760821248;
						if (num2 != 0)
						{
						}
						num2 = (short)1708916738;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					crumbBarItemView.OnCrumbBarItemChanged((global::DevComponents.WpfRibbon.CrumbBarItem)e.OldValue, (global::DevComponents.WpfRibbon.CrumbBarItem)e.NewValue);
					num2 = (short)853868545;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			crumbBarItemView = (o as global::DevComponents.WpfRibbon.CrumbBarItemView);
			num2 = (short)1686503424;
			short num4 = num2;
			num2 = (short)2119237632;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00048B50 File Offset: 0x00046D50
		protected virtual void OnCrumbBarItemChanged(global::DevComponents.WpfRibbon.CrumbBarItem oldValue, global::DevComponents.WpfRibbon.CrumbBarItem newValue)
		{
			int a_ = 7;
			short num = (short)367460353;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num2;
			for (;;)
			{
				IL_3A:
				switch (num2)
				{
				case 0:
				{
					if (newValue == null)
					{
						return;
					}
					num = (short)1277284241;
					short num3 = num;
					num = (short)2074660753;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2089222144;
						if (num != 0)
						{
						}
						num = (short)683474946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝞ѠɢŤɦ᭨", a_));
					binding.Source = newValue;
					binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
					base.SetBinding(global::DevComponents.WpfRibbon.CrumbBarItemView.HeaderProperty, binding);
					num = (short)231473153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_4C;
			}
			return;
			IL_4C:
			num = (short)770768896;
			short num4 = num;
			global::System.Windows.Data.BindingOperations.ClearBinding(this, global::DevComponents.WpfRibbon.CrumbBarItemView.HeaderProperty);
			num = (short)968097792;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_3A;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00048CA4 File Offset: 0x00046EA4
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00048D60 File Offset: 0x00046F60
		public global::DevComponents.WpfRibbon.CrumbBarItem CrumbBarItem
		{
			get
			{
				short num = (short)1529524390;
				short num2 = num;
				num = (short)196194470;
				switch (num2 == num)
				{
				}
				num = (short)1071251456;
				short num3 = num;
				num = (short)2049966081;
				if (num != 0)
				{
				}
				num = (short)1623982080;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.CrumbBarItem)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.CrumbBarItemProperty);
			}
			set
			{
				short num = (short)146069150;
				short num2 = num;
				num = (short)1269552798;
				switch (num2 == num)
				{
				}
				num = (short)1847132160;
				short num3 = num;
				num = (short)1765408769;
				if (num != 0)
				{
				}
				num = (short)375652352;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.CrumbBarItemProperty, value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00048E18 File Offset: 0x00047018
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00048ED4 File Offset: 0x000470D4
		public bool IsOverflowItem
		{
			get
			{
				short num = (short)1950154753;
				if (num != 0)
				{
				}
				num = (short)1167091974;
				short num2 = num;
				num = (short)901277958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)895483904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1009123328;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.IsOverflowItemProperty);
			}
			set
			{
				short num = (short)310573516;
				short num2 = num;
				num = (short)1653668300;
				switch (num2 == num)
				{
				}
				num = (short)279314432;
				short num3 = num;
				num = (short)48300033;
				if (num != 0)
				{
				}
				num = (short)696254464;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.IsOverflowItemProperty, value);
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00048F90 File Offset: 0x00047190
		private static object OnCoerceIsPopupOpen(global::System.Windows.DependencyObject o, object value)
		{
			global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView;
			short num;
			for (;;)
			{
				crumbBarItemView = (o as global::DevComponents.WpfRibbon.CrumbBarItemView);
				if (crumbBarItemView != null)
				{
					break;
				}
				num = (short)559419215;
				short num2 = num;
				num = (short)309006159;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A2;
				}
			}
			num = (short)171507713;
			if (num != 0)
			{
			}
			num = (short)2111176704;
			short num3 = num;
			return crumbBarItemView.OnCoerceIsPopupOpen((bool)value);
			IL_A2:
			num = (short)1302528000;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00049058 File Offset: 0x00047258
		private static void OnIsPopupOpenChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (crumbBarItemView == null)
					{
						return;
					}
					num2 = (short)1479815230;
					short num3 = num2;
					num2 = (short)771174462;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1224081408;
						if (num2 != 0)
						{
						}
						num2 = (short)664928258;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					crumbBarItemView.OnIsPopupOpenChanged((bool)e.OldValue, (bool)e.NewValue);
					num2 = (short)849543169;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)346357761;
			if (num2 != 0)
			{
			}
			num2 = (short)1843789824;
			short num4 = num2;
			crumbBarItemView = (o as global::DevComponents.WpfRibbon.CrumbBarItemView);
			num2 = (short)1948647424;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00049190 File Offset: 0x00047390
		protected virtual bool OnCoerceIsPopupOpen(bool value)
		{
			short num = (short)680525825;
			if (num != 0)
			{
			}
			num = (short)1725739788;
			short num2 = num;
			num = (short)1897247500;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1181941760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1712128000;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00049238 File Offset: 0x00047438
		protected virtual void OnIsPopupOpenChanged(bool oldValue, bool newValue)
		{
			short num = (short)236447815;
			short num2 = num;
			num = (short)1115088967;
			switch (num2 == num)
			{
			}
			num = (short)374603776;
			short num3 = num;
			num = (short)1429798912;
			if (num != 0)
			{
			}
			num = (short)1587347457;
			if (num != 0)
			{
			}
			this.UpdatePressed();
			this.UpdateIsMouseOverState();
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000492EC File Offset: 0x000474EC
		// (set) Token: 0x06000345 RID: 837 RVA: 0x000493A4 File Offset: 0x000475A4
		[global::System.ComponentModel.Browsable(false)]
		public bool IsPopupOpen
		{
			get
			{
				short num = (short)939065458;
				short num2 = num;
				num = (short)1542586482;
				switch (num2 == num)
				{
				}
				num = (short)1718943744;
				short num3 = num;
				num = (short)1508442113;
				if (num != 0)
				{
				}
				num = (short)1364590592;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.IsPopupOpenProperty);
			}
			set
			{
				short num = (short)1613478964;
				short num2 = num;
				num = (short)2064694324;
				switch (num2 == num)
				{
				}
				num = (short)246808576;
				short num3 = num;
				num = (short)2106064896;
				if (num != 0)
				{
				}
				num = (short)1410727937;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.IsPopupOpenProperty, value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0004945C File Offset: 0x0004765C
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00049518 File Offset: 0x00047718
		public bool IsPressed
		{
			get
			{
				short num = (short)1866402029;
				short num2 = num;
				num = (short)992676077;
				switch (num2 == num)
				{
				}
				num = (short)1663696896;
				short num3 = num;
				num = (short)516489217;
				if (num != 0)
				{
				}
				num = (short)361037824;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.IsPressedProperty);
			}
			set
			{
				short num = (short)392153686;
				short num2 = num;
				num = (short)1412614742;
				switch (num2 == num)
				{
				}
				num = (short)1221787648;
				short num3 = num;
				num = (short)1008861185;
				if (num != 0)
				{
				}
				num = (short)1889665024;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.IsPressedProperty, value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000495D4 File Offset: 0x000477D4
		// (set) Token: 0x06000349 RID: 841 RVA: 0x0004968C File Offset: 0x0004788C
		public bool IsMouseOverState
		{
			get
			{
				short num = (short)82505542;
				short num2 = num;
				num = (short)897183558;
				switch (num2 == num)
				{
				}
				num = (short)1628897280;
				short num3 = num;
				num = (short)1311834113;
				if (num != 0)
				{
				}
				num = (short)851902464;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.IsMouseOverStateProperty);
			}
			set
			{
				short num = (short)304161191;
				short num2 = num;
				num = (short)1439244711;
				switch (num2 == num)
				{
				}
				num = (short)1091960832;
				short num3 = num;
				num = (short)1348403201;
				if (num != 0)
				{
				}
				num = (short)289538048;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBarItemView.IsMouseOverStateProperty, value);
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00049744 File Offset: 0x00047944
		static CrumbBarItemView()
		{
			int a_ = 6;
			short num = (short)990412136;
			short num2 = num;
			num = (short)27360616;
			switch (num2 == num)
			{
			}
			num = (short)30408704;
			short num3 = num;
			num = (short)2044067840;
			if (num != 0)
			{
			}
			num = (short)274857985;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.CrumbBarItemView.HeaderProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᙝ՟͡cͥᩧ", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.CrumbBarItemView), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfRibbon.CrumbBarItemView.CrumbBarItemProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵝ቟ᝡॣѥ⩧୩ṫ❭ѯ᝱ᥳ", a_), typeof(global::DevComponents.WpfRibbon.CrumbBarItem), typeof(global::DevComponents.WpfRibbon.CrumbBarItemView), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.CrumbBarItemView.OnCrumbBarItemChanged)));
			global::DevComponents.WpfRibbon.CrumbBarItemView.IsOverflowItemProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝝፟ⵡባͥᩧ౩kŭݯ㭱s፵ᕷ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBarItemView), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfRibbon.CrumbBarItemView.IsPopupOpenProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝝፟㉡ୣᙥᵧᩩ⍫ṭᕯᱱ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBarItemView), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.CrumbBarItemView.OnIsPopupOpenChanged), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.CrumbBarItemView.OnCoerceIsPopupOpen)));
			global::DevComponents.WpfRibbon.CrumbBarItemView.IsPressedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝝፟㉡ᙣͥ᭧ᥩ५੭", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBarItemView), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfRibbon.CrumbBarItemView.IsMouseOverStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝝፟⽡ୣ፥᭧ཀྵ⍫ᡭᕯq❳ɵ᥷๹᥻", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBarItemView), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.CrumbBarItemView), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.CrumbBarItemView)));
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00049980 File Offset: 0x00047B80
		public override void OnApplyTemplate()
		{
			int a_ = 5;
			short num = (short)1895825411;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1E6;
				case 1:
					if (this._Popup != null)
					{
						num = (short)1430585355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 2:
				{
					num = (short)1402333342;
					short num3 = num;
					num = (short)1214507166;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E6;
					default:
					{
						num = (short)895614976;
						short num4 = num;
						num = (short)1753022464;
						if (num != 0)
						{
						}
						this._Popup.Opened -= this.PopupOpened;
						this._Popup.Closed -= this.PopupClosed;
						num = (short)1408499719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					num = (short)1820590081;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 4:
					if (this._Popup != null)
					{
						num = (short)357957634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F5;
				case 5:
					if (this._ScrollViewer != null)
					{
						num = (short)1161166854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_301;
				case 6:
					this._ScrollViewer.Content = this.GetItemsControl();
					num = (short)234553352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_F5;
				case 8:
					goto IL_1B7;
				case 9:
					this._ScrollViewer.Content = null;
					num = (short)485031946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_153;
				case 11:
					this._Popup.Opened += this.PopupOpened;
					this._Popup.Closed += this.PopupClosed;
					num = (short)722927616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_85:
				if (this._ScrollViewer != null)
				{
					num = (short)1327628297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_153;
				IL_F5:
				this._Popup = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൜Ṟ㍠㝢㩤㝦٨᭪ᡬὮ", a_)) as global::System.Windows.Controls.Primitives.Popup);
				num = (short)2130116609;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_153:
				num = (short)1351680004;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E6:
				this._ScrollViewer = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൜Ṟ㍠㝢㩤⹦ᵨ๪lᱮ≰ၲݴᡶᕸ᝺⭼ᙾ", a_)) as global::System.Windows.Controls.ScrollViewer);
				num = (short)584056837;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1B7:
			IL_301:
			base.OnApplyTemplate();
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00049C94 File Offset: 0x00047E94
		private void PopupClosed(object sender, global::System.EventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_42;
			}
			short num;
			int num2;
			global::DevComponents.WpfRibbon.CrumbBar tree;
			for (;;)
			{
				IL_0A:
				num = (short)874119169;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					if (tree == null)
					{
						return;
					}
					num = (short)22888269;
					short num3 = num;
					num = (short)28196685;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)52690944;
						if (num != 0)
						{
						}
						num = (short)36044802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					tree.ViewItemClosed(this);
					num = (short)1184235521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_42;
			}
			return;
			IL_42:
			num = (short)2026045440;
			short num4 = num;
			tree = this.GetTree();
			num = (short)452853760;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00049DB4 File Offset: 0x00047FB4
		private void PopupOpened(object sender, global::System.EventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_42;
			}
			short num;
			int num2;
			global::DevComponents.WpfRibbon.CrumbBar tree;
			for (;;)
			{
				IL_0A:
				num = (short)436600833;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					if (tree == null)
					{
						return;
					}
					num = (short)162248460;
					short num3 = num;
					num = (short)566540044;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1202454528;
						if (num != 0)
						{
						}
						num = (short)905052162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					tree.SetOpenedViewItem(this);
					num = (short)906231809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_42;
			}
			return;
			IL_42:
			num = (short)229900288;
			short num4 = num;
			tree = this.GetTree();
			num = (short)836239360;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00049ED4 File Offset: 0x000480D4
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)436696010;
			short num2 = num;
			num = (short)1559393226;
			switch (num2 == num)
			{
			}
			num = (short)1277558784;
			short num3 = num;
			num = (short)455475201;
			if (num != 0)
			{
			}
			num = (short)959643648;
			if (num != 0)
			{
			}
			this.CrumbBarItem.Select();
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00049F90 File Offset: 0x00048190
		private global::DevComponents.WpfRibbon.CrumbBar GetTree()
		{
			short num = (short)567745120;
			short num2 = num;
			num = (short)262281824;
			switch (num2 == num)
			{
			}
			num = (short)1398931456;
			short num3 = num;
			num = (short)115343361;
			if (num != 0)
			{
			}
			num = (short)1880162304;
			if (num != 0)
			{
			}
			return this._ParentTree;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0004A040 File Offset: 0x00048240
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0004A0F0 File Offset: 0x000482F0
		internal global::DevComponents.WpfRibbon.CrumbBar ParentTree
		{
			get
			{
				short num = (short)1549676054;
				short num2 = num;
				num = (short)1117990422;
				switch (num2 == num)
				{
				}
				num = (short)1275723776;
				short num3 = num;
				num = (short)391053313;
				if (num != 0)
				{
				}
				num = (short)1482489856;
				if (num != 0)
				{
				}
				return this._ParentTree;
			}
			set
			{
				short num = (short)646870002;
				short num2 = num;
				num = (short)1839690738;
				switch (num2 == num)
				{
				}
				num = (short)21364736;
				short num3 = num;
				num = (short)493813761;
				if (num != 0)
				{
				}
				num = (short)959381504;
				if (num != 0)
				{
				}
				this._ParentTree = value;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0004A1A0 File Offset: 0x000483A0
		private void UpdatePressed()
		{
			short num = (short)698618608;
			short num2 = num;
			num = (short)1553470192;
			switch (num2 == num)
			{
			}
			num = (short)269484032;
			short num3 = num;
			num = (short)1601896449;
			if (num != 0)
			{
			}
			num = (short)1847984128;
			if (num != 0)
			{
			}
			this.IsPressed = (this.IsPopupOpen || this._IsLeftMouseButtonDown);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0004A264 File Offset: 0x00048464
		// (set) Token: 0x06000354 RID: 852 RVA: 0x0004A314 File Offset: 0x00048514
		private bool IsLeftMouseButtonDown
		{
			get
			{
				short num = (short)1513684993;
				if (num != 0)
				{
				}
				num = (short)287529175;
				short num2 = num;
				num = (short)1524390103;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1513619456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)189399040;
				if (num != 0)
				{
				}
				return this._IsLeftMouseButtonDown;
			}
			set
			{
				short num = (short)1730019329;
				if (num != 0)
				{
				}
				num = (short)2029715456;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 1:
						return;
					case 2:
						this._IsLeftMouseButtonDown = value;
						this.UpdatePressed();
						num = (short)144113665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_58:
					num = (short)407502848;
					short num3 = num;
					if (this._IsLeftMouseButtonDown == value)
					{
						break;
					}
					num = (short)1560849679;
					short num4 = num;
					num = (short)1382722831;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)530710528;
						if (num != 0)
						{
						}
						num = (short)904134658;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0004A43C File Offset: 0x0004863C
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)585668349;
			short num2 = num;
			num = (short)1814533885;
			switch (num2 == num)
			{
			}
			num = (short)2072444928;
			short num3 = num;
			num = (short)1018757121;
			if (num != 0)
			{
			}
			num = (short)1148059648;
			if (num != 0)
			{
			}
			this.IsLeftMouseButtonDown = true;
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0004A4F4 File Offset: 0x000486F4
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1197015040;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
				{
					this.IsLeftMouseButtonDown = false;
					num = (short)862351682;
					short num3 = num;
					num = (short)1388802370;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)446496768;
						if (num != 0)
						{
						}
						num = (short)54329345;
						if (num != 0)
						{
						}
						num = (short)1633222658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_10B;
				}
				IL_30:
				if (e.ChangedButton != global::System.Windows.Input.MouseButton.Left)
				{
					break;
				}
				num = (short)1790836736;
				short num4 = num;
				num = (short)410189825;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			base.OnMouseUp(e);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0004A618 File Offset: 0x00048818
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Windows.Rect rect;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (rect.Contains(e.GetPosition(this)))
					{
						num2 = (short)1644756992;
						short num3 = num2;
						num2 = (short)2144600065;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_128;
				case 1:
				{
					num2 = (short)439549953;
					if (num2 != 0)
					{
					}
					num2 = (short)1259552243;
					short num4 = num2;
					num2 = (short)1896300019;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2883584;
						if (num2 != 0)
						{
						}
						this.MouseOverInternal = true;
						break;
					}
					num2 = (short)291700738;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
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
			rect = new global::System.Windows.Rect(base.RenderSize);
			num2 = (short)1149632512;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0004A754 File Offset: 0x00048954
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_70;
			}
			short num;
			int num3;
			global::System.Windows.Rect rect;
			for (;;)
			{
				IL_0A:
				num = (short)953679872;
				short num2 = num;
				num = (short)893714433;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					this.MouseOverInternal = true;
					num = (short)1458700291;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1198123072;
					short num4 = num;
					num = (short)214755392;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_124;
					default:
						num = (short)1387528192;
						if (num != 0)
						{
						}
						if (rect.Contains(e.GetPosition(this)))
						{
							num = (short)81002496;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.MouseOverInternal = false;
						num = (short)556072962;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_124;
				case 3:
					goto IL_144;
				}
				goto IL_70;
			}
			IL_124:
			IL_144:
			base.OnMouseMove(e);
			return;
			IL_70:
			rect = new global::System.Windows.Rect(base.RenderSize);
			num = (short)1356988417;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0004A8B0 File Offset: 0x00048AB0
		// (set) Token: 0x0600035A RID: 858 RVA: 0x0004A960 File Offset: 0x00048B60
		private bool MouseOverInternal
		{
			get
			{
				short num = (short)990045258;
				short num2 = num;
				num = (short)727639114;
				switch (num2 == num)
				{
				}
				num = (short)1319895040;
				short num3 = num;
				num = (short)991756289;
				if (num != 0)
				{
				}
				num = (short)709885952;
				if (num != 0)
				{
				}
				return this._MouseOverInternal;
			}
			set
			{
				short num = (short)1278935048;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.GetTree().IsMenuMode)
						{
							num = (short)1066598409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						if (!this.IsOverflowItem)
						{
							num = (short)137101315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)376226244;
						short num3 = num;
						num = (short)985252292;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FD;
						default:
							num = (short)608698368;
							if (num != 0)
							{
							}
							this.IsPopupOpen = true;
							num = (short)1655177217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						this._MouseOverInternal = value;
						this.UpdateIsMouseOverState();
						num = (short)1116864512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1936785408;
						short num4 = num;
						num = (short)731054086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (!this.IsPopupOpen)
						{
							goto IL_FD;
						}
						return;
					case 7:
						num = (short)520552449;
						if (num != 0)
						{
						}
						num = (short)359464962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					case 9:
						num = (short)1650065418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (this.CrumbBarItem.HasItems)
						{
							num = (short)1968570373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_50:
					if (this._MouseOverInternal != value)
					{
						num = (short)111869956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_FD:
					num = (short)1419247623;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0004ABAC File Offset: 0x00048DAC
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)692979122;
			short num2 = num;
			num = (short)1907754418;
			switch (num2 == num)
			{
			}
			num = (short)1123745792;
			short num3 = num;
			num = (short)2005204993;
			if (num != 0)
			{
			}
			num = (short)2008743936;
			if (num != 0)
			{
			}
			this.MouseOverInternal = false;
			base.OnMouseLeave(e);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0004AC64 File Offset: 0x00048E64
		private void UpdateIsMouseOverState()
		{
			short num = (short)1441932164;
			short num2 = num;
			num = (short)1585849220;
			switch (num2 == num)
			{
			}
			num = (short)1050148864;
			short num3 = num;
			num = (short)921436160;
			if (num != 0)
			{
			}
			num = (short)501940225;
			if (num != 0)
			{
			}
			this.IsMouseOverState = (this._MouseOverInternal | this.IsPopupOpen);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0004AD24 File Offset: 0x00048F24
		internal void ClosePopup()
		{
			short num = (short)1817245941;
			short num2 = num;
			num = (short)1848899829;
			switch (num2 == num)
			{
			}
			num = (short)1669988352;
			short num3 = num;
			num = (short)1857355776;
			if (num != 0)
			{
			}
			num = (short)1649475585;
			if (num != 0)
			{
			}
			this.IsPopupOpen = false;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0004ADD4 File Offset: 0x00048FD4
		private global::DevComponents.WpfRibbon.CrumbBarItemsControl GetItemsControl()
		{
			int a_ = 12;
			short num = (short)888733696;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1002045441;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 1:
				{
					this._ItemsControl = new global::DevComponents.WpfRibbon.CrumbBarItemsControl();
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❣ᑥᵧݩ๫Ɑᅯq㵳ɵᵷ᝹剻㝽", a_));
					binding.Source = this;
					this._ItemsControl.SetBinding(global::System.Windows.Controls.ItemsControl.ItemsSourceProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❣ᑥᵧݩ๫Ɑᅯq㵳ɵᵷ᝹剻㝽튅ﲋ", a_));
					binding.Source = this;
					this._ItemsControl.SetBinding(global::System.Windows.Controls.ItemsControl.ItemTemplateProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❣ᑥᵧݩ๫Ɑᅯq㵳ɵᵷ᝹剻㝽튅ﲋ얕ﶗ鍊ﶝ풟춡횣", a_));
					binding.Source = this;
					this._ItemsControl.SetBinding(global::System.Windows.Controls.ItemsControl.ItemTemplateSelectorProperty, binding);
					this._ItemsControl.Margin = new global::System.Windows.Thickness(2.0);
					global::System.Windows.Controls.Grid.SetIsSharedSizeScope(this._ItemsControl, true);
					this._ItemsControl.SnapsToDevicePixels = true;
					this._ItemsControl.ParentViewItem = this;
					num = (short)1042805184;
					short num3 = num;
					num = (short)2110190016;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)265355264;
						if (num != 0)
						{
						}
						num = (short)594018306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_1DC;
				}
				IL_60:
				num = (short)776077312;
				short num4 = num;
				if (this._ItemsControl != null)
				{
					break;
				}
				num = (short)1954611201;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1DC:
			return this._ItemsControl;
		}

		// Token: 0x0400012C RID: 300
		public static readonly global::System.Windows.DependencyProperty HeaderProperty;

		// Token: 0x0400012D RID: 301
		public static readonly global::System.Windows.DependencyProperty CrumbBarItemProperty;

		// Token: 0x0400012E RID: 302
		public static readonly global::System.Windows.DependencyProperty IsOverflowItemProperty;

		// Token: 0x0400012F RID: 303
		public static readonly global::System.Windows.DependencyProperty IsPopupOpenProperty;

		// Token: 0x04000130 RID: 304
		public static readonly global::System.Windows.DependencyProperty IsPressedProperty;

		// Token: 0x04000131 RID: 305
		public static readonly global::System.Windows.DependencyProperty IsMouseOverStateProperty;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Controls.Primitives.Popup _Popup;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Controls.ScrollViewer _ScrollViewer;

		// Token: 0x04000134 RID: 308
		private global::DevComponents.WpfRibbon.CrumbBar _ParentTree;

		// Token: 0x04000135 RID: 309
		private bool _IsLeftMouseButtonDown;

		// Token: 0x04000136 RID: 310
		private bool _MouseOverInternal;

		// Token: 0x04000137 RID: 311
		private global::DevComponents.WpfRibbon.CrumbBarItemsControl _ItemsControl;
	}
}
