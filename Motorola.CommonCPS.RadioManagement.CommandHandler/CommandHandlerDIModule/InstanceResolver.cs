using System;
using System.Runtime.CompilerServices;
using Autofac;
using Autofac.Builder;
using Autofac.Features.ResolveAnything;

namespace Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule
{
	// Token: 0x0200000A RID: 10
	public class InstanceResolver : global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.IInstanceResolver
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003AA0 File Offset: 0x00001CA0
		public static global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.IInstanceResolver GetInstance
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)621915507;
				short num2 = num;
				num = (short)349678963;
				switch (num2 == num)
				{
				default:
				{
					num = (short)854392832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1039728641;
				if (num != 0)
				{
				}
				num = (short)2019819520;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.InstanceResolver.a;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003B4C File Offset: 0x00001D4C
		private InstanceResolver()
		{
			global::Autofac.ContainerBuilder containerBuilder = new global::Autofac.ContainerBuilder();
			containerBuilder.RegisterSource(new global::Autofac.Features.ResolveAnything.AnyConcreteTypeNotAlreadyRegisteredSource());
			containerBuilder.RegisterModule<global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.CommandHandlerModule>();
			this.b = containerBuilder.Build(global::Autofac.Builder.ContainerBuildOptions.None);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003B84 File Offset: 0x00001D84
		public T Resolve<T>() where T : class
		{
			short num = (short)1447633033;
			short num2 = num;
			num = (short)801579145;
			switch (num2 == num)
			{
			default:
			{
				num = (short)720371712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)354287617;
			if (num != 0)
			{
			}
			num = (short)1665859584;
			if (num != 0)
			{
			}
			return this.b.Resolve<T>();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003C38 File Offset: 0x00001E38
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceResolver()
		{
			short num = (short)925648768;
			short num2 = num;
			num = (short)171460480;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1595801600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1679884289;
			if (num != 0)
			{
			}
			num = (short)1782710272;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.InstanceResolver.a = new global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.InstanceResolver();
		}

		// Token: 0x04000012 RID: 18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static readonly global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.IInstanceResolver a;

		// Token: 0x04000013 RID: 19
		private readonly global::Autofac.IContainer b;
	}
}
