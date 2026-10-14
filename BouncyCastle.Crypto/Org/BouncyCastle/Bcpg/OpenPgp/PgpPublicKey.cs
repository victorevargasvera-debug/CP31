using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005B8 RID: 1464
	public class PgpPublicKey
	{
		// Token: 0x06003694 RID: 13972 RVA: 0x001022A4 File Offset: 0x001004A4
		public static byte[] CalculateFingerprint(global::Org.BouncyCastle.Bcpg.PublicKeyPacket publicPk)
		{
			global::Org.BouncyCastle.Bcpg.IBcpgKey key = publicPk.Key;
			global::Org.BouncyCastle.Crypto.IDigest digest;
			if (publicPk.Version <= 3)
			{
				global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey rK = (global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey)key;
				try
				{
					digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest("MD5");
					global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.UpdateDigest(digest, rK.Modulus);
					global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.UpdateDigest(digest, rK.PublicExponent);
					goto IL_B5;
				}
				catch (global::System.Exception e)
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("can't encode key components: " + e.Message, e);
				}
			}
			try
			{
				byte[] kBytes = publicPk.GetEncodedContents();
				digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest("SHA1");
				digest.Update(153);
				digest.Update((byte)(kBytes.Length >> 8));
				digest.Update((byte)kBytes.Length);
				digest.BlockUpdate(kBytes, 0, kBytes.Length);
			}
			catch (global::System.Exception e2)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("can't encode key components: " + e2.Message, e2);
			}
			IL_B5:
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x00102388 File Offset: 0x00100588
		private static void UpdateDigest(global::Org.BouncyCastle.Crypto.IDigest d, global::Org.BouncyCastle.Math.BigInteger b)
		{
			byte[] bytes = b.ToByteArrayUnsigned();
			d.BlockUpdate(bytes, 0, bytes.Length);
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x001023A8 File Offset: 0x001005A8
		private void Init()
		{
			global::Org.BouncyCastle.Bcpg.IBcpgKey key = this.publicPk.Key;
			this.fingerprint = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.CalculateFingerprint(this.publicPk);
			if (this.publicPk.Version <= 3)
			{
				global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey rK = (global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey)key;
				this.keyId = rK.Modulus.LongValue;
				this.keyStrength = rK.Modulus.BitLength;
				return;
			}
			this.keyId = (long)((ulong)this.fingerprint[this.fingerprint.Length - 8] << 56 | (ulong)this.fingerprint[this.fingerprint.Length - 7] << 48 | (ulong)this.fingerprint[this.fingerprint.Length - 6] << 40 | (ulong)this.fingerprint[this.fingerprint.Length - 5] << 32 | (ulong)this.fingerprint[this.fingerprint.Length - 4] << 24 | (ulong)this.fingerprint[this.fingerprint.Length - 3] << 16 | (ulong)this.fingerprint[this.fingerprint.Length - 2] << 8 | (ulong)this.fingerprint[this.fingerprint.Length - 1]);
			if (key is global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey)
			{
				this.keyStrength = ((global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey)key).Modulus.BitLength;
				return;
			}
			if (key is global::Org.BouncyCastle.Bcpg.DsaPublicBcpgKey)
			{
				this.keyStrength = ((global::Org.BouncyCastle.Bcpg.DsaPublicBcpgKey)key).P.BitLength;
				return;
			}
			if (key is global::Org.BouncyCastle.Bcpg.ElGamalPublicBcpgKey)
			{
				this.keyStrength = ((global::Org.BouncyCastle.Bcpg.ElGamalPublicBcpgKey)key).P.BitLength;
				return;
			}
			if (key is global::Org.BouncyCastle.Bcpg.ECPublicBcpgKey)
			{
				this.keyStrength = global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.FindECCurveByOid(((global::Org.BouncyCastle.Bcpg.ECPublicBcpgKey)key).CurveOid).Curve.FieldSize;
			}
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00102540 File Offset: 0x00100740
		public PgpPublicKey(global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey, global::System.DateTime time)
		{
			if (pubKey.IsPrivate)
			{
				throw new global::System.ArgumentException("Expected a public key", "pubKey");
			}
			global::Org.BouncyCastle.Bcpg.IBcpgKey bcpgKey;
			if (pubKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters rK = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)pubKey;
				bcpgKey = new global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey(rK.Modulus, rK.Exponent);
			}
			else if (pubKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters dK = (global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)pubKey;
				global::Org.BouncyCastle.Crypto.Parameters.DsaParameters dP = dK.Parameters;
				bcpgKey = new global::Org.BouncyCastle.Bcpg.DsaPublicBcpgKey(dP.P, dP.Q, dP.G, dK.Y);
			}
			else if (pubKey is global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters ecK = (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)pubKey;
				if (algorithm == global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC)
				{
					bcpgKey = new global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey(ecK.PublicKeyParamSet, ecK.Q, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha256, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes128);
				}
				else
				{
					if (algorithm != global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ECDsa)
					{
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown EC algorithm");
					}
					bcpgKey = new global::Org.BouncyCastle.Bcpg.ECDsaPublicBcpgKey(ecK.PublicKeyParamSet, ecK.Q);
				}
			}
			else
			{
				if (!(pubKey is global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters))
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown key class");
				}
				global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters eK = (global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters)pubKey;
				global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters eS = eK.Parameters;
				bcpgKey = new global::Org.BouncyCastle.Bcpg.ElGamalPublicBcpgKey(eS.P, eS.G, eK.Y);
			}
			this.publicPk = new global::Org.BouncyCastle.Bcpg.PublicKeyPacket(algorithm, time, bcpgKey);
			this.ids = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			this.idSigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			try
			{
				this.Init();
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception calculating keyId", e);
			}
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x001026D8 File Offset: 0x001008D8
		public PgpPublicKey(global::Org.BouncyCastle.Bcpg.PublicKeyPacket publicPk) : this(publicPk, global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(), global::Org.BouncyCastle.Utilities.Platform.CreateArrayList())
		{
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x001026EC File Offset: 0x001008EC
		internal PgpPublicKey(global::Org.BouncyCastle.Bcpg.PublicKeyPacket publicPk, global::Org.BouncyCastle.Bcpg.TrustPacket trustPk, global::System.Collections.IList sigs)
		{
			this.publicPk = publicPk;
			this.trustPk = trustPk;
			this.subSigs = sigs;
			this.Init();
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x00102748 File Offset: 0x00100948
		internal PgpPublicKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, global::Org.BouncyCastle.Bcpg.TrustPacket trust, global::System.Collections.IList subSigs)
		{
			this.publicPk = key.publicPk;
			this.trustPk = trust;
			this.subSigs = subSigs;
			this.fingerprint = key.fingerprint;
			this.keyId = key.keyId;
			this.keyStrength = key.keyStrength;
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x001027C8 File Offset: 0x001009C8
		internal PgpPublicKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			this.publicPk = pubKey.publicPk;
			this.keySigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(pubKey.keySigs);
			this.ids = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(pubKey.ids);
			this.idTrusts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(pubKey.idTrusts);
			this.idSigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(pubKey.idSigs.Count);
			for (int i = 0; i != pubKey.idSigs.Count; i++)
			{
				this.idSigs.Add(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList((global::System.Collections.IList)pubKey.idSigs[i]));
			}
			if (pubKey.subSigs != null)
			{
				this.subSigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(pubKey.subSigs.Count);
				for (int j = 0; j != pubKey.subSigs.Count; j++)
				{
					this.subSigs.Add(pubKey.subSigs[j]);
				}
			}
			this.fingerprint = pubKey.fingerprint;
			this.keyId = pubKey.keyId;
			this.keyStrength = pubKey.keyStrength;
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x00102904 File Offset: 0x00100B04
		internal PgpPublicKey(global::Org.BouncyCastle.Bcpg.PublicKeyPacket publicPk, global::Org.BouncyCastle.Bcpg.TrustPacket trustPk, global::System.Collections.IList keySigs, global::System.Collections.IList ids, global::System.Collections.IList idTrusts, global::System.Collections.IList idSigs)
		{
			this.publicPk = publicPk;
			this.trustPk = trustPk;
			this.keySigs = keySigs;
			this.ids = ids;
			this.idTrusts = idTrusts;
			this.idSigs = idSigs;
			this.Init();
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x00102978 File Offset: 0x00100B78
		internal PgpPublicKey(global::Org.BouncyCastle.Bcpg.PublicKeyPacket publicPk, global::System.Collections.IList ids, global::System.Collections.IList idSigs)
		{
			this.publicPk = publicPk;
			this.ids = ids;
			this.idSigs = idSigs;
			this.Init();
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600369E RID: 13982 RVA: 0x001029D2 File Offset: 0x00100BD2
		public int Version
		{
			get
			{
				return this.publicPk.Version;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x001029DF File Offset: 0x00100BDF
		public global::System.DateTime CreationTime
		{
			get
			{
				return this.publicPk.GetTime();
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060036A0 RID: 13984 RVA: 0x001029EC File Offset: 0x00100BEC
		[global::System.Obsolete("Use 'GetValidSeconds' instead")]
		public int ValidDays
		{
			get
			{
				if (this.publicPk.Version <= 3)
				{
					return this.publicPk.ValidDays;
				}
				long expSecs = this.GetValidSeconds();
				if (expSecs <= 0L)
				{
					return 0;
				}
				int days = (int)(expSecs / 86400L);
				return global::System.Math.Max(1, days);
			}
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x00102A32 File Offset: 0x00100C32
		public byte[] GetTrustData()
		{
			if (this.trustPk == null)
			{
				return null;
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.trustPk.GetLevelAndTrustAmount());
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x00102A50 File Offset: 0x00100C50
		public long GetValidSeconds()
		{
			if (this.publicPk.Version <= 3)
			{
				return (long)this.publicPk.ValidDays * 86400L;
			}
			if (this.IsMasterKey)
			{
				for (int i = 0; i != global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.MasterKeyCertificationTypes.Length; i++)
				{
					long seconds = this.GetExpirationTimeFromSig(true, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.MasterKeyCertificationTypes[i]);
					if (seconds >= 0L)
					{
						return seconds;
					}
				}
			}
			else
			{
				long seconds2 = this.GetExpirationTimeFromSig(false, 24);
				if (seconds2 >= 0L)
				{
					return seconds2;
				}
				seconds2 = this.GetExpirationTimeFromSig(false, 31);
				if (seconds2 >= 0L)
				{
					return seconds2;
				}
			}
			return 0L;
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x00102AD8 File Offset: 0x00100CD8
		private long GetExpirationTimeFromSig(bool selfSigned, int signatureType)
		{
			long expiryTime = -1L;
			long lastDate = -1L;
			foreach (object obj in this.GetSignaturesOfType(signatureType))
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature sig = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)obj;
				if (!selfSigned || sig.KeyId == this.KeyId)
				{
					global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector hashed = sig.GetHashedSubPackets();
					if (hashed != null && hashed.HasSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.KeyExpireTime))
					{
						long current = hashed.GetKeyExpirationTime();
						if (sig.KeyId == this.KeyId)
						{
							if (sig.CreationTime.Ticks > lastDate)
							{
								lastDate = sig.CreationTime.Ticks;
								expiryTime = current;
							}
						}
						else if (current == 0L || current > expiryTime)
						{
							expiryTime = current;
						}
					}
				}
			}
			return expiryTime;
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060036A4 RID: 13988 RVA: 0x00102BAC File Offset: 0x00100DAC
		public long KeyId
		{
			get
			{
				return this.keyId;
			}
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00102BB4 File Offset: 0x00100DB4
		public byte[] GetFingerprint()
		{
			return (byte[])this.fingerprint.Clone();
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x00102BC8 File Offset: 0x00100DC8
		public bool IsEncryptionKey
		{
			get
			{
				global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm = this.publicPk.Algorithm;
				if (algorithm - global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral > 1)
				{
					switch (algorithm)
					{
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt:
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC:
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
						return true;
					}
					return false;
				}
				return true;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x00102C09 File Offset: 0x00100E09
		public bool IsMasterKey
		{
			get
			{
				return this.subSigs == null && (!this.IsEncryptionKey || this.publicPk.Algorithm == global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral);
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x00102C2D File Offset: 0x00100E2D
		public global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag Algorithm
		{
			get
			{
				return this.publicPk.Algorithm;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060036A9 RID: 13993 RVA: 0x00102C3A File Offset: 0x00100E3A
		public int BitStrength
		{
			get
			{
				return this.keyStrength;
			}
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x00102C44 File Offset: 0x00100E44
		public global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter GetKey()
		{
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter result;
			try
			{
				global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm = this.publicPk.Algorithm;
				if (algorithm - global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral > 2)
				{
					switch (algorithm)
					{
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt:
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
					{
						global::Org.BouncyCastle.Bcpg.ElGamalPublicBcpgKey elK = (global::Org.BouncyCastle.Bcpg.ElGamalPublicBcpgKey)this.publicPk.Key;
						result = new global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters(elK.Y, new global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters(elK.P, elK.G));
						break;
					}
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.Dsa:
					{
						global::Org.BouncyCastle.Bcpg.DsaPublicBcpgKey dsaK = (global::Org.BouncyCastle.Bcpg.DsaPublicBcpgKey)this.publicPk.Key;
						result = new global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters(dsaK.Y, new global::Org.BouncyCastle.Crypto.Parameters.DsaParameters(dsaK.P, dsaK.Q, dsaK.G));
						break;
					}
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC:
						result = this.GetECKey("ECDH");
						break;
					case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ECDsa:
						result = this.GetECKey("ECDSA");
						break;
					default:
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown public key algorithm encountered");
					}
				}
				else
				{
					global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey rsaK = (global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey)this.publicPk.Key;
					result = new global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(false, rsaK.Modulus, rsaK.PublicExponent);
				}
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception constructing public key", e);
			}
			return result;
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x00102D70 File Offset: 0x00100F70
		private global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters GetECKey(string algorithm)
		{
			global::Org.BouncyCastle.Bcpg.ECPublicBcpgKey ecK = (global::Org.BouncyCastle.Bcpg.ECPublicBcpgKey)this.publicPk.Key;
			global::Org.BouncyCastle.Math.EC.ECPoint q = global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.FindECCurveByOid(ecK.CurveOid).Curve.DecodePoint(global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(ecK.EncodedPoint));
			return new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(algorithm, q, ecK.CurveOid);
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x00102DBC File Offset: 0x00100FBC
		public global::System.Collections.IEnumerable GetUserIds()
		{
			global::System.Collections.IList temp = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object o in this.ids)
			{
				if (o is string)
				{
					temp.Add(o);
				}
			}
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(temp);
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x00102E28 File Offset: 0x00101028
		public global::System.Collections.IEnumerable GetUserAttributes()
		{
			global::System.Collections.IList temp = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object o in this.ids)
			{
				if (o is global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector)
				{
					temp.Add(o);
				}
			}
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(temp);
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x00102E94 File Offset: 0x00101094
		public global::System.Collections.IEnumerable GetSignaturesForId(string id)
		{
			if (id == null)
			{
				throw new global::System.ArgumentNullException("id");
			}
			global::System.Collections.IList signatures = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			bool userIdFound = false;
			for (int i = 0; i != this.ids.Count; i++)
			{
				if (id.Equals(this.ids[i]))
				{
					userIdFound = true;
					global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(signatures, (global::System.Collections.IList)this.idSigs[i]);
				}
			}
			if (!userIdFound)
			{
				return null;
			}
			return signatures;
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00102F00 File Offset: 0x00101100
		public global::System.Collections.IEnumerable GetSignaturesForUserAttribute(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector userAttributes)
		{
			if (userAttributes == null)
			{
				throw new global::System.ArgumentNullException("userAttributes");
			}
			global::System.Collections.IList signatures = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			bool attributeFound = false;
			for (int i = 0; i != this.ids.Count; i++)
			{
				if (userAttributes.Equals(this.ids[i]))
				{
					attributeFound = true;
					global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(signatures, (global::System.Collections.IList)this.idSigs[i]);
				}
			}
			if (!attributeFound)
			{
				return null;
			}
			return signatures;
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x00102F6C File Offset: 0x0010116C
		public global::System.Collections.IEnumerable GetSignaturesOfType(int signatureType)
		{
			global::System.Collections.IList temp = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj in this.GetSignatures())
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature sig = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)obj;
				if (sig.SignatureType == signatureType)
				{
					temp.Add(sig);
				}
			}
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(temp);
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x00102FDC File Offset: 0x001011DC
		public global::System.Collections.IEnumerable GetSignatures()
		{
			global::System.Collections.IList sigs = this.subSigs;
			if (sigs == null)
			{
				sigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.keySigs);
				foreach (object obj in this.idSigs)
				{
					global::System.Collections.ICollection extraSigs = (global::System.Collections.ICollection)obj;
					global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.AddRange(sigs, extraSigs);
				}
			}
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(sigs);
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x00103054 File Offset: 0x00101254
		public global::System.Collections.IEnumerable GetKeySignatures()
		{
			global::System.Collections.IList sigs = this.subSigs;
			if (sigs == null)
			{
				sigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.keySigs);
			}
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(sigs);
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x0010307D File Offset: 0x0010127D
		public global::Org.BouncyCastle.Bcpg.PublicKeyPacket PublicKeyPacket
		{
			get
			{
				return this.publicPk;
			}
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x00103088 File Offset: 0x00101288
		public byte[] GetEncoded()
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			this.Encode(bOut);
			return bOut.ToArray();
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x001030A8 File Offset: 0x001012A8
		public void Encode(global::System.IO.Stream outStr)
		{
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut = global::Org.BouncyCastle.Bcpg.BcpgOutputStream.Wrap(outStr);
			bcpgOut.WritePacket(this.publicPk);
			if (this.trustPk != null)
			{
				bcpgOut.WritePacket(this.trustPk);
			}
			if (this.subSigs == null)
			{
				foreach (object obj in this.keySigs)
				{
					((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)obj).Encode(bcpgOut);
				}
				for (int i = 0; i != this.ids.Count; i++)
				{
					if (this.ids[i] is string)
					{
						string id = (string)this.ids[i];
						bcpgOut.WritePacket(new global::Org.BouncyCastle.Bcpg.UserIdPacket(id));
					}
					else
					{
						global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector v = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector)this.ids[i];
						bcpgOut.WritePacket(new global::Org.BouncyCastle.Bcpg.UserAttributePacket(v.ToSubpacketArray()));
					}
					if (this.idTrusts[i] != null)
					{
						bcpgOut.WritePacket((global::Org.BouncyCastle.Bcpg.ContainedPacket)this.idTrusts[i]);
					}
					foreach (object obj2 in ((global::System.Collections.IList)this.idSigs[i]))
					{
						((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)obj2).Encode(bcpgOut);
					}
				}
				return;
			}
			foreach (object obj3 in this.subSigs)
			{
				((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)obj3).Encode(bcpgOut);
			}
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x00103264 File Offset: 0x00101464
		public bool IsRevoked()
		{
			int ns = 0;
			bool revoked = false;
			if (this.IsMasterKey)
			{
				while (!revoked)
				{
					if (ns >= this.keySigs.Count)
					{
						break;
					}
					if (((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)this.keySigs[ns++]).SignatureType == 32)
					{
						revoked = true;
					}
				}
			}
			else
			{
				while (!revoked && ns < this.subSigs.Count)
				{
					if (((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature)this.subSigs[ns++]).SignatureType == 40)
					{
						revoked = true;
					}
				}
			}
			return revoked;
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x001032E4 File Offset: 0x001014E4
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey AddCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, string id, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature certification)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.AddCert(key, id, certification);
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x001032EE File Offset: 0x001014EE
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey AddCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector userAttributes, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature certification)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.AddCert(key, userAttributes, certification);
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x001032F8 File Offset: 0x001014F8
		private static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey AddCert(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, object id, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature certification)
		{
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey returnKey = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(key);
			global::System.Collections.IList sigList = null;
			for (int i = 0; i != returnKey.ids.Count; i++)
			{
				if (id.Equals(returnKey.ids[i]))
				{
					sigList = (global::System.Collections.IList)returnKey.idSigs[i];
				}
			}
			if (sigList != null)
			{
				sigList.Add(certification);
			}
			else
			{
				sigList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
				sigList.Add(certification);
				returnKey.ids.Add(id);
				returnKey.idTrusts.Add(null);
				returnKey.idSigs.Add(sigList);
			}
			return returnKey;
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x0010338D File Offset: 0x0010158D
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey RemoveCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector userAttributes)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.RemoveCert(key, userAttributes);
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00103396 File Offset: 0x00101596
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey RemoveCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, string id)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.RemoveCert(key, id);
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x001033A0 File Offset: 0x001015A0
		private static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey RemoveCert(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, object id)
		{
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey returnKey = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(key);
			bool found = false;
			for (int i = 0; i < returnKey.ids.Count; i++)
			{
				if (id.Equals(returnKey.ids[i]))
				{
					found = true;
					returnKey.ids.RemoveAt(i);
					returnKey.idTrusts.RemoveAt(i);
					returnKey.idSigs.RemoveAt(i);
				}
			}
			if (!found)
			{
				return null;
			}
			return returnKey;
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x0010340C File Offset: 0x0010160C
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey RemoveCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, string id, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature certification)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.RemoveCert(key, id, certification);
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00103416 File Offset: 0x00101616
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey RemoveCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector userAttributes, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature certification)
		{
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.RemoveCert(key, userAttributes, certification);
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x00103420 File Offset: 0x00101620
		private static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey RemoveCert(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, object id, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature certification)
		{
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey returnKey = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(key);
			bool found = false;
			for (int i = 0; i < returnKey.ids.Count; i++)
			{
				if (id.Equals(returnKey.ids[i]))
				{
					global::System.Collections.IList certs = (global::System.Collections.IList)returnKey.idSigs[i];
					found = certs.Contains(certification);
					if (found)
					{
						certs.Remove(certification);
					}
				}
			}
			if (!found)
			{
				return null;
			}
			return returnKey;
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x0010348C File Offset: 0x0010168C
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey AddCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature certification)
		{
			if (key.IsMasterKey)
			{
				if (certification.SignatureType == 40)
				{
					throw new global::System.ArgumentException("signature type incorrect for master key revocation.");
				}
			}
			else if (certification.SignatureType == 32)
			{
				throw new global::System.ArgumentException("signature type incorrect for sub-key revocation.");
			}
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey returnKey = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(key);
			if (returnKey.subSigs != null)
			{
				returnKey.subSigs.Add(certification);
			}
			else
			{
				returnKey.keySigs.Add(certification);
			}
			return returnKey;
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x001034F8 File Offset: 0x001016F8
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey RemoveCertification(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey key, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature certification)
		{
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey returnKey = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(key);
			global::System.Collections.IList sigs = (returnKey.subSigs != null) ? returnKey.subSigs : returnKey.keySigs;
			int pos = sigs.IndexOf(certification);
			bool found = pos >= 0;
			if (found)
			{
				sigs.RemoveAt(pos);
			}
			else
			{
				foreach (object obj in key.GetUserIds())
				{
					string id = (string)obj;
					foreach (object sig in key.GetSignaturesForId(id))
					{
						if (certification == sig)
						{
							found = true;
							returnKey = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.RemoveCertification(returnKey, id, certification);
						}
					}
				}
				if (!found)
				{
					foreach (object obj2 in key.GetUserAttributes())
					{
						global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector id2 = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUserAttributeSubpacketVector)obj2;
						foreach (object sig2 in key.GetSignaturesForUserAttribute(id2))
						{
							if (certification == sig2)
							{
								found = true;
								returnKey = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey.RemoveCertification(returnKey, id2, certification);
							}
						}
					}
				}
			}
			return returnKey;
		}

		// Token: 0x040018DA RID: 6362
		private static readonly int[] MasterKeyCertificationTypes = new int[]
		{
			19,
			18,
			17,
			16,
			31
		};

		// Token: 0x040018DB RID: 6363
		private long keyId;

		// Token: 0x040018DC RID: 6364
		private byte[] fingerprint;

		// Token: 0x040018DD RID: 6365
		private int keyStrength;

		// Token: 0x040018DE RID: 6366
		internal global::Org.BouncyCastle.Bcpg.PublicKeyPacket publicPk;

		// Token: 0x040018DF RID: 6367
		internal global::Org.BouncyCastle.Bcpg.TrustPacket trustPk;

		// Token: 0x040018E0 RID: 6368
		internal global::System.Collections.IList keySigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040018E1 RID: 6369
		internal global::System.Collections.IList ids = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040018E2 RID: 6370
		internal global::System.Collections.IList idTrusts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040018E3 RID: 6371
		internal global::System.Collections.IList idSigs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x040018E4 RID: 6372
		internal global::System.Collections.IList subSigs;
	}
}
