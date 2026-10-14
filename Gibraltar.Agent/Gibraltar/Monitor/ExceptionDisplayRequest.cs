using System;
using System.Threading;
using System.Windows.Forms;

namespace Gibraltar.Monitor
{
	// Token: 0x0200018E RID: 398
	internal class ExceptionDisplayRequest
	{
		// Token: 0x060010AB RID: 4267 RVA: 0x0002E570 File Offset: 0x0002C770
		public ExceptionDisplayRequest(global::System.Exception exception, bool threadBlocked, bool canContinue)
		{
			this.Timestamp = global::System.DateTimeOffset.Now;
			this.Exception = exception;
			this.ThreadBlocked = threadBlocked;
			this.CanContinue = canContinue;
			this.m_Result = global::System.Windows.Forms.DialogResult.None;
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x0002E5B0 File Offset: 0x0002C7B0
		// (set) Token: 0x060010AD RID: 4269 RVA: 0x0002E5B8 File Offset: 0x0002C7B8
		public global::System.DateTimeOffset Timestamp { get; private set; }

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x0002E5C4 File Offset: 0x0002C7C4
		// (set) Token: 0x060010AF RID: 4271 RVA: 0x0002E5CC File Offset: 0x0002C7CC
		public global::System.Exception Exception { get; private set; }

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x0002E5D8 File Offset: 0x0002C7D8
		// (set) Token: 0x060010B1 RID: 4273 RVA: 0x0002E5E0 File Offset: 0x0002C7E0
		public bool ThreadBlocked { get; private set; }

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0002E5EC File Offset: 0x0002C7EC
		// (set) Token: 0x060010B3 RID: 4275 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		public bool CanContinue { get; private set; }

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0002E600 File Offset: 0x0002C800
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x0002E63C File Offset: 0x0002C83C
		public global::System.Windows.Forms.DialogResult Result
		{
			get
			{
				global::System.Windows.Forms.DialogResult result;
				lock (this)
				{
					result = this.m_Result;
				}
				return result;
			}
			set
			{
				lock (this)
				{
					this.m_Result = value;
					global::System.Threading.Monitor.PulseAll(this);
				}
			}
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0002E67C File Offset: 0x0002C87C
		public global::System.Windows.Forms.DialogResult WaitForResult()
		{
			global::System.Windows.Forms.DialogResult result;
			lock (this)
			{
				while (this.Result == global::System.Windows.Forms.DialogResult.None)
				{
					global::System.Threading.Monitor.Wait(this);
				}
				result = this.Result;
			}
			return result;
		}

		// Token: 0x04000594 RID: 1428
		private global::System.Windows.Forms.DialogResult m_Result;
	}
}
