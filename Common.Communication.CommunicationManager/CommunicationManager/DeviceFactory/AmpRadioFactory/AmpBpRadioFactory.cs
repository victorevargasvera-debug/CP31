using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory
{
	// Token: 0x0200003D RID: 61
	public class AmpBpRadioFactory : global::Motorola.Common.Communication.CommunicationManager.RNDISDeviceFactory
	{
		// Token: 0x0600014B RID: 331 RVA: 0x0001A66C File Offset: 0x0001886C
		public AmpBpRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory)
		{
			int a_ = 5;
			base..ctor(observer, sequenceManagerFactory, communicationManager, communicationPipeFactory);
			base.PIDList = new string[]
			{
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("歙汛歝坟", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("歙汛歝≟", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("歙汛歝⅟", a_)
			};
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0001A6CC File Offset: 0x000188CC
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			short num = (short)1794027498;
			short num2 = num;
			num = (short)850964458;
			switch (num2 == num)
			{
			}
			num = (short)426573824;
			short num3 = num;
			num = (short)1095434241;
			if (num != 0)
			{
			}
			num = (short)1771372544;
			if (num != 0)
			{
			}
			profile.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
			return new global::Motorola.Common.Communication.CommunicationManager.AstroWireDevice(new global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo
			{
				ProcessorType = global::ProcessorType.BP,
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio,
				ConnectionInfo = connectionInfo
			}, profile, this.SequenceManagerFactory, this.CommunicationManager, this.CommunicationPipeFactory);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0001A7B4 File Offset: 0x000189B4
		public override string PAC_Name
		{
			get
			{
				int a_ = 7;
				short num = (short)1886831162;
				short num2 = num;
				num = (short)605274682;
				switch (num2 == num)
				{
				}
				num = (short)1528365056;
				short num3 = num;
				num = (short)1868038145;
				if (num != 0)
				{
				}
				num = (short)166002688;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᵛ൝㑟ち⭣㥥", a_);
			}
		}
	}
}
