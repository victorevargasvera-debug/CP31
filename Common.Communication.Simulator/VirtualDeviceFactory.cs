using System;
using Motorola.Common.Communication;
using Motorola.Common.Communication.CommunicationManager;

namespace Common.Communication.Simulator
{
	// Token: 0x02000004 RID: 4
	public class VirtualDeviceFactory : global::Motorola.Common.Communication.DeviceFactoryBase
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public VirtualDeviceFactory(global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory)
		{
			int a_ = 7;
			base..ctor(communicationManager, communicationPipeFactory, sequenceManagerFactory);
			base.PIDList = new string[]
			{
				global::Common.Communication.Simulator.VirtualLEDevices.b("罅煇獉畋睍", a_),
				global::Common.Communication.Simulator.VirtualLEDevices.b("罅煇獉畋癍", a_),
				global::Common.Communication.Simulator.VirtualLEDevices.b("᥅ᡇࡉ๋ᅍُ㭑♓≕ⵗ㭙せᩝ՟ᑡൣե൧", a_)
			};
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003B34 File Offset: 0x00001D34
		protected override bool CreateRadio(out global::Motorola.Common.Communication.IMotoDevice radio, global::Motorola.Common.Communication.IRadioProfile hwProfile)
		{
			short num = (short)678700260;
			short num2 = num;
			num = (short)1051600100;
			switch (num2 == num)
			{
			}
			num = (short)564985857;
			if (num != 0)
			{
			}
			num = (short)188612608;
			short num3 = num;
			num = (short)1118830592;
			if (num != 0)
			{
			}
			radio = new global::Common.Communication.Simulator.VirtualMotoDevice(hwProfile);
			return true;
		}
	}
}
