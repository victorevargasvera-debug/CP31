using System;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonResources;
using AcpSecurityLib;
using AcpUI.Common;

namespace AcpUI.DragDrop
{
	// Token: 0x02000069 RID: 105
	public static class DragDropManager
	{
		// Token: 0x06000556 RID: 1366 RVA: 0x0006BD6C File Offset: 0x00069F6C
		public static void SetDragSourceAdvisor(global::System.Windows.DependencyObject dependencyObj, bool isSet)
		{
			short num = (short)2070559597;
			short num2 = num;
			num = (short)636435309;
			switch (num2 == num)
			{
			default:
			{
				num = (short)344850432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)954335233;
			if (num != 0)
			{
			}
			num = (short)1905655808;
			if (num != 0)
			{
			}
			dependencyObj.SetValue(global::AcpUI.DragDrop.DragDropManager.DragSourceAdvisorProperty, isSet);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0006BE24 File Offset: 0x0006A024
		public static void SetDropTargetAdvisor(global::System.Windows.DependencyObject dependencyObj, bool isSet)
		{
			short num = (short)953914423;
			short num2 = num;
			num = (short)313693239;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1898053632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)381943809;
			if (num != 0)
			{
			}
			num = (short)739770368;
			if (num != 0)
			{
			}
			dependencyObj.SetValue(global::AcpUI.DragDrop.DragDropManager.DropTargetAdvisorProperty, isSet);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0006BEE0 File Offset: 0x0006A0E0
		public static global::AcpUI.DragDrop.IDragSourceAdvisor GetDragSourceAdvisor(global::System.Windows.DependencyObject dependencyObj)
		{
			short num = (short)1296821753;
			short num2 = num;
			num = (short)226029049;
			switch (num2 == num)
			{
			default:
			{
				num = (short)436731904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)712638464;
			if (num != 0)
			{
			}
			num = (short)1711407105;
			if (num != 0)
			{
			}
			return dependencyObj.GetValue(global::AcpUI.DragDrop.DragDropManager.DragSourceAdvisorProperty) as global::AcpUI.DragDrop.IDragSourceAdvisor;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0006BF98 File Offset: 0x0006A198
		public static global::AcpUI.DragDrop.IDropTargetAdvisor GetDropTargetAdvisor(global::System.Windows.DependencyObject dependencyObj)
		{
			short num = (short)892747254;
			short num2 = num;
			num = (short)1090797046;
			switch (num2 == num)
			{
			}
			num = (short)1769734144;
			short num3 = num;
			num = (short)1217986560;
			if (num != 0)
			{
			}
			num = (short)1573388289;
			if (num != 0)
			{
			}
			return dependencyObj.GetValue(global::AcpUI.DragDrop.DragDropManager.DropTargetAdvisorProperty) as global::AcpUI.DragDrop.IDropTargetAdvisor;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0006C054 File Offset: 0x0006A254
		private static void OnDragSourceAdvisorChanged(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::System.Windows.UIElement uielement;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (A_1.OldValue == null)
					{
						goto IL_23B;
					}
					num2 = (short)1832982307;
					short num3 = num2;
					num2 = (short)1205802787;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17B;
					default:
						num2 = (short)710410240;
						if (num2 != 0)
						{
						}
						num2 = (short)844234759;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)809893888;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (A_1.OldValue == null)
					{
						num2 = (short)366477316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_101;
				case 3:
					num2 = (short)1001193474;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_179;
				case 5:
					if (A_1.NewValue == null)
					{
						num2 = (short)92864513;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23B;
				case 6:
					if (A_1.NewValue != null)
					{
						num2 = (short)424345603;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_101;
				case 7:
					goto IL_17B;
				case 8:
					goto IL_1C9;
				}
				goto IL_34;
				IL_101:
				num2 = (short)1386545157;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_17B:
				uielement.PreviewMouseLeftButtonDown -= global::AcpUI.DragDrop.DragDropManager.a;
				uielement.PreviewMouseMove -= global::AcpUI.DragDrop.DragDropManager.a;
				uielement.PreviewMouseUp -= global::AcpUI.DragDrop.DragDropManager.b;
				num2 = (short)873725960;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_179:
			num2 = (short)645005313;
			if (num2 != 0)
			{
			}
			uielement.PreviewMouseLeftButtonDown += global::AcpUI.DragDrop.DragDropManager.a;
			uielement.PreviewMouseMove += global::AcpUI.DragDrop.DragDropManager.a;
			uielement.PreviewMouseUp += global::AcpUI.DragDrop.DragDropManager.b;
			(A_1.NewValue as global::AcpUI.DragDrop.IDragSourceAdvisor).SourceUI = uielement;
			return;
			IL_1C9:
			IL_23B:
			num2 = (short)721420288;
			short num4 = num2;
			return;
			IL_34:
			uielement = (A_0 as global::System.Windows.UIElement);
			num2 = (short)768671750;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0006C2C8 File Offset: 0x0006A4C8
		public static void TreeNavigationStart()
		{
			short num = (short)53132451;
			short num2 = num;
			num = (short)322944163;
			switch (num2 == num)
			{
			}
			num = (short)2045050880;
			short num3 = num;
			num = (short)167313409;
			if (num != 0)
			{
			}
			num = (short)1006174208;
			if (num != 0)
			{
			}
			global::AcpUI.DragDrop.DragDropManager.e = true;
			global::AcpUI.DragDrop.DragDropManager.b = false;
			global::System.Windows.Input.Mouse.Capture(null);
			global::AcpUI.DragDrop.DragDropManager.a = null;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0006C38C File Offset: 0x0006A58C
		public static void TreeNavigationStop()
		{
			short num = (short)1045194259;
			short num2 = num;
			num = (short)844654099;
			switch (num2 == num)
			{
			}
			num = (short)554106880;
			short num3 = num;
			num = (short)979566592;
			if (num != 0)
			{
			}
			num = (short)2103050241;
			if (num != 0)
			{
			}
			global::AcpUI.DragDrop.DragDropManager.e = false;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0006C438 File Offset: 0x0006A638
		private static void b(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1644284708;
			short num2 = num;
			num = (short)140299044;
			switch (num2 == num)
			{
			}
			num = (short)1128333312;
			short num3 = num;
			num = (short)1656029185;
			if (num != 0)
			{
			}
			num = (short)242417664;
			if (num != 0)
			{
			}
			global::AcpUI.DragDrop.DragDropManager.b = false;
			global::System.Windows.Input.Mouse.Capture(null);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0006C4F4 File Offset: 0x0006A6F4
		private static void OnDropTargetAdvisorChanged(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)485687297;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_5A;
			}
			int num2;
			global::System.Windows.UIElement uielement;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
				{
					if (A_1.OldValue == null)
					{
						goto IL_264;
					}
					num = (short)319937275;
					short num3 = num;
					num = (short)791599867;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19A;
					default:
						num = (short)444727296;
						if (num != 0)
						{
						}
						num = (short)1108869127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)241303552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (A_1.OldValue == null)
					{
						num = (short)890306564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11F;
				case 3:
					num = (short)1649278978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_198;
				case 5:
					if (A_1.NewValue == null)
					{
						num = (short)927989761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_264;
				case 6:
					if (A_1.NewValue != null)
					{
						num = (short)1753677827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11F;
				case 7:
					goto IL_19A;
				case 8:
					goto IL_200;
				}
				goto IL_5A;
				IL_11F:
				num = (short)384172037;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_19A:
				uielement.PreviewDragEnter -= global::AcpUI.DragDrop.DragDropManager.a;
				uielement.PreviewDragOver -= global::AcpUI.DragDrop.DragDropManager.b;
				uielement.PreviewDragLeave -= global::AcpUI.DragDrop.DragDropManager.c;
				uielement.PreviewDrop -= global::AcpUI.DragDrop.DragDropManager.d;
				uielement.AllowDrop = false;
				num = (short)1869152264;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_198:
			uielement.PreviewDragEnter += global::AcpUI.DragDrop.DragDropManager.a;
			uielement.PreviewDragOver += global::AcpUI.DragDrop.DragDropManager.b;
			uielement.PreviewDragLeave += global::AcpUI.DragDrop.DragDropManager.c;
			uielement.PreviewDrop += global::AcpUI.DragDrop.DragDropManager.d;
			uielement.AllowDrop = true;
			(A_1.NewValue as global::AcpUI.DragDrop.IDropTargetAdvisor).TargetUI = uielement;
			return;
			IL_200:
			IL_264:
			num = (short)693764096;
			short num4 = num;
			return;
			IL_5A:
			uielement = (A_0 as global::System.Windows.UIElement);
			num = (short)1856241670;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0006C790 File Offset: 0x0006A990
		private static void d(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)269221894;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_164;
				case 1:
					goto IL_141;
				case 2:
				{
					num = (short)1245798936;
					short num3 = num;
					num = (short)1352884760;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
					{
						num = (short)599588864;
						if (num != 0)
						{
						}
						global::System.Windows.Point position = A_1.GetPosition(global::AcpUI.DragDrop.DragDropManager.d);
						global::System.Windows.Point position2;
						position2.X -= position.X;
						position2.Y -= position.Y;
						num = (short)1313734664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
				{
					global::AcpUI.DragDrop.IDropTargetAdvisor dropTargetAdvisor = global::AcpUI.DragDrop.DragDropManager.GetDropTargetAdvisor(A_0 as global::System.Windows.DependencyObject);
					global::System.Windows.Point position2 = A_1.GetPosition(A_0 as global::System.Windows.UIElement);
					num = (short)1121058817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_1A7;
				case 5:
				{
					global::AcpUI.DragDrop.IDropTargetAdvisor dropTargetAdvisor;
					dropTargetAdvisor.SetProcess(global::AcpUI.DragDrop.DragDropManager.f);
					global::System.Windows.Point position2;
					dropTargetAdvisor.OnDropCompleted(A_1.Data, position2, dropTargetAdvisor.ConsumerNode);
					num = (short)1287323648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 7:
					if (global::AcpUI.DragDrop.DragDropManager.a())
					{
						num = (short)1769799685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_164;
				case 8:
					goto IL_AA;
				}
				IL_4A:
				if (global::AcpUI.DragDrop.DragDropManager.UpdateEffects(A_0, A_1))
				{
					num = (short)35979267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AA:
				num = (short)932315136;
				short num4 = num;
				num = (short)1764818951;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_141:
				if (global::AcpUI.DragDrop.DragDropManager.d != null)
				{
					num = (short)25821186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_AA;
				IL_164:
				global::AcpUI.DragDrop.DragDropManager.b();
				num = (short)1885863937;
				if (num != 0)
				{
				}
				num = (short)2022965252;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A7:
			A_1.Handled = true;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0006C9F0 File Offset: 0x0006ABF0
		private static void c(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)404226049;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::AcpUI.DragDrop.DragDropManager.b();
					num = (short)1026949120;
					short num3 = num;
					num = (short)2109931522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_E2;
				}
				IL_30:
				num = (short)1375438637;
				short num4 = num;
				num = (short)611026733;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)895090688;
					if (num != 0)
					{
					}
					if (!global::AcpUI.DragDrop.DragDropManager.UpdateEffects(A_0, A_1))
					{
						goto IL_10C;
					}
					num = (short)2052456448;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E2:
			num = (short)1748238337;
			if (num != 0)
			{
			}
			IL_10C:
			A_1.Handled = true;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0006CB10 File Offset: 0x0006AD10
		private static void b(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)1476067330;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B9;
				case 1:
				{
					if (global::AcpUI.DragDrop.DragDropManager.d == null)
					{
						goto IL_17B;
					}
					num = (short)630390785;
					if (num != 0)
					{
					}
					num = (short)1214032187;
					short num3 = num;
					num = (short)1246013755;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1117257728;
						if (num != 0)
						{
						}
						num = (short)322895876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
				{
					num = (short)445644800;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				case 3:
				{
					global::System.Windows.Point position = A_1.GetPosition(A_0 as global::System.Windows.UIElement);
					num = (short)1077215233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					global::System.Windows.Point position;
					global::AcpUI.DragDrop.DragDropManager.d.Left = position.X;
					global::AcpUI.DragDrop.DragDropManager.d.Top = position.Y;
					num = (short)484048896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_61:
				if (!global::AcpUI.DragDrop.DragDropManager.UpdateEffects(A_0, A_1))
				{
					break;
				}
				num = (short)1948844035;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B9:
			IL_17B:
			A_1.Handled = true;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0006CCA0 File Offset: 0x0006AEA0
		private static void a(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)1823932417;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)959643648;
					short num3 = num;
					global::System.Windows.UIElement visualFeedback = global::AcpUI.DragDrop.DragDropManager.GetDropTargetAdvisor(A_0 as global::System.Windows.DependencyObject).GetVisualFeedback(A_1.Data);
					global::AcpUI.DragDrop.DragDropManager.a(A_0 as global::System.Windows.UIElement, visualFeedback);
					num = (short)2113470466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					goto IL_12D;
				}
				IL_32:
				num = (short)1708887484;
				short num4 = num;
				num = (short)1416859068;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2142896128;
					if (num != 0)
					{
					}
					num = (short)225640449;
					if (num != 0)
					{
					}
					if (!global::AcpUI.DragDrop.DragDropManager.UpdateEffects(A_0, A_1))
					{
						goto IL_12F;
					}
					num = (short)792002560;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_12D:
			IL_12F:
			A_1.Handled = true;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0006CDE4 File Offset: 0x0006AFE4
		public static bool UpdateEffects(object uiObject, global::System.Windows.DragEventArgs e)
		{
			short num = (short)275906560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C8;
				}
				global::AcpUI.DragDrop.IDropTargetAdvisor dropTargetAdvisor;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_730;
					case 1:
						num = (short)494862360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!dropTargetAdvisor.IsValidDataObject(e.Data))
						{
							num = (short)297074725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1267597321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_436;
					case 4:
						if ((e.AllowedEffects & global::System.Windows.DragDropEffects.Copy) != global::System.Windows.DragDropEffects.None)
						{
							goto IL_6C9;
						}
						return true;
					case 5:
						goto IL_4F7;
					case 6:
						num = (short)1227423748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_409;
					case 8:
						goto IL_13D;
					case 9:
						if (!dropTargetAdvisor.IsDropAllowedByApp(e.Data))
						{
							num = (short)229900311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)920584210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)769196039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1803419673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (!dropTargetAdvisor.IsDropAllowed(e))
						{
							num = (short)1296957468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D5;
					case 12:
						goto IL_62D;
					case 13:
						if ((e.AllowedEffects & global::System.Windows.DragDropEffects.Move) == global::System.Windows.DragDropEffects.None)
						{
							num = (short)1211432975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19A;
					case 14:
						goto IL_5C3;
					case 15:
						num = (short)508428317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
						num = (short)576389128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)1915289611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (!dropTargetAdvisor.IsDropAllowedByLocalApp(e.Data))
						{
							num = (short)1429340161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dropTargetAdvisor.ConsumerNode = dropTargetAdvisor.IsValidConsumerNode(uiObject, e);
						num = (short)543031328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)598540298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1761673246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
						num = (short)1907621891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)776536090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)2006712354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport == null)
						{
							num = (short)1019215893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.Clear();
						num = (short)928251904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (dropTargetAdvisor.ConsumerNode != null)
						{
							num = (short)642187281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D5;
					case 26:
						e.Effects = (((e.KeyStates & global::System.Windows.DragDropKeyStates.ControlKey) != global::System.Windows.DragDropKeyStates.None) ? global::System.Windows.DragDropEffects.Copy : global::System.Windows.DragDropEffects.Move);
						num = (short)1098907662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_4A8;
					case 28:
						goto IL_21B;
					case 29:
						if ((e.AllowedEffects & global::System.Windows.DragDropEffects.Copy) == global::System.Windows.DragDropEffects.None)
						{
							num = (short)791478305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19A;
					case 30:
						if (global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport == null)
						{
							num = (short)498794532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.Clear();
						num = (short)876544005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if ((e.AllowedEffects & global::System.Windows.DragDropEffects.Move) != global::System.Windows.DragDropEffects.None)
						{
							num = (short)1123811334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 32:
						num = (short)514981889;
						if (num != 0)
						{
						}
						if (dropTargetAdvisor.ConsumerNode != null)
						{
							num = (short)8060947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191;
					case 33:
						goto IL_53A;
					case 34:
					{
						if (global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport == null)
						{
							num = (short)1232535568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.Clear();
						num = (short)254790560;
						short num3 = num;
						num = (short)1985727392;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6C9;
						default:
							num = (short)1639579648;
							if (num != 0)
							{
							}
							num = (short)1393164315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 35:
						if (!dropTargetAdvisor.IsDropAllowedByApplicationLanguage(e.Data))
						{
							num = (short)1652228116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2047803394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
						num = (short)648282124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_699;
					}
					goto IL_C8;
					IL_19A:
					num = (short)999751711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D5:
					num = (short)1977548813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C9:
					num = (short)1610481686;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13D:
				goto IL_57F;
				IL_191:
				e.Effects = global::System.Windows.DragDropEffects.None;
				return true;
				IL_21B:
				e.Effects = global::System.Windows.DragDropEffects.None;
				return true;
				IL_409:
				goto IL_191;
				IL_436:
				goto IL_6E7;
				IL_4A8:
				num = (short)694878208;
				short num4 = num;
				goto IL_57F;
				IL_4F7:
				goto IL_62F;
				IL_53A:
				e.Effects = global::System.Windows.DragDropEffects.None;
				return true;
				IL_57F:
				string app_Versioning_Rules_No_Drop_Allowed = global::AcpCommonResources.AcpResources.App_Versioning_Rules_No_Drop_Allowed;
				global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, app_Versioning_Rules_No_Drop_Allowed, false);
				global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.FieldsReportChanged = true;
				e.Effects = global::System.Windows.DragDropEffects.None;
				return true;
				IL_5C3:
				return true;
				IL_62D:
				IL_62F:
				string app_Language_Rules_No_Drop_Allowed = global::AcpCommonResources.AcpResources.App_Language_Rules_No_Drop_Allowed;
				global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, app_Language_Rules_No_Drop_Allowed, false);
				global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.FieldsReportChanged = true;
				e.Effects = global::System.Windows.DragDropEffects.None;
				return true;
				IL_699:
				e.Effects = global::System.Windows.DragDropEffects.None;
				return false;
				IL_6E7:
				string local_App_Versioning_Rules_No_Drop_Allowed = global::AcpCommonResources.AcpResources.Local_App_Versioning_Rules_No_Drop_Allowed;
				global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, local_App_Versioning_Rules_No_Drop_Allowed, false);
				global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.FieldsReportChanged = true;
				e.Effects = global::System.Windows.DragDropEffects.None;
				return true;
				IL_730:
				goto IL_6E7;
				IL_C8:
				dropTargetAdvisor = global::AcpUI.DragDrop.DragDropManager.GetDropTargetAdvisor(uiObject as global::System.Windows.DependencyObject);
				num = (short)196542499;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0006D534 File Offset: 0x0006B734
		private static void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)16318466;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C2;
				case 1:
				{
					if (global::AcpUI.DragDrop.DragDropManager.GetDragSourceAdvisor(A_0 as global::System.Windows.DependencyObject).IsDraggable(A_1.OriginalSource as global::System.Windows.UIElement))
					{
						num = (short)1712586752;
						short num3 = num;
						global::AcpUI.DragDrop.DragDropManager.a = (A_1.Source as global::System.Windows.UIElement);
						global::AcpUI.DragDrop.DragDropManager.c = A_1.GetPosition(global::AcpUI.DragDrop.DragDropManager.c());
						global::AcpUI.DragDrop.DragDropManager.b = true;
						num = (short)1945763840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)898496152;
					short num4 = num;
					num = (short)210237080;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)424738816;
						if (num != 0)
						{
						}
						num = (short)245039108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 3:
					num = (short)292683777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_161;
				}
				IL_39:
				if (global::AcpUI.DragDrop.DragDropManager.e)
				{
					break;
				}
				num = (short)1970798595;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C2:
			return;
			IL_161:
			num = (short)514064385;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0006D6D0 File Offset: 0x0006B8D0
		private static void a(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)397344768;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)534258506;
				short num3 = num;
				num = (short)1345528650;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1892352000;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_14;
					case 1:
						goto IL_F1;
					case 2:
						num = (short)414580737;
						if (num != 0)
						{
						}
						num = (short)2050555908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						global::AcpUI.DragDrop.DragDropManager.a(A_0 as global::System.Windows.UIElement);
						num = (short)1681719297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (global::AcpUI.DragDrop.DragDropManager.a(A_1.GetPosition(global::AcpUI.DragDrop.DragDropManager.c())))
						{
							num = (short)1762394115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_84;
				}
				IL_14:
				switch (0)
				{
				case 0:
					IL_84:
					if (!global::AcpUI.DragDrop.DragDropManager.b)
					{
						return;
					}
					num = (short)381419522;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F1:
			num = (short)304283648;
			short num4 = num;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0006D840 File Offset: 0x0006BA40
		private static void a(global::System.Windows.UIElement A_0)
		{
			short num = (short)1526202368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_9E;
				}
				for (;;)
				{
					IL_28:
					num = (short)1761884827;
					short num3 = num;
					num = (short)395328155;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1673199616;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							global::System.Windows.DataObject dataObject;
							if (dataObject != null)
							{
								num = (short)1132003329;
								if (num != 0)
								{
								}
								num = (short)52822023;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19D;
						}
						case 1:
							if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
							{
								num = (short)1948254211;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_242;
						case 2:
							goto IL_17C;
						case 3:
						{
							global::System.Windows.Input.Mouse.Capture(A_0);
							global::AcpUI.DragDrop.IDragSourceAdvisor dragSourceAdvisor = global::AcpUI.DragDrop.DragDropManager.GetDragSourceAdvisor(A_0);
							global::System.Windows.DataObject dataObject = dragSourceAdvisor.GetDataObject(global::AcpUI.DragDrop.DragDropManager.a);
							global::System.Windows.DragDropEffects supportedEffects = dragSourceAdvisor.SupportedEffects;
							num = (short)1375600642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Windows.DragDropEffects supportedEffects;
							if (supportedEffects != global::System.Windows.DragDropEffects.None)
							{
								num = (short)219414534;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19D;
						}
						case 5:
							num = (short)2124873728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							try
							{
								global::System.Windows.DataObject dataObject;
								global::System.Windows.DragDropEffects supportedEffects;
								global::System.Windows.DragDropEffects finalEffects = global::System.Windows.DragDrop.DoDragDrop(global::AcpUI.DragDrop.DragDropManager.a, dataObject, supportedEffects);
								global::AcpUI.DragDrop.IDragSourceAdvisor dragSourceAdvisor;
								dragSourceAdvisor.FinishDrag(global::AcpUI.DragDrop.DragDropManager.a, finalEffects);
								goto IL_19D;
							}
							catch (global::System.Exception)
							{
								goto IL_19D;
							}
							goto IL_242;
						case 7:
						{
							num = (short)417792000;
							short num4 = num;
							num = (short)343801860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_1BB;
						}
						goto IL_9E;
					}
					IL_17C:
					if (global::AcpUI.DragDrop.DragDropManager.a != null)
					{
						num = (short)1935409157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_19D:
					global::AcpUI.DragDrop.DragDropManager.b();
					num = (short)1366687752;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1BB:
				IL_242:
				global::System.Windows.Input.Mouse.Capture(null);
				global::AcpUI.DragDrop.DragDropManager.a = null;
				return;
				IL_9E:
				global::AcpUI.DragDrop.DragDropManager.b = false;
				num = (short)1177223169;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0006DAAC File Offset: 0x0006BCAC
		private static bool a(global::System.Windows.Point A_0)
		{
			short num = (short)772145152;
			short num2 = num;
			num = (short)773846437;
			short num3 = num;
			num = (short)1790703013;
			switch (num3 == num)
			{
			}
			num = (short)1874919425;
			if (num != 0)
			{
			}
			num = (short)482869248;
			if (num != 0)
			{
			}
			bool flag = global::System.Math.Abs(A_0.X - global::AcpUI.DragDrop.DragDropManager.c.X) > global::System.Windows.SystemParameters.MinimumHorizontalDragDistance;
			bool flag2 = global::System.Math.Abs(A_0.Y - global::AcpUI.DragDrop.DragDropManager.c.Y) > global::System.Windows.SystemParameters.MinimumVerticalDragDistance;
			return flag || flag2;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0006DB94 File Offset: 0x0006BD94
		private static global::System.Windows.UIElement c()
		{
			short num = (short)1456865280;
			short num2 = num;
			num = (short)749666305;
			if (num != 0)
			{
			}
			num = (short)537056024;
			short num3 = num;
			num = (short)524473112;
			switch (num3 == num)
			{
			}
			num = (short)1115750400;
			if (num != 0)
			{
			}
			return global::System.Windows.Application.Current.MainWindow.Content as global::System.Windows.UIElement;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0006DC50 File Offset: 0x0006BE50
		private static void a(global::System.Windows.UIElement A_0, global::System.Windows.UIElement A_1)
		{
			short num = (short)1597702144;
			short num2 = num;
			num = (short)994694042;
			short num3 = num;
			num = (short)560255898;
			switch (num3 == num)
			{
			}
			num = (short)863567873;
			if (num != 0)
			{
			}
			num = (short)124715008;
			if (num != 0)
			{
			}
			global::AcpUI.DragDrop.DragDropManager.b();
			global::System.Windows.Documents.AdornerLayer adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(global::AcpUI.DragDrop.DragDropManager.c());
			global::AcpUI.DragDrop.DragDropManager.d = new global::AcpUI.DragDrop.DropPreviewAdorner(A_1, A_0);
			adornerLayer.Add(global::AcpUI.DragDrop.DragDropManager.d);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0006DD1C File Offset: 0x0006BF1C
		private static void b()
		{
			short num = (short)834469888;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
					global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(global::AcpUI.DragDrop.DragDropManager.c()).Remove(global::AcpUI.DragDrop.DragDropManager.d);
					global::AcpUI.DragDrop.DragDropManager.d = null;
					num = (short)378142722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				}
				goto IL_80;
				IL_14:
				num = (short)247136257;
				if (num != 0)
				{
				}
				num = (short)103612416;
				short num3 = num;
				switch (0)
				{
				case 0:
				{
					IL_80:
					if (global::AcpUI.DragDrop.DragDropManager.d == null)
					{
						return;
					}
					num = (short)2031061780;
					short num4 = num;
					num = (short)517180180;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)891224064;
						if (num != 0)
						{
						}
						num = (short)1327235073;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0006DE48 File Offset: 0x0006C048
		private static bool a()
		{
			int num;
			short num2;
			bool result;
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
						if (global::AcpSecurityLib.SecurityManager.IsSpecialKeyLoaded)
						{
							num2 = (short)471793667;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
						goto IL_B8;
					case 2:
						goto IL_9A;
					case 3:
						num2 = (short)1469644805;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						result = true;
						num2 = (short)1472069633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (global::AcpSecurityLib.SecurityManager.CheckIfSpecialKeyIsAttached())
						{
							num2 = (short)44433412;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = false;
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.RegisterFieldInReport(null, global::AcpCommonResources.AcpResources.Drop_Failed_No_Key, false);
						global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.FieldsReportChanged = true;
						num2 = (short)86179842;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28;
				}
				IL_9A:
				return result;
				IL_B8:
				num2 = (short)904089811;
				short num3 = num2;
				num2 = (short)1955418323;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2A;
				case 1:
					break;
				default:
				{
					num2 = (short)453705728;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)1798176768;
				if (num2 != 0)
				{
				}
				num2 = (short)1732050945;
				if (num2 != 0)
				{
				}
				return result;
			}
			}
			IL_28:
			result = true;
			IL_2A:
			num2 = (short)790036480;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0006DFE8 File Offset: 0x0006C1E8
		public static void SetDnDProcess(global::AcpCommonLib.IAcpBatchOperation process)
		{
			short num = (short)2036727808;
			short num2 = num;
			num = (short)13300653;
			short num3 = num;
			num = (short)199160749;
			switch (num3 == num)
			{
			}
			num = (short)719257601;
			if (num != 0)
			{
			}
			num = (short)565313536;
			if (num != 0)
			{
			}
			global::AcpUI.DragDrop.DragDropManager.f = process;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0006E098 File Offset: 0x0006C298
		// Note: this type is marked as 'beforefieldinit'.
		static DragDropManager()
		{
			int a_ = 16;
			short num = (short)230752256;
			short num2 = num;
			num = (short)1118108088;
			short num3 = num;
			num = (short)1788541368;
			switch (num3 == num)
			{
			}
			num = (short)1342570497;
			if (num != 0)
			{
			}
			num = (short)1814495232;
			if (num != 0)
			{
			}
			global::AcpUI.DragDrop.DragDropManager.e = false;
			global::AcpUI.DragDrop.DragDropManager.DragSourceAdvisorProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udaa7쮩쮫ﶭ\udfaf잱욳햵\uddb7﮹\ud8bb좽ꦿ뇁ꯃ듅", a_), typeof(global::AcpUI.DragDrop.IDragSourceAdvisor), typeof(global::AcpUI.DragDrop.DragDropManager), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::AcpUI.DragDrop.DragDropManager.OnDragSourceAdvisorChanged)));
			global::AcpUI.DragDrop.DragDropManager.DropTargetAdvisorProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("\udaa7얩\udcab節톯삱펳펵첷﮹\ud8bb좽ꦿ뇁ꯃ듅", a_), typeof(global::AcpUI.DragDrop.IDropTargetAdvisor), typeof(global::AcpUI.DragDrop.DragDropManager), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::AcpUI.DragDrop.DragDropManager.OnDropTargetAdvisorChanged)));
		}

		// Token: 0x040002E6 RID: 742
		private static global::System.Windows.UIElement a;

		// Token: 0x040002E7 RID: 743
		private static bool b;

		// Token: 0x040002E8 RID: 744
		private static global::System.Windows.Point c;

		// Token: 0x040002E9 RID: 745
		private static global::AcpUI.DragDrop.DropPreviewAdorner d;

		// Token: 0x040002EA RID: 746
		private static bool e;

		// Token: 0x040002EB RID: 747
		public static readonly global::System.Windows.DependencyProperty DragSourceAdvisorProperty;

		// Token: 0x040002EC RID: 748
		public static readonly global::System.Windows.DependencyProperty DropTargetAdvisorProperty;

		// Token: 0x040002ED RID: 749
		private static global::AcpCommonLib.IAcpBatchOperation f;
	}
}
