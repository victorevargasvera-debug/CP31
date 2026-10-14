using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001C RID: 28
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	internal class AstroFileFlashSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000AA40 File Offset: 0x00008C40
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
					goto IL_E0;
				case 1:
					if (sessionParameter != null)
					{
						num2 = (short)88735747;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A2;
				case 2:
					if (!sessionParameter.ArchiveSession)
					{
						num2 = (short)1908015104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_133;
				case 3:
					num2 = (short)1596850178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_A2:
			global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper;
			return new global::Motorola.Common.Communication.AstroFileFlashSequenceManager(rcmpWrapper, sessionParameter);
			IL_E0:
			num2 = (short)1786249216;
			short num3 = num2;
			num2 = (short)2039676929;
			if (num2 != 0)
			{
			}
			goto IL_A2;
			IL_20:
			num2 = (short)962557573;
			short num4 = num2;
			num2 = (short)329086597;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_133:
				return new global::Motorola.Common.Communication.AstroManagedFileFlashSequenceManager(rcmpWrapper, sessionParameter);
			default:
			{
				num2 = (short)1566507008;
				if (num2 != 0)
				{
				}
				rcmpWrapper = new global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor(communicationPipe);
				num2 = (short)93716481;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}
	}
}
