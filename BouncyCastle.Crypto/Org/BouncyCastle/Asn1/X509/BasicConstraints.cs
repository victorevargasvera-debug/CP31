using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000647 RID: 1607
	public class BasicConstraints : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B87 RID: 15239 RVA: 0x00111DA5 File Offset: 0x0010FFA5
		public static global::Org.BouncyCastle.Asn1.X509.BasicConstraints GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.BasicConstraints.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x00111DB3 File Offset: 0x0010FFB3
		public static global::Org.BouncyCastle.Asn1.X509.BasicConstraints GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.BasicConstraints)
			{
				return (global::Org.BouncyCastle.Asn1.X509.BasicConstraints)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.X509Extension)
			{
				return global::Org.BouncyCastle.Asn1.X509.BasicConstraints.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extension.ConvertValueToObject((global::Org.BouncyCastle.Asn1.X509.X509Extension)obj));
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.BasicConstraints(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x00111DED File Offset: 0x0010FFED
		public static global::Org.BouncyCastle.Asn1.X509.BasicConstraints FromExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			return global::Org.BouncyCastle.Asn1.X509.BasicConstraints.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetExtensionParsedValue(extensions, global::Org.BouncyCastle.Asn1.X509.X509Extensions.BasicConstraints));
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x00111E00 File Offset: 0x00110000
		private BasicConstraints(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count > 0)
			{
				if (seq[0] is global::Org.BouncyCastle.Asn1.DerBoolean)
				{
					this.cA = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(seq[0]);
				}
				else
				{
					this.pathLenConstraint = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
				}
				if (seq.Count > 1)
				{
					if (this.cA == null)
					{
						throw new global::System.ArgumentException("wrong sequence in constructor", "seq");
					}
					this.pathLenConstraint = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
				}
			}
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x00111E83 File Offset: 0x00110083
		public BasicConstraints(bool cA)
		{
			if (cA)
			{
				this.cA = global::Org.BouncyCastle.Asn1.DerBoolean.True;
			}
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x00111E99 File Offset: 0x00110099
		public BasicConstraints(int pathLenConstraint)
		{
			this.cA = global::Org.BouncyCastle.Asn1.DerBoolean.True;
			this.pathLenConstraint = new global::Org.BouncyCastle.Asn1.DerInteger(pathLenConstraint);
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x00111EB8 File Offset: 0x001100B8
		public bool IsCA()
		{
			return this.cA != null && this.cA.IsTrue;
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06003B8E RID: 15246 RVA: 0x00111ECF File Offset: 0x001100CF
		public global::Org.BouncyCastle.Math.BigInteger PathLenConstraint
		{
			get
			{
				if (this.pathLenConstraint != null)
				{
					return this.pathLenConstraint.Value;
				}
				return null;
			}
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00111EE8 File Offset: 0x001100E8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(2);
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.cA,
				this.pathLenConstraint
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x00111F20 File Offset: 0x00110120
		public override string ToString()
		{
			if (this.pathLenConstraint == null)
			{
				return "BasicConstraints: isCa(" + this.IsCA().ToString() + ")";
			}
			string str = "BasicConstraints: isCa(";
			string str2 = this.IsCA().ToString();
			string str3 = "), pathLenConstraint = ";
			global::Org.BouncyCastle.Math.BigInteger value = this.pathLenConstraint.Value;
			return str + str2 + str3 + ((value != null) ? value.ToString() : null);
		}

		// Token: 0x04001A3B RID: 6715
		private readonly global::Org.BouncyCastle.Asn1.DerBoolean cA;

		// Token: 0x04001A3C RID: 6716
		private readonly global::Org.BouncyCastle.Asn1.DerInteger pathLenConstraint;
	}
}
