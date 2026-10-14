using System;

namespace CefSharp.Internals
{
	// Token: 0x020000D4 RID: 212
	public interface IBaseTimeConverter
	{
		// Token: 0x06000638 RID: 1592
		global::System.DateTime FromBaseTimeToDateTime(long val);

		// Token: 0x06000639 RID: 1593
		long FromDateTimeToBaseTime(global::System.DateTime dateTime);
	}
}
