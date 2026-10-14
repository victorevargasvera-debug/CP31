using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000021 RID: 33
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	internal class AstroWiFiFileFlashSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000077 RID: 119 RVA: 0x0000B15C File Offset: 0x0000935C
		public global::Motorola.Common.Communication.ISequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)1673986049;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1199370503;
				short num3 = num;
				num = (short)1699672327;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1004929025;
					if (num != 0)
					{
					}
					num = (short)1050083328;
					if (num != 0)
					{
					}
					num = (short)2082603008;
					short num4 = num;
					switch (num2)
					{
					case 0:
						goto IL_134;
					case 1:
						goto IL_15;
					case 2:
						goto IL_110;
					case 3:
						num = (short)1328021504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				}
				}
				IL_15:
				switch (0)
				{
				case 0:
					IL_D1:
					if (deviceInfo.ConnectionInfo.InactivityTimeout <= 0)
					{
						num = (short)607649795;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)651821058;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_110:
			int num5 = deviceInfo.ConnectionInfo.InactivityTimeout;
			goto IL_138;
			IL_134:
			num5 = 60;
			IL_138:
			int num6 = num5;
			global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper = new global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor(communicationPipe, num6);
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo.ConnectionInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerCreateSequenceManagerFailure);
			return new global::Motorola.Common.Communication.AstroWiFiManagedFileFlashSequenceManager(rcmpWrapper, num6, sessionParameter);
		}
	}
}
