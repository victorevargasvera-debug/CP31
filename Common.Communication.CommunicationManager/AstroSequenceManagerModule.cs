using System;
using Autofac;
using Motorola.Common.Communication.CommunicationManager;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public class AstroSequenceManagerModule : global::Autofac.Module
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)2082557374;
			short num2 = num;
			num = (short)759057854;
			switch (num2 == num)
			{
			}
			num = (short)1731198977;
			if (num != 0)
			{
			}
			num = (short)1076822016;
			short num3 = num;
			num = (short)1724710912;
			if (num != 0)
			{
			}
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroCpsSequenceManagerCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroFileSequenceManagerCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroOtapIshSequenceManagerCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroOtapFileSequenceManagerCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroFlashSequenceManagerCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroFileFlashSequenceManagerCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroWiFiSequenceManagerCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroWiFiFileFlashSequenceManagerCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>().SingleInstance();
		}
	}
}
