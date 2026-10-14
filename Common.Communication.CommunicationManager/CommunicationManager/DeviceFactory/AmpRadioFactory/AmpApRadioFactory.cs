using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationManager.Device;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory
{
	// Token: 0x0200003C RID: 60
	public class AmpApRadioFactory : global::Motorola.Common.Communication.CommunicationManager.RNDISDeviceFactory
	{
		// Token: 0x06000147 RID: 327 RVA: 0x0001A358 File Offset: 0x00018558
		public AmpApRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory) : base(observer, sequenceManagerFactory, communicationManager, communicationPipeFactory)
		{
			base.PIDList = global::Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory.AmpApRadioFactory.ApPIDs.ToArray();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0001A380 File Offset: 0x00018580
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			short num = (short)400041704;
			short num2 = num;
			num = (short)1553147624;
			switch (num2 == num)
			{
			}
			num = (short)1419640832;
			short num3 = num;
			num = (short)379650049;
			if (num != 0)
			{
			}
			num = (short)1559560192;
			if (num != 0)
			{
			}
			profile.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
			return new global::Motorola.Common.Communication.CommunicationManager.Device.AmpZeroConfigDevice(new global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo
			{
				ProcessorType = global::ProcessorType.AP,
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio,
				ConnectionInfo = connectionInfo,
				ConnectionInfo = 
				{
					IsTlsPskCompatible = true
				}
			}, profile, this.SequenceManagerFactory, this.CommunicationManager, this.CommunicationPipeFactory);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0001A474 File Offset: 0x00018674
		public override string PAC_Name
		{
			get
			{
				int a_ = 6;
				short num = (short)1392967681;
				if (num != 0)
				{
				}
				num = (short)987341482;
				short num2 = num;
				num = (short)1139843754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1381957632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)478543872;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᩚ๜୞㍠Ɫ㩤", a_);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001A534 File Offset: 0x00018734
		// Note: this type is marked as 'beforefieldinit'.
		static AmpApRadioFactory()
		{
			int a_ = 0;
			short num = (short)927617915;
			short num2 = num;
			num = (short)1691505531;
			switch (num2 == num)
			{
			}
			num = (short)552861696;
			short num3 = num;
			num = (short)117309440;
			if (num != 0)
			{
			}
			num = (short)1265041409;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory.AmpApRadioFactory.ApPIDs = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("汔晖湘歚", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("汔晖湘橚", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("汔晖恘歚", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("汔晖恘橚", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("汔晖恘捚", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("汔晖恘扚", a_)
			};
		}

		// Token: 0x0400005B RID: 91
		public static readonly global::System.Collections.Generic.List<string> ApPIDs;
	}
}
