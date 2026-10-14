using System;
using System.Configuration;
using System.IO;
using System.Runtime.CompilerServices;
using CefSharp;
using CefSharp.Wpf;

namespace ACPBrowser
{
	// Token: 0x02000009 RID: 9
	public static class Utility
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00003DCC File Offset: 0x00001FCC
		static Utility()
		{
			int a_ = 17;
			short num = (short)1922826240;
			short num2 = num;
			num = (short)806432505;
			short num3 = num;
			num = (short)1870212857;
			switch (num3 == num)
			{
			}
			num = (short)2114191360;
			if (num != 0)
			{
			}
			num = (short)496697345;
			if (num != 0)
			{
			}
			global::ACPBrowser.Utility.HelpRootDirRelative = global::System.Configuration.ConfigurationManager.AppSettings[global::ACPBrowser.HelpFilePathProvider.b("䬂怄欆礈夊戌怎攐園簔攖", a_)];
			global::ACPBrowser.Utility.HelpRootDir = global::System.AppDomain.CurrentDomain.BaseDirectory + global::ACPBrowser.Utility.HelpRootDirRelative;
			global::ACPBrowser.Utility.TutorialRootDirRelative = global::System.Configuration.ConfigurationManager.AppSettings[global::ACPBrowser.HelpFilePathProvider.b("圂瀄猆昈礊搌渎紐䄒稔砖洘弚琜洞", a_)];
			global::ACPBrowser.Utility.TutorialRootDir = global::System.AppDomain.CurrentDomain.BaseDirectory + global::ACPBrowser.Utility.HelpRootDirRelative + global::ACPBrowser.Utility.TutorialRootDirRelative;
			global::ACPBrowser.Utility.HelpCacheFolder = global::System.Configuration.ConfigurationManager.AppSettings[global::ACPBrowser.HelpFilePathProvider.b("䬂怄欆礈䠊氌氎礐瘒匔砖甘缚砜洞", a_)];
			global::ACPBrowser.Utility.b = new global::ACPBrowser.HelpFilePathProvider(new global::ACPBrowser.FileService());
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003F18 File Offset: 0x00002118
		internal static global::ACPBrowser.HelpWindow d()
		{
			short num = (short)1553596416;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
					goto IL_10C;
				case 2:
				{
					num = (short)1292632064;
					short num3 = num;
					if (!global::ACPBrowser.Utility.a.IsClosed)
					{
						num = (short)1326841857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_138;
				}
				case 3:
					num = (short)91291650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_35:
				num = (short)526039128;
				short num4 = num;
				num = (short)1321252952;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_138;
				default:
					num = (short)1427439616;
					if (num != 0)
					{
					}
					if (global::ACPBrowser.Utility.a == null)
					{
						goto IL_138;
					}
					num = (short)854786051;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10C:
			num = (short)1431568385;
			if (num != 0)
			{
			}
			return global::ACPBrowser.Utility.a;
			IL_138:
			global::ACPBrowser.Utility.a = new global::ACPBrowser.HelpWindow();
			return global::ACPBrowser.Utility.a;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000406C File Offset: 0x0000226C
		public static void CloseHelpWindowIfOpen()
		{
			for (;;)
			{
				IL_00:
				short num = (short)1193607168;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 1:
						num = (short)2120351746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)795716544;
						short num3 = num;
						num = (short)310488000;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)869466113;
							if (num != 0)
							{
							}
							num = (short)695664640;
							if (num != 0)
							{
							}
							if (global::ACPBrowser.Utility.a.IsWindowBeingDisplayed)
							{
								num = (short)79757315;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 3:
						global::ACPBrowser.Utility.a.b();
						global::ACPBrowser.Utility.a = null;
						num = (short)865075204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					}
					IL_39:
					if (global::ACPBrowser.Utility.a == null)
					{
						return;
					}
					num = (short)2123890688;
					short num4 = num;
					num = (short)1571094529;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000041D8 File Offset: 0x000023D8
		public static void DisplayHelpByFragment(string fragment)
		{
			short num = (short)294703900;
			short num2 = num;
			num = (short)1340461852;
			switch (num2 == num)
			{
			}
			num = (short)479002624;
			if (num != 0)
			{
			}
			num = (short)1501822976;
			short num3 = num;
			num = (short)1782710273;
			if (num != 0)
			{
			}
			global::ACPBrowser.Utility.DisplayHelpByPath(global::ACPBrowser.Utility.b.BuildPathForCPSHelp(fragment));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004294 File Offset: 0x00002494
		public static void DisplayHelpByFile(string fileName)
		{
			short num = (short)1453626878;
			short num2 = num;
			num = (short)65639934;
			switch (num2 == num)
			{
			}
			num = (short)1137836033;
			if (num != 0)
			{
			}
			num = (short)282787840;
			short num3 = num;
			num = (short)227672064;
			if (num != 0)
			{
			}
			global::ACPBrowser.Utility.DisplayHelpByPath(global::ACPBrowser.Utility.b.BuildPathForHelpByFileName(fileName));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004350 File Offset: 0x00002550
		public static void DisplayHelpByPath(string path)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E1;
				case 1:
					if (path != null)
					{
						num2 = (short)316118169;
						short num3 = num2;
						num2 = (short)893555865;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_11A;
						}
					}
					num2 = (short)1110507520;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (global::ACPBrowser.Utility.a != null)
					{
						num2 = (short)160038915;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5D;
				case 3:
					num2 = (short)1581056001;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_5D:
			num2 = (short)761135104;
			short num4 = num2;
			num2 = (short)1977155585;
			if (num2 != 0)
			{
			}
			return;
			IL_E1:
			goto IL_5D;
			IL_11A:
			num2 = (short)1814626304;
			if (num2 != 0)
			{
			}
			global::ACPBrowser.Utility.a.a(path);
			global::ACPBrowser.Utility.a.Show();
			global::ACPBrowser.Utility.a.Focus();
			return;
			IL_20:
			global::ACPBrowser.Utility.a = global::ACPBrowser.Utility.d();
			num2 = (short)2041905154;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000044AC File Offset: 0x000026AC
		public static void DisplayMovie(string fragment)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_C6;
				case 1:
					if (text != null)
					{
						num2 = (short)1204385090;
						short num3 = num2;
						num2 = (short)660632898;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_FF;
						}
					}
					num2 = (short)1015676928;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (global::ACPBrowser.Utility.a != null)
					{
						num2 = (short)601161731;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_68;
				case 3:
					num2 = (short)1568735233;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_68:
			num2 = (short)240648192;
			short num4 = num2;
			return;
			IL_C6:
			goto IL_68;
			IL_FF:
			num2 = (short)1996750849;
			if (num2 != 0)
			{
			}
			num2 = (short)1734279168;
			if (num2 != 0)
			{
			}
			global::ACPBrowser.Utility.a.c.Height = 0.0;
			global::ACPBrowser.Utility.a.Height = 684.0;
			global::ACPBrowser.Utility.a.Width = 851.0;
			global::ACPBrowser.Utility.a.a(text);
			global::ACPBrowser.Utility.a.Show();
			global::ACPBrowser.Utility.a.Focus();
			return;
			IL_20:
			global::ACPBrowser.Utility.a = global::ACPBrowser.Utility.d();
			text = global::ACPBrowser.Utility.b.BuildPathForMovies(fragment);
			num2 = (short)1127612418;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004654 File Offset: 0x00002854
		internal static void a(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_C3;
				case 1:
					if (text != null)
					{
						num2 = (short)655097856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13B;
				case 2:
					if (global::ACPBrowser.Utility.a == null)
					{
						num2 = (short)607387651;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2100625409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_67;
				}
				goto IL_20;
			}
			IL_67:
			num2 = (short)436011009;
			if (num2 != 0)
			{
			}
			return;
			IL_C3:
			num2 = (short)1506832007;
			short num3 = num2;
			num2 = (short)751726215;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_13B:
				num2 = (short)2063269888;
				short num4 = num2;
				global::ACPBrowser.Utility.DisplayHelpByFragment(null);
				return;
			}
			default:
				num2 = (short)1545666560;
				if (num2 != 0)
				{
				}
				global::ACPBrowser.Utility.a.a(text);
				global::ACPBrowser.Utility.a.Show();
				global::ACPBrowser.Utility.a.Focus();
				return;
			}
			IL_20:
			global::ACPBrowser.Utility.a = global::ACPBrowser.Utility.d();
			text = global::ACPBrowser.Utility.b.BuildPathForCPSTutorials(A_0);
			num2 = (short)1435107330;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000047CC File Offset: 0x000029CC
		public static bool DisplayCPSHelpDITA(string fragment)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_EC;
				case 1:
					if (text != null)
					{
						num2 = (short)691093080;
						short num3 = num2;
						num2 = (short)214056536;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_127;
						}
					}
					num2 = (short)594673664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (global::ACPBrowser.Utility.a != null)
					{
						num2 = (short)1622278147;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_68;
				case 3:
					num2 = (short)331743233;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_68:
			num2 = (short)564789248;
			short num4 = num2;
			num2 = (short)1098448897;
			if (num2 != 0)
			{
			}
			return false;
			IL_EC:
			goto IL_68;
			IL_127:
			num2 = (short)1164771328;
			if (num2 != 0)
			{
			}
			global::ACPBrowser.Utility.a.a(text);
			global::ACPBrowser.Utility.a.Show();
			global::ACPBrowser.Utility.a.Focus();
			return true;
			IL_20:
			global::ACPBrowser.Utility.a = global::ACPBrowser.Utility.d();
			text = global::ACPBrowser.Utility.b.BuildPathForCPSHelpDITA(fragment);
			num2 = (short)1591869442;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004938 File Offset: 0x00002B38
		internal static string c()
		{
			int a_ = 16;
			if (global::ACPBrowser.Utility.HelpCacheFolder != null)
			{
				short num = (short)293071885;
				short num2 = num;
				num = (short)407628813;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1163264001;
					if (num != 0)
					{
					}
					num = (short)499056640;
					short num3 = num;
					num = (short)731250688;
					if (num != 0)
					{
					}
					return global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::ACPBrowser.HelpFilePathProvider.b("企欃爅朇砉挋戍焏", a_), global::ACPBrowser.Utility.HelpCacheFolder, global::ACPBrowser.HelpFilePathProvider.b("䄁愃怅嬇戉洋簍怏儑甓甕瀗缙", a_));
				}
				}
			}
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004A20 File Offset: 0x00002C20
		internal static void b()
		{
			int a_ = 8;
			short num;
			try
			{
				num = (short)1261895681;
				if (num != 0)
				{
				}
				global::CefSharp.CefRuntime.SubscribeAnyCpuAssemblyResolver(null);
				global::ACPBrowser.Utility.a();
			}
			catch (global::System.Exception ex)
			{
				if (!ex.Message.Equals(global::ACPBrowser.HelpFilePathProvider.b("꿹迻鯽䇿氁紃䔅砇缉䴋納挏眑礓琕琗挙丛笝匟䴡䠣倥䴧堩ఫ䘭儯䄱ᐳ圵吷䠹夻弽␿㭁摃⑅ⵇ⽉≋湍㍏㍑㡓㩕㵗㹙灛繝͟͡ࡣ੥䡧", a_)))
				{
					num = (short)1691763369;
					short num2 = num;
					num = (short)482165417;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)286654464;
						if (num != 0)
						{
						}
						throw;
					}
				}
			}
			num = (short)1175453696;
			short num3 = num;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004B14 File Offset: 0x00002D14
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void a()
		{
			int a_ = 0;
			short num = (short)1366818817;
			if (num != 0)
			{
			}
			num = (short)2068161194;
			short num2 = num;
			num = (short)1183687338;
			switch (num2 == num)
			{
			}
			num = (short)1621426176;
			short num3 = num;
			num = (short)1218117632;
			if (num != 0)
			{
			}
			global::CefSharp.Cef.Initialize(new global::CefSharp.Wpf.CefSettings
			{
				CachePath = global::ACPBrowser.Utility.c(),
				CefCommandLineArgs = 
				{
					{
						global::ACPBrowser.HelpFilePathProvider.b("雱鷳藵駷飹郻鯽ⷿ持球瘅搇按漋漍搏笑笓砕㔗礙紛紝䠟䜡", a_),
						global::ACPBrowser.HelpFilePathProvider.b("쏱", a_)
					},
					{
						global::ACPBrowser.HelpFilePathProvider.b("雱鷳藵駷飹郻鯽ⷿ攁球猅┇礉搋漍琏眑易㬕簗猙漛甝ട䄡䔣䔥䀧伩", a_),
						global::ACPBrowser.HelpFilePathProvider.b("쏱", a_)
					}
				},
				LogSeverity = global::CefSharp.LogSeverity.Disable
			}, true, null);
		}

		// Token: 0x04000013 RID: 19
		private static global::ACPBrowser.HelpWindow a;

		// Token: 0x04000014 RID: 20
		private static global::ACPBrowser.HelpFilePathProvider b;

		// Token: 0x04000015 RID: 21
		public static string HelpRootDirRelative;

		// Token: 0x04000016 RID: 22
		public static string HelpRootDir;

		// Token: 0x04000017 RID: 23
		public static string TutorialRootDirRelative;

		// Token: 0x04000018 RID: 24
		public static string TutorialRootDir;

		// Token: 0x04000019 RID: 25
		public static string HelpCacheFolder;
	}
}
