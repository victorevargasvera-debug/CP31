using System;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using CommonResources;
using SpecialFeatures.Comms;

namespace SpecialFeatures.CBISerialNum
{
	// Token: 0x020001B2 RID: 434
	public class SerialNumberRule : global::System.Windows.Controls.ValidationRule
	{
		// Token: 0x06001476 RID: 5238 RVA: 0x001D6E80 File Offset: 0x001D5080
		public override global::System.Windows.Controls.ValidationResult Validate(object value, global::System.Globalization.CultureInfo cultureInfo)
		{
			short num = (short)257294339;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					string s = (string)value;
					num = (short)386924546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_125;
				case 2:
				{
					string s;
					if (!global::SpecialFeatures.Comms.SerialNumberValidator.ValidateSerialNumber(global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(s))))
					{
						goto IL_78;
					}
					num = (short)751130698;
					short num3 = num;
					num = (short)96950346;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1758003200;
						if (num != 0)
						{
						}
						num = (short)1177092097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				num = (short)616169472;
				short num4 = num;
				if (value == null)
				{
					goto IL_12A;
				}
				num = (short)681312256;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_78:
			return new global::System.Windows.Controls.ValidationResult(false, global::CommonResources.AppResources.Enter_Valid_Serial_Number);
			IL_125:
			return new global::System.Windows.Controls.ValidationResult(true, null);
			IL_12A:
			num = (short)263847937;
			if (num != 0)
			{
			}
			return new global::System.Windows.Controls.ValidationResult(false, global::CommonResources.AppResources.Enter_Valid_Serial_Number);
		}
	}
}
