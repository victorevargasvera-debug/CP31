using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001E RID: 30
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	internal class AstroFlashSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000071 RID: 113 RVA: 0x0000AD10 File Offset: 0x00008F10
		public global::Motorola.Common.Communication.ISequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)1375666176;
			short num2 = num;
			num = (short)795803649;
			if (num != 0)
			{
			}
			num = (short)1352742172;
			short num3 = num;
			num = (short)1210070300;
			switch (num3 == num)
			{
			}
			num = (short)1087176704;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.AstroFlashSequenceManager(new global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor(communicationPipe), sessionParameter);
		}
	}
}
