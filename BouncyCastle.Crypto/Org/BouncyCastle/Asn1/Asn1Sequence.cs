using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005E5 RID: 1509
	public abstract class Asn1Sequence : global::Org.BouncyCastle.Asn1.Asn1Object, global::System.Collections.IEnumerable
	{
		// Token: 0x06003896 RID: 14486 RVA: 0x00109FA0 File Offset: 0x001081A0
		public static global::Org.BouncyCastle.Asn1.Asn1Sequence GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return (global::Org.BouncyCastle.Asn1.Asn1Sequence)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1SequenceParser)
			{
				return global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1SequenceParser)obj).ToAsn1Object());
			}
			if (obj is byte[])
			{
				try
				{
					return global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray((byte[])obj));
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::System.ArgumentException("failed to construct sequence from byte[]: " + e.Message);
				}
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Encodable)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object primitive = ((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object();
				if (primitive is global::Org.BouncyCastle.Asn1.Asn1Sequence)
				{
					return (global::Org.BouncyCastle.Asn1.Asn1Sequence)primitive;
				}
			}
			throw new global::System.ArgumentException("Unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x0010A05C File Offset: 0x0010825C
		public static global::Org.BouncyCastle.Asn1.Asn1Sequence GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object inner = obj.GetObject();
			if (explicitly)
			{
				if (!obj.IsExplicit())
				{
					throw new global::System.ArgumentException("object implicit - explicit expected.");
				}
				return (global::Org.BouncyCastle.Asn1.Asn1Sequence)inner;
			}
			else if (obj.IsExplicit())
			{
				if (obj is global::Org.BouncyCastle.Asn1.BerTaggedObject)
				{
					return new global::Org.BouncyCastle.Asn1.BerSequence(inner);
				}
				return new global::Org.BouncyCastle.Asn1.DerSequence(inner);
			}
			else
			{
				if (inner is global::Org.BouncyCastle.Asn1.Asn1Sequence)
				{
					return (global::Org.BouncyCastle.Asn1.Asn1Sequence)inner;
				}
				throw new global::System.ArgumentException("Unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
			}
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x0010A0D4 File Offset: 0x001082D4
		protected internal Asn1Sequence()
		{
			this.elements = global::Org.BouncyCastle.Asn1.Asn1EncodableVector.EmptyElements;
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x0010A0E7 File Offset: 0x001082E7
		protected internal Asn1Sequence(global::Org.BouncyCastle.Asn1.Asn1Encodable element)
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

		// Token: 0x0600389A RID: 14490 RVA: 0x0010A110 File Offset: 0x00108310
		protected internal Asn1Sequence(params global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements)
		{
			if (global::Org.BouncyCastle.Utilities.Arrays.IsNullOrContainsNull(elements))
			{
				throw new global::System.NullReferenceException("'elements' cannot be null, or contain null");
			}
			this.elements = global::Org.BouncyCastle.Asn1.Asn1EncodableVector.CloneElements(elements);
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x0010A144 File Offset: 0x00108344
		protected internal Asn1Sequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector elementVector)
		{
			if (elementVector == null)
			{
				throw new global::System.ArgumentNullException("elementVector");
			}
			this.elements = elementVector.TakeElements();
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x0010A166 File Offset: 0x00108366
		public virtual global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.elements.GetEnumerator();
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600389D RID: 14493 RVA: 0x0010A173 File Offset: 0x00108373
		public virtual global::Org.BouncyCastle.Asn1.Asn1SequenceParser Parser
		{
			get
			{
				return new global::Org.BouncyCastle.Asn1.Asn1Sequence.Asn1SequenceParserImpl(this);
			}
		}

		// Token: 0x17000792 RID: 1938
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable this[int index]
		{
			get
			{
				return this.elements[index];
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600389F RID: 14495 RVA: 0x0010A185 File Offset: 0x00108385
		public virtual int Count
		{
			get
			{
				return this.elements.Length;
			}
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x0010A18F File Offset: 0x0010838F
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable[] ToArray()
		{
			return global::Org.BouncyCastle.Asn1.Asn1EncodableVector.CloneElements(this.elements);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x0010A19C File Offset: 0x0010839C
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

		// Token: 0x060038A2 RID: 14498 RVA: 0x0010A1E0 File Offset: 0x001083E0
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence that = asn1Object as global::Org.BouncyCastle.Asn1.Asn1Sequence;
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

		// Token: 0x060038A3 RID: 14499 RVA: 0x0010A246 File Offset: 0x00108446
		public override string ToString()
		{
			return global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.ToString(this.elements);
		}

		// Token: 0x04001939 RID: 6457
		internal global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements;

		// Token: 0x0200084C RID: 2124
		private class Asn1SequenceParserImpl : global::Org.BouncyCastle.Asn1.Asn1SequenceParser, global::Org.BouncyCastle.Asn1.IAsn1Convertible
		{
			// Token: 0x0600474B RID: 18251 RVA: 0x0013B505 File Offset: 0x00139705
			public Asn1SequenceParserImpl(global::Org.BouncyCastle.Asn1.Asn1Sequence outer)
			{
				this.outer = outer;
				this.max = outer.Count;
			}

			// Token: 0x0600474C RID: 18252 RVA: 0x0013B520 File Offset: 0x00139720
			public global::Org.BouncyCastle.Asn1.IAsn1Convertible ReadObject()
			{
				if (this.index == this.max)
				{
					return null;
				}
				global::Org.BouncyCastle.Asn1.Asn1Sequence asn1Sequence = this.outer;
				int num = this.index;
				this.index = num + 1;
				global::Org.BouncyCastle.Asn1.Asn1Encodable obj = asn1Sequence[num];
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

			// Token: 0x0600474D RID: 18253 RVA: 0x0013B583 File Offset: 0x00139783
			public global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
			{
				return this.outer;
			}

			// Token: 0x040025BC RID: 9660
			private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence outer;

			// Token: 0x040025BD RID: 9661
			private readonly int max;

			// Token: 0x040025BE RID: 9662
			private int index;
		}
	}
}
