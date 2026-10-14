using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x020001FD RID: 509
	internal class GenericPolynomialExtensionField : global::Org.BouncyCastle.Math.Field.IPolynomialExtensionField, global::Org.BouncyCastle.Math.Field.IExtensionField, global::Org.BouncyCastle.Math.Field.IFiniteField
	{
		// Token: 0x0600141D RID: 5149 RVA: 0x0005F564 File Offset: 0x0005D764
		internal GenericPolynomialExtensionField(global::Org.BouncyCastle.Math.Field.IFiniteField subfield, global::Org.BouncyCastle.Math.Field.IPolynomial polynomial)
		{
			this.subfield = subfield;
			this.minimalPolynomial = polynomial;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0005F57A File Offset: 0x0005D77A
		public virtual global::Org.BouncyCastle.Math.BigInteger Characteristic
		{
			get
			{
				return this.subfield.Characteristic;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x0005F587 File Offset: 0x0005D787
		public virtual int Dimension
		{
			get
			{
				return this.subfield.Dimension * this.minimalPolynomial.Degree;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0005F5A0 File Offset: 0x0005D7A0
		public virtual global::Org.BouncyCastle.Math.Field.IFiniteField Subfield
		{
			get
			{
				return this.subfield;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0005F5A8 File Offset: 0x0005D7A8
		public virtual int Degree
		{
			get
			{
				return this.minimalPolynomial.Degree;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0005F5B5 File Offset: 0x0005D7B5
		public virtual global::Org.BouncyCastle.Math.Field.IPolynomial MinimalPolynomial
		{
			get
			{
				return this.minimalPolynomial;
			}
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0005F5C0 File Offset: 0x0005D7C0
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			global::Org.BouncyCastle.Math.Field.GenericPolynomialExtensionField other = obj as global::Org.BouncyCastle.Math.Field.GenericPolynomialExtensionField;
			return other != null && this.subfield.Equals(other.subfield) && this.minimalPolynomial.Equals(other.minimalPolynomial);
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0005F605 File Offset: 0x0005D805
		public override int GetHashCode()
		{
			return this.subfield.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(this.minimalPolynomial.GetHashCode(), 16);
		}

		// Token: 0x04000937 RID: 2359
		protected readonly global::Org.BouncyCastle.Math.Field.IFiniteField subfield;

		// Token: 0x04000938 RID: 2360
		protected readonly global::Org.BouncyCastle.Math.Field.IPolynomial minimalPolynomial;
	}
}
