using System;

namespace DevAge.Patterns
{
	// Token: 0x020002A8 RID: 680
	internal class AsynchronousActivity : global::DevAge.Patterns.AsyncActivityBase
	{
		// Token: 0x060021E3 RID: 8675 RVA: 0x00078228 File Offset: 0x00076428
		public AsynchronousActivity()
		{
			this.asyncDelegate = new global::DevAge.Patterns.AsynchronousActivity.EmptyDelegate(this.OnAsyncWork);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00078244 File Offset: 0x00076444
		protected override void OnBeginWork(global::System.AsyncCallback callback)
		{
			this.asyncDelegate.BeginInvoke(callback, new object());
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00078258 File Offset: 0x00076458
		protected virtual void OnAsyncWork()
		{
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x0007825C File Offset: 0x0007645C
		protected override void OnEndWork(global::System.IAsyncResult asyncResult)
		{
			this.asyncDelegate.EndInvoke(asyncResult);
		}

		// Token: 0x04000C54 RID: 3156
		private global::DevAge.Patterns.AsynchronousActivity.EmptyDelegate asyncDelegate;

		// Token: 0x020004C0 RID: 1216
		// (Invoke) Token: 0x060033FF RID: 13311
		private delegate void EmptyDelegate();
	}
}
