using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000344 RID: 836
	public class SecurityParameters
	{
		// Token: 0x06002282 RID: 8834 RVA: 0x00098440 File Offset: 0x00096640
		internal virtual void Clear()
		{
			if (this.masterSecret != null)
			{
				global::Org.BouncyCastle.Utilities.Arrays.Fill(this.masterSecret, 0);
				this.masterSecret = null;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x0009845D File Offset: 0x0009665D
		public virtual int Entity
		{
			get
			{
				return this.entity;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x00098465 File Offset: 0x00096665
		public virtual int CipherSuite
		{
			get
			{
				return this.cipherSuite;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x0009846D File Offset: 0x0009666D
		public virtual byte CompressionAlgorithm
		{
			get
			{
				return this.compressionAlgorithm;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x00098475 File Offset: 0x00096675
		public virtual int PrfAlgorithm
		{
			get
			{
				return this.prfAlgorithm;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0009847D File Offset: 0x0009667D
		public virtual int VerifyDataLength
		{
			get
			{
				return this.verifyDataLength;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x00098485 File Offset: 0x00096685
		public virtual byte[] MasterSecret
		{
			get
			{
				return this.masterSecret;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x0009848D File Offset: 0x0009668D
		public virtual byte[] ClientRandom
		{
			get
			{
				return this.clientRandom;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x00098495 File Offset: 0x00096695
		public virtual byte[] ServerRandom
		{
			get
			{
				return this.serverRandom;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x0009849D File Offset: 0x0009669D
		public virtual byte[] SessionHash
		{
			get
			{
				return this.sessionHash;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x000984A5 File Offset: 0x000966A5
		public virtual byte[] PskIdentity
		{
			get
			{
				return this.pskIdentity;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x000984AD File Offset: 0x000966AD
		public virtual byte[] SrpIdentity
		{
			get
			{
				return this.srpIdentity;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x000984B5 File Offset: 0x000966B5
		public virtual bool IsExtendedMasterSecret
		{
			get
			{
				return this.extendedMasterSecret;
			}
		}

		// Token: 0x04000DEF RID: 3567
		internal int entity = -1;

		// Token: 0x04000DF0 RID: 3568
		internal int cipherSuite = -1;

		// Token: 0x04000DF1 RID: 3569
		internal byte compressionAlgorithm;

		// Token: 0x04000DF2 RID: 3570
		internal int prfAlgorithm = -1;

		// Token: 0x04000DF3 RID: 3571
		internal int verifyDataLength = -1;

		// Token: 0x04000DF4 RID: 3572
		internal byte[] masterSecret;

		// Token: 0x04000DF5 RID: 3573
		internal byte[] clientRandom;

		// Token: 0x04000DF6 RID: 3574
		internal byte[] serverRandom;

		// Token: 0x04000DF7 RID: 3575
		internal byte[] sessionHash;

		// Token: 0x04000DF8 RID: 3576
		internal byte[] pskIdentity;

		// Token: 0x04000DF9 RID: 3577
		internal byte[] srpIdentity;

		// Token: 0x04000DFA RID: 3578
		internal short maxFragmentLength = -1;

		// Token: 0x04000DFB RID: 3579
		internal bool truncatedHMac;

		// Token: 0x04000DFC RID: 3580
		internal bool encryptThenMac;

		// Token: 0x04000DFD RID: 3581
		internal bool extendedMasterSecret;
	}
}
