using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.EC;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.Field;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200036A RID: 874
	public abstract class TlsEccUtilities
	{
		// Token: 0x06002370 RID: 9072 RVA: 0x0009B5D0 File Offset: 0x000997D0
		public static void AddSupportedEllipticCurvesExtension(global::System.Collections.IDictionary extensions, int[] namedCurves)
		{
			extensions[10] = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CreateSupportedEllipticCurvesExtension(namedCurves);
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0009B5E5 File Offset: 0x000997E5
		public static void AddSupportedPointFormatsExtension(global::System.Collections.IDictionary extensions, byte[] ecPointFormats)
		{
			extensions[11] = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CreateSupportedPointFormatsExtension(ecPointFormats);
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x0009B5FC File Offset: 0x000997FC
		public static int[] GetSupportedEllipticCurvesExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 10);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadSupportedEllipticCurvesExtension(extensionData);
			}
			return null;
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x0009B620 File Offset: 0x00099820
		public static byte[] GetSupportedPointFormatsExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 11);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadSupportedPointFormatsExtension(extensionData);
			}
			return null;
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x0009B641 File Offset: 0x00099841
		public static byte[] CreateSupportedEllipticCurvesExtension(int[] namedCurves)
		{
			if (namedCurves == null || namedCurves.Length < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint16ArrayWithUint16Length(namedCurves);
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0009B65A File Offset: 0x0009985A
		public static byte[] CreateSupportedPointFormatsExtension(byte[] ecPointFormats)
		{
			if (ecPointFormats == null || !global::Org.BouncyCastle.Utilities.Arrays.Contains(ecPointFormats, 0))
			{
				ecPointFormats = global::Org.BouncyCastle.Utilities.Arrays.Append(ecPointFormats, 0);
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint8ArrayWithUint8Length(ecPointFormats);
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x0009B678 File Offset: 0x00099878
		public static int[] ReadSupportedEllipticCurvesExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extensionData, false);
			int length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf);
			if (length < 2 || (length & 1) != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			int[] result = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16Array(length / 2, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			return result;
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x0009B6C2 File Offset: 0x000998C2
		public static byte[] ReadSupportedPointFormatsExtension(byte[] extensionData)
		{
			byte[] array = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.DecodeUint8ArrayWithUint8Length(extensionData);
			if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(array, 0))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			return array;
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x0009B6DB File Offset: 0x000998DB
		public static string GetNameOfNamedCurve(int namedCurve)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsSupportedNamedCurve(namedCurve))
			{
				return null;
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CurveNames[namedCurve - 1];
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0009B6F0 File Offset: 0x000998F0
		public static global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters GetParametersForNamedCurve(int namedCurve)
		{
			string curveName = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetNameOfNamedCurve(namedCurve);
			if (curveName == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP = global::Org.BouncyCastle.Crypto.EC.CustomNamedCurves.GetByName(curveName);
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.X9.ECNamedCurveTable.GetByName(curveName);
				if (ecP == null)
				{
					return null;
				}
			}
			return new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(ecP.Curve, ecP.G, ecP.N, ecP.H, ecP.GetSeed());
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x0009B742 File Offset: 0x00099942
		public static bool HasAnySupportedNamedCurves()
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CurveNames.Length != 0;
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x0009B750 File Offset: 0x00099950
		public static bool ContainsEccCipherSuites(int[] cipherSuites)
		{
			for (int i = 0; i < cipherSuites.Length; i++)
			{
				if (global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsEccCipherSuite(cipherSuites[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x0009B778 File Offset: 0x00099978
		public static bool IsEccCipherSuite(int cipherSuite)
		{
			if (cipherSuite <= 49293)
			{
				if (cipherSuite <= 49211)
				{
					if (cipherSuite - 49153 > 24 && cipherSuite - 49187 > 24)
					{
						return false;
					}
				}
				else if (cipherSuite - 49266 > 7 && cipherSuite - 49286 > 7)
				{
					return false;
				}
			}
			else if (cipherSuite <= 49327)
			{
				if (cipherSuite - 49306 > 1 && cipherSuite - 49324 > 3)
				{
					return false;
				}
			}
			else if (cipherSuite - 52392 > 1 && cipherSuite != 52396)
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x0009B7F6 File Offset: 0x000999F6
		public static bool AreOnSameCurve(global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters a, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters b)
		{
			return a != null && a.Equals(b);
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x0009B804 File Offset: 0x00099A04
		public static bool IsSupportedNamedCurve(int namedCurve)
		{
			return namedCurve > 0 && namedCurve <= global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CurveNames.Length;
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x0009B81C File Offset: 0x00099A1C
		public static bool IsCompressionPreferred(byte[] ecPointFormats, byte compressionFormat)
		{
			if (ecPointFormats == null)
			{
				return false;
			}
			foreach (byte ecPointFormat in ecPointFormats)
			{
				if (ecPointFormat == 0)
				{
					return false;
				}
				if (ecPointFormat == compressionFormat)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0009B84C File Offset: 0x00099A4C
		public static byte[] SerializeECFieldElement(int fieldSize, global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray((fieldSize + 7) / 8, x);
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x0009B85C File Offset: 0x00099A5C
		public static byte[] SerializeECPoint(byte[] ecPointFormats, global::Org.BouncyCastle.Math.EC.ECPoint point)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve curve = point.Curve;
			bool compressed = false;
			if (global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(curve))
			{
				compressed = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsCompressionPreferred(ecPointFormats, 1);
			}
			else if (global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mCurve(curve))
			{
				compressed = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsCompressionPreferred(ecPointFormats, 2);
			}
			return point.GetEncoded(compressed);
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0009B89B File Offset: 0x00099A9B
		public static byte[] SerializeECPublicKey(byte[] ecPointFormats, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters keyParameters)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.SerializeECPoint(ecPointFormats, keyParameters.Q);
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0009B8AC File Offset: 0x00099AAC
		public static global::Org.BouncyCastle.Math.BigInteger DeserializeECFieldElement(int fieldSize, byte[] encoding)
		{
			int requiredLength = (fieldSize + 7) / 8;
			if (encoding.Length != requiredLength)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, encoding);
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0009B8D4 File Offset: 0x00099AD4
		public static global::Org.BouncyCastle.Math.EC.ECPoint DeserializeECPoint(byte[] ecPointFormats, global::Org.BouncyCastle.Math.EC.ECCurve curve, byte[] encoding)
		{
			if (encoding == null || encoding.Length < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			byte actualFormat;
			switch (encoding[0])
			{
			case 2:
			case 3:
				if (global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mCurve(curve))
				{
					actualFormat = 2;
					goto IL_69;
				}
				if (global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(curve))
				{
					actualFormat = 1;
					goto IL_69;
				}
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			case 4:
				actualFormat = 0;
				goto IL_69;
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			IL_69:
			if (actualFormat != 0 && (ecPointFormats == null || !global::Org.BouncyCastle.Utilities.Arrays.Contains(ecPointFormats, actualFormat)))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			return curve.DecodePoint(encoding);
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x0009B968 File Offset: 0x00099B68
		public static global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters DeserializeECPublicKey(byte[] ecPointFormats, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters curve_params, byte[] encoding)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters result;
			try
			{
				result = new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPoint(ecPointFormats, curve_params.Curve, encoding), curve_params);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47, e);
			}
			return result;
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0009B9A8 File Offset: 0x00099BA8
		public static byte[] CalculateECDHBasicAgreement(global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters publicKey, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privateKey)
		{
			global::Org.BouncyCastle.Crypto.Agreement.ECDHBasicAgreement ecdhbasicAgreement = new global::Org.BouncyCastle.Crypto.Agreement.ECDHBasicAgreement();
			ecdhbasicAgreement.Init(privateKey);
			global::Org.BouncyCastle.Math.BigInteger agreementValue = ecdhbasicAgreement.CalculateAgreement(publicKey);
			return global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(ecdhbasicAgreement.GetFieldSize(), agreementValue);
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x0009B9D4 File Offset: 0x00099BD4
		public static global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateECKeyPair(global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParams)
		{
			global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator eckeyPairGenerator = new global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator();
			eckeyPairGenerator.Init(new global::Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters(ecParams, random));
			return eckeyPairGenerator.GenerateKeyPair();
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x0009B9F0 File Offset: 0x00099BF0
		public static global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters GenerateEphemeralClientKeyExchange(global::Org.BouncyCastle.Security.SecureRandom random, byte[] ecPointFormats, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParams, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair asymmetricCipherKeyPair = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateECKeyPair(random, ecParams);
			global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ecPublicKey = (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)asymmetricCipherKeyPair.Public;
			global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECPoint(ecPointFormats, ecPublicKey.Q, output);
			return (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)asymmetricCipherKeyPair.Private;
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x0009BA28 File Offset: 0x00099C28
		internal static global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters GenerateEphemeralServerKeyExchange(global::Org.BouncyCastle.Security.SecureRandom random, int[] namedCurves, byte[] ecPointFormats, global::System.IO.Stream output)
		{
			int namedCurve = -1;
			if (namedCurves == null)
			{
				namedCurve = 23;
			}
			else
			{
				foreach (int entry in namedCurves)
				{
					if (global::Org.BouncyCastle.Crypto.Tls.NamedCurve.IsValid(entry) && global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsSupportedNamedCurve(entry))
					{
						namedCurve = entry;
						break;
					}
				}
			}
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParams = null;
			if (namedCurve >= 0)
			{
				ecParams = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetParametersForNamedCurve(namedCurve);
			}
			else if (global::Org.BouncyCastle.Utilities.Arrays.Contains(namedCurves, 65281))
			{
				ecParams = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetParametersForNamedCurve(23);
			}
			else if (global::Org.BouncyCastle.Utilities.Arrays.Contains(namedCurves, 65282))
			{
				ecParams = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetParametersForNamedCurve(10);
			}
			if (ecParams == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			if (namedCurve < 0)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteExplicitECParameters(ecPointFormats, ecParams, output);
			}
			else
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteNamedECParameters(namedCurve, output);
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateEphemeralClientKeyExchange(random, ecPointFormats, ecParams, output);
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0009BAC9 File Offset: 0x00099CC9
		public static global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ValidateECPublicKey(global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters key)
		{
			return key;
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x0009BACC File Offset: 0x00099CCC
		public static int ReadECExponent(int fieldSize, global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Math.BigInteger K = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input);
			if (K.BitLength < 32)
			{
				int i = K.IntValue;
				if (i > 0 && i < fieldSize)
				{
					return i;
				}
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x0009BB02 File Offset: 0x00099D02
		public static global::Org.BouncyCastle.Math.BigInteger ReadECFieldElement(int fieldSize, global::System.IO.Stream input)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECFieldElement(fieldSize, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input));
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0009BB10 File Offset: 0x00099D10
		public static global::Org.BouncyCastle.Math.BigInteger ReadECParameter(global::System.IO.Stream input)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input));
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x0009BB20 File Offset: 0x00099D20
		public static global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ReadECParameters(int[] namedCurves, byte[] ecPointFormats, global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters result;
			try
			{
				switch (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input))
				{
				case 1:
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CheckNamedCurve(namedCurves, 65281);
					global::Org.BouncyCastle.Math.BigInteger bigInteger = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input);
					global::Org.BouncyCastle.Math.BigInteger a = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECFieldElement(bigInteger.BitLength, input);
					global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECFieldElement(bigInteger.BitLength, input);
					byte[] baseEncoding = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input);
					global::Org.BouncyCastle.Math.BigInteger order = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input);
					global::Org.BouncyCastle.Math.BigInteger cofactor = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input);
					global::Org.BouncyCastle.Math.EC.ECCurve curve = new global::Org.BouncyCastle.Math.EC.FpCurve(bigInteger, a, b, order, cofactor);
					global::Org.BouncyCastle.Math.EC.ECPoint basePoint = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPoint(ecPointFormats, curve, baseEncoding);
					result = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve, basePoint, order, cofactor);
					break;
				}
				case 2:
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CheckNamedCurve(namedCurves, 65282);
					int i = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input);
					byte b3 = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
					if (!global::Org.BouncyCastle.Crypto.Tls.ECBasisType.IsValid(b3))
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
					}
					int k = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECExponent(i, input);
					int k2 = -1;
					int k3 = -1;
					if (b3 == 2)
					{
						k2 = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECExponent(i, input);
						k3 = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECExponent(i, input);
					}
					global::Org.BouncyCastle.Math.BigInteger a2 = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECFieldElement(i, input);
					global::Org.BouncyCastle.Math.BigInteger b2 = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECFieldElement(i, input);
					byte[] baseEncoding2 = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input);
					global::Org.BouncyCastle.Math.BigInteger order2 = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input);
					global::Org.BouncyCastle.Math.BigInteger cofactor2 = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameter(input);
					global::Org.BouncyCastle.Math.EC.ECCurve curve2 = (b3 == 2) ? new global::Org.BouncyCastle.Math.EC.F2mCurve(i, k, k2, k3, a2, b2, order2, cofactor2) : new global::Org.BouncyCastle.Math.EC.F2mCurve(i, k, a2, b2, order2, cofactor2);
					global::Org.BouncyCastle.Math.EC.ECPoint basePoint2 = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPoint(ecPointFormats, curve2, baseEncoding2);
					result = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(curve2, basePoint2, order2, cofactor2);
					break;
				}
				case 3:
				{
					int namedCurve = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input);
					if (!global::Org.BouncyCastle.Crypto.Tls.NamedCurve.RefersToASpecificNamedCurve(namedCurve))
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
					}
					global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CheckNamedCurve(namedCurves, namedCurve);
					result = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetParametersForNamedCurve(namedCurve);
					break;
				}
				default:
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47, e);
			}
			return result;
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x0009BCE0 File Offset: 0x00099EE0
		private static void CheckNamedCurve(int[] namedCurves, int namedCurve)
		{
			if (namedCurves != null && !global::Org.BouncyCastle.Utilities.Arrays.Contains(namedCurves, namedCurve))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0009BCF6 File Offset: 0x00099EF6
		public static void WriteECExponent(int k, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECParameter(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)k), output);
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0009BD05 File Offset: 0x00099F05
		public static void WriteECFieldElement(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(x.GetEncoded(), output);
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0009BD13 File Offset: 0x00099F13
		public static void WriteECFieldElement(int fieldSize, global::Org.BouncyCastle.Math.BigInteger x, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.SerializeECFieldElement(fieldSize, x), output);
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x0009BD22 File Offset: 0x00099F22
		public static void WriteECParameter(global::Org.BouncyCastle.Math.BigInteger x, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(x), output);
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x0009BD30 File Offset: 0x00099F30
		public static void WriteExplicitECParameters(byte[] ecPointFormats, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParameters, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve curve = ecParameters.Curve;
			if (global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(curve))
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(1, output);
				global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECParameter(curve.Field.Characteristic, output);
			}
			else
			{
				if (!global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mCurve(curve))
				{
					throw new global::System.ArgumentException("'ecParameters' not a known curve type");
				}
				int[] exponents = ((global::Org.BouncyCastle.Math.Field.IPolynomialExtensionField)curve.Field).MinimalPolynomial.GetExponentsPresent();
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(2, output);
				int i = exponents[exponents.Length - 1];
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i, output);
				if (exponents.Length == 3)
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(1, output);
					global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECExponent(exponents[1], output);
				}
				else
				{
					if (exponents.Length != 5)
					{
						throw new global::System.ArgumentException("Only trinomial and pentomial curves are supported");
					}
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(2, output);
					global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECExponent(exponents[1], output);
					global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECExponent(exponents[2], output);
					global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECExponent(exponents[3], output);
				}
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECFieldElement(curve.A, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECFieldElement(curve.B, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.SerializeECPoint(ecPointFormats, ecParameters.G), output);
			global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECParameter(ecParameters.N, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.WriteECParameter(ecParameters.H, output);
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x0009BE3B File Offset: 0x0009A03B
		public static void WriteECPoint(byte[] ecPointFormats, global::Org.BouncyCastle.Math.EC.ECPoint point, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.SerializeECPoint(ecPointFormats, point), output);
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x0009BE4A File Offset: 0x0009A04A
		public static void WriteNamedECParameters(int namedCurve, global::System.IO.Stream output)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.NamedCurve.RefersToASpecificNamedCurve(namedCurve))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(3, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(namedCurve);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(namedCurve, output);
		}

		// Token: 0x04000E62 RID: 3682
		private static readonly string[] CurveNames = new string[]
		{
			"sect163k1",
			"sect163r1",
			"sect163r2",
			"sect193r1",
			"sect193r2",
			"sect233k1",
			"sect233r1",
			"sect239k1",
			"sect283k1",
			"sect283r1",
			"sect409k1",
			"sect409r1",
			"sect571k1",
			"sect571r1",
			"secp160k1",
			"secp160r1",
			"secp160r2",
			"secp192k1",
			"secp192r1",
			"secp224k1",
			"secp224r1",
			"secp256k1",
			"secp256r1",
			"secp384r1",
			"secp521r1",
			"brainpoolP256r1",
			"brainpoolP384r1",
			"brainpoolP512r1"
		};
	}
}
