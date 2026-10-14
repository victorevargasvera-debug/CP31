using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000024 RID: 36
	public interface ICommunicationPipeFactory
	{
		// Token: 0x0600012C RID: 300
		global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CreateCommunicationPipe(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter = null);

		// Token: 0x0600012D RID: 301
		global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator FindCommunicationPipeCreator(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation);
	}
}
