using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000026 RID: 38
	public class AstroWiFiRadioFactory : global::Motorola.Common.Communication.CommunicationManager.WiFiDeviceFactory
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0000BA04 File Offset: 0x00009C04
		public AstroWiFiRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory)
		{
			int a_ = 9;
			base..ctor(observer, communicationManager, communicationPipeFactory, sequenceManagerFactory);
			base.PIDList = new string[]
			{
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ढ़य़②ൣ㥥⥧㩩㑫", a_)
			};
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000BA44 File Offset: 0x00009C44
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
			short num;
			for (;;)
			{
				profile.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
				deviceInfo = new global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo();
				deviceInfo.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
				deviceInfo.ConnectionInfo = connectionInfo;
				if (!profile.TlsPsk)
				{
					break;
				}
				num = (short)2096758785;
				if (num != 0)
				{
				}
				num = (short)27282529;
				short num2 = num;
				num = (short)1069632609;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_C3;
				}
			}
			num = (short)1701838848;
			short num3 = num;
			return new global::Motorola.Common.Communication.CommunicationManager.AstroWiFiDevice(deviceInfo, profile, this.SequenceManagerFactory, this.CommunicationManager, this.CommunicationPipeFactory);
			IL_C3:
			num = (short)1383202816;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.CommunicationManager.AstroWifiTlsDevice(deviceInfo, profile, this.SequenceManagerFactory, this.CommunicationManager, this.CommunicationPipeFactory);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000BB44 File Offset: 0x00009D44
		public override string PAC_Name
		{
			get
			{
				int a_ = 17;
				short num = (short)1130496000;
				short num2 = num;
				num = (short)234894827;
				short num3 = num;
				num = (short)1525757419;
				switch (num3 == num)
				{
				}
				num = (short)560463873;
				if (num != 0)
				{
				}
				num = (short)972488704;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("❥㭧㹩㹫Ⅽ⽯", a_);
			}
		}
	}
}
