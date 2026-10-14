using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics
{
	// Token: 0x02000010 RID: 16
	internal interface IHeaderedItemContainerGenerator
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005B RID: 91
		global::System.Windows.Controls.Panel ItemsHost { get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005C RID: 92
		global::System.Windows.Controls.ScrollViewer ScrollHost { get; }

		// Token: 0x0600005D RID: 93
		void OnApplyTemplate();

		// Token: 0x0600005E RID: 94
		void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item, global::System.Windows.Style parentItemContainerStyle);

		// Token: 0x0600005F RID: 95
		void ScrollIntoView(global::System.Windows.FrameworkElement element);

		// Token: 0x06000060 RID: 96
		void UpdateItemContainerStyle(global::System.Windows.Style itemContainerStyle);

		// Token: 0x06000061 RID: 97
		void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item);
	}
}
