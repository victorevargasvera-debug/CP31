using System;
using System.Reflection;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000014 RID: 20
	public static class ExtensionMethods
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00007E24 File Offset: 0x00006024
		public static object GetPcrDeviceCertificatePropertyValue(this global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo src, string propName)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::System.Reflection.PropertyInfo property;
			short num2;
			object result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (property.PropertyType == typeof(string))
					{
						num2 = (short)733609991;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14E;
				case 1:
					num2 = (short)1901395969;
					if (num2 != 0)
					{
					}
					if (property == null)
					{
						num2 = (short)1295515653;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D7;
				case 2:
					if (property != null)
					{
						num2 = (short)714932230;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14E;
				case 3:
					if ((result = property.GetValue(src, null)) == null)
					{
						num2 = (short)1547436036;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					goto IL_144;
				case 5:
					goto IL_1D2;
				case 6:
					for (;;)
					{
						num2 = (short)1348351158;
						short num3 = num2;
						num2 = (short)1019032758;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_AC;
						}
					}
					IL_AC:
					num2 = (short)194510848;
					if (num2 != 0)
					{
					}
					num2 = (short)558301184;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)860880899;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_14E:
				num2 = (short)503513088;
				short num4 = num2;
				num2 = (short)1123549185;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_144:
			result = string.Empty;
			return result;
			IL_1D2:
			return null;
			IL_1D7:
			return property.GetValue(src, null);
			IL_30:
			property = src.GetType().GetProperty(propName);
			num2 = (short)701300738;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
