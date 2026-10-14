using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;
using Infragistics.Windows;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Selection;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls.Behaviors
{
	// Token: 0x02000138 RID: 312
	public class RmDataGridBehavior : global::System.Windows.Interactivity.Behavior<global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid>
	{
		// Token: 0x0600097C RID: 2428 RVA: 0x0009CE84 File Offset: 0x0009B084
		private void b(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid A_0)
		{
			short num = (short)2087911425;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.b)
					{
						num = (short)1132003331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					num = (short)2097676288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1748706699;
					short num3 = num;
					num = (short)1274619275;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_87;
					default:
						num = (short)1267859456;
						if (num != 0)
						{
						}
						this.a = A_0.ContextMenu;
						A_0.ContextMenu = null;
						this.b = true;
						num = (short)1399980036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_87;
				}
				IL_39:
				if (A_0 == null)
				{
					return;
				}
				num = (short)64159746;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_87:
			num = (short)1972436992;
			short num4 = num;
			num = (short)964952065;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0009CFFC File Offset: 0x0009B1FC
		private void a(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid A_0)
		{
			short num = (short)2017853441;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.b)
					{
						num = (short)523108355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
					num = (short)1486553088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1754827867;
					short num3 = num;
					num = (short)1067945051;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1298399232;
						if (num != 0)
						{
						}
						A_0.ContextMenu = this.a;
						this.a = null;
						this.b = false;
						num = (short)570228736;
						short num4 = num;
						num = (short)1429012484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					return;
				}
				IL_38:
				if (A_0 == null)
				{
					break;
				}
				num = (short)1968504833;
				if (num != 0)
				{
				}
				num = (short)1874984962;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0009D16C File Offset: 0x0009B36C
		protected override void OnAttached()
		{
			short num = (short)1641742337;
			if (num != 0)
			{
			}
			num = (short)2068687777;
			short num2 = num;
			num = (short)634825633;
			switch (num2 == num)
			{
			}
			num = (short)2072772608;
			short num3 = num;
			num = (short)528941056;
			if (num != 0)
			{
			}
			base.OnAttached();
			base.AssociatedObject.LayoutUpdated += this.a;
			base.AssociatedObject.MouseRightButtonDown += this.a;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0009D248 File Offset: 0x0009B448
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid;
			short num2;
			global::System.Windows.FrameworkElement frameworkElement;
			global::System.Windows.DependencyObject ancestorFromType;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					rmdataGrid.ShowFieldChooser(rmdataGrid.FieldLayouts[0], false, true, global::Motorola.CommonCPS.ResourceRepository.Resources.Field_Chooser);
					num2 = (short)944898049;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_120;
				case 2:
					if (frameworkElement.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횥즧즩즫\udcad\udbb1\ud8b3\udab5", a_))
					{
						num2 = (short)1043660807;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_277;
				case 3:
					num2 = (short)96665602;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (rmdataGrid != null)
					{
						num2 = (short)951320576;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1EB;
				case 5:
					num2 = (short)1877606409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)332675011;
					short num3 = num2;
					num2 = (short)1670133699;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_23C;
					default:
						num2 = (short)6094848;
						if (num2 != 0)
						{
						}
						if (ancestorFromType == null)
						{
							num2 = (short)907739141;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_241;
					}
					break;
				}
				case 7:
					goto IL_23C;
				case 8:
					if (frameworkElement is global::System.Windows.Controls.Border)
					{
						num2 = (short)1437401098;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_277;
				case 9:
					if (frameworkElement != null)
					{
						num2 = (short)1436942339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_277;
				case 10:
					goto IL_241;
				}
				goto IL_45;
				IL_23C:
				num2 = (short)495583232;
				short num4 = num2;
				num2 = (short)295763976;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_241:
				num2 = (short)1758265348;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_120:
			num2 = (short)1327890433;
			if (num2 != 0)
			{
			}
			IL_1EB:
			this.b(rmdataGrid);
			return;
			IL_277:
			this.a(rmdataGrid);
			return;
			IL_45:
			frameworkElement = (A_1.OriginalSource as global::System.Windows.FrameworkElement);
			ancestorFromType = global::Infragistics.Windows.Utilities.GetAncestorFromType(frameworkElement, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), true);
			rmdataGrid = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid);
			num2 = (short)1963524102;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0009D4D4 File Offset: 0x0009B6D4
		private void a(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 6;
			global::System.Windows.Controls.Button button;
			short num;
			for (;;)
			{
				button = global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.UiHelper.FindChildByName<global::System.Windows.Controls.Button>(base.AssociatedObject, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즟잡좣슥슩쎫솭쎯ힱ욳춷캹좻톽꺿", a_));
				if (button != null)
				{
					goto IL_CC;
				}
				num = (short)1676083200;
				short num2 = num;
				num = (short)563841712;
				short num3 = num;
				num = (short)1057000112;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8D;
				}
			}
			IL_8D:
			num = (short)18284544;
			if (num != 0)
			{
			}
			num = (short)979632129;
			if (num != 0)
			{
			}
			return;
			IL_CC:
			button.Click -= this.a;
			button.Click += this.a;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0009D5D4 File Offset: 0x0009B7D4
		protected override void OnDetaching()
		{
			short num = (short)1347907337;
			short num2 = num;
			num = (short)1103523593;
			switch (num2 == num)
			{
			}
			num = (short)192282624;
			if (num != 0)
			{
			}
			num = (short)1958215680;
			short num3 = num;
			num = (short)1296891905;
			if (num != 0)
			{
			}
			base.OnDetaching();
			base.AssociatedObject.LayoutUpdated -= this.a;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0009D69C File Offset: 0x0009B89C
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num;
			while (base.AssociatedObject.SelectedItems.Count<global::Infragistics.Windows.Selection.ISelectableItem>() > 1)
			{
				num = (short)1689124864;
				short num2 = num;
				num = (short)1809810672;
				short num3 = num;
				num = (short)187008240;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1313275904;
					if (num != 0)
					{
					}
					base.AssociatedObject.SelectedItems.Records.Clear();
					base.AssociatedObject.SelectedItems.Records.Add(base.AssociatedObject.Records.ToArray<global::Infragistics.Windows.DataPresenter.Record>()[0]);
					base.AssociatedObject.Records.DataPresenter.ActiveRecord = base.AssociatedObject.Records.ToArray<global::Infragistics.Windows.DataPresenter.Record>()[0];
					return;
				}
			}
			num = (short)306446337;
			if (num != 0)
			{
			}
			base.AssociatedObject.SelectedItems.Records.Clear();
			base.AssociatedObject.SelectedItems.Records.AddRange(base.AssociatedObject.Records.ToArray<global::Infragistics.Windows.DataPresenter.Record>(), false, true);
		}

		// Token: 0x0400045E RID: 1118
		private global::System.Windows.Controls.ContextMenu a;

		// Token: 0x0400045F RID: 1119
		private bool b;
	}
}
