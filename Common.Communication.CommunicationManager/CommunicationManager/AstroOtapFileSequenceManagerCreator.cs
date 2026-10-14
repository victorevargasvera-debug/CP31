using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001F RID: 31
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program | global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	internal class AstroOtapFileSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000073 RID: 115 RVA: 0x0000ADDC File Offset: 0x00008FDC
		public global::Motorola.Common.Communication.ISequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			int a_ = 2;
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
					goto IL_123;
				case 1:
				{
					if (deviceInfo.ConnectionInfo.InactivityTimeout <= 0)
					{
						num2 = (short)689045507;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)100466636;
					short num3 = num2;
					num2 = (short)902102988;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D7;
					default:
						num2 = (short)932773888;
						if (num2 != 0)
						{
						}
						num2 = (short)1420558338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_D7;
				case 3:
					num2 = (short)1429995520;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_29;
			}
			IL_D7:
			num2 = (short)2057699329;
			if (num2 != 0)
			{
			}
			int num4 = deviceInfo.ConnectionInfo.InactivityTimeout;
			goto IL_153;
			IL_123:
			num2 = (short)143392768;
			short num5 = num2;
			num4 = 180;
			IL_153:
			int num6 = num4;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᙖ⩘⽚⽜ぞ䅠Ɫᅤ٦ᥨ䭪⑬ŮၰၲŴṶླྀቺॼپ햀ﮈꮊﲎ놐릘뾞猪\ud8a2閤\udaa6薪趬芮醰잲잴캶馸쾺튼龾닀ꛂ뇄뻈ꋊ만꟎裒껔ꓘ蛚", a_), new object[]
			{
				num6,
				deviceInfo.ConnectionInfo.InactivityTimeout
			});
			return new global::Motorola.Common.Communication.AstroOtapFileSequenceManager(new global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor(communicationPipe, num6), num6, sessionParameter, operation);
			IL_29:
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(deviceInfo.ConnectionInfo, global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerCreateSequenceManagerFailure);
			num2 = (short)2004090881;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
