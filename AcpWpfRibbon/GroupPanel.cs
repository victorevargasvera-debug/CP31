using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000054 RID: 84
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupPanel : global::DevComponents.WpfRibbon.ButtonPanel
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00054610 File Offset: 0x00052810
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000546C8 File Offset: 0x000528C8
		public global::DevComponents.WpfRibbon.eRibbonVisualStyle VisualStyle
		{
			get
			{
				short num = (short)929321258;
				short num2 = num;
				num = (short)1026773290;
				switch (num2 == num)
				{
				}
				num = (short)1993080832;
				short num3 = num;
				num = (short)286654464;
				if (num != 0)
				{
				}
				num = (short)154533889;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eRibbonVisualStyle)base.GetValue(global::DevComponents.WpfRibbon.GroupPanel.VisualStyleProperty);
			}
			set
			{
				short num = (short)1910439937;
				if (num != 0)
				{
				}
				num = (short)672192624;
				short num2 = num;
				num = (short)2089539696;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1250164736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1848573952;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.GroupPanel.VisualStyleProperty, value);
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00054784 File Offset: 0x00052984
		private static void OnVisualStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)626519738;
			short num2 = num;
			num = (short)710733498;
			switch (num2 == num)
			{
			}
			num = (short)1552023552;
			short num3 = num;
			num = (short)825688064;
			if (num != 0)
			{
			}
			num = (short)799801345;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.GroupPanel)o).OnVisualStyleChanged((global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.OldValue, (global::DevComponents.WpfRibbon.eRibbonVisualStyle)e.NewValue);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00054850 File Offset: 0x00052A50
		private void OnVisualStyleChanged(global::DevComponents.WpfRibbon.eRibbonVisualStyle oldValue, global::DevComponents.WpfRibbon.eRibbonVisualStyle newValue)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)394723330;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)170459140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (newValue != global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Black)
						{
							goto IL_1B4;
						}
						num = (short)2124357868;
						short num3 = num;
						num = (short)568008940;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)556662784;
							if (num != 0)
							{
							}
							num = (short)302645251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 3:
						goto IL_E8;
					case 4:
						if (newValue != global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Blue)
						{
							num = (short)419561478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					case 5:
						return;
					case 6:
						num = (short)1925775361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (newValue != global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2010Silver)
						{
							num = (short)71958528;
							short num4 = num;
							num = (short)1886715904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					}
					IL_45:
					if (this.IsDesignMode)
					{
						num = (short)144441349;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)860749831;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
			return;
			IL_E8:
			IL_125:
			num = (short)1078591489;
			if (num != 0)
			{
			}
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010;
			return;
			IL_1B4:
			this.EffectiveStyle = global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00054A18 File Offset: 0x00052C18
		private bool IsDesignMode
		{
			get
			{
				short num = (short)1517934977;
				short num2 = num;
				num = (short)1847187841;
				switch (num2 == num)
				{
				}
				num = (short)266665984;
				short num3 = num;
				num = (short)899416064;
				if (num != 0)
				{
				}
				num = (short)2074148865;
				if (num != 0)
				{
				}
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00054AC8 File Offset: 0x00052CC8
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00054B80 File Offset: 0x00052D80
		public global::DevComponents.WpfRibbon.eEffectiveStyle EffectiveStyle
		{
			get
			{
				short num = (short)1731163353;
				short num2 = num;
				num = (short)1924822233;
				switch (num2 == num)
				{
				}
				num = (short)207749120;
				short num3 = num;
				num = (short)1379860481;
				if (num != 0)
				{
				}
				num = (short)993067008;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eEffectiveStyle)base.GetValue(global::DevComponents.WpfRibbon.GroupPanel.EffectiveStyleProperty);
			}
			internal set
			{
				short num = (short)1791406989;
				short num2 = num;
				num = (short)2017375117;
				switch (num2 == num)
				{
				}
				num = (short)1336016896;
				short num3 = num;
				num = (short)1282015233;
				if (num != 0)
				{
				}
				num = (short)504233984;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.GroupPanel.EffectiveStylePropertyKey, value);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00054C38 File Offset: 0x00052E38
		private static void OnEffectiveStyleChanged(global::System.Windows.DependencyObject o, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.GroupPanel groupPanel;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					IL_37:
					num2 = (short)2131296256;
					short num3 = num2;
					if (groupPanel != null)
					{
						num2 = (short)1334837249;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B0;
				}
				case 1:
					groupPanel.OnEffectiveStyleChanged((global::DevComponents.WpfRibbon.eEffectiveStyle)e.OldValue, (global::DevComponents.WpfRibbon.eEffectiveStyle)e.NewValue);
					num2 = (short)919732226;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_B0;
				}
				goto IL_1C;
				IL_B0:
				num2 = (short)1989770952;
				short num4 = num2;
				num2 = (short)446463688;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_37;
				default:
					goto IL_E5;
				}
			}
			IL_E5:
			num2 = (short)1046478849;
			if (num2 != 0)
			{
			}
			num2 = (short)1219756032;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			groupPanel = (o as global::DevComponents.WpfRibbon.GroupPanel);
			num2 = (short)1674444800;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00054D68 File Offset: 0x00052F68
		protected virtual void OnEffectiveStyleChanged(global::DevComponents.WpfRibbon.eEffectiveStyle oldValue, global::DevComponents.WpfRibbon.eEffectiveStyle newValue)
		{
			short num = (short)1444155313;
			short num2 = num;
			num = (short)902172593;
			switch (num2 == num)
			{
			}
			num = (short)1555300352;
			short num3 = num;
			num = (short)1483341825;
			if (num != 0)
			{
			}
			num = (short)1632960512;
			if (num != 0)
			{
			}
			base.InvalidateMeasure();
			base.InvalidateArrange();
			base.InvalidateVisual();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00054E24 File Offset: 0x00053024
		static GroupPanel()
		{
			int a_ = 7;
			short num = (short)646385695;
			short num2 = num;
			num = (short)995168287;
			switch (num2 == num)
			{
			}
			num = (short)1773928448;
			short num3 = num;
			num = (short)833486849;
			if (num != 0)
			{
			}
			num = (short)1980104704;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.GroupPanel.VisualStyleProperty = global::DevComponents.WpfRibbon.Ribbon.VisualStyleProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.GroupPanel), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eRibbonVisualStyle.Office2007Blue, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.GroupPanel.OnVisualStyleChanged)));
			global::DevComponents.WpfRibbon.GroupPanel.EffectiveStylePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩞݠբdѦᵨɪ᭬੮≰ݲ౴᭶ᱸ", a_), typeof(global::DevComponents.WpfRibbon.eEffectiveStyle), typeof(global::DevComponents.WpfRibbon.GroupPanel), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.GroupPanel.OnEffectiveStyleChanged)));
			global::DevComponents.WpfRibbon.GroupPanel.EffectiveStyleProperty = global::DevComponents.WpfRibbon.GroupPanel.EffectiveStylePropertyKey.DependencyProperty;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.GroupPanel), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.GroupPanel)));
			global::DevComponents.WpfRibbon.GroupPanel.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵞ๠ᅢŤɦ᭨⥪Ὤᩮɰ᭲", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.GroupPanel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.GroupPanel.OnBorderBrushChanged)));
			global::DevComponents.WpfRibbon.GroupPanel.LightBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("፞ࡠѢ൤፦⭨ѪὬ୮ᑰŲ㝴ն౸ࡺᕼ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.GroupPanel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.GroupPanel.OnLightBorderBrushChanged)));
			global::DevComponents.WpfRibbon.GroupPanel.CornerRadiusProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᱞ๠ᅢ୤ɦ᭨㥪౬୮ᡰٲٴ", a_), typeof(global::System.Windows.CornerRadius), typeof(global::DevComponents.WpfRibbon.GroupPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.CornerRadius(0.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.GroupPanel.IsCornerRadiusValid));
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00055058 File Offset: 0x00053258
		public override global::DevComponents.WpfRibbon.ButtonPanel Copy(bool deepCopy)
		{
			short num = (short)1858011137;
			if (num != 0)
			{
			}
			num = (short)1110833140;
			short num2 = num;
			num = (short)2035283956;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1136001024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1868890112;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.CloningMachine.Clone(this, deepCopy);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0005510C File Offset: 0x0005330C
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			short num = (short)1184563200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BE;
				}
				global::System.Windows.Media.Brush brush2;
				for (;;)
				{
					IL_27:
					global::DevComponents.WpfRibbon.eEffectiveStyle effectiveStyle;
					global::System.Windows.Media.Brush brush;
					bool flag;
					global::System.Collections.IEnumerator enumerator;
					global::System.Windows.Rect rect;
					switch (num2)
					{
					case 0:
						num = (short)1453457412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (effectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
						{
							num = (short)862912512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_601;
					case 3:
						if (brush != null)
						{
							num = (short)1226375200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (flag)
						{
							num = (short)2111897618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						num = (short)1426194439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)427753476;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.UIElement uielement;
								double num4;
								global::System.Windows.Rect layoutSlot;
								switch (num2)
								{
								case 0:
									if (uielement.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)1104412673;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									goto IL_84F;
								case 2:
								{
									num = (short)200601757;
									short num3 = num;
									num = (short)1994256541;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_84F;
									default:
										num = (short)334364672;
										if (num != 0)
										{
										}
										break;
									}
									break;
								}
								case 3:
									num = (short)524156933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_84A;
									}
									continue;
								case 5:
									goto IL_A23;
								case 6:
									num4 += 1.0;
									dc.DrawLine(this.m_DividerPenLight, new global::System.Windows.Point(num4, layoutSlot.Y), new global::System.Windows.Point(num4, layoutSlot.Bottom));
									num = (short)1796079618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (!enumerator.MoveNext())
									{
										num = (short)473563139;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1311375360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (this.m_DividerPenLight != null)
									{
										num = (short)87818246;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								goto IL_84A;
								IL_84F:
								layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(uielement as global::System.Windows.FrameworkElement);
								num4 = global::System.Math.Round(layoutSlot.Right) + 0.5;
								dc.DrawLine(this.m_DividerPen, new global::System.Windows.Point(num4, layoutSlot.Y), new global::System.Windows.Point(num4, layoutSlot.Bottom));
								num = (short)1590034440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8DB:
								num = (short)788398087;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_84A:
								goto IL_8DB;
							}
							IL_A23:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_A45;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_A32:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)461176833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_A9D;
								case 2:
									if (disposable != null)
									{
										num = (short)417398784;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A9F;
								}
								goto IL_A45;
							}
							IL_A9D:
							IL_A9F:
							goto EndFinally_28;
							IL_A45:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)924844034;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_A32;
							EndFinally_28:;
						}
						goto IL_AA0;
					case 7:
						if (brush2 != null)
						{
							num = (short)648413203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B3;
					case 8:
						dc.DrawGeometry(brush2, null, this.m_BorderGeometry);
						num = (short)1829437451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (effectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007)
						{
							num = (short)1417412625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)4128769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (this.m_BorderGeometry != null)
						{
							num = (short)1219297305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7BC;
					case 11:
						goto IL_7BC;
					case 12:
						if (brush2 != null)
						{
							num = (short)1168900104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7BC;
					case 13:
						num = (short)1341849615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (this.m_DividerPenLight == null)
						{
							num = (short)571605013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EB;
					case 15:
						if (brush2 != null)
						{
							num = (short)577765411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA0;
					case 16:
						if (this.m_LightBorderGeometry != null)
						{
							num = (short)1584136205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA0;
					case 17:
						brush2 = this.LightBorderBrush;
						num = (short)1682374672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						brush = this.BorderBrush;
						rect = new global::System.Windows.Rect(base.RenderSize);
						rect.Width -= 3.5;
						num = (short)1416429596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						dc.DrawGeometry(brush2, null, this.m_BackgroundGeometry);
						num = (short)82903063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_6B3;
					case 21:
						return;
					case 22:
						goto IL_372;
					case 23:
						goto IL_6B3;
					case 24:
						num = (short)212598785;
						if (num != 0)
						{
						}
						if (this.m_BackgroundGeometry != null)
						{
							num = (short)1536753669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.OnRender(dc);
						num = (short)612433940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)861929484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (this.m_DividerPen == null)
						{
							num = (short)657653790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EB;
					case 27:
						if (flag)
						{
							num = (short)730923030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = base.Children.GetEnumerator();
						num = (short)926089245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (brush != null)
						{
							num = (short)1626472482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48F;
					case 29:
						try
						{
							num = (short)1642528772;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									double num5;
									num5 += 1.0;
									global::System.Windows.Rect layoutSlot2;
									dc.DrawLine(this.m_DividerPenLight, new global::System.Windows.Point(layoutSlot2.X, num5), new global::System.Windows.Point(layoutSlot2.Right, num5));
									num = (short)407830535;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1545469954;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement2 = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)877985800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)431095813;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (this.m_DividerPenLight != null)
									{
										num = (short)2123759616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_176;
									}
									continue;
								case 5:
									goto IL_2F9;
								case 6:
								{
									global::System.Windows.UIElement uielement2;
									global::System.Windows.Rect layoutSlot2 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(uielement2 as global::System.Windows.FrameworkElement);
									double num5 = global::System.Math.Round(layoutSlot2.Bottom) + 0.5;
									dc.DrawLine(this.m_DividerPen, new global::System.Windows.Point(layoutSlot2.X, num5), new global::System.Windows.Point(layoutSlot2.Right, num5));
									num = (short)1309540355;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::System.Windows.UIElement uielement2;
									if (uielement2.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)1584857094;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_2A1:
								num = (short)1858535425;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_176:
								goto IL_2A1;
							}
							IL_2F9:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_31B;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_308:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1257963521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_36F;
								case 2:
									if (disposable != null)
									{
										num = (short)1812463616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_371;
								}
								goto IL_31B;
							}
							IL_36F:
							IL_371:
							goto EndFinally_27;
							IL_31B:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)629473282;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_308;
							EndFinally_27:;
						}
						goto IL_372;
					case 30:
						num = (short)582221838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_48F;
					case 32:
					{
						global::System.Windows.Media.Pen pen = new global::System.Windows.Media.Pen(brush, 1.0);
						dc.DrawLine(pen, rect.TopRight, rect.BottomRight);
						num = (short)1649147906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						goto IL_AA0;
					case 34:
					{
						global::System.Windows.Media.Pen pen2 = new global::System.Windows.Media.Pen(brush, 1.0);
						dc.DrawLine(pen2, rect.TopRight, rect.BottomRight);
						num = (short)1041563679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						dc.DrawGeometry(brush2, null, this.m_LightBorderGeometry);
						num = (short)1969291297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BE;
					IL_372:
					num = (short)465960960;
					short num6 = num;
					enumerator = base.Children.GetEnumerator();
					num = (short)706805766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48F:
					rect.X += 1.0;
					brush = this.LightBorderBrush;
					num = (short)833159171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EB:
					num = (short)1679753243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B3:
					effectiveStyle = this.EffectiveStyle;
					flag = (base.Orientation == global::DevComponents.WpfRibbon.eButtonPanelOrientation.Horizontal);
					num = (short)982319113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7BC:
					num = (short)1483800602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA0:
					brush2 = this.BorderBrush;
					num = (short)786628618;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_601:
				return;
				IL_BE:
				brush2 = base.Background;
				num = (short)457834520;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00055CA8 File Offset: 0x00053EA8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)967704577;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			int num2;
			global::System.Windows.Size result;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					result.Width += 6.0;
					num = (short)1983053827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					result.Width += 2.0;
					result.Height += 2.0;
					num = (short)1412759552;
					short num3 = num;
					num = (short)842989573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (this.BorderBrush != null)
					{
						num = (short)1572339713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16E;
				case 3:
					goto IL_16E;
				case 4:
					if (this.EffectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
					{
						num = (short)294060032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_102;
				case 5:
					goto IL_16E;
				}
				goto IL_4E;
				IL_102:
				num = (short)202702850;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16E:
				num = (short)100916806;
				short num4 = num;
				num = (short)160095814;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_102;
				default:
					goto IL_1A3;
				}
			}
			IL_1A3:
			num = (short)708575232;
			if (num != 0)
			{
			}
			return result;
			IL_4E:
			result = base.MeasureOverride(constraint);
			num = (short)1543307268;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00055E70 File Offset: 0x00054070
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)166395904;
			short num2 = num;
			num = (short)784007168;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B0;
				}
				global::System.Windows.Rect rect2;
				for (;;)
				{
					IL_51:
					switch (num3)
					{
					case 0:
						num = (short)1827864584;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_477;
					case 2:
					{
						this.m_BorderGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext = this.m_BorderGeometry.Open();
						num = (short)1799618571;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return finalSize;
					case 4:
						try
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
							global::System.Windows.Rect rect;
							global::System.Windows.CornerRadius cornerRadius;
							global::System.Windows.Thickness thickness;
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext2, rect, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, thickness, false));
							rect.Inflate(-1.0, -1.0);
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext2, rect, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, thickness, true));
							goto IL_454;
						}
						finally
						{
							num = (short)299565057;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
								switch (num3)
								{
								case 0:
									goto IL_37D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_346;
									}
									continue;
								case 2:
									((global::System.IDisposable)streamGeometryContext2).Dispose();
									num = (short)1760231424;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_346:
								if (streamGeometryContext2 == null)
								{
									break;
								}
								num = (short)1796407298;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_37D:;
						}
						goto Block_8;
					case 5:
					{
						global::System.Windows.Rect rect;
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect.Height))
						{
							num = (short)471793664;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					}
					case 6:
					{
						global::System.Windows.Media.Brush lightBorderBrush;
						if (lightBorderBrush != null)
						{
							num = (short)322437129;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					}
					case 7:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect2.Height))
						{
							num = (short)215744525;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 8:
					{
						global::System.Windows.Rect rect;
						if (!rect.IsEmpty)
						{
							num = (short)303759362;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					}
					case 9:
					{
						this.m_LightBorderGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext2 = this.m_LightBorderGeometry.Open();
						num = (short)649265156;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::System.Windows.Thickness thickness = new global::System.Windows.Thickness(1.0);
						global::System.Windows.Rect rect = new global::System.Windows.Rect(finalSize);
						global::System.Windows.CornerRadius cornerRadius = this.CornerRadius;
						global::System.Windows.Media.Brush borderBrush = this.BorderBrush;
						global::System.Windows.Media.Brush lightBorderBrush = this.LightBorderBrush;
						num = (short)1751318545;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						try
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
							global::System.Windows.Rect rect;
							global::System.Windows.CornerRadius cornerRadius;
							global::System.Windows.Thickness thickness;
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext, rect, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, thickness, true));
							rect = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(rect, thickness);
							global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext, rect, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, thickness, true));
							goto IL_537;
						}
						finally
						{
							num = (short)412221441;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
								switch (num3)
								{
								case 0:
									goto IL_6D8;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_69F;
									}
									continue;
								case 2:
									((global::System.IDisposable)streamGeometryContext).Dispose();
									num = (short)154796032;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_69F:
								if (streamGeometryContext == null)
								{
									break;
								}
								num = (short)413401090;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_6D8:;
						}
						return finalSize;
						IL_537:
						this.m_BorderGeometry.Freeze();
						num = (short)1360789510;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::DevComponents.WpfRibbon.eEffectiveStyle effectiveStyle = this.EffectiveStyle;
						if (effectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
						{
							rect2.Width -= 6.0;
						}
						else if (this.BorderBrush != null)
						{
							rect2.Inflate(-1.0, -1.0);
						}
						this.ArrangeInternal(rect2);
						if (effectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007)
						{
							num = (short)902037514;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.m_BackgroundGeometry = null;
						this.m_BorderGeometry = null;
						this.m_LightBorderGeometry = null;
						num = (short)1258487811;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)1126039568;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_380;
					case 15:
						num = (short)1989017607;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (!rect2.IsEmpty)
						{
							num = (short)65667092;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 17:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect2.Width))
						{
							num = (short)2145779727;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 18:
						goto IL_28F;
					case 19:
						num = (short)868876293;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						this.m_BackgroundGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext3 = this.m_BackgroundGeometry.Open();
						num = (short)1454833678;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::System.Windows.Rect rect;
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect.Width))
						{
							num = (short)1388249107;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					}
					}
					goto IL_B0;
					IL_28F:
					num = (short)909115413;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_454:
					this.m_LightBorderGeometry.Freeze();
					num = (short)1252982785;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_380:
						global::System.Windows.CornerRadius cornerRadius;
						global::System.Windows.Thickness thickness;
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext3;
						global::DevComponents.WpfRibbon.LayoutHelpers.CreateGeometry(streamGeometryContext3, rect2, new global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription(cornerRadius, thickness, false));
						goto IL_4DA;
					}
					finally
					{
						num = (short)886833153;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext3;
							switch (num3)
							{
							case 0:
								goto IL_451;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3C8;
								}
								continue;
							case 2:
							{
								num = (short)2026616510;
								short num4 = num;
								num = (short)781366974;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)205324288;
									if (num != 0)
									{
									}
									((global::System.IDisposable)streamGeometryContext3).Dispose();
									break;
								}
								num = (short)1775108096;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_3C8:
							if (streamGeometryContext3 == null)
							{
								break;
							}
							num = (short)348913666;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_451:;
					}
					goto IL_454;
					IL_4DA:
					this.m_BackgroundGeometry.Freeze();
					num = (short)1235615762;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_477:
				num = (short)62455809;
				if (num != 0)
				{
				}
				return finalSize;
				IL_B0:
				this.m_BackgroundGeometry = null;
				this.m_BorderGeometry = null;
				this.m_LightBorderGeometry = null;
				rect2 = new global::System.Windows.Rect(finalSize);
				num = (short)368115724;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00056584 File Offset: 0x00054784
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00056640 File Offset: 0x00054840
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)575758069;
				short num2 = num;
				num = (short)1117216501;
				switch (num2 == num)
				{
				}
				num = (short)868089857;
				if (num != 0)
				{
				}
				num = (short)1350762496;
				short num3 = num;
				num = (short)741605376;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.GroupPanel.BorderBrushProperty);
			}
			set
			{
				short num = (short)538726143;
				short num2 = num;
				num = (short)697913087;
				switch (num2 == num)
				{
				}
				num = (short)1204486145;
				if (num != 0)
				{
				}
				num = (short)536084480;
				short num3 = num;
				num = (short)888930304;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.GroupPanel.BorderBrushProperty, value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000566F8 File Offset: 0x000548F8
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x000567B4 File Offset: 0x000549B4
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush LightBorderBrush
		{
			get
			{
				short num = (short)2063071939;
				short num2 = num;
				num = (short)1973942979;
				switch (num2 == num)
				{
				}
				num = (short)381550593;
				if (num != 0)
				{
				}
				num = (short)1559298048;
				short num3 = num;
				num = (short)784662528;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.GroupPanel.LightBorderBrushProperty);
			}
			set
			{
				short num = (short)110477100;
				short num2 = num;
				num = (short)759086892;
				switch (num2 == num)
				{
				}
				num = (short)1097203713;
				if (num != 0)
				{
				}
				num = (short)528154624;
				short num3 = num;
				num = (short)988282880;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.GroupPanel.LightBorderBrushProperty, value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00056868 File Offset: 0x00054A68
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00056924 File Offset: 0x00054B24
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.CornerRadiusConverter))]
		public global::System.Windows.CornerRadius CornerRadius
		{
			get
			{
				short num = (short)2134170419;
				short num2 = num;
				num = (short)1907940147;
				switch (num2 == num)
				{
				}
				num = (short)1486159872;
				if (num != 0)
				{
				}
				num = (short)1021181952;
				short num3 = num;
				num = (short)723386369;
				if (num != 0)
				{
				}
				return (global::System.Windows.CornerRadius)base.GetValue(global::DevComponents.WpfRibbon.GroupPanel.CornerRadiusProperty);
			}
			set
			{
				short num = (short)1104120415;
				short num2 = num;
				num = (short)2008713823;
				switch (num2 == num)
				{
				}
				num = (short)1799946241;
				if (num != 0)
				{
				}
				num = (short)472055808;
				short num3 = num;
				num = (short)838205440;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.GroupPanel.CornerRadiusProperty, value);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000569E0 File Offset: 0x00054BE0
		private static bool IsCornerRadiusValid(object value)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::System.Windows.CornerRadius cornerRadius;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (cornerRadius.TopLeft >= 0.0)
					{
						num2 = (short)1924988932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
				{
					num2 = (short)461009900;
					short num3 = num2;
					num2 = (short)269644780;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A9;
					default:
						num2 = (short)899874816;
						if (num2 != 0)
						{
						}
						if (cornerRadius.TopRight >= 0.0)
						{
							num2 = (short)741670919;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 2:
					if (cornerRadius.BottomLeft >= 0.0)
					{
						num2 = (short)728563718;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					if (cornerRadius.BottomRight >= 0.0)
					{
						goto IL_1A9;
					}
					return false;
				case 4:
					num2 = (short)2094202881;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)1143078912;
					short num4 = num2;
					num2 = (short)451674112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					num2 = (short)1503985667;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_10A;
				}
				goto IL_30;
				IL_1A9:
				num2 = (short)442826757;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10A:
			num2 = (short)634519553;
			if (num2 != 0)
			{
			}
			return true;
			IL_30:
			cornerRadius = (global::System.Windows.CornerRadius)value;
			num2 = (short)1509883906;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00056BE0 File Offset: 0x00054DE0
		private static void OnBorderBrushChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)828964865;
			if (num != 0)
			{
			}
			num = (short)668224343;
			short num2 = num;
			num = (short)1973242711;
			switch (num2 == num)
			{
			}
			num = (short)527171584;
			short num3 = num;
			num = (short)2069168128;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.GroupPanel)sender).OnBorderBrushChanged(e.OldValue as global::System.Windows.Media.Brush, e.NewValue as global::System.Windows.Media.Brush);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00056CAC File Offset: 0x00054EAC
		private void OnBorderBrushChanged(global::System.Windows.Media.Brush oldBrush, global::System.Windows.Media.Brush newBrush)
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
					goto IL_147;
				case 1:
				{
					global::System.Windows.Media.Brush brush = newBrush.Clone();
					brush.Opacity = 0.35;
					brush.Freeze();
					this.m_DividerPen = new global::System.Windows.Media.Pen(brush, 1.0);
					this.m_DividerPen.Freeze();
					num2 = (short)1444216833;
					if (num2 != 0)
					{
					}
					num2 = (short)341245952;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (newBrush != null)
					{
						num2 = (short)748552193;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				break;
			}
			IL_1C:
			num2 = (short)531514695;
			short num3 = num2;
			num2 = (short)486622535;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_147:
				break;
			default:
			{
				num2 = (short)1352663040;
				if (num2 != 0)
				{
				}
				num2 = (short)466419712;
				short num4 = num2;
				this.m_DividerPen = null;
				num2 = (short)1709572098;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00056E04 File Offset: 0x00055004
		private static void OnLightBorderBrushChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)246689398;
			short num2 = num;
			num = (short)1726164598;
			switch (num2 == num)
			{
			}
			num = (short)581894145;
			if (num != 0)
			{
			}
			num = (short)217448448;
			short num3 = num;
			num = (short)1083441152;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.GroupPanel)sender).OnLightBorderBrushChanged(e.OldValue as global::System.Windows.Media.Brush, e.NewValue as global::System.Windows.Media.Brush);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00056ED4 File Offset: 0x000550D4
		private void OnLightBorderBrushChanged(global::System.Windows.Media.Brush oldBrush, global::System.Windows.Media.Brush newBrush)
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
					goto IL_146;
				case 1:
				{
					global::System.Windows.Media.Brush brush = newBrush.Clone();
					brush.Opacity = 0.5;
					brush.Freeze();
					this.m_DividerPenLight = new global::System.Windows.Media.Pen(brush, 1.0);
					this.m_DividerPenLight.Freeze();
					num2 = (short)913047552;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (newBrush != null)
					{
						num2 = (short)38928385;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				break;
			}
			IL_1C:
			num2 = (short)1743119303;
			short num3 = num2;
			num2 = (short)1370350535;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_146:
				break;
			default:
			{
				num2 = (short)1067319297;
				if (num2 != 0)
				{
				}
				num2 = (short)1013448704;
				short num4 = num2;
				num2 = (short)684916736;
				if (num2 != 0)
				{
				}
				this.m_DividerPenLight = null;
				num2 = (short)892862466;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0005702C File Offset: 0x0005522C
		protected override void OnVisualChildrenChanged(global::System.Windows.DependencyObject visualAdded, global::System.Windows.DependencyObject visualRemoved)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_12E;
				case 1:
					if (visualRemoved is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num2 = (short)1372323842;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					((global::DevComponents.WpfRibbon.ButtonDropDown)visualRemoved).RenderBorder = true;
					num2 = (short)1783365636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_6B;
				case 4:
					goto IL_103;
				case 5:
				{
					num2 = (short)252449722;
					short num3 = num2;
					num2 = (short)1883378618;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6B;
					default:
						num2 = (short)877854720;
						if (num2 != 0)
						{
						}
						((global::DevComponents.WpfRibbon.ButtonDropDown)visualAdded).RenderBorder = false;
						num2 = (short)1853947904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_28;
				IL_6B:
				if (visualAdded is global::DevComponents.WpfRibbon.ButtonDropDown)
				{
					num2 = (short)187039749;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_12E:
				num2 = (short)2039676929;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_103:
			num2 = (short)767098880;
			short num4 = num2;
			return;
			IL_28:
			base.OnVisualChildrenChanged(visualAdded, visualRemoved);
			num2 = (short)215154689;
			if (num2 != 0)
			{
			}
			num2 = (short)247791619;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040001CD RID: 461
		private const int Office2010SeparationWidth = 6;

		// Token: 0x040001CE RID: 462
		public static readonly global::System.Windows.DependencyProperty VisualStyleProperty;

		// Token: 0x040001CF RID: 463
		private static readonly global::System.Windows.DependencyPropertyKey EffectiveStylePropertyKey;

		// Token: 0x040001D0 RID: 464
		public static readonly global::System.Windows.DependencyProperty EffectiveStyleProperty;

		// Token: 0x040001D1 RID: 465
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x040001D2 RID: 466
		public static readonly global::System.Windows.DependencyProperty LightBorderBrushProperty;

		// Token: 0x040001D3 RID: 467
		public static readonly global::System.Windows.DependencyProperty CornerRadiusProperty;

		// Token: 0x040001D4 RID: 468
		private global::System.Windows.Media.StreamGeometry m_BackgroundGeometry;

		// Token: 0x040001D5 RID: 469
		private global::System.Windows.Media.StreamGeometry m_BorderGeometry;

		// Token: 0x040001D6 RID: 470
		private global::System.Windows.Media.StreamGeometry m_LightBorderGeometry;

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Media.Pen m_DividerPen;

		// Token: 0x040001D8 RID: 472
		private global::System.Windows.Media.Pen m_DividerPenLight;
	}
}
