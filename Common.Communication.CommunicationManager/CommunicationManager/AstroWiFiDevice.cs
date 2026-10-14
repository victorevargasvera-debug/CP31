using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002B RID: 43
	internal class AstroWiFiDevice : global::Motorola.Common.Communication.CommunicationManager.WiFiDevice
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00014B88 File Offset: 0x00012D88
		public AstroWiFiDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory) : base(deviceInfo, profile, sequenceManagerFactory, communicationManager, communicationPipeFactory)
		{
			if (profile != null)
			{
				this.a = profile.InstanceId;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00014BB8 File Offset: 0x00012DB8
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			short num = (short)1174405121;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)875683071;
					short num3 = num;
					num = (short)211344639;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_109;
					default:
					{
						num = (short)1832714241;
						if (num != 0)
						{
						}
						num = (short)1044447232;
						if (num != 0)
						{
						}
						num = (short)882442240;
						short num4 = num;
						base.RefreshIPAddress();
						num = (short)2019622914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_109;
				}
				IL_30:
				if (base.RadioProfile == null)
				{
					break;
				}
				num = (short)897122304;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_109:
			return base.OpenSession(operationType, sessionParameter);
		}

		// Token: 0x04000037 RID: 55
		private uint a;
	}
}
