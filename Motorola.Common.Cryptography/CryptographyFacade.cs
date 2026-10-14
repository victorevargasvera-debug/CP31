using System;
using System.Net;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Motorola.Common.Cryptography.Autofac;
using Motorola.Common.Cryptography.Configuration;
using Motorola.Common.Cryptography.Providers;

namespace Motorola.Common.Cryptography
{
	// Token: 0x02000004 RID: 4
	public static class CryptographyFacade
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000028E4 File Offset: 0x00000AE4
		static CryptographyFacade()
		{
			int a_ = 17;
			short num = (short)49704374;
			short num2 = num;
			num = (short)1457614262;
			switch (num2 == num)
			{
			}
			num = (short)3145729;
			if (num != 0)
			{
			}
			num = (short)297467904;
			short num3 = num;
			num = (short)1080164352;
			if (num != 0)
			{
			}
			global::System.AppContext.SetSwitch(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㑦Ṩɪᥬ౮ᥰ嵲♴๶੸ེ᡼ቾ꾀쪂ﾊﮎ\ude92杖ﲘ뎜\udb9e좠킢쒤얦얨캪\udaae\uddb0잲\udcb4잶햸\udeba寮鋀蛂ꯄ돆믈ꋊ꣌볎飐뷒蛔雖韘飚룜귞闠諢菤軦諨諪駬諮", a_), true);
			global::Autofac.ContainerBuilder containerBuilder = new global::Autofac.ContainerBuilder();
			containerBuilder.RegisterModule<global::Motorola.Common.Cryptography.Autofac.CryptographyModule>();
			global::Motorola.Common.Cryptography.CryptographyFacade.a = containerBuilder.Build(global::Autofac.Builder.ContainerBuildOptions.None);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000029C4 File Offset: 0x00000BC4
		public static global::Motorola.Common.Cryptography.Providers.ICertificateProvider GetProvider(string group)
		{
			short num = (short)1608993548;
			short num2 = num;
			num = (short)521685772;
			switch (num2 == num)
			{
			}
			num = (short)1932328961;
			if (num != 0)
			{
			}
			num = (short)2143223808;
			short num3 = num;
			num = (short)933363712;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Cryptography.CryptographyFacade.a.Resolve(new global::Autofac.Core.Parameter[]
			{
				global::Motorola.Common.Cryptography.CryptographyFacade.a(group)
			});
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002A88 File Offset: 0x00000C88
		public static global::Motorola.Common.Cryptography.Configuration.ICertificateConfiguration GetConfiguration(global::System.Net.IPEndPoint[] portBindings, string group)
		{
			short num = (short)297899195;
			short num2 = num;
			num = (short)1502844091;
			switch (num2 == num)
			{
			}
			num = (short)934477825;
			if (num != 0)
			{
			}
			num = (short)1751908352;
			short num3 = num;
			num = (short)801243136;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Cryptography.CryptographyFacade.a.Resolve(new global::Autofac.Core.Parameter[]
			{
				new global::Autofac.TypedParameter(typeof(global::System.Net.IPEndPoint[]), portBindings),
				global::Motorola.Common.Cryptography.CryptographyFacade.a(group)
			});
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002B60 File Offset: 0x00000D60
		public static global::Motorola.Common.Cryptography.Providers.IIdentityProvider GetServerIdentityProvider()
		{
			int a_ = 10;
			short num = (short)219071265;
			short num2 = num;
			num = (short)1854063393;
			switch (num2 == num)
			{
			}
			num = (short)1596129280;
			if (num != 0)
			{
			}
			num = (short)1587216384;
			short num3 = num;
			num = (short)1302855681;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Cryptography.CryptographyFacade.a.Resolve(new global::Autofac.Core.Parameter[]
			{
				global::Motorola.Common.Cryptography.CryptographyFacade.a(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("፟ݡᙣၥ൧ᡩ╫੭ᕯᱱsή౷͹", a_))
			});
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002C38 File Offset: 0x00000E38
		private static global::Autofac.Core.ConstantParameter a(string A_0)
		{
			int a_ = 11;
			short num = (short)1758231960;
			short num2 = num;
			num = (short)1948286360;
			switch (num2 == num)
			{
			}
			num = (short)852361217;
			if (num != 0)
			{
			}
			num = (short)1966473216;
			short num3 = num;
			num = (short)359137280;
			if (num != 0)
			{
			}
			return new global::Autofac.NamedParameter(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("٠ᅢ੤ቦᥨ", a_), A_0);
		}

		// Token: 0x04000007 RID: 7
		private static readonly global::Autofac.IContainer a;
	}
}
