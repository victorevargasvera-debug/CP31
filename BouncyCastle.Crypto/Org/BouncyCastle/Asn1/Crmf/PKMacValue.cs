using System;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000734 RID: 1844
	public class PKMacValue : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004226 RID: 16934 RVA: 0x0012A87A File Offset: 0x00128A7A
		private PKMacValue(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.algID = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[0]);
			this.macValue = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[1]);
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x0012A8A6 File Offset: 0x00128AA6
		public static global::Org.BouncyCastle.Asn1.Crmf.PKMacValue GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.PKMacValue)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.PKMacValue)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.PKMacValue((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x0012A8E5 File Offset: 0x00128AE5
		public static global::Org.BouncyCastle.Asn1.Crmf.PKMacValue GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Crmf.PKMacValue.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x0012A8F3 File Offset: 0x00128AF3
		public PKMacValue(global::Org.BouncyCastle.Asn1.Cmp.PbmParameter pbmParams, global::Org.BouncyCastle.Asn1.DerBitString macValue) : this(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Cmp.CmpObjectIdentifiers.passwordBasedMac, pbmParams), macValue)
		{
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x0012A907 File Offset: 0x00128B07
		public PKMacValue(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID, global::Org.BouncyCastle.Asn1.DerBitString macValue)
		{
			this.algID = algID;
			this.macValue = macValue;
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x0600422B RID: 16939 RVA: 0x0012A91D File Offset: 0x00128B1D
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgID
		{
			get
			{
				return this.algID;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x0012A925 File Offset: 0x00128B25
		public virtual global::Org.BouncyCastle.Asn1.DerBitString MacValue
		{
			get
			{
				return this.macValue;
			}
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x0012A92D File Offset: 0x00128B2D
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.algID,
				this.macValue
			});
		}

		// Token: 0x04001FD8 RID: 8152
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID;

		// Token: 0x04001FD9 RID: 8153
		private readonly global::Org.BouncyCastle.Asn1.DerBitString macValue;
	}
}
