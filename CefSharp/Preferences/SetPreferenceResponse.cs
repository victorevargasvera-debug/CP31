using System;

namespace CefSharp.Preferences
{
	// Token: 0x020000BA RID: 186
	public class SetPreferenceResponse
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00008CB0 File Offset: 0x00006EB0
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00008CB8 File Offset: 0x00006EB8
		public bool Success { get; private set; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00008CC1 File Offset: 0x00006EC1
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x00008CC9 File Offset: 0x00006EC9
		public string ErrorMessage { get; private set; }

		// Token: 0x060005A8 RID: 1448 RVA: 0x00008CD2 File Offset: 0x00006ED2
		public SetPreferenceResponse(bool success, string errorMessage)
		{
			this.Success = success;
			this.ErrorMessage = errorMessage;
		}
	}
}
