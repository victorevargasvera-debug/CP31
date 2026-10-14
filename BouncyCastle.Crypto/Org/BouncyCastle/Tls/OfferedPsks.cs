using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000DB RID: 219
	public sealed class OfferedPsks
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00020FF7 File Offset: 0x0001F1F7
		public OfferedPsks(global::System.Collections.IList identities) : this(identities, null, -1)
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00021004 File Offset: 0x0001F204
		private OfferedPsks(global::System.Collections.IList identities, global::System.Collections.IList binders, int bindersSize)
		{
			if (identities == null || identities.Count < 1)
			{
				throw new global::System.ArgumentException("cannot be null or empty", "identities");
			}
			if (binders != null && identities.Count != binders.Count)
			{
				throw new global::System.ArgumentException("must be the same length as 'identities' (or null)", "binders");
			}
			if (binders != null != bindersSize >= 0)
			{
				throw new global::System.ArgumentException("must be >= 0 iff 'binders' are present", "bindersSize");
			}
			this.m_identities = identities;
			this.m_binders = binders;
			this.m_bindersSize = bindersSize;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00021086 File Offset: 0x0001F286
		public global::System.Collections.IList Binders
		{
			get
			{
				return this.m_binders;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0002108E File Offset: 0x0001F28E
		public int BindersSize
		{
			get
			{
				return this.m_bindersSize;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00021096 File Offset: 0x0001F296
		public global::System.Collections.IList Identities
		{
			get
			{
				return this.m_identities;
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000210A0 File Offset: 0x0001F2A0
		public int GetIndexOfIdentity(global::Org.BouncyCastle.Tls.PskIdentity pskIdentity)
		{
			int i = 0;
			int count = this.m_identities.Count;
			while (i < count)
			{
				if (pskIdentity.Equals(this.m_identities[i]))
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000210DC File Offset: 0x0001F2DC
		public void Encode(global::System.IO.Stream output)
		{
			int lengthOfIdentitiesList = 0;
			foreach (object obj in this.m_identities)
			{
				global::Org.BouncyCastle.Tls.PskIdentity identity = (global::Org.BouncyCastle.Tls.PskIdentity)obj;
				lengthOfIdentitiesList += identity.GetEncodedLength();
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(lengthOfIdentitiesList);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(lengthOfIdentitiesList, output);
			foreach (object obj2 in this.m_identities)
			{
				((global::Org.BouncyCastle.Tls.PskIdentity)obj2).Encode(output);
			}
			if (this.m_binders != null)
			{
				int lengthOfBindersList = 0;
				foreach (object obj3 in this.m_binders)
				{
					byte[] binder = (byte[])obj3;
					lengthOfBindersList += 1 + binder.Length;
				}
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(lengthOfBindersList);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(lengthOfBindersList, output);
				foreach (object obj4 in this.m_binders)
				{
					global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8((byte[])obj4, output);
				}
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0002123C File Offset: 0x0001F43C
		internal static void EncodeBinders(global::System.IO.Stream output, global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash, global::Org.BouncyCastle.Tls.OfferedPsks.BindersConfig bindersConfig)
		{
			global::Org.BouncyCastle.Tls.TlsPsk[] psks = bindersConfig.m_psks;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret[] earlySecrets = bindersConfig.m_earlySecrets;
			int expectedLengthOfBindersList = bindersConfig.m_bindersSize - 2;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(expectedLengthOfBindersList);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(expectedLengthOfBindersList, output);
			int lengthOfBindersList = 0;
			for (int i = 0; i < psks.Length; i++)
			{
				global::Org.BouncyCastle.Tls.TlsPsk tlsPsk = psks[i];
				global::Org.BouncyCastle.Tls.Crypto.TlsSecret earlySecret = earlySecrets[i];
				bool isExternalPsk = true;
				int pskCryptoHashAlgorithm = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashForPrf(tlsPsk.PrfAlgorithm);
				global::Org.BouncyCastle.Tls.Crypto.TlsHash hash = crypto.CreateHash(pskCryptoHashAlgorithm);
				handshakeHash.CopyBufferTo(new global::Org.BouncyCastle.Tls.Crypto.TlsHashSink(hash));
				byte[] transcriptHash = hash.CalculateHash();
				byte[] binder = global::Org.BouncyCastle.Tls.TlsUtilities.CalculatePskBinder(crypto, isExternalPsk, pskCryptoHashAlgorithm, earlySecret, transcriptHash);
				lengthOfBindersList += 1 + binder.Length;
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(binder, output);
			}
			if (expectedLengthOfBindersList != lengthOfBindersList)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000212E8 File Offset: 0x0001F4E8
		internal static int GetBindersSize(global::Org.BouncyCastle.Tls.TlsPsk[] psks)
		{
			int lengthOfBindersList = 0;
			for (int i = 0; i < psks.Length; i++)
			{
				int prfCryptoHashAlgorithm = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashForPrf(psks[i].PrfAlgorithm);
				lengthOfBindersList += 1 + global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashOutputSize(prfCryptoHashAlgorithm);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(lengthOfBindersList);
			return 2 + lengthOfBindersList;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00021328 File Offset: 0x0001F528
		public static global::Org.BouncyCastle.Tls.OfferedPsks Parse(global::System.IO.Stream input)
		{
			global::System.Collections.IList identities = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			int num = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			if (num < 7)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(num, input), false);
			do
			{
				global::Org.BouncyCastle.Tls.PskIdentity identity = global::Org.BouncyCastle.Tls.PskIdentity.Parse(buf);
				identities.Add(identity);
			}
			while (buf.Position < buf.Length);
			global::System.Collections.IList binders = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			int totalLengthBinders = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			if (totalLengthBinders < 33)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.IO.MemoryStream buf2 = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Tls.TlsUtilities.ReadFully(totalLengthBinders, input), false);
			do
			{
				byte[] binder = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(buf2, 32);
				binders.Add(binder);
			}
			while (buf2.Position < buf2.Length);
			return new global::Org.BouncyCastle.Tls.OfferedPsks(identities, binders, 2 + totalLengthBinders);
		}

		// Token: 0x040005FA RID: 1530
		private readonly global::System.Collections.IList m_identities;

		// Token: 0x040005FB RID: 1531
		private readonly global::System.Collections.IList m_binders;

		// Token: 0x040005FC RID: 1532
		private readonly int m_bindersSize;

		// Token: 0x020007A8 RID: 1960
		internal class BindersConfig
		{
			// Token: 0x06004516 RID: 17686 RVA: 0x001327D4 File Offset: 0x001309D4
			internal BindersConfig(global::Org.BouncyCastle.Tls.TlsPsk[] psks, short[] pskKeyExchangeModes, global::Org.BouncyCastle.Tls.Crypto.TlsSecret[] earlySecrets, int bindersSize)
			{
				this.m_psks = psks;
				this.m_pskKeyExchangeModes = pskKeyExchangeModes;
				this.m_earlySecrets = earlySecrets;
				this.m_bindersSize = bindersSize;
			}

			// Token: 0x04002316 RID: 8982
			internal readonly global::Org.BouncyCastle.Tls.TlsPsk[] m_psks;

			// Token: 0x04002317 RID: 8983
			internal readonly short[] m_pskKeyExchangeModes;

			// Token: 0x04002318 RID: 8984
			internal readonly global::Org.BouncyCastle.Tls.Crypto.TlsSecret[] m_earlySecrets;

			// Token: 0x04002319 RID: 8985
			internal int m_bindersSize;
		}

		// Token: 0x020007A9 RID: 1961
		internal class SelectedConfig
		{
			// Token: 0x06004517 RID: 17687 RVA: 0x001327F9 File Offset: 0x001309F9
			internal SelectedConfig(int index, global::Org.BouncyCastle.Tls.TlsPsk psk, short[] pskKeyExchangeModes, global::Org.BouncyCastle.Tls.Crypto.TlsSecret earlySecret)
			{
				this.m_index = index;
				this.m_psk = psk;
				this.m_pskKeyExchangeModes = pskKeyExchangeModes;
				this.m_earlySecret = earlySecret;
			}

			// Token: 0x0400231A RID: 8986
			internal readonly int m_index;

			// Token: 0x0400231B RID: 8987
			internal readonly global::Org.BouncyCastle.Tls.TlsPsk m_psk;

			// Token: 0x0400231C RID: 8988
			internal readonly short[] m_pskKeyExchangeModes;

			// Token: 0x0400231D RID: 8989
			internal readonly global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_earlySecret;
		}
	}
}
