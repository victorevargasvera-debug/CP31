using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000605 RID: 1541
	public class DerExternal : global::Org.BouncyCastle.Asn1.Asn1Object
	{
		// Token: 0x06003985 RID: 14725 RVA: 0x0010C9BC File Offset: 0x0010ABBC
		public DerExternal(global::Org.BouncyCastle.Asn1.Asn1EncodableVector vector)
		{
			int offset = 0;
			global::Org.BouncyCastle.Asn1.Asn1Object enc = global::Org.BouncyCastle.Asn1.DerExternal.GetObjFromVector(vector, offset);
			if (enc is global::Org.BouncyCastle.Asn1.DerObjectIdentifier)
			{
				this.directReference = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)enc;
				offset++;
				enc = global::Org.BouncyCastle.Asn1.DerExternal.GetObjFromVector(vector, offset);
			}
			if (enc is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				this.indirectReference = (global::Org.BouncyCastle.Asn1.DerInteger)enc;
				offset++;
				enc = global::Org.BouncyCastle.Asn1.DerExternal.GetObjFromVector(vector, offset);
			}
			if (!(enc is global::Org.BouncyCastle.Asn1.Asn1TaggedObject))
			{
				this.dataValueDescriptor = enc;
				offset++;
				enc = global::Org.BouncyCastle.Asn1.DerExternal.GetObjFromVector(vector, offset);
			}
			if (vector.Count != offset + 1)
			{
				throw new global::System.ArgumentException("input vector too large", "vector");
			}
			if (!(enc is global::Org.BouncyCastle.Asn1.Asn1TaggedObject))
			{
				throw new global::System.ArgumentException("No tagged object found in vector. Structure doesn't seem to be of type External", "vector");
			}
			global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)enc;
			this.Encoding = obj.TagNo;
			if (this.encoding < 0 || this.encoding > 2)
			{
				throw new global::System.InvalidOperationException("invalid encoding value");
			}
			this.externalContent = obj.GetObject();
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x0010CAA3 File Offset: 0x0010ACA3
		public DerExternal(global::Org.BouncyCastle.Asn1.DerObjectIdentifier directReference, global::Org.BouncyCastle.Asn1.DerInteger indirectReference, global::Org.BouncyCastle.Asn1.Asn1Object dataValueDescriptor, global::Org.BouncyCastle.Asn1.DerTaggedObject externalData) : this(directReference, indirectReference, dataValueDescriptor, externalData.TagNo, externalData.ToAsn1Object())
		{
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x0010CABC File Offset: 0x0010ACBC
		public DerExternal(global::Org.BouncyCastle.Asn1.DerObjectIdentifier directReference, global::Org.BouncyCastle.Asn1.DerInteger indirectReference, global::Org.BouncyCastle.Asn1.Asn1Object dataValueDescriptor, int encoding, global::Org.BouncyCastle.Asn1.Asn1Object externalData)
		{
			this.DirectReference = directReference;
			this.IndirectReference = indirectReference;
			this.DataValueDescriptor = dataValueDescriptor;
			this.Encoding = encoding;
			this.ExternalContent = externalData.ToAsn1Object();
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x0010CAF0 File Offset: 0x0010ACF0
		internal override int EncodedLength(bool withID)
		{
			int contentsLength = 0;
			if (this.directReference != null)
			{
				contentsLength += this.directReference.EncodedLength(true);
			}
			if (this.indirectReference != null)
			{
				contentsLength += this.indirectReference.EncodedLength(true);
			}
			if (this.dataValueDescriptor != null)
			{
				contentsLength += this.dataValueDescriptor.GetDerEncoded().Length;
			}
			contentsLength += new global::Org.BouncyCastle.Asn1.DerTaggedObject(8, this.externalContent).EncodedLength(true);
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, contentsLength);
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x0010CB64 File Offset: 0x0010AD64
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			global::System.IO.MemoryStream ms = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Asn1.DerExternal.WriteEncodable(ms, this.directReference);
			global::Org.BouncyCastle.Asn1.DerExternal.WriteEncodable(ms, this.indirectReference);
			global::Org.BouncyCastle.Asn1.DerExternal.WriteEncodable(ms, this.dataValueDescriptor);
			global::Org.BouncyCastle.Asn1.DerExternal.WriteEncodable(ms, new global::Org.BouncyCastle.Asn1.DerTaggedObject(8, this.externalContent));
			asn1Out.WriteEncodingDL(withID, 40, ms.ToArray());
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x0010CBBC File Offset: 0x0010ADBC
		protected override int Asn1GetHashCode()
		{
			int ret = this.externalContent.GetHashCode();
			if (this.directReference != null)
			{
				ret ^= this.directReference.GetHashCode();
			}
			if (this.indirectReference != null)
			{
				ret ^= this.indirectReference.GetHashCode();
			}
			if (this.dataValueDescriptor != null)
			{
				ret ^= this.dataValueDescriptor.GetHashCode();
			}
			return ret;
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x0010CC18 File Offset: 0x0010AE18
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			if (this == asn1Object)
			{
				return true;
			}
			global::Org.BouncyCastle.Asn1.DerExternal other = asn1Object as global::Org.BouncyCastle.Asn1.DerExternal;
			return other != null && (object.Equals(this.directReference, other.directReference) && object.Equals(this.indirectReference, other.indirectReference) && object.Equals(this.dataValueDescriptor, other.dataValueDescriptor)) && this.externalContent.Equals(other.externalContent);
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600398C RID: 14732 RVA: 0x0010CC83 File Offset: 0x0010AE83
		// (set) Token: 0x0600398D RID: 14733 RVA: 0x0010CC8B File Offset: 0x0010AE8B
		public global::Org.BouncyCastle.Asn1.Asn1Object DataValueDescriptor
		{
			get
			{
				return this.dataValueDescriptor;
			}
			set
			{
				this.dataValueDescriptor = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x0600398E RID: 14734 RVA: 0x0010CC94 File Offset: 0x0010AE94
		// (set) Token: 0x0600398F RID: 14735 RVA: 0x0010CC9C File Offset: 0x0010AE9C
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier DirectReference
		{
			get
			{
				return this.directReference;
			}
			set
			{
				this.directReference = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06003990 RID: 14736 RVA: 0x0010CCA5 File Offset: 0x0010AEA5
		// (set) Token: 0x06003991 RID: 14737 RVA: 0x0010CCAD File Offset: 0x0010AEAD
		public int Encoding
		{
			get
			{
				return this.encoding;
			}
			set
			{
				if (this.encoding < 0 || this.encoding > 2)
				{
					throw new global::System.InvalidOperationException("invalid encoding value: " + this.encoding.ToString());
				}
				this.encoding = value;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x0010CCE3 File Offset: 0x0010AEE3
		// (set) Token: 0x06003993 RID: 14739 RVA: 0x0010CCEB File Offset: 0x0010AEEB
		public global::Org.BouncyCastle.Asn1.Asn1Object ExternalContent
		{
			get
			{
				return this.externalContent;
			}
			set
			{
				this.externalContent = value;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06003994 RID: 14740 RVA: 0x0010CCF4 File Offset: 0x0010AEF4
		// (set) Token: 0x06003995 RID: 14741 RVA: 0x0010CCFC File Offset: 0x0010AEFC
		public global::Org.BouncyCastle.Asn1.DerInteger IndirectReference
		{
			get
			{
				return this.indirectReference;
			}
			set
			{
				this.indirectReference = value;
			}
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x0010CD05 File Offset: 0x0010AF05
		private static global::Org.BouncyCastle.Asn1.Asn1Object GetObjFromVector(global::Org.BouncyCastle.Asn1.Asn1EncodableVector v, int index)
		{
			if (v.Count <= index)
			{
				throw new global::System.ArgumentException("too few objects in input vector", "v");
			}
			return v[index].ToAsn1Object();
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x0010CD2C File Offset: 0x0010AF2C
		private static void WriteEncodable(global::System.IO.MemoryStream ms, global::Org.BouncyCastle.Asn1.Asn1Encodable e)
		{
			if (e != null)
			{
				byte[] bs = e.GetDerEncoded();
				ms.Write(bs, 0, bs.Length);
			}
		}

		// Token: 0x0400198B RID: 6539
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier directReference;

		// Token: 0x0400198C RID: 6540
		private global::Org.BouncyCastle.Asn1.DerInteger indirectReference;

		// Token: 0x0400198D RID: 6541
		private global::Org.BouncyCastle.Asn1.Asn1Object dataValueDescriptor;

		// Token: 0x0400198E RID: 6542
		private int encoding;

		// Token: 0x0400198F RID: 6543
		private global::Org.BouncyCastle.Asn1.Asn1Object externalContent;
	}
}
