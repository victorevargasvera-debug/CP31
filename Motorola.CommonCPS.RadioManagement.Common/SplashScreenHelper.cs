using System;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000025 RID: 37
	public static class SplashScreenHelper
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00011ECC File Offset: 0x000100CC
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00011F7C File Offset: 0x0001017C
		public static global::Motorola.CommonCPS.RadioManagement.Common.SplashWindow SplashScreen
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)122617857;
				if (num != 0)
				{
				}
				num = (short)72810496;
				short num2 = num;
				num = (short)124218620;
				short num3 = num;
				num = (short)314141948;
				switch (num3 == num)
				{
				}
				num = (short)1076822016;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)608973130;
				short num2 = num;
				num = (short)1957376330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1242759168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1775108096;
				if (num != 0)
				{
				}
				num = (short)659816449;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.a = value;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00012030 File Offset: 0x00010230
		public static void Show()
		{
			short num = (short)768409604;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1969553408;
				short num3 = num;
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					if (!global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.CheckAccess())
					{
						num = (short)1501757443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)278598674;
					short num4 = num;
					num = (short)133239826;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EA;
					default:
						goto IL_16D;
					}
					break;
				}
				case 2:
					goto IL_102;
				case 3:
					num = (short)163512321;
					if (num != 0)
					{
					}
					goto IL_EA;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				IL_61:
				if (global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen == null)
				{
					num = (short)2046558208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)157745153;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EA:
				num = (short)1639645186;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_102:
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.<>c.<>9.a));
			return;
			IL_16D:
			num = (short)1870004224;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Show();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000121CC File Offset: 0x000103CC
		public static void Hide()
		{
			short num = (short)9240580;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1753219072;
				short num3 = num;
				num = (short)211156993;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					if (!global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.CheckAccess())
					{
						num = (short)695205891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)890785378;
					short num4 = num;
					num = (short)72896098;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_ED;
					default:
						goto IL_16F;
					}
					break;
				}
				case 2:
					goto IL_104;
				case 3:
					goto IL_ED;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				}
				IL_89:
				if (global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen == null)
				{
					num = (short)1883176960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)782368769;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ED:
				num = (short)1626931202;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_104:
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.<>c.<>9.b));
			return;
			IL_16F:
			num = (short)1525219328;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Hide();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00012368 File Offset: 0x00010568
		public static void Active()
		{
			short num = (short)2125791236;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)421986304;
				short num3 = num;
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					if (!global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.CheckAccess())
					{
						num = (short)1440219139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)358416385;
					if (num != 0)
					{
					}
					num = (short)1666389583;
					short num4 = num;
					num = (short)1473451599;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BF;
					default:
						goto IL_16B;
					}
					break;
				}
				case 2:
					goto IL_D7;
				case 3:
					goto IL_BF;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				IL_61:
				if (global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen == null)
				{
					num = (short)668860416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2130640897;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BF:
				num = (short)1205600258;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_D7:
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.<>c.<>9.c));
			return;
			IL_16B:
			num = (short)1016791040;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Activate();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00012500 File Offset: 0x00010700
		public static void Close()
		{
			short num = (short)1626865668;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)801374208;
				short num3 = num;
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					if (!global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.CheckAccess())
					{
						num = (short)1708392451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)773783553;
					if (num != 0)
					{
					}
					num = (short)624764901;
					short num4 = num;
					num = (short)1731340261;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BF;
					default:
						goto IL_166;
					}
					break;
				}
				case 2:
					goto IL_D6;
				case 3:
					goto IL_BF;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				IL_62:
				if (global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen == null)
				{
					num = (short)29687808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)5963777;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BF:
				num = (short)201195522;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_D6:
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.<>c.<>9.d));
			return;
			IL_166:
			num = (short)1766653952;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Close();
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen = null;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001269C File Offset: 0x0001089C
		public static void StopProgressIndicator()
		{
			short num = (short)1491075076;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1529741312;
				short num3 = num;
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					if (!global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.CheckAccess())
					{
						num = (short)194379779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)216793089;
					if (num != 0)
					{
					}
					num = (short)162838075;
					short num4 = num;
					num = (short)751744571;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BE;
					default:
						goto IL_167;
					}
					break;
				}
				case 2:
					goto IL_D6;
				case 3:
					goto IL_BE;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				IL_61:
				if (global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen == null)
				{
					num = (short)2072576000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)996802561;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BE:
				num = (short)14745602;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_D6:
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.<>c.<>9.e));
			return;
			IL_167:
			num = (short)415105024;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.progressIndicator.Stop();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00012834 File Offset: 0x00010A34
		public static void StartProgressIndicator()
		{
			short num = (short)899153924;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1966342144;
				short num3 = num;
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					if (!global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.CheckAccess())
					{
						num = (short)210436099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)185202661;
					short num4 = num;
					num = (short)2005530597;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EB;
					default:
						goto IL_170;
					}
					break;
				}
				case 2:
					goto IL_103;
				case 3:
					goto IL_EB;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				}
				IL_60:
				num = (short)1355350017;
				if (num != 0)
				{
				}
				if (global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen == null)
				{
					num = (short)2078212096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)307691521;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EB:
				num = (short)353435650;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_103:
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.<>c.<>9.f));
			return;
			IL_170:
			num = (short)1909391360;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.progressIndicator.Start();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000129D8 File Offset: 0x00010BD8
		public static void ShowStatus(string status)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.a a;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (!global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.CheckAccess())
					{
						num2 = (short)436273155;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AC;
				case 2:
					goto IL_177;
				case 3:
				{
					num2 = (short)1934491648;
					short num3 = num2;
					global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Action(a.b));
					num2 = (short)255995717;
					short num4 = num2;
					num2 = (short)1111633733;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_177;
					default:
						num2 = (short)1256587264;
						if (num2 != 0)
						{
						}
						num2 = (short)1403977730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen == null)
					{
						num2 = (short)1400897536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)13959169;
					if (num2 != 0)
					{
					}
					num2 = (short)921501697;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return;
			IL_177:
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.Dispatcher.Invoke(global::System.Windows.Threading.DispatcherPriority.ApplicationIdle, new global::System.Action(global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.<>c.<>9.g));
			return;
			IL_1AC:
			global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.LoadingInfo.Status = a.a;
			return;
			IL_24:
			a = new global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.a();
			a.a = status;
			num2 = (short)1490550788;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000BB RID: 187
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::Motorola.CommonCPS.RadioManagement.Common.SplashWindow a;

		// Token: 0x02000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000101 RID: 257 RVA: 0x00013174 File Offset: 0x00011374
			internal void b()
			{
				short num = (short)770093242;
				short num2 = num;
				num = (short)1763684538;
				switch (num2 == num)
				{
				}
				num = (short)1148125185;
				if (num != 0)
				{
				}
				num = (short)1790312448;
				short num3 = num;
				num = (short)191561728;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.LoadingInfo.Status = this.a;
				global::Motorola.CommonCPS.RadioManagement.Common.SplashScreenHelper.SplashScreen.LoadingInfo.Progress += 33;
			}

			// Token: 0x040000C4 RID: 196
			public string a;
		}
	}
}
