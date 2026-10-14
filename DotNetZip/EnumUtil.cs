using System;
using System.ComponentModel;

namespace Ionic
{
	// Token: 0x0200000D RID: 13
	internal sealed class EnumUtil
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002063 File Offset: 0x00000263
		private EnumUtil()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000039C4 File Offset: 0x00001BC4
		internal static string GetDescription(global::System.Enum value)
		{
			global::System.ComponentModel.DescriptionAttribute[] array = (global::System.ComponentModel.DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(global::System.ComponentModel.DescriptionAttribute), false);
			if (array.Length != 0)
			{
				return array[0].Description;
			}
			return value.ToString();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003A0B File Offset: 0x00001C0B
		internal static object Parse(global::System.Type enumType, string stringRepresentation)
		{
			return global::Ionic.EnumUtil.Parse(enumType, stringRepresentation, false);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003A18 File Offset: 0x00001C18
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
