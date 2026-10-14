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
	// Token: 0x0200003E RID: 62
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SuperTabPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00056408 File Offset: 0x00054608
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x000564C0 File Offset: 0x000546C0
		public bool IsOversized
		{
			get
			{
				short num = (short)284643869;
				short num2 = num;
				num = (short)104813085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)777453568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1955069952;
				if (num != 0)
				{
				}
				num = (short)1434517505;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.SuperTabPanel.IsOversizedProperty);
			}
			internal set
			{
				short num = (short)1969593185;
				short num2 = num;
				num = (short)109091681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1183055872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)14483457;
				if (num != 0)
				{
				}
				num = (short)456589312;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabPanel.a, value);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00056578 File Offset: 0x00054778
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00056634 File Offset: 0x00054834
		public global::DevComponents.WpfEditors.eSuperTabControlLayoutType LayoutType
		{
			get
			{
				short num = (short)1837440077;
				short num2 = num;
				num = (short)243276877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521549312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)416874497;
				if (num != 0)
				{
				}
				num = (short)1121255424;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.eSuperTabControlLayoutType)base.GetValue(global::DevComponents.WpfEditors.SuperTabPanel.LayoutTypeProperty);
			}
			set
			{
				short num = (short)1845611362;
				short num2 = num;
				num = (short)2099366754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2015625216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)676790272;
				if (num != 0)
				{
				}
				num = (short)2143289345;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabPanel.LayoutTypeProperty, value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000566EC File Offset: 0x000548EC
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000567A4 File Offset: 0x000549A4
		public double TabTuck
		{
			get
			{
				short num = (short)1644640792;
				short num2 = num;
				num = (short)976501272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1290665984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)642580480;
				if (num != 0)
				{
				}
				num = (short)1972961281;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfEditors.SuperTabPanel.TabTuckProperty);
			}
			set
			{
				short num = (short)1127982178;
				short num2 = num;
				num = (short)358392930;
				switch (num2 == num)
				{
				default:
				{
					num = (short)274202624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1376256000;
				if (num != 0)
				{
				}
				num = (short)66322433;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabPanel.TabTuckProperty, value);
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0005685C File Offset: 0x00054A5C
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.SuperTabPanel superTabPanel;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2091712513;
					if (num2 != 0)
					{
					}
					if (superTabPanel != null)
					{
						goto IL_62;
					}
					goto IL_B0;
				case 1:
					goto IL_B0;
				case 2:
					superTabPanel.OnBorderBrushChanged((global::System.Windows.Media.Brush)A_1.OldValue, (global::System.Windows.Media.Brush)A_1.NewValue);
					num2 = (short)226033665;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
				IL_62:
				num2 = (short)637206530;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_B0:
				num2 = (short)818180848;
				short num3 = num2;
				num2 = (short)1728213744;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_62;
				default:
					goto IL_E7;
				}
			}
			IL_E7:
			num2 = (short)59834368;
			if (num2 != 0)
			{
			}
			num2 = (short)2091974656;
			short num4 = num2;
			return;
			IL_1C:
			superTabPanel = (A_0 as global::DevComponents.WpfEditors.SuperTabPanel);
			num2 = (short)705560576;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00056990 File Offset: 0x00054B90
		protected virtual void OnBorderBrushChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
			short num = (short)1676607491;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B7;
				case 1:
					goto IL_E7;
				case 2:
					this.c = new global::System.Windows.Media.Pen(newValue, 1.0);
					goto IL_CE;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				if (newValue != null)
				{
					num = (short)257949698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.c = null;
				num = (short)661689875;
				short num3 = num;
				num = (short)1762825747;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)31850496;
					if (num != 0)
					{
					}
					num = (short)463077376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CE:
				num = (short)853082113;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B7:
			goto IL_113;
			IL_E7:
			num = (short)2063663104;
			short num4 = num;
			IL_113:
			num = (short)1937768449;
			if (num != 0)
			{
			}
			this.e();
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00056AE0 File Offset: 0x00054CE0
		private void e()
		{
			short num = (short)466223106;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)35894896;
					short num3 = num;
					num = (short)111326832;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11E;
					default:
						num = (short)1656160257;
						if (num != 0)
						{
						}
						num = (short)1571291136;
						if (num != 0)
						{
						}
						base.InvalidateMeasure();
						num = (short)1944649729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_63;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				int num4 = this.b;
				this.b = 0;
				if (this.BorderBrush != null)
				{
					this.b = 2;
				}
				if (this.InnerBorderBrush != null)
				{
					this.b = 2;
				}
				if (num4 == this.b)
				{
					break;
				}
				num = (short)968753152;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_63:
			IL_11E:
			num = (short)122683392;
			short num5 = num;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00056C34 File Offset: 0x00054E34
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00056CEC File Offset: 0x00054EEC
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)1999535794;
				short num2 = num;
				num = (short)1234927282;
				switch (num2 == num)
				{
				}
				num = (short)1005322240;
				if (num != 0)
				{
				}
				num = (short)253493248;
				short num3 = num;
				num = (short)18350081;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.SuperTabPanel.BorderBrushProperty);
			}
			set
			{
				short num = (short)119493458;
				short num2 = num;
				num = (short)1067864914;
				switch (num2 == num)
				{
				}
				num = (short)1037172737;
				if (num != 0)
				{
				}
				num = (short)906100736;
				short num3 = num;
				num = (short)385744896;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabPanel.BorderBrushProperty, value);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00056DA4 File Offset: 0x00054FA4
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			short num;
			int num2;
			global::DevComponents.WpfEditors.SuperTabPanel superTabPanel;
			for (;;)
			{
				IL_0A:
				num = (short)1850933249;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1286015427;
					short num3 = num;
					num = (short)801180099;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_98;
					default:
						goto IL_E6;
					}
					break;
				}
				case 1:
					superTabPanel.OnInnerBorderBrushChanged((global::System.Windows.Media.Brush)A_1.OldValue, (global::System.Windows.Media.Brush)A_1.NewValue);
					goto IL_98;
				case 2:
					if (superTabPanel != null)
					{
						num = (short)1729691649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FF;
				}
				goto IL_43;
				IL_98:
				num = (short)1440743424;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E6:
			num = (short)708182016;
			if (num != 0)
			{
			}
			IL_FF:
			num = (short)73793536;
			short num4 = num;
			return;
			IL_43:
			superTabPanel = (A_0 as global::DevComponents.WpfEditors.SuperTabPanel);
			num = (short)741998594;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00056EDC File Offset: 0x000550DC
		protected virtual void OnInnerBorderBrushChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
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
					num2 = (short)1520174440;
					short num3 = num2;
					num2 = (short)637797736;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
						goto IL_DC;
					}
					break;
				}
				case 1:
					num2 = (short)1802371073;
					if (num2 != 0)
					{
					}
					this.d = new global::System.Windows.Media.Pen(newValue, 1.0);
					goto IL_90;
				case 2:
					if (newValue != null)
					{
						num2 = (short)752025601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F3;
				}
				goto IL_1C;
				IL_90:
				num2 = (short)525402112;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_DC:
			num2 = (short)360054784;
			if (num2 != 0)
			{
			}
			IL_F3:
			num2 = (short)561184768;
			short num4 = num2;
			this.e();
			return;
			IL_1C:
			this.d = null;
			num2 = (short)1362296834;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0005700C File Offset: 0x0005520C
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x000570C0 File Offset: 0x000552C0
		public global::System.Windows.Media.Brush InnerBorderBrush
		{
			get
			{
				short num = (short)861012089;
				short num2 = num;
				num = (short)729677945;
				switch (num2 == num)
				{
				}
				num = (short)420413441;
				if (num != 0)
				{
				}
				num = (short)1680736256;
				short num3 = num;
				num = (short)1260584960;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.SuperTabPanel.InnerBorderBrushProperty);
			}
			set
			{
				short num = (short)67964123;
				short num2 = num;
				num = (short)1230507227;
				switch (num2 == num)
				{
				}
				num = (short)1942683649;
				if (num != 0)
				{
				}
				num = (short)1393033216;
				short num3 = num;
				num = (short)649723904;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.SuperTabPanel.InnerBorderBrushProperty, value);
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00057178 File Offset: 0x00055378
		static SuperTabPanel()
		{
			int a_ = 10;
			short num = (short)74904222;
			short num2 = num;
			num = (short)1034220190;
			switch (num2 == num)
			{
			}
			num = (short)1615527937;
			if (num != 0)
			{
			}
			num = (short)202571776;
			short num3 = num;
			num = (short)483459072;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.SuperTabPanel.a = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("黖꫘铚ꯜ뫞鏠郢賤鷦賨迪", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.SuperTabPanel), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfEditors.SuperTabPanel.IsOversizedProperty = global::DevComponents.WpfEditors.SuperTabPanel.a.DependencyProperty;
			global::DevComponents.WpfEditors.SuperTabPanel.LayoutTypeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯖룘ꋚ닜꫞闠럢鳤韦賨", a_), typeof(global::DevComponents.WpfEditors.eSuperTabControlLayoutType), typeof(global::DevComponents.WpfEditors.SuperTabPanel), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfEditors.eSuperTabControlLayoutType.SingleLine, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
			global::DevComponents.WpfEditors.SuperTabPanel.TabTuckProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菖룘맚觜꫞苠裢", a_), typeof(double), typeof(global::DevComponents.WpfEditors.SuperTabPanel), new global::System.Windows.FrameworkPropertyMetadata(2.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
			global::DevComponents.WpfEditors.SuperTabPanel.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闖뛘꧚맜뫞鏠ꇢ韤鋦髨菪", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.SuperTabPanel), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabPanel.b)));
			global::DevComponents.WpfEditors.SuperTabPanel.InnerBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("黖럘뗚룜귞ꏠ賢韤菦賨駪꿬鷮蓰胲鷴", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.SuperTabPanel), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.SuperTabPanel.a)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.SuperTabPanel), global::System.Windows.Controls.Primitives.Selector.SelectedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.SuperTabPanel.b));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.SuperTabPanel), global::DevComponents.WpfEditors.SuperTabItem.HeaderChangedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.SuperTabPanel.a));
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000573A4 File Offset: 0x000555A4
		private static void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)146441843;
			short num2 = num;
			num = (short)1854572147;
			switch (num2 == num)
			{
			}
			num = (short)157745153;
			if (num != 0)
			{
			}
			num = (short)1758003200;
			short num3 = num;
			num = (short)207880192;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.SuperTabPanel)A_0).InvalidateVisual();
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0005745C File Offset: 0x0005565C
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1286209537;
			if (num != 0)
			{
			}
			num = (short)991470832;
			short num2 = num;
			num = (short)380937456;
			switch (num2 == num)
			{
			}
			num = (short)1458765824;
			short num3 = num;
			num = (short)965476352;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.SuperTabPanel)A_0).InvalidateVisual();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00057510 File Offset: 0x00055710
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)1824260096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CA;
				}
				global::System.Windows.Size result;
				bool a_;
				global::DevComponents.WpfEditors.eSuperTabControlLayoutType layoutType;
				for (;;)
				{
					IL_27:
					global::System.Windows.Size size;
					global::System.Windows.Controls.Dock dock;
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_4C9;
					case 1:
						goto IL_4C9;
					case 2:
					{
						num = (short)843589596;
						short num3 = num;
						num = (short)1823156188;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_119;
						default:
							num = (short)515768320;
							if (num != 0)
							{
							}
							result.Width = availableSize.Width;
							a_ = true;
							num = (short)1020002313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_119;
					case 4:
						num = (short)835190819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1318191132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (result.Height > availableSize.Height)
						{
							num = (short)1114898448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C9;
					case 7:
						result = this.MeasureMultiLine(availableSize);
						num = (short)1582628881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_4C9;
					case 9:
						goto IL_4C9;
					case 10:
						goto IL_4C9;
					case 11:
						if (result.Width > availableSize.Width)
						{
							num = (short)2102788098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_451;
					case 12:
						if (layoutType == global::DevComponents.WpfEditors.eSuperTabControlLayoutType.SingleLine)
						{
							num = (short)1299841057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						size = this.a(availableSize, 0.0);
						num = (short)1281359906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (layoutType == global::DevComponents.WpfEditors.eSuperTabControlLayoutType.Multiline)
						{
							num = (short)1996816391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)866254860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (dock == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)1108475929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result.Width = global::System.Math.Ceiling(result.Width + (double)this.b);
						num = (short)2087976987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (this.e > 0.0)
						{
							num = (short)1331298334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DC;
					case 16:
						a_ = true;
						result.Height = availableSize.Height;
						num = (short)1308491800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)210698241;
						if (num != 0)
						{
						}
						goto IL_4C9;
					case 18:
						if (dock != global::System.Windows.Controls.Dock.Top)
						{
							num = (short)174522387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_419;
					case 19:
						num = (short)1979383822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (!flag)
						{
							num = (short)1173028867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_451;
					case 21:
						goto IL_44C;
					case 22:
						num = (short)380436516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						double a_2 = (this.e - (size.Width - availableSize.Width)) / this.e;
						result = this.a(availableSize, a_2);
						num = (short)724631562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_4C9;
					case 25:
						goto IL_419;
					case 26:
						if (flag)
						{
							num = (short)1348665376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C9;
					case 27:
						goto IL_630;
					case 28:
						flag2 = (this.TabStripPlacement == global::System.Windows.Controls.Dock.Right);
						goto IL_510;
					case 29:
						if (size.Width > availableSize.Width)
						{
							num = (short)493682692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					case 30:
					{
						double a_3 = (this.e - (size.Height - availableSize.Height)) / this.e;
						result = this.a(availableSize, a_3);
						num = (short)1186988033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						num = (short)1836253199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1347682310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						result = this.a(availableSize, 0.0);
						num = (short)1178664980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						if (flag)
						{
							num = (short)2085683222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)946143232;
						short num4 = num;
						num = (short)1745551389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						if (this.e > 0.0)
						{
							num = (short)1981743127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					case 36:
						if (size.Height > availableSize.Height)
						{
							num = (short)1749811231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DC;
					case 37:
						flag2 = true;
						goto IL_510;
					case 38:
						if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Left)
						{
							num = (short)809566213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)199098405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CA;
					IL_119:
					num = (short)1603010571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_324:
					result = size;
					num = (short)312279048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_419:
					result.Height = global::System.Math.Ceiling(result.Height + (double)this.b);
					num = (short)1199439893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_451:
					num = (short)210173978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C9:
					dock = this.TabStripPlacement;
					num = (short)190513170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_510:
					flag = flag2;
					a_ = false;
					num = (short)1099300877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5DC:
					result = size;
					num = (short)1734737920;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_44C:
				IL_630:
				global::DevComponents.WpfEditors.d.a(ref result);
				this.IsOversized = a_;
				return result;
				IL_CA:
				result = default(global::System.Windows.Size);
				layoutType = this.LayoutType;
				num = (short)496828454;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00057C68 File Offset: 0x00055E68
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)2063663105;
			if (num != 0)
			{
			}
			num = (short)974782467;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Size result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					return result;
				case 2:
					result = this.ArrangeMultiLine(finalSize);
					goto IL_FA;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				}
				IL_5C:
				int layoutType = (int)this.LayoutType;
				result = default(global::System.Windows.Size);
				if (layoutType == 2)
				{
					num = (short)1139408898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				result = this.ArrangeSingleLine(finalSize);
				num = (short)1363329133;
				short num3 = num;
				num = (short)994033773;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)754057216;
					if (num != 0)
					{
					}
					num = (short)1203896320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_FA:
				num = (short)1305149440;
				short num4 = num;
				num = (short)1193934849;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00057DB4 File Offset: 0x00055FB4
		private global::System.Windows.Size a(global::System.Windows.Size A_0, double A_1)
		{
			short num = (short)1111687168;
			short num2 = num;
			num = (short)1971716096;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				this.e = 0.0;
				global::System.Windows.Size result = default(global::System.Windows.Size);
				global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
				bool flag = !global::DevComponents.WpfEditors.d.a(A_1);
				bool flag2;
				if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Left)
				{
					flag2 = (this.TabStripPlacement == global::System.Windows.Controls.Dock.Right);
					goto IL_74F;
				}
				IL_741:
				flag2 = true;
				IL_74F:
				bool flag3 = flag2;
				double tabTuck = this.TabTuck;
				bool flag4 = true;
				global::System.Collections.IEnumerator enumerator = internalChildren.GetEnumerator();
				try
				{
					num = (short)1152319520;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Windows.Size desiredSize;
						global::System.Windows.Size availableSize;
						global::System.Windows.UIElement uielement;
						switch (num3)
						{
						case 0:
							this.e += desiredSize.Width - (flag4 ? 0.0 : tabTuck);
							num = (short)944308244;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (flag3)
							{
								num = (short)902103064;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							availableSize.Width = global::System.Math.Max(22.0, global::System.Math.Floor(availableSize.Width * A_1));
							num = (short)1720975377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_457;
						case 3:
							goto IL_603;
						case 4:
							num = (short)82313231;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
							{
								num = (short)1225719822;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							result.Height = desiredSize.Height;
							num = (short)1555038237;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)1615265810;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							availableSize = uielement.DesiredSize;
							availableSize.Width = global::System.Math.Round(availableSize.Width);
							availableSize.Height = global::System.Math.Round(availableSize.Height);
							num = (short)1079377921;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (result.Width < desiredSize.Width)
							{
								num = (short)60096538;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_457;
						case 11:
							goto IL_346;
						case 12:
							this.e += desiredSize.Height - (flag4 ? 0.0 : tabTuck);
							num = (short)1692860419;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (flag)
							{
								num = (short)958857225;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_299;
						case 14:
							availableSize = A_0;
							num = (short)1702363149;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (flag3)
							{
								num = (short)2033057823;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)705888278;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							goto IL_679;
						case 17:
							goto IL_299;
						case 18:
							if (flag3)
							{
								num = (short)80281611;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 19:
							if (desiredSize.Height >= tabTuck || !flag3)
							{
								num = (short)1062928388;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 20:
							goto IL_603;
						case 21:
							result.Width += desiredSize.Width - (flag4 ? 0.0 : tabTuck);
							num = (short)1610219520;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							if (result.Height < desiredSize.Height)
							{
								num = (short)1118371846;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_565;
						case 23:
							goto IL_299;
						case 24:
							availableSize.Height = global::System.Math.Max(22.0, global::System.Math.Floor(availableSize.Height * A_1));
							num = (short)939982871;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							if (!enumerator.MoveNext())
							{
								num = (short)1311965212;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)696713221;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							result.Width = desiredSize.Width;
							num = (short)1015218177;
							if (num != 0)
							{
							}
							num = (short)81592322;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							result.Height += desiredSize.Height - (flag4 ? 0.0 : tabTuck);
							num = (short)2133262348;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							num = (short)2101149712;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							goto IL_565;
						case 30:
							if (desiredSize.Width < tabTuck)
							{
								num = (short)1502806024;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_346;
						case 31:
							num = (short)1444806666;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							switch (0)
							{
							case 0:
								goto IL_128;
							}
							continue;
						}
						goto IL_128;
						IL_299:
						uielement.Measure(availableSize);
						desiredSize = uielement.DesiredSize;
						desiredSize.Width = global::System.Math.Round(desiredSize.Width);
						desiredSize.Height = global::System.Math.Round(desiredSize.Height);
						num = (short)811991070;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_346:
						num = (short)1187577875;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_457:
						num = (short)447283227;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_565:
						num = (short)1978794005;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_603:
						flag4 = false;
						num = (short)822673415;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_620:
						num = (short)516161561;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_128:
						goto IL_620;
					}
					IL_679:
					goto IL_766;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_69B;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_688:
						switch (num3)
						{
						case 0:
						{
							num = (short)1016726492;
							short num4 = num;
							num = (short)96601052;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_6E0;
							default:
								goto IL_729;
							}
							break;
						}
						case 1:
							disposable.Dispose();
							goto IL_6E0;
						case 2:
							if (disposable != null)
							{
								num = (short)1300430849;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_740;
						}
						goto IL_69B;
						IL_6E0:
						num = (short)2101411840;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_729:
					num = (short)901644288;
					if (num != 0)
					{
					}
					IL_740:
					goto EndFinally_19;
					IL_69B:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1722155010;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_688;
					EndFinally_19:;
				}
				goto IL_741;
				IL_766:
				result.Width += this.f.Left + this.f.Right;
				result.Height += this.f.Top + this.f.Bottom;
				return result;
			}
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00058590 File Offset: 0x00056790
		private global::DevComponents.WpfEditors.SuperTabItem d()
		{
			short num = (short)775356416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::DevComponents.WpfEditors.SuperTabControl superTabControl;
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)575275011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (superTabControl != null)
						{
							num = (short)1084555264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8;
					case 2:
						goto IL_CD;
					case 3:
						if (superTabControl.SelectedIndex >= 0)
						{
							num = (short)2112946180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8;
					case 4:
					{
						num = (short)1221916194;
						short num3 = num;
						num = (short)1569125922;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A8;
						default:
							goto IL_144;
						}
						break;
					}
					}
					goto IL_42;
					IL_A8:
					enumerator = base.InternalChildren.GetEnumerator();
					num = (short)631635970;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CD:
				global::DevComponents.WpfEditors.SuperTabItem result;
				try
				{
					num = (short)227868677;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)697434115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)546701319;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::DevComponents.WpfEditors.SuperTabItem superTabItem;
							result = superTabItem;
							num = (short)1846542344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::DevComponents.WpfEditors.SuperTabItem superTabItem;
							if (superTabItem.IsSelected)
							{
								num = (short)466681858;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)100204545;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::DevComponents.WpfEditors.SuperTabItem superTabItem = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfEditors.SuperTabItem;
							num = (short)1516568582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_1E1;
							}
							continue;
						case 6:
						{
							global::DevComponents.WpfEditors.SuperTabItem superTabItem;
							if (superTabItem != null)
							{
								num = (short)701693952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							goto IL_2D8;
						case 8:
							goto IL_2BB;
						}
						IL_1E3:
						num = (short)349241348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E1:
						goto IL_1E3;
					}
					IL_2BB:
					return result;
					IL_2D8:
					goto IL_10E;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_2FA;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_2E7:
						switch (num2)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)1008467969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_352;
						case 1:
							disposable.Dispose();
							num = (short)1398800386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_350;
						}
						goto IL_2FA;
					}
					IL_350:
					IL_352:
					goto EndFinally_9;
					IL_2FA:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1223491584;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_2E7;
					EndFinally_9:;
				}
				return result;
				IL_10E:
				return null;
				IL_144:
				num = (short)1712324609;
				if (num != 0)
				{
				}
				num = (short)344195072;
				if (num != 0)
				{
				}
				return superTabControl.ItemContainerGenerator.ContainerFromIndex(superTabControl.SelectedIndex) as global::DevComponents.WpfEditors.SuperTabItem;
				IL_42:
				num = (short)1020788736;
				short num4 = num;
				superTabControl = (base.TemplatedParent as global::DevComponents.WpfEditors.SuperTabControl);
				num = (short)2049638401;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00058910 File Offset: 0x00056B10
		private global::System.Collections.IList c(global::System.Windows.Size A_0)
		{
			short num = (short)749207552;
			switch (num)
			{
			default:
			{
				num = (short)564396044;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					global::System.Windows.Size size;
					double num3;
					double num4;
					global::DevComponents.WpfEditors.SuperTabItem superTabItem2;
					bool flag2;
					double num5;
					global::System.Windows.Size size2;
					double tabTuck;
					double num6;
					bool flag3;
					global::System.Windows.Size size3;
					int num8;
					global::System.Windows.UIElement uielement;
					int index;
					global::System.Collections.Generic.List<global::System.Windows.UIElement> list;
					switch (num2)
					{
					case 0:
					{
						global::DevComponents.WpfEditors.SuperTabItem superTabItem;
						if (superTabItem != null)
						{
							num = (short)320798747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_77C;
					}
					case 1:
						if (flag)
						{
							num = (short)517406740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_172;
					case 2:
						size = default(global::System.Windows.Size);
						num = (short)1514209316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!flag)
						{
							num = (short)823918607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_570;
					case 4:
						num = (short)1891762177;
						if (num != 0)
						{
						}
						if (num3 > num4)
						{
							num = (short)983040041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_871;
					case 5:
						if (superTabItem2 == null)
						{
							num = (short)1093730306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)951975953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_386;
					case 7:
						flag2 = true;
						goto IL_444;
					case 8:
						if (num5 + size2.Height - tabTuck <= num6)
						{
							num = (short)1081933859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FD;
					case 9:
						goto IL_871;
					case 10:
						if (num3 + size2.Width - tabTuck > num4)
						{
							num = (short)1065353230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_570;
					case 11:
					{
						num = (short)1887050921;
						short num7 = num;
						num = (short)85925033;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27D;
						default:
							num = (short)2113011712;
							if (num != 0)
							{
							}
							num = (short)1065353219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						switch (0)
						{
						case 0:
							goto IL_103;
						}
						continue;
					case 13:
						num = (short)663355439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						flag3 = true;
						num = (short)1458044954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1144389642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_871;
					case 17:
						size3 = superTabItem2.DesiredSize;
						goto IL_2E5;
					case 18:
						goto IL_172;
					case 19:
						num = (short)173735944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)176881698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (num8 >= base.InternalChildren.Count)
						{
							num = (short)1303314461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement = base.InternalChildren[num8];
						num = (short)764608557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::DevComponents.WpfEditors.SuperTabItem superTabItem;
						if (superTabItem.IsSelected)
						{
							num = (short)831782923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_77C;
					}
					case 23:
						if (num5 > num6)
						{
							num = (short)1183121440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_871;
					case 24:
						goto IL_309;
					case 25:
						index = num8;
						num = (short)234291224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_172;
					case 27:
						num = (short)1016463382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (this.TabStripPlacement != global::System.Windows.Controls.Dock.Left)
						{
							num = (short)1379729421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2118713351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						return list;
					case 30:
						if (num3 + size2.Width - tabTuck <= num4)
						{
							num = (short)1398472729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_309;
					case 31:
						if (flag)
						{
							num = (short)1271070739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)150143006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						flag3 = true;
						num = (short)1552351241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (!flag3)
						{
							num = (short)1084227623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list.Insert(index, uielement);
						num = (short)807338022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (num5 + size2.Height - tabTuck > num6)
						{
							num = (short)1010827310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_172;
					case 35:
						index = num8;
						num = (short)23265320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						size3 = size;
						goto IL_2E5;
					case 37:
						goto IL_23D;
					case 38:
						goto IL_23D;
					case 39:
						goto IL_1AA;
					case 40:
						goto IL_4FD;
					case 41:
						flag3 = true;
						goto IL_27D;
					case 42:
					{
						global::DevComponents.WpfEditors.SuperTabItem superTabItem = uielement as global::DevComponents.WpfEditors.SuperTabItem;
						num = (short)1082261504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_386;
					case 44:
						goto IL_126;
					case 45:
						if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							num = (short)1954283562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_871;
					case 46:
					{
						num = (short)1868496896;
						short num9 = num;
						flag3 = true;
						num = (short)1182728210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						flag2 = (this.TabStripPlacement == global::System.Windows.Controls.Dock.Right);
						goto IL_444;
					}
					IL_103:
					if (!this.IsOversized)
					{
						num = (short)25690156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					list = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(base.InternalChildren.Count);
					num3 = 0.0;
					num5 = 0.0;
					num6 = A_0.Height - (this.f.Top + this.f.Bottom);
					num4 = A_0.Width - (this.f.Left + this.f.Right);
					num = (short)1251278876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_172:
					num = (short)1791557665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23D:
					num = (short)1425145887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27D:
					num = (short)1727397904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E5:
					size2 = size3;
					num8 = 0;
					num = (short)1177485355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_309:
					double num10 = num3;
					size = uielement.DesiredSize;
					num3 = num10 + (size.Width - this.TabTuck);
					num = (short)2034892804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_386:
					num = (short)38797333;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_444:
					flag = flag2;
					flag3 = false;
					tabTuck = this.TabTuck;
					superTabItem2 = this.d();
					index = 0;
					num = (short)1331363845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FD:
					double num11 = num5;
					size = uielement.DesiredSize;
					num5 = num11 + (size.Height - tabTuck);
					num = (short)361496599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_570:
					num = (short)49545217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_77C:
					list.Add(uielement);
					num = (short)237961253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_871:
					num8++;
					num = (short)1377566726;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_126:
				return base.InternalChildren;
				IL_1AA:
				return base.InternalChildren;
			}
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000591B4 File Offset: 0x000573B4
		protected virtual global::System.Windows.Size ArrangeSingleLine(global::System.Windows.Size finalSize)
		{
			short num = (short)83820544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				double num4;
				double num6;
				double num7;
				for (;;)
				{
					IL_27:
					double num3;
					global::System.Collections.IList list;
					int num5;
					bool flag;
					global::System.Windows.Controls.Dock dock;
					int num8;
					double tabTuck;
					global::System.Collections.IEnumerator enumerator;
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_1AB;
					case 1:
						num3 -= (double)this.b;
						num4 += (double)this.b;
						num = (short)2119499792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)987299841;
						if (num != 0)
						{
						}
						num5 = list.Count + 1;
						goto IL_336;
					case 3:
						if (!flag)
						{
							num = (short)1291124740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1833631755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)878510082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (dock == global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1413087250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2018508808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (dock == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)623575041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					case 7:
						goto IL_13D;
					case 8:
						if (dock == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)674824202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2041511956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (dock != global::System.Windows.Controls.Dock.Left)
						{
							num = (short)773193751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82C;
					case 10:
						num6 -= (double)this.b;
						num7 += (double)this.b;
						num = (short)895483917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num5 = 1;
						goto IL_336;
					case 12:
						if (num6 - global::System.Math.Round(num6) == 0.0)
						{
							num = (short)394919951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13D;
					case 13:
						goto IL_1AB;
					case 14:
						try
						{
							num = (short)1041104906;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.UIElement uielement;
								global::System.Windows.Size desiredSize;
								switch (num2)
								{
								case 0:
									num7 += num6;
									num = (short)471400453;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)2133590035;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									goto IL_538;
								case 3:
									goto IL_761;
								case 5:
									goto IL_640;
								case 6:
									num = (short)207814659;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Windows.Controls.TabItem tabItem;
									if (!tabItem.IsSelected)
									{
										num = (short)1020788756;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::System.Windows.Controls.TabItem tabItem;
									if (tabItem != null)
									{
										num = (short)1415577618;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_44C;
								}
								case 9:
									num4 += num3;
									num = (short)537591819;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_447;
									}
									continue;
								case 11:
									goto IL_497;
								case 12:
									goto IL_538;
								case 13:
									num8 += (flag ? 1 : -1);
									num = (short)1887895556;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (flag)
									{
										num = (short)9043983;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2113863697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									num = (short)800325648;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									if (num7 + (desiredSize.Height - tabTuck) > num6)
									{
										num = (short)1649934336;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_640;
								case 17:
									if (num4 + (desiredSize.Width - tabTuck) > num3)
									{
										num = (short)1549795337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_497;
								case 18:
									num = (short)883490823;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
								{
									desiredSize = uielement.DesiredSize;
									global::System.Windows.Controls.TabItem tabItem = uielement as global::System.Windows.Controls.TabItem;
									num = (short)1846935566;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
									goto IL_44C;
								case 21:
									if (!enumerator.MoveNext())
									{
										num = (short)980549638;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1773273089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_447;
								IL_44C:
								global::System.Windows.Controls.Panel.SetZIndex(uielement, num8);
								num = (short)1444544525;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_497:
								uielement.Arrange(new global::System.Windows.Rect(num4, num7, desiredSize.Width, num6));
								num4 += desiredSize.Width - tabTuck;
								num = (short)421265410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4D8:
								num = (short)1756364821;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_447:
								goto IL_4D8;
								IL_538:
								num = (short)913702920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_640:
								uielement.Arrange(new global::System.Windows.Rect(num4, num7, num3, desiredSize.Height));
								num7 += desiredSize.Height - tabTuck;
								num = (short)1035796492;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_761:
							return finalSize;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_783;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_770:
								switch (num2)
								{
								case 0:
								{
									num = (short)247242674;
									short num9 = num;
									num = (short)689086386;
									switch ((num9 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										goto IL_812;
									}
									break;
								}
								case 1:
									disposable.Dispose();
									num = (short)357564416;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)922353665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_82B;
								}
								goto IL_783;
							}
							IL_812:
							num = (short)559808512;
							if (num != 0)
							{
							}
							IL_82B:
							goto EndFinally_19;
							IL_783:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)693501954;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_770;
							EndFinally_19:;
						}
						goto IL_82C;
					case 15:
						num6 += 0.5;
						num = (short)1756299271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_1AB;
					case 17:
						num3 -= (double)(this.b - 1);
						num = (short)1249181715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num6 -= (double)this.b;
						num = (short)1279197184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_1AB;
					case 20:
						if (dock == global::System.Windows.Controls.Dock.Left)
						{
							num = (short)1705050129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)859308038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						flag2 = true;
						goto IL_2DA;
					case 22:
						flag2 = (dock == global::System.Windows.Controls.Dock.Right);
						goto IL_2DA;
					case 23:
						num = (short)726597654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8E;
					IL_13D:
					num3 = finalSize.Width - (this.f.Left + this.f.Right);
					list = this.c(finalSize);
					dock = this.TabStripPlacement;
					num = (short)299106313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB:
					tabTuck = this.TabTuck;
					num = (short)951386115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DA:
					flag = flag2;
					num = (short)1956511749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_336:
					num8 = num5;
					enumerator = list.GetEnumerator();
					num = (short)174587918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_82C:
					num = (short)338493440;
					short num10 = num;
					num = (short)636485653;
					num2 = (int)((global::System.IntPtr)num);
				}
				return finalSize;
				IL_8E:
				num4 = this.f.Left;
				num7 = this.f.Top;
				num6 = finalSize.Height - (this.f.Top + this.f.Bottom);
				num = (short)696451084;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00059AC8 File Offset: 0x00057CC8
		protected virtual global::System.Windows.Size MeasureMultiLine(global::System.Windows.Size constraint)
		{
			short num = (short)1397620736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1511981057;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_A4;
				}
				global::System.Windows.Controls.Dock dock;
				global::System.Windows.Size result;
				double num3;
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					IL_51:
					double num4;
					int num7;
					switch (num2)
					{
					case 0:
						num = (short)1440088072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_6CA;
					case 2:
						if (dock != global::System.Windows.Controls.Dock.Left)
						{
							num = (short)836435983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E8;
					case 3:
						num = (short)1403715586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_6C5;
					case 5:
						if (!double.IsNaN(result.Width))
						{
							num = (short)1307312128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FE;
					case 6:
						num3 = num4;
						num = (short)622723073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (dock != global::System.Windows.Controls.Dock.Top)
						{
							num = (short)401866762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_609;
					case 8:
						if (num3 < constraint.Width)
						{
							num = (short)2042167300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_994;
					case 9:
						goto IL_4E8;
					case 10:
						num = (short)1872560139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (dock != global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)1350107139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_609;
					case 12:
						if (!double.IsInfinity(result.Width))
						{
							num = (short)597622800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FE;
					case 13:
						if (dock == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)1460207625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 14:
						if (num3 < num4)
						{
							num = (short)1430978566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CA;
					case 15:
					{
						num = (short)279511040;
						short num5 = num;
						num = (short)1464008717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)1696006149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						try
						{
							num = (short)964165638;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Size size;
								switch (num2)
								{
								case 0:
									goto IL_46D;
								case 1:
								{
									num = (short)998770275;
									short num6 = num;
									num = (short)1840318051;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_42F;
									default:
										num = (short)1412759552;
										if (num != 0)
										{
										}
										goto IL_1FF;
									}
									break;
								}
								case 3:
									num = (short)974323712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)97845259;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (this.i < size.Height)
									{
										num = (short)1034944519;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1FF;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_19C;
									}
									continue;
								case 7:
									this.i = size.Height;
									num = (short)1427374081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									this.g++;
									global::System.Windows.UIElement uielement;
									uielement.Measure(constraint);
									size = this.a(uielement);
									num = (short)1170669573;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1193410563;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1741291536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									if (num7 > 0)
									{
										num = (short)163250191;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A1;
								case 12:
									goto IL_1C9;
								case 13:
									num3 = num4;
									num = (short)434831372;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (num3 < num4)
									{
										num = (short)1572274189;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1C9;
								case 15:
									goto IL_42F;
								case 16:
								{
									global::System.Windows.UIElement uielement;
									if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)401276936;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 17:
									if (num4 + size.Width > constraint.Width)
									{
										num = (short)194379780;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A1;
								}
								goto IL_19C;
								IL_1A1:
								num4 += size.Width;
								num7++;
								num = (short)1553661961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C9:
								num4 = size.Width;
								num7 = 1;
								this.h++;
								num = (short)321519618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FF:
								num = (short)1457258513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3B8:
								num = (short)1333592074;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19C:
								goto IL_3B8;
								IL_42F:
								num = (short)255328270;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46D:
							goto IL_5BF;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_48F;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_47C:
								switch (num2)
								{
								case 0:
									goto IL_4E5;
								case 1:
									disposable.Dispose();
									num = (short)1170145280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)228524033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4E7;
								}
								goto IL_48F;
							}
							IL_4E5:
							IL_4E7:
							goto EndFinally_25;
							IL_48F:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1699086338;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_47C;
							EndFinally_25:;
						}
						goto IL_4E8;
						IL_5BF:
						num = (short)1241448462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_50D;
					}
					goto IL_A4;
					IL_4E8:
					enumerator = base.InternalChildren.GetEnumerator();
					num = (short)1136853010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_609:
					num7 = 0;
					num4 = 0.0;
					num3 = 0.0;
					enumerator = base.InternalChildren.GetEnumerator();
					num = (short)2117992465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CA:
					result.Height = this.i * (double)this.h;
					num = (short)999555084;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_50D:
				try
				{
					num = (short)1931739137;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Windows.Size size2;
						switch (num2)
						{
						case 0:
							goto IL_91B;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_7B0;
							}
							continue;
						case 2:
							num = (short)794492928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							result.Width = size2.Width;
							num = (short)611057669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.Windows.UIElement uielement2;
							if (uielement2.Visibility != global::System.Windows.Visibility.Collapsed)
							{
								num = (short)172097544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_818;
						case 7:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)79822850;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement2 = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)1439891460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							this.g++;
							global::System.Windows.UIElement uielement2;
							uielement2.Measure(constraint);
							size2 = this.a(uielement2);
							num = (short)1436024841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							if (result.Width < size2.Width)
							{
								num = (short)3211267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_818;
						}
						goto IL_7B0;
						IL_818:
						result.Height += size2.Height;
						num = (short)753467398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8C3:
						num = (short)2062286855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7B0:
						goto IL_8C3;
					}
					IL_91B:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_93A;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_927:
						switch (num2)
						{
						case 0:
							goto IL_98F;
						case 1:
							disposable.Dispose();
							num = (short)1949302784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (disposable != null)
							{
								num = (short)144834561;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_991;
						}
						goto IL_93A;
					}
					IL_98F:
					IL_991:
					goto EndFinally_24;
					IL_93A:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1313603586;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_927;
					EndFinally_24:;
				}
				return result;
				IL_5FE:
				result.Width = num3;
				return result;
				IL_6C5:
				goto IL_5FE;
				IL_994:
				result.Width = constraint.Width;
				return result;
				IL_A4:
				result = default(global::System.Windows.Size);
				dock = this.TabStripPlacement;
				this.h = 1;
				this.g = 0;
				this.i = 0.0;
				num = (short)53870599;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0005A4AC File Offset: 0x000586AC
		private global::System.Windows.Size a(global::System.Windows.UIElement A_0)
		{
			short num = (short)1419575297;
			if (num != 0)
			{
			}
			num = (short)52849024;
			short num2 = num;
			num = (short)2024630656;
			switch (num2 == num)
			{
			}
			num = (short)8388608;
			if (num != 0)
			{
			}
			num = (short)755892224;
			short num3 = num;
			global::System.Windows.Thickness thickness = (global::System.Windows.Thickness)A_0.GetValue(global::System.Windows.FrameworkElement.MarginProperty);
			return new global::System.Windows.Size
			{
				Height = global::System.Math.Max(0.0, A_0.DesiredSize.Height - thickness.Top - thickness.Bottom),
				Width = global::System.Math.Max(0.0, A_0.DesiredSize.Width - thickness.Left - thickness.Right)
			};
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0005A5D8 File Offset: 0x000587D8
		private global::System.Windows.Controls.Dock TabStripPlacement
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.Windows.Controls.TabControl tabControl;
				global::System.Windows.Controls.Dock result;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)902032615;
						short num3 = num2;
						num2 = (short)1888349415;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_62;
						default:
							goto IL_AC;
						}
						break;
					}
					case 1:
						if (tabControl != null)
						{
							num2 = (short)1521221634;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
						result = tabControl.TabStripPlacement;
						goto IL_62;
					}
					goto IL_1C;
					IL_62:
					num2 = (short)1743388672;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_AC:
				num2 = (short)1877475328;
				if (num2 != 0)
				{
				}
				num2 = (short)464322560;
				short num4 = num2;
				num2 = (short)142147585;
				if (num2 != 0)
				{
				}
				return result;
				IL_1C:
				result = global::System.Windows.Controls.Dock.Top;
				tabControl = (base.TemplatedParent as global::System.Windows.Controls.TabControl);
				num2 = (short)1105920001;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0005A6FC File Offset: 0x000588FC
		protected virtual global::System.Windows.Size ArrangeMultiLine(global::System.Windows.Size arrangeSize)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1990328321;
					if (num2 != 0)
					{
					}
					num2 = (short)300941313;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_11F;
				case 2:
				{
					global::System.Windows.Controls.Dock dock;
					switch (dock)
					{
					case global::System.Windows.Controls.Dock.Left:
					case global::System.Windows.Controls.Dock.Right:
						goto IL_B6;
					case global::System.Windows.Controls.Dock.Top:
					case global::System.Windows.Controls.Dock.Bottom:
						goto IL_D8;
					default:
						num2 = (short)688128000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_D6;
				}
				goto IL_20;
			}
			IL_B6:
			this.a(arrangeSize);
			goto IL_BD;
			IL_D6:
			return arrangeSize;
			IL_D8:
			this.b(arrangeSize);
			return arrangeSize;
			IL_11F:
			num2 = (short)100990976;
			short num3 = num2;
			return arrangeSize;
			IL_20:
			num2 = (short)53124116;
			short num4 = num2;
			num2 = (short)1725209620;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BD:
				num2 = (short)1514930179;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)207749120;
				if (num2 != 0)
				{
				}
				global::System.Windows.Controls.Dock dock = this.TabStripPlacement;
				num2 = (short)909901826;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0005A858 File Offset: 0x00058A58
		private double[] b()
		{
			short num = (short)93650944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)221642752;
				short num3 = num;
				num = (short)293535745;
				if (num != 0)
				{
				}
				double[] array = new double[this.g];
				int num4 = 0;
				global::System.Collections.IEnumerator enumerator = base.InternalChildren.GetEnumerator();
				try
				{
					num = (short)424869892;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)198967299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::System.Windows.UIElement uielement;
							array[num4] = this.a(uielement).Width;
							num4++;
							num = (short)88276993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_190;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_CC;
							}
							continue;
						case 5:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
							{
								num = (short)1457782786;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)803995648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)976683013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_10F:
						num = (short)278265862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_CC:
						goto IL_10F;
					}
					IL_190:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1B2;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_19F:
						switch (num2)
						{
						case 0:
						{
							num = (short)2044401130;
							short num5 = num;
							num = (short)1179194858;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1F6;
							default:
								goto IL_241;
							}
							break;
						}
						case 1:
							if (disposable != null)
							{
								num = (short)2104754178;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_258;
						case 2:
							disposable.Dispose();
							goto IL_1F6;
						}
						goto IL_1B2;
						IL_1F6:
						num = (short)1538392064;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_241:
					num = (short)1765343232;
					if (num != 0)
					{
					}
					IL_258:
					goto EndFinally_6;
					IL_1B2:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1679949825;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_19F;
					EndFinally_6:;
				}
				return array;
			}
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0005AADC File Offset: 0x00058CDC
		private void b(global::System.Windows.Size A_0)
		{
			short num = (short)252248064;
			short num2 = num;
			num = (short)1165885440;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B6;
				}
				bool flag;
				global::System.Windows.Controls.Dock dock;
				int num5;
				int[] array;
				global::System.Windows.Vector vector;
				double[] array2;
				double tabTuck;
				for (;;)
				{
					IL_4F:
					num = (short)1432158209;
					if (num != 0)
					{
					}
					int num4;
					int num6;
					global::System.Collections.IEnumerator enumerator;
					int num7;
					switch (num3)
					{
					case 0:
						try
						{
							num = (short)835256321;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.UIElement uielement;
								object obj;
								double left;
								double right;
								double top;
								double bottom;
								switch (num3)
								{
								case 0:
									num = (short)1568473090;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_277;
									}
									continue;
								case 2:
									if (!((global::System.Windows.Controls.TabItem)uielement).IsSelected)
									{
										num = (short)661585949;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_7A7;
								case 4:
									if (flag)
									{
										num = (short)1109458966;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)832700439;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (dock == global::System.Windows.Controls.Dock.Bottom)
									{
										num = (short)736362523;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27C;
								case 6:
									obj = 1;
									goto IL_4C0;
								case 7:
									if (dock != global::System.Windows.Controls.Dock.Top)
									{
										num = (short)1593966609;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_57C;
								case 8:
								{
									global::System.Windows.Thickness thickness = (global::System.Windows.Thickness)uielement.GetValue(global::System.Windows.FrameworkElement.MarginProperty);
									left = thickness.Left;
									right = thickness.Right;
									top = thickness.Top;
									bottom = thickness.Bottom;
									num = (short)819658756;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)2024407048;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
									if (num4 == num5 - 1)
									{
										num = (short)40960011;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27C;
								case 11:
									num = (short)1353711621;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (array[num4] != num6)
									{
										num = (short)1525678093;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1760821254;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_3F1;
								case 14:
									num = (short)330629141;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									goto IL_534;
								case 16:
									if (!enumerator.MoveNext())
									{
										num = (short)480706584;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1199243273;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									goto IL_4DA;
								case 18:
									if (num4 < array.Length)
									{
										num = (short)685375516;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F1;
								case 19:
									goto IL_41A;
								case 20:
									obj = (num6 == this.g - 1);
									goto IL_4C0;
								case 21:
									if (num4 == num5)
									{
										num = (short)920715290;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4DA;
								case 22:
									num = (short)1731067922;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									obj = 0;
									goto IL_4C0;
								case 24:
									num = (short)1212022787;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									goto IL_41A;
								case 26:
									num = (short)849346567;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									goto IL_57C;
								case 28:
									num = (short)2001076236;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									goto IL_3A6;
								case 31:
									if (uielement is global::System.Windows.Controls.TabItem)
									{
										num = (short)1499856896;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3A6;
								}
								goto IL_277;
								IL_27C:
								vector.Y += this.i;
								num = (short)1301086227;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_3A6:
								global::System.Windows.Controls.Panel.SetZIndex(uielement, num7);
								num7--;
								num = (short)1328218142;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_3F1:
								num = (short)1916534804;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_41A:
								vector.X = 0.0;
								num4++;
								num = (short)869269519;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_4DA:
								num = (short)1947205642;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_534:
								num6++;
								num = (short)714604575;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_4C0:
								global::System.Windows.Size size = new global::System.Windows.Size(array2[num6], this.i);
								object obj2 = obj;
								if (obj2 != null)
								{
									size.Width = A_0.Width - vector.X;
								}
								uielement.Arrange(new global::System.Windows.Rect(vector.X, vector.Y, size.Width, size.Height));
								global::System.Windows.Size size2 = size;
								size2.Height = global::System.Math.Max(0.0, size2.Height - top - bottom);
								size2.Width = global::System.Math.Max(0.0, size2.Width - left - right);
								vector.X += size.Width - tabTuck;
								if (obj2 != null)
								{
									num = (short)1101070350;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_534;
								IL_57C:
								vector.Y = 0.0;
								num = (short)982646809;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_5E5:
								num = (short)1731330064;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_277:
								goto IL_5E5;
							}
							IL_7A7:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_7C9;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_7B6:
								switch (num3)
								{
								case 0:
								{
									num = (short)1094300938;
									short num8 = num;
									num = (short)1720825098;
									switch ((num8 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_80C;
									default:
										goto IL_857;
									}
									break;
								}
								case 1:
									if (disposable != null)
									{
										num = (short)169803778;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_86E;
								case 2:
									disposable.Dispose();
									goto IL_80C;
								}
								goto IL_7C9;
								IL_80C:
								num = (short)1587019776;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_857:
							num = (short)374079488;
							if (num != 0)
							{
							}
							IL_86E:
							goto EndFinally_22;
							IL_7C9:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1016397825;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_7B6;
							EndFinally_22:;
						}
						goto IL_86F;
					case 1:
						goto IL_121;
					case 2:
						if (dock == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)1445986308;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 3:
						vector.Y += (double)this.b;
						num = (short)912392193;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)475594762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (flag)
						{
							num = (short)1946288139;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 6:
						if (dock == global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1196883981;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_931;
					case 7:
						goto IL_931;
					case 8:
						vector.Y = (double)(this.h - num5) * this.i;
						num = (short)842137609;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_15E;
					case 10:
						if (num5 != 0)
						{
							num = (short)1770192904;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 11:
						goto IL_86F;
					case 12:
						if (dock == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)1990590467;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121;
					case 13:
						vector.Y = (double)(this.h - 1 - num5) * this.i;
						num = (short)157286407;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B6;
					IL_121:
					num6 = 0;
					num4 = 0;
					num7 = base.InternalChildren.Count + 1;
					enumerator = base.InternalChildren.GetEnumerator();
					num = (short)299237376;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E:
					num = (short)353763340;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_86F:
					array = this.a(A_0.Width, array2);
					num5 = this.a(array);
					num = (short)187629574;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_931:
					num = (short)501874690;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_B6:
				dock = this.TabStripPlacement;
				flag = (this.h > 1);
				num5 = 0;
				array = new int[0];
				vector = default(global::System.Windows.Vector);
				array2 = this.b();
				tabTuck = this.TabTuck;
				num = (short)856358917;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0005B4A8 File Offset: 0x000596A8
		private void a(global::System.Windows.Size A_0)
		{
			short num = (short)1110048768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				double num3;
				double num6;
				for (;;)
				{
					IL_27:
					global::System.Collections.IEnumerator enumerator;
					int num7;
					switch (num2)
					{
					case 0:
					{
						num = (short)727515137;
						if (num != 0)
						{
						}
						num3 += (double)this.b;
						num = (short)1027684216;
						short num4 = num;
						num = (short)375601016;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1585577984;
							if (num != 0)
							{
							}
							num = (short)2008154113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_2E5;
					case 2:
					{
						int num5 = (int)this.TabStripPlacement;
						double tabTuck = this.TabTuck;
						if (num5 == 2)
						{
							num = (short)2041511936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E5;
					}
					case 3:
						try
						{
							num = (short)119668738;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.UIElement uielement;
								switch (num2)
								{
								case 0:
									num = (short)1697972234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (uielement is global::System.Windows.Controls.TabItem)
									{
										num = (short)1154351104;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_133;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E9;
									}
									continue;
								case 3:
									goto IL_133;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)1307508742;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1007747080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)92340231;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_26B;
								case 8:
									if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)1366097929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
								{
									global::System.Windows.Size size = this.a(uielement);
									uielement.Arrange(new global::System.Windows.Rect(num3, num6, A_0.Width, size.Height));
									double tabTuck;
									num6 += size.Height - tabTuck;
									num = (short)1070727169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (!((global::System.Windows.Controls.TabItem)uielement).IsSelected)
									{
										num = (short)1033961475;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								goto IL_E9;
								IL_133:
								global::System.Windows.Controls.Panel.SetZIndex(uielement, num7);
								num7--;
								num = (short)38862852;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_159:
								num = (short)2063859717;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E9:
								goto IL_159;
							}
							IL_26B:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_28D;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_27A:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)445513730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2E4;
								case 1:
									goto IL_2E2;
								case 2:
									disposable.Dispose();
									num = (short)1305280513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_28D;
							}
							IL_2E2:
							IL_2E4:
							goto EndFinally_9;
							IL_28D:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1318060032;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_27A;
							EndFinally_9:;
						}
						goto IL_2E5;
					}
					goto IL_3E;
					IL_2E5:
					num7 = base.InternalChildren.Count + 1;
					enumerator = base.InternalChildren.GetEnumerator();
					num = (short)1527578624;
					short num8 = num;
					num = (short)979238915;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3E:
				num6 = 0.0;
				num3 = 0.0;
				num = (short)125960194;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0005B8B0 File Offset: 0x00059AB0
		private int[] a(double A_0, double[] A_1)
		{
			short num = (short)1918107648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FB;
				}
				double num3;
				double num4;
				double num5;
				int num6;
				int num8;
				double[] array;
				int num9;
				int[] array2;
				int num11;
				int num12;
				double[] array3;
				int[] array4;
				double[] array5;
				int[] array6;
				for (;;)
				{
					IL_28:
					int num7;
					double num13;
					int num15;
					int num16;
					int num21;
					switch (num2)
					{
					case 0:
						if (num3 < num4)
						{
							num = (short)1680080902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44B;
					case 1:
						if (num5 + A_1[num6] > A_0)
						{
							num = (short)1416888370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DE;
					case 2:
						goto IL_5B6;
					case 3:
						goto IL_410;
					case 4:
						if (A_1[num6] != 0.0)
						{
							num = (short)237305876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BB;
					case 5:
						goto IL_44B;
					case 6:
						num3 = num4;
						num = (short)2058158085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (num7 >= num8)
						{
							num = (short)1498415117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_1[num7] += array[num9];
						num = (short)2035744782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (array2[num9] == num7)
						{
							num = (short)1985740846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_947;
					case 9:
					{
						num = (short)883621888;
						short num10 = num;
						goto IL_947;
					}
					case 10:
						goto IL_385;
					case 11:
						goto IL_1B6;
					case 12:
						goto IL_900;
					case 13:
						return array2;
					case 14:
						if (num9 < num11)
						{
							num = (short)798621734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_947;
					case 15:
						goto IL_777;
					case 16:
						if (num3 < num4)
						{
							num = (short)898629674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28B;
					case 17:
						if (num12 > 0)
						{
							num = (short)1097990187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DE;
					case 18:
						num = (short)911212563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (num13 < num3)
						{
							num = (short)195821612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B6;
					case 20:
					{
						num12++;
						num = (short)1067433017;
						short num14 = num;
						num = (short)1557969977;
						switch ((num14 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3BD;
						default:
							num = (short)355794944;
							if (num != 0)
							{
							}
							num = (short)627507230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
						if (num6 >= num8)
						{
							num = (short)1625227297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1710686209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_28B;
					case 23:
						num13 = array3[num15];
						num16 = num15;
						num = (short)1572891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_410;
					case 25:
					{
						int num17 = num16;
						int num18 = num17 - 1;
						int num19 = array4[num18];
						double num20 = A_1[num19];
						array5[num17] += num20;
						num = (short)264634413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (num21 >= this.h)
						{
							num = (short)1397948434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1536753699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_924;
					case 28:
						num = (short)1929183233;
						if (num != 0)
						{
						}
						if (num13 < array3[num15])
						{
							num = (short)446038039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_924;
					case 29:
						goto IL_573;
					case 30:
						goto IL_4BB;
					case 31:
						num13 = array3[num21];
						num = (short)286261260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_1B6;
					case 33:
						goto IL_3BD;
					case 34:
						if (num15 >= this.h)
						{
							num = (short)2062155823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)206962716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (num13 < array3[num21])
						{
							num = (short)179765279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_900;
					case 36:
					{
						int num18;
						array4[num18]--;
						int num17;
						array6[num17]++;
						double num20;
						array5[num18] -= num20;
						array6[num18]--;
						array3[num18] = (A_0 - array5[num18]) / (double)array6[num18];
						array3[num17] = (A_0 - array5[num17]) / (double)array6[num17];
						num13 = 0.0;
						num21 = 0;
						num = (short)353894448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						if (num9 == 0)
						{
							num = (short)27656207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array5[num9] = num5;
						array6[num9] = num12;
						num4 = (A_0 - num5) / (double)num12;
						array3[num9] = num4;
						num = (short)2144665600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)646578184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (num16 != 0)
						{
							num = (short)1302396953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_268;
					case 40:
						goto IL_385;
					case 41:
						goto IL_4BB;
					case 42:
						num3 = num4;
						num = (short)1629093910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						array5[num9] = num5;
						array6[num9] = num12;
						num4 = global::System.Math.Max(0.0, (A_0 - num5) / (double)num12);
						array3[num9] = num4;
						array4[num9] = num6 - 1;
						num = (short)1718222864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num3 = num13;
						array4.CopyTo(array2, 0);
						array3.CopyTo(array, 0);
						num = (short)952172593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						int num17;
						if (array5[num17] <= A_0)
						{
							num = (short)893386788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_268;
					}
					case 46:
						num9++;
						num = (short)35717129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)633602087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						goto IL_573;
					case 49:
						goto IL_5B6;
					case 50:
						num = (short)951582737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FB;
					IL_1B6:
					num = (short)52822050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_268:
					num9 = 0;
					num7 = 0;
					num = (short)1399586840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28B:
					num9++;
					num5 = A_1[num6];
					num12 = 1;
					num = (short)1749811241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_385:
					num = (short)315293717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BD:
					num = (short)1254948901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_410:
					num = (short)266600455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44B:
					array4.CopyTo(array2, 0);
					array3.CopyTo(array, 0);
					num = (short)1973878786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BB:
					num6++;
					num = (short)686358538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DE:
					num5 += A_1[num6];
					num = (short)442499076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_573:
					num = (short)1324810266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B6:
					num16 = 0;
					num13 = 0.0;
					num15 = 0;
					num = (short)77856800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_900:
					num21++;
					num = (short)1212284957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_924:
					num15++;
					num = (short)1311637515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_947:
					num7++;
					num = (short)1005322243;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array2;
				IL_777:
				return new int[0];
				IL_FB:
				num3 = 0.0;
				num8 = A_1.Length;
				num11 = this.h - 1;
				num5 = 0.0;
				num12 = 0;
				num4 = 0.0;
				array4 = new int[num11];
				array2 = new int[num11];
				array6 = new int[this.h];
				array5 = new double[this.h];
				array3 = new double[this.h];
				array = new double[this.h];
				num9 = 0;
				num6 = 0;
				num = (short)1829044264;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0005C290 File Offset: 0x0005A490
		private int a(int[] A_0)
		{
			short num = (short)851836928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				int num3;
				int num5;
				int result;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (this.TabStripPlacement == global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1731788803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					case 1:
					{
						num = (short)1390936064;
						short num4 = num;
						global::System.Collections.IEnumerator enumerator = base.InternalChildren.GetEnumerator();
						num = (short)1251934212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (A_0.Length != 0)
						{
							num = (short)1625686017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_393;
					case 3:
						num3 = this.h - 1;
						num = (short)557121541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						try
						{
							num = (short)1143996427;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (num3 < A_0.Length)
									{
										num = (short)1589313545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_214;
								case 1:
									num = (short)427884548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)628097025;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1469972486;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_31B;
								case 5:
									num = (short)206372878;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Windows.UIElement uielement;
									if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)2038824965;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									if (A_0[num3] == num5)
									{
										num = (short)838467592;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_214;
								case 8:
									num3++;
									num = (short)1077936140;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)437649415;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									result = num3;
									num = (short)1113718797;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_154;
									}
									continue;
								case 12:
									goto IL_214;
								case 13:
									goto IL_270;
								case 14:
								{
									global::System.Windows.UIElement uielement;
									if ((bool)uielement.GetValue(global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty))
									{
										num = (short)2015100938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)659816448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_156:
								num = (short)675414019;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_154:
								goto IL_156;
								IL_214:
								num5++;
								num = (short)775487490;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_270:
							goto IL_3D7;
							IL_31B:;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_33A;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_327:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1614020610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_392;
								case 1:
									goto IL_390;
								case 2:
									disposable.Dispose();
									num = (short)1465581569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_33A;
							}
							IL_390:
							IL_392:
							goto EndFinally_11;
							IL_33A:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1036976128;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_327;
							EndFinally_11:;
						}
						goto IL_393;
						IL_3D7:
						num = (short)1367146497;
						if (num != 0)
						{
						}
						num = (short)2078342216;
						short num6 = num;
						num = (short)546176072;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_393;
						default:
							goto IL_432;
						}
						break;
					}
					case 5:
						return num3;
					}
					goto IL_48;
					IL_393:
					num = (short)1300692992;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num3;
				IL_432:
				num = (short)742719488;
				if (num != 0)
				{
				}
				return result;
				IL_48:
				num3 = 0;
				num5 = 0;
				num = (short)1155399682;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0005C704 File Offset: 0x0005A904
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			short num = (short)1661009920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_11B;
				}
				for (;;)
				{
					IL_28:
					global::System.Windows.Point[] array;
					switch (num2)
					{
					case 0:
						goto IL_61F;
					case 1:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)2113994763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1060896816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_4D8;
					case 3:
						goto IL_76E;
					case 4:
					{
						int num3;
						if (num3 >= array.Length)
						{
							goto IL_A6B;
						}
						double num4;
						global::System.Windows.Point[] array2;
						array[num3] = new global::System.Windows.Point(num4, array2[num3].Y);
						num3++;
						num = (short)1093337101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Windows.Point[] array3 = array;
						int num5 = 0;
						double num6 = array3[num5].Y;
						array3[num5].Y = num6 + 1.0;
						num = (short)1766457345;
						if (num != 0)
						{
						}
						num = (short)1106837533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)383582258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					}
					case 7:
						goto IL_3A2;
					case 8:
					{
						int num7;
						if (num7 >= array.Length)
						{
							num = (short)1707540518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						double num4;
						global::System.Windows.Point[] array2;
						array[num7] = new global::System.Windows.Point(num4, array2[num7].Y);
						num7++;
						num = (short)1259208713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_D78;
					case 10:
						goto IL_511;
					case 11:
					{
						global::System.Windows.Rect rect;
						double num8 = rect.Y + 1.5;
						global::System.Windows.Point[] array2;
						array2[0] = new global::System.Windows.Point(0.0, num8);
						global::System.Windows.Rect rect2;
						array2[1] = new global::System.Windows.Point(rect2.X, num8);
						array2[2] = new global::System.Windows.Point(rect2.Right, num8);
						array2[3] = new global::System.Windows.Point(rect.Right, num8);
						num8 -= 1.0;
						int num9 = 0;
						num = (short)1923940355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_1F4;
					case 13:
						goto IL_A47;
					case 14:
					{
						int num10;
						if (num10 >= array.Length)
						{
							num = (short)1397030955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Point[] array2;
						double num8;
						array[num10] = new global::System.Windows.Point(array2[num10].X, num8);
						num10++;
						num = (short)1766129664;
						short num11 = num;
						num = (short)258605073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						if (this.b == 0)
						{
							num = (short)961675283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Controls.Dock dock = this.TabStripPlacement;
						global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
						global::System.Windows.Rect rect2 = this.a();
						double num8 = 0.0;
						double num4 = 0.0;
						global::System.Windows.Point[] array2 = new global::System.Windows.Point[4];
						array = new global::System.Windows.Point[4];
						num = (short)319750171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::System.Windows.Rect rect;
						double num4 = rect.Right - (double)this.b + 0.5;
						global::System.Windows.Point[] array2;
						array2[0] = new global::System.Windows.Point(num4, 0.0);
						global::System.Windows.Rect rect2;
						array2[1] = new global::System.Windows.Point(num4, rect2.Y);
						array2[2] = new global::System.Windows.Point(num4, rect2.Bottom);
						array2[3] = new global::System.Windows.Point(num4, rect.Bottom);
						num4 += 1.0;
						int num3 = 0;
						num = (short)743505943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_2CF;
					case 18:
						goto IL_61F;
					case 19:
						return;
					case 20:
						if (this.c != null)
						{
							num = (short)1400832022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					case 21:
						goto IL_61F;
					case 22:
					{
						global::System.Windows.Point[] array2;
						dc.DrawLine(this.c, array2[0], array2[1]);
						dc.DrawLine(this.c, array2[2], array2[3]);
						num = (short)839712775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_A47;
					case 24:
					{
						global::System.Windows.Point[] array4 = array;
						int num12 = 0;
						double num6 = array4[num12].X;
						array4[num12].X = num6 + 1.0;
						num = (short)580059146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						global::System.Windows.Point[] array5 = array;
						int num13 = 3;
						double num6 = array5[num13].X;
						array5[num13].X = num6 - 1.0;
						num = (short)73596949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (array[1] != array[0])
						{
							num = (short)1549336628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F4;
					case 27:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock == global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1171587130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)655818753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						dc.DrawLine(this.d, array[0], array[1]);
						num = (short)1119485954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_976;
					case 30:
					{
						int num9;
						if (num9 >= array.Length)
						{
							num = (short)959119392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Point[] array2;
						double num8;
						array[num9] = new global::System.Windows.Point(array2[num9].X, num8);
						num9++;
						num = (short)1642790969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						return;
					case 32:
						num = (short)565182511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_2CF;
					case 34:
						if (array[1] != array[0])
						{
							num = (short)831389724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D8;
					case 35:
					{
						global::System.Windows.Point[] array6 = array;
						int num14 = 0;
						double num6 = array6[num14].Y;
						array6[num14].Y = num6 + 1.0;
						num = (short)123011125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
					{
						num = (short)1572086929;
						short num15 = num;
						num = (short)1758209169;
						switch ((num15 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A6B;
						default:
						{
							num = (short)1819475968;
							if (num != 0)
							{
							}
							global::System.Windows.Point[] array7 = array;
							int num16 = 3;
							double num6 = array7[num16].Y;
							array7[num16].Y = num6 - 1.0;
							num = (short)593231890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 37:
						if (array[3].X > 0.0)
						{
							num = (short)1643249689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					case 38:
						num = (short)581500979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (array[3].X > 0.0)
						{
							num = (short)1050607662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					case 40:
						if (array[3].Y > 0.0)
						{
							num = (short)548536374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					case 41:
						num = (short)403439650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (array[3].Y > 0.0)
						{
							num = (short)1454964772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					case 43:
						num = (short)1830748186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						goto IL_D78;
					case 45:
						if (this.d != null)
						{
							num = (short)785186857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 46:
					{
						global::System.Windows.Point[] array8 = array;
						int num17 = 3;
						double num6 = array8[num17].X;
						array8[num17].X = num6 - 1.0;
						num = (short)514916407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						if (array[1] != array[0])
						{
							num = (short)1014038552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_511;
					case 48:
					{
						global::System.Windows.Controls.Dock dock;
						if (dock == global::System.Windows.Controls.Dock.Left)
						{
							num = (short)1425604624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1393688582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						if (array[1] != array[0])
						{
							num = (short)370278405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_976;
					case 50:
					{
						double num4 = 1.5;
						global::System.Windows.Point[] array2;
						array2[0] = new global::System.Windows.Point(num4, 0.0);
						global::System.Windows.Rect rect2;
						array2[1] = new global::System.Windows.Point(num4, rect2.Y);
						array2[2] = new global::System.Windows.Point(num4, rect2.Bottom);
						global::System.Windows.Rect rect;
						array2[3] = new global::System.Windows.Point(num4, rect.Bottom);
						num4 -= 1.0;
						int num7 = 0;
						num = (short)1481244716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
						if (array[1] != array[0])
						{
							num = (short)731709475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_803;
					case 52:
					{
						global::System.Windows.Point[] array9 = array;
						int num18 = 0;
						double num6 = array9[num18].X;
						array9[num18].X = num6 + 1.0;
						num = (short)456720396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						goto IL_803;
					case 54:
					{
						global::System.Windows.Point[] array10 = array;
						int num19 = 3;
						double num6 = array10[num19].Y;
						array10[num19].Y = num6 - 1.0;
						num = (short)1020329984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						goto IL_61F;
					case 56:
						num = (short)2052456497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_76E;
					case 58:
					{
						global::System.Windows.Rect rect;
						double num8 = rect.Bottom - (double)this.b + 0.5;
						global::System.Windows.Point[] array2;
						array2[0] = new global::System.Windows.Point(0.0, num8);
						global::System.Windows.Rect rect2;
						array2[1] = new global::System.Windows.Point(rect2.X, num8);
						array2[2] = new global::System.Windows.Point(rect2.Right, num8);
						array2[3] = new global::System.Windows.Point(rect.Right, num8);
						num8 += 1.0;
						int num10 = 0;
						num = (short)2130247713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_11B;
					IL_1F4:
					num = (short)1540948005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CF:
					num = (short)261619726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A2:
					num = (short)272236589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D8:
					dc.DrawLine(this.d, array[2], array[3]);
					num = (short)535625759;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_511:
					num = (short)1045495847;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61F:
					num = (short)1551171604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76E:
					num = (short)1410203678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_803:
					num = (short)1068957738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_976:
					num = (short)1854341160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A47:
					num = (short)1993146372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A6B:
					num = (short)1583349816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D78:
					num = (short)2051211272;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_11B:
				base.OnRender(dc);
				num = (short)333447183;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0005D4CC File Offset: 0x0005B6CC
		private global::System.Windows.Rect a()
		{
			short num = (short)698941440;
			short num2 = num;
			num = (short)939917312;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)50462721;
				if (num != 0)
				{
				}
				global::System.Windows.Rect result = default(global::System.Windows.Rect);
				global::System.Collections.IEnumerator enumerator = base.Children.GetEnumerator();
				try
				{
					num = (short)163643393;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Windows.Controls.TabItem tabItem;
						switch (num3)
						{
						case 0:
							goto IL_212;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_CE;
							}
							continue;
						case 2:
							if (tabItem != null)
							{
								num = (short)203292677;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
							num = (short)1245904896;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)347834281;
							short num4 = num;
							num = (short)1926137769;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_18B;
							default:
								goto IL_1DE;
							}
							break;
						}
						case 5:
							num = (short)845414406;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (tabItem.IsSelected)
							{
								num = (short)1074462728;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 7:
							if (!enumerator.MoveNext())
							{
								num = (short)1805582339;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							tabItem = (((global::System.Windows.UIElement)enumerator.Current) as global::System.Windows.Controls.TabItem);
							num = (short)549847042;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_18B;
						}
						IL_112:
						num = (short)2005008391;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CE:
						goto IL_112;
						IL_18B:
						result = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(tabItem);
						num = (short)202309636;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1DE:
					num = (short)1271136256;
					if (num != 0)
					{
					}
					IL_212:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_231;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_21E:
						switch (num3)
						{
						case 0:
							disposable.Dispose();
							num = (short)650182658;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (disposable != null)
							{
								num = (short)1351483392;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_287;
						case 2:
							goto IL_285;
						}
						goto IL_231;
					}
					IL_285:
					IL_287:
					goto EndFinally_7;
					IL_231:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)7143425;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_21E;
					EndFinally_7:;
				}
				return result;
			}
			}
		}

		// Token: 0x0400022C RID: 556
		private static readonly global::System.Windows.DependencyPropertyKey a;

		// Token: 0x0400022D RID: 557
		public static readonly global::System.Windows.DependencyProperty IsOversizedProperty;

		// Token: 0x0400022E RID: 558
		public static readonly global::System.Windows.DependencyProperty LayoutTypeProperty;

		// Token: 0x0400022F RID: 559
		public static readonly global::System.Windows.DependencyProperty TabTuckProperty;

		// Token: 0x04000230 RID: 560
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x04000231 RID: 561
		private int b;

		// Token: 0x04000232 RID: 562
		public static readonly global::System.Windows.DependencyProperty InnerBorderBrushProperty;

		// Token: 0x04000233 RID: 563
		private global::System.Windows.Media.Pen c;

		// Token: 0x04000234 RID: 564
		private global::System.Windows.Media.Pen d;

		// Token: 0x04000235 RID: 565
		private double e;

		// Token: 0x04000236 RID: 566
		private global::System.Windows.Thickness f = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 0.0);

		// Token: 0x04000237 RID: 567
		private int g;

		// Token: 0x04000238 RID: 568
		private int h;

		// Token: 0x04000239 RID: 569
		private double i;
	}
}
