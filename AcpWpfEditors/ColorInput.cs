using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x0200000D RID: 13
	[global::System.ComponentModel.DefaultEvent("ValueChanged")]
	[global::System.ComponentModel.DesignTimeVisible(true)]
	public class ColorInput : global::DevComponents.WpfEditors.InputBaseControl
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00009FC4 File Offset: 0x000081C4
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.ColorInput colorInput;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					colorInput.OnShowDropDownChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num2 = (short)867165743;
					short num3 = num2;
					num2 = (short)954000943;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)692912128;
						if (num2 != 0)
						{
						}
						num2 = (short)1126957057;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					if (colorInput != null)
					{
						num2 = (short)766771200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1270218753;
			if (num2 != 0)
			{
			}
			num2 = (short)2074542080;
			short num4 = num2;
			colorInput = (A_0 as global::DevComponents.WpfEditors.ColorInput);
			num2 = (short)1233715202;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000A0FC File Offset: 0x000082FC
		protected virtual void OnShowDropDownChanged(bool oldValue, bool newValue)
		{
			short num = (short)1298661377;
			if (num != 0)
			{
			}
			num = (short)77475887;
			short num2 = num;
			num = (short)1052913711;
			switch (num2 == num)
			{
			}
			num = (short)130482176;
			short num3 = num;
			num = (short)530972672;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000A1AC File Offset: 0x000083AC
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000A264 File Offset: 0x00008464
		public bool ShowDropDown
		{
			get
			{
				short num = (short)47855081;
				short num2 = num;
				num = (short)1875195369;
				switch (num2 == num)
				{
				}
				num = (short)1196818433;
				if (num != 0)
				{
				}
				num = (short)925368320;
				short num3 = num;
				num = (short)1424621568;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.ColorInput.ShowDropDownProperty);
			}
			set
			{
				short num = (short)272469007;
				short num2 = num;
				num = (short)335318031;
				switch (num2 == num)
				{
				}
				num = (short)1717698561;
				if (num != 0)
				{
				}
				num = (short)140050432;
				short num3 = num;
				num = (short)1156251648;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorInput.ShowDropDownProperty, value);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000A320 File Offset: 0x00008520
		private static object a(global::System.Windows.DependencyObject A_0, object A_1)
		{
			global::DevComponents.WpfEditors.ColorInput colorInput = A_0 as global::DevComponents.WpfEditors.ColorInput;
			if (colorInput != null)
			{
				short num;
				for (;;)
				{
					num = (short)773652480;
					short num2 = num;
					num = (short)1615919071;
					short num3 = num;
					num = (short)890107871;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6D;
					}
				}
				IL_6D:
				num = (short)1306001409;
				if (num != 0)
				{
				}
				num = (short)877461504;
				if (num != 0)
				{
				}
				return colorInput.OnCoerceValue((global::System.Windows.Media.Color?)A_1);
			}
			return A_1;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000A3EC File Offset: 0x000085EC
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.ColorInput colorInput;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					colorInput.OnValueChanged((global::System.Windows.Media.Color?)A_1.OldValue, (global::System.Windows.Media.Color?)A_1.NewValue);
					num2 = (short)403155460;
					short num3 = num2;
					num2 = (short)1533913604;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)661913600;
						if (num2 != 0)
						{
						}
						num2 = (short)529858561;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					num2 = (short)1406926849;
					if (num2 != 0)
					{
					}
					if (colorInput != null)
					{
						num2 = (short)1863974912;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			colorInput = (A_0 as global::DevComponents.WpfEditors.ColorInput);
			num2 = (short)1228079104;
			short num4 = num2;
			num2 = (short)1835466754;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000A524 File Offset: 0x00008724
		protected virtual global::System.Windows.Media.Color? OnCoerceValue(global::System.Windows.Media.Color? value)
		{
			short num = (short)875541562;
			short num2 = num;
			num = (short)1240249402;
			switch (num2 == num)
			{
			}
			num = (short)1312817153;
			if (num != 0)
			{
			}
			num = (short)1014956032;
			short num3 = num;
			num = (short)949616640;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000A5D0 File Offset: 0x000087D0
		protected virtual void OnValueChanged(global::System.Windows.Media.Color? oldValue, global::System.Windows.Media.Color? newValue)
		{
			short num = (short)252100229;
			short num2 = num;
			num = (short)553565829;
			switch (num2 == num)
			{
			}
			num = (short)1133969409;
			if (num != 0)
			{
			}
			num = (short)1024786432;
			short num3 = num;
			num = (short)1212874752;
			if (num != 0)
			{
			}
			this.OnValueChanged();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000A680 File Offset: 0x00008880
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000A738 File Offset: 0x00008938
		public global::System.Windows.Media.Color? Value
		{
			get
			{
				short num = (short)2022920649;
				short num2 = num;
				num = (short)235426249;
				switch (num2 == num)
				{
				}
				num = (short)142016513;
				if (num != 0)
				{
				}
				num = (short)1205207040;
				short num3 = num;
				num = (short)1808990208;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Color?)base.GetValue(global::DevComponents.WpfEditors.ColorInput.ValueProperty);
			}
			set
			{
				short num = (short)2025135960;
				short num2 = num;
				num = (short)811081560;
				switch (num2 == num)
				{
				}
				num = (short)166985729;
				if (num != 0)
				{
				}
				num = (short)942080000;
				short num3 = num;
				num = (short)1144389632;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorInput.ValueProperty, value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000A7F0 File Offset: 0x000089F0
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		public bool EditColorAlphaComponent
		{
			get
			{
				short num = (short)375083922;
				short num2 = num;
				num = (short)553800594;
				switch (num2 == num)
				{
				}
				num = (short)616562689;
				if (num != 0)
				{
				}
				num = (short)1394475008;
				short num3 = num;
				num = (short)1874460672;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.ColorInput.EditColorAlphaComponentProperty);
			}
			set
			{
				short num = (short)806395485;
				short num2 = num;
				num = (short)1312071261;
				switch (num2 == num)
				{
				}
				num = (short)1116667905;
				if (num != 0)
				{
				}
				num = (short)1079640064;
				short num3 = num;
				num = (short)571408384;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorInput.EditColorAlphaComponentProperty, value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000A964 File Offset: 0x00008B64
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000AA20 File Offset: 0x00008C20
		public global::System.Windows.Visibility MoreColorsButtonVisibility
		{
			get
			{
				short num = (short)67781833;
				short num2 = num;
				num = (short)1021723849;
				switch (num2 == num)
				{
				}
				num = (short)2072576001;
				if (num != 0)
				{
				}
				num = (short)532021248;
				short num3 = num;
				num = (short)1456799744;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.ColorInput.MoreColorsButtonVisibilityProperty);
			}
			set
			{
				short num = (short)575106584;
				short num2 = num;
				num = (short)159673880;
				switch (num2 == num)
				{
				}
				num = (short)964689920;
				if (num != 0)
				{
				}
				num = (short)1401487360;
				short num3 = num;
				num = (short)1937178625;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorInput.MoreColorsButtonVisibilityProperty, value);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600006A RID: 106 RVA: 0x0000AADC File Offset: 0x00008CDC
		// (remove) Token: 0x0600006B RID: 107 RVA: 0x0000AB94 File Offset: 0x00008D94
		public event global::System.Windows.RoutedEventHandler ValueChanged
		{
			add
			{
				short num = (short)713253516;
				short num2 = num;
				num = (short)735142540;
				switch (num2 == num)
				{
				}
				num = (short)60620800;
				if (num != 0)
				{
				}
				num = (short)17563648;
				short num3 = num;
				num = (short)1246167041;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.ColorInput.ValueChangedEvent, value);
			}
			remove
			{
				short num = (short)1630653969;
				short num2 = num;
				num = (short)636079633;
				switch (num2 == num)
				{
				}
				num = (short)538836993;
				if (num != 0)
				{
				}
				num = (short)1325989888;
				short num3 = num;
				num = (short)1513619456;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.ColorInput.ValueChangedEvent, value);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000AC48 File Offset: 0x00008E48
		protected virtual void OnValueChanged()
		{
			short num = (short)703290014;
			short num2 = num;
			num = (short)857365150;
			switch (num2 == num)
			{
			}
			num = (short)818806785;
			if (num != 0)
			{
			}
			num = (short)1420427264;
			short num3 = num;
			num = (short)874643456;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.ColorInput.ValueChangedEvent);
			base.RaiseEvent(e);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000AD04 File Offset: 0x00008F04
		static ColorInput()
		{
			int a_ = 11;
			short num = (short)668133985;
			short num2 = num;
			num = (short)1938287201;
			switch (num2 == num)
			{
			}
			num = (short)1607925761;
			if (num != 0)
			{
			}
			num = (short)1723596800;
			short num3 = num;
			num = (short)484835328;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.ColorInput.ShowDropDownProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("诗닙돛꧝ꓟ郡诣雥곧藩鯫胭", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.ColorInput), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.ColorInput.b)));
			global::DevComponents.WpfEditors.ColorInput.ValueProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軗믙냛ꯝ藟", a_), typeof(global::System.Windows.Media.Color?), typeof(global::DevComponents.WpfEditors.ColorInput), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.ColorInput.a), new global::System.Windows.CoerceValueCallback(global::DevComponents.WpfEditors.ColorInput.a), false, global::System.Windows.Data.UpdateSourceTrigger.PropertyChanged));
			global::DevComponents.WpfEditors.ColorInput.EditColorAlphaComponentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷗뻙뗛ꫝꏟ跡裣觥髧ꯩ胫黭飯鏱럳駵闷諹鏻都旿氁瀃", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.ColorInput), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfEditors.ColorInput.MoreColorsButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闗뗙껛믝ꏟ跡裣觥髧駩껫鯭蓯蛱鯳飵껷鏹迻韽拿欁栃漅簇猉", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.ColorInput), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::DevComponents.WpfEditors.ColorInput.ValueChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軗믙냛ꯝ藟ꇡ賣蟥蛧跩觫諭", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.ColorInput));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.ColorInput), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.ColorInput)));
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000AF08 File Offset: 0x00009108
		protected override void OnInputGroupAssigned()
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.ColorInputGroup colorInputGroup;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯌껎뷐ꛒ냔", a_));
					binding.Source = this;
					binding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.PropertyChanged;
					binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
					colorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.ColorInputGroup.ColorProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("裌ꯎ룐꟒雔룖뗘듚꿜點跠鏢跤蛦ꫨ蓪胬鿮黰鷲郴駶跸", a_));
					binding.Source = this;
					binding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.PropertyChanged;
					binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
					colorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.ColorInputGroup.EditColorAlphaComponentProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蓌볎菐뛒듔돖雘뗚뇜ꛞ", a_));
					binding.Source = this;
					binding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.PropertyChanged;
					binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
					colorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.IsReadOnlyProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髌껎ꗐ뛒꟔뫖룘꧚뛜點跠諢苤触蓨軪菬鯮", a_));
					binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
					binding.Source = this;
					colorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkAlignmentProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髌껎ꗐ뛒꟔뫖룘꧚뛜鷞蓠询蓤釦胨蓪鿬", a_));
					binding.Source = this;
					colorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBehaviorProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髌껎ꗐ뛒꟔뫖룘꧚뛜鷞鏠離雤迦", a_));
					binding.Source = this;
					colorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBrushProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髌껎ꗐ뛒꟔뫖룘꧚뛜髞迠苢蟤详賨迪", a_));
					binding.Source = this;
					colorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkEnabledProperty, binding);
					binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髌껎ꗐ뛒꟔뫖룘꧚뛜诞蓠鯢釤", a_));
					binding.Source = this;
					colorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkTextProperty, binding);
					num2 = (short)925255843;
					short num3 = num2;
					num2 = (short)463292579;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2058223616;
						if (num2 != 0)
						{
						}
						num2 = (short)1109983233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					if (colorInputGroup != null)
					{
						num2 = (short)334364673;
						if (num2 != 0)
						{
						}
						num2 = (short)1293549568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_25;
			}
			return;
			IL_25:
			base.OnInputGroupAssigned();
			this.a();
			colorInputGroup = (this.GetInputGroup() as global::DevComponents.WpfEditors.Primitives.ColorInputGroup);
			num2 = (short)1918238720;
			short num4 = num2;
			num2 = (short)692518914;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000B1B0 File Offset: 0x000093B0
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (this.a == null)
					{
						goto IL_27A;
					}
					num2 = (short)1015801130;
					short num3 = num2;
					num2 = (short)1367205162;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25D;
					default:
						num2 = (short)1393229824;
						if (num2 != 0)
						{
						}
						num2 = (short)288882694;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (this.ShowDropDown)
					{
						num2 = (short)2013331463;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2121138176;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					this.a = new global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton();
					this.a.Focusable = false;
					this.a.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
					this.a.SelectedColorChanged += this.a;
					num2 = (short)505020417;
					if (num2 != 0)
					{
					}
					num2 = (short)904069123;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_FE;
				case 4:
					goto IL_1A9;
				case 5:
					if (this.a == null)
					{
						goto IL_25D;
					}
					goto IL_73;
				case 6:
					inputGroup.Items.Remove(this.a);
					this.a.SelectedColorChanged -= this.a;
					num2 = (short)515309572;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)172032005;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return;
				case 9:
					if (inputGroup == null)
					{
						num2 = (short)1286930440;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1072365569;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_25D:
				num2 = (short)226557954;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_73:
			inputGroup.Items.Add(this.a);
			return;
			IL_FE:
			num2 = (short)1971716096;
			short num4 = num2;
			goto IL_73;
			IL_1A9:
			IL_27A:
			this.a = null;
			return;
			IL_38:
			inputGroup = this.GetInputGroup();
			num2 = (short)978255881;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000B440 File Offset: 0x00009640
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)135528449;
			if (num != 0)
			{
			}
			num = (short)1192213677;
			short num2 = num;
			num = (short)1702149293;
			switch (num2 == num)
			{
			}
			num = (short)619249664;
			short num3 = num;
			num = (short)1651179520;
			if (num != 0)
			{
			}
			this.Value = this.a.SelectedColor;
		}

		// Token: 0x0400001A RID: 26
		public static readonly global::System.Windows.DependencyProperty ShowDropDownProperty;

		// Token: 0x0400001B RID: 27
		public static readonly global::System.Windows.DependencyProperty ValueProperty;

		// Token: 0x0400001C RID: 28
		public static readonly global::System.Windows.DependencyProperty EditColorAlphaComponentProperty;

		// Token: 0x0400001D RID: 29
		public static readonly global::System.Windows.DependencyProperty MoreColorsButtonVisibilityProperty;

		// Token: 0x0400001F RID: 31
		private new global::DevComponents.WpfEditors.Primitives.ColorInputDropDownButton a;
	}
}
