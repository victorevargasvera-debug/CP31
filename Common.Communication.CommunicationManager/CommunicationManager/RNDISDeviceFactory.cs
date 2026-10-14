using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000025 RID: 37
	public abstract class RNDISDeviceFactory : global::Motorola.Common.Communication.DeviceFactoryBase
	{
		// Token: 0x06000082 RID: 130
		protected abstract global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo);

		// Token: 0x06000083 RID: 131 RVA: 0x0000B7F4 File Offset: 0x000099F4
		protected RNDISDeviceFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManagerClass, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory) : base(communicationManagerClass, communicationPipeFactory, sequenceManagerFactory)
		{
			this.a = observer;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000B814 File Offset: 0x00009A14
		protected override bool CreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			short num = (short)972554460;
			short num2 = num;
			num = (short)1867579612;
			bool result;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E5:
				num = (short)1379532801;
				if (num != 0)
				{
				}
				radio.DeviceInfo.RadioID = hwProfile.RadioIdString;
				result = true;
				num = (short)1009713155;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)259719168;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				break;
			}
			for (;;)
			{
				IL_58:
				switch (num3)
				{
				case 0:
				{
					radio.Prefetch();
					num = (short)1781399552;
					short num4 = num;
					num = (short)1010171905;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_189;
				case 2:
					if (radio != null)
					{
						num = (short)515964932;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
					goto IL_13A;
				case 4:
					radio.Register(this.a);
					num = (short)343277573;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.CommunicationManager.DiscoveryWorkMode == global::Motorola.Common.Communication.CommonUtil.WorkMode.Active)
					{
						num = (short)394526720;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E5;
				}
				goto IL_76;
			}
			IL_13A:
			return result;
			IL_189:
			goto IL_E5;
			IL_76:
			result = true;
			global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile rndisradioProfile = hwProfile as global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile;
			radio = this.CreateRadio(rndisradioProfile, new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo
			{
				ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter,
				UniqueAddress = rndisradioProfile.IPAddress,
				DeviceInstance = rndisradioProfile.DeviceInstanceID
			});
			num = (short)272302082;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_58;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000085 RID: 133
		public abstract string PAC_Name { get; }

		// Token: 0x04000025 RID: 37
		private readonly global::Motorola.Common.Communication.CommonUtil.IObserver a;
	}
}
