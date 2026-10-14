using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000022 RID: 34
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program | global::Motorola.Common.Communication.CommonUtil.RadioOperation.CBIProgram)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)]
	internal class AstroWiFiSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000079 RID: 121 RVA: 0x0000B2D4 File Offset: 0x000094D4
		public global::Motorola.Common.Communication.ISequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)1437204481;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)643116396;
				short num3 = num;
				num = (short)702754156;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1552154625;
					if (num != 0)
					{
					}
					num = (short)1354498048;
					if (num != 0)
					{
					}
					num = (short)436142080;
					short num4 = num;
					switch (num2)
					{
					case 0:
						goto IL_134;
					case 1:
						goto IL_14;
					case 2:
						goto IL_110;
					case 3:
						num = (short)365297664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CF;
				}
				}
				IL_14:
				switch (0)
				{
				case 0:
					IL_CF:
					if (deviceInfo.ConnectionInfo.InactivityTimeout <= 0)
					{
						num = (short)1505492995;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)128385026;
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
			return new global::Motorola.Common.Communication.AstroWifiFileSeqManager(rcmpWrapper, num6, sessionParameter);
		}
	}
}
