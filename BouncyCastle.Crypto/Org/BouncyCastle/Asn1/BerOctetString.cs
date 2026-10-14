using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005F2 RID: 1522
	public class BerOctetString : global::Org.BouncyCastle.Asn1.DerOctetString, global::System.Collections.IEnumerable
	{
		// Token: 0x060038EC RID: 14572 RVA: 0x0010AFF8 File Offset: 0x001091F8
		public static global::Org.BouncyCastle.Asn1.BerOctetString FromSequence(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int count = seq.Count;
			global::Org.BouncyCastle.Asn1.Asn1OctetString[] v = new global::Org.BouncyCastle.Asn1.Asn1OctetString[count];
			for (int i = 0; i < count; i++)
			{
				v[i] = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[i]);
			}
			return new global::Org.BouncyCastle.Asn1.BerOctetString(v);
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x0010B034 File Offset: 0x00109234
		internal static byte[] FlattenOctetStrings(global::Org.BouncyCastle.Asn1.Asn1OctetString[] octetStrings)
		{
			int count = octetStrings.Length;
			if (count == 0)
			{
				return global::Org.BouncyCastle.Asn1.Asn1OctetString.EmptyOctets;
			}
			if (count != 1)
			{
				int totalOctets = 0;
				for (int i = 0; i < count; i++)
				{
					totalOctets += octetStrings[i].str.Length;
				}
				byte[] str = new byte[totalOctets];
				int pos = 0;
				for (int j = 0; j < count; j++)
				{
					byte[] octets = octetStrings[j].str;
					global::System.Array.Copy(octets, 0, str, pos, octets.Length);
					pos += octets.Length;
				}
				return str;
			}
			return octetStrings[0].str;
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x0010B0B8 File Offset: 0x001092B8
		private static global::Org.BouncyCastle.Asn1.Asn1OctetString[] ToOctetStringArray(global::System.Collections.IEnumerable e)
		{
			global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(e);
			int count = list.Count;
			global::Org.BouncyCastle.Asn1.Asn1OctetString[] v = new global::Org.BouncyCastle.Asn1.Asn1OctetString[count];
			for (int i = 0; i < count; i++)
			{
				v[i] = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(list[i]);
			}
			return v;
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x0010B0F6 File Offset: 0x001092F6
		[global::System.Obsolete("Will be removed")]
		public BerOctetString(global::System.Collections.IEnumerable e) : this(global::Org.BouncyCastle.Asn1.BerOctetString.ToOctetStringArray(e))
		{
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x0010B104 File Offset: 0x00109304
		public BerOctetString(byte[] str) : this(str, 1000)
		{
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x0010B112 File Offset: 0x00109312
		public BerOctetString(global::Org.BouncyCastle.Asn1.Asn1OctetString[] elements) : this(elements, 1000)
		{
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x0010B120 File Offset: 0x00109320
		public BerOctetString(byte[] str, int segmentLimit) : this(str, null, segmentLimit)
		{
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x0010B12B File Offset: 0x0010932B
		public BerOctetString(global::Org.BouncyCastle.Asn1.Asn1OctetString[] elements, int segmentLimit) : this(global::Org.BouncyCastle.Asn1.BerOctetString.FlattenOctetStrings(elements), elements, segmentLimit)
		{
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x0010B13B File Offset: 0x0010933B
		private BerOctetString(byte[] octets, global::Org.BouncyCastle.Asn1.Asn1OctetString[] elements, int segmentLimit) : base(octets)
		{
			this.elements = elements;
			this.segmentLimit = segmentLimit;
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x0010B152 File Offset: 0x00109352
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			if (this.elements == null)
			{
				return new global::Org.BouncyCastle.Asn1.BerOctetString.ChunkEnumerator(this.str, this.segmentLimit);
			}
			return this.elements.GetEnumerator();
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x0010B179 File Offset: 0x00109379
		[global::System.Obsolete("Use GetEnumerator() instead")]
		public global::System.Collections.IEnumerator GetObjects()
		{
			return this.GetEnumerator();
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x0010B181 File Offset: 0x00109381
		private bool IsConstructed
		{
			get
			{
				return this.elements != null || this.str.Length > this.segmentLimit;
			}
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x0010B19D File Offset: 0x0010939D
		internal override int EncodedLength(bool withID)
		{
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("BerOctetString.EncodedLength");
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x0010B1AC File Offset: 0x001093AC
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			if (!asn1Out.IsBer || !this.IsConstructed)
			{
				base.Encode(asn1Out, withID);
				return;
			}
			asn1Out.WriteIdentifier(withID, 36);
			asn1Out.WriteByte(128);
			if (this.elements != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object[] primitives = this.elements;
				asn1Out.WritePrimitives(primitives);
			}
			else
			{
				int segmentLength;
				for (int pos = 0; pos < this.str.Length; pos += segmentLength)
				{
					segmentLength = global::System.Math.Min(this.str.Length - pos, this.segmentLimit);
					global::Org.BouncyCastle.Asn1.DerOctetString.Encode(asn1Out, true, this.str, pos, segmentLength);
				}
			}
			asn1Out.WriteByte(0);
			asn1Out.WriteByte(0);
		}

		// Token: 0x0400196E RID: 6510
		private const int DefaultSegmentLimit = 1000;

		// Token: 0x0400196F RID: 6511
		private readonly int segmentLimit;

		// Token: 0x04001970 RID: 6512
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString[] elements;

		// Token: 0x0200084F RID: 2127
		private class ChunkEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06004753 RID: 18259 RVA: 0x0013B68C File Offset: 0x0013988C
			internal ChunkEnumerator(byte[] octets, int segmentLimit)
			{
				this.octets = octets;
				this.segmentLimit = segmentLimit;
			}

			// Token: 0x17000ABC RID: 2748
			// (get) Token: 0x06004754 RID: 18260 RVA: 0x0013B6A2 File Offset: 0x001398A2
			public object Current
			{
				get
				{
					if (this.currentSegment == null)
					{
						throw new global::System.InvalidOperationException();
					}
					return this.currentSegment;
				}
			}

			// Token: 0x06004755 RID: 18261 RVA: 0x0013B6B8 File Offset: 0x001398B8
			public bool MoveNext()
			{
				if (this.nextSegmentPos >= this.octets.Length)
				{
					this.currentSegment = null;
					return false;
				}
				int length = global::System.Math.Min(this.octets.Length - this.nextSegmentPos, this.segmentLimit);
				byte[] segment = new byte[length];
				global::System.Array.Copy(this.octets, this.nextSegmentPos, segment, 0, length);
				this.currentSegment = new global::Org.BouncyCastle.Asn1.DerOctetString(segment);
				this.nextSegmentPos += length;
				return true;
			}

			// Token: 0x06004756 RID: 18262 RVA: 0x0013B72F File Offset: 0x0013992F
			public void Reset()
			{
				this.currentSegment = null;
				this.nextSegmentPos = 0;
			}

			// Token: 0x040025C2 RID: 9666
			private readonly byte[] octets;

			// Token: 0x040025C3 RID: 9667
			private readonly int segmentLimit;

			// Token: 0x040025C4 RID: 9668
			private global::Org.BouncyCastle.Asn1.DerOctetString currentSegment;

			// Token: 0x040025C5 RID: 9669
			private int nextSegmentPos;
		}
	}
}
