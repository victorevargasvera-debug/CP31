using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x02000052 RID: 82
	public class PushbackStream : global::Org.BouncyCastle.Utilities.IO.FilterStream
	{
		// Token: 0x060003B6 RID: 950 RVA: 0x00013D91 File Offset: 0x00011F91
		public PushbackStream(global::System.IO.Stream s) : base(s)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00013DA1 File Offset: 0x00011FA1
		public override int ReadByte()
		{
			if (this.buf != -1)
			{
				int result = this.buf;
				this.buf = -1;
				return result;
			}
			return base.ReadByte();
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00013DC0 File Offset: 0x00011FC0
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this.buf != -1 && count > 0)
			{
				buffer[offset] = (byte)this.buf;
				this.buf = -1;
				return 1;
			}
			return base.Read(buffer, offset, count);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00013DEB File Offset: 0x00011FEB
		public virtual void Unread(int b)
		{
			if (this.buf != -1)
			{
				throw new global::System.InvalidOperationException("Can only push back one byte");
			}
			this.buf = (b & 255);
		}

		// Token: 0x04000279 RID: 633
		private int buf = -1;
	}
}
