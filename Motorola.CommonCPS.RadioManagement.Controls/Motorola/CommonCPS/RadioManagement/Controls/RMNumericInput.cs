using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Controls.Editors;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200006A RID: 106
	public class RMNumericInput : global::Infragistics.Controls.Editors.XamNumericInput
	{
		// Token: 0x06000224 RID: 548 RVA: 0x00023CF4 File Offset: 0x00021EF4
		static RMNumericInput()
		{
			short num = (short)615432025;
			short num2 = num;
			num = (short)1198767961;
			switch (num2 == num)
			{
			}
			num = (short)994574337;
			if (num != 0)
			{
			}
			num = (short)1777205248;
			short num3 = num;
			num = (short)1518862336;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput)));
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00023DC0 File Offset: 0x00021FC0
		public RMNumericInput()
		{
			base.PreviewKeyDown += this.RMNumericInput_PreviewKeyDown;
			base.PreviewKeyUp += this.RMNumericInput_PreviewKeyUp;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00023DF8 File Offset: 0x00021FF8
		private void RMNumericInput_PreviewKeyUp(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)1488846848;
			short num2 = num;
			num = (short)1077215234;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					global::System.Windows.Data.BindingExpression bindingExpression;
					if (bindingExpression != null)
					{
						num = (short)456589315;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 1:
				{
					global::System.Windows.Data.BindingExpression bindingExpression = base.GetBindingExpression(global::Infragistics.Controls.Editors.ValueInput.ValueProperty);
					num = (short)1642463232;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 3:
				{
					num = (short)561914215;
					short num4 = num;
					num = (short)1528504679;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)551157761;
						if (num != 0)
						{
						}
						num = (short)1974992896;
						if (num != 0)
						{
						}
						break;
					}
					global::System.Windows.Data.BindingExpression bindingExpression;
					bindingExpression.UpdateSource();
					num = (short)1300496388;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				}
				IL_63:
				if (A_1.Key != global::System.Windows.Input.Key.Return)
				{
					break;
				}
				num = (short)1653604353;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00023F60 File Offset: 0x00022160
		private void RMNumericInput_PreviewKeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)1125842946;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_1.Key != global::System.Windows.Input.Key.X)
					{
						num = (short)162660362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C6;
				case 1:
					goto IL_1C6;
				case 2:
				{
					num = (short)483524608;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				}
				case 3:
					if (global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Control)
					{
						num = (short)1659240457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num = (short)1552482307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					if (A_1.Key != global::System.Windows.Input.Key.V)
					{
						num = (short)386400263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C6;
				case 7:
					num = (short)922746880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (A_1.Key == global::System.Windows.Input.Key.Z)
					{
						num = (short)1267335169;
						if (num != 0)
						{
						}
						num = (short)1837301761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					num = (short)1925644294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_EB;
				}
				IL_7A:
				num = (short)1606827178;
				short num4 = num;
				num = (short)700988586;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_EB:
					num = (short)1722679304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)2066022400;
					if (num != 0)
					{
					}
					if (base.IsReadOnly)
					{
						num = (short)2129657860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_1C6:
				A_1.Handled = true;
				num = (short)809893893;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
