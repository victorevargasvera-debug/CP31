using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000259 RID: 601
	public class ByteArrayOutputStream : global::System.IO.MemoryStream
	{
		// Token: 0x06000ED0 RID: 3792 RVA: 0x0002BC0A File Offset: 0x00029E0A
		public ByteArrayOutputStream() : this(32)
		{
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0002BC14 File Offset: 0x00029E14
		public ByteArrayOutputStream(int size) : base(size)
		{
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0002BC1D File Offset: 0x00029E1D
		public virtual void Write(int b)
		{
			this.WriteByte((byte)b);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0002BC27 File Offset: 0x00029E27
		public virtual void Write(byte[] b)
		{
			this.Write(b, 0, b.Length);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0002BC34 File Offset: 0x00029E34
		public void Reset()
		{
			this.Position = 0L;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0002BC3E File Offset: 0x00029E3E
		public byte[] ToByteArray()
		{
			return this.ToArray();
		}
	}
}
