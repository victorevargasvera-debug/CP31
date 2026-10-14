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
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000E6 RID: 230
	public class RMScanList : global::Motorola.CommonCPS.RadioManagement.Controls.RMSealedFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x00064A54 File Offset: 0x00062C54
		public RMScanList()
		{
			this.InitializeComponent();
			this.lbItems.Drop += this.OnListBoxDrop;
			this.lbSelectedItems.Drop += this.OnListBoxDrop;
			this.scvItems = (global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.GetDescendantByType(this.lbItems, typeof(global::System.Windows.Controls.ScrollViewer)) as global::System.Windows.Controls.ScrollViewer);
			this.scvSelectedItems = (global::Motorola.CommonCPS.RadioManagement.Controls.RMItemsMover.GetDescendantByType(this.lbSelectedItems, typeof(global::System.Windows.Controls.ScrollViewer)) as global::System.Windows.Controls.ScrollViewer);
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00064ADC File Offset: 0x00062CDC
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00064B94 File Offset: 0x00062D94
		public bool IsBatchOperationAllowed
		{
			get
			{
				short num = (short)1623246188;
				short num2 = num;
				num = (short)1594738028;
				switch (num2 == num)
				{
				}
				num = (short)1888747521;
				if (num != 0)
				{
				}
				num = (short)1760428032;
				short num3 = num;
				num = (short)411041792;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList.IsBatchOperationAllowedProperty);
			}
			set
			{
				short num = (short)38640022;
				short num2 = num;
				num = (short)1497995670;
				switch (num2 == num)
				{
				}
				num = (short)221511681;
				if (num != 0)
				{
				}
				num = (short)381878272;
				short num3 = num;
				num = (short)1464205312;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList.IsBatchOperationAllowedProperty, value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00064C50 File Offset: 0x00062E50
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00064D0C File Offset: 0x00062F0C
		public string AvailableListBoxLabel
		{
			get
			{
				short num = (short)751435777;
				if (num != 0)
				{
				}
				num = (short)369841983;
				short num2 = num;
				num = (short)320624447;
				switch (num2 == num)
				{
				}
				num = (short)775618560;
				short num3 = num;
				num = (short)745668608;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList.AvailableListBoxLabelProperty);
			}
			set
			{
				short num = (short)869557067;
				short num2 = num;
				num = (short)1842570059;
				switch (num2 == num)
				{
				}
				num = (short)825229313;
				if (num != 0)
				{
				}
				num = (short)776536064;
				short num3 = num;
				num = (short)784072704;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList.AvailableListBoxLabelProperty, value);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00064DC0 File Offset: 0x00062FC0
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00064E78 File Offset: 0x00063078
		public string SelectedListBoxLabel
		{
			get
			{
				short num = (short)336068609;
				if (num != 0)
				{
				}
				num = (short)1732332247;
				short num2 = num;
				num = (short)573524695;
				switch (num2 == num)
				{
				}
				num = (short)270008320;
				short num3 = num;
				num = (short)2092040192;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList.SelectedListBoxLabelProperty);
			}
			set
			{
				short num = (short)1682650007;
				short num2 = num;
				num = (short)338113431;
				switch (num2 == num)
				{
				}
				num = (short)896991233;
				if (num != 0)
				{
				}
				num = (short)1429667840;
				short num3 = num;
				num = (short)737738752;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList.SelectedListBoxLabelProperty, value);
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00064F30 File Offset: 0x00063130
		private void lbItems_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)1801453568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1427767297;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> list;
				for (;;)
				{
					num = (short)1812725761;
					if (num != 0)
					{
					}
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1280180225;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)692191234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_105;
									}
									continue;
								case 2:
									goto IL_17F;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1918500864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									list.Add(obj as global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem);
									num = (short)432406531;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_132:
								num = (short)1161625604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_105:
								goto IL_132;
							}
							IL_17F:
							goto IL_27D;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1A1;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_18E:
								switch (num2)
								{
								case 0:
									goto IL_244;
								case 1:
									if (disposable != null)
									{
										num = (short)2097741826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_246;
								case 2:
								{
									disposable.Dispose();
									num = (short)796336488;
									short num3 = num;
									num = (short)1645093224;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_244;
									default:
										num = (short)1424424960;
										if (num != 0)
										{
										}
										num = (short)338427904;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_1A1;
							}
							IL_244:
							IL_246:
							goto EndFinally_6;
							IL_1A1:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)632684545;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_18E;
							EndFinally_6:;
						}
						goto IL_247;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_77;
						}
						continue;
					case 2:
						return;
					}
					IL_77:
					num = (short)739246080;
					short num4 = num;
					if (this.iEdit == null)
					{
						num = (short)1512767490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_247:
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem>();
					enumerator = this.lbItems.SelectedItems.GetEnumerator();
					num = (short)1961623552;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_27D:
				this.iEdit.AvailableListBoxSelectedItems.Clear();
				this.iEdit.AvailableListBoxSelectedItems.AddRange(list);
				return;
			}
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000651EC File Offset: 0x000633EC
		private void lbSelectedItems_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			short num = (short)1792147456;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1295777793;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> list;
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)603521025;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1664286722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_105;
									}
									continue;
								case 2:
									goto IL_17F;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)269352960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									list.Add(obj as global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem);
									num = (short)1255604227;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_131:
								num = (short)1099104260;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_105:
								goto IL_131;
							}
							IL_17F:
							goto IL_27C;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1A1;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_18E:
								switch (num2)
								{
								case 0:
									goto IL_244;
								case 1:
									if (disposable != null)
									{
										num = (short)1312096258;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_246;
								case 2:
								{
									disposable.Dispose();
									num = (short)786391952;
									short num3 = num;
									num = (short)1725981584;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_244;
									default:
										num = (short)81068032;
										if (num != 0)
										{
										}
										num = (short)1197080576;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_1A1;
							}
							IL_244:
							IL_246:
							goto EndFinally_6;
							IL_1A1:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)357892097;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_18E;
							EndFinally_6:;
						}
						goto IL_247;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_51;
						}
						continue;
					case 2:
						return;
					}
					IL_51:
					if (this.iEdit == null)
					{
						num = (short)81854464;
						short num4 = num;
						num = (short)1678901249;
						if (num != 0)
						{
						}
						num = (short)378798082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_247:
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem>();
					enumerator = this.lbSelectedItems.SelectedItems.GetEnumerator();
					num = (short)661258240;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_27C:
				this.iEdit.SelectedListBoxSelctedItems.Clear();
				this.iEdit.SelectedListBoxSelctedItems.AddRange(list);
				return;
			}
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000654A8 File Offset: 0x000636A8
		private void ListBox_PreviewMouseMove(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)1839005707;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				bool flag2;
				bool flag3;
				global::System.Windows.Controls.ListBox listBox;
				switch (num2)
				{
				case 0:
					if (flag)
					{
						num = (short)1284636679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_159;
				case 2:
				{
					if (this.btnRemove.IsEnabled)
					{
						num = (short)300417032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1359937536;
					short num3 = num;
					num = (short)792985610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					return;
				case 4:
					return;
				case 5:
					flag2 = false;
					goto IL_2E3;
				case 6:
					flag3 = !this.scvSelectedItems.IsMouseCaptureWithin;
					goto IL_2C6;
				case 7:
					goto IL_18D;
				case 8:
					num = (short)1426194438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_159;
				case 10:
					flag3 = false;
					goto IL_2C6;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					continue;
				case 12:
					flag2 = !this.scvItems.IsMouseCaptureWithin;
					goto IL_2E3;
				case 13:
					if (this.btnAdd.IsEnabled)
					{
						num = (short)268238863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1158545413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)1765212173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)796721164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (listBox == this.lbItems)
					{
						num = (short)270073870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)725221378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_68:
				if (A_1.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
				{
					num = (short)1016659972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				listBox = (global::System.Windows.Controls.ListBox)A_0;
				this.dragSource = listBox;
				flag = false;
				num = (short)348646108;
				short num4 = num;
				num = (short)70511324;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_18D;
				default:
					num = (short)1437401089;
					if (num != 0)
					{
					}
					num = (short)844562432;
					if (num != 0)
					{
					}
					num = (short)1635319824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_159:
				num = (short)705495040;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18D:
				global::System.Windows.DragDrop.DoDragDrop(listBox, listBox.SelectedItems, global::System.Windows.DragDropEffects.All);
				num = (short)1130364931;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C6:
				flag = flag3;
				num = (short)973930497;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E3:
				flag = flag2;
				num = (short)1445593097;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000657E0 File Offset: 0x000639E0
		private void OnListBoxDrop(object A_0, global::System.Windows.DragEventArgs A_1)
		{
			short num = (short)879624196;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.dragSource == A_0)
					{
						num = (short)1310654469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)300154882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					num = (short)11862017;
					if (num != 0)
					{
					}
					if (A_0 == this.lbItems)
					{
						num = (short)1943797763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18C;
				case 3:
					goto IL_C1;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					goto IL_187;
				}
				IL_3C:
				if (A_1.Effects == global::System.Windows.DragDropEffects.None)
				{
					num = (short)1280966657;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1123811328;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_C1:
			this.iEdit.RemoveCommand.Execute(null);
			return;
			IL_187:
			num = (short)887685168;
			short num3 = num;
			num = (short)1170866224;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C1;
			case 1:
				break;
			default:
			{
				num = (short)950599680;
				short num4 = num;
				break;
			}
			}
			num = (short)738918400;
			if (num != 0)
			{
			}
			return;
			IL_18C:
			this.iEdit.AddCommand.Execute(null);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0006598C File Offset: 0x00063B8C
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
					num2 = (short)1557528577;
					if (num2 != 0)
					{
					}
					num2 = (short)127270914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_8F;
				case 2:
					return;
				}
				goto IL_1C;
			}
			IL_8F:
			num2 = (short)2111963136;
			short num3 = num2;
			if (this.iEdit != null)
			{
				goto IL_C2;
			}
			return;
			IL_1C:
			this.iEdit = (base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.IScanList);
			num2 = (short)2125355403;
			short num4 = num2;
			num2 = (short)140401035;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C2:
				num2 = (short)1291911168;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2107047936;
				if (num2 != 0)
				{
				}
				num2 = (short)43122689;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00065AD8 File Offset: 0x00063CD8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num;
			if (this._contentLoaded)
			{
				for (;;)
				{
					num = (short)998637568;
					short num2 = num;
					num = (short)888535775;
					short num3 = num;
					num = (short)1818491615;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_71;
					}
				}
				IL_71:
				num = (short)169410560;
				if (num != 0)
				{
				}
				return;
			}
			num = (short)1684078593;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("辟쮣튥잧\ud8a9쎫슭톯鲱\ud9b5햷ힹ펻킽莿鋁韃髇ꯉ꣋ꟍ뿏鿑뗓룕맗뷙맛돝藟賡郣죥ꯧ藩苫髭苯鷱飳藵쏷駹鏻鏽烿洁樃挅昇縉⌋笍挏眑易甕眗琙栛氝伟両圣थ丧䌩䤫䈭启圱倳張䰷唹主䴽漿ぁ⥃㕅⭇⭉≋≍㥏⅑⁓硕⁗㭙ㅛ㉝", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00065BB8 File Offset: 0x00063DB8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)946025265;
			short num2 = num;
			num = (short)2064593713;
			switch (num2 == num)
			{
			}
			num = (short)225705984;
			if (num != 0)
			{
			}
			num = (short)1625554944;
			short num3 = num;
			num = (short)746389505;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00065C6C File Offset: 0x00063E6C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1079836673;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)963843291;
					short num3 = num;
					num = (short)163845339;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19F;
					default:
						num = (short)35323904;
						if (num != 0)
						{
						}
						num = (short)1880686594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_18D;
				}
				IL_30:
				num = (short)1616773121;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 1:
					goto IL_111;
				case 2:
					goto IL_1B9;
				case 3:
					goto IL_201;
				case 4:
					goto IL_1AC;
				case 5:
					goto IL_DC;
				case 6:
					goto IL_1F4;
				case 7:
					goto IL_A1;
				case 8:
					goto IL_192;
				case 9:
					goto IL_11E;
				case 10:
					goto IL_19F;
				default:
					num = (short)538116096;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_A1:
			this.lbSelectedItems = (global::System.Windows.Controls.ListBox)target;
			this.lbSelectedItems.PreviewMouseMove += this.ListBox_PreviewMouseMove;
			this.lbSelectedItems.SelectionChanged += this.lbSelectedItems_SelectionChanged;
			return;
			IL_DC:
			num = (short)981991424;
			short num4 = num;
			this.btnRemove = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_111:
			this.itemsMover = (global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList)target;
			return;
			IL_11E:
			this.btnSetPriority2 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_18D:
			this._contentLoaded = true;
			return;
			IL_192:
			this.btnSetPriority1 = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_19F:
			this.btnSetAffiliation = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1AC:
			this.btnAdd = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1B9:
			this.lbItems = (global::System.Windows.Controls.ListBox)target;
			this.lbItems.PreviewMouseMove += this.ListBox_PreviewMouseMove;
			this.lbItems.SelectionChanged += this.lbItems_SelectionChanged;
			return;
			IL_1F4:
			this.btnRemoveAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_201:
			this.btnAddAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00065E90 File Offset: 0x00064090
		// Note: this type is marked as 'beforefieldinit'.
		static RMScanList()
		{
			int a_ = 8;
			short num = (short)1772202482;
			short num2 = num;
			num = (short)632334834;
			switch (num2 == num)
			{
			}
			num = (short)39452673;
			if (num != 0)
			{
			}
			num = (short)679673856;
			short num3 = num;
			num = (short)1669267456;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList.IsBatchOperationAllowedProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톡장\udca7즩쒫삯ힱ욳ힵ첷펹펻킽膿껁ꣃ꧅뿇꿉꣋", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList), null);
			global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList.AvailableListBoxLabelProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("풡얣쾥쒧쮩캫슭햯ﺱ\uddb3억첷펻욽貿ꏁꛃꏅ꓇", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList.SelectedListBoxLabelProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("잡좣쎥쮧\udea9즫쪭ﲯ\udbb1잳습覆햹쒻ꆿꃁꇃ꫅", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, null));
		}

		// Token: 0x040002AF RID: 687
		private global::System.Windows.Controls.ListBox dragSource;

		// Token: 0x040002B0 RID: 688
		private global::Motorola.CommonCPS.RadioManagement.UIModels.IScanList iEdit;

		// Token: 0x040002B1 RID: 689
		private global::System.Windows.Controls.ScrollViewer scvItems;

		// Token: 0x040002B2 RID: 690
		private global::System.Windows.Controls.ScrollViewer scvSelectedItems;

		// Token: 0x040002B3 RID: 691
		public static readonly global::System.Windows.DependencyProperty IsBatchOperationAllowedProperty;

		// Token: 0x040002B4 RID: 692
		public static readonly global::System.Windows.DependencyProperty AvailableListBoxLabelProperty;

		// Token: 0x040002B5 RID: 693
		public static readonly global::System.Windows.DependencyProperty SelectedListBoxLabelProperty;

		// Token: 0x040002B6 RID: 694
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMScanList itemsMover;

		// Token: 0x040002B7 RID: 695
		internal global::System.Windows.Controls.ListBox lbItems;

		// Token: 0x040002B8 RID: 696
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnAddAll;

		// Token: 0x040002B9 RID: 697
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnAdd;

		// Token: 0x040002BA RID: 698
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRemove;

		// Token: 0x040002BB RID: 699
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRemoveAll;

		// Token: 0x040002BC RID: 700
		internal global::System.Windows.Controls.ListBox lbSelectedItems;

		// Token: 0x040002BD RID: 701
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnSetPriority1;

		// Token: 0x040002BE RID: 702
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnSetPriority2;

		// Token: 0x040002BF RID: 703
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnSetAffiliation;

		// Token: 0x040002C0 RID: 704
		private bool _contentLoaded;
	}
}
