using System;
using System.Globalization;
using System.Windows.Controls;
using CommonResources;

namespace SpecialFeatures.POP25BatchProgrammer
{
	// Token: 0x020000A1 RID: 161
	public class DataGridRadioIPValidation : global::System.Windows.Controls.ValidationRule
	{
		// Token: 0x06000B2B RID: 2859 RVA: 0x000D5778 File Offset: 0x000D3978
		public override global::System.Windows.Controls.ValidationResult Validate(object value, global::System.Globalization.CultureInfo cultureInfo)
		{
			short num = (short)338362368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				string text;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)584777733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_16A;
					case 2:
						goto IL_E5;
					case 3:
						goto IL_1DE;
					case 4:
						goto IL_A1;
					case 5:
					{
						int num3;
						if (num3 > 255)
						{
							num = (short)1894383618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						num4++;
						num = (short)1111031820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)221315073;
						if (num != 0)
						{
						}
						int num3;
						if (num3 < 0)
						{
							goto IL_19B;
						}
						num = (short)668898234;
						short num5 = num;
						num = (short)1537053626;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18F;
						default:
							num = (short)1446838272;
							if (num != 0)
							{
							}
							num = (short)470417408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_1A7;
					case 8:
					{
						if (string.IsNullOrEmpty(text))
						{
							num = (short)246153220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array = text.Split(new char[]
						{
							'.'
						});
						num = (short)971636746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						int num3;
						int num4;
						string[] array2;
						if (!int.TryParse(array2[num4], global::System.Globalization.NumberStyles.Integer, cultureInfo.NumberFormat, out num3))
						{
							num = (short)1121845261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1127415814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						string[] array;
						if (array.Length != 4)
						{
							num = (short)700579840;
							short num6 = num;
							num = (short)1222246401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array2 = array;
						int num4 = 0;
						num = (short)1291583495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int num4;
						string[] array2;
						if (num4 >= array2.Length)
						{
							num = (short)844955651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2120876041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_1A7;
					case 13:
						goto IL_226;
					}
					goto IL_67;
					IL_1A7:
					num = (short)953221131;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A1:
				goto IL_18F;
				IL_E5:
				goto IL_19B;
				IL_16A:
				return new global::System.Windows.Controls.ValidationResult(false, global::CommonResources.AppResources.Please_Enter_A_Valid_IP_Address);
				IL_18F:
				return new global::System.Windows.Controls.ValidationResult(false, global::CommonResources.AppResources.Please_Enter_A_Valid_IP_Address);
				IL_19B:
				return new global::System.Windows.Controls.ValidationResult(false, global::CommonResources.AppResources.Please_Enter_A_Valid_IP_Address);
				IL_1DE:
				return new global::System.Windows.Controls.ValidationResult(true, null);
				IL_226:
				return new global::System.Windows.Controls.ValidationResult(false, global::CommonResources.AppResources.Please_Enter_A_Valid_IP_Address);
				IL_67:
				text = (value as string);
				num = (short)1877278728;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
