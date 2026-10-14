using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000591 RID: 1425
	public class RevocationKey : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x060035E0 RID: 13792 RVA: 0x000FFE73 File Offset: 0x000FE073
		public RevocationKey(bool isCritical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.RevocationKey, isCritical, isLongLength, data)
		{
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x000FFE80 File Offset: 0x000FE080
		public RevocationKey(bool isCritical, global::Org.BouncyCastle.Bcpg.RevocationKeyTag signatureClass, global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm, byte[] fingerprint) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.RevocationKey, isCritical, false, global::Org.BouncyCastle.Bcpg.RevocationKey.CreateData(signatureClass, keyAlgorithm, fingerprint))
		{
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x000FFE98 File Offset: 0x000FE098
		private static byte[] CreateData(global::Org.BouncyCastle.Bcpg.RevocationKeyTag signatureClass, global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm, byte[] fingerprint)
		{
			byte[] data = new byte[2 + fingerprint.Length];
			data[0] = (byte)signatureClass;
			data[1] = (byte)keyAlgorithm;
			global::System.Array.Copy(fingerprint, 0, data, 2, fingerprint.Length);
			return data;
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060035E3 RID: 13795 RVA: 0x000FFEC6 File Offset: 0x000FE0C6
		public virtual global::Org.BouncyCastle.Bcpg.RevocationKeyTag SignatureClass
		{
			get
			{
				return (global::Org.BouncyCastle.Bcpg.RevocationKeyTag)base.GetData()[0];
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x000FFED0 File Offset: 0x000FE0D0
		public virtual global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag Algorithm
		{
			get
			{
				return (global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag)base.GetData()[1];
			}
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x000FFEDC File Offset: 0x000FE0DC
		public virtual byte[] GetFingerprint()
		{
			byte[] data = base.GetData();
			byte[] fingerprint = new byte[data.Length - 2];
			global::System.Array.Copy(data, 2, fingerprint, 0, fingerprint.Length);
			return fingerprint;
		}
	}
}
