using System;
using System.IO;
using NPOI.Util;

namespace NPOI.HSSF.Record.Crypto
{
	// Token: 0x0200044D RID: 1101
	public class Biff8DecryptingStream : global::NPOI.HSSF.Record.BiffHeaderInput, global::NPOI.Util.ILittleEndianInput
	{
		// Token: 0x060028AF RID: 10415 RVA: 0x0007AD7A File Offset: 0x00078F7A
		public Biff8DecryptingStream(global::System.IO.Stream in1, int InitialOffSet, global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey key)
		{
			this._rc4 = new global::NPOI.HSSF.Record.Crypto.Biff8RC4(InitialOffSet, key);
			if (in1 is global::NPOI.Util.ILittleEndianInput)
			{
				this._le = (global::NPOI.Util.ILittleEndianInput)in1;
				return;
			}
			this._le = new global::NPOI.Util.LittleEndianInputStream(in1);
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0007ADB0 File Offset: 0x00078FB0
		public int Available()
		{
			return this._le.Available();
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x0007ADC0 File Offset: 0x00078FC0
		public int ReadRecordSID()
		{
			int num = this._le.ReadUShort();
			this._rc4.SkipTwoBytes();
			this._rc4.StartRecord(num);
			return num;
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x0007ADF1 File Offset: 0x00078FF1
		public int ReadDataSize()
		{
			int result = this._le.ReadUShort();
			this._rc4.SkipTwoBytes();
			return result;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x0007AE09 File Offset: 0x00079009
		public double ReadDouble()
		{
			double num = global::System.BitConverter.Int64BitsToDouble(this.ReadLong());
			if (double.IsNaN(num))
			{
				throw new global::System.Exception("Did not expect to read NaN");
			}
			return num;
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x0007AE29 File Offset: 0x00079029
		public void ReadFully(byte[] buf)
		{
			this.ReadFully(buf, 0, buf.Length);
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x0007AE36 File Offset: 0x00079036
		public void ReadFully(byte[] buf, int off, int len)
		{
			this._le.ReadFully(buf, off, len);
			this._rc4.Xor(buf, off, len);
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x0007AE54 File Offset: 0x00079054
		public int ReadUByte()
		{
			return this.ReadByte() & 255;
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0007AE62 File Offset: 0x00079062
		public int ReadByte()
		{
			return this._rc4.XorByte(this._le.ReadUByte());
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x0007AE7A File Offset: 0x0007907A
		public int ReadUShort()
		{
			return (int)this.ReadShort() & 65535;
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x0007AE88 File Offset: 0x00079088
		public short ReadShort()
		{
			return (short)this._rc4.Xorshort(this._le.ReadUShort());
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x0007AEA1 File Offset: 0x000790A1
		public int ReadInt()
		{
			return this._rc4.XorInt(this._le.ReadInt());
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0007AEB9 File Offset: 0x000790B9
		public long ReadLong()
		{
			return this._rc4.XorLong(this._le.ReadLong());
		}

		// Token: 0x0400117E RID: 4478
		private global::NPOI.Util.ILittleEndianInput _le;

		// Token: 0x0400117F RID: 4479
		private global::NPOI.HSSF.Record.Crypto.Biff8RC4 _rc4;
	}
}
