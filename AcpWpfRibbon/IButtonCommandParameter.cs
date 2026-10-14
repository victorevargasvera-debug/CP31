using System;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000012 RID: 18
	public interface IButtonCommandParameter
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000201 RID: 513
		// (set) Token: 0x06000202 RID: 514
		bool IsChecked { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000203 RID: 515
		// (set) Token: 0x06000204 RID: 516
		object Tag { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000205 RID: 517
		// (set) Token: 0x06000206 RID: 518
		bool ValueChanged { get; set; }
	}
}
