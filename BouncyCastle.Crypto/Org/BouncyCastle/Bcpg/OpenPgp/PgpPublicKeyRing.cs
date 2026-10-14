using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005BA RID: 1466
	public class PgpPublicKeyRing : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing
	{
		// Token: 0x060036CB RID: 14027 RVA: 0x00103B99 File Offset: 0x00101D99
		public PgpPublicKeyRing(byte[] encoding) : this(new global::System.IO.MemoryStream(encoding, false))
		{
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00103BA8 File Offset: 0x00101DA8
		internal PgpPublicKeyRing(global::System.Collections.IList pubKeys)
		{
			this.keys = pubKeys;
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00103BB8 File Offset: 0x00101DB8
		public PgpPublicKeyRing(global::System.IO.Stream inputStream)
		{
			this.keys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgInput = global::Org.BouncyCastle.Bcpg.BcpgInputStream.Wrap(inputStream);
			global::Org.BouncyCastle.Bcpg.PacketTag initialTag = bcpgInput.SkipMarkerPackets();
			if (initialTag != global::Org.BouncyCastle.Bcpg.PacketTag.PublicKey && initialTag != global::Org.BouncyCastle.Bcpg.PacketTag.PublicSubkey)
			{
				string str = "public key ring doesn't start with public key tag: tag 0x";
				int num = (int)initialTag;
				throw new global::System.IO.IOException(str + num.ToString("X"));
			}
			global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubPk = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing.ReadPublicKeyPacket(bcpgInput);
			global::Org.BouncyCastle.Bcpg.TrustPacket trustPk = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadOptionalTrustPacket(bcpgInput);
			global::System.Collections.IList keySigs = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadSignaturesAndTrust(bcpgInput);
			global::System.Collections.IList ids;
			global::System.Collections.IList idTrusts;
			global::System.Collections.IList idSigs;
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadUserIDs(bcpgInput, out ids, out idTrusts, out idSigs);
			this.keys.Add(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(pubPk, trustPk, keySigs, ids, idTrusts, idSigs));
			while (bcpgInput.NextPacketTag() == global::Org.BouncyCastle.Bcpg.PacketTag.PublicSubkey)
			{
				this.keys.Add(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing.ReadSubkey(bcpgInput));
			}
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00103C67 File Offset: 0x00101E67
		public virtual global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey GetPublicKey()
		{
			return (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey)this.keys[0];
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00103C7C File Offset: 0x00101E7C
		public virtual global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey GetPublicKey(long keyId)
		{
			foreach (object obj in this.keys)
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey i = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey)obj;
				if (keyId == i.KeyId)
				{
					return i;
				}
			}
			return null;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00103CE0 File Offset: 0x00101EE0
		public virtual global::System.Collections.IEnumerable GetPublicKeys()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.keys);
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00103CF0 File Offset: 0x00101EF0
		public virtual byte[] GetEncoded()
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			this.Encode(bOut);
			return bOut.ToArray();
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00103D10 File Offset: 0x00101F10
		public virtual void Encode(global::System.IO.Stream outStr)
		{
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			foreach (object obj in this.keys)
			{
				((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey)obj).Encode(outStr);
			}
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00103D78 File Offset: 0x00101F78
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing InsertPublicKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing pubRing, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			global::System.Collections.IList keys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(pubRing.keys);
			bool found = false;
			bool masterFound = false;
			for (int i = 0; i != keys.Count; i++)
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pgpPublicKey = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey)keys[i];
				if (pgpPublicKey.KeyId == pubKey.KeyId)
				{
					found = true;
					keys[i] = pubKey;
				}
				if (pgpPublicKey.IsMasterKey)
				{
					masterFound = true;
				}
			}
			if (!found)
			{
				if (pubKey.IsMasterKey)
				{
					if (masterFound)
					{
						throw new global::System.ArgumentException("cannot add a master key to a ring that already has one");
					}
					keys.Insert(0, pubKey);
				}
				else
				{
					keys.Add(pubKey);
				}
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing(keys);
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x00103E04 File Offset: 0x00102004
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing RemovePublicKey(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing pubRing, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pubKey)
		{
			global::System.Collections.IList keys = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(pubRing.keys);
			bool found = false;
			for (int i = 0; i < keys.Count; i++)
			{
				if (((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey)keys[i]).KeyId == pubKey.KeyId)
				{
					found = true;
					keys.RemoveAt(i);
				}
			}
			if (!found)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing(keys);
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x00103E60 File Offset: 0x00102060
		internal static global::Org.BouncyCastle.Bcpg.PublicKeyPacket ReadPublicKeyPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgInput)
		{
			global::Org.BouncyCastle.Bcpg.Packet packet = bcpgInput.ReadPacket();
			if (!(packet is global::Org.BouncyCastle.Bcpg.PublicKeyPacket))
			{
				string str = "unexpected packet in stream: ";
				global::Org.BouncyCastle.Bcpg.Packet packet2 = packet;
				throw new global::System.IO.IOException(str + ((packet2 != null) ? packet2.ToString() : null));
			}
			return (global::Org.BouncyCastle.Bcpg.PublicKeyPacket)packet;
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x00103EA0 File Offset: 0x001020A0
		internal static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey ReadSubkey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgInput)
		{
			global::Org.BouncyCastle.Bcpg.PublicKeyPacket publicPk = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing.ReadPublicKeyPacket(bcpgInput);
			global::Org.BouncyCastle.Bcpg.TrustPacket kTrust = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadOptionalTrustPacket(bcpgInput);
			global::System.Collections.IList sigList = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyRing.ReadSignaturesAndTrust(bcpgInput);
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(publicPk, kTrust, sigList);
		}

		// Token: 0x040018E6 RID: 6374
		private readonly global::System.Collections.IList keys;
	}
}
