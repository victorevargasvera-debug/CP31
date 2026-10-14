using System;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Motorola.Common.Cryptography.Autofac;
using Motorola.Common.Cryptography.Configuration.PortBinding;
using Motorola.Common.Cryptography.Configuration.Registry;
using Motorola.Common.Cryptography.Providers;

namespace Motorola.Common.Cryptography.Configuration
{
	// Token: 0x02000018 RID: 24
	public class CertificateConfiguration : global::Motorola.Common.Cryptography.Configuration.ICertificateConfiguration
	{
		// Token: 0x06000031 RID: 49 RVA: 0x0000401C File Offset: 0x0000221C
		public CertificateConfiguration(global::Motorola.Common.Cryptography.Configuration.Registry.IRegistryConfig registry, global::Motorola.Common.Cryptography.Configuration.PortBinding.IPortBindingConfiguration portBindingConfiguration, global::Motorola.Common.Cryptography.Providers.ICertificateProvider certificateProvider, global::Motorola.Common.Cryptography.Providers.ICertificateRemover certificateRemover, global::System.Net.IPEndPoint[] portBindings)
		{
			int a_ = 2;
			base..ctor();
			this.b = registry;
			if (registry == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("⩗㽙㭛㝝፟ᙡᙣὥ", a_));
			}
			this.d = portBindingConfiguration;
			if (portBindingConfiguration == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("⡗㕙⹛⩝≟ୡ੣ɥŧѩ୫⵭Ὧᱱታήίཹ๻ώ", a_));
			}
			this.a = certificateProvider;
			if (certificateProvider == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㭗㽙⹛⩝य़ѡൣե१ṩ५㹭ɯᵱɳήᱷό๻", a_));
			}
			this.c = certificateRemover;
			if (certificateRemover == null)
			{
				throw new global::System.ArgumentNullException();
			}
			this.e = portBindings;
			if (portBindings == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("⡗㕙⹛⩝≟ୡ੣ɥŧѩ୫ᵭ", a_));
			}
			if (!this.e.Any<global::System.Net.IPEndPoint>())
			{
				throw new global::System.ArgumentException(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("ᙗ㕙籛㱝य़ౡcཥ٧൩Ὣ乭oq᭳uᅷṹ᥻᩽", a_), global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("⡗㕙⹛⩝≟ୡ੣ɥŧѩ୫ᵭ", a_));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00004118 File Offset: 0x00002318
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000041CC File Offset: 0x000023CC
		public global::Motorola.Common.Cryptography.CertificateType SelectedCertificateType
		{
			get
			{
				short num = (short)850974065;
				short num2 = num;
				num = (short)862180721;
				switch (num2 == num)
				{
				}
				num = (short)2079326208;
				short num3 = num;
				num = (short)369950721;
				if (num != 0)
				{
				}
				num = (short)1914437632;
				if (num != 0)
				{
				}
				return this.b.SelectedCertificateTypeOrDefault();
			}
			set
			{
				short num = (short)967835649;
				if (num != 0)
				{
				}
				num = (short)1372508639;
				short num2 = num;
				num = (short)1820971487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1806696448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945160192;
				if (num != 0)
				{
				}
				global::Motorola.Common.Cryptography.Configuration.CertificateConfiguration.a a = new global::Motorola.Common.Cryptography.Configuration.CertificateConfiguration.a();
				a.a = this;
				this.b.SelectedCertificateType = new global::Motorola.Common.Cryptography.CertificateType?(value);
				a.b = this.a.SelectedCertificate;
				global::System.Threading.Tasks.Task.WaitAll(this.e.Select(new global::System.Func<global::System.Net.IPEndPoint, global::System.Threading.Tasks.Task>(a.c)).ToArray<global::System.Threading.Tasks.Task>());
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000042C4 File Offset: 0x000024C4
		public void RemoveCertificates()
		{
			short num = (short)1970662806;
			short num2 = num;
			num = (short)1944448406;
			switch (num2 == num)
			{
			}
			num = (short)1273102336;
			short num3 = num;
			num = (short)1099169793;
			if (num != 0)
			{
			}
			num = (short)878772224;
			if (num != 0)
			{
			}
			this.c.RemoveAll();
			this.b.WereSha1CertificatesRemoved = new bool?(true);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00004388 File Offset: 0x00002588
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00004440 File Offset: 0x00002640
		public bool WereSha1CertificatesRemoved
		{
			get
			{
				short num = (short)1700176180;
				short num2 = num;
				num = (short)1401594164;
				switch (num2 == num)
				{
				}
				num = (short)1105657856;
				short num3 = num;
				num = (short)999227393;
				if (num != 0)
				{
				}
				num = (short)154599424;
				if (num != 0)
				{
				}
				return this.b.WereSha1CertificatesRemovedOrDefault();
			}
			set
			{
				short num = (short)2066772199;
				short num2 = num;
				num = (short)1514959079;
				switch (num2 == num)
				{
				}
				num = (short)1198718976;
				short num3 = num;
				num = (short)2111242240;
				if (num != 0)
				{
				}
				num = (short)1828913153;
				if (num != 0)
				{
				}
				this.b.WereSha1CertificatesRemoved = new bool?(value);
			}
		}

		// Token: 0x04000011 RID: 17
		private readonly global::Motorola.Common.Cryptography.Providers.ICertificateProvider a;

		// Token: 0x04000012 RID: 18
		private readonly global::Motorola.Common.Cryptography.Configuration.Registry.IRegistryConfig b;

		// Token: 0x04000013 RID: 19
		private readonly global::Motorola.Common.Cryptography.Providers.ICertificateRemover c;

		// Token: 0x04000014 RID: 20
		private readonly global::Motorola.Common.Cryptography.Configuration.PortBinding.IPortBindingConfiguration d;

		// Token: 0x04000015 RID: 21
		private readonly global::System.Net.IPEndPoint[] e;

		// Token: 0x0200001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600003D RID: 61 RVA: 0x00004510 File Offset: 0x00002710
			internal global::System.Threading.Tasks.Task c(global::System.Net.IPEndPoint A_0)
			{
				short num = (short)1541159573;
				short num2 = num;
				num = (short)1209547413;
				switch (num2 == num)
				{
				}
				num = (short)1318715392;
				short num3 = num;
				num = (short)1975517184;
				if (num != 0)
				{
				}
				num = (short)1864957953;
				if (num != 0)
				{
				}
				return global::System.Threading.Tasks.Task.Run(new global::System.Action(new global::Motorola.Common.Cryptography.Configuration.CertificateConfiguration.b
				{
					b = this,
					a = A_0
				}.c));
			}

			// Token: 0x04000016 RID: 22
			public global::Motorola.Common.Cryptography.Configuration.CertificateConfiguration a;

			// Token: 0x04000017 RID: 23
			public global::System.Security.Cryptography.X509Certificates.X509Certificate2 b;
		}

		// Token: 0x0200001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x0600003F RID: 63 RVA: 0x000045F0 File Offset: 0x000027F0
			internal void c()
			{
				short num = (short)810024961;
				if (num != 0)
				{
				}
				num = (short)1967098075;
				short num2 = num;
				num = (short)1248889051;
				switch (num2 == num)
				{
				default:
				{
					num = (short)467337216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)386990080;
				if (num != 0)
				{
				}
				this.b.a.d.SetCertificateBinding(this.b.b, this.a);
			}

			// Token: 0x04000018 RID: 24
			public global::System.Net.IPEndPoint a;

			// Token: 0x04000019 RID: 25
			public global::Motorola.Common.Cryptography.Configuration.CertificateConfiguration.a b;
		}
	}
}
