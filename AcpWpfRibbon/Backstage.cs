using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200000A RID: 10
	public class Backstage : global::System.Windows.Controls.TabControl
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00025E2C File Offset: 0x0002402C
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00025EE4 File Offset: 0x000240E4
		public global::System.Windows.Media.Brush ContentBackground
		{
			get
			{
				short num = (short)1939182750;
				short num2 = num;
				num = (short)1265407134;
				switch (num2 == num)
				{
				}
				num = (short)15859713;
				if (num != 0)
				{
				}
				num = (short)902168576;
				if (num != 0)
				{
				}
				num = (short)750977024;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.Backstage.ContentBackgroundProperty);
			}
			set
			{
				short num = (short)795941117;
				short num2 = num;
				num = (short)1055332605;
				switch (num2 == num)
				{
				}
				num = (short)1587806209;
				if (num != 0)
				{
				}
				num = (short)1061748736;
				if (num != 0)
				{
				}
				num = (short)1699741696;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.Backstage.ContentBackgroundProperty, value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00025F9C File Offset: 0x0002419C
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00026054 File Offset: 0x00024254
		public global::System.Windows.Media.Brush ContentBorderBrush
		{
			get
			{
				short num = (short)1273726102;
				short num2 = num;
				num = (short)1116570774;
				switch (num2 == num)
				{
				}
				num = (short)928448512;
				if (num != 0)
				{
				}
				num = (short)1142554625;
				if (num != 0)
				{
				}
				num = (short)1632239616;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.Backstage.ContentBorderBrushProperty);
			}
			set
			{
				short num = (short)1568122645;
				short num2 = num;
				num = (short)530491157;
				switch (num2 == num)
				{
				}
				num = (short)1488650241;
				if (num != 0)
				{
				}
				num = (short)1288437760;
				if (num != 0)
				{
				}
				num = (short)1798635520;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.Backstage.ContentBorderBrushProperty, value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00026110 File Offset: 0x00024310
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000261C8 File Offset: 0x000243C8
		public global::System.Windows.Media.Brush ContentInnerBorderBrush
		{
			get
			{
				short num = (short)2089877505;
				if (num != 0)
				{
				}
				num = (short)14044782;
				short num2 = num;
				num = (short)1727024750;
				switch (num2 == num)
				{
				}
				num = (short)1484128256;
				if (num != 0)
				{
				}
				num = (short)1779630080;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.Backstage.ContentInnerBorderBrushProperty);
			}
			set
			{
				short num = (short)1809366033;
				short num2 = num;
				num = (short)883145745;
				switch (num2 == num)
				{
				}
				num = (short)528023553;
				if (num != 0)
				{
				}
				num = (short)1928790016;
				if (num != 0)
				{
				}
				num = (short)712114176;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.Backstage.ContentInnerBorderBrushProperty, value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00026280 File Offset: 0x00024480
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0002633C File Offset: 0x0002453C
		public global::System.Windows.Thickness ContentBorderThickness
		{
			get
			{
				short num = (short)1667579940;
				short num2 = num;
				num = (short)1681080356;
				switch (num2 == num)
				{
				}
				num = (short)1614872577;
				if (num != 0)
				{
				}
				num = (short)692584448;
				if (num != 0)
				{
				}
				num = (short)858783744;
				short num3 = num;
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.Backstage.ContentBorderThicknessProperty);
			}
			set
			{
				short num = (short)1303496111;
				short num2 = num;
				num = (short)707446191;
				switch (num2 == num)
				{
				}
				num = (short)1522532353;
				if (num != 0)
				{
				}
				num = (short)2028142592;
				if (num != 0)
				{
				}
				num = (short)966852608;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.Backstage.ContentBorderThicknessProperty, value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000263F4 File Offset: 0x000245F4
		// (set) Token: 0x06000177 RID: 375 RVA: 0x000264B0 File Offset: 0x000246B0
		public double TabStripMinWidth
		{
			get
			{
				short num = (short)1067316112;
				short num2 = num;
				num = (short)198243216;
				switch (num2 == num)
				{
				}
				num = (short)2124021760;
				if (num != 0)
				{
				}
				num = (short)1578434561;
				if (num != 0)
				{
				}
				num = (short)1967915008;
				short num3 = num;
				return (double)base.GetValue(global::DevComponents.WpfRibbon.Backstage.TabStripMinWidthProperty);
			}
			set
			{
				short num = (short)1367568706;
				short num2 = num;
				num = (short)1575186754;
				switch (num2 == num)
				{
				}
				num = (short)620560385;
				if (num != 0)
				{
				}
				num = (short)749535232;
				if (num != 0)
				{
				}
				num = (short)169017344;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.Backstage.TabStripMinWidthProperty, value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00026568 File Offset: 0x00024768
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0002661C File Offset: 0x0002481C
		public object SelectedPanelEffectiveBackgroundImage
		{
			get
			{
				short num = (short)2097816978;
				short num2 = num;
				num = (short)1187194258;
				switch (num2 == num)
				{
				}
				num = (short)561643521;
				if (num != 0)
				{
				}
				num = (short)1162805248;
				if (num != 0)
				{
				}
				num = (short)80084992;
				short num3 = num;
				return base.GetValue(global::DevComponents.WpfRibbon.Backstage.SelectedPanelEffectiveBackgroundImageProperty);
			}
			set
			{
				short num = (short)1343196921;
				short num2 = num;
				num = (short)625774329;
				switch (num2 == num)
				{
				}
				num = (short)1380122624;
				if (num != 0)
				{
				}
				num = (short)231407617;
				if (num != 0)
				{
				}
				num = (short)138805248;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.Backstage.SelectedPanelEffectiveBackgroundImageProperty, value);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000266D4 File Offset: 0x000248D4
		static Backstage()
		{
			int a_ = 4;
			short num = (short)98467751;
			short num2 = num;
			num = (short)1082163111;
			switch (num2 == num)
			{
			}
			num = (short)1125580801;
			if (num != 0)
			{
			}
			num = (short)222756864;
			if (num != 0)
			{
			}
			num = (short)194314240;
			short num3 = num;
			global::DevComponents.WpfRibbon.Backstage.ContentBackgroundProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ὓㅝ๟ᙡţࡥᱧ⡩൫൭᭯ᕱٳ᥵൷ᑹ᡻", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.Backstage), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Backstage.ContentBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ὓㅝ๟ᙡţࡥᱧ⡩ͫᱭᑯ᝱ٳ㑵੷ཹཻᙽ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.Backstage), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Backstage.ContentInnerBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ὓㅝ๟ᙡţࡥᱧ⍩ɫmᕯq㙳᥵੷ṹ᥻౽쉿", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.Backstage), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Backstage.ContentBorderThicknessProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ὓㅝ๟ᙡţࡥᱧ⡩ͫᱭᑯ᝱ٳ≵ၷ፹ύᕽ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.Backstage), new global::System.Windows.UIPropertyMetadata(default(global::System.Windows.Thickness)));
			global::DevComponents.WpfRibbon.Backstage.TabStripMinWidthProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("࡛㽝ɟㅡၣᑥŧᩩⅫݭṯ╱ᵳት౷ቹ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.Backstage), new global::System.Windows.UIPropertyMetadata(120.0));
			global::DevComponents.WpfRibbon.Backstage.SelectedPanelEffectiveBackgroundImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ཛ㭝౟ݡݣብ൧๩㱫཭ṯ᝱ᡳ㍵ṷᱹ᥻ᵽ쪇ﮓﺙ햛솟얡솣", a_), typeof(object), typeof(global::DevComponents.WpfRibbon.Backstage), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Backstage._BackstageButtonStyleKey = new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Backstage), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ṛ⭝ᑟᙡୣࡥ", a_));
			global::DevComponents.WpfRibbon.Backstage._BackstageButtonDropDownStyleKey = new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Backstage), global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ṛ⭝ᑟᙡୣࡥⱧᡩͫṭ㑯ᵱͳᡵ", a_));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.Backstage), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.Backstage)));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00026934 File Offset: 0x00024B34
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			short num = (short)716878174;
			short num2 = num;
			num = (short)2047258974;
			switch (num2 == num)
			{
			}
			num = (short)464257024;
			if (num != 0)
			{
			}
			num = (short)1392246785;
			if (num != 0)
			{
			}
			num = (short)246677504;
			short num3 = num;
			return true;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000269E0 File Offset: 0x00024BE0
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::System.Windows.FrameworkElement frameworkElement;
			for (;;)
			{
				IL_0A:
				global::System.Windows.ResourceKey resourceKey;
				switch (num)
				{
				case 0:
				{
					global::System.Type type;
					if (type == typeof(global::DevComponents.WpfRibbon.ButtonDropDown))
					{
						num2 = (short)401866757;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_88;
				}
				case 1:
					if (this.IsDefaultStyle(frameworkElement, global::System.Windows.FrameworkElement.StyleProperty))
					{
						num2 = (short)660733958;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (resourceKey != null)
					{
						num2 = (short)558628867;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					num2 = (short)1068105729;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (frameworkElement != null)
					{
						num2 = (short)1471545354;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					resourceKey = global::DevComponents.WpfRibbon.Backstage.ButtonDropDownStyleKey;
					num2 = (short)83296267;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					frameworkElement.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, resourceKey);
					num2 = (short)895483913;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_157;
				case 8:
					goto IL_88;
				case 9:
					return;
				case 10:
				{
					global::System.Type type = frameworkElement.GetType();
					resourceKey = null;
					num2 = (short)458620940;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 11:
				{
					num2 = (short)221904585;
					short num3 = num2;
					num2 = (short)21561033;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_157;
					default:
						num2 = (short)1484455937;
						if (num2 != 0)
						{
						}
						num2 = (short)632225792;
						if (num2 != 0)
						{
						}
						goto IL_88;
					}
					break;
				}
				case 12:
				{
					global::System.Type type;
					if (type == typeof(global::System.Windows.Controls.Button))
					{
						num2 = (short)336723975;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)630128640;
					short num4 = num2;
					num2 = (short)689242112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_44;
				IL_88:
				num2 = (short)1413414914;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_157:
				resourceKey = global::DevComponents.WpfRibbon.Backstage.ButtonStyleKey;
				num2 = (short)1472528392;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_44:
			base.PrepareContainerForItemOverride(element, item);
			frameworkElement = (element as global::System.Windows.FrameworkElement);
			num2 = (short)509739012;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00026C98 File Offset: 0x00024E98
		private bool IsDefaultStyle(global::System.Windows.DependencyObject targetObject, global::System.Windows.DependencyProperty dp)
		{
			short num = (short)927858688;
			short num2 = num;
			num = (short)782827521;
			if (num != 0)
			{
			}
			num = (short)2080043517;
			short num3 = num;
			num = (short)957346301;
			switch (num3 == num)
			{
			}
			num = (short)936640512;
			if (num != 0)
			{
			}
			return global::System.Windows.DependencyPropertyHelper.GetValueSource(targetObject, dp).BaseValueSource <= global::System.Windows.BaseValueSource.ImplicitStyleReference;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00026D58 File Offset: 0x00024F58
		public static global::System.Windows.ResourceKey ButtonStyleKey
		{
			get
			{
				short num = (short)1262813184;
				short num2 = num;
				num = (short)1358797155;
				short num3 = num;
				num = (short)676567395;
				switch (num3 == num)
				{
				}
				num = (short)13762561;
				if (num != 0)
				{
				}
				num = (short)895614976;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfRibbon.Backstage._BackstageButtonStyleKey;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00026E08 File Offset: 0x00025008
		public static global::System.Windows.ResourceKey ButtonDropDownStyleKey
		{
			get
			{
				short num = (short)1151991808;
				short num2 = num;
				num = (short)208113216;
				short num3 = num;
				num = (short)1096912448;
				switch (num3 == num)
				{
				}
				num = (short)1707802625;
				if (num != 0)
				{
				}
				num = (short)617349120;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfRibbon.Backstage._BackstageButtonDropDownStyleKey;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00026EB8 File Offset: 0x000250B8
		private int FindNextTabItemIndex(int startIndex, int direction)
		{
			short num = (short)1418985481;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			for (;;)
			{
				global::System.Windows.Controls.TabItem tabItem;
				int num4;
				switch (num2)
				{
				case 0:
					if (tabItem.Visibility == global::System.Windows.Visibility.Visible)
					{
						num = (short)1758265352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D3;
				case 1:
					goto IL_23C;
				case 2:
					goto IL_13F;
				case 3:
					goto IL_23C;
				case 4:
					num3 = base.Items.Count - 1;
					num = (short)1252589584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return -1;
				case 6:
				{
					num = (short)1406140417;
					if (num != 0)
					{
					}
					num3 = startIndex;
					num4 = 0;
					num = (short)231276544;
					short num5 = num;
					num = (short)283115521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					num3 = 0;
					num = (short)1983381506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return num3;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 10:
					if (tabItem != null)
					{
						num = (short)824770573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D3;
				case 11:
					if (tabItem.IsEnabled)
					{
						num = (short)1334247436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D3;
				case 12:
				{
					num = (short)1654864260;
					short num6 = num;
					num = (short)120535428;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_189;
					default:
						num = (short)663224320;
						if (num != 0)
						{
						}
						num = (short)887947264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 13:
					num = (short)1820065803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (num3 < 0)
					{
						num = (short)581369860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13F;
				case 15:
					if (num4 >= base.Items.Count)
					{
						num = (short)2092892165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_189;
				case 16:
					goto IL_13F;
				case 17:
					if (num3 >= base.Items.Count)
					{
						num = (short)509673479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1463746574;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6D:
				if (direction != 0)
				{
					num = (short)1813970950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return -1;
				IL_13F:
				tabItem = (base.ItemContainerGenerator.ContainerFromIndex(num3) as global::System.Windows.Controls.TabItem);
				num = (short)1757020170;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_189:
				num3 += direction;
				num = (short)1515716625;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D3:
				num4++;
				num = (short)776273923;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23C:
				num = (short)1175060495;
				num2 = (int)((global::System.IntPtr)num);
			}
			return num3;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0002720C File Offset: 0x0002540C
		protected override void OnInitialized(global::System.EventArgs e)
		{
			short num = (short)1222967296;
			short num2 = num;
			num = (short)781811019;
			short num3 = num;
			num = (short)883129675;
			switch (num3 == num)
			{
			}
			num = (short)1808269313;
			if (num != 0)
			{
			}
			num = (short)1065811968;
			if (num != 0)
			{
			}
			base.ItemContainerGenerator.StatusChanged += this.OnGeneratorStatusChanged;
			base.OnInitialized(e);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000272D4 File Offset: 0x000254D4
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1806827520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1351548939;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						num = (short)1815609354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)148111376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (e.NewItems != null)
						{
							num = (short)2068185089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_172;
					case 3:
					{
						global::System.Collections.IEnumerator enumerator = e.OldItems.GetEnumerator();
						num = (short)1944977420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator();
						num = (short)394854408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
						num = (short)149487633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_534;
					case 7:
						num = (short)1305739265;
						if (num != 0)
						{
						}
						this.EnsureSelectedTab();
						num = (short)118947855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						try
						{
							num = (short)1790312448;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_6DF;
									}
									continue;
								case 1:
									goto IL_796;
								case 2:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2059665414;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.FrameworkElement frameworkElement = enumerator.Current as global::System.Windows.FrameworkElement;
									num = (short)1183252484;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Windows.FrameworkElement frameworkElement;
									if (frameworkElement != null)
									{
										num = (short)2126315525;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::System.Windows.FrameworkElement frameworkElement;
									base.AddLogicalChild(frameworkElement);
									num = (short)1201405955;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1056571393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6E1:
								num = (short)1317142530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6DF:
								goto IL_6E1;
							}
							IL_796:
							goto IL_172;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_7B8;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_7A5:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1312423938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_80B;
								case 1:
									goto IL_809;
								case 2:
									disposable.Dispose();
									num = (short)69861377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_7B8;
							}
							IL_809:
							IL_80B:
							goto EndFinally_27;
							IL_7B8:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1766653952;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_7A5;
							EndFinally_27:;
						}
						goto IL_80C;
					case 9:
						num = (short)249364494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (flag)
						{
							num = (short)200343557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_325;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_95;
						}
						continue;
					case 12:
						goto IL_14B;
					case 13:
						if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
						{
							num = (short)1763311616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_325;
					case 14:
						if (flag)
						{
							num = (short)1523056643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80C;
					case 15:
						goto IL_5A1;
					case 16:
					{
						num = (short)1965628681;
						short num3 = num;
						num = (short)124263689;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14B;
						case 1:
							break;
						default:
						{
							num = (short)961019904;
							short num4 = num;
							break;
						}
						}
						num = (short)484835328;
						if (num != 0)
						{
						}
						if (flag)
						{
							num = (short)2084700164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_172;
					}
					case 17:
						try
						{
							num = (short)1943339008;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_40C;
									}
									continue;
								case 1:
									goto IL_4BD;
								case 3:
									num = (short)437649409;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Windows.FrameworkElement frameworkElement2;
									base.AddLogicalChild(frameworkElement2);
									num = (short)1680146434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2017001475;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.FrameworkElement frameworkElement2 = enumerator.Current as global::System.Windows.FrameworkElement;
									num = (short)1369309190;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::System.Windows.FrameworkElement frameworkElement2;
									if (frameworkElement2 != null)
									{
										num = (short)1465057284;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_467:
								num = (short)403505157;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_40C:
								goto IL_467;
							}
							IL_4BD:
							goto IL_325;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_4DF;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_4CC:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)679477250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_533;
								case 1:
									goto IL_531;
								case 2:
									disposable.Dispose();
									num = (short)168624129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4DF;
							}
							IL_531:
							IL_533:
							goto EndFinally_26;
							IL_4DF:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1566244864;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_4CC;
							EndFinally_26:;
						}
						goto IL_534;
					case 18:
						if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
						{
							num = (short)483328007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A1;
					case 19:
						if (e.OldItems != null)
						{
							num = (short)1529872393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80C;
					}
					IL_95:
					if (base.Items.Count > 0)
					{
						num = (short)2106458118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A1;
					IL_172:
					num = (short)841613331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_325:
					num = (short)527499266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14B:
					try
					{
						num = (short)1728118784;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1F5;
								}
								continue;
							case 1:
								goto IL_2AD;
							case 2:
							{
								global::System.Collections.IEnumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)2000748550;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.FrameworkElement frameworkElement3 = enumerator.Current as global::System.Windows.FrameworkElement;
								num = (short)1417019396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								global::System.Windows.FrameworkElement frameworkElement3;
								if (frameworkElement3 != null)
								{
									num = (short)1787559941;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::System.Windows.FrameworkElement frameworkElement3;
								base.RemoveLogicalChild(frameworkElement3);
								num = (short)1065156611;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								num = (short)520486913;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1F7:
							num = (short)712376322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1F5:
							goto IL_1F7;
						}
						IL_2AD:
						break;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_2CF;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_2BC:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1510866946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_324;
							case 1:
								goto IL_322;
							case 2:
								disposable.Dispose();
								num = (short)840237057;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2CF;
						}
						IL_322:
						IL_324:
						goto EndFinally_25;
						IL_2CF:
						global::System.Collections.IEnumerator enumerator;
						disposable = (enumerator as global::System.IDisposable);
						num = (short)512425984;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_2BC;
						EndFinally_25:;
					}
					goto IL_325;
					IL_534:
					num = (short)1940914194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A1:
					flag = (base.ItemsSource != null);
					num = (short)1239810061;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_80C:
				base.OnItemsChanged(e);
				return;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00027B1C File Offset: 0x00025D1C
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				short num = (short)1726676992;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1517092864;
					num2 = (int)((global::System.IntPtr)num);
					global::System.Collections.Generic.List<object> list;
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						switch (num2)
						{
						case 0:
						{
							num = (short)1118306304;
							short num3 = num;
							switch (0)
							{
							case 0:
								goto IL_7A;
							}
							continue;
						}
						case 1:
							try
							{
								num = (short)1105068032;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_E5;
										}
										continue;
									case 1:
										goto IL_194;
									case 2:
									{
										object obj;
										if (obj is global::System.Windows.FrameworkElement)
										{
											num = (short)1791098886;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)965214213;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										object obj = enumerator.Current;
										num = (short)953417730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										num = (short)187498497;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										object obj;
										list.Add(obj);
										num = (short)1906311171;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_123:
									num = (short)1916338180;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_E5:
									goto IL_123;
								}
								IL_194:
								goto IL_23F;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_1B6;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1A3:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)301137922;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_20D;
									case 1:
										goto IL_20B;
									case 2:
										disposable.Dispose();
										num = (short)615972865;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1B6;
								}
								IL_20B:
								IL_20D:
								goto EndFinally_7;
								IL_1B6:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1280180224;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1A3;
								EndFinally_7:;
							}
							goto IL_20E;
						case 2:
							goto IL_20E;
						}
						IL_7A:
						if (base.ItemsSource != null)
						{
							num = (short)1376518146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC;
						IL_20E:
						list = new global::System.Collections.Generic.List<object>();
						enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
						num = (short)818151425;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_23F:
					num = (short)1667797628;
					short num4 = num;
					num = (short)1632735868;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_2BC:
						return base.LogicalChildren;
					default:
						num = (short)987824129;
						if (num != 0)
						{
						}
						num = (short)298647552;
						if (num != 0)
						{
						}
						return list.GetEnumerator();
					}
					break;
				}
				}
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00027DFC File Offset: 0x00025FFC
		private void EnsureSelectedTab()
		{
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
					num2 = this.FindNextTabItemIndex(base.SelectedIndex, 1);
					num3 = (short)331284483;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
				{
					if (num2 < 0)
					{
						return;
					}
					num3 = (short)46792704;
					short num4 = num3;
					num3 = (short)1520087584;
					short num5 = num3;
					num3 = (short)352694816;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CE;
					default:
						num3 = (short)496304128;
						if (num3 != 0)
						{
						}
						num3 = (short)760020999;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 2:
					if (base.SelectedIndex == -1)
					{
						num3 = (short)859373573;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)833617924;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					goto IL_6F;
				case 4:
					goto IL_1CE;
				case 5:
					num2 = this.FindNextTabItemIndex(-1, 1);
					num3 = (short)1582956550;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					goto IL_6F;
				case 7:
					base.SelectedIndex = num2;
					num3 = (short)1708589057;
					if (num3 != 0)
					{
					}
					num3 = (short)377356296;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
					return;
				}
				goto IL_34;
				IL_6F:
				num3 = (short)1196490753;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1CE:
				if (base.ItemContainerGenerator.ContainerFromIndex(base.SelectedIndex) is global::System.Windows.Controls.TabItem)
				{
					goto IL_6F;
				}
				num3 = (short)1302200320;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_34:
			num2 = -1;
			num3 = (short)1983643650;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00028010 File Offset: 0x00026210
		private void OnGeneratorStatusChanged(object sender, global::System.EventArgs e)
		{
			short num = (short)114622465;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)364997783;
				short num3 = num;
				num = (short)410479767;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E4;
				default:
					num = (short)1645150208;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						this.EnsureSelectedTab();
						num = (short)483590146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)764280833;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					case 2:
						goto IL_E4;
					}
					IL_A1:
					if (base.ItemContainerGenerator.Status != global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
					{
						return;
					}
					num = (short)1796472832;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E4:
			num = (short)940113920;
			short num4 = num;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0002812C File Offset: 0x0002632C
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			int a_ = 2;
			short num = (short)1226768387;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::DevComponents.WpfRibbon.BackstageTab backstageTab;
					if (backstageTab == null)
					{
						num = (short)1354170372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ὑ㩛㡝՟šၣཥṧཀྵ⹫཭፯ᥱ፳ѵ᝷ཹቻ᩽쥿", a_));
					binding.Source = backstageTab;
					binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
					base.SetBinding(global::DevComponents.WpfRibbon.Backstage.SelectedPanelEffectiveBackgroundImageProperty, binding);
					num = (short)1945894913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_1EC;
				case 2:
				{
					num = (short)805735503;
					short num3 = num;
					num = (short)1851231311;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1EC;
					default:
						num = (short)410451968;
						if (num != 0)
						{
						}
						base.ClearValue(global::DevComponents.WpfRibbon.Backstage.SelectedPanelEffectiveBackgroundImageProperty);
						num = (short)349110278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 4:
					base.ClearValue(global::DevComponents.WpfRibbon.Backstage.SelectedPanelEffectiveBackgroundImageProperty);
					num = (short)1278148613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_8D;
				case 6:
					goto IL_1A3;
				}
				IL_4A:
				if (base.SelectedIndex == -1)
				{
					num = (short)1166934018;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)297402368;
					short num4 = num;
					global::DevComponents.WpfRibbon.BackstageTab backstageTab = base.ItemContainerGenerator.ContainerFromIndex(base.SelectedIndex) as global::DevComponents.WpfRibbon.BackstageTab;
					num = (short)1356201985;
					if (num != 0)
					{
					}
					num = (short)656539648;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_8D:
			IL_1A3:
			IL_1EC:
			base.OnSelectionChanged(e);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00028330 File Offset: 0x00026530
		// (set) Token: 0x06000188 RID: 392 RVA: 0x000283E0 File Offset: 0x000265E0
		internal global::DevComponents.WpfRibbon.ApplicationMenu ApplicationMenu
		{
			get
			{
				short num = (short)691142657;
				if (num != 0)
				{
				}
				num = (short)866680693;
				short num2 = num;
				num = (short)369327989;
				switch (num2 == num)
				{
				}
				num = (short)431030272;
				if (num != 0)
				{
				}
				num = (short)1782448128;
				short num3 = num;
				return this._ApplicationMenu;
			}
			set
			{
				short num = (short)813291087;
				short num2 = num;
				num = (short)1642124879;
				switch (num2 == num)
				{
				}
				num = (short)33619968;
				if (num != 0)
				{
				}
				num = (short)2091253761;
				if (num != 0)
				{
				}
				num = (short)2073821184;
				short num3 = num;
				this._ApplicationMenu = value;
			}
		}

		// Token: 0x04000085 RID: 133
		public static readonly global::System.Windows.DependencyProperty ContentBackgroundProperty;

		// Token: 0x04000086 RID: 134
		public static readonly global::System.Windows.DependencyProperty ContentBorderBrushProperty;

		// Token: 0x04000087 RID: 135
		public static readonly global::System.Windows.DependencyProperty ContentInnerBorderBrushProperty;

		// Token: 0x04000088 RID: 136
		public static readonly global::System.Windows.DependencyProperty ContentBorderThicknessProperty;

		// Token: 0x04000089 RID: 137
		public static readonly global::System.Windows.DependencyProperty TabStripMinWidthProperty;

		// Token: 0x0400008A RID: 138
		public static readonly global::System.Windows.DependencyProperty SelectedPanelEffectiveBackgroundImageProperty;

		// Token: 0x0400008B RID: 139
		private static global::System.Windows.ComponentResourceKey _BackstageButtonStyleKey;

		// Token: 0x0400008C RID: 140
		private static global::System.Windows.ComponentResourceKey _BackstageButtonDropDownStyleKey;

		// Token: 0x0400008D RID: 141
		private global::DevComponents.WpfRibbon.ApplicationMenu _ApplicationMenu;
	}
}
