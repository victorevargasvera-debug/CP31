using System;
using System.IO;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002D9 RID: 729
	internal class CloseIgnoringInputStream : global::System.IO.Stream
	{
		// Token: 0x06001425 RID: 5157 RVA: 0x0003CA86 File Offset: 0x0003AC86
		public CloseIgnoringInputStream(global::System.IO.Stream stream)
		{
			this._is = stream;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0003CA95 File Offset: 0x0003AC95
		public int Read()
		{
			return this._is.ReadByte();
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0003CAA2 File Offset: 0x0003ACA2
		public override int Read(byte[] b, int off, int len)
		{
			return this._is.Read(b, off, len);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Close()
		{
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Flush()
		{
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0002C43E File Offset: 0x0002A63E
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void SetLength(long value)
		{
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0003CAB2 File Offset: 0x0003ACB2
		public override long Length
		{
			get
			{
				return this._is.Length;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0003CABF File Offset: 0x0003ACBF
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x0003CACC File Offset: 0x0003ACCC
		public override long Position
		{
			get
			{
				return this._is.Position;
			}
			set
			{
				this._is.Position = (long)global::System.Convert.ToInt32(value);
			}
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0400085C RID: 2140
		private global::System.IO.Stream _is;
	}
}
