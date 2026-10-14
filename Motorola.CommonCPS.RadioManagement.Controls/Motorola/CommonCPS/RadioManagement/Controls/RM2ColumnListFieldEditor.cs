using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000CD RID: 205
	public class RM2ColumnListFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x00059E9C File Offset: 0x0005809C
		public RM2ColumnListFieldEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060005A5 RID: 1445 RVA: 0x00059EB8 File Offset: 0x000580B8
		// (remove) Token: 0x060005A6 RID: 1446 RVA: 0x00059F70 File Offset: 0x00058170
		public event global::System.Windows.RoutedEventHandler SelectSetRequested
		{
			add
			{
				short num = (short)695795713;
				if (num != 0)
				{
				}
				num = (short)249036800;
				short num2 = num;
				num = (short)2143909057;
				short num3 = num;
				num = (short)954954945;
				switch (num3 == num)
				{
				}
				num = (short)773390336;
				if (num != 0)
				{
				}
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RM2ColumnListFieldEditor.SelectSetRequestedEvent, value);
			}
			remove
			{
				short num = (short)1193290848;
				short num2 = num;
				num = (short)409152608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1230700544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2145779712;
				if (num != 0)
				{
				}
				num = (short)154140673;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RM2ColumnListFieldEditor.SelectSetRequestedEvent, value);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0005A024 File Offset: 0x00058224
		private void cbbList_SelectionChanged(object A_0, global::System.Windows.Controls.SelectionChangedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)1150353410;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (A_1.RemovedItems.Count > 0)
					{
						num = (short)1054670862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10E;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 3:
					goto IL_10E;
				case 4:
				{
					num = (short)408879104;
					short num3 = num;
					goto IL_29A;
				}
				case 5:
				{
					if (this.cbbList.SelectedIndex == -1)
					{
						num = (short)619577354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Data.BindingOperations.ClearBinding(this.cbbList, global::System.Windows.Controls.Primitives.Selector.SelectedIndexProperty);
					this.cbbList.SetBinding(global::System.Windows.Controls.Primitives.Selector.SelectedIndexProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("直캪솬쪮튰잲킴펶햺\ud9bc\udabe맀", a_));
					global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit listEdit;
					listEdit.SelectedIndex = listEdit.Items.Count - 1;
					listEdit.SelectedIndex = listEdit.Items.Count - 2;
					num = (short)671809542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_29A;
				case 7:
					if (A_1.AddedItems.Count == 0)
					{
						num = (short)272891919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)929300493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					this.cbbList.SelectionChanged -= this.cbbList_SelectionChanged;
					global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit listEdit = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit;
					base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.RM2ColumnListFieldEditor.SelectSetRequestedEvent, listEdit));
					num = (short)630259717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					num = (short)611450887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.cbbList.SelectedItem = null;
					num = (short)1312555012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)484442113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (((global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem)A_1.AddedItems[0]).Name == global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Action_Show_Sets)
					{
						num = (short)1063714824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 13:
					if (A_1.RemovedItems != null)
					{
						num = (short)660996107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10E;
				case 14:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit listEdit2 = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit;
					global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> items = listEdit2.Items;
					num = (short)201064451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					goto IL_21B;
				}
				IL_6D:
				num = (short)2125594625;
				if (num != 0)
				{
				}
				if (A_1.AddedItems != null)
				{
					num = (short)181338121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_10E:
				num = (short)2115043340;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29A:
				num = (short)1573771128;
				short num4 = num;
				num = (short)1827526520;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1551564800;
					if (num != 0)
					{
					}
					this.cbbList.SelectionChanged += this.cbbList_SelectionChanged;
					num = (short)2076246016;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return;
			IL_21B:;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0005A3F8 File Offset: 0x000585F8
		private void btnLock_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)605535518;
			short num2 = num;
			num = (short)2070461726;
			switch (num2 == num)
			{
			default:
			{
				num = (short)574291968;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1248395265;
			if (num != 0)
			{
			}
			num = (short)1767309312;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMButton rmbutton = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMButton;
			this.cbbList.IsEnabled = (bool)rmbutton.Tag;
			rmbutton.Tag = !(bool)rmbutton.Tag;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0005A4D8 File Offset: 0x000586D8
		public override void SetFocus()
		{
			short num = (short)504296000;
			short num2 = num;
			num = (short)379515456;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1364918272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)854851585;
			if (num != 0)
			{
			}
			num = (short)1199702016;
			if (num != 0)
			{
			}
			this.cbbList.Focus();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0005A58C File Offset: 0x0005878C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)1818589582;
			short num2 = num;
			num = (short)1952676238;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)873660417;
				if (num != 0)
				{
				}
				num = (short)1066598400;
				if (num != 0)
				{
				}
				if (this._contentLoaded)
				{
					return;
				}
				break;
			}
			num = (short)642908160;
			short num3 = num;
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("讣잧\udea9쎫\udcad\udfaf\udeb1햳颵﮷햹톻펽꾿곁蟃雅鯇黋꿍듏믑믓鯕맗듙뷛망藟迡臣裥鳧쓩꿫臭黯蛱蛳駵铷觹쟻鷽濿漁球椅昇漉戋稍㼏朑朓猕樗礙猛瀝吟倡䬣䨥嬧ԩ䨫䜭唯帱倳匵尷匹䠻儽㈿ㅁ歃㑅╇硉⽋⅍㱏❑㥓㡕㑗㍙⽛⩝ٟୡţ੥౧ཀྵ࡫ݭѯᵱٳ塵w᭹ᅻች", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0005A670 File Offset: 0x00058870
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1924176716;
			short num2 = num;
			num = (short)52271948;
			switch (num2 == num)
			{
			}
			num = (short)2012807168;
			if (num != 0)
			{
			}
			num = (short)210436096;
			short num3 = num;
			num = (short)1979056129;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0005A720 File Offset: 0x00058920
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2100379850;
			short num2 = num;
			num = (short)763576522;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)932249600;
				if (num != 0)
				{
				}
				num = (short)975175680;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					case 1:
					{
						num = (short)975437824;
						short num4 = num;
						num = (short)1614020610;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_12A;
					}
					IL_7F:
					switch (connectionId)
					{
					case 1:
						goto IL_105;
					case 2:
						goto IL_D2;
					case 3:
						goto IL_12C;
					default:
						num = (short)2104950785;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_D2:
				num = (short)398000129;
				if (num != 0)
				{
				}
				this.cbbList = (global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox)target;
				return;
				IL_105:
				this.tblLabel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
				return;
				IL_12A:
				this._contentLoaded = true;
				return;
			}
			}
			IL_12C:
			this.btnLock = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0005A870 File Offset: 0x00058A70
		// Note: this type is marked as 'beforefieldinit'.
		static RM2ColumnListFieldEditor()
		{
			int a_ = 6;
			short num = (short)841790898;
			short num2 = num;
			num = (short)125089202;
			switch (num2 == num)
			{
			}
			num = (short)1919614977;
			if (num != 0)
			{
			}
			num = (short)162922496;
			short num3 = num;
			num = (short)898826240;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RM2ColumnListFieldEditor.SelectSetRequestedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춝얟캡솣얥\udca7囹즫\udaadힱ얳쎵\uddb7즹좻\udbbd꒿", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RM2ColumnListFieldEditor));
		}

		// Token: 0x0400025A RID: 602
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock tblLabel;

		// Token: 0x0400025B RID: 603
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMComboBox cbbList;

		// Token: 0x0400025C RID: 604
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnLock;

		// Token: 0x0400025D RID: 605
		private bool _contentLoaded;
	}
}
