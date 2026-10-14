using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005CD RID: 1485
	public class Features : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x060037ED RID: 14317 RVA: 0x001084F8 File Offset: 0x001066F8
		private static byte[] featureToByteArray(byte feature)
		{
			return new byte[]
			{
				feature
			};
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00108504 File Offset: 0x00106704
		public Features(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.Features, critical, isLongLength, data)
		{
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x00108511 File Offset: 0x00106711
		public Features(bool critical, byte features) : this(critical, false, global::Org.BouncyCastle.Bcpg.Sig.Features.featureToByteArray(features))
		{
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00108521 File Offset: 0x00106721
		public Features(bool critical, int features) : this(critical, false, global::Org.BouncyCastle.Bcpg.Sig.Features.featureToByteArray((byte)features))
		{
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x00108532 File Offset: 0x00106732
		public bool SupportsModificationDetection
		{
			get
			{
				return this.SupportsFeature(global::Org.BouncyCastle.Bcpg.Sig.Features.FEATURE_MODIFICATION_DETECTION);
			}
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x0010853F File Offset: 0x0010673F
		public bool SupportsFeature(byte feature)
		{
			return (this.data[0] & feature) > 0;
		}

		// Token: 0x0400191B RID: 6427
		public static readonly byte FEATURE_MODIFICATION_DETECTION = 1;

		// Token: 0x0400191C RID: 6428
		public static readonly byte FEATURE_AEAD_ENCRYPTED_DATA = 2;

		// Token: 0x0400191D RID: 6429
		public static readonly byte FEATURE_VERSION_5_PUBLIC_KEY = 4;
	}
}
