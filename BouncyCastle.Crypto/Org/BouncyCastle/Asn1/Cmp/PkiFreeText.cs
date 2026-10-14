using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000780 RID: 1920
	public class PkiFreeText : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600444A RID: 17482 RVA: 0x001307FA File Offset: 0x0012E9FA
		public static global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x00130808 File Offset: 0x0012EA08
		public static global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PkiFreeText((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600444C RID: 17484 RVA: 0x00130848 File Offset: 0x0012EA48
		public PkiFreeText(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			using (global::System.Collections.IEnumerator enumerator = seq.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!(enumerator.Current is global::Org.BouncyCastle.Asn1.DerUtf8String))
					{
						throw new global::System.ArgumentException("attempt to insert non UTF8 STRING into PkiFreeText");
					}
				}
			}
			this.strings = seq;
		}

		// Token: 0x0600444D RID: 17485 RVA: 0x001308B0 File Offset: 0x0012EAB0
		public PkiFreeText(global::Org.BouncyCastle.Asn1.DerUtf8String p)
		{
			this.strings = new global::Org.BouncyCastle.Asn1.DerSequence(p);
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x001308C4 File Offset: 0x0012EAC4
		[global::System.Obsolete("Use 'Count' property instead")]
		public int Size
		{
			get
			{
				return this.strings.Count;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600444F RID: 17487 RVA: 0x001308D1 File Offset: 0x0012EAD1
		public int Count
		{
			get
			{
				return this.strings.Count;
			}
		}

		// Token: 0x17000A44 RID: 2628
		public global::Org.BouncyCastle.Asn1.DerUtf8String this[int index]
		{
			get
			{
				return (global::Org.BouncyCastle.Asn1.DerUtf8String)this.strings[index];
			}
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x001308F1 File Offset: 0x0012EAF1
		[global::System.Obsolete("Use 'object[index]' syntax instead")]
		public global::Org.BouncyCastle.Asn1.DerUtf8String GetStringAt(int index)
		{
			return this[index];
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x001308FA File Offset: 0x0012EAFA
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.strings;
		}

		// Token: 0x04002114 RID: 8468
		internal global::Org.BouncyCastle.Asn1.Asn1Sequence strings;
	}
}
