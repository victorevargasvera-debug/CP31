using System;
using System.Threading;

namespace DevAge.Patterns
{
	// Token: 0x020002A2 RID: 674
	internal interface IActivity
	{
		// Token: 0x060021B2 RID: 8626
		void Start(global::DevAge.Patterns.IActivityEvents events);

		// Token: 0x060021B3 RID: 8627
		void Cancel();

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060021B4 RID: 8628
		global::DevAge.Patterns.ActivityCollection SubActivities { get; }

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060021B5 RID: 8629
		global::DevAge.Patterns.ActivityStatus Status { get; }

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060021B6 RID: 8630
		string Name { get; }

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060021B7 RID: 8631
		global::System.Threading.WaitHandle WaitHandle { get; }

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060021B8 RID: 8632
		global::System.Exception Exception { get; }

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060021B9 RID: 8633
		// (set) Token: 0x060021BA RID: 8634
		global::DevAge.Patterns.IActivity Parent { get; set; }

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060021BB RID: 8635
		string FullName { get; }
	}
}
