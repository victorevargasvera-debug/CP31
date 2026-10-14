using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;
using DevComponents.WpfRibbon.themes;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000028 RID: 40
	public class CrumbBar : global::System.Windows.Controls.ItemsControl
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x0003FB80 File Offset: 0x0003DD80
		private static object OnCoerceSelectedItem(global::System.Windows.DependencyObject o, object value)
		{
			global::DevComponents.WpfRibbon.CrumbBar crumbBar = o as global::DevComponents.WpfRibbon.CrumbBar;
			if (crumbBar != null)
			{
				short num = (short)301478885;
				short num2 = num;
				num = (short)942879717;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1196949505;
					if (num != 0)
					{
					}
					num = (short)121372672;
					if (num != 0)
					{
					}
					num = (short)38535168;
					short num3 = num;
					break;
				}
				}
				return crumbBar.OnCoerceSelectedItem(value);
			}
			return value;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0003FC40 File Offset: 0x0003DE40
		private static void OnSelectedItemChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::DevComponents.WpfRibbon.CrumbBar crumbBar;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					crumbBar.OnSelectedItemChanged(e.OldValue, e.NewValue);
					num2 = (short)1635188737;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_F4;
				case 2:
					goto IL_AD;
				}
				goto IL_1C;
			}
			IL_AD:
			if (crumbBar != null)
			{
				goto IL_B0;
			}
			return;
			IL_F4:
			num2 = (short)1922891776;
			short num3 = num2;
			return;
			IL_1C:
			crumbBar = (o as global::DevComponents.WpfRibbon.CrumbBar);
			num2 = (short)518293919;
			short num4 = num2;
			num2 = (short)959089055;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B0:
				num2 = (short)1999437824;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1828585472;
				if (num2 != 0)
				{
				}
				num2 = (short)756154369;
				if (num2 != 0)
				{
				}
				num2 = (short)2085617666;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0003FD6C File Offset: 0x0003DF6C
		protected virtual object OnCoerceSelectedItem(object value)
		{
			short num = (short)334426453;
			short num2 = num;
			num = (short)1480257877;
			switch (num2 == num)
			{
			}
			num = (short)2048065536;
			if (num != 0)
			{
			}
			num = (short)2030567424;
			short num3 = num;
			num = (short)2015625217;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0003FE14 File Offset: 0x0003E014
		protected virtual void OnSelectedItemChanged(object oldValue, object newValue)
		{
			short num = (short)2110154762;
			short num2 = num;
			num = (short)868247562;
			switch (num2 == num)
			{
			}
			num = (short)795410433;
			if (num != 0)
			{
			}
			num = (short)210239488;
			short num3 = num;
			num = (short)776863744;
			if (num != 0)
			{
			}
			this.SetSelectedItem(newValue);
			this.OnSelectionChanged(oldValue, newValue);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0003FECC File Offset: 0x0003E0CC
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x0003FF80 File Offset: 0x0003E180
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(null)]
		public object SelectedItem
		{
			get
			{
				short num = (short)1938373177;
				short num2 = num;
				num = (short)1259158073;
				switch (num2 == num)
				{
				}
				num = (short)704970752;
				if (num != 0)
				{
				}
				num = (short)1899757568;
				short num3 = num;
				num = (short)493617153;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.CrumbBar.SelectedItemProperty);
			}
			set
			{
				short num = (short)1913487321;
				short num2 = num;
				num = (short)924418009;
				switch (num2 == num)
				{
				}
				num = (short)530972673;
				if (num != 0)
				{
				}
				num = (short)1574109184;
				short num3 = num;
				num = (short)2100822016;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBar.SelectedItemProperty, value);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00040038 File Offset: 0x0003E238
		// (set) Token: 0x060002DA RID: 730 RVA: 0x000400EC File Offset: 0x0003E2EC
		public object SelectedImage
		{
			get
			{
				short num = (short)803249726;
				short num2 = num;
				num = (short)433954366;
				switch (num2 == num)
				{
				}
				num = (short)635764737;
				if (num != 0)
				{
				}
				num = (short)266993664;
				short num3 = num;
				num = (short)1792212992;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfRibbon.CrumbBar.SelectedImageProperty);
			}
			set
			{
				short num = (short)1861025793;
				if (num != 0)
				{
				}
				num = (short)1124915153;
				short num2 = num;
				num = (short)324130769;
				switch (num2 == num)
				{
				}
				num = (short)714801152;
				short num3 = num;
				num = (short)548405248;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBar.SelectedImageProperty, value);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002DB RID: 731 RVA: 0x000401A4 File Offset: 0x0003E3A4
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0004025C File Offset: 0x0003E45C
		public bool HasOverflowItems
		{
			get
			{
				short num = (short)1751842817;
				if (num != 0)
				{
				}
				num = (short)1830383230;
				short num2 = num;
				num = (short)966815358;
				switch (num2 == num)
				{
				}
				num = (short)970784768;
				short num3 = num;
				num = (short)1065877504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBar.HasOverflowItemsProperty);
			}
			set
			{
				short num = (short)459041734;
				short num2 = num;
				num = (short)1884974022;
				switch (num2 == num)
				{
				}
				num = (short)823197697;
				if (num != 0)
				{
				}
				num = (short)1394868224;
				short num3 = num;
				num = (short)54525952;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBar.HasOverflowItemsProperty, value);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00040314 File Offset: 0x0003E514
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000403D0 File Offset: 0x0003E5D0
		public bool IsOverflowOpen
		{
			get
			{
				short num = (short)2024790651;
				short num2 = num;
				num = (short)1329584763;
				switch (num2 == num)
				{
				}
				num = (short)1364066304;
				if (num != 0)
				{
				}
				num = (short)1700593664;
				short num3 = num;
				num = (short)144572417;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBar.IsOverflowOpenProperty);
			}
			set
			{
				short num = (short)1929612065;
				short num2 = num;
				num = (short)1686604577;
				switch (num2 == num)
				{
				}
				num = (short)1359085569;
				if (num != 0)
				{
				}
				num = (short)461635584;
				short num3 = num;
				num = (short)365232128;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBar.IsOverflowOpenProperty, value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0004048C File Offset: 0x0003E68C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::System.Collections.ObjectModel.ObservableCollection<object> ActionItems
		{
			get
			{
				short num = (short)191585463;
				short num2 = num;
				num = (short)898325687;
				switch (num2 == num)
				{
				}
				num = (short)1241579521;
				if (num != 0)
				{
				}
				num = (short)1626472448;
				short num3 = num;
				num = (short)125698048;
				if (num != 0)
				{
				}
				return (global::System.Collections.ObjectModel.ObservableCollection<object>)base.GetValue(global::DevComponents.WpfRibbon.CrumbBar.ActionItemsProperty);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00040544 File Offset: 0x0003E744
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasActionItems
		{
			get
			{
				short num = (short)248268461;
				short num2 = num;
				num = (short)1639270061;
				switch (num2 == num)
				{
				}
				num = (short)2066481153;
				if (num != 0)
				{
				}
				num = (short)1968898048;
				short num3 = num;
				num = (short)460324864;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.CrumbBar.HasActionItemsProperty);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000405FC File Offset: 0x0003E7FC
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x000406B4 File Offset: 0x0003E8B4
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate ActionItemTemplate
		{
			get
			{
				short num = (short)929302183;
				short num2 = num;
				num = (short)47908519;
				switch (num2 == num)
				{
				}
				num = (short)1837367296;
				short num3 = num;
				num = (short)1785528320;
				if (num != 0)
				{
				}
				num = (short)1876295681;
				if (num != 0)
				{
				}
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfRibbon.CrumbBar.ActionItemTemplateProperty);
			}
			set
			{
				short num = (short)2025422638;
				short num2 = num;
				num = (short)1292533550;
				switch (num2 == num)
				{
				}
				num = (short)1066663936;
				short num3 = num;
				num = (short)1798438912;
				if (num != 0)
				{
				}
				num = (short)1220280321;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBar.ActionItemTemplateProperty, value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0004076C File Offset: 0x0003E96C
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00040828 File Offset: 0x0003EA28
		public global::System.Windows.Controls.DataTemplateSelector ActionItemTemplateSelector
		{
			get
			{
				short num = (short)1249663123;
				short num2 = num;
				num = (short)987584659;
				switch (num2 == num)
				{
				}
				num = (short)1579548672;
				short num3 = num;
				num = (short)88080385;
				if (num != 0)
				{
				}
				num = (short)1878720512;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfRibbon.CrumbBar.ActionItemTemplateSelectorProperty);
			}
			set
			{
				short num = (short)1568334390;
				short num2 = num;
				num = (short)405856822;
				switch (num2 == num)
				{
				}
				num = (short)981467136;
				short num3 = num;
				num = (short)478609409;
				if (num != 0)
				{
				}
				num = (short)1810432000;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.CrumbBar.ActionItemTemplateSelectorProperty, value);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060002E5 RID: 741 RVA: 0x000408DC File Offset: 0x0003EADC
		// (remove) Token: 0x060002E6 RID: 742 RVA: 0x00040994 File Offset: 0x0003EB94
		public event global::DevComponents.WpfRibbon.CrumbBarSelectionChangedEventHandler SelectionChanged
		{
			add
			{
				short num = (short)1842424591;
				short num2 = num;
				num = (short)64760591;
				switch (num2 == num)
				{
				}
				num = (short)197459968;
				short num3 = num;
				num = (short)1068040193;
				if (num != 0)
				{
				}
				num = (short)96534528;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.CrumbBar.SelectionChangedEvent, value);
			}
			remove
			{
				short num = (short)1735141178;
				short num2 = num;
				num = (short)1590437690;
				switch (num2 == num)
				{
				}
				num = (short)931463168;
				short num3 = num;
				num = (short)1133051905;
				if (num != 0)
				{
				}
				num = (short)302841856;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.CrumbBar.SelectionChangedEvent, value);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060002E7 RID: 743 RVA: 0x00040A48 File Offset: 0x0003EC48
		// (remove) Token: 0x060002E8 RID: 744 RVA: 0x00040AFC File Offset: 0x0003ECFC
		public event global::DevComponents.WpfRibbon.CrumbBarSelectionChangedEventHandler PreviewSelectionChanged
		{
			add
			{
				short num = (short)1853883008;
				short num2 = num;
				num = (short)1167458944;
				switch (num2 == num)
				{
				}
				num = (short)826474496;
				short num3 = num;
				num = (short)1835794433;
				if (num != 0)
				{
				}
				num = (short)1109131264;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfRibbon.CrumbBar.PreviewSelectionChangedEvent, value);
			}
			remove
			{
				short num = (short)902777533;
				short num2 = num;
				num = (short)1979534013;
				switch (num2 == num)
				{
				}
				num = (short)1055653888;
				short num3 = num;
				num = (short)1723858945;
				if (num != 0)
				{
				}
				num = (short)570359808;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfRibbon.CrumbBar.PreviewSelectionChangedEvent, value);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00040BB4 File Offset: 0x0003EDB4
		protected virtual void OnSelectionChanged(object oldSelection, object newSelection)
		{
			short num = (short)313965437;
			short num2 = num;
			num = (short)1362606973;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1297481728;
				short num3 = num;
				num = (short)1637089280;
				if (num != 0)
				{
				}
				global::DevComponents.WpfRibbon.CrumbBarSelectionChangedEventArgs crumbBarSelectionChangedEventArgs = new global::DevComponents.WpfRibbon.CrumbBarSelectionChangedEventArgs(global::DevComponents.WpfRibbon.CrumbBar.PreviewSelectionChangedEvent, this, newSelection, oldSelection);
				base.RaiseEvent(crumbBarSelectionChangedEventArgs);
				if (!crumbBarSelectionChangedEventArgs.Handled)
				{
					num = (short)397213697;
					if (num != 0)
					{
					}
					global::DevComponents.WpfRibbon.CrumbBarSelectionChangedEventArgs e = new global::DevComponents.WpfRibbon.CrumbBarSelectionChangedEventArgs(global::DevComponents.WpfRibbon.CrumbBar.SelectionChangedEvent, this, newSelection, oldSelection);
					base.RaiseEvent(e);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00040C90 File Offset: 0x0003EE90
		static CrumbBar()
		{
			int a_ = 6;
			short num = (short)2146339845;
			short num2 = num;
			num = (short)2006158341;
			switch (num2 == num)
			{
			}
			num = (short)1200947200;
			short num3 = num;
			num = (short)1341980673;
			if (num != 0)
			{
			}
			num = (short)1546190848;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.CrumbBar.SelectedItemProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝՟๡ţեᱧཀྵ࡫❭ѯ᝱ᥳ", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.CrumbBar), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.CrumbBar.OnSelectedItemChanged), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfRibbon.CrumbBar.OnCoerceSelectedItem)));
			global::DevComponents.WpfRibbon.CrumbBar.SelectedImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝՟๡ţեᱧཀྵ࡫❭ᵯ፱፳፵", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.CrumbBar), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.CrumbBar.HasOverflowItemsProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᙝşᅡ⭣ၥ൧ᡩ੫ɭὯձ㵳ɵᵷ᝹ཻ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBar), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfRibbon.CrumbBar.IsOverflowOpenProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᝝፟ⵡባͥᩧ౩kŭݯ㵱ѳ፵ᙷ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBar), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::DevComponents.WpfRibbon.CrumbBar.ActionItemTemplateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ὕ͟ᙡൣ॥٧⍩ᡫ୭ᵯ♱ᅳ᭵ࡷᙹᵻ੽", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfRibbon.CrumbBar), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.CrumbBar.ActionItemTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ὕ͟ᙡൣ॥٧⍩ᡫ୭ᵯ♱ᅳ᭵ࡷᙹᵻ੽톁", a_), typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::DevComponents.WpfRibbon.CrumbBar), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.CrumbBar.SelectionChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൝՟๡ţեᱧͩͫm㍯ᩱᕳᡵίό᡻", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::DevComponents.WpfRibbon.CrumbBarSelectionChangedEventHandler), typeof(global::DevComponents.WpfRibbon.CrumbBar));
			global::DevComponents.WpfRibbon.CrumbBar.PreviewSelectionChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("๝቟ݡባཥ൧ᵩ㽫୭ᱯ᝱ᝳɵᅷᕹቻ㵽", a_), global::System.Windows.RoutingStrategy.Tunnel, typeof(global::DevComponents.WpfRibbon.CrumbBarSelectionChangedEventHandler), typeof(global::DevComponents.WpfRibbon.CrumbBar));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.CrumbBar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.CrumbBar)));
			global::DevComponents.WpfRibbon.CrumbBar.ActionItemsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ὕ͟ᙡൣ॥٧⍩ᡫ୭ᵯű", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<object>), typeof(global::DevComponents.WpfRibbon.CrumbBar), new global::System.Windows.PropertyMetadata(new global::System.Collections.ObjectModel.ObservableCollection<object>()));
			global::DevComponents.WpfRibbon.CrumbBar.ActionItemsProperty = global::DevComponents.WpfRibbon.CrumbBar.ActionItemsPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.CrumbBar.HasActionItemsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᙝşᅡ╣եᱧͩͫm㥯ٱᅳ᭵୷", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.CrumbBar), new global::System.Windows.PropertyMetadata(false));
			global::DevComponents.WpfRibbon.CrumbBar.HasActionItemsProperty = global::DevComponents.WpfRibbon.CrumbBar.HasActionItemsPropertyKey.DependencyProperty;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00040FA0 File Offset: 0x0003F1A0
		public CrumbBar()
		{
			global::System.Collections.ObjectModel.ObservableCollection<object> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<object>();
			observableCollection.CollectionChanged += this.ActionItemsCollectionChanged;
			base.SetValue(global::DevComponents.WpfRibbon.CrumbBar.ActionItemsPropertyKey, observableCollection);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00040FD8 File Offset: 0x0003F1D8
		public override void OnApplyTemplate()
		{
			int a_ = 17;
			short num = (short)1146814466;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this._OverflowPopup.Opened += this.OverflowPopupOpened;
					this._OverflowPopup.Closed += this.OverflowPopupClosed;
					num = (short)981270531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this._OverflowPopup != null)
					{
						num = (short)1246429184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AC;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 3:
					goto IL_23F;
				case 4:
					this._OverflowPopup.Opened -= this.OverflowPopupOpened;
					this._OverflowPopup.Closed -= this.OverflowPopupClosed;
					num = (short)218628102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this._ViewPanel.Children.Clear();
					num = (short)1844445192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1A4;
				case 7:
					if (this._OverflowPopup != null)
					{
						num = (short)947388420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C1;
				case 8:
					num = (short)327681;
					if (num != 0)
					{
					}
					goto IL_26B;
				}
				IL_51:
				num = (short)862802921;
				short num3 = num;
				num = (short)1158960105;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1A4:
					break;
				default:
					num = (short)1524105216;
					if (num != 0)
					{
					}
					if (this._ViewPanel != null)
					{
						num = (short)678756357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26B;
				}
				IL_C1:
				this._ViewPanel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㥨⩪㽬㭮⹰╲ᱴቶ๸⭺ᱼᅾ", a_)) as global::DevComponents.WpfRibbon.CrumbBarViewPanel);
				this._ViewOverflowPanel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㥨⩪㽬㭮⹰㱲ʹቶ୸ᵺᅼၾ펂", a_)) as global::DevComponents.WpfRibbon.CrumbBarViewOverflowPanel);
				this._OverflowPopup = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("♨ᵪ࡬ᵮᝰὲᩴv⥸ᑺർ੾", a_)) as global::System.Windows.Controls.Primitives.Popup);
				num = (short)1242759169;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_26B:
				num = (short)1686241287;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_23F:
			num = (short)1190395904;
			short num4 = num;
			IL_2AC:
			this.SetSelectedItem(this.SelectedItem);
			base.OnApplyTemplate();
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000412A4 File Offset: 0x0003F4A4
		private void OverflowPopupClosed(object sender, global::System.EventArgs e)
		{
			short num = (short)270139392;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)577306624;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				}
				case 1:
					return;
				case 2:
					num = (short)914554881;
					if (num != 0)
					{
					}
					this.IsMenuMode = false;
					num = (short)1150550017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5B:
				num = (short)451510892;
				short num4 = num;
				num = (short)905609836;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)47382528;
					if (num != 0)
					{
					}
					if (this._OpenItem != null)
					{
						return;
					}
					break;
				}
				num = (short)779354114;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000413C0 File Offset: 0x0003F5C0
		private void OverflowPopupOpened(object sender, global::System.EventArgs e)
		{
			short num = (short)1896135626;
			short num2 = num;
			num = (short)2087369674;
			switch (num2 == num)
			{
			}
			num = (short)359596032;
			short num3 = num;
			num = (short)1314127872;
			if (num != 0)
			{
			}
			num = (short)1715142657;
			if (num != 0)
			{
			}
			this.SetOpenedViewItem(null);
			this.IsMenuMode = true;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0004147C File Offset: 0x0003F67C
		protected override void OnInitialized(global::System.EventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
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
					global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator = base.ItemContainerGenerator;
					global::System.IDisposable disposable = itemContainerGenerator.StartAt(new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, 0), global::System.Windows.Controls.Primitives.GeneratorDirection.Forward);
					num2 = (short)1113915400;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)1602551814;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_398;
				case 3:
					if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
					{
						goto IL_130;
					}
					goto IL_33E;
				case 4:
					if (this.SelectedItem == null)
					{
						num2 = (short)174653445;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_39A;
				case 5:
					num2 = (short)330039307;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (base.ItemContainerGenerator.Status != global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
					{
						num2 = (short)723910656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_39A;
				case 7:
					num2 = (short)1783103491;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					try
					{
						num2 = (short)1999568897;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator;
								global::System.Windows.UIElement container;
								if ((container = (itemContainerGenerator.GenerateNext() as global::System.Windows.UIElement)) == null)
								{
									num2 = (short)1190395908;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								itemContainerGenerator.PrepareItemContainer(container);
								num2 = (short)797835266;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_239;
								}
								continue;
							case 3:
								goto IL_2A9;
							case 4:
								num2 = (short)2021195779;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_258:
							num2 = (short)1813708800;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_239:
							goto IL_258;
						}
						IL_2A9:
						goto IL_39A;
					}
					finally
					{
						num2 = (short)1101660160;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							global::System.IDisposable disposable;
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2DF;
								}
								continue;
							case 1:
								goto IL_33B;
							case 2:
								num2 = (short)2057961473;
								if (num2 != 0)
								{
								}
								disposable.Dispose();
								num2 = (short)1864892417;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_2DF:
							if (disposable == null)
							{
								break;
							}
							num2 = (short)499449858;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_33B:;
					}
					goto IL_33E;
				case 9:
					goto IL_37B;
				case 10:
					if (base.ItemsSource != null)
					{
						num2 = (short)2143813633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_39A;
				case 11:
					if (base.ItemsSource != null)
					{
						num2 = (short)76189335;
						short num3 = num2;
						num2 = (short)933006999;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_130;
						case 1:
							break;
						default:
						{
							num2 = (short)2044002304;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1889402880;
						if (num2 != 0)
						{
						}
						num2 = (short)1376976903;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_37B;
				}
				goto IL_40;
				IL_130:
				num2 = (short)1945501705;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_33E:
				num2 = (short)2116354058;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_37B:
				this.SelectFirstItem();
				num2 = (short)1786380290;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_398:
			IL_39A:
			base.OnInitialized(e);
			return;
			IL_40:
			base.ItemContainerGenerator.StatusChanged += this.ItemContainerGeneratorStatusChanged;
			num2 = (short)1877606404;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0004183C File Offset: 0x0003FA3C
		private void ItemContainerGeneratorStatusChanged(object sender, global::System.EventArgs e)
		{
			short num = (short)73728003;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1989970122;
					short num3 = num;
					num = (short)1307216074;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_171;
					default:
						goto IL_E5;
					}
					break;
				}
				case 1:
					goto IL_171;
				case 2:
					num = (short)1721434113;
					if (num != 0)
					{
					}
					num = (short)1152647173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 4:
					if (this.SelectedItem == null)
					{
						num = (short)769130502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
				case 5:
					if (base.HasItems)
					{
						num = (short)776929281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
				case 6:
					this.SelectFirstItem();
					num = (short)1202257920;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_41:
				if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
				{
					num = (short)709754882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_173;
				IL_171:
				num = (short)265879556;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E5:
			num = (short)1554055168;
			if (num != 0)
			{
			}
			IL_173:
			num = (short)77004800;
			short num4 = num;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000419E8 File Offset: 0x0003FBE8
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			short num = (short)1041825793;
			if (num != 0)
			{
			}
			num = (short)1468207327;
			short num2 = num;
			num = (short)166531295;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1699676160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)976748544;
			if (num != 0)
			{
			}
			return item is global::DevComponents.WpfRibbon.CrumbBarItem;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00041A9C File Offset: 0x0003FC9C
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			short num = (short)817369694;
			short num2 = num;
			num = (short)815207006;
			switch (num2 == num)
			{
			}
			num = (short)561512448;
			short num3 = num;
			num = (short)617807872;
			if (num != 0)
			{
			}
			num = (short)803471361;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfRibbon.CrumbBarItem();
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00041B4C File Offset: 0x0003FD4C
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1198195080;
			short num2 = num;
			num = (short)1636172168;
			switch (num2 == num)
			{
			}
			num = (short)1798504448;
			short num3 = num;
			num = (short)444989440;
			if (num != 0)
			{
			}
			num = (short)2057764865;
			if (num != 0)
			{
			}
			base.OnItemsChanged(e);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00041BFC File Offset: 0x0003FDFC
		private global::DevComponents.WpfRibbon.CrumbBarItemView CreateView(global::DevComponents.WpfRibbon.CrumbBarItem item)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::System.Windows.Controls.ToolTipService.GetToolTip(item) != null)
					{
						num2 = (short)15925250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return crumbBarItemView;
				case 1:
					return crumbBarItemView;
				case 2:
					goto IL_FE;
				}
				goto IL_1C;
			}
			IL_FE:
			global::System.Windows.Controls.ToolTipService.SetToolTip(crumbBarItemView, global::System.Windows.Controls.ToolTipService.GetToolTip(item));
			goto IL_10C;
			IL_1C:
			crumbBarItemView = new global::DevComponents.WpfRibbon.CrumbBarItemView();
			crumbBarItemView.ParentTree = this;
			crumbBarItemView.CrumbBarItem = item;
			num2 = (short)1300758529;
			if (num2 != 0)
			{
			}
			num2 = (short)646162248;
			short num3 = num2;
			num2 = (short)512730952;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_10C:
				num2 = (short)256180225;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)1805123584;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)1216675840;
			if (num2 != 0)
			{
			}
			num2 = (short)816250880;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00041D30 File Offset: 0x0003FF30
		private void SelectFirstItem()
		{
			short num = (short)1799553025;
			if (num != 0)
			{
			}
			num = (short)770965504;
			short num2 = num;
			num = (short)2021261312;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_7F;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					object selectedItem;
					this.SelectedItem = selectedItem;
					num = (short)629276673;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_7F:
				num = (short)1497461346;
				short num4 = num;
				num = (short)957444706;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)18153472;
					if (num != 0)
					{
					}
					object selectedItem;
					global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem;
					if (!this.GetFirstItem(out selectedItem, out crumbBarItem))
					{
						return;
					}
					break;
				}
				}
				num = (short)944046082;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00041E4C File Offset: 0x0004004C
		private bool GetFirstItem(out object item, out global::DevComponents.WpfRibbon.CrumbBarItem container)
		{
			short num = (short)758251521;
			if (num != 0)
			{
			}
			num = (short)944496112;
			short num2 = num;
			num = (short)630775280;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A2;
			case 1:
				break;
			default:
			{
				num = (short)2057961472;
				short num3 = num;
				break;
			}
			}
			num = (short)1403191296;
			if (num != 0)
			{
			}
			if (!base.HasItems)
			{
				item = null;
				container = null;
				return false;
			}
			IL_A2:
			item = base.Items[0];
			container = (base.ItemContainerGenerator.ContainerFromIndex(0) as global::DevComponents.WpfRibbon.CrumbBarItem);
			return item != null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00041F2C File Offset: 0x0004012C
		private void SetSelectedItem(object selectedItem)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (selectedItem != null)
					{
						num2 = (short)351797250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_112;
				case 1:
					goto IL_110;
				case 2:
					goto IL_ED;
				}
				goto IL_1C;
			}
			IL_ED:
			global::DevComponents.WpfRibbon.CrumbBarItem container = this.FindContainer(selectedItem);
			goto IL_F7;
			IL_110:
			IL_112:
			this.SetSelectedItem(selectedItem, container);
			return;
			IL_1C:
			container = null;
			num2 = (short)408346860;
			short num3 = num2;
			num2 = (short)1587929324;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F7:
				num2 = (short)830865409;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1384972288;
				short num4 = num2;
				num2 = (short)879558657;
				if (num2 != 0)
				{
				}
				num2 = (short)1970143232;
				if (num2 != 0)
				{
				}
				num2 = (short)1799421952;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00042054 File Offset: 0x00040254
		private global::DevComponents.WpfRibbon.CrumbBarItem FindContainer(object selectedItem)
		{
			short num = (short)1404764160;
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
				global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (!(selectedItem is global::DevComponents.WpfRibbon.CrumbBarItem))
						{
							num = (short)586219521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46B;
					case 1:
					{
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
						num = (short)1217921024;
						short num3 = num;
						num = (short)2109472773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (selectedItem != null)
						{
							num = (short)868024326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					case 3:
						num = (short)1259929600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_126;
					case 5:
						try
						{
							num = (short)767688709;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem2;
								global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem3;
								switch (num2)
								{
								case 0:
									goto IL_36A;
								case 1:
									num = (short)1658585088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (crumbBarItem != null)
									{
										num = (short)2040659977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1787691009;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									num = (short)862388231;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									crumbBarItem = this.FindContainer(crumbBarItem2, selectedItem);
									num = (short)1715994626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1E9;
									}
									continue;
								case 6:
									num = (short)421593096;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									object obj;
									if (!(obj is global::DevComponents.WpfRibbon.CrumbBarItem))
									{
										num = (short)564461574;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)364052492;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									object obj;
									crumbBarItem3 = (base.ItemContainerGenerator.ContainerFromItem(obj) as global::DevComponents.WpfRibbon.CrumbBarItem);
									goto IL_314;
								}
								case 9:
									num = (short)757727242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_2AA;
								case 11:
									if (crumbBarItem2 != null)
									{
										num = (short)813039620;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 12:
								{
									object obj;
									crumbBarItem3 = (global::DevComponents.WpfRibbon.CrumbBarItem)obj;
									goto IL_314;
								}
								}
								IL_252:
								num = (short)869400579;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E9:
								goto IL_252;
								IL_314:
								crumbBarItem2 = crumbBarItem3;
								num = (short)1459093515;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2AA:
							IL_36A:
							goto IL_46B;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_38C;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_379:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										goto IL_3B0;
									}
									goto IL_432;
								case 1:
									goto IL_430;
								case 2:
								{
									disposable.Dispose();
									num = (short)1390200275;
									short num4 = num;
									num = (short)454084051;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3B0;
									default:
										num = (short)457506816;
										if (num != 0)
										{
										}
										num = (short)1632894977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_38C;
								IL_3B0:
								num = (short)356646914;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_430:
							IL_432:
							goto EndFinally_11;
							IL_38C:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)913113088;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_379;
							EndFinally_11:;
						}
						goto IL_433;
					case 6:
						crumbBarItem = (base.ItemContainerGenerator.ContainerFromItem(selectedItem) as global::DevComponents.WpfRibbon.CrumbBarItem);
						num = (short)1868431364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (crumbBarItem == null)
						{
							num = (short)2096365577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46B;
					case 8:
						if (selectedItem != null)
						{
							num = (short)2011627523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46B;
					case 9:
						goto IL_433;
					}
					goto IL_57;
					IL_126:
					num = (short)513933319;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_433:
					num = (short)1767899144;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_46B:
				num = (short)1893728257;
				if (num != 0)
				{
				}
				return crumbBarItem;
				IL_57:
				crumbBarItem = null;
				num = (short)261750786;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00042510 File Offset: 0x00040710
		private global::DevComponents.WpfRibbon.CrumbBarItem FindContainer(global::DevComponents.WpfRibbon.CrumbBarItem generatedItem, object selectedItem)
		{
			short num = (short)195362816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)generatedItem.Items).GetEnumerator();
						num = (short)1329659910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)85458945;
						if (num != 0)
						{
						}
						global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator;
						global::System.IDisposable disposable = itemContainerGenerator.StartAt(new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, 0), global::System.Windows.Controls.Primitives.GeneratorDirection.Forward);
						num = (short)77135875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator = generatedItem.ItemContainerGenerator;
						num = (short)946995204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_42E;
					case 4:
					{
						global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator;
						if (itemContainerGenerator != null)
						{
							num = (short)529596417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7;
					}
					case 5:
						if (generatedItem.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.NotStarted)
						{
							num = (short)481427458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7;
					case 6:
						try
						{
							num = (short)50528262;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem;
								global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem3;
								switch (num2)
								{
								case 0:
									num = (short)699858954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3B2;
								case 2:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)181534731;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									num = (short)1124073475;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									object obj;
									if (!(obj is global::DevComponents.WpfRibbon.CrumbBarItem))
									{
										num = (short)1373962240;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1242562572;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									if (crumbBarItem != null)
									{
										num = (short)905510919;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									num = (short)308674569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_226;
									}
									continue;
								case 7:
									crumbBarItem2 = this.FindContainer(crumbBarItem, selectedItem);
									num = (short)589299720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (crumbBarItem2 != null)
									{
										num = (short)413859845;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
									goto IL_2A9;
								case 10:
								{
									object obj;
									crumbBarItem3 = (generatedItem.ItemContainerGenerator.ContainerFromItem(obj) as global::DevComponents.WpfRibbon.CrumbBarItem);
									goto IL_318;
								}
								case 11:
									num = (short)2139488257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									object obj;
									crumbBarItem3 = (global::DevComponents.WpfRibbon.CrumbBarItem)obj;
									goto IL_318;
								}
								}
								IL_255:
								num = (short)402849794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_226:
								goto IL_255;
								IL_318:
								crumbBarItem = crumbBarItem3;
								num = (short)1985282052;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A9:
							IL_3B2:
							return crumbBarItem2;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_3D4;
							}
							global::System.IDisposable disposable2;
							for (;;)
							{
								IL_3C1:
								switch (num2)
								{
								case 0:
									goto IL_42B;
								case 1:
									if (disposable2 != null)
									{
										num = (short)466550786;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_42D;
								case 2:
									disposable2.Dispose();
									num = (short)2121596928;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3D4;
							}
							IL_42B:
							IL_42D:
							goto EndFinally_17;
							IL_3D4:
							global::System.Collections.IEnumerator enumerator;
							disposable2 = (enumerator as global::System.IDisposable);
							num = (short)1070989313;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3C1;
							EndFinally_17:;
						}
						goto Block_5;
					case 7:
						if (crumbBarItem2 == null)
						{
							num = (short)607518720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return crumbBarItem2;
					}
					goto IL_4F;
					IL_E7:
					crumbBarItem2 = (generatedItem.ItemContainerGenerator.ContainerFromItem(selectedItem) as global::DevComponents.WpfRibbon.CrumbBarItem);
					num = (short)1514340359;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_5:
					try
					{
						IL_42E:
						switch (0)
						{
						case 0:
							goto IL_45B;
						}
						for (;;)
						{
							IL_438:
							global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem4;
							switch (num2)
							{
							case 0:
								goto IL_54B;
							case 1:
								goto IL_586;
							case 2:
								num = (short)607191041;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_509;
							case 4:
							{
								num = (short)1106206674;
								short num3 = num;
								num = (short)366698450;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_54B;
								default:
									num = (short)854065152;
									if (num != 0)
									{
									}
									goto IL_509;
								}
								break;
							}
							case 5:
								if (crumbBarItem4 != null)
								{
									num = (short)1951072256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_509;
							case 6:
							{
								global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator;
								global::System.Windows.UIElement uielement;
								if ((uielement = (itemContainerGenerator.GenerateNext() as global::System.Windows.UIElement)) == null)
								{
									num = (short)599457794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								itemContainerGenerator.PrepareItemContainer(uielement);
								crumbBarItem4 = (uielement as global::DevComponents.WpfRibbon.CrumbBarItem);
								num = (short)1867448325;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_45B;
							IL_509:
							num = (short)1361313798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_54B:
							crumbBarItem4.ApplyTemplate();
							num = (short)1004208131;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_586:
						goto IL_E7;
						IL_45B:
						num = (short)983629828;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_438;
					}
					finally
					{
						num = (short)1758068737;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.IDisposable disposable;
							switch (num2)
							{
							case 0:
								goto IL_5F5;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_5BE;
								}
								continue;
							case 2:
								disposable.Dispose();
								num = (short)564592640;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_5BE:
							if (disposable == null)
							{
								break;
							}
							num = (short)2069954562;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_5F5:;
					}
					break;
				}
				return crumbBarItem2;
				IL_4F:
				crumbBarItem2 = null;
				num = (short)1827995648;
				short num4 = num;
				num = (short)1939931141;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00042B4C File Offset: 0x00040D4C
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Windows.UIElement> ViewItems
		{
			get
			{
				short num = (short)360185857;
				if (num != 0)
				{
				}
				if (this._ViewPanel != null)
				{
					num = (short)969932800;
					short num2 = num;
					num = (short)275546499;
					short num3 = num;
					num = (short)1955692931;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1317601280;
						if (num != 0)
						{
						}
						return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Windows.UIElement>(this._ViewPanel.GeneratedChildren);
					}
				}
				return null;
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00042C14 File Offset: 0x00040E14
		internal void SetSelectedItem(object selectedItem, global::DevComponents.WpfRibbon.CrumbBarItem container)
		{
			short num = (short)684851200;
			switch (num)
			{
			default:
			{
				num = (short)774045710;
				int num2 = (int)((global::System.IntPtr)num);
				global::DevComponents.WpfRibbon.CrumbBarViewPanel viewPanel;
				for (;;)
				{
					global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.CrumbBarItemView> list;
					global::DevComponents.WpfRibbon.CrumbBarItem crumbBarItem;
					switch (num2)
					{
					case 0:
						goto IL_58C;
					case 1:
						if (container == null)
						{
							num = (short)86310937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					case 2:
						goto IL_2B6;
					case 3:
						try
						{
							num = (short)1730150402;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)2028732417;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4D0;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3FE;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.CrumbBarItemView>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1741160448;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfRibbon.CrumbBarItemView item = enumerator.Current;
									viewPanel.GeneratedChildren.Add(item);
									num = (short)1257504771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_42D:
								num = (short)1233764077;
								short num3 = num;
								num = (short)1703329517;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_4D0;
								default:
									num = (short)479002624;
									if (num != 0)
									{
									}
									num = (short)63766532;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3FE:
								goto IL_42D;
							}
							IL_4D0:
							goto IL_257;
						}
						finally
						{
							num = (short)424869889;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.CrumbBarItemView>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_50A;
						IL_257:
						viewPanel.InvalidateMeasure();
						num = (short)974192658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (selectedItem == null)
						{
							num = (short)1000538125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1658650625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_D5;
					case 6:
						this.SelectedImage = global::DevComponents.WpfRibbon.CloningMachine.GetObjectCopy(container.Image, true);
						num = (short)89063448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						container = (global::DevComponents.WpfRibbon.CrumbBarItem)selectedItem;
						num = (short)531759116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (selectedItem is global::DevComponents.WpfRibbon.CrumbBarItem)
						{
							num = (short)1560150023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_359;
					case 9:
						return;
					case 10:
						this._SelectedContainer.IsSelected = false;
						num = (short)1033699345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this._SelectedContainer != null)
						{
							num = (short)1667956758;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58C;
					case 12:
						goto IL_359;
					case 13:
						goto IL_316;
					case 14:
						switch (0)
						{
						case 0:
							goto IL_AD;
						}
						continue;
					case 15:
						if (container == null)
						{
							num = (short)1490485248;
							short num4 = num;
							num = (short)1792933897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1742340107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						viewPanel.GeneratedChildren.Clear();
						global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.CrumbBarItemView>.Enumerator enumerator = list.GetEnumerator();
						num = (short)667484163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_2DE;
					case 18:
						if (container != null)
						{
							num = (short)77987846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SelectedImage = null;
						num = (short)500957186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						return;
					case 20:
						goto IL_D5;
					case 21:
						if (this._SelectedContainer != null)
						{
							num = (short)1172111370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DE;
					case 22:
						this._SelectedContainer.IsSelected = true;
						num = (short)1409089536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (crumbBarItem == null)
						{
							num = (short)750452752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50A;
					case 24:
						goto IL_1D4;
					case 25:
						num = (short)125042696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AD:
					if (this._ViewPanel == null)
					{
						num = (short)630259731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					viewPanel = this._ViewPanel;
					num = (short)1954283541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D5:
					num = (short)1059913751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DE:
					num = (short)24772612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_359:
					this._SelectedContainer = container;
					num = (short)1719861263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50A:
					global::DevComponents.WpfRibbon.CrumbBarItemView viewItem = this.GetViewItem(crumbBarItem);
					list.Insert(0, viewItem);
					crumbBarItem = this.GetParentTreeItem(crumbBarItem);
					num = (short)1031340037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58C:
					list = new global::System.Collections.Generic.List<global::DevComponents.WpfRibbon.CrumbBarItemView>();
					crumbBarItem = container;
					num = (short)588972052;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1D4:
				IL_2B6:
				goto IL_5B1;
				IL_316:
				viewPanel.GeneratedChildren.Clear();
				viewPanel.InvalidateMeasure();
				return;
				IL_5B1:
				this.IsMenuMode = false;
				return;
			}
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000431F8 File Offset: 0x000413F8
		private global::DevComponents.WpfRibbon.CrumbBarItem GetParentTreeItem(global::DevComponents.WpfRibbon.CrumbBarItem current)
		{
			short num = (short)322961413;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView;
			global::System.Windows.Controls.ItemsControl itemsControl;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (crumbBarItemView != null)
					{
						num = (short)848560138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_142;
				case 1:
				{
					if (current.Parent is global::DevComponents.WpfRibbon.CrumbBarItem)
					{
						num = (short)877658123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1994718327;
					short num3 = num;
					num = (short)1663106167;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_270;
					default:
					{
						num = (short)194641920;
						short num4 = num;
						num = (short)305070080;
						if (num != 0)
						{
						}
						itemsControl = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(current);
						num = (short)1303117830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_270;
				case 3:
					crumbBarItemView = (itemsControl.TemplatedParent as global::DevComponents.WpfRibbon.CrumbBarItemView);
					num = (short)1704591360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (itemsControl is global::DevComponents.WpfRibbon.CrumbBarItemsControl)
					{
						num = (short)102105091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_275;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 6:
					num = (short)396492801;
					if (num != 0)
					{
					}
					if (itemsControl != null)
					{
						num = (short)1593114631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_275;
				case 7:
					num = (short)427622408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (itemsControl is global::DevComponents.WpfRibbon.CrumbBarItem)
					{
						num = (short)2040922114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)597557252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_6B;
				case 10:
					goto IL_AF;
				case 11:
					goto IL_F5;
				}
				IL_54:
				if (current == null)
				{
					num = (short)891551753;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2137980929;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_6B:
			return null;
			IL_AF:
			return crumbBarItemView.CrumbBarItem;
			IL_F5:
			return (global::DevComponents.WpfRibbon.CrumbBarItem)current.Parent;
			IL_142:
			return ((global::DevComponents.WpfRibbon.CrumbBarItemsControl)itemsControl).ParentViewItem.CrumbBarItem;
			IL_270:
			return (global::DevComponents.WpfRibbon.CrumbBarItem)itemsControl;
			IL_275:
			return null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0004347C File Offset: 0x0004167C
		private global::DevComponents.WpfRibbon.CrumbBarItemView GetViewItem(global::DevComponents.WpfRibbon.CrumbBarItem current)
		{
			short num = (short)1782054912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::DevComponents.WpfRibbon.CrumbBarViewPanel viewPanel;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.List<global::System.Windows.UIElement>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2139095046;
							num2 = (int)((global::System.IntPtr)num);
							global::DevComponents.WpfRibbon.CrumbBarItemView result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_22B;
								case 1:
								{
									global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView;
									if (crumbBarItemView != null)
									{
										num = (short)1723138055;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)497352704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1CF;
								case 4:
								{
									global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView;
									if (crumbBarItemView.CrumbBarItem == current)
									{
										num = (short)1950547973;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView;
									result = crumbBarItemView;
									goto IL_1B6;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_EA;
									}
									continue;
								case 7:
									num = (short)1535115268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									if (enumerator.MoveNext())
									{
										global::DevComponents.WpfRibbon.CrumbBarItemView crumbBarItemView = enumerator.Current as global::DevComponents.WpfRibbon.CrumbBarItemView;
										num = (short)1913716737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1108817059;
									short num3 = num;
									num = (short)550515875;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1B6;
									default:
										num = (short)2122121216;
										if (num != 0)
										{
										}
										num = (short)381157378;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_12C:
								num = (short)1156710408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EA:
								goto IL_12C;
								IL_1B6:
								num = (short)2105999363;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1CF:
							return result;
							IL_22B:
							goto IL_28D;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_23B;
					case 1:
						if (viewPanel != null)
						{
							num = (short)128909314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28D;
					case 2:
						num = (short)1509097473;
						if (num != 0)
						{
						}
						goto IL_23B;
					}
					goto IL_3B;
					IL_23B:
					enumerator = viewPanel.GeneratedChildren.GetEnumerator();
					num = (short)1754267648;
					short num4 = num;
					num = (short)135659520;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_28D:
				return this.CreateView(current);
				IL_3B:
				viewPanel = this._ViewPanel;
				num = (short)197787649;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0004373C File Offset: 0x0004193C
		internal global::DevComponents.WpfRibbon.CrumbBarViewOverflowPanel OverflowPanel
		{
			get
			{
				short num = (short)1323065865;
				short num2 = num;
				num = (short)223240713;
				switch (num2 == num)
				{
				}
				num = (short)1091764224;
				short num3 = num;
				num = (short)312999937;
				if (num != 0)
				{
				}
				num = (short)110886912;
				if (num != 0)
				{
				}
				return this._ViewOverflowPanel;
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000437F0 File Offset: 0x000419F0
		internal void SetOpenedViewItem(global::DevComponents.WpfRibbon.CrumbBarItemView item)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.CrumbBarItemView openItem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1522466830;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (openItem != item)
					{
						num2 = (short)808779778;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_292;
				case 2:
				{
					openItem.ClosePopup();
					num2 = (short)1859256321;
					if (num2 != 0)
					{
					}
					num2 = (short)1367452048;
					short num3 = num2;
					num2 = (short)1939188112;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)28639232;
						if (num2 != 0)
						{
						}
						num2 = (short)246743049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
				{
					this._OverflowPopup.IsOpen = false;
					num2 = (short)1648230400;
					short num4 = num2;
					num2 = (short)1796603910;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					return;
				case 5:
					if (item != null)
					{
						num2 = (short)268435456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_210;
				case 6:
					goto IL_210;
				case 7:
					if (this._OpenItem != null)
					{
						num2 = (short)57671691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					num2 = (short)2119303169;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_292;
				case 10:
					num2 = (short)100728844;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					this.IsMenuMode = true;
					num2 = (short)445120516;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (this._OverflowPopup.IsOpen)
					{
						num2 = (short)1166802947;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_210;
				case 13:
					if (openItem != null)
					{
						num2 = (short)789839880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_292;
				case 14:
					if (this._OverflowPopup != null)
					{
						num2 = (short)1347944458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_210;
				}
				goto IL_4C;
				IL_210:
				this._OpenItem = item;
				num2 = (short)2047082503;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_292:
				num2 = (short)2039087109;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_4C:
			openItem = this._OpenItem;
			num2 = (short)52166669;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00043AC8 File Offset: 0x00041CC8
		internal void ViewItemClosed(global::DevComponents.WpfRibbon.CrumbBarItemView item)
		{
			short num = (short)186974209;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)968949760;
					short num3 = num;
					this._OpenItem = null;
					this.IsMenuMode = false;
					num = (short)1853816834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					num = (short)1762209699;
					short num4 = num;
					num = (short)1715613603;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1600192513;
						if (num != 0)
						{
						}
						num = (short)1015808000;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				IL_A2:
				if (item != this._OpenItem)
				{
					break;
				}
				num = (short)1331167232;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00043BE8 File Offset: 0x00041DE8
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00043C98 File Offset: 0x00041E98
		internal bool IsMenuMode
		{
			get
			{
				short num = (short)324536862;
				short num2 = num;
				num = (short)1091373598;
				switch (num2 == num)
				{
				}
				num = (short)1339228160;
				short num3 = num;
				num = (short)914685953;
				if (num != 0)
				{
				}
				num = (short)343474176;
				if (num != 0)
				{
				}
				return this._IsMenuMode;
			}
			set
			{
				short num = (short)1135345679;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1223884800;
						short num3 = num;
						base.ReleaseMouseCapture();
						num = (short)393281539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						if (!this._IsMenuMode)
						{
							num = (short)1180696581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_163;
					case 3:
						goto IL_27C;
					case 4:
						global::System.Windows.Input.Mouse.Capture(this, global::System.Windows.Input.CaptureMode.SubTree);
						num = (short)726401025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1646985230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1673527304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						this._IsMenuMode = value;
						num = (short)1055195138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this._OverflowPopup.IsOpen)
						{
							num = (short)785121293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						goto IL_9B;
					case 10:
					{
						num = (short)816167397;
						short num4 = num;
						num = (short)1923856869;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_163;
						default:
							num = (short)393412608;
							if (num != 0)
							{
							}
							if (this._OverflowPopup != null)
							{
								num = (short)598671366;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 11:
						num = (short)868876289;
						if (num != 0)
						{
						}
						if (!base.IsMouseCaptured)
						{
							num = (short)1413021700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						this.SetOpenedViewItem(null);
						num = (short)1335296009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_251;
					case 14:
						if (base.IsMouseCaptured)
						{
							num = (short)1407516672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27C;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					case 16:
						if (this._OpenItem != null)
						{
							num = (short)1943535628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B;
					}
					IL_69:
					if (this._IsMenuMode != value)
					{
						num = (short)1817051143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_9B:
					num = (short)1443430410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_163:
					num = (short)706805771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27C:
					num = (short)363986960;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_251:
				this._OverflowPopup.IsOpen = false;
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00043FD0 File Offset: 0x000421D0
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)67960835;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9E;
				case 1:
				{
					num = (short)145424384;
					short num3 = num;
					num = (short)841940996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_82;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
				{
					num = (short)150215011;
					short num4 = num;
					num = (short)2107119971;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_82;
					default:
						num = (short)220266497;
						if (num != 0)
						{
						}
						num = (short)604700672;
						if (num != 0)
						{
						}
						if (e.OriginalSource == this)
						{
							num = (short)1590362114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_151;
					}
					break;
				}
				}
				IL_38:
				if (this.IsMenuMode)
				{
					num = (short)312868865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_82:
				this.IsMenuMode = false;
				num = (short)1069481984;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9E:
			IL_151:
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00044138 File Offset: 0x00042338
		protected override void OnPreviewMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1300561937;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (e.ChangedButton != global::System.Windows.Input.MouseButton.Left)
					{
						num = (short)2035154951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_317;
				case 1:
					goto IL_2A5;
				case 2:
					if (this.IsMenuMode)
					{
						num = (short)198049796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				case 3:
					if (e.ChangedButton == global::System.Windows.Input.MouseButton.Right)
					{
						num = (short)1550974989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				case 4:
				{
					global::System.Windows.FrameworkElement frameworkElement = e.OriginalSource as global::System.Windows.FrameworkElement;
					num = (short)1082785793;
					if (num != 0)
					{
					}
					num = (short)1538392082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_233;
				case 6:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					if (frameworkElement.TemplatedParent != this)
					{
						num = (short)1374224399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_233;
				}
				case 7:
					num = (short)356843523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					if (frameworkElement != this)
					{
						num = (short)1741160464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_233;
				}
				case 9:
					num = (short)166658048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)1570766859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					if (global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsChildOf(this, frameworkElement))
					{
						num = (short)1656029189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				}
				case 12:
				{
					num = (short)1508114432;
					short num3 = num;
					global::System.Windows.FrameworkElement frameworkElement;
					if (!(frameworkElement.TemplatedParent is global::DevComponents.WpfRibbon.CrumbBar))
					{
						num = (short)200146954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_233;
				}
				case 13:
					goto IL_317;
				case 14:
					num = (short)40828936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)702349324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)420478982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 18:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					if (frameworkElement != null)
					{
						num = (short)828440590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				}
				}
				IL_70:
				if (!e.Handled)
				{
					num = (short)1369178121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_233:
				num = (short)2052389977;
				short num4 = num;
				num = (short)1870986329;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2A5;
				default:
					num = (short)111214592;
					if (num != 0)
					{
					}
					this.IsMenuMode = false;
					e.Handled = true;
					num = (short)86966273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_317:
				num = (short)50069506;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2A5:
			IL_353:
			base.OnPreviewMouseDown(e);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000444A0 File Offset: 0x000426A0
		private void ActionItemsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1194000384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)458752023;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.SetValue(global::DevComponents.WpfRibbon.CrumbBar.HasActionItemsPropertyKey, false);
						num = (short)1136001043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1642463235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
						{
							num = (short)507117589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_753;
					case 3:
						if (e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
						{
							num = (short)2098462733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39F;
					case 4:
						try
						{
							num = (short)1047199747;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)515375108;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object child = enumerator.Current;
									base.AddLogicalChild(child);
									num = (short)1733296129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_511;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_49B;
									}
									continue;
								case 4:
									num = (short)481427458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4C4:
								num = (short)195428352;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_49B:
								goto IL_4C4;
							}
							IL_511:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_533;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_520:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)55574530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)1218912865;
									short num3 = num;
									num = (short)705110625;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1533083648;
										if (num != 0)
										{
										}
										if (disposable == null)
										{
											goto IL_5DC;
										}
										break;
									}
									num = (short)1037434880;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_5DA;
								}
								goto IL_533;
							}
							IL_5DA:
							IL_5DC:
							goto EndFinally_24;
							IL_533:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1094320129;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_520;
							EndFinally_24:;
						}
						goto IL_5DD;
					case 5:
						num = (short)1238368257;
						if (num != 0)
						{
						}
						try
						{
							num = (short)2042691587;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1915158530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)915079168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object child2 = enumerator.Current;
									base.RemoveLogicalChild(child2);
									num = (short)869793796;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_180;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_10B;
									}
									continue;
								}
								IL_10D:
								num = (short)759037953;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10B:
								goto IL_10D;
							}
							IL_180:
							goto IL_35D;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1A2;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_18F:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1252982786;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)11927552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1FC;
								case 2:
									goto IL_1FA;
								}
								goto IL_1A2;
							}
							IL_1FA:
							IL_1FC:
							goto EndFinally_23;
							IL_1A2:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1258160129;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_18F;
							EndFinally_23:;
						}
						goto Block_3;
					case 6:
						if (e.OldItems != null)
						{
							num = (short)624361481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35D;
					case 7:
						goto IL_1FD;
					case 8:
						if (!this.HasActionItems)
						{
							num = (short)2056912906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_753;
					case 9:
					{
						global::System.Collections.IEnumerator enumerator = e.OldItems.GetEnumerator();
						num = (short)1757872133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						base.SetValue(global::DevComponents.WpfRibbon.CrumbBar.HasActionItemsPropertyKey, true);
						num = (short)1295319057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.ActionItems.Count > 0)
						{
							num = (short)217251852;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_753;
					case 12:
						num = (short)525074440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1149239298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_5DD;
					case 15:
						if (this.HasActionItems)
						{
							num = (short)1646788608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CF;
					case 16:
					{
						global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator();
						num = (short)1602289668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_753;
					case 18:
						if (e.NewItems != null)
						{
							num = (short)369885200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 19:
						goto IL_753;
					case 20:
						goto IL_31B;
					case 21:
						goto IL_39F;
					case 22:
						if (this.ActionItems.Count == 0)
						{
							num = (short)1849819156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CF;
					case 23:
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					case 24:
						if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
						{
							num = (short)1496645646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1891237894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A9:
					if (e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						num = (short)1651703809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39F;
					IL_31B:
					num = (short)1231355919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					global::System.Collections.Generic.IEnumerator<object> enumerator2;
					try
					{
						IL_1FD:
						num = (short)865468419;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1933443076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object child3 = enumerator2.Current;
								base.AddLogicalChild(child3);
								num = (short)774176769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_2AC;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_238;
								}
								continue;
							case 4:
								num = (short)1388838914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_25F:
							num = (short)510918656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_238:
							goto IL_25F;
						}
						IL_2AC:
						break;
					}
					finally
					{
						num = (short)518193153;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator2.Dispose();
								num = (short)629997570;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2E3;
								}
								continue;
							case 2:
								goto IL_318;
							}
							IL_2E3:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)478871552;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_318:;
					}
					goto IL_31B;
					IL_35D:
					num = (short)1105199122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39F:
					num = (short)1702821888;
					short num4 = num;
					num = (short)28114966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5DD:
					enumerator2 = this.ActionItems.GetEnumerator();
					num = (short)846987271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CF:
					num = (short)666042379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_753:
					num = (short)1538457624;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00044CEC File Offset: 0x00042EEC
		private static global::System.Windows.ResourceDictionary GetColorTable(global::DevComponents.WpfRibbon.eCrumbBarVisualStyle colorTable)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			global::System.Windows.ResourceDictionary result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					result = new global::DevComponents.WpfRibbon.themes.CrumbBarOffice2007BlueScheme();
					num2 = (short)1753219081;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_EF;
				case 2:
					if (colorTable == global::DevComponents.WpfRibbon.eCrumbBarVisualStyle.Vista)
					{
						num2 = (short)2017132555;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)382271489;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
				{
					num2 = (short)1130033805;
					short num3 = num2;
					num2 = (short)1893200525;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EF;
					default:
						num2 = (short)1826619392;
						if (num2 != 0)
						{
						}
						num2 = (short)1050738689;
						if (num2 != 0)
						{
						}
						result = new global::DevComponents.WpfRibbon.themes.CrumbBarOffice2007BlackScheme();
						num2 = (short)102694915;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					return result;
				case 6:
					result = new global::DevComponents.WpfRibbon.themes.CrumbBarOffice2007SilverScheme();
					num2 = (short)1093795845;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (colorTable == global::DevComponents.WpfRibbon.eCrumbBarVisualStyle.Office2007Blue)
					{
						num2 = (short)2069299200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1725366280;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (colorTable == global::DevComponents.WpfRibbon.eCrumbBarVisualStyle.Office2007Silver)
					{
						num2 = (short)511639558;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_187;
				case 9:
					goto IL_D3;
				case 10:
					return result;
				case 11:
				{
					result = new global::DevComponents.WpfRibbon.themes.CrumbBarVistaScheme();
					num2 = (short)346030080;
					short num4 = num2;
					num2 = (short)1406140426;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_49;
				IL_EF:
				if (colorTable == global::DevComponents.WpfRibbon.eCrumbBarVisualStyle.Office2007Black)
				{
					num2 = (short)557383684;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)1072496647;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_D3:
			return result;
			IL_187:
			throw new global::System.ComponentModel.InvalidEnumArgumentException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⁢੤୦٨ᥪ䵬᭮ၰᅲᥴቶ奸ᕺቼ୾ꆀꦈ力ﺐﮔﺖﺚ列", a_));
			IL_49:
			result = null;
			num2 = (short)171311106;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00044F5C File Offset: 0x0004315C
		private static global::System.Windows.ResourceDictionary CreateColorScheme(global::System.Windows.ResourceDictionary rd, global::System.Windows.Media.Color baseColor)
		{
			short num = (short)1408630784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::DevComponents.WpfRibbon.ColorFactory colorFactory = global::DevComponents.WpfRibbon.CrumbBar.GetColorFactory(baseColor);
				global::System.Collections.IEnumerator enumerator = rd.Keys.GetEnumerator();
				try
				{
					num = (short)2125135879;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						object obj;
						object obj2;
						switch (num2)
						{
						case 0:
							if (obj is global::System.Windows.ComponentResourceKey)
							{
								num = (short)1074987020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A3;
						case 1:
							try
							{
								num = (short)1005977604;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1121386497;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1AC;
									case 3:
									{
										global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)255197184;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Media.GradientStop gradientStop = enumerator2.Current;
										gradientStop.Color = colorFactory.GetColor(gradientStop.Color);
										num = (short)1605173250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_125;
										}
										continue;
									}
									IL_15B:
									num = (short)1260191747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_125:
									goto IL_15B;
								}
								IL_1AC:
								break;
							}
							finally
							{
								global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_1BF;
						case 2:
							if (obj2 is global::System.Windows.Media.RadialGradientBrush)
							{
								num = (short)980484107;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
							num = (short)1288110081;
							if (num != 0)
							{
							}
							try
							{
								num = (short)2078932996;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
										goto IL_3A5;
									case 2:
									{
										global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											goto IL_2F1;
										}
										global::System.Windows.Media.GradientStop gradientStop2 = enumerator2.Current;
										gradientStop2.Color = colorFactory.GetColor(gradientStop2.Color);
										num = (short)972226560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										num = (short)276918275;
										short num3 = num;
										num = (short)914059267;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_2F1;
										default:
											num = (short)292683776;
											if (num != 0)
											{
											}
											num = (short)1743716353;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_2CF;
										}
										continue;
									}
									IL_2D1:
									num = (short)869728258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2CF:
									goto IL_2D1;
									IL_2F1:
									num = (short)1506017283;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3A5:
								break;
							}
							finally
							{
								global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_3B8;
						case 4:
							if (obj2 is global::System.Windows.Media.SolidColorBrush)
							{
								num = (short)1874198544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1156513807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)93388808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_9E;
							}
							continue;
						case 8:
							goto IL_515;
						case 9:
						{
							global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2 = (obj2 as global::System.Windows.Media.LinearGradientBrush).GradientStops.GetEnumerator();
							num = (short)1284702211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_A3;
						case 11:
						{
							global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2 = (obj2 as global::System.Windows.Media.RadialGradientBrush).GradientStops.GetEnumerator();
							num = (short)1117585409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							goto IL_1BF;
						case 13:
							if (!(obj as global::System.Windows.ComponentResourceKey).ResourceId.ToString().StartsWith(global::DevComponents.WpfRibbon.CrumbBarColors.ButtonClass))
							{
								num = (short)1404370954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 14:
							if (!enumerator.MoveNext())
							{
								num = (short)1160577030;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							obj = enumerator.Current;
							obj2 = null;
							num = (short)891355136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (obj2 is global::System.Windows.Media.LinearGradientBrush)
							{
								num = (short)712507401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)35323906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							goto IL_3B8;
						}
						goto IL_9E;
						IL_A3:
						obj2 = rd[obj];
						num = (short)1006960644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BF:
						num = (short)368771085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_254:
						num = (short)80871438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9E:
						goto IL_254;
						IL_3B8:
						global::System.Windows.Media.SolidColorBrush solidColorBrush = obj2 as global::System.Windows.Media.SolidColorBrush;
						solidColorBrush.Color = colorFactory.GetColor(solidColorBrush.Color);
						num = (short)1895497733;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_515:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_534;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_521:
						switch (num2)
						{
						case 0:
							goto IL_588;
						case 1:
							disposable.Dispose();
							num = (short)404553728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (disposable != null)
							{
								num = (short)1782841345;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_58A;
						}
						goto IL_534;
					}
					IL_588:
					IL_58A:
					goto EndFinally_17;
					IL_534:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1316814850;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_521;
					EndFinally_17:;
				}
				num = (short)1442447360;
				short num4 = num;
				return rd;
			}
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0004556C File Offset: 0x0004376C
		private static global::DevComponents.WpfRibbon.ColorFactory GetColorFactory(global::System.Windows.Media.Color baseColor)
		{
			short num = (short)1034984543;
			short num2 = num;
			num = (short)1454939231;
			switch (num2 == num)
			{
			}
			num = (short)1003683840;
			if (num != 0)
			{
			}
			num = (short)756482048;
			short num3 = num;
			num = (short)1715601409;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfRibbon.ColorBlendFactory(baseColor);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00045618 File Offset: 0x00043818
		public void ChangeColorScheme(global::DevComponents.WpfRibbon.eCrumbBarVisualStyle colorTable)
		{
			if (global::System.Windows.Application.Current == null)
			{
				short num = (short)1488248272;
				short num2 = num;
				num = (short)1641930192;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)893059072;
					short num3 = num;
					num = (short)1597702145;
					if (num != 0)
					{
					}
					num = (short)543555584;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			global::System.Windows.ResourceDictionary colorTable2 = global::DevComponents.WpfRibbon.CrumbBar.GetColorTable(colorTable);
			this.MergeDictionary(colorTable2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000456DC File Offset: 0x000438DC
		public void ChangeColorScheme(global::DevComponents.WpfRibbon.eCrumbBarVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor)
		{
			if (global::System.Windows.Application.Current == null)
			{
				short num = (short)1264825892;
				short num2 = num;
				num = (short)1313191460;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2104688640;
					short num3 = num;
					num = (short)1976762369;
					if (num != 0)
					{
					}
					num = (short)1780088832;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			global::System.Windows.ResourceDictionary rd = global::DevComponents.WpfRibbon.CrumbBar.CreateColorScheme(baseColorTable, baseColor);
			this.MergeDictionary(rd);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000457A4 File Offset: 0x000439A4
		public static global::System.Windows.ResourceDictionary CreateColorScheme(global::DevComponents.WpfRibbon.eCrumbBarVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor)
		{
			short num = (short)838723879;
			short num2 = num;
			num = (short)1256712487;
			switch (num2 == num)
			{
			}
			num = (short)539688960;
			if (num != 0)
			{
			}
			num = (short)1202847744;
			short num3 = num;
			num = (short)1445265409;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.CrumbBar.CreateColorScheme(global::DevComponents.WpfRibbon.CrumbBar.GetColorTable(baseColorTable), baseColor);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0004585C File Offset: 0x00043A5C
		private void MergeDictionary(global::System.Windows.ResourceDictionary rd)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.ResourceDictionary resourceDictionary;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::System.Windows.ResourceDictionary> enumerator;
				switch (num)
				{
				case 0:
					goto IL_30E;
				case 1:
					goto IL_30E;
				case 2:
					resourceDictionary = base.Resources;
					num2 = (short)905838592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					try
					{
						num2 = (short)1896087555;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							global::System.Windows.ResourceDictionary resourceDictionary2;
							switch (num)
							{
							case 0:
								num2 = (short)472973319;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								if (!(resourceDictionary2 is global::DevComponents.WpfRibbon.themes.CrumbBarVistaScheme))
								{
									num2 = (short)2028077061;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_E0;
							case 2:
								num2 = (short)2017329161;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_DE;
								}
								continue;
							case 4:
								goto IL_101;
							case 5:
								num2 = (short)1023344648;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
								goto IL_E0;
							case 7:
								if (!(resourceDictionary2 is global::DevComponents.WpfRibbon.themes.CrumbBarOffice2007BlueScheme))
								{
									num2 = (short)1428094986;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_E0;
							case 8:
								if (!(resourceDictionary2 is global::DevComponents.WpfRibbon.themes.CrumbBarOffice2007BlackScheme))
								{
									num2 = (short)364445696;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_E0;
							case 9:
								goto IL_251;
							case 10:
								num2 = (short)1087045643;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 11:
								if (resourceDictionary2 is global::DevComponents.WpfRibbon.themes.CrumbBarOffice2007SilverScheme)
								{
									num2 = (short)605880326;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 12:
								if (!enumerator.MoveNext())
								{
									num2 = (short)662503426;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								resourceDictionary2 = enumerator.Current;
								num2 = (short)753008641;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_DE;
							IL_E0:
							resourceDictionary.MergedDictionaries.Remove(resourceDictionary2);
							num2 = (short)81330180;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_106:
							num2 = (short)330629132;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_DE:
							goto IL_106;
						}
						IL_101:
						IL_251:
						goto IL_3A6;
					}
					finally
					{
						for (;;)
						{
							IL_256:
							num2 = (short)293928962;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_30B;
								case 1:
								{
									num2 = (short)668716577;
									short num3 = num2;
									num2 = (short)624217633;
									switch ((num3 == num2) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_256;
									default:
										num2 = (short)2006712320;
										if (num2 != 0)
										{
										}
										enumerator.Dispose();
										num2 = (short)1360658432;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_288;
									}
									continue;
								}
								IL_288:
								if (enumerator == null)
								{
									goto IL_30D;
								}
								num2 = (short)1315438593;
								num = (int)((global::System.IntPtr)num2);
							}
						}
						IL_30B:
						IL_30D:;
					}
					goto IL_30E;
				case 4:
				{
					if (global::System.Windows.Application.Current == null)
					{
						num2 = (short)1505427458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1972764672;
					short num4 = num2;
					resourceDictionary = global::System.Windows.Application.Current.Resources;
					num2 = (short)103350273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
				IL_30E:
				enumerator = resourceDictionary.MergedDictionaries.GetEnumerator();
				num2 = (short)2143354883;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_3A6:
			resourceDictionary.MergedDictionaries.Add(rd);
			return;
			IL_24:
			resourceDictionary = null;
			num2 = (short)1928658945;
			if (num2 != 0)
			{
			}
			num2 = (short)1246363652;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000F3 RID: 243
		public static readonly global::System.Windows.DependencyProperty SelectedItemProperty;

		// Token: 0x040000F4 RID: 244
		public static readonly global::System.Windows.DependencyProperty SelectedImageProperty;

		// Token: 0x040000F5 RID: 245
		public static readonly global::System.Windows.DependencyProperty HasOverflowItemsProperty;

		// Token: 0x040000F6 RID: 246
		public static readonly global::System.Windows.DependencyProperty IsOverflowOpenProperty;

		// Token: 0x040000F7 RID: 247
		private static readonly global::System.Windows.DependencyPropertyKey ActionItemsPropertyKey;

		// Token: 0x040000F8 RID: 248
		public static readonly global::System.Windows.DependencyProperty ActionItemsProperty;

		// Token: 0x040000F9 RID: 249
		private static readonly global::System.Windows.DependencyPropertyKey HasActionItemsPropertyKey;

		// Token: 0x040000FA RID: 250
		public static readonly global::System.Windows.DependencyProperty HasActionItemsProperty;

		// Token: 0x040000FB RID: 251
		public static readonly global::System.Windows.DependencyProperty ActionItemTemplateProperty;

		// Token: 0x040000FC RID: 252
		public static readonly global::System.Windows.DependencyProperty ActionItemTemplateSelectorProperty;

		// Token: 0x040000FF RID: 255
		private global::DevComponents.WpfRibbon.CrumbBarViewOverflowPanel _ViewOverflowPanel;

		// Token: 0x04000100 RID: 256
		private global::DevComponents.WpfRibbon.CrumbBarViewPanel _ViewPanel;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Controls.Primitives.Popup _OverflowPopup;

		// Token: 0x04000102 RID: 258
		private global::DevComponents.WpfRibbon.CrumbBarItem _SelectedContainer;

		// Token: 0x04000103 RID: 259
		private global::DevComponents.WpfRibbon.CrumbBarItemView _OpenItem;

		// Token: 0x04000104 RID: 260
		private bool _IsMenuMode;
	}
}
