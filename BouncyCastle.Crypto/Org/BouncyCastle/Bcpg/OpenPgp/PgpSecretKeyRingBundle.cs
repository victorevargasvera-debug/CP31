using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005BE RID: 1470
	public class PgpSecretKeyRingBundle
	{
		// Token: 0x0600372B RID: 14123 RVA: 0x00105CCB File Offset: 0x00103ECB
		private PgpSecretKeyRingBundle(global::System.Collections.IDictionary secretRings, global::System.Collections.IList order)
		{
			this.secretRings = secretRings;
			this.order = order;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00105CE1 File Offset: 0x00103EE1
		public PgpSecretKeyRingBundle(byte[] encoding) : this(new global::System.IO.MemoryStream(encoding, false))
		{
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00105CF0 File Offset: 0x00103EF0
		public PgpSecretKeyRingBundle(global::System.IO.Stream inputStream) : this(new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObjectFactory(inputStream).AllPgpObjects())
		{
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00105D04 File Offset: 0x00103F04
		public PgpSecretKeyRingBundle(global::System.Collections.IEnumerable e)
		{
			this.secretRings = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			this.order = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj in e)
			{
				if (!(obj is global::Org.BouncyCastle.Bcpg.OpenPgp.PgpMarker))
				{
					global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing pgpSecret = obj as global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing;
					if (pgpSecret == null)
					{
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException(global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj) + " found where PgpSecretKeyRing expected");
					}
					long key = pgpSecret.GetPublicKey().KeyId;
					this.secretRings.Add(key, pgpSecret);
					this.order.Add(key);
				}
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600372F RID: 14127 RVA: 0x00105DC4 File Offset: 0x00103FC4
		[global::System.Obsolete("Use 'Count' property instead")]
		public int Size
		{
			get
			{
				return this.order.Count;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x00105DD1 File Offset: 0x00103FD1
		public int Count
		{
			get
			{
				return this.order.Count;
			}
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00105DDE File Offset: 0x00103FDE
		public global::System.Collections.IEnumerable GetKeyRings()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.secretRings.Values);
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00105DF0 File Offset: 0x00103FF0
		public global::System.Collections.IEnumerable GetKeyRings(string userId)
		{
			return this.GetKeyRings(userId, false, false);
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00105DFB File Offset: 0x00103FFB
		public global::System.Collections.IEnumerable GetKeyRings(string userId, bool matchPartial)
		{
			return this.GetKeyRings(userId, matchPartial, false);
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00105E08 File Offset: 0x00104008
		public global::System.Collections.IEnumerable GetKeyRings(string userId, bool matchPartial, bool ignoreCase)
		{
			global::System.Collections.IList rings = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			if (ignoreCase)
			{
				userId = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(userId);
			}
			foreach (object obj in this.GetKeyRings())
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing secRing = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing)obj;
				foreach (object obj2 in secRing.GetSecretKey().UserIds)
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
							rings.Add(secRing);
						}
					}
					else if (next.Equals(userId))
					{
						rings.Add(secRing);
					}
				}
			}
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(rings);
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x00105EFC File Offset: 0x001040FC
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey GetSecretKey(long keyId)
		{
			foreach (object obj in this.GetKeyRings())
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKey sec = ((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing)obj).GetSecretKey(keyId);
				if (sec != null)
				{
					return sec;
				}
			}
			return null;
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00105F60 File Offset: 0x00104160
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing GetSecretKeyRing(long keyId)
		{
			if (this.secretRings.Contains(keyId))
			{
				return (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing)this.secretRings[keyId];
			}
			foreach (object obj in this.GetKeyRings())
			{
				global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing secretRing = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing)obj;
				if (secretRing.GetSecretKey(keyId) != null)
				{
					return secretRing;
				}
			}
			return null;
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00105FF4 File Offset: 0x001041F4
		public bool Contains(long keyID)
		{
			return this.GetSecretKey(keyID) != null;
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x00106000 File Offset: 0x00104200
		public byte[] GetEncoded()
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			this.Encode(bOut);
			return bOut.ToArray();
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00106020 File Offset: 0x00104220
		public void Encode(global::System.IO.Stream outStr)
		{
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut = global::Org.BouncyCastle.Bcpg.BcpgOutputStream.Wrap(outStr);
			foreach (object obj in this.order)
			{
				long key = (long)obj;
				((global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing)this.secretRings[key]).Encode(bcpgOut);
			}
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00106098 File Offset: 0x00104298
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRingBundle AddSecretKeyRing(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRingBundle bundle, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing secretKeyRing)
		{
			long key = secretKeyRing.GetPublicKey().KeyId;
			if (bundle.secretRings.Contains(key))
			{
				throw new global::System.ArgumentException("Collection already contains a key with a keyId for the passed in ring.");
			}
			global::System.Collections.IDictionary dictionary = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(bundle.secretRings);
			global::System.Collections.IList newOrder = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(bundle.order);
			dictionary[key] = secretKeyRing;
			newOrder.Add(key);
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRingBundle(dictionary, newOrder);
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x00106108 File Offset: 0x00104308
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRingBundle RemoveSecretKeyRing(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRingBundle bundle, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRing secretKeyRing)
		{
			long key = secretKeyRing.GetPublicKey().KeyId;
			if (!bundle.secretRings.Contains(key))
			{
				throw new global::System.ArgumentException("Collection does not contain a key with a keyId for the passed in ring.");
			}
			global::System.Collections.IDictionary dictionary = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable(bundle.secretRings);
			global::System.Collections.IList newOrder = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(bundle.order);
			dictionary.Remove(key);
			newOrder.Remove(key);
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSecretKeyRingBundle(dictionary, newOrder);
		}

		// Token: 0x040018ED RID: 6381
		private readonly global::System.Collections.IDictionary secretRings;

		// Token: 0x040018EE RID: 6382
		private readonly global::System.Collections.IList order;
	}
}
