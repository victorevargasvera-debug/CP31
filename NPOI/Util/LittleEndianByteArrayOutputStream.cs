using System;
using System.Globalization;

namespace NPOI.Util
{
	// Token: 0x02000274 RID: 628
	public class LittleEndianByteArrayOutputStream : global::NPOI.Util.ILittleEndianOutput, global::NPOI.Util.IDelayableLittleEndianOutput
	{
		// Token: 0x060010A3 RID: 4259 RVA: 0x00032EC8 File Offset: 0x000310C8
		public LittleEndianByteArrayOutputStream(byte[] buf, int startOffset, int maxWriteLen)
		{
			if (startOffset < 0 || startOffset > buf.Length)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Specified startOffset (",
					startOffset.ToString(),
					") is out of allowable range (0..",
					buf.Length.ToString(),
					")"
				}));
			}
			this._buf = buf;
			this._writeIndex = startOffset;
			this._endIndex = startOffset + maxWriteLen;
			if (this._endIndex < startOffset || this._endIndex > buf.Length)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"calculated end index (",
					this._endIndex.ToString(),
					") is out of allowable range (",
					this._writeIndex.ToString(),
					"..",
					buf.Length.ToString(),
					")"
				}));
			}
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00032FAC File Offset: 0x000311AC
		public LittleEndianByteArrayOutputStream(byte[] buf, int startOffset) : this(buf, startOffset, buf.Length - startOffset)
		{
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00032FBC File Offset: 0x000311BC
		private void CheckPosition(int i)
		{
			if (i > this._endIndex - this._writeIndex)
			{
				throw new global::NPOI.Util.RuntimeException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Buffer overrun i={0};endIndex={1};writeIndex={2}", new object[]
				{
					i,
					this._endIndex,
					this._writeIndex
				}));
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0003301C File Offset: 0x0003121C
		public void WriteByte(int v)
		{
			this.CheckPosition(1);
			byte[] buf = this._buf;
			int writeIndex = this._writeIndex;
			this._writeIndex = writeIndex + 1;
			buf[writeIndex] = (byte)v;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0003304A File Offset: 0x0003124A
		public void WriteDouble(double v)
		{
			this.WriteLong(global::System.BitConverter.DoubleToInt64Bits(v));
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00033058 File Offset: 0x00031258
		public void WriteInt(int v)
		{
			this.CheckPosition(4);
			int writeIndex = this._writeIndex;
			this._buf[writeIndex++] = (byte)(v & 255);
			this._buf[writeIndex++] = (byte)(v >> 8 & 255);
			this._buf[writeIndex++] = (byte)(v >> 16 & 255);
			this._buf[writeIndex++] = (byte)(v >> 24 & 255);
			this._writeIndex = writeIndex;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000330D2 File Offset: 0x000312D2
		public void WriteLong(long v)
		{
			this.WriteInt((int)v);
			this.WriteInt((int)(v >> 32));
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000330E8 File Offset: 0x000312E8
		public void WriteShort(int v)
		{
			this.CheckPosition(2);
			int writeIndex = this._writeIndex;
			this._buf[writeIndex++] = (byte)(v & 255);
			this._buf[writeIndex++] = (byte)(v >> 8 & 255);
			this._writeIndex = writeIndex;
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00033134 File Offset: 0x00031334
		public void Write(byte[] b)
		{
			int num = b.Length;
			this.CheckPosition(num);
			global::System.Array.Copy(b, 0, this._buf, this._writeIndex, num);
			this._writeIndex += num;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0003316E File Offset: 0x0003136E
		public void Write(byte[] b, int offset, int len)
		{
			this.CheckPosition(len);
			global::System.Array.Copy(b, offset, this._buf, this._writeIndex, len);
			this._writeIndex += len;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00033199 File Offset: 0x00031399
		public int WriteIndex
		{
			get
			{
				return this._writeIndex;
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x000331A1 File Offset: 0x000313A1
		public global::NPOI.Util.ILittleEndianOutput CreateDelayedOutput(int size)
		{
			this.CheckPosition(size);
			global::NPOI.Util.ILittleEndianOutput result = new global::NPOI.Util.LittleEndianByteArrayOutputStream(this._buf, this._writeIndex, size);
			this._writeIndex += size;
			return result;
		}

		// Token: 0x0400073A RID: 1850
		private byte[] _buf;

		// Token: 0x0400073B RID: 1851
		private int _endIndex;

		// Token: 0x0400073C RID: 1852
		private int _writeIndex;
	}
}
