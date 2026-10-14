using System;

namespace CefSharp
{
	// Token: 0x020000A5 RID: 165
	public class WaitForSelectorAsyncResponse
	{
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00006EE4 File Offset: 0x000050E4
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00006EEC File Offset: 0x000050EC
		public string ElementId { get; private set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00006EF5 File Offset: 0x000050F5
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00006EFD File Offset: 0x000050FD
		public string TagName { get; private set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00006F06 File Offset: 0x00005106
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00006F0E File Offset: 0x0000510E
		public bool Success { get; private set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00006F17 File Offset: 0x00005117
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00006F1F File Offset: 0x0000511F
		public string ErrorMessage { get; private set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00006F28 File Offset: 0x00005128
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00006F30 File Offset: 0x00005130
		public bool ElementAdded { get; private set; }

		// Token: 0x060004B4 RID: 1204 RVA: 0x00006F39 File Offset: 0x00005139
		public WaitForSelectorAsyncResponse(bool success, string errorMessage)
		{
			this.Success = success;
			this.ErrorMessage = errorMessage;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00006F4F File Offset: 0x0000514F
		public WaitForSelectorAsyncResponse(string elementId, string tagName, bool elementAdded)
		{
			this.Success = true;
			this.ErrorMessage = string.Empty;
			this.ElementId = elementId;
			this.TagName = tagName;
			this.ElementAdded = elementAdded;
		}
	}
}
