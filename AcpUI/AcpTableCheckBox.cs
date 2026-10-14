using System;
using System.Windows;
using System.Windows.Input;

namespace AcpUI
{
	// Token: 0x02000007 RID: 7
	public class AcpTableCheckBox : global::AcpUI.AcpCheckBox
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00005618 File Offset: 0x00003818
		public AcpTableCheckBox()
		{
			base.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005634 File Offset: 0x00003834
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)122869516;
			short num2 = num;
			num = (short)799659788;
			switch (num2 == num)
			{
			}
			num = (short)537395201;
			if (num != 0)
			{
			}
			num = (short)1874198528;
			short num3 = num;
			num = (short)1869086720;
			if (num != 0)
			{
			}
			new global::AcpUI.AcpTableTextBoxBase().AcpTableTextBox_PreviewKeyDown(null, e);
		}
	}
}
