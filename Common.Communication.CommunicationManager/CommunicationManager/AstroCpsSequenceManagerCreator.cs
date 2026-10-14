using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001B RID: 27
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program | global::Motorola.Common.Communication.CommonUtil.RadioOperation.CBIProgram | global::Motorola.Common.Communication.CommonUtil.RadioOperation.PasswordReset)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create | global::Motorola.Common.Communication.CommonUtil.RadioOperation.PasswordReset)]
	internal class AstroCpsSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000A978 File Offset: 0x00008B78
		public global::Motorola.Common.Communication.ISequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)1881014272;
			short num2 = num;
			num = (short)1984036865;
			if (num != 0)
			{
			}
			num = (short)2030513048;
			short num3 = num;
			num = (short)1485646744;
			switch (num3 == num)
			{
			}
			num = (short)706936832;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.AstroCpsSequenceManager(new global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor(communicationPipe), sessionParameter);
		}
	}
}
