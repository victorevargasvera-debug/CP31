using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000024 RID: 36
	public class AstroRadioFactory : global::Motorola.Common.Communication.CommunicationManager.RNDISDeviceFactory
	{
		// Token: 0x0600007F RID: 127 RVA: 0x0000B44C File Offset: 0x0000964C
		public AstroRadioFactory(global::Motorola.Common.Communication.CommonUtil.IObserver observer, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory)
		{
			int a_ = 15;
			base..ctor(observer, sequenceManagerFactory, communicationManager, communicationPipeFactory);
			base.PIDList = new string[]
			{
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧婩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧孩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧塩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧幩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧屩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧嵩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧剩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧卩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥奧屩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥奧嵩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥奧剩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥奧卩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥塧嵩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥奧⭩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥奧⡩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧⭩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥塧剩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧⡩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧⥩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥孧⹩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥嵧孩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥嵧塩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥嵧奩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥嵧幩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥嵧彩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥嵧屩", a_),
				global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("啣噥嵧卩", a_)
			};
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000B658 File Offset: 0x00009858
		protected override global::Motorola.Common.Communication.IMotoDevice CreateRadio(global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo)
		{
			short num = (short)1215496192;
			short num2 = num;
			num = (short)1577857003;
			short num3 = num;
			num = (short)1878142955;
			switch (num3 == num)
			{
			}
			num = (short)937492480;
			if (num != 0)
			{
			}
			num = (short)798031873;
			if (num != 0)
			{
			}
			profile.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
			return new global::Motorola.Common.Communication.CommunicationManager.AstroWireDevice(new global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo
			{
				Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio,
				ConnectionInfo = connectionInfo
			}, profile, this.SequenceManagerFactory, this.CommunicationManager, this.CommunicationPipeFactory);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000B734 File Offset: 0x00009934
		public override string PAC_Name
		{
			get
			{
				int a_ = 13;
				short num = (short)724107264;
				short num2 = num;
				num = (short)917932081;
				short num3 = num;
				num = (short)1066764337;
				switch (num3 == num)
				{
				}
				num = (short)438304769;
				if (num != 0)
				{
				}
				num = (short)1523515392;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("⍡㝣㉥㩧╩㍫", a_);
			}
		}
	}
}
