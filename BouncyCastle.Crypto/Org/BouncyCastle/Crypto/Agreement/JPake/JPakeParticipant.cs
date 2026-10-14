using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Agreement.JPake
{
	// Token: 0x02000500 RID: 1280
	public class JPakeParticipant
	{
		// Token: 0x06003220 RID: 12832 RVA: 0x000F0C6C File Offset: 0x000EEE6C
		public JPakeParticipant(string participantId, char[] password) : this(participantId, password, global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakePrimeOrderGroups.NIST_3072)
		{
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x000F0C7B File Offset: 0x000EEE7B
		public JPakeParticipant(string participantId, char[] password, global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakePrimeOrderGroup group) : this(participantId, password, group, new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest(), new global::Org.BouncyCastle.Security.SecureRandom())
		{
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x000F0C90 File Offset: 0x000EEE90
		public JPakeParticipant(string participantId, char[] password, global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakePrimeOrderGroup group, global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(participantId, "participantId");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(password, "password");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(group, "p");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(digest, "digest");
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateNotNull(random, "random");
			if (password.Length == 0)
			{
				throw new global::System.ArgumentException("Password must not be empty.");
			}
			this.participantId = participantId;
			this.password = new char[password.Length];
			global::System.Array.Copy(password, this.password, password.Length);
			this.p = group.P;
			this.q = group.Q;
			this.g = group.G;
			this.digest = digest;
			this.random = random;
			this.state = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_INITIALIZED;
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x000F0D4E File Offset: 0x000EEF4E
		public virtual int State
		{
			get
			{
				return this.state;
			}
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x000F0D58 File Offset: 0x000EEF58
		public virtual global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeRound1Payload CreateRound1PayloadToSend()
		{
			if (this.state >= global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_1_CREATED)
			{
				throw new global::System.InvalidOperationException("Round 1 payload already created for " + this.participantId);
			}
			this.x1 = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.GenerateX1(this.q, this.random);
			this.x2 = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.GenerateX2(this.q, this.random);
			this.gx1 = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateGx(this.p, this.g, this.x1);
			this.gx2 = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateGx(this.p, this.g, this.x2);
			global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateZeroKnowledgeProof(this.p, this.q, this.g, this.gx1, this.x1, this.participantId, this.digest, this.random);
			global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX2 = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateZeroKnowledgeProof(this.p, this.q, this.g, this.gx2, this.x2, this.participantId, this.digest, this.random);
			this.state = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_1_CREATED;
			return new global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeRound1Payload(this.participantId, this.gx1, this.gx2, knowledgeProofForX, knowledgeProofForX2);
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x000F0E80 File Offset: 0x000EF080
		public virtual void ValidateRound1PayloadReceived(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeRound1Payload round1PayloadReceived)
		{
			if (this.state >= global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_1_VALIDATED)
			{
				throw new global::System.InvalidOperationException("Validation already attempted for round 1 payload for " + this.participantId);
			}
			this.partnerParticipantId = round1PayloadReceived.ParticipantId;
			this.gx3 = round1PayloadReceived.Gx1;
			this.gx4 = round1PayloadReceived.Gx2;
			global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX3 = round1PayloadReceived.KnowledgeProofForX1;
			global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX4 = round1PayloadReceived.KnowledgeProofForX2;
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateParticipantIdsDiffer(this.participantId, round1PayloadReceived.ParticipantId);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateGx4(this.gx4);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateZeroKnowledgeProof(this.p, this.q, this.g, this.gx3, knowledgeProofForX3, round1PayloadReceived.ParticipantId, this.digest);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateZeroKnowledgeProof(this.p, this.q, this.g, this.gx4, knowledgeProofForX4, round1PayloadReceived.ParticipantId, this.digest);
			this.state = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_1_VALIDATED;
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x000F0F60 File Offset: 0x000EF160
		public virtual global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeRound2Payload CreateRound2PayloadToSend()
		{
			if (this.state >= global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_2_CREATED)
			{
				throw new global::System.InvalidOperationException("Round 2 payload already created for " + this.participantId);
			}
			if (this.state < global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_1_VALIDATED)
			{
				throw new global::System.InvalidOperationException("Round 1 payload must be validated prior to creating round 2 payload for " + this.participantId);
			}
			global::Org.BouncyCastle.Math.BigInteger gA = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateGA(this.p, this.gx1, this.gx3, this.gx4);
			global::Org.BouncyCastle.Math.BigInteger s = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateS(this.password);
			global::Org.BouncyCastle.Math.BigInteger x2s = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateX2s(this.q, this.x2, s);
			global::Org.BouncyCastle.Math.BigInteger A = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateA(this.p, this.q, gA, x2s);
			global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX2s = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateZeroKnowledgeProof(this.p, this.q, gA, A, x2s, this.participantId, this.digest, this.random);
			this.state = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_2_CREATED;
			return new global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeRound2Payload(this.participantId, A, knowledgeProofForX2s);
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x000F1048 File Offset: 0x000EF248
		public virtual void ValidateRound2PayloadReceived(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeRound2Payload round2PayloadReceived)
		{
			if (this.state >= global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_2_VALIDATED)
			{
				throw new global::System.InvalidOperationException("Validation already attempted for round 2 payload for " + this.participantId);
			}
			if (this.state < global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_1_VALIDATED)
			{
				throw new global::System.InvalidOperationException("Round 1 payload must be validated prior to validation round 2 payload for " + this.participantId);
			}
			global::Org.BouncyCastle.Math.BigInteger gB = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateGA(this.p, this.gx3, this.gx1, this.gx2);
			this.b = round2PayloadReceived.A;
			global::Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX4s = round2PayloadReceived.KnowledgeProofForX2s;
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateParticipantIdsDiffer(this.participantId, round2PayloadReceived.ParticipantId);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateParticipantIdsEqual(this.partnerParticipantId, round2PayloadReceived.ParticipantId);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateGa(gB);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateZeroKnowledgeProof(this.p, this.q, gB, this.b, knowledgeProofForX4s, round2PayloadReceived.ParticipantId, this.digest);
			this.state = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_2_VALIDATED;
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000F1124 File Offset: 0x000EF324
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateKeyingMaterial()
		{
			if (this.state >= global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_KEY_CALCULATED)
			{
				throw new global::System.InvalidOperationException("Key already calculated for " + this.participantId);
			}
			if (this.state < global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_2_VALIDATED)
			{
				throw new global::System.InvalidOperationException("Round 2 payload must be validated prior to creating key for " + this.participantId);
			}
			global::Org.BouncyCastle.Math.BigInteger s = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateS(this.password);
			global::System.Array.Clear(this.password, 0, this.password.Length);
			this.password = null;
			global::Org.BouncyCastle.Math.BigInteger result = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateKeyingMaterial(this.p, this.q, this.gx4, this.x2, s, this.b);
			this.x1 = null;
			this.x2 = null;
			this.b = null;
			this.state = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_KEY_CALCULATED;
			return result;
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x000F11E4 File Offset: 0x000EF3E4
		public virtual global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeRound3Payload CreateRound3PayloadToSend(global::Org.BouncyCastle.Math.BigInteger keyingMaterial)
		{
			if (this.state >= global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_3_CREATED)
			{
				throw new global::System.InvalidOperationException("Round 3 payload already created for " + this.participantId);
			}
			if (this.state < global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_KEY_CALCULATED)
			{
				throw new global::System.InvalidOperationException("Keying material must be calculated prior to creating round 3 payload for " + this.participantId);
			}
			global::Org.BouncyCastle.Math.BigInteger macTag = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.CalculateMacTag(this.participantId, this.partnerParticipantId, this.gx1, this.gx2, this.gx3, this.gx4, keyingMaterial, this.digest);
			this.state = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_3_CREATED;
			return new global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeRound3Payload(this.participantId, macTag);
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x000F1280 File Offset: 0x000EF480
		public virtual void ValidateRound3PayloadReceived(global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeRound3Payload round3PayloadReceived, global::Org.BouncyCastle.Math.BigInteger keyingMaterial)
		{
			if (this.state >= global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_3_VALIDATED)
			{
				throw new global::System.InvalidOperationException("Validation already attempted for round 3 payload for " + this.participantId);
			}
			if (this.state < global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_KEY_CALCULATED)
			{
				throw new global::System.InvalidOperationException("Keying material must be calculated prior to validating round 3 payload for " + this.participantId);
			}
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateParticipantIdsDiffer(this.participantId, round3PayloadReceived.ParticipantId);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateParticipantIdsEqual(this.partnerParticipantId, round3PayloadReceived.ParticipantId);
			global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeUtilities.ValidateMacTag(this.participantId, this.partnerParticipantId, this.gx1, this.gx2, this.gx3, this.gx4, keyingMaterial, this.digest, round3PayloadReceived.MacTag);
			this.gx1 = null;
			this.gx2 = null;
			this.gx3 = null;
			this.gx4 = null;
			this.state = global::Org.BouncyCastle.Crypto.Agreement.JPake.JPakeParticipant.STATE_ROUND_3_VALIDATED;
		}

		// Token: 0x04001637 RID: 5687
		public static readonly int STATE_INITIALIZED = 0;

		// Token: 0x04001638 RID: 5688
		public static readonly int STATE_ROUND_1_CREATED = 10;

		// Token: 0x04001639 RID: 5689
		public static readonly int STATE_ROUND_1_VALIDATED = 20;

		// Token: 0x0400163A RID: 5690
		public static readonly int STATE_ROUND_2_CREATED = 30;

		// Token: 0x0400163B RID: 5691
		public static readonly int STATE_ROUND_2_VALIDATED = 40;

		// Token: 0x0400163C RID: 5692
		public static readonly int STATE_KEY_CALCULATED = 50;

		// Token: 0x0400163D RID: 5693
		public static readonly int STATE_ROUND_3_CREATED = 60;

		// Token: 0x0400163E RID: 5694
		public static readonly int STATE_ROUND_3_VALIDATED = 70;

		// Token: 0x0400163F RID: 5695
		private string participantId;

		// Token: 0x04001640 RID: 5696
		private char[] password;

		// Token: 0x04001641 RID: 5697
		private global::Org.BouncyCastle.Crypto.IDigest digest;

		// Token: 0x04001642 RID: 5698
		private readonly global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04001643 RID: 5699
		private readonly global::Org.BouncyCastle.Math.BigInteger p;

		// Token: 0x04001644 RID: 5700
		private readonly global::Org.BouncyCastle.Math.BigInteger q;

		// Token: 0x04001645 RID: 5701
		private readonly global::Org.BouncyCastle.Math.BigInteger g;

		// Token: 0x04001646 RID: 5702
		private string partnerParticipantId;

		// Token: 0x04001647 RID: 5703
		private global::Org.BouncyCastle.Math.BigInteger x1;

		// Token: 0x04001648 RID: 5704
		private global::Org.BouncyCastle.Math.BigInteger x2;

		// Token: 0x04001649 RID: 5705
		private global::Org.BouncyCastle.Math.BigInteger gx1;

		// Token: 0x0400164A RID: 5706
		private global::Org.BouncyCastle.Math.BigInteger gx2;

		// Token: 0x0400164B RID: 5707
		private global::Org.BouncyCastle.Math.BigInteger gx3;

		// Token: 0x0400164C RID: 5708
		private global::Org.BouncyCastle.Math.BigInteger gx4;

		// Token: 0x0400164D RID: 5709
		private global::Org.BouncyCastle.Math.BigInteger b;

		// Token: 0x0400164E RID: 5710
		private int state;
	}
}
