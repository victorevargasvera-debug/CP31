using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000018 RID: 24
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.PasswordReset)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.PasswordReset)]
	internal class AstroUsbBtResetCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000065 RID: 101 RVA: 0x0000A460 File Offset: 0x00008660
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			short num = (short)165871616;
			short num2 = num;
			num = (short)1611714661;
			short num3 = num;
			num = (short)1402327141;
			switch (num3 == num)
			{
			}
			num = (short)1883373568;
			if (num != 0)
			{
			}
			num = (short)1399259137;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo), 8002, false);
		}
	}
}
