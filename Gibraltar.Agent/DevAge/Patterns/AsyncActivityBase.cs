using System;

namespace DevAge.Patterns
{
	// Token: 0x020002A7 RID: 679
	internal abstract class AsyncActivityBase : global::DevAge.Patterns.ActivityBase
	{
		// Token: 0x060021DC RID: 8668 RVA: 0x000781C4 File Offset: 0x000763C4
		protected override void ResetRunningStatus()
		{
			base.ResetRunningStatus();
			this.mAsyncResult = null;
		}

		// Token: 0x060021DD RID: 8669
		protected abstract void OnBeginWork(global::System.AsyncCallback callback);

		// Token: 0x060021DE RID: 8670
		protected abstract void OnEndWork(global::System.IAsyncResult asyncResult);

		// Token: 0x060021DF RID: 8671 RVA: 0x000781D4 File Offset: 0x000763D4
		private void CurrentAsyncCallback(global::System.IAsyncResult asyncResult)
		{
			this.mAsyncResult = asyncResult;
			if (this.mAsyncResult == null)
			{
				throw new global::DevAge.DevAgeApplicationException("Invalid async activity, IAsyncResult is null");
			}
			base.DoWork();
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000781FC File Offset: 0x000763FC
		protected override void OnWork()
		{
			this.OnEndWork(this.mAsyncResult);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0007820C File Offset: 0x0007640C
		protected override void StartActivity()
		{
			this.OnBeginWork(new global::System.AsyncCallback(this.CurrentAsyncCallback));
		}

		// Token: 0x04000C53 RID: 3155
		private global::System.IAsyncResult mAsyncResult;
	}
}
