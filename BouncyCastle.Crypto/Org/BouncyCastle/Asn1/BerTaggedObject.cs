using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005FC RID: 1532
	public class BerTaggedObject : global::Org.BouncyCastle.Asn1.DerTaggedObject
	{
		// Token: 0x06003923 RID: 14627 RVA: 0x0010B4F3 File Offset: 0x001096F3
		public BerTaggedObject(int tagNo, global::Org.BouncyCastle.Asn1.Asn1Encodable obj) : base(tagNo, obj)
		{
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x0010B4FD File Offset: 0x001096FD
		public BerTaggedObject(bool explicitly, int tagNo, global::Org.BouncyCastle.Asn1.Asn1Encodable obj) : base(explicitly, tagNo, obj)
		{
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x0010B508 File Offset: 0x00109708
		public BerTaggedObject(int tagNo) : base(false, tagNo, global::Org.BouncyCastle.Asn1.BerSequence.Empty)
		{
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x0010B517 File Offset: 0x00109717
		internal override int EncodedLength(bool withID)
		{
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("BerTaggedObject.EncodedLength");
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x0010B524 File Offset: 0x00109724
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			if (asn1Out.IsBer)
			{
				if (withID)
				{
					asn1Out.WriteIdentifier(true, 160, this.tagNo);
				}
				asn1Out.WriteByte(128);
				if (!base.IsEmpty())
				{
					if (!this.explicitly)
					{
						global::System.Collections.IEnumerable eObj;
						if (this.obj is global::Org.BouncyCastle.Asn1.Asn1OctetString)
						{
							if (this.obj is global::Org.BouncyCastle.Asn1.BerOctetString)
							{
								eObj = (global::Org.BouncyCastle.Asn1.BerOctetString)this.obj;
							}
							else
							{
								eObj = new global::Org.BouncyCastle.Asn1.BerOctetString(((global::Org.BouncyCastle.Asn1.Asn1OctetString)this.obj).GetOctets());
							}
						}
						else if (this.obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
						{
							eObj = (global::Org.BouncyCastle.Asn1.Asn1Sequence)this.obj;
						}
						else
						{
							if (!(this.obj is global::Org.BouncyCastle.Asn1.Asn1Set))
							{
								throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException(global::Org.BouncyCastle.Utilities.Platform.GetTypeName(this.obj));
							}
							eObj = (global::Org.BouncyCastle.Asn1.Asn1Set)this.obj;
						}
						using (global::System.Collections.IEnumerator enumerator = eObj.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								global::Org.BouncyCastle.Asn1.Asn1Encodable o = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
								asn1Out.WritePrimitive(o.ToAsn1Object(), true);
							}
							goto IL_117;
						}
					}
					asn1Out.WritePrimitive(this.obj.ToAsn1Object(), true);
				}
				IL_117:
				asn1Out.WriteByte(0);
				asn1Out.WriteByte(0);
				return;
			}
			base.Encode(asn1Out, withID);
		}
	}
}
