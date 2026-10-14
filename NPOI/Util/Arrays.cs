using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NPOI.Util.Collections;

namespace NPOI.Util
{
	// Token: 0x0200025D RID: 605
	public class Arrays
	{
		// Token: 0x06000F15 RID: 3861 RVA: 0x0002C46C File Offset: 0x0002A66C
		public static void Fill(byte[] array, byte defaultValue)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = defaultValue;
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0002C48C File Offset: 0x0002A68C
		public static void Fill(char[] array, char defaultValue)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = defaultValue;
			}
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0002C4AC File Offset: 0x0002A6AC
		public static void Fill<T>(T[] array, T defaultValue)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = defaultValue;
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0002C4D0 File Offset: 0x0002A6D0
		public static void Fill(byte[] a, int fromIndex, int toIndex, byte val)
		{
			global::NPOI.Util.Arrays.RangeCheck(a.Length, fromIndex, toIndex);
			for (int i = fromIndex; i < toIndex; i++)
			{
				a[i] = val;
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0002C4F8 File Offset: 0x0002A6F8
		public static void Fill(char[] a, int fromIndex, int toIndex, char val)
		{
			global::NPOI.Util.Arrays.RangeCheck(a.Length, fromIndex, toIndex);
			for (int i = fromIndex; i < toIndex; i++)
			{
				a[i] = val;
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0002C520 File Offset: 0x0002A720
		private static void RangeCheck(int length, int fromIndex, int toIndex)
		{
			if (fromIndex > toIndex)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"fromIndex(",
					fromIndex.ToString(),
					") > toIndex(",
					toIndex.ToString(),
					")"
				}));
			}
			if (fromIndex < 0)
			{
				throw new global::System.IndexOutOfRangeException("fromIndex(" + fromIndex.ToString() + ")");
			}
			if (toIndex > length)
			{
				throw new global::System.IndexOutOfRangeException("toIndex(" + toIndex.ToString() + ")");
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0002C5B0 File Offset: 0x0002A7B0
		public static global::System.Collections.ArrayList AsList(global::System.Array arr)
		{
			if (arr.Length <= 0)
			{
				return new global::System.Collections.ArrayList();
			}
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(arr.Length);
			for (int i = 0; i < arr.Length; i++)
			{
				arrayList.Add(arr.GetValue(i));
			}
			return arrayList;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0002C5F8 File Offset: 0x0002A7F8
		public static global::System.Collections.ArrayList AsArrayList<T>(params T[] arr)
		{
			if (arr.Length == 0)
			{
				return new global::System.Collections.ArrayList();
			}
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(arr.Length);
			arrayList.AddRange(arr);
			return arrayList;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0002C613 File Offset: 0x0002A813
		public static global::System.Collections.Generic.List<T> AsList<T>(params T[] arr)
		{
			if (arr.Length == 0)
			{
				return new global::System.Collections.Generic.List<T>();
			}
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>(arr.Length);
			list.AddRange(arr);
			return list;
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0002C630 File Offset: 0x0002A830
		public static void Fill(int[] array, byte defaultValue)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (int)defaultValue;
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0002C650 File Offset: 0x0002A850
		public new static bool Equals(object a1, object b1)
		{
			if (a1 == null || b1 == null)
			{
				return false;
			}
			global::System.Array array = a1 as global::System.Array;
			global::System.Array array2 = b1 as global::System.Array;
			if (array.Length != array2.Length)
			{
				return false;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (!array.GetValue(i).Equals(array2.GetValue(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0002C6AC File Offset: 0x0002A8AC
		public static bool Equals(object[] a, object[] a2)
		{
			if (a == a2)
			{
				return true;
			}
			if (a == null || a2 == null)
			{
				return false;
			}
			int num = a.Length;
			if (a2.Length != num)
			{
				return false;
			}
			for (int i = 0; i < num; i++)
			{
				object obj = a[i];
				object obj2 = a2[i];
				if (!((obj == null) ? (obj2 == null) : obj.Equals(obj2)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0002C6FC File Offset: 0x0002A8FC
		public static void ArrayMoveWithin(object[] array, int moveFrom, int moveTo, int numToMove)
		{
			if (numToMove <= 0)
			{
				return;
			}
			if (moveFrom == moveTo)
			{
				return;
			}
			if (moveFrom < 0 || moveFrom >= array.Length)
			{
				throw new global::System.ArgumentException("The moveFrom must be a valid array index");
			}
			if (moveTo < 0 || moveTo >= array.Length)
			{
				throw new global::System.ArgumentException("The moveTo must be a valid array index");
			}
			if (moveFrom + numToMove > array.Length)
			{
				throw new global::System.ArgumentException("Asked to move more entries than the array has");
			}
			if (moveTo + numToMove > array.Length)
			{
				throw new global::System.ArgumentException("Asked to move to a position that doesn't have enough space");
			}
			object[] array2 = new object[numToMove];
			global::System.Array.Copy(array, moveFrom, array2, 0, numToMove);
			object[] array3;
			int destinationIndex;
			if (moveFrom > moveTo)
			{
				array3 = new object[moveFrom - moveTo];
				global::System.Array.Copy(array, moveTo, array3, 0, array3.Length);
				destinationIndex = moveTo + numToMove;
			}
			else
			{
				array3 = new object[moveTo - moveFrom];
				global::System.Array.Copy(array, moveFrom + numToMove, array3, 0, array3.Length);
				destinationIndex = moveFrom;
			}
			global::System.Array.Copy(array2, 0, array, moveTo, array2.Length);
			global::System.Array.Copy(array3, 0, array, destinationIndex, array3.Length);
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0002C7C4 File Offset: 0x0002A9C4
		public static byte[] CopyOf(byte[] source, int newLength)
		{
			byte[] array = new byte[newLength];
			global::System.Array.Copy(source, 0, array, 0, global::System.Math.Min(source.Length, newLength));
			return array;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0002C7EC File Offset: 0x0002A9EC
		internal static int[] CopyOfRange(int[] original, int from, int to)
		{
			int num = to - from;
			if (num < 0)
			{
				throw new global::System.ArgumentException(from.ToString() + " > " + to.ToString());
			}
			int[] array = new int[num];
			global::System.Array.Copy(original, from, array, 0, global::System.Math.Min(original.Length - from, num));
			return array;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0002C83C File Offset: 0x0002AA3C
		internal static byte[] CopyOfRange(byte[] original, int from, int to)
		{
			int num = to - from;
			if (num < 0)
			{
				throw new global::System.ArgumentException(from.ToString() + " > " + to.ToString());
			}
			byte[] array = new byte[num];
			global::System.Array.Copy(original, from, array, 0, global::System.Math.Min(original.Length - from, num));
			return array;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0002C88C File Offset: 0x0002AA8C
		public static int HashCode(long[] a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			foreach (long num2 in a)
			{
				int num3 = (int)(num2 ^ global::NPOI.Util.Operator.UnsignedRightShift(num2, 32));
				num = 31 * num + num3;
			}
			return num;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
		public static int HashCode(int[] a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			foreach (int num2 in a)
			{
				num = 31 * num + num2;
			}
			return num;
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0002C8F8 File Offset: 0x0002AAF8
		public static int HashCode(short[] a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			foreach (short num2 in a)
			{
				num = 31 * num + (int)num2;
			}
			return num;
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0002C928 File Offset: 0x0002AB28
		public static int HashCode(char[] a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			foreach (char c in a)
			{
				num = 31 * num + (int)c;
			}
			return num;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0002C958 File Offset: 0x0002AB58
		public static int HashCode(byte[] a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			foreach (byte b in a)
			{
				num = 31 * num + (int)b;
			}
			return num;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0002C988 File Offset: 0x0002AB88
		public static int HashCode(bool[] a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			foreach (bool flag in a)
			{
				num = 31 * num + (flag ? 1231 : 1237);
			}
			return num;
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0002C9C8 File Offset: 0x0002ABC8
		public static int HashCode(float[] a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			foreach (float value in a)
			{
				num = 31 * num + global::System.BitConverter.ToInt32(global::System.BitConverter.GetBytes(value), 0);
			}
			return num;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x0002CA04 File Offset: 0x0002AC04
		public static int HashCode(double[] a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			for (int i = 0; i < a.Length; i++)
			{
				long num2 = global::System.BitConverter.DoubleToInt64Bits(a[i]);
				num = 31 * num + (int)(num2 ^ global::NPOI.Util.Operator.UnsignedRightShift(num2, 32));
			}
			return num;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0002CA44 File Offset: 0x0002AC44
		public static int HashCode(object[] a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			foreach (object obj in a)
			{
				num = 31 * num + ((obj == null) ? 0 : obj.GetHashCode());
			}
			return num;
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0002CA80 File Offset: 0x0002AC80
		public static int DeepHashCode(object[] a)
		{
			if (a == null)
			{
				return 0;
			}
			int num = 1;
			foreach (object obj in a)
			{
				int num2 = 0;
				if (obj is object[])
				{
					num2 = global::NPOI.Util.Arrays.DeepHashCode((object[])obj);
				}
				else if (obj is byte[])
				{
					num2 = global::NPOI.Util.Arrays.HashCode((byte[])obj);
				}
				else if (obj is short[])
				{
					num2 = global::NPOI.Util.Arrays.HashCode((short[])obj);
				}
				else if (obj is int[])
				{
					num2 = global::NPOI.Util.Arrays.HashCode((int[])obj);
				}
				else if (obj is long[])
				{
					num2 = global::NPOI.Util.Arrays.HashCode((long[])obj);
				}
				else if (obj is char[])
				{
					num2 = global::NPOI.Util.Arrays.HashCode((char[])obj);
				}
				else if (obj is float[])
				{
					num2 = global::NPOI.Util.Arrays.HashCode((float[])obj);
				}
				else if (obj is double[])
				{
					num2 = global::NPOI.Util.Arrays.HashCode((double[])obj);
				}
				else if (obj is bool[])
				{
					num2 = global::NPOI.Util.Arrays.HashCode((bool[])obj);
				}
				else if (obj != null)
				{
					num2 = obj.GetHashCode();
				}
				num = 31 * num + num2;
			}
			return num;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0002CBA0 File Offset: 0x0002ADA0
		public static bool DeepEquals(object[] a1, object[] a2)
		{
			if (a1 == a2)
			{
				return true;
			}
			if (a1 == null || a2 == null)
			{
				return false;
			}
			int num = a1.Length;
			if (a2.Length != num)
			{
				return false;
			}
			for (int i = 0; i < num; i++)
			{
				object obj = a1[i];
				object obj2 = a2[i];
				if (obj != obj2)
				{
					if (obj == null)
					{
						return false;
					}
					if (!global::NPOI.Util.Arrays.DeepEquals0(obj, obj2))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0002CBF0 File Offset: 0x0002ADF0
		private static bool DeepEquals0(object e1, object e2)
		{
			bool result;
			if (e1 is object[] && e2 is object[])
			{
				result = global::NPOI.Util.Arrays.DeepEquals((object[])e1, (object[])e2);
			}
			else if (e1 is byte[] && e2 is byte[])
			{
				result = global::NPOI.Util.Arrays.Equals((byte[])e1, (byte[])e2);
			}
			else if (e1 is short[] && e2 is short[])
			{
				result = global::NPOI.Util.Arrays.Equals((short[])e1, (short[])e2);
			}
			else if (e1 is int[] && e2 is int[])
			{
				result = global::NPOI.Util.Arrays.Equals((int[])e1, (int[])e2);
			}
			else if (e1 is long[] && e2 is long[])
			{
				result = global::NPOI.Util.Arrays.Equals((long[])e1, (long[])e2);
			}
			else if (e1 is char[] && e2 is char[])
			{
				result = global::NPOI.Util.Arrays.Equals((char[])e1, (char[])e2);
			}
			else if (e1 is float[] && e2 is float[])
			{
				result = global::NPOI.Util.Arrays.Equals((float[])e1, (float[])e2);
			}
			else if (e1 is double[] && e2 is double[])
			{
				result = global::NPOI.Util.Arrays.Equals((double[])e1, (double[])e2);
			}
			else if (e1 is bool[] && e2 is bool[])
			{
				result = global::NPOI.Util.Arrays.Equals((bool[])e1, (bool[])e2);
			}
			else
			{
				result = e1.Equals(e2);
			}
			return result;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0002CD5C File Offset: 0x0002AF5C
		public static string ToString(long[] a)
		{
			if (a == null)
			{
				return "null";
			}
			int num = a.Length - 1;
			if (num == -1)
			{
				return "[]";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			int num2 = 0;
			for (;;)
			{
				stringBuilder.Append(a[num2]);
				if (num2 == num)
				{
					break;
				}
				stringBuilder.Append(", ");
				num2++;
			}
			return stringBuilder.Append(']').ToString();
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0002CDC0 File Offset: 0x0002AFC0
		public static string ToString(int[] a)
		{
			if (a == null)
			{
				return "null";
			}
			int num = a.Length - 1;
			if (num == -1)
			{
				return "[]";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			int num2 = 0;
			for (;;)
			{
				stringBuilder.Append(a[num2]);
				if (num2 == num)
				{
					break;
				}
				stringBuilder.Append(", ");
				num2++;
			}
			return stringBuilder.Append(']').ToString();
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0002CE24 File Offset: 0x0002B024
		public static string ToString(short[] a)
		{
			if (a == null)
			{
				return "null";
			}
			int num = a.Length - 1;
			if (num == -1)
			{
				return "[]";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			int num2 = 0;
			for (;;)
			{
				stringBuilder.Append(a[num2]);
				if (num2 == num)
				{
					break;
				}
				stringBuilder.Append(", ");
				num2++;
			}
			return stringBuilder.Append(']').ToString();
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0002CE88 File Offset: 0x0002B088
		public static string ToString(char[] a)
		{
			if (a == null)
			{
				return "null";
			}
			int num = a.Length - 1;
			if (num == -1)
			{
				return "[]";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			int num2 = 0;
			for (;;)
			{
				stringBuilder.Append(a[num2]);
				if (num2 == num)
				{
					break;
				}
				stringBuilder.Append(", ");
				num2++;
			}
			return stringBuilder.Append(']').ToString();
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0002CEEC File Offset: 0x0002B0EC
		public static string ToString(byte[] a)
		{
			if (a == null)
			{
				return "null";
			}
			int num = a.Length - 1;
			if (num == -1)
			{
				return "[]";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			int num2 = 0;
			for (;;)
			{
				stringBuilder.Append(a[num2]);
				if (num2 == num)
				{
					break;
				}
				stringBuilder.Append(", ");
				num2++;
			}
			return stringBuilder.Append(']').ToString();
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0002CF50 File Offset: 0x0002B150
		public static string ToString(bool[] a)
		{
			if (a == null)
			{
				return "null";
			}
			int num = a.Length - 1;
			if (num == -1)
			{
				return "[]";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			int num2 = 0;
			for (;;)
			{
				stringBuilder.Append(a[num2]);
				if (num2 == num)
				{
					break;
				}
				stringBuilder.Append(", ");
				num2++;
			}
			return stringBuilder.Append(']').ToString();
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0002CFB4 File Offset: 0x0002B1B4
		public static string ToString(float[] a)
		{
			if (a == null)
			{
				return "null";
			}
			int num = a.Length - 1;
			if (num == -1)
			{
				return "[]";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			int num2 = 0;
			for (;;)
			{
				stringBuilder.Append(a[num2]);
				if (num2 == num)
				{
					break;
				}
				stringBuilder.Append(", ");
				num2++;
			}
			return stringBuilder.Append(']').ToString();
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0002D018 File Offset: 0x0002B218
		public static string ToString(double[] a)
		{
			if (a == null)
			{
				return "null";
			}
			int num = a.Length - 1;
			if (num == -1)
			{
				return "[]";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			int num2 = 0;
			for (;;)
			{
				stringBuilder.Append(a[num2]);
				if (num2 == num)
				{
					break;
				}
				stringBuilder.Append(", ");
				num2++;
			}
			return stringBuilder.Append(']').ToString();
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0002D07C File Offset: 0x0002B27C
		public static string DeepToString(object[] a)
		{
			if (a == null)
			{
				return "null";
			}
			int num = 20 * a.Length;
			if (a.Length != 0 && num <= 0)
			{
				num = int.MaxValue;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(num);
			global::NPOI.Util.Arrays.DeepToString(a, stringBuilder, new global::NPOI.Util.Collections.HashSet<object[]>());
			return stringBuilder.ToString();
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0002D0C0 File Offset: 0x0002B2C0
		private static void DeepToString(object[] a, global::System.Text.StringBuilder buf, global::NPOI.Util.Collections.HashSet<object[]> dejaVu)
		{
			if (a == null)
			{
				buf.Append("null");
				return;
			}
			int num = a.Length - 1;
			if (num == -1)
			{
				buf.Append("[]");
				return;
			}
			dejaVu.Add(a);
			buf.Append('[');
			int num2 = 0;
			for (;;)
			{
				object obj = a[num2];
				if (obj == null)
				{
					buf.Append("null");
				}
				else
				{
					global::System.Type type = obj.GetType();
					if (type.IsArray)
					{
						if (type == typeof(byte[]))
						{
							buf.Append(global::NPOI.Util.Arrays.ToString((byte[])obj));
						}
						else if (type == typeof(short[]))
						{
							buf.Append(global::NPOI.Util.Arrays.ToString((short[])obj));
						}
						else if (type == typeof(int[]))
						{
							buf.Append(global::NPOI.Util.Arrays.ToString((int[])obj));
						}
						else if (type == typeof(long[]))
						{
							buf.Append(global::NPOI.Util.Arrays.ToString((long[])obj));
						}
						else if (type == typeof(char[]))
						{
							buf.Append(global::NPOI.Util.Arrays.ToString((char[])obj));
						}
						else if (type == typeof(float[]))
						{
							buf.Append(global::NPOI.Util.Arrays.ToString((float[])obj));
						}
						else if (type == typeof(double[]))
						{
							buf.Append(global::NPOI.Util.Arrays.ToString((double[])obj));
						}
						else if (type == typeof(bool[]))
						{
							buf.Append(global::NPOI.Util.Arrays.ToString((bool[])obj));
						}
						else if (dejaVu.Contains(obj as object[]))
						{
							buf.Append("[...]");
						}
						else
						{
							global::NPOI.Util.Arrays.DeepToString((object[])obj, buf, dejaVu);
						}
					}
					else
					{
						buf.Append(obj.ToString());
					}
				}
				if (num2 == num)
				{
					break;
				}
				buf.Append(", ");
				num2++;
			}
			buf.Append(']');
			dejaVu.Remove(a);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0002D2D4 File Offset: 0x0002B4D4
		public static string ToString(object[] a)
		{
			if (a == null)
			{
				return "null";
			}
			int num = a.Length - 1;
			if (num == -1)
			{
				return "[]";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append('[');
			int num2 = 0;
			for (;;)
			{
				stringBuilder.Append(a[num2].ToString());
				if (num2 == num)
				{
					break;
				}
				stringBuilder.Append(", ");
				num2++;
			}
			return stringBuilder.Append(']').ToString();
		}
	}
}
