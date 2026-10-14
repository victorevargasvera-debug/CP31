using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000015 RID: 21
	internal class TlsClientAuthentication : global::Org.BouncyCastle.Crypto.Tls.TlsAuthentication
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00005644 File Offset: 0x00003844
		public TlsClientAuthentication(global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte signatureAlgorithm)
		{
			this.b = certificate;
			this.c = privateKey;
			this.d = signatureAlgorithm;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000566C File Offset: 0x0000386C
		public void Initialize(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			short num = (short)10747905;
			if (num != 0)
			{
			}
			num = (short)11236931;
			short num2 = num;
			num = (short)558331459;
			switch (num2 == num)
			{
			default:
			{
				num = (short)438435840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1834614784;
			if (num != 0)
			{
			}
			this.a = context;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000571C File Offset: 0x0000391C
		public void NotifyServerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
		{
			short num = (short)839335048;
			short num2 = num;
			num = (short)536493192;
			switch (num2 == num)
			{
			}
			num = (short)2117271552;
			short num3 = num;
			num = (short)1896939521;
			if (num != 0)
			{
			}
			num = (short)126943232;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000057C4 File Offset: 0x000039C4
		public global::Org.BouncyCastle.Crypto.Tls.TlsCredentials GetClientCredentials(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
		{
			short num = (short)723386368;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1177944065;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 1:
				{
					num = (short)1328314066;
					short num3 = num;
					num = (short)563246802;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_AD;
					}
					break;
				}
				case 2:
					goto IL_10E;
				}
				IL_58:
				if (certificateRequest.SupportedSignatureAlgorithms == null)
				{
					num = (short)502005761;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)507117570;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_AD:
			num = (short)324927488;
			short num4 = num;
			num = (short)1570570240;
			if (num != 0)
			{
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			IL_10E:
			global::Org.BouncyCastle.Crypto.Tls.TlsCredentials tlsCredentials = this.a(certificateRequest.SupportedSignatureAlgorithms).FirstOrDefault<global::Org.BouncyCastle.Crypto.Tls.TlsCredentials>();
			if (tlsCredentials == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			return tlsCredentials;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005900 File Offset: 0x00003B00
		private global::System.Collections.Generic.IEnumerable<global::Org.BouncyCastle.Crypto.Tls.TlsCredentials> a(global::System.Collections.IList A_0)
		{
			short num = (short)913648933;
			short num2 = num;
			num = (short)948841765;
			switch (num2 == num)
			{
			}
			num = (short)1342832640;
			short num3 = num;
			num = (short)1656946688;
			if (num != 0)
			{
			}
			num = (short)947847169;
			if (num != 0)
			{
			}
			return A_0.Cast<global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm>().Where(new global::System.Func<global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm, bool>(this.b)).Select(new global::System.Func<global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm, global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSignerCredentials>(this.a));
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000059D4 File Offset: 0x00003BD4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm A_0)
		{
			short num = (short)686403593;
			short num2 = num;
			num = (short)221032457;
			switch (num2 == num)
			{
			}
			num = (short)492830720;
			short num3 = num;
			num = (short)682098689;
			if (num != 0)
			{
			}
			num = (short)1895825408;
			if (num != 0)
			{
			}
			return A_0.Signature == this.d;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005A8C File Offset: 0x00003C8C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSignerCredentials a(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm A_0)
		{
			short num = (short)121198686;
			short num2 = num;
			num = (short)1431394398;
			switch (num2 == num)
			{
			}
			num = (short)220594176;
			short num3 = num;
			num = (short)689176576;
			if (num != 0)
			{
			}
			num = (short)1409941505;
			if (num != 0)
			{
			}
			return new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSignerCredentials(this.a, this.b, this.c, A_0);
		}

		// Token: 0x04000028 RID: 40
		private global::Org.BouncyCastle.Crypto.Tls.TlsContext a;

		// Token: 0x04000029 RID: 41
		private readonly global::Org.BouncyCastle.Crypto.Tls.Certificate b;

		// Token: 0x0400002A RID: 42
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter c;

		// Token: 0x0400002B RID: 43
		private readonly byte d;
	}
}
