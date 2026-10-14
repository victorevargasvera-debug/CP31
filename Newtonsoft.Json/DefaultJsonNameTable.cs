using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x0200000F RID: 15
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class DefaultJsonNameTable : global::Newtonsoft.Json.JsonNameTable
	{
		// Token: 0x0600000E RID: 14 RVA: 0x000020E8 File Offset: 0x000002E8
		public DefaultJsonNameTable()
		{
			this._entries = new global::Newtonsoft.Json.DefaultJsonNameTable.Entry[this._mask + 1];
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000210C File Offset: 0x0000030C
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override string Get(char[] key, int start, int length)
		{
			if (length == 0)
			{
				return string.Empty;
			}
			int num = length + global::Newtonsoft.Json.DefaultJsonNameTable.HashCodeRandomizer;
			num += (num << 7 ^ (int)key[start]);
			int num2 = start + length;
			for (int i = start + 1; i < num2; i++)
			{
				num += (num << 7 ^ (int)key[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			int num3 = num & this._mask;
			for (global::Newtonsoft.Json.DefaultJsonNameTable.Entry entry = this._entries[num3]; entry != null; entry = entry.Next)
			{
				if (entry.HashCode == num && global::Newtonsoft.Json.DefaultJsonNameTable.TextEquals(entry.Value, key, start, length))
				{
					return entry.Value;
				}
			}
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021AC File Offset: 0x000003AC
		public string Add(string key)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			int length = key.Length;
			if (length == 0)
			{
				return string.Empty;
			}
			int num = length + global::Newtonsoft.Json.DefaultJsonNameTable.HashCodeRandomizer;
			for (int i = 0; i < key.Length; i++)
			{
				num += (num << 7 ^ (int)key[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			for (global::Newtonsoft.Json.DefaultJsonNameTable.Entry entry = this._entries[num & this._mask]; entry != null; entry = entry.Next)
			{
				if (entry.HashCode == num && entry.Value.Equals(key, global::System.StringComparison.Ordinal))
				{
					return entry.Value;
				}
			}
			return this.AddEntry(key, num);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002258 File Offset: 0x00000458
		private string AddEntry(string str, int hashCode)
		{
			int num = hashCode & this._mask;
			global::Newtonsoft.Json.DefaultJsonNameTable.Entry entry = new global::Newtonsoft.Json.DefaultJsonNameTable.Entry(str, hashCode, this._entries[num]);
			this._entries[num] = entry;
			int count = this._count;
			this._count = count + 1;
			if (count == this._mask)
			{
				this.Grow();
			}
			return entry.Value;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022AC File Offset: 0x000004AC
		private void Grow()
		{
			global::Newtonsoft.Json.DefaultJsonNameTable.Entry[] entries = this._entries;
			int num = this._mask * 2 + 1;
			global::Newtonsoft.Json.DefaultJsonNameTable.Entry[] array = new global::Newtonsoft.Json.DefaultJsonNameTable.Entry[num + 1];
			foreach (global::Newtonsoft.Json.DefaultJsonNameTable.Entry entry in entries)
			{
				while (entry != null)
				{
					int num2 = entry.HashCode & num;
					global::Newtonsoft.Json.DefaultJsonNameTable.Entry next = entry.Next;
					entry.Next = array[num2];
					array[num2] = entry;
					entry = next;
				}
			}
			this._entries = array;
			this._mask = num;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002324 File Offset: 0x00000524
		private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length)
		{
			if (str1.Length != str2Length)
			{
				return false;
			}
			for (int i = 0; i < str1.Length; i++)
			{
				if (str1[i] != str2[str2Start + i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000014 RID: 20
		private static readonly int HashCodeRandomizer = global::System.Environment.TickCount;

		// Token: 0x04000015 RID: 21
		private int _count;

		// Token: 0x04000016 RID: 22
		private global::Newtonsoft.Json.DefaultJsonNameTable.Entry[] _entries;

		// Token: 0x04000017 RID: 23
		private int _mask = 31;

		// Token: 0x02000114 RID: 276
		[global::System.Runtime.CompilerServices.Nullable(0)]
		private class Entry
		{
			// Token: 0x06000DDA RID: 3546 RVA: 0x00036EE8 File Offset: 0x000350E8
			internal Entry(string value, int hashCode, global::Newtonsoft.Json.DefaultJsonNameTable.Entry next)
			{
				this.Value = value;
				this.HashCode = hashCode;
				this.Next = next;
			}

			// Token: 0x0400045D RID: 1117
			internal readonly string Value;

			// Token: 0x0400045E RID: 1118
			internal readonly int HashCode;

			// Token: 0x0400045F RID: 1119
			internal global::Newtonsoft.Json.DefaultJsonNameTable.Entry Next;
		}
	}
}
