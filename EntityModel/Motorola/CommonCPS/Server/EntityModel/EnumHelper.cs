using System;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200010C RID: 268
	public static class EnumHelper
	{
		// Token: 0x06000FC6 RID: 4038 RVA: 0x000A8CF4 File Offset: 0x000A6EF4
		public static T GetAttributeOfType<T>(this global::System.Enum enumVal) where T : global::System.Attribute
		{
			short num = (short)134228157;
			short num2 = num;
			num = (short)619129021;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)843579392;
				if (num != 0)
				{
				}
				num = (short)964755456;
				short num3 = num;
				object[] customAttributes = enumVal.GetType().GetMember(enumVal.ToString())[0].GetCustomAttributes(typeof(T), false);
				if (customAttributes.Length != 0)
				{
					return (T)((object)customAttributes[0]);
				}
				break;
			}
			}
			num = (short)827916289;
			if (num != 0)
			{
			}
			return default(T);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000A8DDC File Offset: 0x000A6FDC
		public static bool IsPCRFamily(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily family)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute attributeOfType;
			short num2;
			for (;;)
			{
				IL_0A:
				global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pacType;
				switch (num)
				{
				case 0:
					if (attributeOfType != null)
					{
						num2 = (short)1866268673;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_126;
				case 1:
					pacType = attributeOfType.PacType;
					num2 = (short)987037698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_F5;
				case 3:
				{
					num2 = (short)1925281106;
					short num3 = num2;
					num2 = (short)1684567378;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F5;
					default:
						goto IL_BC;
					}
					break;
				}
				}
				goto IL_20;
				IL_F5:
				if (!pacType.Equals(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR))
				{
					goto IL_126;
				}
				num2 = (short)1114115;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BC:
			num2 = (short)850591744;
			if (num2 != 0)
			{
			}
			return true;
			IL_126:
			num2 = (short)831520769;
			if (num2 != 0)
			{
			}
			return false;
			IL_20:
			attributeOfType = family.GetAttributeOfType<global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute>();
			num2 = (short)1075773440;
			short num4 = num2;
			num2 = (short)8847360;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
