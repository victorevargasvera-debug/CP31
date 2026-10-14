using System;
using System.Reflection;

namespace Gibraltar.Serialization.Internal
{
	// Token: 0x02000110 RID: 272
	internal class ArrayEncoder<T>
	{
		// Token: 0x06000B67 RID: 2919 RVA: 0x0001CC4C File Offset: 0x0001AE4C
		public ArrayEncoder()
		{
			string text = "Read" + typeof(T).Name;
			this.m_ReadMethod = typeof(global::Gibraltar.Serialization.IFieldReader).GetMethod(text);
			this.m_WriteMethod = typeof(global::Gibraltar.Serialization.IFieldWriter).GetMethod("Write", new global::System.Type[]
			{
				typeof(T)
			});
			if (this.m_ReadMethod == null)
			{
				global::Gibraltar.ErrorNotifier.Notify(this, new global::Gibraltar.GibraltarException("Could not find method: IFieldReader." + text));
			}
			if (this.m_WriteMethod == null)
			{
				global::Gibraltar.ErrorNotifier.Notify(this, new global::Gibraltar.GibraltarException("Could not find method: IFieldWriter.Write(" + typeof(T).Name + ")"));
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0001CD18 File Offset: 0x0001AF18
		private static bool AreEqual(T left, T right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0001CD44 File Offset: 0x0001AF44
		private T ReadValue(global::Gibraltar.Serialization.IFieldReader reader)
		{
			return (T)((object)this.m_ReadMethod.Invoke(reader, new object[0]));
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0001CD60 File Offset: 0x0001AF60
		private void WriteValue(global::Gibraltar.Serialization.IFieldWriter writer, T value)
		{
			this.m_WriteMethod.Invoke(writer, new object[]
			{
				value
			});
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0001CD80 File Offset: 0x0001AF80
		public T[] Read(global::Gibraltar.Serialization.IFieldReader reader)
		{
			int num = (int)reader.ReadUInt32();
			T[] array = new T[num];
			int i = 0;
			while (i < num)
			{
				int num2 = reader.ReadInt32();
				if (num2 > 0)
				{
					T t = this.ReadValue(reader);
					for (int j = 0; j < num2; j++)
					{
						array[i++] = t;
					}
				}
				else
				{
					for (int k = num2; k < 0; k++)
					{
						T t2 = this.ReadValue(reader);
						array[i++] = t2;
					}
				}
			}
			return array;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0001CE10 File Offset: 0x0001B010
		public void Write(T[] array, global::Gibraltar.Serialization.IFieldWriter writer)
		{
			writer.Write((uint)array.Length);
			int i = 0;
			int num = i + 1;
			int num2 = 0;
			while (i < array.Length)
			{
				if (num < array.Length)
				{
					if (num2 == 0)
					{
						if (global::Gibraltar.Serialization.Internal.ArrayEncoder<T>.AreEqual(array[num], array[num - 1]))
						{
							num2 = 2;
						}
						else
						{
							num2 = -1;
						}
						num++;
					}
					else if (num2 > 0)
					{
						if (global::Gibraltar.Serialization.Internal.ArrayEncoder<T>.AreEqual(array[num], array[num - 1]))
						{
							num2++;
							num++;
						}
						else
						{
							this.WriteRun(array, writer, ref num2, ref i, ref num);
						}
					}
					else if (!global::Gibraltar.Serialization.Internal.ArrayEncoder<T>.AreEqual(array[num], array[num - 1]))
					{
						num2--;
						num++;
					}
					else
					{
						this.WriteRun(array, writer, ref num2, ref i, ref num);
					}
				}
				else
				{
					this.WriteRun(array, writer, ref num2, ref i, ref num);
				}
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0001CF04 File Offset: 0x0001B104
		private void WriteRun(T[] array, global::Gibraltar.Serialization.IFieldWriter writer, ref int runLength, ref int currentIndex, ref int peekIndex)
		{
			if (currentIndex == array.Length - 1)
			{
				runLength = -1;
			}
			writer.Write(runLength);
			if (runLength > 0)
			{
				this.WriteValue(writer, array[currentIndex]);
				currentIndex += runLength;
			}
			else
			{
				while (runLength < 0)
				{
					int num = currentIndex;
					currentIndex = num + 1;
					this.WriteValue(writer, array[num]);
					runLength++;
				}
			}
			peekIndex = currentIndex + 1;
			runLength = 0;
		}

		// Token: 0x0400032D RID: 813
		private readonly global::System.Reflection.MethodInfo m_ReadMethod;

		// Token: 0x0400032E RID: 814
		private readonly global::System.Reflection.MethodInfo m_WriteMethod;
	}
}
