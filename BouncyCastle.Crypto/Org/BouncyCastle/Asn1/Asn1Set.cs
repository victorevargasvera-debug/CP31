using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005E7 RID: 1511
	public abstract class Asn1Set : global::Org.BouncyCastle.Asn1.Asn1Object, global::System.Collections.IEnumerable
	{
		// Token: 0x060038A5 RID: 14501 RVA: 0x0010A254 File Offset: 0x00108454
		public static global::Org.BouncyCastle.Asn1.Asn1Set GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Asn1Set)
			{
				return (global::Org.BouncyCastle.Asn1.Asn1Set)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1SetParser)
			{
				return global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1SetParser)obj).ToAsn1Object());
			}
			if (obj is byte[])
			{
				try
				{
					return global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray((byte[])obj));
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::System.ArgumentException("failed to construct set from byte[]: " + e.Message);
				}
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Encodable)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object primitive = ((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object();
				if (primitive is global::Org.BouncyCastle.Asn1.Asn1Set)
				{
					return (global::Org.BouncyCastle.Asn1.Asn1Set)primitive;
				}
			}
			throw new global::System.ArgumentException("Unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x0010A310 File Offset: 0x00108510
		public static global::Org.BouncyCastle.Asn1.Asn1Set GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object inner = obj.GetObject();
			if (explicitly)
			{
				if (!obj.IsExplicit())
				{
					throw new global::System.ArgumentException("object implicit - explicit expected.");
				}
				return (global::Org.BouncyCastle.Asn1.Asn1Set)inner;
			}
			else
			{
				if (obj.IsExplicit())
				{
					return new global::Org.BouncyCastle.Asn1.DerSet(inner);
				}
				if (inner is global::Org.BouncyCastle.Asn1.Asn1Set)
				{
					return (global::Org.BouncyCastle.Asn1.Asn1Set)inner;
				}
				if (inner is global::Org.BouncyCastle.Asn1.Asn1Sequence)
				{
					global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
					foreach (object obj2 in ((global::Org.BouncyCastle.Asn1.Asn1Sequence)inner))
					{
						global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2;
						v.Add(ae);
					}
					return new global::Org.BouncyCastle.Asn1.DerSet(v, false);
				}
				throw new global::System.ArgumentException("Unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
			}
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x0010A3E0 File Offset: 0x001085E0
		protected internal Asn1Set()
		{
			this.elements = global::Org.BouncyCastle.Asn1.Asn1EncodableVector.EmptyElements;
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x0010A3F3 File Offset: 0x001085F3
		protected internal Asn1Set(global::Org.BouncyCastle.Asn1.Asn1Encodable element)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			this.elements = new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				element
			};
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x0010A41C File Offset: 0x0010861C
		protected internal Asn1Set(params global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements)
		{
			if (global::Org.BouncyCastle.Utilities.Arrays.IsNullOrContainsNull(elements))
			{
				throw new global::System.NullReferenceException("'elements' cannot be null, or contain null");
			}
			this.elements = global::Org.BouncyCastle.Asn1.Asn1EncodableVector.CloneElements(elements);
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x0010A450 File Offset: 0x00108650
		protected internal Asn1Set(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector)
		{
			if (elementVector == null)
			{
				throw new global::System.ArgumentNullException("elementVector");
			}
			this.elements = elementVector.TakeElements();
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x0010A472 File Offset: 0x00108672
		public virtual global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.elements.GetEnumerator();
		}

		// Token: 0x17000794 RID: 1940
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable this[int index]
		{
			get
			{
				return this.elements[index];
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060038AD RID: 14509 RVA: 0x0010A489 File Offset: 0x00108689
		public virtual int Count
		{
			get
			{
				return this.elements.Length;
			}
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x0010A493 File Offset: 0x00108693
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable[] ToArray()
		{
			return global::Org.BouncyCastle.Asn1.Asn1EncodableVector.CloneElements(this.elements);
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060038AF RID: 14511 RVA: 0x0010A4A0 File Offset: 0x001086A0
		public global::Org.BouncyCastle.Asn1.Asn1SetParser Parser
		{
			get
			{
				return new global::Org.BouncyCastle.Asn1.Asn1Set.Asn1SetParserImpl(this);
			}
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x0010A4A8 File Offset: 0x001086A8
		protected override int Asn1GetHashCode()
		{
			int i = this.elements.Length;
			int hc = i + 1;
			while (--i >= 0)
			{
				hc *= 257;
				hc ^= this.elements[i].ToAsn1Object().CallAsn1GetHashCode();
			}
			return hc;
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x0010A4EC File Offset: 0x001086EC
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.Asn1Set that = asn1Object as global::Org.BouncyCastle.Asn1.Asn1Set;
			if (that == null)
			{
				return false;
			}
			int count = this.Count;
			if (that.Count != count)
			{
				return false;
			}
			for (int i = 0; i < count; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object o = this.elements[i].ToAsn1Object();
				global::Org.BouncyCastle.Asn1.Asn1Object o2 = that.elements[i].ToAsn1Object();
				if (o != o2 && !o.CallAsn1Equals(o2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x0010A554 File Offset: 0x00108754
		protected internal void Sort()
		{
			if (this.elements.Length < 2)
			{
				return;
			}
			int count = this.elements.Length;
			byte[][] keys = new byte[count][];
			for (int i = 0; i < count; i++)
			{
				keys[i] = this.elements[i].GetEncoded("DER");
			}
			global::System.Array.Sort(keys, this.elements, new global::Org.BouncyCastle.Asn1.Asn1Set.DerComparer());
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x0010A5AF File Offset: 0x001087AF
		public override string ToString()
		{
			return global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ToString(this.elements);
		}

		// Token: 0x0400193A RID: 6458
		internal global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements;

		// Token: 0x0200084D RID: 2125
		private class Asn1SetParserImpl : global::Org.BouncyCastle.Asn1.Asn1SetParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
		{
			// Token: 0x0600474E RID: 18254 RVA: 0x0013B58B File Offset: 0x0013978B
			public Asn1SetParserImpl(global::Org.BouncyCastle.Asn1.Asn1Set outer)
			{
				this.outer = outer;
				this.max = outer.Count;
			}

			// Token: 0x0600474F RID: 18255 RVA: 0x0013B5A8 File Offset: 0x001397A8
			public global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
			{
				if (this.index == this.max)
				{
					return null;
				}
				global::Org.BouncyCastle.Asn1.Asn1Set asn1Set = this.outer;
				int num = this.index;
				this.index = num + 1;
				global::Org.BouncyCastle.Asn1.Asn1Encodable obj = asn1Set[num];
				if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
				{
					return ((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj).Parser;
				}
				if (obj is global::Org.BouncyCastle.Asn1.Asn1Set)
				{
					return ((global::Org.BouncyCastle.Asn1.Asn1Set)obj).Parser;
				}
				return obj;
			}

			// Token: 0x06004750 RID: 18256 RVA: 0x0013B60B File Offset: 0x0013980B
			public virtual global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
			{
				return this.outer;
			}

			// Token: 0x040025BF RID: 9663
			private readonly global::Org.BouncyCastle.Asn1.Asn1Set outer;

			// Token: 0x040025C0 RID: 9664
			private readonly int max;

			// Token: 0x040025C1 RID: 9665
			private int index;
		}

		// Token: 0x0200084E RID: 2126
		private class DerComparer : global::System.Collections.IComparer
		{
			// Token: 0x06004751 RID: 18257 RVA: 0x0013B614 File Offset: 0x00139814
			public int Compare(object x, object y)
			{
				byte[] a = (byte[])x;
				byte[] b = (byte[])y;
				int a2 = (int)a[0] & -33;
				int b2 = (int)b[0] & -33;
				if (a2 == b2)
				{
					int len = global::System.Math.Min(a.Length, b.Length);
					int i = 1;
					while (i < len)
					{
						byte ai = a[i];
						byte bi = b[i];
						if (ai != bi)
						{
							if (ai >= bi)
							{
								return 1;
							}
							return -1;
						}
						else
						{
							i++;
						}
					}
					return 0;
				}
				if (a2 >= b2)
				{
					return 1;
				}
				return -1;
			}
		}
	}
}
