using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Agreement.JPake
{
	// Token: 0x02000505 RID: 1285
	public class JPakeRound3Payload
	{
		// Token: 0x0600323D RID: 12861 RVA: 0x000F1700 File Offset: 0x000EF900
		public JPakeRound3Payload(string participantId, global::Org.BouncyCastle.Math.BigInteger magTag)
		{
			this.participantId = participantId;
			this.macTag = magTag;
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x000F1716 File Offset: 0x000EF916
		public virtual string ParticipantId
		{
			get
			{
				return this.participantId;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600323F RID: 12863 RVA: 0x000F171E File Offset: 0x000EF91E
		public virtual global::Org.BouncyCastle.Math.BigInteger MacTag
		{
			get
			{
				return this.macTag;
			}
		}

		// Token: 0x0400165D RID: 5725
		private readonly string participantId;

		// Token: 0x0400165E RID: 5726
		private readonly global::Org.BouncyCastle.Math.BigInteger macTag;
	}
}
