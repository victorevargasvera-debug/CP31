using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Log
{
	// Token: 0x02000250 RID: 592
	public enum ViolationSettingName
	{
		// Token: 0x040009E6 RID: 2534
		[global::System.Runtime.Serialization.EnumMember(Value = "longTask")]
		LongTask,
		// Token: 0x040009E7 RID: 2535
		[global::System.Runtime.Serialization.EnumMember(Value = "longLayout")]
		LongLayout,
		// Token: 0x040009E8 RID: 2536
		[global::System.Runtime.Serialization.EnumMember(Value = "blockedEvent")]
		BlockedEvent,
		// Token: 0x040009E9 RID: 2537
		[global::System.Runtime.Serialization.EnumMember(Value = "blockedParser")]
		BlockedParser,
		// Token: 0x040009EA RID: 2538
		[global::System.Runtime.Serialization.EnumMember(Value = "discouragedAPIUse")]
		DiscouragedAPIUse,
		// Token: 0x040009EB RID: 2539
		[global::System.Runtime.Serialization.EnumMember(Value = "handler")]
		Handler,
		// Token: 0x040009EC RID: 2540
		[global::System.Runtime.Serialization.EnumMember(Value = "recurringHandler")]
		RecurringHandler
	}
}
