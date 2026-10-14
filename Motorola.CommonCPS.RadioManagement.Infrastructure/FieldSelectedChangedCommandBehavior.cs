using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Editors;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000011 RID: 17
	public class FieldSelectedChangedCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.Editors.XamComboEditor>
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000051B0 File Offset: 0x000033B0
		public FieldSelectedChangedCommandBehavior(global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor) : base(xamComboEditor)
		{
			xamComboEditor.SelectedItemChanged += this.a;
			xamComboEditor.MouseLeave += this.a;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000051E8 File Offset: 0x000033E8
		private void a(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)472741090;
			short num2 = num;
			num = (short)1830909154;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)870121472;
				if (num != 0)
				{
				}
				num = (short)1522335745;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_95;
				}
				int num3;
				global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor;
				for (;;)
				{
					IL_7B:
					switch (num3)
					{
					case 0:
						num = (short)283705347;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1924661248;
						short num4 = num;
						if (xamComboEditor.IsInEditMode)
						{
							num = (short)892993536;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						return;
					case 3:
						if (!xamComboEditor.IsDropDownOpen)
						{
							num = (short)1280114692;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						xamComboEditor.EndEditMode(true, true);
						num = (short)999686146;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_95:
				xamComboEditor = (A_0 as global::Infragistics.Windows.Editors.XamComboEditor);
				num = (short)1979973633;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7B;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005348 File Offset: 0x00003548
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)81723393;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)219021315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
						goto IL_12D;
					case 3:
						if ((A_0 as global::Infragistics.Windows.Editors.XamComboEditor).IsKeyboardFocusWithin)
						{
							num = (short)792002564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_170;
					case 4:
						goto IL_8A;
					}
					IL_38:
					num = (short)37158912;
					short num3 = num;
					if (!(A_0 as global::Infragistics.Windows.Editors.XamComboEditor).IsMouseCaptureWithin)
					{
						num = (short)824442880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8A:
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = ((global::Infragistics.Windows.Editors.XamComboEditor)A_0).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord;
					object[] commandParameter = new object[]
					{
						dataRecord.DataItem,
						A_1.OldValue,
						A_1.NewValue
					};
					base.CommandParameter = commandParameter;
					this.ExecuteCommand();
					num = (short)2121393719;
					short num4 = num;
					num = (short)1609295415;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)1189347328;
						if (num != 0)
						{
						}
						num = (short)2136080386;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_12D:
			IL_170:
			num = (short)1271070721;
			if (num != 0)
			{
			}
		}
	}
}
