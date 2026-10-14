using System;
using System.ComponentModel;

namespace Microsoft.Expression.Interactivity
{
	// Token: 0x0200002E RID: 46
	internal static class TypeConverterHelper
	{
		// Token: 0x060001BB RID: 443 RVA: 0x000099A8 File Offset: 0x00007BA8
		internal static object DoConversionFrom(global::System.ComponentModel.TypeConverter converter, object value)
		{
			object result = value;
			try
			{
				if (converter != null && value != null && converter.CanConvertFrom(value.GetType()))
				{
					result = converter.ConvertFrom(value);
				}
			}
			catch (global::System.Exception e)
			{
				if (!global::Microsoft.Expression.Interactivity.TypeConverterHelper.ShouldEatException(e))
				{
					throw;
				}
			}
			return result;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000099F4 File Offset: 0x00007BF4
		private static bool ShouldEatException(global::System.Exception e)
		{
			bool flag = false;
			if (e.InnerException != null)
			{
				flag |= global::Microsoft.Expression.Interactivity.TypeConverterHelper.ShouldEatException(e.InnerException);
			}
			return flag | e is global::System.FormatException;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00009A26 File Offset: 0x00007C26
		internal static global::System.ComponentModel.TypeConverter GetTypeConverter(global::System.Type type)
		{
			return global::System.ComponentModel.TypeDescriptor.GetConverter(type);
		}
	}
}
