using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000112 RID: 274
	public static class Utility
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x0008F848 File Offset: 0x0008DA48
		internal static object[] a(global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs A_0)
		{
			short num = (short)1119485952;
			switch (num)
			{
			default:
			{
				num = (short)672792579;
				int num2 = (int)((global::System.IntPtr)num);
				object[] array;
				string text3;
				for (;;)
				{
					bool flag;
					string text;
					switch (num2)
					{
					case 0:
						goto IL_11D;
					case 1:
						num = (short)638713857;
						if (num != 0)
						{
						}
						flag = false;
						num = (short)572653568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (A_0.Cell.Value is string)
						{
							num = (short)1037107211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)349110289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_9C;
						}
						continue;
					case 4:
						text = string.Empty;
						num = (short)253165578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_10F;
					case 6:
						goto IL_C5;
					case 7:
					{
						num = (short)2125418474;
						short num3 = num;
						num = (short)276975594;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_47E;
						default:
							num = (short)1695612928;
							if (num != 0)
							{
							}
							if (!flag)
							{
								num = (short)1643315214;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array = new object[3];
							array[0] = A_0.Cell.Record.DataItem;
							array[1] = A_0.Cell.Field.Name;
							num = (short)1247805445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_2F6;
					case 9:
					{
						int? num4;
						int? num5;
						if (num4.GetValueOrDefault() == num5.GetValueOrDefault() & num4 != null == (num5 != null))
						{
							num = (short)436273153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11D;
					}
					case 10:
						goto IL_1C7;
					case 11:
					{
						string text2 = A_0.Cell.Value as string;
						num = (short)1151205392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						num = (short)1152122880;
						short num6 = num;
						string text2 = string.Empty;
						num = (short)1435041800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (text == null)
						{
							num = (short)1277820932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C7;
					case 14:
						goto IL_1A1;
					case 15:
						flag = false;
						num = (short)208863252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						string text2;
						if (text2 == null)
						{
							num = (short)1001979916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F6;
					}
					case 17:
						if (A_0.Cell.Value is int?)
						{
							num = (short)1748631573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11D;
					case 18:
					{
						string text2;
						if (text.Trim() == text2)
						{
							num = (short)2101542927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text3 = text;
						goto IL_47E;
					}
					case 19:
						goto IL_11D;
					case 20:
						goto IL_11D;
					case 21:
					{
						int? num4 = (int?)A_0.Cell.Value;
						int? num5 = (int?)A_0.Editor.Value;
						num = (short)1405026313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9C:
					if (!A_0.Cell.IsDataChanged)
					{
						num = (short)1917386758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text3 = null;
					flag = true;
					num = (short)2013921282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11D:
					num = (short)1361969159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C7:
					num = (short)1063911442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F6:
					text = (A_0.Editor.Value as string);
					num = (short)683081741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47E:
					num = (short)1984757779;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C5:
				return null;
				IL_10F:
				object[] array2 = array;
				int num7 = 2;
				string text4;
				if ((text4 = text3) == null)
				{
					text4 = A_0.Editor.Value;
				}
				array2[num7] = text4;
				return array;
				IL_1A1:
				A_0.AcceptChanges = false;
				return null;
			}
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0008FD04 File Offset: 0x0008DF04
		internal static global::System.Collections.Generic.IEnumerable<a> d<a>(global::System.Windows.DependencyObject A_0) where a : global::System.Windows.DependencyObject
		{
			short num = (short)335760298;
			short num2 = num;
			num = (short)1314343850;
			switch (num2 == num)
			{
			}
			num = (short)288161792;
			short num3 = num;
			num = (short)1149173761;
			if (num != 0)
			{
			}
			num = (short)1785004032;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.Utility.<FindLogicChildren>d__1<a> <FindLogicChildren>d__ = new global::Motorola.CommonCPS.RadioManagement.Controls.Utility.<FindLogicChildren>d__1<a>(-2);
			<FindLogicChildren>d__.e = A_0;
			return <FindLogicChildren>d__;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0008FDBC File Offset: 0x0008DFBC
		internal static a c<a>(global::System.Windows.DependencyObject A_0) where a : global::System.Windows.DependencyObject
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
					goto IL_A1;
				case 1:
					goto IL_111;
				case 2:
				{
					num2 = (short)1650720768;
					short num3 = num2;
					if (parent is a)
					{
						num2 = (short)1842479105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_147;
				}
				case 3:
				{
					if (parent != null)
					{
						num2 = (short)1080098818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)777580931;
					short num4 = num2;
					num2 = (short)1544024451;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_147;
					default:
						num2 = (short)1102708736;
						if (num2 != 0)
						{
						}
						num2 = (short)447545344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_A1:
			return default(a);
			IL_111:
			num2 = (short)1483669505;
			if (num2 != 0)
			{
			}
			return (a)((object)parent);
			IL_147:
			return global::Motorola.CommonCPS.RadioManagement.Controls.Utility.c<a>(parent);
			IL_20:
			parent = global::System.Windows.LogicalTreeHelper.GetParent(A_0);
			num2 = (short)685899779;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0008FF18 File Offset: 0x0008E118
		internal static global::System.Windows.DependencyObject a(global::System.Windows.DependencyObject A_0, string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::System.Windows.DependencyObject parent;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_CA;
				case 1:
					return parent;
				case 2:
					if (parent.GetType().FullName.Equals(A_1))
					{
						num2 = (short)345899009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				case 3:
				{
					if (parent != null)
					{
						num2 = (short)1767768064;
						short num3 = num2;
						num2 = (short)527958018;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1881463685;
					short num4 = num2;
					num2 = (short)2078071685;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13F;
					default:
						num2 = (short)1012203521;
						if (num2 != 0)
						{
						}
						num2 = (short)2064973824;
						if (num2 != 0)
						{
						}
						num2 = (short)53739520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_CA:
			return null;
			IL_13F:
			return global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(parent, A_1);
			IL_20:
			parent = global::System.Windows.LogicalTreeHelper.GetParent(A_0);
			num2 = (short)487129091;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0009006C File Offset: 0x0008E26C
		internal static global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter a(global::System.Windows.FrameworkElement A_0, bool A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
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
					if (window.Tag is global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter)
					{
						num2 = (short)879886342;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BD;
				case 1:
					if (A_1)
					{
						num2 = (short)46465029;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_218;
				case 2:
					if (window is global::Motorola.CommonCPS.RadioManagement.Controls.GlueWindow.InnerWindow)
					{
						num2 = (short)1525612545;
						if (num2 != 0)
						{
						}
						num2 = (short)1967194116;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BD;
				case 3:
					num2 = (short)2121138178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)793640960;
					short num3 = num2;
					num2 = (short)2093481992;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_F2;
				case 6:
					goto IL_134;
				case 7:
					goto IL_F7;
				case 8:
					if (window.Tag != null)
					{
						num2 = (short)748158983;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BD;
				case 9:
				{
					if (window == null)
					{
						goto IL_BD;
					}
					num2 = (short)5190242;
					short num4 = num2;
					num2 = (short)292500066;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F7;
					default:
						num2 = (short)1616445440;
						if (num2 != 0)
						{
						}
						num2 = (short)1693974531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_38;
				IL_BD:
				num2 = (short)1706557441;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_F7:
				num2 = (short)610926592;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F2:
			return global::Motorola.CommonCPS.RadioManagement.Controls.Utility.b<global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter>(A_0);
			IL_134:
			return window.Tag as global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter;
			IL_218:
			return global::Motorola.CommonCPS.RadioManagement.Controls.Utility.c<global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter>(A_0);
			IL_38:
			window = global::System.Windows.Window.GetWindow(A_0);
			num2 = (short)77135881;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00090298 File Offset: 0x0008E498
		internal static global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter b(global::System.Windows.FrameworkElement A_0)
		{
			short num = (short)830053740;
			short num2 = num;
			num = (short)319528300;
			switch (num2 == num)
			{
			}
			num = (short)700055552;
			short num3 = num;
			num = (short)1296433153;
			if (num != 0)
			{
			}
			num = (short)855179264;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(A_0, false);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0009034C File Offset: 0x0008E54C
		internal static global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter a(global::System.Windows.FrameworkElement A_0)
		{
			short num = (short)460154831;
			short num2 = num;
			num = (short)301230031;
			switch (num2 == num)
			{
			}
			num = (short)1051197440;
			short num3 = num;
			num = (short)1626144769;
			if (num != 0)
			{
			}
			num = (short)766640128;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(A_0, true);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00090400 File Offset: 0x0008E600
		internal static a b<a>(global::System.Windows.DependencyObject A_0) where a : global::System.Windows.DependencyObject
		{
			short num = (short)578617351;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.DependencyObject parent;
			a a;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					parent = global::System.Windows.Media.VisualTreeHelper.GetParent(A_0);
					num = (short)1252917249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					if (parent == null)
					{
						goto IL_60;
					}
					num = (short)191129353;
					short num3 = num;
					num = (short)577267465;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_196;
					default:
						num = (short)91291648;
						if (num != 0)
						{
						}
						num = (short)1995767810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)1751908353;
					if (num != 0)
					{
					}
					num = (short)1292304390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (a != null)
					{
						num = (short)1531183108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BD;
				case 4:
					goto IL_9A;
				case 5:
					goto IL_1B8;
				case 6:
					goto IL_196;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				}
				IL_44:
				if (A_0 != null)
				{
					num = (short)1593049088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1BD;
				IL_60:
				a = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.b<a>(parent);
				num = (short)59572227;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_196:
				if (!(parent is a))
				{
					goto IL_60;
				}
				num = (short)2126315525;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9A:
			num = (short)726269952;
			short num4 = num;
			return a;
			IL_1B8:
			return (a)((object)parent);
			IL_1BD:
			return default(a);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000905D4 File Offset: 0x0008E7D4
		internal static void a(global::System.Windows.DependencyObject A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor rmanchor;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_E9;
				case 1:
					goto IL_A0;
				case 2:
					if (rmanchor != null)
					{
						num2 = (short)2041249793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_A0:
			goto IL_A2;
			IL_E9:
			num2 = (short)209518593;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)989148062;
			short num3 = num2;
			num2 = (short)914043806;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_A2:
				num2 = (short)1119944704;
				short num4 = num2;
				rmanchor.IsExpanded = true;
				num2 = (short)1357578240;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1742471168;
				if (num2 != 0)
				{
				}
				rmanchor = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.b<global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor>(A_0);
				num2 = (short)1272381442;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000906F4 File Offset: 0x0008E8F4
		public static T FindChildByName<T>(global::System.Windows.DependencyObject dependencyObject, string controlID) where T : global::System.Windows.DependencyObject
		{
			short num = (short)992346112;
			switch (num)
			{
			default:
			{
				num = (short)1518796811;
				int num2 = (int)((global::System.IntPtr)num);
				T t;
				global::System.Windows.DependencyObject child;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1674903553;
						if (num != 0)
						{
						}
						goto IL_1BF;
					case 1:
						num = (short)1962016772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1FB;
					case 3:
						goto IL_1BF;
					case 4:
					{
						num = (short)1226497268;
						short num3 = num;
						num = (short)428399860;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return t;
						default:
							num = (short)33292288;
							if (num != 0)
							{
							}
							if (((global::System.Windows.FrameworkElement)child).Name == controlID)
							{
								num = (short)2086535180;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14B;
						}
						break;
					}
					case 5:
						return t;
					case 6:
						if (child != null)
						{
							num = (short)1365311495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14B;
					case 7:
						num = (short)1145569288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (child is T)
						{
							num = (short)781975553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14B;
					case 9:
					{
						if (t != null)
						{
							num = (short)787415045;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						num4++;
						num = (short)222167043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						int num4;
						if (num4 >= global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(dependencyObject))
						{
							num = (short)331743234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						child = global::System.Windows.Media.VisualTreeHelper.GetChild(dependencyObject, num4);
						num = (short)790822918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 12:
						goto IL_291;
					case 13:
					{
						int num4 = 0;
						num = (short)389677056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_7C:
					if (dependencyObject != null)
					{
						num = (short)1118437389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D8;
					IL_14B:
					t = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.FindChildByName<T>(child, controlID);
					num = (short)2105344000;
					short num5 = num;
					num = (short)318111753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BF:
					num = (short)1107820554;
					num2 = (int)((global::System.IntPtr)num);
				}
				return t;
				IL_1FB:
				goto IL_2D8;
				IL_291:
				return (T)((object)child);
				IL_2D8:
				return default(T);
			}
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000909E4 File Offset: 0x0008EBE4
		public static TObject FindVisualParent<TObject>(global::System.Windows.UIElement child) where TObject : global::System.Windows.UIElement
		{
			short num = (short)2001862660;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.UIElement uielement;
				switch (num2)
				{
				case 0:
					goto IL_D9;
				case 1:
				{
					num = (short)951189505;
					if (num != 0)
					{
					}
					if (uielement == null)
					{
						num = (short)492175362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					TObject tobject = uielement as TObject;
					num = (short)1672544263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_135;
				case 3:
				{
					num = (short)2111603797;
					short num3 = num;
					num = (short)1924891733;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1833107456;
						if (num != 0)
						{
						}
						num = (short)1610285056;
						short num4 = num;
						goto IL_D9;
					}
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 5:
					goto IL_60;
				case 6:
				{
					TObject tobject;
					return tobject;
				}
				case 7:
				{
					TObject tobject;
					if (tobject != null)
					{
						num = (short)414711814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					uielement = (global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::System.Windows.UIElement);
					num = (short)340131840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_44:
				if (child == null)
				{
					num = (short)2141847557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				uielement = (global::System.Windows.Media.VisualTreeHelper.GetParent(child) as global::System.Windows.UIElement);
				num = (short)258867203;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D9:
				num = (short)859308033;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_60:
			return default(TObject);
			IL_135:
			return default(TObject);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00090BD4 File Offset: 0x0008EDD4
		internal static void a(global::System.Windows.FrameworkElement A_0, double A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			double num3;
			double num6;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_265;
				case 1:
					num2 = (short)617611269;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1394343937;
					if (num2 != 0)
					{
					}
					if (num3 >= 0.4)
					{
						num2 = (short)1740832774;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (num3 <= 2.0)
					{
						num2 = (short)1112604673;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					if (A_1 < 0.0)
					{
						num2 = (short)1467285511;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1760493571;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_241;
				case 6:
					num2 = (short)1015676937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)1613168640;
					short num4 = num2;
					num2 = (short)1728577538;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					goto IL_190;
				case 9:
				{
					num2 = (short)449308974;
					short num5 = num2;
					num2 = (short)1942743342;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_241;
					default:
						num2 = (short)1027145728;
						if (num2 != 0)
						{
						}
						if (num6 < 0.4)
						{
							num2 = (short)1543176200;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E1;
					}
					break;
				}
				}
				goto IL_38;
				IL_241:
				if (num6 <= 2.0)
				{
					goto IL_26B;
				}
				num2 = (short)1629028352;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E1:
			num3 -= 0.1;
			num6 -= 0.1;
			A_0.LayoutTransform = new global::System.Windows.Media.ScaleTransform(num3, num6);
			return;
			IL_190:
			return;
			IL_265:
			return;
			IL_26B:
			num3 += 0.1;
			num6 += 0.1;
			A_0.LayoutTransform = new global::System.Windows.Media.ScaleTransform(num3, num6);
			return;
			IL_38:
			num3 = A_0.LayoutTransform.Value.M11;
			num6 = A_0.LayoutTransform.Value.M22;
			num2 = (short)368574468;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00090E74 File Offset: 0x0008F074
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> GetColumOnUI(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgr)
		{
			short num = (short)1526530048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)518979585;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> list;
				global::Infragistics.Windows.DataPresenter.FieldCollection fields;
				for (;;)
				{
					IL_50:
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_1D3;
					case 1:
					{
						num = (short)1740930233;
						short num3 = num;
						num = (short)673086649;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_21A;
						default:
							num = (short)1883045888;
							if (num != 0)
							{
							}
							goto IL_CB;
						}
						break;
					}
					case 2:
						return list;
					case 3:
					{
						if (num4 >= fields.Count)
						{
							num = (short)1539833858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.Windows.DataPresenter.Field field = fields[num4];
						goto IL_21A;
					}
					case 4:
					{
						global::Infragistics.Windows.DataPresenter.Field field;
						if (field.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)548012039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB;
					}
					case 5:
						if (fields != null)
						{
							num = (short)298516486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 6:
						num4 = 0;
						num = (short)324141064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Infragistics.Windows.DataPresenter.Field field;
						string uiLable = field.Label as string;
						string name = field.Name;
						global::System.Windows.Data.IValueConverter converter = field.Converter;
						global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo item = new global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo(field.Name, uiLable, null, converter);
						list.Add(item);
						num = (short)387317761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						num = (short)681508864;
						short num5 = num;
						goto IL_1D3;
					}
					}
					goto IL_7B;
					IL_CB:
					num4++;
					num = (short)1920335872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D3:
					num = (short)1014300675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21A:
					num = (short)1254031364;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_7B:
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo>();
				fields = dgr.FieldLayouts[0].Fields;
				num = (short)1648492549;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}
	}
}
