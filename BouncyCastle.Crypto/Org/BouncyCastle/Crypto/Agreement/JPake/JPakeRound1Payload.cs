using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Agreement.JPake
{
	// Token: 0x02000503 RID: 1283
	public class JPakeRound1Payload
	{
		// Token: 0x06003233 RID: 12851 RVA: 0x000F1544 File Offset: 0x000EF744
		public JPakeRound1Payload(string participantId, global::Org.BouncyCastle.Math.BigInteger gx1, global::Org.BouncyCastle.Math.BigInteger gx2, global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX1, global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX2)
		{
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(participantId, "participantId");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(gx1, "gx1");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(gx2, "gx2");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(knowledgeProofForX1, "knowledgeProofForX1");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(knowledgeProofForX2, "knowledgeProofForX2");
			this.participantId = participantId;
			this.gx1 = gx1;
			this.gx2 = gx2;
			this.knowledgeProofForX1 = new global::Org.BouncyCastle.Math.BigInteger[knowledgeProofForX1.Length];
			global::System.Array.Copy(knowledgeProofForX1, this.knowledgeProofForX1, knowledgeProofForX1.Length);
			this.knowledgeProofForX2 = new global::Org.BouncyCastle.Math.BigInteger[knowledgeProofForX2.Length];
			global::System.Array.Copy(knowledgeProofForX2, this.knowledgeProofForX2, knowledgeProofForX2.Length);
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x000F15E5 File Offset: 0x000EF7E5
		public virtual string ParticipantId
		{
			get
			{
				return this.participantId;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x000F15ED File Offset: 0x000EF7ED
		public virtual global::Org.BouncyCastle.Math.BigInteger Gx1
		{
			get
			{
				return this.gx1;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x000F15F5 File Offset: 0x000EF7F5
		public virtual global::Org.BouncyCastle.Math.BigInteger Gx2
		{
			get
			{
				return this.gx2;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06003237 RID: 12855 RVA: 0x000F1600 File Offset: 0x000EF800
		public virtual global::Org.BouncyCastle.Math.BigInteger[] KnowledgeProofForX1
		{
			get
			{
				global::Org.BouncyCastle.Math.BigInteger[] kp = new global::Org.BouncyCastle.Math.BigInteger[this.knowledgeProofForX1.Length];
				global::System.Array.Copy(this.knowledgeProofForX1, kp, this.knowledgeProofForX1.Length);
				return kp;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x000F1630 File Offset: 0x000EF830
		public virtual global::Org.BouncyCastle.Math.BigInteger[] KnowledgeProofForX2
		{
			get
			{
				global::Org.BouncyCastle.Math.BigInteger[] kp = new global::Org.BouncyCastle.Math.BigInteger[this.knowledgeProofForX2.Length];
				global::System.Array.Copy(this.knowledgeProofForX2, kp, this.knowledgeProofForX2.Length);
				return kp;
			}
		}

		// Token: 0x04001655 RID: 5717
		private readonly string participantId;

		// Token: 0x04001656 RID: 5718
		private readonly global::Org.BouncyCastle.Math.BigInteger gx1;

		// Token: 0x04001657 RID: 5719
		private readonly global::Org.BouncyCastle.Math.BigInteger gx2;

		// Token: 0x04001658 RID: 5720
		private readonly global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX1;

		// Token: 0x04001659 RID: 5721
		private readonly global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX2;
	}
}
