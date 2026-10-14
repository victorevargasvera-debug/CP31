using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005DB RID: 1499
	public class Asn1EncodableVector : global::System.Collections.IEnumerable
	{
		// Token: 0x06003835 RID: 14389 RVA: 0x00108EA4 File Offset: 0x001070A4
		public static global::Org.BouncyCastle.Asn1.Asn1EncodableVector FromEnumerable(global::System.Collections.IEnumerable e)
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj2 in e)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable obj = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2;
				v.Add(obj);
			}
			return v;
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x00108F00 File Offset: 0x00107100
		public Asn1EncodableVector() : this(10)
		{
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x00108F0A File Offset: 0x0010710A
		public Asn1EncodableVector(int initialCapacity)
		{
			if (initialCapacity < 0)
			{
				throw new global::System.ArgumentException("must not be negative", "initialCapacity");
			}
			this.elements = ((initialCapacity == 0) ? global::Org.BouncyCastle.Asn1.Asn1EncodableVector.EmptyElements : new global::Org.BouncyCastle.Asn1.Asn1Encodable[initialCapacity]);
			this.elementCount = 0;
			this.copyOnWrite = false;
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00108F4A File Offset: 0x0010714A
		public Asn1EncodableVector(params global::Org.BouncyCastle.Asn1.Asn1Encodable[] v) : this()
		{
			this.Add(v);
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00108F5C File Offset: 0x0010715C
		public void Add(global::Org.BouncyCastle.Asn1.Asn1Encodable element)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			int capacity = this.elements.Length;
			int minCapacity = this.elementCount + 1;
			if (minCapacity > capacity | this.copyOnWrite)
			{
				this.Reallocate(minCapacity);
			}
			this.elements[this.elementCount] = element;
			this.elementCount = minCapacity;
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x00108FB4 File Offset: 0x001071B4
		public void Add(params global::Org.BouncyCastle.Asn1.Asn1Encodable[] objs)
		{
			foreach (global::Org.BouncyCastle.Asn1.Asn1Encodable obj in objs)
			{
				this.Add(obj);
			}
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x00108FDC File Offset: 0x001071DC
		public void AddOptional(params global::Org.BouncyCastle.Asn1.Asn1Encodable[] objs)
		{
			if (objs != null)
			{
				foreach (global::Org.BouncyCastle.Asn1.Asn1Encodable obj in objs)
				{
					if (obj != null)
					{
						this.Add(obj);
					}
				}
			}
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x0010900A File Offset: 0x0010720A
		public void AddOptionalTagged(bool isExplicit, int tagNo, global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			if (obj != null)
			{
				this.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(isExplicit, tagNo, obj));
			}
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00109020 File Offset: 0x00107220
		public void AddAll(global::Org.BouncyCastle.Asn1.Asn1EncodableVector other)
		{
			if (other == null)
			{
				throw new global::System.ArgumentNullException("other");
			}
			int otherElementCount = other.Count;
			if (otherElementCount < 1)
			{
				return;
			}
			int capacity = this.elements.Length;
			int minCapacity = this.elementCount + otherElementCount;
			if (minCapacity > capacity | this.copyOnWrite)
			{
				this.Reallocate(minCapacity);
			}
			int i = 0;
			for (;;)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable otherElement = other[i];
				if (otherElement == null)
				{
					break;
				}
				this.elements[this.elementCount + i] = otherElement;
				if (++i >= otherElementCount)
				{
					goto Block_5;
				}
			}
			throw new global::System.NullReferenceException("'other' elements cannot be null");
			Block_5:
			this.elementCount = minCapacity;
		}

		// Token: 0x1700078B RID: 1931
		public global::Org.BouncyCastle.Asn1.Asn1Encodable this[int index]
		{
			get
			{
				if (index >= this.elementCount)
				{
					throw new global::System.IndexOutOfRangeException(index.ToString() + " >= " + this.elementCount.ToString());
				}
				return this.elements[index];
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600383F RID: 14399 RVA: 0x001090DC File Offset: 0x001072DC
		public int Count
		{
			get
			{
				return this.elementCount;
			}
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x001090E4 File Offset: 0x001072E4
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.CopyElements().GetEnumerator();
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x001090F4 File Offset: 0x001072F4
		internal global::Org.BouncyCastle.Asn1.Asn1Encodable[] CopyElements()
		{
			if (this.elementCount == 0)
			{
				return global::Org.BouncyCastle.Asn1.Asn1EncodableVector.EmptyElements;
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] copy = new global::Org.BouncyCastle.Asn1.Asn1Encodable[this.elementCount];
			global::System.Array.Copy(this.elements, 0, copy, 0, this.elementCount);
			return copy;
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00109130 File Offset: 0x00107330
		internal global::Org.BouncyCastle.Asn1.Asn1Encodable[] TakeElements()
		{
			if (this.elementCount == 0)
			{
				return global::Org.BouncyCastle.Asn1.Asn1EncodableVector.EmptyElements;
			}
			if (this.elements.Length == this.elementCount)
			{
				this.copyOnWrite = true;
				return this.elements;
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] copy = new global::Org.BouncyCastle.Asn1.Asn1Encodable[this.elementCount];
			global::System.Array.Copy(this.elements, 0, copy, 0, this.elementCount);
			return copy;
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x0010918C File Offset: 0x0010738C
		private void Reallocate(int minCapacity)
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] copy = new global::Org.BouncyCastle.Asn1.Asn1Encodable[global::System.Math.Max(this.elements.Length, minCapacity + (minCapacity >> 1))];
			global::System.Array.Copy(this.elements, 0, copy, 0, this.elementCount);
			this.elements = copy;
			this.copyOnWrite = false;
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x001091D3 File Offset: 0x001073D3
		internal static global::Org.BouncyCastle.Asn1.Asn1Encodable[] CloneElements(global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements)
		{
			if (elements.Length >= 1)
			{
				return (global::Org.BouncyCastle.Asn1.Asn1Encodable[])elements.Clone();
			}
			return global::Org.BouncyCastle.Asn1.Asn1EncodableVector.EmptyElements;
		}

		// Token: 0x0400192F RID: 6447
		internal static readonly global::Org.BouncyCastle.Asn1.Asn1Encodable[] EmptyElements = new global::Org.BouncyCastle.Asn1.Asn1Encodable[0];

		// Token: 0x04001930 RID: 6448
		private const int DefaultCapacity = 10;

		// Token: 0x04001931 RID: 6449
		private global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements;

		// Token: 0x04001932 RID: 6450
		private int elementCount;

		// Token: 0x04001933 RID: 6451
		private bool copyOnWrite;
	}
}
