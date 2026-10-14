using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000065 RID: 101
	internal class PaneItemDescriptionList : global::System.Collections.ObjectModel.ObservableCollection<global::DevComponents.WpfRibbon.PaneItemDescription>
	{
		// Token: 0x060004A3 RID: 1187 RVA: 0x00065948 File Offset: 0x00063B48
		public PaneItemDescriptionList(global::DevComponents.WpfRibbon.NavigationPane np)
		{
			foreach (object obj in ((global::System.Collections.IEnumerable)np.Items))
			{
				global::DevComponents.WpfRibbon.PaneItem paneItem = obj as global::DevComponents.WpfRibbon.PaneItem;
				if (paneItem != null)
				{
					base.Add(new global::DevComponents.WpfRibbon.PaneItemDescription(paneItem));
				}
			}
		}
	}
}
