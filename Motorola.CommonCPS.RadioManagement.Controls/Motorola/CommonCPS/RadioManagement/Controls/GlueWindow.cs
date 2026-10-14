using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.DockManager;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000A0 RID: 160
	public static class GlueWindow
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00040314 File Offset: 0x0003E514
		public static bool IsGlueWindowWorkingNow
		{
			get
			{
				short num = (short)242352129;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_35;
						}
						continue;
					case 2:
						return false;
					case 3:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a())
						{
							num = (short)277217282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					IL_35:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a.Count == 0)
					{
						num = (short)28835840;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1154220032;
						short num3 = num;
						num = (short)565036996;
						short num4 = num;
						num = (short)1010157508;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num = (short)1985937408;
							if (num != 0)
							{
							}
							num = (short)158400513;
							if (num != 0)
							{
							}
							num = (short)1604911107;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00040458 File Offset: 0x0003E658
		private static global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow a(string A_0)
		{
			short num;
			for (;;)
			{
				num = (short)93847553;
				if (num != 0)
				{
				}
				if (!global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a.ContainsKey(A_0))
				{
					goto IL_BB;
				}
				num = (short)1388278421;
				short num2 = num;
				num = (short)1475506837;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6E;
				}
			}
			IL_6E:
			num = (short)919076864;
			if (num != 0)
			{
			}
			num = (short)1370488832;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a[A_0];
			IL_BB:
			return null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00040524 File Offset: 0x0003E724
		private static bool a()
		{
			short num = (short)332412048;
			short num2 = num;
			num = (short)126956688;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)620363776;
				short num3 = num;
				break;
			}
			}
			num = (short)267452417;
			if (num != 0)
			{
			}
			num = (short)203620352;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow>.ValueCollection.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a.Values.GetEnumerator())
			{
				num = (short)863764483;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1381498884;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow = enumerator.Current;
						num = (short)941359110;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_196;
					case 2:
						goto IL_17D;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_F2;
						}
						continue;
					case 4:
						num = (short)165740545;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						result = false;
						num = (short)595591170;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
						if (!innerWindow.IsHidden)
						{
							num = (short)854261765;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_F4:
					num = (short)842989568;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_F2:
					goto IL_F4;
				}
				IL_17D:
				return result;
				IL_196:
				return true;
			}
			return result;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000406EC File Offset: 0x0003E8EC
		private static void a(string A_0, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow A_1)
		{
			short num = (short)1206452227;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)831258628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1C0;
				case 2:
					if (!A_1.Equals(innerWindow))
					{
						num = (short)1768423425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)1798018442;
					short num3 = num;
					num = (short)1340249482;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DB;
					default:
						num = (short)1765146624;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_8A;
						}
						continue;
					}
					break;
				}
				case 4:
					num = (short)1077608449;
					if (num != 0)
					{
					}
					if (A_1 != null)
					{
						num = (short)603979782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DB;
				case 5:
					goto IL_179;
				case 6:
					innerWindow = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a[A_0];
					num = (short)1960771586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8A:
				if (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a.ContainsKey(A_0))
				{
					num = (short)960495616;
					short num4 = num;
					num = (short)539688960;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a.Add(A_0, A_1);
					num = (short)2098331653;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_DB:
			global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a.Remove(A_0);
			return;
			IL_179:
			return;
			IL_1C0:
			global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a[A_0] = A_1;
			innerWindow.a(true, false);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000408C0 File Offset: 0x0003EAC0
		public static global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow GetAttachedGlueWindowByKey(string key)
		{
			while (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a.ContainsKey(key))
			{
				short num = (short)1800120383;
				short num2 = num;
				num = (short)1015457855;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1623457793;
					if (num != 0)
					{
					}
					num = (short)1940586496;
					if (num != 0)
					{
					}
					num = (short)1590493184;
					short num3 = num;
					return global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a[key];
				}
				}
			}
			return null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00040988 File Offset: 0x0003EB88
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow> GetAttchedGlueWindowByContent(global::System.Windows.DependencyObject content)
		{
			short num = (short)1383880632;
			short num2 = num;
			num = (short)808998840;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow> list;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1445068800;
				short num3 = num;
				num = (short)257687553;
				if (num != 0)
				{
				}
				num = (short)1304035328;
				if (num != 0)
				{
				}
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow>();
				using (global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow>.ValueCollection.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a.Values.GetEnumerator())
				{
					num = (short)74448899;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
							if (innerWindow.InnerContent.Equals(content))
							{
								num = (short)795672580;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_1A7;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_F2;
							}
							continue;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
							list.Add(innerWindow);
							num = (short)1857486850;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)461111297;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)815136773;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow = enumerator.Current;
							num = (short)2045181952;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_135:
						num = (short)1118240774;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F2:
						goto IL_135;
					}
					IL_1A7:;
				}
				break;
			}
			}
			return list;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00040B60 File Offset: 0x0003ED60
		public static bool TryShowGlueWindowAgain(global::System.Windows.FrameworkElement owerElement, global::System.Windows.DependencyObject content, string keyForCache, object tag)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow2;
			short num2;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow> attchedGlueWindowByContent;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return true;
				case 1:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a(keyForCache, innerWindow);
					innerWindow2 = innerWindow;
					num2 = (short)2144403460;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return true;
				case 3:
					num2 = (short)498597889;
					if (num2 != 0)
					{
					}
					if (attchedGlueWindowByContent.Count > 0)
					{
						num2 = (short)1156317189;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11D;
				case 4:
					goto IL_11D;
				case 5:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow = attchedGlueWindowByContent[0];
					num2 = (short)148111367;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (innerWindow2 == null)
					{
						num2 = (short)1858273288;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					innerWindow2.r();
					num2 = (short)1436811266;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
					if (innerWindow != null)
					{
						num2 = (short)2074935297;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11D;
				}
				case 8:
				{
					num2 = (short)1713504256;
					short num3 = num2;
					num2 = (short)956338195;
					short num4 = num2;
					num2 = (short)324046867;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1204551680;
						if (num2 != 0)
						{
						}
						innerWindow2 = new global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow(owerElement, content, keyForCache, tag);
						innerWindow2.a(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy.a);
						break;
					}
					num2 = (short)623443968;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_34;
				IL_11D:
				num2 = (short)1537540102;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_34:
			innerWindow2 = null;
			attchedGlueWindowByContent = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.GetAttchedGlueWindowByContent(content);
			num2 = (short)403570691;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00040D74 File Offset: 0x0003EF74
		public static void GlueIt(global::System.Windows.FrameworkElement owerElement, global::System.Windows.DependencyObject content, string keyForCache, object tag)
		{
			int a_ = 2;
			short num = (short)1489633281;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EC;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 2:
					if (string.IsNullOrEmpty(keyForCache))
					{
						num = (short)406913025;
						if (num != 0)
						{
						}
						num = (short)1381564421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					innerWindow = null;
					innerWindow = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a(keyForCache);
					num = (short)1549598723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)677443197;
					short num3 = num;
					num = (short)215152253;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_140;
					default:
						num = (short)1491468288;
						if (num != 0)
						{
						}
						if (innerWindow != null)
						{
							num = (short)1766981632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AE;
					}
					break;
				}
				case 4:
					goto IL_60;
				case 5:
					goto IL_1A9;
				}
				IL_45:
				if (owerElement == null)
				{
					num = (short)1635254276;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2122973186;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_60:
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﮝ튟좣쎥얧쾩슫\udaad邯솱\udcb3\ud9b5춷횹\ud8bb麽꺿귁냃꫇꿉ꃍꗏ뻑룓", a_));
			IL_EC:
			IL_140:
			innerWindow.r();
			return;
			IL_1A9:
			num = (short)614727680;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("鍊춡횣즧즩쒫쮭邯솱\udcb3\ud9b5춷횹\ud8bb麽꺿귁냃꫇꿉ꃍꗏ뻑룓", a_));
			IL_1AE:
			innerWindow = new global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow(owerElement, content, keyForCache, tag);
			innerWindow.a(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy.a);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00040F40 File Offset: 0x0003F140
		private static void a(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow A_0)
		{
			short num = (short)701825024;
			short num2 = num;
			num = (short)1034878976;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow>();
				using (global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow>.ValueCollection.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a.Values.GetEnumerator())
				{
					num = (short)865271812;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
							num = (short)1856110600;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
							if (innerWindow != null)
							{
								num = (short)254607367;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
							if (!A_0.Equals(innerWindow))
							{
								num = (short)1221853189;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_1D4;
							}
							continue;
						case 5:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
							list.Add(innerWindow);
							num = (short)33095680;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1700855809;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow = enumerator.Current;
							num = (short)1109196802;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num = (short)485359619;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_2BE;
						}
						IL_22B:
						num = (short)495321094;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D4:
						goto IL_22B;
					}
					IL_2BE:
					goto IL_17D;
				}
				goto IL_2D1;
				for (;;)
				{
					IL_17D:
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow>.Enumerator enumerator2 = list.GetEnumerator())
					{
						num = (short)217579520;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_A0;
								}
								continue;
							case 1:
								num = (short)306446340;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								num = (short)804901067;
								short num4 = num;
								num = (short)1289867467;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_16A;
								default:
									num = (short)1602682880;
									if (num != 0)
									{
									}
									break;
								}
								break;
							}
							case 3:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)695664641;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow2 = enumerator2.Current;
								innerWindow2.p();
								num = (short)786890754;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_16A;
							}
							IL_A2:
							num = (short)1543700483;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_A0:
							goto IL_A2;
						}
						IL_16A:
						break;
					}
				}
				IL_2D1:
				num = (short)1503789057;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00041278 File Offset: 0x0003F478
		// Note: this type is marked as 'beforefieldinit'.
		static GlueWindow()
		{
			short num = (short)980877312;
			short num2 = num;
			num = (short)569840546;
			short num3 = num;
			num = (short)1875579810;
			switch (num3 == num)
			{
			}
			num = (short)878182401;
			if (num != 0)
			{
			}
			num = (short)1109524480;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow>();
		}

		// Token: 0x04000151 RID: 337
		private static readonly global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow> a;

		// Token: 0x020000A1 RID: 161
		public class InnerWindow : global::System.Windows.Window
		{
			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0004132C File Offset: 0x0003F52C
			internal global::System.Windows.FrameworkElement OwnerElement
			{
				get
				{
					short num = (short)809304064;
					short num2 = num;
					num = (short)1006378541;
					short num3 = num;
					num = (short)294067757;
					switch (num3 == num)
					{
					}
					num = (short)1570701313;
					if (num != 0)
					{
					}
					num = (short)1191837696;
					if (num != 0)
					{
					}
					return this.ownerElement;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000413DC File Offset: 0x0003F5DC
			public bool IsHidden
			{
				get
				{
					short num = (short)529203200;
					short num2 = num;
					num = (short)869061806;
					short num3 = num;
					num = (short)1681052846;
					switch (num3 == num)
					{
					}
					num = (short)1856110593;
					if (num != 0)
					{
					}
					num = (short)595591168;
					if (num != 0)
					{
					}
					return this.isHidden;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00041488 File Offset: 0x0003F688
			public string Key
			{
				get
				{
					short num = (short)1569390592;
					short num2 = num;
					num = (short)766927193;
					short num3 = num;
					num = (short)2318681;
					switch (num3 == num)
					{
					}
					num = (short)1702428672;
					if (num != 0)
					{
					}
					num = (short)653328385;
					if (num != 0)
					{
					}
					return this.key;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00041538 File Offset: 0x0003F738
			public bool IsFirstTimeToShow
			{
				get
				{
					short num = (short)674496512;
					short num2 = num;
					num = (short)1677723269;
					short num3 = num;
					num = (short)1389692549;
					switch (num3 == num)
					{
					}
					num = (short)617349121;
					if (num != 0)
					{
					}
					num = (short)1760624640;
					if (num != 0)
					{
					}
					return this.timesOfShow < 2;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000415EC File Offset: 0x0003F7EC
			public global::System.Windows.DependencyObject InnerContent
			{
				get
				{
					short num = (short)847708160;
					short num2 = num;
					num = (short)207552513;
					if (num != 0)
					{
					}
					num = (short)1771382520;
					short num3 = num;
					num = (short)1388783352;
					switch (num3 == num)
					{
					}
					num = (short)1574043648;
					if (num != 0)
					{
					}
					return this.innerContent;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0004169C File Offset: 0x0003F89C
			public global::System.Windows.Controls.ScrollViewer InnerScrollViewer
			{
				get
				{
					short num = (short)296878080;
					short num2 = num;
					num = (short)1501494989;
					short num3 = num;
					num = (short)167182029;
					switch (num3 == num)
					{
					}
					num = (short)329711617;
					if (num != 0)
					{
					}
					num = (short)887029760;
					if (num != 0)
					{
					}
					return this.innerScrollViewer;
				}
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x00041748 File Offset: 0x0003F948
			internal void m()
			{
				short num = (short)872611841;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1575009969;
						short num3 = num;
						num = (short)1505935025;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)192151553;
							if (num != 0)
							{
							}
							num = (short)575340544;
							if (num != 0)
							{
							}
							this.h();
							num = (short)1910898688;
							short num4 = num;
							num = (short)714604546;
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
							goto IL_32;
						}
						continue;
					case 2:
						return;
					}
					IL_32:
					if (!this.k())
					{
						break;
					}
					num = (short)376307712;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x00041864 File Offset: 0x0003FA64
			private bool k()
			{
				short num = (short)252051459;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.DependencyObject parent;
					global::System.Windows.Controls.ScrollViewer scrollViewer;
					switch (num2)
					{
					case 0:
						return true;
					case 1:
					{
						num = (short)283077434;
						short num3 = num;
						num = (short)957836090;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_120;
						default:
							goto IL_B9;
						}
						break;
					}
					case 2:
						if (!parent.Equals(this.innerScrollViewer))
						{
							goto IL_120;
						}
						return false;
					case 3:
					{
						num = (short)1676279808;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					}
					case 4:
						num = (short)67239938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (scrollViewer != null)
						{
							num = (short)705691652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					IL_65:
					if (base.Content == null)
					{
						num = (short)455671809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					parent = global::System.Windows.LogicalTreeHelper.GetParent(this.innerContent);
					scrollViewer = (parent as global::System.Windows.Controls.ScrollViewer);
					num = (short)1372389381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_120:
					num = (short)1424621568;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B9:
				num = (short)2143944705;
				if (num != 0)
				{
				}
				num = (short)1581252608;
				if (num != 0)
				{
				}
				return true;
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x000419FC File Offset: 0x0003FBFC
			internal InnerWindow(global::System.Windows.FrameworkElement A_0, global::System.Windows.DependencyObject A_1, string A_2, object A_3)
			{
				base.Tag = A_3;
				this.ownerElement = A_0;
				this.innerContent = A_1;
				this.key = A_2;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a(A_2, this);
				this.j();
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00041A3C File Offset: 0x0003FC3C
			private void j()
			{
				short num = (short)772355874;
				short num2 = num;
				num = (short)874919714;
				switch (num2 == num)
				{
				}
				num = (short)2080702465;
				if (num != 0)
				{
				}
				num = (short)1282408448;
				if (num != 0)
				{
				}
				num = (short)1386086400;
				short num3 = num;
				this.i();
				this.h();
				this.g();
				this.d();
				this.e();
				this.c();
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x00041B08 File Offset: 0x0003FD08
			private void i()
			{
				short num = (short)158770365;
				short num2 = num;
				num = (short)545498301;
				switch (num2 == num)
				{
				}
				num = (short)1328676864;
				if (num != 0)
				{
				}
				num = (short)712572929;
				if (num != 0)
				{
				}
				num = (short)1681129472;
				short num3 = num;
				base.Left = (base.Top = 10000.0);
				base.Background = global::System.Windows.Media.Brushes.White;
				base.ShowInTaskbar = false;
				base.ShowActivated = false;
				base.WindowStyle = global::System.Windows.WindowStyle.None;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.g(this);
				base.ResizeMode = global::System.Windows.ResizeMode.NoResize;
				base.FlowDirection = this.ownerElement.FlowDirection;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.h(this);
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x00041C10 File Offset: 0x0003FE10
			private void h()
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow innerWindow;
					short num2;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
						{
							innerWindow.Content = null;
							num2 = (short)297930822;
							short num3 = num2;
							num2 = (short)1825968198;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)918487040;
								if (num2 != 0)
								{
								}
								num2 = (short)997588993;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 1:
							goto IL_11C;
						case 2:
						{
							num2 = (short)2117533696;
							short num4 = num2;
							if (innerWindow != null)
							{
								num2 = (short)1711865856;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_11E;
						}
						}
						break;
					}
					IL_1C:
					num2 = (short)1954086913;
					if (num2 != 0)
					{
					}
					innerWindow = (global::System.Windows.Window.GetWindow(this.innerContent) as global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow);
					num2 = (short)1369047042;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_11C:
				IL_11E:
				global::System.Windows.Controls.ScrollViewer scrollViewer = new global::System.Windows.Controls.ScrollViewer();
				scrollViewer.HorizontalScrollBarVisibility = (scrollViewer.VerticalScrollBarVisibility = global::System.Windows.Controls.ScrollBarVisibility.Auto);
				scrollViewer.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
				scrollViewer.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
				scrollViewer.Background = global::System.Windows.Media.Brushes.White;
				scrollViewer.FocusVisualStyle = null;
				scrollViewer.Content = this.innerContent;
				this.innerScrollViewer = scrollViewer;
				base.Content = scrollViewer;
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x00041D8C File Offset: 0x0003FF8C
			private void g()
			{
				int a_ = 12;
				switch (0)
				{
				case 0:
					goto IL_29;
				}
				int num;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.<>c__DisplayClass24_0 CS$<>8__locals1;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						CS$<>8__locals1.a.Activated += global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.<>c.<>9.a;
						num2 = (short)65672744;
						short num3 = num2;
						num2 = (short)2015237672;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num2 = (short)639434752;
							if (num2 != 0)
							{
							}
							num2 = (short)443940866;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (CS$<>8__locals1.a == null)
						{
							num2 = (short)1353646083;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1831337985;
						if (num2 != 0)
						{
						}
						base.Owner = CS$<>8__locals1.a;
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.f(CS$<>8__locals1.a);
						CS$<>8__locals1.a.Closing += CS$<>8__locals1.b;
						num2 = (short)1237909504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_170;
					case 3:
						goto IL_71;
					}
					goto IL_29;
				}
				IL_71:
				throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮣톥춧\ud8a9슭햯\udfb1톳\ud8b5첷骹톻쮽뎿뛁꓅귇꿉ꋋ뇏뛑냓돕볗龎뗛냝铟跡쓣郥臧駩駫迭鳯틱胳蓵鷷鿹퓻雽懿焁␃椅缇搉椋簍』攑紓砕簗甙欛㜝\u001f䀡䄣䀥䜧堩䤫อ眯帱䄳匵焷丹", a_));
				IL_170:
				num2 = (short)261160960;
				short num4 = num2;
				CS$<>8__locals1.a.Deactivated += global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.<>c.<>9.b;
				return;
				IL_29:
				CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.<>c__DisplayClass24_0();
				CS$<>8__locals1.a = global::System.Windows.Window.GetWindow(this.ownerElement);
				num2 = (short)1617887233;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x00041F7C File Offset: 0x0004017C
			private void d(bool A_0)
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
						if (A_0)
						{
							num2 = (short)1050411010;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
					{
						this.ownerElement.LayoutUpdated += this.OwerElement_LayoutUpdated;
						num2 = (short)1108935036;
						short num3 = num2;
						num2 = (short)935002492;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)1126629376;
							if (num2 != 0)
							{
							}
							num2 = (short)2027159552;
							short num4 = num2;
							num2 = (short)1118568449;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
				IL_1C:
				num2 = (short)1920991233;
				if (num2 != 0)
				{
				}
				this.f();
				num2 = (short)1941635072;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x000420A8 File Offset: 0x000402A8
			private void c(bool A_0)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.Windows.Window window;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)961282048;
						short num3 = num2;
						if (A_0)
						{
							goto IL_71;
						}
						return;
					}
					case 1:
					{
						num2 = (short)854932106;
						short num4 = num2;
						num2 = (short)1088699018;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_71;
						default:
							goto IL_110;
						}
						break;
					}
					case 2:
						window.LocationChanged += this.ParentWindow_LocationChanged;
						num2 = (short)1541144577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
					IL_71:
					num2 = (short)525336577;
					if (num2 != 0)
					{
					}
					num2 = (short)1487536130;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_110:
				num2 = (short)509411328;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				window = global::System.Windows.Window.GetWindow(this.ownerElement);
				this.a(window);
				num2 = (short)566493184;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x000421DC File Offset: 0x000403DC
			private void b(bool A_0)
			{
				short num = (short)1162795893;
				short num2 = num;
				num = (short)981916533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1910046720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)982581249;
				if (num != 0)
				{
				}
				num = (short)215023616;
				if (num != 0)
				{
				}
				this.d(A_0);
				this.c(A_0);
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x00042290 File Offset: 0x00040490
			private void ParentWindow_LocationChanged(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1597636270;
				short num2 = num;
				num = (short)492699310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1796407296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1119617025;
				if (num != 0)
				{
				}
				num = (short)1254162432;
				if (num != 0)
				{
				}
				global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this.ownerElement);
				this.a(window);
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x0004234C File Offset: 0x0004054C
			private void OwerElement_LayoutUpdated(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1982090849;
				short num2 = num;
				num = (short)300109409;
				switch (num2 == num)
				{
				default:
				{
					num = (short)405602304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)916848640;
				if (num != 0)
				{
				}
				num = (short)1335099393;
				if (num != 0)
				{
				}
				this.f();
				global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this.ownerElement);
				this.a(window);
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x00042410 File Offset: 0x00040610
			private void f()
			{
				short num = (short)868220929;
				if (num != 0)
				{
				}
				num = (short)1039335426;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)2053415571;
						short num3 = num;
						num = (short)1543086739;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8A;
						default:
							goto IL_112;
						}
						break;
					}
					case 1:
					{
						double actualWidth = this.ownerElement.ActualWidth;
						double actualHeight = this.ownerElement.ActualHeight;
						base.Width = actualWidth;
						base.Height = actualHeight;
						num = (short)1239744512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1499332608;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					}
					}
					goto IL_7F;
					IL_8A:
					num = (short)532480001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F:
					if (!this.isHidden)
					{
						goto IL_8A;
					}
					return;
				}
				IL_112:
				num = (short)1345978368;
				if (num != 0)
				{
				}
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x00042548 File Offset: 0x00040748
			private void a(global::System.Windows.Window A_0)
			{
				short num = (short)908197889;
				if (num != 0)
				{
				}
				num = (short)863043588;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Point point;
						base.Left = point.X;
						base.Top = point.Y;
						num = (short)432144386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)2113208320;
						short num3 = num;
						num = (short)984416259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					case 3:
					{
						global::System.Windows.Point point;
						if (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(this.ownerElement, A_0, out point))
						{
							goto IL_154;
						}
						return;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					}
					IL_5E:
					num = (short)709022021;
					short num4 = num;
					num = (short)1245958469;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_154:
						num = (short)875692032;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1794113536;
						if (num != 0)
						{
						}
						if (this.isHidden)
						{
							return;
						}
						num = (short)1692336129;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x000426C4 File Offset: 0x000408C4
			private void e()
			{
				short num = (short)64552961;
				if (num != 0)
				{
				}
				num = (short)868856866;
				short num2 = num;
				num = (short)672969762;
				switch (num2 == num)
				{
				}
				num = (short)1579483136;
				if (num != 0)
				{
				}
				num = (short)1282408448;
				short num3 = num;
				this.IsEnabledInner = this.ownerElement.IsEnabled;
				this.ownerElement.IsEnabledChanged += this.b;
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x00042794 File Offset: 0x00040994
			private void b(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
			{
				short num = (short)1118028201;
				short num2 = num;
				num = (short)2106048937;
				switch (num2 == num)
				{
				}
				num = (short)140115968;
				if (num != 0)
				{
				}
				num = (short)1024262145;
				if (num != 0)
				{
				}
				num = (short)643366912;
				short num3 = num;
				this.IsEnabledInner = (bool)A_1.NewValue;
				base.Opacity = (this.IsEnabledInner ? 1.0 : 0.5);
			}

			// Token: 0x06000407 RID: 1031 RVA: 0x00042874 File Offset: 0x00040A74
			private void d()
			{
				short num = (short)1607532546;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E0;
					case 1:
						this.p();
						num = (short)69992448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)76495623;
						short num3 = num;
						num = (short)510278407;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)102236160;
							short num4 = num;
							num = (short)186646528;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A3;
							}
							continue;
						}
						}
						break;
					}
					}
					IL_A3:
					if (this.ownerElement.IsVisible)
					{
						goto IL_109;
					}
					num = (short)451543041;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E0:
				num = (short)951713793;
				if (num != 0)
				{
				}
				IL_109:
				this.ownerElement.IsVisibleChanged -= this.a;
				this.ownerElement.IsVisibleChanged += this.a;
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x000429B8 File Offset: 0x00040BB8
			private global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow GetLastShownWindowOfOwnerElemenet(global::System.Windows.FrameworkElement A_0)
			{
				short num = (short)577724054;
				short num2 = num;
				num = (short)402153110;
				switch (num2 == num)
				{
				}
				num = (short)1996488705;
				if (num != 0)
				{
				}
				num = (short)1817968640;
				if (num != 0)
				{
				}
				num = (short)490012672;
				short num3 = num;
				return (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow)A_0.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.LastShownWindowOfOwnerElemenetProperty);
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x00042A74 File Offset: 0x00040C74
			private void SetLastShownWindowOfOwnerElemenet(global::System.Windows.FrameworkElement A_0, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow A_1)
			{
				short num = (short)1928389125;
				short num2 = num;
				num = (short)1218241029;
				switch (num2 == num)
				{
				}
				num = (short)689831936;
				short num3 = num;
				num = (short)1371602944;
				if (num != 0)
				{
				}
				num = (short)1101463553;
				if (num != 0)
				{
				}
				A_0.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.LastShownWindowOfOwnerElemenetProperty, A_1);
			}

			// Token: 0x0600040A RID: 1034 RVA: 0x00042B28 File Offset: 0x00040D28
			private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				bool flag;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_92;
					case 1:
					{
						num2 = (short)2046637417;
						short num3 = num2;
						num2 = (short)531707241;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15B;
						default:
						{
							num2 = (short)2006581249;
							if (num2 != 0)
							{
							}
							num2 = (short)657391616;
							short num4 = num2;
							num2 = (short)434307072;
							if (num2 != 0)
							{
							}
							num2 = (short)1510080516;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_172;
					case 3:
						if (!flag)
						{
							num2 = (short)1779433473;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.ApplicationIdle, new global::System.Action(this.a));
						num2 = (short)77135872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (!this.isHidden)
						{
							goto IL_15B;
						}
						return;
					}
					goto IL_24;
					IL_15B:
					num2 = (short)118620162;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_92:
				return;
				IL_172:
				this.p();
				return;
				IL_24:
				flag = (bool)A_1.NewValue;
				num2 = (short)99745795;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x0600040B RID: 1035 RVA: 0x00042CAC File Offset: 0x00040EAC
			private void c()
			{
				short num = (short)1445199873;
				if (num != 0)
				{
				}
				num = (short)502377665;
				short num2 = num;
				num = (short)1228254401;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1933901824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)106692608;
				if (num != 0)
				{
				}
				base.Closing -= this.InnerWindow_Closing;
				base.Closing += this.InnerWindow_Closing;
				base.SourceInitialized += this.InnerWindow_SourceInitialized;
				base.Activated += this.InnerWindow_Activated;
				base.Deactivated += this.InnerWindow_Deactivated;
				base.PreviewKeyDown += this.InnerWindow_PreviewKeyDown;
			}

			// Token: 0x0600040C RID: 1036 RVA: 0x00042DC0 File Offset: 0x00040FC0
			private void InnerWindow_PreviewKeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
			{
				short num = (short)1427439617;
				int num2 = (int)((global::System.IntPtr)num);
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
							goto IL_38;
						}
						continue;
					case 2:
						num = (short)333512705;
						if (num != 0)
						{
						}
						if (global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Control)
						{
							num = (short)1420165120;
							short num3 = num;
							num = (short)71696387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)952830337;
						short num4 = num;
						num = (short)1495730561;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)323223552;
							if (num != 0)
							{
							}
							this.a(true);
							num = (short)136904704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)1169489922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_38:
					if (A_1.Key != global::System.Windows.Input.Key.S)
					{
						break;
					}
					num = (short)888143876;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x0600040D RID: 1037 RVA: 0x00042F24 File Offset: 0x00041124
			private void InnerWindow_Deactivated(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)883752961;
				if (num != 0)
				{
				}
				num = (short)1564606465;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E6;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 2:
						this.a(false);
						num = (short)1863057408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5A:
					if (this.isHidden)
					{
						break;
					}
					num = (short)614087584;
					short num3 = num;
					num = (short)1986476960;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E8;
					default:
						num = (short)33030144;
						if (num != 0)
						{
						}
						num = (short)119144450;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_E6:
				IL_E8:
				num = (short)1748762624;
				short num4 = num;
			}

			// Token: 0x0600040E RID: 1038 RVA: 0x00043044 File Offset: 0x00041244
			private void InnerWindow_Activated(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1407582209;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_A2;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.d(this), false);
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(this);
						num = (short)304676864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30:
					num = (short)1619853313;
					if (num != 0)
					{
					}
					if (this.isHidden)
					{
						goto IL_EE;
					}
					num = (short)1056112642;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A2:
				num = (short)743438922;
				short num3 = num;
				num = (short)1120926282;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)37355520;
					if (num != 0)
					{
					}
					break;
				}
				IL_EE:
				num = (short)682819584;
				short num4 = num;
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x00043168 File Offset: 0x00041368
			private void InnerWindow_SourceInitialized(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1498022741;
				short num2 = num;
				num = (short)1561658197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)197394432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1883832321;
				if (num != 0)
				{
				}
				num = (short)2066415616;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.c(this);
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x06000410 RID: 1040 RVA: 0x0004321C File Offset: 0x0004141C
			// (set) Token: 0x06000411 RID: 1041 RVA: 0x000432D0 File Offset: 0x000414D0
			internal bool IsEnabledInner
			{
				get
				{
					short num = (short)1616787050;
					short num2 = num;
					num = (short)1424242282;
					switch (num2 == num)
					{
					default:
					{
						num = (short)973930496;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)24182784;
					if (num != 0)
					{
					}
					num = (short)2144272385;
					if (num != 0)
					{
					}
					return this.innerScrollViewer.IsEnabled;
				}
				set
				{
					short num = (short)1499804517;
					short num2 = num;
					num = (short)127021925;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1880358912;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)1646526465;
					if (num != 0)
					{
					}
					num = (short)738787328;
					if (num != 0)
					{
					}
					this.innerScrollViewer.IsEnabled = value;
				}
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x00043388 File Offset: 0x00041588
			private void InnerWindow_Closing(object A_0, global::System.ComponentModel.CancelEventArgs A_1)
			{
				short num = (short)1937469428;
				short num2 = num;
				num = (short)434597876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)950272000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)275185665;
				if (num != 0)
				{
				}
				num = (short)82575360;
				if (num != 0)
				{
				}
				A_1.Cancel = true;
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000413 RID: 1043 RVA: 0x0004343C File Offset: 0x0004163C
			internal bool IsShowScreenNow
			{
				get
				{
					if (!double.IsNaN(base.Left))
					{
						short num = (short)262841273;
						short num2 = num;
						num = (short)1175561145;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1792802817;
							if (num != 0)
							{
							}
							num = (short)462422016;
							if (num != 0)
							{
							}
							num = (short)522190848;
							short num3 = num;
							return base.Left < 10000.0;
						}
						}
					}
					return false;
				}
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x00043504 File Offset: 0x00041704
			internal void p()
			{
				short num = (short)502726660;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)102760449;
						if (num != 0)
						{
						}
						base.Visibility = global::System.Windows.Visibility.Hidden;
						base.Left = (base.Top = 10000.0);
						num = (short)1221245417;
						short num3 = num;
						num = (short)1039383017;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A4;
						default:
							num = (short)419430400;
							if (num != 0)
							{
							}
							num = (short)1734279171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						this.isHidden = true;
						this.a(false);
						num = (short)1251147776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_85;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 5:
						if (!this.isHidden)
						{
							goto IL_A4;
						}
						return;
					}
					IL_3D:
					if (this.IsShowScreenNow)
					{
						num = (short)1830354945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_85:
					num = (short)570425349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A4:
					num = (short)285605888;
					short num4 = num;
					num = (short)44105730;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x000436A8 File Offset: 0x000418A8
			private void a(bool A_0)
			{
				switch (0)
				{
				case 0:
					goto IL_38;
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
						return;
					case 1:
						goto IL_B6;
					case 2:
						if (uielement != null)
						{
							num2 = (short)171048964;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 3:
						if (A_0)
						{
							num2 = (short)564527109;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 4:
						uielement.Focus();
						goto IL_1AA;
					case 5:
					{
						num2 = (short)165368858;
						short num3 = num2;
						num2 = (short)622220314;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1AA;
						default:
							num2 = (short)1959329793;
							if (num2 != 0)
							{
							}
							num2 = (short)1004863488;
							if (num2 != 0)
							{
							}
							num2 = (short)1892745218;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 6:
						if (this.innerScrollViewer != null)
						{
							num2 = (short)1053294600;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B6;
					case 7:
						this.innerScrollViewer.Focus();
						num2 = (short)1811808257;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						num2 = (short)1816985609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						if (!this.innerScrollViewer.IsFocused)
						{
							num2 = (short)1412300807;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B6;
					}
					goto IL_38;
					IL_B6:
					num2 = (short)509542403;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1AA:
					num2 = (short)1228931072;
					short num4 = num2;
					num2 = (short)1741750272;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_38:
				uielement = (global::System.Windows.Input.FocusManager.GetFocusedElement(this) as global::System.Windows.UIElement);
				num2 = (short)118161414;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x000438CC File Offset: 0x00041ACC
			internal void a(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy A_0)
			{
				short num = (short)1280112406;
				short num2 = num;
				num = (short)670955286;
				switch (num2 == num)
				{
				default:
				{
					num = (short)221184000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)632750081;
				if (num != 0)
				{
				}
				num = (short)1178992640;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a(this);
				this.m();
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a(this, A_0);
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x00043988 File Offset: 0x00041B88
			internal void q()
			{
				short num = (short)1857592236;
				short num2 = num;
				num = (short)46570412;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1888092160;
					short num3 = num;
					break;
				}
				}
				num = (short)1362100224;
				if (num != 0)
				{
				}
				this.b(this.IsFirstTimeToShow);
				try
				{
					num = (short)1126170625;
					if (num != 0)
					{
					}
					base.Show();
					this.isHidden = false;
					this.timesOfShow++;
					this.SetLastShownWindowOfOwnerElemenet(this.ownerElement, this);
					base.Activate();
				}
				catch (global::System.Exception ex)
				{
					this.a(true, true);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a();
					throw ex;
				}
			}

			// Token: 0x06000418 RID: 1048 RVA: 0x00043A90 File Offset: 0x00041C90
			public new void Show()
			{
				short num = (short)1949758143;
				short num2 = num;
				num = (short)1818227391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)413335552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2099707904;
				if (num != 0)
				{
				}
				num = (short)655687681;
				if (num != 0)
				{
				}
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x00043B38 File Offset: 0x00041D38
			internal void r()
			{
				short num = (short)1659214503;
				short num2 = num;
				num = (short)870357671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)65273856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)566886401;
				if (num != 0)
				{
				}
				num = (short)715456512;
				if (num != 0)
				{
				}
				this.a(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy.b);
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x00043BE8 File Offset: 0x00041DE8
			internal void s()
			{
				short num = (short)7756742;
				short num2 = num;
				num = (short)1705663430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1381105664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758972417;
				if (num != 0)
				{
				}
				num = (short)2045837312;
				if (num != 0)
				{
				}
				this.a(false, false);
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x00043C9C File Offset: 0x00041E9C
			protected override void OnClosed(global::System.EventArgs e)
			{
				short num = (short)1930518664;
				short num2 = num;
				num = (short)505372808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1848180736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2090532864;
				if (num != 0)
				{
				}
				num = (short)1908408321;
				if (num != 0)
				{
				}
				this.b();
				base.OnClosed(e);
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x00043D50 File Offset: 0x00041F50
			internal void a(bool A_0, bool A_1)
			{
				short num = (short)413532163;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1590362113;
						if (num != 0)
						{
						}
						num = (short)672464900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a(this.key, null);
						num = (short)1083506690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_D7;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 4:
					{
						if (!A_1)
						{
							goto IL_7C;
						}
						num = (short)282900981;
						short num3 = num;
						num = (short)437041653;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15F;
						default:
							num = (short)1657274368;
							if (num != 0)
							{
							}
							num = (short)980615169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_39:
					if (!A_0)
					{
						goto IL_15F;
					}
					num = (short)1023410176;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7C:
				num = (short)718209024;
				short num4 = num;
				this.b();
				base.Close();
				return;
				IL_D7:
				goto IL_7C;
				IL_15F:
				this.p();
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x00043EC4 File Offset: 0x000420C4
			private void b()
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.Windows.Window window;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (window != null)
						{
							num2 = (short)1121517569;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1CA;
					case 1:
					{
						num2 = (short)1808599788;
						short num3 = num2;
						num2 = (short)280693484;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)2089549825;
							if (num2 != 0)
							{
							}
							num2 = (short)2097152000;
							if (num2 != 0)
							{
							}
							window.LocationChanged -= this.ParentWindow_LocationChanged;
							num2 = (short)1221001218;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_1C8;
					}
					goto IL_1C;
				}
				IL_1C8:
				IL_1CA:
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.b(this);
				return;
				IL_1C:
				base.Closing -= this.InnerWindow_Closing;
				this.ownerElement.LayoutUpdated -= this.OwerElement_LayoutUpdated;
				this.ownerElement.IsVisibleChanged -= this.a;
				this.ownerElement.IsEnabledChanged -= this.b;
				this.ownerElement.LayoutUpdated -= this.OwerElement_LayoutUpdated;
				base.Activated -= this.InnerWindow_Activated;
				base.Deactivated -= this.InnerWindow_Deactivated;
				base.PreviewKeyDown -= this.InnerWindow_PreviewKeyDown;
				window = global::System.Windows.Window.GetWindow(this.ownerElement);
				num2 = (short)1572012032;
				short num4 = num2;
				num2 = (short)1805320192;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x000440A4 File Offset: 0x000422A4
			// Note: this type is marked as 'beforefieldinit'.
			static InnerWindow()
			{
				int a_ = 2;
				short num = (short)1998480117;
				short num2 = num;
				num = (short)861037301;
				switch (num2 == num)
				{
				}
				num = (short)1519648768;
				short num3 = num;
				num = (short)1705836545;
				if (num != 0)
				{
				}
				num = (short)1599733760;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.LastShownWindowOfOwnerElemenetProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횙ﶛ풟첣즥\udfa7쒩ﮫ잭\udeaf횱\udbb3솵\udcb9즽꺿ꟁ뛃菅꓇꿉ꇋꯍ뻏럑ꃓ", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow), typeof(global::System.Windows.FrameworkElement), new global::System.Windows.PropertyMetadata(null));
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x0004418C File Offset: 0x0004238C
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private void a()
			{
				short num = (short)192610304;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 1:
					{
						num = (short)624144796;
						short num3 = num;
						num = (short)1568125340;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1750401024;
							if (num != 0)
							{
							}
							num = (short)103153664;
							short num4 = num;
							break;
						}
						}
						this.r();
						num = (short)1930297346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_F4;
					}
					IL_32:
					if (!this.Equals(this.GetLastShownWindowOfOwnerElemenet(this.ownerElement)))
					{
						return;
					}
					num = (short)1116209153;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F4:
				num = (short)970850305;
				if (num != 0)
				{
				}
			}

			// Token: 0x04000152 RID: 338
			private global::System.Windows.FrameworkElement ownerElement;

			// Token: 0x04000153 RID: 339
			private global::System.Windows.DependencyObject innerContent;

			// Token: 0x04000154 RID: 340
			private global::System.Windows.Controls.ScrollViewer innerScrollViewer;

			// Token: 0x04000155 RID: 341
			private bool isHidden;

			// Token: 0x04000156 RID: 342
			private string key;

			// Token: 0x04000157 RID: 343
			private int timesOfShow;

			// Token: 0x04000158 RID: 344
			private static global::System.Windows.DependencyProperty LastShownWindowOfOwnerElemenetProperty;

			// Token: 0x04000159 RID: 345
			private const double XYToHideWindow = 10000.0;

			// Token: 0x020000A2 RID: 162
			private static class ShowQueueManger
			{
				// Token: 0x06000420 RID: 1056 RVA: 0x000442B8 File Offset: 0x000424B8
				static ShowQueueManger()
				{
					short num = (short)1295479064;
					short num2 = num;
					num = (short)807891224;
					switch (num2 == num)
					{
					}
					num = (short)2099118080;
					short num3 = num;
					num = (short)418054144;
					if (num != 0)
					{
					}
					num = (short)1778712577;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>>();
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a();
				}

				// Token: 0x06000421 RID: 1057 RVA: 0x00044370 File Offset: 0x00042570
				internal static void a()
				{
					short num = (short)1643577346;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							IL_188:
							num = (short)342491137;
							if (num != 0)
							{
							}
							goto IL_C6;
						case 1:
							goto IL_C1;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3E;
							}
							continue;
						case 3:
							if (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c != null)
							{
								num = (short)61931524;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B4;
						case 4:
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c.Stop();
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c.Tick -= global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b;
							num = (short)1766588417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b.Stop();
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b.Tick -= global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a;
							num = (short)1248002048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3E:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b != null)
						{
							num = (short)245694464;
							short num3 = num;
							num = (short)372506629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_C6:
						num = (short)266271237;
						short num4 = num;
						num = (short)1196751365;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_188;
						default:
							num = (short)1005453312;
							if (num != 0)
							{
							}
							num = (short)1901199363;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_C1:
					IL_1B4:
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.ContextIdle);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.ApplicationIdle);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b.Interval = new global::System.TimeSpan(0, 0, 0, 0, 10);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b.Tick += global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a;
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c.Interval = new global::System.TimeSpan(0, 0, 0, 0, 10);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c.Tick += global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b;
				}

				// Token: 0x06000422 RID: 1058 RVA: 0x000445A0 File Offset: 0x000427A0
				private static void b(object A_0, global::System.EventArgs A_1)
				{
					short num = (short)941096964;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>> list;
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>>.Enumerator enumerator = list.GetEnumerator();
							num = (short)1166278657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							try
							{
								num = (short)1446903812;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)952238082;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy> item = enumerator.Current;
										global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a.Remove(item);
										num = (short)2004615171;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_16F;
									case 2:
										num = (short)1914175489;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_154;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_A6;
										}
										continue;
									}
									goto IL_A6;
									IL_F3:
									num = (short)1229324288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_154:
									goto IL_F3;
									IL_A6:
									num = (short)421902868;
									short num3 = num;
									num = (short)288471572;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_154;
									default:
										num = (short)1518927872;
										if (num != 0)
										{
										}
										goto IL_F3;
									}
								}
								IL_16F:
								goto IL_230;
							}
							finally
							{
								global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_182;
						case 2:
							if (list != null)
							{
								num = (short)1227161600;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_230;
						case 3:
							if (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a.Count != 0)
							{
								num = (short)1425145856;
								short num4 = num;
								num = (short)2034958342;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_46;
							}
							continue;
						case 5:
							return;
						case 6:
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b.IsEnabled = true;
							num = (short)1720844293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_69;
						}
						IL_46:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b.IsEnabled)
						{
							num = (short)1578893319;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_182:
						num = (short)625147905;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c.Stop();
						list = (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c.Tag as global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>>);
						num = (short)515112962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_230:
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c.Tag = null;
						num = (short)1692794883;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_69:
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b.IsEnabled = false;
				}

				// Token: 0x06000423 RID: 1059 RVA: 0x00044894 File Offset: 0x00042A94
				private static void a(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>> A_0)
				{
					short num = (short)958245265;
					short num2 = num;
					num = (short)1018538385;
					switch (num2 == num)
					{
					default:
					{
						num = (short)1262157824;
						short num3 = num;
						break;
					}
					case true:
						break;
					}
					num = (short)856621057;
					if (num != 0)
					{
					}
					num = (short)918552576;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c.Tag = A_0;
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.c.Start();
				}

				// Token: 0x06000424 RID: 1060 RVA: 0x00044954 File Offset: 0x00042B54
				private static void a(object A_0, global::System.EventArgs A_1)
				{
					short num = (short)268042240;
					switch (num)
					{
					default:
					{
						num = (short)1708523524;
						int num2 = (int)((global::System.IntPtr)num);
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>> list;
						for (;;)
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow key;
							int num5;
							switch (num2)
							{
							case 0:
								goto IL_184;
							case 1:
							{
								num = (short)427755862;
								short num3 = num;
								num = (short)1736116566;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_21C;
								default:
								{
									num = (short)1893662720;
									if (num != 0)
									{
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy> keyValuePair;
									key = keyValuePair.Key;
									num = (short)806027276;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 2:
								goto IL_11D;
							case 3:
								num = (short)1902116865;
								if (num != 0)
								{
								}
								goto IL_21C;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_89;
								}
								continue;
							case 5:
								num = (short)278659080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_2A7;
							case 7:
								goto IL_243;
							case 8:
								if (!key.IsShowScreenNow)
								{
									num = (short)814088203;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_38B;
							case 9:
							{
								num = (short)1045823488;
								short num4 = num;
								if (num5 < 0)
								{
									num = (short)1823866887;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy> keyValuePair = list[num5];
								num = (short)1088159759;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
								if (key.ownerElement.IsLoaded)
								{
									num = (short)88080398;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_38B;
							case 11:
								key.q();
								num = (short)1812332550;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								goto IL_243;
							case 13:
								goto IL_11D;
							case 14:
								num = (short)355926032;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
							{
								global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy> keyValuePair;
								if (keyValuePair.Value != global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy.c)
								{
									num = (short)1946615809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num5--;
								num = (short)2293773;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 16:
								if (key.ownerElement.IsVisible)
								{
									num = (short)1313603589;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_38B;
							}
							IL_89:
							if (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a.Count == 0)
							{
								num = (short)1759641603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_184;
							IL_11D:
							num = (short)381681673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_184:
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>> source = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a.ToList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>>();
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow key2 = source.Last<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>>().Key;
							list = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a(key2);
							key = list.Last<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>>().Key;
							num5 = list.Count - 1;
							num = (short)243859458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_21C:
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b.Stop();
							num = (short)1173291008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_243:
							num = (short)271515658;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2A7:
						IL_38B:
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a(list);
						return;
					}
					}
				}

				// Token: 0x06000425 RID: 1061 RVA: 0x00044CF4 File Offset: 0x00042EF4
				private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>> a(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow A_0)
				{
					short num = (short)1528294783;
					short num2 = num;
					num = (short)1152052607;
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>> list;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)158400512;
						if (num != 0)
						{
						}
						list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>>();
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a.GetEnumerator();
						try
						{
							num = (short)430964739;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_162;
								case 1:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy> item;
									list.Add(item);
									num = (short)337575942;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy> item;
									if (item.Key.ownerElement.Equals(A_0.ownerElement))
									{
										num = (short)970850305;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_9F;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2031091717;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy> item = enumerator.Current;
									num = (short)1860632578;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)823656448;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_ED:
								num = (short)174063620;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_9F:
								goto IL_ED;
							}
							IL_162:;
						}
						finally
						{
							num = (short)1881341953;
							if (num != 0)
							{
							}
							((global::System.IDisposable)enumerator).Dispose();
						}
						break;
					}
					}
					num = (short)2072248320;
					short num4 = num;
					return list;
				}

				// Token: 0x06000426 RID: 1062 RVA: 0x00044EE0 File Offset: 0x000430E0
				public static void a(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow A_0, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy A_1)
				{
					short num = (short)1329079607;
					short num2 = num;
					num = (short)649995575;
					switch (num2 == num)
					{
					}
					num = (short)1877409792;
					if (num != 0)
					{
					}
					num = (short)849870849;
					if (num != 0)
					{
					}
					num = (short)1832124416;
					short num3 = num;
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.a.Add(new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>(A_0, A_1));
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowQueueManger.b.Start();
				}

				// Token: 0x0400015A RID: 346
				private static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow.ShowInvokedBy>> a;

				// Token: 0x0400015B RID: 347
				private static global::System.Windows.Threading.DispatcherTimer b;

				// Token: 0x0400015C RID: 348
				private static global::System.Windows.Threading.DispatcherTimer c;
			}

			// Token: 0x020000A3 RID: 163
			internal enum ShowInvokedBy
			{
				// Token: 0x0400015E RID: 350
				a,
				// Token: 0x0400015F RID: 351
				b,
				// Token: 0x04000160 RID: 352
				c
			}
		}

		// Token: 0x020000A6 RID: 166
		private static class NativeMethods
		{
			// Token: 0x0600042D RID: 1069
			[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
			public static extern uint GetWindowThreadProcessId(global::System.IntPtr A_0, out uint A_1);

			// Token: 0x0600042E RID: 1070
			[global::System.Runtime.InteropServices.DllImport("user32.dll")]
			private static extern global::System.IntPtr DefWindowProc(global::System.IntPtr A_0, uint A_1, global::System.IntPtr A_2, global::System.IntPtr A_3);

			// Token: 0x0600042F RID: 1071
			[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
			internal static extern bool SetWindowPos(global::System.IntPtr A_0, global::System.IntPtr A_1, int A_2, int A_3, int A_4, int A_5, uint A_6);

			// Token: 0x06000430 RID: 1072
			[global::System.Runtime.InteropServices.DllImport("User32")]
			private static extern global::System.IntPtr GetTopWindow(global::System.IntPtr A_0);

			// Token: 0x06000431 RID: 1073
			[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
			private static extern global::System.IntPtr GetWindow(global::System.IntPtr A_0, uint A_1);

			// Token: 0x06000432 RID: 1074
			[global::System.Runtime.InteropServices.DllImport("user32.dll")]
			internal static extern global::System.IntPtr GetForegroundWindow();

			// Token: 0x06000433 RID: 1075 RVA: 0x0004529C File Offset: 0x0004349C
			private static global::System.IntPtr e(global::System.IntPtr A_0)
			{
				short num = (short)734560083;
				short num2 = num;
				num = (short)846495571;
				switch (num2 == num)
				{
				}
				num = (short)139067392;
				if (num != 0)
				{
				}
				num = (short)692649985;
				if (num != 0)
				{
				}
				num = (short)362741760;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.GetWindow(A_0, 2U);
			}

			// Token: 0x06000434 RID: 1076
			[global::System.Runtime.InteropServices.DllImport("user32.dll")]
			[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
			private static extern bool SetForegroundWindow(global::System.IntPtr A_0);

			// Token: 0x06000435 RID: 1077
			[global::System.Runtime.InteropServices.DllImport("user32.dll")]
			private static extern global::System.IntPtr SetWinEventHook(uint A_0, uint A_1, global::System.IntPtr A_2, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.WinEventDelegate A_3, uint A_4, uint A_5, uint A_6);

			// Token: 0x06000436 RID: 1078
			[global::System.Runtime.InteropServices.DllImport("user32.dll")]
			private static extern bool UnhookWinEvent(global::System.IntPtr A_0);

			// Token: 0x06000437 RID: 1079
			[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetWindowLong")]
			private static extern global::System.IntPtr c(global::System.IntPtr A_0, int A_1);

			// Token: 0x06000438 RID: 1080
			[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
			private static extern global::System.IntPtr b(global::System.IntPtr A_0, int A_1);

			// Token: 0x06000439 RID: 1081 RVA: 0x0004534C File Offset: 0x0004354C
			public static global::System.IntPtr a(global::System.IntPtr A_0, int A_1)
			{
				short num = (short)23187739;
				short num2 = num;
				num = (short)1358614811;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)302776321;
					if (num != 0)
					{
					}
					num = (short)2098921472;
					if (num != 0)
					{
					}
					if (global::System.IntPtr.Size != 8)
					{
						num = (short)1346895872;
						short num3 = num;
						return global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.c(A_0, A_1);
					}
					break;
				}
				return global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.b(A_0, A_1);
			}

			// Token: 0x0600043A RID: 1082
			[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowLong")]
			private static extern int a(global::System.Runtime.InteropServices.HandleRef A_0, int A_1, int A_2);

			// Token: 0x0600043B RID: 1083
			[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
			private static extern global::System.IntPtr b(global::System.Runtime.InteropServices.HandleRef A_0, int A_1, global::System.IntPtr A_2);

			// Token: 0x0600043C RID: 1084 RVA: 0x00045410 File Offset: 0x00043610
			public static global::System.IntPtr a(global::System.Runtime.InteropServices.HandleRef A_0, int A_1, global::System.IntPtr A_2)
			{
				short num = (short)1839036982;
				short num2 = num;
				num = (short)1871411766;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)73203712;
					if (num != 0)
					{
					}
					num = (short)643629057;
					if (num != 0)
					{
					}
					if (global::System.IntPtr.Size != 8)
					{
						num = (short)547815424;
						short num3 = num;
						return new global::System.IntPtr(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(A_0, A_1, A_2.ToInt32()));
					}
					break;
				}
				return global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.b(A_0, A_1, A_2);
			}

			// Token: 0x0600043D RID: 1085
			[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
			private static extern bool BringWindowToTop(global::System.IntPtr A_0);

			// Token: 0x0600043E RID: 1086
			[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "SystemParametersInfo")]
			public static extern int a(int A_0, int A_1, out int A_2, int A_3);

			// Token: 0x0600043F RID: 1087
			[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "SystemParametersInfo")]
			public static extern int a(int A_0, int A_1, int A_2, int A_3);

			// Token: 0x06000440 RID: 1088
			[global::System.Runtime.InteropServices.DllImport("kernel32.dll")]
			private static extern global::System.IntPtr GetStdHandle(uint A_0);

			// Token: 0x06000441 RID: 1089
			[global::System.Runtime.InteropServices.DllImport("kernel32.dll")]
			private static extern void SetStdHandle(uint A_0, global::System.IntPtr A_1);

			// Token: 0x06000442 RID: 1090
			[global::System.Runtime.InteropServices.DllImport("kernel32")]
			private static extern bool AllocConsole();

			// Token: 0x06000443 RID: 1091 RVA: 0x000454E0 File Offset: 0x000436E0
			public static void h(global::System.Windows.Window A_0)
			{
				short num = (short)788135937;
				if (num != 0)
				{
				}
				num = (short)137753931;
				short num2 = num;
				num = (short)758969675;
				switch (num2 == num)
				{
				}
				num = (short)560791552;
				if (num != 0)
				{
				}
				num = (short)965869568;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.<>c__DisplayClass51_0 CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.<>c__DisplayClass51_0();
				CS$<>8__locals1.a = A_0;
				CS$<>8__locals1.a.Loaded += CS$<>8__locals1.b;
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x000455B0 File Offset: 0x000437B0
			public static void g(global::System.Windows.Window A_0)
			{
				short num = (short)60785425;
				short num2 = num;
				num = (short)1255441169;
				switch (num2 == num)
				{
				}
				num = (short)1206714369;
				if (num != 0)
				{
				}
				num = (short)1300168704;
				if (num != 0)
				{
				}
				num = (short)1348534272;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.<>c__DisplayClass52_0 CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.<>c__DisplayClass52_0();
				CS$<>8__locals1.a = A_0;
				CS$<>8__locals1.a.SourceInitialized += CS$<>8__locals1.b;
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x0004567C File Offset: 0x0004387C
			public static void d()
			{
				short num = (short)1780248816;
				short num2 = num;
				num = (short)1163686128;
				switch (num2 == num)
				{
				}
				num = (short)2019622912;
				if (num != 0)
				{
				}
				num = (short)2042298369;
				if (num != 0)
				{
				}
				num = (short)1463746560;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(37, 0, 0, 0);
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x00045730 File Offset: 0x00043930
			public static void c()
			{
				short num = (short)1377514445;
				short num2 = num;
				num = (short)1697395661;
				switch (num2 == num)
				{
				}
				num = (short)1932132352;
				if (num != 0)
				{
				}
				num = (short)1947533313;
				if (num != 0)
				{
				}
				num = (short)142082048;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(37, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.z ? 1 : 0, 0, 0);
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x000457F4 File Offset: 0x000439F4
			private static bool b()
			{
				short num = (short)1492938322;
				short num2 = num;
				num = (short)1276931666;
				switch (num2 == num)
				{
				}
				num = (short)56229888;
				if (num != 0)
				{
				}
				num = (short)1892810753;
				if (num != 0)
				{
				}
				num = (short)2025848832;
				short num3 = num;
				global::System.IntPtr foregroundWindow = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.GetForegroundWindow();
				uint num4 = 0U;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.GetWindowThreadProcessId(foregroundWindow, out num4);
				return num4.Equals((uint)global::System.Diagnostics.Process.GetCurrentProcess().Id);
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x000458C0 File Offset: 0x00043AC0
			public static void f(global::System.Windows.Window A_0)
			{
				int num;
				short num2;
				global::System.Windows.Interop.HwndSource hwndSource;
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
						{
							num2 = (short)573833217;
							if (num2 != 0)
							{
							}
							num2 = (short)800456704;
							short num3 = num2;
							if (hwndSource != null)
							{
								num2 = (short)1950613505;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						case 1:
							hwndSource.AddHook(new global::System.Windows.Interop.HwndSourceHook(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.b));
							num2 = (short)1943339010;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							goto IL_D6;
						}
						goto IL_1C;
					}
					IL_D6:
					num2 = (short)278781152;
					short num4 = num2;
					num2 = (short)1206836448;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_28;
					default:
						num2 = (short)41025536;
						if (num2 != 0)
						{
						}
						break;
					}
					return;
				}
				}
				IL_1C:
				hwndSource = (global::System.Windows.PresentationSource.FromVisual(A_0) as global::System.Windows.Interop.HwndSource);
				IL_28:
				num2 = (short)1187315712;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x000459F4 File Offset: 0x00043BF4
			public static void e(global::System.Windows.Window A_0)
			{
				int num;
				global::System.Windows.Interop.HwndSource hwndSource;
				short num2;
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
							if (hwndSource != null)
							{
								num2 = (short)682950656;
								short num3 = num2;
								num2 = (short)8847361;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						case 1:
							hwndSource.RemoveHook(new global::System.Windows.Interop.HwndSourceHook(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.b));
							num2 = (short)1375076354;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							goto IL_AB;
						}
						goto IL_1C;
					}
					IL_AB:
					num2 = (short)618898995;
					short num4 = num2;
					num2 = (short)1271965235;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_28;
					default:
						num2 = (short)145555457;
						if (num2 != 0)
						{
						}
						num2 = (short)1805385728;
						if (num2 != 0)
						{
						}
						break;
					}
					return;
				}
				}
				IL_1C:
				hwndSource = (global::System.Windows.PresentationSource.FromVisual(A_0) as global::System.Windows.Interop.HwndSource);
				IL_28:
				num2 = (short)237043712;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x00045B20 File Offset: 0x00043D20
			private static global::System.IntPtr b(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, global::System.IntPtr A_3, ref bool A_4)
			{
				short num;
				int num2;
				global::System.IntPtr result;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_0A:
						num = (short)291897345;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							num = (short)169803776;
							short num3 = num;
							if (A_1 == 134)
							{
								num = (short)2062548993;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 1:
							result = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.DefWindowProc(A_0, 134U, new global::System.IntPtr(1), new global::System.IntPtr(-1));
							A_4 = true;
							num = (short)1790181378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_DE;
						}
						goto IL_43;
					}
					IL_DE:
					num = (short)1788370371;
					short num4 = num;
					num = (short)576085443;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_49;
					default:
						num = (short)1735262208;
						if (num != 0)
						{
						}
						break;
					}
					return result;
				}
				}
				IL_43:
				result = global::System.IntPtr.Zero;
				IL_49:
				num = (short)2060386304;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x00045C5C File Offset: 0x00043E5C
			internal static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>> d(global::System.Windows.Window A_0)
			{
				short num = (short)955121665;
				if (num != 0)
				{
				}
				num = (short)1837826048;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_78;
					}
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>> list;
					global::System.Collections.IEnumerator enumerator2;
					global::System.Collections.Generic.List<global::System.Windows.Window> list2;
					for (;;)
					{
						IL_4D:
						global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Windows.Window> dictionary;
						global::System.Collections.Generic.List<global::System.Windows.Window>.Enumerator enumerator;
						global::System.IntPtr intPtr;
						switch (num2)
						{
						case 0:
							goto IL_3AC;
						case 1:
							try
							{
								num = (short)1629880323;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_4C2;
									case 1:
									{
										global::System.Windows.Interop.HwndSource hwndSource;
										global::System.Windows.Window window;
										dictionary.Add(hwndSource.Handle, window);
										num = (short)705953796;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::System.Windows.Interop.HwndSource hwndSource;
										if (hwndSource != null)
										{
											num = (short)279838721;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_3F3;
										}
										continue;
									case 5:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)710868998;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Window window = enumerator.Current;
										global::System.Windows.PresentationSource presentationSource = global::System.Windows.PresentationSource.FromVisual(window);
										global::System.Windows.Interop.HwndSource hwndSource = presentationSource as global::System.Windows.Interop.HwndSource;
										num = (short)1710358530;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										num = (short)215089152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_46A:
									num = (short)1360199685;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_3F3:
									goto IL_46A;
								}
								IL_4C2:
								goto IL_151;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_4D5;
							IL_151:
							list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>>();
							intPtr = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.GetTopWindow(global::System.IntPtr.Zero);
							num = (short)1722351620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)1191247875;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2AC;
									case 1:
										num = (short)664666112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)1786511361;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Window window2 = (global::System.Windows.Window)enumerator2.Current;
										num = (short)1755185156;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_1E9;
										}
										continue;
									case 4:
									{
										global::System.Windows.Window window2;
										if (!(window2 is global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow))
										{
											num = (short)1451491333;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
									{
										global::System.Windows.Window window2;
										list2.Add(window2);
										num = (short)1009909766;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1EB:
									num = (short)1838415874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1E9:
									goto IL_1EB;
								}
								IL_2AC:
								goto IL_4D5;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_2CE;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_2BB:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1113063425;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_328;
									case 1:
										disposable.Dispose();
										num = (short)283508738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_326;
									}
									goto IL_2CE;
								}
								IL_326:
								IL_328:
								goto EndFinally_12;
								IL_2CE:
								disposable = (enumerator2 as global::System.IDisposable);
								num = (short)726532096;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_2BB;
								EndFinally_12:;
							}
							goto IL_329;
						case 3:
							goto IL_36C;
						case 4:
							goto IL_36C;
						case 5:
						{
							num = (short)1920106657;
							short num3 = num;
							num = (short)513573025;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_C2;
							default:
							{
								num = (short)770506752;
								short num4 = num;
								num = (short)1142947840;
								if (num != 0)
								{
								}
								goto IL_181;
							}
							}
							break;
						}
						case 6:
							if (dictionary.ContainsKey(intPtr))
							{
								num = (short)229113863;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_181;
						case 7:
							list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>(intPtr, dictionary[intPtr]));
							goto IL_C2;
						case 8:
							if (!(intPtr != global::System.IntPtr.Zero))
							{
								num = (short)1886388224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_329;
						}
						goto IL_78;
						IL_C2:
						num = (short)304742405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_181:
						intPtr = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.e(intPtr);
						num = (short)581173251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_329:
						num = (short)987758598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_36C:
						num = (short)1085276168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4D5:
						dictionary = new global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Windows.Window>();
						enumerator = list2.GetEnumerator();
						num = (short)634060801;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3AC:
					list.Reverse();
					return list;
					IL_78:
					global::System.Windows.Window owner = A_0.Owner;
					list2 = new global::System.Collections.Generic.List<global::System.Windows.Window>();
					enumerator2 = owner.OwnedWindows.GetEnumerator();
					num = (short)535953410;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4D;
				}
				}
			}

			// Token: 0x0600044C RID: 1100 RVA: 0x000461A4 File Offset: 0x000443A4
			public static void c(global::System.Windows.Window A_0)
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				int num2;
				for (;;)
				{
					IL_0A:
					num = (short)1782317057;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Interop.HwndSource hwndSource;
						hwndSource.RemoveHook(new global::System.Windows.Interop.HwndSourceHook(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a));
						hwndSource.AddHook(new global::System.Windows.Interop.HwndSourceHook(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a));
						num = (short)1638203393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
					{
						num = (short)1323499520;
						short num3 = num;
						global::System.Windows.Interop.HwndSource hwndSource;
						if (hwndSource != null)
						{
							num = (short)1281163264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					goto IL_43;
				}
				return;
				for (;;)
				{
					IL_43:
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>> a_ = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.d(A_0);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(a_, true);
					global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.PresentationSource.FromVisual(A_0) as global::System.Windows.Interop.HwndSource;
					num = (short)964659034;
					short num4 = num;
					num = (short)173442906;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_92;
					}
				}
				IL_92:
				num = (short)1902379008;
				if (num != 0)
				{
				}
				num = (short)947060738;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x000462F4 File Offset: 0x000444F4
			public static void b(global::System.Windows.Window A_0)
			{
				short num = (short)1038417921;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num2;
				for (;;)
				{
					IL_33:
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Interop.HwndSource hwndSource;
						hwndSource.RemoveHook(new global::System.Windows.Interop.HwndSourceHook(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a));
						num = (short)737673217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
					{
						num = (short)949354496;
						short num3 = num;
						global::System.Windows.Interop.HwndSource hwndSource;
						if (hwndSource != null)
						{
							num = (short)542900224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					goto IL_45;
				}
				return;
				for (;;)
				{
					IL_45:
					global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.PresentationSource.FromVisual(A_0) as global::System.Windows.Interop.HwndSource;
					num = (short)1033570199;
					short num4 = num;
					num = (short)1504577431;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_85;
					}
				}
				IL_85:
				num = (short)742522880;
				if (num != 0)
				{
				}
				num = (short)305790978;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x00046424 File Offset: 0x00044624
			static NativeMethods()
			{
				short num = (short)847773697;
				if (num != 0)
				{
				}
				num = (short)685093557;
				short num2 = num;
				num = (short)1809953461;
				switch (num2 == num)
				{
				}
				num = (short)1689518080;
				if (num != 0)
				{
				}
				num = (short)2115174400;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.aa = new global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.WinEventDelegate(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a);
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ab = global::System.IntPtr.Zero;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ac = new global::System.Collections.Generic.List<global::System.IntPtr>();
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ad = false;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ae = false;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a();
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ab = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.SetWinEventHook(3U, 3U, global::System.IntPtr.Zero, global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.aa, 0U, 0U, 2U);
				global::System.Windows.Application.Current.Exit += global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a;
				int num4;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(38, 0, out num4, 0);
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.z = (num4 != 0);
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x00046544 File Offset: 0x00044744
			private static void a(object A_0, global::System.Windows.ExitEventArgs A_1)
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
						num2 = (short)1368719361;
						if (num2 != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.UnhookWinEvent(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ab);
						num2 = (short)281608193;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return;
					case 2:
					{
						global::System.IntPtr zero;
						if (!zero.Equals(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ab))
						{
							num2 = (short)1131544576;
							short num3 = num2;
							num2 = (short)1604583424;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					goto IL_1C;
				}
				return;
				for (;;)
				{
					IL_1C:
					global::System.IntPtr zero = global::System.IntPtr.Zero;
					num2 = (short)1869590484;
					short num4 = num2;
					num2 = (short)478392276;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_56;
					}
				}
				IL_56:
				num2 = (short)1846738944;
				if (num2 != 0)
				{
				}
				num2 = (short)1462960130;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x00046674 File Offset: 0x00044874
			internal static void a()
			{
				short num = (short)1021523614;
				short num2 = num;
				num = (short)771241630;
				switch (num2 == num)
				{
				}
				num = (short)48824320;
				if (num != 0)
				{
				}
				num = (short)1581907969;
				if (num != 0)
				{
				}
				num = (short)1012137984;
				short num3 = num;
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x00046720 File Offset: 0x00044920
			private static void a(global::System.IntPtr A_0, uint A_1, global::System.IntPtr A_2, int A_3, int A_4, uint A_5, uint A_6)
			{
				short num = (short)1592655873;
				if (num != 0)
				{
				}
				num = (short)2143967324;
				short num2 = num;
				num = (short)186472540;
				switch (num2 == num)
				{
				}
				num = (short)1159397376;
				if (num != 0)
				{
				}
				num = (short)1118437376;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.b(A_2);
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x000467D0 File Offset: 0x000449D0
			internal static global::System.Windows.Window d(global::System.IntPtr A_0)
			{
				short num = (short)1735262211;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Interop.HwndSource hwndSource;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10C;
					case 1:
						if (hwndSource != null)
						{
							num = (short)49414144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13D;
					case 2:
						goto IL_7A;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_36;
						}
						continue;
					}
					IL_36:
					num = (short)1976303617;
					if (num != 0)
					{
					}
					if (A_0.ToInt32() == 0)
					{
						num = (short)1721696258;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1511153952;
						short num3 = num;
						num = (short)1600545056;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)317980672;
							if (num != 0)
							{
							}
							hwndSource = global::System.Windows.Interop.HwndSource.FromHwnd(A_0);
							break;
						}
						num = (short)1159331841;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_7A:
				return null;
				IL_10C:
				num = (short)669581312;
				short num4 = num;
				return hwndSource.RootVisual as global::System.Windows.Window;
				IL_13D:
				return null;
			}

			// Token: 0x06000453 RID: 1107 RVA: 0x0004691C File Offset: 0x00044B1C
			internal static global::System.IntPtr a(global::System.Windows.Window A_0)
			{
				short num = (short)1638105361;
				short num2 = num;
				num = (short)112886033;
				switch (num2 == num)
				{
				}
				num = (short)953155585;
				if (num != 0)
				{
				}
				num = (short)1512505344;
				if (num != 0)
				{
				}
				num = (short)1378222080;
				short num3 = num;
				global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(A_0);
				windowInteropHelper.EnsureHandle();
				return windowInteropHelper.Handle;
			}

			// Token: 0x06000454 RID: 1108 RVA: 0x000469D8 File Offset: 0x00044BD8
			private static global::System.IntPtr a(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, global::System.IntPtr A_3, ref bool A_4)
			{
				int a_ = 6;
				short num = (short)1304887296;
				switch (num)
				{
				default:
				{
					num = (short)323026953;
					int num2 = (int)((global::System.IntPtr)num);
					global::System.IntPtr foregroundWindow;
					for (;;)
					{
						global::System.Windows.Window window;
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>> list;
						bool flag;
						bool flag2;
						switch (num2)
						{
						case 0:
							if (((global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow)window).IsHidden)
							{
								num = (short)1490157590;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_298;
						case 1:
							if (!foregroundWindow.Equals(A_0))
							{
								num = (short)744751106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_492;
						case 2:
							num = (short)238092292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (!global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ae)
							{
								num = (short)1981349905;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_492;
						case 4:
						{
							if (A_1 != 70)
							{
								goto IL_492;
							}
							num = (short)603870121;
							short num3 = num;
							num = (short)1606439849;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_326;
							default:
								num = (short)713621504;
								if (num != 0)
								{
								}
								num = (short)1746796565;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(list, true);
							num = (short)1020657674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							flag = false;
							goto IL_3F5;
						case 7:
						{
							global::System.Windows.Window window2;
							flag = window2.GetType().FullName.Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힝캟쒡횣장쾧쎩\udfab\udaad\ud9af톱잳颵펹튻\udabd꾿뗁럃诇ꗉꋋ뫍ꋏ뷑룓ꗕ軙돛뇝賟뗡跣裥賧藩鯫ꛭ鿯臱胳ꇵ釷铹飻釽矿", a_));
							goto IL_3F5;
						}
						case 8:
							if (flag2)
							{
								num = (short)780468243;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)955187201;
							if (num != 0)
							{
							}
							num = (short)415170575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							switch (0)
							{
							case 0:
								goto IL_AF;
							}
							continue;
						case 10:
							goto IL_474;
						case 11:
						{
							global::System.Windows.Window window2;
							if (window2 != null)
							{
								num = (short)654180364;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)641400838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)359923719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_326;
						case 14:
							num = (short)1868431363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (!flag2)
							{
								num = (short)1213071365;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_474;
						case 16:
							goto IL_490;
						case 17:
							num = (short)1374683137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (window is global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow)
							{
								num = (short)871563277;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_298;
						case 19:
							goto IL_42E;
						case 20:
							if (list.Count != 0)
							{
								num = (short)494993422;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_492;
						case 21:
						{
							num = (short)758906880;
							short num4 = num;
							global::System.Windows.Window window2 = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.d(foregroundWindow);
							num = (short)29229067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
							return A_0;
						case 23:
							return A_0;
						}
						IL_AF:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ad)
						{
							num = (short)367984663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						window = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.d(A_0);
						num = (short)529334290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_298:
						list = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.d(window);
						foregroundWindow = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.GetForegroundWindow();
						num = (short)590479380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_326:
						num = (short)1420623872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3F5:
						flag2 = flag;
						num = (short)1176961032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_474:
						A_4 = true;
						num = (short)814022672;
						num2 = (int)((global::System.IntPtr)num);
					}
					return A_0;
					IL_42E:
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ad = true;
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.SetWindowPos(foregroundWindow, new global::System.IntPtr(-2), 0, 0, 0, 0, 1043U);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(foregroundWindow);
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ad = false;
					A_4 = true;
					return global::System.IntPtr.Zero;
					IL_490:
					IL_492:
					return global::System.IntPtr.Zero;
				}
				}
			}

			// Token: 0x06000455 RID: 1109 RVA: 0x00046E7C File Offset: 0x0004507C
			internal static void a(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>> A_0, bool A_1)
			{
				short num = (short)289603584;
				switch (num)
				{
				default:
				{
					num = (short)1768030219;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>>.Enumerator enumerator;
						bool flag;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1570766854;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_481;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1205338115;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window> keyValuePair = enumerator.Current;
										global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.SetWindowPos(keyValuePair.Key, new global::System.IntPtr(-1), 0, 0, 0, 0, 1043U);
										num = (short)22740994;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window> keyValuePair;
										if (!global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ac.Contains(keyValuePair.Key))
										{
											num = (short)1428553733;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										num = (short)487260160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window> keyValuePair;
										global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ac.Add(keyValuePair.Key);
										num = (short)237699076;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_394;
										}
										continue;
									}
									IL_42B:
									num = (short)221052929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_394:
									goto IL_42B;
								}
								IL_481:
								goto IL_2C7;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							return;
							IL_2C7:
							num = (short)309854215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (A_1)
							{
								num = (short)1055850505;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_302;
						case 2:
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>>.Enumerator enumerator2 = A_0.GetEnumerator();
							num = (short)546897924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (!flag)
							{
								num = (short)1355874306;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_495;
						case 4:
							try
							{
								num = (short)44105732;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_249;
									case 1:
										num = (short)1969946624;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1650655233;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window> keyValuePair2 = enumerator2.Current;
										global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(keyValuePair2.Key);
										num = (short)350486531;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_174;
										}
										continue;
									}
									IL_1A2:
									num = (short)1586200336;
									short num3 = num;
									num = (short)1009483536;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)588185600;
										if (num != 0)
										{
										}
										num = (short)1289027586;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_174:
									goto IL_1A2;
								}
								IL_249:
								goto IL_495;
							}
							finally
							{
								global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.IntPtr, global::System.Windows.Window>>.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_25C;
						case 5:
							return;
						case 6:
							num = (short)2090663939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (!A_1)
							{
								num = (short)1435697158;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_495;
						case 8:
							return;
						case 9:
						{
							num = (short)202768384;
							short num4 = num;
							num = (short)1213005834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							if (!flag)
							{
								num = (short)877264904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_302;
						case 11:
							switch (0)
							{
							case 0:
								goto IL_73;
							}
							continue;
						}
						IL_73:
						num = (short)70516737;
						if (num != 0)
						{
						}
						if (A_0.Count == 0)
						{
							num = (short)305397765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_25C:
						flag = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.b();
						num = (short)751304705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_302:
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ae = true;
						enumerator = A_0.GetEnumerator();
						num = (short)1064239104;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
					IL_495:
					global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ae = false;
					return;
				}
				}
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x00047358 File Offset: 0x00045558
			public static bool c(global::System.IntPtr A_0)
			{
				short num = (short)1163166669;
				short num2 = num;
				num = (short)1854047181;
				switch (num2 == num)
				{
				}
				num = (short)747896832;
				if (num != 0)
				{
				}
				num = (short)1604059137;
				if (num != 0)
				{
				}
				num = (short)1362296832;
				short num3 = num;
				return ((int)global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(A_0, -20) & 8) != 0;
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x00047414 File Offset: 0x00045614
			internal static void b(global::System.IntPtr A_0)
			{
				short num = (short)430243840;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1360920577;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					bool flag;
					bool flag2;
					bool flag3;
					for (;;)
					{
						IL_50:
						global::System.Collections.Generic.List<global::System.IntPtr>.Enumerator enumerator;
						switch (num2)
						{
						case 0:
							return;
						case 1:
						{
							try
							{
								num = (short)174456836;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1DE;
									case 1:
										num = (short)313982976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)348520449;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.IntPtr a_ = enumerator.Current;
										global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.SetWindowPos(a_, new global::System.IntPtr(-2), 0, 0, 0, 0, 1043U);
										num = (short)745209859;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_FE;
										}
										continue;
									}
									IL_138:
									num = (short)1274428328;
									short num3 = num;
									num = (short)1368865704;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)561774592;
										if (num != 0)
										{
										}
										num = (short)2081947650;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_FE:
									goto IL_138;
								}
								IL_1DE:
								goto IL_21C;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_1EE;
							IL_21C:
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a(A_0);
							global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ad = false;
							num = (short)1312751616;
							short num4 = num;
							num = (short)1445396480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_1EE;
						case 3:
							if ((!flag && flag2) & !flag3)
							{
								num = (short)1724448770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						goto IL_67;
						IL_1EE:
						global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ad = true;
						enumerator = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ac.GetEnumerator();
						num = (short)1499332609;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
					IL_67:
					flag = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.b();
					flag2 = (global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.ac.Count != 0);
					flag3 = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.a();
					num = (short)1627455491;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_50;
				}
				}
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x000476AC File Offset: 0x000458AC
			private static void a(global::System.IntPtr A_0)
			{
				short num = (short)1686769531;
				short num2 = num;
				num = (short)1832783739;
				switch (num2 == num)
				{
				}
				num = (short)1682964480;
				if (num != 0)
				{
				}
				num = (short)227409921;
				if (num != 0)
				{
				}
				num = (short)365363200;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.BringWindowToTop(A_0);
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x0004775C File Offset: 0x0004595C
			internal static a a<a>(global::System.Windows.DependencyObject A_0) where a : global::System.Windows.DependencyObject
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				global::System.Windows.DependencyObject parent;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)172621824;
						short num3 = num2;
						num2 = (short)2042397067;
						short num4 = num2;
						num2 = (short)1668186507;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A8;
						default:
							goto IL_8C;
						}
						break;
					}
					case 1:
						num2 = (short)1470889985;
						if (num2 != 0)
						{
						}
						if (parent is a)
						{
							num2 = (short)710082560;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13E;
					case 2:
						goto IL_52;
					case 3:
						if (parent == null)
						{
							num2 = (short)356909058;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_A8;
					}
					goto IL_20;
					IL_A8:
					num2 = (short)547487745;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_52:
				return default(a);
				IL_8C:
				num2 = (short)1432748032;
				if (num2 != 0)
				{
				}
				return (a)((object)parent);
				IL_13E:
				return global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a<a>(parent);
				IL_20:
				parent = global::System.Windows.LogicalTreeHelper.GetParent(A_0);
				num2 = (short)853082115;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x000478B0 File Offset: 0x00045AB0
			internal static void a(global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow A_0)
			{
				short num = (short)869793792;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					global::Infragistics.Windows.DockManager.XamDockManager xamDockManager;
					for (;;)
					{
						IL_27:
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DockManager.ContentPane> enumerator;
						switch (num2)
						{
						case 0:
						{
							num = (short)1662320640;
							short num3 = num;
							goto IL_2BE;
						}
						case 1:
							try
							{
								num = (short)399638536;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)866975747;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Infragistics.Windows.DockManager.ContentPane contentPane = enumerator.Current;
										num = (short)299499527;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)44236804;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_24C;
									case 3:
										num = (short)1977155586;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::Infragistics.Windows.DockManager.ContentPane contentPane;
										if (contentPane.IsVisibleResolved)
										{
											num = (short)38141957;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
									{
										global::Infragistics.Windows.DockManager.ContentPane contentPane;
										contentPane.ExecuteCommand(global::Infragistics.Windows.DockManager.ContentPaneCommands.FlyIn);
										num = (short)1951662086;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										num = (short)1632522425;
										short num4 = num;
										num = (short)1026248889;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
										{
											num = (short)689766400;
											if (num != 0)
											{
											}
											global::Infragistics.Windows.DockManager.ContentPane contentPane;
											if (contentPane.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unpinned)
											{
												num = (short)143785985;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										break;
									}
									case 8:
										switch (0)
										{
										case 0:
											goto IL_F7;
										}
										continue;
									}
									IL_F9:
									num = (short)337051648;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_F7:
									goto IL_F9;
								}
								IL_24C:
								return;
							}
							finally
							{
								num = (short)976551938;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)2359297;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_2BB;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_283;
										}
										continue;
									}
									IL_283:
									if (enumerator == null)
									{
										break;
									}
									num = (short)526581760;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2BB:;
							}
							goto IL_2BE;
						case 2:
							if (xamDockManager != null)
							{
								num = (short)1034420224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						goto IL_3A;
						IL_2BE:
						num = (short)1413283841;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DockManager.ContentPane> panes = xamDockManager.GetPanes(global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder);
						global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
						enumerator = panes.GetEnumerator();
						num = (short)1360134145;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
					IL_3A:
					global::Infragistics.Windows.DockManager.XamDockManager a_ = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a<global::Infragistics.Windows.DockManager.XamDockManager>(A_0.OwnerElement);
					xamDockManager = global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.a<global::Infragistics.Windows.DockManager.XamDockManager>(a_);
					num = (short)1657405442;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x00047BF4 File Offset: 0x00045DF4
			internal static bool a(global::System.Windows.FrameworkElement A_0, global::System.Windows.Window A_1, out global::System.Windows.Point A_2)
			{
				short num;
				global::System.Windows.PresentationSource presentationSource;
				global::System.Windows.Point point2;
				for (;;)
				{
					IL_00:
					num = (short)794689536;
					switch (num)
					{
					default:
					{
						num = (short)1522270210;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)21559806;
							short num3 = num;
							num = (short)187955710;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)300417024;
								short num4 = num;
								num = (short)470614016;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 0:
									if (presentationSource != null)
									{
										num = (short)540868609;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_183;
								case 1:
									goto IL_173;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_C6;
									}
									continue;
								}
								IL_C6:
								global::System.Windows.Point point = new global::System.Windows.Point((A_0.FlowDirection == global::System.Windows.FlowDirection.LeftToRight) ? 0.0 : A_0.ActualWidth, 0.0);
								point2 = A_0.PointToScreen(point);
								presentationSource = global::System.Windows.PresentationSource.FromVisual(A_1);
								num = (short)377880576;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							}
						}
						break;
					}
					}
				}
				IL_173:
				num = (short)1724776449;
				if (num != 0)
				{
				}
				A_2 = presentationSource.CompositionTarget.TransformFromDevice.Transform(point2);
				return true;
				IL_183:
				A_2 = new global::System.Windows.Point(0.0, 0.0);
				return false;
			}

			// Token: 0x04000165 RID: 357
			private const int a = 134;

			// Token: 0x04000166 RID: 358
			private const int b = 6;

			// Token: 0x04000167 RID: 359
			private const int c = 70;

			// Token: 0x04000168 RID: 360
			private const int d = 33;

			// Token: 0x04000169 RID: 361
			private const int e = 2;

			// Token: 0x0400016A RID: 362
			private const int f = 1;

			// Token: 0x0400016B RID: 363
			private const int g = 16;

			// Token: 0x0400016C RID: 364
			private const int h = 1024;

			// Token: 0x0400016D RID: 365
			private const int i = 512;

			// Token: 0x0400016E RID: 366
			private const int j = -16;

			// Token: 0x0400016F RID: 367
			private const int k = -20;

			// Token: 0x04000170 RID: 368
			private const int l = 524288;

			// Token: 0x04000171 RID: 369
			private const int m = 8;

			// Token: 0x04000172 RID: 370
			private const int n = 32;

			// Token: 0x04000173 RID: 371
			private const int o = 0;

			// Token: 0x04000174 RID: 372
			private const int p = 1;

			// Token: 0x04000175 RID: 373
			private const int q = -1;

			// Token: 0x04000176 RID: 374
			private const int r = -2;

			// Token: 0x04000177 RID: 375
			private const uint s = 32780U;

			// Token: 0x04000178 RID: 376
			private const uint t = 0U;

			// Token: 0x04000179 RID: 377
			private const uint u = 3U;

			// Token: 0x0400017A RID: 378
			private const uint v = 2U;

			// Token: 0x0400017B RID: 379
			private const int w = 38;

			// Token: 0x0400017C RID: 380
			private const int x = 37;

			// Token: 0x0400017D RID: 381
			private const uint y = 4294967285U;

			// Token: 0x0400017E RID: 382
			private static bool z;

			// Token: 0x0400017F RID: 383
			private static global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.NativeMethods.WinEventDelegate aa;

			// Token: 0x04000180 RID: 384
			private static global::System.IntPtr ab;

			// Token: 0x04000181 RID: 385
			private static global::System.Collections.Generic.List<global::System.IntPtr> ac;

			// Token: 0x04000182 RID: 386
			private static bool ad;

			// Token: 0x04000183 RID: 387
			private static bool ae;

			// Token: 0x020000A7 RID: 167
			private enum GetWindow_Cmd : uint
			{
				// Token: 0x04000185 RID: 389
				a,
				// Token: 0x04000186 RID: 390
				b,
				// Token: 0x04000187 RID: 391
				c,
				// Token: 0x04000188 RID: 392
				d,
				// Token: 0x04000189 RID: 393
				e,
				// Token: 0x0400018A RID: 394
				f,
				// Token: 0x0400018B RID: 395
				g
			}

			// Token: 0x020000A8 RID: 168
			private enum HookType
			{
				// Token: 0x0400018D RID: 397
				a,
				// Token: 0x0400018E RID: 398
				b,
				// Token: 0x0400018F RID: 399
				c,
				// Token: 0x04000190 RID: 400
				d,
				// Token: 0x04000191 RID: 401
				e,
				// Token: 0x04000192 RID: 402
				f,
				// Token: 0x04000193 RID: 403
				g,
				// Token: 0x04000194 RID: 404
				h,
				// Token: 0x04000195 RID: 405
				i,
				// Token: 0x04000196 RID: 406
				j,
				// Token: 0x04000197 RID: 407
				k,
				// Token: 0x04000198 RID: 408
				l,
				// Token: 0x04000199 RID: 409
				m,
				// Token: 0x0400019A RID: 410
				n,
				// Token: 0x0400019B RID: 411
				o
			}

			// Token: 0x020000A9 RID: 169
			public struct WINDOWPOS
			{
				// Token: 0x0400019C RID: 412
				public global::System.IntPtr a;

				// Token: 0x0400019D RID: 413
				public global::System.IntPtr b;

				// Token: 0x0400019E RID: 414
				public int c;

				// Token: 0x0400019F RID: 415
				public int d;

				// Token: 0x040001A0 RID: 416
				public int e;

				// Token: 0x040001A1 RID: 417
				public int f;

				// Token: 0x040001A2 RID: 418
				public uint g;
			}

			// Token: 0x020000AA RID: 170
			// (Invoke) Token: 0x0600045D RID: 1117
			private delegate void WinEventDelegate(global::System.IntPtr A_0, uint A_1, global::System.IntPtr A_2, int A_3, int A_4, uint A_5, uint A_6);
		}
	}
}
