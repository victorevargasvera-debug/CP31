using System;
using System.IO;
using Org.BouncyCastle.Bcpg.Sig;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005C3 RID: 1475
	public class PgpSignatureSubpacketVector
	{
		// Token: 0x06003794 RID: 14228 RVA: 0x0010704A File Offset: 0x0010524A
		public static global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector FromSubpackets(global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] packets)
		{
			if (packets == null)
			{
				packets = new global::Org.BouncyCastle.Bcpg.SignatureSubpacket[0];
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector(packets);
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x0010705D File Offset: 0x0010525D
		internal PgpSignatureSubpacketVector(global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] packets)
		{
			this.packets = packets;
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x0010706C File Offset: 0x0010526C
		public global::Org.BouncyCastle.Bcpg.SignatureSubpacket GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag type)
		{
			for (int i = 0; i != this.packets.Length; i++)
			{
				if (this.packets[i].SubpacketType == type)
				{
					return this.packets[i];
				}
			}
			return null;
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x001070A6 File Offset: 0x001052A6
		public bool HasSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag type)
		{
			return this.GetSubpacket(type) != null;
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x001070B4 File Offset: 0x001052B4
		public global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] GetSubpackets(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag type)
		{
			int count = 0;
			for (int i = 0; i < this.packets.Length; i++)
			{
				if (this.packets[i].SubpacketType == type)
				{
					count++;
				}
			}
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] result = new global::Org.BouncyCastle.Bcpg.SignatureSubpacket[count];
			int pos = 0;
			for (int j = 0; j < this.packets.Length; j++)
			{
				if (this.packets[j].SubpacketType == type)
				{
					result[pos++] = this.packets[j];
				}
			}
			return result;
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x0010712C File Offset: 0x0010532C
		public global::Org.BouncyCastle.Bcpg.Sig.NotationData[] GetNotationDataOccurrences()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] notations = this.GetSubpackets(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.NotationData);
			global::Org.BouncyCastle.Bcpg.Sig.NotationData[] vals = new global::Org.BouncyCastle.Bcpg.Sig.NotationData[notations.Length];
			for (int i = 0; i < notations.Length; i++)
			{
				vals[i] = (global::Org.BouncyCastle.Bcpg.Sig.NotationData)notations[i];
			}
			return vals;
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00107165 File Offset: 0x00105365
		[global::System.Obsolete("Use 'GetNotationDataOccurrences' instead")]
		public global::Org.BouncyCastle.Bcpg.Sig.NotationData[] GetNotationDataOccurences()
		{
			return this.GetNotationDataOccurrences();
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x00107170 File Offset: 0x00105370
		public long GetIssuerKeyId()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket p = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.IssuerKeyId);
			if (p != null)
			{
				return ((global::Org.BouncyCastle.Bcpg.Sig.IssuerKeyId)p).KeyId;
			}
			return 0L;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x00107197 File Offset: 0x00105397
		public bool HasSignatureCreationTime()
		{
			return this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.CreationTime) != null;
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x001071A3 File Offset: 0x001053A3
		public global::System.DateTime GetSignatureCreationTime()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket subpacket = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.CreationTime);
			if (subpacket == null)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("SignatureCreationTime not available");
			}
			return ((global::Org.BouncyCastle.Bcpg.Sig.SignatureCreationTime)subpacket).GetTime();
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x001071C4 File Offset: 0x001053C4
		public long GetSignatureExpirationTime()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket p = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.ExpireTime);
			if (p != null)
			{
				return ((global::Org.BouncyCastle.Bcpg.Sig.SignatureExpirationTime)p).Time;
			}
			return 0L;
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x001071EC File Offset: 0x001053EC
		public long GetKeyExpirationTime()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket p = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.KeyExpireTime);
			if (p != null)
			{
				return ((global::Org.BouncyCastle.Bcpg.Sig.KeyExpirationTime)p).Time;
			}
			return 0L;
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00107214 File Offset: 0x00105414
		public int[] GetPreferredHashAlgorithms()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket p = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PreferredHashAlgorithms);
			if (p != null)
			{
				return ((global::Org.BouncyCastle.Bcpg.Sig.PreferredAlgorithms)p).GetPreferences();
			}
			return null;
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x0010723C File Offset: 0x0010543C
		public int[] GetPreferredSymmetricAlgorithms()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket p = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PreferredSymmetricAlgorithms);
			if (p != null)
			{
				return ((global::Org.BouncyCastle.Bcpg.Sig.PreferredAlgorithms)p).GetPreferences();
			}
			return null;
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x00107264 File Offset: 0x00105464
		public int[] GetPreferredCompressionAlgorithms()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket p = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PreferredCompressionAlgorithms);
			if (p != null)
			{
				return ((global::Org.BouncyCastle.Bcpg.Sig.PreferredAlgorithms)p).GetPreferences();
			}
			return null;
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x0010728C File Offset: 0x0010548C
		public int GetKeyFlags()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket p = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.KeyFlags);
			if (p != null)
			{
				return ((global::Org.BouncyCastle.Bcpg.Sig.KeyFlags)p).Flags;
			}
			return 0;
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x001072B4 File Offset: 0x001054B4
		public string GetSignerUserId()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket p = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.SignerUserId);
			if (p != null)
			{
				return ((global::Org.BouncyCastle.Bcpg.Sig.SignerUserId)p).GetId();
			}
			return null;
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x001072DC File Offset: 0x001054DC
		public bool IsPrimaryUserId()
		{
			global::Org.BouncyCastle.Bcpg.Sig.PrimaryUserId primaryId = (global::Org.BouncyCastle.Bcpg.Sig.PrimaryUserId)this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PrimaryUserId);
			return primaryId != null && primaryId.IsPrimaryUserId();
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00107304 File Offset: 0x00105504
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureList GetEmbeddedSignatures()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] sigs = this.GetSubpackets(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.EmbeddedSignature);
			global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature[] i = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature[sigs.Length];
			for (int j = 0; j < sigs.Length; j++)
			{
				try
				{
					i[j] = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature(global::Org.BouncyCastle.Bcpg.SignaturePacket.FromByteArray(sigs[j].GetData()));
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Unable to parse signature packet: " + e.Message, e);
				}
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureList(i);
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x00107378 File Offset: 0x00105578
		public global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag[] GetCriticalTags()
		{
			int count = 0;
			for (int i = 0; i != this.packets.Length; i++)
			{
				if (this.packets[i].IsCritical())
				{
					count++;
				}
			}
			global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag[] list = new global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag[count];
			count = 0;
			for (int j = 0; j != this.packets.Length; j++)
			{
				if (this.packets[j].IsCritical())
				{
					list[count++] = this.packets[j].SubpacketType;
				}
			}
			return list;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x001073F0 File Offset: 0x001055F0
		public global::Org.BouncyCastle.Bcpg.Sig.Features GetFeatures()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket p = this.GetSubpacket(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.Features);
			if (p == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Bcpg.Sig.Features(p.IsCritical(), p.IsLongLength(), p.GetData());
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060037A9 RID: 14249 RVA: 0x00107422 File Offset: 0x00105622
		[global::System.Obsolete("Use 'Count' property instead")]
		public int Size
		{
			get
			{
				return this.packets.Length;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060037AA RID: 14250 RVA: 0x0010742C File Offset: 0x0010562C
		public int Count
		{
			get
			{
				return this.packets.Length;
			}
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x00107436 File Offset: 0x00105636
		internal global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] ToSubpacketArray()
		{
			return this.packets;
		}

		// Token: 0x0400190E RID: 6414
		private readonly global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] packets;
	}
}
