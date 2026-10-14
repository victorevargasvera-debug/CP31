using System;
using System.Collections;
using Org.BouncyCastle.Bcpg.Sig;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005C2 RID: 1474
	public class PgpSignatureSubpacketGenerator
	{
		// Token: 0x0600377E RID: 14206 RVA: 0x00106D95 File Offset: 0x00104F95
		public PgpSignatureSubpacketGenerator()
		{
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00106DA8 File Offset: 0x00104FA8
		public PgpSignatureSubpacketGenerator(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector sigSubV)
		{
			if (sigSubV != null)
			{
				global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] subs = sigSubV.ToSubpacketArray();
				for (int i = 0; i != sigSubV.Count; i++)
				{
					this.list.Add(subs[i]);
				}
			}
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x00106DF0 File Offset: 0x00104FF0
		public void SetRevocable(bool isCritical, bool isRevocable)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.Revocable(isCritical, isRevocable));
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00106E05 File Offset: 0x00105005
		public void SetExportable(bool isCritical, bool isExportable)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.Exportable(isCritical, isExportable));
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x00106E1A File Offset: 0x0010501A
		public void SetFeature(bool isCritical, byte feature)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.Features(isCritical, feature));
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x00106E2F File Offset: 0x0010502F
		public void SetTrust(bool isCritical, int depth, int trustAmount)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.TrustSignature(isCritical, depth, trustAmount));
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00106E45 File Offset: 0x00105045
		public void SetKeyExpirationTime(bool isCritical, long seconds)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.KeyExpirationTime(isCritical, seconds));
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00106E5A File Offset: 0x0010505A
		public void SetSignatureExpirationTime(bool isCritical, long seconds)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.SignatureExpirationTime(isCritical, seconds));
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x00106E6F File Offset: 0x0010506F
		public void SetSignatureCreationTime(bool isCritical, global::System.DateTime date)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.SignatureCreationTime(isCritical, date));
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00106E84 File Offset: 0x00105084
		public void SetPreferredHashAlgorithms(bool isCritical, int[] algorithms)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.PreferredAlgorithms(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PreferredHashAlgorithms, isCritical, algorithms));
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00106E9B File Offset: 0x0010509B
		public void SetPreferredSymmetricAlgorithms(bool isCritical, int[] algorithms)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.PreferredAlgorithms(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PreferredSymmetricAlgorithms, isCritical, algorithms));
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00106EB2 File Offset: 0x001050B2
		public void SetPreferredCompressionAlgorithms(bool isCritical, int[] algorithms)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.PreferredAlgorithms(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PreferredCompressionAlgorithms, isCritical, algorithms));
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x00106EC9 File Offset: 0x001050C9
		public void SetKeyFlags(bool isCritical, int flags)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.KeyFlags(isCritical, flags));
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00106EDE File Offset: 0x001050DE
		public void SetSignerUserId(bool isCritical, string userId)
		{
			if (userId == null)
			{
				throw new global::System.ArgumentNullException("userId");
			}
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.SignerUserId(isCritical, userId));
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x00106F01 File Offset: 0x00105101
		public void SetSignerUserId(bool isCritical, byte[] rawUserId)
		{
			if (rawUserId == null)
			{
				throw new global::System.ArgumentNullException("rawUserId");
			}
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.SignerUserId(isCritical, false, rawUserId));
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00106F28 File Offset: 0x00105128
		public void SetEmbeddedSignature(bool isCritical, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignature pgpSignature)
		{
			byte[] sig = pgpSignature.GetEncoded();
			byte[] data;
			if (sig.Length - 1 > 256)
			{
				data = new byte[sig.Length - 3];
			}
			else
			{
				data = new byte[sig.Length - 2];
			}
			global::System.Array.Copy(sig, sig.Length - data.Length, data, 0, data.Length);
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.EmbeddedSignature(isCritical, false, data));
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x00106F86 File Offset: 0x00105186
		public void SetPrimaryUserId(bool isCritical, bool isPrimaryUserId)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.PrimaryUserId(isCritical, isPrimaryUserId));
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00106F9B File Offset: 0x0010519B
		public void SetNotationData(bool isCritical, bool isHumanReadable, string notationName, string notationValue)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.NotationData(isCritical, isHumanReadable, notationName, notationValue));
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00106FB3 File Offset: 0x001051B3
		public void SetRevocationReason(bool isCritical, global::Org.BouncyCastle.Bcpg.RevocationReasonTag reason, string description)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.RevocationReason(isCritical, reason, description));
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00106FC9 File Offset: 0x001051C9
		public void SetRevocationKey(bool isCritical, global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm, byte[] fingerprint)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.RevocationKey(isCritical, global::Org.BouncyCastle.Bcpg.RevocationKeyTag.ClassDefault, keyAlgorithm, fingerprint));
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x00106FE4 File Offset: 0x001051E4
		public void SetIssuerKeyID(bool isCritical, long keyID)
		{
			this.list.Add(new global::Org.BouncyCastle.Bcpg.Sig.IssuerKeyId(isCritical, keyID));
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x00106FFC File Offset: 0x001051FC
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector Generate()
		{
			global::Org.BouncyCastle.Bcpg.SignatureSubpacket[] a = new global::Org.BouncyCastle.Bcpg.SignatureSubpacket[this.list.Count];
			for (int i = 0; i < this.list.Count; i++)
			{
				a[i] = (global::Org.BouncyCastle.Bcpg.SignatureSubpacket)this.list[i];
			}
			return new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpSignatureSubpacketVector(a);
		}

		// Token: 0x0400190D RID: 6413
		private global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
	}
}
