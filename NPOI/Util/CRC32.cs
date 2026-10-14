using System;
using System.IO;
using System.Text;

namespace NPOI.Util
{
	// Token: 0x02000265 RID: 613
	public class CRC32
	{
		// Token: 0x06000FE9 RID: 4073 RVA: 0x0003127C File Offset: 0x0002F47C
		public CRC32()
		{
			this.crc32Table = new ulong[256];
			for (int i = 0; i < 256; i++)
			{
				ulong num = (ulong)((long)i);
				for (int j = 8; j > 0; j--)
				{
					if ((num & 1UL) == 1UL)
					{
						num = (num >> 1 ^ (ulong)-306674912);
					}
					else
					{
						num >>= 1;
					}
				}
				this.crc32Table[i] = num;
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x000312E0 File Offset: 0x0002F4E0
		public ulong ByteCRC(ref byte[] buffer)
		{
			ulong num = (ulong)-1;
			ulong num2 = (ulong)((long)buffer.Length);
			for (ulong num3 = 0UL; num3 < num2; num3 += 1UL)
			{
				ulong num4 = num & 255UL;
				num4 ^= (ulong)buffer[(int)(checked((global::System.IntPtr)num3))];
				num >>= 8;
				num ^= this.crc32Table[(int)(checked((global::System.IntPtr)num4))];
			}
			return num ^ (ulong)-1;
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0003132C File Offset: 0x0002F52C
		public ulong StringCRC(string sInputString)
		{
			byte[] bytes = global::System.Text.Encoding.Default.GetBytes(sInputString);
			return this.ByteCRC(ref bytes);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00031350 File Offset: 0x0002F550
		public long FileCRC(string sInputFilename)
		{
			long result;
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(sInputFilename, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
			{
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				result = (long)this.ByteCRC(ref array);
			}
			return result;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x000313A8 File Offset: 0x0002F5A8
		public long StreamCRC(global::System.IO.Stream inFile)
		{
			long result;
			try
			{
				byte[] array = new byte[inFile.Length];
				inFile.Read(array, 0, array.Length);
				inFile.Close();
				result = (long)this.ByteCRC(ref array);
			}
			catch (global::System.IO.IOException)
			{
				throw;
			}
			return result;
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x000313F4 File Offset: 0x0002F5F4
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x000313FC File Offset: 0x0002F5FC
		public ulong Value { get; set; }

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00031405 File Offset: 0x0002F605
		public void Update(byte[] data)
		{
			this.Value = this.ByteCRC(ref data);
		}

		// Token: 0x04000720 RID: 1824
		protected ulong[] crc32Table;
	}
}
