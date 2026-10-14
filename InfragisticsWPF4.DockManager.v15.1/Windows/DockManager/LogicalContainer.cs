using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200002D RID: 45
	internal class LogicalContainer : global::System.Windows.FrameworkElement
	{
		// Token: 0x0600027A RID: 634 RVA: 0x0000D16F File Offset: 0x0000B36F
		internal LogicalContainer()
		{
			this._children = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000D182 File Offset: 0x0000B382
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return this._children.GetEnumerator();
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000D18F File Offset: 0x0000B38F
		internal void AddLogicalChildInternal(object child)
		{
			if (child != null)
			{
				this._children.Add(child);
				base.AddLogicalChild(child);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000D1A7 File Offset: 0x0000B3A7
		internal void RemoveLogicalChildInternal(object child)
		{
			if (child != null)
			{
				this._children.Remove(child);
				base.RemoveLogicalChild(child);
			}
		}

		// Token: 0x04000163 RID: 355
		private global::System.Collections.Generic.IList<object> _children;
	}
}
