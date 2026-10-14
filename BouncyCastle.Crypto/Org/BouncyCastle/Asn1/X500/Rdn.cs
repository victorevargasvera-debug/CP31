using System;

namespace Org.BouncyCastle.Asn1.X500
{
	// Token: 0x02000691 RID: 1681
	public class Rdn : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003DE5 RID: 15845 RVA: 0x0011A169 File Offset: 0x00118369
		private Rdn(global::Org.BouncyCastle.Asn1.Asn1Set values)
		{
			this.values = values;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x0011A178 File Offset: 0x00118378
		public static global::Org.BouncyCastle.Asn1.X500.Rdn GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X500.Rdn)
			{
				return (global::Org.BouncyCastle.Asn1.X500.Rdn)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.X500.Rdn(global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x0011A199 File Offset: 0x00118399
		public Rdn(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			this.values = new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				oid,
				value
			}));
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x0011A1BF File Offset: 0x001183BF
		public Rdn(global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue attrTAndV)
		{
			this.values = new global::Org.BouncyCastle.Asn1.DerSet(attrTAndV);
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x0011A1D4 File Offset: 0x001183D4
		public Rdn(global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue[] aAndVs)
		{
			this.values = new global::Org.BouncyCastle.Asn1.DerSet(aAndVs);
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x0011A1F5 File Offset: 0x001183F5
		public virtual bool IsMultiValued
		{
			get
			{
				return this.values.Count > 1;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06003DEB RID: 15851 RVA: 0x0011A205 File Offset: 0x00118405
		public virtual int Count
		{
			get
			{
				return this.values.Count;
			}
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x0011A212 File Offset: 0x00118412
		public virtual global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue GetFirst()
		{
			if (this.values.Count == 0)
			{
				return null;
			}
			return global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue.GetInstance(this.values[0]);
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x0011A234 File Offset: 0x00118434
		public virtual global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue[] GetTypesAndValues()
		{
			global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue[] tmp = new global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue[this.values.Count];
			for (int i = 0; i < tmp.Length; i++)
			{
				tmp[i] = global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue.GetInstance(this.values[i]);
			}
			return tmp;
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x0011A275 File Offset: 0x00118475
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.values;
		}

		// Token: 0x04001BAA RID: 7082
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set values;
	}
}
