using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005EA RID: 1514
	public abstract class Asn1TaggedObject : global::Org.BouncyCastle.Asn1.Asn1Object, global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x060038BF RID: 14527 RVA: 0x0010A9D0 File Offset: 0x00108BD0
		internal static bool IsConstructed(bool isExplicit, global::Org.BouncyCastle.Asn1.Asn1Object obj)
		{
			if (isExplicit || obj is global::Org.BouncyCastle.Asn1.Asn1Sequence || obj is global::Org.BouncyCastle.Asn1.Asn1Set)
			{
				return true;
			}
			global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = obj as global::Org.BouncyCastle.Asn1.Asn1TaggedObject;
			return tagged != null && global::Org.BouncyCastle.Asn1.Asn1TaggedObject.IsConstructed(tagged.IsExplicit(), tagged.GetObject());
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x0010AA0F File Offset: 0x00108C0F
		public static global::Org.BouncyCastle.Asn1.Asn1TaggedObject GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			if (explicitly)
			{
				return global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj.GetObject());
			}
			throw new global::System.ArgumentException("implicitly tagged tagged object");
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x0010AA2A File Offset: 0x00108C2A
		public static global::Org.BouncyCastle.Asn1.Asn1TaggedObject GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
			}
			throw new global::System.ArgumentException("Unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x0010AA58 File Offset: 0x00108C58
		protected Asn1TaggedObject(int tagNo, global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			this.explicitly = true;
			this.tagNo = tagNo;
			this.obj = obj;
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x0010AA7C File Offset: 0x00108C7C
		protected Asn1TaggedObject(bool explicitly, int tagNo, global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			this.explicitly = (explicitly || obj is global::Org.BouncyCastle.Asn1.IAsn1Choice);
			this.tagNo = tagNo;
			this.obj = obj;
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x0010AAB0 File Offset: 0x00108CB0
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.Asn1TaggedObject other = asn1Object as global::Org.BouncyCastle.Asn1.Asn1TaggedObject;
			return other != null && (this.tagNo == other.tagNo && this.explicitly == other.explicitly) && object.Equals(this.GetObject(), other.GetObject());
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x0010AAF8 File Offset: 0x00108CF8
		protected override int Asn1GetHashCode()
		{
			int code = this.tagNo.GetHashCode();
			if (this.obj != null)
			{
				code ^= this.obj.GetHashCode();
			}
			return code;
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060038C6 RID: 14534 RVA: 0x0010AB28 File Offset: 0x00108D28
		public int TagNo
		{
			get
			{
				return this.tagNo;
			}
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x0010AB30 File Offset: 0x00108D30
		public bool IsExplicit()
		{
			return this.explicitly;
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x0010AB38 File Offset: 0x00108D38
		public bool IsEmpty()
		{
			return false;
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x0010AB3B File Offset: 0x00108D3B
		public global::Org.BouncyCastle.Asn1.Asn1Object GetObject()
		{
			if (this.obj != null)
			{
				return this.obj.ToAsn1Object();
			}
			return null;
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x0010AB54 File Offset: 0x00108D54
		public global::Org.BouncyCastle.Asn1.IAsn1Convertible GetObjectParser(int tag, bool isExplicit)
		{
			if (tag == 4)
			{
				return global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(this, isExplicit).Parser;
			}
			if (tag == 16)
			{
				return global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(this, isExplicit).Parser;
			}
			if (tag == 17)
			{
				return global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(this, isExplicit).Parser;
			}
			if (isExplicit)
			{
				return this.GetObject();
			}
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("implicit tagging for tag: " + tag.ToString());
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x0010ABB6 File Offset: 0x00108DB6
		public override string ToString()
		{
			string str = "[";
			string str2 = this.tagNo.ToString();
			string str3 = "]";
			global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Encodable = this.obj;
			return str + str2 + str3 + ((asn1Encodable != null) ? asn1Encodable.ToString() : null);
		}

		// Token: 0x0400193E RID: 6462
		internal int tagNo;

		// Token: 0x0400193F RID: 6463
		internal bool explicitly = true;

		// Token: 0x04001940 RID: 6464
		internal global::Org.BouncyCastle.Asn1.Asn1Encodable obj;
	}
}
