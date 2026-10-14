using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000082 RID: 130
	internal interface IApplicationUser
	{
		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000609 RID: 1545
		string Key { get; }

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600060A RID: 1546
		string FullyQualifiedUserName { get; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600060B RID: 1547
		string Caption { get; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600060C RID: 1548
		string EmailAddress { get; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600060D RID: 1549
		string Phone { get; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600060E RID: 1550
		string Organization { get; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600060F RID: 1551
		string Title { get; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000610 RID: 1552
		string TimeZoneCode { get; }
	}
}
