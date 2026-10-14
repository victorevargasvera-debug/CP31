using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000092 RID: 146
	public class RMSealedFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor
	{
		// Token: 0x06000377 RID: 887 RVA: 0x00039444 File Offset: 0x00037644
		public RMSealedFieldEditor()
		{
			base.GotFocus += this.RMSealedFieldEditor_GotFocus;
			base.LostFocus += this.RMSealedFieldEditor_LostFocus;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0003947C File Offset: 0x0003767C
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00039528 File Offset: 0x00037728
		public static string CurrentFieldName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)927076106;
				short num2 = num;
				num = (short)333188874;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075576832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2016280576;
				if (num != 0)
				{
				}
				num = (short)1997209601;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Controls.RMSealedFieldEditor.<CurrentFieldName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1441637860;
				short num2 = num;
				num = (short)1474930148;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2110390272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1664679937;
				if (num != 0)
				{
				}
				num = (short)816250880;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.RMSealedFieldEditor.<CurrentFieldName>k__BackingField = value;
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000395D4 File Offset: 0x000377D4
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)276299776;
			short num2 = num;
			num = (short)1165582344;
			short num3 = num;
			num = (short)2071027720;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)17039360;
				if (num != 0)
				{
				}
				num = (short)1758330881;
				if (num != 0)
				{
				}
				base.OnMouseEnter(e);
				global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase;
				if (fieldBase != null)
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.RMSealedFieldEditor.CurrentFieldName = fieldBase.Name;
					return;
				}
				break;
			}
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000396A4 File Offset: 0x000378A4
		private void RMSealedFieldEditor_GotFocus(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)331939840;
			short num2 = num;
			num = (short)1509348948;
			short num3 = num;
			num = (short)548001364;
			switch (num3 == num)
			{
			}
			num = (short)1706885121;
			if (num != 0)
			{
			}
			num = (short)255197184;
			if (num != 0)
			{
			}
			base.RaiseEnterField();
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00039754 File Offset: 0x00037954
		private void RMSealedFieldEditor_LostFocus(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2143748096;
			short num2 = num;
			num = (short)615688789;
			short num3 = num;
			num = (short)184330837;
			switch (num3 == num)
			{
			}
			num = (short)1432289281;
			if (num != 0)
			{
			}
			num = (short)558301184;
			if (num != 0)
			{
			}
			base.RaiseLeaveField();
		}
	}
}
