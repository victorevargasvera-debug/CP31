using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Security;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x0200001D RID: 29
	internal class TransportLayerSecurityBouncyCastleAdapter : global::Motorola.Common.Communication.TLS.ITransportLayerSecurity
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000081B0 File Offset: 0x000063B0
		public TransportLayerSecurityBouncyCastleAdapter(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe pipe)
		{
			this.a = pipe;
			this.c = global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv10;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000081D8 File Offset: 0x000063D8
		public void Initialize(global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> cert)
		{
			short num;
			try
			{
				num = (short)585170945;
				if (num != 0)
				{
				}
				num = (short)1969161499;
				short num2 = num;
				num = (short)668861723;
				switch (num2 == num)
				{
				}
				num = (short)523304960;
				if (num != 0)
				{
				}
				this.b = cert;
				this.d = global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(this.a(), this.a);
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Initialize_Failed);
			}
			num = (short)1249705984;
			short num3 = num;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000082BC File Offset: 0x000064BC
		public void Connect(int secMode)
		{
			short num = (short)1493958657;
			if (num != 0)
			{
			}
			if (this.d is global::Motorola.Common.Communication.TLS.TlsClientProtocol)
			{
				num = (short)1757478912;
				short num2 = num;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					global::Motorola.Common.Communication.TLS.TlsClientProtocol tlsClientProtocol;
					for (;;)
					{
						IL_6F:
						int num3;
						switch (num3)
						{
						case 0:
							goto IL_146;
						case 1:
							goto IL_15E;
						case 2:
							goto IL_146;
						case 3:
							tlsClientProtocol = (this.d as global::Motorola.Common.Communication.TLS.TlsClientProtocol);
							if (tlsClientProtocol == null)
							{
								num = (short)888733698;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10B;
						}
						goto IL_85;
						IL_146:
						num = (short)1138229249;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_10B:
					global::Org.BouncyCastle.Crypto.Tls.TlsClient tlsClient;
					tlsClientProtocol.Connect(tlsClient);
					goto IL_111;
					IL_15E:
					return;
					IL_85:
					tlsClient = global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(this.c, this.a(), secMode);
					num = (short)1745647651;
					short num4 = num;
					num = (short)753367075;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_111:
						num = (short)1652817920;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_6F;
					}
					default:
					{
						num = (short)376700928;
						if (num != 0)
						{
						}
						num = (short)1224998915;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_6F;
					}
					}
				}
				catch (global::Org.BouncyCastle.Crypto.Tls.TlsException ex)
				{
					throw this.SecurityExceptionHandler(ex);
				}
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00008444 File Offset: 0x00006644
		public void Accept(int secMode, global::System.Action<global::System.Security.Cryptography.X509Certificates.X509Certificate> validateClientCertificate = null)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsServer tlsServer;
			for (;;)
			{
				IL_00:
				short num = (short)1398538242;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_129;
					case 1:
					{
						num = (short)893806024;
						short num3 = num;
						num = (short)1396467144;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1052508160;
							short num4 = num;
							num = (short)205717504;
							if (num != 0)
							{
							}
							tlsServer = global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(this.c, this.a(), secMode, new global::Motorola.Common.Communication.TLS.TlsCipherFactory(this.e), validateClientCertificate);
							num = (short)353828864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					}
					IL_32:
					if (!(this.d is global::Motorola.Common.Communication.TLS.TlsServerProtocol))
					{
						goto IL_142;
					}
					num = (short)1080885249;
					if (num != 0)
					{
					}
					num = (short)1461321729;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_129:
			global::Motorola.Common.Communication.TLS.TlsServerProtocol tlsServerProtocol = this.d as global::Motorola.Common.Communication.TLS.TlsServerProtocol;
			if (tlsServerProtocol == null)
			{
				return;
			}
			tlsServerProtocol.Accept(tlsServer);
			return;
			IL_142:
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008598 File Offset: 0x00006798
		public int SendData(byte[] buffer, int len)
		{
			short num;
			try
			{
				num = (short)2002843287;
				short num2 = num;
				num = (short)1038546583;
				switch (num2 == num)
				{
				}
				num = (short)1151467520;
				if (num != 0)
				{
				}
				this.d.Stream.Write(buffer, 0, len);
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Send_Failed);
			}
			num = (short)1926889472;
			short num3 = num;
			num = (short)208601089;
			if (num != 0)
			{
			}
			return len;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00008678 File Offset: 0x00006878
		public int ReceiveData(byte[] buffer, int len)
		{
			short num;
			int result;
			try
			{
				num = (short)1832759892;
				short num2 = num;
				num = (short)75805268;
				switch (num2 == num)
				{
				}
				num = (short)599130112;
				if (num != 0)
				{
				}
				result = this.d.Stream.Read(buffer, 0, len);
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Receive_Failed);
			}
			num = (short)1112080384;
			short num3 = num;
			num = (short)1561591809;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00008754 File Offset: 0x00006954
		public void Uninitialize()
		{
			short num;
			try
			{
				num = (short)1129573964;
				short num2 = num;
				num = (short)1022291532;
				switch (num2 == num)
				{
				}
				num = (short)2023882753;
				if (num != 0)
				{
				}
				num = (short)1457586176;
				if (num != 0)
				{
				}
				this.d.Close();
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Uninitialize);
			}
			num = (short)752287744;
			short num3 = num;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008828 File Offset: 0x00006A28
		public void SetProtocolVersion(global::Motorola.Common.Communication.TLS.TlsProtocolVersion tlsProtocolVersion, bool enableOpenSslCompatibilityMode = false)
		{
			short num = (short)1997604571;
			short num2 = num;
			num = (short)1968703195;
			switch (num2 == num)
			{
			}
			num = (short)114229248;
			if (num != 0)
			{
			}
			num = (short)2050097153;
			if (num != 0)
			{
			}
			num = (short)500432896;
			short num3 = num;
			this.c = global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.ConvertProtocolVersion(tlsProtocolVersion);
			this.e = enableOpenSslCompatibilityMode;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000088EC File Offset: 0x00006AEC
		private static global::Org.BouncyCastle.Crypto.Tls.TlsServer a(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion A_0, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> A_1, int A_2, global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory A_3, global::System.Action<global::System.Security.Cryptography.X509Certificates.X509Certificate> A_4 = null)
		{
			short num = (short)762555077;
			short num2 = num;
			num = (short)421178053;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_141:
				num = (short)470810624;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)445579264;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				break;
			}
			for (;;)
			{
				IL_54:
				num = (short)2038235137;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					num = (short)111214593;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_122;
				case 2:
					if (A_2 != 4)
					{
						num = (short)829947907;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F8;
				case 3:
					num = (short)1720975364;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_13C;
				}
				goto IL_94;
			}
			IL_F8:
			int[] a_;
			return global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(A_0, global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.GetCertificateBasedAuthMaterial(ref A_1), a_, A_3, A_4);
			IL_122:
			throw new global::System.NotImplementedException();
			IL_13C:
			if (A_2 != 16)
			{
				goto IL_141;
			}
			return global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(A_0, A_1, a_, A_3, A_4);
			IL_94:
			a_ = global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.ConvertCipherSuite(A_2);
			num = (short)1818230784;
			short num4 = num;
			num = (short)437256194;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00008A68 File Offset: 0x00006C68
		private static global::Org.BouncyCastle.Crypto.Tls.TlsServer a(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion A_0, global::Motorola.Common.Communication.TLS.AuthenticationMaterials A_1, int[] A_2, global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory A_3, global::System.Action<global::System.Security.Cryptography.X509Certificates.X509Certificate> A_4 = null)
		{
			short num = (short)1077739521;
			if (num != 0)
			{
			}
			num = (short)84700652;
			short num2 = num;
			num = (short)2051763692;
			switch (num2 == num)
			{
			}
			num = (short)1078788096;
			if (num != 0)
			{
			}
			num = (short)195297280;
			short num3 = num;
			global::Org.BouncyCastle.Crypto.Tls.Certificate certificate;
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey;
			global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(ref A_1, out certificate, out privateKey);
			return new global::Motorola.Common.Communication.TLS.TlsServer(certificate, privateKey, A_2, A_0, A_3)
			{
				NotifyClientVersionAction = A_4
			};
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008B2C File Offset: 0x00006D2C
		private static global::Org.BouncyCastle.Crypto.Tls.TlsServer a(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion A_0, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> A_1, int[] A_2, global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory A_3, global::System.Action<global::System.Security.Cryptography.X509Certificates.X509Certificate> A_4 = null)
		{
			short num = (short)1805647872;
			short num2 = num;
			num = (short)105012898;
			short num3 = num;
			num = (short)1959878306;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_105:
				num = (short)459931648;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)770310144;
				if (num != 0)
				{
				}
				num = (short)49676288;
				num4 = (int)num;
				switch (num4)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_B3;
					}
					break;
				}
				break;
			}
			for (;;)
			{
				IL_A0:
				switch (num4)
				{
				case 0:
					goto IL_11B;
				case 1:
					if (global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.PskExists(ref A_1))
					{
						num = (short)1515257858;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
				case 2:
					goto IL_FC;
				}
				goto IL_B3;
			}
			IL_FC:
			global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager pskIdentityManager = new global::Motorola.Common.Communication.TLS.TlsAdvPskIdentityManager(A_1);
			goto IL_105;
			IL_11B:
			num = (short)805437441;
			if (num != 0)
			{
			}
			IL_144:
			global::Org.BouncyCastle.Crypto.Tls.Certificate certificate;
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey;
			return new global::Motorola.Common.Communication.TLS.TlsRsaPskServer(pskIdentityManager, certificate, privateKey, A_2, A_0, A_3)
			{
				NotifyClientVersionAction = A_4
			};
			IL_B3:
			pskIdentityManager = null;
			global::Motorola.Common.Communication.TLS.AuthenticationMaterials certificateBasedAuthMaterial = global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.GetCertificateBasedAuthMaterial(ref A_1);
			global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(ref certificateBasedAuthMaterial, out certificate, out privateKey);
			num = (short)1128595457;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A0;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00008C90 File Offset: 0x00006E90
		private static void a(ref global::Motorola.Common.Communication.TLS.AuthenticationMaterials A_0, out global::Org.BouncyCastle.Crypto.Tls.Certificate A_1, out global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				string @string;
				global::Motorola.Common.Communication.TLS.Password password;
				switch (num)
				{
				case 0:
					goto IL_81;
				case 1:
					goto IL_13F;
				case 2:
					try
					{
						global::Motorola.Common.Communication.TLS.CertificateUtilities.LoadPfxCertificateFile(@string, password, out A_1, out A_2);
						return;
					}
					finally
					{
						num2 = (short)1093009408;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_107;
								}
								continue;
							case 1:
								((global::System.IDisposable)password).Dispose();
								num2 = (short)500563970;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_13C;
							}
							IL_107:
							if (password == null)
							{
								break;
							}
							num2 = (short)2059010049;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_13C:;
					}
					goto IL_13F;
				}
				goto IL_1C;
				IL_13F:
				@string = global::System.Text.Encoding.ASCII.GetString(A_0.CERT_FILE, 0, A_0.CERT_FILE_LEN);
				password = new global::Motorola.Common.Communication.TLS.Password(global::System.Text.Encoding.ASCII.GetChars(A_0.CERT_PSWD, 0, A_0.CERT_PSWD_LEN));
				num2 = (short)987168768;
				short num3 = num2;
				num2 = (short)563347458;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_81:
			num2 = (short)1996161025;
			if (num2 != 0)
			{
			}
			if (A_0 != null)
			{
				goto IL_B0;
			}
			throw new global::System.ArgumentException();
			IL_1C:
			num2 = (short)1345742114;
			short num4 = num2;
			num2 = (short)396387618;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B0:
				num2 = (short)1355743233;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)809369600;
				if (num2 != 0)
				{
				}
				A_1 = null;
				A_2 = null;
				num2 = (short)829292544;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00008E70 File Offset: 0x00007070
		private static global::Org.BouncyCastle.Crypto.Tls.TlsClient a(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion A_0, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> A_1, int A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					switch (A_2)
					{
					case 1:
					case 2:
					case 3:
						goto IL_BA;
					case 4:
						goto IL_AB;
					case 5:
					case 6:
					case 7:
						goto IL_195;
					case 8:
						goto IL_173;
					}
					goto IL_69;
				case 1:
					if (A_2 != 16)
					{
						num2 = (short)1662582787;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_173;
				case 2:
				{
					num2 = (short)1530789888;
					short num3 = num2;
					num2 = (short)1649672193;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					num2 = (short)1144061363;
					short num4 = num2;
					num2 = (short)252902835;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
						num2 = (short)1386348544;
						if (num2 != 0)
						{
						}
						num2 = (short)1675886596;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_193;
				}
				goto IL_24;
				IL_69:
				num2 = (short)2059534337;
				if (num2 != 0)
				{
				}
				num2 = (short)2092695554;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_AB:
			int[] a_;
			return global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.b(A_0, global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.GetCertificateBasedAuthMaterial(ref A_1), a_);
			IL_BA:
			return global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(A_0, global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.GetPskBasedAuthMaterial(ref A_1), a_);
			IL_173:
			return global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(A_0, A_1, a_);
			IL_193:
			IL_195:
			throw new global::System.ArgumentException();
			IL_24:
			a_ = global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.ConvertCipherSuite(A_2);
			num2 = (short)771948544;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00009018 File Offset: 0x00007218
		private static global::Motorola.Common.Communication.TLS.TlsClient b(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion A_0, global::Motorola.Common.Communication.TLS.AuthenticationMaterials A_1, int[] A_2)
		{
			short num = (short)357503280;
			short num2 = num;
			num = (short)103682352;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B8;
			case 1:
				break;
			default:
			{
				num = (short)27852800;
				short num3 = num;
				break;
			}
			}
			num = (short)1712128001;
			if (num != 0)
			{
			}
			num = (short)32964608;
			if (num != 0)
			{
			}
			num = (short)1777926144;
			switch (num)
			{
			default:
			{
				IL_B8:
				string certificate_FILE = A_1.CERTIFICATE_FILE;
				string public_KEY = A_1.PUBLIC_KEY;
				global::Motorola.Common.Communication.TLS.Password password = new global::Motorola.Common.Communication.TLS.Password(A_1.PASSWORD);
				global::Org.BouncyCastle.Crypto.Tls.Certificate certificate;
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey;
				try
				{
					global::Motorola.Common.Communication.TLS.CertificateUtilities.LoadCertificate(certificate_FILE, password, public_KEY, out certificate, out privateKey);
				}
				finally
				{
					num = (short)881917952;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_118;
							}
							continue;
						case 1:
							((global::System.IDisposable)password).Dispose();
							num = (short)1631518722;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_150;
						}
						IL_118:
						if (password == null)
						{
							break;
						}
						num = (short)1686700033;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_150:;
				}
				return new global::Motorola.Common.Communication.TLS.TlsClient(certificate, privateKey, A_2, A_0);
			}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00009194 File Offset: 0x00007394
		private static global::Motorola.Common.Communication.TLS.TlsPskClient a(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion A_0, global::Motorola.Common.Communication.TLS.AuthenticationMaterials A_1, int[] A_2)
		{
			short num = (short)1811152896;
			short num2 = num;
			num = (short)590699893;
			short num3 = num;
			num = (short)636181877;
			switch (num3 == num)
			{
			}
			num = (short)319946753;
			if (num != 0)
			{
			}
			num = (short)1858142208;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.TLS.TlsPskClient(new global::Org.BouncyCastle.Crypto.Tls.BasicTlsPskIdentity(A_1.PSK_ID, A_1.PSK_VALUE), A_2, A_0);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009258 File Offset: 0x00007458
		private static global::Motorola.Common.Communication.TLS.TlsRsaPskClient a(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion A_0, global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> A_1, int[] A_2)
		{
			short num = (short)203620352;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)364052481;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				global::Org.BouncyCastle.Crypto.Tls.Certificate certificate;
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey;
				global::Motorola.Common.Communication.TLS.AuthenticationMaterials certificateBasedAuthMaterial;
				for (;;)
				{
					IL_50:
					num = (short)1215767025;
					short num3 = num;
					num = (short)1402610161;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1457192960;
						if (num != 0)
						{
						}
						string certificate_FILE;
						global::Motorola.Common.Communication.TLS.Password password;
						string public_KEY;
						switch (num2)
						{
						case 0:
							goto IL_D0;
						case 1:
							goto IL_177;
						case 2:
							try
							{
								global::Motorola.Common.Communication.TLS.CertificateUtilities.LoadCertificate(certificate_FILE, password, public_KEY, out certificate, out privateKey);
								goto IL_1DA;
							}
							finally
							{
								num = (short)1554317312;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_13A;
										}
										continue;
									case 1:
										((global::System.IDisposable)password).Dispose();
										num = (short)1014824962;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_174;
									}
									IL_13A:
									if (password == null)
									{
										break;
									}
									num = (short)1861156865;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_174:;
							}
							goto IL_177;
						}
						goto IL_AF;
						IL_177:
						num = (short)1909260288;
						short num4 = num;
						certificate_FILE = certificateBasedAuthMaterial.CERTIFICATE_FILE;
						public_KEY = certificateBasedAuthMaterial.PUBLIC_KEY;
						password = new global::Motorola.Common.Communication.TLS.Password(certificateBasedAuthMaterial.PASSWORD);
						num = (short)1588658178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_D0:
					if (certificateBasedAuthMaterial == null)
					{
						break;
					}
					num = (short)26476545;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DA:
				return new global::Motorola.Common.Communication.TLS.TlsRsaPskClient(new global::Motorola.Common.Communication.TLS.TlsAdvPskIdentity(A_1), certificate, privateKey, A_2, A_0);
				IL_AF:
				certificate = null;
				privateKey = null;
				certificateBasedAuthMaterial = global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.GetCertificateBasedAuthMaterial(ref A_1);
				num = (short)2134310912;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00009460 File Offset: 0x00007660
		private static global::Org.BouncyCastle.Crypto.Tls.TlsProtocol a(global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> A_0, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe A_1)
		{
			short num = (short)888930305;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					flag = false;
					goto IL_81;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_70;
				case 3:
					num = (short)650379265;
					if (num != 0)
					{
					}
					num = (short)176947202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				global::Motorola.Common.Communication.TLS.AuthenticationMaterials certificateBasedAuthMaterial = global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.GetCertificateBasedAuthMaterial(ref A_0);
				if (certificateBasedAuthMaterial == null)
				{
					num = (short)795017216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag = (certificateBasedAuthMaterial.Mode == global::Motorola.Common.Communication.TLS.SecurityEndpointMode.SERVER);
				IL_81:
				if (!flag)
				{
					goto IL_14A;
				}
				num = (short)7012352;
				short num3 = num;
				num = (short)534176788;
				short num4 = num;
				num = (short)1491264532;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_34;
				default:
					num = (short)1329004544;
					if (num != 0)
					{
					}
					num = (short)1254162435;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_70:
			return new global::Motorola.Common.Communication.TLS.TlsServerProtocol(global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(A_1), new global::Org.BouncyCastle.Security.SecureRandom());
			IL_14A:
			return new global::Motorola.Common.Communication.TLS.TlsClientProtocol(global::Motorola.Common.Communication.TLS.TransportLayerSecurityBouncyCastleAdapter.a(A_1), new global::Org.BouncyCastle.Security.SecureRandom());
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000095C8 File Offset: 0x000077C8
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> a()
		{
			short num = (short)1676738560;
			short num2 = num;
			num = (short)1069812874;
			short num3 = num;
			num = (short)6884490;
			switch (num3 == num)
			{
			}
			num = (short)1588002817;
			if (num != 0)
			{
			}
			num = (short)268828672;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000967C File Offset: 0x0000787C
		private static global::System.IO.Stream a(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe A_0)
		{
			short num = (short)1213726720;
			short num2 = num;
			num = (short)327986457;
			short num3 = num;
			num = (short)1751821593;
			switch (num3 == num)
			{
			}
			num = (short)1574633472;
			if (num != 0)
			{
			}
			num = (short)858128385;
			if (num != 0)
			{
			}
			return A_0.GetStream() ?? new global::Motorola.Common.Communication.TLS.CommunicationPipeAdapter(A_0);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00009738 File Offset: 0x00007938
		internal static int[] ConvertCipherSuite(int cipherSuite)
		{
			short num = (short)745275392;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					goto IL_BA;
				case 2:
					num = (short)25952259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					if (cipherSuite == 16)
					{
						goto IL_10F;
					}
					num = (short)570115006;
					short num3 = num;
					num = (short)1363952574;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_61;
					default:
						num = (short)2124742656;
						if (num != 0)
						{
						}
						num = (short)168689668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					num = (short)239337473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_39;
				IL_61:
				num = (short)1538588674;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39:
				switch (cipherSuite)
				{
				case 1:
					goto IL_1BE;
				case 2:
					goto IL_1CD;
				case 3:
					goto IL_8F;
				case 4:
					goto IL_7C;
				case 5:
				case 6:
				case 7:
					goto IL_1D9;
				case 8:
					goto IL_1A7;
				}
				goto IL_61;
			}
			IL_7C:
			return new int[]
			{
				47,
				61,
				157,
				49202,
				49194,
				49198,
				49190,
				107,
				159,
				49200,
				49196,
				49188
			};
			IL_8F:
			return new int[]
			{
				140,
				44
			};
			IL_BA:
			num = (short)967966721;
			if (num != 0)
			{
			}
			num = (short)2004811776;
			short num4 = num;
			goto IL_1D9;
			IL_10F:
			return new int[]
			{
				140,
				141,
				61
			};
			IL_1A7:
			return new int[]
			{
				140,
				141
			};
			IL_1BE:
			return new int[]
			{
				140
			};
			IL_1CD:
			return new int[]
			{
				44
			};
			IL_1D9:
			throw new global::System.ArgumentException();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00009924 File Offset: 0x00007B24
		internal static global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ConvertProtocolVersion(global::Motorola.Common.Communication.TLS.TlsProtocolVersion tlsProtocolVersion)
		{
			short num = (short)806682624;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
				{
					num = (short)1617719981;
					short num3 = num;
					num = (short)1779397293;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A;
					default:
						goto IL_A4;
					}
					break;
				}
				case 2:
				{
					num = (short)180617216;
					short num4 = num;
					num = (short)2104426499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (tlsProtocolVersion != global::Motorola.Common.Communication.TLS.TlsProtocolVersion.TLSv12)
					{
						num = (short)93650948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_142;
				case 4:
					goto IL_5A;
				}
				IL_38:
				if (tlsProtocolVersion != global::Motorola.Common.Communication.TLS.TlsProtocolVersion.TLSv1)
				{
					num = (short)1002045442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_5A:
				num = (short)1797455873;
				num2 = (int)((global::System.IntPtr)num);
			}
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv10;
			IL_A4:
			num = (short)522452992;
			if (num != 0)
			{
			}
			num = (short)1508114433;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentException();
			IL_142:
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00009A80 File Offset: 0x00007C80
		internal static global::Motorola.Common.Communication.TLS.AuthenticationMaterials GetCertificateBasedAuthMaterial(ref global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> authenticationMaterials)
		{
			short num = (short)819134464;
			short num2 = num;
			num = (short)2025593823;
			short num3 = num;
			num = (short)1385569247;
			switch (num3 == num)
			{
			}
			num = (short)165478400;
			if (num != 0)
			{
			}
			num = (short)1844641793;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> list = authenticationMaterials;
			if (list == null)
			{
				return null;
			}
			return list.FirstOrDefault(delegate(global::Motorola.Common.Communication.TLS.AuthenticationMaterials authm)
			{
				short num4 = (short)1738866688;
				short num5 = num4;
				num4 = (short)2086147393;
				short num6 = num4;
				num4 = (short)1182799169;
				switch (num6 == num4)
				{
				}
				num4 = (short)488177665;
				if (num4 != 0)
				{
				}
				num4 = (short)629145600;
				if (num4 != 0)
				{
				}
				return authm.CERTTYPE == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.Certificate;
			});
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00009B5C File Offset: 0x00007D5C
		internal static global::Motorola.Common.Communication.TLS.AuthenticationMaterials GetPskBasedAuthMaterial(ref global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> authenticationMaterials)
		{
			short num = (short)535691264;
			short num2 = num;
			num = (short)59882274;
			short num3 = num;
			num = (short)1220918050;
			switch (num3 == num)
			{
			}
			num = (short)1948254209;
			if (num != 0)
			{
			}
			num = (short)1204617216;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> list = authenticationMaterials;
			if (list == null)
			{
				return null;
			}
			return list.FirstOrDefault(delegate(global::Motorola.Common.Communication.TLS.AuthenticationMaterials authm)
			{
				short num4 = (short)1245708288;
				short num5 = num4;
				num4 = (short)719176909;
				short num6 = num4;
				num4 = (short)1030800589;
				switch (num6 == num4)
				{
				}
				num4 = (short)733085697;
				if (num4 != 0)
				{
				}
				num4 = (short)2134769664;
				if (num4 != 0)
				{
				}
				return authm.CERTTYPE == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PreSharedKey;
			});
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00009C38 File Offset: 0x00007E38
		internal static bool PskExists(ref global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> authenticationMaterials)
		{
			short num = (short)49479680;
			short num2 = num;
			num = (short)715587585;
			if (num != 0)
			{
			}
			num = (short)1631665474;
			short num3 = num;
			num = (short)1341078850;
			switch (num3 == num)
			{
			}
			num = (short)476774400;
			if (num != 0)
			{
			}
			return authenticationMaterials.Any(delegate(global::Motorola.Common.Communication.TLS.AuthenticationMaterials authm)
			{
				short num4 = (short)1529413632;
				short num5 = num4;
				num4 = (short)1752643498;
				short num6 = num4;
				num4 = (short)1632253866;
				switch (num6 == num4)
				{
				}
				num4 = (short)191496193;
				if (num4 != 0)
				{
				}
				num4 = (short)2073755648;
				if (num4 != 0)
				{
				}
				return authm.CERTTYPE == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PreSharedKey;
			});
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00009D08 File Offset: 0x00007F08
		public global::System.Exception SecurityExceptionHandler(global::Org.BouncyCastle.Crypto.Tls.TlsException ex)
		{
			short num = (short)1327366145;
			if (num != 0)
			{
			}
			num = (short)734068743;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				byte? b;
				byte? b3;
				switch (num2)
				{
				case 0:
				{
					byte valueOrDefault;
					if (valueOrDefault != 20)
					{
						num = (short)513802243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_287;
				}
				case 1:
				{
					byte? b2;
					b = b2;
					goto IL_249;
				}
				case 2:
					goto IL_244;
				case 3:
					num = (short)2029322245;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1337163952;
					short num3 = num;
					num = (short)1511096496;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_244;
					default:
						num = (short)1505951744;
						if (num != 0)
						{
						}
						if (ex.InnerException.GetType() == typeof(global::Motorola.Common.CustomException.CommonException))
						{
							num = (short)1331560456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF;
					}
					break;
				}
				case 5:
				{
					byte valueOrDefault;
					if (valueOrDefault == 40)
					{
						num = (short)2087845890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_292;
				}
				case 6:
					num = (short)1341521924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				case 8:
					goto IL_20C;
				case 9:
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlertReceived tlsFatalAlertReceived = ex as global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlertReceived;
					if (tlsFatalAlertReceived == null)
					{
						byte? b2 = null;
						num = (short)117047296;
						short num4 = num;
						num = (short)1434386433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					b = new byte?(tlsFatalAlertReceived.AlertDescription);
					goto IL_249;
				}
				case 10:
					if (b3 != null)
					{
						num = (short)93126667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_292;
				case 11:
				{
					byte valueOrDefault = b3.GetValueOrDefault();
					num = (short)1295187968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_7B:
				if (ex.InnerException != null)
				{
					num = (short)1161428998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DF:
				num = (short)101711881;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_249:
				b3 = b;
				num = (short)601489418;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_20C:
			return ex.InnerException;
			IL_244:
			return new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_PreShared_Key_Missing);
			IL_287:
			return new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_PreShared_Key_Mismatch);
			IL_292:
			return new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Handshake_Failed);
		}

		// Token: 0x04000043 RID: 67
		private readonly global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe a;

		// Token: 0x04000044 RID: 68
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> b;

		// Token: 0x04000045 RID: 69
		private global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion c;

		// Token: 0x04000046 RID: 70
		private global::Org.BouncyCastle.Crypto.Tls.TlsProtocol d;

		// Token: 0x04000047 RID: 71
		private bool e;
	}
}
