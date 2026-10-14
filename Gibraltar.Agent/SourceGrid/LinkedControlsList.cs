using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SourceGrid
{
	// Token: 0x020003CE RID: 974
	internal class LinkedControlsList : global::System.Collections.Generic.IEnumerable<global::SourceGrid.LinkedControlValue>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002C3C RID: 11324 RVA: 0x00094A74 File Offset: 0x00092C74
		public LinkedControlsList(global::System.Windows.Forms.Control parent)
		{
			this.mParent = parent;
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00094A90 File Offset: 0x00092C90
		public void Add(global::SourceGrid.LinkedControlValue linkedControl)
		{
			this.mList.Add(linkedControl);
			this.mParent.Controls.Add(linkedControl.Control);
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x00094AC4 File Offset: 0x00092CC4
		public void Remove(global::SourceGrid.LinkedControlValue linkedControl)
		{
			this.mList.Remove(linkedControl);
			this.mParent.Controls.Remove(linkedControl.Control);
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00094AF8 File Offset: 0x00092CF8
		public global::SourceGrid.LinkedControlValue GetByControl(global::System.Windows.Forms.Control control)
		{
			for (int i = 0; i < this.mList.Count; i++)
			{
				if (control == this.mList[i].Control)
				{
					return this.mList[i];
				}
			}
			return null;
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x00094B48 File Offset: 0x00092D48
		public global::System.Collections.Generic.IEnumerator<global::SourceGrid.LinkedControlValue> GetEnumerator()
		{
			return this.mList.GetEnumerator();
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x00094B5C File Offset: 0x00092D5C
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.mList.GetEnumerator();
		}

		// Token: 0x04000EB3 RID: 3763
		private global::System.Windows.Forms.Control mParent;

		// Token: 0x04000EB4 RID: 3764
		private global::System.Collections.Generic.List<global::SourceGrid.LinkedControlValue> mList = new global::System.Collections.Generic.List<global::SourceGrid.LinkedControlValue>();
	}
}
