using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000025 RID: 37
	public interface ISequenceManagerFactory
	{
		// Token: 0x0600012E RID: 302
		global::Motorola.Common.Communication.ISequenceManager CreateSequenceManager(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter);
	}
}
