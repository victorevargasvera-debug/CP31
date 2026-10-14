using System;
using System.ComponentModel;

namespace Gibraltar
{
	// Token: 0x0200015D RID: 349
	[global::System.Serializable]
	internal class BindingListEx<T> : global::System.ComponentModel.BindingList<T>
	{
		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06000E9A RID: 3738 RVA: 0x00025430 File Offset: 0x00023630
		// (remove) Token: 0x06000E9B RID: 3739 RVA: 0x0002546C File Offset: 0x0002366C
		public event global::System.EventHandler BeginUpdate;

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06000E9C RID: 3740 RVA: 0x000254A8 File Offset: 0x000236A8
		// (remove) Token: 0x06000E9D RID: 3741 RVA: 0x000254E4 File Offset: 0x000236E4
		public event global::System.EventHandler EndUpdate;

		// Token: 0x06000E9E RID: 3742 RVA: 0x00025520 File Offset: 0x00023720
		internal void SynchornizationStart()
		{
			this.OnBeginUpdate(new global::System.EventArgs());
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00025530 File Offset: 0x00023730
		internal void SynchronizationEnd()
		{
			this.OnEndUpdate(new global::System.EventArgs());
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00025540 File Offset: 0x00023740
		protected virtual void OnBeginUpdate(global::System.EventArgs e)
		{
			global::System.EventHandler beginUpdate = this.BeginUpdate;
			if (beginUpdate != null)
			{
				beginUpdate(this, e);
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00025568 File Offset: 0x00023768
		protected virtual void OnEndUpdate(global::System.EventArgs e)
		{
			global::System.EventHandler endUpdate = this.EndUpdate;
			if (endUpdate != null)
			{
				endUpdate(this, e);
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00025590 File Offset: 0x00023790
		protected override void RemoveItem(int index)
		{
			global::Gibraltar.ListChangedEventArgsItemDeleted<T> e = new global::Gibraltar.ListChangedEventArgsItemDeleted<T>(base[index], index);
			this.OnListChanged(e);
			base.RemoveItem(index);
		}
	}
}
