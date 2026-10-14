using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005C1 RID: 1473
	public class PgpSignatureList : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpObject
	{
		// Token: 0x06003777 RID: 14199 RVA: 0x00106D31 File Offset: 0x00104F31
		public PgpSignatureList(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature[] sigs)
		{
			this.sigs = (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature[])sigs.Clone();
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x00106D4A File Offset: 0x00104F4A
		public PgpSignatureList(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature sig)
		{
			this.sigs = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature[]
			{
				sig
			};
		}

		// Token: 0x1700077B RID: 1915
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature this[int index]
		{
			get
			{
				return this.sigs[index];
			}
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x00106D6C File Offset: 0x00104F6C
		[global::System.Obsolete("Use 'object[index]' syntax instead")]
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature Get(int index)
		{
			return this[index];
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x00106D75 File Offset: 0x00104F75
		[global::System.Obsolete("Use 'Count' property instead")]
		public int Size
		{
			get
			{
				return this.sigs.Length;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600377C RID: 14204 RVA: 0x00106D7F File Offset: 0x00104F7F
		public int Count
		{
			get
			{
				return this.sigs.Length;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x00106D89 File Offset: 0x00104F89
		public bool IsEmpty
		{
			get
			{
				return this.sigs.Length == 0;
			}
		}

		// Token: 0x0400190C RID: 6412
		private global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature[] sigs;
	}
}
