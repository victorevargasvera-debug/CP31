using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000009 RID: 9
	internal static class CertificateUtilities
	{
		// Token: 0x06000020 RID: 32 RVA: 0x0000338C File Offset: 0x0000158C
		public static void LoadPfxCertificateFile(string filePath, global::Org.BouncyCastle.OpenSsl.IPasswordFinder password, out global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate, out global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter asymmetricKeyParameter)
		{
			short num = (short)1185432189;
			short num2 = num;
			num = (short)2094809725;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1547894785;
				if (num != 0)
				{
				}
				num = (short)2111963136;
				if (num != 0)
				{
				}
				global::System.IO.FileStream fileStream = global::System.IO.File.Open(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					global::Motorola.Common.Communication.TLS.CertificateUtilities.a(fileStream, password, out serverCertificate, out asymmetricKeyParameter);
				}
				finally
				{
					num = (short)996868097;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_EE;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_B9;
							}
							continue;
						case 2:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)1252786176;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_B9:
						if (fileStream == null)
						{
							break;
						}
						num = (short)1920991234;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_EE:;
				}
				break;
			}
			}
			num = (short)130678784;
			short num4 = num;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000034C4 File Offset: 0x000016C4
		private static void a(global::System.IO.Stream A_0, global::Org.BouncyCastle.OpenSsl.IPasswordFinder A_1, out global::Org.BouncyCastle.Crypto.Tls.Certificate A_2, out global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter A_3)
		{
			short num = (short)1632175553;
			short num2 = num;
			num = (short)1989543361;
			switch (num2 == num)
			{
			}
			num = (short)1568997376;
			if (num != 0)
			{
			}
			num = (short)2033713153;
			if (num != 0)
			{
			}
			num = (short)133824512;
			short num3 = num;
			char[] password = A_1.GetPassword();
			global::Org.BouncyCastle.Pkcs.Pkcs12Store pkcs12Store = new global::Org.BouncyCastle.Pkcs.Pkcs12Store(A_0, password);
			global::System.Collections.IEnumerator enumerator = pkcs12Store.Aliases.GetEnumerator();
			enumerator.MoveNext();
			string alias = enumerator.Current as string;
			A_2 = new global::Org.BouncyCastle.Crypto.Tls.Certificate(new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[]
			{
				pkcs12Store.GetCertificate(alias).Certificate.CertificateStructure
			});
			A_3 = pkcs12Store.GetKey(alias).Key;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000035C8 File Offset: 0x000017C8
		public static void LoadCertificate(string certFile, global::Org.BouncyCastle.OpenSsl.IPasswordFinder password, string privateKeyFile, out global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate, out global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter asymmetricKeyParameter)
		{
			global::System.IO.FileStream fileStream = global::System.IO.File.Open(certFile, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
			short num;
			try
			{
				serverCertificate = global::Motorola.Common.Communication.TLS.CertificateUtilities.a(fileStream);
				goto IL_85;
			}
			finally
			{
				num = (short)347602945;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_17D;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_CF;
						}
						continue;
					case 2:
						((global::System.IDisposable)fileStream).Dispose();
						num = (short)231276545;
						if (num != 0)
						{
						}
						num = (short)451018752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CF:
					if (fileStream == null)
					{
						break;
					}
					num = (short)1756271206;
					short num3 = num;
					num = (short)49386086;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1723858944;
						if (num != 0)
						{
						}
						num = (short)398393346;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_17D:;
			}
			goto IL_180;
			for (;;)
			{
				IL_85:
				global::System.IO.FileStream fileStream2 = global::System.IO.File.Open(privateKeyFile, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					asymmetricKeyParameter = global::Motorola.Common.Communication.TLS.CertificateUtilities.a(fileStream2, password);
					break;
				}
				finally
				{
					num = (short)1894776833;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_82;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_4E;
							}
							continue;
						case 2:
							((global::System.IDisposable)fileStream2).Dispose();
							num = (short)979566592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_4E:
						if (fileStream2 == null)
						{
							break;
						}
						num = (short)1398472706;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_82:;
				}
			}
			IL_180:
			num = (short)600047616;
			short num4 = num;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000379C File Offset: 0x0000199C
		private static global::Org.BouncyCastle.Crypto.Tls.Certificate a(global::System.IO.Stream A_0)
		{
			short num = (short)251196795;
			short num2 = num;
			num = (short)496760187;
			switch (num2 == num)
			{
			}
			num = (short)1556938753;
			if (num != 0)
			{
			}
			num = (short)507248640;
			if (num != 0)
			{
			}
			num = (short)382205952;
			short num3 = num;
			global::Org.BouncyCastle.X509.X509Certificate x509Certificate = new global::Org.BouncyCastle.OpenSsl.PemReader(new global::System.IO.StreamReader(A_0)).ReadObject() as global::Org.BouncyCastle.X509.X509Certificate;
			return new global::Org.BouncyCastle.Crypto.Tls.Certificate(new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[]
			{
				x509Certificate.CertificateStructure
			});
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003870 File Offset: 0x00001A70
		private static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter a(global::System.IO.Stream A_0, global::Org.BouncyCastle.OpenSsl.IPasswordFinder A_1)
		{
			short num = (short)83551896;
			short num2 = num;
			num = (short)11527832;
			switch (num2 == num)
			{
			}
			num = (short)2063728641;
			if (num != 0)
			{
			}
			num = (short)875495424;
			if (num != 0)
			{
			}
			num = (short)985726976;
			short num3 = num;
			return new global::Org.BouncyCastle.OpenSsl.PemReader(new global::System.IO.StreamReader(A_0), A_1).ReadObject() as global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000392C File Offset: 0x00001B2C
		public static global::System.Security.Cryptography.X509Certificates.X509Certificate ToX509Certificate(this global::Org.BouncyCastle.Crypto.Tls.Certificate certificate)
		{
			short num = (short)1995810898;
			short num2 = num;
			num = (short)1979230290;
			switch (num2 == num)
			{
			}
			num = (short)94633984;
			if (num != 0)
			{
			}
			num = (short)1453129729;
			if (num != 0)
			{
			}
			num = (short)1749549056;
			short num3 = num;
			return global::Org.BouncyCastle.Security.DotNetUtilities.ToX509Certificate(certificate.GetCertificateAt(0));
		}
	}
}
