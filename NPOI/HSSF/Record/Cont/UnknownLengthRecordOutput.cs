using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Cont
{
	// Token: 0x02000454 RID: 1108
	internal class UnknownLengthRecordOutput : global::NPOI.Util.ILittleEndianOutput
	{
		// Token: 0x060028F7 RID: 10487 RVA: 0x0007BBD4 File Offset: 0x00079DD4
		public UnknownLengthRecordOutput(global::NPOI.Util.ILittleEndianOutput out1, int sid)
		{
			this._originalOut = out1;
			out1.WriteShort(sid);
			if (out1 is global::NPOI.Util.IDelayableLittleEndianOutput)
			{
				global::NPOI.Util.IDelayableLittleEndianOutput delayableLittleEndianOutput = (global::NPOI.Util.IDelayableLittleEndianOutput)out1;
				this._dataSizeOutput = delayableLittleEndianOutput.CreateDelayedOutput(2);
				this._byteBuffer = null;
				this._out = out1;
				return;
			}
			this._dataSizeOutput = out1;
			this._byteBuffer = new byte[8224];
			this._out = new global::NPOI.Util.LittleEndianByteArrayOutputStream(this._byteBuffer, 0);
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x0007BC49 File Offset: 0x00079E49
		public int TotalSize
		{
			get
			{
				return 4 + this._size;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x0007BC53 File Offset: 0x00079E53
		public int AvailableSpace
		{
			get
			{
				if (this._out == null)
				{
					throw new global::System.InvalidOperationException("Record already terminated");
				}
				return 8224 - this._size;
			}
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x0007BC74 File Offset: 0x00079E74
		public void Terminate()
		{
			if (this._out == null)
			{
				throw new global::System.InvalidOperationException("Record already terminated");
			}
			this._dataSizeOutput.WriteShort(this._size);
			if (this._byteBuffer != null)
			{
				this._originalOut.Write(this._byteBuffer, 0, this._size);
				this._out = null;
				return;
			}
			this._out = null;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x0007BCD4 File Offset: 0x00079ED4
		public void Write(byte[] b)
		{
			this._out.Write(b);
			this._size += b.Length;
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x0007BCF2 File Offset: 0x00079EF2
		public void Write(byte[] b, int offset, int len)
		{
			this._out.Write(b, offset, len);
			this._size += len;
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x0007BD10 File Offset: 0x00079F10
		public void WriteByte(int v)
		{
			this._out.WriteByte(v);
			this._size++;
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x0007BD2C File Offset: 0x00079F2C
		public void WriteDouble(double v)
		{
			this._out.WriteDouble(v);
			this._size += 8;
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x0007BD48 File Offset: 0x00079F48
		public void WriteInt(int v)
		{
			this._out.WriteInt(v);
			this._size += 4;
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x0007BD64 File Offset: 0x00079F64
		public void WriteLong(long v)
		{
			this._out.WriteLong(v);
			this._size += 8;
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x0007BD80 File Offset: 0x00079F80
		public void WriteShort(int v)
		{
			this._out.WriteShort(v);
			this._size += 2;
		}

		// Token: 0x04001193 RID: 4499
		private const int MAX_DATA_SIZE = 8224;

		// Token: 0x04001194 RID: 4500
		private global::NPOI.Util.ILittleEndianOutput _originalOut;

		// Token: 0x04001195 RID: 4501
		private global::NPOI.Util.ILittleEndianOutput _dataSizeOutput;

		// Token: 0x04001196 RID: 4502
		private byte[] _byteBuffer;

		// Token: 0x04001197 RID: 4503
		private global::NPOI.Util.ILittleEndianOutput _out;

		// Token: 0x04001198 RID: 4504
		private int _size;
	}
}
