using System;

namespace CefSharp
{
	// Token: 0x02000077 RID: 119
	public interface IPopupFeatures
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002E8 RID: 744
		int? X { get; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002E9 RID: 745
		int? Y { get; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002EA RID: 746
		int? Width { get; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002EB RID: 747
		int? Height { get; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002EC RID: 748
		bool IsPopup { get; }
	}
}
