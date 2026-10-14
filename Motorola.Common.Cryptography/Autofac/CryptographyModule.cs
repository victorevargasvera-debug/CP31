using System;
using Autofac;
using Autofac.Core;
using Motorola.Common.Cryptography.Configuration;
using Motorola.Common.Cryptography.Configuration.AppConfig;
using Motorola.Common.Cryptography.Configuration.PortBinding;
using Motorola.Common.Cryptography.Configuration.Registry;
using Motorola.Common.Cryptography.Providers;

namespace Motorola.Common.Cryptography.Autofac
{
	// Token: 0x02000033 RID: 51
	public class CryptographyModule : global::Autofac.Module
	{
		// Token: 0x0600008E RID: 142 RVA: 0x000077C4 File Offset: 0x000059C4
		protected override void Load(global::Autofac.ContainerBuilder builder)
		{
			short num = (short)1312381355;
			short num2 = num;
			num = (short)1899649451;
			switch (num2 == num)
			{
			}
			num = (short)1514733568;
			if (num != 0)
			{
			}
			num = (short)148242432;
			short num3 = num;
			num = (short)1276051457;
			if (num != 0)
			{
			}
			base.Load(builder);
			builder.RegisterType<global::Motorola.Common.Cryptography.Configuration.CertificateConfiguration>().As<global::Motorola.Common.Cryptography.Configuration.ICertificateConfiguration>();
			builder.RegisterType<global::Motorola.Common.Cryptography.Providers.CertificateProvider>().As<global::Motorola.Common.Cryptography.Providers.ICertificateProvider>();
			builder.RegisterType<global::Motorola.Common.Cryptography.Configuration.Registry.RegistryConfig>().As<global::Motorola.Common.Cryptography.Configuration.Registry.IRegistryConfig>();
			builder.RegisterType<global::Motorola.Common.Cryptography.Providers.CertificateStore>().As<global::Motorola.Common.Cryptography.Providers.ICertificateStore>().OnPreparing(new global::System.Action<global::Autofac.Core.PreparingEventArgs>(global::Motorola.Common.Cryptography.Autofac.AutofacExtensions.ForwardFactoryParameters));
			builder.RegisterType<global::Motorola.Common.Cryptography.Providers.CertificateRemover>().As<global::Motorola.Common.Cryptography.Providers.ICertificateRemover>();
			builder.Register(new global::System.Func<global::Autofac.IComponentContext, global::Motorola.Common.Cryptography.Configuration.AppConfig.ICertificateSection>(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.<>c.<>9.a)).As<global::Motorola.Common.Cryptography.Configuration.AppConfig.ICertificateSection>();
			builder.RegisterType<global::Motorola.Common.Cryptography.Configuration.PortBinding.PortBindingConfiguration>().As<global::Motorola.Common.Cryptography.Configuration.PortBinding.IPortBindingConfiguration>();
			builder.RegisterType<global::Motorola.Common.Cryptography.Providers.IdentityProvider>().As<global::Motorola.Common.Cryptography.Providers.IIdentityProvider>();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000791C File Offset: 0x00005B1C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(63307419 + A_1) + (global::System.IntPtr)38 + (global::System.IntPtr)70 + (global::System.IntPtr)78);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x04000034 RID: 52
		public const string GroupParamName = "group";
	}
}
