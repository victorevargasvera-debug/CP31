using System;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000014 RID: 20
	internal class TlsClient : global::Org.BouncyCastle.Crypto.Tls.DefaultTlsClient
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00005134 File Offset: 0x00003334
		public TlsClient(global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, int[] cipherSuites, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version)
		{
			this.b = cipherSuites;
			this.a = new global::Motorola.Common.Communication.TLS.TlsClientAuthentication(certificate, privateKey, 1);
			this.c = version;
			this.d = version;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000516C File Offset: 0x0000336C
		public override void Init(global::Org.BouncyCastle.Crypto.Tls.TlsClientContext context)
		{
			short num = (short)385392725;
			short num2 = num;
			num = (short)178888789;
			switch (num2 == num)
			{
			}
			num = (short)1733230592;
			short num3 = num;
			num = (short)933560321;
			if (num != 0)
			{
			}
			num = (short)1439105024;
			if (num != 0)
			{
			}
			base.Init(context);
			this.a.Initialize(this.mContext);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000522C File Offset: 0x0000342C
		public override void NotifySecureRenegotiation(bool secureRenegotiation)
		{
			short num = (short)266912119;
			short num2 = num;
			num = (short)180666743;
			switch (num2 == num)
			{
			}
			num = (short)1878261760;
			short num3 = num;
			num = (short)1110769665;
			if (num != 0)
			{
			}
			num = (short)742916096;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000052D8 File Offset: 0x000034D8
		public override global::Org.BouncyCastle.Crypto.Tls.TlsAuthentication GetAuthentication()
		{
			short num = (short)388572643;
			short num2 = num;
			num = (short)1908352483;
			switch (num2 == num)
			{
			}
			num = (short)1136066560;
			short num3 = num;
			num = (short)1325858816;
			if (num != 0)
			{
			}
			num = (short)1527382017;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005388 File Offset: 0x00003588
		public override int[] GetCipherSuites()
		{
			short num = (short)518491528;
			short num2 = num;
			num = (short)1910476168;
			switch (num2 == num)
			{
			}
			num = (short)351404032;
			short num3 = num;
			num = (short)675151873;
			if (num != 0)
			{
			}
			num = (short)1543307264;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00005438 File Offset: 0x00003638
		public override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)654455753;
				short num2 = num;
				num = (short)800142281;
				switch (num2 == num)
				{
				}
				num = (short)119275520;
				short num3 = num;
				num = (short)1079246848;
				if (num != 0)
				{
				}
				num = (short)380829697;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000054E4 File Offset: 0x000036E4
		public override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion MinimumVersion
		{
			get
			{
				short num = (short)1145796487;
				short num2 = num;
				num = (short)1538488199;
				switch (num2 == num)
				{
				}
				num = (short)534183936;
				short num3 = num;
				num = (short)220266497;
				if (num != 0)
				{
				}
				num = (short)332398592;
				if (num != 0)
				{
				}
				return this.ClientVersion;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00005594 File Offset: 0x00003794
		public override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientHelloRecordLayerVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)82064028;
				short num2 = num;
				num = (short)6959772;
				switch (num2 == num)
				{
				}
				num = (short)415105024;
				short num3 = num;
				num = (short)1391656961;
				if (num != 0)
				{
				}
				num = (short)1928003584;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x04000024 RID: 36
		private readonly global::Motorola.Common.Communication.TLS.TlsClientAuthentication a;

		// Token: 0x04000025 RID: 37
		private readonly int[] b;

		// Token: 0x04000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion c;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion d;
	}
}
