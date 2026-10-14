using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x0200026D RID: 621
	public class FileInputStream : global::NPOI.Util.InputStream
	{
		// Token: 0x06001047 RID: 4167 RVA: 0x000320E5 File Offset: 0x000302E5
		public FileInputStream(global::System.IO.Stream fs)
		{
			this.inner = fs;
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x000320F4 File Offset: 0x000302F4
		public override bool CanRead
		{
			get
			{
				return this.inner.CanRead;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x00032101 File Offset: 0x00030301
		public override long Length
		{
			get
			{
				return this.inner.Length;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0003210E File Offset: 0x0003030E
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x0003211B File Offset: 0x0003031B
		public override long Position
		{
			get
			{
				return this.inner.Position;
			}
			set
			{
				this.inner.Position = value;
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void Flush()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00032129 File Offset: 0x00030329
		public override int Read()
		{
			return this.inner.ReadByte();
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00008C75 File Offset: 0x00006E75
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00032136 File Offset: 0x00030336
		public override void Close()
		{
			if (this.inner != null)
			{
				this.inner.Close();
			}
		}

		// Token: 0x0400072C RID: 1836
		private global::System.IO.Stream inner;
	}
}
