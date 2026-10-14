using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000020 RID: 32
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Raw, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)]
	internal class AstroOtapIshSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000AF9C File Offset: 0x0000919C
		public global::Motorola.Common.Communication.ISequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_124;
				case 1:
				{
					if (deviceInfo.ConnectionInfo.InactivityTimeout <= 0)
					{
						num2 = (short)760938497;
						if (num2 != 0)
						{
						}
						num2 = (short)329973763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2041431149;
					short num3 = num2;
					num2 = (short)803062893;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FF;
					default:
						num2 = (short)636420096;
						if (num2 != 0)
						{
						}
						num2 = (short)1141571586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_FF;
				case 3:
					num2 = (short)36044800;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_29;
			}
			IL_FF:
			int num4 = deviceInfo.ConnectionInfo.InactivityTimeout;
			goto IL_153;
			IL_124:
			num2 = (short)52232192;
			short num5 = num2;
			num4 = 180;
			IL_153:
			int num6 = num4;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("⁠ၢᅤᕦ٨䭪≬᭮ၰͲ啴㹶᝸᩺Ṽ୾\udf8a떔ﺖ뮚爵햠莢톤좦覨횬龮첰鮴鞶钸鮺즼춾룀뇄꣆룊꣌믎ꓒ볔ꏖ뇘ﯚ蛜ꓞ탠黢룤", a_), new object[]
			{
				num6,
				deviceInfo.ConnectionInfo.InactivityTimeout
			});
			return new global::Motorola.Common.Communication.AstroOtapIshSequenceManager(new global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor(communicationPipe, num6), num6, sessionParameter);
			IL_29:
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo.ConnectionInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerCreateSequenceManagerFailure);
			num2 = (short)1559822337;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
