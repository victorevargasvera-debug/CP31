using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Threading;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000043 RID: 67
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class TabPanelBorder : global::System.Windows.Controls.Decorator
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x0005E974 File Offset: 0x0005CB74
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.TabPanelBorder tabPanelBorder;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_37:
					if (tabPanelBorder != null)
					{
						num2 = (short)1221722114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B1;
				case 1:
					goto IL_B1;
				case 2:
				{
					num2 = (short)526516224;
					short num3 = num2;
					tabPanelBorder.OnBorderBrushChanged((global::System.Windows.Media.Brush)A_1.OldValue, (global::System.Windows.Media.Brush)A_1.NewValue);
					num2 = (short)1851523073;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
				IL_B1:
				num2 = (short)1310234688;
				short num4 = num2;
				num2 = (short)488937536;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_37;
				default:
					goto IL_E6;
				}
			}
			IL_E6:
			num2 = (short)116523009;
			if (num2 != 0)
			{
			}
			num2 = (short)1094975488;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			tabPanelBorder = (A_0 as global::DevComponents.WpfEditors.TabPanelBorder);
			num2 = (short)1625161728;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0005EAA4 File Offset: 0x0005CCA4
		protected virtual void OnBorderBrushChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
			while (newValue == null)
			{
				short num = (short)2025793193;
				short num2 = num;
				num = (short)2145068713;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1533870081;
					if (num != 0)
					{
					}
					num = (short)216596480;
					if (num != 0)
					{
					}
					num = (short)1748303872;
					short num3 = num;
					this.a = null;
					return;
				}
				}
			}
			this.a = new global::System.Windows.Media.Pen(newValue, 1.0);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0005EB74 File Offset: 0x0005CD74
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x0005EC2C File Offset: 0x0005CE2C
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)1577394896;
				short num2 = num;
				num = (short)227418832;
				switch (num2 == num)
				{
				}
				num = (short)366870529;
				if (num != 0)
				{
				}
				num = (short)54984704;
				if (num != 0)
				{
				}
				num = (short)451084288;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.TabPanelBorder.BorderBrushProperty);
			}
			set
			{
				short num = (short)751166963;
				short num2 = num;
				num = (short)2052253171;
				switch (num2 == num)
				{
				}
				num = (short)1094975489;
				if (num != 0)
				{
				}
				num = (short)672923648;
				if (num != 0)
				{
				}
				num = (short)1673592832;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.TabPanelBorder.BorderBrushProperty, value);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0005ECE4 File Offset: 0x0005CEE4
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.TabPanelBorder tabPanelBorder;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_38:
					if (tabPanelBorder != null)
					{
						num2 = (short)1631715330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B4;
				case 1:
					goto IL_B4;
				case 2:
				{
					num2 = (short)1842216960;
					short num3 = num2;
					tabPanelBorder.OnInnerBorderBrushChanged((global::System.Windows.Media.Brush)A_1.OldValue, (global::System.Windows.Media.Brush)A_1.NewValue);
					num2 = (short)484507649;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
				IL_B4:
				num2 = (short)1501609111;
				short num4 = num2;
				num2 = (short)1701100695;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_38;
				default:
					goto IL_E8;
				}
			}
			IL_E8:
			num2 = (short)1034747904;
			if (num2 != 0)
			{
			}
			num2 = (short)2022178817;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			tabPanelBorder = (A_0 as global::DevComponents.WpfEditors.TabPanelBorder);
			num2 = (short)896729088;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0005EE18 File Offset: 0x0005D018
		protected virtual void OnInnerBorderBrushChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
			while (newValue == null)
			{
				short num = (short)250980685;
				short num2 = num;
				num = (short)2041424205;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1692532737;
					if (num != 0)
					{
					}
					num = (short)447807488;
					if (num != 0)
					{
					}
					num = (short)1747648512;
					short num3 = num;
					this.b = null;
					return;
				}
				}
			}
			this.b = new global::System.Windows.Media.Pen(newValue, 1.0);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0005EEE8 File Offset: 0x0005D0E8
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x0005EFA0 File Offset: 0x0005D1A0
		public global::System.Windows.Media.Brush InnerBorderBrush
		{
			get
			{
				short num = (short)1877498874;
				short num2 = num;
				num = (short)1308122106;
				switch (num2 == num)
				{
				}
				num = (short)1234960385;
				if (num != 0)
				{
				}
				num = (short)252248064;
				if (num != 0)
				{
				}
				num = (short)121307136;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.TabPanelBorder.InnerBorderBrushProperty);
			}
			set
			{
				short num = (short)774012600;
				short num2 = num;
				num = (short)1476165304;
				switch (num2 == num)
				{
				}
				num = (short)1193279489;
				if (num != 0)
				{
				}
				num = (short)1957691392;
				if (num != 0)
				{
				}
				num = (short)639696896;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.TabPanelBorder.InnerBorderBrushProperty, value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0005F058 File Offset: 0x0005D258
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x0005F114 File Offset: 0x0005D314
		public global::System.Windows.Controls.Dock TabPlacement
		{
			get
			{
				short num = (short)2095742107;
				short num2 = num;
				num = (short)1869773979;
				switch (num2 == num)
				{
				}
				num = (short)1154613248;
				if (num != 0)
				{
				}
				num = (short)349306881;
				if (num != 0)
				{
				}
				num = (short)564002816;
				short num3 = num;
				return (global::System.Windows.Controls.Dock)base.GetValue(global::DevComponents.WpfEditors.TabPanelBorder.TabPlacementProperty);
			}
			set
			{
				short num = (short)387958015;
				short num2 = num;
				num = (short)515556607;
				switch (num2 == num)
				{
				}
				num = (short)1754005504;
				if (num != 0)
				{
				}
				num = (short)1673789441;
				if (num != 0)
				{
				}
				num = (short)1457913856;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.TabPanelBorder.TabPlacementProperty, value);
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0005F1D0 File Offset: 0x0005D3D0
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.TabPanelBorder tabPanelBorder;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_37:
					if (tabPanelBorder != null)
					{
						num2 = (short)461766658;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E1;
				case 1:
					num2 = (short)163643393;
					if (num2 != 0)
					{
					}
					goto IL_E1;
				case 2:
				{
					num2 = (short)629014528;
					short num3 = num2;
					tabPanelBorder.OnSelectedTabIndexChanged((int)A_1.OldValue, (int)A_1.NewValue);
					num2 = (short)2120089601;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
				IL_E1:
				num2 = (short)854577304;
				short num4 = num2;
				num2 = (short)1767821464;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_37;
				default:
					goto IL_117;
				}
			}
			IL_117:
			num2 = (short)637534208;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			tabPanelBorder = (A_0 as global::DevComponents.WpfEditors.TabPanelBorder);
			num2 = (short)160497664;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0005F30C File Offset: 0x0005D50C
		protected virtual void OnSelectedTabIndexChanged(int oldValue, int newValue)
		{
			short num = (short)1691924347;
			short num2 = num;
			num = (short)138786683;
			switch (num2 == num)
			{
			}
			num = (short)1148125185;
			if (num != 0)
			{
			}
			num = (short)542113792;
			if (num != 0)
			{
			}
			num = (short)2135031808;
			short num3 = num;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Windows.Threading.DispatcherOperationCallback(this.a), null);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0005F3D0 File Offset: 0x0005D5D0
		private object a(object A_0)
		{
			short num = (short)170131457;
			if (num != 0)
			{
			}
			num = (short)1971705563;
			short num2 = num;
			num = (short)878302939;
			switch (num2 == num)
			{
			}
			num = (short)1412366336;
			if (num != 0)
			{
			}
			num = (short)633602048;
			short num3 = num;
			base.InvalidateVisual();
			return null;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0005F480 File Offset: 0x0005D680
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x0005F538 File Offset: 0x0005D738
		public int SelectedTabIndex
		{
			get
			{
				short num = (short)1267040297;
				short num2 = num;
				num = (short)1317437481;
				switch (num2 == num)
				{
				}
				num = (short)1389953025;
				if (num != 0)
				{
				}
				num = (short)1375207424;
				if (num != 0)
				{
				}
				num = (short)1942487040;
				short num3 = num;
				return (int)base.GetValue(global::DevComponents.WpfEditors.TabPanelBorder.SelectedTabIndexProperty);
			}
			set
			{
				short num = (short)1155596646;
				short num2 = num;
				num = (short)1013252454;
				switch (num2 == num)
				{
				}
				num = (short)285343745;
				if (num != 0)
				{
				}
				num = (short)2140798976;
				if (num != 0)
				{
				}
				num = (short)788201472;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.TabPanelBorder.SelectedTabIndexProperty, value);
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0005F5F0 File Offset: 0x0005D7F0
		static TabPanelBorder()
		{
			int a_ = 3;
			short num = (short)1493893121;
			if (num != 0)
			{
			}
			num = (short)1544636218;
			short num2 = num;
			num = (short)102123322;
			switch (num2 == num)
			{
			}
			num = (short)1114046464;
			if (num != 0)
			{
			}
			num = (short)1658126336;
			short num3 = num;
			global::DevComponents.WpfEditors.TabPanelBorder.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鋏뷑ꛓ닕뷗꣙黛곝闟釡賣", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.TabPanelBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.TabPanelBorder.c)));
			global::DevComponents.WpfEditors.TabPanelBorder.InnerBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駏병뫓돕꫗飙돛곝蓟蟡難ꓥ髧鿩鿫蛭", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.TabPanelBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.TabPanelBorder.b)));
			global::DevComponents.WpfEditors.TabPanelBorder.TabPlacementProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蓏돑뛓蛕듗믙뿛믝跟蟡諣鋥", a_), typeof(global::System.Windows.Controls.Dock), typeof(global::DevComponents.WpfEditors.TabPanelBorder), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Dock.Top, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfEditors.TabPanelBorder.SelectedTabIndexProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菏럑룓돕믗껙맛뫝듟菡蛣꿥蛧軩觫雭", a_), typeof(int), typeof(global::DevComponents.WpfEditors.TabPanelBorder), new global::System.Windows.UIPropertyMetadata(-1, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.TabPanelBorder.a)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.TabPanelBorder), global::DevComponents.WpfEditors.SuperTabItem.HeaderChangedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.TabPanelBorder.a));
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0005F7C0 File Offset: 0x0005D9C0
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1145083673;
			short num2 = num;
			num = (short)1432917785;
			switch (num2 == num)
			{
			}
			num = (short)1468334081;
			if (num != 0)
			{
			}
			num = (short)598212608;
			if (num != 0)
			{
			}
			num = (short)1362821120;
			short num3 = num;
			((global::DevComponents.WpfEditors.TabPanelBorder)A_0).InvalidateVisual();
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0005F874 File Offset: 0x0005DA74
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			short num;
			int num3;
			global::System.Windows.Size result;
			for (;;)
			{
				IL_0A:
				num = (short)331939840;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (this.TabPlacement != global::System.Windows.Controls.Dock.Top)
					{
						num = (short)746455043;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13A;
				case 1:
					if (this.TabPlacement == global::System.Windows.Controls.Dock.Bottom)
					{
						num = (short)868548612;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result.Width += 2.0;
					goto IL_AF;
				case 2:
				{
					num = (short)1622216058;
					short num4 = num;
					num = (short)357764474;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AF;
					default:
						goto IL_FD;
					}
					break;
				}
				case 3:
					num = (short)199557121;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_13A;
				case 5:
					return result;
				}
				goto IL_51;
				IL_AF:
				num = (short)1498152962;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_13A:
				result.Height += 2.0;
				num = (short)1756954629;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_FD:
			num = (short)355270656;
			if (num != 0)
			{
			}
			num = (short)1114636289;
			if (num != 0)
			{
			}
			return result;
			IL_51:
			result = base.MeasureOverride(constraint);
			num = (short)131596288;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0005FA2C File Offset: 0x0005DC2C
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			global::System.Windows.UIElement child;
			short num2;
			global::System.Windows.Rect finalRect;
			global::System.Windows.Controls.Dock tabPlacement;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (child != null)
					{
						num2 = (short)1757544449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return arrangeSize;
				case 1:
					child.Arrange(finalRect);
					num2 = (short)615448589;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1355276502;
					short num3 = num2;
					num2 = (short)1155260630;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_32F;
					default:
						num2 = (short)1858732032;
						if (num2 != 0)
						{
						}
						num2 = (short)103677953;
						if (num2 != 0)
						{
						}
						goto IL_1EA;
					}
					break;
				}
				case 3:
					finalRect.Height -= 2.0;
					num2 = (short)2100166670;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (tabPlacement == global::System.Windows.Controls.Dock.Bottom)
					{
						num2 = (short)1512243210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1507917832;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					finalRect.Width -= 2.0;
					num2 = (short)1019019276;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					finalRect.Width -= 2.0;
					finalRect.X += 2.0;
					num2 = (short)493027330;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (tabPlacement == global::System.Windows.Controls.Dock.Right)
					{
						num2 = (short)1744764934;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1EA;
				case 8:
					if (tabPlacement == global::System.Windows.Controls.Dock.Left)
					{
						num2 = (short)138018821;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)89653255;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (tabPlacement == global::System.Windows.Controls.Dock.Top)
					{
						num2 = (short)31588352;
						short num4 = num2;
						num2 = (short)1682702339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1923153924;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					finalRect.Y += 2.0;
					finalRect.Height -= 2.0;
					num2 = (short)481493003;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_32F;
				case 12:
					goto IL_1EA;
				case 13:
					return arrangeSize;
				case 14:
					goto IL_1EA;
				}
				goto IL_4C;
				IL_1EA:
				num2 = (short)613351424;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_32F:
				goto IL_1EA;
			}
			return arrangeSize;
			IL_4C:
			child = this.Child;
			finalRect = new global::System.Windows.Rect(arrangeSize);
			tabPlacement = this.TabPlacement;
			num2 = (short)1928331273;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0005FD70 File Offset: 0x0005DF70
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			short num = (short)182124544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E7;
				}
				global::System.Windows.Media.Geometry geometry;
				global::System.Windows.Point[] array;
				global::System.Windows.Rect rect;
				global::System.Windows.Controls.Dock tabPlacement;
				global::DevComponents.WpfEditors.SuperTabControl superTabControl;
				for (;;)
				{
					IL_28:
					global::System.Windows.Rect layoutSlot;
					switch (num2)
					{
					case 0:
						if (geometry != null)
						{
							goto IL_272;
						}
						goto IL_43C;
					case 1:
						if (this.b != null)
						{
							num = (short)1067319298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65A;
					case 2:
						drawingContext.DrawLine(this.b, array[2], array[3]);
						num = (short)189726760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						array[0] = new global::System.Windows.Point(rect.X + 1.5, rect.Y);
						array[1] = new global::System.Windows.Point(rect.X + 1.5, rect.Bottom);
						array[2] = new global::System.Windows.Point(rect.X + 0.5, rect.Y + 1.0);
						array[3] = new global::System.Windows.Point(rect.X + 0.5, rect.Bottom - 1.0);
						num = (short)806617133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (tabPlacement != global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1930952720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_825;
					case 5:
					{
						global::DevComponents.WpfEditors.SuperTabItem superTabItem;
						layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(superTabItem);
						num = (short)961216537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_43C;
					case 7:
						goto IL_254;
					case 8:
						drawingContext.PushClip(geometry);
						num = (short)1863581706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (geometry != null)
						{
							num = (short)1946615816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14F;
					case 10:
						goto IL_14F;
					case 11:
						goto IL_722;
					case 12:
						if (superTabControl != null)
						{
							num = (short)71237670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D8;
					case 13:
						goto IL_722;
					case 14:
						if (base.VisualXSnappingGuidelines == null)
						{
							num = (short)1107165214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ACA;
					case 15:
						if (tabPlacement == global::System.Windows.Controls.Dock.Left)
						{
							num = (short)1131151378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2089091114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						num = (short)679280640;
						short num3 = num;
						num = (short)285081620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						drawingContext.Pop();
						num = (short)1564278790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						array[0] = new global::System.Windows.Point(rect.Right - 1.5, rect.Y);
						array[1] = new global::System.Windows.Point(rect.Right - 1.5, rect.Bottom);
						array[2] = new global::System.Windows.Point(rect.Right - 0.5, rect.Y + 1.0);
						array[3] = new global::System.Windows.Point(rect.Right - 0.5, rect.Bottom - 1.0);
						num = (short)2123431958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						base.VisualYSnappingGuidelines = new global::System.Windows.Media.DoubleCollection(new double[]
						{
							0.0,
							base.ActualHeight
						});
						num = (short)151912484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (tabPlacement == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)1693843484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F5;
					case 21:
						if (tabPlacement == global::System.Windows.Controls.Dock.Bottom)
						{
							num = (short)2122448919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1114636303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_722;
					case 23:
						array[0] = new global::System.Windows.Point(rect.X + 1.0, rect.Y + 1.5);
						array[1] = new global::System.Windows.Point(rect.Right - 1.0, rect.Y + 1.5);
						array[2] = new global::System.Windows.Point(rect.X + 1.0, rect.Y + 0.5);
						array[3] = new global::System.Windows.Point(rect.Right - 1.0, rect.Y + 0.5);
						num = (short)414384141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_75F;
					case 25:
						try
						{
							global::System.Windows.Controls.Panel panel;
							layoutSlot.Location = base.PointFromScreen(panel.PointToScreen(layoutSlot.Location));
							goto IL_216;
						}
						catch (global::System.InvalidOperationException)
						{
							layoutSlot.Location = default(global::System.Windows.Point);
							goto IL_216;
						}
						goto IL_5F5;
						IL_216:
						num = (short)645136388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						global::DevComponents.WpfEditors.SuperTabItem superTabItem;
						if (superTabItem != null)
						{
							num = (short)267649051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D8;
					}
					case 27:
					{
						global::DevComponents.WpfEditors.SuperTabItem superTabItem;
						global::System.Windows.Controls.Panel panel = global::System.Windows.Media.VisualTreeHelper.GetParent(superTabItem) as global::System.Windows.Controls.Panel;
						num = (short)1236402210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_825;
					case 29:
						drawingContext.DrawLine(this.a, array[0], array[1]);
						num = (short)1738080263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						base.VisualXSnappingGuidelines = new global::System.Windows.Media.DoubleCollection(new double[]
						{
							0.0,
							base.ActualWidth
						});
						num = (short)1826619424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						array[0] = new global::System.Windows.Point(rect.X, rect.Bottom - 1.5);
						array[1] = new global::System.Windows.Point(rect.Right, rect.Bottom - 1.5);
						array[2] = new global::System.Windows.Point(rect.X + 1.0, rect.Bottom - 0.5);
						array[3] = new global::System.Windows.Point(rect.Right - 1.0, rect.Bottom - 0.5);
						num = (short)78708747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_ACA;
					case 33:
						if (this.a != null)
						{
							num = (short)1009385501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_254;
					case 34:
					{
						global::System.Windows.Controls.Panel panel;
						if (panel != null)
						{
							num = (short)863502341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D8;
					}
					case 35:
						goto IL_75F;
					case 36:
						return;
					case 37:
						if (tabPlacement == global::System.Windows.Controls.Dock.Top)
						{
							num = (short)1601372191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1350172693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)731512871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (superTabControl.SelectedIndex >= 0)
						{
							num = (short)2103640108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D8;
					case 40:
						goto IL_65A;
					case 41:
						goto IL_6D8;
					case 42:
					{
						num = (short)1437825232;
						short num4 = num;
						num = (short)1412593872;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_272;
						default:
							num = (short)2036137984;
							if (num != 0)
							{
							}
							if (tabPlacement == global::System.Windows.Controls.Dock.Right)
							{
								num = (short)25427971;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_722;
						}
						break;
					}
					case 43:
						num = (short)56229889;
						if (num != 0)
						{
						}
						if (base.VisualYSnappingGuidelines == null)
						{
							num = (short)708247571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 44:
					{
						global::DevComponents.WpfEditors.SuperTabItem superTabItem = superTabControl.ItemContainerGenerator.ContainerFromIndex(superTabControl.SelectedIndex) as global::DevComponents.WpfEditors.SuperTabItem;
						num = (short)427622426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						goto IL_722;
					}
					goto IL_E7;
					IL_14F:
					num = (short)1458372609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_254:
					num = (short)2080505856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_272:
					num = (short)1419575313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43C:
					num = (short)1680211982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F5:
					layoutSlot = new global::System.Windows.Rect(rect.X, layoutSlot.Y, rect.Width, layoutSlot.Height);
					num = (short)1170472995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65A:
					num = (short)203489313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D8:
					global::System.Windows.Media.Brush borderBrush = this.BorderBrush;
					global::System.Windows.Media.Brush innerBorderBrush = this.InnerBorderBrush;
					num = (short)929103909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_722:
					num = (short)1417150473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_75F:
					geometry = new global::System.Windows.Media.CombinedGeometry
					{
						GeometryCombineMode = global::System.Windows.Media.GeometryCombineMode.Exclude,
						Geometry1 = new global::System.Windows.Media.RectangleGeometry(rect),
						Geometry2 = new global::System.Windows.Media.RectangleGeometry(layoutSlot)
					};
					num = (short)1606221865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_825:
					layoutSlot = new global::System.Windows.Rect(layoutSlot.X, rect.Y, layoutSlot.Width, rect.Height);
					num = (short)1571553304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ACA:
					num = (short)440205355;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_E7:
				base.OnRender(drawingContext);
				tabPlacement = this.TabPlacement;
				array = new global::System.Windows.Point[4];
				rect = new global::System.Windows.Rect(base.RenderSize);
				geometry = null;
				superTabControl = this.a();
				num = (short)1440022540;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000608BC File Offset: 0x0005EABC
		private global::DevComponents.WpfEditors.SuperTabControl a()
		{
			short num = (short)1374900753;
			short num2 = num;
			num = (short)187191825;
			switch (num2 == num)
			{
			}
			num = (short)1472200704;
			short num3 = num;
			num = (short)365821953;
			if (num != 0)
			{
			}
			num = (short)1805058048;
			if (num != 0)
			{
			}
			return base.TemplatedParent as global::DevComponents.WpfEditors.SuperTabControl;
		}

		// Token: 0x04000243 RID: 579
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x04000244 RID: 580
		private global::System.Windows.Media.Pen a;

		// Token: 0x04000245 RID: 581
		public static readonly global::System.Windows.DependencyProperty InnerBorderBrushProperty;

		// Token: 0x04000246 RID: 582
		private global::System.Windows.Media.Pen b;

		// Token: 0x04000247 RID: 583
		public static readonly global::System.Windows.DependencyProperty TabPlacementProperty;

		// Token: 0x04000248 RID: 584
		public static readonly global::System.Windows.DependencyProperty SelectedTabIndexProperty;
	}
}
