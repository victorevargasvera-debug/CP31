using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Controls.Menus;
using Infragistics.DragDrop;
using Infragistics.Windows;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000100 RID: 256
	public class RMGroupList : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000769 RID: 1897 RVA: 0x0007683C File Offset: 0x00074A3C
		public RMGroupList()
		{
			this.InitializeComponent();
			base.PreviewMouseWheel += global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.ScrollViewer_PreviewMouseWheel;
			global::Microsoft.Practices.Prism.Events.IEventAggregator instance = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>();
			instance.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.SelectGroupInGroupsView>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(this.a));
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0007688C File Offset: 0x00074A8C
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00076944 File Offset: 0x00074B44
		public bool AllowEdit
		{
			get
			{
				short num = (short)1481272476;
				short num2 = num;
				num = (short)1162505372;
				switch (num2 == num)
				{
				}
				num = (short)1282539520;
				short num3 = num;
				num = (short)929103872;
				if (num != 0)
				{
				}
				num = (short)337248257;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.AllowEditProperty);
			}
			set
			{
				short num = (short)912655589;
				short num2 = num;
				num = (short)1279263973;
				switch (num2 == num)
				{
				}
				num = (short)1261961216;
				short num3 = num;
				num = (short)1378222081;
				if (num != 0)
				{
				}
				num = (short)1431961600;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.AllowEditProperty, value);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00076A00 File Offset: 0x00074C00
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00076ABC File Offset: 0x00074CBC
		public bool AllowRestoreExpandedNodes
		{
			get
			{
				short num = (short)1337681291;
				short num2 = num;
				num = (short)1151165835;
				switch (num2 == num)
				{
				}
				num = (short)568918016;
				short num3 = num;
				num = (short)313720833;
				if (num != 0)
				{
				}
				num = (short)1710292992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.AllowRestoreExpandedNodesProperty);
			}
			set
			{
				short num = (short)1636535076;
				short num2 = num;
				num = (short)1051757348;
				switch (num2 == num)
				{
				}
				num = (short)932118528;
				short num3 = num;
				num = (short)1022558209;
				if (num != 0)
				{
				}
				num = (short)983040000;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.AllowRestoreExpandedNodesProperty, value);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00076B78 File Offset: 0x00074D78
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x00076C34 File Offset: 0x00074E34
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> Groups
		{
			get
			{
				short num = (short)2102213083;
				short num2 = num;
				num = (short)425474523;
				switch (num2 == num)
				{
				}
				num = (short)596901888;
				short num3 = num;
				num = (short)1775042561;
				if (num != 0)
				{
				}
				num = (short)2145583104;
				if (num != 0)
				{
				}
				return (global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.GroupsProperty);
			}
			set
			{
				short num = (short)1055404804;
				short num2 = num;
				num = (short)124990212;
				switch (num2 == num)
				{
				}
				num = (short)90308608;
				short num3 = num;
				num = (short)1748369408;
				if (num != 0)
				{
				}
				num = (short)51904513;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.GroupsProperty, value);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00076CF0 File Offset: 0x00074EF0
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00076DAC File Offset: 0x00074FAC
		public bool AllowDragAndDrop
		{
			get
			{
				short num = (short)1056178177;
				if (num != 0)
				{
				}
				num = (short)55240871;
				short num2 = num;
				num = (short)1112926375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101791232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1573257216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.AllowDragAndDropProperty);
			}
			set
			{
				short num = (short)993580585;
				short num2 = num;
				num = (short)783078953;
				switch (num2 == num)
				{
				}
				num = (short)1539309568;
				short num3 = num;
				num = (short)1774256129;
				if (num != 0)
				{
				}
				num = (short)626589696;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.AllowDragAndDropProperty, value);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00076E64 File Offset: 0x00075064
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00076F20 File Offset: 0x00075120
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group SelectedGroup
		{
			get
			{
				short num = (short)1969252096;
				short num2 = num;
				num = (short)1178887936;
				switch (num2 == num)
				{
				}
				num = (short)1160970240;
				short num3 = num;
				num = (short)1730347008;
				if (num != 0)
				{
				}
				num = (short)1614217217;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.Group)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.SelectedGroupProperty);
			}
			set
			{
				short num = (short)265289729;
				if (num != 0)
				{
				}
				num = (short)104726530;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.SelectedGroupProperty, value);
						num = (short)693043200;
						short num3 = num;
						num = (short)644895720;
						short num4 = num;
						num = (short)642995176;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1027407872;
							if (num != 0)
							{
							}
							num = (short)2037448705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					}
					IL_56:
					if (object.Equals(value, base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.SelectedGroupProperty)))
					{
						break;
					}
					num = (short)1578893312;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0007704C File Offset: 0x0007524C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList rmgroupList;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E7;
				case 1:
					global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.a(rmgroupList.GroupTree, (global::Motorola.CommonCPS.RadioManagement.UIModels.Group)A_1.NewValue, rmgroupList.MyDevices, rmgroupList.AllowRestoreExpandedNodes);
					num2 = (short)2135818243;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if ((global::Motorola.CommonCPS.RadioManagement.UIModels.Group)A_1.NewValue != null)
					{
						num2 = (short)376832004;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					num2 = (short)1552547841;
					if (num2 != 0)
					{
					}
					num2 = (short)574160901;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if ((global::Motorola.CommonCPS.RadioManagement.UIModels.Group)A_1.OldValue != null)
					{
						num2 = (short)1083899905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
				{
					num2 = (short)438862934;
					short num3 = num2;
					num2 = (short)652772438;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1869152256;
						if (num2 != 0)
						{
						}
						if (rmgroupList.GroupTree.Nodes.Count == 0)
						{
							num2 = (short)1031012352;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					num2 = (short)2112946178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_2C;
			}
			IL_E7:
			rmgroupList.MyDevices.IsChecked = new bool?(true);
			return;
			IL_2C:
			rmgroupList = (global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList)A_0;
			num2 = (short)1693646848;
			short num4 = num2;
			num2 = (short)2131361798;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00077240 File Offset: 0x00075440
		private static void a(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_1, global::Motorola.CommonCPS.RadioManagement.Controls.RMToggleButton A_2, bool A_3)
		{
			short num = (short)877789194;
			int num2 = (int)((global::System.IntPtr)num);
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2;
			for (;;)
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
				switch (num2)
				{
				case 0:
					goto IL_8B;
				case 1:
					goto IL_E8;
				case 2:
					if (A_3)
					{
						num = (short)296812547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B3;
				case 3:
					num = (short)649592833;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.a(A_0);
					num = (short)661782533;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::System.Guid? id;
					if (id == null)
					{
						num = (short)375586816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_112;
				}
				case 5:
					goto IL_B3;
				case 6:
				{
					global::Infragistics.Controls.Menus.XamDataTreeNodesCollection nodes = A_0.Nodes;
					global::System.Guid? id = A_1.ID;
					xamDataTreeNode = global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.a(nodes, id.Value);
					goto IL_1DC;
				}
				case 7:
				{
					global::System.Guid? id = A_1.ID;
					num = (short)31862966;
					short num3 = num;
					num = (short)1038495926;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_112;
					default:
						num = (short)1808728064;
						if (num != 0)
						{
						}
						num = (short)1398734852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					if (xamDataTreeNode2 == null)
					{
						num = (short)2018639873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_241;
				case 9:
					xamDataTreeNode = null;
					goto IL_1DC;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				}
				IL_52:
				if (A_1 != null)
				{
					num = (short)1941831687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8B:
				num = (short)1593311241;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B3:
				num = (short)1109262344;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_112:
				num = (short)141099014;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DC:
				xamDataTreeNode2 = xamDataTreeNode;
				num = (short)1856700418;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E8:
			num = (short)776798208;
			short num4 = num;
			A_2.IsChecked = new bool?(true);
			return;
			IL_241:
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.a(xamDataTreeNode2, A_0);
			A_2.IsChecked = new bool?(false);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000774A4 File Offset: 0x000756A4
		private static void a(global::Infragistics.Controls.Menus.XamDataTreeNode A_0, global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree A_1)
		{
			short num = (short)77315473;
			short num2 = num;
			num = (short)1182186897;
			switch (num2 == num)
			{
			}
			num = (short)1318977536;
			short num3 = num;
			num = (short)1272381441;
			if (num != 0)
			{
			}
			num = (short)1641742336;
			if (num != 0)
			{
			}
			A_1.SelectionSettings.SelectedNodes.Clear();
			A_0.IsExpanded = true;
			A_0.IsSelected = true;
			A_1.ActiveNode = A_0;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x00077574 File Offset: 0x00075774
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x0007762C File Offset: 0x0007582C
		public global::System.Windows.Input.ICommand RenameCommand
		{
			get
			{
				short num = (short)722083069;
				short num2 = num;
				num = (short)1278090493;
				switch (num2 == num)
				{
				}
				num = (short)1027801088;
				short num3 = num;
				num = (short)634126336;
				if (num != 0)
				{
				}
				num = (short)948371457;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.RenameCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)718852550;
				short num2 = num;
				num = (short)597545414;
				switch (num2 == num)
				{
				}
				num = (short)1314258944;
				short num3 = num;
				num = (short)594083841;
				if (num != 0)
				{
				}
				num = (short)1277820928;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.RenameCommandProperty, value);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000776E0 File Offset: 0x000758E0
		// (set) Token: 0x0600077A RID: 1914 RVA: 0x00077798 File Offset: 0x00075998
		public global::System.Windows.Input.ICommand SelectedGroupChangedCommad
		{
			get
			{
				short num = (short)2094622169;
				short num2 = num;
				num = (short)688940505;
				switch (num2 == num)
				{
				}
				num = (short)163250176;
				short num3 = num;
				num = (short)1227358208;
				if (num != 0)
				{
				}
				num = (short)854196225;
				if (num != 0)
				{
				}
				return (global::System.Windows.Input.ICommand)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.SelectedGroupChangedCommadProperty);
			}
			set
			{
				short num = (short)125894657;
				if (num != 0)
				{
				}
				num = (short)756257742;
				short num2 = num;
				num = (short)1424593870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1762525184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1985675264;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.SelectedGroupChangedCommadProperty, value);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x00077850 File Offset: 0x00075A50
		// (set) Token: 0x0600077C RID: 1916 RVA: 0x0007790C File Offset: 0x00075B0C
		public global::System.Windows.Input.ICommand UpdateCommand
		{
			get
			{
				short num = (short)1817598268;
				short num2 = num;
				num = (short)834165052;
				switch (num2 == num)
				{
				}
				num = (short)1657929728;
				short num3 = num;
				num = (short)1297743872;
				if (num != 0)
				{
				}
				num = (short)1657208833;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.UpdateCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1903759522;
				short num2 = num;
				num = (short)1386614946;
				switch (num2 == num)
				{
				}
				num = (short)1400504320;
				short num3 = num;
				num = (short)2014052353;
				if (num != 0)
				{
				}
				num = (short)502333440;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.UpdateCommandProperty, value);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x000779C4 File Offset: 0x00075BC4
		// (set) Token: 0x0600077E RID: 1918 RVA: 0x00077A78 File Offset: 0x00075C78
		public global::System.Windows.Input.ICommand RefreshCommand
		{
			get
			{
				short num = (short)399996623;
				short num2 = num;
				num = (short)1385854671;
				switch (num2 == num)
				{
				}
				num = (short)1261109248;
				short num3 = num;
				num = (short)1810300929;
				if (num != 0)
				{
				}
				num = (short)1190264832;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.RefreshCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1573257217;
				if (num != 0)
				{
				}
				num = (short)826012309;
				short num2 = num;
				num = (short)294843029;
				switch (num2 == num)
				{
				default:
				{
					num = (short)899940352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)978190336;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.RefreshCommandProperty, value);
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00077B30 File Offset: 0x00075D30
		public void PrepareRename(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group)
		{
			short num = (short)1416269488;
			short num2 = num;
			num = (short)1517522608;
			switch (num2 == num)
			{
			}
			num = (short)1503199232;
			short num3 = num;
			num = (short)72220672;
			if (num != 0)
			{
			}
			num = (short)703856641;
			if (num != 0)
			{
			}
			this.GroupTree.EnterEditMode(this.GroupTree.ActiveNode);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00077BEC File Offset: 0x00075DEC
		public void EndEditMode()
		{
			short num = (short)140771329;
			if (num != 0)
			{
			}
			num = (short)2098104516;
			short num2 = num;
			num = (short)859211972;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1851260928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)269877248;
			if (num != 0)
			{
			}
			this.GroupTree.ExitEditMode(true);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00077CA4 File Offset: 0x00075EA4
		private static global::Infragistics.Controls.Menus.XamDataTreeNode a(global::Infragistics.Controls.Menus.XamDataTreeNodesCollection A_0, global::System.Guid A_1)
		{
			short num = (short)181927936;
			switch (num)
			{
			default:
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = null;
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerator = A_0.GetEnumerator();
				global::Infragistics.Controls.Menus.XamDataTreeNode result;
				try
				{
					num = (short)1502806031;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2;
						bool flag;
						switch (num2)
						{
						case 0:
							result = xamDataTreeNode2;
							num = (short)1072758794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							num = (short)959643649;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)2017722382;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							xamDataTreeNode2 = enumerator.Current;
							global::System.Guid? id = ((global::Motorola.CommonCPS.RadioManagement.UIModels.Group)xamDataTreeNode2.Data).ID;
							num = (short)1237778440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)73465865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							flag = true;
							goto IL_254;
						case 4:
						{
							global::System.Guid? id;
							flag = (id.GetValueOrDefault() == A_1);
							goto IL_254;
						}
						case 5:
							num = (short)392167427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_30B;
						case 7:
							if (xamDataTreeNode != null)
							{
								num = (short)1931018251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 8:
						{
							global::System.Guid? id;
							if (id == null)
							{
								num = (short)1535836162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)5963789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							flag = false;
							goto IL_254;
						case 10:
							goto IL_E4;
						case 11:
							num = (short)1598160908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_A8;
						case 13:
						{
							num = (short)1313877330;
							short num3 = num;
							num = (short)132656466;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_20A;
							default:
							{
								num = (short)894435328;
								if (num != 0)
								{
								}
								global::System.Guid? id;
								if (id == null)
								{
									num = (short)917438469;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)857997316;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 14:
							num = (short)712441862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							switch (0)
							{
							case 0:
								goto IL_90;
							}
							continue;
						}
						IL_E9:
						num = (short)604831745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_90:
						goto IL_E9;
						IL_20A:
						xamDataTreeNode = global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.a(xamDataTreeNode2.Nodes, A_1);
						num = (short)766771207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_254:
						if (!flag)
						{
							goto IL_20A;
						}
						num = (short)936640512;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_A8:
					return xamDataTreeNode;
					IL_E4:
					goto IL_37C;
					IL_30B:
					return xamDataTreeNode;
				}
				finally
				{
					num = (short)667025410;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1990918145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_379;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_342;
							}
							continue;
						}
						IL_342:
						if (enumerator == null)
						{
							break;
						}
						num = (short)459603968;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_379:;
				}
				IL_37C:
				num = (short)268632064;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00078078 File Offset: 0x00076278
		private void GroupTree_ContextMenuOpening(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl;
			short num2;
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					if (xamDataTreeNodeControl == null)
					{
						num2 = (short)1796997120;
						short num3 = num2;
						num2 = (short)1165557764;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)391905283;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_134;
				case 2:
				{
					num2 = (short)61085453;
					short num4 = num2;
					num2 = (short)354293517;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_176;
					default:
						num2 = (short)1389559808;
						if (num2 != 0)
						{
						}
						num2 = (short)1052442629;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					flag = (xamDataTreeNodeControl.Node != null);
					goto IL_118;
				case 4:
					num2 = (short)167313414;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return;
				case 6:
					flag = (null != null);
					goto IL_118;
				case 7:
					if (xamDataTree == null)
					{
						num2 = (short)18808834;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					xamDataTreeNodeControl = (global::Infragistics.Windows.Utilities.GetAncestorFromType(A_1.OriginalSource as global::System.Windows.DependencyObject, typeof(global::Infragistics.Controls.Menus.XamDataTreeNodeControl), true) as global::Infragistics.Controls.Menus.XamDataTreeNodeControl);
					goto IL_176;
				}
				goto IL_30;
				IL_118:
				if (!flag)
				{
					num2 = (short)523239425;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1D6;
				IL_176:
				num2 = (short)657653760;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_134:
			this.a();
			return;
			IL_1D6:
			xamDataTreeNodeControl.Node.IsActive = true;
			xamDataTreeNodeControl.Node.IsSelected = true;
			return;
			IL_30:
			num2 = (short)618004481;
			if (num2 != 0)
			{
			}
			xamDataTree = (A_0 as global::Infragistics.Controls.Menus.XamDataTree);
			num2 = (short)1338638343;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00078274 File Offset: 0x00076474
		private void ContextMenuOpeningOnMyDevicesButton(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)601858493;
			short num2 = num;
			num = (short)1763680701;
			switch (num2 == num)
			{
			}
			num = (short)912850945;
			if (num != 0)
			{
			}
			num = (short)313589760;
			short num3 = num;
			num = (short)290062336;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00078324 File Offset: 0x00076524
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Infragistics.Controls.Menus.XamDataTreeNode activeNode;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FC;
				case 1:
				{
					if (activeNode == null)
					{
						return;
					}
					num2 = (short)878238060;
					short num3 = num2;
					num2 = (short)175233388;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D0;
					default:
					{
						num2 = (short)648413184;
						if (num2 != 0)
						{
						}
						num2 = (short)1220804608;
						short num4 = num2;
						num2 = (short)1257963522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_D0;
				}
				goto IL_1C;
				IL_D0:
				this.EndEditMode();
				activeNode.IsSelected = false;
				activeNode.IsActive = false;
				num2 = (short)1437270016;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FC:
			num2 = (short)1312227329;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			activeNode = this.GroupTree.ActiveNode;
			num2 = (short)663617537;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00078458 File Offset: 0x00076658
		private void GroupTree_EditModeEnding(object A_0, global::Infragistics.Controls.Menus.TreeExitEditingEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
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
					goto IL_15B;
				case 1:
					return;
				case 2:
					if (text != A_1.Node.Data.ToString())
					{
						num2 = (short)253558784;
						short num3 = num2;
						num2 = (short)1757872129;
						if (num2 != 0)
						{
						}
						num2 = (short)994705411;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A1;
				case 3:
					try
					{
						num2 = (short)1268187138;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_139;
							case 1:
								goto IL_156;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_A3;
								}
								continue;
							case 3:
							{
								num2 = (short)439147412;
								short num4 = num2;
								num2 = (short)122346388;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num2 = (short)432537600;
									if (num2 != 0)
									{
									}
									this.RenameCommand.Execute(text);
									break;
								}
								num2 = (short)37879808;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							IL_A3:
							if (this.RenameCommand.CanExecute(text))
							{
								num2 = (short)896270339;
								num = (int)((global::System.IntPtr)num2);
							}
							else
							{
								num2 = (short)243269633;
								num = (int)((global::System.IntPtr)num2);
							}
						}
						IL_139:
						return;
						IL_156:
						goto IL_1A1;
					}
					catch
					{
						goto IL_1A1;
					}
					goto IL_15B;
				case 4:
					num2 = (short)732823554;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (text != null)
					{
						num2 = (short)2005532672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A1;
				case 6:
					if (text != string.Empty)
					{
						num2 = (short)1811480580;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A1;
				}
				goto IL_2C;
				IL_15B:
				text = text.Trim();
				num2 = (short)459014150;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1A1:
				((global::System.Windows.Controls.TextBox)A_1.Node.Control.Content).Text = A_1.Node.Data.ToString();
				num2 = (short)983760897;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			text = (string)A_1.NewValue;
			num2 = (short)1733951493;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000786FC File Offset: 0x000768FC
		private void GroupTree_SelectedGroupChanged(object A_0, global::Infragistics.Controls.Menus.ActiveNodeChangedEventArgs A_1)
		{
			short num = (short)1018298378;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Guid? guid;
				bool flag;
				global::System.Guid? guid2;
				switch (num2)
				{
				case 0:
					num = (short)1798832130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					global::System.Guid? id;
					if (id != null != (guid != null))
					{
						num = (short)1257635845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1607794694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					flag = true;
					goto IL_203;
				case 3:
				{
					global::System.Guid? id;
					flag = (id.GetValueOrDefault() == guid.GetValueOrDefault());
					goto IL_203;
				}
				case 4:
					goto IL_21C;
				case 5:
				{
					num = (short)111804416;
					short num3 = num;
					num = (short)1572536329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					global::System.Guid? id;
					if (id == null)
					{
						num = (short)352452608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)289800195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					global::System.Guid? id = ((global::Motorola.CommonCPS.RadioManagement.UIModels.Group)A_1.NewActiveTreeNode.Data).ID;
					num = (short)545390603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
				{
					global::System.Guid? guid3;
					guid2 = guid3;
					goto IL_F6;
				}
				case 9:
					flag = false;
					goto IL_203;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 11:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.Group selectedGroup = this.SelectedGroup;
					if (selectedGroup == null)
					{
						global::System.Guid? guid3 = null;
						num = (short)215941128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					guid2 = selectedGroup.ID;
					goto IL_F6;
				}
				}
				IL_55:
				if (A_1.NewActiveTreeNode != null)
				{
					num = (short)734658567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_291;
				IL_F6:
				guid = guid2;
				num = (short)1086652417;
				if (num != 0)
				{
				}
				num = (short)1874984961;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_203:
				if (!flag)
				{
					break;
				}
				num = (short)1233256452;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.SelectedGroup = (global::Motorola.CommonCPS.RadioManagement.UIModels.Group)A_1.NewActiveTreeNode.Data;
			return;
			IL_21C:
			num = (short)190513699;
			short num4 = num;
			num = (short)428212771;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_291:
				this.SelectedGroup = new global::Motorola.CommonCPS.RadioManagement.UIModels.Group();
				return;
			default:
				num = (short)391577600;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000789A8 File Offset: 0x00076BA8
		private void GroupTree_OnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1634729995;
			int num2 = (int)((global::System.IntPtr)num);
			global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2;
			for (;;)
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
				switch (num2)
				{
				case 0:
					num = (short)1542389763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)2075394053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					global::System.Guid? id;
					if (id == null)
					{
						num = (short)733413377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E;
				}
				case 3:
				{
					num = (short)1171259393;
					if (num != 0)
					{
					}
					if (this.SelectedGroup == null)
					{
						num = (short)194314249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Guid? id = this.SelectedGroup.ID;
					num = (short)664862722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_106;
				case 5:
					xamDataTreeNode = null;
					goto IL_151;
				case 6:
					if (xamDataTreeNode2 == null)
					{
						num = (short)1597112330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27B;
				case 7:
				{
					global::Infragistics.Controls.Menus.XamDataTreeNodesCollection nodes = this.GroupTree.Nodes;
					global::System.Guid? id = this.SelectedGroup.ID;
					xamDataTreeNode = global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.a(nodes, id.Value);
					goto IL_151;
				}
				case 8:
					global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.a(this.GroupTree);
					num = (short)1449590788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_279;
				case 10:
					return;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 12:
					if (this.GroupTree.Nodes.Any<global::Infragistics.Controls.Menus.XamDataTreeNode>())
					{
						num = (short)464715776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_59:
				if (this.AllowRestoreExpandedNodes)
				{
					num = (short)109379592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_106;
				IL_7E:
				num = (short)1589248007;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_151:
				xamDataTreeNode2 = xamDataTreeNode;
				num = (short)1737376162;
				short num3 = num;
				num = (short)1894007202;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_7E;
				default:
					num = (short)440270848;
					if (num != 0)
					{
					}
					num = (short)11075590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_106:
				num = (short)1108738060;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_279:
			return;
			IL_27B:
			num = (short)327090176;
			short num4 = num;
			this.MyDevices.IsChecked = new bool?(false);
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.a(xamDataTreeNode2, this.GroupTree);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00078C78 File Offset: 0x00076E78
		private void a(global::Infragistics.Controls.Menus.XamDataTreeNode A_0, bool A_1)
		{
			short num = (short)1702952961;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerator = A_0.Nodes.GetEnumerator();
			try
			{
				num = (short)1551106051;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1647771649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_E4;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1400832000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = enumerator.Current;
						xamDataTreeNode.IsExpanded = A_1;
						this.a(xamDataTreeNode, A_1);
						num = (short)1273561092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					}
					IL_9B:
					num = (short)197001218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D:
					goto IL_9B;
				}
				IL_E4:;
			}
			finally
			{
				num = (short)238485505;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_19E;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_11A;
						}
						continue;
					case 2:
					{
						num = (short)1555912959;
						short num3 = num;
						num = (short)1503025407;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)797442048;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)521797632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_11A:
					if (enumerator == null)
					{
						break;
					}
					num = (short)198508546;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19E:;
			}
			num = (short)2067136512;
			short num4 = num;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00078E60 File Offset: 0x00077060
		private void GroupTree_OnGotKeyboardFocus(object A_0, global::System.Windows.Input.KeyboardFocusChangedEventArgs A_1)
		{
			short num = (short)1175025283;
			short num2 = num;
			num = (short)630224515;
			switch (num2 == num)
			{
			}
			num = (short)200474624;
			if (num != 0)
			{
			}
			num = (short)356122624;
			short num3 = num;
			num = (short)985333761;
			if (num != 0)
			{
			}
			this.a(A_1.NewFocus as global::System.Windows.Controls.TextBox);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00078F1C File Offset: 0x0007711C
		private void a(global::System.Windows.Controls.TextBox A_0)
		{
			short num = (short)1102446593;
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
						goto IL_31;
					}
					continue;
				case 2:
				{
					num = (short)124711007;
					short num3 = num;
					num = (short)821948511;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)306315264;
						if (num != 0)
						{
						}
						num = (short)1562181633;
						if (num != 0)
						{
						}
						A_0.SelectAll();
						num = (short)223281152;
						short num4 = num;
						num = (short)350158848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_31:
				if (A_0 == null)
				{
					break;
				}
				num = (short)725680130;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00079030 File Offset: 0x00077230
		private static void ScrollViewer_PreviewMouseWheel(object A_0, global::System.Windows.Input.MouseWheelEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList rmgroupList;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1349844994;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_93;
				case 2:
				{
					num2 = (short)1301217280;
					short num3 = num2;
					if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
					{
						num2 = (short)1626472451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_93;
				}
				case 3:
				{
					num2 = (short)1865767278;
					short num4 = num2;
					num2 = (short)1094801774;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1324220416;
						if (num2 != 0)
						{
						}
						num2 = (short)1284374532;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
					{
						num2 = (short)906952705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					if (rmgroupList != null)
					{
						num2 = (short)786038784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					return;
				}
				goto IL_2C;
				IL_93:
				global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(rmgroupList, (double)A_1.Delta);
				num2 = (short)192937990;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			num2 = (short)1476132865;
			if (num2 != 0)
			{
			}
			rmgroupList = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList);
			num2 = (short)311492613;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000791F4 File Offset: 0x000773F4
		private void MyDevice_OnChecked(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1078132739;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Guid? id;
				bool flag;
				switch (num2)
				{
				case 0:
				{
					num = (short)1117823117;
					short num3 = num;
					num = (short)835821709;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48;
					default:
						num = (short)715784192;
						if (num != 0)
						{
						}
						num = (short)649396226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					flag = (id == null);
					goto IL_EC;
				case 2:
					goto IL_C4;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
					flag = true;
					goto IL_EC;
				}
				goto IL_39;
				IL_48:
				num = (short)1945108484;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39:
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group selectedGroup = this.SelectedGroup;
				if (selectedGroup == null)
				{
					goto IL_48;
				}
				id = selectedGroup.ID;
				num = (short)1579745281;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC:
				if (!flag)
				{
					goto IL_134;
				}
				num = (short)764608512;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C4:
			num = (short)630128641;
			if (num != 0)
			{
			}
			return;
			IL_134:
			num = (short)2006974464;
			short num4 = num;
			this.GroupTree.SelectionSettings.SelectedNodes.Clear();
			this.GroupTree.ActiveNode = null;
			this.SelectedGroup = new global::Motorola.CommonCPS.RadioManagement.UIModels.Group();
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0007938C File Offset: 0x0007758C
		private void MyDevice_OnUnchecked(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2036924419;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Guid? id;
				bool flag;
				switch (num2)
				{
				case 0:
					this.MyDevices.IsChecked = new bool?(true);
					goto IL_97;
				case 1:
					flag = (id == null);
					goto IL_B3;
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
					flag = true;
					goto IL_B3;
				}
				IL_39:
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group selectedGroup = this.SelectedGroup;
				if (selectedGroup == null)
				{
					num = (short)1858863105;
					if (num != 0)
					{
					}
					num = (short)98238468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				id = selectedGroup.ID;
				num = (short)1571713211;
				short num3 = num;
				num = (short)794325179;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)720633856;
					if (num != 0)
					{
					}
					num = (short)631898112;
					short num4 = num;
					num = (short)1838743553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_97:
				num = (short)4259842;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B3:
				if (!flag)
				{
					break;
				}
				num = (short)2073100288;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0007950C File Offset: 0x0007770C
		private void GroupTree_OnKeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree;
			short num2;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					goto IL_18A;
				case 1:
					if (A_1.Key == global::System.Windows.Input.Key.Divide)
					{
						goto IL_1CA;
					}
					return;
				case 2:
					goto IL_141;
				case 3:
					this.a(rmdataTree.ActiveNode, false);
					num2 = (short)217645056;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (A_1.Key == global::System.Windows.Input.Key.Multiply)
					{
						num2 = (short)241762306;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1515323393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)732889089;
					if (num2 != 0)
					{
					}
					num2 = (short)2068210648;
					short num3 = num2;
					num2 = (short)187130840;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CA;
					default:
						num2 = (short)30277632;
						if (num2 != 0)
						{
						}
						num2 = (short)1190854664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					goto IL_1FC;
				case 7:
					num2 = (short)325713926;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					flag = (null != null);
					goto IL_225;
				case 9:
					if (rmdataTree == null)
					{
						num2 = (short)327090181;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1590820874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					flag = (rmdataTree.ActiveNode != null);
					goto IL_225;
				}
				goto IL_3C;
				IL_225:
				if (!flag)
				{
					num2 = (short)2047737863;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)1028128772;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1CA:
				num2 = (short)397017091;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_141:
			rmdataTree.ActiveNode.IsExpanded = true;
			this.a(rmdataTree.ActiveNode, true);
			return;
			IL_18A:
			return;
			IL_1FC:
			num2 = (short)328925184;
			short num4 = num2;
			return;
			IL_3C:
			rmdataTree = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree);
			num2 = (short)1795883017;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0007975C File Offset: 0x0007795C
		private void GroupTree_OnNodeDragDrop(object A_0, global::Infragistics.Controls.Menus.TreeDropEventArgs A_1)
		{
			short num = (short)35782656;
			switch (num)
			{
			default:
			{
				num = (short)620363788;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2;
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode3;
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode4;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
						global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2;
						if (this.a(group, group2))
						{
							num = (short)287768580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						group.Parent = group2;
						num = (short)1163591681;
						if (num != 0)
						{
						}
						num = (short)1859256322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.Group group = (global::Motorola.CommonCPS.RadioManagement.UIModels.Group)xamDataTreeNode.Data;
						global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.Group)xamDataTreeNode2.Data;
						num = (short)37093387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					case 3:
						if (xamDataTreeNode2 != null)
						{
							num = (short)1148715021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_29C;
					case 5:
						goto IL_262;
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.Group group2 = group2.Parent;
						num = (short)1714814981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						xamDataTreeNode3 = null;
						goto IL_17B;
					case 8:
					{
						global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = A_1.DragDropEventArgs.DragSource as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
						if (xamDataTreeNodeControl != null)
						{
							xamDataTreeNode3 = xamDataTreeNodeControl.Node;
							goto IL_17B;
						}
						num = (short)1552471795;
						short num3 = num;
						num = (short)749459187;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_262;
						default:
						{
							num = (short)1437728768;
							short num4 = num;
							num = (short)2124677120;
							if (num != 0)
							{
							}
							num = (short)526647303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 9:
						xamDataTreeNode4 = null;
						goto IL_B1;
					case 10:
						if (xamDataTreeNode != null)
						{
							num = (short)1652752385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						if (A_1.DropDestination != global::Infragistics.Controls.Menus.TreeDropDestination.DropOnto)
						{
							num = (short)1959460870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_262;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 13:
						num = (short)257818634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7C:
					global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl2 = A_1.DragDropEventArgs.DropTarget as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
					if (xamDataTreeNodeControl2 == null)
					{
						num = (short)1380515849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					xamDataTreeNode4 = xamDataTreeNodeControl2.Node;
					IL_B1:
					xamDataTreeNode2 = xamDataTreeNode4;
					num = (short)505806856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17B:
					xamDataTreeNode = xamDataTreeNode3;
					num = (short)1326907395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_262:
					num = (short)2111307776;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_29C:
				A_1.Handled = true;
				return;
			}
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00079A58 File Offset: 0x00077C58
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_1)
		{
			short num = (short)2005204997;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				global::System.Guid? guid;
				global::System.Guid? guid2;
				global::System.Guid? guid4;
				global::System.Guid? guid5;
				switch (num2)
				{
				case 0:
					flag = true;
					goto IL_2B7;
				case 1:
					goto IL_289;
				case 2:
				{
					num = (short)1551192311;
					short num3 = num;
					num = (short)1470517495;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_289;
					default:
						num = (short)960823296;
						if (num != 0)
						{
						}
						flag = false;
						goto IL_2B7;
					}
					break;
				}
				case 3:
					guid = A_1.ID;
					goto IL_1E5;
				case 4:
					if (guid2 == null)
					{
						num = (short)750649345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)937951244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 6:
				{
					global::System.Guid? guid3 = null;
					num = (short)524484619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					global::System.Guid? guid3;
					guid4 = guid3;
					goto IL_DD;
				}
				case 8:
					goto IL_2D2;
				case 9:
					num = (short)566296578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (guid2 != null != (guid5 != null))
					{
						num = (short)655425545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)392953860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					global::System.Guid? guid3;
					guid = guid3;
					goto IL_1E5;
				}
				case 12:
					flag = (guid2.GetValueOrDefault() == guid5.GetValueOrDefault());
					goto IL_2B7;
				case 13:
					if (A_1 == null)
					{
						num = (short)2002911238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1687420931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5D:
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group parent = A_0.Parent;
				if (parent == null)
				{
					global::System.Guid? guid3 = null;
					num = (short)868745217;
					if (num != 0)
					{
					}
					num = (short)1625620487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				guid4 = parent.ID;
				IL_DD:
				guid2 = guid4;
				num = (short)87687181;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E5:
				guid5 = guid;
				num = (short)1581056010;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_289:
				num = (short)1800536064;
				short num4 = num;
				num = (short)603652096;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B7:
				if (flag)
				{
					return true;
				}
				num = (short)240189448;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2D2:
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService.CheckIfTheGroupIsParentOrAncestor(A_1, A_0);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00079D40 File Offset: 0x00077F40
		private void GroupTree_OnNodeExpansionChanged(object A_0, global::Infragistics.Controls.Menus.NodeExpansionChangedEventArgs A_1)
		{
			short num = (short)397876745;
			short num2 = num;
			num = (short)115285513;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1621753857;
				if (num != 0)
				{
				}
				num = (short)1535901696;
				if (num != 0)
				{
				}
				num = (short)1784872962;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_238;
					case 1:
						if (group.Children.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>())
						{
							num = (short)1919483904;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_BA;
						}
						continue;
					case 3:
						num = (short)716374024;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (A_1.Node.IsExpanded)
						{
							num = (short)1247936515;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.ListExpandedNodes.Remove(group.ID.Value);
						num = (short)861798405;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return;
					case 6:
						return;
					case 7:
						num = (short)1629552641;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.ListExpandedNodes.Contains(group.ID.Value))
						{
							num = (short)186515463;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_BA:
					num = (short)779550720;
					short num4 = num;
					if (!this.AllowRestoreExpandedNodes)
					{
						num = (short)1496580102;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						group = (global::Motorola.CommonCPS.RadioManagement.UIModels.Group)A_1.Node.Data;
						num = (short)774045700;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				return;
			}
			}
			IL_238:
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.ListExpandedNodes.Add(group.ID.Value);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00079F8C File Offset: 0x0007818C
		private static void a(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree A_0)
		{
			short num = (short)735510528;
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
				global::System.Collections.Generic.List<global::System.Guid> list;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::System.Guid>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1265696770;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)488243203;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)1755199250;
									short num3 = num;
									num = (short)2025404178;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1EE;
									default:
										num = (short)736100352;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_19E;
										}
										continue;
									}
									break;
								}
								case 3:
									goto IL_222;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1944846336;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Guid item = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.ListExpandedNodes.Remove(item);
									goto IL_1EE;
								}
								}
								IL_1A0:
								num = (short)2141847556;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19E:
								goto IL_1A0;
								IL_1EE:
								num = (short)1118961665;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_222:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_3;
					case 1:
						goto IL_235;
					case 2:
						goto IL_7C;
					case 3:
					{
						if (!A_0.Nodes.Any<global::Infragistics.Controls.Menus.XamDataTreeNode>())
						{
							num = (short)758382594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<global::System.Guid>.Enumerator enumerator2 = global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.ListExpandedNodes.GetEnumerator();
						num = (short)748093441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_3E;
					Block_3:
					try
					{
						IL_235:
						num = (short)793182209;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1875378181;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_27B;
								}
								continue;
							case 2:
							{
								global::System.Guid guid;
								list.Add(guid);
								num = (short)350093316;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
								if (xamDataTreeNode == null)
								{
									num = (short)774897666;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								xamDataTreeNode.IsExpanded = true;
								num = (short)657915910;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_35F;
							case 7:
							{
								global::System.Collections.Generic.List<global::System.Guid>.Enumerator enumerator2;
								if (!enumerator2.MoveNext())
								{
									num = (short)1761542144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Guid guid = enumerator2.Current;
								global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.a(A_0.Nodes, guid);
								num = (short)1999831043;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_27D:
							num = (short)388956167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_27B:
							goto IL_27D;
						}
						IL_35F:
						goto IL_A5;
					}
					finally
					{
						global::System.Collections.Generic.List<global::System.Guid>.Enumerator enumerator2;
						((global::System.IDisposable)enumerator2).Dispose();
					}
					return;
					IL_A5:
					enumerator = list.GetEnumerator();
					num = (short)1345978368;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7C:
				num = (short)2105737217;
				if (num != 0)
				{
				}
				num = (short)533790720;
				short num4 = num;
				return;
				IL_3E:
				list = new global::System.Collections.Generic.List<global::System.Guid>();
				num = (short)521469955;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0007A340 File Offset: 0x00078540
		private void GroupTree_OnNodeDragEnd(object A_0, global::Infragistics.DragDrop.DragDropEventArgs A_1)
		{
			short num = (short)990969856;
			switch (num)
			{
			default:
			{
				num = (short)1396572164;
				int num2 = (int)((global::System.IntPtr)num);
				global::Infragistics.DragDrop.DragDropCancelEventArgs dragDropCancelEventArgs;
				for (;;)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2;
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode3;
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode4;
					switch (num2)
					{
					case 0:
						num = (short)687472641;
						if (num != 0)
						{
						}
						xamDataTreeNode = null;
						goto IL_163;
					case 1:
						xamDataTreeNode2 = null;
						goto IL_A1;
					case 2:
						goto IL_238;
					case 3:
					{
						num = (short)1917714432;
						short num3 = num;
						num = (short)1299120135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					case 5:
						IL_21A:
						if (dragDropCancelEventArgs != null)
						{
							num = (short)1097859074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_1F9;
					case 7:
					{
						if (xamDataTreeNode3 == null)
						{
							num = (short)405667846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.Group parameter = (global::Motorola.CommonCPS.RadioManagement.UIModels.Group)xamDataTreeNode3.Data;
						num = (short)1575223304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_267;
					case 9:
						if (xamDataTreeNode4 != null)
						{
							num = (short)149880835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F9;
					case 10:
					{
						global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = A_1.DragSource as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
						if (xamDataTreeNodeControl == null)
						{
							num = (short)128122880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						xamDataTreeNode = xamDataTreeNodeControl.Node;
						goto IL_163;
					}
					}
					IL_70:
					global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl2 = A_1.DropTarget as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
					if (xamDataTreeNodeControl2 == null)
					{
						num = (short)1355415553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					xamDataTreeNode2 = xamDataTreeNodeControl2.Node;
					IL_A1:
					xamDataTreeNode4 = xamDataTreeNode2;
					num = (short)1322548852;
					short num4 = num;
					num = (short)1033666164;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_21A;
					default:
						num = (short)1033371648;
						if (num != 0)
						{
						}
						num = (short)512622602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_163:
					xamDataTreeNode3 = xamDataTreeNode;
					num = (short)1436352521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F9:
					dragDropCancelEventArgs = (A_1 as global::Infragistics.DragDrop.DragDropCancelEventArgs);
					num = (short)1702494213;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_238:
				dragDropCancelEventArgs.Cancel = true;
				return;
				IL_267:
				try
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.Group parameter;
					this.UpdateCommand.Execute(parameter);
					this.RefreshCommand.Execute(parameter);
				}
				catch
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode3;
					(xamDataTreeNode3.Control.Content as global::System.Windows.Controls.TextBox).Text = xamDataTreeNode3.Data.ToString();
				}
				return;
			}
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0007A604 File Offset: 0x00078804
		private void RMGroupList_OnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)139050494;
			short num2 = num;
			num = (short)417316350;
			switch (num2 == num)
			{
			}
			num = (short)1090650112;
			short num3 = num;
			num = (short)671678465;
			if (num != 0)
			{
			}
			num = (short)2101805056;
			if (num != 0)
			{
			}
			this.GroupTree.EditingSettings.AllowEditing = this.AllowEdit;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0007A6C4 File Offset: 0x000788C4
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_0)
		{
			short num = (short)1127194780;
			short num2 = num;
			num = (short)1445634204;
			switch (num2 == num)
			{
			}
			num = (short)1469579264;
			short num3 = num;
			num = (short)2109997057;
			if (num != 0)
			{
			}
			num = (short)684720128;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.<>c__DisplayClass63_0 CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.<>c__DisplayClass63_0();
			CS$<>8__locals1.a = this;
			CS$<>8__locals1.b = A_0;
			global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(CS$<>8__locals1.c), global::System.Array.Empty<object>());
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0007A7A0 File Offset: 0x000789A0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num = (short)2080833537;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				num = (short)802684928;
				short num2 = num;
				num = (short)1863893415;
				short num3 = num;
				num = (short)2125840807;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1463549952;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("辟쮣튥잧\ud8a9쎫슭톯鲱\ud9b5햷ힹ펻킽莿鋁韃髇ꯉ꣋ꟍ뿏鿑뗓룕맗뷙맛돝藟賡郣죥ꯧ藩苫髭苯鷱飳藵쏷駹鏻鏽烿洁樃挅昇縉⌋笍挏眑易甕眗琙栛氝伟両圣थ娧䜩䬫尭弯䜱䐳娵儷䤹䠻ွ㠿⍁⥃⩅", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0007A880 File Offset: 0x00078A80
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1091767953;
			short num2 = num;
			num = (short)418123409;
			switch (num2 == num)
			{
			}
			num = (short)266338305;
			if (num != 0)
			{
			}
			num = (short)982974464;
			if (num != 0)
			{
			}
			num = (short)1235746816;
			short num3 = num;
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0007A92C File Offset: 0x00078B2C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1443037185;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C3;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
				{
					num = (short)619642880;
					short num3 = num;
					num = (short)1476657152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_69;
				case 2:
					goto IL_5C;
				case 3:
					goto IL_136;
				default:
					num = (short)142278658;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_5C:
			this.MyDevices = (global::Motorola.CommonCPS.RadioManagement.Controls.RMToggleButton)target;
			return;
			IL_69:
			((global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList)target).Loaded += this.RMGroupList_OnLoaded;
			return;
			IL_C3:
			num = (short)294438070;
			short num4 = num;
			num = (short)718193846;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_5C;
			default:
				num = (short)1885995009;
				if (num != 0)
				{
				}
				num = (short)2025193472;
				if (num != 0)
				{
				}
				this._contentLoaded = true;
				return;
			}
			IL_136:
			this.GroupTree = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree)target;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0007AA84 File Offset: 0x00078C84
		// Note: this type is marked as 'beforefieldinit'.
		static RMGroupList()
		{
			int a_ = 11;
			short num = (short)634781697;
			if (num != 0)
			{
			}
			num = (short)1391952646;
			short num2 = num;
			num = (short)1939112710;
			switch (num2 == num)
			{
			}
			num = (short)427360256;
			if (num != 0)
			{
			}
			num = (short)448921600;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.ListExpandedNodes = new global::System.Collections.Generic.List<global::System.Guid>();
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.AllowEditProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즤쮦욨\udcaa쮮\ud8b0잲", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.AllowRestoreExpandedNodesProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즤쮦욨\udcaaﾬ쪮슰잲\udab4얶\udcb8ﺺ얼쾾ꃀ귂ꇄꋆ귈藊ꋌꯎ듐ꃒ", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.GroupsProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힤좦\udca8\udbaa\udeac", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.AllowDragAndDropProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즤쮦욨\udcaa\uddae킰풲\ud9b6\uddb8ﾺ쾼킾뇀", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.SelectedGroupProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삤쮦첨좪\ud9ac쪮햰잴\ud8b6첸쮺", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Group), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.RenameCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삤즦좨욪좬\udeb0\udeb2\ud8b4횶ힸ\udfba", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.SelectedGroupChangedCommadProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삤쮦첨좪\ud9ac쪮햰잴\ud8b6첸쮺ﺼힾꃀ귂ꋄꋆ귈裊ꋌꋎ볐닒뇔", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.UpdateCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("햤쎦좨\udfaa좬\udeb0\udeb2\ud8b4횶ힸ\udfba", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList.RefreshCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삤솦\udba8캪\udeac잮\udcb2\ud8b4\udab6\ud8b8햺\ud9bc", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList));
		}

		// Token: 0x0400036B RID: 875
		private static readonly global::System.Collections.Generic.List<global::System.Guid> ListExpandedNodes;

		// Token: 0x0400036C RID: 876
		public static readonly global::System.Windows.DependencyProperty AllowEditProperty;

		// Token: 0x0400036D RID: 877
		public static readonly global::System.Windows.DependencyProperty AllowRestoreExpandedNodesProperty;

		// Token: 0x0400036E RID: 878
		public static readonly global::System.Windows.DependencyProperty GroupsProperty;

		// Token: 0x0400036F RID: 879
		public static readonly global::System.Windows.DependencyProperty AllowDragAndDropProperty;

		// Token: 0x04000370 RID: 880
		public static readonly global::System.Windows.DependencyProperty SelectedGroupProperty;

		// Token: 0x04000371 RID: 881
		public static readonly global::System.Windows.DependencyProperty RenameCommandProperty;

		// Token: 0x04000372 RID: 882
		public static readonly global::System.Windows.DependencyProperty SelectedGroupChangedCommadProperty;

		// Token: 0x04000373 RID: 883
		public static readonly global::System.Windows.DependencyProperty UpdateCommandProperty;

		// Token: 0x04000374 RID: 884
		public static readonly global::System.Windows.DependencyProperty RefreshCommandProperty;

		// Token: 0x04000375 RID: 885
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMToggleButton MyDevices;

		// Token: 0x04000376 RID: 886
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree GroupTree;

		// Token: 0x04000377 RID: 887
		private bool _contentLoaded;
	}
}
