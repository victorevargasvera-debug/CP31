using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO.Pem;
using Org.BouncyCastle.X509;

namespace SSLMangrComp
{
	// Token: 0x02000006 RID: 6
	public static class CertificateLoader
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002140 File Offset: 0x00000340
		public static global::System.Security.Cryptography.X509Certificates.X509Certificate2 LoadCertificate(string certificateFilePath)
		{
			global::System.IO.FileStream fileStream = global::System.IO.File.Open(certificateFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
			global::System.Security.Cryptography.X509Certificates.X509Certificate2 result;
			short num;
			try
			{
				result = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(global::Org.BouncyCastle.Security.DotNetUtilities.ToX509Certificate(global::SSLMangrComp.CertificateLoader.a(fileStream).GetCertificateAt(0)));
			}
			finally
			{
				for (;;)
				{
					num = (short)384499714;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)1044971521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_B2;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_57;
							}
							continue;
						}
						IL_57:
						num = (short)736493569;
						if (num != 0)
						{
						}
						if (fileStream == null)
						{
							goto IL_FD;
						}
						num = (short)286588928;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_B2:
					num = (short)1773438423;
					short num3 = num;
					num = (short)1065321943;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_E6;
					}
				}
				IL_E6:
				num = (short)355205120;
				if (num != 0)
				{
				}
				IL_FD:;
			}
			num = (short)1404174336;
			short num4 = num;
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002288 File Offset: 0x00000488
		public static global::System.Security.Cryptography.X509Certificates.X509Certificate2 LoadCertificate(byte[] rawCertificateData)
		{
			short num = (short)1013035892;
			short num2 = num;
			num = (short)289780596;
			switch (num2 == num)
			{
			}
			num = (short)1316683776;
			if (num != 0)
			{
			}
			num = (short)614072320;
			short num3 = num;
			num = (short)1930493953;
			if (num != 0)
			{
			}
			return new global::System.Security.Cryptography.X509Certificates.X509Certificate2(global::Org.BouncyCastle.Security.DotNetUtilities.ToX509Certificate(global::SSLMangrComp.CertificateLoader.LoadBcCertificate(rawCertificateData).GetCertificateAt(0)));
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002348 File Offset: 0x00000548
		public static global::System.Security.Cryptography.X509Certificates.X509Certificate2 LoadPfxCertificate(string certificateFilePath, string certificatePassword)
		{
			short num = (short)1619242173;
			short num2 = num;
			num = (short)1015262397;
			switch (num2 == num)
			{
			}
			num = (short)1808859136;
			if (num != 0)
			{
			}
			num = (short)287899648;
			short num3 = num;
			num = (short)1827536897;
			if (num != 0)
			{
			}
			return global::SSLMangrComp.CertificateLoader.LoadPfxCertificate(global::System.IO.File.ReadAllBytes(certificateFilePath), certificatePassword);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023FC File Offset: 0x000005FC
		public static global::System.Security.Cryptography.X509Certificates.X509Certificate2 LoadPfxCertificate(byte[] rawCertificateData, string certificatePassword)
		{
			short num = (short)727403109;
			short num2 = num;
			num = (short)1613777509;
			switch (num2 == num)
			{
			}
			num = (short)986251265;
			if (num != 0)
			{
			}
			num = (short)1828978688;
			short num3 = num;
			num = (short)43974656;
			if (num != 0)
			{
			}
			global::Org.BouncyCastle.Crypto.Tls.Certificate certificate;
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter asymmetricKeyParameter;
			global::SSLMangrComp.CertificateLoader.LoadPfxCertificate(rawCertificateData, new global::SSLMangrComp.b(certificatePassword), out certificate, out asymmetricKeyParameter);
			global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate = new global::System.Security.Cryptography.X509Certificates.X509Certificate2(global::Org.BouncyCastle.Security.DotNetUtilities.ToX509Certificate(certificate.GetCertificateAt(0)));
			global::System.Security.Cryptography.RSA privateKey = global::Org.BouncyCastle.Security.DotNetUtilities.ToRSA(asymmetricKeyParameter as global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters);
			x509Certificate.PrivateKey = privateKey;
			return x509Certificate;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000024DC File Offset: 0x000006DC
		public static global::Org.BouncyCastle.OpenSsl.IPasswordFinder ToPasswordFinder(string password)
		{
			short num = (short)1170850980;
			short num2 = num;
			num = (short)1111934116;
			switch (num2 == num)
			{
			}
			num = (short)740098049;
			if (num != 0)
			{
			}
			num = (short)1869021184;
			short num3 = num;
			num = (short)1321664512;
			if (num != 0)
			{
			}
			return new global::SSLMangrComp.b(password);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000258C File Offset: 0x0000078C
		public static global::Org.BouncyCastle.Crypto.Parameters.DHParameters LoadDhParams(byte[] rawBytes)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(rawBytes);
			global::Org.BouncyCastle.Crypto.Parameters.DHParameters result;
			short num;
			try
			{
				global::Org.BouncyCastle.Asn1.Pkcs.DHParameter dhparameter = new global::Org.BouncyCastle.Asn1.Pkcs.DHParameter(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(new global::Org.BouncyCastle.Utilities.IO.Pem.PemReader(new global::System.IO.StreamReader(memoryStream)).ReadPemObject().Content));
				result = new global::Org.BouncyCastle.Crypto.Parameters.DHParameters(dhparameter.P, dhparameter.G);
			}
			finally
			{
				for (;;)
				{
					num = (short)716570626;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)1124204545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_A4;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_71;
							}
							continue;
						}
						IL_71:
						if (memoryStream == null)
						{
							goto IL_F0;
						}
						num = (short)2032271360;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_A4:
					num = (short)1078768219;
					short num3 = num;
					num = (short)400798299;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_D9;
					}
				}
				IL_D9:
				num = (short)1702428672;
				if (num != 0)
				{
				}
				IL_F0:;
			}
			num = (short)1787822080;
			short num4 = num;
			num = (short)1559822337;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000026F0 File Offset: 0x000008F0
		public static global::Org.BouncyCastle.Crypto.Tls.Certificate LoadBcCertificate(byte[] certBytes)
		{
			short num = (short)1404698625;
			if (num != 0)
			{
			}
			num = (short)1851064320;
			short num2 = num;
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(certBytes);
			global::Org.BouncyCastle.Crypto.Tls.Certificate result;
			try
			{
				result = global::SSLMangrComp.CertificateLoader.a(memoryStream);
			}
			finally
			{
				for (;;)
				{
					num = (short)1507065858;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)2082930689;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_CF;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_96;
							}
							continue;
						}
						IL_96:
						if (memoryStream == null)
						{
							goto IL_11B;
						}
						num = (short)1189347328;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_CF:
					num = (short)752176927;
					short num4 = num;
					num = (short)2063421215;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_104;
					}
				}
				IL_104:
				num = (short)1881997312;
				if (num != 0)
				{
				}
				IL_11B:;
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000282C File Offset: 0x00000A2C
		public static void LoadPfxCertificate(byte[] certBytes, global::Org.BouncyCastle.OpenSsl.IPasswordFinder password, out global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate, out global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter asymmetricKeyParameter)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(certBytes);
			short num;
			try
			{
				global::SSLMangrComp.CertificateLoader.a(memoryStream, password, out serverCertificate, out asymmetricKeyParameter);
			}
			finally
			{
				for (;;)
				{
					num = (short)806354946;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)1249116161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_7D;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_49;
							}
							continue;
						}
						IL_49:
						if (memoryStream == null)
						{
							goto IL_C9;
						}
						num = (short)57802752;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_7D:
					num = (short)709647737;
					short num3 = num;
					num = (short)1195531641;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_B2;
					}
				}
				IL_B2:
				num = (short)1555038208;
				if (num != 0)
				{
				}
				IL_C9:;
			}
			num = (short)473038848;
			short num4 = num;
			num = (short)1368064001;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002964 File Offset: 0x00000B64
		private static void a(global::System.IO.Stream A_0, global::Org.BouncyCastle.OpenSsl.IPasswordFinder A_1, out global::Org.BouncyCastle.Crypto.Tls.Certificate A_2, out global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter A_3)
		{
			short num = (short)394233400;
			short num2 = num;
			num = (short)1443071544;
			switch (num2 == num)
			{
			}
			num = (short)1453457408;
			if (num != 0)
			{
			}
			num = (short)960036864;
			short num3 = num;
			num = (short)1634402305;
			if (num != 0)
			{
			}
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

		// Token: 0x0600000D RID: 13 RVA: 0x00002A68 File Offset: 0x00000C68
		public static void LoadCertificate(string certFile, global::Org.BouncyCastle.OpenSsl.IPasswordFinder password, string privateKeyFile, out global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate, out global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter asymmetricKeyParameter)
		{
			global::System.IO.FileStream fileStream = global::System.IO.File.Open(certFile, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
			try
			{
				serverCertificate = global::SSLMangrComp.CertificateLoader.a(fileStream);
				goto IL_F5;
			}
			finally
			{
				short num = (short)1656553474;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						((global::System.IDisposable)fileStream).Dispose();
						num = (short)1457848321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_19D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_168;
						}
						continue;
					}
					IL_168:
					if (fileStream == null)
					{
						break;
					}
					num = (short)691208192;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19D:;
			}
			return;
			for (;;)
			{
				IL_F5:
				short num = (short)1275658240;
				short num3 = num;
				global::System.IO.FileStream fileStream2 = global::System.IO.File.Open(privateKeyFile, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					num = (short)476971009;
					if (num != 0)
					{
					}
					asymmetricKeyParameter = global::SSLMangrComp.CertificateLoader.a(fileStream2, password);
					break;
				}
				finally
				{
					for (;;)
					{
						num = (short)1213136898;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)fileStream2).Dispose();
								num = (short)1298202625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_A7;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_74;
								}
								continue;
							}
							IL_74:
							if (fileStream2 == null)
							{
								goto IL_F4;
							}
							num = (short)662372352;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_A7:
						num = (short)114699246;
						short num4 = num;
						num = (short)626469870;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_DD;
						}
					}
					IL_DD:
					num = (short)2056519680;
					if (num != 0)
					{
					}
					IL_F4:;
				}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002C34 File Offset: 0x00000E34
		private static global::Org.BouncyCastle.Crypto.Tls.Certificate a(global::System.IO.Stream A_0)
		{
			try
			{
				global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure instance = global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Sequence)new global::Org.BouncyCastle.Asn1.Asn1InputStream(A_0).ReadObject());
				global::Org.BouncyCastle.Crypto.Tls.Certificate result = new global::Org.BouncyCastle.Crypto.Tls.Certificate(new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[]
				{
					instance
				});
				goto IL_87;
			}
			catch (global::System.Exception)
			{
			}
			IL_2B:
			short num = (short)365297664;
			short num2 = num;
			A_0.Position = 0L;
			global::Org.BouncyCastle.X509.X509Certificate x509Certificate = new global::Org.BouncyCastle.OpenSsl.PemReader(new global::System.IO.StreamReader(A_0)).ReadObject() as global::Org.BouncyCastle.X509.X509Certificate;
			return new global::Org.BouncyCastle.Crypto.Tls.Certificate(new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure[]
			{
				x509Certificate.CertificateStructure
			});
			IL_87:
			num = (short)1374290530;
			short num3 = num;
			num = (short)1495073378;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_2B;
			default:
			{
				num = (short)1578762241;
				if (num != 0)
				{
				}
				num = (short)1286995968;
				if (num != 0)
				{
				}
				global::Org.BouncyCastle.Crypto.Tls.Certificate result;
				return result;
			}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002D4C File Offset: 0x00000F4C
		private static global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter a(global::System.IO.Stream A_0, global::Org.BouncyCastle.OpenSsl.IPasswordFinder A_1)
		{
			short num = (short)687626088;
			short num2 = num;
			num = (short)1720866664;
			switch (num2 == num)
			{
			}
			num = (short)1467678720;
			if (num != 0)
			{
			}
			num = (short)1700331520;
			short num3 = num;
			num = (short)76414977;
			if (num != 0)
			{
			}
			return new global::Org.BouncyCastle.OpenSsl.PemReader(new global::System.IO.StreamReader(A_0), A_1).ReadObject() as global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter;
		}
	}
}
