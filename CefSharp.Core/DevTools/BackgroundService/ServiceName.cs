using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.BackgroundService
{
	// Token: 0x02000342 RID: 834
	public enum ServiceName
	{
		// Token: 0x04000D12 RID: 3346
		[global::System.Runtime.Serialization.EnumMember(Value = "backgroundFetch")]
		BackgroundFetch,
		// Token: 0x04000D13 RID: 3347
		[global::System.Runtime.Serialization.EnumMember(Value = "backgroundSync")]
		BackgroundSync,
		// Token: 0x04000D14 RID: 3348
		[global::System.Runtime.Serialization.EnumMember(Value = "pushMessaging")]
		PushMessaging,
		// Token: 0x04000D15 RID: 3349
		[global::System.Runtime.Serialization.EnumMember(Value = "notifications")]
		Notifications,
		// Token: 0x04000D16 RID: 3350
		[global::System.Runtime.Serialization.EnumMember(Value = "paymentHandler")]
		PaymentHandler,
		// Token: 0x04000D17 RID: 3351
		[global::System.Runtime.Serialization.EnumMember(Value = "periodicBackgroundSync")]
		PeriodicBackgroundSync
	}
}
