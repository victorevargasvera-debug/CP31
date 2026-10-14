using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200066A RID: 1642
	public class SubjectDirectoryAttributes : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C93 RID: 15507 RVA: 0x001151D0 File Offset: 0x001133D0
		public static global::Org.BouncyCastle.Asn1.X509.SubjectDirectoryAttributes GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.SubjectDirectoryAttributes)
			{
				return (global::Org.BouncyCastle.Asn1.X509.SubjectDirectoryAttributes)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.SubjectDirectoryAttributes((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x00115220 File Offset: 0x00113420
		private SubjectDirectoryAttributes(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.attributes = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence s = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj);
				this.attributes.Add(global::Org.BouncyCastle.Asn1.X509.AttributeX509.GetInstance(s));
			}
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x00115290 File Offset: 0x00113490
		[global::System.Obsolete]
		public SubjectDirectoryAttributes(global::System.Collections.ArrayList attributes) : this(attributes)
		{
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x00115299 File Offset: 0x00113499
		public SubjectDirectoryAttributes(global::System.Collections.IList attributes)
		{
			this.attributes = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(attributes);
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x001152B0 File Offset: 0x001134B0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.X509.AttributeX509[] v = new global::Org.BouncyCastle.Asn1.X509.AttributeX509[this.attributes.Count];
			for (int i = 0; i < this.attributes.Count; i++)
			{
				v[i] = (global::Org.BouncyCastle.Asn1.X509.AttributeX509)this.attributes[i];
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements = v;
			return new global::Org.BouncyCastle.Asn1.DerSequence(elements);
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06003C98 RID: 15512 RVA: 0x00115300 File Offset: 0x00113500
		public global::System.Collections.IEnumerable Attributes
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.attributes);
			}
		}

		// Token: 0x04001AC1 RID: 6849
		private readonly global::System.Collections.IList attributes;
	}
}
