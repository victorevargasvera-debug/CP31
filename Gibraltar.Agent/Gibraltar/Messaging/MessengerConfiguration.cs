using System;

namespace Gibraltar.Messaging
{
	// Token: 0x02000239 RID: 569
	internal class MessengerConfiguration
	{
		// Token: 0x06001CAD RID: 7341 RVA: 0x00064D00 File Offset: 0x00062F00
		public MessengerConfiguration(string name, string messengerType)
		{
			this.m_Name = name;
			this.m_MessengerType = messengerType;
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00064D18 File Offset: 0x00062F18
		public string Name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001CAF RID: 7343 RVA: 0x00064D20 File Offset: 0x00062F20
		public string MessengerType
		{
			get
			{
				return this.m_MessengerType;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00064D28 File Offset: 0x00062F28
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x00064D30 File Offset: 0x00062F30
		public bool ForceSynchronous { get; set; }

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00064D3C File Offset: 0x00062F3C
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00064D44 File Offset: 0x00062F44
		public int MaxQueueLength { get; set; }

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00064D50 File Offset: 0x00062F50
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x00064D58 File Offset: 0x00062F58
		public bool Enabled { get; set; }

		// Token: 0x04000A8B RID: 2699
		private string m_Name;

		// Token: 0x04000A8C RID: 2700
		private string m_MessengerType;
	}
}
