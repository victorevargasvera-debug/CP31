using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000727 RID: 1831
	public class CertReqMessages : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060041C3 RID: 16835 RVA: 0x001299C8 File Offset: 0x00127BC8
		private CertReqMessages(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x001299D7 File Offset: 0x00127BD7
		public static global::Org.BouncyCastle.Asn1.Crmf.CertReqMessages GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.CertReqMessages)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.CertReqMessages)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.CertReqMessages((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x00129A18 File Offset: 0x00127C18
		public CertReqMessages(params global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg[] msgs)
		{
			this.content = new global::Org.BouncyCastle.Asn1.DerSequence(msgs);
		}

		// Token: 0x060041C6 RID: 16838 RVA: 0x00129A3C File Offset: 0x00127C3C
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg[] ToCertReqMsgArray()
		{
			global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg[] result = new global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg[this.content.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Crmf.CertReqMsg.GetInstance(this.content[i]);
			}
			return result;
		}

		// Token: 0x060041C7 RID: 16839 RVA: 0x00129A7D File Offset: 0x00127C7D
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x04001FA1 RID: 8097
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
