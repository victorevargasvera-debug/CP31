using System;
using NLog.Internal;

namespace NLog.Common
{
	// Token: 0x0200018E RID: 398
	public static class ConversionHelpers
	{
		// Token: 0x060010E2 RID: 4322 RVA: 0x0002CE8D File Offset: 0x0002B08D
		public static bool TryParseEnum<TEnum>(string inputValue, out TEnum resultValue, TEnum defaultValue = default(TEnum)) where TEnum : struct
		{
			if (string.IsNullOrEmpty(inputValue))
			{
				resultValue = defaultValue;
				return true;
			}
			if (!global::NLog.Common.ConversionHelpers.TryParse<TEnum>(inputValue, true, out resultValue))
			{
				resultValue = defaultValue;
				return false;
			}
			return true;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0002CEB4 File Offset: 0x0002B0B4
		internal static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct
		{
			return global::NLog.Common.ConversionHelpers.TryParse<TEnum>(value, false, out result);
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0002CEBE File Offset: 0x0002B0BE
		internal static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct
		{
			return global::System.Enum.TryParse<TEnum>(value, ignoreCase, out result);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0002CEC8 File Offset: 0x0002B0C8
		private static bool TryParseEnum_net3<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct
		{
			global::System.Type typeFromHandle = typeof(TEnum);
			if (!typeFromHandle.IsEnum())
			{
				throw new global::System.ArgumentException(string.Format("Type '{0}' is not an enum", typeFromHandle.FullName));
			}
			if (global::NLog.Internal.StringHelpers.IsNullOrWhiteSpace(value))
			{
				result = default(TEnum);
				return false;
			}
			bool result2;
			try
			{
				result = (TEnum)((object)global::System.Enum.Parse(typeFromHandle, value, ignoreCase));
				result2 = true;
			}
			catch (global::System.Exception)
			{
				result = default(TEnum);
				result2 = false;
			}
			return result2;
		}
	}
}
