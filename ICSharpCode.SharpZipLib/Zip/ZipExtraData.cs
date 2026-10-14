using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200001B RID: 27
	public sealed class ZipExtraData : global::System.IDisposable
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0000479F File Offset: 0x0000299F
		public ZipExtraData()
		{
			this.Clear();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000047AD File Offset: 0x000029AD
		public ZipExtraData(byte[] data)
		{
			if (data == null)
			{
				this._data = global::ICSharpCode.SharpZipLib.Core.Empty.Array<byte>();
				return;
			}
			this._data = data;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000047CB File Offset: 0x000029CB
		public byte[] GetEntryData()
		{
			if (this.Length > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Data exceeds maximum length");
			}
			return (byte[])this._data.Clone();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000047F5 File Offset: 0x000029F5
		public void Clear()
		{
			if (this._data == null || this._data.Length != 0)
			{
				this._data = global::ICSharpCode.SharpZipLib.Core.Empty.Array<byte>();
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00004813 File Offset: 0x00002A13
		public int Length
		{
			get
			{
				return this._data.Length;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004820 File Offset: 0x00002A20
		public global::System.IO.Stream GetStreamForTag(int tag)
		{
			global::System.IO.Stream result = null;
			if (this.Find(tag))
			{
				result = new global::System.IO.MemoryStream(this._data, this._index, this._readValueLength, false);
			}
			return result;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004854 File Offset: 0x00002A54
		public T GetData<T>() where T : class, global::ICSharpCode.SharpZipLib.Zip.ITaggedData, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			if (this.Find((int)t.TagID))
			{
				t.SetData(this._data, this._readValueStart, this._readValueLength);
				return t;
			}
			return default(T);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000048A2 File Offset: 0x00002AA2
		public int ValueLength
		{
			get
			{
				return this._readValueLength;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000048AA File Offset: 0x00002AAA
		public int CurrentReadIndex
		{
			get
			{
				return this._index;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000048B2 File Offset: 0x00002AB2
		public int UnreadCount
		{
			get
			{
				if (this._readValueStart > this._data.Length || this._readValueStart < 4)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Find must be called before calling a Read method");
				}
				return this._readValueStart + this._readValueLength - this._index;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000048EC File Offset: 0x00002AEC
		public bool Find(int headerID)
		{
			this._readValueStart = this._data.Length;
			this._readValueLength = 0;
			this._index = 0;
			int num = this._readValueStart;
			int num2 = headerID - 1;
			while (num2 != headerID && this._index < this._data.Length - 3)
			{
				num2 = this.ReadShortInternal();
				num = this.ReadShortInternal();
				if (num2 != headerID)
				{
					this._index += num;
				}
			}
			bool flag = num2 == headerID && this._index + num <= this._data.Length;
			if (flag)
			{
				this._readValueStart = this._index;
				this._readValueLength = num;
			}
			return flag;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000498A File Offset: 0x00002B8A
		public void AddEntry(global::ICSharpCode.SharpZipLib.Zip.ITaggedData taggedData)
		{
			if (taggedData == null)
			{
				throw new global::System.ArgumentNullException("taggedData");
			}
			this.AddEntry((int)taggedData.TagID, taggedData.GetData());
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000049AC File Offset: 0x00002BAC
		public void AddEntry(int headerID, byte[] fieldData)
		{
			if (headerID > 65535 || headerID < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("headerID");
			}
			int num = (fieldData == null) ? 0 : fieldData.Length;
			if (num > 65535)
			{
				throw new global::System.ArgumentOutOfRangeException("fieldData", "exceeds maximum length");
			}
			int num2 = this._data.Length + num + 4;
			if (this.Find(headerID))
			{
				num2 -= this.ValueLength + 4;
			}
			if (num2 > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Data exceeds maximum length");
			}
			this.Delete(headerID);
			byte[] array = new byte[num2];
			this._data.CopyTo(array, 0);
			int index = this._data.Length;
			this._data = array;
			this.SetShort(ref index, headerID);
			this.SetShort(ref index, num);
			if (fieldData != null)
			{
				fieldData.CopyTo(array, index);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004A6F File Offset: 0x00002C6F
		public void StartNewEntry()
		{
			this._newEntry = new global::System.IO.MemoryStream();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004A7C File Offset: 0x00002C7C
		public void AddNewEntry(int headerID)
		{
			byte[] fieldData = this._newEntry.ToArray();
			this._newEntry = null;
			this.AddEntry(headerID, fieldData);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004AA4 File Offset: 0x00002CA4
		public void AddData(byte data)
		{
			this._newEntry.WriteByte(data);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004AB2 File Offset: 0x00002CB2
		public void AddData(byte[] data)
		{
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			this._newEntry.Write(data, 0, data.Length);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004AD2 File Offset: 0x00002CD2
		public void AddLeShort(int toAdd)
		{
			this._newEntry.WriteByte((byte)toAdd);
			this._newEntry.WriteByte((byte)(toAdd >> 8));
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public void AddLeInt(int toAdd)
		{
			this.AddLeShort((int)((short)toAdd));
			this.AddLeShort((int)((short)(toAdd >> 16)));
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00004B05 File Offset: 0x00002D05
		public void AddLeLong(long toAdd)
		{
			this.AddLeInt((int)(toAdd & (long)((ulong)-1)));
			this.AddLeInt((int)(toAdd >> 32));
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004B20 File Offset: 0x00002D20
		public bool Delete(int headerID)
		{
			bool result = false;
			if (this.Find(headerID))
			{
				result = true;
				int num = this._readValueStart - 4;
				byte[] array = new byte[this._data.Length - (this.ValueLength + 4)];
				global::System.Array.Copy(this._data, 0, array, 0, num);
				int num2 = num + this.ValueLength + 4;
				global::System.Array.Copy(this._data, num2, array, num, this._data.Length - num2);
				this._data = array;
			}
			return result;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004B94 File Offset: 0x00002D94
		public long ReadLong()
		{
			this.ReadCheck(8);
			return ((long)this.ReadInt() & (long)((ulong)-1)) | (long)this.ReadInt() << 32;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004BB4 File Offset: 0x00002DB4
		public int ReadInt()
		{
			this.ReadCheck(4);
			int result = (int)this._data[this._index] + ((int)this._data[this._index + 1] << 8) + ((int)this._data[this._index + 2] << 16) + ((int)this._data[this._index + 3] << 24);
			this._index += 4;
			return result;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004C1B File Offset: 0x00002E1B
		public int ReadShort()
		{
			this.ReadCheck(2);
			int result = (int)this._data[this._index] + ((int)this._data[this._index + 1] << 8);
			this._index += 2;
			return result;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004C54 File Offset: 0x00002E54
		public int ReadByte()
		{
			int result = -1;
			if (this._index < this._data.Length && this._readValueStart + this._readValueLength > this._index)
			{
				result = (int)this._data[this._index];
				this._index++;
			}
			return result;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004CA5 File Offset: 0x00002EA5
		public void Skip(int amount)
		{
			this.ReadCheck(amount);
			this._index += amount;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004CBC File Offset: 0x00002EBC
		private void ReadCheck(int length)
		{
			if (this._readValueStart > this._data.Length || this._readValueStart < 4)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Find must be called before calling a Read method");
			}
			if (this._index > this._readValueStart + this._readValueLength - length)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("End of extra data");
			}
			if (this._index + length < 4)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot read before start of tag");
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004D28 File Offset: 0x00002F28
		private int ReadShortInternal()
		{
			if (this._index > this._data.Length - 2)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("End of extra data");
			}
			int result = (int)this._data[this._index] + ((int)this._data[this._index + 1] << 8);
			this._index += 2;
			return result;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004D7F File Offset: 0x00002F7F
		private void SetShort(ref int index, int source)
		{
			this._data[index] = (byte)source;
			this._data[index + 1] = (byte)(source >> 8);
			index += 2;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004DA1 File Offset: 0x00002FA1
		public void Dispose()
		{
			if (this._newEntry != null)
			{
				this._newEntry.Dispose();
			}
		}

		// Token: 0x040000B1 RID: 177
		private int _index;

		// Token: 0x040000B2 RID: 178
		private int _readValueStart;

		// Token: 0x040000B3 RID: 179
		private int _readValueLength;

		// Token: 0x040000B4 RID: 180
		private global::System.IO.MemoryStream _newEntry;

		// Token: 0x040000B5 RID: 181
		private byte[] _data;
	}
}
