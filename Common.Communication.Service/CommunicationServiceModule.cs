using System;
using Autofac;
using Autofac.Builder;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000043 RID: 67
	public class CommunicationServiceModule : global::Autofac.Module
	{
		// Token: 0x0600025D RID: 605 RVA: 0x00015964 File Offset: 0x00013B64
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)1946071416;
			short num2 = num;
			num = (short)961393016;
			switch (num2 == num)
			{
			}
			num = (short)1317076992;
			short num3 = num;
			num = (short)9764865;
			if (num != 0)
			{
			}
			num = (short)1020264448;
			if (num != 0)
			{
			}
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.SequenceManagerFactory>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.CommunicationPipeFactory>().As<global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector>().AsSelf<global::Motorola.Common.Communication.CommunicationManager.MotoDeviceDetector, global::Autofac.Builder.ConcreteReflectionActivatorData>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.MotoDeviceFactory>().AsSelf<global::Motorola.Common.Communication.CommunicationManager.MotoDeviceFactory, global::Autofac.Builder.ConcreteReflectionActivatorData>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass>().AsSelf<global::Motorola.Common.Communication.CommunicationManager.CommunicationManagerClass, global::Autofac.Builder.ConcreteReflectionActivatorData>().As<global::Motorola.Common.Communication.CommonUtil.IObserver>().As<global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.Service.DeviceServiceManager>().AsSelf<global::Motorola.Common.Communication.Service.DeviceServiceManager, global::Autofac.Builder.ConcreteReflectionActivatorData>().SingleInstance();
		}
	}
}
