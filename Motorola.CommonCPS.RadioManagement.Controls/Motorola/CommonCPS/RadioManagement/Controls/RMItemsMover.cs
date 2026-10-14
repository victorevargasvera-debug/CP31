using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000EA RID: 234
	public class RMItemsMover : global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000666 RID: 1638 RVA: 0x00066920 File Offset: 0x00064B20
		public RMItemsMover()
		{
			this.InitializeComponent();
			this.lbItems.Drop += this.OnListBoxDrop;
			this.lbSelectedItems.Drop += this.OnListBoxDrop;
			this.scvItems = (global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.GetDescendantByType(this.lbItems, typeof(global::System.Windows.Controls.ScrollViewer)) as global::System.Windows.Controls.ScrollViewer);
			this.scvSelectedItems = (global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.GetDescendantByType(this.lbSelectedItems, typeof(global::System.Windows.Controls.ScrollViewer)) as global::System.Windows.Controls.ScrollViewer);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x000669A8 File Offset: 0x00064BA8
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00066A60 File Offset: 0x00064C60
		public bool IsMultipleSelectionAllowed
		{
			get
			{
				short num = (short)2084249843;
				short num2 = num;
				num = (short)1589059827;
				switch (num2 == num)
				{
				}
				num = (short)355336192;
				if (num != 0)
				{
				}
				num = (short)182779904;
				short num3 = num;
				num = (short)1878917121;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.IsMultipleSelectionAllowedProperty);
			}
			set
			{
				short num = (short)421287730;
				short num2 = num;
				num = (short)46159666;
				switch (num2 == num)
				{
				}
				num = (short)865927169;
				if (num != 0)
				{
				}
				num = (short)1860632576;
				short num3 = num;
				num = (short)732168192;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.IsMultipleSelectionAllowedProperty, value);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00066B1C File Offset: 0x00064D1C
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00066BD4 File Offset: 0x00064DD4
		public bool IsBatchOperationAllowed
		{
			get
			{
				short num = (short)2052448593;
				short num2 = num;
				num = (short)584442193;
				switch (num2 == num)
				{
				}
				num = (short)1917517825;
				if (num != 0)
				{
				}
				num = (short)2045378560;
				short num3 = num;
				num = (short)1036451840;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.IsBatchOperationAllowedProperty);
			}
			set
			{
				short num = (short)443254975;
				short num2 = num;
				num = (short)192383167;
				switch (num2 == num)
				{
				}
				num = (short)1251409921;
				if (num != 0)
				{
				}
				num = (short)1106116608;
				short num3 = num;
				num = (short)1569849344;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.IsBatchOperationAllowedProperty, value);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00066C8C File Offset: 0x00064E8C
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00066D48 File Offset: 0x00064F48
		public string AvailableListBoxLabel
		{
			get
			{
				short num = (short)24512862;
				short num2 = num;
				num = (short)237963614;
				switch (num2 == num)
				{
				}
				num = (short)726335488;
				if (num != 0)
				{
				}
				num = (short)415629312;
				short num3 = num;
				num = (short)520421377;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.AvailableListBoxLabelProperty);
			}
			set
			{
				short num = (short)337943484;
				short num2 = num;
				num = (short)1086495676;
				switch (num2 == num)
				{
				}
				num = (short)370081793;
				if (num != 0)
				{
				}
				num = (short)2004025344;
				short num3 = num;
				num = (short)34275328;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.AvailableListBoxLabelProperty, value);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00066DFC File Offset: 0x00064FFC
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00066EB8 File Offset: 0x000650B8
		public string SelectedListBoxLabel
		{
			get
			{
				short num = (short)1073912977;
				short num2 = num;
				num = (short)1696177297;
				switch (num2 == num)
				{
				}
				num = (short)169541633;
				if (num != 0)
				{
				}
				num = (short)443154432;
				short num3 = num;
				num = (short)1622147072;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.SelectedListBoxLabelProperty);
			}
			set
			{
				short num = (short)69494536;
				short num2 = num;
				num = (short)1676764936;
				switch (num2 == num)
				{
				}
				num = (short)116654081;
				if (num != 0)
				{
				}
				num = (short)2146762752;
				short num3 = num;
				num = (short)688324608;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.SelectedListBoxLabelProperty, value);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00066F6C File Offset: 0x0006516C
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00067028 File Offset: 0x00065228
		public bool PositionMoverVisibility
		{
			get
			{
				short num = (short)2060419524;
				short num2 = num;
				num = (short)309100996;
				switch (num2 == num)
				{
				}
				num = (short)1010106369;
				if (num != 0)
				{
				}
				num = (short)1144258560;
				short num3 = num;
				num = (short)1718484992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.PositionMoverVisibilityProperty);
			}
			set
			{
				short num = (short)568068707;
				short num2 = num;
				num = (short)150538851;
				switch (num2 == num)
				{
				}
				num = (short)949616641;
				if (num != 0)
				{
				}
				num = (short)1587150848;
				short num3 = num;
				num = (short)279838720;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.PositionMoverVisibilityProperty, value);
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000670E0 File Offset: 0x000652E0
		private void lbItems_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)128909313;
			if (num != 0)
			{
			}
			num = (short)2083651584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1726283777;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> list;
				for (;;)
				{
					num = (short)427425792;
					short num3 = num;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						continue;
					case 2:
						try
						{
							num = (short)1237778435;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								IL_E5:
								switch (num2)
								{
								case 0:
									num = (short)1442054148;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									while (enumerator.MoveNext())
									{
										num = (short)1590973493;
										short num4 = num;
										num = (short)1368609845;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
										{
											num = (short)1139015680;
											if (num != 0)
											{
											}
											object obj = enumerator.Current;
											list.Add(obj as global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem);
											num = (short)1842741249;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_E5;
										}
										}
									}
									num = (short)327286784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_100;
									}
									continue;
								case 4:
									goto IL_1D2;
								}
								IL_179:
								num = (short)819527682;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_100:
								goto IL_179;
							}
							IL_1D2:
							goto IL_280;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1F4;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1E1:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)755695618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)1555234816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_24A;
								case 2:
									goto IL_248;
								}
								goto IL_1F4;
							}
							IL_248:
							IL_24A:
							goto EndFinally_6;
							IL_1F4:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)880345089;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E1;
							EndFinally_6:;
						}
						goto IL_24B;
					}
					IL_A0:
					if (this.iEdit == null)
					{
						num = (short)1956511744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_24B:
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem>();
					enumerator = this.lbItems.SelectedItems.GetEnumerator();
					num = (short)1494614018;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_280:
				this.iEdit.AvailableListBoxSelectedItems.Clear();
				this.iEdit.AvailableListBoxSelectedItems.AddRange(list);
				return;
			}
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000673AC File Offset: 0x000655AC
		private void lbSelectedItems_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)1354891264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)649658369;
				if (num != 0)
				{
				}
				num = (short)1222180865;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> list;
				for (;;)
				{
					num = (short)1770913792;
					short num3 = num;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					case 2:
						try
						{
							num = (short)302645248;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								IL_E6:
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_101;
									}
									continue;
								case 1:
									while (enumerator.MoveNext())
									{
										num = (short)1575396361;
										short num4 = num;
										num = (short)1764729865;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
										{
											num = (short)1076166656;
											if (num != 0)
											{
											}
											object obj = enumerator.Current;
											list.Add(obj as global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem);
											num = (short)987824131;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_E6;
										}
										}
									}
									num = (short)23134212;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1D3;
								case 4:
									num = (short)320339970;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17C:
								num = (short)598867969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_101:
								goto IL_17C;
							}
							IL_1D3:
							goto IL_280;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1F5;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1E2:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)104529922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)947650560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_24A;
								case 2:
									goto IL_248;
								}
								goto IL_1F5;
							}
							IL_248:
							IL_24A:
							goto EndFinally_6;
							IL_1F5:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1135738881;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E2;
							EndFinally_6:;
						}
						goto IL_24B;
					}
					IL_A1:
					if (this.iEdit == null)
					{
						num = (short)1605435392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_24B:
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem>();
					enumerator = this.lbSelectedItems.SelectedItems.GetEnumerator();
					num = (short)170721282;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_280:
				this.iEdit.SelectedListBoxSelctedItems.Clear();
				this.iEdit.SelectedListBoxSelctedItems.AddRange(list);
				this.iEdit.SelectedIndex = this.lbSelectedItems.SelectedIndex;
				return;
			}
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0006768C File Offset: 0x0006588C
		private void ListBox_PreviewMouseMove(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)1558380549;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1080623104;
				short num3 = num;
				bool flag;
				global::System.Windows.Controls.ListBox listBox;
				bool flag2;
				bool flag3;
				switch (num2)
				{
				case 0:
					num = (short)510722058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					flag = !this.scvItems.IsMouseCaptureWithin;
					goto IL_2EA;
				case 2:
					global::System.Windows.DragDrop.DoDragDrop(listBox, listBox.SelectedItems, global::System.Windows.DragDropEffects.All);
					num = (short)49479696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)588316673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.btnRemove.IsEnabled)
					{
						num = (short)1022885888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1767964680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				case 6:
					goto IL_1A6;
				case 7:
					goto IL_1A6;
				case 8:
				{
					num = (short)1704650012;
					short num4 = num;
					num = (short)2006181148;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_249;
					default:
						num = (short)421134336;
						if (num != 0)
						{
						}
						flag2 = false;
						goto IL_2CC;
					}
					break;
				}
				case 9:
					num = (short)1030291470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_249;
				case 11:
					return;
				case 12:
					if (listBox == this.lbItems)
					{
						num = (short)593035273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)73203716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					flag = false;
					goto IL_2EA;
				case 14:
					if (this.btnAdd.IsEnabled)
					{
						num = (short)128253955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1169686541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (flag3)
					{
						num = (short)1177878530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 16:
					return;
				}
				IL_91:
				if (A_1.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
				{
					num = (short)224067595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				listBox = (global::System.Windows.Controls.ListBox)A_0;
				this.dragSource = listBox;
				flag3 = false;
				num = (short)1005191180;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A6:
				num = (short)1587544079;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CC:
				flag3 = flag2;
				num = (short)223543302;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_249:
				num = (short)1200291841;
				if (num != 0)
				{
				}
				flag2 = !this.scvSelectedItems.IsMouseCaptureWithin;
				goto IL_2CC;
				IL_2EA:
				flag3 = flag;
				num = (short)1073676295;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000679C8 File Offset: 0x00065BC8
		private void OnListBoxDrop(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)294024150;
			short num2 = num;
			num = (short)143225814;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1832058880;
				if (num != 0)
				{
				}
				num = (short)213647360;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 1:
					goto IL_107;
				case 2:
					return;
				case 3:
					return;
				case 4:
					if (A_0 == this.lbItems)
					{
						num = (short)1195769857;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_182;
				case 5:
					if (this.dragSource == A_0)
					{
						num = (short)463339522;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1789591556;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_85:
				if (A_1.Effects == global::System.Windows.DragDropEffects.None)
				{
					num = (short)1472921600;
					short num4 = num;
					num = (short)1930887171;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)518258693;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_107:
			num = (short)192348161;
			if (num != 0)
			{
			}
			this.iEdit.RemoveCommand.Execute(null);
			return;
			IL_182:
			this.iEdit.AddCommand.Execute(null);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00067B68 File Offset: 0x00065D68
		public void UserControl_DataContextChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					this.iEdit.AvailableListBoxSelectedItems.Clear();
					this.iEdit.SelectedListBoxSelctedItems.Clear();
					num2 = (short)1347289090;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.iEdit != null)
					{
						num2 = (short)1141178368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_111;
				}
				goto IL_1C;
			}
			IL_111:
			num2 = (short)240320512;
			short num3 = num2;
			return;
			IL_1C:
			num2 = (short)356646913;
			if (num2 != 0)
			{
			}
			num2 = (short)96267024;
			short num4 = num2;
			num2 = (short)2029972240;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)717094912;
				if (num2 != 0)
				{
				}
				this.iEdit = (base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.IMultiSelectionListEdit);
				num2 = (short)1186725889;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00067CB4 File Offset: 0x00065EB4
		public static global::System.Windows.Media.Visual GetDescendantByType(global::System.Windows.Media.Visual element, global::System.Type type)
		{
			short num = (short)1021444102;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_1E9;
				case 1:
					goto IL_204;
				case 2:
				{
					global::System.Windows.Media.Visual visual;
					if (visual == null)
					{
						num = (short)1572405258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return visual;
				}
				case 3:
				{
					global::System.Windows.Media.Visual visual;
					return visual;
				}
				case 4:
					if (element is global::System.Windows.FrameworkElement)
					{
						num = (short)144769033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E9;
				case 5:
					goto IL_204;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 7:
					goto IL_9A;
				case 8:
					return element;
				case 9:
					(element as global::System.Windows.FrameworkElement).ApplyTemplate();
					num = (short)2024341504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num3++;
					num = (short)819920901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					if (element.GetType() == type)
					{
						num = (short)958660616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Media.Visual visual = null;
					num = (short)1065353220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
				{
					if (num3 >= global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(element))
					{
						num = (short)1584922627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1983250432;
					short num4 = num;
					global::System.Windows.Media.Visual element2 = global::System.Windows.Media.VisualTreeHelper.GetChild(element, num3) as global::System.Windows.Media.Visual;
					global::System.Windows.Media.Visual visual = global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.GetDescendantByType(element2, type);
					num = (short)953733113;
					short num5 = num;
					num = (short)847826937;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E7;
					default:
						num = (short)1667825664;
						if (num != 0)
						{
						}
						num = (short)1309933570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_59:
				num = (short)448921601;
				if (num != 0)
				{
				}
				if (element == null)
				{
					num = (short)1270546439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2037121035;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E9:
				num3 = 0;
				num = (short)1105526785;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_204:
				num = (short)283967500;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9A:
			IL_1E7:
			return null;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00067F44 File Offset: 0x00066144
		public override void SetPreviewMode()
		{
			short num = (short)678363136;
			short num2 = num;
			num = (short)1262268116;
			short num3 = num;
			num = (short)1400024788;
			switch (num3 == num)
			{
			}
			num = (short)838074368;
			if (num != 0)
			{
			}
			num = (short)247922689;
			if (num != 0)
			{
			}
			base.Height = 24.0;
			base.SetPreviewMode();
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00068004 File Offset: 0x00066204
		public override void SetPreviewModeProperties(global::System.Windows.FrameworkElementFactory cellFieldEditorFactory)
		{
			short num = (short)61079552;
			short num2 = num;
			num = (short)870110516;
			short num3 = num;
			num = (short)2741556;
			switch (num3 == num)
			{
			}
			num = (short)218693632;
			if (num != 0)
			{
			}
			num = (short)357367809;
			if (num != 0)
			{
			}
			base.SetPreviewModeProperties(cellFieldEditorFactory);
			cellFieldEditorFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.IsBatchOperationAllowedProperty, this.IsBatchOperationAllowed);
			cellFieldEditorFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.AvailableListBoxLabelProperty, this.AvailableListBoxLabel);
			cellFieldEditorFactory.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.SelectedListBoxLabelProperty, this.SelectedListBoxLabel);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x000680F0 File Offset: 0x000662F0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 11;
			while (this._contentLoaded)
			{
				short num = (short)1339817984;
				short num2 = num;
				num = (short)1522404462;
				short num3 = num;
				num = (short)874712174;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1330642945;
					if (num != 0)
					{
					}
					num = (short)643432448;
					if (num != 0)
					{
					}
					return;
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("貢좦\udda8쒪\udfac삮\uddb0튲鮴횸횺킼킾꿀胂闄铆駊곌ꯎ룐볒飔뛖럘뫚뫜뫞賠蛢诤鏦쟨꣪苬臮藰臲髴鯶諸샺黼郾氀猂樄椆氈攊礌‎搐怒瀔攖稘琚猜欞匠䰢䤤否ب太䀬䘮䔰嘲場䐶吸吺䬼娾㍀浂㵄♆⑈❊", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000681D4 File Offset: 0x000663D4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1549271040;
			short num2 = num;
			num = (short)2100822017;
			if (num != 0)
			{
			}
			num = (short)777262338;
			short num3 = num;
			num = (short)1941247234;
			switch (num3 == num)
			{
			}
			num = (short)1487273984;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00068288 File Offset: 0x00066488
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1688199023;
			short num2 = num;
			num = (short)969924463;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1928134656;
				if (num != 0)
				{
				}
				num = (short)849739777;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)1765212161;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					num = (short)1293811714;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A1;
					}
					continue;
				case 2:
					goto IL_188;
				}
				IL_A1:
				num = (short)288686080;
				short num4 = num;
				switch (connectionId)
				{
				case 1:
					goto IL_157;
				case 2:
					goto IL_1B4;
				case 3:
					goto IL_1A7;
				case 4:
					goto IL_1EF;
				case 5:
					goto IL_14A;
				case 6:
					goto IL_18D;
				case 7:
					goto IL_10F;
				case 8:
					goto IL_164;
				case 9:
					goto IL_19A;
				default:
					num = (short)1326579712;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10F:
			this.lbSelectedItems = (global::System.Windows.Controls.ListBox)target;
			this.lbSelectedItems.PreviewMouseMove += this.ListBox_PreviewMouseMove;
			this.lbSelectedItems.SelectionChanged += this.lbSelectedItems_SelectionChanged;
			return;
			IL_14A:
			this.btnRemove = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_157:
			this.itemsMover = (global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover)target;
			return;
			IL_164:
			this.btnUp = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_188:
			this._contentLoaded = true;
			return;
			IL_18D:
			this.btnRemoveAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_19A:
			this.btnDown = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1A7:
			this.btnAddAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1B4:
			this.lbItems = (global::System.Windows.Controls.ListBox)target;
			this.lbItems.PreviewMouseMove += this.ListBox_PreviewMouseMove;
			this.lbItems.SelectionChanged += this.lbItems_SelectionChanged;
			return;
			IL_1EF:
			this.btnAdd = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00068498 File Offset: 0x00066698
		// Note: this type is marked as 'beforefieldinit'.
		static RMItemsMover()
		{
			int a_ = 19;
			short num = (short)727318528;
			short num2 = num;
			num = (short)440479352;
			short num3 = num;
			num = (short)970206840;
			switch (num3 == num)
			{
			}
			num = (short)999424001;
			if (num != 0)
			{
			}
			num = (short)1435303936;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.IsMultipleSelectionAllowedProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udeac쒰\udfb2솴\udeb6즸ힺ\ud8bc꓀꿂ꃄ꓆뷈ꋊꋌꇎ郐뿒맔룖께뻚맜", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover), new global::System.Windows.PropertyMetadata(true));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.IsBatchOperationAllowedProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udeac킰잲횴\udfb6쮺\ud8bc춾ꃀ럂계꣆ꟈ諊ꇌꏎ뻐ꓒ냔돖", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover), null);
			global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.AvailableListBoxLabelProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udbac캮\ud8b0\udfb2풴햶햸\udeba횾닀럂蟄꣆뇈蟊곌귎듐뿒", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.SelectedListBoxLabelProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좬쎮풰킲솴튶\uddb8풼첾뗀臂꫄뿆藈꫊꿌꫎뷐", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.PositionMoverVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﮪ슬\udcae\ud8b0잲\udcb4\ud8b6ힸ튼즾꓀뇂鏄껆뫈ꋊ꿌ꛎ뷐뫒ꇔ껖", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover), null);
		}

		// Token: 0x040002C7 RID: 711
		private global::System.Windows.Controls.ListBox dragSource;

		// Token: 0x040002C8 RID: 712
		private global::Motorola.CommonCPS.RadioManagement.UIModels.IMultiSelectionListEdit iEdit;

		// Token: 0x040002C9 RID: 713
		private global::System.Windows.Controls.ScrollViewer scvItems;

		// Token: 0x040002CA RID: 714
		private global::System.Windows.Controls.ScrollViewer scvSelectedItems;

		// Token: 0x040002CB RID: 715
		public static readonly global::System.Windows.DependencyProperty IsMultipleSelectionAllowedProperty;

		// Token: 0x040002CC RID: 716
		public static readonly global::System.Windows.DependencyProperty IsBatchOperationAllowedProperty;

		// Token: 0x040002CD RID: 717
		public static readonly global::System.Windows.DependencyProperty AvailableListBoxLabelProperty;

		// Token: 0x040002CE RID: 718
		public static readonly global::System.Windows.DependencyProperty SelectedListBoxLabelProperty;

		// Token: 0x040002CF RID: 719
		public static readonly global::System.Windows.DependencyProperty PositionMoverVisibilityProperty;

		// Token: 0x040002D0 RID: 720
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover itemsMover;

		// Token: 0x040002D1 RID: 721
		internal global::System.Windows.Controls.ListBox lbItems;

		// Token: 0x040002D2 RID: 722
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnAddAll;

		// Token: 0x040002D3 RID: 723
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnAdd;

		// Token: 0x040002D4 RID: 724
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRemove;

		// Token: 0x040002D5 RID: 725
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRemoveAll;

		// Token: 0x040002D6 RID: 726
		internal global::System.Windows.Controls.ListBox lbSelectedItems;

		// Token: 0x040002D7 RID: 727
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnUp;

		// Token: 0x040002D8 RID: 728
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnDown;

		// Token: 0x040002D9 RID: 729
		private bool _contentLoaded;
	}
}
