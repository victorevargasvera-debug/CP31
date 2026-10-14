using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001D RID: 29
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter | global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.FileUpdate)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program | global::Motorola.Common.Communication.CommonUtil.RadioOperation.CBIProgram)]
	internal class AstroFileSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600006F RID: 111 RVA: 0x0000AB9C File Offset: 0x00008D9C
		public global::Motorola.Common.Communication.ISequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_148;
				case 1:
					if (sessionParameter != null)
					{
						num2 = (short)1686437891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DE;
				case 2:
					if (!sessionParameter.ArchiveSession)
					{
						num2 = (short)1462763520;
						short num3 = num2;
						num2 = (short)603127808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14A;
				case 3:
					num2 = (short)209387522;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_DE:
			global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper;
			return new global::Motorola.Common.Communication.AstroFileSeqManager(rcmpWrapper, sessionParameter);
			IL_148:
			goto IL_DE;
			IL_20:
			num2 = (short)874491160;
			short num4 = num2;
			num2 = (short)552054040;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14A:
				return new global::Motorola.Common.Communication.AstroManagedFileSeqManager(rcmpWrapper, sessionParameter);
			default:
			{
				num2 = (short)1109524480;
				if (num2 != 0)
				{
				}
				num2 = (short)1311113217;
				if (num2 != 0)
				{
				}
				rcmpWrapper = new global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor(communicationPipe);
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo.ConnectionInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerCreateSequenceManagerFailure);
				num2 = (short)2086207489;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}
	}
}
