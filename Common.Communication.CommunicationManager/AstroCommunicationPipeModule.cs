using System;
using Autofac;
using Motorola.Common.Communication.CommunicationManager;
using Motorola.Common.Communication.CommunicationManager.Creators.CommunicationPipe.ASTRO;

namespace Motorola.Common.Communication
{
	// Token: 0x02000005 RID: 5
	public class AstroCommunicationPipeModule : global::Autofac.Module
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000279C File Offset: 0x0000099C
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)1678190319;
			short num2 = num;
			num = (short)406791919;
			switch (num2 == num)
			{
			}
			num = (short)1939865601;
			if (num != 0)
			{
			}
			num = (short)1541996544;
			short num3 = num;
			num = (short)1099497472;
			if (num != 0)
			{
			}
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroUsbBtCommPipeCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroUsbBtResetCommPipeCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroUsbBtTlsHandshakeCommPipeCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroOtapCommPipeCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroOtapTlsHandshakeCommPipeCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.AstroWifiCommPipeCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.Creators.CommunicationPipe.ASTRO.AmpCommPipeCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator>().SingleInstance();
			builder.RegisterType<global::Motorola.Common.Communication.CommunicationManager.Creators.CommunicationPipe.ASTRO.AmpTlsHandshakeCommPipeCreator>().As<global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator>().SingleInstance();
		}
	}
}
