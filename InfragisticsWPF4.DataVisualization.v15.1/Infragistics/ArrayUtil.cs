using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics
{
	// Token: 0x0200006A RID: 106
	public static class ArrayUtil
	{
		// Token: 0x060005F0 RID: 1520 RVA: 0x00016E28 File Offset: 0x00015028
		public static void Shuffle<T>(this global::System.Collections.Generic.IList<T> list)
		{
			if (list != null)
			{
				global::System.Random random = new global::System.Random();
				for (int i = list.Count - 1; i > 0; i--)
				{
					int index = random.Next(i);
					T value = list[i];
					list[i] = list[index];
					list[index] = value;
				}
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00016E78 File Offset: 0x00015078
		public static int InsertionIndex<T>(this global::System.Collections.Generic.IList<T> collection, T value) where T : global::System.IComparable
		{
			int num = -1;
			int num2 = 0;
			int num3 = collection.Count;
			while (num == -1)
			{
				if (num3 <= num2)
				{
					num = num2;
				}
				else
				{
					int num4 = (num2 + num3) / 2;
					switch (global::System.Math.Sign(value.CompareTo(collection[num4])))
					{
					case -1:
						num3 = num4;
						break;
					case 0:
						num = num4;
						break;
					case 1:
						num2 = num4 + 1;
						break;
					}
				}
			}
			return num;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00016EE8 File Offset: 0x000150E8
		public static int InsertionIndex<T>(this global::System.Collections.Generic.IList<T> collection, global::System.Comparison<T> comparison, T value)
		{
			int num = -1;
			int num2 = 0;
			int num3 = collection.Count;
			while (num == -1)
			{
				if (num3 <= num2)
				{
					num = num2;
				}
				else
				{
					int num4 = (num2 + num3) / 2;
					switch (global::System.Math.Sign(comparison(value, collection[num4])))
					{
					case -1:
						num3 = num4;
						break;
					case 0:
						num = num4;
						break;
					case 1:
						num2 = num4 + 1;
						break;
					}
				}
			}
			return num;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0001720C File Offset: 0x0001540C
		public static global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>> Permute<T>(this global::System.Collections.Generic.IEnumerable<T> list, int count)
		{
			if (count == 0)
			{
				yield return new T[0];
			}
			else
			{
				foreach (T startingElement in list)
				{
					global::System.Collections.Generic.IEnumerable<T> remainingItems = list.Except(new T[]
					{
						startingElement
					});
					foreach (global::System.Collections.Generic.IEnumerable<T> permutationOfRemainder in remainingItems.Permute(count - 1))
					{
						yield return new T[]
						{
							startingElement
						}.Concat(permutationOfRemainder);
					}
				}
			}
			yield break;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00017230 File Offset: 0x00015430
		public static int BinarySearch<T>(this global::System.Collections.Generic.IList<T> list, global::System.Func<T, int> comparisonFunction)
		{
			int i = 0;
			int num = list.Count - 1;
			while (i <= num)
			{
				int num2 = i + (num - i >> 1);
				int num3 = comparisonFunction(list[num2]);
				if (num3 < 0)
				{
					num = num2 - 1;
				}
				else
				{
					if (num3 <= 0)
					{
						return num2;
					}
					i = num2 + 1;
				}
			}
			return ~i;
		}
	}
}
