using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using Infragistics.Controls.Menus;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000050 RID: 80
	public static class Helpers
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00012860 File Offset: 0x00010A60
		public static object GetDragDataFromSysMemory(global::System.Windows.DragEventArgs e, string format)
		{
			short num = (short)961150978;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1465327304;
					short num3 = num;
					num = (short)866197192;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1275789312;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)1215299584;
					short num4 = num;
					num = (short)579141633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_130;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
					goto IL_BB;
				}
				IL_35:
				if (!e.Data.GetDataPresent(format))
				{
					num = (short)647888896;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1198653443;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_BB:
			num = (short)423231489;
			if (num != 0)
			{
			}
			return e.Data.GetData(format);
			IL_130:
			return e.Data;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000129A8 File Offset: 0x00010BA8
		public static bool IsMarkedAsSerializable(global::System.Type t)
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			object[] customAttributes;
			for (;;)
			{
				IL_0A:
				num = (short)2147317026;
				short num2 = num;
				num = (short)173176098;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1979318272;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_104;
					case 1:
						return true;
					case 2:
						if (customAttributes.Count<object>() != 0)
						{
							num = (short)1598095361;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						num = (short)261750785;
						if (num != 0)
						{
						}
						if (customAttributes != null)
						{
							num = (short)1725300736;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_6A;
				}
				IL_104:
				num = (short)290783234;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_6A:
			customAttributes = t.GetCustomAttributes(typeof(global::System.SerializableAttribute), true);
			num = (short)561053696;
			short num4 = num;
			num = (short)877658115;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00012AF4 File Offset: 0x00010CF4
		public static bool HitTestOnType<T>(object sender, global::System.Windows.Point elementPosition) where T : global::System.Windows.UIElement
		{
			T t = global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.a<T>(sender, elementPosition);
			if (t != null)
			{
				short num = (short)1909745200;
				short num2 = num;
				num = (short)2000250416;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)752943104;
					short num3 = num;
					num = (short)1050411009;
					if (num != 0)
					{
					}
					num = (short)2129985536;
					if (num != 0)
					{
					}
					return t.Visibility == global::System.Windows.Visibility.Visible;
				}
				}
			}
			return false;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00012BC4 File Offset: 0x00010DC4
		private static a a<a>(object A_0, global::System.Windows.Point A_1) where a : global::System.Windows.UIElement
		{
			short num = (short)1440874496;
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
				global::System.Windows.Media.HitTestResult hitTestResult;
				global::System.Windows.Media.Visual visual;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_72;
					case 1:
						goto IL_156;
					case 2:
						if (hitTestResult == null)
						{
							num = (short)1160183809;
							if (num != 0)
							{
							}
							num = (short)1841692673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165;
					case 3:
					{
						if (visual == null)
						{
							num = (short)204013568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(visual, A_1);
						num = (short)867360859;
						short num3 = num;
						num = (short)1361436763;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9F;
						default:
							num = (short)1818886144;
							if (num != 0)
							{
							}
							num = (short)1315831810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_3E;
				}
				IL_72:
				num = (short)266403840;
				short num4 = num;
				return default(a);
				IL_9F:
				return default(a);
				IL_156:
				goto IL_9F;
				IL_165:
				return hitTestResult.VisualHit.b<a>();
				IL_3E:
				visual = (A_0 as global::System.Windows.Media.Visual);
				num = (short)1892417539;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00012D44 File Offset: 0x00010F44
		public static global::System.Windows.UIElement GetDragItem(global::Motorola.CommonCPS.RadioManagement.Controls.DragInfo info)
		{
			short num = (short)1124204549;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1720306421;
					short num3 = num;
					num = (short)1847446261;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DE;
					default:
						goto IL_13B;
					}
					break;
				}
				case 1:
					goto IL_DE;
				case 2:
				{
					num = (short)740687872;
					short num4 = num;
					num = (short)851969;
					if (num != 0)
					{
					}
					num = (short)1017839617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					num = (short)658046980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (info.VisualSource != null)
					{
						num = (short)381353986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_193;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				}
				IL_3C:
				if (info != null)
				{
					num = (short)1328283651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_193;
				IL_DE:
				if (!(info.VisualSource is global::Infragistics.Controls.Menus.XamDataTree))
				{
					goto IL_193;
				}
				num = (short)1522663424;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_13B:
			num = (short)1738211328;
			if (num != 0)
			{
			}
			global::Infragistics.Controls.Menus.XamDataTree a_ = (global::Infragistics.Controls.Menus.XamDataTree)info.VisualSource;
			return a_.a(info.DragStartPoint);
			IL_193:
			return null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00012EE8 File Offset: 0x000110E8
		public static global::System.Windows.UIElement GetTargetItem(global::Motorola.CommonCPS.RadioManagement.Controls.DropInfo info)
		{
			short num = (short)891748357;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1745119041;
					short num3 = num;
					num = (short)1430677313;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DF;
					default:
						goto IL_13C;
					}
					break;
				}
				case 1:
					goto IL_DF;
				case 2:
					num = (short)1270349825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)917372932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (info.VisualTarget != null)
					{
						num = (short)1407057922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_192;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				}
				IL_3C:
				num = (short)1164443649;
				if (num != 0)
				{
				}
				if (info != null)
				{
					num = (short)1544159235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_192;
				IL_DF:
				if (!(info.VisualTarget is global::Infragistics.Controls.Menus.XamDataTree))
				{
					goto IL_192;
				}
				num = (short)35979264;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_13C:
			num = (short)1172111360;
			if (num != 0)
			{
			}
			num = (short)237305856;
			short num4 = num;
			global::Infragistics.Controls.Menus.XamDataTree a_ = (global::Infragistics.Controls.Menus.XamDataTree)info.VisualTarget;
			return a_.a(info.CurrentMouseLocation);
			IL_192:
			return null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00013088 File Offset: 0x00011288
		private static global::Infragistics.Controls.Menus.XamDataTreeNodeControl a(this global::Infragistics.Controls.Menus.XamDataTree A_0, global::System.Windows.Point A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::System.Windows.IInputElement inputElement;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_13D;
				case 1:
					if (inputElement is global::System.Windows.DependencyObject)
					{
						num2 = (short)143065088;
						short num3 = num2;
						num2 = (short)1337720832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_190;
				case 2:
					goto IL_18E;
				case 3:
				{
					num2 = (short)2142867024;
					short num4 = num2;
					num2 = (short)677809744;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_154;
					default:
						goto IL_96;
					}
					break;
				}
				case 4:
					if (inputElement is global::Infragistics.Controls.Menus.XamDataTreeNodeControl)
					{
						num2 = (short)2138439682;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1435697153;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (inputElement == null)
					{
						num2 = (short)487587843;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_154;
				}
				goto IL_28;
				IL_154:
				num2 = (short)81264644;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_96:
			num2 = (short)256966656;
			if (num2 != 0)
			{
			}
			num2 = (short)261160961;
			if (num2 != 0)
			{
			}
			return null;
			IL_13D:
			return ((global::System.Windows.DependencyObject)inputElement).b<global::Infragistics.Controls.Menus.XamDataTreeNodeControl>();
			IL_18E:
			return (global::Infragistics.Controls.Menus.XamDataTreeNodeControl)inputElement;
			IL_190:
			return null;
			IL_28:
			inputElement = A_0.InputHitTest(A_1);
			num2 = (short)1317863429;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00013228 File Offset: 0x00011428
		public static T GetVisualDescendent<T>(this global::System.Windows.DependencyObject d) where T : global::System.Windows.DependencyObject
		{
			short num = (short)1236726745;
			short num2 = num;
			num = (short)95548377;
			switch (num2 == num)
			{
			default:
			{
				num = (short)322699264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1197604865;
			if (num != 0)
			{
			}
			num = (short)1806827520;
			if (num != 0)
			{
			}
			return d.GetVisualDescendents<T>().FirstOrDefault<T>();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000132E0 File Offset: 0x000114E0
		public static global::System.Collections.Generic.IEnumerable<T> GetVisualDescendents<T>(this global::System.Windows.DependencyObject d) where T : global::System.Windows.DependencyObject
		{
			short num = (short)141956093;
			short num2 = num;
			num = (short)1975063549;
			switch (num2 == num)
			{
			default:
			{
				num = (short)117243904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1948778497;
			if (num != 0)
			{
			}
			num = (short)1417412608;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.<GetVisualDescendents>d__8<T> <GetVisualDescendents>d__ = new global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.<GetVisualDescendents>d__8<T>(-2);
			<GetVisualDescendents>d__.e = d;
			return <GetVisualDescendents>d__;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00013398 File Offset: 0x00011598
		private static a b<a>(this global::System.Windows.DependencyObject A_0) where a : class
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			a a;
			short num2;
			global::System.Windows.DependencyObject parent;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return a;
				case 1:
				{
					if (a != null)
					{
						num2 = (short)1617756160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					parent = global::System.Windows.Media.VisualTreeHelper.GetParent(parent);
					num2 = (short)268784226;
					short num3 = num2;
					num2 = (short)1124618850;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_156;
					default:
						num2 = (short)1445724161;
						if (num2 != 0)
						{
						}
						num2 = (short)305201152;
						if (num2 != 0)
						{
						}
						num2 = (short)898957315;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_18B;
				case 3:
					goto IL_156;
				case 4:
				{
					if (parent == null)
					{
						num2 = (short)98500610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)62652416;
					short num4 = num2;
					a = (parent as a);
					num2 = (short)634388481;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					goto IL_156;
				}
				goto IL_28;
				IL_156:
				num2 = (short)1152647172;
				num = (int)((global::System.IntPtr)num2);
			}
			return a;
			IL_18B:
			return default(a);
			IL_28:
			parent = global::System.Windows.Media.VisualTreeHelper.GetParent(A_0.a());
			num2 = (short)1800732677;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001353C File Offset: 0x0001173C
		private static global::System.Windows.DependencyObject a(this global::System.Windows.DependencyObject A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::System.Windows.DependencyObject result;
			global::System.Windows.DependencyObject dependencyObject;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_6D;
				case 1:
					return result;
				case 2:
					dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
					num2 = (short)254017536;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					if (dependencyObject != null)
					{
						result = dependencyObject;
						num2 = (short)391839748;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)965101962;
					short num3 = num2;
					num2 = (short)1458129290;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14D;
					default:
						num2 = (short)1235025920;
						if (num2 != 0)
						{
						}
						num2 = (short)425721857;
						if (num2 != 0)
						{
						}
						num2 = (short)773586945;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_14D;
				case 5:
					goto IL_6D;
				}
				goto IL_28;
				IL_6D:
				num2 = (short)679608323;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_14D:
				if (dependencyObject is global::System.Windows.Media.Visual)
				{
					break;
				}
				num2 = (short)790757378;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_28:
			dependencyObject = A_0;
			result = A_0;
			num2 = (short)1877016576;
			short num4 = num2;
			num2 = (short)158924805;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600013B RID: 315
		[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetWindowLong")]
		private static extern global::System.IntPtr b(global::System.IntPtr A_0, int A_1);

		// Token: 0x0600013C RID: 316
		[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
		private static extern global::System.IntPtr a(global::System.IntPtr A_0, int A_1);

		// Token: 0x0600013D RID: 317 RVA: 0x000136BC File Offset: 0x000118BC
		public static global::System.IntPtr GetWindowLongPtr(global::System.IntPtr hWnd, int nIndex)
		{
			if (global::System.IntPtr.Size == 8)
			{
				short num = (short)1918242662;
				short num2 = num;
				num = (short)475926374;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)886571008;
					short num3 = num;
					num = (short)1723072513;
					if (num != 0)
					{
					}
					num = (short)1588133888;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.a(hWnd, nIndex);
				}
				}
			}
			return global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.b(hWnd, nIndex);
		}

		// Token: 0x0600013E RID: 318
		[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowLong")]
		private static extern int a(global::System.Runtime.InteropServices.HandleRef A_0, int A_1, int A_2);

		// Token: 0x0600013F RID: 319
		[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
		private static extern global::System.IntPtr a(global::System.Runtime.InteropServices.HandleRef A_0, int A_1, global::System.IntPtr A_2);

		// Token: 0x06000140 RID: 320 RVA: 0x00013780 File Offset: 0x00011980
		public static global::System.IntPtr SetWindowLongPtr(global::System.Runtime.InteropServices.HandleRef hWnd, int nIndex, global::System.IntPtr dwNewLong)
		{
			if (global::System.IntPtr.Size == 8)
			{
				short num = (short)1332004336;
				short num2 = num;
				num = (short)1468712432;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1358954496;
					short num3 = num;
					num = (short)2039611392;
					if (num != 0)
					{
					}
					num = (short)2059796481;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.a(hWnd, nIndex, dwNewLong);
				}
				}
			}
			return new global::System.IntPtr(global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.a(hWnd, nIndex, dwNewLong.ToInt32()));
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00013854 File Offset: 0x00011A54
		internal static global::System.IntPtr a(global::System.Windows.Window A_0)
		{
			short num = (short)1965369086;
			short num2 = num;
			num = (short)746399486;
			switch (num2 == num)
			{
			default:
			{
				num = (short)301203456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1846607873;
			if (num != 0)
			{
			}
			num = (short)321716224;
			if (num != 0)
			{
			}
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(A_0);
			windowInteropHelper.EnsureHandle();
			return windowInteropHelper.Handle;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00013910 File Offset: 0x00011B10
		public static void SetWindowAsTransparent(global::System.Windows.Window window)
		{
			short num = (short)307298305;
			if (num != 0)
			{
			}
			num = (short)1010237440;
			short num2 = num;
			num = (short)104975413;
			short num3 = num;
			num = (short)897174581;
			switch (num3 == num)
			{
			}
			num = (short)1941241856;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.<>c__DisplayClass22_0 CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.<>c__DisplayClass22_0();
			CS$<>8__locals1.a = window;
			CS$<>8__locals1.a.SourceInitialized += CS$<>8__locals1.b;
		}

		// Token: 0x04000038 RID: 56
		public const int GWL_STYLE = -16;

		// Token: 0x04000039 RID: 57
		public const int GWL_EXSTYLE = -20;

		// Token: 0x0400003A RID: 58
		public const int WS_EX_LAYERED = 524288;

		// Token: 0x0400003B RID: 59
		public const int WS_EX_TRANSPARENT = 32;

		// Token: 0x02000051 RID: 81
		public static class InterceptMouse
		{
			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000143 RID: 323 RVA: 0x000139DC File Offset: 0x00011BDC
			public static global::System.Windows.Point CurrentMouseLocation
			{
				get
				{
					int a_ = 18;
					if (global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.c == global::System.IntPtr.Zero)
					{
						short num = (short)1799845209;
						short num2 = num;
						num = (short)519599449;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)785711104;
							short num3 = num;
							num = (short)1388838912;
							if (num != 0)
							{
							}
							num = (short)1106706433;
							if (num != 0)
							{
							}
							throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슫\uddad쒯펱\ud8b3\udab5햹즻춽ꖿ諁ꯃ꧅ꏇ꫋ꟍꋏꇑꃓ", a_));
						}
						}
					}
					return global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.d;
				}
			}

			// Token: 0x06000144 RID: 324 RVA: 0x00013AC0 File Offset: 0x00011CC0
			public static void InstallMouseHook()
			{
				short num = (short)411173701;
				short num2 = num;
				num = (short)2027291461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)80805888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)358350849;
				if (num != 0)
				{
				}
				num = (short)1575550976;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.UninstallMouseHook();
				global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.c = global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.a(global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.b);
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00013B7C File Offset: 0x00011D7C
			public static void UninstallMouseHook()
			{
				short num = (short)1318584322;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_F7;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (!(global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.c != global::System.IntPtr.Zero))
					{
						break;
					}
					num = (short)674751433;
					short num3 = num;
					num = (short)1930027977;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1459748864;
						short num4 = num;
						num = (short)1808400385;
						if (num != 0)
						{
						}
						num = (short)466747392;
						if (num != 0)
						{
						}
						num = (short)1791557633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_F7:
					global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.UnhookWindowsHookEx(global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.c);
					num = (short)49020928;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x06000146 RID: 326 RVA: 0x00013CA8 File Offset: 0x00011EA8
			// (remove) Token: 0x06000147 RID: 327 RVA: 0x00013DDC File Offset: 0x00011FDC
			public static event global::System.EventHandler MouseLeftButtonUp
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				add
				{
					int num;
					global::System.EventHandler eventHandler;
					short num2;
					switch (0)
					{
					case 0:
						break;
					default:
						for (;;)
						{
							IL_0A:
							switch (num)
							{
							case 0:
								return;
							case 1:
							{
								global::System.EventHandler eventHandler2;
								if (eventHandler == eventHandler2)
								{
									num2 = (short)970326016;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_5E;
							}
							case 2:
								goto IL_5E;
							}
							goto IL_1C;
							IL_5E:
							num2 = (short)1528739300;
							short num3 = num2;
							num2 = (short)1603384804;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_22;
							default:
							{
								num2 = (short)1933508608;
								if (num2 != 0)
								{
								}
								num2 = (short)1483014144;
								short num4 = num2;
								global::System.EventHandler eventHandler2 = eventHandler;
								global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
								eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.a, value2, eventHandler2);
								num2 = (short)1946812417;
								num = (int)((global::System.IntPtr)num2);
								break;
							}
							}
						}
						return;
					}
					IL_1C:
					eventHandler = global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.a;
					IL_22:
					num2 = (short)135856129;
					if (num2 != 0)
					{
					}
					num2 = (short)1358430210;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				remove
				{
					int num;
					global::System.EventHandler eventHandler;
					short num2;
					switch (0)
					{
					case 0:
						break;
					default:
						for (;;)
						{
							IL_0A:
							switch (num)
							{
							case 0:
								return;
							case 1:
							{
								global::System.EventHandler eventHandler2;
								if (eventHandler == eventHandler2)
								{
									num2 = (short)1289551872;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_61;
							}
							case 2:
								num2 = (short)1379926017;
								if (num2 != 0)
								{
								}
								goto IL_61;
							}
							goto IL_1C;
							IL_61:
							num2 = (short)344178332;
							short num3 = num2;
							num2 = (short)1890565788;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_22;
							default:
							{
								num2 = (short)1202585600;
								if (num2 != 0)
								{
								}
								num2 = (short)1965752320;
								short num4 = num2;
								global::System.EventHandler eventHandler2 = eventHandler;
								global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
								eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.a, value2, eventHandler2);
								num2 = (short)768278529;
								num = (int)((global::System.IntPtr)num2);
								break;
							}
							}
						}
						return;
					}
					IL_1C:
					eventHandler = global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.a;
					IL_22:
					num2 = (short)827064322;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}

			// Token: 0x06000148 RID: 328 RVA: 0x00013F14 File Offset: 0x00012114
			private static global::System.IntPtr a(global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.LowLevelMouseProc A_0)
			{
				short num = (short)533856257;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Process currentProcess = global::System.Diagnostics.Process.GetCurrentProcess();
				global::System.IntPtr result;
				try
				{
					global::System.Diagnostics.ProcessModule mainModule = currentProcess.MainModule;
					try
					{
						result = global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.SetWindowsHookEx(14, A_0, global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.GetModuleHandle(mainModule.ModuleName), 0U);
					}
					finally
					{
						num = (short)793575426;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_B6;
							case 1:
								((global::System.IDisposable)mainModule).Dispose();
								num = (short)731381760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_81;
								}
								continue;
							}
							IL_81:
							if (mainModule == null)
							{
								break;
							}
							num = (short)426573825;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_B6:;
					}
				}
				finally
				{
					num = (short)1178861570;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_16F;
						case 1:
							goto IL_150;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_EA;
							}
							continue;
						}
						IL_EA:
						if (currentProcess == null)
						{
							break;
						}
						num = (short)1245033770;
						short num3 = num;
						num = (short)1487516970;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2105475072;
							if (num != 0)
							{
							}
							num = (short)894238721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_150:
						((global::System.IDisposable)currentProcess).Dispose();
						num = (short)475201536;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_16F:;
				}
				num = (short)1691484160;
				short num4 = num;
				return result;
			}

			// Token: 0x06000149 RID: 329 RVA: 0x000140DC File Offset: 0x000122DC
			private static global::System.IntPtr a(int A_0, global::System.IntPtr A_1, global::System.IntPtr A_2)
			{
				short num = (short)594345994;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_15A;
					case 1:
						goto IL_11A;
					case 2:
						goto IL_1F9;
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.MouseMessages mouseMessages;
						if (mouseMessages != global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.MouseMessages.b)
						{
							num = (short)180551680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)475201536;
						short num3 = num;
						num = (short)2024079368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.MouseMessages mouseMessages = (global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.MouseMessages)((int)A_1);
						num = (short)2008154118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_275;
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.MouseMessages mouseMessages;
						if (mouseMessages != global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.MouseMessages.c)
						{
							num = (short)271319047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.MSLLHOOKSTRUCT msllhookstruct = (global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.MSLLHOOKSTRUCT)global::System.Runtime.InteropServices.Marshal.PtrToStructure(A_2, typeof(global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.MSLLHOOKSTRUCT));
						global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.d.X = (double)msllhookstruct.a.a;
						global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.d.Y = (double)msllhookstruct.a.b;
						num = (short)1567621121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)239271939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.EventHandler eventHandler = global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.a;
						if (eventHandler == null)
						{
							num = (short)1156907017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						eventHandler(null, new global::System.EventArgs());
						num = (short)1268113237;
						short num4 = num;
						num = (short)1854267221;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15A;
						default:
							num = (short)1567752193;
							if (num != 0)
							{
							}
							num = (short)1168769024;
							if (num != 0)
							{
							}
							num = (short)1881735170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						goto IL_25C;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					}
					IL_50:
					if (A_0 >= 0)
					{
						num = (short)1522073604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_15A:
					num = (short)669319173;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11A:
				IL_1F9:
				IL_25C:
				IL_275:
				return global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.CallNextHookEx(global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.c, A_0, A_1, A_2);
			}

			// Token: 0x0600014A RID: 330
			[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
			private static extern global::System.IntPtr SetWindowsHookEx(int A_0, global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.LowLevelMouseProc A_1, global::System.IntPtr A_2, uint A_3);

			// Token: 0x0600014B RID: 331
			[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
			[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
			private static extern bool UnhookWindowsHookEx(global::System.IntPtr A_0);

			// Token: 0x0600014C RID: 332
			[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
			private static extern global::System.IntPtr CallNextHookEx(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, global::System.IntPtr A_3);

			// Token: 0x0600014D RID: 333
			[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
			private static extern global::System.IntPtr GetModuleHandle(string A_0);

			// Token: 0x0600014E RID: 334 RVA: 0x00014370 File Offset: 0x00012570
			// Note: this type is marked as 'beforefieldinit'.
			static InterceptMouse()
			{
				short num = (short)681294714;
				short num2 = num;
				num = (short)474790778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1866989568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1147142144;
				if (num != 0)
				{
				}
				num = (short)1598947329;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.b = new global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.LowLevelMouseProc(global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.a);
				global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.c = global::System.IntPtr.Zero;
				global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.d = default(global::System.Windows.Point);
			}

			// Token: 0x0400003C RID: 60
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private static global::System.EventHandler a;

			// Token: 0x0400003D RID: 61
			private static global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.LowLevelMouseProc b;

			// Token: 0x0400003E RID: 62
			private static global::System.IntPtr c;

			// Token: 0x0400003F RID: 63
			private static global::System.Windows.Point d;

			// Token: 0x04000040 RID: 64
			private const int e = 14;

			// Token: 0x02000052 RID: 82
			// (Invoke) Token: 0x06000150 RID: 336
			private delegate global::System.IntPtr LowLevelMouseProc(int A_0, global::System.IntPtr A_1, global::System.IntPtr A_2);

			// Token: 0x02000053 RID: 83
			private enum MouseMessages
			{
				// Token: 0x04000042 RID: 66
				a = 513,
				// Token: 0x04000043 RID: 67
				b,
				// Token: 0x04000044 RID: 68
				c = 512,
				// Token: 0x04000045 RID: 69
				d = 522,
				// Token: 0x04000046 RID: 70
				e = 516,
				// Token: 0x04000047 RID: 71
				f
			}

			// Token: 0x02000054 RID: 84
			private struct POINT
			{
				// Token: 0x04000048 RID: 72
				public int a;

				// Token: 0x04000049 RID: 73
				public int b;
			}

			// Token: 0x02000055 RID: 85
			private struct MSLLHOOKSTRUCT
			{
				// Token: 0x0400004A RID: 74
				public global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.POINT a;

				// Token: 0x0400004B RID: 75
				public uint b;

				// Token: 0x0400004C RID: 76
				public uint c;

				// Token: 0x0400004D RID: 77
				public uint d;

				// Token: 0x0400004E RID: 78
				public global::System.IntPtr e;
			}
		}
	}
}
