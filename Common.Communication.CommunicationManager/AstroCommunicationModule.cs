using System;
using Autofac;
using Motorola.Common.Communication.CommunicationManager;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	public class AstroCommunicationModule : global::Autofac.Module
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002AB4 File Offset: 0x00000CB4
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)1569652737;
			if (num != 0)
			{
			}
			num = (short)1105839184;
			short num2 = num;
			num = (short)1037222992;
			switch (num2 == num)
			{
			}
			num = (short)440926208;
			short num3 = num;
			num = (short)511639552;
			if (num != 0)
			{
			}
			builder.RegisterModule<global::Motorola.Common.Communication.AstroCommunicationPipeModule>();
			builder.RegisterModule<global::Motorola.Common.Communication.AstroSequenceManagerModule>();
			builder.RegisterModule<global::Motorola.Common.Communication.AstroDeviceDetectorsModule>();
			builder.RegisterModule<global::Motorola.Common.Communication.AstroDeviceFactoriesModule>();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpCpsSequenceManagerCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory.AmpBpRadioFactory>().As<global::Motorola.Common.Communication.IDeviceFactory>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.DeviceFactory.AmpRadioFactory.AmpApRadioFactory>().As<global::Motorola.Common.Communication.IDeviceFactory>().SingleInstance();
		}
	}
}
