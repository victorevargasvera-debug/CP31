using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.Qualified
{
	// Token: 0x02000687 RID: 1671
	public class BiometricData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003DA8 RID: 15784 RVA: 0x00119778 File Offset: 0x00117978
		public static global::Org.BouncyCastle.Asn1.X509.Qualified.BiometricData GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.Qualified.BiometricData)
			{
				return (global::Org.BouncyCastle.Asn1.X509.Qualified.BiometricData)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Qualified.BiometricData(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			throw new global::System.ArgumentException("unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x001197C8 File Offset: 0x001179C8
		private BiometricData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.typeOfBiometricData = global::Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData.GetInstance(seq[0]);
			this.hashAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1]);
			this.biometricDataHash = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[2]);
			if (seq.Count > 3)
			{
				this.sourceDataUri = global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(seq[3]);
			}
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x0011982C File Offset: 0x00117A2C
		public BiometricData(global::Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData typeOfBiometricData, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString biometricDataHash, global::Org.BouncyCastle.Asn1.DerIA5String sourceDataUri)
		{
			this.typeOfBiometricData = typeOfBiometricData;
			this.hashAlgorithm = hashAlgorithm;
			this.biometricDataHash = biometricDataHash;
			this.sourceDataUri = sourceDataUri;
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x00119851 File Offset: 0x00117A51
		public BiometricData(global::Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData typeOfBiometricData, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString biometricDataHash)
		{
			this.typeOfBiometricData = typeOfBiometricData;
			this.hashAlgorithm = hashAlgorithm;
			this.biometricDataHash = biometricDataHash;
			this.sourceDataUri = null;
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06003DAC RID: 15788 RVA: 0x00119875 File Offset: 0x00117A75
		public global::Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData TypeOfBiometricData
		{
			get
			{
				return this.typeOfBiometricData;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x0011987D File Offset: 0x00117A7D
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				return this.hashAlgorithm;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06003DAE RID: 15790 RVA: 0x00119885 File Offset: 0x00117A85
		public global::Org.BouncyCastle.Asn1.Asn1OctetString BiometricDataHash
		{
			get
			{
				return this.biometricDataHash;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06003DAF RID: 15791 RVA: 0x0011988D File Offset: 0x00117A8D
		public global::Org.BouncyCastle.Asn1.DerIA5String SourceDataUri
		{
			get
			{
				return this.sourceDataUri;
			}
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x00119898 File Offset: 0x00117A98
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.typeOfBiometricData,
				this.hashAlgorithm,
				this.biometricDataHash
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.sourceDataUri
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001B8D RID: 7053
		private readonly global::Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData typeOfBiometricData;

		// Token: 0x04001B8E RID: 7054
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm;

		// Token: 0x04001B8F RID: 7055
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString biometricDataHash;

		// Token: 0x04001B90 RID: 7056
		private readonly global::Org.BouncyCastle.Asn1.DerIA5String sourceDataUri;
	}
}
