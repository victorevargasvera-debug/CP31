using System;
using System.ComponentModel;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000125 RID: 293
	internal class HubConnectionCanConnectEventArgs : global::System.ComponentModel.AsyncCompletedEventArgs
	{
		// Token: 0x06000C0E RID: 3086 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		internal HubConnectionCanConnectEventArgs(global::System.Exception error, bool cancelled, global::Gibraltar.Server.Client.HubStatus? status, string message, bool isValid) : base(error, cancelled, null)
		{
			this.Status = status;
			this.Message = message;
			this.IsValid = isValid;
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x0001F700 File Offset: 0x0001D900
		public global::Gibraltar.Server.Client.HubStatus? Status { get; private set; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0001F70C File Offset: 0x0001D90C
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x0001F714 File Offset: 0x0001D914
		public string Message { get; private set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x0001F720 File Offset: 0x0001D920
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x0001F728 File Offset: 0x0001D928
		public bool IsValid { get; private set; }
	}
}
