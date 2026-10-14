using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;
using Infragistics.Controls.Menus;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree
{
	// Token: 0x0200013B RID: 315
	public class CustomRightMouseDownBehaviour : global::System.Windows.Interactivity.Behavior<global::Infragistics.Controls.Menus.XamDataTree>
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0009E718 File Offset: 0x0009C918
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x0009E7C8 File Offset: 0x0009C9C8
		public bool Activate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1743060993;
				if (num != 0)
				{
				}
				num = (short)1220260057;
				short num2 = num;
				num = (short)504803545;
				switch (num2 == num)
				{
				}
				num = (short)92667904;
				short num3 = num;
				num = (short)679936000;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)1557251390;
				short num2 = num;
				num = (short)1950729534;
				switch (num2 == num)
				{
				}
				num = (short)1501102080;
				if (num != 0)
				{
				}
				num = (short)491323392;
				short num3 = num;
				num = (short)618725377;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0009E878 File Offset: 0x0009CA78
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x0009E928 File Offset: 0x0009CB28
		public bool Select
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1035742929;
				short num2 = num;
				num = (short)1920085713;
				switch (num2 == num)
				{
				}
				num = (short)21954561;
				if (num != 0)
				{
				}
				num = (short)1438973952;
				short num3 = num;
				num = (short)1611595776;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)709368522;
				short num2 = num;
				num = (short)2139298506;
				switch (num2 == num)
				{
				}
				num = (short)626327553;
				if (num != 0)
				{
				}
				num = (short)1831075840;
				short num3 = num;
				num = (short)871104512;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0009E9D4 File Offset: 0x0009CBD4
		public bool CanBeDetached
		{
			get
			{
				while (!this.Activate)
				{
					short num = (short)986575985;
					short num2 = num;
					num = (short)162985073;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)744357888;
						short num3 = num;
						num = (short)152305665;
						if (num != 0)
						{
						}
						num = (short)762642432;
						if (num != 0)
						{
						}
						return !this.Select;
					}
					}
				}
				return false;
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0009EA94 File Offset: 0x0009CC94
		protected override void OnAttached()
		{
			short num = (short)2020771771;
			short num2 = num;
			num = (short)512657339;
			switch (num2 == num)
			{
			}
			num = (short)1555300353;
			if (num != 0)
			{
			}
			num = (short)1238761472;
			short num3 = num;
			num = (short)1729232896;
			if (num != 0)
			{
			}
			base.AssociatedObject.PreviewMouseRightButtonDown += this.a;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0009EB54 File Offset: 0x0009CD54
		protected override void OnDetaching()
		{
			short num = (short)859070636;
			short num2 = num;
			num = (short)2002739372;
			switch (num2 == num)
			{
			}
			num = (short)1167130624;
			if (num != 0)
			{
			}
			num = (short)541982720;
			short num3 = num;
			num = (short)1620312065;
			if (num != 0)
			{
			}
			base.AssociatedObject.PreviewMouseRightButtonDown -= this.a;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0009EC14 File Offset: 0x0009CE14
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					A_1.Handled = true;
					global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree;
					num2 = (short)1040252932;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (xamDataTreeNode != null)
					{
						num2 = (short)446889989;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected)
					{
						num2 = (short)1539375104;
						short num3 = num2;
						num2 = (short)1905983488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.a((global::Infragistics.Controls.Menus.XamDataTree)A_0, xamDataTreeNode);
					goto IL_12D;
				case 3:
					return;
				case 4:
				{
					num2 = (short)404057030;
					short num4 = num2;
					num2 = (short)1479437254;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12D;
					default:
					{
						num2 = (short)705363968;
						if (num2 != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree;
						if (rmdataTree != null)
						{
							num2 = (short)580780039;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_72;
					}
					}
					break;
				}
				case 5:
					num2 = (short)1868300290;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_BB;
				case 7:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree;
					rmdataTree.RaiseConnectionToServerLostEvent(rmdataTree, null);
					num2 = (short)809631750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_30;
				IL_12D:
				num2 = (short)941555715;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_72:
			num2 = (short)1179910145;
			if (num2 != 0)
			{
			}
			return;
			IL_BB:
			goto IL_72;
			IL_30:
			xamDataTreeNode = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.a(A_1.OriginalSource as global::System.Windows.DependencyObject);
			num2 = (short)1800994817;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0009EE00 File Offset: 0x0009D000
		private void a(global::Infragistics.Controls.Menus.XamDataTree A_0, global::Infragistics.Controls.Menus.XamDataTreeNode A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodes;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_13E;
				case 1:
				{
					num2 = (short)512557056;
					short num3 = num2;
					if (!selectedNodes.Contains(A_1))
					{
						num2 = (short)510197766;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					A_0.SelectionSettings.SelectedNodes.Clear();
					num2 = (short)1282605063;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (this.Activate)
					{
						num2 = (short)1434583044;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB;
				case 4:
					A_1.IsActive = true;
					num2 = (short)1089536010;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return;
				case 6:
					num2 = (short)506068992;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_EA;
				case 8:
					if (this.Select)
					{
						num2 = (short)564002825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
				{
					num2 = (short)1487601665;
					if (num2 != 0)
					{
					}
					A_1.IsSelected = true;
					num2 = (short)100707131;
					short num4 = num2;
					num2 = (short)837921595;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13E;
					default:
						num2 = (short)1836056576;
						if (num2 != 0)
						{
						}
						num2 = (short)364969989;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					goto IL_AB;
				}
				goto IL_3C;
				IL_AB:
				num2 = (short)182386696;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_EA:
				num2 = (short)444071939;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_13E:
				if (global::System.Windows.Input.Keyboard.Modifiers.HasFlag(global::System.Windows.Input.ModifierKeys.Control))
				{
					goto IL_EA;
				}
				num2 = (short)467664898;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_3C:
			selectedNodes = A_0.SelectionSettings.SelectedNodes;
			num2 = (short)898236417;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0009F068 File Offset: 0x0009D268
		private static global::Infragistics.Controls.Menus.XamDataTreeNode a(global::System.Windows.DependencyObject A_0)
		{
			short num = (short)581828611;
			int num2 = (int)((global::System.IntPtr)num);
			global::Infragistics.Controls.Menus.XamDataTreeNode result;
			for (;;)
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
				switch (num2)
				{
				case 0:
					goto IL_11C;
				case 1:
				{
					num = (short)1196425217;
					if (num != 0)
					{
					}
					global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = A_0 as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
					if (xamDataTreeNodeControl == null)
					{
						num = (short)535101445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					xamDataTreeNode = xamDataTreeNodeControl.Node;
					goto IL_11E;
				}
				case 2:
					goto IL_142;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
				{
					num = (short)1169429456;
					short num3 = num;
					num = (short)433394640;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_55;
					default:
						num = (short)780468224;
						if (num != 0)
						{
						}
						num = (short)1817968640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					xamDataTreeNode = null;
					goto IL_11E;
				}
				IL_3C:
				if (A_0 == null)
				{
					num = (short)1326383108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_55:
				num = (short)1177419777;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11E:
				if ((result = xamDataTreeNode) != null)
				{
					return result;
				}
				num = (short)1377107970;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11C:
			return null;
			IL_142:
			num = (short)560201728;
			short num4 = num;
			result = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.a(global::System.Windows.Media.VisualTreeHelper.GetParent(A_0));
			return result;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0009F204 File Offset: 0x0009D404
		internal static string c(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1841874846 + A_1) + (global::System.IntPtr)85 + (global::System.IntPtr)67 + (global::System.IntPtr)41 + (global::System.IntPtr)8 + (global::System.IntPtr)48);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x04000465 RID: 1125
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a;

		// Token: 0x04000466 RID: 1126
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;
	}
}
