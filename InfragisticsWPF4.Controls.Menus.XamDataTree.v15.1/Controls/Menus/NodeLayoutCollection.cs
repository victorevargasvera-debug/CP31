using System;
using System.ComponentModel;
using Infragistics.Collections;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000026 RID: 38
	public class NodeLayoutCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Menus.NodeLayout>
	{
		// Token: 0x17000067 RID: 103
		public global::Infragistics.Controls.Menus.NodeLayout this[string key]
		{
			get
			{
				foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout in this.Items)
				{
					if (nodeLayout.Key == key)
					{
						return nodeLayout;
					}
				}
				return null;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00007024 File Offset: 0x00005224
		protected override void AddItemSilently(int index, global::Infragistics.Controls.Menus.NodeLayout item)
		{
			if (item != null)
			{
				if (this[item.Key] == null)
				{
					base.AddItemSilently(index, item);
					return;
				}
				bool flag = false;
				if (item != null)
				{
					flag = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(item);
				}
				if (!flag)
				{
					throw new global::System.Exception(global::Infragistics.SRDataTree.GetString("DuplicateKeyException"));
				}
			}
		}
	}
}
