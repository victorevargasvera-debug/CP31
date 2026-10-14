using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.FileOperations
{
	// Token: 0x02000112 RID: 274
	public partial class BusyIndicator : Control
	{
		// Token: 0x06000F0D RID: 3853 RVA: 0x0014F374 File Offset: 0x0014D574
		static BusyIndicator()
		{
			int a_ = 14;
			short num = (short)937558016;
			short num2 = num;
			num = (short)689831937;
			if (num != 0)
			{
			}
			num = (short)965798812;
			short num3 = num;
			num = (short)773843868;
			switch (num3 == num)
			{
			}
			num = (short)51118080;
			if (num != 0)
			{
			}
			FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(BusyIndicator), new FrameworkPropertyMetadata(typeof(BusyIndicator)));
			BusyIndicator.BusyStateProperty = DependencyProperty.Register(RptMgrErrorHandler.b("펐쪘ﲜ쒠", a_), typeof(BusyStates), typeof(BusyIndicator), new FrameworkPropertyMetadata(BusyStates.NOT_BUSY, FrameworkPropertyMetadataOptions.AffectsRender, new PropertyChangedCallback(BusyIndicator.OnBusyStateChanged)));
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0014F48C File Offset: 0x0014D68C
		protected override AutomationPeer OnCreateAutomationPeer()
		{
			short num = (short)295567360;
			short num2 = num;
			num = (short)1344715176;
			short num3 = num;
			num = (short)1214757288;
			switch (num3 == num)
			{
			}
			num = (short)1463812097;
			if (num != 0)
			{
			}
			num = (short)1315241984;
			if (num != 0)
			{
			}
			return new BusyIndicatorAutomationPeer(this);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0014F53C File Offset: 0x0014D73C
		private static void OnBusyStateChanged(DependencyObject A_0, DependencyPropertyChangedEventArgs A_1)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_61;
			}
			int num;
			short num2;
			BusyIndicator busyIndicator;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if ((BusyStates)A_1.NewValue == BusyStates.NOT_BUSY)
					{
						num2 = (short)694353923;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1318453259;
					num = (int)((IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1923416065;
					if (num2 != 0)
					{
					}
					num2 = (short)167706626;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
					if (busyIndicator.a != null)
					{
						num2 = (short)1475084305;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 3:
					num2 = (short)609746959;
					num = (int)((IntPtr)num2);
					continue;
				case 4:
					goto IL_224;
				case 5:
					busyIndicator.a.Stop(busyIndicator.b);
					num2 = (short)420872196;
					num = (int)((IntPtr)num2);
					continue;
				case 6:
					if ((BusyStates)A_1.NewValue == BusyStates.BUSY)
					{
						num2 = (short)1639383049;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)353697792;
					num = (int)((IntPtr)num2);
					continue;
				case 7:
					goto IL_345;
				case 8:
					goto IL_2B1;
				case 9:
					num2 = (short)1397030928;
					num = (int)((IntPtr)num2);
					continue;
				case 10:
				{
					num2 = (short)199112763;
					short num3 = num2;
					num2 = (short)1442658363;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_362;
					default:
						num2 = (short)1239678976;
						if (num2 != 0)
						{
						}
						num2 = (short)2093613069;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					if ((BusyStates)A_1.NewValue == BusyStates.COMPLETE_NO_ERROR)
					{
						num2 = (short)182452234;
						num = (int)((IntPtr)num2);
						continue;
					}
					num2 = (short)1310916620;
					num = (int)((IntPtr)num2);
					continue;
				case 12:
					if ((BusyStates)A_1.NewValue == BusyStates.COMPLETE_WITH_ERROR)
					{
						num2 = (short)693370881;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 13:
					if (busyIndicator.a != null)
					{
						num2 = (short)484179976;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 14:
					goto IL_306;
				case 15:
					if (busyIndicator.a != null)
					{
						num2 = (short)1633091591;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 16:
					goto IL_362;
				case 17:
				{
					num2 = (short)669908992;
					short num4 = num2;
					Storyboard storyboard = busyIndicator.a;
					busyIndicator.a = (Storyboard)busyIndicator.FindResource(RptMgrErrorHandler.b("첊\udd8e殺", a_));
					busyIndicator.a.Begin(busyIndicator.b, HandoffBehavior.Compose, true);
					num2 = (short)1373831182;
					num = (int)((IntPtr)num2);
					continue;
				}
				}
				goto IL_61;
				IL_362:
				if (busyIndicator.a == null)
				{
					break;
				}
				num2 = (short)620232709;
				num = (int)((IntPtr)num2);
			}
			IL_12B:
			busyIndicator.b = (FrameworkElement)busyIndicator.GetTemplateChild(RptMgrErrorHandler.b("잊ﺐ얖", a_));
			FrameworkElement frameworkElement = (FrameworkElement)A_0;
			busyIndicator.Visibility = Visibility.Hidden;
			busyIndicator.a = (Storyboard)busyIndicator.FindResource(RptMgrErrorHandler.b("\ud88a﶐ﾒ튔ﾚ캜좠춢", a_));
			busyIndicator.a.Begin(busyIndicator.b, true);
			busyIndicator.Visibility = Visibility.Visible;
			return;
			IL_224:
			goto IL_12B;
			IL_2B1:
			Storyboard storyboard2 = busyIndicator.a;
			busyIndicator.a = (Storyboard)busyIndicator.FindResource(RptMgrErrorHandler.b("첊좎練릘좚ﺞ춠쾢", a_));
			busyIndicator.a.Begin(busyIndicator.b, HandoffBehavior.SnapshotAndReplace, true);
			return;
			IL_306:
			return;
			IL_345:
			busyIndicator.a.Stop(busyIndicator.b);
			busyIndicator.Visibility = Visibility.Hidden;
			return;
			IL_61:
			busyIndicator = (A_0 as BusyIndicator);
			num2 = (short)1682767878;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x0014F99C File Offset: 0x0014DB9C
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x0014FA58 File Offset: 0x0014DC58
		public BusyStates BusyState
		{
			get
			{
				short num = (short)390640829;
				short num2 = num;
				num = (short)1135785149;
				switch (num2 == num)
				{
				}
				num = (short)1999699969;
				if (num != 0)
				{
				}
				num = (short)1183121408;
				if (num != 0)
				{
				}
				num = (short)782172160;
				short num3 = num;
				return (BusyStates)base.GetValue(BusyIndicator.BusyStateProperty);
			}
			set
			{
				short num = (short)250650275;
				short num2 = num;
				num = (short)742760099;
				switch (num2 == num)
				{
				}
				num = (short)1654521857;
				if (num != 0)
				{
				}
				num = (short)616759296;
				if (num != 0)
				{
				}
				num = (short)597229568;
				short num3 = num;
				base.SetValue(BusyIndicator.BusyStateProperty, value);
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0014FB14 File Offset: 0x0014DD14
		public override void OnApplyTemplate()
		{
			short num = (short)69085861;
			short num2 = num;
			num = (short)161229477;
			switch (num2 == num)
			{
			}
			num = (short)782106625;
			if (num != 0)
			{
			}
			num = (short)338886656;
			if (num != 0)
			{
			}
			num = (short)1498087424;
			short num3 = num;
			base.OnApplyTemplate();
		}

		// Token: 0x040007E4 RID: 2020
		public static DependencyProperty BusyStateProperty;

		// Token: 0x040007E5 RID: 2021
		private Storyboard a;

		// Token: 0x040007E6 RID: 2022
		private FrameworkElement b;
	}
}
