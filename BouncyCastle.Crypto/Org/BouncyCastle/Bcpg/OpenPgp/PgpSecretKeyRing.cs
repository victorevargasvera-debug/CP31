using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005BD RID: 1469
	public class PgpSecretKeyRing : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing
	{
		// Token: 0x0600371C RID: 14108 RVA: 0x001057A2 File Offset: 0x001039A2
		internal PgpSecretKeyRing(global::System.Collections.IList keys) : this(keys, global::Org.BouncyCastle.Utilities.Platform.CreateArrayList())
		{
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x001057B0 File Offset: 0x001039B0
		private PgpSecretKeyRing(global::System.Collections.IList keys, global::System.Collections.IList extraPubKeys)
		{
			this.keys = keys;
			this.extraPubKeys = extraPubKeys;
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x001057C6 File Offset: 0x001039C6
		public PgpSecretKeyRing(byte[] encoding) : this(new global::System.IO.MemoryStream(encoding))
		{
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x001057D4 File Offset: 0x001039D4
		public PgpSecretKeyRing(global::System.IO.Stream inputStream)
		{
			this.keys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			this.extraPubKeys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgInput = global::Org.BouncyCastle.Bcpg.BcpgInputStream.Wrap(inputStream);
			global::Org.BouncyCastle.Bcpg.PacketTag initialTag = bcpgInput.SkipMarkerPackets();
			if (initialTag != global::Org.BouncyCastle.Bcpg.PacketTag.SecretKey && initialTag != global::Org.BouncyCastle.Bcpg.PacketTag.SecretSubkey)
			{
				string str = "secret key ring doesn't start with secret key tag: tag 0x";
				int num = (int)initialTag;
				throw new global::System.IO.IOException(str + num.ToString("X"));
			}
			global::Org.BouncyCastle.Bcpg.SecretKeyPacket secret = (global::Org.BouncyCastle.Bcpg.SecretKeyPacket)bcpgInput.ReadPacket();
			while (bcpgInput.NextPacketTag() == global::Org.BouncyCastle.Bcpg.PacketTag.Experimental2)
			{
				bcpgInput.ReadPacket();
			}
			global::Org.BouncyCastle.Bcpg.TrustPacket trust = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadOptionalTrustPacket(bcpgInput);
			global::System.Collections.IList keySigs = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadSignaturesAndTrust(bcpgInput);
			global::System.Collections.IList ids;
			global::System.Collections.IList idTrusts;
			global::System.Collections.IList idSigs;
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadUserIDs(bcpgInput, out ids, out idTrusts, out idSigs);
			this.keys.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey(secret, new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(secret.PublicKeyPacket, trust, keySigs, ids, idTrusts, idSigs)));
			while (bcpgInput.NextPacketTag() == global::Org.BouncyCastle.Bcpg.PacketTag.SecretSubkey || bcpgInput.NextPacketTag() == global::Org.BouncyCastle.Bcpg.PacketTag.PublicSubkey)
			{
				if (bcpgInput.NextPacketTag() == global::Org.BouncyCastle.Bcpg.PacketTag.SecretSubkey)
				{
					global::Org.BouncyCastle.Bcpg.SecretSubkeyPacket sub = (global::Org.BouncyCastle.Bcpg.SecretSubkeyPacket)bcpgInput.ReadPacket();
					while (bcpgInput.NextPacketTag() == global::Org.BouncyCastle.Bcpg.PacketTag.Experimental2)
					{
						bcpgInput.ReadPacket();
					}
					global::Org.BouncyCastle.Bcpg.TrustPacket subTrust = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadOptionalTrustPacket(bcpgInput);
					global::System.Collections.IList sigList = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadSignaturesAndTrust(bcpgInput);
					this.keys.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey(sub, new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(sub.PublicKeyPacket, subTrust, sigList)));
				}
				else
				{
					global::Org.BouncyCastle.Bcpg.PublicSubkeyPacket sub2 = (global::Org.BouncyCastle.Bcpg.PublicSubkeyPacket)bcpgInput.ReadPacket();
					global::Org.BouncyCastle.Bcpg.TrustPacket subTrust2 = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadOptionalTrustPacket(bcpgInput);
					global::System.Collections.IList sigList2 = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadSignaturesAndTrust(bcpgInput);
					this.extraPubKeys.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(sub2, subTrust2, sigList2));
				}
			}
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x00105942 File Offset: 0x00103B42
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey GetPublicKey()
		{
			return ((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey)this.keys[0]).PublicKey;
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x0010595A File Offset: 0x00103B5A
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey GetSecretKey()
		{
			return (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey)this.keys[0];
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x0010596D File Offset: 0x00103B6D
		public global::System.Collections.IEnumerable GetSecretKeys()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.keys);
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0010597C File Offset: 0x00103B7C
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey GetSecretKey(long keyId)
		{
			foreach (object obj in this.keys)
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey i = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey)obj;
				if (keyId == i.KeyId)
				{
					return i;
				}
			}
			return null;
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x001059E0 File Offset: 0x00103BE0
		public global::System.Collections.IEnumerable GetExtraPublicKeys()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.extraPubKeys);
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x001059F0 File Offset: 0x00103BF0
		public byte[] GetEncoded()
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			this.Encode(bOut);
			return bOut.ToArray();
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x00105A10 File Offset: 0x00103C10
		public void Encode(global::System.IO.Stream outStr)
		{
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			foreach (object obj in this.keys)
			{
				((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey)obj).Encode(outStr);
			}
			foreach (object obj2 in this.extraPubKeys)
			{
				((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey)obj2).Encode(outStr);
			}
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00105ABC File Offset: 0x00103CBC
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing ReplacePublicKeys(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing secretRing, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing publicRing)
		{
			global::System.Collections.IList newList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(secretRing.keys.Count);
			foreach (object obj in secretRing.keys)
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey sk = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey)obj;
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pk = publicRing.GetPublicKey(sk.KeyId);
				newList.Add(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.ReplacePublicKey(sk, pk));
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing(newList);
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x00105B44 File Offset: 0x00103D44
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing CopyWithNewPassword(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing ring, char[] oldPassPhrase, char[] newPassPhrase, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag newEncAlgorithm, global::Org.BouncyCastle.Security.SecureRandom rand)
		{
			global::System.Collections.IList newKeys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(ring.keys.Count);
			foreach (object obj in ring.GetSecretKeys())
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey secretKey = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey)obj;
				if (secretKey.IsPrivateKeyEmpty)
				{
					newKeys.Add(secretKey);
				}
				else
				{
					newKeys.Add(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey.CopyWithNewPassword(secretKey, oldPassPhrase, newPassPhrase, newEncAlgorithm, rand));
				}
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing(newKeys, ring.extraPubKeys);
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00105BD8 File Offset: 0x00103DD8
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing InsertSecretKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing secRing, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey secKey)
		{
			global::System.Collections.IList keys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(secRing.keys);
			bool found = false;
			bool masterFound = false;
			for (int i = 0; i != keys.Count; i++)
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey pgpSecretKey = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey)keys[i];
				if (pgpSecretKey.KeyId == secKey.KeyId)
				{
					found = true;
					keys[i] = secKey;
				}
				if (pgpSecretKey.IsMasterKey)
				{
					masterFound = true;
				}
			}
			if (!found)
			{
				if (secKey.IsMasterKey)
				{
					if (masterFound)
					{
						throw new global::System.ArgumentException("cannot add a master key to a ring that already has one");
					}
					keys.Insert(0, secKey);
				}
				else
				{
					keys.Add(secKey);
				}
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing(keys, secRing.extraPubKeys);
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00105C6C File Offset: 0x00103E6C
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing RemoveSecretKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing secRing, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey secKey)
		{
			global::System.Collections.IList keys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(secRing.keys);
			bool found = false;
			for (int i = 0; i < keys.Count; i++)
			{
				if (((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey)keys[i]).KeyId == secKey.KeyId)
				{
					found = true;
					keys.RemoveAt(i);
				}
			}
			if (!found)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing(keys, secRing.extraPubKeys);
		}

		// Token: 0x040018EB RID: 6379
		private readonly global::System.Collections.IList keys;

		// Token: 0x040018EC RID: 6380
		private readonly global::System.Collections.IList extraPubKeys;
	}
}
