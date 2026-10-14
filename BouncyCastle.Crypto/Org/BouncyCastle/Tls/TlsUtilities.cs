using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Bsi;
using Org.BouncyCastle.Asn1.Eac;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200012F RID: 303
	public abstract class TlsUtilities
	{
		// Token: 0x06000B96 RID: 2966 RVA: 0x0002BA4A File Offset: 0x00029C4A
		private static void AddCertSigAlgOid(global::System.Collections.IDictionary d, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHash)
		{
			d[oid.Id] = sigAndHash;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0002BA59 File Offset: 0x00029C59
		private static void AddCertSigAlgOid(global::System.Collections.IDictionary d, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, short hashAlgorithm, short signatureAlgorithm)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(d, oid, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(hashAlgorithm, signatureAlgorithm));
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0002BA6C File Offset: 0x00029C6C
		private static global::System.Collections.IDictionary CreateCertSigAlgOids()
		{
			global::System.Collections.IDictionary dictionary = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224, 3, 2);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256, 4, 2);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384, 5, 2);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512, 6, 2);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1, 2, 2);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.Sha1WithRsa, 2, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption, 2, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption, 3, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption, 4, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption, 5, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption, 6, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1, 2, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224, 3, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256, 4, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384, 5, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512, 6, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1, 2, 2);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_1, 2, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_224, 3, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_256, 4, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_384, 5, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_512, 6, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA_v1_5_SHA_1, 2, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA_v1_5_SHA_256, 4, 1);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA1, 2, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA224, 3, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA256, 4, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA384, 5, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA512, 6, 3);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed25519, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.ed25519);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed448, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.ed448);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_256, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.gostr34102012_256);
			global::Org.BouncyCastle.Tls.TlsUtilities.AddCertSigAlgOid(dictionary, global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_512, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.gostr34102012_512);
			return dictionary;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0002BC38 File Offset: 0x00029E38
		private static global::System.Collections.IList CreateDefaultSupportedSigAlgs()
		{
			global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.ed25519);
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.ed448);
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(4, 3));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(5, 3));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(6, 3));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_rsae_sha256);
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_rsae_sha384);
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_rsae_sha512);
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_pss_sha256);
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_pss_sha384);
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_pss_sha512);
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(4, 1));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(5, 1));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(6, 1));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(4, 2));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(5, 2));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(6, 2));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(3, 3));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(3, 1));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(3, 2));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(2, 3));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(2, 1));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(2, 2));
			return list;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0002BD7C File Offset: 0x00029F7C
		public static void CheckUint8(short i)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint8(i))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0002BD8E File Offset: 0x00029F8E
		public static void CheckUint8(int i)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint8(i))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		public static void CheckUint8(long i)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint8(i))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0002BDB2 File Offset: 0x00029FB2
		public static void CheckUint16(int i)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint16(i))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0002BDC4 File Offset: 0x00029FC4
		public static void CheckUint16(long i)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint16(i))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0002BDD6 File Offset: 0x00029FD6
		public static void CheckUint24(int i)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint24(i))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0002BDE8 File Offset: 0x00029FE8
		public static void CheckUint24(long i)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint24(i))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0002BDFA File Offset: 0x00029FFA
		public static void CheckUint32(long i)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint32(i))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0002BE0C File Offset: 0x0002A00C
		public static void CheckUint48(long i)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint48(i))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0002BE1E File Offset: 0x0002A01E
		public static void CheckUint64(long i)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint64(i))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0002BE30 File Offset: 0x0002A030
		public static bool IsValidUint8(short i)
		{
			return (i & 255) == i;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0002BE3C File Offset: 0x0002A03C
		public static bool IsValidUint8(int i)
		{
			return (i & 255) == i;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0002BE48 File Offset: 0x0002A048
		public static bool IsValidUint8(long i)
		{
			return (i & 255L) == i;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0002BE55 File Offset: 0x0002A055
		public static bool IsValidUint16(int i)
		{
			return (i & 65535) == i;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0002BE61 File Offset: 0x0002A061
		public static bool IsValidUint16(long i)
		{
			return (i & 65535L) == i;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0002BE6E File Offset: 0x0002A06E
		public static bool IsValidUint24(int i)
		{
			return (i & 16777215) == i;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0002BE7A File Offset: 0x0002A07A
		public static bool IsValidUint24(long i)
		{
			return (i & 16777215L) == i;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0002BE87 File Offset: 0x0002A087
		public static bool IsValidUint32(long i)
		{
			return (i & (long)((ulong)-1)) == i;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0002BE90 File Offset: 0x0002A090
		public static bool IsValidUint48(long i)
		{
			return (i & 281474976710655L) == i;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0002BEA0 File Offset: 0x0002A0A0
		public static bool IsValidUint64(long i)
		{
			return true;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0002BEA3 File Offset: 0x0002A0A3
		public static bool IsSsl(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			return context.ServerVersion.IsSsl;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
		public static bool IsTlsV10(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0002BEC2 File Offset: 0x0002A0C2
		public static bool IsTlsV10(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV10(context.ServerVersion);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0002BECF File Offset: 0x0002A0CF
		public static bool IsTlsV11(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv11.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0002BEE1 File Offset: 0x0002A0E1
		public static bool IsTlsV11(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV11(context.ServerVersion);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0002BEEE File Offset: 0x0002A0EE
		public static bool IsTlsV12(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0002BF00 File Offset: 0x0002A100
		public static bool IsTlsV12(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(context.ServerVersion);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0002BF0D File Offset: 0x0002A10D
		public static bool IsTlsV13(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0002BF1F File Offset: 0x0002A11F
		public static bool IsTlsV13(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(context.ServerVersion);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0002BF2C File Offset: 0x0002A12C
		public static void WriteUint8(short i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)i);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0002BF36 File Offset: 0x0002A136
		public static void WriteUint8(int i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)i);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0002BF40 File Offset: 0x0002A140
		public static void WriteUint8(short i, byte[] buf, int offset)
		{
			buf[offset] = (byte)i;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0002BF47 File Offset: 0x0002A147
		public static void WriteUint8(int i, byte[] buf, int offset)
		{
			buf[offset] = (byte)i;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0002BF4E File Offset: 0x0002A14E
		public static void WriteUint16(int i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)(i >> 8));
			output.WriteByte((byte)i);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0002BF62 File Offset: 0x0002A162
		public static void WriteUint16(int i, byte[] buf, int offset)
		{
			buf[offset] = (byte)(i >> 8);
			buf[offset + 1] = (byte)i;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0002BF72 File Offset: 0x0002A172
		public static void WriteUint24(int i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)(i >> 16));
			output.WriteByte((byte)(i >> 8));
			output.WriteByte((byte)i);
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0002BF91 File Offset: 0x0002A191
		public static void WriteUint24(int i, byte[] buf, int offset)
		{
			buf[offset] = (byte)(i >> 16);
			buf[offset + 1] = (byte)(i >> 8);
			buf[offset + 2] = (byte)i;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0002BFAB File Offset: 0x0002A1AB
		public static void WriteUint32(long i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)(i >> 24));
			output.WriteByte((byte)(i >> 16));
			output.WriteByte((byte)(i >> 8));
			output.WriteByte((byte)i);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0002BFD5 File Offset: 0x0002A1D5
		public static void WriteUint32(long i, byte[] buf, int offset)
		{
			buf[offset] = (byte)(i >> 24);
			buf[offset + 1] = (byte)(i >> 16);
			buf[offset + 2] = (byte)(i >> 8);
			buf[offset + 3] = (byte)i;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0002BFF9 File Offset: 0x0002A1F9
		public static void WriteUint48(long i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)(i >> 40));
			output.WriteByte((byte)(i >> 32));
			output.WriteByte((byte)(i >> 24));
			output.WriteByte((byte)(i >> 16));
			output.WriteByte((byte)(i >> 8));
			output.WriteByte((byte)i);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0002C039 File Offset: 0x0002A239
		public static void WriteUint48(long i, byte[] buf, int offset)
		{
			buf[offset] = (byte)(i >> 40);
			buf[offset + 1] = (byte)(i >> 32);
			buf[offset + 2] = (byte)(i >> 24);
			buf[offset + 3] = (byte)(i >> 16);
			buf[offset + 4] = (byte)(i >> 8);
			buf[offset + 5] = (byte)i;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0002C074 File Offset: 0x0002A274
		public static void WriteUint64(long i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)(i >> 56));
			output.WriteByte((byte)(i >> 48));
			output.WriteByte((byte)(i >> 40));
			output.WriteByte((byte)(i >> 32));
			output.WriteByte((byte)(i >> 24));
			output.WriteByte((byte)(i >> 16));
			output.WriteByte((byte)(i >> 8));
			output.WriteByte((byte)i);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0002C0D8 File Offset: 0x0002A2D8
		public static void WriteUint64(long i, byte[] buf, int offset)
		{
			buf[offset] = (byte)(i >> 56);
			buf[offset + 1] = (byte)(i >> 48);
			buf[offset + 2] = (byte)(i >> 40);
			buf[offset + 3] = (byte)(i >> 32);
			buf[offset + 4] = (byte)(i >> 24);
			buf[offset + 5] = (byte)(i >> 16);
			buf[offset + 6] = (byte)(i >> 8);
			buf[offset + 7] = (byte)i;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0002C12F File Offset: 0x0002A32F
		public static void WriteOpaque8(byte[] buf, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(buf.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(buf.Length, output);
			output.Write(buf, 0, buf.Length);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0002C14D File Offset: 0x0002A34D
		public static void WriteOpaque8(byte[] data, byte[] buf, int off)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(data.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(data.Length, buf, off);
			global::System.Array.Copy(data, 0, buf, off + 1, data.Length);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0002C16F File Offset: 0x0002A36F
		public static void WriteOpaque16(byte[] buf, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(buf.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(buf.Length, output);
			output.Write(buf, 0, buf.Length);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0002C18D File Offset: 0x0002A38D
		public static void WriteOpaque16(byte[] data, byte[] buf, int off)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(data.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(data.Length, buf, off);
			global::System.Array.Copy(data, 0, buf, off + 2, data.Length);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0002C1AF File Offset: 0x0002A3AF
		public static void WriteOpaque24(byte[] buf, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint24(buf.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(buf.Length, output);
			output.Write(buf, 0, buf.Length);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0002C1CD File Offset: 0x0002A3CD
		public static void WriteOpaque24(byte[] data, byte[] buf, int off)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint24(data.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(data.Length, buf, off);
			global::System.Array.Copy(data, 0, buf, off + 3, data.Length);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0002C1F0 File Offset: 0x0002A3F0
		public static void WriteUint8Array(short[] u8s, global::System.IO.Stream output)
		{
			for (int i = 0; i < u8s.Length; i++)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(u8s[i], output);
			}
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0002C214 File Offset: 0x0002A414
		public static void WriteUint8Array(short[] u8s, byte[] buf, int offset)
		{
			for (int i = 0; i < u8s.Length; i++)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(u8s[i], buf, offset);
				offset++;
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0002C23E File Offset: 0x0002A43E
		public static void WriteUint8ArrayWithUint8Length(short[] u8s, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(u8s.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(u8s.Length, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8Array(u8s, output);
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0002C258 File Offset: 0x0002A458
		public static void WriteUint8ArrayWithUint8Length(short[] u8s, byte[] buf, int offset)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(u8s.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(u8s.Length, buf, offset);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8Array(u8s, buf, offset + 1);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0002C278 File Offset: 0x0002A478
		public static void WriteUint16Array(int[] u16s, global::System.IO.Stream output)
		{
			for (int i = 0; i < u16s.Length; i++)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(u16s[i], output);
			}
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0002C29C File Offset: 0x0002A49C
		public static void WriteUint16Array(int[] u16s, byte[] buf, int offset)
		{
			for (int i = 0; i < u16s.Length; i++)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(u16s[i], buf, offset);
				offset += 2;
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0002C2C6 File Offset: 0x0002A4C6
		public static void WriteUint16ArrayWithUint16Length(int[] u16s, global::System.IO.Stream output)
		{
			int i = 2 * u16s.Length;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(i);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(i, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16Array(u16s, output);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
		public static void WriteUint16ArrayWithUint16Length(int[] u16s, byte[] buf, int offset)
		{
			int i = 2 * u16s.Length;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(i);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(i, buf, offset);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16Array(u16s, buf, offset + 2);
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0002C2FE File Offset: 0x0002A4FE
		public static byte[] DecodeOpaque8(byte[] buf)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.DecodeOpaque8(buf, 0);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0002C308 File Offset: 0x0002A508
		public static byte[] DecodeOpaque8(byte[] buf, int minLength)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("buf");
			}
			if (buf.Length < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			short length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(buf, 0);
			if (buf.Length != (int)(length + 1) || (int)length < minLength)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.CopyOfRangeExact(buf, 1, buf.Length);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0002C357 File Offset: 0x0002A557
		public static byte[] DecodeOpaque16(byte[] buf)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.DecodeOpaque16(buf, 0);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0002C360 File Offset: 0x0002A560
		public static byte[] DecodeOpaque16(byte[] buf, int minLength)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("buf");
			}
			if (buf.Length < 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf, 0);
			if (buf.Length != length + 2 || length < minLength)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.CopyOfRangeExact(buf, 2, buf.Length);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0002C3AF File Offset: 0x0002A5AF
		public static short DecodeUint8(byte[] buf)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("buf");
			}
			if (buf.Length != 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(buf, 0);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0002C3D4 File Offset: 0x0002A5D4
		public static short[] DecodeUint8ArrayWithUint8Length(byte[] buf)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("buf");
			}
			int count = (int)global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(buf, 0);
			if (buf.Length != count + 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			short[] uints = new short[count];
			for (int i = 0; i < count; i++)
			{
				uints[i] = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(buf, i + 1);
			}
			return uints;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0002C427 File Offset: 0x0002A627
		public static int DecodeUint16(byte[] buf)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("buf");
			}
			if (buf.Length != 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf, 0);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0002C44C File Offset: 0x0002A64C
		public static long DecodeUint32(byte[] buf)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("buf");
			}
			if (buf.Length != 4)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint32(buf, 0);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0002C471 File Offset: 0x0002A671
		public static byte[] EncodeOpaque8(byte[] buf)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(buf.Length);
			return global::Org.BouncyCastle.Utilities.Arrays.Prepend(buf, (byte)buf.Length);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0002C488 File Offset: 0x0002A688
		public static byte[] EncodeOpaque16(byte[] buf)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(buf.Length);
			byte[] r = new byte[2 + buf.Length];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(buf.Length, r, 0);
			global::System.Array.Copy(buf, 0, r, 2, buf.Length);
			return r;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
		public static byte[] EncodeOpaque24(byte[] buf)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint24(buf.Length);
			byte[] r = new byte[3 + buf.Length];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(buf.Length, r, 0);
			global::System.Array.Copy(buf, 0, r, 3, buf.Length);
			return r;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0002C4F8 File Offset: 0x0002A6F8
		public static byte[] EncodeUint8(short u8)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(u8);
			byte[] encoding = new byte[1];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(u8, encoding, 0);
			return encoding;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0002C51C File Offset: 0x0002A71C
		public static byte[] EncodeUint8ArrayWithUint8Length(short[] u8s)
		{
			byte[] result = new byte[1 + u8s.Length];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8ArrayWithUint8Length(u8s, result, 0);
			return result;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0002C540 File Offset: 0x0002A740
		public static byte[] EncodeUint16(int u16)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(u16);
			byte[] encoding = new byte[2];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(u16, encoding, 0);
			return encoding;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0002C564 File Offset: 0x0002A764
		public static byte[] EncodeUint16ArrayWithUint16Length(int[] u16s)
		{
			int length = 2 * u16s.Length;
			byte[] result = new byte[2 + length];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16ArrayWithUint16Length(u16s, result, 0);
			return result;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0002C58C File Offset: 0x0002A78C
		public static byte[] EncodeUint24(int u24)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint24(u24);
			byte[] encoding = new byte[3];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(u24, encoding, 0);
			return encoding;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0002C5B0 File Offset: 0x0002A7B0
		public static byte[] EncodeUint32(long u32)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint32(u32);
			byte[] encoding = new byte[4];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint32(u32, encoding, 0);
			return encoding;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0002C5D3 File Offset: 0x0002A7D3
		public static byte[] EncodeVersion(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return new byte[]
			{
				(byte)version.MajorVersion,
				(byte)version.MinorVersion
			};
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0002C5EF File Offset: 0x0002A7EF
		public static int ReadInt32(byte[] buf, int offset)
		{
			return (int)buf[offset] << 24 | (int)(buf[++offset] & byte.MaxValue) << 16 | (int)(buf[++offset] & byte.MaxValue) << 8 | (int)(buf[++offset] & byte.MaxValue);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0002C629 File Offset: 0x0002A829
		public static short ReadUint8(global::System.IO.Stream input)
		{
			int num = input.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return (short)num;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0002C63C File Offset: 0x0002A83C
		public static short ReadUint8(byte[] buf, int offset)
		{
			return (short)(buf[offset] & byte.MaxValue);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0002C648 File Offset: 0x0002A848
		public static int ReadUint16(global::System.IO.Stream input)
		{
			int num = input.ReadByte();
			int i2 = input.ReadByte();
			if (i2 < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return num << 8 | i2;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0002C670 File Offset: 0x0002A870
		public static int ReadUint16(byte[] buf, int offset)
		{
			return (int)(buf[offset] & byte.MaxValue) << 8 | (int)(buf[++offset] & byte.MaxValue);
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0002C68C File Offset: 0x0002A88C
		public static int ReadUint24(global::System.IO.Stream input)
		{
			int num = input.ReadByte();
			int i2 = input.ReadByte();
			int i3 = input.ReadByte();
			if (i3 < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return num << 16 | i2 << 8 | i3;
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0002C6C0 File Offset: 0x0002A8C0
		public static int ReadUint24(byte[] buf, int offset)
		{
			return (int)(buf[offset] & byte.MaxValue) << 16 | (int)(buf[++offset] & byte.MaxValue) << 8 | (int)(buf[++offset] & byte.MaxValue);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0002C6F0 File Offset: 0x0002A8F0
		public static long ReadUint32(global::System.IO.Stream input)
		{
			int num = input.ReadByte();
			int i2 = input.ReadByte();
			int i3 = input.ReadByte();
			int i4 = input.ReadByte();
			if (i4 < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return (long)(num << 24 | i2 << 16 | i3 << 8 | i4) & (long)((ulong)-1);
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0002C734 File Offset: 0x0002A934
		public static long ReadUint32(byte[] buf, int offset)
		{
			return (long)((int)(buf[offset] & byte.MaxValue) << 24 | (int)(buf[++offset] & byte.MaxValue) << 16 | (int)(buf[++offset] & byte.MaxValue) << 8 | (int)(buf[++offset] & byte.MaxValue)) & (long)((ulong)-1);
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0002C784 File Offset: 0x0002A984
		public static long ReadUint48(global::System.IO.Stream input)
		{
			long num = (long)global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(input);
			int lo = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(input);
			return (num & (long)((ulong)-1)) << 24 | ((long)lo & (long)((ulong)-1));
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0002C7AC File Offset: 0x0002A9AC
		public static long ReadUint48(byte[] buf, int offset)
		{
			long num = (long)global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(buf, offset);
			int lo = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(buf, offset + 3);
			return (num & (long)((ulong)-1)) << 24 | ((long)lo & (long)((ulong)-1));
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
		public static byte[] ReadAllOrNothing(int length, global::System.IO.Stream input)
		{
			if (length < 1)
			{
				return global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
			}
			byte[] buf = new byte[length];
			int read = global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, buf);
			if (read == 0)
			{
				return null;
			}
			if (read != length)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return buf;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0002C810 File Offset: 0x0002AA10
		public static byte[] ReadFully(int length, global::System.IO.Stream input)
		{
			if (length < 1)
			{
				return global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
			}
			byte[] buf = new byte[length];
			if (length != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, buf))
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return buf;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0002C840 File Offset: 0x0002AA40
		public static void ReadFully(byte[] buf, global::System.IO.Stream input)
		{
			int length = buf.Length;
			if (length > 0 && length != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, buf))
			{
				throw new global::System.IO.EndOfStreamException();
			}
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0002C865 File Offset: 0x0002AA65
		public static byte[] ReadOpaque8(global::System.IO.Stream input)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully((int)global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input), input);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0002C873 File Offset: 0x0002AA73
		public static byte[] ReadOpaque8(global::System.IO.Stream input, int minLength)
		{
			short num = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			if ((int)num < minLength)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully((int)num, input);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0002C890 File Offset: 0x0002AA90
		public static byte[] ReadOpaque8(global::System.IO.Stream input, int minLength, int maxLength)
		{
			short length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			if ((int)length < minLength || maxLength < (int)length)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully((int)length, input);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0002C8BB File Offset: 0x0002AABB
		public static byte[] ReadOpaque16(global::System.IO.Stream input)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input), input);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0002C8C9 File Offset: 0x0002AAC9
		public static byte[] ReadOpaque16(global::System.IO.Stream input, int minLength)
		{
			int num = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			if (num < minLength)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(num, input);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0002C8E3 File Offset: 0x0002AAE3
		public static byte[] ReadOpaque24(global::System.IO.Stream input)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(input), input);
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0002C8F1 File Offset: 0x0002AAF1
		public static byte[] ReadOpaque24(global::System.IO.Stream input, int minLength)
		{
			int num = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint24(input);
			if (num < minLength)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(num, input);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0002C90C File Offset: 0x0002AB0C
		public static short[] ReadUint8Array(int count, global::System.IO.Stream input)
		{
			short[] uints = new short[count];
			for (int i = 0; i < count; i++)
			{
				uints[i] = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			}
			return uints;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0002C936 File Offset: 0x0002AB36
		public static short[] ReadUint8ArrayWithUint8Length(global::System.IO.Stream input, int minLength)
		{
			short num = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input);
			if ((int)num < minLength)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8Array((int)num, input);
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0002C950 File Offset: 0x0002AB50
		public static int[] ReadUint16Array(int count, global::System.IO.Stream input)
		{
			int[] uints = new int[count];
			for (int i = 0; i < count; i++)
			{
				uints[i] = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			}
			return uints;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0002C97A File Offset: 0x0002AB7A
		public static global::Org.BouncyCastle.Tls.ProtocolVersion ReadVersion(byte[] buf, int offset)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.Get((int)buf[offset], (int)buf[offset + 1]);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0002C98C File Offset: 0x0002AB8C
		public static global::Org.BouncyCastle.Tls.ProtocolVersion ReadVersion(global::System.IO.Stream input)
		{
			int major = input.ReadByte();
			int i2 = input.ReadByte();
			if (i2 < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return global::Org.BouncyCastle.Tls.ProtocolVersion.Get(major, i2);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
		public static global::Org.BouncyCastle.Asn1.Asn1Object ReadAsn1Object(byte[] encoding)
		{
			global::Org.BouncyCastle.Asn1.Asn1InputStream asn = new global::Org.BouncyCastle.Asn1.Asn1InputStream(encoding);
			global::Org.BouncyCastle.Asn1.Asn1Object result = asn.ReadObject();
			if (result == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			if (asn.ReadObject() != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return result;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0002C9EF File Offset: 0x0002ABEF
		public static global::Org.BouncyCastle.Asn1.Asn1Object ReadDerObject(byte[] encoding)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object asn1Object = global::Org.BouncyCastle.Tls.TlsUtilities.ReadAsn1Object(encoding);
			if (!global::Org.BouncyCastle.Utilities.Arrays.AreEqual(asn1Object.GetEncoded("DER"), encoding))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return asn1Object;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0002CA14 File Offset: 0x0002AC14
		public static void WriteGmtUnixTime(byte[] buf, int offset)
		{
			int t = (int)(global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs() / 1000L);
			buf[offset] = (byte)(t >> 24);
			buf[offset + 1] = (byte)(t >> 16);
			buf[offset + 2] = (byte)(t >> 8);
			buf[offset + 3] = (byte)t;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0002CA51 File Offset: 0x0002AC51
		public static void WriteVersion(global::Org.BouncyCastle.Tls.ProtocolVersion version, global::System.IO.Stream output)
		{
			output.WriteByte((byte)version.MajorVersion);
			output.WriteByte((byte)version.MinorVersion);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0002CA6D File Offset: 0x0002AC6D
		public static void WriteVersion(global::Org.BouncyCastle.Tls.ProtocolVersion version, byte[] buf, int offset)
		{
			buf[offset] = (byte)version.MajorVersion;
			buf[offset + 1] = (byte)version.MinorVersion;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0002CA85 File Offset: 0x0002AC85
		public static void AddIfSupported(global::System.Collections.IList supportedAlgs, global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm alg)
		{
			if (crypto.HasSignatureAndHashAlgorithm(alg))
			{
				supportedAlgs.Add(alg);
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0002CA98 File Offset: 0x0002AC98
		public static void AddIfSupported(global::System.Collections.IList supportedGroups, global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, int namedGroup)
		{
			if (crypto.HasNamedGroup(namedGroup))
			{
				supportedGroups.Add(namedGroup);
			}
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0002CAB0 File Offset: 0x0002ACB0
		public static void AddIfSupported(global::System.Collections.IList supportedGroups, global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, int[] namedGroups)
		{
			for (int i = 0; i < namedGroups.Length; i++)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.AddIfSupported(supportedGroups, crypto, namedGroups[i]);
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0002CAD5 File Offset: 0x0002ACD5
		public static bool AddToSet(global::System.Collections.IList s, int i)
		{
			bool flag = !s.Contains(i);
			if (flag)
			{
				s.Add(i);
			}
			return flag;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0002CAF6 File Offset: 0x0002ACF6
		public static global::System.Collections.IList GetDefaultDssSignatureAlgorithms()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetDefaultSignatureAlgorithms(2);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0002CAFE File Offset: 0x0002ACFE
		public static global::System.Collections.IList GetDefaultECDsaSignatureAlgorithms()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetDefaultSignatureAlgorithms(3);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0002CB06 File Offset: 0x0002AD06
		public static global::System.Collections.IList GetDefaultRsaSignatureAlgorithms()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetDefaultSignatureAlgorithms(1);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0002CB0E File Offset: 0x0002AD0E
		public static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm GetDefaultSignatureAlgorithm(short signatureAlgorithm)
		{
			if (signatureAlgorithm - 1 <= 2)
			{
				return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(2, signatureAlgorithm);
			}
			return null;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0002CB20 File Offset: 0x0002AD20
		public static global::System.Collections.IList GetDefaultSignatureAlgorithms(short signatureAlgorithm)
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlg = global::Org.BouncyCastle.Tls.TlsUtilities.GetDefaultSignatureAlgorithm(signatureAlgorithm);
			if (sigAndHashAlg != null)
			{
				return global::Org.BouncyCastle.Tls.TlsUtilities.VectorOfOne(sigAndHashAlg);
			}
			return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0002CB44 File Offset: 0x0002AD44
		public static global::System.Collections.IList GetDefaultSupportedSignatureAlgorithms(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto = context.Crypto;
			global::System.Collections.IList result = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(global::Org.BouncyCastle.Tls.TlsUtilities.DefaultSupportedSigAlgs.Count);
			foreach (object obj in global::Org.BouncyCastle.Tls.TlsUtilities.DefaultSupportedSigAlgs)
			{
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlg = (global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm)obj;
				global::Org.BouncyCastle.Tls.TlsUtilities.AddIfSupported(result, crypto, sigAndHashAlg);
			}
			return result;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
		public static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.TlsCredentialedSigner signerCredentials)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetSignatureAndHashAlgorithm(context.ServerVersion, signerCredentials);
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
		internal static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion, global::Org.BouncyCastle.Tls.TlsCredentialedSigner signerCredentials)
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = null;
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(negotiatedVersion))
			{
				signatureAndHashAlgorithm = signerCredentials.SignatureAndHashAlgorithm;
				if (signatureAndHashAlgorithm == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
			}
			return signatureAndHashAlgorithm;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0002CBF2 File Offset: 0x0002ADF2
		public static byte[] GetExtensionData(global::System.Collections.IDictionary extensions, int extensionType)
		{
			if (extensions != null && extensions.Contains(extensionType))
			{
				return (byte[])extensions[extensionType];
			}
			return null;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0002CC18 File Offset: 0x0002AE18
		public static bool HasExpectedEmptyExtensionData(global::System.Collections.IDictionary extensions, int extensionType, short alertDescription)
		{
			byte[] extension_data = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, extensionType);
			if (extension_data == null)
			{
				return false;
			}
			if (extension_data.Length != 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(alertDescription);
			}
			return true;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0002CC3E File Offset: 0x0002AE3E
		public static global::Org.BouncyCastle.Tls.TlsSession ImportSession(byte[] sessionID, global::Org.BouncyCastle.Tls.SessionParameters sessionParameters)
		{
			return new global::Org.BouncyCastle.Tls.TlsSessionImpl(sessionID, sessionParameters);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0002CC47 File Offset: 0x0002AE47
		internal static bool IsExtendedMasterSecretOptionalDtls(global::Org.BouncyCastle.Tls.ProtocolVersion[] activeProtocolVersions)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(activeProtocolVersions, global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12) || global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(activeProtocolVersions, global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv10);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0002CC63 File Offset: 0x0002AE63
		internal static bool IsExtendedMasterSecretOptionalTls(global::Org.BouncyCastle.Tls.ProtocolVersion[] activeProtocolVersions)
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(activeProtocolVersions, global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12) || global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(activeProtocolVersions, global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv11) || global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(activeProtocolVersions, global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0002CC8C File Offset: 0x0002AE8C
		public static bool IsNullOrContainsNull(object[] array)
		{
			if (array == null)
			{
				return true;
			}
			int count = array.Length;
			for (int i = 0; i < count; i++)
			{
				if (array[i] == null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0002CCB6 File Offset: 0x0002AEB6
		public static bool IsNullOrEmpty(byte[] array)
		{
			return array == null || array.Length < 1;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0002CCC3 File Offset: 0x0002AEC3
		public static bool IsNullOrEmpty(short[] array)
		{
			return array == null || array.Length < 1;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0002CCD0 File Offset: 0x0002AED0
		public static bool IsNullOrEmpty(int[] array)
		{
			return array == null || array.Length < 1;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0002CCDD File Offset: 0x0002AEDD
		public static bool IsNullOrEmpty(object[] array)
		{
			return array == null || array.Length < 1;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0002CCEA File Offset: 0x0002AEEA
		public static bool IsNullOrEmpty(string s)
		{
			return s == null || s.Length < 1;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0002CCFA File Offset: 0x0002AEFA
		public static bool IsNullOrEmpty(global::System.Collections.IList v)
		{
			return v == null || v.Count < 1;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0002CD0A File Offset: 0x0002AF0A
		public static bool IsSignatureAlgorithmsExtensionAllowed(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			return version != null && global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version.GetEquivalentTlsVersion());
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0002CD21 File Offset: 0x0002AF21
		public static short GetLegacyClientCertType(short signatureAlgorithm)
		{
			switch (signatureAlgorithm)
			{
			case 1:
				return 1;
			case 2:
				return 2;
			case 3:
				return 64;
			default:
				return -1;
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0002CD41 File Offset: 0x0002AF41
		public static short GetLegacySignatureAlgorithmClient(short clientCertificateType)
		{
			if (clientCertificateType == 1)
			{
				return 1;
			}
			if (clientCertificateType == 2)
			{
				return 2;
			}
			if (clientCertificateType != 64)
			{
				return -1;
			}
			return 3;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0002CD59 File Offset: 0x0002AF59
		public static short GetLegacySignatureAlgorithmClientCert(short clientCertificateType)
		{
			switch (clientCertificateType)
			{
			case 1:
			case 3:
				break;
			case 2:
			case 4:
				return 2;
			default:
				switch (clientCertificateType)
				{
				case 64:
				case 66:
					return 3;
				case 65:
					break;
				default:
					return -1;
				}
				break;
			}
			return 1;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0002CD91 File Offset: 0x0002AF91
		public static short GetLegacySignatureAlgorithmServer(int keyExchangeAlgorithm)
		{
			if (keyExchangeAlgorithm != 3)
			{
				if (keyExchangeAlgorithm != 5)
				{
					switch (keyExchangeAlgorithm)
					{
					case 17:
						return 3;
					case 19:
					case 23:
						return 1;
					case 22:
						return 2;
					}
					return -1;
				}
				return 1;
			}
			return 2;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0002CDCC File Offset: 0x0002AFCC
		public static short GetLegacySignatureAlgorithmServerCert(int keyExchangeAlgorithm)
		{
			switch (keyExchangeAlgorithm)
			{
			case 1:
			case 5:
			case 9:
			case 15:
			case 18:
			case 19:
			case 23:
				return 1;
			case 3:
			case 7:
			case 22:
				return 2;
			case 16:
			case 17:
				return 3;
			}
			return -1;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0002CE46 File Offset: 0x0002B046
		public static global::System.Collections.IList GetLegacySupportedSignatureAlgorithms()
		{
			global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(3);
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(2, 2));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(2, 3));
			list.Add(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(2, 1));
			return list;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0002CE78 File Offset: 0x0002B078
		public static void EncodeSupportedSignatureAlgorithms(global::System.Collections.IList supportedSignatureAlgorithms, global::System.IO.Stream output)
		{
			if (supportedSignatureAlgorithms == null || supportedSignatureAlgorithms.Count < 1 || supportedSignatureAlgorithms.Count >= 32768)
			{
				throw new global::System.ArgumentException("must have length from 1 to (2^15 - 1)", "supportedSignatureAlgorithms");
			}
			int i = 2 * supportedSignatureAlgorithms.Count;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(i);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(i, output);
			foreach (object obj in supportedSignatureAlgorithms)
			{
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = (global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm)obj;
				if (signatureAndHashAlgorithm.Signature == 0)
				{
					throw new global::System.ArgumentException("SignatureAlgorithm.anonymous MUST NOT appear in the signature_algorithms extension");
				}
				signatureAndHashAlgorithm.Encode(output);
			}
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0002CF1C File Offset: 0x0002B11C
		public static global::System.Collections.IList ParseSupportedSignatureAlgorithms(global::System.IO.Stream input)
		{
			int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			if (length < 2 || (length & 1) != 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			int count = length / 2;
			global::System.Collections.IList supportedSignatureAlgorithms = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(count);
			for (int i = 0; i < count; i++)
			{
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlg = global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.Parse(input);
				if (sigAndHashAlg.Signature != 0)
				{
					supportedSignatureAlgorithms.Add(sigAndHashAlg);
				}
			}
			return supportedSignatureAlgorithms;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0002CF74 File Offset: 0x0002B174
		public static void VerifySupportedSignatureAlgorithm(global::System.Collections.IList supportedSignatureAlgorithms, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAlgorithm)
		{
			if (supportedSignatureAlgorithms == null || supportedSignatureAlgorithms.Count < 1 || supportedSignatureAlgorithms.Count >= 32768)
			{
				throw new global::System.ArgumentException("must have length from 1 to (2^15 - 1)", "supportedSignatureAlgorithms");
			}
			if (signatureAlgorithm == null)
			{
				throw new global::System.ArgumentNullException("signatureAlgorithm");
			}
			if (signatureAlgorithm.Signature == 0 || !global::Org.BouncyCastle.Tls.TlsUtilities.ContainsSignatureAlgorithm(supportedSignatureAlgorithms, signatureAlgorithm))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0002CFD4 File Offset: 0x0002B1D4
		public static bool ContainsSignatureAlgorithm(global::System.Collections.IList supportedSignatureAlgorithms, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAlgorithm)
		{
			using (global::System.Collections.IEnumerator enumerator = supportedSignatureAlgorithms.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm)enumerator.Current).Equals(signatureAlgorithm))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0002D030 File Offset: 0x0002B230
		public static bool ContainsAnySignatureAlgorithm(global::System.Collections.IList supportedSignatureAlgorithms, short signatureAlgorithm)
		{
			using (global::System.Collections.IEnumerator enumerator = supportedSignatureAlgorithms.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (((global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm)enumerator.Current).Signature == signatureAlgorithm)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0002D08C File Offset: 0x0002B28C
		public static global::Org.BouncyCastle.Tls.Crypto.TlsSecret Prf(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret, string asciiLabel, byte[] seed, int length)
		{
			return secret.DeriveUsingPrf(securityParameters.PrfAlgorithm, asciiLabel, seed, length);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0002D09E File Offset: 0x0002B29E
		public static byte[] Clone(byte[] data)
		{
			if (data == null)
			{
				return null;
			}
			if (data.Length != 0)
			{
				return (byte[])data.Clone();
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0002D0BA File Offset: 0x0002B2BA
		public static string[] Clone(string[] s)
		{
			if (s == null)
			{
				return null;
			}
			if (s.Length >= 1)
			{
				return (string[])s.Clone();
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EmptyStrings;
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0002D0D8 File Offset: 0x0002B2D8
		public static bool ConstantTimeAreEqual(int len, byte[] a, int aOff, byte[] b, int bOff)
		{
			int d = 0;
			for (int i = 0; i < len; i++)
			{
				d |= (int)(a[aOff + i] ^ b[bOff + i]);
			}
			return d == 0;
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0002D108 File Offset: 0x0002B308
		public static byte[] CopyOfRangeExact(byte[] original, int from, int to)
		{
			int newLength = to - from;
			byte[] copy = new byte[newLength];
			global::System.Array.Copy(original, from, copy, 0, newLength);
			return copy;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0002D12C File Offset: 0x0002B32C
		internal static byte[] Concat(byte[] a, byte[] b)
		{
			byte[] c = new byte[a.Length + b.Length];
			global::System.Array.Copy(a, 0, c, 0, a.Length);
			global::System.Array.Copy(b, 0, c, a.Length, b.Length);
			return c;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0002D161 File Offset: 0x0002B361
		internal static byte[] CalculateEndPointHash(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsCertificate certificate, byte[] enc)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.CalculateEndPointHash(context, certificate, enc, 0, enc.Length);
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0002D170 File Offset: 0x0002B370
		internal static byte[] CalculateEndPointHash(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsCertificate certificate, byte[] enc, int encOff, int encLen)
		{
			short hashAlgorithm = 0;
			string sigAlgOid = certificate.SigAlgOid;
			if (sigAlgOid != null)
			{
				if (global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss.Id.Equals(sigAlgOid))
				{
					global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters pssParams = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.GetInstance(certificate.GetSigAlgParams());
					if (pssParams != null)
					{
						global::Org.BouncyCastle.Asn1.DerObjectIdentifier hashOid = pssParams.HashAlgorithm.Algorithm;
						if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Equals(hashOid))
						{
							hashAlgorithm = 4;
						}
						else if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Equals(hashOid))
						{
							hashAlgorithm = 5;
						}
						else if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Equals(hashOid))
						{
							hashAlgorithm = 6;
						}
					}
				}
				else if (global::Org.BouncyCastle.Tls.TlsUtilities.CertSigAlgOids.Contains(sigAlgOid))
				{
					hashAlgorithm = ((global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm)global::Org.BouncyCastle.Tls.TlsUtilities.CertSigAlgOids[sigAlgOid]).Hash;
				}
			}
			if (hashAlgorithm - 1 > 1)
			{
				if (hashAlgorithm == 8)
				{
					hashAlgorithm = 0;
				}
			}
			else
			{
				hashAlgorithm = 4;
			}
			if (hashAlgorithm != 0)
			{
				global::Org.BouncyCastle.Tls.Crypto.TlsHash hash = global::Org.BouncyCastle.Tls.TlsUtilities.CreateHash(context.Crypto, hashAlgorithm);
				if (hash != null)
				{
					hash.Update(enc, encOff, encLen);
					return hash.CalculateHash();
				}
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0002D24C File Offset: 0x0002B44C
		public static byte[] CalculateExporterSeed(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, byte[] context)
		{
			byte[] cr = securityParameters.ClientRandom;
			byte[] sr = securityParameters.ServerRandom;
			if (context == null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(cr, sr);
			}
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint16(context.Length))
			{
				throw new global::System.ArgumentException("must have length less than 2^16 (or be null)", "context");
			}
			byte[] contextLength = new byte[2];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(context.Length, contextLength, 0);
			return global::Org.BouncyCastle.Utilities.Arrays.ConcatenateAll(new byte[][]
			{
				cr,
				sr,
				contextLength,
				context
			});
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0002D2B8 File Offset: 0x0002B4B8
		private static byte[] CalculateFinishedHmac(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, global::Org.BouncyCastle.Tls.Crypto.TlsSecret baseKey, byte[] transcriptHash)
		{
			int prfCryptoHashAlgorithm = securityParameters.PrfCryptoHashAlgorithm;
			int prfHashLength = securityParameters.PrfHashLength;
			return global::Org.BouncyCastle.Tls.TlsUtilities.CalculateFinishedHmac(prfCryptoHashAlgorithm, prfHashLength, baseKey, transcriptHash);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0002D2DC File Offset: 0x0002B4DC
		private static byte[] CalculateFinishedHmac(int prfCryptoHashAlgorithm, int prfHashLength, global::Org.BouncyCastle.Tls.Crypto.TlsSecret baseKey, byte[] transcriptHash)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret finishedKey = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.HkdfExpandLabel(baseKey, prfCryptoHashAlgorithm, "finished", global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, prfHashLength);
			byte[] result;
			try
			{
				result = finishedKey.CalculateHmac(prfCryptoHashAlgorithm, transcriptHash, 0, transcriptHash.Length);
			}
			finally
			{
				finishedKey.Destroy();
			}
			return result;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0002D324 File Offset: 0x0002B524
		internal static global::Org.BouncyCastle.Tls.Crypto.TlsSecret CalculateMasterSecret(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsSecret preMasterSecret)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters sp = context.SecurityParameters;
			string asciiLabel;
			byte[] seed;
			if (sp.IsExtendedMasterSecret)
			{
				asciiLabel = "extended master secret";
				seed = sp.SessionHash;
			}
			else
			{
				asciiLabel = "master secret";
				seed = global::Org.BouncyCastle.Tls.TlsUtilities.Concat(sp.ClientRandom, sp.ServerRandom);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.Prf(sp, preMasterSecret, asciiLabel, seed, 48);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0002D374 File Offset: 0x0002B574
		internal static byte[] CalculatePskBinder(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, bool isExternalPsk, int pskCryptoHashAlgorithm, global::Org.BouncyCastle.Tls.Crypto.TlsSecret earlySecret, byte[] transcriptHash)
		{
			int prfHashLength = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashOutputSize(pskCryptoHashAlgorithm);
			string label = isExternalPsk ? "ext binder" : "res binder";
			byte[] emptyTranscriptHash = crypto.CreateHash(pskCryptoHashAlgorithm).CalculateHash();
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret binderKey = global::Org.BouncyCastle.Tls.TlsUtilities.DeriveSecret(pskCryptoHashAlgorithm, prfHashLength, earlySecret, label, emptyTranscriptHash);
			byte[] result;
			try
			{
				result = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateFinishedHmac(pskCryptoHashAlgorithm, prfHashLength, binderKey, transcriptHash);
			}
			finally
			{
				binderKey.Destroy();
			}
			return result;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0002D3D8 File Offset: 0x0002B5D8
		internal static byte[] CalculateVerifyData(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash, bool isServer)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion))
			{
				global::Org.BouncyCastle.Tls.Crypto.TlsSecret baseKey = isServer ? securityParameters.BaseKeyServer : securityParameters.BaseKeyClient;
				byte[] transcriptHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(handshakeHash);
				return global::Org.BouncyCastle.Tls.TlsUtilities.CalculateFinishedHmac(securityParameters, baseKey, transcriptHash);
			}
			if (negotiatedVersion.IsSsl)
			{
				return global::Org.BouncyCastle.Tls.Ssl3Utilities.CalculateVerifyData(handshakeHash, isServer);
			}
			string asciiLabel = isServer ? "server finished" : "client finished";
			byte[] prfHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(handshakeHash);
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret master_secret = securityParameters.MasterSecret;
			int verify_data_length = securityParameters.VerifyDataLength;
			return global::Org.BouncyCastle.Tls.TlsUtilities.Prf(securityParameters, master_secret, asciiLabel, prfHash, verify_data_length).Extract();
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0002D46C File Offset: 0x0002B66C
		internal static void Establish13PhaseSecrets(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsSecret pskEarlySecret, global::Org.BouncyCastle.Tls.Crypto.TlsSecret sharedSecret)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto = context.Crypto;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			int cryptoHashAlgorithm = securityParameters.PrfCryptoHashAlgorithm;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret zeros = crypto.HkdfInit(cryptoHashAlgorithm);
			byte[] emptyTranscriptHash = crypto.CreateHash(cryptoHashAlgorithm).CalculateHash();
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret earlySecret = pskEarlySecret;
			if (earlySecret == null)
			{
				earlySecret = crypto.HkdfInit(cryptoHashAlgorithm).HkdfExtract(cryptoHashAlgorithm, zeros);
			}
			if (sharedSecret == null)
			{
				sharedSecret = zeros;
			}
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret handshakeSecret = global::Org.BouncyCastle.Tls.TlsUtilities.DeriveSecret(securityParameters, earlySecret, "derived", emptyTranscriptHash).HkdfExtract(cryptoHashAlgorithm, sharedSecret);
			if (sharedSecret != zeros)
			{
				sharedSecret.Destroy();
			}
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret masterSecret = global::Org.BouncyCastle.Tls.TlsUtilities.DeriveSecret(securityParameters, handshakeSecret, "derived", emptyTranscriptHash).HkdfExtract(cryptoHashAlgorithm, zeros);
			securityParameters.m_earlySecret = earlySecret;
			securityParameters.m_handshakeSecret = handshakeSecret;
			securityParameters.m_masterSecret = masterSecret;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0002D514 File Offset: 0x0002B714
		private static void Establish13TrafficSecrets(global::Org.BouncyCastle.Tls.TlsContext context, byte[] transcriptHash, global::Org.BouncyCastle.Tls.Crypto.TlsSecret phaseSecret, string clientLabel, string serverLabel, global::Org.BouncyCastle.Tls.RecordStream recordStream)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			securityParameters.m_trafficSecretClient = global::Org.BouncyCastle.Tls.TlsUtilities.DeriveSecret(securityParameters, phaseSecret, clientLabel, transcriptHash);
			if (serverLabel != null)
			{
				securityParameters.m_trafficSecretServer = global::Org.BouncyCastle.Tls.TlsUtilities.DeriveSecret(securityParameters, phaseSecret, serverLabel, transcriptHash);
			}
			recordStream.SetPendingCipher(global::Org.BouncyCastle.Tls.TlsUtilities.InitCipher(context));
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0002D558 File Offset: 0x0002B758
		internal static void Establish13PhaseApplication(global::Org.BouncyCastle.Tls.TlsContext context, byte[] serverFinishedTranscriptHash, global::Org.BouncyCastle.Tls.RecordStream recordStream)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret phaseSecret = securityParameters.MasterSecret;
			global::Org.BouncyCastle.Tls.TlsUtilities.Establish13TrafficSecrets(context, serverFinishedTranscriptHash, phaseSecret, "c ap traffic", "s ap traffic", recordStream);
			securityParameters.m_exporterMasterSecret = global::Org.BouncyCastle.Tls.TlsUtilities.DeriveSecret(securityParameters, phaseSecret, "exp master", serverFinishedTranscriptHash);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0002D598 File Offset: 0x0002B798
		internal static void Establish13PhaseEarly(global::Org.BouncyCastle.Tls.TlsContext context, byte[] clientHelloTranscriptHash, global::Org.BouncyCastle.Tls.RecordStream recordStream)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret phaseSecret = securityParameters.EarlySecret;
			if (recordStream != null)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.Establish13TrafficSecrets(context, clientHelloTranscriptHash, phaseSecret, "c e traffic", null, recordStream);
			}
			securityParameters.m_earlyExporterMasterSecret = global::Org.BouncyCastle.Tls.TlsUtilities.DeriveSecret(securityParameters, phaseSecret, "e exp master", clientHelloTranscriptHash);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0002D5D8 File Offset: 0x0002B7D8
		internal static void Establish13PhaseHandshake(global::Org.BouncyCastle.Tls.TlsContext context, byte[] serverHelloTranscriptHash, global::Org.BouncyCastle.Tls.RecordStream recordStream)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret phaseSecret = securityParameters.HandshakeSecret;
			global::Org.BouncyCastle.Tls.TlsUtilities.Establish13TrafficSecrets(context, serverHelloTranscriptHash, phaseSecret, "c hs traffic", "s hs traffic", recordStream);
			securityParameters.m_baseKeyClient = securityParameters.TrafficSecretClient;
			securityParameters.m_baseKeyServer = securityParameters.TrafficSecretServer;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0002D61C File Offset: 0x0002B81C
		internal static void Update13TrafficSecretLocal(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.Update13TrafficSecret(context, context.IsServer);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0002D62A File Offset: 0x0002B82A
		internal static void Update13TrafficSecretPeer(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.Update13TrafficSecret(context, !context.IsServer);
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0002D63C File Offset: 0x0002B83C
		private static void Update13TrafficSecret(global::Org.BouncyCastle.Tls.TlsContext context, bool forServer)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret current;
			if (forServer)
			{
				current = securityParameters.TrafficSecretServer;
				securityParameters.m_trafficSecretServer = global::Org.BouncyCastle.Tls.TlsUtilities.Update13TrafficSecret(securityParameters, current);
			}
			else
			{
				current = securityParameters.TrafficSecretClient;
				securityParameters.m_trafficSecretClient = global::Org.BouncyCastle.Tls.TlsUtilities.Update13TrafficSecret(securityParameters, current);
			}
			if (current != null)
			{
				current.Destroy();
			}
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0002D686 File Offset: 0x0002B886
		private static global::Org.BouncyCastle.Tls.Crypto.TlsSecret Update13TrafficSecret(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret)
		{
			return global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.HkdfExpandLabel(secret, securityParameters.PrfCryptoHashAlgorithm, "traffic upd", global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, securityParameters.PrfHashLength);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0002D6A4 File Offset: 0x0002B8A4
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOidForHashAlgorithm(short hashAlgorithm)
		{
			switch (hashAlgorithm)
			{
			case 1:
				return global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5;
			case 2:
				return global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdSha1;
			case 3:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224;
			case 4:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256;
			case 5:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384;
			case 6:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512;
			default:
				throw new global::System.ArgumentException("invalid HashAlgorithm: " + global::Org.BouncyCastle.Tls.HashAlgorithm.GetText(hashAlgorithm));
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0002D70C File Offset: 0x0002B90C
		internal static int GetPrfAlgorithm(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, int cipherSuite)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			bool isTlsV13 = global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion);
			bool isTlsV12Exactly = !isTlsV13 && global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(negotiatedVersion);
			bool isSsl = negotiatedVersion.IsSsl;
			if (cipherSuite <= 199)
			{
				if (cipherSuite - 59 > 5 && cipherSuite - 103 > 6)
				{
					switch (cipherSuite)
					{
					case 156:
					case 158:
					case 160:
					case 162:
					case 164:
					case 166:
					case 168:
					case 170:
					case 172:
					case 186:
					case 187:
					case 188:
					case 189:
					case 190:
					case 191:
					case 192:
					case 193:
					case 194:
					case 195:
					case 196:
					case 197:
						break;
					case 157:
					case 159:
					case 161:
					case 163:
					case 165:
					case 167:
					case 169:
					case 171:
					case 173:
						goto IL_3D2;
					case 174:
					case 176:
					case 178:
					case 180:
					case 182:
					case 184:
						goto IL_3F6;
					case 175:
					case 177:
					case 179:
					case 181:
					case 183:
					case 185:
						goto IL_3DF;
					case 198:
					case 199:
						if (isTlsV13)
						{
							return 7;
						}
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
					default:
						goto IL_3F6;
					}
				}
			}
			else if (cipherSuite <= 49327)
			{
				switch (cipherSuite)
				{
				case 4865:
				case 4867:
				case 4868:
				case 4869:
					if (isTlsV13)
					{
						return 4;
					}
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				case 4866:
					if (isTlsV13)
					{
						return 5;
					}
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				default:
					switch (cipherSuite)
					{
					case 49187:
					case 49189:
					case 49191:
					case 49193:
					case 49195:
					case 49197:
					case 49199:
					case 49201:
					case 49212:
					case 49214:
					case 49216:
					case 49218:
					case 49220:
					case 49222:
					case 49224:
					case 49226:
					case 49228:
					case 49230:
					case 49232:
					case 49234:
					case 49236:
					case 49238:
					case 49240:
					case 49242:
					case 49244:
					case 49246:
					case 49248:
					case 49250:
					case 49252:
					case 49254:
					case 49256:
					case 49258:
					case 49260:
					case 49262:
					case 49264:
					case 49266:
					case 49268:
					case 49270:
					case 49272:
					case 49274:
					case 49276:
					case 49278:
					case 49280:
					case 49282:
					case 49284:
					case 49286:
					case 49288:
					case 49290:
					case 49292:
					case 49294:
					case 49296:
					case 49298:
					case 49308:
					case 49309:
					case 49310:
					case 49311:
					case 49312:
					case 49313:
					case 49314:
					case 49315:
					case 49316:
					case 49317:
					case 49318:
					case 49319:
					case 49320:
					case 49321:
					case 49322:
					case 49323:
					case 49324:
					case 49325:
					case 49326:
					case 49327:
						break;
					case 49188:
					case 49190:
					case 49192:
					case 49194:
					case 49196:
					case 49198:
					case 49200:
					case 49202:
					case 49213:
					case 49215:
					case 49217:
					case 49219:
					case 49221:
					case 49223:
					case 49225:
					case 49227:
					case 49229:
					case 49231:
					case 49233:
					case 49235:
					case 49237:
					case 49239:
					case 49241:
					case 49243:
					case 49245:
					case 49247:
					case 49249:
					case 49251:
					case 49253:
					case 49255:
					case 49257:
					case 49259:
					case 49261:
					case 49263:
					case 49265:
					case 49267:
					case 49269:
					case 49271:
					case 49273:
					case 49275:
					case 49277:
					case 49279:
					case 49281:
					case 49283:
					case 49285:
					case 49287:
					case 49289:
					case 49291:
					case 49293:
					case 49295:
					case 49297:
					case 49299:
						goto IL_3D2;
					case 49203:
					case 49204:
					case 49205:
					case 49206:
					case 49207:
					case 49209:
					case 49210:
					case 49300:
					case 49302:
					case 49304:
					case 49306:
						goto IL_3F6;
					case 49208:
					case 49211:
					case 49301:
					case 49303:
					case 49305:
					case 49307:
						goto IL_3DF;
					default:
						goto IL_3F6;
					}
					break;
				}
			}
			else if (cipherSuite - 52392 > 6)
			{
				switch (cipherSuite)
				{
				case 53249:
				case 53251:
				case 53253:
					break;
				case 53250:
					goto IL_3D2;
				case 53252:
					goto IL_3F6;
				default:
					goto IL_3F6;
				}
			}
			if (isTlsV12Exactly)
			{
				return 2;
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			IL_3D2:
			if (isTlsV12Exactly)
			{
				return 3;
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			IL_3DF:
			if (isTlsV13)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			if (isTlsV12Exactly)
			{
				return 3;
			}
			if (isSsl)
			{
				return 0;
			}
			return 1;
			IL_3F6:
			if (isTlsV13)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			if (isTlsV12Exactly)
			{
				return 2;
			}
			if (isSsl)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0002DB25 File Offset: 0x0002BD25
		internal static int GetPrfAlgorithm13(int cipherSuite)
		{
			if (cipherSuite - 198 <= 1)
			{
				return 7;
			}
			switch (cipherSuite)
			{
			case 4865:
			case 4867:
			case 4868:
			case 4869:
				return 4;
			case 4866:
				return 5;
			default:
				return -1;
			}
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0002DB5C File Offset: 0x0002BD5C
		internal static int[] GetPrfAlgorithms13(int[] cipherSuites)
		{
			int[] result = new int[global::System.Math.Min(3, cipherSuites.Length)];
			int count = 0;
			for (int i = 0; i < cipherSuites.Length; i++)
			{
				int prfAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetPrfAlgorithm13(cipherSuites[i]);
				if (prfAlgorithm >= 0 && !global::Org.BouncyCastle.Utilities.Arrays.Contains(result, prfAlgorithm))
				{
					result[count++] = prfAlgorithm;
				}
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.Truncate(result, count);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0002DBB0 File Offset: 0x0002BDB0
		internal static byte[] CalculateSignatureHash(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm, byte[] extraSignatureInput, global::Org.BouncyCastle.Tls.DigestInputBuffer buf)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto = context.Crypto;
			global::Org.BouncyCastle.Tls.Crypto.TlsHash tlsHash;
			if (algorithm != null)
			{
				tlsHash = global::Org.BouncyCastle.Tls.TlsUtilities.CreateHash(crypto, algorithm.Hash);
			}
			else
			{
				global::Org.BouncyCastle.Tls.Crypto.TlsHash tlsHash2 = new global::Org.BouncyCastle.Tls.CombinedHash(crypto);
				tlsHash = tlsHash2;
			}
			global::Org.BouncyCastle.Tls.Crypto.TlsHash h = tlsHash;
			global::Org.BouncyCastle.Tls.SecurityParameters sp = context.SecurityParameters;
			byte[] randoms = global::Org.BouncyCastle.Utilities.Arrays.Concatenate(sp.ClientRandom, sp.ServerRandom);
			h.Update(randoms, 0, randoms.Length);
			if (extraSignatureInput != null)
			{
				h.Update(extraSignatureInput, 0, extraSignatureInput.Length);
			}
			buf.UpdateDigest(h);
			return h.CalculateHash();
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0002DC20 File Offset: 0x0002BE20
		internal static void SendSignatureInput(global::Org.BouncyCastle.Tls.TlsContext context, byte[] extraSignatureInput, global::Org.BouncyCastle.Tls.DigestInputBuffer buf, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters sp = context.SecurityParameters;
			byte[] randoms = global::Org.BouncyCastle.Utilities.Arrays.Concatenate(sp.ClientRandom, sp.ServerRandom);
			output.Write(randoms, 0, randoms.Length);
			if (extraSignatureInput != null)
			{
				output.Write(extraSignatureInput, 0, extraSignatureInput.Length);
			}
			buf.CopyTo(output);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(output);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0002DC6C File Offset: 0x0002BE6C
		internal static global::Org.BouncyCastle.Tls.DigitallySigned GenerateCertificateVerifyClient(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.TlsCredentialedSigner credentialedSigner, global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner streamSigner, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = clientContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetSignatureAndHashAlgorithm(negotiatedVersion, credentialedSigner);
			byte[] signature;
			if (streamSigner != null)
			{
				handshakeHash.CopyBufferTo(streamSigner.GetOutputStream());
				signature = streamSigner.GetSignature();
			}
			else
			{
				byte[] hash;
				if (signatureAndHashAlgorithm == null)
				{
					hash = securityParameters.SessionHash;
				}
				else
				{
					int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetCryptoHashAlgorithm(global::Org.BouncyCastle.Tls.SignatureScheme.From(signatureAndHashAlgorithm));
					hash = handshakeHash.GetFinalHash(cryptoHashAlgorithm);
				}
				signature = credentialedSigner.GenerateRawSignature(hash);
			}
			return new global::Org.BouncyCastle.Tls.DigitallySigned(signatureAndHashAlgorithm, signature);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0002DCE8 File Offset: 0x0002BEE8
		internal static global::Org.BouncyCastle.Tls.DigitallySigned Generate13CertificateVerify(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.TlsCredentialedSigner credentialedSigner, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash)
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = credentialedSigner.SignatureAndHashAlgorithm;
			if (signatureAndHashAlgorithm == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			string contextString = context.IsServer ? "TLS 1.3, server CertificateVerify" : "TLS 1.3, client CertificateVerify";
			byte[] signature = global::Org.BouncyCastle.Tls.TlsUtilities.Generate13CertificateVerify(context.Crypto, credentialedSigner, contextString, handshakeHash, signatureAndHashAlgorithm);
			return new global::Org.BouncyCastle.Tls.DigitallySigned(signatureAndHashAlgorithm, signature);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0002DD34 File Offset: 0x0002BF34
		private static byte[] Generate13CertificateVerify(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.TlsCredentialedSigner credentialedSigner, string contextString, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner streamSigner = credentialedSigner.GetStreamSigner();
			byte[] header = global::Org.BouncyCastle.Tls.TlsUtilities.GetCertificateVerifyHeader(contextString);
			byte[] prfHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(handshakeHash);
			if (streamSigner != null)
			{
				global::System.IO.Stream outputStream = streamSigner.GetOutputStream();
				outputStream.Write(header, 0, header.Length);
				outputStream.Write(prfHash, 0, prfHash.Length);
				return streamSigner.GetSignature();
			}
			int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetCryptoHashAlgorithm(global::Org.BouncyCastle.Tls.SignatureScheme.From(signatureAndHashAlgorithm));
			global::Org.BouncyCastle.Tls.Crypto.TlsHash tlsHash = crypto.CreateHash(cryptoHashAlgorithm);
			tlsHash.Update(header, 0, header.Length);
			tlsHash.Update(prfHash, 0, prfHash.Length);
			byte[] hash = tlsHash.CalculateHash();
			return credentialedSigner.GenerateRawSignature(hash);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0002DDB4 File Offset: 0x0002BFB4
		internal static void VerifyCertificateVerifyClient(global::Org.BouncyCastle.Tls.TlsServerContext serverContext, global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest, global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = serverContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.Crypto.TlsCertificate verifyingCert = securityParameters.PeerCertificate.GetCertificateAt(0);
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlg = certificateVerify.Algorithm;
			short signatureAlgorithm;
			if (sigAndHashAlg == null)
			{
				signatureAlgorithm = verifyingCert.GetLegacySignatureAlgorithm();
				short clientCertType = global::Org.BouncyCastle.Tls.TlsUtilities.GetLegacyClientCertType(signatureAlgorithm);
				if (clientCertType < 0 || !global::Org.BouncyCastle.Utilities.Arrays.Contains(certificateRequest.CertificateTypes, clientCertType))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(43);
				}
			}
			else
			{
				signatureAlgorithm = sigAndHashAlg.Signature;
				if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidSignatureAlgorithmForCertificateVerify(signatureAlgorithm, certificateRequest.CertificateTypes))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				global::Org.BouncyCastle.Tls.TlsUtilities.VerifySupportedSignatureAlgorithm(securityParameters.ServerSigAlgs, sigAndHashAlg);
			}
			bool verified;
			try
			{
				global::Org.BouncyCastle.Tls.Crypto.TlsVerifier verifier = verifyingCert.CreateVerifier(signatureAlgorithm);
				global::Org.BouncyCastle.Tls.Crypto.TlsStreamVerifier streamVerifier = verifier.GetStreamVerifier(certificateVerify);
				if (streamVerifier != null)
				{
					handshakeHash.CopyBufferTo(streamVerifier.GetOutputStream());
					verified = streamVerifier.IsVerified();
				}
				else
				{
					byte[] hash;
					if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(serverContext))
					{
						int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetCryptoHashAlgorithm(global::Org.BouncyCastle.Tls.SignatureScheme.From(sigAndHashAlg));
						hash = handshakeHash.GetFinalHash(cryptoHashAlgorithm);
					}
					else
					{
						hash = securityParameters.SessionHash;
					}
					verified = verifier.VerifyRawSignature(certificateVerify, hash);
				}
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert tlsFatalAlert)
			{
				throw tlsFatalAlert;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(51, e);
			}
			if (!verified)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(51);
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0002DED0 File Offset: 0x0002C0D0
		internal static void Verify13CertificateVerifyClient(global::Org.BouncyCastle.Tls.TlsServerContext serverContext, global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest, global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = serverContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.Crypto.TlsCertificate verifyingCert = securityParameters.PeerCertificate.GetCertificateAt(0);
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlg = certificateVerify.Algorithm;
			global::Org.BouncyCastle.Tls.TlsUtilities.VerifySupportedSignatureAlgorithm(securityParameters.ServerSigAlgs, sigAndHashAlg);
			int signatureScheme = global::Org.BouncyCastle.Tls.SignatureScheme.From(sigAndHashAlg);
			bool verified;
			try
			{
				global::Org.BouncyCastle.Tls.Crypto.TlsVerifier verifier = verifyingCert.CreateVerifier(signatureScheme);
				verified = global::Org.BouncyCastle.Tls.TlsUtilities.Verify13CertificateVerify(serverContext.Crypto, certificateVerify, verifier, "TLS 1.3, client CertificateVerify", handshakeHash);
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert tlsFatalAlert)
			{
				throw tlsFatalAlert;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(51, e);
			}
			if (!verified)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(51);
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0002DF60 File Offset: 0x0002C160
		internal static void Verify13CertificateVerifyServer(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = clientContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.Crypto.TlsCertificate verifyingCert = securityParameters.PeerCertificate.GetCertificateAt(0);
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlg = certificateVerify.Algorithm;
			global::Org.BouncyCastle.Tls.TlsUtilities.VerifySupportedSignatureAlgorithm(securityParameters.ClientSigAlgs, sigAndHashAlg);
			int signatureScheme = global::Org.BouncyCastle.Tls.SignatureScheme.From(sigAndHashAlg);
			bool verified;
			try
			{
				global::Org.BouncyCastle.Tls.Crypto.TlsVerifier verifier = verifyingCert.CreateVerifier(signatureScheme);
				verified = global::Org.BouncyCastle.Tls.TlsUtilities.Verify13CertificateVerify(clientContext.Crypto, certificateVerify, verifier, "TLS 1.3, server CertificateVerify", handshakeHash);
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert tlsFatalAlert)
			{
				throw tlsFatalAlert;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(51, e);
			}
			if (!verified)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(51);
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
		private static bool Verify13CertificateVerify(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify, global::Org.BouncyCastle.Tls.Crypto.TlsVerifier verifier, string contextString, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsStreamVerifier streamVerifier = verifier.GetStreamVerifier(certificateVerify);
			byte[] header = global::Org.BouncyCastle.Tls.TlsUtilities.GetCertificateVerifyHeader(contextString);
			byte[] prfHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(handshakeHash);
			if (streamVerifier != null)
			{
				global::System.IO.Stream outputStream = streamVerifier.GetOutputStream();
				outputStream.Write(header, 0, header.Length);
				outputStream.Write(prfHash, 0, prfHash.Length);
				return streamVerifier.IsVerified();
			}
			int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetCryptoHashAlgorithm(global::Org.BouncyCastle.Tls.SignatureScheme.From(certificateVerify.Algorithm));
			global::Org.BouncyCastle.Tls.Crypto.TlsHash tlsHash = crypto.CreateHash(cryptoHashAlgorithm);
			tlsHash.Update(header, 0, header.Length);
			tlsHash.Update(prfHash, 0, prfHash.Length);
			byte[] hash = tlsHash.CalculateHash();
			return verifier.VerifyRawSignature(certificateVerify, hash);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0002E078 File Offset: 0x0002C278
		private static byte[] GetCertificateVerifyHeader(string contextString)
		{
			int count = contextString.Length;
			byte[] header = new byte[64 + count + 1];
			for (int i = 0; i < 64; i++)
			{
				header[i] = 32;
			}
			for (int j = 0; j < count; j++)
			{
				char c = contextString[j];
				header[64 + j] = (byte)c;
			}
			header[64 + count] = 0;
			return header;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
		internal static void GenerateServerKeyExchangeSignature(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.TlsCredentialedSigner credentials, byte[] extraSignatureInput, global::Org.BouncyCastle.Tls.DigestInputBuffer digestBuffer)
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetSignatureAndHashAlgorithm(context, credentials);
			global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner streamSigner = credentials.GetStreamSigner();
			byte[] signature;
			if (streamSigner != null)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.SendSignatureInput(context, extraSignatureInput, digestBuffer, streamSigner.GetOutputStream());
				signature = streamSigner.GetSignature();
			}
			else
			{
				byte[] hash = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateSignatureHash(context, algorithm, extraSignatureInput, digestBuffer);
				signature = credentials.GenerateRawSignature(hash);
			}
			new global::Org.BouncyCastle.Tls.DigitallySigned(algorithm, signature).Encode(digestBuffer);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0002E128 File Offset: 0x0002C328
		internal static void VerifyServerKeyExchangeSignature(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream signatureInput, global::Org.BouncyCastle.Tls.Crypto.TlsCertificate serverCertificate, byte[] extraSignatureInput, global::Org.BouncyCastle.Tls.DigestInputBuffer digestBuffer)
		{
			global::Org.BouncyCastle.Tls.DigitallySigned digitallySigned = global::Org.BouncyCastle.Tls.DigitallySigned.Parse(context, signatureInput);
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			int keyExchangeAlgorithm = securityParameters.KeyExchangeAlgorithm;
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlg = digitallySigned.Algorithm;
			short signatureAlgorithm;
			if (sigAndHashAlg == null)
			{
				signatureAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetLegacySignatureAlgorithmServer(keyExchangeAlgorithm);
			}
			else
			{
				signatureAlgorithm = sigAndHashAlg.Signature;
				if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidSignatureAlgorithmForServerKeyExchange(signatureAlgorithm, keyExchangeAlgorithm))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				global::Org.BouncyCastle.Tls.TlsUtilities.VerifySupportedSignatureAlgorithm(securityParameters.ClientSigAlgs, sigAndHashAlg);
			}
			global::Org.BouncyCastle.Tls.Crypto.TlsVerifier verifier = serverCertificate.CreateVerifier(signatureAlgorithm);
			global::Org.BouncyCastle.Tls.Crypto.TlsStreamVerifier streamVerifier = verifier.GetStreamVerifier(digitallySigned);
			bool verified;
			if (streamVerifier != null)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.SendSignatureInput(context, null, digestBuffer, streamVerifier.GetOutputStream());
				verified = streamVerifier.IsVerified();
			}
			else
			{
				byte[] hash = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateSignatureHash(context, sigAndHashAlg, null, digestBuffer);
				verified = verifier.VerifyRawSignature(digitallySigned, hash);
			}
			if (!verified)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(51);
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0002E1DC File Offset: 0x0002C3DC
		internal static void TrackHashAlgorithms(global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash, global::System.Collections.IList supportedSignatureAlgorithms)
		{
			if (supportedSignatureAlgorithms != null)
			{
				foreach (object obj in supportedSignatureAlgorithms)
				{
					global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = (global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm)obj;
					int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetCryptoHashAlgorithm(global::Org.BouncyCastle.Tls.SignatureScheme.From(signatureAndHashAlgorithm));
					if (cryptoHashAlgorithm >= 0)
					{
						handshakeHash.TrackHashAlgorithm(cryptoHashAlgorithm);
					}
					else if (8 == signatureAndHashAlgorithm.Hash)
					{
						handshakeHash.ForceBuffering();
					}
				}
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0002E254 File Offset: 0x0002C454
		public static bool HasSigningCapability(short clientCertificateType)
		{
			return clientCertificateType - 1 <= 1 || clientCertificateType == 64;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0002E264 File Offset: 0x0002C464
		public static global::System.Collections.IList VectorOfOne(object obj)
		{
			global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1);
			list.Add(obj);
			return list;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0002E274 File Offset: 0x0002C474
		public static int GetCipherType(int cipherSuite)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetEncryptionAlgorithmType(global::Org.BouncyCastle.Tls.TlsUtilities.GetEncryptionAlgorithm(cipherSuite));
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0002E284 File Offset: 0x0002C484
		public static int GetEncryptionAlgorithm(int cipherSuite)
		{
			if (cipherSuite <= 4869)
			{
				switch (cipherSuite)
				{
				case 2:
				case 44:
				case 45:
				case 46:
					return 0;
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 11:
				case 12:
				case 14:
				case 15:
				case 17:
				case 18:
				case 20:
				case 21:
				case 23:
				case 24:
				case 25:
				case 26:
				case 28:
				case 29:
				case 30:
				case 31:
				case 32:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
				case 38:
				case 39:
				case 40:
				case 41:
				case 42:
				case 43:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 76:
				case 77:
				case 78:
				case 79:
				case 80:
				case 81:
				case 82:
				case 83:
				case 84:
				case 85:
				case 86:
				case 87:
				case 88:
				case 89:
				case 90:
				case 91:
				case 92:
				case 93:
				case 94:
				case 95:
				case 96:
				case 97:
				case 98:
				case 99:
				case 100:
				case 101:
				case 102:
				case 110:
				case 111:
				case 112:
				case 113:
				case 114:
				case 115:
				case 116:
				case 117:
				case 118:
				case 119:
				case 120:
				case 121:
				case 122:
				case 123:
				case 124:
				case 125:
				case 126:
				case 127:
				case 128:
				case 129:
				case 130:
				case 131:
				case 138:
				case 142:
				case 146:
					return -1;
				case 10:
				case 13:
				case 16:
				case 19:
				case 22:
				case 27:
				case 139:
				case 143:
				case 147:
					break;
				case 47:
				case 48:
				case 49:
				case 50:
				case 51:
				case 52:
				case 60:
				case 62:
				case 63:
				case 64:
				case 103:
				case 108:
				case 140:
				case 144:
				case 148:
				case 174:
				case 178:
				case 182:
					return 8;
				case 53:
				case 54:
				case 55:
				case 56:
				case 57:
				case 58:
				case 61:
				case 104:
				case 105:
				case 106:
				case 107:
				case 109:
				case 141:
				case 145:
				case 149:
				case 175:
				case 179:
				case 183:
					return 9;
				case 59:
				case 176:
				case 180:
				case 184:
					return 0;
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 186:
				case 187:
				case 188:
				case 189:
				case 190:
				case 191:
					return 12;
				case 132:
				case 133:
				case 134:
				case 135:
				case 136:
				case 137:
				case 192:
				case 193:
				case 194:
				case 195:
				case 196:
				case 197:
					return 13;
				case 150:
				case 151:
				case 152:
				case 153:
				case 154:
				case 155:
					return 14;
				case 156:
				case 158:
				case 160:
				case 162:
				case 164:
				case 166:
				case 168:
				case 170:
				case 172:
					return 10;
				case 157:
				case 159:
				case 161:
				case 163:
				case 165:
				case 167:
				case 169:
				case 171:
				case 173:
					return 11;
				case 177:
				case 181:
				case 185:
					return 0;
				case 198:
					return 27;
				case 199:
					return 26;
				default:
					switch (cipherSuite)
					{
					case 4865:
						return 10;
					case 4866:
						return 11;
					case 4867:
						return 21;
					case 4868:
						return 15;
					case 4869:
						return 16;
					default:
						return -1;
					}
					break;
				}
			}
			else
			{
				switch (cipherSuite)
				{
				case 49153:
				case 49158:
				case 49163:
				case 49168:
				case 49173:
				case 49209:
					return 0;
				case 49154:
				case 49159:
				case 49164:
				case 49169:
				case 49174:
				case 49203:
					return -1;
				case 49155:
				case 49160:
				case 49165:
				case 49170:
				case 49175:
				case 49178:
				case 49179:
				case 49180:
				case 49204:
					break;
				case 49156:
				case 49161:
				case 49166:
				case 49171:
				case 49176:
				case 49181:
				case 49182:
				case 49183:
				case 49187:
				case 49189:
				case 49191:
				case 49193:
				case 49205:
				case 49207:
					return 8;
				case 49157:
				case 49162:
				case 49167:
				case 49172:
				case 49177:
				case 49184:
				case 49185:
				case 49186:
				case 49188:
				case 49190:
				case 49192:
				case 49194:
				case 49206:
				case 49208:
					return 9;
				case 49195:
				case 49197:
				case 49199:
				case 49201:
					return 10;
				case 49196:
				case 49198:
				case 49200:
				case 49202:
					return 11;
				case 49210:
					return 0;
				case 49211:
					return 0;
				case 49212:
				case 49214:
				case 49216:
				case 49218:
				case 49220:
				case 49222:
				case 49224:
				case 49226:
				case 49228:
				case 49230:
				case 49252:
				case 49254:
				case 49256:
				case 49264:
					return 22;
				case 49213:
				case 49215:
				case 49217:
				case 49219:
				case 49221:
				case 49223:
				case 49225:
				case 49227:
				case 49229:
				case 49231:
				case 49253:
				case 49255:
				case 49257:
				case 49265:
					return 23;
				case 49232:
				case 49234:
				case 49236:
				case 49238:
				case 49240:
				case 49242:
				case 49244:
				case 49246:
				case 49248:
				case 49250:
				case 49258:
				case 49260:
				case 49262:
					return 24;
				case 49233:
				case 49235:
				case 49237:
				case 49239:
				case 49241:
				case 49243:
				case 49245:
				case 49247:
				case 49249:
				case 49251:
				case 49259:
				case 49261:
				case 49263:
					return 25;
				case 49266:
				case 49268:
				case 49270:
				case 49272:
				case 49300:
				case 49302:
				case 49304:
				case 49306:
					return 12;
				case 49267:
				case 49269:
				case 49271:
				case 49273:
				case 49301:
				case 49303:
				case 49305:
				case 49307:
					return 13;
				case 49274:
				case 49276:
				case 49278:
				case 49280:
				case 49282:
				case 49284:
				case 49286:
				case 49288:
				case 49290:
				case 49292:
				case 49294:
				case 49296:
				case 49298:
					return 19;
				case 49275:
				case 49277:
				case 49279:
				case 49281:
				case 49283:
				case 49285:
				case 49287:
				case 49289:
				case 49291:
				case 49293:
				case 49295:
				case 49297:
				case 49299:
					return 20;
				case 49308:
				case 49310:
				case 49316:
				case 49318:
				case 49324:
					return 15;
				case 49309:
				case 49311:
				case 49317:
				case 49319:
				case 49325:
					return 17;
				case 49312:
				case 49314:
				case 49320:
				case 49322:
				case 49326:
					return 16;
				case 49313:
				case 49315:
				case 49321:
				case 49323:
				case 49327:
					return 18;
				default:
					if (cipherSuite - 52392 <= 6)
					{
						return 21;
					}
					switch (cipherSuite)
					{
					case 53249:
						return 10;
					case 53250:
						return 11;
					case 53251:
						return 16;
					case 53252:
						return -1;
					case 53253:
						return 15;
					default:
						return -1;
					}
					break;
				}
			}
			return 7;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0002E91C File Offset: 0x0002CB1C
		public static int GetEncryptionAlgorithmType(int encryptionAlgorithm)
		{
			switch (encryptionAlgorithm)
			{
			case 0:
			case 1:
			case 2:
				return 0;
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 12:
			case 13:
			case 14:
			case 22:
			case 23:
			case 28:
				return 1;
			case 10:
			case 11:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
			case 24:
			case 25:
			case 26:
			case 27:
				return 2;
			default:
				return -1;
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0002E9AC File Offset: 0x0002CBAC
		public static int GetKeyExchangeAlgorithm(int cipherSuite)
		{
			if (cipherSuite <= 49327)
			{
				switch (cipherSuite)
				{
				case 2:
				case 10:
				case 47:
				case 53:
				case 59:
				case 60:
				case 61:
				case 65:
				case 132:
				case 150:
				case 156:
				case 157:
				case 186:
				case 192:
					return 1;
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 11:
				case 12:
				case 14:
				case 15:
				case 17:
				case 18:
				case 20:
				case 21:
				case 23:
				case 24:
				case 25:
				case 26:
				case 28:
				case 29:
				case 30:
				case 31:
				case 32:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
				case 38:
				case 39:
				case 40:
				case 41:
				case 42:
				case 43:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 76:
				case 77:
				case 78:
				case 79:
				case 80:
				case 81:
				case 82:
				case 83:
				case 84:
				case 85:
				case 86:
				case 87:
				case 88:
				case 89:
				case 90:
				case 91:
				case 92:
				case 93:
				case 94:
				case 95:
				case 96:
				case 97:
				case 98:
				case 99:
				case 100:
				case 101:
				case 102:
				case 110:
				case 111:
				case 112:
				case 113:
				case 114:
				case 115:
				case 116:
				case 117:
				case 118:
				case 119:
				case 120:
				case 121:
				case 122:
				case 123:
				case 124:
				case 125:
				case 126:
				case 127:
				case 128:
				case 129:
				case 130:
				case 131:
				case 138:
				case 142:
				case 146:
					return -1;
				case 13:
				case 48:
				case 54:
				case 62:
				case 66:
				case 104:
				case 133:
				case 151:
				case 164:
				case 165:
				case 187:
				case 193:
					return 7;
				case 16:
				case 49:
				case 55:
				case 63:
				case 67:
				case 105:
				case 134:
				case 152:
				case 160:
				case 161:
				case 188:
				case 194:
					return 9;
				case 19:
				case 50:
				case 56:
				case 64:
				case 68:
				case 106:
				case 135:
				case 153:
				case 162:
				case 163:
				case 189:
				case 195:
					return 3;
				case 22:
				case 51:
				case 57:
				case 69:
				case 103:
				case 107:
				case 136:
				case 154:
				case 158:
				case 159:
				case 190:
				case 196:
					return 5;
				case 27:
				case 52:
				case 58:
				case 70:
				case 108:
				case 109:
				case 137:
				case 155:
				case 166:
				case 167:
				case 191:
				case 197:
					break;
				case 44:
				case 139:
				case 140:
				case 141:
				case 168:
				case 169:
				case 174:
				case 175:
				case 176:
				case 177:
					return 13;
				case 45:
				case 143:
				case 144:
				case 145:
				case 170:
				case 171:
				case 178:
				case 179:
				case 180:
				case 181:
					return 14;
				case 46:
				case 147:
				case 148:
				case 149:
				case 172:
				case 173:
				case 182:
				case 183:
				case 184:
				case 185:
					return 15;
				case 198:
				case 199:
					return 0;
				default:
					if (cipherSuite - 4865 <= 4)
					{
						return 0;
					}
					switch (cipherSuite)
					{
					case 49153:
					case 49155:
					case 49156:
					case 49157:
					case 49189:
					case 49190:
					case 49197:
					case 49198:
					case 49226:
					case 49227:
					case 49246:
					case 49247:
					case 49268:
					case 49269:
					case 49288:
					case 49289:
						return 16;
					case 49154:
					case 49159:
					case 49164:
					case 49169:
					case 49174:
					case 49203:
						return -1;
					case 49158:
					case 49160:
					case 49161:
					case 49162:
					case 49187:
					case 49188:
					case 49195:
					case 49196:
					case 49224:
					case 49225:
					case 49244:
					case 49245:
					case 49266:
					case 49267:
					case 49286:
					case 49287:
					case 49324:
					case 49325:
					case 49326:
					case 49327:
						return 17;
					case 49163:
					case 49165:
					case 49166:
					case 49167:
					case 49193:
					case 49194:
					case 49201:
					case 49202:
					case 49230:
					case 49231:
					case 49250:
					case 49251:
					case 49272:
					case 49273:
					case 49292:
					case 49293:
						return 18;
					case 49168:
					case 49170:
					case 49171:
					case 49172:
					case 49191:
					case 49192:
					case 49199:
					case 49200:
					case 49228:
					case 49229:
					case 49248:
					case 49249:
					case 49270:
					case 49271:
					case 49290:
					case 49291:
						return 19;
					case 49173:
					case 49175:
					case 49176:
					case 49177:
						return 20;
					case 49178:
					case 49181:
					case 49184:
						return 21;
					case 49179:
					case 49182:
					case 49185:
						return 23;
					case 49180:
					case 49183:
					case 49186:
						return 22;
					case 49204:
					case 49205:
					case 49206:
					case 49207:
					case 49208:
					case 49209:
					case 49210:
					case 49211:
					case 49264:
					case 49265:
					case 49306:
					case 49307:
						return 24;
					case 49212:
					case 49213:
					case 49232:
					case 49233:
					case 49274:
					case 49275:
					case 49308:
					case 49309:
					case 49312:
					case 49313:
						return 1;
					case 49214:
					case 49215:
					case 49240:
					case 49241:
					case 49282:
					case 49283:
						return 7;
					case 49216:
					case 49217:
					case 49236:
					case 49237:
					case 49278:
					case 49279:
						return 9;
					case 49218:
					case 49219:
					case 49238:
					case 49239:
					case 49280:
					case 49281:
						return 3;
					case 49220:
					case 49221:
					case 49234:
					case 49235:
					case 49276:
					case 49277:
					case 49310:
					case 49311:
					case 49314:
					case 49315:
						return 5;
					case 49222:
					case 49223:
					case 49242:
					case 49243:
					case 49284:
					case 49285:
						break;
					case 49252:
					case 49253:
					case 49258:
					case 49259:
					case 49294:
					case 49295:
					case 49300:
					case 49301:
					case 49316:
					case 49317:
					case 49320:
					case 49321:
						return 13;
					case 49254:
					case 49255:
					case 49260:
					case 49261:
					case 49296:
					case 49297:
					case 49302:
					case 49303:
					case 49318:
					case 49319:
					case 49322:
					case 49323:
						return 14;
					case 49256:
					case 49257:
					case 49262:
					case 49263:
					case 49298:
					case 49299:
					case 49304:
					case 49305:
						return 15;
					default:
						return -1;
					}
					break;
				}
				return 11;
			}
			switch (cipherSuite)
			{
			case 52392:
				return 19;
			case 52393:
				return 17;
			case 52394:
				return 5;
			case 52395:
				return 13;
			case 52396:
				return 24;
			case 52397:
				break;
			case 52398:
				return 15;
			default:
				if (cipherSuite - 53249 > 2 && cipherSuite != 53253)
				{
					return -1;
				}
				return 24;
			}
			return 14;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0002F02C File Offset: 0x0002D22C
		public static global::System.Collections.IList GetKeyExchangeAlgorithms(int[] cipherSuites)
		{
			global::System.Collections.IList result = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (cipherSuites != null)
			{
				for (int i = 0; i < cipherSuites.Length; i++)
				{
					global::Org.BouncyCastle.Tls.TlsUtilities.AddToSet(result, global::Org.BouncyCastle.Tls.TlsUtilities.GetKeyExchangeAlgorithm(cipherSuites[i]));
				}
				result.Remove(-1);
			}
			return result;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0002F06C File Offset: 0x0002D26C
		public static int GetMacAlgorithm(int cipherSuite)
		{
			if (cipherSuite <= 49327)
			{
				switch (cipherSuite)
				{
				case 2:
				case 10:
				case 13:
				case 16:
				case 19:
				case 22:
				case 27:
				case 44:
				case 45:
				case 46:
				case 47:
				case 48:
				case 49:
				case 50:
				case 51:
				case 52:
				case 53:
				case 54:
				case 55:
				case 56:
				case 57:
				case 58:
				case 65:
				case 66:
				case 67:
				case 68:
				case 69:
				case 70:
				case 132:
				case 133:
				case 134:
				case 135:
				case 136:
				case 137:
				case 139:
				case 140:
				case 141:
				case 143:
				case 144:
				case 145:
				case 147:
				case 148:
				case 149:
				case 150:
				case 151:
				case 152:
				case 153:
				case 154:
				case 155:
					break;
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 11:
				case 12:
				case 14:
				case 15:
				case 17:
				case 18:
				case 20:
				case 21:
				case 23:
				case 24:
				case 25:
				case 26:
				case 28:
				case 29:
				case 30:
				case 31:
				case 32:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
				case 38:
				case 39:
				case 40:
				case 41:
				case 42:
				case 43:
				case 71:
				case 72:
				case 73:
				case 74:
				case 75:
				case 76:
				case 77:
				case 78:
				case 79:
				case 80:
				case 81:
				case 82:
				case 83:
				case 84:
				case 85:
				case 86:
				case 87:
				case 88:
				case 89:
				case 90:
				case 91:
				case 92:
				case 93:
				case 94:
				case 95:
				case 96:
				case 97:
				case 98:
				case 99:
				case 100:
				case 101:
				case 102:
				case 110:
				case 111:
				case 112:
				case 113:
				case 114:
				case 115:
				case 116:
				case 117:
				case 118:
				case 119:
				case 120:
				case 121:
				case 122:
				case 123:
				case 124:
				case 125:
				case 126:
				case 127:
				case 128:
				case 129:
				case 130:
				case 131:
				case 138:
				case 142:
				case 146:
					return -1;
				case 59:
				case 60:
				case 61:
				case 62:
				case 63:
				case 64:
				case 103:
				case 104:
				case 105:
				case 106:
				case 107:
				case 108:
				case 109:
				case 174:
				case 176:
				case 178:
				case 180:
				case 182:
				case 184:
				case 186:
				case 187:
				case 188:
				case 189:
				case 190:
				case 191:
				case 192:
				case 193:
				case 194:
				case 195:
				case 196:
				case 197:
					return 3;
				case 156:
				case 157:
				case 158:
				case 159:
				case 160:
				case 161:
				case 162:
				case 163:
				case 164:
				case 165:
				case 166:
				case 167:
				case 168:
				case 169:
				case 170:
				case 171:
				case 172:
				case 173:
				case 198:
				case 199:
					return 0;
				case 175:
				case 177:
				case 179:
				case 181:
				case 183:
				case 185:
					return 4;
				default:
					if (cipherSuite - 4865 <= 4)
					{
						return 0;
					}
					switch (cipherSuite)
					{
					case 49153:
					case 49155:
					case 49156:
					case 49157:
					case 49158:
					case 49160:
					case 49161:
					case 49162:
					case 49163:
					case 49165:
					case 49166:
					case 49167:
					case 49168:
					case 49170:
					case 49171:
					case 49172:
					case 49173:
					case 49175:
					case 49176:
					case 49177:
					case 49178:
					case 49179:
					case 49180:
					case 49181:
					case 49182:
					case 49183:
					case 49184:
					case 49185:
					case 49186:
					case 49204:
					case 49205:
					case 49206:
					case 49209:
						break;
					case 49154:
					case 49159:
					case 49164:
					case 49169:
					case 49174:
					case 49203:
						return -1;
					case 49187:
					case 49189:
					case 49191:
					case 49193:
					case 49207:
					case 49210:
					case 49212:
					case 49214:
					case 49216:
					case 49218:
					case 49220:
					case 49222:
					case 49224:
					case 49226:
					case 49228:
					case 49230:
					case 49252:
					case 49254:
					case 49256:
					case 49264:
					case 49266:
					case 49268:
					case 49270:
					case 49272:
					case 49300:
					case 49302:
					case 49304:
					case 49306:
						return 3;
					case 49188:
					case 49190:
					case 49192:
					case 49194:
					case 49208:
					case 49211:
					case 49213:
					case 49215:
					case 49217:
					case 49219:
					case 49221:
					case 49223:
					case 49225:
					case 49227:
					case 49229:
					case 49231:
					case 49253:
					case 49255:
					case 49257:
					case 49265:
					case 49267:
					case 49269:
					case 49271:
					case 49273:
					case 49301:
					case 49303:
					case 49305:
					case 49307:
						return 4;
					case 49195:
					case 49196:
					case 49197:
					case 49198:
					case 49199:
					case 49200:
					case 49201:
					case 49202:
					case 49232:
					case 49233:
					case 49234:
					case 49235:
					case 49236:
					case 49237:
					case 49238:
					case 49239:
					case 49240:
					case 49241:
					case 49242:
					case 49243:
					case 49244:
					case 49245:
					case 49246:
					case 49247:
					case 49248:
					case 49249:
					case 49250:
					case 49251:
					case 49258:
					case 49259:
					case 49260:
					case 49261:
					case 49262:
					case 49263:
					case 49274:
					case 49275:
					case 49276:
					case 49277:
					case 49278:
					case 49279:
					case 49280:
					case 49281:
					case 49282:
					case 49283:
					case 49284:
					case 49285:
					case 49286:
					case 49287:
					case 49288:
					case 49289:
					case 49290:
					case 49291:
					case 49292:
					case 49293:
					case 49294:
					case 49295:
					case 49296:
					case 49297:
					case 49298:
					case 49299:
					case 49308:
					case 49309:
					case 49310:
					case 49311:
					case 49312:
					case 49313:
					case 49314:
					case 49315:
					case 49316:
					case 49317:
					case 49318:
					case 49319:
					case 49320:
					case 49321:
					case 49322:
					case 49323:
					case 49324:
					case 49325:
					case 49326:
					case 49327:
						return 0;
					default:
						return -1;
					}
					break;
				}
				return 2;
			}
			if (cipherSuite - 52392 > 6 && cipherSuite - 53249 > 2 && cipherSuite != 53253)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0002F6A0 File Offset: 0x0002D8A0
		public static global::Org.BouncyCastle.Tls.ProtocolVersion GetMinimumVersion(int cipherSuite)
		{
			if (cipherSuite <= 4869)
			{
				if (cipherSuite > 109)
				{
					switch (cipherSuite)
					{
					case 156:
					case 157:
					case 158:
					case 159:
					case 160:
					case 161:
					case 162:
					case 163:
					case 164:
					case 165:
					case 166:
					case 167:
					case 168:
					case 169:
					case 170:
					case 171:
					case 172:
					case 173:
					case 186:
					case 187:
					case 188:
					case 189:
					case 190:
					case 191:
					case 192:
					case 193:
					case 194:
					case 195:
					case 196:
					case 197:
						goto IL_368;
					case 174:
					case 175:
					case 176:
					case 177:
					case 178:
					case 179:
					case 180:
					case 181:
					case 182:
					case 183:
					case 184:
					case 185:
						goto IL_36E;
					case 198:
					case 199:
						break;
					default:
						if (cipherSuite - 4865 > 4)
						{
							goto IL_36E;
						}
						break;
					}
					return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13;
				}
				if (cipherSuite - 59 > 5 && cipherSuite - 103 > 6)
				{
					goto IL_36E;
				}
			}
			else if (cipherSuite <= 52398)
			{
				switch (cipherSuite)
				{
				case 49187:
				case 49188:
				case 49189:
				case 49190:
				case 49191:
				case 49192:
				case 49193:
				case 49194:
				case 49195:
				case 49196:
				case 49197:
				case 49198:
				case 49199:
				case 49200:
				case 49201:
				case 49202:
				case 49212:
				case 49213:
				case 49214:
				case 49215:
				case 49216:
				case 49217:
				case 49218:
				case 49219:
				case 49220:
				case 49221:
				case 49222:
				case 49223:
				case 49224:
				case 49225:
				case 49226:
				case 49227:
				case 49228:
				case 49229:
				case 49230:
				case 49231:
				case 49232:
				case 49233:
				case 49234:
				case 49235:
				case 49236:
				case 49237:
				case 49238:
				case 49239:
				case 49240:
				case 49241:
				case 49242:
				case 49243:
				case 49244:
				case 49245:
				case 49246:
				case 49247:
				case 49248:
				case 49249:
				case 49250:
				case 49251:
				case 49252:
				case 49253:
				case 49254:
				case 49255:
				case 49256:
				case 49257:
				case 49258:
				case 49259:
				case 49260:
				case 49261:
				case 49262:
				case 49263:
				case 49264:
				case 49265:
				case 49266:
				case 49267:
				case 49268:
				case 49269:
				case 49270:
				case 49271:
				case 49272:
				case 49273:
				case 49274:
				case 49275:
				case 49276:
				case 49277:
				case 49278:
				case 49279:
				case 49280:
				case 49281:
				case 49282:
				case 49283:
				case 49284:
				case 49285:
				case 49286:
				case 49287:
				case 49288:
				case 49289:
				case 49290:
				case 49291:
				case 49292:
				case 49293:
				case 49294:
				case 49295:
				case 49296:
				case 49297:
				case 49298:
				case 49299:
				case 49308:
				case 49309:
				case 49310:
				case 49311:
				case 49312:
				case 49313:
				case 49314:
				case 49315:
				case 49316:
				case 49317:
				case 49318:
				case 49319:
				case 49320:
				case 49321:
				case 49322:
				case 49323:
				case 49324:
				case 49325:
				case 49326:
				case 49327:
					break;
				case 49203:
				case 49204:
				case 49205:
				case 49206:
				case 49207:
				case 49208:
				case 49209:
				case 49210:
				case 49211:
				case 49300:
				case 49301:
				case 49302:
				case 49303:
				case 49304:
				case 49305:
				case 49306:
				case 49307:
					goto IL_36E;
				default:
					if (cipherSuite - 52392 > 6)
					{
						goto IL_36E;
					}
					break;
				}
			}
			else if (cipherSuite - 53249 > 2 && cipherSuite != 53253)
			{
				goto IL_36E;
			}
			IL_368:
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12;
			IL_36E:
			return global::Org.BouncyCastle.Tls.ProtocolVersion.SSLv3;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0002FA20 File Offset: 0x0002DC20
		public static global::System.Collections.IList GetNamedGroupRoles(int[] cipherSuites)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetNamedGroupRoles(global::Org.BouncyCastle.Tls.TlsUtilities.GetKeyExchangeAlgorithms(cipherSuites));
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0002FA30 File Offset: 0x0002DC30
		public static global::System.Collections.IList GetNamedGroupRoles(global::System.Collections.IList keyExchangeAlgorithms)
		{
			global::System.Collections.IList result = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			using (global::System.Collections.IEnumerator enumerator = keyExchangeAlgorithms.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					switch ((int)enumerator.Current)
					{
					case 0:
						global::Org.BouncyCastle.Tls.TlsUtilities.AddToSet(result, 1);
						global::Org.BouncyCastle.Tls.TlsUtilities.AddToSet(result, 2);
						break;
					case 3:
					case 5:
					case 7:
					case 9:
					case 11:
					case 14:
						global::Org.BouncyCastle.Tls.TlsUtilities.AddToSet(result, 1);
						break;
					case 16:
					case 17:
						global::Org.BouncyCastle.Tls.TlsUtilities.AddToSet(result, 2);
						global::Org.BouncyCastle.Tls.TlsUtilities.AddToSet(result, 3);
						break;
					case 18:
					case 19:
					case 20:
					case 24:
						global::Org.BouncyCastle.Tls.TlsUtilities.AddToSet(result, 2);
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0002FB2C File Offset: 0x0002DD2C
		public static bool IsAeadCipherSuite(int cipherSuite)
		{
			return 2 == global::Org.BouncyCastle.Tls.TlsUtilities.GetCipherType(cipherSuite);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0002FB37 File Offset: 0x0002DD37
		public static bool IsBlockCipherSuite(int cipherSuite)
		{
			return 1 == global::Org.BouncyCastle.Tls.TlsUtilities.GetCipherType(cipherSuite);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0002FB42 File Offset: 0x0002DD42
		public static bool IsStreamCipherSuite(int cipherSuite)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetCipherType(cipherSuite) == 0;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0002FB50 File Offset: 0x0002DD50
		public static bool IsValidCipherSuiteForSignatureAlgorithms(int cipherSuite, global::System.Collections.IList sigAlgs)
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite);
			if (keyExchangeAlgorithm <= 3)
			{
				if (keyExchangeAlgorithm == 0 || keyExchangeAlgorithm == 3)
				{
					goto IL_3F;
				}
			}
			else
			{
				if (keyExchangeAlgorithm == 5)
				{
					goto IL_3F;
				}
				switch (keyExchangeAlgorithm)
				{
				case 17:
				case 19:
				case 22:
				case 23:
					goto IL_3F;
				}
			}
			return true;
			IL_3F:
			using (global::System.Collections.IEnumerator enumerator = sigAlgs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (global::Org.BouncyCastle.Tls.TlsUtilities.IsValidSignatureAlgorithmForServerKeyExchange((short)enumerator.Current, keyExchangeAlgorithm))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0002FBEC File Offset: 0x0002DDEC
		internal static bool IsValidCipherSuiteSelection(int[] offeredCipherSuites, int cipherSuite)
		{
			return offeredCipherSuites != null && global::Org.BouncyCastle.Utilities.Arrays.Contains(offeredCipherSuites, cipherSuite) && cipherSuite != 0 && !global::Org.BouncyCastle.Tls.CipherSuite.IsScsv(cipherSuite);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0002FC08 File Offset: 0x0002DE08
		internal static bool IsValidKeyShareSelection(global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion, int[] clientSupportedGroups, global::System.Collections.IDictionary clientAgreements, int keyShareGroup)
		{
			return clientSupportedGroups != null && global::Org.BouncyCastle.Utilities.Arrays.Contains(clientSupportedGroups, keyShareGroup) && !clientAgreements.Contains(keyShareGroup) && global::Org.BouncyCastle.Tls.NamedGroup.CanBeNegotiated(keyShareGroup, negotiatedVersion);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0002FC30 File Offset: 0x0002DE30
		internal static bool IsValidSignatureAlgorithmForCertificateVerify(short signatureAlgorithm, short[] clientCertificateTypes)
		{
			short clientCertificateType = global::Org.BouncyCastle.Tls.SignatureAlgorithm.GetClientCertificateType(signatureAlgorithm);
			return clientCertificateType >= 0 && global::Org.BouncyCastle.Utilities.Arrays.Contains(clientCertificateTypes, clientCertificateType);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0002FC54 File Offset: 0x0002DE54
		internal static bool IsValidSignatureAlgorithmForServerKeyExchange(short signatureAlgorithm, int keyExchangeAlgorithm)
		{
			if (keyExchangeAlgorithm > 3)
			{
				if (keyExchangeAlgorithm != 5)
				{
					switch (keyExchangeAlgorithm)
					{
					case 17:
						return signatureAlgorithm == 3 || signatureAlgorithm - 7 <= 1;
					case 18:
					case 20:
					case 21:
						return false;
					case 19:
					case 23:
						break;
					case 22:
						goto IL_72;
					default:
						return false;
					}
				}
				switch (signatureAlgorithm)
				{
				case 1:
				case 4:
				case 5:
				case 6:
				case 9:
				case 10:
				case 11:
					return true;
				}
				return false;
			}
			if (keyExchangeAlgorithm == 0)
			{
				return signatureAlgorithm != 0;
			}
			if (keyExchangeAlgorithm != 3)
			{
				return false;
			}
			IL_72:
			return 2 == signatureAlgorithm;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0002FCEC File Offset: 0x0002DEEC
		public static bool IsValidSignatureSchemeForServerKeyExchange(int signatureScheme, int keyExchangeAlgorithm)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.IsValidSignatureAlgorithmForServerKeyExchange(global::Org.BouncyCastle.Tls.SignatureScheme.GetSignatureAlgorithm(signatureScheme), keyExchangeAlgorithm);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0002FCFC File Offset: 0x0002DEFC
		public static bool IsValidVersionForCipherSuite(int cipherSuite, global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			version = version.GetEquivalentTlsVersion();
			global::Org.BouncyCastle.Tls.ProtocolVersion minimumVersion = global::Org.BouncyCastle.Tls.TlsUtilities.GetMinimumVersion(cipherSuite);
			return minimumVersion == version || (minimumVersion.IsEarlierVersionOf(version) && (global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(minimumVersion) || global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13.IsLaterVersionOf(version)));
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0002FD43 File Offset: 0x0002DF43
		public static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm ChooseSignatureAndHashAlgorithm(global::Org.BouncyCastle.Tls.TlsContext context, global::System.Collections.IList sigHashAlgs, short signatureAlgorithm)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.ChooseSignatureAndHashAlgorithm(context.ServerVersion, sigHashAlgs, signatureAlgorithm);
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0002FD54 File Offset: 0x0002DF54
		public static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm ChooseSignatureAndHashAlgorithm(global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion, global::System.Collections.IList sigHashAlgs, short signatureAlgorithm)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(negotiatedVersion))
			{
				return null;
			}
			if (sigHashAlgs == null)
			{
				sigHashAlgs = global::Org.BouncyCastle.Tls.TlsUtilities.GetDefaultSignatureAlgorithms(signatureAlgorithm);
			}
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm result = null;
			foreach (object obj in sigHashAlgs)
			{
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigHashAlg = (global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm)obj;
				if (sigHashAlg.Signature == signatureAlgorithm)
				{
					short hash = sigHashAlg.Hash;
					if (hash >= global::Org.BouncyCastle.Tls.TlsUtilities.MinimumHashStrict)
					{
						if (result == null)
						{
							result = sigHashAlg;
						}
						else
						{
							short current = result.Hash;
							if (current < global::Org.BouncyCastle.Tls.TlsUtilities.MinimumHashPreferred)
							{
								if (hash > current)
								{
									result = sigHashAlg;
								}
							}
							else if (hash >= global::Org.BouncyCastle.Tls.TlsUtilities.MinimumHashPreferred && hash < current)
							{
								result = sigHashAlg;
							}
						}
					}
				}
			}
			if (result == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return result;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0002FE10 File Offset: 0x0002E010
		public static global::System.Collections.IList GetUsableSignatureAlgorithms(global::System.Collections.IList sigHashAlgs)
		{
			if (sigHashAlgs == null)
			{
				global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(3);
				list.Add(1);
				list.Add(2);
				list.Add(3);
				return list;
			}
			global::System.Collections.IList v = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj in sigHashAlgs)
			{
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigHashAlg = (global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm)obj;
				if (sigHashAlg.Hash >= global::Org.BouncyCastle.Tls.TlsUtilities.MinimumHashStrict)
				{
					short sigAlg = sigHashAlg.Signature;
					if (!v.Contains(sigAlg))
					{
						v.Add(sigAlg);
					}
				}
			}
			return v;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0002FEC8 File Offset: 0x0002E0C8
		public static int GetCommonCipherSuite13(global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion, int[] peerCipherSuites, int[] localCipherSuites, bool useLocalOrder)
		{
			int[] ordered = peerCipherSuites;
			int[] unordered = localCipherSuites;
			if (useLocalOrder)
			{
				ordered = localCipherSuites;
				unordered = peerCipherSuites;
			}
			foreach (int candidate in ordered)
			{
				if (global::Org.BouncyCastle.Utilities.Arrays.Contains(unordered, candidate) && global::Org.BouncyCastle.Tls.TlsUtilities.IsValidVersionForCipherSuite(candidate, negotiatedVersion))
				{
					return candidate;
				}
			}
			return -1;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0002FF08 File Offset: 0x0002E108
		public static int[] GetCommonCipherSuites(int[] peerCipherSuites, int[] localCipherSuites, bool useLocalOrder)
		{
			int[] ordered = peerCipherSuites;
			int[] unordered = localCipherSuites;
			if (useLocalOrder)
			{
				ordered = localCipherSuites;
				unordered = peerCipherSuites;
			}
			int count = 0;
			int limit = global::System.Math.Min(ordered.Length, unordered.Length);
			int[] candidates = new int[limit];
			foreach (int candidate in ordered)
			{
				if (!global::Org.BouncyCastle.Tls.TlsUtilities.Contains(candidates, 0, count, candidate) && global::Org.BouncyCastle.Utilities.Arrays.Contains(unordered, candidate))
				{
					candidates[count++] = candidate;
				}
			}
			if (count < limit)
			{
				candidates = global::Org.BouncyCastle.Utilities.Arrays.CopyOf(candidates, count);
			}
			return candidates;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0002FF7F File Offset: 0x0002E17F
		public static int[] GetSupportedCipherSuites(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, int[] suites)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetSupportedCipherSuites(crypto, suites, 0, suites.Length);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0002FF8C File Offset: 0x0002E18C
		public static int[] GetSupportedCipherSuites(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, int[] suites, int suitesOff, int suitesCount)
		{
			int[] supported = new int[suitesCount];
			int count = 0;
			for (int i = 0; i < suitesCount; i++)
			{
				int suite = suites[suitesOff + i];
				if (global::Org.BouncyCastle.Tls.TlsUtilities.IsSupportedCipherSuite(crypto, suite))
				{
					supported[count++] = suite;
				}
			}
			if (count < suitesCount)
			{
				supported = global::Org.BouncyCastle.Utilities.Arrays.CopyOf(supported, count);
			}
			return supported;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0002FFD2 File Offset: 0x0002E1D2
		public static bool IsSupportedCipherSuite(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, int cipherSuite)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.IsSupportedKeyExchange(crypto, global::Org.BouncyCastle.Tls.TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite)) && crypto.HasEncryptionAlgorithm(global::Org.BouncyCastle.Tls.TlsUtilities.GetEncryptionAlgorithm(cipherSuite)) && crypto.HasMacAlgorithm(global::Org.BouncyCastle.Tls.TlsUtilities.GetMacAlgorithm(cipherSuite));
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00030000 File Offset: 0x0002E200
		public static bool IsSupportedKeyExchange(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, int keyExchangeAlgorithm)
		{
			switch (keyExchangeAlgorithm)
			{
			case 0:
			case 13:
				return true;
			case 1:
			case 15:
				return crypto.HasRsaEncryption();
			case 3:
				return crypto.HasDHAgreement() && crypto.HasSignatureAlgorithm(2);
			case 5:
				return crypto.HasDHAgreement() && global::Org.BouncyCastle.Tls.TlsUtilities.HasAnyRsaSigAlgs(crypto);
			case 7:
			case 9:
			case 11:
			case 14:
				return crypto.HasDHAgreement();
			case 16:
			case 18:
			case 20:
			case 24:
				return crypto.HasECDHAgreement();
			case 17:
				return crypto.HasECDHAgreement() && (crypto.HasSignatureAlgorithm(3) || crypto.HasSignatureAlgorithm(7) || crypto.HasSignatureAlgorithm(8));
			case 19:
				return crypto.HasECDHAgreement() && global::Org.BouncyCastle.Tls.TlsUtilities.HasAnyRsaSigAlgs(crypto);
			case 21:
				return crypto.HasSrpAuthentication();
			case 22:
				return crypto.HasSrpAuthentication() && crypto.HasSignatureAlgorithm(2);
			case 23:
				return crypto.HasSrpAuthentication() && global::Org.BouncyCastle.Tls.TlsUtilities.HasAnyRsaSigAlgs(crypto);
			}
			return false;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00030118 File Offset: 0x0002E318
		internal static bool HasAnyRsaSigAlgs(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto)
		{
			return crypto.HasSignatureAlgorithm(1) || crypto.HasSignatureAlgorithm(4) || crypto.HasSignatureAlgorithm(5) || crypto.HasSignatureAlgorithm(6) || crypto.HasSignatureAlgorithm(9) || crypto.HasSignatureAlgorithm(10) || crypto.HasSignatureAlgorithm(11);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00030167 File Offset: 0x0002E367
		internal static byte[] GetCurrentPrfHash(global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash)
		{
			return handshakeHash.ForkPrfHash().CalculateHash();
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00030174 File Offset: 0x0002E374
		internal static void SealHandshakeHash(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash, bool forceBuffering)
		{
			if (forceBuffering || !context.Crypto.HasAllRawSignatureAlgorithms())
			{
				handshakeHash.ForceBuffering();
			}
			handshakeHash.SealHashAlgorithms();
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00030194 File Offset: 0x0002E394
		private static global::Org.BouncyCastle.Tls.Crypto.TlsHash CreateHash(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, short hashAlgorithm)
		{
			int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHash(hashAlgorithm);
			return crypto.CreateHash(cryptoHashAlgorithm);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000301B0 File Offset: 0x0002E3B0
		private static global::Org.BouncyCastle.Tls.TlsKeyExchange CreateKeyExchangeClient(global::Org.BouncyCastle.Tls.TlsClient client, int keyExchange)
		{
			global::Org.BouncyCastle.Tls.TlsKeyExchangeFactory factory = client.GetKeyExchangeFactory();
			switch (keyExchange)
			{
			case 1:
				return factory.CreateRsaKeyExchange(keyExchange);
			case 3:
			case 5:
				return factory.CreateDheKeyExchangeClient(keyExchange, client.GetDHGroupVerifier());
			case 7:
			case 9:
				return factory.CreateDHKeyExchange(keyExchange);
			case 11:
				return factory.CreateDHanonKeyExchangeClient(keyExchange, client.GetDHGroupVerifier());
			case 13:
			case 15:
			case 24:
				return factory.CreatePskKeyExchangeClient(keyExchange, client.GetPskIdentity(), null);
			case 14:
				return factory.CreatePskKeyExchangeClient(keyExchange, client.GetPskIdentity(), client.GetDHGroupVerifier());
			case 16:
			case 18:
				return factory.CreateECDHKeyExchange(keyExchange);
			case 17:
			case 19:
				return factory.CreateECDheKeyExchangeClient(keyExchange);
			case 20:
				return factory.CreateECDHanonKeyExchangeClient(keyExchange);
			case 21:
			case 22:
			case 23:
				return factory.CreateSrpKeyExchangeClient(keyExchange, client.GetSrpIdentity(), client.GetSrpConfigVerifier());
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000302B0 File Offset: 0x0002E4B0
		private static global::Org.BouncyCastle.Tls.TlsKeyExchange CreateKeyExchangeServer(global::Org.BouncyCastle.Tls.TlsServer server, int keyExchange)
		{
			global::Org.BouncyCastle.Tls.TlsKeyExchangeFactory factory = server.GetKeyExchangeFactory();
			switch (keyExchange)
			{
			case 1:
				return factory.CreateRsaKeyExchange(keyExchange);
			case 3:
			case 5:
				return factory.CreateDheKeyExchangeServer(keyExchange, server.GetDHConfig());
			case 7:
			case 9:
				return factory.CreateDHKeyExchange(keyExchange);
			case 11:
				return factory.CreateDHanonKeyExchangeServer(keyExchange, server.GetDHConfig());
			case 13:
			case 15:
				return factory.CreatePskKeyExchangeServer(keyExchange, server.GetPskIdentityManager(), null, null);
			case 14:
				return factory.CreatePskKeyExchangeServer(keyExchange, server.GetPskIdentityManager(), server.GetDHConfig(), null);
			case 16:
			case 18:
				return factory.CreateECDHKeyExchange(keyExchange);
			case 17:
			case 19:
				return factory.CreateECDheKeyExchangeServer(keyExchange, server.GetECDHConfig());
			case 20:
				return factory.CreateECDHanonKeyExchangeServer(keyExchange, server.GetECDHConfig());
			case 21:
			case 22:
			case 23:
				return factory.CreateSrpKeyExchangeServer(keyExchange, server.GetSrpLoginParameters());
			case 24:
				return factory.CreatePskKeyExchangeServer(keyExchange, server.GetPskIdentityManager(), null, server.GetECDHConfig());
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000303D0 File Offset: 0x0002E5D0
		internal static global::Org.BouncyCastle.Tls.TlsKeyExchange InitKeyExchangeClient(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.TlsClient client)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = clientContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.TlsKeyExchange tlsKeyExchange = global::Org.BouncyCastle.Tls.TlsUtilities.CreateKeyExchangeClient(client, securityParameters.KeyExchangeAlgorithm);
			tlsKeyExchange.Init(clientContext);
			return tlsKeyExchange;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x000303F8 File Offset: 0x0002E5F8
		internal static global::Org.BouncyCastle.Tls.TlsKeyExchange InitKeyExchangeServer(global::Org.BouncyCastle.Tls.TlsServerContext serverContext, global::Org.BouncyCastle.Tls.TlsServer server)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = serverContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.TlsKeyExchange tlsKeyExchange = global::Org.BouncyCastle.Tls.TlsUtilities.CreateKeyExchangeServer(server, securityParameters.KeyExchangeAlgorithm);
			tlsKeyExchange.Init(serverContext);
			return tlsKeyExchange;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00030420 File Offset: 0x0002E620
		internal static global::Org.BouncyCastle.Tls.Crypto.TlsCipher InitCipher(global::Org.BouncyCastle.Tls.TlsContext context)
		{
			int cipherSuite = context.SecurityParameters.CipherSuite;
			int encryptionAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetEncryptionAlgorithm(cipherSuite);
			int macAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetMacAlgorithm(cipherSuite);
			if (encryptionAlgorithm < 0 || macAlgorithm < 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return context.Crypto.CreateCipher(new global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters(context), encryptionAlgorithm, macAlgorithm);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00030468 File Offset: 0x0002E668
		public static void CheckPeerSigAlgs(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[] peerCertPath)
		{
			if (context.IsServer)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckSigAlgOfClientCerts(context, peerCertPath);
				return;
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckSigAlgOfServerCerts(context, peerCertPath);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00030484 File Offset: 0x0002E684
		private static void CheckSigAlgOfClientCerts(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[] clientCertPath)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			short[] clientCertTypes = securityParameters.ClientCertTypes;
			global::System.Collections.IList serverSigAlgsCert = securityParameters.ServerSigAlgsCert;
			int trustAnchorPos = clientCertPath.Length - 1;
			for (int i = 0; i < trustAnchorPos; i++)
			{
				global::Org.BouncyCastle.Tls.Crypto.TlsCertificate subjectCert = clientCertPath[i];
				global::Org.BouncyCastle.Tls.Crypto.TlsCertificate issuerCert = clientCertPath[i + 1];
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlg = global::Org.BouncyCastle.Tls.TlsUtilities.GetCertSigAndHashAlg(subjectCert, issuerCert);
				bool valid = false;
				if (sigAndHashAlg != null)
				{
					if (serverSigAlgsCert == null)
					{
						if (clientCertTypes != null)
						{
							for (int j = 0; j < clientCertTypes.Length; j++)
							{
								short signatureAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetLegacySignatureAlgorithmClientCert(clientCertTypes[j]);
								if (sigAndHashAlg.Signature == signatureAlgorithm)
								{
									valid = true;
									break;
								}
							}
						}
					}
					else
					{
						valid = global::Org.BouncyCastle.Tls.TlsUtilities.ContainsSignatureAlgorithm(serverSigAlgsCert, sigAndHashAlg);
					}
				}
				if (!valid)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(42);
				}
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0003051C File Offset: 0x0002E71C
		private static void CheckSigAlgOfServerCerts(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsCertificate[] serverCertPath)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			global::System.Collections.IList clientSigAlgsCert = securityParameters.ClientSigAlgsCert;
			global::System.Collections.IList clientSigAlgs = securityParameters.ClientSigAlgs;
			if (clientSigAlgs == clientSigAlgsCert || global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
			{
				clientSigAlgs = null;
			}
			int trustAnchorPos = serverCertPath.Length - 1;
			for (int i = 0; i < trustAnchorPos; i++)
			{
				global::Org.BouncyCastle.Tls.Crypto.TlsCertificate subjectCert = serverCertPath[i];
				global::Org.BouncyCastle.Tls.Crypto.TlsCertificate issuerCert = serverCertPath[i + 1];
				global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlg = global::Org.BouncyCastle.Tls.TlsUtilities.GetCertSigAndHashAlg(subjectCert, issuerCert);
				bool valid = false;
				if (sigAndHashAlg != null)
				{
					if (clientSigAlgsCert == null)
					{
						valid = (global::Org.BouncyCastle.Tls.TlsUtilities.GetLegacySignatureAlgorithmServerCert(securityParameters.KeyExchangeAlgorithm) == sigAndHashAlg.Signature);
					}
					else
					{
						valid = (global::Org.BouncyCastle.Tls.TlsUtilities.ContainsSignatureAlgorithm(clientSigAlgsCert, sigAndHashAlg) || (clientSigAlgs != null && global::Org.BouncyCastle.Tls.TlsUtilities.ContainsSignatureAlgorithm(clientSigAlgs, sigAndHashAlg)));
					}
				}
				if (!valid)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(42);
				}
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x000305C8 File Offset: 0x0002E7C8
		internal static void CheckTlsFeatures(global::Org.BouncyCastle.Tls.Certificate serverCertificate, global::System.Collections.IDictionary clientExtensions, global::System.Collections.IDictionary serverExtensions)
		{
			byte[] tlsFeatures = serverCertificate.GetCertificateAt(0).GetExtension(global::Org.BouncyCastle.Tls.TlsObjectIdentifiers.id_pe_tlsfeature);
			if (tlsFeatures != null)
			{
				foreach (object obj in global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Tls.TlsUtilities.ReadDerObject(tlsFeatures)))
				{
					int extensionType = ((global::Org.BouncyCastle.Asn1.DerInteger)obj).IntValueExact;
					global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(extensionType);
					if (clientExtensions.Contains(extensionType) && !serverExtensions.Contains(extensionType))
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(46);
					}
				}
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00030664 File Offset: 0x0002E864
		internal static void ProcessClientCertificate(global::Org.BouncyCastle.Tls.TlsServerContext serverContext, global::Org.BouncyCastle.Tls.Certificate clientCertificate, global::Org.BouncyCastle.Tls.TlsKeyExchange keyExchange, global::Org.BouncyCastle.Tls.TlsServer server)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = serverContext.SecurityParameters;
			if (securityParameters.PeerCertificate != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
			{
				if (clientCertificate.IsEmpty)
				{
					keyExchange.SkipClientCredentials();
				}
				else
				{
					keyExchange.ProcessClientCertificate(clientCertificate);
				}
			}
			securityParameters.m_peerCertificate = clientCertificate;
			server.NotifyClientCertificate(clientCertificate);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000306BC File Offset: 0x0002E8BC
		internal static void ProcessServerCertificate(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.CertificateStatus serverCertificateStatus, global::Org.BouncyCastle.Tls.TlsKeyExchange keyExchange, global::Org.BouncyCastle.Tls.TlsAuthentication clientAuthentication, global::System.Collections.IDictionary clientExtensions, global::System.Collections.IDictionary serverExtensions)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = clientContext.SecurityParameters;
			bool isTlsV13 = global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion);
			if (clientAuthentication != null)
			{
				global::Org.BouncyCastle.Tls.Certificate serverCertificate = securityParameters.PeerCertificate;
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckTlsFeatures(serverCertificate, clientExtensions, serverExtensions);
				if (!isTlsV13)
				{
					keyExchange.ProcessServerCertificate(serverCertificate);
				}
				clientAuthentication.NotifyServerCertificate(new global::Org.BouncyCastle.Tls.TlsServerCertificateImpl(serverCertificate, serverCertificateStatus));
				return;
			}
			if (isTlsV13)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			keyExchange.SkipServerCredentials();
			securityParameters.m_tlsServerEndPoint = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00030724 File Offset: 0x0002E924
		internal static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm GetCertSigAndHashAlg(global::Org.BouncyCastle.Tls.Crypto.TlsCertificate subjectCert, global::Org.BouncyCastle.Tls.Crypto.TlsCertificate issuerCert)
		{
			string sigAlgOid = subjectCert.SigAlgOid;
			if (sigAlgOid != null)
			{
				if (!global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss.Id.Equals(sigAlgOid))
				{
					if (!global::Org.BouncyCastle.Tls.TlsUtilities.CertSigAlgOids.Contains(sigAlgOid))
					{
						return null;
					}
					return (global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm)global::Org.BouncyCastle.Tls.TlsUtilities.CertSigAlgOids[sigAlgOid];
				}
				else
				{
					global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters pssParams = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.GetInstance(subjectCert.GetSigAlgParams());
					if (pssParams != null)
					{
						global::Org.BouncyCastle.Asn1.DerObjectIdentifier hashOid = pssParams.HashAlgorithm.Algorithm;
						if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Equals(hashOid))
						{
							if (issuerCert.SupportsSignatureAlgorithmCA(9))
							{
								return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_pss_sha256;
							}
							if (issuerCert.SupportsSignatureAlgorithmCA(4))
							{
								return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_rsae_sha256;
							}
						}
						else if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Equals(hashOid))
						{
							if (issuerCert.SupportsSignatureAlgorithmCA(10))
							{
								return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_pss_sha384;
							}
							if (issuerCert.SupportsSignatureAlgorithmCA(5))
							{
								return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_rsae_sha384;
							}
						}
						else if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Equals(hashOid))
						{
							if (issuerCert.SupportsSignatureAlgorithmCA(11))
							{
								return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_pss_sha512;
							}
							if (issuerCert.SupportsSignatureAlgorithmCA(6))
							{
								return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.rsa_pss_rsae_sha512;
							}
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00030814 File Offset: 0x0002EA14
		internal static global::Org.BouncyCastle.Tls.CertificateRequest ValidateCertificateRequest(global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest, global::Org.BouncyCastle.Tls.TlsKeyExchange keyExchange)
		{
			short[] validClientCertificateTypes = keyExchange.GetClientCertificateTypes();
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(validClientCertificateTypes))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			certificateRequest = global::Org.BouncyCastle.Tls.TlsUtilities.NormalizeCertificateRequest(certificateRequest, validClientCertificateTypes);
			if (certificateRequest == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return certificateRequest;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00030850 File Offset: 0x0002EA50
		internal static global::Org.BouncyCastle.Tls.CertificateRequest NormalizeCertificateRequest(global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest, short[] validClientCertificateTypes)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.ContainsAll(validClientCertificateTypes, certificateRequest.CertificateTypes))
			{
				return certificateRequest;
			}
			short[] retained = global::Org.BouncyCastle.Tls.TlsUtilities.RetainAll(certificateRequest.CertificateTypes, validClientCertificateTypes);
			if (retained.Length < 1)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Tls.CertificateRequest(retained, certificateRequest.SupportedSignatureAlgorithms, certificateRequest.CertificateAuthorities);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00030894 File Offset: 0x0002EA94
		internal static bool Contains(int[] buf, int off, int len, int value)
		{
			for (int i = 0; i < len; i++)
			{
				if (value == buf[off + i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000308B8 File Offset: 0x0002EAB8
		internal static bool ContainsAll(short[] container, short[] elements)
		{
			for (int i = 0; i < elements.Length; i++)
			{
				if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(container, elements[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000308E4 File Offset: 0x0002EAE4
		internal static short[] RetainAll(short[] retainer, short[] elements)
		{
			short[] retained = new short[global::System.Math.Min(retainer.Length, elements.Length)];
			int count = 0;
			for (int i = 0; i < elements.Length; i++)
			{
				if (global::Org.BouncyCastle.Utilities.Arrays.Contains(retainer, elements[i]))
				{
					retained[count++] = elements[i];
				}
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.Truncate(retained, count);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00030930 File Offset: 0x0002EB30
		internal static short[] Truncate(short[] a, int n)
		{
			if (n >= a.Length)
			{
				return a;
			}
			short[] t = new short[n];
			global::System.Array.Copy(a, 0, t, 0, n);
			return t;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00030958 File Offset: 0x0002EB58
		internal static int[] Truncate(int[] a, int n)
		{
			if (n >= a.Length)
			{
				return a;
			}
			int[] t = new int[n];
			global::System.Array.Copy(a, 0, t, 0, n);
			return t;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0003097F File Offset: 0x0002EB7F
		internal static global::Org.BouncyCastle.Tls.TlsCredentialedAgreement RequireAgreementCredentials(global::Org.BouncyCastle.Tls.TlsCredentials credentials)
		{
			if (!(credentials is global::Org.BouncyCastle.Tls.TlsCredentialedAgreement))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return (global::Org.BouncyCastle.Tls.TlsCredentialedAgreement)credentials;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00030997 File Offset: 0x0002EB97
		internal static global::Org.BouncyCastle.Tls.TlsCredentialedDecryptor RequireDecryptorCredentials(global::Org.BouncyCastle.Tls.TlsCredentials credentials)
		{
			if (!(credentials is global::Org.BouncyCastle.Tls.TlsCredentialedDecryptor))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return (global::Org.BouncyCastle.Tls.TlsCredentialedDecryptor)credentials;
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000309AF File Offset: 0x0002EBAF
		internal static global::Org.BouncyCastle.Tls.TlsCredentialedSigner RequireSignerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials credentials)
		{
			if (!(credentials is global::Org.BouncyCastle.Tls.TlsCredentialedSigner))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return (global::Org.BouncyCastle.Tls.TlsCredentialedSigner)credentials;
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000309C8 File Offset: 0x0002EBC8
		private static void CheckDowngradeMarker(byte[] randomBlock, byte[] downgradeMarker)
		{
			int len = downgradeMarker.Length;
			if (global::Org.BouncyCastle.Tls.TlsUtilities.ConstantTimeAreEqual(len, downgradeMarker, 0, randomBlock, randomBlock.Length - len))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000309F1 File Offset: 0x0002EBF1
		internal static void CheckDowngradeMarker(global::Org.BouncyCastle.Tls.ProtocolVersion version, byte[] randomBlock)
		{
			version = version.GetEquivalentTlsVersion();
			if (version.IsEqualOrEarlierVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv11))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckDowngradeMarker(randomBlock, global::Org.BouncyCastle.Tls.TlsUtilities.DowngradeTlsV11);
			}
			if (version.IsEqualOrEarlierVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckDowngradeMarker(randomBlock, global::Org.BouncyCastle.Tls.TlsUtilities.DowngradeTlsV12);
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00030A2C File Offset: 0x0002EC2C
		internal static void WriteDowngradeMarker(global::Org.BouncyCastle.Tls.ProtocolVersion version, byte[] randomBlock)
		{
			version = version.GetEquivalentTlsVersion();
			byte[] marker;
			if (global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12 == version)
			{
				marker = global::Org.BouncyCastle.Tls.TlsUtilities.DowngradeTlsV12;
			}
			else
			{
				if (!version.IsEqualOrEarlierVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv11))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				marker = global::Org.BouncyCastle.Tls.TlsUtilities.DowngradeTlsV11;
			}
			global::System.Array.Copy(marker, 0, randomBlock, randomBlock.Length - marker.Length, marker.Length);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00030A80 File Offset: 0x0002EC80
		internal static global::Org.BouncyCastle.Tls.TlsAuthentication ReceiveServerCertificate(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.TlsClient client, global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = clientContext.SecurityParameters;
			if (securityParameters.PeerCertificate != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			global::System.IO.MemoryStream endPointHash = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.Certificate serverCertificate = global::Org.BouncyCastle.Tls.Certificate.Parse(new global::Org.BouncyCastle.Tls.Certificate.ParseOptions().SetMaxChainLength(client.GetMaxCertificateChainLength()), clientContext, buf, endPointHash);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			if (serverCertificate.IsEmpty)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			securityParameters.m_peerCertificate = serverCertificate;
			securityParameters.m_tlsServerEndPoint = endPointHash.ToArray();
			global::Org.BouncyCastle.Tls.TlsAuthentication authentication = client.GetAuthentication();
			if (authentication == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return authentication;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00030B00 File Offset: 0x0002ED00
		internal static global::Org.BouncyCastle.Tls.TlsAuthentication Receive13ServerCertificate(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.TlsClient client, global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = clientContext.SecurityParameters;
			if (securityParameters.PeerCertificate != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			global::Org.BouncyCastle.Tls.Certificate serverCertificate = global::Org.BouncyCastle.Tls.Certificate.Parse(new global::Org.BouncyCastle.Tls.Certificate.ParseOptions().SetMaxChainLength(client.GetMaxCertificateChainLength()), clientContext, buf, null);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			if (serverCertificate.GetCertificateRequestContext().Length != 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			if (serverCertificate.IsEmpty)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			securityParameters.m_peerCertificate = serverCertificate;
			securityParameters.m_tlsServerEndPoint = null;
			global::Org.BouncyCastle.Tls.TlsAuthentication authentication = client.GetAuthentication();
			if (authentication == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return authentication;
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00030B88 File Offset: 0x0002ED88
		internal static global::Org.BouncyCastle.Tls.TlsAuthentication Skip13ServerCertificate(global::Org.BouncyCastle.Tls.TlsClientContext clientContext)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = clientContext.SecurityParameters;
			if (securityParameters.PeerCertificate != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			securityParameters.m_peerCertificate = null;
			securityParameters.m_tlsServerEndPoint = null;
			return null;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00030BBC File Offset: 0x0002EDBC
		public static bool ContainsNonAscii(byte[] bs)
		{
			for (int i = 0; i < bs.Length; i++)
			{
				if (bs[i] >= 128)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00030BE4 File Offset: 0x0002EDE4
		public static bool ContainsNonAscii(string s)
		{
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] >= '\u0080')
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00030C14 File Offset: 0x0002EE14
		internal static global::System.Collections.IDictionary AddKeyShareToClientHello(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.TlsClient client, global::System.Collections.IDictionary clientExtensions)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(clientContext.ClientVersion) || !clientExtensions.Contains(10))
			{
				return null;
			}
			int[] supportedGroups = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedGroupsExtension(clientExtensions);
			global::System.Collections.IList keyShareGroups = client.GetEarlyKeyShareGroups();
			global::System.Collections.IDictionary clientAgreements = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(3);
			global::System.Collections.IList clientShares = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(2);
			global::Org.BouncyCastle.Tls.TlsUtilities.CollectKeyShares(clientContext.Crypto, supportedGroups, keyShareGroups, clientAgreements, clientShares);
			global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddKeyShareClientHello(clientExtensions, clientShares);
			return clientAgreements;
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00030C74 File Offset: 0x0002EE74
		internal static global::System.Collections.IDictionary AddKeyShareToClientHelloRetry(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::System.Collections.IDictionary clientExtensions, int keyShareGroup)
		{
			int[] supportedGroups = new int[]
			{
				keyShareGroup
			};
			global::System.Collections.IList keyShareGroups = global::Org.BouncyCastle.Tls.TlsUtilities.VectorOfOne(keyShareGroup);
			global::System.Collections.IDictionary clientAgreements = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(1);
			global::System.Collections.IList clientShares = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1);
			global::Org.BouncyCastle.Tls.TlsUtilities.CollectKeyShares(clientContext.Crypto, supportedGroups, keyShareGroups, clientAgreements, clientShares);
			global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddKeyShareClientHello(clientExtensions, clientShares);
			if (clientAgreements.Count < 1 || clientShares.Count < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return clientAgreements;
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00030CD8 File Offset: 0x0002EED8
		private static void CollectKeyShares(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, int[] supportedGroups, global::System.Collections.IList keyShareGroups, global::System.Collections.IDictionary clientAgreements, global::System.Collections.IList clientShares)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(supportedGroups))
			{
				return;
			}
			if (keyShareGroups == null || keyShareGroups.Count < 1)
			{
				return;
			}
			foreach (int supportedGroup in supportedGroups)
			{
				if (keyShareGroups.Contains(supportedGroup) && !clientAgreements.Contains(supportedGroup) && crypto.HasNamedGroup(supportedGroup))
				{
					global::Org.BouncyCastle.Tls.Crypto.TlsAgreement agreement = null;
					if (global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificCurve(supportedGroup))
					{
						if (crypto.HasECDHAgreement())
						{
							agreement = crypto.CreateECDomain(new global::Org.BouncyCastle.Tls.Crypto.TlsECConfig(supportedGroup)).CreateECDH();
						}
					}
					else if (global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificFiniteField(supportedGroup) && crypto.HasDHAgreement())
					{
						agreement = crypto.CreateDHDomain(new global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig(supportedGroup, true)).CreateDH();
					}
					if (agreement != null)
					{
						byte[] key_exchange = agreement.GenerateEphemeral();
						global::Org.BouncyCastle.Tls.KeyShareEntry clientShare = new global::Org.BouncyCastle.Tls.KeyShareEntry(supportedGroup, key_exchange);
						clientShares.Add(clientShare);
						clientAgreements[supportedGroup] = agreement;
					}
				}
			}
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00030DB0 File Offset: 0x0002EFB0
		internal static global::Org.BouncyCastle.Tls.KeyShareEntry SelectKeyShare(global::System.Collections.IList clientShares, int keyShareGroup)
		{
			if (clientShares != null && 1 == clientShares.Count)
			{
				global::Org.BouncyCastle.Tls.KeyShareEntry clientShare = (global::Org.BouncyCastle.Tls.KeyShareEntry)clientShares[0];
				if (clientShare != null && clientShare.NamedGroup == keyShareGroup)
				{
					return clientShare;
				}
			}
			return null;
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00030DE8 File Offset: 0x0002EFE8
		internal static global::Org.BouncyCastle.Tls.KeyShareEntry SelectKeyShare(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion, global::System.Collections.IList clientShares, int[] clientSupportedGroups, int[] serverSupportedGroups)
		{
			if (clientShares != null && !global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(clientSupportedGroups) && !global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(serverSupportedGroups))
			{
				foreach (object obj in clientShares)
				{
					global::Org.BouncyCastle.Tls.KeyShareEntry clientShare = (global::Org.BouncyCastle.Tls.KeyShareEntry)obj;
					int group = clientShare.NamedGroup;
					if (global::Org.BouncyCastle.Tls.NamedGroup.CanBeNegotiated(group, negotiatedVersion) && global::Org.BouncyCastle.Utilities.Arrays.Contains(serverSupportedGroups, group) && global::Org.BouncyCastle.Utilities.Arrays.Contains(clientSupportedGroups, group) && crypto.HasNamedGroup(group) && (!global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificCurve(group) || crypto.HasECDHAgreement()) && (!global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificFiniteField(group) || crypto.HasDHAgreement()))
					{
						return clientShare;
					}
				}
			}
			return null;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00030EA8 File Offset: 0x0002F0A8
		internal static int SelectKeyShareGroup(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion, int[] clientSupportedGroups, int[] serverSupportedGroups)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(clientSupportedGroups) && !global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(serverSupportedGroups))
			{
				foreach (int group in clientSupportedGroups)
				{
					if (global::Org.BouncyCastle.Tls.NamedGroup.CanBeNegotiated(group, negotiatedVersion) && global::Org.BouncyCastle.Utilities.Arrays.Contains(serverSupportedGroups, group) && crypto.HasNamedGroup(group) && (!global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificCurve(group) || crypto.HasECDHAgreement()) && (!global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificFiniteField(group) || crypto.HasDHAgreement()))
					{
						return group;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00030F17 File Offset: 0x0002F117
		internal static byte[] ReadEncryptedPms(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream input)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsSsl(context))
			{
				return global::Org.BouncyCastle.Tls.Ssl3Utilities.ReadEncryptedPms(input);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00030F2E File Offset: 0x0002F12E
		internal static void WriteEncryptedPms(global::Org.BouncyCastle.Tls.TlsContext context, byte[] encryptedPms, global::System.IO.Stream output)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsSsl(context))
			{
				global::Org.BouncyCastle.Tls.Ssl3Utilities.WriteEncryptedPms(encryptedPms, output);
				return;
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(encryptedPms, output);
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00030F48 File Offset: 0x0002F148
		internal static byte[] GetSessionID(global::Org.BouncyCastle.Tls.TlsSession tlsSession)
		{
			if (tlsSession != null)
			{
				byte[] sessionID = tlsSession.SessionID;
				if (sessionID != null && sessionID.Length != 0 && sessionID.Length <= 32)
				{
					return sessionID;
				}
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00030F74 File Offset: 0x0002F174
		internal static void AdjustTranscriptForRetry(global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash)
		{
			byte[] currentPrfHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(handshakeHash);
			handshakeHash.Reset();
			int length = currentPrfHash.Length;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(length);
			byte[] synthetic = new byte[4 + length];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(254, synthetic, 0);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint24(length, synthetic, 1);
			global::System.Array.Copy(currentPrfHash, 0, synthetic, 4, length);
			handshakeHash.Update(synthetic, 0, synthetic.Length);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00030FC8 File Offset: 0x0002F1C8
		internal static global::Org.BouncyCastle.Tls.TlsCredentials EstablishClientCredentials(global::Org.BouncyCastle.Tls.TlsAuthentication clientAuthentication, global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.ValidateCredentials(clientAuthentication.GetClientCredentials(certificateRequest));
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00030FD6 File Offset: 0x0002F1D6
		internal static global::Org.BouncyCastle.Tls.TlsCredentialedSigner Establish13ClientCredentials(global::Org.BouncyCastle.Tls.TlsAuthentication clientAuthentication, global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.Validate13Credentials(clientAuthentication.GetClientCredentials(certificateRequest));
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00030FE4 File Offset: 0x0002F1E4
		internal static void EstablishClientSigAlgs(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, global::System.Collections.IDictionary clientExtensions)
		{
			securityParameters.m_clientSigAlgs = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSignatureAlgorithmsExtension(clientExtensions);
			securityParameters.m_clientSigAlgsCert = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSignatureAlgorithmsCertExtension(clientExtensions);
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00030FFE File Offset: 0x0002F1FE
		internal static global::Org.BouncyCastle.Tls.TlsCredentials EstablishServerCredentials(global::Org.BouncyCastle.Tls.TlsServer server)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.ValidateCredentials(server.GetCredentials());
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0003100B File Offset: 0x0002F20B
		internal static global::Org.BouncyCastle.Tls.TlsCredentialedSigner Establish13ServerCredentials(global::Org.BouncyCastle.Tls.TlsServer server)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.Validate13Credentials(server.GetCredentials());
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00031018 File Offset: 0x0002F218
		internal static void EstablishServerSigAlgs(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest)
		{
			securityParameters.m_clientCertTypes = certificateRequest.CertificateTypes;
			securityParameters.m_serverSigAlgs = certificateRequest.SupportedSignatureAlgorithms;
			securityParameters.m_serverSigAlgsCert = certificateRequest.SupportedSignatureAlgorithmsCert;
			if (securityParameters.ServerSigAlgsCert == null)
			{
				securityParameters.m_serverSigAlgsCert = securityParameters.ServerSigAlgs;
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00031052 File Offset: 0x0002F252
		internal static global::Org.BouncyCastle.Tls.TlsCredentials ValidateCredentials(global::Org.BouncyCastle.Tls.TlsCredentials credentials)
		{
			if (credentials != null && 0 + ((credentials is global::Org.BouncyCastle.Tls.TlsCredentialedAgreement) ? 1 : 0) + ((credentials is global::Org.BouncyCastle.Tls.TlsCredentialedDecryptor) ? 1 : 0) + ((credentials is global::Org.BouncyCastle.Tls.TlsCredentialedSigner) ? 1 : 0) != 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return credentials;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0003108B File Offset: 0x0002F28B
		internal static global::Org.BouncyCastle.Tls.TlsCredentialedSigner Validate13Credentials(global::Org.BouncyCastle.Tls.TlsCredentials credentials)
		{
			if (credentials == null)
			{
				return null;
			}
			if (!(credentials is global::Org.BouncyCastle.Tls.TlsCredentialedSigner))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return (global::Org.BouncyCastle.Tls.TlsCredentialedSigner)credentials;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000310A8 File Offset: 0x0002F2A8
		internal static void NegotiatedCipherSuite(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, int cipherSuite)
		{
			securityParameters.m_cipherSuite = cipherSuite;
			securityParameters.m_keyExchangeAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite);
			int prfAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetPrfAlgorithm(securityParameters, cipherSuite);
			securityParameters.m_prfAlgorithm = prfAlgorithm;
			if (prfAlgorithm <= 1)
			{
				securityParameters.m_prfCryptoHashAlgorithm = -1;
				securityParameters.m_prfHashLength = -1;
			}
			else
			{
				int prfCryptoHashAlgorithm = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashForPrf(prfAlgorithm);
				securityParameters.m_prfCryptoHashAlgorithm = prfCryptoHashAlgorithm;
				securityParameters.m_prfHashLength = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashOutputSize(prfCryptoHashAlgorithm);
			}
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion))
			{
				securityParameters.m_verifyDataLength = securityParameters.PrfHashLength;
				return;
			}
			securityParameters.m_verifyDataLength = (negotiatedVersion.IsSsl ? 36 : 12);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00031138 File Offset: 0x0002F338
		internal static void NegotiatedVersion(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(securityParameters.NegotiatedVersion))
			{
				securityParameters.m_clientSigAlgs = null;
				securityParameters.m_clientSigAlgsCert = null;
				return;
			}
			if (securityParameters.ClientSigAlgs == null)
			{
				securityParameters.m_clientSigAlgs = global::Org.BouncyCastle.Tls.TlsUtilities.GetLegacySupportedSignatureAlgorithms();
			}
			if (securityParameters.ClientSigAlgsCert == null)
			{
				securityParameters.m_clientSigAlgsCert = securityParameters.ClientSigAlgs;
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00031188 File Offset: 0x0002F388
		internal static void NegotiatedVersionDtlsClient(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.TlsClient client)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = clientContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.IsSupportedDtlsVersionClient(negotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedVersion(securityParameters);
			client.NotifyServerVersion(negotiatedVersion);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x000311BE File Offset: 0x0002F3BE
		internal static void NegotiatedVersionDtlsServer(global::Org.BouncyCastle.Tls.TlsServerContext serverContext)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = serverContext.SecurityParameters;
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.IsSupportedDtlsVersionServer(securityParameters.NegotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedVersion(securityParameters);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x000311E0 File Offset: 0x0002F3E0
		internal static void NegotiatedVersionTlsClient(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.TlsClient client)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = clientContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.IsSupportedTlsVersionClient(negotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedVersion(securityParameters);
			client.NotifyServerVersion(negotiatedVersion);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00031216 File Offset: 0x0002F416
		internal static void NegotiatedVersionTlsServer(global::Org.BouncyCastle.Tls.TlsServerContext serverContext)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = serverContext.SecurityParameters;
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.IsSupportedTlsVersionServer(securityParameters.NegotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedVersion(securityParameters);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00031238 File Offset: 0x0002F438
		internal static global::Org.BouncyCastle.Tls.Crypto.TlsSecret DeriveSecret(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret, string label, byte[] transcriptHash)
		{
			int prfCryptoHashAlgorithm = securityParameters.PrfCryptoHashAlgorithm;
			int prfHashLength = securityParameters.PrfHashLength;
			return global::Org.BouncyCastle.Tls.TlsUtilities.DeriveSecret(prfCryptoHashAlgorithm, prfHashLength, secret, label, transcriptHash);
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0003125B File Offset: 0x0002F45B
		internal static global::Org.BouncyCastle.Tls.Crypto.TlsSecret DeriveSecret(int prfCryptoHashAlgorithm, int prfHashLength, global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret, string label, byte[] transcriptHash)
		{
			if (transcriptHash.Length != prfHashLength)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.HkdfExpandLabel(secret, prfCryptoHashAlgorithm, label, transcriptHash, prfHashLength);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00031278 File Offset: 0x0002F478
		internal static global::Org.BouncyCastle.Tls.Crypto.TlsSecret GetSessionMasterSecret(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.Crypto.TlsSecret masterSecret)
		{
			if (masterSecret != null)
			{
				lock (masterSecret)
				{
					if (masterSecret.IsAlive())
					{
						return crypto.AdoptSecret(masterSecret);
					}
				}
			}
			return null;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x000312C8 File Offset: 0x0002F4C8
		internal static bool IsPermittedExtensionType13(int handshakeType, int extensionType)
		{
			switch (extensionType)
			{
			case 0:
			case 1:
			case 10:
			case 14:
			case 15:
			case 16:
			case 19:
			case 20:
				return handshakeType == 1 || handshakeType == 8;
			case 2:
			case 3:
			case 4:
			case 6:
			case 7:
			case 8:
			case 9:
			case 11:
			case 12:
			case 17:
				goto IL_105;
			case 5:
			case 18:
				return handshakeType == 1 || handshakeType == 11 || handshakeType == 13;
			case 13:
				break;
			case 21:
				goto IL_C0;
			default:
				switch (extensionType)
				{
				case 41:
					return handshakeType - 1 <= 1;
				case 42:
					return handshakeType == 1 || handshakeType == 4 || handshakeType == 8;
				case 43:
				case 51:
					return handshakeType - 1 <= 1 || handshakeType == 6;
				case 44:
					return handshakeType == 1 || handshakeType == 6;
				case 45:
				case 49:
					goto IL_C0;
				case 46:
					goto IL_105;
				case 47:
				case 50:
					break;
				case 48:
					return handshakeType == 13;
				default:
					goto IL_105;
				}
				break;
			}
			return handshakeType == 1 || handshakeType == 13;
			IL_C0:
			return handshakeType == 1;
			IL_105:
			return !global::Org.BouncyCastle.Tls.ExtensionType.IsRecognized(extensionType);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000313E4 File Offset: 0x0002F5E4
		internal static void CheckExtensionData13(global::System.Collections.IDictionary extensions, int handshakeType, short alertDescription)
		{
			foreach (object obj in extensions.Keys)
			{
				int extensionType = (int)obj;
				if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsPermittedExtensionType13(handshakeType, extensionType))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(alertDescription, "Invalid extension: " + global::Org.BouncyCastle.Tls.ExtensionType.GetText(extensionType));
				}
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00031458 File Offset: 0x0002F658
		public static global::Org.BouncyCastle.Tls.Crypto.TlsSecret GenerateEncryptedPreMasterSecret(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsEncryptor encryptor, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion version = context.RsaPreMasterSecretVersion;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret tlsSecret = context.Crypto.GenerateRsaPreMasterSecret(version);
			byte[] encryptedPreMasterSecret = tlsSecret.Encrypt(encryptor);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteEncryptedPms(context, encryptedPreMasterSecret, output);
			return tlsSecret;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00031488 File Offset: 0x0002F688
		public static bool IsTimeout(global::System.Net.Sockets.SocketException e)
		{
			return global::System.Net.Sockets.SocketError.TimedOut == e.SocketErrorCode;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00031498 File Offset: 0x0002F698
		internal static void AddPreSharedKeyToClientExtensions(global::Org.BouncyCastle.Tls.TlsPsk[] psks, global::System.Collections.IDictionary clientExtensions)
		{
			global::System.Collections.IList identities = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(psks.Length);
			foreach (global::Org.BouncyCastle.Tls.TlsPsk psk in psks)
			{
				identities.Add(new global::Org.BouncyCastle.Tls.PskIdentity(psk.Identity, 0L));
			}
			global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddPreSharedKeyClientHello(clientExtensions, new global::Org.BouncyCastle.Tls.OfferedPsks(identities));
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x000314E0 File Offset: 0x0002F6E0
		internal static global::Org.BouncyCastle.Tls.OfferedPsks.BindersConfig AddPreSharedKeyToClientHello(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.TlsClient client, global::System.Collections.IDictionary clientExtensions, int[] offeredCipherSuites)
		{
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(clientContext.ClientVersion))
			{
				return null;
			}
			global::Org.BouncyCastle.Tls.TlsPskExternal[] pskExternals = global::Org.BouncyCastle.Tls.TlsUtilities.GetPskExternalsClient(client, offeredCipherSuites);
			if (pskExternals == null)
			{
				return null;
			}
			short[] pskKeyExchangeModes = client.GetPskKeyExchangeModes();
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(pskKeyExchangeModes))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, "External PSKs configured but no PskKeyExchangeMode available");
			}
			global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto = clientContext.Crypto;
			global::Org.BouncyCastle.Tls.TlsPsk[] psks = pskExternals;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret[] pskEarlySecrets = global::Org.BouncyCastle.Tls.TlsUtilities.GetPskEarlySecrets(crypto, psks);
			psks = pskExternals;
			int bindersSize = global::Org.BouncyCastle.Tls.OfferedPsks.GetBindersSize(psks);
			psks = pskExternals;
			global::Org.BouncyCastle.Tls.TlsUtilities.AddPreSharedKeyToClientExtensions(psks, clientExtensions);
			global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddPskKeyExchangeModesExtension(clientExtensions, pskKeyExchangeModes);
			psks = pskExternals;
			return new global::Org.BouncyCastle.Tls.OfferedPsks.BindersConfig(psks, pskKeyExchangeModes, pskEarlySecrets, bindersSize);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00031560 File Offset: 0x0002F760
		internal static global::Org.BouncyCastle.Tls.OfferedPsks.BindersConfig AddPreSharedKeyToClientHelloRetry(global::Org.BouncyCastle.Tls.TlsClientContext clientContext, global::Org.BouncyCastle.Tls.OfferedPsks.BindersConfig clientBinders, global::System.Collections.IDictionary clientExtensions)
		{
			int prfAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetPrfAlgorithm13(clientContext.SecurityParameters.CipherSuite);
			global::System.Collections.IList pskIndices = global::Org.BouncyCastle.Tls.TlsUtilities.GetPskIndices(clientBinders.m_psks, prfAlgorithm);
			if (pskIndices.Count < 1)
			{
				return null;
			}
			global::Org.BouncyCastle.Tls.OfferedPsks.BindersConfig result = clientBinders;
			int count = pskIndices.Count;
			if (count < clientBinders.m_psks.Length)
			{
				global::Org.BouncyCastle.Tls.TlsPsk[] psks = new global::Org.BouncyCastle.Tls.TlsPsk[count];
				global::Org.BouncyCastle.Tls.Crypto.TlsSecret[] earlySecrets = new global::Org.BouncyCastle.Tls.Crypto.TlsSecret[count];
				for (int i = 0; i < count; i++)
				{
					int j = (int)pskIndices[i];
					psks[i] = clientBinders.m_psks[j];
					earlySecrets[i] = clientBinders.m_earlySecrets[j];
				}
				int bindersSize = global::Org.BouncyCastle.Tls.OfferedPsks.GetBindersSize(psks);
				result = new global::Org.BouncyCastle.Tls.OfferedPsks.BindersConfig(psks, clientBinders.m_pskKeyExchangeModes, earlySecrets, bindersSize);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.AddPreSharedKeyToClientExtensions(result.m_psks, clientExtensions);
			return result;
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00031620 File Offset: 0x0002F820
		internal static global::Org.BouncyCastle.Tls.OfferedPsks.SelectedConfig SelectPreSharedKey(global::Org.BouncyCastle.Tls.TlsServerContext serverContext, global::Org.BouncyCastle.Tls.TlsServer server, global::System.Collections.IDictionary clientHelloExtensions, global::Org.BouncyCastle.Tls.HandshakeMessageInput clientHelloMessage, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash, bool afterHelloRetryRequest)
		{
			bool handshakeHashUpdated = false;
			global::Org.BouncyCastle.Tls.OfferedPsks offeredPsks = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetPreSharedKeyClientHello(clientHelloExtensions);
			if (offeredPsks != null)
			{
				short[] pskKeyExchangeModes = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetPskKeyExchangeModesExtension(clientHelloExtensions);
				if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(pskKeyExchangeModes))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(109);
				}
				if (global::Org.BouncyCastle.Utilities.Arrays.Contains(pskKeyExchangeModes, 1))
				{
					global::Org.BouncyCastle.Tls.TlsPskExternal psk = server.GetExternalPsk(offeredPsks.Identities);
					if (psk != null)
					{
						int index = offeredPsks.GetIndexOfIdentity(new global::Org.BouncyCastle.Tls.PskIdentity(psk.Identity, 0L));
						if (index >= 0)
						{
							byte[] binder = (byte[])offeredPsks.Binders[index];
							global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto = serverContext.Crypto;
							global::Org.BouncyCastle.Tls.Crypto.TlsSecret earlySecret = global::Org.BouncyCastle.Tls.TlsUtilities.GetPskEarlySecret(crypto, psk);
							bool isExternalPsk = true;
							int pskCryptoHashAlgorithm = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashForPrf(psk.PrfAlgorithm);
							handshakeHashUpdated = true;
							int bindersSize = offeredPsks.BindersSize;
							clientHelloMessage.UpdateHashPrefix(handshakeHash, bindersSize);
							byte[] transcriptHash;
							if (afterHelloRetryRequest)
							{
								transcriptHash = handshakeHash.GetFinalHash(pskCryptoHashAlgorithm);
							}
							else
							{
								global::Org.BouncyCastle.Tls.Crypto.TlsHash hash = crypto.CreateHash(pskCryptoHashAlgorithm);
								handshakeHash.CopyBufferTo(new global::Org.BouncyCastle.Tls.Crypto.TlsHashSink(hash));
								transcriptHash = hash.CalculateHash();
							}
							clientHelloMessage.UpdateHashSuffix(handshakeHash, bindersSize);
							if (global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(global::Org.BouncyCastle.Tls.TlsUtilities.CalculatePskBinder(crypto, isExternalPsk, pskCryptoHashAlgorithm, earlySecret, transcriptHash), binder))
							{
								return new global::Org.BouncyCastle.Tls.OfferedPsks.SelectedConfig(index, psk, pskKeyExchangeModes, earlySecret);
							}
						}
					}
				}
			}
			if (!handshakeHashUpdated)
			{
				clientHelloMessage.UpdateHash(handshakeHash);
			}
			return null;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00031748 File Offset: 0x0002F948
		internal static global::Org.BouncyCastle.Tls.Crypto.TlsSecret GetPskEarlySecret(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.TlsPsk psk)
		{
			int cryptoHashAlgorithm = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashForPrf(psk.PrfAlgorithm);
			return crypto.HkdfInit(cryptoHashAlgorithm).HkdfExtract(cryptoHashAlgorithm, psk.Key);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00031774 File Offset: 0x0002F974
		internal static global::Org.BouncyCastle.Tls.Crypto.TlsSecret[] GetPskEarlySecrets(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.TlsPsk[] psks)
		{
			int count = psks.Length;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret[] earlySecrets = new global::Org.BouncyCastle.Tls.Crypto.TlsSecret[count];
			for (int i = 0; i < count; i++)
			{
				earlySecrets[i] = global::Org.BouncyCastle.Tls.TlsUtilities.GetPskEarlySecret(crypto, psks[i]);
			}
			return earlySecrets;
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000317A8 File Offset: 0x0002F9A8
		internal static global::Org.BouncyCastle.Tls.TlsPskExternal[] GetPskExternalsClient(global::Org.BouncyCastle.Tls.TlsClient client, int[] offeredCipherSuites)
		{
			global::System.Collections.IList externalPsks = client.GetExternalPsks();
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(externalPsks))
			{
				return null;
			}
			int[] prfAlgorithms = global::Org.BouncyCastle.Tls.TlsUtilities.GetPrfAlgorithms13(offeredCipherSuites);
			int count = externalPsks.Count;
			global::Org.BouncyCastle.Tls.TlsPskExternal[] result = new global::Org.BouncyCastle.Tls.TlsPskExternal[count];
			for (int i = 0; i < count; i++)
			{
				global::Org.BouncyCastle.Tls.TlsPskExternal pskExternal = externalPsks[i] as global::Org.BouncyCastle.Tls.TlsPskExternal;
				if (pskExternal == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, "External PSKs element is not a TlsPSKExternal");
				}
				if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(prfAlgorithms, pskExternal.PrfAlgorithm))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, "External PSK incompatible with offered cipher suites");
				}
				result[i] = pskExternal;
			}
			return result;
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00031830 File Offset: 0x0002FA30
		internal static global::System.Collections.IList GetPskIndices(global::Org.BouncyCastle.Tls.TlsPsk[] psks, int prfAlgorithm)
		{
			global::System.Collections.IList v = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(psks.Length);
			for (int i = 0; i < psks.Length; i++)
			{
				if (psks[i].PrfAlgorithm == prfAlgorithm)
				{
					v.Add(i);
				}
			}
			return v;
		}

		// Token: 0x04000754 RID: 1876
		private static readonly byte[] DowngradeTlsV11 = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("444F574E47524400");

		// Token: 0x04000755 RID: 1877
		private static readonly byte[] DowngradeTlsV12 = global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("444F574E47524401");

		// Token: 0x04000756 RID: 1878
		private static readonly global::System.Collections.IDictionary CertSigAlgOids = global::Org.BouncyCastle.Tls.TlsUtilities.CreateCertSigAlgOids();

		// Token: 0x04000757 RID: 1879
		private static readonly global::System.Collections.IList DefaultSupportedSigAlgs = global::Org.BouncyCastle.Tls.TlsUtilities.CreateDefaultSupportedSigAlgs();

		// Token: 0x04000758 RID: 1880
		public static readonly byte[] EmptyBytes = new byte[0];

		// Token: 0x04000759 RID: 1881
		public static readonly short[] EmptyShorts = new short[0];

		// Token: 0x0400075A RID: 1882
		public static readonly int[] EmptyInts = new int[0];

		// Token: 0x0400075B RID: 1883
		public static readonly long[] EmptyLongs = new long[0];

		// Token: 0x0400075C RID: 1884
		public static readonly string[] EmptyStrings = new string[0];

		// Token: 0x0400075D RID: 1885
		internal static short MinimumHashStrict = 2;

		// Token: 0x0400075E RID: 1886
		internal static short MinimumHashPreferred = 4;
	}
}
