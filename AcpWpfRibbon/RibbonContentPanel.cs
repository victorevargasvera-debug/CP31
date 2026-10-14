using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200009B RID: 155
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RibbonContentPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x000A6FEC File Offset: 0x000A51EC
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x000A70A8 File Offset: 0x000A52A8
		public global::DevComponents.WpfRibbon.eRibbonVisualStyle VisualStyle
		{
			get
			{
				short num = (short)1004629211;
				short num2 = num;
				num = (short)461139163;
				switch (num2 == num)
				{
				}
				num = (short)972357632;
				short num3 = num;
				num = (short)985071617;
				if (num != 0)
				{
				}
				num = (short)746717184;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eRibbonVisualStyle)base.GetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.VisualStyleProperty);
			}
			set
			{
				short num = (short)344050817;
				short num2 = num;
				num = (short)16764033;
				switch (num2 == num)
				{
				}
				num = (short)610271232;
				short num3 = num;
				num = (short)1867579392;
				if (num != 0)
				{
				}
				num = (short)1106182145;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.VisualStyleProperty, value);
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000A7164 File Offset: 0x000A5364
		private static void OnVisualStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1890469654;
			short num2 = num;
			num = (short)1252476694;
			switch (num2 == num)
			{
			}
			num = (short)1187708928;
			short num3 = num;
			num = (short)1993867264;
			if (num != 0)
			{
			}
			num = (short)381419521;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.RibbonContentPanel)o).OnVisualStyleChanged((global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.OldValue, (global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.NewValue);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000A7230 File Offset: 0x000A5430
		private void OnVisualStyleChanged(global::DevComponents.WpfRibbon.eRibbonVisualStyle oldValue, global::DevComponents.WpfRibbon.eRibbonVisualStyle newValue)
		{
			for (;;)
			{
				IL_00:
				short num = (short)988282881;
				if (num != 0)
				{
				}
				num = (short)327942144;
				short num2 = num;
				num = (short)1456734211;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (newValue != global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Blue)
						{
							num = (short)897908741;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					case 1:
						goto IL_127;
					case 2:
						if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Black)
						{
							num = (short)1418330113;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 3:
					{
						num = (short)652076981;
						short num4 = num;
						num = (short)739764149;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)259194880;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_D6;
							}
							continue;
						}
						break;
					}
					case 4:
						num = (short)1602682880;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)162988034;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D6:
					if (newValue == global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Silver)
					{
						goto IL_F0;
					}
					num = (short)1180893188;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_F0:
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010;
			return;
			IL_127:
			goto IL_F0;
			IL_15F:
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007;
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000A73A4 File Offset: 0x000A55A4
		private bool IsDesignMode
		{
			get
			{
				short num = (short)948858814;
				short num2 = num;
				num = (short)1922723774;
				switch (num2 == num)
				{
				}
				num = (short)1646985216;
				short num3 = num;
				num = (short)1008467968;
				if (num != 0)
				{
				}
				num = (short)1230831617;
				if (num != 0)
				{
				}
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x000A7458 File Offset: 0x000A5658
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x000A7510 File Offset: 0x000A5710
		public global::DevComponents.WpfRibbon.eEffectiveStyle EffectiveStyle
		{
			get
			{
				short num = (short)1327052677;
				short num2 = num;
				num = (short)348600197;
				switch (num2 == num)
				{
				}
				num = (short)203030528;
				short num3 = num;
				num = (short)241893376;
				if (num != 0)
				{
				}
				num = (short)2034565121;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eEffectiveStyle)base.GetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.EffectiveStyleProperty);
			}
			internal set
			{
				short num = (short)852899939;
				short num2 = num;
				num = (short)613103715;
				switch (num2 == num)
				{
				}
				num = (short)310575104;
				short num3 = num;
				num = (short)369098753;
				if (num != 0)
				{
				}
				num = (short)1959329792;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.EffectiveStylePropertyKey, value);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000A75CC File Offset: 0x000A57CC
		private static void OnEffectiveStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)473563136;
			short num2 = num;
			num = (short)803892854;
			short num3 = num;
			num = (short)835546742;
			global::DevComponents.WpfRibbon.RibbonContentPanel ribbonContentPanel;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AB:
				if (ribbonContentPanel == null)
				{
					return;
				}
				num = (short)1813184513;
				if (num != 0)
				{
				}
				num = (short)713883648;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)416940032;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				break;
			}
			for (;;)
			{
				IL_7D:
				switch (num4)
				{
				case 0:
					ribbonContentPanel.OnEffectiveStyleChanged((global::DevComponents.WpfRibbon.eEffectiveStyle)e.OldValue, (global::DevComponents.WpfRibbon.eEffectiveStyle)e.NewValue);
					num = (short)1761804290;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_AB;
				case 2:
					goto IL_120;
				}
				goto IL_8F;
			}
			IL_120:
			return;
			IL_8F:
			ribbonContentPanel = (o as global::DevComponents.WpfRibbon.RibbonContentPanel);
			num = (short)1289027585;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7D;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000A76FC File Offset: 0x000A58FC
		protected virtual void OnEffectiveStyleChanged(global::DevComponents.WpfRibbon.eEffectiveStyle oldValue, global::DevComponents.WpfRibbon.eEffectiveStyle newValue)
		{
			short num = (short)1924971102;
			short num2 = num;
			num = (short)847100510;
			switch (num2 == num)
			{
			}
			num = (short)135593984;
			short num3 = num;
			num = (short)622198784;
			if (num != 0)
			{
			}
			num = (short)1084096513;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000A77A4 File Offset: 0x000A59A4
		static RibbonContentPanel()
		{
			int a_ = 0;
			short num = (short)358547457;
			if (num != 0)
			{
			}
			num = (short)2079640462;
			short num2 = num;
			num = (short)982109070;
			switch (num2 == num)
			{
			default:
			{
				num = (short)360316928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)508559360;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonContentPanel.VisualStyleProperty = global::DevComponents.WpfRibbon.Ribbon.VisualStyleProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.RibbonContentPanel), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Blue, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonContentPanel.OnVisualStyleChanged)));
			global::DevComponents.WpfRibbon.RibbonContentPanel.EffectiveStylePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵗ㱙㩛㭝͟ᙡൣၥ൧㥩ᡫ᝭ᱯ᝱", a_), typeof(global::DevComponents.WpfRibbon.eEffectiveStyle), typeof(global::DevComponents.WpfRibbon.RibbonContentPanel), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonContentPanel.OnEffectiveStyleChanged)));
			global::DevComponents.WpfRibbon.RibbonContentPanel.EffectiveStyleProperty = global::DevComponents.WpfRibbon.RibbonContentPanel.EffectiveStylePropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.RibbonContentPanel.ContentPartProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭗㕙㉛⩝՟ౡၣ㙥१ᡩᡫ", a_), typeof(global::DevComponents.WpfRibbon.eRibbonContentPart), typeof(global::DevComponents.WpfRibbon.RibbonContentPanel), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonContentPart.None, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonContentPanel.OnContentPartChanged)), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.RibbonContentPanel.IsPartValid));
			global::DevComponents.WpfRibbon.RibbonContentPanel.WindowBorderThicknessProperty = global::DevComponents.WpfRibbon.Ribbon.WindowBorderThicknessProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.RibbonContentPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Thickness(3.0, 0.0, 3.0, 0.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonContentPanel.OnWindowBorderThicknessChanged)));
			global::DevComponents.WpfRibbon.RibbonContentPanel.IsGlassEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᅗ⥙᭛㉝şᅡᝣ⍥٧୩๫ɭᕯᙱ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.RibbonContentPanel), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonContentPanel.IsGlassEnabledChanged)));
			global::DevComponents.WpfRibbon.RibbonContentPanel.IsVisibleAutoChangedProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᅗ⥙ਜ਼㝝፟ୡ٣੥൧⭩ᥫᩭὯㅱᱳ᝵ᙷᵹ᥻᩽", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.RibbonContentPanel), new global::System.Windows.PropertyMetadata(false));
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000A7A00 File Offset: 0x000A5C00
		protected override void OnInitialized(global::System.EventArgs e)
		{
			short num = (short)2014215303;
			short num2 = num;
			num = (short)2076933255;
			switch (num2 == num)
			{
			}
			num = (short)334823424;
			short num3 = num;
			num = (short)1896349697;
			if (num != 0)
			{
			}
			num = (short)1143930880;
			if (num != 0)
			{
			}
			this.CreateBackgroundChrome();
			base.OnInitialized(e);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000A7AB8 File Offset: 0x000A5CB8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)371916800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_DE;
				}
				global::System.Windows.Size size;
				global::System.Windows.Size s;
				global::System.Windows.Size s2;
				global::System.Windows.Size size2;
				global::System.Windows.UIElement uielement;
				global::System.Collections.IEnumerator enumerator;
				bool isMinimumSized;
				for (;;)
				{
					IL_27:
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						size = new global::System.Windows.Size(global::System.Math.Max(s.Width + s2.Width, size2.Width) + this.WindowBorderThickness.Left + this.WindowBorderThickness.Right, global::System.Math.Max(s.Height, global::System.Math.Max(s2.Height, this.m_BackChrome.TitleChromeHeight) + size2.Height + (double)this.QatTabSpacing + this.WindowBorderThickness.Top));
						num = (short)875560982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)1010761742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B74;
					case 2:
					{
						num = (short)1348403200;
						short num3 = num;
						if (global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(s2))
						{
							num = (short)1507131401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E14;
					}
					case 3:
						if (global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(s))
						{
							num = (short)2145910802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D7;
					case 4:
						this.m_BackChrome.Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)694878224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_B74;
					case 6:
						num = (short)1154678786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							num = (short)867303425;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.UIElement uielement2;
								global::System.Windows.Size availableSize2;
								switch (num2)
								{
								case 0:
									uielement = uielement2;
									num = (short)160301076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5A4;
									}
									continue;
								case 2:
									if (global::DevComponents.WpfRibbon.RibbonContentPanel.GetContentPart(uielement2) == global::DevComponents.WpfRibbon.eRibbonContentPart.ApplicationMenu)
									{
										num = (short)2047606817;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A4F;
								case 3:
									availableSize2.Width = global::System.Math.Max(availableSize.Width - 120.0, 22.0);
									num = (short)437059598;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1134297104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (uielement2.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)2131427334;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									uielement2.Measure(availableSize);
									num = (short)655228945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									availableSize2 = availableSize;
									num = (short)1130561545;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (availableSize.Width < double.PositiveInfinity)
									{
										num = (short)608108547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_91F;
								case 10:
									uielement2.Visibility = global::System.Windows.Visibility.Collapsed;
									global::DevComponents.WpfRibbon.RibbonContentPanel.SetIsVisibleAutoChanged(uielement2, true);
									num = (short)1671692301;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_617;
								case 12:
									num = (short)249167877;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_617;
								case 14:
									goto IL_91F;
								case 15:
									if (uielement2 != this.m_BackChrome)
									{
										num = (short)36372492;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 16:
									if (uielement2.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)599326727;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5D4;
								case 18:
									goto IL_AAE;
								case 19:
									num = (short)1227096090;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									if (!enumerator.MoveNext())
									{
										num = (short)1964245021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uielement2 = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)358940708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									if (!isMinimumSized)
									{
										num = (short)1769930783;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_617;
								case 23:
									if (global::DevComponents.WpfRibbon.RibbonContentPanel.GetContentPart(uielement2) == global::DevComponents.WpfRibbon.eRibbonContentPart.Tabs)
									{
										num = (short)1579024384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1536229391;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									if (global::DevComponents.WpfRibbon.RibbonContentPanel.GetIsVisibleAutoChanged(uielement2))
									{
										num = (short)1714815004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_617;
								case 26:
									if (uielement2.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)1591410698;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_795;
								case 27:
									uielement2.Measure(availableSize);
									s = uielement2.DesiredSize;
									num = (short)1654980616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									uielement2.Visibility = global::System.Windows.Visibility.Visible;
									global::DevComponents.WpfRibbon.RibbonContentPanel.SetIsVisibleAutoChanged(uielement2, false);
									num = (short)1979318283;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									num = (short)375914514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									if (uielement2 != this.m_BackChrome)
									{
										num = (short)1205141523;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_795;
								case 31:
									num = (short)930807832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									if (uielement2.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)703922203;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A4F;
								case 33:
									num = (short)1071972384;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									num = (short)833159198;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
									if (global::DevComponents.WpfRibbon.RibbonContentPanel.GetContentPart(uielement2) == global::DevComponents.WpfRibbon.eRibbonContentPart.QuickAccessToolbar)
									{
										num = (short)2110914564;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5D4;
								case 36:
									if (isMinimumSized)
									{
										num = (short)912850978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_795;
								}
								goto IL_5A4;
								IL_5D4:
								num = (short)1445330967;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_617:
								num = (short)460390402;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_795:
								num = (short)514129942;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_91F:
								uielement2.Measure(availableSize2);
								s2 = uielement2.DesiredSize;
								num = (short)820838425;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_94A:
								num = (short)1754660885;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5A4:
								goto IL_94A;
								IL_A4F:
								num = (short)638255139;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_AAE:
							goto IL_E32;
						}
						finally
						{
							num = (short)442084910;
							short num4 = num;
							num = (short)265268782;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_B5C:
								num = (short)279183360;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)649068544;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_B1C;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_B09:
								switch (num2)
								{
								case 0:
									goto IL_B71;
								case 1:
									goto IL_B53;
								case 2:
									if (disposable != null)
									{
										num = (short)620625921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B73;
								}
								goto IL_B1C;
							}
							IL_B53:
							disposable.Dispose();
							goto IL_B5C;
							IL_B71:
							IL_B73:
							goto EndFinally_33;
							IL_B1C:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)553713666;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_B09;
							EndFinally_33:;
						}
						goto IL_B74;
						IL_E32:
						num = (short)681443364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						size = new global::System.Windows.Size(global::System.Math.Max(s.Width + size2.Width, s2.Width) + this.WindowBorderThickness.Left + this.WindowBorderThickness.Right, global::System.Math.Max(s2.Height, this.m_BackChrome.TitleChromeHeight) + global::System.Math.Max(s.Height, size2.Height) + (double)this.QatTabSpacing + this.WindowBorderThickness.Top);
						num = (short)999227434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1112473617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_DCA;
					case 11:
						if (!isMinimumSized)
						{
							num = (short)1064042523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D7;
					case 12:
						num = (short)680853507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						size.Width = availableSize.Width;
						num = (short)504627219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::System.Windows.Size availableSize3 = availableSize;
						availableSize3.Width = global::System.Math.Max(6.0, availableSize3.Width - s.Width) - this.WindowBorderThickness.Right;
						uielement.Measure(availableSize3);
						size2 = uielement.DesiredSize;
						size2.Height += this.WindowBorderThickness.Top;
						size2.Width += this.WindowBorderThickness.Right;
						num = (short)1703018501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						size = new global::System.Windows.Size(availableSize.Width, this.m_BackChrome.TotalTitleChromeHeight);
						num = (short)2057371658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_41C;
					case 17:
						num = (short)1427636225;
						if (num != 0)
						{
						}
						flag = isMinimumSized;
						goto IL_C52;
					case 18:
						num = (short)1888616474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_29A;
					case 20:
						return size;
					case 21:
						if (flag2)
						{
							num = (short)1859977224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						size = new global::System.Windows.Size(global::System.Math.Max(s.Width + s2.Width, size2.Width) + this.WindowBorderThickness.Left + this.WindowBorderThickness.Right, global::System.Math.Max(s.Height, s2.Height) + size2.Height + this.WindowBorderThickness.Top);
						num = (short)430374937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_16A;
					case 23:
						if (size.Width > availableSize.Width)
						{
							num = (short)1062535181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					case 24:
						if (this.m_BackChrome.Visibility != global::System.Windows.Visibility.Visible)
						{
							num = (short)638582819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FEE;
					case 25:
						goto IL_16A;
					case 26:
						if (global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(s2))
						{
							num = (short)880869410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D7;
					case 27:
						num = (short)492765224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_16A;
					case 29:
						if (flag2)
						{
							num = (short)1559363584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						size = new global::System.Windows.Size(global::System.Math.Max(s.Width + s2.Width, size2.Width) + this.WindowBorderThickness.Left + this.WindowBorderThickness.Right, global::System.Math.Max(s.Height, s2.Height) + size2.Height + this.WindowBorderThickness.Top);
						num = (short)59768860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (isMinimumSized)
						{
							num = (short)1023410191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DCA;
					case 31:
						num = (short)1013579777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						flag = true;
						goto IL_C52;
					case 33:
						if (this.m_BackChrome != null)
						{
							num = (short)1977876492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return size;
					case 34:
						num = (short)297533451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						this.m_BackChrome.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)1377566763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (uielement != null)
						{
							num = (short)214695967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B74;
					case 37:
						if (this.EffectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007)
						{
							num = (short)2072182823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)969867285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(s))
						{
							num = (short)282722310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E14;
					case 39:
						num = (short)1614282781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (this.m_BackChrome.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1355546628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41C;
					case 41:
						goto IL_41C;
					case 42:
						goto IL_16A;
					case 43:
						goto IL_FEE;
					}
					goto IL_DE;
					IL_16A:
					num = (short)176554014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29A:
					num = (short)1789001761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D7:
					num = (short)1969356824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41C:
					this.m_BackChrome.UpdateMinimalAppearance(isMinimumSized);
					num = (short)2135162900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B74:
					num = (short)630521894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C52:
					flag2 = flag;
					num = (short)619249701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DCA:
					num = (short)883687447;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E14:
					num = (short)1722941472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FEE:
					this.m_BackChrome.Measure(size);
					num = (short)1540292649;
					num2 = (int)((global::System.IntPtr)num);
				}
				return size;
				IL_DE:
				global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
				s = default(global::System.Windows.Size);
				s2 = default(global::System.Windows.Size);
				size2 = default(global::System.Windows.Size);
				uielement = null;
				isMinimumSized = this.GetIsMinimumSized();
				enumerator = internalChildren.GetEnumerator();
				num = (short)1960771591;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000A8AFC File Offset: 0x000A6CFC
		private bool GetIsMinimumSized()
		{
			if (!(base.TemplatedParent is global::DevComponents.WpfRibbon.Ribbon))
			{
				short num = (short)1429013793;
				short num2 = num;
				num = (short)993592609;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1960640513;
					if (num != 0)
					{
					}
					num = (short)271908864;
					short num3 = num;
					num = (short)1137311744;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return ((global::DevComponents.WpfRibbon.Ribbon)base.TemplatedParent).IsBelowMinimumSize;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000A8BC4 File Offset: 0x000A6DC4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1135476736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_11F;
				}
				global::System.Windows.UIElement uielement2;
				global::System.Collections.IEnumerator enumerator;
				global::System.Windows.UIElement uielement3;
				global::System.Windows.UIElement uielement4;
				for (;;)
				{
					IL_28:
					double num4;
					double num5;
					double num6;
					switch (num2)
					{
					case 0:
						num = (short)813760513;
						if (num != 0)
						{
						}
						num = (short)1280442400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						goto IL_7EA;
						try
						{
							for (;;)
							{
								IL_7EA:
								num = (short)1001259010;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										global::System.Windows.UIElement uielement;
										if (global::DevComponents.WpfRibbon.RibbonContentPanel.GetContentPart(uielement) != global::DevComponents.WpfRibbon.eRibbonContentPart.QuickAccessToolbar)
										{
											num = (short)1562640393;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1982562352;
										short num3 = num;
										num = (short)1976467504;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_7EA;
										default:
											num = (short)519110656;
											if (num != 0)
											{
											}
											num = (short)902299653;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_848;
										}
										continue;
									case 4:
										goto IL_A4D;
									case 5:
									{
										global::System.Windows.UIElement uielement;
										uielement2 = uielement;
										num = (short)562626568;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)898957322;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
										num = (short)572129293;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::System.Windows.UIElement uielement;
										uielement3 = uielement;
										num = (short)1832124419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										global::System.Windows.UIElement uielement;
										if (global::DevComponents.WpfRibbon.RibbonContentPanel.GetContentPart(uielement) == global::DevComponents.WpfRibbon.eRibbonContentPart.Tabs)
										{
											num = (short)1867579404;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										uielement.Arrange(new global::System.Windows.Rect(finalSize));
										num = (short)417071115;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										num = (short)58523652;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
									{
										global::System.Windows.UIElement uielement;
										uielement4 = uielement;
										num = (short)974585856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 13:
									{
										global::System.Windows.UIElement uielement;
										if (global::DevComponents.WpfRibbon.RibbonContentPanel.GetContentPart(uielement) == global::DevComponents.WpfRibbon.eRibbonContentPart.ApplicationMenu)
										{
											num = (short)2075656199;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1529020417;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_9F5:
									num = (short)696909830;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_848:
									goto IL_9F5;
								}
							}
							IL_A4D:
							goto IL_191;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_A6F;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_A5C:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1761476609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_AC5;
								case 2:
									if (disposable != null)
									{
										num = (short)277282816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_AC7;
								}
								goto IL_A6F;
							}
							IL_AC5:
							IL_AC7:
							goto EndFinally_33;
							IL_A6F:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)944046082;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_A5C;
							EndFinally_33:;
						}
						goto IL_AC8;
						IL_191:
						num4 = 0.0;
						global::DevComponents.WpfRibbon.eEffectiveStyle effectiveStyle = this.EffectiveStyle;
						num = (short)1794506760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num5 = (double)6;
						goto IL_78C;
					case 3:
					{
						global::DevComponents.WpfRibbon.eEffectiveStyle effectiveStyle;
						if (effectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
						{
							num = (short)1065943081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_559;
					}
					case 4:
						if (((global::System.Windows.Controls.ContentPresenter)uielement3).Content != null)
						{
							num = (short)406913061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47B;
					case 5:
					{
						global::DevComponents.WpfRibbon.eEffectiveStyle effectiveStyle;
						if (effectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
						{
							num = (short)88539185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47B;
					}
					case 6:
						if (uielement2.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)955121684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					case 7:
						if (uielement3.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)516096047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47B;
					case 8:
					{
						global::DevComponents.WpfRibbon.eEffectiveStyle effectiveStyle;
						if (effectiveStyle != global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
						{
							num = (short)1038549028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)344129554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (uielement3 != null)
						{
							num = (short)901447734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47B;
					case 10:
					{
						double y = finalSize.Height - uielement4.DesiredSize.Height;
						uielement4.Arrange(new global::System.Windows.Rect(num6, y, global::System.Math.Max(finalSize.Width - num6 - this.WindowBorderThickness.Right, 16.0), uielement4.DesiredSize.Height));
						num = (short)2124611614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_D6F;
					case 12:
						num = (short)1481637944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)2064515103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return finalSize;
					case 15:
						goto IL_596;
					case 16:
						((global::DevComponents.WpfRibbon.Qat)((global::System.Windows.Controls.ContentPresenter)uielement2).Content).IsGlassEnabled = this.IsGlassEnabled;
						num = (short)1410465825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)537067564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num5 = (double)0;
						goto IL_78C;
					case 19:
						if (((global::System.Windows.Controls.ContentPresenter)uielement2).Content is global::DevComponents.WpfRibbon.Qat)
						{
							num = (short)1773207564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					case 20:
					{
						uielement2.Arrange(new global::System.Windows.Rect(num4, this.WindowBorderThickness.Top + 1.0, uielement2.DesiredSize.Width, uielement2.DesiredSize.Height));
						double y = uielement2.DesiredSize.Height + (double)this.QatTabSpacing;
						num = (short)893386780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (uielement3 is global::System.Windows.Controls.ContentPresenter)
						{
							num = (short)2094792763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C2;
					case 22:
						if (uielement2 != null)
						{
							num = (short)1531052078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C24;
					case 23:
						goto IL_AC8;
					case 24:
						num = (short)1723072546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1010434067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (this.m_BackChrome != null)
						{
							num = (short)312541232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 27:
						if (uielement2.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)1983905834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C24;
					case 28:
						if (uielement2 is global::System.Windows.Controls.ContentPresenter)
						{
							num = (short)534183961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					case 29:
						if (uielement3.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)955056151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_685;
					case 30:
						goto IL_150;
					case 31:
						if (uielement4.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)1264779274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_150;
					case 32:
						if (((global::System.Windows.Controls.ContentPresenter)uielement2).Content != null)
						{
							num = (short)1897332751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					case 33:
						goto IL_3A2;
					case 34:
						if (uielement2 is global::System.Windows.Controls.ContentPresenter)
						{
							num = (short)539688960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_596;
					case 35:
					{
						global::DevComponents.WpfRibbon.eEffectiveStyle effectiveStyle;
						if (effectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007)
						{
							num = (short)1882456121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_685;
					}
					case 36:
						num = (short)1329922050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_6C2;
					case 38:
						if (((global::System.Windows.Controls.ContentPresenter)uielement3).Content != null)
						{
							num = (short)462028845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_685;
					case 39:
						if (uielement2 != null)
						{
							num = (short)1186791448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					case 40:
						goto IL_559;
					case 41:
						num4 = 8.0;
						num = (short)2077687866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)1764425778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (uielement3 != null)
						{
							num = (short)1825505297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_685;
					case 44:
						if (uielement3 is global::System.Windows.Controls.ContentPresenter)
						{
							num = (short)245170229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_268;
					case 45:
						goto IL_268;
					case 46:
						num = (short)554958875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
					{
						global::System.Windows.Rect finalRect = new global::System.Windows.Rect(new global::System.Windows.Point(num6, finalSize.Height - uielement3.DesiredSize.Height + 1.0), uielement3.DesiredSize);
						uielement3.Arrange(finalRect);
						num6 += uielement3.DesiredSize.Width + 1.0;
						num = (short)1325072439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						num = (short)2027290646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)429719561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						this.m_BackChrome.QatRightPosition = new global::System.Windows.GridLength(num4 + ((uielement2 != null) ? uielement2.DesiredSize.Width : 0.0));
						num = (short)1709178891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_D6F;
					case 52:
						if (uielement4 != null)
						{
							num = (short)392167437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_150;
					case 53:
						num = (short)601161766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						num = (short)669777941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_47B;
					case 56:
						if (((global::DevComponents.WpfRibbon.Qat)((global::System.Windows.Controls.ContentPresenter)uielement2).Content).IsGlassEnabled != this.IsGlassEnabled)
						{
							num = (short)993329168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					case 57:
						num = (short)724500523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						goto IL_559;
					case 59:
						num = (short)334168068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11F;
					IL_150:
					num = (short)913702938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_268:
					num = (short)804454429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A2:
					num = (short)891617285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47B:
					num = (short)1014497332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_559:
					num = (short)1107623975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_596:
					num = (short)999358470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_685:
					num = (short)652214275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C2:
					num = (short)330498055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_78C:
					num6 = num5;
					num = (short)1566703651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC8:
					global::System.Windows.Rect finalRect2 = new global::System.Windows.Rect(new global::System.Windows.Point(this.WindowBorderThickness.Left - 3.0, this.WindowBorderThickness.Top), uielement3.DesiredSize);
					uielement3.Arrange(finalRect2);
					num4 = finalRect2.Right - 12.0;
					num6 = finalRect2.Right - 2.0;
					num = (short)2093416488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C24:
					this.m_BackChrome.QatRightPosition = new global::System.Windows.GridLength(0.0);
					num = (short)286654515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6F:
					this.m_BackChrome.TabXPosition = num6;
					this.m_BackChrome.Arrange(new global::System.Windows.Rect(finalSize));
					num = (short)1941110784;
					short num7 = num;
					num = (short)300089358;
					num2 = (int)((global::System.IntPtr)num);
				}
				return finalSize;
				IL_11F:
				global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
				uielement3 = null;
				uielement2 = null;
				uielement4 = null;
				enumerator = internalChildren.GetEnumerator();
				num = (short)819396609;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000A9A08 File Offset: 0x000A7C08
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static global::DevComponents.WpfRibbon.eRibbonContentPart GetContentPart(global::System.Windows.UIElement element)
		{
			int a_ = 12;
			short num = (short)1580007425;
			if (num != 0)
			{
			}
			if (element != null)
			{
				num = (short)852557824;
				short num2 = num;
				num = (short)461530316;
				short num3 = num;
				num = (short)1412392140;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1686568960;
					if (num != 0)
					{
					}
					return (global::DevComponents.WpfRibbon.eRibbonContentPart)element.GetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.ContentPartProperty);
				}
			}
			throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ţ੥൧ݩ", a_));
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000A9AE4 File Offset: 0x000A7CE4
		public static void SetContentPart(global::System.Windows.UIElement element, global::DevComponents.WpfRibbon.eRibbonContentPart part)
		{
			int a_ = 8;
			if (element != null)
			{
				short num = (short)220105882;
				short num2 = num;
				num = (short)1454083226;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0E;
				case 1:
					break;
				default:
				{
					num = (short)435945472;
					short num3 = num;
					break;
				}
				}
				num = (short)444989441;
				if (num != 0)
				{
				}
				num = (short)535298048;
				if (num != 0)
				{
				}
				element.SetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.ContentPartProperty, part);
				return;
			}
			IL_0E:
			throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("՟๡ţ୥", a_));
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000A9BC4 File Offset: 0x000A7DC4
		private static void OnContentPartChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.UIElement uielement;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::DevComponents.WpfRibbon.RibbonContentPanel ribbonContentPanel;
					ribbonContentPanel.InvalidateMeasure();
					goto IL_D7;
				}
				case 1:
				{
					global::DevComponents.WpfRibbon.RibbonContentPanel ribbonContentPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::DevComponents.WpfRibbon.RibbonContentPanel;
					num2 = (short)1875705858;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)463339521;
					if (num2 != 0)
					{
					}
					global::DevComponents.WpfRibbon.RibbonContentPanel ribbonContentPanel;
					if (ribbonContentPanel != null)
					{
						num2 = (short)1330905088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
				{
					if (uielement == null)
					{
						return;
					}
					num2 = (short)311989006;
					short num3 = num2;
					num2 = (short)404067086;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D7;
					default:
					{
						num2 = (short)1127874560;
						if (num2 != 0)
						{
						}
						num2 = (short)32440320;
						short num4 = num2;
						num2 = (short)1946943489;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 4:
					return;
				}
				goto IL_24;
				IL_D7:
				num2 = (short)1861484548;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			uielement = (d as global::System.Windows.UIElement);
			num2 = (short)236257283;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x000A9D30 File Offset: 0x000A7F30
		private static bool IsPartValid(object o)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			global::DevComponents.WpfRibbon.eRibbonContentPart eRibbonContentPart;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (eRibbonContentPart != global::DevComponents.WpfRibbon.eRibbonContentPart.Tabs)
					{
						num2 = (short)1308557313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					num2 = (short)972357635;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_E3;
				case 3:
					if (eRibbonContentPart != global::DevComponents.WpfRibbon.eRibbonContentPart.None)
					{
						num2 = (short)624820231;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					num2 = (short)2096627713;
					if (num2 != 0)
					{
					}
					num2 = (short)813170688;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (eRibbonContentPart != global::DevComponents.WpfRibbon.eRibbonContentPart.QuickAccessToolbar)
					{
						num2 = (short)1716322308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					if (eRibbonContentPart != global::DevComponents.WpfRibbon.eRibbonContentPart.ApplicationMenu)
					{
						num2 = (short)92602370;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					return false;
				}
				goto IL_30;
			}
			IL_E3:
			goto IL_155;
			IL_30:
			eRibbonContentPart = (global::DevComponents.WpfRibbon.eRibbonContentPart)o;
			num2 = (short)1679790298;
			short num3 = num2;
			num2 = (short)1890685146;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_155:
				num2 = (short)1896873989;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2082996224;
				if (num2 != 0)
				{
				}
				num2 = (short)1610809344;
				short num4 = num2;
				num2 = (short)1505624070;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x000A9EF4 File Offset: 0x000A80F4
		private void CreateBackgroundChrome()
		{
			if (this.m_BackChrome == null)
			{
				short num = (short)927727617;
				if (num != 0)
				{
				}
				num = (short)1507655680;
				short num2 = num;
				num = (short)2138584791;
				short num3 = num;
				num = (short)1362900695;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)782368768;
					if (num != 0)
					{
					}
					this.m_BackChrome = new global::DevComponents.WpfRibbon.RibbonBackgroundChrome();
					this.m_BackChrome.WindowBorderThickness = this.WindowBorderThickness;
					this.m_BackChrome.IsGlassEnabled = this.IsGlassEnabled;
					base.Children.Add(this.m_BackChrome);
					global::System.Windows.Controls.Panel.SetZIndex(this.m_BackChrome, -1);
					return;
				}
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x000A9FF0 File Offset: 0x000A81F0
		internal global::DevComponents.WpfRibbon.RibbonBackgroundChrome BackgroundChrome
		{
			get
			{
				short num = (short)528199030;
				short num2 = num;
				num = (short)1296936310;
				switch (num2 == num)
				{
				}
				num = (short)444137473;
				if (num != 0)
				{
				}
				num = (short)1011548160;
				if (num != 0)
				{
				}
				num = (short)431751168;
				short num3 = num;
				return this.m_BackChrome;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x000AA09C File Offset: 0x000A829C
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x000AA154 File Offset: 0x000A8354
		public global::System.Windows.Thickness WindowBorderThickness
		{
			get
			{
				short num = (short)1104300555;
				short num2 = num;
				num = (short)719079947;
				switch (num2 == num)
				{
				}
				num = (short)1899102208;
				if (num != 0)
				{
				}
				num = (short)269680641;
				if (num != 0)
				{
				}
				num = (short)1269563392;
				short num3 = num;
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.WindowBorderThicknessProperty);
			}
			set
			{
				short num = (short)541778645;
				short num2 = num;
				num = (short)874767061;
				switch (num2 == num)
				{
				}
				num = (short)1463812096;
				if (num != 0)
				{
				}
				num = (short)9830401;
				if (num != 0)
				{
				}
				num = (short)64159744;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.WindowBorderThicknessProperty, value);
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x000AA210 File Offset: 0x000A8410
		private static void OnWindowBorderThicknessChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1241770661;
			short num2 = num;
			num = (short)1378347685;
			switch (num2 == num)
			{
			}
			num = (short)1193017345;
			if (num != 0)
			{
			}
			num = (short)1669201920;
			if (num != 0)
			{
			}
			num = (short)326565888;
			short num3 = num;
			((global::DevComponents.WpfRibbon.RibbonContentPanel)d).OnWindowBorderThicknessChanged((global::System.Windows.Thickness)e.NewValue);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x000AA2D0 File Offset: 0x000A84D0
		private void OnWindowBorderThicknessChanged(global::System.Windows.Thickness t)
		{
			short num = (short)953417729;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2001836545;
				short num3 = num;
				num = (short)625842689;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1341390848;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 2:
					{
						num = (short)507379712;
						short num4 = num;
						this.m_BackChrome.WindowBorderThickness = t;
						goto IL_F9;
					}
					}
					IL_7B:
					num = (short)282394625;
					if (num != 0)
					{
					}
					if (this.m_BackChrome != null)
					{
						num = (short)1099300866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_F9:
				num = (short)2001993728;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x000AA3F0 File Offset: 0x000A85F0
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x000AA4A8 File Offset: 0x000A86A8
		public bool IsGlassEnabled
		{
			get
			{
				short num = (short)1404643935;
				short num2 = num;
				num = (short)1589979743;
				switch (num2 == num)
				{
				}
				num = (short)1526071297;
				if (num != 0)
				{
				}
				num = (short)1371537408;
				if (num != 0)
				{
				}
				num = (short)1751187456;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.IsGlassEnabledProperty);
			}
			set
			{
				short num = (short)1092711405;
				short num2 = num;
				num = (short)902853613;
				switch (num2 == num)
				{
				}
				num = (short)978452481;
				if (num != 0)
				{
				}
				num = (short)211025920;
				if (num != 0)
				{
				}
				num = (short)130809856;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.IsGlassEnabledProperty, value);
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000AA564 File Offset: 0x000A8764
		private static void IsGlassEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1040882222;
			short num2 = num;
			num = (short)556440110;
			switch (num2 == num)
			{
			}
			num = (short)1460994049;
			if (num != 0)
			{
			}
			num = (short)1467547648;
			if (num != 0)
			{
			}
			num = (short)1084620800;
			short num3 = num;
			((global::DevComponents.WpfRibbon.RibbonContentPanel)d).OnIsGlassEnabledChanged((bool)e.NewValue);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000AA628 File Offset: 0x000A8828
		private void OnIsGlassEnabledChanged(bool newValue)
		{
			short num = (short)959381506;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)909377537;
				if (num != 0)
				{
				}
				global::System.Collections.IEnumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_292;
				case 1:
				{
					num = (short)1929117696;
					short num3 = num;
					try
					{
						num = (short)1619263495;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_173;
							case 1:
							{
								global::System.Windows.UIElement uielement;
								if (((global::System.Windows.Controls.ContentPresenter)uielement).Content is global::DevComponents.WpfRibbon.Qat)
								{
									num = (short)776470534;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								global::System.Windows.UIElement uielement;
								if (uielement is global::System.Windows.Controls.ContentPresenter)
								{
									num = (short)156106755;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								num = (short)1803616257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)786694152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
								num = (short)705691650;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_1D5;
							case 6:
							{
								global::System.Windows.UIElement uielement;
								(((global::System.Windows.Controls.ContentPresenter)uielement).Content as global::DevComponents.WpfRibbon.Qat).IsGlassEnabled = newValue;
								num = (short)264830976;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								switch (0)
								{
								case 0:
									goto IL_C9;
								}
								continue;
							case 8:
								num = (short)892665861;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_10D:
							num = (short)1675034628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C9:
							goto IL_10D;
						}
						IL_173:
						IL_1D5:
						return;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1F6;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1E4:
							switch (num2)
							{
							case 0:
								goto IL_247;
							case 1:
								if (disposable != null)
								{
									num = (short)1899954178;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_247;
							case 2:
								goto IL_22B;
							}
							goto IL_1F6;
							IL_22B:
							disposable.Dispose();
							num = (short)276824064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_247:
							num = (short)789731237;
							short num4 = num;
							num = (short)569071525;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_22B;
							default:
								goto IL_27C;
							}
						}
						IL_27C:
						num = (short)1469120512;
						if (num != 0)
						{
						}
						goto EndFinally_8;
						IL_1F6:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)701366273;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1E4;
						EndFinally_8:;
					}
					goto IL_292;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 3:
					this.m_BackChrome.IsGlassEnabled = newValue;
					num = (short)1717436416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5C:
				if (this.m_BackChrome != null)
				{
					num = (short)409141251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_292:
				enumerator = base.InternalChildren.GetEnumerator();
				num = (short)663683073;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000AA95C File Offset: 0x000A8B5C
		internal static bool GetIsVisibleAutoChanged(global::System.Windows.UIElement element)
		{
			int a_ = 6;
			if (element != null)
			{
				short num = (short)1443043110;
				short num2 = num;
				num = (short)513414950;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0E;
				case 1:
					break;
				default:
				{
					num = (short)1578434560;
					short num3 = num;
					break;
				}
				}
				num = (short)1075511297;
				if (num != 0)
				{
				}
				num = (short)555483136;
				if (num != 0)
				{
				}
				return (bool)element.GetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.IsVisibleAutoChangedProperty);
			}
			IL_0E:
			throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㭝౟ݡॣ", a_));
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000AAA38 File Offset: 0x000A8C38
		internal static void SetIsVisibleAutoChanged(global::System.Windows.UIElement element, bool value)
		{
			int a_ = 13;
			if (element != null)
			{
				short num = (short)1444010410;
				short num2 = num;
				num = (short)2056247722;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0E;
				case 1:
					break;
				default:
				{
					num = (short)1803354112;
					short num3 = num;
					break;
				}
				}
				num = (short)76480512;
				if (num != 0)
				{
				}
				num = (short)371654657;
				if (num != 0)
				{
				}
				element.SetValue(global::DevComponents.WpfRibbon.RibbonContentPanel.IsVisibleAutoChangedProperty, value);
				return;
			}
			IL_0E:
			throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("d୦౨٪", a_));
		}

		// Token: 0x04000660 RID: 1632
		public static readonly global::System.Windows.DependencyProperty VisualStyleProperty;

		// Token: 0x04000661 RID: 1633
		private static readonly global::System.Windows.DependencyPropertyKey EffectiveStylePropertyKey;

		// Token: 0x04000662 RID: 1634
		public static readonly global::System.Windows.DependencyProperty EffectiveStyleProperty;

		// Token: 0x04000663 RID: 1635
		public static readonly global::System.Windows.DependencyProperty ContentPartProperty;

		// Token: 0x04000664 RID: 1636
		public static readonly global::System.Windows.DependencyProperty WindowBorderThicknessProperty;

		// Token: 0x04000665 RID: 1637
		public static readonly global::System.Windows.DependencyProperty IsGlassEnabledProperty;

		// Token: 0x04000666 RID: 1638
		public static readonly global::System.Windows.DependencyProperty IsVisibleAutoChangedProperty;

		// Token: 0x04000667 RID: 1639
		private int QatTabSpacing = 1;

		// Token: 0x04000668 RID: 1640
		private global::DevComponents.WpfRibbon.RibbonBackgroundChrome m_BackChrome;

		// Token: 0x04000669 RID: 1641
		private const int MinSystemItemsSize = 120;
	}
}
