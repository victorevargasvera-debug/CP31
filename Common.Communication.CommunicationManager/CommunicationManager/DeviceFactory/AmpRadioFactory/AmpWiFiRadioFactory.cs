using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationManager.Device;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory
{
	// Token: 0x0200003E RID: 62
	public class AmpWiFiRadioFactory : global::Motorola.Common.Communication.CommunicationManager.WiFiDeviceFactory
	{
		// Token: 0x0600014E RID: 334 RVA: 0x0001A878 File Offset: 0x00018A78
		public AmpWiFiRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory)
		{
			int a_ = 7;
			base..ctor(observer, communicationManager, communicationPipeFactory, sequenceManagerFactory);
			base.PIDList = new string[]
			{
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("୛㝝♟ୡ㭣❥╧㩩", a_)
			};
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0001A8B8 File Offset: 0x00018AB8
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			short num = (short)418250753;
			if (num != 0)
			{
			}
			num = (short)2135167378;
			short num2 = num;
			num = (short)430707090;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1153630208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)98631680;
			if (num != 0)
			{
			}
			profile.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
			return new global::Motorola.Common.Communication.CommunicationManager.Device.AmpZeroConfigDevice(new global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo
			{
				ProcessorType = global::ProcessorType.AP,
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio,
				ConnectionInfo = connectionInfo
			}, profile, this.SequenceManagerFactory, this.CommunicationManager, this.CommunicationPipeFactory);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		public override string PAC_Name
		{
			get
			{
				int a_ = 5;
				short num = (short)2108782808;
				short num2 = num;
				num = (short)669415640;
				switch (num2 == num)
				{
				}
				num = (short)1100808192;
				short num3 = num;
				num = (short)641597440;
				if (num != 0)
				{
				}
				num = (short)862126081;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("᭙ཛ੝㉟ⵡ㭣", a_);
			}
		}
	}
}
