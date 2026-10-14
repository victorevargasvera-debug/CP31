using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005BB RID: 1467
	public class PgpPublicKeyRingBundle
	{
		// Token: 0x060036D7 RID: 14039 RVA: 0x00103EC8 File Offset: 0x001020C8
		private PgpPublicKeyRingBundle(global::System.Collections.IDictionary pubRings, global::System.Collections.IList order)
		{
			this.pubRings = pubRings;
			this.order = order;
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00103EDE File Offset: 0x001020DE
		public PgpPublicKeyRingBundle(byte[] encoding) : this(new global::System.IO.MemoryStream(encoding, false))
		{
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x00103EED File Offset: 0x001020ED
		public PgpPublicKeyRingBundle(global::System.IO.Stream inputStream) : this(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObjectFactory(inputStream).AllPgpObjects())
		{
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x00103F00 File Offset: 0x00102100
		public PgpPublicKeyRingBundle(global::System.Collections.IEnumerable e)
		{
			this.pubRings = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			this.order = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj in e)
			{
				if (!(obj is global::Org.BouncyCastle.Bcpg.OpenPgp.PgpMarker))
				{
					global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing pgpPub = obj as global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing;
					if (pgpPub == null)
					{
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException(global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj) + " found where PgpPublicKeyRing expected");
					}
					long key = pgpPub.GetPublicKey().KeyId;
					this.pubRings.Add(key, pgpPub);
					this.order.Add(key);
				}
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060036DB RID: 14043 RVA: 0x00103FC0 File Offset: 0x001021C0
		[global::System.Obsolete("Use 'Count' property instead")]
		public int Size
		{
			get
			{
				return this.order.Count;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x00103FCD File Offset: 0x001021CD
		public int Count
		{
			get
			{
				return this.order.Count;
			}
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00103FDA File Offset: 0x001021DA
		public global::System.Collections.IEnumerable GetKeyRings()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.pubRings.Values);
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x00103FEC File Offset: 0x001021EC
		public global::System.Collections.IEnumerable GetKeyRings(string userId)
		{
			return this.GetKeyRings(userId, false, false);
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00103FF7 File Offset: 0x001021F7
		public global::System.Collections.IEnumerable GetKeyRings(string userId, bool matchPartial)
		{
			return this.GetKeyRings(userId, matchPartial, false);
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00104004 File Offset: 0x00102204
		public global::System.Collections.IEnumerable GetKeyRings(string userId, bool matchPartial, bool ignoreCase)
		{
			global::System.Collections.IList rings = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (ignoreCase)
			{
				userId = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(userId);
			}
			foreach (object obj in this.GetKeyRings())
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing pubRing = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing)obj;
				foreach (object obj2 in pubRing.GetPublicKey().GetUserIds())
				{
					string next = (string)obj2;
					if (ignoreCase)
					{
						next = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(next);
					}
					if (matchPartial)
					{
						if (global::Org.BouncyCastle.Utilities.Platform.IndexOf(next, userId) > -1)
						{
							rings.Add(pubRing);
						}
					}
					else if (next.Equals(userId))
					{
						rings.Add(pubRing);
					}
				}
			}
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(rings);
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x001040F8 File Offset: 0x001022F8
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey GetPublicKey(long keyId)
		{
			foreach (object obj in this.GetKeyRings())
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pub = ((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing)obj).GetPublicKey(keyId);
				if (pub != null)
				{
					return pub;
				}
			}
			return null;
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x0010415C File Offset: 0x0010235C
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing GetPublicKeyRing(long keyId)
		{
			if (this.pubRings.Contains(keyId))
			{
				return (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing)this.pubRings[keyId];
			}
			foreach (object obj in this.GetKeyRings())
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing pubRing = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing)obj;
				if (pubRing.GetPublicKey(keyId) != null)
				{
					return pubRing;
				}
			}
			return null;
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x001041E8 File Offset: 0x001023E8
		public bool Contains(long keyID)
		{
			return this.GetPublicKey(keyID) != null;
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x001041F4 File Offset: 0x001023F4
		public byte[] GetEncoded()
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			this.Encode(bOut);
			return bOut.ToArray();
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00104214 File Offset: 0x00102414
		public void Encode(global::System.IO.Stream outStr)
		{
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut = global::Org.BouncyCastle.Bcpg.BcpgOutputStream.Wrap(outStr);
			foreach (object obj in this.order)
			{
				long key = (long)obj;
				((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing)this.pubRings[key]).Encode(bcpgOut);
			}
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x0010428C File Offset: 0x0010248C
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRingBundle AddPublicKeyRing(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRingBundle bundle, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing publicKeyRing)
		{
			long key = publicKeyRing.GetPublicKey().KeyId;
			if (bundle.pubRings.Contains(key))
			{
				throw new global::System.ArgumentException("Bundle already contains a key with a keyId for the passed in ring.");
			}
			global::System.Collections.IDictionary dictionary = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(bundle.pubRings);
			global::System.Collections.IList newOrder = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(bundle.order);
			dictionary[key] = publicKeyRing;
			newOrder.Add(key);
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRingBundle(dictionary, newOrder);
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x001042FC File Offset: 0x001024FC
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRingBundle RemovePublicKeyRing(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRingBundle bundle, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRing publicKeyRing)
		{
			long key = publicKeyRing.GetPublicKey().KeyId;
			if (!bundle.pubRings.Contains(key))
			{
				throw new global::System.ArgumentException("Bundle does not contain a key with a keyId for the passed in ring.");
			}
			global::System.Collections.IDictionary dictionary = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(bundle.pubRings);
			global::System.Collections.IList newOrder = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(bundle.order);
			dictionary.Remove(key);
			newOrder.Remove(key);
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyRingBundle(dictionary, newOrder);
		}

		// Token: 0x040018E7 RID: 6375
		private readonly global::System.Collections.IDictionary pubRings;

		// Token: 0x040018E8 RID: 6376
		private readonly global::System.Collections.IList order;
	}
}
