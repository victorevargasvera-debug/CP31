using System;
using System.Collections;
using System.Windows;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Editors;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000008 RID: 8
	public class ComboBoxSelectSetRequestedCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.Editors.XamComboEditor>
	{
		// Token: 0x06000017 RID: 23 RVA: 0x0000330C File Offset: 0x0000150C
		public ComboBoxSelectSetRequestedCommandBehavior(global::Infragistics.Windows.Editors.XamComboEditor comboEditor) : base(comboEditor)
		{
			comboEditor.ValueChanged += this.a;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003334 File Offset: 0x00001534
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num2;
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor;
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)796534255;
					short num3 = num2;
					num2 = (short)895428079;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D7;
					default:
						num2 = (short)689700864;
						if (num2 != 0)
						{
						}
						num2 = (short)1777074178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					string text;
					if (text != null)
					{
						goto IL_1D7;
					}
					goto IL_1F3;
				}
				case 2:
				{
					string text;
					if (text.Equals(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Action_Show_Sets))
					{
						num2 = (short)1438318597;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F3;
				}
				case 3:
					if (A_1.NewValue == null)
					{
						num2 = (short)1800536077;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2023882763;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					xamComboEditor = (A_0 as global::Infragistics.Windows.Editors.XamComboEditor);
					int count = ((global::System.Collections.ICollection)xamComboEditor.ItemsSource).Count;
					base.CommandParameter = dataRecord.DataItem;
					this.ExecuteCommand();
					num2 = (short)619380742;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					xamComboEditor.SelectedItem = A_1.OldValue;
					num2 = (short)274661384;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					if (xamComboEditor.SelectedIndex == -1)
					{
						num2 = (short)813105159;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string text = xamComboEditor.SelectedItem as string;
					num2 = (short)1318387713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_27D;
				case 8:
					num2 = (short)1051197441;
					if (num2 != 0)
					{
					}
					goto IL_1F3;
				case 9:
					goto IL_213;
				case 10:
					num2 = (short)1683488771;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (A_1.NewValue.ToString() == global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Action_Show_Sets)
					{
						num2 = (short)1617428484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CC;
				case 12:
					if (dataRecord != null)
					{
						num2 = (short)1590755338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 13:
					goto IL_1AB;
				}
				goto IL_48;
				IL_1D7:
				num2 = (short)396099584;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F3:
				xamComboEditor.EndEditMode(true, true);
				num2 = (short)1155530761;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1AB:
			return;
			IL_213:
			goto IL_2CC;
			IL_27D:
			xamComboEditor.SelectedItem = null;
			return;
			IL_2CC:
			num2 = (short)1729822720;
			short num4 = num2;
			return;
			IL_48:
			dataRecord = (((global::Infragistics.Windows.Editors.XamComboEditor)A_0).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
			num2 = (short)1429209100;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
