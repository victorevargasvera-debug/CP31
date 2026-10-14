using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000120 RID: 288
	public class RMTextBox : global::System.Windows.Controls.TextBox
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x00096C68 File Offset: 0x00094E68
		static RMTextBox()
		{
			short num = (short)1918415639;
			short num2 = num;
			num = (short)653112087;
			switch (num2 == num)
			{
			}
			num = (short)1316683776;
			if (num != 0)
			{
			}
			num = (short)514916352;
			short num3 = num;
			num = (short)623509505;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)));
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00096D38 File Offset: 0x00094F38
		protected override void OnTextChanged(global::System.Windows.Controls.TextChangedEventArgs e)
		{
			short num = (short)1554409519;
			short num2 = num;
			num = (short)120023087;
			switch (num2 == num)
			{
			}
			num = (short)290193409;
			if (num != 0)
			{
			}
			num = (short)909705216;
			short num3 = num;
			num = (short)2139226112;
			if (num != 0)
			{
			}
			base.OnTextChanged(e);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00096DEC File Offset: 0x00094FEC
		public RMTextBox()
		{
			base.PreviewKeyUp += this.RMTextBox_PreviewKeyUp;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00096E14 File Offset: 0x00095014
		private void RMTextBox_PreviewKeyUp(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)879624196;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Windows.Data.BindingExpression bindingExpression;
					if (bindingExpression != null)
					{
						num = (short)132513794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 1:
				{
					num = (short)1474828586;
					short num3 = num;
					num = (short)530454826;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_45;
					default:
						goto IL_AF;
					}
					break;
				}
				case 2:
				{
					global::System.Windows.Data.BindingExpression bindingExpression;
					bindingExpression.UpdateSource();
					num = (short)300154881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					global::System.Windows.Data.BindingExpression bindingExpression = base.GetBindingExpression(global::System.Windows.Controls.TextBox.TextProperty);
					num = (short)1099497472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				goto IL_39;
				IL_45:
				num = (short)1758658563;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39:
				if (A_1.Key == global::System.Windows.Input.Key.Return)
				{
					goto IL_45;
				}
				return;
			}
			IL_AF:
			num = (short)756416513;
			if (num != 0)
			{
			}
			num = (short)1750597632;
			if (num != 0)
			{
			}
			num = (short)2115567616;
			short num4 = num;
		}
	}
}
