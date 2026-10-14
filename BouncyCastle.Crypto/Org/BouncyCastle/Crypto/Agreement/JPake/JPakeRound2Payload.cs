using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Agreement.JPake
{
	// Token: 0x02000504 RID: 1284
	public class JPakeRound2Payload
	{
		// Token: 0x06003239 RID: 12857 RVA: 0x000F1660 File Offset: 0x000EF860
		public JPakeRound2Payload(string participantId, global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX2s)
		{
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(participantId, "participantId");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(a, "a");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(knowledgeProofForX2s, "knowledgeProofForX2s");
			this.participantId = participantId;
			this.a = a;
			this.knowledgeProofForX2s = new global::Org.BouncyCastle.Math.BigInteger[knowledgeProofForX2s.Length];
			knowledgeProofForX2s.CopyTo(this.knowledgeProofForX2s, 0);
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x000F16BD File Offset: 0x000EF8BD
		public virtual string ParticipantId
		{
			get
			{
				return this.participantId;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x000F16C5 File Offset: 0x000EF8C5
		public virtual global::Org.BouncyCastle.Math.BigInteger A
		{
			get
			{
				return this.a;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x000F16D0 File Offset: 0x000EF8D0
		public virtual global::Org.BouncyCastle.Math.BigInteger[] KnowledgeProofForX2s
		{
			get
			{
				global::Org.BouncyCastle.Math.BigInteger[] kp = new global::Org.BouncyCastle.Math.BigInteger[this.knowledgeProofForX2s.Length];
				global::System.Array.Copy(this.knowledgeProofForX2s, kp, this.knowledgeProofForX2s.Length);
				return kp;
			}
		}

		// Token: 0x0400165A RID: 5722
		private readonly string participantId;

		// Token: 0x0400165B RID: 5723
		private readonly global::Org.BouncyCastle.Math.BigInteger a;

		// Token: 0x0400165C RID: 5724
		private readonly global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX2s;
	}
}
