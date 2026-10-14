using System;

namespace Gibraltar.Serialization
{
	// Token: 0x0200010F RID: 271
	internal sealed class UniqueStringList
	{
		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0001C8D4 File Offset: 0x0001AAD4
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x0001C8DC File Offset: 0x0001AADC
		public global::System.DateTime ReferenceTime
		{
			get
			{
				return this.m_ReferenceTime;
			}
			set
			{
				this.m_ReferenceTime = value;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0001C8E8 File Offset: 0x0001AAE8
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x0001C8F0 File Offset: 0x0001AAF0
		public long GenericFactor
		{
			get
			{
				return this.m_GenericFactor;
			}
			set
			{
				this.m_GenericFactor = value;
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0001C8FC File Offset: 0x0001AAFC
		public UniqueStringList()
		{
			int[] array = global::Gibraltar.Serialization.UniqueStringList.primeNumberList;
			int primeNumberListIndex = this.m_PrimeNumberListIndex;
			this.m_PrimeNumberListIndex = primeNumberListIndex + 1;
			this.m_BucketListCapacity = array[primeNumberListIndex];
			this.m_StringList = new string[this.m_BucketListCapacity];
			this.m_Buckets = new int[this.m_BucketListCapacity];
			this.m_LoadLimit = (int)((float)this.m_BucketListCapacity * 0.72f);
		}

		// Token: 0x17000459 RID: 1113
		public string this[int index]
		{
			get
			{
				return this.m_StringList[index];
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0001C99C File Offset: 0x0001AB9C
		public int Count
		{
			get
			{
				return this.m_StringListIndex;
			}
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
		public void Clear()
		{
			this.m_StringListIndex = 0;
			this.m_PrimeNumberListIndex = 0;
			int[] array = global::Gibraltar.Serialization.UniqueStringList.primeNumberList;
			int primeNumberListIndex = this.m_PrimeNumberListIndex;
			this.m_PrimeNumberListIndex = primeNumberListIndex + 1;
			this.m_BucketListCapacity = array[primeNumberListIndex];
			this.m_StringList = new string[this.m_BucketListCapacity];
			this.m_Buckets = new int[this.m_BucketListCapacity];
			this.m_LoadLimit = (int)((float)this.m_BucketListCapacity * 0.72f);
			global::Gibraltar.StringReference.Pack();
			global::System.GC.Collect();
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0001CA20 File Offset: 0x0001AC20
		public void Commit()
		{
			this.m_CommittedStringListIndex = this.m_StringListIndex;
			this.m_CommittedReferenceTime = this.m_ReferenceTime;
			this.m_CommittedGenericFactor = this.m_GenericFactor;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0001CA48 File Offset: 0x0001AC48
		public void Abort()
		{
			this.m_StringListIndex = this.m_CommittedStringListIndex;
			this.m_ReferenceTime = this.m_CommittedReferenceTime;
			this.m_GenericFactor = this.m_CommittedGenericFactor;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0001CA70 File Offset: 0x0001AC70
		public int AddOrGet(string value)
		{
			int bucketIndex = this.GetBucketIndex(value);
			int num = this.m_Buckets[bucketIndex];
			if (num == 0)
			{
				string[] stringList = this.m_StringList;
				int stringListIndex = this.m_StringListIndex;
				this.m_StringListIndex = stringListIndex + 1;
				stringList[stringListIndex] = value;
				this.m_Buckets[bucketIndex] = this.m_StringListIndex;
				if (this.m_StringListIndex > this.m_LoadLimit)
				{
					this.Expand();
				}
				return this.m_StringListIndex - 1;
			}
			return num - 1;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
		private void Expand()
		{
			int[] array = global::Gibraltar.Serialization.UniqueStringList.primeNumberList;
			int primeNumberListIndex = this.m_PrimeNumberListIndex;
			this.m_PrimeNumberListIndex = primeNumberListIndex + 1;
			this.m_BucketListCapacity = array[primeNumberListIndex];
			this.m_Buckets = new int[this.m_BucketListCapacity];
			string[] array2 = new string[this.m_BucketListCapacity];
			this.m_StringList.CopyTo(array2, 0);
			this.m_StringList = array2;
			this.Reindex();
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0001CB4C File Offset: 0x0001AD4C
		private void Reindex()
		{
			this.m_LoadLimit = (int)((float)this.m_BucketListCapacity * 0.72f);
			for (int i = 0; i < this.m_StringListIndex; i++)
			{
				int bucketIndex = this.GetBucketIndex(this.m_StringList[i]);
				this.m_Buckets[bucketIndex] = i + 1;
			}
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0001CBA4 File Offset: 0x0001ADA4
		private int GetBucketIndex(string value)
		{
			int num = (value.GetHashCode() & int.MaxValue) % this.m_BucketListCapacity;
			int num2 = (num > 1) ? num : 1;
			int bucketListCapacity = this.m_BucketListCapacity;
			while (0 < bucketListCapacity--)
			{
				int num3 = this.m_Buckets[num];
				if (num3 == 0)
				{
					return num;
				}
				if (string.CompareOrdinal(value, this.m_StringList[num3 - 1]) == 0)
				{
					return num;
				}
				num = (num + num2) % this.m_BucketListCapacity;
			}
			throw new global::System.InvalidOperationException("Failed to locate a bucket.");
		}

		// Token: 0x04000320 RID: 800
		private const float LoadFactor = 0.72f;

		// Token: 0x04000321 RID: 801
		private static readonly int[] primeNumberList = new int[]
		{
			389,
			1543,
			6151,
			24593,
			98317,
			196613,
			393241,
			786433,
			1572869,
			3145739,
			6291469,
			12582917,
			25165843,
			50331653,
			100663319,
			201326611,
			402653189,
			805306457,
			1610612741
		};

		// Token: 0x04000322 RID: 802
		private int m_BucketListCapacity;

		// Token: 0x04000323 RID: 803
		private int[] m_Buckets;

		// Token: 0x04000324 RID: 804
		private int m_LoadLimit;

		// Token: 0x04000325 RID: 805
		private int m_PrimeNumberListIndex;

		// Token: 0x04000326 RID: 806
		private string[] m_StringList;

		// Token: 0x04000327 RID: 807
		private int m_StringListIndex;

		// Token: 0x04000328 RID: 808
		private int m_CommittedStringListIndex;

		// Token: 0x04000329 RID: 809
		private global::System.DateTime m_ReferenceTime = global::System.DateTime.MinValue;

		// Token: 0x0400032A RID: 810
		private global::System.DateTime m_CommittedReferenceTime = global::System.DateTime.MinValue;

		// Token: 0x0400032B RID: 811
		private long m_GenericFactor = 1L;

		// Token: 0x0400032C RID: 812
		private long m_CommittedGenericFactor = 1L;
	}
}
