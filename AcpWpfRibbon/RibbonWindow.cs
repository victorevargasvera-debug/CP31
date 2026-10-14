using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x020000A1 RID: 161
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class RibbonWindow : global::System.Windows.Window
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x000B6574 File Offset: 0x000B4774
		static RibbonWindow()
		{
			int a_ = 5;
			short num = (short)985464833;
			if (num != 0)
			{
			}
			num = (short)1997615313;
			short num2 = num;
			num = (short)1877225681;
			switch (num2 == num)
			{
			}
			num = (short)731971584;
			short num3 = num;
			num = (short)1222246400;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.RibbonWindow.MaximizedGlassTopAdjustment = 3.0;
			global::DevComponents.WpfRibbon.RibbonWindow.SiziningWindowInProgress = false;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.RibbonWindow), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.RibbonWindow)));
			global::DevComponents.WpfRibbon.RibbonWindow.EnableGlassProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᡜㅞ`Ţ।ɦ⹨ݪ౬ᱮɰ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.RibbonWindow), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.RibbonWindow.EnableGlassChanged)));
			global::DevComponents.WpfRibbon.RibbonWindow.IsUsingGlassPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᑜⱞ㑠ၢ౤०๨ⱪŬ๮ɰr", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.RibbonWindow), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.RibbonWindow.IsUsingGlassProperty = global::DevComponents.WpfRibbon.RibbonWindow.IsUsingGlassPropertyKey.DependencyProperty;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000B66E8 File Offset: 0x000B48E8
		public RibbonWindow()
		{
			this.m_IsGlassEnabled = this.GetGlassEnabled();
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000B6708 File Offset: 0x000B4908
		public override void OnApplyTemplate()
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.m_PreviousWindowState != base.WindowState)
					{
						num2 = (short)965345290;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CE;
				case 1:
					num2 = (short)464322566;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)162201600;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)857473025;
					if (num2 != 0)
					{
					}
					this.m_Border.TransparentMargin = new global::System.Windows.Thickness(0.0, this.m_RibbonControl.GetTitleChromeHeight(), 0.0, 0.0);
					num2 = (short)1149763589;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1254555659;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_291;
				case 6:
					goto IL_26D;
				case 7:
					if (base.WindowState == global::System.Windows.WindowState.Maximized)
					{
						num2 = (short)1978728450;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CE;
				case 8:
					if (this.IsGlassEnabled)
					{
						num2 = (short)1441267716;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_291;
				case 9:
					goto IL_254;
				case 10:
					this.HandleWindowStateChanged();
					num2 = (short)550502409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					num2 = (short)1964896199;
					short num3 = num2;
					num2 = (short)354873287;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_26D;
					default:
						num2 = (short)1330511872;
						if (num2 != 0)
						{
						}
						if (this.m_RibbonControl != null)
						{
							num2 = (short)2020671489;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_291;
					}
					break;
				}
				}
				goto IL_49;
				IL_26D:
				if (this.m_Border != null)
				{
					num2 = (short)2042560515;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_291:
				num2 = (short)310771719;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_254:
			IL_2CE:
			base.OnApplyTemplate();
			return;
			IL_49:
			num2 = (short)374996992;
			short num4 = num2;
			this.m_Border = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("क़ᩚཛྷ୞㹠㑢౤०൨Ѫᩬ⵮ṰŲᅴቶ୸", a_)) as global::DevComponents.WpfRibbon.WindowBorder);
			this.m_ResizeGrip = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("๘㉚㍜㭞๠ᑢ㝤ɦᩨɪᝬ੮㙰Ųᱴݶ", a_)) as global::System.Windows.Controls.Primitives.ResizeGrip);
			num2 = (short)655622152;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000B69EC File Offset: 0x000B4BEC
		protected override void OnPreviewMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1638662153;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2B3;
				case 1:
				{
					global::System.Windows.Point position = e.GetPosition(this);
					global::DevComponents.WpfRibbon.WinApi.SizingCommand sizingCommandFromPoint = this.GetSizingCommandFromPoint(position);
					goto IL_17B;
				}
				case 2:
				{
					global::System.Windows.Input.Cursor cursor;
					if (cursor != null)
					{
						num = (short)1558577168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_201;
				}
				case 3:
					if (e.RightButton == global::System.Windows.Input.MouseButtonState.Released)
					{
						num = (short)620036097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_201;
				case 4:
					goto IL_30D;
				case 5:
					goto IL_2B3;
				case 6:
					goto IL_2B3;
				case 7:
					goto IL_2B3;
				case 8:
					num = (short)1492254741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_8D;
					}
					continue;
				case 10:
					goto IL_2B3;
				case 11:
				{
					num = (short)862906149;
					short num3 = num;
					num = (short)1284237093;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17B;
					default:
						num = (short)272564224;
						if (num != 0)
						{
						}
						num = (short)1349058566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 12:
					num = (short)1275985923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_2B3;
				case 14:
					if (base.Cursor != null)
					{
						num = (short)376832008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_201;
				case 15:
				{
					num = (short)1788739584;
					short num4 = num;
					num = (short)1829371918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 16:
				{
					this.m_CursorIsSet = true;
					global::System.Windows.Input.Cursor cursor;
					base.Cursor = cursor;
					e.Handled = true;
					num = (short)1742536727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 17:
					e.Handled = true;
					num = (short)59310084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_201;
				case 19:
					num = (short)1582235649;
					if (num != 0)
					{
					}
					if (this.m_SizingWindow)
					{
						num = (short)983564305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49A;
				case 20:
					goto IL_2B3;
				case 21:
					if (this.m_CursorIsSet)
					{
						num = (short)1600126998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_201;
				case 22:
					base.Cursor = null;
					this.m_CursorIsSet = false;
					num = (short)2035417106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_201;
				case 24:
				{
					global::DevComponents.WpfRibbon.WinApi.SizingCommand sizingCommandFromPoint;
					switch (sizingCommandFromPoint)
					{
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.West:
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.East:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeWE;
						num = (short)593297421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.North:
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.South:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeNS;
						num = (short)1149763589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.NorthWest:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeNWSE;
						num = (short)1429798922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.NorthEast:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeNESW;
						num = (short)1153171476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthWest:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeNESW;
						num = (short)198836224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthEast:
					{
						global::System.Windows.Input.Cursor cursor = global::System.Windows.Input.Cursors.SizeNWSE;
						num = (short)1167130631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					default:
						num = (short)1284309003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 25:
				{
					global::DevComponents.WpfRibbon.WinApi.SizingCommand sizingCommandFromPoint;
					if (sizingCommandFromPoint == global::DevComponents.WpfRibbon.WinApi.SizingCommand.None)
					{
						num = (short)714670095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Input.Cursor cursor = null;
					num = (short)1913782296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_8D:
				if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
				{
					num = (short)92667916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_201;
				IL_17B:
				num = (short)1166344217;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_201:
				num = (short)2070872083;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B3:
				num = (short)1434517506;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_30D:
			IL_49A:
			base.OnPreviewMouseMove(e);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000B6E9C File Offset: 0x000B509C
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfRibbon.WinApi.SizingCommand sizingCommandFromPoint;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_122;
				case 1:
				{
					this.StartResize(sizingCommandFromPoint);
					e.Handled = true;
					num2 = (short)1136459777;
					if (num2 != 0)
					{
					}
					num2 = (short)1318584320;
					short num3 = num2;
					num2 = (short)1347420160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					if (sizingCommandFromPoint == global::DevComponents.WpfRibbon.WinApi.SizingCommand.None)
					{
						goto IL_124;
					}
					num2 = (short)2073978558;
					short num4 = num2;
					num2 = (short)570713790;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_124;
					default:
						num2 = (short)1313275904;
						if (num2 != 0)
						{
						}
						num2 = (short)1401683969;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_122:
			IL_124:
			base.OnPreviewMouseLeftButtonDown(e);
			return;
			IL_1C:
			global::System.Windows.Point position = e.GetPosition(this);
			sizingCommandFromPoint = this.GetSizingCommandFromPoint(position);
			num2 = (short)535166978;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000B6FD4 File Offset: 0x000B51D4
		private global::DevComponents.WpfRibbon.WinApi.SizingCommand GetSizingCommandFromPoint(global::System.Windows.Point p)
		{
			short num = (short)1770717184;
			switch (num)
			{
			default:
			{
				num = (short)2120876047;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Size size;
					global::System.Windows.Thickness resizeBorderThickness;
					global::System.Windows.Rect rect;
					switch (num2)
					{
					case 0:
						if (p.X >= 0.0)
						{
							num = (short)528023595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76D;
					case 1:
						if (p.Y <= size.Height)
						{
							num = (short)1774977077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A95;
					case 2:
						num = (short)1780940810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (p.X >= 0.0)
						{
							num = (short)565968926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37C;
					case 4:
						num = (short)264175658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_455;
					case 6:
						if (p.Y <= resizeBorderThickness.Top)
						{
							num = (short)725155871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CF;
					case 7:
						if (p.Y <= resizeBorderThickness.Top)
						{
							num = (short)859635760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_620;
					case 8:
						num = (short)919207995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.m_ResizeGrip.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)469696540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CE;
					case 10:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.X <= resizeCornerRadius.TopLeft)
						{
							num = (short)1637810208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CF;
					}
					case 11:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.X >= size.Width - resizeCornerRadius.BottomRight)
						{
							num = (short)1471938598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A95;
					}
					case 12:
						goto IL_2C5;
					case 13:
						goto IL_6FA;
					case 14:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.NorthEast;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_136;
						}
						continue;
					case 16:
						if (p.Y <= size.Height)
						{
							num = (short)262995993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76D;
					case 17:
						if (this.m_ResizeGrip != null)
						{
							num = (short)368377900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CE;
					case 18:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.X <= resizeCornerRadius.BottomLeft)
						{
							num = (short)1628831802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76D;
					}
					case 19:
						num = (short)286916609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (p.X >= 0.0)
						{
							num = (short)974979085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CF;
					case 21:
						num = (short)184614935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_351;
					case 23:
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							num = (short)1450901530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthEast;
					case 24:
						if (p.X <= resizeBorderThickness.Left)
						{
							num = (short)1012269091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37C;
					case 25:
						num = (short)268107794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthWest;
					case 27:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.Y >= size.Height - resizeCornerRadius.BottomLeft)
						{
							num = (short)1119748141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76D;
					}
					case 28:
						num = (short)1271136302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.North;
					case 30:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.West;
					case 31:
						num = (short)1630011443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1030225940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1741750319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						global::System.Windows.Point point = base.PointToScreen(p);
						point = this.m_ResizeGrip.PointFromScreen(point);
						rect = new global::System.Windows.Rect(this.m_ResizeGrip.RenderSize);
						num = (short)670171176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						num = (short)465240067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.East;
					case 37:
						if (p.X <= size.Width)
						{
							num = (short)94306340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A4;
					case 38:
						num = (short)296288310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (p.X >= size.Width - resizeBorderThickness.Right)
						{
							num = (short)1390346296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A4;
					case 40:
					{
						global::System.Windows.Point point;
						if (rect.Contains(point))
						{
							num = (short)398721045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CE;
					}
					case 41:
						if (p.Y >= 0.0)
						{
							num = (short)1095172125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_620;
					case 42:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.X >= size.Width - resizeCornerRadius.TopRight)
						{
							num = (short)402587662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_808;
					}
					case 43:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthWest;
					case 44:
					{
						num = (short)1247543296;
						short num3 = num;
						num = (short)1699479561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						num = (short)1002045456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (base.ResizeMode == global::System.Windows.ResizeMode.CanResizeWithGrip)
						{
							num = (short)828571682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CE;
					case 47:
						if (p.Y <= size.Height)
						{
							num = (short)2120351793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
					case 48:
						num = (short)1762983977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.South;
					case 50:
						if (p.Y >= size.Height - resizeBorderThickness.Bottom)
						{
							num = (short)1702494241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
					case 51:
						if (p.Y >= 0.0)
						{
							num = (short)1846411266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CF;
					case 52:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.Y >= size.Height - resizeCornerRadius.BottomRight)
						{
							num = (short)1135607827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A95;
					}
					case 53:
						num = (short)811270155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (p.X <= size.Width)
						{
							num = (short)1639186444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A95;
					case 55:
					{
						if (rect.Contains(p))
						{
							num = (short)968622102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.CornerRadius resizeCornerRadius = this.GetResizeCornerRadius();
						num = (short)844365830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						num = (short)1613889573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
					{
						global::System.Windows.CornerRadius resizeCornerRadius;
						if (p.Y < resizeCornerRadius.TopRight)
						{
							num = (short)1392312324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_808;
					}
					case 58:
						num = (short)24182784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						if (base.ResizeMode == global::System.Windows.ResizeMode.NoResize)
						{
							num = (short)411303941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						rect = default(global::System.Windows.Rect);
						num = (short)1269694481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_136:
					if (base.WindowState == global::System.Windows.WindowState.Normal)
					{
						num = (short)1965817864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
					IL_2CE:
					resizeBorderThickness = this.GetResizeBorderThickness();
					size = new global::System.Windows.Size(base.ActualWidth, base.ActualHeight);
					rect = global::DevComponents.WpfRibbon.LayoutHelpers.DeflateRect(new global::System.Windows.Rect(0.0, 0.0, size.Width, size.Height), resizeBorderThickness);
					num = (short)174325815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37C:
					num = (short)949223463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CF:
					num = (short)1407254585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_620:
					num = (short)635109400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76D:
					num = (short)1088094260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_808:
					num = (short)890765339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8A4:
					num = (short)2105868338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A95:
					num = (short)1591541767;
					num2 = (int)((global::System.IntPtr)num);
				}
				return global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthWest;
				IL_2C5:
				num = (short)1785672006;
				short num4 = num;
				num = (short)1852453190;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return global::DevComponents.WpfRibbon.WinApi.SizingCommand.NorthWest;
				default:
					num = (short)1997078528;
					if (num != 0)
					{
					}
					return global::DevComponents.WpfRibbon.WinApi.SizingCommand.SouthEast;
				}
				IL_351:
				num = (short)590807041;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
				IL_455:
				return global::DevComponents.WpfRibbon.WinApi.SizingCommand.None;
				IL_6FA:
				return global::DevComponents.WpfRibbon.WinApi.SizingCommand.NorthWest;
			}
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000B7AC0 File Offset: 0x000B5CC0
		private global::System.Windows.Thickness GetResizeBorderThickness()
		{
			short num = (short)1149928218;
			short num2 = num;
			num = (short)1198555930;
			switch (num2 == num)
			{
			}
			num = (short)114819072;
			if (num != 0)
			{
			}
			num = (short)226361345;
			if (num != 0)
			{
			}
			num = (short)1686831104;
			short num3 = num;
			return new global::System.Windows.Thickness(5.0, 5.0, 5.0, 5.0);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000B7B94 File Offset: 0x000B5D94
		private global::System.Windows.CornerRadius GetResizeCornerRadius()
		{
			short num = (short)875585488;
			short num2 = num;
			num = (short)1439522768;
			switch (num2 == num)
			{
			}
			num = (short)183435265;
			if (num != 0)
			{
			}
			num = (short)1224933376;
			if (num != 0)
			{
			}
			num = (short)706543616;
			short num3 = num;
			return new global::System.Windows.CornerRadius(6.0, 6.0, 6.0, 6.0);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000B7C68 File Offset: 0x000B5E68
		private void StartResize(global::DevComponents.WpfRibbon.WinApi.SizingCommand cmd)
		{
			short num = (short)193200130;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_F0;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				num = (short)1801322497;
				if (num != 0)
				{
				}
				if (global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
				{
					num = (short)1344106215;
					short num3 = num;
					num = (short)53047015;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F0;
					case 1:
						break;
					default:
					{
						num = (short)1363345408;
						short num4 = num;
						break;
					}
					}
					num = (short)14483456;
					if (num != 0)
					{
					}
					num = (short)124846081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F0:
				global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
				global::DevComponents.WpfRibbon.WinApi.SendMessage(handle, 274, (int)(61440 + cmd), 0);
				global::DevComponents.WpfRibbon.WinApi.SendMessage(handle, 514, 0, 0);
				num = (short)324599808;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x000B7DB0 File Offset: 0x000B5FB0
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x000B7E60 File Offset: 0x000B6060
		private bool SizingWindow
		{
			get
			{
				short num = (short)469397344;
				short num2 = num;
				num = (short)2097573728;
				switch (num2 == num)
				{
				}
				num = (short)1554972672;
				if (num != 0)
				{
				}
				num = (short)2016804865;
				if (num != 0)
				{
				}
				num = (short)382599168;
				short num3 = num;
				return this.m_SizingWindow;
			}
			set
			{
				short num = (short)1077192336;
				short num2 = num;
				num = (short)3122832;
				switch (num2 == num)
				{
				}
				num = (short)826343425;
				if (num != 0)
				{
				}
				num = (short)390725632;
				if (num != 0)
				{
				}
				num = (short)687538176;
				short num3 = num;
				this.m_SizingWindow = value;
				global::DevComponents.WpfRibbon.RibbonWindow.SiziningWindowInProgress = value;
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x000B7F18 File Offset: 0x000B6118
		protected override void OnSourceInitialized(global::System.EventArgs e)
		{
			short num = (short)470551005;
			short num2 = num;
			num = (short)1166674397;
			switch (num2 == num)
			{
			}
			num = (short)604635137;
			if (num != 0)
			{
			}
			num = (short)1591214080;
			if (num != 0)
			{
			}
			num = (short)1646854144;
			short num3 = num;
			base.OnSourceInitialized(e);
			this.m_SourceInitialized = true;
			global::System.Windows.Interop.HwndSource.FromHwnd(new global::System.Windows.Interop.WindowInteropHelper(this).Handle).AddHook(new global::System.Windows.Interop.HwndSourceHook(this.WindowMessageHandler));
			this.UpdateWindowStyle();
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000B7FF4 File Offset: 0x000B61F4
		private void UpdateWindowStyle()
		{
			for (;;)
			{
				IL_00:
				short num = (short)1860632579;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_3DD;
					case 1:
						goto IL_27A;
					case 2:
					{
						num = (short)1093057628;
						short num3 = num;
						num = (short)1081982044;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)426967040;
							if (num != 0)
							{
							}
							int num4;
							if ((num4 & 262144) == 0)
							{
								num = (short)399966214;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_27A;
						}
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					case 4:
						if (this.m_Border != null)
						{
							num = (short)609222665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E2;
					case 5:
					{
						this.IsUsingGlass = true;
						global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
						global::DevComponents.WpfRibbon.WinApi.SetWindowRgn(handle, global::System.IntPtr.Zero, false);
						int num4 = global::DevComponents.WpfRibbon.WinApi.GetWindowLong(handle, -16);
						num = (short)1691156482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						int num4;
						num4 |= 262144;
						global::System.IntPtr handle;
						global::DevComponents.WpfRibbon.WinApi.SetWindowLong(handle, -16, num4);
						global::DevComponents.WpfRibbon.WinApi.SetWindowPos(handle, global::System.IntPtr.Zero, 0, 0, 0, 0, 39);
						num = (short)2003238913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_275;
					case 8:
						if (base.WindowStyle == global::System.Windows.WindowStyle.None)
						{
							num = (short)347275279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23E;
					case 9:
						this.m_Border.TransparentMargin = new global::System.Windows.Thickness(0.0);
						num = (short)6291463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)667418624;
						short num5 = num;
						num = (short)461635585;
						if (num != 0)
						{
						}
						goto IL_8D;
					}
					case 11:
						return;
					case 12:
					{
						global::System.IntPtr handle2 = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
						global::System.Windows.Interop.HwndSource.FromHwnd(handle2).CompositionTarget.BackgroundColor = global::System.Windows.Media.Colors.Black;
						if (this.m_RibbonControl != null && this.m_RibbonControl.IsUsingGlass)
						{
							this.m_RibbonControl.IsUsingGlass = false;
						}
						int num6 = global::DevComponents.WpfRibbon.WinApi.GetWindowLong(handle2, -16);
						num6 &= ~(num6 & 262144);
						global::DevComponents.WpfRibbon.WinApi.SetWindowLong(handle2, -16, num6);
						global::DevComponents.WpfRibbon.WinApi.SetWindowPos(handle2, global::System.IntPtr.Zero, 0, 0, 0, 0, 39);
						num = (short)1054998532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (this.IsGlassEnabled)
						{
							num = (short)1286930437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1762459662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (base.WindowStyle != global::System.Windows.WindowStyle.None)
						{
							num = (short)1015611408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D;
					case 15:
						base.WindowStyle = global::System.Windows.WindowStyle.SingleBorderWindow;
						num = (short)740818944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						base.WindowStyle = global::System.Windows.WindowStyle.None;
						num = (short)351207434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_69:
					if (!this.m_SourceInitialized)
					{
						num = (short)159907851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1267859469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D:
					num = (short)1648361484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27A:
					num = (short)1365377032;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_23E:
			this.UpdateGlass();
			return;
			IL_275:
			goto IL_3E2;
			IL_3DD:
			goto IL_23E;
			IL_3E2:
			this.UpdateRegion(false);
			this.IsUsingGlass = false;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000B83F4 File Offset: 0x000B65F4
		private void UpdateRegion(bool redraw)
		{
			short num = (short)1727791104;
			switch (num)
			{
			default:
			{
				int height;
				int width;
				for (;;)
				{
					IL_1D:
					num = (short)750714884;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.IntPtr handle;
						switch (num2)
						{
						case 0:
							height = (int)global::System.Math.Ceiling(base.ActualHeight) + 1;
							width = (int)global::System.Math.Ceiling(base.ActualWidth) + 1;
							num = (short)1392246800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_380;
						case 2:
							goto IL_2DD;
						case 3:
						{
							num = (short)9437184;
							short num3 = num;
							num = (short)1111425032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_A4;
							}
							continue;
						case 5:
							if (base.SizeToContent == global::System.Windows.SizeToContent.Width)
							{
								num = (short)1371865103;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1206059031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::DevComponents.WpfRibbon.WinApi.RECT rect;
							height = rect.Height + 1;
							num = (short)118256326;
							short num4 = num;
							num = (short)1791128262;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
								num = (short)1618739200;
								if (num != 0)
								{
								}
								num = (short)511836167;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							goto IL_3F4;
						case 8:
							if (base.SizeToContent == global::System.Windows.SizeToContent.WidthAndHeight)
							{
								num = (short)1850015744;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1985085445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							return;
						case 10:
						{
							global::DevComponents.WpfRibbon.WinApi.RECT rect = default(global::DevComponents.WpfRibbon.WinApi.RECT);
							global::DevComponents.WpfRibbon.WinApi.GetWindowRect(handle, ref rect);
							num = (short)1770717201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_10E;
						case 12:
							if (base.SizeToContent != global::System.Windows.SizeToContent.Manual)
							{
								num = (short)1100939267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10E;
						case 13:
							if (handle != global::System.IntPtr.Zero)
							{
								num = (short)674430986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4BA;
						case 14:
							height = (int)global::System.Math.Ceiling(base.ActualHeight) + 1;
							num = (short)2113011723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							width = (int)global::System.Math.Ceiling(base.ActualWidth) + 1;
							num = (short)123600917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							goto IL_10E;
						case 17:
						{
							if (base.SizeToContent != global::System.Windows.SizeToContent.Manual)
							{
								num = (short)1510211604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::DevComponents.WpfRibbon.WinApi.RECT rect;
							width = rect.Width + 1;
							height = rect.Height + 1;
							num = (short)142999554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
							if (base.SizeToContent == global::System.Windows.SizeToContent.Width)
							{
								num = (short)1213071366;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)42336275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							if (base.SizeToContent == global::System.Windows.SizeToContent.Height)
							{
								num = (short)498794518;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4BA;
						case 20:
							num = (short)1269432338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							goto IL_10E;
						case 22:
						{
							global::DevComponents.WpfRibbon.WinApi.RECT rect;
							width = rect.Width + 1;
							num = (short)2115829761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							if (base.SizeToContent == global::System.Windows.SizeToContent.Height)
							{
								num = (short)1330642958;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10E;
						}
						IL_A4:
						if (this.IsGlassEnabled)
						{
							num = (short)1985282057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
						width = (int)base.Width + 1;
						height = (int)base.Height + 1;
						num = (short)2049245196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_10E:
						num = (short)1655963661;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_2DD:
				IL_380:
				goto IL_4BA;
				IL_3F4:
				num = (short)1706426369;
				if (num != 0)
				{
				}
				IL_4BA:
				this.UpdateRegion(redraw, width, height);
				return;
			}
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000B88C4 File Offset: 0x000B6AC4
		private void UpdateRegion(bool redraw, int width, int height)
		{
			short num = (short)1796800512;
			short num2 = num;
			num = (short)1364393985;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)955645818;
					short num4 = num;
					num = (short)270532474;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E;
					default:
						goto IL_EC;
					}
					break;
				}
				case 1:
					goto IL_3E;
				case 2:
					goto IL_79;
				}
				goto IL_5A;
				IL_3E:
				switch (0)
				{
				case 0:
					IL_5A:
					if (base.WindowState == global::System.Windows.WindowState.Minimized)
					{
						num = (short)1711144962;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1366425600;
						num3 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_79:
			num = (short)1078132737;
			if (num != 0)
			{
			}
			return;
			IL_EC:
			num = (short)298385408;
			if (num != 0)
			{
			}
			global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
			global::System.IntPtr hRgn = global::System.IntPtr.Zero;
			if (base.WindowState != global::System.Windows.WindowState.Maximized)
			{
				hRgn = global::DevComponents.WpfRibbon.WinApi.CreateRoundRectRgn(0, 0, width, height, 7, 7);
			}
			global::DevComponents.WpfRibbon.WinApi.SetWindowRgn(handle, hRgn, redraw);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x000B8A08 File Offset: 0x000B6C08
		private global::System.IntPtr WindowMessageHandler(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			switch (0)
			{
			case 0:
				goto IL_7C;
			}
			int num;
			global::System.IntPtr result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_44E;
				case 1:
					result = this.WmGetMinMaxInfo(hwnd, msg, wParam, lParam, ref handled);
					num2 = (short)2120679442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_3CD;
				case 3:
					result = this.WmEnterSizeMove(hwnd, msg, wParam, lParam, ref handled);
					num2 = (short)186777604;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_2FB;
				case 5:
					if (msg == 1125)
					{
						num2 = (short)347537423;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					result = this.WmNcHitTest(hwnd, msg, wParam, lParam, ref handled);
					num2 = (short)297599000;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (msg == 5)
					{
						num2 = (short)1118502924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1103036438;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_369;
				case 9:
					if (msg == 131)
					{
						num2 = (short)971505680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)232587285;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_49C;
				case 11:
					goto IL_19E;
				case 12:
					result = this.WmSize(hwnd, msg, wParam, lParam, ref handled);
					num2 = (short)1532428290;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (msg == 561)
					{
						num2 = (short)1563361283;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1852506129;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					result = this.WmNcLButtonDown(hwnd, msg, wParam, lParam, ref handled);
					num2 = (short)1391984651;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					base.Top = (double)wParam.ToInt32();
					handled = true;
					num2 = (short)735838216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_134;
				case 17:
				{
					if (msg == 36)
					{
						num2 = (short)1197932545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1316700387;
					short num3 = num2;
					num2 = (short)1335443683;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_134;
					default:
						num2 = (short)1655635968;
						if (num2 != 0)
						{
						}
						num2 = (short)1209794580;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 18:
					goto IL_423;
				case 19:
					goto IL_3F8;
				case 20:
					if (msg == 798)
					{
						num2 = (short)429064215;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)920518665;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if (msg == 132)
					{
						num2 = (short)173867014;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)614793242;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (msg == 562)
					{
						num2 = (short)2118778905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1565982733;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					result = this.WmDwmCompositionChanged(hwnd, msg, wParam, lParam, ref handled);
					num2 = (short)874774528;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					goto IL_207;
				case 25:
					result = this.WmExitSizeMove(hwnd, msg, wParam, lParam, ref handled);
					num2 = (short)38731795;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (msg == 161)
					{
						num2 = (short)408354830;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1982660613;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_7C;
				IL_134:
				result = this.WmNcCalcSize(hwnd, msg, wParam, lParam, ref handled);
				num2 = (short)594870273;
				if (num2 != 0)
				{
				}
				num2 = (short)1052311562;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_19E:
			IL_207:
			IL_2FB:
			IL_369:
			IL_3CD:
			IL_3F8:
			IL_423:
			IL_44E:
			return result;
			IL_49C:
			num2 = (short)581304320;
			short num4 = num2;
			return result;
			IL_7C:
			result = global::System.IntPtr.Zero;
			num2 = (short)113770503;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x000B8EE0 File Offset: 0x000B70E0
		private global::System.IntPtr WmNcLButtonDown(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)649723905;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (this.RibbonControl == null)
					{
						goto IL_182;
					}
					num = (short)1555761483;
					short num3 = num;
					num = (short)699271499;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A2;
					default:
					{
						num = (short)1878392832;
						if (num != 0)
						{
						}
						num = (short)1495400448;
						short num4 = num;
						num = (short)546897922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					num = (short)23003137;
					if (num != 0)
					{
					}
					num = (short)709033988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1290993664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_A2;
				case 5:
					goto IL_CB;
				}
				IL_3C:
				if (wParam.ToInt32() == 3)
				{
					num = (short)2087124995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_18C;
				IL_A2:
				if (this.RibbonControl.EffectiveStyle != global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
				{
					goto IL_182;
				}
				num = (short)55836677;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CB:
			return global::System.IntPtr.Zero;
			IL_182:
			handled = true;
			return global::System.IntPtr.Zero;
			IL_18C:
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000B9080 File Offset: 0x000B7280
		private global::System.IntPtr WmNcCalcSize(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)573440000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::System.IntPtr zero;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_21F;
					case 1:
						IL_90:
						if (this.IsGlassEnabled)
						{
							num = (short)1782644738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return zero;
					case 2:
						num = (short)1039597574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return zero;
					case 4:
						num = (short)399507457;
						if (num != 0)
						{
						}
						global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::DevComponents.WpfRibbon.WinApi.RECT>(global::DevComponents.WpfRibbon.WinApi.RECT.FromRectangle(this.GetGlassClientRectangle(hwnd, ((global::DevComponents.WpfRibbon.WinApi.RECT)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::DevComponents.WpfRibbon.WinApi.RECT))).ToRectangle())), lParam, false);
						zero = global::System.IntPtr.Zero;
						num = (short)61603840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_21F;
					case 6:
					{
						if (wParam == global::System.IntPtr.Zero)
						{
							num = (short)417398788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfRibbon.WinApi.NCCALCSIZE_PARAMS nccalcsize_PARAMS = (global::DevComponents.WpfRibbon.WinApi.NCCALCSIZE_PARAMS)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::DevComponents.WpfRibbon.WinApi.NCCALCSIZE_PARAMS));
						global::DevComponents.WpfRibbon.WinApi.WINDOWPOS windowpos = (global::DevComponents.WpfRibbon.WinApi.WINDOWPOS)global::System.Runtime.InteropServices.Marshal.PtrToStructure(nccalcsize_PARAMS.lppos, typeof(global::DevComponents.WpfRibbon.WinApi.WINDOWPOS));
						global::DevComponents.WpfRibbon.WinApi.RECT rect = global::DevComponents.WpfRibbon.WinApi.RECT.FromRectangle(this.GetGlassClientRectangle(hwnd, new global::System.Windows.Rect((double)windowpos.x, (double)windowpos.y, (double)windowpos.cx, (double)windowpos.cy)));
						nccalcsize_PARAMS.rgrc0 = rect;
						nccalcsize_PARAMS.rgrc1 = rect;
						global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::DevComponents.WpfRibbon.WinApi.NCCALCSIZE_PARAMS>(nccalcsize_PARAMS, lParam, false);
						zero = new global::System.IntPtr(1024);
						num = (short)2003828741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4B;
					IL_21F:
					num = (short)1905135289;
					short num3 = num;
					num = (short)1809649337;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
						num = (short)1137049600;
						if (num != 0)
						{
						}
						handled = true;
						num = (short)1003421699;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return zero;
				IL_4B:
				num = (short)560332800;
				short num4 = num;
				zero = global::System.IntPtr.Zero;
				num = (short)1615462401;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x000B9318 File Offset: 0x000B7518
		protected virtual global::System.Windows.Rect GetGlassClientRectangle(global::System.IntPtr hwnd, global::System.Windows.Rect r)
		{
			short num = (short)937754624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				double num4;
				int num6;
				int num7;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)877159889;
						short num3 = num;
						num = (short)1831429585;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_21B;
						default:
							num = (short)470286336;
							if (num != 0)
							{
							}
							if (num4 >= 1.5)
							{
								num = (short)1010761736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B3;
						}
						break;
					}
					case 1:
						goto IL_21B;
					case 2:
					{
						global::System.IntPtr intPtr;
						if (intPtr != global::System.IntPtr.Zero)
						{
							num = (short)49283077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return r;
					}
					case 3:
						goto IL_173;
					case 4:
						goto IL_1B3;
					case 5:
					{
						global::DevComponents.WpfRibbon.WinApi.MONITORINFO monitorinfo = new global::DevComponents.WpfRibbon.WinApi.MONITORINFO();
						global::System.IntPtr intPtr;
						global::DevComponents.WpfRibbon.WinApi.GetMonitorInfo(intPtr, monitorinfo);
						global::DevComponents.WpfRibbon.WinApi.RECT rcWork = monitorinfo.rcWork;
						global::DevComponents.WpfRibbon.WinApi.RECT rcMonitor = monitorinfo.rcMonitor;
						num = (short)2041839622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)633208832;
						short num5 = num;
						global::DevComponents.WpfRibbon.WinApi.RECT rcWork;
						if (r.Height > (double)rcWork.Height)
						{
							num = (short)1441005575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return r;
					}
					case 7:
					{
						global::DevComponents.WpfRibbon.WinApi.RECT rcWork;
						r.Height = (double)global::System.Math.Max(2, rcWork.Height + num6 - 2);
						num = (short)1085997069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num4 = 1.0 - global::System.Math.Abs(num4 - 1.0);
						num7 = (int)(num4 * (double)num7);
						num6 = (int)(num4 * (double)num6);
						num = (short)663420932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.IsGlassEnabled)
						{
							num = (short)68354060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return r;
					case 10:
						num = (short)1791426561;
						if (num != 0)
						{
						}
						num = (short)1630339083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (global::DevComponents.WpfRibbon.WinApi.IsZoomed(hwnd))
						{
							num = (short)1331757059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return r;
					case 12:
					{
						int flags = 2;
						global::System.IntPtr intPtr = global::DevComponents.WpfRibbon.WinApi.MonitorFromWindow(hwnd, flags);
						num = (short)1549205506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						return r;
					}
					goto IL_66;
					IL_173:
					num = (short)1726939145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21B:
					if (base.WindowState != global::System.Windows.WindowState.Maximized)
					{
						num = (short)618856458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
					IL_1B3:
					r.X += (double)num7;
					r.Width = global::System.Math.Max(2.0, r.Width - (double)(num7 * 2));
					r.Height = global::System.Math.Max(2.0, r.Height - (double)num6);
					num = (short)1099104257;
					num2 = (int)((global::System.IntPtr)num);
				}
				return r;
				IL_66:
				global::System.Windows.Size frameBorderSize = global::DevComponents.WpfRibbon.WinApi.FrameBorderSize;
				int borderMultiplierFactor = global::DevComponents.WpfRibbon.WinApi.BorderMultiplierFactor;
				num7 = (int)frameBorderSize.Width * borderMultiplierFactor;
				num6 = (int)frameBorderSize.Height * borderMultiplierFactor;
				num4 = this.DpiMultiplier;
				num = (short)687800320;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x000B96E0 File Offset: 0x000B78E0
		private global::System.IntPtr WmDwmCompositionChanged(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)1954349056;
			short num2 = num;
			num = (short)731096223;
			short num3 = num;
			num = (short)1425253535;
			switch (num3 == num)
			{
			}
			num = (short)1226702849;
			if (num != 0)
			{
			}
			num = (short)1782841344;
			if (num != 0)
			{
			}
			this.m_IsGlassEnabled = this.GetGlassEnabled();
			this.UpdateWindowStyle();
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000B97A4 File Offset: 0x000B79A4
		private global::System.IntPtr WmGetMinMaxInfo(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)1876099072;
			switch (num)
			{
			default:
			{
				num = (short)2076704772;
				int num2 = (int)((global::System.IntPtr)num);
				global::DevComponents.WpfRibbon.WinApi.MINMAXINFO structure;
				for (;;)
				{
					global::System.IntPtr intPtr;
					switch (num2)
					{
					case 0:
						goto IL_2E5;
					case 1:
						goto IL_88;
					case 2:
					{
						IL_248:
						global::DevComponents.WpfRibbon.WinApi.RECT rcWork;
						if (rcWork.Right - rcWork.Left > rcWork.Left)
						{
							num = (short)582352903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_281;
					}
					case 3:
					{
						global::DevComponents.WpfRibbon.WinApi.RECT rcWork;
						if (rcWork.Left > 0)
						{
							num = (short)1959002121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_281;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_6B;
						}
						continue;
					case 5:
						if (intPtr != global::System.IntPtr.Zero)
						{
							num = (short)716963848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_281;
					case 6:
					{
						global::DevComponents.WpfRibbon.WinApi.RECT rcWork;
						global::DevComponents.WpfRibbon.WinApi.RECT rcMonitor;
						structure.ptMaxSize.y = global::System.Math.Abs(rcWork.Bottom - rcWork.Top) + ((rcMonitor.Height == rcWork.Height) ? 2 : 5);
						num = (short)2135883779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_279;
					case 8:
					{
						global::DevComponents.WpfRibbon.WinApi.MONITORINFO monitorinfo = new global::DevComponents.WpfRibbon.WinApi.MONITORINFO();
						global::DevComponents.WpfRibbon.WinApi.GetMonitorInfo(intPtr, monitorinfo);
						global::DevComponents.WpfRibbon.WinApi.RECT rcWork = monitorinfo.rcWork;
						global::DevComponents.WpfRibbon.WinApi.RECT rcMonitor = monitorinfo.rcMonitor;
						structure.ptMaxPosition.x = global::System.Math.Abs(rcWork.Left - rcMonitor.Left);
						structure.ptMaxPosition.y = global::System.Math.Abs(rcWork.Top - rcMonitor.Top) - 3;
						structure.ptMaxSize.x = global::System.Math.Abs(rcWork.Right - rcWork.Left);
						num = (short)2120548358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						num = (short)1674248192;
						short num3 = num;
						num = (short)75104258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_6B:
					if (this.IsGlassEnabled)
					{
						num = (short)915668993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					structure = (global::DevComponents.WpfRibbon.WinApi.MINMAXINFO)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::DevComponents.WpfRibbon.WinApi.MINMAXINFO));
					int flags = 2;
					intPtr = global::DevComponents.WpfRibbon.WinApi.MonitorFromWindow(hwnd, flags);
					num = (short)57999365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_281:
					num = (short)363857532;
					short num4 = num;
					num = (short)1395459708;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_248;
					default:
						num = (short)1500184576;
						if (num != 0)
						{
						}
						num = (short)515506176;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_88:
				return global::System.IntPtr.Zero;
				IL_279:
				return global::System.IntPtr.Zero;
				IL_2E5:
				num = (short)1584070657;
				if (num != 0)
				{
				}
				structure.ptMinTrackSize = new global::DevComponents.WpfRibbon.WinApi.POINT((int)((base.MinWidth > 0.0) ? base.MinWidth : 160.0), (int)((base.MinHeight > 0.0) ? base.MinHeight : 38.0));
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::DevComponents.WpfRibbon.WinApi.MINMAXINFO>(structure, lParam, true);
				handled = true;
				return global::System.IntPtr.Zero;
			}
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000B9B2C File Offset: 0x000B7D2C
		private global::System.IntPtr WmSizing(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)298188800;
			short num2 = num;
			num = (short)1239691015;
			short num3 = num;
			num = (short)843984647;
			switch (num3 == num)
			{
			}
			num = (short)860291072;
			if (num != 0)
			{
			}
			num = (short)1855258625;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.WinApi.RECT rect = (global::DevComponents.WpfRibbon.WinApi.RECT)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::DevComponents.WpfRibbon.WinApi.RECT));
			this.UpdateRegion(true, rect.Width + 1, rect.Height + 1);
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000B9C08 File Offset: 0x000B7E08
		private global::System.IntPtr WmEnterSizeMove(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)639631360;
			short num2 = num;
			num = (short)592863896;
			short num3 = num;
			num = (short)695165592;
			switch (num3 == num)
			{
			}
			num = (short)466157569;
			if (num != 0)
			{
			}
			num = (short)1408237568;
			if (num != 0)
			{
			}
			this.SizingWindow = true;
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000B9CC0 File Offset: 0x000B7EC0
		private global::System.IntPtr WmExitSizeMove(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)1401618432;
			short num2 = num;
			num = (short)1661522940;
			short num3 = num;
			num = (short)1713427452;
			switch (num3 == num)
			{
			}
			num = (short)804978688;
			if (num != 0)
			{
			}
			num = (short)1915551745;
			if (num != 0)
			{
			}
			this.SizingWindow = false;
			this.UpdateRegion(true);
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000B9D7C File Offset: 0x000B7F7C
		protected override void OnLocationChanged(global::System.EventArgs e)
		{
			short num = (short)2011387683;
			short num2 = num;
			num = (short)530732835;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D0:
				this._LastTopPosition = base.Top + 28.0;
				num = (short)1886126081;
				if (num != 0)
				{
				}
				num = (short)302252033;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1345388544;
				if (num != 0)
				{
				}
				num = (short)1498939392;
				short num4 = num;
				num = (short)589299712;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_AD;
					}
					continue;
				case 1:
					goto IL_125;
				case 2:
					goto IL_168;
				case 3:
					num = (short)1866924036;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (base.Top > -32000.0)
					{
						num = (short)659030018;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16D;
				}
				IL_AD:
				if (base.WindowState == global::System.Windows.WindowState.Minimized)
				{
					break;
				}
				num = (short)260046851;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_125:
			goto IL_16D;
			IL_168:
			goto IL_D0;
			IL_16D:
			base.OnLocationChanged(e);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000B9F00 File Offset: 0x000B8100
		private global::System.IntPtr WmSize(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)1724055552;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				int num3;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						this._WasMaximized = true;
						num = (short)1746862088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num3 == 2)
						{
							num = (short)1789657110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)688586765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int flags = 2;
						global::System.IntPtr intPtr = global::DevComponents.WpfRibbon.WinApi.MonitorFromWindow(hwnd, flags);
						num = (short)2116419589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_238;
					case 4:
						goto IL_257;
					case 5:
					{
						global::System.IntPtr intPtr;
						if (intPtr != global::System.IntPtr.Zero)
						{
							num = (short)544210955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_238;
					}
					case 6:
						if (num3 == 2)
						{
							num = (short)1326645248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455;
					case 7:
						if (num3 != 2)
						{
							num = (short)216203274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F5;
					case 8:
						goto IL_27D;
					case 9:
						if (num3 == 1)
						{
							num = (short)1304756242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)173342726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)408223764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)1798585964;
						short num4 = num;
						num = (short)1732525676;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_437;
						default:
						{
							num = (short)135921664;
							if (num != 0)
							{
							}
							global::DevComponents.WpfRibbon.WinApi.MONITORINFO monitorinfo = new global::DevComponents.WpfRibbon.WinApi.MONITORINFO();
							global::System.IntPtr intPtr;
							global::DevComponents.WpfRibbon.WinApi.GetMonitorInfo(intPtr, monitorinfo);
							global::DevComponents.WpfRibbon.WinApi.RECT rcWork = monitorinfo.rcWork;
							global::DevComponents.WpfRibbon.WinApi.RECT rcMonitor = monitorinfo.rcMonitor;
							num = (short)997195793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 12:
					{
						global::DevComponents.WpfRibbon.WinApi.RECT rcWork;
						global::DevComponents.WpfRibbon.WinApi.PostMessage(hwnd, 1125, rcWork.Top, 0);
						num = (short)1976696835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (num3 == 0)
						{
							num = (short)1854406670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455;
					case 14:
						num = (short)327352339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						num = (short)210829312;
						short num5 = num;
						goto IL_1F5;
					}
					case 16:
						goto IL_1B7;
					case 17:
					{
						global::DevComponents.WpfRibbon.WinApi.RECT rcWork;
						if (this._LastTopPosition < (double)rcWork.Top)
						{
							num = (short)506855436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_238;
					}
					case 18:
						this._WasMaximized = false;
						num = (short)64028693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (this._WasMaximized)
						{
							goto IL_437;
						}
						goto IL_238;
					case 20:
						if (num3 == 0)
						{
							num = (short)1820393487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1903755273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_378;
					case 22:
						num = (short)1203109889;
						if (num != 0)
						{
						}
						this._WasMaximized = true;
						num = (short)121307152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B;
					IL_1F5:
					this.UpdateRegion(true);
					num = (short)2097610753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_238:
					this._WasMaximized = false;
					num = (short)234946564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_437:
					num = (short)65538;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B7:
				IL_257:
				IL_27D:
				IL_378:
				IL_455:
				return global::System.IntPtr.Zero;
				IL_8B:
				num3 = wParam.ToInt32();
				num = (short)1977352199;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060007FE RID: 2046
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool MoveWindow(global::System.IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		// Token: 0x060007FF RID: 2047 RVA: 0x000BA368 File Offset: 0x000B8568
		private global::System.IntPtr WmNcHitTest(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			short num = (short)1484521472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B7;
				}
				global::System.IntPtr zero;
				int num6;
				int num7;
				for (;;)
				{
					IL_28:
					global::System.Windows.Rect rect3;
					global::System.Windows.Point point2;
					switch (num2)
					{
					case 0:
						num = (short)697827335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_6AE;
					case 2:
					{
						global::System.Windows.Rect rect;
						global::System.Windows.Point point;
						if (rect.Contains(point))
						{
							num = (short)503840797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B0;
					}
					case 3:
						num = (short)228786206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!this.IsGlassEnabled)
						{
							num = (short)1216675873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3 = 4;
						num3 = (int)global::DevComponents.WpfRibbon.WinApi.FrameBorderSize.Width * global::DevComponents.WpfRibbon.WinApi.BorderMultiplierFactor;
						zero = global::System.IntPtr.Zero;
						global::DevComponents.WpfRibbon.WinApi.DwmDefWindowProc(hwnd, msg, wParam, lParam, out zero);
						int num4 = zero.ToInt32();
						num = (short)880934938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (this.RibbonControl != null)
						{
							num = (short)1785135116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B6;
					case 6:
						if (this.m_ResizeGrip != null)
						{
							num = (short)1166671890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B0;
					case 7:
						if (base.ResizeMode == global::System.Windows.ResizeMode.CanResizeWithGrip)
						{
							num = (short)252575764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B0;
					case 8:
					{
						if (this.m_ResizeGrip.Visibility != global::System.Windows.Visibility.Visible)
						{
							goto IL_4B0;
						}
						num = (short)502459772;
						short num5 = num;
						num = (short)1276374396;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_492;
						default:
							num = (short)1407647744;
							if (num != 0)
							{
							}
							num = (short)596180992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						handled = true;
						num = (short)1304428549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (base.ResizeMode != global::System.Windows.ResizeMode.NoResize)
						{
							goto IL_492;
						}
						goto IL_4B0;
					case 11:
					{
						int num4;
						if (num4 != 20)
						{
							num = (short)200671259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56D;
					}
					case 12:
						num = (short)750387214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						if (base.ResizeMode == global::System.Windows.ResizeMode.NoResize)
						{
							num = (short)753664028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						global::System.Windows.Rect rect2 = new global::System.Windows.Rect(base.ActualWidth - 120.0, (double)num3, (double)(120 - num3 * 2), 43.0);
						num = (short)1912930326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (this.RibbonControl.EffectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
						{
							num = (short)498663439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B6;
					case 15:
						goto IL_3DC;
					case 16:
						goto IL_337;
					case 17:
					{
						global::System.Windows.Point point = this.m_ResizeGrip.PointFromScreen(new global::System.Windows.Point((double)num6, (double)num7));
						global::System.Windows.Rect rect = new global::System.Windows.Rect(this.m_ResizeGrip.RenderSize);
						num = (short)1601568770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)1913847816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (rect3.Contains(point2))
						{
							num = (short)356909065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1597898756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1348665368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						int num4;
						if (num4 != 8)
						{
							num = (short)101515267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56D;
					}
					case 22:
					{
						global::System.Windows.Rect rect2;
						if (rect2.Contains(point2))
						{
							num = (short)2073821184;
							short num8 = num;
							num = (short)1570373648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B3;
					}
					case 23:
						num = (short)1443299338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (base.WindowState == global::System.Windows.WindowState.Normal)
						{
							num = (short)1670971415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B0;
					case 25:
						num = (short)278921227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						int num4;
						if (num4 != 8)
						{
							num = (short)956366879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56D;
					}
					case 27:
						num = (short)1382219777;
						if (num != 0)
						{
						}
						num = (short)544866325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_1F6;
					case 29:
						goto IL_1B3;
					case 30:
					{
						int num4;
						if (num4 == 21)
						{
							num = (short)1531707393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1946943501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						num = (short)1421279264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						int num4;
						if (num4 != 9)
						{
							num = (short)355270681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56D;
					}
					case 33:
						goto IL_375;
					}
					goto IL_B7;
					IL_492:
					num = (short)1469120529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B0:
					point2 = base.PointFromScreen(new global::System.Windows.Point((double)num6, (double)num7));
					rect3 = new global::System.Windows.Rect(4.0, 4.0, 16.0, 16.0);
					num = (short)1304231955;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B3:
				handled = true;
				return new global::System.IntPtr(1);
				IL_1F6:
				handled = true;
				return global::System.IntPtr.Zero;
				IL_337:
				handled = true;
				return new global::System.IntPtr(1);
				IL_375:
				return global::System.IntPtr.Zero;
				IL_3DC:
				return new global::System.IntPtr(3);
				IL_56D:
				handled = true;
				return zero;
				IL_5B6:
				return new global::System.IntPtr(1);
				IL_6AE:
				goto IL_56D;
				IL_6B3:
				handled = false;
				return global::System.IntPtr.Zero;
				IL_B7:
				num6 = global::DevComponents.WpfRibbon.WinApi.LOWORD(lParam);
				num7 = global::DevComponents.WpfRibbon.WinApi.HIWORD(lParam);
				num = (short)752287750;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x000BAA34 File Offset: 0x000B8C34
		private bool IsGlassEnabled
		{
			get
			{
				short num = (short)1387057625;
				short num2 = num;
				num = (short)1088344537;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				case 1:
					break;
				default:
				{
					num = (short)115212288;
					short num3 = num;
					break;
				}
				}
				num = (short)300417024;
				if (num != 0)
				{
				}
				if (this.m_IsGlassEnabled)
				{
					num = (short)2012282881;
					if (num != 0)
					{
					}
					return this.EnableGlass;
				}
				return false;
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000BAAF0 File Offset: 0x000B8CF0
		private bool GetGlassEnabled()
		{
			short num = (short)1893400576;
			short num2 = num;
			num = (short)583325848;
			short num3 = num;
			num = (short)144693400;
			switch (num3 == num)
			{
			}
			num = (short)1976827905;
			if (num != 0)
			{
			}
			num = (short)708247552;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.WinApi.IsGlassEnabled;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x000BABA0 File Offset: 0x000B8DA0
		private double DpiMultiplier
		{
			get
			{
				double num5;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::System.Windows.Point resolution;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
						{
							num2 = (short)849281024;
							short num3 = num2;
							num2 = (short)1627742470;
							short num4 = num2;
							num2 = (short)1500274950;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)444989441;
								if (num2 != 0)
								{
								}
								num2 = (short)1878720512;
								if (num2 != 0)
								{
								}
								if (resolution.Y != 96.0)
								{
									num2 = (short)1690959874;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								return num5;
							}
							break;
						}
						case 1:
							return num5;
						case 2:
							num5 += (resolution.Y - 96.0) / 96.0;
							num2 = (short)1126694913;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					IL_1C:
					num5 = 1.0;
					resolution = global::DevComponents.WpfRibbon.LayoutHelpers.GetResolution(this);
					num2 = (short)37289984;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				return num5;
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000BACF0 File Offset: 0x000B8EF0
		protected override void OnStateChanged(global::System.EventArgs e)
		{
			short num = (short)915472384;
			short num2 = num;
			num = (short)1256611598;
			short num3 = num;
			num = (short)1327062798;
			switch (num3 == num)
			{
			}
			num = (short)1482162177;
			if (num != 0)
			{
			}
			num = (short)488701952;
			if (num != 0)
			{
			}
			base.OnStateChanged(e);
			this.HandleWindowStateChanged();
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000BADA4 File Offset: 0x000B8FA4
		private void HandleWindowStateChanged()
		{
			for (;;)
			{
				IL_00:
				short num = (short)167706630;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (base.WindowState == global::System.Windows.WindowState.Maximized)
						{
							num = (short)1972043780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1604386830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1267536408;
						short num3 = num;
						num = (short)1603015192;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1762852864;
							if (num != 0)
							{
							}
							num = (short)703528960;
							short num4 = num;
							num = (short)2103967747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						num = (short)1681063952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (base.WindowState == global::System.Windows.WindowState.Normal)
						{
							num = (short)850132994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_414;
					case 4:
						num = (short)1116864519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1594359816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 7:
						if (!this._GlassSizeAdjusted)
						{
							num = (short)311820300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					case 8:
						if (base.WindowState != global::System.Windows.WindowState.Maximized)
						{
							num = (short)1709309953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					case 9:
						num = (short)2120744961;
						if (num != 0)
						{
						}
						goto IL_338;
					case 10:
						goto IL_357;
					case 11:
						goto IL_35C;
					case 12:
						this.m_RibbonControl.WindowBorderThickness = new global::System.Windows.Thickness(this.m_RibbonControl.WindowBorderThickness.Left, this.m_RibbonControl.WindowBorderThickness.Top + global::DevComponents.WpfRibbon.RibbonWindow.MaximizedGlassTopAdjustment, this.m_RibbonControl.WindowBorderThickness.Right, this.m_RibbonControl.WindowBorderThickness.Bottom);
						this._GlassSizeAdjusted = true;
						num = (short)1500971017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						this.m_RibbonControl.WindowBorderThickness = new global::System.Windows.Thickness(this.m_RibbonControl.WindowBorderThickness.Left, this.m_RibbonControl.WindowBorderThickness.Top - global::DevComponents.WpfRibbon.RibbonWindow.MaximizedGlassTopAdjustment, this.m_RibbonControl.WindowBorderThickness.Right, this.m_RibbonControl.WindowBorderThickness.Bottom);
						this._GlassSizeAdjusted = false;
						num = (short)289472530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (this._GlassSizeAdjusted)
						{
							num = (short)1364918285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					case 15:
						if (this.m_RibbonControl != null)
						{
							num = (short)2124742673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_338;
					case 16:
						if (this.m_PreviousWindowState == global::System.Windows.WindowState.Maximized)
						{
							num = (short)404815883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_414;
					case 17:
						num = (short)264634368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_338;
					}
					IL_72:
					if (this.IsGlassEnabled)
					{
						num = (short)1726939141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_414;
					IL_338:
					this.UpdateGlass();
					num = (short)1912668170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35C:
					num = (short)1114701839;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_357:
			IL_414:
			this.m_PreviousWindowState = base.WindowState;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000BB1D4 File Offset: 0x000B93D4
		internal void UpdateGlass()
		{
			short num = (short)1057947648;
			switch (num)
			{
			default:
			{
				num = (short)472907783;
				int num2 = (int)((global::System.IntPtr)num);
				int glassHeight;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_33B;
					case 1:
						goto IL_266;
					case 2:
						num = (short)738197526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_456;
					case 4:
						goto IL_2A7;
					case 5:
					{
						num = (short)1925567227;
						short num3 = num;
						num = (short)352113403;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C5;
						default:
							num = (short)48103424;
							if (num != 0)
							{
							}
							this.m_RibbonControl.IsUsingGlass = true;
							num = (short)669777923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_456;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						continue;
					case 8:
						if (this.m_RibbonControl != null)
						{
							num = (short)1166671877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_456;
					case 9:
					{
						if (!this.m_RibbonControl.HasCaption)
						{
							num = (short)2001141778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double dpiMultiplier = this.DpiMultiplier;
						double top = this.m_RibbonControl.GetTitleChromeHeight() - 1.0;
						glassHeight = (int)global::System.Math.Ceiling(this.m_RibbonControl.GetTitleChromeHeight() * dpiMultiplier) - 1;
						num = (short)641990672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)1612578836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.m_Border != null)
						{
							num = (short)1667563533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_496;
					case 12:
						num = (short)579338248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						double top;
						this.m_Border.TransparentMargin = new global::System.Windows.Thickness(0.0, top, 0.0, 0.0);
						num = (short)1702035457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (this.m_RibbonControl != null)
						{
							num = (short)711327765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C5;
					case 15:
						this.m_RibbonControl.IsUsingGlass = false;
						num = (short)2078932998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_33B;
					case 17:
						if (this.IsGlassEnabled)
						{
							num = (short)337903628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_456;
					case 18:
						goto IL_1C5;
					case 19:
						if (this.IsGlassEnabled)
						{
							num = (short)2061434882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 20:
						if (this.m_RibbonControl != null)
						{
							num = (short)1496711183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_108;
					case 21:
						goto IL_C5;
					case 22:
					{
						if (!this.m_SourceInitialized)
						{
							num = (short)349437956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						glassHeight = 0;
						double top = 27.0;
						num = (short)1392836609;
						if (num != 0)
						{
						}
						num = (short)593231886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9F:
					if (!this.IsGlassEnabled)
					{
						num = (short)880541706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_108;
					IL_C5:
					num = (short)2121990153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_108:
					num = (short)1268711441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C5:
					glassHeight = (int)global::DevComponents.WpfRibbon.WinApi.FrameBorderSize.Height * global::DevComponents.WpfRibbon.WinApi.BorderMultiplierFactor;
					num = (short)806354944;
					short num4 = num;
					num = (short)1605632000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33B:
					num = (short)452984843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_456:
					num = (short)1683947539;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_266:
				goto IL_496;
				IL_2A7:
				return;
				IL_496:
				global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
				global::System.Windows.Interop.HwndSource.FromHwnd(handle).CompositionTarget.BackgroundColor = global::System.Windows.Media.Colors.Transparent;
				global::DevComponents.WpfRibbon.WinApi.ExtendGlass(handle, glassHeight);
				return;
			}
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x000BB6A0 File Offset: 0x000B98A0
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x000BB750 File Offset: 0x000B9950
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::DevComponents.WpfRibbon.Ribbon RibbonControl
		{
			get
			{
				short num = (short)1169202339;
				short num2 = num;
				num = (short)183344291;
				switch (num2 == num)
				{
				}
				num = (short)1902903297;
				if (num != 0)
				{
				}
				num = (short)1636433920;
				short num3 = num;
				num = (short)1520304128;
				if (num != 0)
				{
				}
				return this.m_RibbonControl;
			}
			set
			{
				short num = (short)1981743109;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.m_RibbonControl != null)
						{
							num = (short)702414854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DA;
					case 1:
						goto IL_1D8;
					case 2:
						goto IL_18C;
					case 3:
						goto IL_6A;
					case 4:
					{
						num = (short)1511372997;
						short num3 = num;
						num = (short)570079429;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18C;
						default:
							num = (short)1661009920;
							if (num != 0)
							{
							}
							num = (short)1191247874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 6:
						this.m_RibbonControl.SetupBindings();
						num = (short)1690697729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						this.m_RibbonControl.ReleaseBindings();
						num = (short)1438318592;
						short num4 = num;
						num = (short)1170735107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_44:
					if (this.m_RibbonControl != value)
					{
						num = (short)1763639300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_6A:
					this.m_RibbonControl = value;
					num = (short)244973569;
					if (num != 0)
					{
					}
					num = (short)770637824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18C:
					if (this.m_RibbonControl == null)
					{
						goto IL_6A;
					}
					num = (short)1597964295;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D8:
				IL_1DA:
				this.UpdateGlass();
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x000BB940 File Offset: 0x000B9B40
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x000BB9F8 File Offset: 0x000B9BF8
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool EnableGlass
		{
			get
			{
				short num = (short)1000563450;
				short num2 = num;
				num = (short)801465082;
				switch (num2 == num)
				{
				}
				num = (short)42270721;
				if (num != 0)
				{
				}
				num = (short)1440284672;
				short num3 = num;
				num = (short)2141716480;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonWindow.EnableGlassProperty);
			}
			set
			{
				short num = (short)1674486849;
				short num2 = num;
				num = (short)682271809;
				switch (num2 == num)
				{
				}
				num = (short)1775763457;
				if (num != 0)
				{
				}
				num = (short)1828782080;
				short num3 = num;
				num = (short)121044992;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonWindow.EnableGlassProperty, value);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000BBAB4 File Offset: 0x000B9CB4
		private static void EnableGlassChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)2012691729;
			short num2 = num;
			num = (short)667499793;
			switch (num2 == num)
			{
			}
			num = (short)2032599041;
			if (num != 0)
			{
			}
			num = (short)291373056;
			short num3 = num;
			num = (short)2029584384;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.RibbonWindow)d).OnEnableGlassChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000BBB84 File Offset: 0x000B9D84
		private void OnEnableGlassChanged(bool oldValue, bool newValue)
		{
			short num = (short)638521327;
			short num2 = num;
			num = (short)681381871;
			switch (num2 == num)
			{
			}
			num = (short)1358102528;
			if (num != 0)
			{
			}
			num = (short)1730019328;
			short num3 = num;
			num = (short)1717370881;
			if (num != 0)
			{
			}
			this.UpdateWindowStyle();
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000BBC34 File Offset: 0x000B9E34
		private int GetSystemCaptionHeight()
		{
			short num = (short)1219271083;
			short num2 = num;
			num = (short)1797757355;
			switch (num2 == num)
			{
			}
			num = (short)437059585;
			if (num != 0)
			{
			}
			num = (short)2122383360;
			short num3 = num;
			num = (short)192544768;
			if (num != 0)
			{
			}
			return (int)global::DevComponents.WpfRibbon.WinApi.FrameBorderSize.Height * global::DevComponents.WpfRibbon.WinApi.BorderMultiplierFactor + global::DevComponents.WpfRibbon.WinApi.CaptionHeight;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000BBCF8 File Offset: 0x000B9EF8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)182976518;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				double num3;
				int num5;
				switch (num2)
				{
				case 0:
					if (global::System.Environment.Version.Major < 4)
					{
						num = (short)1054998531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36B;
				case 1:
					num3 = this.DpiMultiplier;
					num = (short)319946769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_2B5;
				case 3:
					goto IL_118;
				case 4:
					if (num3 >= 1.0)
					{
						num = (short)718733321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93;
				case 5:
					goto IL_1DD;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 7:
					num3 = 1.0 - global::System.Math.Abs(num3 - 1.0);
					num = (short)1283063810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_20E;
				case 9:
				{
					num = (short)1907032065;
					if (num != 0)
					{
					}
					num = (short)1443842667;
					short num4 = num;
					num = (short)32328299;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_118;
					default:
						num = (short)961937408;
						if (num != 0)
						{
						}
						num = (short)1863319566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					num5 = 4;
					num = (short)1934426128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (availableSize.Height != double.PositiveInfinity)
					{
						num = (short)808779777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36B;
				case 12:
					if (num3 >= 1.0)
					{
						num = (short)2016870410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DD;
				case 13:
					num5 = 2;
					num = (short)2032009221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (num3 < 1.3)
					{
						num = (short)1329004557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93;
				case 15:
					num = (short)1100742656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_1DD;
				case 17:
					if (num3 >= 1.0)
					{
						num = (short)1257832455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B5;
				}
				IL_6E:
				if (this.IsGlassEnabled)
				{
					num = (short)2031157263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_36B;
				IL_93:
				num = (short)1066860556;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_118:
				num = (short)655097867;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DD:
				availableSize.Height += (double)this.GetSystemCaptionHeight() * num3 + (double)num5;
				num = (short)1110704136;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B5:
				num5 = 0;
				num = (short)402587652;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_20E:
			num = (short)810745856;
			short num6 = num;
			IL_36B:
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000BC078 File Offset: 0x000BA278
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeBounds)
		{
			short num = (short)1100283909;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				double num3;
				switch (num2)
				{
				case 0:
					goto IL_1C3;
				case 1:
					goto IL_1F8;
				case 2:
					goto IL_19A;
				case 3:
					num3 = 1.0 - global::System.Math.Abs(num3 - 1.0);
					num = (short)842137600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)55221708;
					short num4 = num;
					num = (short)2124717516;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19A;
					default:
						num = (short)699072512;
						if (num != 0)
						{
						}
						num = (short)1707671554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 6:
					if (num3 >= 1.0)
					{
						num = (short)702873601;
						if (num != 0)
						{
						}
						num = (short)1933443072;
						short num5 = num;
						num = (short)1864171523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C3;
				case 7:
					num3 = this.DpiMultiplier;
					num = (short)237633542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_45:
				if (this.IsGlassEnabled)
				{
					num = (short)1479737348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_19A:
				if (global::System.Environment.Version.Major < 4)
				{
					num = (short)70778887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1C3:
				arrangeBounds.Height += global::System.Math.Ceiling((double)this.GetSystemCaptionHeight() * num3);
				num = (short)1011875841;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F8:
			return base.ArrangeOverride(arrangeBounds);
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x000BC288 File Offset: 0x000BA488
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x000BC340 File Offset: 0x000BA540
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsUsingGlass
		{
			get
			{
				short num = (short)1165254000;
				short num2 = num;
				num = (short)1463704944;
				switch (num2 == num)
				{
				}
				num = (short)522977280;
				if (num != 0)
				{
				}
				num = (short)1499332608;
				short num3 = num;
				num = (short)1926627329;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.RibbonWindow.IsUsingGlassProperty);
			}
			internal set
			{
				short num = (short)2128597491;
				short num2 = num;
				num = (short)2005979635;
				switch (num2 == num)
				{
				}
				num = (short)1652228097;
				if (num != 0)
				{
				}
				num = (short)1024065536;
				short num3 = num;
				num = (short)1034354688;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.RibbonWindow.IsUsingGlassPropertyKey, value);
			}
		}

		// Token: 0x040006A6 RID: 1702
		public static readonly global::System.Windows.DependencyProperty EnableGlassProperty;

		// Token: 0x040006A7 RID: 1703
		public static readonly global::System.Windows.DependencyProperty IsUsingGlassProperty;

		// Token: 0x040006A8 RID: 1704
		private static readonly global::System.Windows.DependencyPropertyKey IsUsingGlassPropertyKey;

		// Token: 0x040006A9 RID: 1705
		private bool m_IsGlassEnabled;

		// Token: 0x040006AA RID: 1706
		private global::DevComponents.WpfRibbon.Ribbon m_RibbonControl;

		// Token: 0x040006AB RID: 1707
		private bool m_SourceInitialized;

		// Token: 0x040006AC RID: 1708
		private const string PartWindowBorder = "PART_WindowBorder";

		// Token: 0x040006AD RID: 1709
		private const string PartWindowResizeGrip = "WindowResizeGrip";

		// Token: 0x040006AE RID: 1710
		private global::DevComponents.WpfRibbon.WindowBorder m_Border;

		// Token: 0x040006AF RID: 1711
		private bool m_SizingWindow;

		// Token: 0x040006B0 RID: 1712
		private global::System.Windows.Controls.Primitives.ResizeGrip m_ResizeGrip;

		// Token: 0x040006B1 RID: 1713
		internal static double MaximizedGlassTopAdjustment;

		// Token: 0x040006B2 RID: 1714
		private bool m_CursorIsSet;

		// Token: 0x040006B3 RID: 1715
		internal static bool SiziningWindowInProgress;

		// Token: 0x040006B4 RID: 1716
		private double _LastTopPosition;

		// Token: 0x040006B5 RID: 1717
		private bool _WasMaximized;

		// Token: 0x040006B6 RID: 1718
		private global::System.Windows.WindowState m_PreviousWindowState;

		// Token: 0x040006B7 RID: 1719
		private bool _GlassSizeAdjusted;
	}
}
