using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000366 RID: 870
	public abstract class TlsDHUtilities
	{
		// Token: 0x06002349 RID: 9033 RVA: 0x0009AEFA File Offset: 0x000990FA
		private static global::Org.BouncyCastle.Math.BigInteger FromHex(string hex)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(hex));
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0009AF08 File Offset: 0x00099108
		private static global::Org.BouncyCastle.Crypto.Parameters.DHParameters FromSafeP(string hexP)
		{
			global::Org.BouncyCastle.Math.BigInteger bigInteger = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromHex(hexP);
			global::Org.BouncyCastle.Math.BigInteger q = bigInteger.ShiftRight(1);
			return new global::Org.BouncyCastle.Crypto.Parameters.DHParameters(bigInteger, global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.Two, q);
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0009AF2E File Offset: 0x0009912E
		public static void AddNegotiatedDheGroupsClientExtension(global::System.Collections.IDictionary extensions, byte[] dheGroups)
		{
			extensions[global::Org.BouncyCastle.Crypto.Tls.ExtensionType.negotiated_ff_dhe_groups] = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.CreateNegotiatedDheGroupsClientExtension(dheGroups);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0009AF46 File Offset: 0x00099146
		public static void AddNegotiatedDheGroupsServerExtension(global::System.Collections.IDictionary extensions, byte dheGroup)
		{
			extensions[global::Org.BouncyCastle.Crypto.Tls.ExtensionType.negotiated_ff_dhe_groups] = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.CreateNegotiatedDheGroupsServerExtension(dheGroup);
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0009AF60 File Offset: 0x00099160
		public static byte[] GetNegotiatedDheGroupsClientExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, global::Org.BouncyCastle.Crypto.Tls.ExtensionType.negotiated_ff_dhe_groups);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadNegotiatedDheGroupsClientExtension(extensionData);
			}
			return null;
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x0009AF84 File Offset: 0x00099184
		public static short GetNegotiatedDheGroupsServerExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, global::Org.BouncyCastle.Crypto.Tls.ExtensionType.negotiated_ff_dhe_groups);
			if (extensionData != null)
			{
				return (short)global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadNegotiatedDheGroupsServerExtension(extensionData);
			}
			return -1;
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0009AFA8 File Offset: 0x000991A8
		public static byte[] CreateNegotiatedDheGroupsClientExtension(byte[] dheGroups)
		{
			if (dheGroups == null || dheGroups.Length < 1 || dheGroups.Length > 255)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint8ArrayWithUint8Length(dheGroups);
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x0009AFCB File Offset: 0x000991CB
		public static byte[] CreateNegotiatedDheGroupsServerExtension(byte dheGroup)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint8(dheGroup);
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x0009AFD3 File Offset: 0x000991D3
		public static byte[] ReadNegotiatedDheGroupsClientExtension(byte[] extensionData)
		{
			byte[] array = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.DecodeUint8ArrayWithUint8Length(extensionData);
			if (array.Length < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			return array;
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x0009AFE9 File Offset: 0x000991E9
		public static byte ReadNegotiatedDheGroupsServerExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.DecodeUint8(extensionData);
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x0009AFF1 File Offset: 0x000991F1
		public static global::Org.BouncyCastle.Crypto.Parameters.DHParameters GetParametersForDHEGroup(short dheGroup)
		{
			switch (dheGroup)
			{
			case 0:
				return global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe2432;
			case 1:
				return global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe3072;
			case 2:
				return global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe4096;
			case 3:
				return global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe6144;
			case 4:
				return global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe8192;
			default:
				return null;
			}
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0009B030 File Offset: 0x00099230
		public static bool ContainsDheCipherSuites(int[] cipherSuites)
		{
			for (int i = 0; i < cipherSuites.Length; i++)
			{
				if (global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.IsDheCipherSuite(cipherSuites[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x0009B058 File Offset: 0x00099258
		public static bool IsDheCipherSuite(int cipherSuite)
		{
			if (cipherSuite <= 137)
			{
				if (cipherSuite <= 58)
				{
					if (cipherSuite <= 45)
					{
						switch (cipherSuite)
						{
						case 17:
						case 18:
						case 19:
						case 20:
						case 21:
						case 22:
						case 24:
						case 27:
							break;
						case 23:
						case 25:
						case 26:
							return false;
						default:
							if (cipherSuite != 45)
							{
								return false;
							}
							break;
						}
					}
					else if (cipherSuite - 50 > 2 && cipherSuite - 56 > 2)
					{
						return false;
					}
				}
				else if (cipherSuite <= 70)
				{
					if (cipherSuite != 64 && cipherSuite - 68 > 2)
					{
						return false;
					}
				}
				else if (cipherSuite != 103 && cipherSuite - 106 > 3 && cipherSuite - 135 > 2)
				{
					return false;
				}
			}
			else if (cipherSuite <= 49285)
			{
				if (cipherSuite <= 181)
				{
					if (cipherSuite - 142 > 3)
					{
						switch (cipherSuite)
						{
						case 153:
						case 154:
						case 155:
						case 158:
						case 159:
						case 162:
						case 163:
						case 166:
						case 167:
						case 170:
						case 171:
						case 178:
						case 179:
						case 180:
						case 181:
							break;
						case 156:
						case 157:
						case 160:
						case 161:
						case 164:
						case 165:
						case 168:
						case 169:
						case 172:
						case 173:
						case 174:
						case 175:
						case 176:
						case 177:
							return false;
						default:
							return false;
						}
					}
				}
				else if (cipherSuite - 189 > 2 && cipherSuite - 195 > 2)
				{
					switch (cipherSuite)
					{
					case 49276:
					case 49277:
					case 49280:
					case 49281:
					case 49284:
					case 49285:
						break;
					case 49278:
					case 49279:
					case 49282:
					case 49283:
						return false;
					default:
						return false;
					}
				}
			}
			else if (cipherSuite <= 49303)
			{
				if (cipherSuite - 49296 > 1 && cipherSuite - 49302 > 1)
				{
					return false;
				}
			}
			else
			{
				switch (cipherSuite)
				{
				case 49310:
				case 49311:
				case 49314:
				case 49315:
				case 49318:
				case 49319:
				case 49322:
				case 49323:
					break;
				case 49312:
				case 49313:
				case 49316:
				case 49317:
				case 49320:
				case 49321:
					return false;
				default:
					if (cipherSuite != 52394 && cipherSuite != 52397)
					{
						return false;
					}
					break;
				}
			}
			return true;
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x0009B284 File Offset: 0x00099484
		public static bool AreCompatibleParameters(global::Org.BouncyCastle.Crypto.Parameters.DHParameters a, global::Org.BouncyCastle.Crypto.Parameters.DHParameters b)
		{
			return a.P.Equals(b.P) && a.G.Equals(b.G) && (a.Q == null || b.Q == null || a.Q.Equals(b.Q));
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x0009B2DC File Offset: 0x000994DC
		public static byte[] CalculateDHBasicAgreement(global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters publicKey, global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters privateKey)
		{
			global::Org.BouncyCastle.Crypto.Agreement.DHBasicAgreement dhbasicAgreement = new global::Org.BouncyCastle.Crypto.Agreement.DHBasicAgreement();
			dhbasicAgreement.Init(privateKey);
			return global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(dhbasicAgreement.CalculateAgreement(publicKey));
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x0009B2F5 File Offset: 0x000994F5
		public static global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateDHKeyPair(global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams)
		{
			global::Org.BouncyCastle.Crypto.Generators.DHBasicKeyPairGenerator dhbasicKeyPairGenerator = new global::Org.BouncyCastle.Crypto.Generators.DHBasicKeyPairGenerator();
			dhbasicKeyPairGenerator.Init(new global::Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters(random, dhParams));
			return dhbasicKeyPairGenerator.GenerateKeyPair();
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x0009B30E File Offset: 0x0009950E
		public static global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters GenerateEphemeralClientKeyExchange(global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair asymmetricCipherKeyPair = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateDHKeyPair(random, dhParams);
			global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.WriteDHParameter(((global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)asymmetricCipherKeyPair.Public).Y, output);
			return (global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)asymmetricCipherKeyPair.Private;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x0009B337 File Offset: 0x00099537
		public static global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters GenerateEphemeralServerKeyExchange(global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair asymmetricCipherKeyPair = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateDHKeyPair(random, dhParams);
			global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters dhpublicKeyParameters = (global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)asymmetricCipherKeyPair.Public;
			global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.WriteDHParameters(dhParams, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.WriteDHParameter(dhpublicKeyParameters.Y, output);
			return (global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)asymmetricCipherKeyPair.Private;
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x0009B367 File Offset: 0x00099567
		public static global::Org.BouncyCastle.Math.BigInteger ReadDHParameter(global::System.IO.Stream input)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input));
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x0009B378 File Offset: 0x00099578
		public static global::Org.BouncyCastle.Crypto.Parameters.DHParameters ReadDHParameters(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Math.BigInteger p = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(input);
			global::Org.BouncyCastle.Math.BigInteger g = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(input);
			return new global::Org.BouncyCastle.Crypto.Parameters.DHParameters(p, g);
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x0009B398 File Offset: 0x00099598
		public static global::Org.BouncyCastle.Crypto.Parameters.DHParameters ReceiveDHParameters(global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier dhVerifier, global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameters(input);
			if (!dhVerifier.Accept(dhParameters))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(71);
			}
			return dhParameters;
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x0009B3BE File Offset: 0x000995BE
		public static void WriteDHParameter(global::Org.BouncyCastle.Math.BigInteger x, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(x), output);
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x0009B3CC File Offset: 0x000995CC
		public static void WriteDHParameters(global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.WriteDHParameter(dhParameters.P, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.WriteDHParameter(dhParameters.G, output);
		}

		// Token: 0x04000E57 RID: 3671
		internal static readonly global::Org.BouncyCastle.Math.BigInteger Two = global::Org.BouncyCastle.Math.BigInteger.Two;

		// Token: 0x04000E58 RID: 3672
		private static readonly string draft_ffdhe2432_p = "FFFFFFFFFFFFFFFFADF85458A2BB4A9AAFDC5620273D3CF1D8B9C583CE2D3695A9E13641146433FBCC939DCE249B3EF97D2FE363630C75D8F681B202AEC4617AD3DF1ED5D5FD65612433F51F5F066ED0856365553DED1AF3B557135E7F57C935984F0C70E0E68B77E2A689DAF3EFE8721DF158A136ADE73530ACCA4F483A797ABC0AB182B324FB61D108A94BB2C8E3FBB96ADAB760D7F4681D4F42A3DE394DF4AE56EDE76372BB190B07A7C8EE0A6D709E02FCE1CDF7E2ECC03404CD28342F619172FE9CE98583FF8E4F1232EEF28183C3FE3B1B4C6FAD733BB5FCBC2EC22005C58EF1837D1683B2C6F34A26C1B2EFFA886B4238611FCFDCDE355B3B6519035BBC34F4DEF99C023861B46FC9D6E6C9077AD91D2691F7F7EE598CB0FAC186D91CAEFE13098533C8B3FFFFFFFFFFFFFFFF";

		// Token: 0x04000E59 RID: 3673
		internal static readonly global::Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe2432 = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromSafeP(global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe2432_p);

		// Token: 0x04000E5A RID: 3674
		private static readonly string draft_ffdhe3072_p = "FFFFFFFFFFFFFFFFADF85458A2BB4A9AAFDC5620273D3CF1D8B9C583CE2D3695A9E13641146433FBCC939DCE249B3EF97D2FE363630C75D8F681B202AEC4617AD3DF1ED5D5FD65612433F51F5F066ED0856365553DED1AF3B557135E7F57C935984F0C70E0E68B77E2A689DAF3EFE8721DF158A136ADE73530ACCA4F483A797ABC0AB182B324FB61D108A94BB2C8E3FBB96ADAB760D7F4681D4F42A3DE394DF4AE56EDE76372BB190B07A7C8EE0A6D709E02FCE1CDF7E2ECC03404CD28342F619172FE9CE98583FF8E4F1232EEF28183C3FE3B1B4C6FAD733BB5FCBC2EC22005C58EF1837D1683B2C6F34A26C1B2EFFA886B4238611FCFDCDE355B3B6519035BBC34F4DEF99C023861B46FC9D6E6C9077AD91D2691F7F7EE598CB0FAC186D91CAEFE130985139270B4130C93BC437944F4FD4452E2D74DD364F2E21E71F54BFF5CAE82AB9C9DF69EE86D2BC522363A0DABC521979B0DEADA1DBF9A42D5C4484E0ABCD06BFA53DDEF3C1B20EE3FD59D7C25E41D2B66C62E37FFFFFFFFFFFFFFFF";

		// Token: 0x04000E5B RID: 3675
		internal static readonly global::Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe3072 = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromSafeP(global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe3072_p);

		// Token: 0x04000E5C RID: 3676
		private static readonly string draft_ffdhe4096_p = "FFFFFFFFFFFFFFFFADF85458A2BB4A9AAFDC5620273D3CF1D8B9C583CE2D3695A9E13641146433FBCC939DCE249B3EF97D2FE363630C75D8F681B202AEC4617AD3DF1ED5D5FD65612433F51F5F066ED0856365553DED1AF3B557135E7F57C935984F0C70E0E68B77E2A689DAF3EFE8721DF158A136ADE73530ACCA4F483A797ABC0AB182B324FB61D108A94BB2C8E3FBB96ADAB760D7F4681D4F42A3DE394DF4AE56EDE76372BB190B07A7C8EE0A6D709E02FCE1CDF7E2ECC03404CD28342F619172FE9CE98583FF8E4F1232EEF28183C3FE3B1B4C6FAD733BB5FCBC2EC22005C58EF1837D1683B2C6F34A26C1B2EFFA886B4238611FCFDCDE355B3B6519035BBC34F4DEF99C023861B46FC9D6E6C9077AD91D2691F7F7EE598CB0FAC186D91CAEFE130985139270B4130C93BC437944F4FD4452E2D74DD364F2E21E71F54BFF5CAE82AB9C9DF69EE86D2BC522363A0DABC521979B0DEADA1DBF9A42D5C4484E0ABCD06BFA53DDEF3C1B20EE3FD59D7C25E41D2B669E1EF16E6F52C3164DF4FB7930E9E4E58857B6AC7D5F42D69F6D187763CF1D5503400487F55BA57E31CC7A7135C886EFB4318AED6A1E012D9E6832A907600A918130C46DC778F971AD0038092999A333CB8B7A1A1DB93D7140003C2A4ECEA9F98D0ACC0A8291CDCEC97DCF8EC9B55A7F88A46B4DB5A851F44182E1C68A007E5E655F6AFFFFFFFFFFFFFFFF";

		// Token: 0x04000E5D RID: 3677
		internal static readonly global::Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe4096 = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromSafeP(global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe4096_p);

		// Token: 0x04000E5E RID: 3678
		private static readonly string draft_ffdhe6144_p = "FFFFFFFFFFFFFFFFADF85458A2BB4A9AAFDC5620273D3CF1D8B9C583CE2D3695A9E13641146433FBCC939DCE249B3EF97D2FE363630C75D8F681B202AEC4617AD3DF1ED5D5FD65612433F51F5F066ED0856365553DED1AF3B557135E7F57C935984F0C70E0E68B77E2A689DAF3EFE8721DF158A136ADE73530ACCA4F483A797ABC0AB182B324FB61D108A94BB2C8E3FBB96ADAB760D7F4681D4F42A3DE394DF4AE56EDE76372BB190B07A7C8EE0A6D709E02FCE1CDF7E2ECC03404CD28342F619172FE9CE98583FF8E4F1232EEF28183C3FE3B1B4C6FAD733BB5FCBC2EC22005C58EF1837D1683B2C6F34A26C1B2EFFA886B4238611FCFDCDE355B3B6519035BBC34F4DEF99C023861B46FC9D6E6C9077AD91D2691F7F7EE598CB0FAC186D91CAEFE130985139270B4130C93BC437944F4FD4452E2D74DD364F2E21E71F54BFF5CAE82AB9C9DF69EE86D2BC522363A0DABC521979B0DEADA1DBF9A42D5C4484E0ABCD06BFA53DDEF3C1B20EE3FD59D7C25E41D2B669E1EF16E6F52C3164DF4FB7930E9E4E58857B6AC7D5F42D69F6D187763CF1D5503400487F55BA57E31CC7A7135C886EFB4318AED6A1E012D9E6832A907600A918130C46DC778F971AD0038092999A333CB8B7A1A1DB93D7140003C2A4ECEA9F98D0ACC0A8291CDCEC97DCF8EC9B55A7F88A46B4DB5A851F44182E1C68A007E5E0DD9020BFD64B645036C7A4E677D2C38532A3A23BA4442CAF53EA63BB454329B7624C8917BDD64B1C0FD4CB38E8C334C701C3ACDAD0657FCCFEC719B1F5C3E4E46041F388147FB4CFDB477A52471F7A9A96910B855322EDB6340D8A00EF092350511E30ABEC1FFF9E3A26E7FB29F8C183023C3587E38DA0077D9B4763E4E4B94B2BBC194C6651E77CAF992EEAAC0232A281BF6B3A739C1226116820AE8DB5847A67CBEF9C9091B462D538CD72B03746AE77F5E62292C311562A846505DC82DB854338AE49F5235C95B91178CCF2DD5CACEF403EC9D1810C6272B045B3B71F9DC6B80D63FDD4A8E9ADB1E6962A69526D43161C1A41D570D7938DAD4A40E329CD0E40E65FFFFFFFFFFFFFFFF";

		// Token: 0x04000E5F RID: 3679
		internal static readonly global::Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe6144 = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromSafeP(global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe6144_p);

		// Token: 0x04000E60 RID: 3680
		private static readonly string draft_ffdhe8192_p = "FFFFFFFFFFFFFFFFADF85458A2BB4A9AAFDC5620273D3CF1D8B9C583CE2D3695A9E13641146433FBCC939DCE249B3EF97D2FE363630C75D8F681B202AEC4617AD3DF1ED5D5FD65612433F51F5F066ED0856365553DED1AF3B557135E7F57C935984F0C70E0E68B77E2A689DAF3EFE8721DF158A136ADE73530ACCA4F483A797ABC0AB182B324FB61D108A94BB2C8E3FBB96ADAB760D7F4681D4F42A3DE394DF4AE56EDE76372BB190B07A7C8EE0A6D709E02FCE1CDF7E2ECC03404CD28342F619172FE9CE98583FF8E4F1232EEF28183C3FE3B1B4C6FAD733BB5FCBC2EC22005C58EF1837D1683B2C6F34A26C1B2EFFA886B4238611FCFDCDE355B3B6519035BBC34F4DEF99C023861B46FC9D6E6C9077AD91D2691F7F7EE598CB0FAC186D91CAEFE130985139270B4130C93BC437944F4FD4452E2D74DD364F2E21E71F54BFF5CAE82AB9C9DF69EE86D2BC522363A0DABC521979B0DEADA1DBF9A42D5C4484E0ABCD06BFA53DDEF3C1B20EE3FD59D7C25E41D2B669E1EF16E6F52C3164DF4FB7930E9E4E58857B6AC7D5F42D69F6D187763CF1D5503400487F55BA57E31CC7A7135C886EFB4318AED6A1E012D9E6832A907600A918130C46DC778F971AD0038092999A333CB8B7A1A1DB93D7140003C2A4ECEA9F98D0ACC0A8291CDCEC97DCF8EC9B55A7F88A46B4DB5A851F44182E1C68A007E5E0DD9020BFD64B645036C7A4E677D2C38532A3A23BA4442CAF53EA63BB454329B7624C8917BDD64B1C0FD4CB38E8C334C701C3ACDAD0657FCCFEC719B1F5C3E4E46041F388147FB4CFDB477A52471F7A9A96910B855322EDB6340D8A00EF092350511E30ABEC1FFF9E3A26E7FB29F8C183023C3587E38DA0077D9B4763E4E4B94B2BBC194C6651E77CAF992EEAAC0232A281BF6B3A739C1226116820AE8DB5847A67CBEF9C9091B462D538CD72B03746AE77F5E62292C311562A846505DC82DB854338AE49F5235C95B91178CCF2DD5CACEF403EC9D1810C6272B045B3B71F9DC6B80D63FDD4A8E9ADB1E6962A69526D43161C1A41D570D7938DAD4A40E329CCFF46AAA36AD004CF600C8381E425A31D951AE64FDB23FCEC9509D43687FEB69EDD1CC5E0B8CC3BDF64B10EF86B63142A3AB8829555B2F747C932665CB2C0F1CC01BD70229388839D2AF05E454504AC78B7582822846C0BA35C35F5C59160CC046FD8251541FC68C9C86B022BB7099876A460E7451A8A93109703FEE1C217E6C3826E52C51AA691E0E423CFC99E9E31650C1217B624816CDAD9A95F9D5B8019488D9C0A0A1FE3075A577E23183F81D4A3F2FA4571EFC8CE0BA8A4FE8B6855DFE72B0A66EDED2FBABFBE58A30FAFABE1C5D71A87E2F741EF8C1FE86FEA6BBFDE530677F0D97D11D49F7A8443D0822E506A9F4614E011E2A94838FF88CD68C8BB7C5C6424CFFFFFFFFFFFFFFFF";

		// Token: 0x04000E61 RID: 3681
		internal static readonly global::Org.BouncyCastle.Crypto.Parameters.DHParameters draft_ffdhe8192 = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.FromSafeP(global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.draft_ffdhe8192_p);
	}
}
