using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Iana;
using Org.BouncyCastle.Asn1.Misc;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001C9 RID: 457
	public sealed class MacUtilities
	{
		// Token: 0x06001104 RID: 4356 RVA: 0x00047DC8 File Offset: 0x00045FC8
		private MacUtilities()
		{
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00047DD0 File Offset: 0x00045FD0
		static MacUtilities()
		{
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacMD5.Id] = "HMAC-MD5";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacRipeMD160.Id] = "HMAC-RIPEMD160";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacSha1.Id] = "HMAC-SHA1";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacTiger.Id] = "HMAC-TIGER";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha1.Id] = "HMAC-SHA1";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.HMAC_SHA1.Id] = "HMAC-SHA1";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha224.Id] = "HMAC-SHA224";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha256.Id] = "HMAC-SHA256";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha384.Id] = "HMAC-SHA384";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha512.Id] = "HMAC-SHA512";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_224.Id] = "HMAC-SHA3-224";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_256.Id] = "HMAC-SHA3-256";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_384.Id] = "HMAC-SHA3-384";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_512.Id] = "HMAC-SHA3-512";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_hmac_gost_3411_12_256.Id] = "HMAC-GOST3411-2012-256";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_hmac_gost_3411_12_512.Id] = "HMAC-GOST3411-2012-512";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["DES"] = "DESMAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["DES/CFB8"] = "DESMAC/CFB8";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["DES64"] = "DESMAC64";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["DESEDE"] = "DESEDEMAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc.Id] = "DESEDEMAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["DESEDE/CFB8"] = "DESEDEMAC/CFB8";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["DESISO9797MAC"] = "DESWITHISO9797";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["DESEDE64"] = "DESEDEMAC64";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["DESEDE64WITHISO7816-4PADDING"] = "DESEDEMAC64WITHISO7816-4PADDING";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["DESEDEISO9797ALG1MACWITHISO7816-4PADDING"] = "DESEDEMAC64WITHISO7816-4PADDING";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["DESEDEISO9797ALG1WITHISO7816-4PADDING"] = "DESEDEMAC64WITHISO7816-4PADDING";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["ISO9797ALG3"] = "ISO9797ALG3MAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["ISO9797ALG3MACWITHISO7816-4PADDING"] = "ISO9797ALG3WITHISO7816-4PADDING";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["SKIPJACK"] = "SKIPJACKMAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["SKIPJACK/CFB8"] = "SKIPJACKMAC/CFB8";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["IDEA"] = "IDEAMAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["IDEA/CFB8"] = "IDEAMAC/CFB8";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["RC2"] = "RC2MAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["RC2/CFB8"] = "RC2MAC/CFB8";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["RC5"] = "RC5MAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["RC5/CFB8"] = "RC5MAC/CFB8";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["GOST28147"] = "GOST28147MAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["VMPC"] = "VMPCMAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["VMPC-MAC"] = "VMPCMAC";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["SIPHASH"] = "SIPHASH-2-4";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["PBEWITHHMACSHA"] = "PBEWITHHMACSHA1";
			global::Org.BouncyCastle.Security.MacUtilities.algorithms["1.3.14.3.2.26"] = "PBEWITHHMACSHA1";
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00048198 File Offset: 0x00046398
		public static global::Org.BouncyCastle.Crypto.IMac GetMac(global::Org.BouncyCastle.Asn1.DerObjectIdentifier id)
		{
			return global::Org.BouncyCastle.Security.MacUtilities.GetMac(id.Id);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x000481A8 File Offset: 0x000463A8
		public static global::Org.BouncyCastle.Crypto.IMac GetMac(string algorithm)
		{
			string upper = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm);
			string mechanism = (string)global::Org.BouncyCastle.Security.MacUtilities.algorithms[upper];
			if (mechanism == null)
			{
				mechanism = upper;
			}
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEWITH"))
			{
				mechanism = mechanism.Substring("PBEWITH".Length);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "HMAC"))
			{
				string digestName;
				if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "HMAC-") || global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "HMAC/"))
				{
					digestName = mechanism.Substring(5);
				}
				else
				{
					digestName = mechanism.Substring(4);
				}
				return new global::Org.BouncyCastle.Crypto.Macs.HMac(global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(digestName));
			}
			if (mechanism == "AESCMAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CMac(new global::Org.BouncyCastle.Crypto.Engines.AesEngine());
			}
			if (mechanism == "DESMAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.DesEngine());
			}
			if (mechanism == "DESMAC/CFB8")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CfbBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.DesEngine());
			}
			if (mechanism == "DESMAC64")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.DesEngine(), 64);
			}
			if (mechanism == "DESEDECMAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CMac(new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine());
			}
			if (mechanism == "DESEDEMAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine());
			}
			if (mechanism == "DESEDEMAC/CFB8")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CfbBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine());
			}
			if (mechanism == "DESEDEMAC64")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine(), 64);
			}
			if (mechanism == "DESEDEMAC64WITHISO7816-4PADDING")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine(), 64, new global::Org.BouncyCastle.Crypto.Paddings.ISO7816d4Padding());
			}
			if (mechanism == "DESWITHISO9797" || mechanism == "ISO9797ALG3MAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.ISO9797Alg3Mac(new global::Org.BouncyCastle.Crypto.Engines.DesEngine());
			}
			if (mechanism == "ISO9797ALG3WITHISO7816-4PADDING")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.ISO9797Alg3Mac(new global::Org.BouncyCastle.Crypto.Engines.DesEngine(), new global::Org.BouncyCastle.Crypto.Paddings.ISO7816d4Padding());
			}
			if (mechanism == "SKIPJACKMAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine());
			}
			if (mechanism == "SKIPJACKMAC/CFB8")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CfbBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine());
			}
			if (mechanism == "IDEAMAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.IdeaEngine());
			}
			if (mechanism == "IDEAMAC/CFB8")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CfbBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.IdeaEngine());
			}
			if (mechanism == "RC2MAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.RC2Engine());
			}
			if (mechanism == "RC2MAC/CFB8")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CfbBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.RC2Engine());
			}
			if (mechanism == "RC5MAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.RC532Engine());
			}
			if (mechanism == "RC5MAC/CFB8")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.CfbBlockCipherMac(new global::Org.BouncyCastle.Crypto.Engines.RC532Engine());
			}
			if (mechanism == "GOST28147MAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac();
			}
			if (mechanism == "VMPCMAC")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.VmpcMac();
			}
			if (mechanism == "SIPHASH-2-4")
			{
				return new global::Org.BouncyCastle.Crypto.Macs.SipHash();
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Mac " + mechanism + " not recognised.");
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00048468 File Offset: 0x00046668
		public static string GetAlgorithmName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Security.MacUtilities.algorithms[oid.Id];
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0004847F File Offset: 0x0004667F
		public static byte[] CalculateMac(string algorithm, global::Org.BouncyCastle.Crypto.ICipherParameters cp, byte[] input)
		{
			global::Org.BouncyCastle.Crypto.IMac mac = global::Org.BouncyCastle.Security.MacUtilities.GetMac(algorithm);
			mac.Init(cp);
			mac.BlockUpdate(input, 0, input.Length);
			return global::Org.BouncyCastle.Security.MacUtilities.DoFinal(mac);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x000484A0 File Offset: 0x000466A0
		public static byte[] DoFinal(global::Org.BouncyCastle.Crypto.IMac mac)
		{
			byte[] b = new byte[mac.GetMacSize()];
			mac.DoFinal(b, 0);
			return b;
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x000484C3 File Offset: 0x000466C3
		public static byte[] DoFinal(global::Org.BouncyCastle.Crypto.IMac mac, byte[] input)
		{
			mac.BlockUpdate(input, 0, input.Length);
			return global::Org.BouncyCastle.Security.MacUtilities.DoFinal(mac);
		}

		// Token: 0x040008CF RID: 2255
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
