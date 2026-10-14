using System;
using System.Collections.Generic;

namespace CefSharp.Internals
{
	// Token: 0x020000E5 RID: 229
	public sealed class MethodInvocation
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0000B409 File Offset: 0x00009609
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x0000B411 File Offset: 0x00009611
		public int BrowserId { get; private set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0000B41A File Offset: 0x0000961A
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0000B422 File Offset: 0x00009622
		public long FrameId { get; private set; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0000B42B File Offset: 0x0000962B
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x0000B433 File Offset: 0x00009633
		public long? CallbackId { get; private set; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0000B43C File Offset: 0x0000963C
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x0000B444 File Offset: 0x00009644
		public long ObjectId { get; private set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0000B44D File Offset: 0x0000964D
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0000B455 File Offset: 0x00009655
		public string MethodName { get; private set; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0000B45E File Offset: 0x0000965E
		public global::System.Collections.Generic.List<object> Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0000B466 File Offset: 0x00009666
		public MethodInvocation(int browserId, long frameId, long objectId, string methodName, long? callbackId)
		{
			this.BrowserId = browserId;
			this.FrameId = frameId;
			this.CallbackId = callbackId;
			this.ObjectId = objectId;
			this.MethodName = methodName;
		}

		// Token: 0x040003AC RID: 940
		private readonly global::System.Collections.Generic.List<object> parameters = new global::System.Collections.Generic.List<object>();
	}
}
