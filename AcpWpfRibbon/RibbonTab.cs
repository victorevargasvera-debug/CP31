using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200009D RID: 157
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_RibbonTabBorder", Type = typeof(global::System.Windows.Controls.Decorator))]
	public class RibbonTab : global::System.Windows.Controls.HeaderedContentControl
	{
		// Token: 0x06000782 RID: 1922 RVA: 0x000AC240 File Offset: 0x000AA440
		static RibbonTab()
		{
			int a_ = 13;
			short num = (short)1087438849;
			if (num != 0)
			{
			}
			num = (short)350748672;
			short num2 = num;
			num = (short)1134778192;
			short num3 = num;
			num = (short)1076451152;
			switch (num3 == num)
			{
			}
			num = (short)302055424;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonTab.MinimumTabWidth = 24;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.RibbonTab), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.RibbonTab)));
			global::DevComponents.WpfRibbon.RibbonTab.IsSelectedProperty = global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.RibbonTab), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonTab.OnIsSelectedChanged)));
			global::DevComponents.WpfRibbon.RibbonTab.ContextGroupProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("♤ࡦݨὪ࡬ᝮհ㑲ݴᡶ౸୺", a_), typeof(global::DevComponents.WpfRibbon.ContextGroup), typeof(global::DevComponents.WpfRibbon.RibbonTab), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonTab.OnContextGroupChanged)));
			global::DevComponents.WpfRibbon.RibbonTab.ColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("♤ࡦըѪὬ", a_), typeof(global::DevComponents.WpfRibbon.eRibbonTabColor), typeof(global::DevComponents.WpfRibbon.RibbonTab), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonTabColor.Default, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonTab.OnColorChanged)));
			global::DevComponents.WpfRibbon.RibbonTab.TabColorProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅤ٦୨⡪ɬͮṰŲ", a_), typeof(global::DevComponents.WpfRibbon.eRibbonTabColor), typeof(global::DevComponents.WpfRibbon.RibbonTab), new global::System.Windows.PropertyMetadata(global::DevComponents.WpfRibbon.eRibbonTabColor.Default));
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x000AC410 File Offset: 0x000AA610
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x000AC4C8 File Offset: 0x000AA6C8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::DevComponents.WpfRibbon.ContextGroup ContextGroup
		{
			get
			{
				short num = (short)502653108;
				short num2 = num;
				num = (short)430170292;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1625751552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1229717504;
				if (num != 0)
				{
				}
				num = (short)1486225409;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.ContextGroup)base.GetValue(global::DevComponents.WpfRibbon.RibbonTab.ContextGroupProperty);
			}
			set
			{
				short num = (short)1802793854;
				short num2 = num;
				num = (short)800748414;
				switch (num2 == num)
				{
				default:
				{
					num = (short)59244544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1688731649;
				if (num != 0)
				{
				}
				num = (short)1717305344;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonTab.ContextGroupProperty, value);
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000AC57C File Offset: 0x000AA77C
		public override void OnApplyTemplate()
		{
			int a_ = 0;
			short num = (short)816267729;
			short num2 = num;
			num = (short)1960657361;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1698693120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1387134976;
			if (num != 0)
			{
			}
			num = (short)459603969;
			if (num != 0)
			{
			}
			base.OnApplyTemplate();
			this.m_TabBorder = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ࡗ᭙๛੝㽟ちൣѥ੧թɫ㩭ᅯၱ㙳᥵੷ṹ᥻౽", a_)) as global::DevComponents.WpfRibbon.RibbonTabBorder);
			this.UpdateBorderRenderState();
			this.UpdateTabBorderColorClass();
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000AC660 File Offset: 0x000AA860
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 1:
					if (oldContent is global::System.Windows.UIElement)
					{
						num2 = (short)1645911349;
						short num3 = num2;
						num2 = (short)973446453;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B9;
						case 1:
							break;
						default:
						{
							num2 = (short)266534912;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)584187904;
						if (num2 != 0)
						{
						}
						num2 = (short)1368784902;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7C;
				case 2:
					if (this.IsSelected)
					{
						num2 = (short)1108803592;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E2;
				case 3:
					if (newContent is global::System.Windows.UIElement)
					{
						num2 = (short)79953925;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
				{
					global::DevComponents.WpfRibbon.Ribbon parentRibbon;
					if (parentRibbon != null)
					{
						goto IL_1B9;
					}
					goto IL_E2;
				}
				case 5:
					num2 = (short)1970274305;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfRibbon.RibbonTab.SetTabColor((global::System.Windows.UIElement)newContent, this.Color);
					num2 = (short)1384644615;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					global::DevComponents.WpfRibbon.RibbonTab.SetTabColor((global::System.Windows.UIElement)oldContent, global::DevComponents.WpfRibbon.eRibbonTabColor.Default);
					num2 = (short)2025848832;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return;
				case 8:
				{
					global::DevComponents.WpfRibbon.Ribbon parentRibbon = this.ParentRibbon;
					num2 = (short)154796036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					global::DevComponents.WpfRibbon.Ribbon parentRibbon;
					parentRibbon.SelectedContent = newContent;
					num2 = (short)1872232458;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					goto IL_E2;
				}
				goto IL_3C;
				IL_7C:
				num2 = (short)711065603;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E2:
				num2 = (short)1826095105;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B9:
				num2 = (short)735117321;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_3C:
			base.OnContentChanged(oldContent, newContent);
			num2 = (short)2075066370;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x000AC8B8 File Offset: 0x000AAAB8
		internal global::DevComponents.WpfRibbon.Ribbon ParentRibbon
		{
			get
			{
				short num = (short)1240348325;
				short num2 = num;
				num = (short)853882533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)389677056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)244580352;
				if (num != 0)
				{
				}
				num = (short)1475674113;
				if (num != 0)
				{
				}
				return global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this) as global::DevComponents.WpfRibbon.Ribbon;
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000AC968 File Offset: 0x000AAB68
		protected override void OnAccessKey(global::System.Windows.Input.AccessKeyEventArgs e)
		{
			int num;
			short num2;
			global::DevComponents.WpfRibbon.Ribbon parentRibbon;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_125;
					case 1:
						num2 = (short)402063372;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (parentRibbon != null)
						{
							num2 = (short)207683593;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_279;
					case 3:
						if (!this.IsSelected)
						{
							num2 = (short)1891762180;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1D8;
					case 4:
						num2 = (short)501481480;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_85;
					case 6:
						parentRibbon.IsRibbonMenuOpen = true;
						num2 = (short)395706373;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						if (parentRibbon.IsMinimized)
						{
							num2 = (short)1783824385;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_85;
					case 8:
					{
						num2 = (short)670760960;
						short num3 = num2;
						if (parentRibbon != null)
						{
							num2 = (short)1348468747;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_85;
					}
					case 9:
						num2 = (short)877527041;
						if (num2 != 0)
						{
						}
						parentRibbon.EnterKeyTipsMode();
						num2 = (short)1779367936;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						goto IL_1D8;
					case 11:
						num2 = (short)444268551;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 12:
						if (!parentRibbon.IsRibbonMenuOpen)
						{
							num2 = (short)340983814;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_85;
					}
					goto IL_44;
					IL_85:
					this.IsSelected = true;
					num2 = (short)732233738;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1D8:
					num2 = (short)497352706;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_125:
				num2 = (short)137796962;
				short num4 = num2;
				num2 = (short)2010160482;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4B;
				default:
					num2 = (short)966524928;
					if (num2 != 0)
					{
					}
					break;
				}
				IL_279:
				base.OnAccessKey(e);
				return;
			}
			}
			IL_44:
			parentRibbon = this.ParentRibbon;
			IL_4B:
			num2 = (short)23134211;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x000ACBF8 File Offset: 0x000AADF8
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x000ACCB0 File Offset: 0x000AAEB0
		[global::System.ComponentModel.DefaultValue(global::DevComponents.WpfRibbon.eRibbonTabColor.Default)]
		public global::DevComponents.WpfRibbon.eRibbonTabColor Color
		{
			get
			{
				short num = (short)1408374119;
				short num2 = num;
				num = (short)1043993959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)293339136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2076114945;
				if (num != 0)
				{
				}
				num = (short)124780544;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eRibbonTabColor)base.GetValue(global::DevComponents.WpfRibbon.RibbonTab.ColorProperty);
			}
			set
			{
				short num = (short)729606657;
				short num2 = num;
				num = (short)477227521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)311099392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1705050113;
				if (num != 0)
				{
				}
				num = (short)1591738368;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonTab.ColorProperty, value);
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000ACD6C File Offset: 0x000AAF6C
		private static void OnColorChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)2005877944;
			short num2 = num;
			num = (short)1202144440;
			switch (num2 == num)
			{
			default:
			{
				num = (short)263913472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1337720833;
			if (num != 0)
			{
			}
			num = (short)1537802240;
			if (num != 0)
			{
			}
			(d as global::DevComponents.WpfRibbon.RibbonTab).OnColorChanged((global::DevComponents.WpfRibbon.eRibbonTabColor)e.NewValue);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000ACE30 File Offset: 0x000AB030
		private void OnColorChanged(global::DevComponents.WpfRibbon.eRibbonTabColor newValue)
		{
			short num = (short)1559503585;
			short num2 = num;
			num = (short)1870340833;
			switch (num2 == num)
			{
			default:
			{
				num = (short)292356096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)691273729;
			if (num != 0)
			{
			}
			num = (short)1333592064;
			if (num != 0)
			{
			}
			this.UpdateTabBorderColorClass();
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000ACEE0 File Offset: 0x000AB0E0
		private void UpdateTabBorderColorClass()
		{
			short num = (short)660144129;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfRibbon.eRibbonTabColor color;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
				{
					if (color != global::DevComponents.WpfRibbon.eRibbonTabColor.Default)
					{
						goto IL_144;
					}
					num = (short)324189413;
					short num3 = num;
					num = (short)156351717;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B7;
					default:
						num = (short)1316814848;
						if (num != 0)
						{
						}
						num = (short)1698299907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_13E;
				}
				IL_35:
				if (this.m_TabBorder == null)
				{
					num = (short)32964608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B7:
				color = this.Color;
				num = (short)538116098;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_13E:
			num = (short)598867968;
			short num4 = num;
			num = (short)978255873;
			if (num != 0)
			{
			}
			this.m_TabBorder.ColorClass = global::DevComponents.WpfRibbon.RibbonColors.RibbonTabClass;
			return;
			IL_144:
			this.m_TabBorder.ColorClass = global::DevComponents.WpfRibbon.RibbonColors.RibbonTabClass + color.ToString();
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000AD054 File Offset: 0x000AB254
		private static void OnContextGroupChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1315084710;
			short num2 = num;
			num = (short)1035311526;
			switch (num2 == num)
			{
			default:
			{
				num = (short)741343232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1869873153;
			if (num != 0)
			{
			}
			num = (short)1911422976;
			if (num != 0)
			{
			}
			(d as global::DevComponents.WpfRibbon.RibbonTab).OnContextGroupChanged(e.OldValue as global::DevComponents.WpfRibbon.ContextGroup, e.NewValue as global::DevComponents.WpfRibbon.ContextGroup);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000AD120 File Offset: 0x000AB320
		private void OnContextGroupChanged(global::DevComponents.WpfRibbon.ContextGroup oldGroup, global::DevComponents.WpfRibbon.ContextGroup newGroup)
		{
			short num = (short)211877891;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EF;
				case 1:
					oldGroup.LinkedTabs.Remove(this);
					num = (short)1659568133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					newGroup.LinkedTabs.Add(this);
					num = (short)1628569600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					if (newGroup != null)
					{
						num = (short)1027604482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					goto IL_11C;
				}
				IL_3C:
				num = (short)707390047;
				short num3 = num;
				num = (short)84601439;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1279918080;
					if (num != 0)
					{
					}
					num = (short)1208942593;
					if (num != 0)
					{
					}
					if (oldGroup != null)
					{
						num = (short)639369217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_11C:
				num = (short)307691524;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			num = (short)2020999168;
			short num4 = num;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000AD2A8 File Offset: 0x000AB4A8
		private static void OnIsSelectedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1816788992;
					short num3 = num2;
					num2 = (short)1904779740;
					short num4 = num2;
					num2 = (short)52994524;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_87;
					default:
						num2 = (short)1568604160;
						if (num2 != 0)
						{
						}
						ribbonTab.OnSelected(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.Primitives.Selector.SelectedEvent, ribbonTab));
						num2 = (short)194379779;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if ((bool)e.NewValue)
					{
						num2 = (short)1058734080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_87;
				case 2:
					goto IL_D5;
				case 3:
					goto IL_14D;
				}
				goto IL_20;
				IL_87:
				num2 = (short)226361345;
				if (num2 != 0)
				{
				}
				ribbonTab.OnUnselected(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.Primitives.Selector.UnselectedEvent, ribbonTab));
				num2 = (short)1088815106;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D5:
			IL_14D:
			ribbonTab.UpdateBorderRenderState();
			return;
			IL_20:
			ribbonTab = (d as global::DevComponents.WpfRibbon.RibbonTab);
			num2 = (short)1750204417;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000AD40C File Offset: 0x000AB60C
		protected virtual void OnSelected(global::System.Windows.RoutedEventArgs e)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1233453056;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
					{
						global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)base.Content;
						uielement.ClearValue(global::DevComponents.WpfRibbon.RibbonTab.TabColorProperty);
						global::DevComponents.WpfRibbon.RibbonTab.SetTabColor(uielement, this.Color);
						num = (short)1667170304;
						short num3 = num;
						num = (short)52756482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_103;
					}
					IL_31:
					num = (short)1077855500;
					short num4 = num;
					num = (short)1344783628;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)1428815872;
						if (num != 0)
						{
						}
						if (!(base.Content is global::System.Windows.UIElement))
						{
							goto IL_12D;
						}
						num = (short)1116798977;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_103:
			num = (short)1960509441;
			if (num != 0)
			{
			}
			IL_12D:
			this.RaiseSelectedEvents(true, e);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000AD550 File Offset: 0x000AB750
		protected virtual void OnUnselected(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2122214818;
			short num2 = num;
			num = (short)1292332450;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1246232576;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2011037697;
			if (num != 0)
			{
			}
			num = (short)182452224;
			if (num != 0)
			{
			}
			this.RaiseSelectedEvents(false, e);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000AD600 File Offset: 0x000AB800
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
					num2 = (short)2001403905;
					if (num2 != 0)
					{
					}
					if (e.NewFocus == this)
					{
						num2 = (short)2022309890;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					num2 = (short)362872832;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)29949952;
					short num3 = num2;
					num2 = (short)1560805379;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (!this.IsSelected)
					{
						num2 = (short)1206845445;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
				{
					num2 = (short)1553527443;
					short num4 = num2;
					num2 = (short)2008085139;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)197853184;
						if (num2 != 0)
						{
						}
						if (!e.Handled)
						{
							num2 = (short)427687937;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 5:
					this.IsSelected = true;
					num2 = (short)1344405510;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return;
				}
				goto IL_2C;
			}
			return;
			IL_2C:
			base.OnGotKeyboardFocus(e);
			num2 = (short)247922692;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000AD7B8 File Offset: 0x000AB9B8
		private void RaiseSelectedEvents(bool newValue, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)885221514;
			short num2 = num;
			num = (short)992372874;
			switch (num2 == num)
			{
			}
			num = (short)2080440321;
			if (num != 0)
			{
			}
			num = (short)431423488;
			short num3 = num;
			num = (short)770703360;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x000AD868 File Offset: 0x000ABA68
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x000AD920 File Offset: 0x000ABB20
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsSelected
		{
			get
			{
				short num = (short)1171900522;
				short num2 = num;
				num = (short)100714602;
				switch (num2 == num)
				{
				}
				num = (short)852754432;
				if (num != 0)
				{
				}
				num = (short)1083179008;
				short num3 = num;
				num = (short)1692991489;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonTab.IsSelectedProperty);
			}
			set
			{
				short num = (short)2001515322;
				short num2 = num;
				num = (short)1339077434;
				switch (num2 == num)
				{
				}
				num = (short)868352001;
				if (num != 0)
				{
				}
				num = (short)1621688320;
				short num3 = num;
				num = (short)1663434752;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonTab.IsSelectedProperty, value);
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000AD9DC File Offset: 0x000ABBDC
		protected override void OnMouseDoubleClick(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)230162438;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1124990977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (e.Source == this)
					{
						num = (short)1569456133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F5;
				case 2:
				{
					num = (short)535155177;
					short num3 = num;
					num = (short)920572393;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F4;
					default:
						goto IL_1B6;
					}
					break;
				}
				case 3:
				{
					global::DevComponents.WpfRibbon.Ribbon ribbon;
					ribbon.IsMinimized = !ribbon.IsMinimized;
					e.Handled = true;
					num = (short)1555496962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1423638529;
					if (num != 0)
					{
					}
					global::DevComponents.WpfRibbon.Ribbon ribbon;
					if (ribbon != null)
					{
						goto IL_F4;
					}
					goto IL_1F5;
				}
				case 5:
				{
					global::DevComponents.WpfRibbon.Ribbon ribbon = this.GetRibbon();
					num = (short)310116356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 7:
					num = (short)1320419336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					global::DevComponents.WpfRibbon.Ribbon ribbon;
					if (ribbon.AutoExpand)
					{
						num = (short)1682374659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F5;
				}
				}
				IL_48:
				if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
				{
					num = (short)242221056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1F5;
				IL_F4:
				num = (short)1469251591;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1B6:
			num = (short)162922496;
			short num4 = num;
			num = (short)876085248;
			if (num != 0)
			{
			}
			IL_1F5:
			base.OnMouseDoubleClick(e);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000ADBE8 File Offset: 0x000ABDE8
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_70;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::DevComponents.WpfRibbon.Ribbon ribbon;
				switch (num)
				{
				case 0:
				{
					global::System.Windows.Window window;
					if (!window.IsActive)
					{
						num2 = (short)1768030214;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_282;
				}
				case 1:
					if (!this.IsSelected)
					{
						num2 = (short)902299648;
						short num3 = num2;
						num2 = (short)1368850437;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F7;
				case 2:
					goto IL_3AA;
				case 3:
					num2 = (short)1439891465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1351876608;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					this.IsSelected = true;
					num2 = (short)235929612;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return;
				case 7:
					if (!this.m_IsRibbonMenuOpen)
					{
						num2 = (short)1403387923;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					num2 = (short)2072707079;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (this.IsSelected)
					{
						num2 = (short)249298967;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3AA;
				case 10:
					if (this.m_IsMinimizedState)
					{
						num2 = (short)1388642312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					return;
				case 12:
					goto IL_F7;
				case 13:
				{
					global::System.Windows.Window window = global::System.Windows.Window.GetWindow(ribbon);
					num2 = (short)1771175953;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 14:
					if (e.Source == this)
					{
						num2 = (short)598212611;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 15:
					if (ribbon != null)
					{
						num2 = (short)1965096973;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 16:
					IL_8F:
					if (!global::DevComponents.WpfRibbon.WinApi.KeyValidated)
					{
						num2 = (short)1711341589;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)396754958;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
				{
					global::System.Windows.Window window;
					if (window != null)
					{
						num2 = (short)1832910852;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_282;
				}
				case 18:
					num2 = (short)1590099988;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					ribbon = this.GetRibbon();
					num2 = (short)2490383;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (!this.m_IsRibbonMenuOpen)
					{
						num2 = (short)1864040450;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 21:
					return;
				case 22:
					num2 = (short)1420886017;
					if (num2 != 0)
					{
					}
					if (this.m_IsMinimizedState)
					{
						num2 = (short)1163132946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 23:
					num2 = (short)1869086742;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_70;
				IL_282:
				ribbon.IsRibbonMenuOpen = true;
				num2 = (short)1670447115;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3AA:
				num2 = (short)257163265;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_F7:
				e.Handled = true;
				num2 = (short)958640113;
				short num4 = num2;
				num2 = (short)496807921;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8F;
				default:
					num2 = (short)739246080;
					if (num2 != 0)
					{
					}
					num2 = (short)1342832650;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return;
			IL_70:
			base.OnMouseLeftButtonDown(e);
			num2 = (short)240713744;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000AE008 File Offset: 0x000AC208
		private global::DevComponents.WpfRibbon.Ribbon GetRibbon()
		{
			short num = (short)156958723;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.DependencyObject dependencyObject;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)429457408;
					short num3 = num;
					goto IL_165;
				}
				case 1:
					if (dependencyObject is global::DevComponents.WpfRibbon.Ribbon)
					{
						goto IL_C2;
					}
					goto IL_165;
				case 2:
					if (base.Parent is global::DevComponents.WpfRibbon.Ribbon)
					{
						num = (short)138412036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					dependencyObject = this;
					num = (short)356974592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)647495681;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 4:
					goto IL_160;
				case 5:
					if (dependencyObject == null)
					{
						num = (short)50069511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
					num = (short)1830027265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_D9;
				case 7:
					goto IL_1E5;
				case 8:
					goto IL_95;
				}
				IL_70:
				if (base.TemplatedParent is global::DevComponents.WpfRibbon.Ribbon)
				{
					num = (short)218628104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1006829570;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C2:
				num = (short)1551630342;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_165:
				num = (short)1113456985;
				short num4 = num;
				num = (short)219545945;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C2;
				default:
					num = (short)657457152;
					if (num != 0)
					{
					}
					num = (short)202113029;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_95:
			return base.TemplatedParent as global::DevComponents.WpfRibbon.Ribbon;
			IL_D9:
			return dependencyObject as global::DevComponents.WpfRibbon.Ribbon;
			IL_160:
			return base.Parent as global::DevComponents.WpfRibbon.Ribbon;
			IL_1E5:
			return null;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000AE21C File Offset: 0x000AC41C
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)920206775;
			short num2 = num;
			num = (short)2056076727;
			switch (num2 == num)
			{
			}
			num = (short)1429929984;
			short num3 = num;
			num = (short)1061879809;
			if (num != 0)
			{
			}
			num = (short)1012334592;
			if (num != 0)
			{
			}
			base.OnMouseEnter(e);
			this.UpdateBorderRenderState();
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000AE2D4 File Offset: 0x000AC4D4
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1291059201;
			if (num != 0)
			{
			}
			num = (short)1318101461;
			short num2 = num;
			num = (short)569221589;
			switch (num2 == num)
			{
			default:
			{
				num = (short)237174784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1054474240;
			if (num != 0)
			{
			}
			base.OnMouseLeave(e);
			this.UpdateBorderRenderState();
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000AE38C File Offset: 0x000AC58C
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
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
				{
					for (;;)
					{
						this.UpdateBorderRenderState();
						num2 = (short)609260216;
						short num3 = num2;
						num2 = (short)257659576;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_94;
						}
					}
					IL_94:
					num2 = (short)403308544;
					if (num2 != 0)
					{
					}
					num2 = (short)2072248321;
					if (num2 != 0)
					{
					}
					num2 = (short)2032402432;
					short num4 = num2;
					num2 = (short)537395201;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
					if (this.IsSelected)
					{
						num2 = (short)1976958976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			base.OnMouseMove(e);
			num2 = (short)722403330;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000AE4AC File Offset: 0x000AC6AC
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)524156929;
			if (num != 0)
			{
			}
			num = (short)771643591;
			short num2 = num;
			num = (short)2050971847;
			switch (num2 == num)
			{
			default:
			{
				num = (short)817692672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1141768192;
			if (num != 0)
			{
			}
			base.OnIsKeyboardFocusWithinChanged(e);
			this.UpdateBorderRenderState();
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x000AE564 File Offset: 0x000AC764
		private bool RibbonKeyTipsEnabled
		{
			get
			{
				global::DevComponents.WpfRibbon.Ribbon ribbon = this.GetRibbon();
				short num;
				if (ribbon != null)
				{
					for (;;)
					{
						num = (short)530841601;
						if (num != 0)
						{
						}
						num = (short)1912040841;
						short num2 = num;
						num = (short)390360457;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_67;
						}
					}
					IL_67:
					num = (short)719847424;
					if (num != 0)
					{
					}
					return ribbon.ShowKeyTips;
				}
				num = (short)1436811264;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000AE620 File Offset: 0x000AC820
		internal void UpdateBorderRenderState()
		{
			short num = (short)853868572;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfRibbon.eRibbonTabRenderingState eRibbonTabRenderingState;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (this.IsSelected)
					{
						num = (short)1644232735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					eRibbonTabRenderingState = global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Hover;
					num = (short)593559571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_27F;
				case 3:
					this.m_TabBorder.TabState = eRibbonTabRenderingState;
					num = (short)2056519692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.m_IsMinimizedState)
					{
						num = (short)1097662477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31A;
				case 5:
					if (base.IsKeyboardFocusWithin)
					{
						num = (short)1867513876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_185;
				case 6:
				{
					num = (short)1488257024;
					short num3 = num;
					if (this.m_IsRibbonMenuOpen)
					{
						num = (short)1306460182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1900806151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					global::System.Windows.Rect rect;
					if (rect.Contains(global::System.Windows.Input.Mouse.GetPosition(this)))
					{
						num = (short)199950352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27F;
				}
				case 8:
					if (this.RibbonKeyTipsEnabled)
					{
						num = (short)2070872081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_185;
				case 9:
					num = (short)1977155590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (this.m_TabBorder.TabState != eRibbonTabRenderingState)
					{
						num = (short)1535901699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					goto IL_31A;
				case 12:
					return;
				case 13:
					num = (short)950992919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (this.m_IsMinimizedState)
					{
						num = (short)1144455177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)747175957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)117243908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					eRibbonTabRenderingState = global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Hover;
					num = (short)1744633882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					eRibbonTabRenderingState = global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Focused;
					num = (short)1693712413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_27F;
				case 19:
					goto IL_27F;
				case 20:
					num = (short)1636892680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
				{
					global::System.Windows.Rect rect;
					if (rect.Contains(global::System.Windows.Input.Mouse.GetPosition(this)))
					{
						num = (short)1442709536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					eRibbonTabRenderingState = global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Selected;
					num = (short)1508507649;
					if (num != 0)
					{
					}
					num = (short)143327250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 22:
					eRibbonTabRenderingState = global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Selected;
					num = (short)1838809113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (this.m_IsRibbonMenuOpen)
					{
						num = (short)1661599755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27F;
				case 24:
					num = (short)690683905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_27F;
				case 26:
					goto IL_27F;
				case 27:
					if (this.IsSelected)
					{
						num = (short)1134231567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27F;
				case 28:
					switch (0)
					{
					case 0:
						goto IL_AC;
					}
					continue;
				case 29:
					goto IL_27F;
				case 30:
					goto IL_27F;
				case 31:
				{
					global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
					num = (short)1428291598;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 32:
					eRibbonTabRenderingState = global::DevComponents.WpfRibbon.eRibbonTabRenderingState.HoverSelected;
					num = (short)340066334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					if (base.IsMouseOver)
					{
						num = (short)1968046104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1028718619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AC:
				if (this.m_TabBorder != null)
				{
					eRibbonTabRenderingState = global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Normal;
					num = (short)389480453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)619902339;
				short num4 = num;
				num = (short)548533635;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)474218496;
					if (num != 0)
					{
					}
					num = (short)729612288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_185:
				num = (short)593559585;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27F:
				num = (short)640024586;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_31A:
				eRibbonTabRenderingState = global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Selected;
				num = (short)344981506;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x000AEBB4 File Offset: 0x000ACDB4
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x000AEC64 File Offset: 0x000ACE64
		internal bool IsMinimizedState
		{
			get
			{
				short num = (short)1248760063;
				short num2 = num;
				num = (short)477925631;
				switch (num2 == num)
				{
				}
				num = (short)195821568;
				short num3 = num;
				num = (short)177995776;
				if (num != 0)
				{
				}
				num = (short)1836187649;
				if (num != 0)
				{
				}
				return this.m_IsMinimizedState;
			}
			set
			{
				short num = (short)2013003777;
				if (num != 0)
				{
				}
				num = (short)288686082;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1604940327;
						short num3 = num;
						num = (short)463761959;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)2048131072;
							if (num != 0)
							{
							}
							this.m_IsMinimizedState = value;
							this.UpdateBorderRenderState();
							num = (short)1529085952;
							short num4 = num;
							num = (short)2045771777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					}
					IL_56:
					if (this.m_IsMinimizedState == value)
					{
						break;
					}
					num = (short)1988231168;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x000AED84 File Offset: 0x000ACF84
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x000AEE34 File Offset: 0x000AD034
		internal bool IsRibbonMenuOpen
		{
			get
			{
				short num = (short)1134288028;
				short num2 = num;
				num = (short)1872419996;
				switch (num2 == num)
				{
				}
				num = (short)2075197440;
				short num3 = num;
				num = (short)1865613312;
				if (num != 0)
				{
				}
				num = (short)1560215553;
				if (num != 0)
				{
				}
				return this.m_IsRibbonMenuOpen;
			}
			set
			{
				short num = (short)1905524738;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)64107281;
						short num3 = num;
						num = (short)1580151569;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)129236992;
							if (num != 0)
							{
							}
							num = (short)523239425;
							if (num != 0)
							{
							}
							this.m_IsRibbonMenuOpen = value;
							this.UpdateBorderRenderState();
							num = (short)951320576;
							short num4 = num;
							num = (short)802684929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (this.m_IsRibbonMenuOpen == value)
					{
						break;
					}
					num = (short)492240896;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000AEF5C File Offset: 0x000AD15C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			global::System.Windows.Size result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (this.ContextGroup != null)
					{
						num2 = (short)1614741508;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					global::System.Windows.Size desiredSize = this.ContextGroup.DesiredSize;
					result.Width = global::System.Math.Ceiling(desiredSize.Width);
					num2 = (short)2042429440;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					num2 = (short)1843003393;
					if (num2 != 0)
					{
					}
					num2 = (short)1038551132;
					short num3 = num2;
					num2 = (short)1822885980;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_162;
					default:
					{
						num2 = (short)2066939904;
						if (num2 != 0)
						{
						}
						global::System.Windows.Size desiredSize;
						if (desiredSize.Width > result.Width)
						{
							num2 = (short)2011955202;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 4:
					num2 = (short)1017315335;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (global::System.Math.Ceiling(result.Width) < global::System.Math.Ceiling(constraint.Width))
					{
						num2 = (short)1417347082;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
				{
					this.ContextGroup.Measure(constraint);
					global::System.Windows.Size desiredSize = this.ContextGroup.DesiredSize;
					num2 = (short)323420163;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					if (this.ContextGroup.Visibility == global::System.Windows.Visibility.Visible)
					{
						num2 = (short)753860608;
						short num4 = num2;
						num2 = (short)1557790729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 8:
					if (this.ContextGroup.LinkedTabs.Count == 1)
					{
						num2 = (short)1571422214;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 9:
					goto IL_162;
				case 10:
					num2 = (short)208338945;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3C;
				IL_162:
				num2 = (short)1777598472;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_3C:
			result = base.MeasureOverride(constraint);
			num2 = (short)1511391237;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000AF1F8 File Offset: 0x000AD3F8
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static global::DevComponents.WpfRibbon.eRibbonTabColor GetTabColor(global::System.Windows.UIElement element)
		{
			int a_ = 17;
			short num;
			if (element == null)
			{
				for (;;)
				{
					num = (short)1857445955;
					short num2 = num;
					num = (short)1590059075;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_46;
					}
				}
				IL_46:
				num = (short)1957167105;
				if (num != 0)
				{
				}
				num = (short)1674903552;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("౨ݪ࡬ɮ", a_));
			}
			num = (short)576847872;
			short num3 = num;
			return (global::DevComponents.WpfRibbon.eRibbonTabColor)element.GetValue(global::DevComponents.WpfRibbon.RibbonTab.TabColorProperty);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000AF2D4 File Offset: 0x000AD4D4
		public static void SetTabColor(global::System.Windows.UIElement element, global::DevComponents.WpfRibbon.eRibbonTabColor tabColor)
		{
			int a_ = 16;
			short num;
			if (element == null)
			{
				for (;;)
				{
					num = (short)1305214977;
					if (num != 0)
					{
					}
					num = (short)1388818970;
					short num2 = num;
					num = (short)66695706;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6D;
					}
				}
				IL_6D:
				num = (short)1903034368;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("൧٩५ͭ", a_));
			}
			num = (short)422248448;
			short num3 = num;
			element.SetValue(global::DevComponents.WpfRibbon.RibbonTab.TabColorProperty, tabColor);
		}

		// Token: 0x0400067A RID: 1658
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty;

		// Token: 0x0400067B RID: 1659
		public static readonly global::System.Windows.DependencyProperty ContextGroupProperty;

		// Token: 0x0400067C RID: 1660
		public static readonly global::System.Windows.DependencyProperty ColorProperty;

		// Token: 0x0400067D RID: 1661
		public static readonly global::System.Windows.DependencyProperty TabColorProperty;

		// Token: 0x0400067E RID: 1662
		private global::DevComponents.WpfRibbon.RibbonTabBorder m_TabBorder;

		// Token: 0x0400067F RID: 1663
		private const string RibbonTabBorderName = "PART_RibbonTabBorder";

		// Token: 0x04000680 RID: 1664
		internal static int MinimumTabWidth;

		// Token: 0x04000681 RID: 1665
		private bool m_IsMinimizedState;

		// Token: 0x04000682 RID: 1666
		private bool m_IsRibbonMenuOpen;
	}
}
