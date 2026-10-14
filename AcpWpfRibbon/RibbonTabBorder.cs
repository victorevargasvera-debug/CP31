using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200009E RID: 158
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RibbonTabBorder : global::System.Windows.Controls.Decorator
	{
		// Token: 0x060007A8 RID: 1960 RVA: 0x000AF3C8 File Offset: 0x000AD5C8
		static RibbonTabBorder()
		{
			int a_ = 12;
			short num = (short)437381772;
			short num2 = num;
			num = (short)1820650124;
			switch (num2 == num)
			{
			}
			num = (short)1828323328;
			short num3 = num;
			num = (short)1136263169;
			if (num != 0)
			{
			}
			num = (short)1296629760;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonTabBorder.PaddingProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑣ݥ౧๩իmᝯ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Thickness(10.0, 1.0, 10.0, 2.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.RibbonTabBorder.IsThicknessValid));
			global::DevComponents.WpfRibbon.RibbonTabBorder.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("♣॥ᩧ๩५ᱭ㉯qųյၷ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.RibbonTabBorder.BorderInnerBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("♣॥ᩧ๩५ᱭ㥯ᱱᩳ፵੷㡹๻୽", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.RibbonTabBorder.BorderOuterBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("♣॥ᩧ๩५ᱭ㽯ݱs፵੷㡹๻୽", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.RibbonTabBorder.BackgroundProperty = global::System.Windows.Controls.Panel.BackgroundProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.RibbonTabBorder.TabStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("っݥ੧㥩ᡫ཭ѯ᝱", a_), typeof(global::DevComponents.WpfRibbon.eRibbonTabRenderingState), typeof(global::DevComponents.WpfRibbon.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Normal, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonTabBorder.OnTabStateChanged)));
			global::DevComponents.WpfRibbon.RibbonTabBorder.ColorClassProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("❣॥ѧթṫ⵭ᱯ፱ݳյ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.RibbonTabBorder), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.RibbonColors.RibbonTabClass, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonTabBorder.OnTabClassChanged)));
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000AF63C File Offset: 0x000AD83C
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			short num = (short)1141440512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FE;
				}
				global::System.Windows.Media.StreamGeometry streamGeometry;
				global::DevComponents.WpfRibbon.eRibbonTabRenderingState tabState;
				global::System.Windows.Media.StreamGeometry streamGeometry2;
				global::System.Windows.Media.StreamGeometry streamGeometry3;
				for (;;)
				{
					IL_27:
					global::DevComponents.WpfRibbon.RibbonTabBorder.RenderOverlayBrushes renderOverlayBrushes;
					global::System.Windows.Media.Brush brush;
					switch (num2)
					{
					case 0:
						goto IL_7F6;
					case 1:
						num = (short)1433927727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						brush = renderOverlayBrushes.BorderInnerBrush;
						dc.DrawGeometry(brush, null, streamGeometry);
						num = (short)1973420058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (brush != null)
						{
							num = (short)452853792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8BF;
					case 4:
						if (renderOverlayBrushes != null)
						{
							num = (short)1500250113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					case 5:
						goto IL_64A;
					case 6:
						if (tabState == global::DevComponents.WpfRibbon.eRibbonTabRenderingState.HoverSelected)
						{
							num = (short)1847918615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_745;
					case 7:
						dc.DrawGeometry(brush, null, streamGeometry2);
						num = (short)1648361477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1291190283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (brush != null)
						{
							num = (short)716308493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D6;
					case 10:
						brush = this.Background;
						num = (short)2145255462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.m_SizeReducedFactor < 0.8)
						{
							num = (short)1437859855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						if (streamGeometry != null)
						{
							num = (short)306118683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					case 13:
						dc.DrawGeometry(brush, null, this.m_BorderOuterGeometry);
						num = (short)535625771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_409;
					case 15:
					{
						global::System.Windows.Media.Pen separatorPen = this.GetSeparatorPen();
						num = (short)1299054622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						num = (short)2079365782;
						short num3 = num;
						num = (short)683252374;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_64A;
						default:
							num = (short)566755328;
							if (num != 0)
							{
							}
							if (brush != null)
							{
								num = (short)1774452743;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_78A;
						}
						break;
					}
					case 17:
						if (this.m_BorderOuterGeometry != null)
						{
							num = (short)1843396648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F6;
					case 18:
						if (streamGeometry3 != null)
						{
							num = (short)378535946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_705;
					case 19:
						num = (short)127729670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_8BF;
					case 21:
						goto IL_705;
					case 22:
						if (streamGeometry2 != null)
						{
							num = (short)1459355689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_409;
					case 23:
						goto IL_832;
					case 24:
						if (renderOverlayBrushes.BorderOuterBrush != null)
						{
							num = (short)2076180511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F6;
					case 25:
						if (renderOverlayBrushes != null)
						{
							num = (short)374341666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_409;
					case 26:
					{
						num = (short)1327497216;
						short num4 = num;
						goto IL_308;
					}
					case 27:
						brush = this.BorderInnerBrush;
						num = (short)509804547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)998113304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (renderOverlayBrushes != null)
						{
							num = (short)895549468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F6;
					case 30:
					{
						global::System.Windows.Media.Pen separatorPen;
						if (separatorPen != null)
						{
							num = (short)293339184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 31:
						brush = renderOverlayBrushes.BorderOuterBrush;
						dc.DrawGeometry(brush, null, this.m_BorderOuterGeometry);
						num = (short)775553024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)966524929;
						if (num != 0)
						{
						}
						dc.DrawGeometry(brush, null, streamGeometry);
						num = (short)947257364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1635450917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)1406205991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						return;
					case 36:
						goto IL_745;
					case 37:
						if (renderOverlayBrushes.Background != null)
						{
							num = (short)1515782194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_705;
					case 38:
						if (brush != null)
						{
							num = (short)1808793642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_551;
					case 39:
						if (renderOverlayBrushes.BorderBrush != null)
						{
							num = (short)854065203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_409;
					case 40:
						brush = this.BorderOuterBrush;
						num = (short)363659273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						brush = this.BorderBrush;
						num = (short)1676541968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						dc.DrawGeometry(brush, null, streamGeometry3);
						num = (short)570490929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_4D6;
					case 44:
						if (renderOverlayBrushes != null)
						{
							num = (short)810876961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_705;
					case 45:
						if (this.m_SizeReducedFactor > 0.0)
						{
							num = (short)1578958856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 46:
						if (tabState != global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Selected)
						{
							num = (short)515964947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_832;
					case 47:
						if (renderOverlayBrushes.BorderInnerBrush != null)
						{
							num = (short)2093154306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					case 48:
					{
						global::System.Windows.Media.Pen separatorPen;
						dc.DrawLine(separatorPen, new global::System.Windows.Point(base.DesiredSize.Width - 1.5, 0.0), new global::System.Windows.Point(base.DesiredSize.Width - 1.5, base.DesiredSize.Height + 3.0));
						num = (short)952827939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						goto IL_551;
					case 50:
						brush = renderOverlayBrushes.Background;
						dc.DrawGeometry(brush, null, streamGeometry3);
						num = (short)287899669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						brush = renderOverlayBrushes.BorderBrush;
						dc.DrawGeometry(brush, null, streamGeometry2);
						num = (short)1005191182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FE;
					IL_308:
					num = (short)1704460310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_409:
					num = (short)56098861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D6:
					num = (short)1740046365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_551:
					num = (short)1665269804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_705:
					num = (short)1721565201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_745:
					renderOverlayBrushes = this.GetRenderOverlayBrushes();
					brush = null;
					num = (short)1940848658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_78A:
					num = (short)1915944985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64A:
					goto IL_78A;
					IL_7F6:
					num = (short)1359609868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_832:
					streamGeometry3 = this.m_SelectedBackgroundGeometry;
					streamGeometry2 = this.m_SelectedBorderGeometry;
					streamGeometry = this.m_SelectedBorderInnerGeometry;
					num = (short)1806237732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8BF:
					num = (short)575340548;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_FE:
				base.OnRender(dc);
				tabState = this.TabState;
				streamGeometry3 = this.m_BackgroundGeometry;
				streamGeometry2 = this.m_BorderGeometry;
				streamGeometry = this.m_BorderInnerGeometry;
				num = (short)332398638;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000AFF88 File Offset: 0x000AE188
		private global::System.Windows.Media.Pen GetSeparatorPen()
		{
			short num = (short)1048444928;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)145555457;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					continue;
				case 1:
					goto IL_87;
				case 2:
				{
					num = (short)220594176;
					short num3 = num;
					if (this.m_SeparatorBrush == null)
					{
						num = (short)497549316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8C;
				}
				case 3:
					if (this.m_SeparatorBrush == null)
					{
						num = (short)1077936134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C4;
				case 4:
					this.m_SeparatorBrush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.RibbonTabSeparator)) as global::System.Windows.Media.Brush);
					num = (short)518520837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_8C;
				case 6:
					goto IL_10F;
				}
				IL_68:
				if (this.m_SeparatorPen != null)
				{
					num = (short)1930428417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1687158786;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8C:
				num = (short)1717687486;
				short num4 = num;
				num = (short)238539966;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_87;
				default:
					num = (short)1239023616;
					if (num != 0)
					{
					}
					num = (short)1426587651;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_87:
			return this.m_SeparatorPen;
			IL_10F:
			return null;
			IL_1C4:
			this.m_SeparatorPen = new global::System.Windows.Media.Pen(this.m_SeparatorBrush, 1.0);
			return this.m_SeparatorPen;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x000B017C File Offset: 0x000AE37C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)787283968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5C;
				}
				global::System.Windows.UIElement child;
				global::System.Windows.Size result;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						child.Measure(constraint);
						global::System.Windows.Size desiredSize = child.DesiredSize;
						result.Width += desiredSize.Width;
						result.Height += desiredSize.Height;
						num = (short)1723006979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (child != null)
						{
							num = (short)2094596096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13D;
					case 2:
						goto IL_2A5;
					case 3:
						goto IL_13D;
					case 4:
						goto IL_106;
					case 5:
						this.m_SizeReducedFactor = constraint.Width / result.Width;
						num = (short)202506242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (result.Width > 0.0)
						{
							num = (short)249167872;
							short num3 = num;
							num = (short)26279941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.m_SizeReducedFactor = 0.0;
						num = (short)1103101956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)1644377186;
						short num4 = num;
						num = (short)1690514530;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_106;
						default:
							num = (short)1491402752;
							if (num != 0)
							{
							}
							if (result.Width > constraint.Width)
							{
								num = (short)338690058;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.m_SizeReducedFactor = 0.0;
							num = (short)1867513864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						return result;
					case 9:
						return result;
					case 10:
						num = (short)2070478854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C;
					IL_13D:
					result.Width += this.Padding.Left + this.Padding.Right;
					result.Height += this.Padding.Top + this.Padding.Bottom;
					num = (short)1309999111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A5:
					result.Width = global::System.Math.Max((double)global::DevComponents.WpfRibbon.RibbonTab.MinimumTabWidth, constraint.Width);
					num = (short)1039859721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_106:
					goto IL_2A5;
				}
				return result;
				IL_5C:
				num = (short)2081423361;
				if (num != 0)
				{
				}
				child = this.Child;
				result = new global::System.Windows.Size((double)(this.m_CornerSize * 2), (double)(this.m_CornerSize * 2 - 1));
				num = (short)119930881;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000B04D8 File Offset: 0x000AE6D8
		private global::System.Windows.Rect GetInnerRect(global::System.Windows.Rect r)
		{
			short num = (short)1322647552;
			short num2 = num;
			num = (short)837848835;
			short num3 = num;
			num = (short)2026671875;
			switch (num3 == num)
			{
			}
			num = (short)2073231361;
			if (num != 0)
			{
			}
			num = (short)1104084992;
			if (num != 0)
			{
			}
			r.Inflate(-1.0, 0.0);
			r.Offset(0.0, 1.0);
			double height = r.Height;
			r.Height = height - 1.0;
			return r;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000B05CC File Offset: 0x000AE7CC
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)723845120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7A;
				}
				global::System.Windows.Rect rect2;
				for (;;)
				{
					IL_27:
					global::System.Windows.CornerRadius rad;
					global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
					global::System.Windows.UIElement child;
					global::System.Windows.Media.StreamGeometryContext streamGeometryContext5;
					global::System.Windows.Media.StreamGeometryContext streamGeometryContext6;
					switch (num2)
					{
					case 0:
						try
						{
							global::System.Windows.Rect rect = rect2;
							rect.Inflate(1.0, 0.0);
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
							this.CreateTabGeometry(streamGeometryContext, rect, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), true), false);
							global::System.Windows.Rect innerRect = this.GetInnerRect(rect);
							this.CreateTabGeometry(streamGeometryContext, innerRect, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), true), false);
							goto IL_A42;
						}
						finally
						{
							num = (short)1056702464;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1D3;
									}
									continue;
								case 1:
									((global::System.IDisposable)streamGeometryContext).Dispose();
									num = (short)1941700610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_20D;
								}
								IL_1D3:
								if (streamGeometryContext == null)
								{
									break;
								}
								num = (short)1348337665;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_20D:;
						}
						goto IL_210;
					case 1:
					{
						try
						{
							this.CreateTabGeometry(streamGeometryContext2, rect2, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), true), false);
							global::System.Windows.Rect innerRect2 = this.GetInnerRect(rect2);
							this.CreateTabGeometry(streamGeometryContext2, innerRect2, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), true), false);
							goto IL_2A0;
						}
						finally
						{
							num = (short)893321216;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_A08;
									}
									continue;
								case 1:
									((global::System.IDisposable)streamGeometryContext2).Dispose();
									num = (short)848822274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_A3F;
								}
								IL_A08:
								if (streamGeometryContext2 == null)
								{
									break;
								}
								num = (short)1796341761;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A3F:;
						}
						goto IL_A42;
						IL_2A0:
						this.m_BorderOuterGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext = this.m_BorderOuterGeometry.Open();
						num = (short)1215102976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Windows.Size desiredSize;
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(rect2.Width, desiredSize.Width))
						{
							num = (short)704380932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C3;
					}
					case 3:
						if (child != null)
						{
							num = (short)938278930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 4:
					{
						global::System.Windows.Size desiredSize;
						double num3 = (rect2.Width - desiredSize.Width) / 2.0;
						rect2.X += num3;
						rect2.Width = desiredSize.Width;
						num = (short)212533254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(finalSize.Height))
						{
							num = (short)868417552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 6:
						num = (short)1480589313;
						if (num != 0)
						{
						}
						goto IL_3C3;
					case 7:
					{
						try
						{
							global::System.Windows.Rect innerRect3 = this.GetInnerRect(rect2);
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext3;
							this.CreateTabGeometry(streamGeometryContext3, innerRect3, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), false), false);
							goto IL_34B;
						}
						finally
						{
							num = (short)1657667584;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext3;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_569;
									}
									continue;
								case 1:
									((global::System.IDisposable)streamGeometryContext3).Dispose();
									num = (short)1947467778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_5A0;
								}
								IL_569:
								if (streamGeometryContext3 == null)
								{
									break;
								}
								num = (short)486080513;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5A0:;
						}
						goto Block_8;
						IL_34B:
						this.m_SelectedBorderGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext4 = this.m_SelectedBorderGeometry.Open();
						num = (short)928055308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(finalSize.Width))
						{
							num = (short)179109897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 9:
						goto IL_4C0;
					case 10:
						goto IL_3E3;
					case 11:
					{
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(0.0, rect2.Width))
						{
							num = (short)1331953678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						rad = new global::System.Windows.CornerRadius((double)this.m_CornerSize, (double)this.m_CornerSize, (double)(this.m_CornerSize - 2), (double)(this.m_CornerSize - 2));
						this.m_SelectedBackgroundGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext3 = this.m_SelectedBackgroundGeometry.Open();
						num = (short)1629159431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_5A3;
					case 13:
						try
						{
							global::System.Windows.Rect innerRect4 = this.GetInnerRect(rect2);
							this.CreateTabGeometry(streamGeometryContext5, innerRect4, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), false), false);
							goto IL_210;
						}
						finally
						{
							num = (short)111411200;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_8AB;
									}
									continue;
								case 1:
								{
									num = (short)347233083;
									short num4 = num;
									num = (short)1983863611;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)62586880;
										if (num != 0)
										{
										}
										((global::System.IDisposable)streamGeometryContext5).Dispose();
										num = (short)104660994;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_934;
								}
								IL_8AB:
								if (streamGeometryContext5 == null)
								{
									break;
								}
								num = (short)1438515201;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_934:;
						}
						goto IL_937;
					case 14:
						goto IL_983;
					case 15:
						goto IL_65E;
					case 16:
						goto IL_937;
					case 17:
						try
						{
							global::System.Windows.Rect rect3 = rect2;
							rect3.Inflate(-1.0, -1.0);
							this.CreateTabGeometry(streamGeometryContext6, rect3, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), true), false);
							global::System.Windows.Rect innerRect5 = this.GetInnerRect(rect3);
							this.CreateTabGeometry(streamGeometryContext6, innerRect5, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), true), false);
							goto IL_738;
						}
						finally
						{
							num = (short)1836056576;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_486;
									}
									continue;
								case 1:
									((global::System.IDisposable)streamGeometryContext6).Dispose();
									num = (short)837353474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4BD;
								}
								IL_486:
								if (streamGeometryContext6 == null)
								{
									break;
								}
								num = (short)409665537;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4BD:;
						}
						goto IL_4C0;
					case 18:
					{
						rect2.Inflate(-2.0, (double)(-(double)this.m_CornerSize));
						global::System.Windows.Thickness padding = this.Padding;
						global::System.Windows.Size desiredSize = child.DesiredSize;
						num = (short)605618178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7A;
					IL_210:
					this.m_BorderGeometry = new global::System.Windows.Media.StreamGeometry();
					streamGeometryContext2 = this.m_BorderGeometry.Open();
					num = (short)1512767489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_9:
					global::System.Windows.Media.StreamGeometryContext streamGeometryContext7;
					try
					{
						IL_65E:
						global::System.Windows.Rect rect4 = rect2;
						rect4.Inflate(-1.0, -1.0);
						this.CreateTabGeometry(streamGeometryContext7, rect4, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), true), false);
						global::System.Windows.Rect innerRect6 = this.GetInnerRect(rect4);
						this.CreateTabGeometry(streamGeometryContext7, innerRect6, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), true), false);
						goto IL_380;
					}
					finally
					{
						num = (short)1648689152;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_6FB;
								}
								continue;
							case 1:
								((global::System.IDisposable)streamGeometryContext7).Dispose();
								num = (short)1427046402;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_735;
							}
							IL_6FB:
							if (streamGeometryContext7 == null)
							{
								break;
							}
							num = (short)1898446849;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_735:;
					}
					goto IL_738;
					IL_380:
					child = this.Child;
					num = (short)1914503171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_5A3:
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext4;
						this.CreateTabGeometry(streamGeometryContext4, rect2, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), true), false);
						global::System.Windows.Rect innerRect7 = this.GetInnerRect(rect2);
						this.CreateTabGeometry(streamGeometryContext4, innerRect7, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(rad, new global::System.Windows.Thickness(1.0), true), false);
						goto IL_795;
					}
					finally
					{
						num = (short)683802624;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext4;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_623;
								}
								continue;
							case 1:
								((global::System.IDisposable)streamGeometryContext4).Dispose();
								num = (short)1390018562;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_65B;
							}
							IL_623:
							if (streamGeometryContext4 == null)
							{
								break;
							}
							num = (short)1642528769;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_65B:;
					}
					goto Block_9;
					IL_795:
					this.m_SelectedBorderInnerGeometry = new global::System.Windows.Media.StreamGeometry();
					streamGeometryContext6 = this.m_SelectedBorderInnerGeometry.Open();
					num = (short)2132344849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C3:
					child.Arrange(rect2);
					num = (short)103677962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C0:
					num = (short)1946222597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_738:
					rad = new global::System.Windows.CornerRadius((double)this.m_CornerSize, (double)this.m_CornerSize, 0.0, 0.0);
					this.m_BackgroundGeometry = new global::System.Windows.Media.StreamGeometry();
					streamGeometryContext5 = this.m_BackgroundGeometry.Open();
					num = (short)1430323213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_937:
					num = (short)669646859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A42:
					this.m_BorderInnerGeometry = new global::System.Windows.Media.StreamGeometry();
					streamGeometryContext7 = this.m_BorderInnerGeometry.Open();
					num = (short)41549839;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3E3:
				return finalSize;
				IL_983:
				return finalSize;
				IL_7A:
				num = (short)1067712512;
				short num5 = num;
				this.m_SelectedBackgroundGeometry = null;
				this.m_SelectedBorderGeometry = null;
				this.m_SelectedBorderInnerGeometry = null;
				this.m_BackgroundGeometry = null;
				this.m_BorderGeometry = null;
				this.m_BorderInnerGeometry = null;
				rect2 = new global::System.Windows.Rect(finalSize);
				rect2.Inflate((double)(-(double)this.m_CornerSize), 0.0);
				num = (short)24248328;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000B10AC File Offset: 0x000AF2AC
		private void CreateTabGeometry(global::System.Windows.Media.StreamGeometryContext ctx, global::System.Windows.Rect rect, global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription rd, bool isBorder)
		{
			short num = (short)205651968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AA;
				}
				global::System.Windows.Point point;
				global::System.Windows.Point point2;
				global::System.Windows.Point point3;
				global::System.Windows.Point point4;
				global::System.Windows.Point point5;
				global::System.Windows.Point point6;
				global::System.Windows.Point point7;
				global::System.Windows.Point point8;
				for (;;)
				{
					IL_27:
					global::System.Windows.Size size;
					switch (num2)
					{
					case 0:
						if (point.Y > point2.Y)
						{
							num = (short)786563079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_676;
					case 1:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(size))
						{
							num = (short)227475482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_761;
					case 2:
						ctx.BeginFigure(point3, false, false);
						num = (short)1362427929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!isBorder)
						{
							num = (short)275775496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_4E3;
					case 5:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(size))
						{
							num = (short)1921777682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38A;
					case 6:
						ctx.ArcTo(point4, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
						num = (short)318898185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						point.Y = rect.Y + rect.Height / 2.0;
						point2.Y = point.Y;
						num = (short)1150943261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						ctx.LineTo(point3, true, false);
						num = (short)666763279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_205;
					case 10:
						if (point4.X > point5.X)
						{
							num = (short)162267156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340;
					case 11:
					{
						num = (short)620881151;
						short num3 = num;
						num = (short)798352639;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_419;
						default:
							num = (short)1493499904;
							if (num != 0)
							{
							}
							goto IL_340;
						}
						break;
					}
					case 12:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(size))
						{
							num = (short)336461840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E3;
					case 13:
						point3.X = rect.X + rect.Width / 2.0;
						point6.X = point3.X;
						num = (short)803799057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_761;
					case 15:
						return;
					case 16:
						ctx.ArcTo(point6, size, 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true, false);
						num = (short)1708523524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)195887105;
						if (num != 0)
						{
						}
						goto IL_5F0;
					case 18:
						ctx.ArcTo(point, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
						num = (short)1961295900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_6BE;
					case 20:
						goto IL_419;
					case 21:
						point7.Y = rect.Y + rect.Height / 2.0;
						point8.Y = point7.Y;
						num = (short)1314390035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (point3.X > point6.X)
						{
							num = (short)1037828109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F0;
					case 23:
						goto IL_291;
					case 24:
						if (isBorder)
						{
							num = (short)2056650754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ctx.BeginFigure(point3, true, true);
						num = (short)973602839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_291;
					case 26:
					{
						num = (short)1949827072;
						short num4 = num;
						ctx.ArcTo(point8, size, 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true, false);
						num = (short)794689550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						if (point7.Y > point3.Y)
						{
							num = (short)1897005077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BE;
					case 28:
						goto IL_38A;
					case 29:
						goto IL_676;
					case 30:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(size))
						{
							num = (short)155123718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_205;
					}
					goto IL_AA;
					IL_205:
					ctx.LineTo(point5, true, false);
					size = new global::System.Windows.Size(global::System.Math.Max(0.0, rect.Right - point5.X), global::System.Math.Max(0.0, point.Y - rect.Y));
					num = (short)1564540933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_291:
					size = new global::System.Windows.Size(global::System.Math.Max(0.0, rect.X - point3.X), global::System.Math.Max(0.0, rect.Bottom - point8.Y));
					num = (short)60620801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_340:
					num = (short)1238368256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38A:
					ctx.LineTo(point2, true, false);
					size = new global::System.Windows.Size(global::System.Math.Max(0.0, point6.X - rect.Right), global::System.Math.Max(0.0, rect.Bottom - point2.Y));
					num = (short)383189004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_419:
					point4.X = rect.X + rect.Width / 2.0;
					point5.X = point4.X;
					num = (short)1375731723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E3:
					num = (short)2144927747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F0:
					num = (short)1490485272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_676:
					num = (short)472711190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6BE:
					num = (short)869466122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_761:
					ctx.LineTo(point7, true, false);
					size = new global::System.Windows.Size(global::System.Math.Max(point4.X - rect.X, 0.0), global::System.Math.Max(0.0, point7.Y - rect.Y));
					num = (short)1658912798;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_AA:
				point7 = new global::System.Windows.Point(rect.X, rect.Y + rd.TopLeft.Y);
				point4 = new global::System.Windows.Point(rect.X + rd.TopLeft.X, rect.Y);
				point5 = new global::System.Windows.Point(rect.Right - rd.TopRight.X, rect.Y);
				point = new global::System.Windows.Point(rect.Right, rect.Y + rd.TopRight.Y);
				point2 = new global::System.Windows.Point(rect.Right, rect.Bottom - rd.BottomRight.Y);
				point6 = new global::System.Windows.Point(rect.Right + rd.BottomRight.X, rect.Bottom);
				point3 = new global::System.Windows.Point(rect.X - rd.BottomLeft.X, rect.Bottom);
				point8 = new global::System.Windows.Point(rect.X, rect.Bottom - rd.BottomLeft.Y);
				num = (short)1492189211;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000B1950 File Offset: 0x000AFB50
		protected override global::System.Windows.Media.HitTestResult HitTestCore(global::System.Windows.Media.PointHitTestParameters hitTestParameters)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::System.Windows.Media.HitTestResult hitTestResult;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::System.Windows.Point hitPoint;
					if (hitPoint.X >= 0.0)
					{
						num2 = (short)679804929;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return hitTestResult;
				}
				case 1:
				{
					global::System.Windows.Point hitPoint = hitTestParameters.HitPoint;
					num2 = (short)554762250;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::System.Windows.Point hitPoint;
					if (hitPoint.X <= base.RenderSize.Width)
					{
						num2 = (short)578551817;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return hitTestResult;
				}
				case 3:
				{
					global::System.Windows.Point hitPoint;
					if (hitPoint.Y < base.RenderSize.Height)
					{
						num2 = (short)1389101060;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return hitTestResult;
				}
				case 4:
					hitTestResult = new global::System.Windows.Media.PointHitTestResult(this, hitTestParameters.HitPoint);
					num2 = (short)1795620872;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					global::System.Windows.Point hitPoint = hitTestParameters.HitPoint;
					num2 = (short)342425602;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					num2 = (short)291517396;
					short num3 = num2;
					num2 = (short)996750292;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_58;
					default:
					{
						num2 = (short)1242234880;
						if (num2 != 0)
						{
						}
						num2 = (short)1472069633;
						if (num2 != 0)
						{
						}
						global::System.Windows.Point hitPoint = hitTestParameters.HitPoint;
						num2 = (short)1289158656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 7:
					goto IL_58;
				case 8:
					return hitTestResult;
				case 9:
				{
					global::System.Windows.Point hitPoint = hitTestParameters.HitPoint;
					num2 = (short)1119551491;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
				{
					global::System.Windows.Point hitPoint;
					if (hitPoint.Y >= 0.0)
					{
						num2 = (short)1517158400;
						short num4 = num2;
						num2 = (short)1905000453;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return hitTestResult;
				}
				}
				goto IL_3C;
				IL_58:
				if (hitTestResult != null)
				{
					break;
				}
				num2 = (short)920059910;
				num = (int)((global::System.IntPtr)num2);
			}
			return hitTestResult;
			IL_3C:
			hitTestResult = base.HitTestCore(hitTestParameters);
			num2 = (short)1436942343;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000B1BDC File Offset: 0x000AFDDC
		private static bool IsThicknessValid(object value)
		{
			short num = (short)1296711705;
			short num2 = num;
			num = (short)1595883545;
			switch (num2 == num)
			{
			default:
			{
				num = (short)324861952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)838074368;
			if (num != 0)
			{
			}
			num = (short)300679169;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.LayoutHelpers.IsThicknessValid(value);
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x000B1C8C File Offset: 0x000AFE8C
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x000B1D44 File Offset: 0x000AFF44
		public global::System.Windows.Thickness Padding
		{
			get
			{
				short num = (short)848156029;
				short num2 = num;
				num = (short)1511839101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)375652352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1492385793;
				if (num != 0)
				{
				}
				num = (short)1670905856;
				if (num != 0)
				{
				}
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.PaddingProperty);
			}
			set
			{
				short num = (short)1149522276;
				short num2 = num;
				num = (short)1481789796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)462618624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1870790657;
				if (num != 0)
				{
				}
				num = (short)2063794176;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.PaddingProperty, value);
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000B1DFC File Offset: 0x000AFFFC
		private static void OnTabStateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)742588417;
			if (num != 0)
			{
			}
			num = (short)1530003456;
			short num2 = num;
			num = (short)1521018921;
			short num3 = num;
			num = (short)967174185;
			switch (num3 == num)
			{
			}
			num = (short)1544749056;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonTabBorder ribbonTabBorder = (global::DevComponents.WpfRibbon.RibbonTabBorder)d;
			global::DevComponents.WpfRibbon.eRibbonTabRenderingState oldState = (global::DevComponents.WpfRibbon.eRibbonTabRenderingState)e.OldValue;
			global::DevComponents.WpfRibbon.eRibbonTabRenderingState newState = (global::DevComponents.WpfRibbon.eRibbonTabRenderingState)e.NewValue;
			ribbonTabBorder.UpdateOverlay(oldState, newState);
			ribbonTabBorder.UpdateVisualState();
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000B1ED4 File Offset: 0x000B00D4
		private void UpdateOverlay(global::DevComponents.WpfRibbon.eRibbonTabRenderingState oldState, global::DevComponents.WpfRibbon.eRibbonTabRenderingState newState)
		{
			short num = (short)1835925512;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (oldState == global::DevComponents.WpfRibbon.eRibbonTabRenderingState.HoverSelected)
					{
						num = (short)585367556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_244;
				case 1:
					goto IL_149;
				case 2:
					if (oldState == global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Hover)
					{
						num = (short)1972371465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DD;
				case 3:
					goto IL_1ED;
				case 4:
					num = (short)1318518795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (newState != global::DevComponents.WpfRibbon.eRibbonTabRenderingState.HoverSelected)
					{
						num = (short)1198981130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14E;
				case 6:
					if (newState == global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Normal)
					{
						num = (short)1871380481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DD;
				case 7:
					num = (short)208011266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 9:
					num = (short)1329922054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)609550336;
					short num3 = num;
					num = (short)846200832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					if (newState == global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Selected)
					{
						num = (short)1961361411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_244;
				}
				IL_55:
				if (newState != global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Hover)
				{
					num = (short)256507911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_DD:
				num = (short)958464005;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_149:
			goto IL_23C;
			IL_14E:
			num = (short)1725300737;
			if (num != 0)
			{
			}
			this.CreateRendererOverlayBrushes(global::DevComponents.WpfRibbon.eRibbonTabRenderingState.HoverSelected);
			return;
			IL_1ED:
			num = (short)759962831;
			short num4 = num;
			num = (short)856759503;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1914699776;
				if (num != 0)
				{
				}
				goto IL_14E;
			}
			IL_23C:
			this.CreateRendererOverlayBrushes(global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Hover);
			return;
			IL_244:
			this.DestroyRendererOverlayBrushes();
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000B212C File Offset: 0x000B032C
		private void UpdateVisualState()
		{
			short num = (short)816119808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				global::DevComponents.WpfRibbon.RibbonTabBorder.RenderOverlayBrushes renderOverlayBrushes;
				string colorClass;
				global::DevComponents.WpfRibbon.RibbonTabBorder.RenderOverlayBrushes renderOverlayBrushes2;
				for (;;)
				{
					IL_28:
					global::DevComponents.WpfRibbon.eRibbonTabRenderingState eRibbonTabRenderingState;
					switch (num2)
					{
					case 0:
						goto IL_153;
					case 1:
						if (eRibbonTabRenderingState == global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Hover)
						{
							num = (short)1820983318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1205207058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)695664647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_491;
					case 4:
						eRibbonTabRenderingState = global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Selected;
						num = (short)522190861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (this.TabState == global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Hover)
						{
							goto IL_153;
						}
						num = (short)2021277554;
						short num3 = num;
						num = (short)271204210;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F6;
						default:
							num = (short)1154154496;
							if (num != 0)
							{
							}
							num = (short)1330380802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_1F6;
					case 7:
						if (this.TabState == global::DevComponents.WpfRibbon.eRibbonTabRenderingState.HoverSelected)
						{
							num = (short)83558400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111;
					case 8:
						num = (short)943456271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.TabState != global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Normal)
						{
							num = (short)1088618504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					case 10:
						num = (short)1415184393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (renderOverlayBrushes != null)
						{
							num = (short)380698647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
					{
						if (colorClass == "")
						{
							num = (short)109117461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						eRibbonTabRenderingState = this.TabState;
						num = (short)825229312;
						short num4 = num;
						num = (short)1259077652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_491;
					case 14:
						if (renderOverlayBrushes2 != null)
						{
							num = (short)879886342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 15:
						if (this.TabState == global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Selected)
						{
							num = (short)1181745168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					case 16:
						goto IL_1B6;
					case 17:
						num = (short)1307181061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (eRibbonTabRenderingState == global::DevComponents.WpfRibbon.eRibbonTabRenderingState.HoverSelected)
						{
							num = (short)628686852;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_491;
					case 19:
						if (this.AnimationEnabled)
						{
							num = (short)1171456010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					case 20:
						if (this.AnimationEnabled)
						{
							num = (short)456589336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_491;
					case 21:
						goto IL_E4;
					case 22:
						eRibbonTabRenderingState = global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Normal;
						num = (short)791937027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_192;
					case 24:
						num = (short)1358823425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (this.AnimationEnabled)
						{
							num = (short)392626193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111;
					case 26:
						return;
					}
					goto IL_9B;
					IL_111:
					num = (short)297402387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_153:
					renderOverlayBrushes = this.GetRenderOverlayBrushes();
					num = (short)1697447947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B6:
					renderOverlayBrushes2 = this.GetRenderOverlayBrushes();
					num = (short)2099118094;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F0:
					base.InvalidateVisual();
					num = (short)66584602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_491:
					string str = colorClass + this.GetStateKey(eRibbonTabRenderingState);
					base.SetResourceReference(global::DevComponents.WpfRibbon.RibbonTabBorder.BackgroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonTabPartColorKeys.Background));
					base.SetResourceReference(global::DevComponents.WpfRibbon.RibbonTabBorder.BorderBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonTabPartColorKeys.Border));
					base.SetResourceReference(global::DevComponents.WpfRibbon.RibbonTabBorder.BorderInnerBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonTabPartColorKeys.BorderInner));
					base.SetResourceReference(global::DevComponents.WpfRibbon.RibbonTabBorder.BorderOuterBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonTabPartColorKeys.BorderOuter));
					this.m_SeparatorPen = null;
					this.m_SeparatorBrush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.RibbonTabSeparator)) as global::System.Windows.Media.Brush);
					num = (short)1947533337;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E4:
				num = (short)1126957057;
				if (num != 0)
				{
				}
				this.Background = null;
				this.BorderBrush = null;
				this.BorderInnerBrush = null;
				this.BorderOuterBrush = null;
				base.InvalidateVisual();
				return;
				IL_192:
				global::System.Windows.Duration duration = new global::System.Windows.Duration(global::System.TimeSpan.FromSeconds(0.2));
				global::System.Windows.Media.Animation.DoubleAnimation animation = new global::System.Windows.Media.Animation.DoubleAnimation(0.3, 1.0, duration);
				renderOverlayBrushes.BeginAnimation(animation);
				return;
				IL_1F6:
				global::System.Windows.Duration duration2 = new global::System.Windows.Duration(global::System.TimeSpan.FromSeconds(0.2));
				global::System.Windows.Media.Animation.DoubleAnimation animation2 = new global::System.Windows.Media.Animation.DoubleAnimation(1.0, 0.0, duration2);
				renderOverlayBrushes2.BeginAnimation(animation2);
				return;
				IL_9B:
				colorClass = this.ColorClass;
				num = (short)778764300;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000B2758 File Offset: 0x000B0958
		private string GetStateKey(global::DevComponents.WpfRibbon.eRibbonTabRenderingState renderingState)
		{
			short num = (short)143327232;
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
					num = (short)918145730;
					short num3 = num;
					num = (short)1128319682;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)99418112;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)309592066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_FA;
				}
				IL_31:
				switch (renderingState)
				{
				case global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Normal:
					goto IL_102;
				case global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Selected:
					goto IL_DC;
				case global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Hover:
					goto IL_130;
				case global::DevComponents.WpfRibbon.eRibbonTabRenderingState.HoverSelected:
					goto IL_AC;
				case global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Focused:
					goto IL_FC;
				default:
					num = (short)1923678209;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_AC:
			num = (short)89456640;
			short num4 = num;
			return global::DevComponents.WpfRibbon.RibbonTabStateColorKeys.HoverSelected;
			IL_DC:
			return global::DevComponents.WpfRibbon.RibbonTabStateColorKeys.Selected;
			IL_FA:
			return global::DevComponents.WpfRibbon.RibbonTabStateColorKeys.Normal;
			IL_FC:
			return global::DevComponents.WpfRibbon.RibbonTabStateColorKeys.Focused;
			IL_102:
			num = (short)242024449;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.RibbonTabStateColorKeys.Normal;
			IL_130:
			return global::DevComponents.WpfRibbon.RibbonTabStateColorKeys.Hover;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000B28A0 File Offset: 0x000B0AA0
		private static void OnTabClassChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)804098886;
			short num2 = num;
			num = (short)571642694;
			switch (num2 == num)
			{
			}
			num = (short)1356660736;
			short num3 = num;
			num = (short)609746944;
			if (num != 0)
			{
			}
			num = (short)2094596097;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.RibbonTabBorder)d).UpdateVisualState();
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x000B2954 File Offset: 0x000B0B54
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x000B2A0C File Offset: 0x000B0C0C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush Background
		{
			get
			{
				short num = (short)2048709867;
				short num2 = num;
				num = (short)1876743403;
				switch (num2 == num)
				{
				}
				num = (short)2125070336;
				short num3 = num;
				num = (short)620953601;
				if (num != 0)
				{
				}
				num = (short)1590820864;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.BackgroundProperty);
			}
			set
			{
				short num = (short)539110786;
				short num2 = num;
				num = (short)387263874;
				switch (num2 == num)
				{
				}
				num = (short)1001259008;
				short num3 = num;
				num = (short)1042219008;
				if (num != 0)
				{
				}
				num = (short)16318465;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.BackgroundProperty, value);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x000B2AC4 File Offset: 0x000B0CC4
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x000B2B7C File Offset: 0x000B0D7C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)1695778150;
				short num2 = num;
				num = (short)107775334;
				switch (num2 == num)
				{
				}
				num = (short)1611202560;
				short num3 = num;
				num = (short)543490049;
				if (num != 0)
				{
				}
				num = (short)1907556352;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.BorderBrushProperty);
			}
			set
			{
				short num = (short)172949505;
				if (num != 0)
				{
				}
				num = (short)944386243;
				short num2 = num;
				num = (short)96350403;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2033451008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)753860608;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.BorderBrushProperty, value);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000B2C30 File Offset: 0x000B0E30
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x000B2CE8 File Offset: 0x000B0EE8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderInnerBrush
		{
			get
			{
				short num = (short)557740580;
				short num2 = num;
				num = (short)210072100;
				switch (num2 == num)
				{
				}
				num = (short)473235456;
				short num3 = num;
				num = (short)603389953;
				if (num != 0)
				{
				}
				num = (short)584712192;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.BorderInnerBrushProperty);
			}
			set
			{
				short num = (short)356123674;
				short num2 = num;
				num = (short)699859994;
				switch (num2 == num)
				{
				}
				num = (short)24903680;
				short num3 = num;
				num = (short)1057947649;
				if (num != 0)
				{
				}
				num = (short)214368256;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.BorderInnerBrushProperty, value);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x000B2D9C File Offset: 0x000B0F9C
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x000B2E54 File Offset: 0x000B1054
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderOuterBrush
		{
			get
			{
				short num = (short)963967839;
				short num2 = num;
				num = (short)1012661087;
				switch (num2 == num)
				{
				}
				num = (short)964820992;
				short num3 = num;
				num = (short)1014366209;
				if (num != 0)
				{
				}
				num = (short)596115456;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.BorderOuterBrushProperty);
			}
			set
			{
				short num = (short)1230087148;
				short num2 = num;
				num = (short)1654301676;
				switch (num2 == num)
				{
				}
				num = (short)35520512;
				short num3 = num;
				num = (short)2066350080;
				if (num != 0)
				{
				}
				num = (short)275185665;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.BorderOuterBrushProperty, value);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x000B2F0C File Offset: 0x000B110C
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x000B2FC4 File Offset: 0x000B11C4
		[global::System.ComponentModel.DefaultValue("Button")]
		public string ColorClass
		{
			get
			{
				short num = (short)1766343834;
				short num2 = num;
				num = (short)904610970;
				switch (num2 == num)
				{
				}
				num = (short)228065280;
				short num3 = num;
				num = (short)112263168;
				if (num != 0)
				{
				}
				num = (short)972161025;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.ColorClassProperty);
			}
			set
			{
				short num = (short)1800339457;
				if (num != 0)
				{
				}
				num = (short)493463517;
				short num2 = num;
				num = (short)582199261;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745747968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)502267904;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.ColorClassProperty, value);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x000B307C File Offset: 0x000B127C
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x000B3134 File Offset: 0x000B1334
		[global::System.ComponentModel.DefaultValue(global::DevComponents.WpfRibbon.eRibbonTabRenderingState.Normal)]
		public global::DevComponents.WpfRibbon.eRibbonTabRenderingState TabState
		{
			get
			{
				short num = (short)662041725;
				short num2 = num;
				num = (short)544666749;
				switch (num2 == num)
				{
				}
				num = (short)676331520;
				short num3 = num;
				num = (short)1079377921;
				if (num != 0)
				{
				}
				num = (short)1051852800;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eRibbonTabRenderingState)base.GetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.TabStateProperty);
			}
			set
			{
				short num = (short)1109767097;
				short num2 = num;
				num = (short)482063289;
				switch (num2 == num)
				{
				}
				num = (short)364314624;
				short num3 = num;
				num = (short)886308865;
				if (num != 0)
				{
				}
				num = (short)2006253568;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonTabBorder.TabStateProperty, value);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x000B31F0 File Offset: 0x000B13F0
		private bool AnimationEnabled
		{
			get
			{
				short num = (short)1497104386;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (global::System.Windows.SystemParameters.ClientAreaAnimation)
						{
							num = (short)70844423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
					{
						num = (short)1930690560;
						short num3 = num;
						num = (short)541523973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 3:
						goto IL_D2;
					case 4:
					{
						num = (short)129171457;
						if (num != 0)
						{
						}
						num = (short)999010490;
						short num4 = num;
						num = (short)2114760890;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_196;
						default:
							num = (short)701890560;
							if (num != 0)
							{
							}
							num = (short)1457848320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						if (base.IsEnabled)
						{
							num = (short)1386741763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						goto IL_196;
					case 7:
						num = (short)196149254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_44:
					if (global::System.Windows.SystemParameters.PowerLineStatus == global::System.Windows.PowerLineStatus.Online)
					{
						num = (short)423297028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_196:
					if (global::System.Windows.Media.RenderCapability.Tier <= 0)
					{
						return false;
					}
					num = (short)1013121025;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D2:
				return this.m_Animation;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x000B33BC File Offset: 0x000B15BC
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x000B3468 File Offset: 0x000B1668
		internal bool Animation
		{
			get
			{
				short num = (short)677044296;
				short num2 = num;
				num = (short)1908531272;
				switch (num2 == num)
				{
				}
				num = (short)1415380992;
				short num3 = num;
				num = (short)884539393;
				if (num != 0)
				{
				}
				num = (short)1750728704;
				if (num != 0)
				{
				}
				return this.m_Animation;
			}
			set
			{
				short num = (short)1596679829;
				short num2 = num;
				num = (short)1704158869;
				switch (num2 == num)
				{
				}
				num = (short)122880000;
				short num3 = num;
				num = (short)279707649;
				if (num != 0)
				{
				}
				num = (short)520159232;
				if (num != 0)
				{
				}
				this.m_Animation = value;
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000B351C File Offset: 0x000B171C
		private global::DevComponents.WpfRibbon.RibbonTabBorder.RenderOverlayBrushes GetRenderOverlayBrushes()
		{
			short num = (short)954204161;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_7A;
				case 1:
					num = (short)617938945;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 2:
					goto IL_12B;
				case 3:
				{
					if (this.AnimationEnabled)
					{
						goto IL_130;
					}
					num = (short)1003151875;
					short num3 = num;
					num = (short)1717559811;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7A;
					default:
						num = (short)2028273664;
						if (num != 0)
						{
						}
						num = (short)2135162882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_5C:
				if (base.IsEnabled)
				{
					num = (short)1372192768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)767623171;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7C:
			num = (short)812449792;
			short num4 = num;
			return null;
			IL_12B:
			goto IL_7C;
			IL_130:
			return this.m_RenderBrushes;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x000B3660 File Offset: 0x000B1860
		private void DestroyRendererOverlayBrushes()
		{
			short num = (short)2012627353;
			short num2 = num;
			num = (short)863977881;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)41222144;
				short num3 = num;
				num = (short)1529741312;
				if (num != 0)
				{
				}
				object resourceAccessLock = this.m_ResourceAccessLock;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(resourceAccessLock, ref flag);
					this.m_RenderBrushes = null;
				}
				finally
				{
					num = (short)1117126656;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_C2;
							}
							continue;
						case 1:
							num = (short)65142785;
							if (num != 0)
							{
							}
							global::System.Threading.Monitor.Exit(resourceAccessLock);
							num = (short)1467875330;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_11B;
						}
						IL_C2:
						if (!flag)
						{
							break;
						}
						num = (short)1612709889;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_11B:;
				}
				break;
			}
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000B379C File Offset: 0x000B199C
		private void CreateRendererOverlayBrushes(global::DevComponents.WpfRibbon.eRibbonTabRenderingState renderingState)
		{
			short num = (short)114758385;
			short num2 = num;
			num = (short)389223153;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_94;
			case 1:
				break;
			default:
			{
				num = (short)533135360;
				short num3 = num;
				break;
			}
			}
			num = (short)1439563776;
			if (num != 0)
			{
			}
			num = (short)1703739392;
			int num4 = (int)num;
			switch (num4)
			{
			default:
			{
				IL_94:
				num = (short)123273217;
				if (num != 0)
				{
				}
				object resourceAccessLock = this.m_ResourceAccessLock;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_113;
					}
					string colorClass;
					for (;;)
					{
						IL_D0:
						global::System.Windows.Media.Brush brush;
						string str;
						switch (num4)
						{
						case 0:
							goto IL_365;
						case 1:
							this.m_RenderBrushes.Background = brush.Clone();
							num = (short)1784938507;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_19F;
						case 3:
							this.m_RenderBrushes.BorderBrush = brush.Clone();
							num = (short)823394304;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_3C8;
						case 5:
							if (brush != null)
							{
								num = (short)2000027656;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C8;
						case 6:
							this.m_RenderBrushes.BorderInnerBrush = brush.Clone();
							num = (short)2112487426;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							str = colorClass + this.GetStateKey(renderingState);
							brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonTabPartColorKeys.Background)) as global::System.Windows.Media.Brush);
							num = (short)584253452;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							this.m_RenderBrushes.BorderOuterBrush = brush.Clone();
							num = (short)176947204;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (colorClass != "")
							{
								num = (short)660406279;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3C8;
						case 10:
							goto IL_3E2;
						case 11:
							goto IL_304;
						case 12:
							if (brush != null)
							{
								num = (short)2009923585;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_304;
						case 13:
							if (brush != null)
							{
								num = (short)1901658118;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19F;
						case 14:
							if (brush != null)
							{
								num = (short)1452867587;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_365;
						}
						goto IL_113;
						IL_19F:
						brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonTabPartColorKeys.BorderOuter)) as global::System.Windows.Media.Brush);
						num = (short)1932656645;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_304:
						brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonTabPartColorKeys.Border)) as global::System.Windows.Media.Brush);
						num = (short)2007760910;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_365:
						brush = (base.TryFindResource(new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.RibbonTabPartColorKeys.BorderInner)) as global::System.Windows.Media.Brush);
						num = (short)1528823821;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_3C8:
						num = (short)1880358922;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_3E2:
					return;
					IL_113:
					global::System.Threading.Monitor.Enter(resourceAccessLock, ref flag);
					this.m_RenderBrushes = new global::DevComponents.WpfRibbon.RibbonTabBorder.RenderOverlayBrushes();
					colorClass = this.ColorClass;
					num = (short)557711369;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_D0;
				}
				finally
				{
					num = (short)1366163456;
					num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_417;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(resourceAccessLock);
							num = (short)250347522;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_44C;
						}
						IL_417:
						if (!flag)
						{
							break;
						}
						num = (short)2069430273;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_44C:;
				}
				return;
			}
			}
		}

		// Token: 0x04000683 RID: 1667
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty;

		// Token: 0x04000684 RID: 1668
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x04000685 RID: 1669
		public static readonly global::System.Windows.DependencyProperty BorderInnerBrushProperty;

		// Token: 0x04000686 RID: 1670
		public static readonly global::System.Windows.DependencyProperty BorderOuterBrushProperty;

		// Token: 0x04000687 RID: 1671
		public static readonly global::System.Windows.DependencyProperty PaddingProperty;

		// Token: 0x04000688 RID: 1672
		public static readonly global::System.Windows.DependencyProperty TabStateProperty;

		// Token: 0x04000689 RID: 1673
		public static readonly global::System.Windows.DependencyProperty ColorClassProperty;

		// Token: 0x0400068A RID: 1674
		private int m_CornerSize = 3;

		// Token: 0x0400068B RID: 1675
		private global::System.Windows.Media.StreamGeometry m_SelectedBackgroundGeometry;

		// Token: 0x0400068C RID: 1676
		private global::System.Windows.Media.StreamGeometry m_SelectedBorderGeometry;

		// Token: 0x0400068D RID: 1677
		private global::System.Windows.Media.StreamGeometry m_SelectedBorderInnerGeometry;

		// Token: 0x0400068E RID: 1678
		private global::System.Windows.Media.StreamGeometry m_BackgroundGeometry;

		// Token: 0x0400068F RID: 1679
		private global::System.Windows.Media.StreamGeometry m_BorderGeometry;

		// Token: 0x04000690 RID: 1680
		private global::System.Windows.Media.StreamGeometry m_BorderInnerGeometry;

		// Token: 0x04000691 RID: 1681
		private global::System.Windows.Media.StreamGeometry m_BorderOuterGeometry;

		// Token: 0x04000692 RID: 1682
		private bool m_Animation = true;

		// Token: 0x04000693 RID: 1683
		private const double FadeDuration = 0.2;

		// Token: 0x04000694 RID: 1684
		private global::DevComponents.WpfRibbon.RibbonTabBorder.RenderOverlayBrushes m_RenderBrushes;

		// Token: 0x04000695 RID: 1685
		private double m_SizeReducedFactor;

		// Token: 0x04000696 RID: 1686
		private global::System.Windows.Media.Brush m_SeparatorBrush;

		// Token: 0x04000697 RID: 1687
		private global::System.Windows.Media.Pen m_SeparatorPen;

		// Token: 0x04000698 RID: 1688
		private object m_ResourceAccessLock = new object();

		// Token: 0x0200009F RID: 159
		private class RenderOverlayBrushes
		{
			// Token: 0x060007CB RID: 1995 RVA: 0x000B3C40 File Offset: 0x000B1E40
			internal void BeginAnimation(global::System.Windows.Media.Animation.DoubleAnimation animation1)
			{
				short num = (short)643170315;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.BorderInnerBrush.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)1697350422;
						short num3 = num;
						num = (short)662209302;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12E;
						default:
							num = (short)1068105728;
							if (num != 0)
							{
							}
							num = (short)1188691969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_219;
					case 2:
						return;
					case 3:
						goto IL_12E;
					case 4:
						this.BorderOuterBrush.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)685834242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.BorderInnerBrush != null)
						{
							num = (short)889061376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_219;
					case 6:
						goto IL_F0;
					case 7:
					{
						num = (short)1680605185;
						if (num != 0)
						{
						}
						this.Background.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)1898840064;
						short num4 = num;
						num = (short)698089475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (this.BorderOuterBrush != null)
						{
							num = (short)1963720708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						if (this.BorderBrush != null)
						{
							num = (short)1253441546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					case 10:
						this.BorderBrush.BeginAnimation(global::System.Windows.Media.Brush.OpacityProperty, animation1);
						num = (short)568918022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_55;
						}
						continue;
					}
					IL_55:
					if (this.Background != null)
					{
						num = (short)1542717447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12E;
					IL_F0:
					num = (short)1053949957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12E:
					num = (short)39256073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_219:
					num = (short)1652031496;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x04000699 RID: 1689
			public global::System.Windows.Media.Brush Background;

			// Token: 0x0400069A RID: 1690
			public global::System.Windows.Media.Brush BorderBrush;

			// Token: 0x0400069B RID: 1691
			public global::System.Windows.Media.Brush BorderInnerBrush;

			// Token: 0x0400069C RID: 1692
			public global::System.Windows.Media.Brush BorderOuterBrush;
		}
	}
}
