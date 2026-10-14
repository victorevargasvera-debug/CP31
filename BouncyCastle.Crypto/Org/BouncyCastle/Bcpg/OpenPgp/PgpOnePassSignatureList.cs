using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005B4 RID: 1460
	public class PgpOnePassSignatureList : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject
	{
		// Token: 0x0600367E RID: 13950 RVA: 0x00101E87 File Offset: 0x00100087
		public PgpOnePassSignatureList(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature[] sigs)
		{
			this.sigs = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature[])sigs.Clone();
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00101EA0 File Offset: 0x001000A0
		public PgpOnePassSignatureList(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature sig)
		{
			this.sigs = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature[]
			{
				sig
			};
		}

		// Token: 0x17000755 RID: 1877
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature this[int index]
		{
			get
			{
				return this.sigs[index];
			}
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x00101EC2 File Offset: 0x001000C2
		[global::System.Obsolete("Use 'object[index]' syntax instead")]
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature Get(int index)
		{
			return this[index];
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06003682 RID: 13954 RVA: 0x00101ECB File Offset: 0x001000CB
		[global::System.Obsolete("Use 'Count' property instead")]
		public int Size
		{
			get
			{
				return this.sigs.Length;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x00101ED5 File Offset: 0x001000D5
		public int Count
		{
			get
			{
				return this.sigs.Length;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06003684 RID: 13956 RVA: 0x00101EDF File Offset: 0x001000DF
		public bool IsEmpty
		{
			get
			{
				return this.sigs.Length == 0;
			}
		}

		// Token: 0x040018D5 RID: 6357
		private readonly global::Org.BouncyCastle.Bcpg.OpenPgp.PgpOnePassSignature[] sigs;
	}
}
