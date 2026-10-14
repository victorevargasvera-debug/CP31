using System;
using System.Globalization;
using System.Text;
using System.Windows;
using Infragistics.Controls.Editors;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000063 RID: 99
	public class RMIPAddressInput : global::Infragistics.Controls.Editors.XamMaskedInput
	{
		// Token: 0x0600020F RID: 527 RVA: 0x000228A8 File Offset: 0x00020AA8
		static RMIPAddressInput()
		{
			short num = (short)2037664155;
			short num2 = num;
			num = (short)597772699;
			switch (num2 == num)
			{
			}
			num = (short)301137921;
			if (num != 0)
			{
			}
			num = (short)303562752;
			if (num != 0)
			{
			}
			num = (short)937492480;
			short num3 = num;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMIPAddressInput)));
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00022974 File Offset: 0x00020B74
		public RMIPAddressInput()
		{
			base.ValueChanged += this.RMIPAddressInput_ValueChanged;
			this._sb = new global::System.Text.StringBuilder(16, 16);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000229A8 File Offset: 0x00020BA8
		private void RMIPAddressInput_ValueChanged(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 3;
			short num = (short)1147011072;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				global::Infragistics.Controls.Editors.XamMaskedInput xamMaskedInput;
				for (;;)
				{
					IL_30:
					int num3;
					string text3;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)990707721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						string[] array;
						if (num3 >= array.Length)
						{
							num = (short)41353223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = array[num3];
						num = (short)1189937169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)1754267649;
						if (num != 0)
						{
						}
						this._sb.Clear();
						string text2 = xamMaskedInput.Text;
						text3 = text2;
						num = (short)1686110212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						string text2;
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)949157889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C;
					}
					case 5:
						goto IL_282;
					case 6:
					{
						string[] array2;
						string[] array = array2;
						num3 = 0;
						num = (short)428998671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_1BA;
					case 8:
					{
						string[] array2;
						if (array2 != null)
						{
							num = (short)482410502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BA;
					}
					case 9:
					{
						string text2;
						if (text2.Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("떚", a_)))
						{
							num = (short)1449852944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C;
					}
					case 10:
					{
						string text;
						int num4 = int.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture);
						this._sb.Append(num4.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
						this._sb.Append(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("떚", a_));
						num = (short)888930316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_EC;
					case 12:
						goto IL_EC;
					case 13:
						if (xamMaskedInput.Value != null)
						{
							num = (short)1138819072;
							short num5 = num;
							num = (short)556269571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						goto IL_30C;
					case 15:
						goto IL_282;
					case 16:
					{
						string text2;
						string[] array2 = text2.Split(new char[]
						{
							'.'
						});
						num = (short)46858248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1558315018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this._sb.Append(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("떚", a_));
						num = (short)211025931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7F;
					IL_EC:
					num3++;
					num = (short)1222311941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BA:
					string text4 = this._sb.ToString();
					this._sb.Clear();
					int startIndex = text4.LastIndexOf('.');
					text3 = text4.Remove(startIndex);
					num = (short)1486749710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_282:
					num = (short)1884188522;
					short num6 = num;
					num = (short)1559064426;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)293601280;
						if (num != 0)
						{
						}
						num = (short)1862074370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_30C:
					xamMaskedInput.Text = text3;
					num = (short)327876608;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7F:
				xamMaskedInput = (A_0 as global::Infragistics.Controls.Editors.XamMaskedInput);
				num = (short)1371734029;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x04000094 RID: 148
		private readonly global::System.Text.StringBuilder _sb;
	}
}
