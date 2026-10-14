using System;
using System.ComponentModel;

namespace Gibraltar
{
	// Token: 0x020000BF RID: 191
	internal class SyncBindingList<T> : global::System.ComponentModel.BindingList<T>
	{
		// Token: 0x06000808 RID: 2056 RVA: 0x00010DB0 File Offset: 0x0000EFB0
		public SyncBindingList() : this(null)
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00010DBC File Offset: 0x0000EFBC
		public SyncBindingList(global::System.ComponentModel.ISynchronizeInvoke syncObject)
		{
			this.m_SyncObject = syncObject;
			this.m_FireEventAction = new global::System.Action<global::System.ComponentModel.ListChangedEventArgs>(this.FireEvent);
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00010DE0 File Offset: 0x0000EFE0
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		public global::System.ComponentModel.ISynchronizeInvoke SyncObject
		{
			get
			{
				return this.m_SyncObject;
			}
			set
			{
				this.m_SyncObject = value;
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00010DF4 File Offset: 0x0000EFF4
		protected override void OnListChanged(global::System.ComponentModel.ListChangedEventArgs e)
		{
			if (this.m_SyncObject == null || !this.m_SyncObject.InvokeRequired)
			{
				this.FireEvent(e);
				return;
			}
			this.m_SyncObject.BeginInvoke(this.m_FireEventAction, new object[]
			{
				e
			});
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00010E44 File Offset: 0x0000F044
		private void FireEvent(global::System.ComponentModel.ListChangedEventArgs args)
		{
			base.OnListChanged(args);
		}

		// Token: 0x040001AE RID: 430
		private readonly global::System.Action<global::System.ComponentModel.ListChangedEventArgs> m_FireEventAction;

		// Token: 0x040001AF RID: 431
		private global::System.ComponentModel.ISynchronizeInvoke m_SyncObject;
	}
}
