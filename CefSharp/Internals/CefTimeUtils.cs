using System;

namespace CefSharp.Internals
{
	// Token: 0x020000CC RID: 204
	public static class CefTimeUtils
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x00009C24 File Offset: 0x00007E24
		public static void UseBaseTimeConveter(global::CefSharp.Internals.IBaseTimeConverter converter)
		{
			if (converter == null)
			{
				throw new global::System.ArgumentNullException("converter");
			}
			global::CefSharp.Internals.CefTimeUtils.BaseTimeConverter = converter;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00009C3C File Offset: 0x00007E3C
		public static global::System.DateTime? FromBaseTimeToNullableDateTime(long val)
		{
			if (val == 0L)
			{
				return null;
			}
			return new global::System.DateTime?(global::CefSharp.Internals.CefTimeUtils.FromBaseTimeToDateTime(val));
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00009C61 File Offset: 0x00007E61
		public static global::System.DateTime FromBaseTimeToDateTime(long val)
		{
			return global::CefSharp.Internals.CefTimeUtils.BaseTimeConverter.FromBaseTimeToDateTime(val);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00009C6E File Offset: 0x00007E6E
		public static long FromDateTimeToBaseTime(global::System.DateTime dateTime)
		{
			return global::CefSharp.Internals.CefTimeUtils.BaseTimeConverter.FromDateTimeToBaseTime(dateTime);
		}

		// Token: 0x04000376 RID: 886
		private static global::CefSharp.Internals.IBaseTimeConverter BaseTimeConverter = new global::CefSharp.Internals.BaseTimeConverter();
	}
}
