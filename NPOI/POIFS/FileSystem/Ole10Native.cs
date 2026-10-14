using System;
using System.IO;
using System.Text;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002EC RID: 748
	public class Ole10Native
	{
		// Token: 0x0600155E RID: 5470 RVA: 0x0003FFC7 File Offset: 0x0003E1C7
		public static global::NPOI.POIFS.FileSystem.Ole10Native CreateFromEmbeddedOleObject(global::NPOI.POIFS.FileSystem.POIFSFileSystem poifs)
		{
			return global::NPOI.POIFS.FileSystem.Ole10Native.CreateFromEmbeddedOleObject(poifs.Root);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0003FFD4 File Offset: 0x0003E1D4
		public static global::NPOI.POIFS.FileSystem.Ole10Native CreateFromEmbeddedOleObject(global::NPOI.POIFS.FileSystem.DirectoryNode directory)
		{
			global::NPOI.POIFS.FileSystem.DocumentEntry documentEntry = (global::NPOI.POIFS.FileSystem.DocumentEntry)directory.GetEntry(global::NPOI.POIFS.FileSystem.Ole10Native.OLE10_NATIVE);
			byte[] array = new byte[documentEntry.Size];
			directory.CreateDocumentInputStream(documentEntry).Read(array);
			return new global::NPOI.POIFS.FileSystem.Ole10Native(array, 0);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00040013 File Offset: 0x0003E213
		public Ole10Native(string label, string filename, string command, byte[] data)
		{
			this.Label = label;
			this.FileName = filename;
			this.Command = command;
			this.DataBuffer = data;
			this.mode = global::NPOI.POIFS.FileSystem.Ole10Native.EncodingMode.parsed;
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00040050 File Offset: 0x0003E250
		public Ole10Native(byte[] data, int offset)
		{
			if (data.Length < offset + 2)
			{
				throw new global::NPOI.POIFS.FileSystem.Ole10NativeException("data is too small");
			}
			this.totalSize = global::NPOI.Util.LittleEndian.GetInt(data, offset);
			int num = offset + 4;
			this.mode = global::NPOI.POIFS.FileSystem.Ole10Native.EncodingMode.unparsed;
			if (global::NPOI.Util.LittleEndian.GetShort(data, num) == 2)
			{
				if (char.IsControl((char)data[num + 2]))
				{
					this.mode = global::NPOI.POIFS.FileSystem.Ole10Native.EncodingMode.compact;
				}
				else
				{
					this.mode = global::NPOI.POIFS.FileSystem.Ole10Native.EncodingMode.parsed;
				}
			}
			int num2 = 0;
			switch (this.mode)
			{
			case global::NPOI.POIFS.FileSystem.Ole10Native.EncodingMode.parsed:
			{
				this.flags1 = global::NPOI.Util.LittleEndian.GetShort(data, num);
				num += 2;
				int num3 = global::NPOI.POIFS.FileSystem.Ole10Native.GetStringLength(data, num);
				this.label = global::NPOI.Util.StringUtil.GetFromCompressedUnicode(data, num, num3 - 1);
				num += num3;
				num3 = global::NPOI.POIFS.FileSystem.Ole10Native.GetStringLength(data, num);
				this.fileName = global::NPOI.Util.StringUtil.GetFromCompressedUnicode(data, num, num3 - 1);
				num += num3;
				this.flags2 = global::NPOI.Util.LittleEndian.GetShort(data, num);
				num += 2;
				this.unknown1 = global::NPOI.Util.LittleEndian.GetShort(data, num);
				num += 2;
				num3 = global::NPOI.Util.LittleEndian.GetInt(data, num);
				num += 4;
				this.command = global::NPOI.Util.StringUtil.GetFromCompressedUnicode(data, num, num3 - 1);
				num += num3;
				if (this.totalSize < num)
				{
					throw new global::NPOI.POIFS.FileSystem.Ole10NativeException("Invalid Ole10Native");
				}
				num2 = global::NPOI.Util.LittleEndian.GetInt(data, num);
				num += 4;
				if (num2 < 0 || this.totalSize - (num - 4) < num2)
				{
					throw new global::NPOI.POIFS.FileSystem.Ole10NativeException("Invalid Ole10Native");
				}
				break;
			}
			case global::NPOI.POIFS.FileSystem.Ole10Native.EncodingMode.unparsed:
				num2 = this.totalSize;
				break;
			case global::NPOI.POIFS.FileSystem.Ole10Native.EncodingMode.compact:
				this.flags1 = global::NPOI.Util.LittleEndian.GetShort(data, num);
				num += 2;
				num2 = this.totalSize - 2;
				break;
			}
			this.dataBuffer = new byte[num2];
			global::System.Array.Copy(data, num, this.dataBuffer, 0, num2);
			num += num2;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000401F0 File Offset: 0x0003E3F0
		private static int GetStringLength(byte[] data, int ofs)
		{
			int num = 0;
			while (num + ofs < data.Length && data[ofs + num] != 0)
			{
				num++;
			}
			return num + 1;
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x00040219 File Offset: 0x0003E419
		public int TotalSize
		{
			get
			{
				return this.totalSize;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x00040221 File Offset: 0x0003E421
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x00040229 File Offset: 0x0003E429
		public short Flags1
		{
			get
			{
				return this.flags1;
			}
			set
			{
				this.flags1 = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00040232 File Offset: 0x0003E432
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x0004023A File Offset: 0x0003E43A
		public string Label
		{
			get
			{
				return this.label;
			}
			set
			{
				this.label = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00040243 File Offset: 0x0003E443
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x0004024B File Offset: 0x0003E44B
		public string FileName
		{
			get
			{
				return this.fileName;
			}
			set
			{
				this.fileName = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00040254 File Offset: 0x0003E454
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x0004025C File Offset: 0x0003E45C
		public short Flags2
		{
			get
			{
				return this.flags2;
			}
			set
			{
				this.flags2 = value;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00040265 File Offset: 0x0003E465
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x0004026D File Offset: 0x0003E46D
		public short Unknown1
		{
			get
			{
				return this.unknown1;
			}
			set
			{
				this.unknown1 = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00040276 File Offset: 0x0003E476
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x0004027E File Offset: 0x0003E47E
		public string Command
		{
			get
			{
				return this.command;
			}
			set
			{
				this.command = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x00040287 File Offset: 0x0003E487
		public int DataSize
		{
			get
			{
				return this.dataBuffer.Length;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00040291 File Offset: 0x0003E491
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x00040299 File Offset: 0x0003E499
		public byte[] DataBuffer
		{
			get
			{
				return this.dataBuffer;
			}
			set
			{
				this.dataBuffer = (byte[])value.Clone();
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x000402AC File Offset: 0x0003E4AC
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x000402B4 File Offset: 0x0003E4B4
		public short Flags3
		{
			get
			{
				return this.flags3;
			}
			set
			{
				this.flags3 = value;
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000402C0 File Offset: 0x0003E4C0
		public void WriteOut(global::System.IO.Stream out1)
		{
			new byte[4];
			new byte[2];
			new byte[4];
			global::NPOI.Util.LittleEndianOutputStream littleEndianOutputStream = new global::NPOI.Util.LittleEndianOutputStream(out1);
			switch (this.mode)
			{
			case global::NPOI.POIFS.FileSystem.Ole10Native.EncodingMode.parsed:
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				global::NPOI.Util.LittleEndianOutputStream littleEndianOutputStream2 = new global::NPOI.Util.LittleEndianOutputStream(memoryStream);
				littleEndianOutputStream2.WriteShort((int)this.Flags1);
				littleEndianOutputStream2.Write(global::System.Text.Encoding.GetEncoding(global::NPOI.POIFS.FileSystem.Ole10Native.ISO1).GetBytes(this.Label));
				littleEndianOutputStream2.WriteByte(0);
				littleEndianOutputStream2.Write(global::System.Text.Encoding.GetEncoding(global::NPOI.POIFS.FileSystem.Ole10Native.ISO1).GetBytes(this.FileName));
				littleEndianOutputStream2.WriteByte(0);
				littleEndianOutputStream2.WriteShort((int)this.Flags2);
				littleEndianOutputStream2.WriteShort((int)this.Unknown1);
				littleEndianOutputStream2.WriteInt(this.Command.Length + 1);
				littleEndianOutputStream2.Write(global::System.Text.Encoding.GetEncoding(global::NPOI.POIFS.FileSystem.Ole10Native.ISO1).GetBytes(this.Command));
				littleEndianOutputStream2.WriteByte(0);
				littleEndianOutputStream2.WriteInt(this.DataSize);
				littleEndianOutputStream2.Write(this.DataBuffer);
				littleEndianOutputStream2.WriteShort((int)this.Flags3);
				littleEndianOutputStream.WriteInt((int)memoryStream.Length);
				memoryStream.WriteTo(out1);
				return;
			}
			case global::NPOI.POIFS.FileSystem.Ole10Native.EncodingMode.compact:
				littleEndianOutputStream.WriteInt(this.DataSize + 2);
				littleEndianOutputStream.WriteShort((int)this.Flags1);
				out1.Write(this.DataBuffer, 0, this.DataBuffer.Length);
				return;
			}
			littleEndianOutputStream.WriteInt(this.DataSize);
			out1.Write(this.DataBuffer, 0, this.DataBuffer.Length);
		}

		// Token: 0x0400089C RID: 2204
		public static string OLE10_NATIVE = "\u0001Ole10Native";

		// Token: 0x0400089D RID: 2205
		protected static string ISO1 = "ISO-8859-1";

		// Token: 0x0400089E RID: 2206
		private int totalSize;

		// Token: 0x0400089F RID: 2207
		private short flags1 = 2;

		// Token: 0x040008A0 RID: 2208
		private string label;

		// Token: 0x040008A1 RID: 2209
		private string fileName;

		// Token: 0x040008A2 RID: 2210
		private short flags2;

		// Token: 0x040008A3 RID: 2211
		private short unknown1 = 3;

		// Token: 0x040008A4 RID: 2212
		private string command;

		// Token: 0x040008A5 RID: 2213
		private byte[] dataBuffer;

		// Token: 0x040008A6 RID: 2214
		private short flags3;

		// Token: 0x040008A7 RID: 2215
		private global::NPOI.POIFS.FileSystem.Ole10Native.EncodingMode mode;

		// Token: 0x020005B0 RID: 1456
		private enum EncodingMode
		{
			// Token: 0x0400193F RID: 6463
			parsed,
			// Token: 0x04001940 RID: 6464
			unparsed,
			// Token: 0x04001941 RID: 6465
			compact
		}
	}
}
