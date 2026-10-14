using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000013 RID: 19
	internal interface INavigation
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006F RID: 111
		// (set) Token: 0x06000070 RID: 112
		global::System.Uri NavigationUri { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000071 RID: 113
		// (set) Token: 0x06000072 RID: 114
		string NavigationParameter { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000073 RID: 115
		// (set) Token: 0x06000074 RID: 116
		global::System.Windows.FrameworkElement NavigationElement { get; set; }

		// Token: 0x06000075 RID: 117
		void NavigateTo();
	}
}
