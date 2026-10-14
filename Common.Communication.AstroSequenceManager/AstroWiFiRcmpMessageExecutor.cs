using System;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001A RID: 26
	public class AstroWiFiRcmpMessageExecutor : global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00018980 File Offset: 0x00016B80
		public AstroWiFiRcmpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, int inactivityTimeout) : base(commPipe, inactivityTimeout)
		{
			this.a = inactivityTimeout * 1000;
		}

		// Token: 0x04000042 RID: 66
		private int a = 60000;
	}
}
