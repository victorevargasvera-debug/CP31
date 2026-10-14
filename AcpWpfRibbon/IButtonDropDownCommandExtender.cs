using System;
using System.Windows.Media;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000019 RID: 25
	public interface IButtonDropDownCommandExtender
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600022D RID: 557
		// (set) Token: 0x0600022E RID: 558
		global::System.Windows.Media.ImageSource ImageSource { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600022F RID: 559
		// (set) Token: 0x06000230 RID: 560
		global::System.Windows.Media.ImageSource ImageSmallSource { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000231 RID: 561
		// (set) Token: 0x06000232 RID: 562
		string Header { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000233 RID: 563
		// (set) Token: 0x06000234 RID: 564
		bool SyncHeader { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000235 RID: 565
		// (set) Token: 0x06000236 RID: 566
		bool SyncImageSource { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000237 RID: 567
		// (set) Token: 0x06000238 RID: 568
		bool SyncImageSmallSource { get; set; }
	}
}
