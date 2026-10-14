using System;
using System.ComponentModel;

namespace Ionic
{
	// Token: 0x02000423 RID: 1059
	internal sealed class EnumUtil
	{
		// Token: 0x06002DDE RID: 11742 RVA: 0x0009B0B4 File Offset: 0x000992B4
		private EnumUtil()
		{
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x0009B0BC File Offset: 0x000992BC
		internal static string GetDescription(global::System.Enum value)
		{
			global::System.ComponentModel.DescriptionAttribute[] array = (global::System.ComponentModel.DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(global::System.ComponentModel.DescriptionAttribute), false);
			if (array.Length != 0)
			{
				return array[0].Description;
			}
			return value.ToString();
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x0009B110 File Offset: 0x00099310
		internal static object Parse(global::System.Type enumType, string stringRepresentation)
		{
			return global::Ionic.EnumUtil.Parse(enumType, stringRepresentation, false);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x0009B11C File Offset: 0x0009931C
		internal static object Parse(global::System.Type enumType, string stringRepresentation, bool ignoreCase)
		{
			if (ignoreCase)
			{
				stringRepresentation = stringRepresentation.ToLower();
			}
			foreach (object obj in global::System.Enum.GetValues(enumType))
			{
				global::System.Enum @enum = (global::System.Enum)obj;
				string text = global::Ionic.EnumUtil.GetDescription(@enum);
				if (ignoreCase)
				{
					text = text.ToLower();
				}
				if (text == stringRepresentation)
				{
					return @enum;
				}
			}
			return global::System.Enum.Parse(enumType, stringRepresentation, ignoreCase);
		}
	}
}
