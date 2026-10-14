using System;
using System.Threading;
using System.Windows.Threading;

namespace Infragistics
{
	// Token: 0x02000037 RID: 55
	internal class DeferredOperation
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0000A957 File Offset: 0x00008B57
		internal DeferredOperation(global::System.Action deferredAction)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(deferredAction);
			this._deferredAction = deferredAction;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000A96C File Offset: 0x00008B6C
		internal bool IsOperationPending
		{
			get
			{
				return this._pendingContext != null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000A97A File Offset: 0x00008B7A
		internal bool IsPerformingAction
		{
			get
			{
				return this._isPerformingAction;
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000A984 File Offset: 0x00008B84
		internal void InvokePendingOperation()
		{
			if (this._pendingContext == null)
			{
				return;
			}
			this._pendingContext = null;
			bool isPerformingAction = this._isPerformingAction;
			this._isPerformingAction = true;
			try
			{
				this._deferredAction();
			}
			finally
			{
				this._isPerformingAction = isPerformingAction;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		internal void CancelPendingOperation()
		{
			this._pendingContext = null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000A9DD File Offset: 0x00008BDD
		internal void StartAsyncOperation()
		{
			if (this._pendingContext != null)
			{
				return;
			}
			this._pendingContext = new global::System.Windows.Threading.DispatcherSynchronizationContext();
			this._pendingContext.Post(new global::System.Threading.SendOrPostCallback(this.OnAsyncCallback), this._pendingContext);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000AA10 File Offset: 0x00008C10
		private void OnAsyncCallback(object state)
		{
			if (state != this._pendingContext)
			{
				return;
			}
			this.InvokePendingOperation();
		}

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Threading.DispatcherSynchronizationContext _pendingContext;

		// Token: 0x040000BC RID: 188
		private global::System.Action _deferredAction;

		// Token: 0x040000BD RID: 189
		private bool _isPerformingAction;
	}
}
