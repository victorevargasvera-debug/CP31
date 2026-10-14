using System;
using System.Collections.Concurrent;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000401 RID: 1025
	internal class BitVec
	{
		// Token: 0x06002FB6 RID: 12214 RVA: 0x00095714 File Offset: 0x00093914
		private BitVec()
		{
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x0009571C File Offset: 0x0009391C
		public BitVec(int length) : this(length, false)
		{
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x00095728 File Offset: 0x00093928
		public BitVec(int length, bool defaultValue)
		{
			if (length < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length", "ArgumentOutOfRange_NeedNonNegNum");
			}
			this.m_array = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool.Instance.GetArray(global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(length, 32));
			this.m_length = length;
			int num = defaultValue ? -1 : 0;
			for (int i = 0; i < this.m_array.Length; i++)
			{
				this.m_array[i] = num;
			}
			this._version = 0;
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x0009579C File Offset: 0x0009399C
		public BitVec(byte[] bytes)
		{
			if (bytes == null)
			{
				throw new global::System.ArgumentNullException("bytes");
			}
			if (bytes.Length > 268435455)
			{
				throw new global::System.ArgumentException("Argument_ArrayTooLarge", "bytes");
			}
			this.m_array = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool.Instance.GetArray(global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(bytes.Length, 4));
			this.m_length = bytes.Length * 8;
			int num = 0;
			int num2 = 0;
			while (bytes.Length - num2 >= 4)
			{
				this.m_array[num++] = ((int)(bytes[num2] & byte.MaxValue) | (int)(bytes[num2 + 1] & byte.MaxValue) << 8 | (int)(bytes[num2 + 2] & byte.MaxValue) << 16 | (int)(bytes[num2 + 3] & byte.MaxValue) << 24);
				num2 += 4;
			}
			switch (bytes.Length - num2)
			{
			case 1:
				goto IL_F4;
			case 2:
				break;
			case 3:
				this.m_array[num] = (int)(bytes[num2 + 2] & byte.MaxValue) << 16;
				break;
			default:
				goto IL_10D;
			}
			this.m_array[num] |= (int)(bytes[num2 + 1] & byte.MaxValue) << 8;
			IL_F4:
			this.m_array[num] |= (int)(bytes[num2] & byte.MaxValue);
			IL_10D:
			this._version = 0;
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x000958C0 File Offset: 0x00093AC0
		public BitVec(bool[] values)
		{
			if (values == null)
			{
				throw new global::System.ArgumentNullException("values");
			}
			this.m_array = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool.Instance.GetArray(global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(values.Length, 32));
			this.m_length = values.Length;
			for (int i = 0; i < values.Length; i++)
			{
				if (values[i])
				{
					this.m_array[i / 32] |= 1 << i % 32;
				}
			}
			this._version = 0;
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x0009593C File Offset: 0x00093B3C
		public BitVec(int[] values)
		{
			if (values == null)
			{
				throw new global::System.ArgumentNullException("values");
			}
			int num = values.Length;
			this.m_array = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool.Instance.GetArray(values.Length);
			this.m_length = values.Length * 32;
			global::System.Array.Copy(values, this.m_array, values.Length);
			this._version = 0;
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x0009599C File Offset: 0x00093B9C
		public BitVec(global::System.Data.Entity.Core.Query.InternalTrees.BitVec bits)
		{
			if (bits == null)
			{
				throw new global::System.ArgumentNullException("bits");
			}
			int arrayLength = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(bits.m_length, 32);
			this.m_array = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool.Instance.GetArray(arrayLength);
			this.m_length = bits.m_length;
			global::System.Array.Copy(bits.m_array, this.m_array, arrayLength);
			this._version = bits._version;
		}

		// Token: 0x1700096D RID: 2413
		public bool this[int index]
		{
			get
			{
				return this.Get(index);
			}
			set
			{
				this.Set(index, value);
			}
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00095A19 File Offset: 0x00093C19
		public bool Get(int index)
		{
			if (index < 0 || index >= this.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("index", "ArgumentOutOfRange_Index");
			}
			return (this.m_array[index / 32] & 1 << index % 32) != 0;
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00095A50 File Offset: 0x00093C50
		public void Set(int index, bool value)
		{
			if (index < 0 || index >= this.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("index", "ArgumentOutOfRange_Index");
			}
			if (value)
			{
				this.m_array[index / 32] |= 1 << index % 32;
			}
			else
			{
				this.m_array[index / 32] &= ~(1 << index % 32);
			}
			this._version++;
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00095AC8 File Offset: 0x00093CC8
		public void SetAll(bool value)
		{
			int num = value ? -1 : 0;
			int arrayLength = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(this.m_length, 32);
			for (int i = 0; i < arrayLength; i++)
			{
				this.m_array[i] = num;
			}
			this._version++;
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00095B10 File Offset: 0x00093D10
		public global::System.Data.Entity.Core.Query.InternalTrees.BitVec And(global::System.Data.Entity.Core.Query.InternalTrees.BitVec value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			if (this.Length != value.Length)
			{
				throw new global::System.ArgumentException("Arg_ArrayLengthsDiffer");
			}
			int arrayLength = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(this.m_length, 32);
			for (int i = 0; i < arrayLength; i++)
			{
				this.m_array[i] &= value.m_array[i];
			}
			this._version++;
			return this;
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00095B88 File Offset: 0x00093D88
		public global::System.Data.Entity.Core.Query.InternalTrees.BitVec Or(global::System.Data.Entity.Core.Query.InternalTrees.BitVec value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			if (this.Length != value.Length)
			{
				throw new global::System.ArgumentException("Arg_ArrayLengthsDiffer");
			}
			int arrayLength = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(this.m_length, 32);
			for (int i = 0; i < arrayLength; i++)
			{
				this.m_array[i] |= value.m_array[i];
			}
			this._version++;
			return this;
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00095C00 File Offset: 0x00093E00
		public global::System.Data.Entity.Core.Query.InternalTrees.BitVec Xor(global::System.Data.Entity.Core.Query.InternalTrees.BitVec value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			if (this.Length != value.Length)
			{
				throw new global::System.ArgumentException("Arg_ArrayLengthsDiffer");
			}
			int arrayLength = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(this.m_length, 32);
			for (int i = 0; i < arrayLength; i++)
			{
				this.m_array[i] ^= value.m_array[i];
			}
			this._version++;
			return this;
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x00095C78 File Offset: 0x00093E78
		public global::System.Data.Entity.Core.Query.InternalTrees.BitVec Not()
		{
			int arrayLength = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(this.m_length, 32);
			for (int i = 0; i < arrayLength; i++)
			{
				this.m_array[i] = ~this.m_array[i];
			}
			this._version++;
			return this;
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06002FC6 RID: 12230 RVA: 0x00095CBF File Offset: 0x00093EBF
		// (set) Token: 0x06002FC7 RID: 12231 RVA: 0x00095CC8 File Offset: 0x00093EC8
		public int Length
		{
			get
			{
				return this.m_length;
			}
			set
			{
				if (value < 0)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "ArgumentOutOfRange_NeedNonNegNum");
				}
				int arraySize = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArraySize(value, 32);
				if (arraySize > this.m_array.Length || arraySize + 1024 < this.m_array.Length)
				{
					int[] array = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool.Instance.GetArray(arraySize);
					global::System.Array.Copy(this.m_array, array, (arraySize > this.m_array.Length) ? this.m_array.Length : arraySize);
					global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool.Instance.PutArray(this.m_array);
					this.m_array = array;
				}
				if (value > this.m_length)
				{
					int num = global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(this.m_length, 32) - 1;
					int num2 = this.m_length % 32;
					if (num2 > 0)
					{
						this.m_array[num] &= (1 << num2) - 1;
					}
					global::System.Array.Clear(this.m_array, num + 1, arraySize - num - 1);
				}
				this.m_length = value;
				this._version++;
			}
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00095DBA File Offset: 0x00093FBA
		public static int GetArrayLength(int n, int div)
		{
			if (n <= 0)
			{
				return 0;
			}
			return (n - 1) / div + 1;
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00095DC9 File Offset: 0x00093FC9
		private static int GetArraySize(int n, int div)
		{
			uint num = global::System.Convert.ToUInt32(global::System.Data.Entity.Core.Query.InternalTrees.BitVec.GetArrayLength(n, div)) - 1U;
			uint num2 = num | num >> 1;
			uint num3 = num2 | num2 >> 2;
			uint num4 = num3 | num3 >> 4;
			uint num5 = num4 | num4 >> 8;
			return global::System.Convert.ToInt32((num5 | num5 >> 16) + 1U);
		}

		// Token: 0x04001014 RID: 4116
		private const int BitsPerInt32 = 32;

		// Token: 0x04001015 RID: 4117
		private const int BytesPerInt32 = 4;

		// Token: 0x04001016 RID: 4118
		private const int BitsPerByte = 8;

		// Token: 0x04001017 RID: 4119
		public int[] m_array;

		// Token: 0x04001018 RID: 4120
		private int m_length;

		// Token: 0x04001019 RID: 4121
		private int _version;

		// Token: 0x0400101A RID: 4122
		private const int _ShrinkThreshold = 1024;

		// Token: 0x02000A0C RID: 2572
		private class ArrayPool
		{
			// Token: 0x060060D6 RID: 24790 RVA: 0x0014BF89 File Offset: 0x0014A189
			private ArrayPool()
			{
				this.dictionary = new global::System.Collections.Concurrent.ConcurrentDictionary<int, global::System.Collections.Concurrent.ConcurrentBag<int[]>>();
			}

			// Token: 0x170010AC RID: 4268
			// (get) Token: 0x060060D7 RID: 24791 RVA: 0x0014BF9C File Offset: 0x0014A19C
			public static global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool Instance
			{
				get
				{
					return global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool.instance;
				}
			}

			// Token: 0x060060D8 RID: 24792 RVA: 0x0014BFA4 File Offset: 0x0014A1A4
			public int[] GetArray(int length)
			{
				int[] result;
				if (this.GetBag(length).TryTake(out result))
				{
					return result;
				}
				return new int[length];
			}

			// Token: 0x060060D9 RID: 24793 RVA: 0x0014BFC9 File Offset: 0x0014A1C9
			private global::System.Collections.Concurrent.ConcurrentBag<int[]> GetBag(int length)
			{
				return this.dictionary.GetOrAdd(length, (int l) => new global::System.Collections.Concurrent.ConcurrentBag<int[]>());
			}

			// Token: 0x060060DA RID: 24794 RVA: 0x0014BFF6 File Offset: 0x0014A1F6
			public void PutArray(int[] arr)
			{
				global::System.Collections.Concurrent.ConcurrentBag<int[]> bag = this.GetBag(arr.Length);
				global::System.Array.Clear(arr, 0, arr.Length);
				bag.Add(arr);
			}

			// Token: 0x04002924 RID: 10532
			private global::System.Collections.Concurrent.ConcurrentDictionary<int, global::System.Collections.Concurrent.ConcurrentBag<int[]>> dictionary;

			// Token: 0x04002925 RID: 10533
			private static readonly global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool instance = new global::System.Data.Entity.Core.Query.InternalTrees.BitVec.ArrayPool();
		}
	}
}
