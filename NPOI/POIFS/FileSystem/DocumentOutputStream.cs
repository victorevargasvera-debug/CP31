using System;
using System.IO;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002DB RID: 731
	public class DocumentOutputStream : global::System.IO.MemoryStream
	{
		// Token: 0x0600144E RID: 5198 RVA: 0x0003CCB5 File Offset: 0x0003AEB5
		public DocumentOutputStream(global::System.IO.Stream stream, int limit)
		{
			this._stream = stream;
			this._limit = limit;
			this._written = 0;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0003CCD2 File Offset: 0x0003AED2
		public void Write(int b)
		{
			this.LimitCheck(1);
			this._stream.WriteByte((byte)b);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0002BC27 File Offset: 0x00029E27
		public void Write(byte[] b)
		{
			this.Write(b, 0, b.Length);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0003CCE8 File Offset: 0x0003AEE8
		public override void Write(byte[] b, int off, int len)
		{
			this.LimitCheck(len);
			this._stream.Write(b, off, len);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0003CCFF File Offset: 0x0003AEFF
		public override void Flush()
		{
			this._stream.Flush();
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Close()
		{
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0003CD0C File Offset: 0x0003AF0C
		public void WriteFiller(int totalLimit, byte Fill)
		{
			if (totalLimit > this._written)
			{
				byte[] array = new byte[totalLimit - this._written];
				global::NPOI.Util.Arrays.Fill(array, Fill);
				this._stream.Write(array, 0, array.Length);
			}
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0003CD47 File Offset: 0x0003AF47
		private void LimitCheck(int toBeWritten)
		{
			if (this._written + toBeWritten > this._limit)
			{
				throw new global::System.IO.IOException("tried to write too much data");
			}
			this._written += toBeWritten;
		}

		// Token: 0x04000862 RID: 2146
		private global::System.IO.Stream _stream;

		// Token: 0x04000863 RID: 2147
		private int _limit;

		// Token: 0x04000864 RID: 2148
		private int _written;
	}
}
