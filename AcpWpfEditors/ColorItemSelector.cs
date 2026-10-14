using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000011 RID: 17
	[global::System.ComponentModel.DesignTimeVisible(true)]
	public class ColorItemSelector : global::System.Windows.Controls.Control
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00011DC4 File Offset: 0x0000FFC4
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00011E80 File Offset: 0x00010080
		public global::DevComponents.WpfEditors.ColorItem SelectedColorItem
		{
			get
			{
				short num = (short)1608450049;
				if (num != 0)
				{
				}
				num = (short)1301947212;
				short num2 = num;
				num = (short)752427852;
				switch (num2 == num)
				{
				}
				num = (short)461832192;
				short num3 = num;
				num = (short)1833828352;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.ColorItem)base.GetValue(global::DevComponents.WpfEditors.ColorItemSelector.SelectedColorItemProperty);
			}
			internal set
			{
				short num = (short)2096159533;
				short num2 = num;
				num = (short)1942412077;
				switch (num2 == num)
				{
				}
				num = (short)931332096;
				if (num != 0)
				{
				}
				num = (short)1968832512;
				short num3 = num;
				num = (short)1980235777;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorItemSelector.a, value);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00011F38 File Offset: 0x00010138
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.ColorItemSelector colorItemSelector;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					colorItemSelector.OnSelectedColorItemChanged((global::DevComponents.WpfEditors.ColorItem)A_1.OldValue, (global::DevComponents.WpfEditors.ColorItem)A_1.NewValue);
					num2 = (short)713069050;
					short num3 = num2;
					num2 = (short)1672253946;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1200619520;
						if (num2 != 0)
						{
						}
						num2 = (short)228851713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_101;
				case 2:
					if (colorItemSelector != null)
					{
						num2 = (short)811008000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_101:
			num2 = (short)1994915841;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			colorItemSelector = (A_0 as global::DevComponents.WpfEditors.ColorItemSelector);
			num2 = (short)782368768;
			short num4 = num2;
			num2 = (short)502464514;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00012070 File Offset: 0x00010270
		protected virtual void OnSelectedColorItemChanged(global::DevComponents.WpfEditors.ColorItem oldValue, global::DevComponents.WpfEditors.ColorItem newValue)
		{
			short num = (short)68222982;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Media.Color? selectedColor;
				switch (num2)
				{
				case 0:
					selectedColor = this.SelectedColor;
					num = (short)1297547267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.SelectedColor = new global::System.Windows.Media.Color?(global::System.Windows.Media.Colors.Transparent);
					goto IL_1A0;
				case 2:
					goto IL_18E;
				case 3:
					if (!selectedColor.Equals(newValue.Color))
					{
						num = (short)338821122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					num = (short)1270409387;
					short num3 = num;
					num = (short)1220405419;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A0;
					default:
						num = (short)695336960;
						if (num != 0)
						{
						}
						if (!selectedColor.Equals(global::System.Windows.Media.Colors.Transparent))
						{
							num = (short)37814273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 5:
					goto IL_1B8;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				}
				IL_42:
				if (newValue != null)
				{
					num = (short)1999634432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)79101952;
				short num4 = num;
				selectedColor = this.SelectedColor;
				num = (short)997785604;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A0:
				num = (short)28901381;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_18E:
			this.SelectedColor = new global::System.Windows.Media.Color?(newValue.Color);
			return;
			IL_1B8:
			num = (short)182190081;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00012260 File Offset: 0x00010460
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.ColorItemSelector colorItemSelector;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)193658881;
					if (num2 != 0)
					{
					}
					colorItemSelector.OnSelectedColorChanged((global::System.Windows.Media.Color?)A_1.OldValue, (global::System.Windows.Media.Color?)A_1.NewValue);
					num2 = (short)245467851;
					short num3 = num2;
					num2 = (short)2036959947;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1797193728;
						if (num2 != 0)
						{
						}
						num2 = (short)2075918337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					if (colorItemSelector != null)
					{
						num2 = (short)688259072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			colorItemSelector = (A_0 as global::DevComponents.WpfEditors.ColorItemSelector);
			num2 = (short)1632698368;
			short num4 = num2;
			num2 = (short)442171394;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0001239C File Offset: 0x0001059C
		protected virtual void OnSelectedColorChanged(global::System.Windows.Media.Color? oldValue, global::System.Windows.Media.Color? newValue)
		{
			short num = (short)854614470;
			short num2 = num;
			num = (short)916873670;
			switch (num2 == num)
			{
			}
			num = (short)698417153;
			if (num != 0)
			{
			}
			num = (short)117899264;
			short num3 = num;
			num = (short)374865920;
			if (num != 0)
			{
			}
			this.b();
			this.OnSelectedColorChanged();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00012454 File Offset: 0x00010654
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0001250C File Offset: 0x0001070C
		public global::System.Windows.Media.Color? SelectedColor
		{
			get
			{
				short num = (short)941673125;
				short num2 = num;
				num = (short)1241434789;
				switch (num2 == num)
				{
				}
				num = (short)187891713;
				if (num != 0)
				{
				}
				num = (short)1547567104;
				short num3 = num;
				num = (short)1314783232;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Color?)base.GetValue(global::DevComponents.WpfEditors.ColorItemSelector.SelectedColorProperty);
			}
			set
			{
				short num = (short)1143722927;
				short num2 = num;
				num = (short)1347605423;
				switch (num2 == num)
				{
				}
				num = (short)155844609;
				if (num != 0)
				{
				}
				num = (short)449118208;
				short num3 = num;
				num = (short)137166848;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorItemSelector.SelectedColorProperty, value);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000E4 RID: 228 RVA: 0x000125C8 File Offset: 0x000107C8
		// (remove) Token: 0x060000E5 RID: 229 RVA: 0x0001267C File Offset: 0x0001087C
		public event global::System.Windows.RoutedEventHandler SelectedColorChanged
		{
			add
			{
				short num = (short)1538122228;
				short num2 = num;
				num = (short)1905451508;
				switch (num2 == num)
				{
				}
				num = (short)229965824;
				if (num != 0)
				{
				}
				num = (short)263585792;
				short num3 = num;
				num = (short)2139422721;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.ColorItemSelector.SelectedColorChangedEvent, value);
			}
			remove
			{
				short num = (short)692781057;
				if (num != 0)
				{
				}
				num = (short)1368972406;
				short num2 = num;
				num = (short)117038198;
				switch (num2 == num)
				{
				}
				num = (short)95289344;
				short num3 = num;
				num = (short)1978073088;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.ColorItemSelector.SelectedColorChangedEvent, value);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00012734 File Offset: 0x00010934
		protected virtual void OnSelectedColorChanged()
		{
			short num = (short)441006547;
			short num2 = num;
			num = (short)1576745427;
			switch (num2 == num)
			{
			}
			num = (short)1576140801;
			if (num != 0)
			{
			}
			num = (short)971177984;
			short num3 = num;
			num = (short)895483904;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.ColorItemSelector.SelectedColorChangedEvent);
			base.RaiseEvent(routedEventArgs);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000127F4 File Offset: 0x000109F4
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000128B0 File Offset: 0x00010AB0
		public global::System.Windows.Visibility MoreColorsButtonVisibility
		{
			get
			{
				short num = (short)488767489;
				if (num != 0)
				{
				}
				num = (short)845874473;
				short num2 = num;
				num = (short)425526569;
				switch (num2 == num)
				{
				}
				num = (short)1092550656;
				short num3 = num;
				num = (short)1894711296;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.ColorItemSelector.MoreColorsButtonVisibilityProperty);
			}
			set
			{
				short num = (short)233639084;
				short num2 = num;
				num = (short)179440812;
				switch (num2 == num)
				{
				}
				num = (short)809172993;
				if (num != 0)
				{
				}
				num = (short)376176640;
				short num3 = num;
				num = (short)1280049152;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.ColorItemSelector.MoreColorsButtonVisibilityProperty, value);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0001296C File Offset: 0x00010B6C
		static ColorItemSelector()
		{
			int a_ = 11;
			short num = (short)1489516834;
			short num2 = num;
			num = (short)930691362;
			switch (num2 == num)
			{
			}
			num = (short)1469186048;
			if (num != 0)
			{
			}
			num = (short)157417472;
			short num3 = num;
			num = (short)280100865;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.ColorItemSelector.a = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("诗뿙냛믝菟雡臣若ꯧ藩胫臭苯믱胳鏵闷", a_), typeof(global::DevComponents.WpfEditors.ColorItem), typeof(global::DevComponents.WpfEditors.ColorItemSelector), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.ColorItemSelector.b)));
			global::DevComponents.WpfEditors.ColorItemSelector.SelectedColorItemProperty = global::DevComponents.WpfEditors.ColorItemSelector.a.DependencyProperty;
			global::DevComponents.WpfEditors.ColorItemSelector.SelectedColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("诗뿙냛믝菟雡臣若ꯧ藩胫臭苯", a_), typeof(global::System.Windows.Media.Color?), typeof(global::DevComponents.WpfEditors.ColorItemSelector), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.ColorItemSelector.a)));
			global::DevComponents.WpfEditors.ColorItemSelector.SelectedColorChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("诗뿙냛믝菟雡臣若ꯧ藩胫臭苯뇱鳳韵雷鷹駻髽", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.ColorItemSelector));
			global::DevComponents.WpfEditors.ColorItemSelector.MoreColorsButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闗뗙껛믝ꏟ跡裣觥髧駩껫鯭蓯蛱鯳飵껷鏹迻韽拿欁栃漅簇猉", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.ColorItemSelector), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.ColorItemSelector), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.ColorItemSelector)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.ColorItemSelector), global::System.Windows.Controls.Primitives.Selector.SelectedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.ColorItemSelector.b));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.ColorItemSelector), global::System.Windows.Controls.Primitives.Selector.UnselectedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.ColorItemSelector.a));
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00012B6C File Offset: 0x00010D6C
		public override void OnApplyTemplate()
		{
			int a_ = 15;
			short num = (short)426639366;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Media.Color? selectedColor;
				switch (num2)
				{
				case 0:
				{
					this.d.Click += this.c;
					num = (short)1021771776;
					short num3 = num;
					num = (short)1585577991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (selectedColor != null)
					{
						num = (short)1211760642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27E;
				case 2:
					this.b();
					goto IL_1C7;
				case 3:
					this.d.Click -= this.c;
					num = (short)1132789765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1DE;
				case 5:
					goto IL_1E3;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 7:
					goto IL_EC;
				case 8:
					if (this.d != null)
					{
						num = (short)268369920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC;
				}
				IL_52:
				num = (short)1614551177;
				short num4 = num;
				num = (short)704911497;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1C7:
					num = (short)1794441220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)1200226304;
					if (num != 0)
					{
					}
					num = (short)309067777;
					if (num != 0)
					{
					}
					if (this.d != null)
					{
						num = (short)250019843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E3;
				}
				IL_EC:
				selectedColor = this.SelectedColor;
				num = (short)958529537;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E3:
				this.b = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("賛鿝닟뛡믣ꇥ髧菩裫뫭飯韱駳鏵믷闹郻釽狿焁", a_)) as global::System.Windows.Controls.Grid);
				this.c = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("賛鿝닟뛡믣ꇥ髧菩裫뷭蓯鏱髳鋵駷裹飻뷽濿渁欃琅笇", a_)) as global::System.Windows.Controls.Grid);
				this.d = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("賛鿝닟뛡믣ꯥ蟧飩觫귭鿯黱鯳蓵请룹觻諽瓿洁樃", a_)) as global::System.Windows.Controls.Button);
				num = (short)1632043016;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1DE:
			IL_27E:
			base.OnApplyTemplate();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00012E00 File Offset: 0x00011000
		private void c(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.ColorsDialog colorsDialog;
			global::System.Windows.Media.Color? selectedColor;
			for (;;)
			{
				IL_0A:
				bool? flag;
				switch (num)
				{
				case 0:
					num2 = (short)528678913;
					if (num2 != 0)
					{
					}
					selectedColor = colorsDialog.SelectedColor;
					num2 = (short)1342898178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					this.SelectedColor = colorsDialog.SelectedColor;
					num2 = (short)1303642117;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (selectedColor != null)
					{
						num2 = (short)2137391105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_13C;
				case 4:
				{
					global::DevComponents.WpfEditors.ColorsDialog colorsDialog2 = colorsDialog;
					selectedColor = this.SelectedColor;
					colorsDialog2.CurrentColor = selectedColor.Value;
					num2 = (short)2029125638;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					return;
				case 6:
					goto IL_1F6;
				case 7:
				{
					if (selectedColor == null)
					{
						goto IL_1F6;
					}
					num2 = (short)283246592;
					short num3 = num2;
					num2 = (short)703515684;
					short num4 = num2;
					num2 = (short)642042916;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13C;
					default:
						num2 = (short)1541865472;
						if (num2 != 0)
						{
						}
						num2 = (short)324337668;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 8:
					if (flag.Value)
					{
						num2 = (short)263454720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					if (flag != null)
					{
						num2 = (short)1197670403;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_38;
				IL_13C:
				num2 = (short)893911048;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F6:
				flag = colorsDialog.ShowDialog();
				num2 = (short)571015177;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			colorsDialog = new global::DevComponents.WpfEditors.ColorsDialog();
			selectedColor = this.SelectedColor;
			num2 = (short)18939911;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00013048 File Offset: 0x00011248
		private void b()
		{
			short num = (short)209059840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::System.Windows.Media.Color? selectedColor;
				for (;;)
				{
					IL_27:
					global::System.Windows.Media.Color color;
					global::System.Windows.Media.Color color2;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						color = global::System.Windows.Media.Colors.Transparent;
						goto IL_423;
					case 1:
						if (this.b != null)
						{
							num = (short)1581580304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5;
					case 2:
						goto IL_465;
					case 3:
						num = (short)2095841280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)553254913;
						if (num != 0)
						{
						}
						this.SelectedColorItem.IsSelected = false;
						num = (short)1522925570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.c != null)
						{
							num = (short)1172373514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						if (this.SelectedColorItem != null)
						{
							num = (short)5701645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131;
					case 7:
						color = selectedColor.GetValueOrDefault();
						goto IL_423;
					case 8:
						goto IL_3D2;
					case 9:
						try
						{
							num = (short)1880227846;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_641;
								case 1:
								{
									global::DevComponents.WpfEditors.ColorItem colorItem;
									if (colorItem != null)
									{
										num = (short)1832779778;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)967376900;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									num = (short)158606180;
									short num3 = num;
									num = (short)1969365860;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										goto IL_546;
									}
									break;
								}
								case 4:
								{
									global::DevComponents.WpfEditors.ColorItem colorItem;
									if (colorItem.Color == color2)
									{
										num = (short)1289289736;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1013186560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_4F0;
									}
									continue;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1161691141;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfEditors.ColorItem colorItem = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfEditors.ColorItem;
									num = (short)693829633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::DevComponents.WpfEditors.ColorItem colorItem;
									colorItem.IsSelected = true;
									num = (short)1472397315;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_5A8:
								num = (short)1116078087;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F0:
								goto IL_5A8;
							}
							IL_546:
							num = (short)603586560;
							if (num != 0)
							{
							}
							return;
							IL_641:
							goto IL_C5;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_663;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_650:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1798832129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6BA;
								case 1:
									disposable.Dispose();
									num = (short)1194328066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_6B8;
								}
								goto IL_663;
							}
							IL_6B8:
							IL_6BA:
							goto EndFinally_20;
							IL_663:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)23068672;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_650;
							EndFinally_20:;
						}
						goto IL_6BB;
					case 10:
					{
						num = (short)1004077056;
						short num4 = num;
						enumerator = this.c.Children.GetEnumerator();
						num = (short)1891827724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (this.SelectedColorItem != null)
						{
							num = (short)1348075524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_465;
					case 12:
						try
						{
							num = (short)2137849862;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2C8;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2070806530;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfEditors.ColorItem colorItem2 = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfEditors.ColorItem;
									num = (short)1452343300;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1495597056;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1DB;
								case 4:
								{
									global::DevComponents.WpfEditors.ColorItem colorItem2;
									if (colorItem2 != null)
									{
										num = (short)227868680;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::DevComponents.WpfEditors.ColorItem colorItem2;
									colorItem2.IsSelected = true;
									num = (short)1591869443;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1BC;
									}
									continue;
								case 7:
								{
									global::DevComponents.WpfEditors.ColorItem colorItem2;
									if (colorItem2.Color == color2)
									{
										num = (short)1335558149;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)209256455;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1E0:
								num = (short)953614337;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BC:
								goto IL_1E0;
							}
							IL_1DB:
							IL_2C8:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2EA;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2D7:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1345781761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_342;
								case 1:
									disposable.Dispose();
									num = (short)105119746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_340;
								}
								goto IL_2EA;
							}
							IL_340:
							IL_342:
							goto EndFinally_19;
							IL_2EA:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1408040960;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2D7;
							EndFinally_19:;
						}
						goto IL_343;
					case 13:
						num = (short)1983315983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (selectedColor == null)
						{
							num = (short)2004615171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_343;
					case 15:
						if (this.SelectedColorItem.Color == color2)
						{
							num = (short)199294984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_131;
					case 16:
						goto IL_6BB;
					}
					goto IL_72;
					IL_C5:
					num = (short)1433468933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_131:
					num = (short)1302331403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_343:
					num = (short)2115567623;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_423:
					color2 = color;
					num = (short)1179254790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_465:
					num = (short)1301544961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6BB:
					enumerator = this.b.Children.GetEnumerator();
					num = (short)130220041;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3D2:
				this.SelectedColorItem.IsSelected = true;
				return;
				IL_72:
				selectedColor = this.SelectedColor;
				num = (short)92405774;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000137A4 File Offset: 0x000119A4
		private static void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1580747145;
			short num2 = num;
			num = (short)1525369225;
			switch (num2 == num)
			{
			}
			num = (short)2012676096;
			if (num != 0)
			{
			}
			num = (short)996016128;
			short num3 = num;
			num = (short)1016528897;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.ColorItemSelector)A_0).a(A_1.OriginalSource as global::System.Windows.FrameworkElement, true, A_1);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00013868 File Offset: 0x00011A68
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1490963705;
			short num2 = num;
			num = (short)259017977;
			switch (num2 == num)
			{
			}
			num = (short)1475543041;
			if (num != 0)
			{
			}
			num = (short)1779630080;
			short num3 = num;
			num = (short)1165819904;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.ColorItemSelector)A_0).a(A_1.OriginalSource as global::System.Windows.FrameworkElement, false, A_1);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00013930 File Offset: 0x00011B30
		internal void a(global::System.Windows.FrameworkElement A_0, bool A_1, global::System.Windows.RoutedEventArgs A_2)
		{
			short num = (short)1778843655;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1274347525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_12E;
				case 2:
					goto IL_106;
				case 3:
					goto IL_E8;
				case 4:
					num = (short)566558728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (A_1)
					{
						num = (short)1614872577;
						if (num != 0)
						{
						}
						num = (short)1147404297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.Selection.c(A_0);
					num = (short)216072195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_185;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 8:
					if (A_0 != null)
					{
						num = (short)1512570880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_166;
				case 9:
					this.Selection.d(A_0);
					num = (short)1092550657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4C:
				if (this.Selection.e())
				{
					goto IL_166;
				}
				num = (short)1780088832;
				short num3 = num;
				num = (short)1274244127;
				short num4 = num;
				num = (short)1302031391;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)813957120;
					if (num != 0)
					{
					}
					num = (short)938803204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E8:
				A_2.Handled = true;
				num = (short)1589772290;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_12E:
				goto IL_E8;
				IL_166:
				A_2.Handled = true;
				num = (short)670433286;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_106:
			IL_185:
			this.OnSelectionChanged(A_0, A_1);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00013B54 File Offset: 0x00011D54
		protected virtual void OnSelectionChanged(global::System.Windows.FrameworkElement selectedElement, bool isSelected)
		{
			short num;
			while (selectedElement is global::DevComponents.WpfEditors.ColorItem)
			{
				num = (short)350552064;
				short num2 = num;
				num = (short)205017155;
				short num3 = num;
				num = (short)341594179;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)986513408;
					if (num != 0)
					{
					}
					this.SelectedColorItem = (global::DevComponents.WpfEditors.ColorItem)selectedElement;
					return;
				}
			}
			num = (short)1245446145;
			if (num != 0)
			{
			}
			this.SelectedColorItem = null;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00013C20 File Offset: 0x00011E20
		private global::DevComponents.WpfEditors.ColorItemSelector.a Selection
		{
			get
			{
				short num = (short)1716206404;
				short num2 = num;
				num = (short)578960196;
				switch (num2 == num)
				{
				}
				num = (short)2080571392;
				if (num != 0)
				{
				}
				num = (short)741081088;
				short num3 = num;
				num = (short)231407617;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x04000035 RID: 53
		private static readonly global::System.Windows.DependencyPropertyKey a;

		// Token: 0x04000036 RID: 54
		public static readonly global::System.Windows.DependencyProperty SelectedColorItemProperty;

		// Token: 0x04000037 RID: 55
		public static readonly global::System.Windows.DependencyProperty SelectedColorProperty;

		// Token: 0x04000039 RID: 57
		public static readonly global::System.Windows.DependencyProperty MoreColorsButtonVisibilityProperty;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Controls.Grid b;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Controls.Grid c;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Controls.Button d;

		// Token: 0x0400003D RID: 61
		private global::DevComponents.WpfEditors.ColorItemSelector.a e = new global::DevComponents.WpfEditors.ColorItemSelector.a();

		// Token: 0x02000012 RID: 18
		private class a
		{
			// Token: 0x060000F3 RID: 243 RVA: 0x00013CF0 File Offset: 0x00011EF0
			public bool e()
			{
				short num = (short)1428818502;
				short num2 = num;
				num = (short)1773668934;
				switch (num2 == num)
				{
				}
				num = (short)687276033;
				if (num != 0)
				{
				}
				num = (short)605421568;
				short num3 = num;
				num = (short)219021312;
				if (num != 0)
				{
				}
				return this.a > 0;
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x00013DA4 File Offset: 0x00011FA4
			public bool f()
			{
				short num = (short)918489998;
				short num2 = num;
				num = (short)1597836174;
				switch (num2 == num)
				{
				}
				num = (short)284229633;
				if (num != 0)
				{
				}
				num = (short)86179840;
				short num3 = num;
				num = (short)1574305792;
				if (num != 0)
				{
				}
				return this.c;
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x00013E50 File Offset: 0x00012050
			public void c(bool A_0)
			{
				short num = (short)1209765155;
				short num2 = num;
				num = (short)298945827;
				switch (num2 == num)
				{
				}
				num = (short)2097479680;
				if (num != 0)
				{
				}
				num = (short)160759808;
				short num3 = num;
				num = (short)603717633;
				if (num != 0)
				{
				}
				this.c = A_0;
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x00013F04 File Offset: 0x00012104
			public void c(global::System.Windows.FrameworkElement A_0)
			{
				short num = (short)693960705;
				if (num != 0)
				{
				}
				num = (short)723255296;
				short num2 = num;
				this.d();
				try
				{
					num = (short)104529924;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							A_0.SetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty, false);
							num = (short)1079705601;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							num = (short)2122118258;
							short num4 = num;
							num = (short)1034941554;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_6D;
							default:
								num = (short)442957824;
								if (num != 0)
								{
								}
								goto IL_15E;
							}
							break;
						}
						case 2:
							if (!this.b.Contains(A_0))
							{
								num = (short)114163718;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19E;
						case 3:
							goto IL_1B5;
						case 4:
							goto IL_6D;
						case 5:
							goto IL_19E;
						case 6:
							this.b.Remove(A_0);
							num = (short)2106654725;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99;
						IL_6D:
						switch (0)
						{
						case 0:
							IL_99:
							if (!(bool)A_0.GetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty))
							{
								goto IL_15E;
							}
							num = (short)1726545920;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
						continue;
						IL_15E:
						num = (short)378667010;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_19E:
						num = (short)2054422531;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1B5:;
				}
				finally
				{
					this.c();
				}
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x000140EC File Offset: 0x000122EC
			public void d(global::System.Windows.FrameworkElement A_0)
			{
				this.d();
				short num;
				try
				{
					num = (short)1826291712;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1C;
						case 1:
							goto IL_1E6;
						case 2:
							A_0.SetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty, true);
							num = (short)34996227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_12E;
						case 4:
							goto IL_75;
						case 5:
						{
							num = (short)156148517;
							short num3 = num;
							num = (short)76194597;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1C;
							default:
								num = (short)1263403008;
								if (num != 0)
								{
								}
								if (!this.b.Contains(A_0))
								{
									num = (short)28114950;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E6;
							}
							break;
						}
						case 6:
							this.b.Add(A_0);
							num = (short)1352073217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							this.g();
							num = (short)1336934404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_1FD;
						case 9:
							if (!(bool)A_0.GetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty))
							{
								num = (short)596770818;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12E;
						}
						goto IL_54;
						IL_1C:
						switch (0)
						{
						case 0:
							IL_54:
							if (this.c)
							{
								goto IL_75;
							}
							num = (short)826015751;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						continue;
						IL_75:
						num = (short)1661272065;
						if (num != 0)
						{
						}
						num = (short)1240399881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_12E:
						num = (short)545456133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E6:
						num = (short)2098855944;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1FD:;
				}
				finally
				{
					this.c();
				}
				num = (short)2025521152;
				short num4 = num;
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x00014344 File Offset: 0x00012544
			public void g()
			{
				this.d();
				goto IL_08;
				short num;
				try
				{
					for (;;)
					{
						IL_08:
						using (global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>.Enumerator enumerator = this.b.GetEnumerator())
						{
							num = (short)1859059715;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_C9;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1986199554;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.SetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty, false);
									num = (short)577110020;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)698023936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_4F;
									}
									continue;
								}
								IL_7E:
								num = (short)356450305;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F:
								goto IL_7E;
							}
							IL_C9:;
						}
						num = (short)467211337;
						short num3 = num;
						num = (short)812389449;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_10F;
						}
					}
					IL_10F:
					num = (short)916324352;
					if (num != 0)
					{
					}
					this.b.Clear();
				}
				finally
				{
					num = (short)1694105601;
					if (num != 0)
					{
					}
					this.c();
				}
				num = (short)258605056;
				short num4 = num;
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x00014514 File Offset: 0x00012714
			private void d()
			{
				short num = (short)1611679204;
				short num2 = num;
				num = (short)920471012;
				switch (num2 == num)
				{
				}
				num = (short)150208512;
				if (num != 0)
				{
				}
				num = (short)1208156161;
				if (num != 0)
				{
				}
				num = (short)1061617664;
				short num3 = num;
				this.a++;
			}

			// Token: 0x060000FA RID: 250 RVA: 0x000145C8 File Offset: 0x000127C8
			private void c()
			{
				int a_ = 5;
				short num = (short)263979009;
				if (num != 0)
				{
				}
				this.a--;
				if (this.a < 0)
				{
					num = (short)315204680;
					short num2 = num;
					num = (short)1025745992;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C0;
					case 1:
						break;
					default:
					{
						num = (short)109117440;
						short num3 = num;
						break;
					}
					}
					num = (short)61276160;
					if (num != 0)
					{
					}
					IL_C0:
					throw new global::System.InvalidOperationException(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韑뫓닕诗뿙냛믝菟雡跣觥蛧쫩迫迭鳯黱釳鋵\ud8f7跹闻諽棿洁焃爅⠇椉挋簍戏眑朓昕眗琙砛眝丟䔡У搥䴧䴩䔫䀭振圱堳匵嬷丹唻儽⸿", a_));
				}
			}

			// Token: 0x060000FB RID: 251 RVA: 0x000146AC File Offset: 0x000128AC
			public global::System.Windows.FrameworkElement[] h()
			{
				short num = (short)941428135;
				short num2 = num;
				num = (short)635571623;
				switch (num2 == num)
				{
				}
				num = (short)1294336001;
				if (num != 0)
				{
				}
				num = (short)2026242048;
				if (num != 0)
				{
				}
				num = (short)1159725056;
				short num3 = num;
				global::System.Windows.FrameworkElement[] array = new global::System.Windows.FrameworkElement[this.b.Count];
				this.b.CopyTo(array);
				return array;
			}

			// Token: 0x0400003E RID: 62
			private int a;

			// Token: 0x0400003F RID: 63
			private global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> b = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();

			// Token: 0x04000040 RID: 64
			private bool c;
		}
	}
}
