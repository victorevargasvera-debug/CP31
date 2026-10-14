using System;
using System.Collections.Generic;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000048 RID: 72
	public class TarExtendedHeaderReader
	{
		// Token: 0x0600034D RID: 845 RVA: 0x0000FEE6 File Offset: 0x0000E0E6
		public TarExtendedHeaderReader()
		{
			this.ResetBuffers();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000FF28 File Offset: 0x0000E128
		public void Read(byte[] buffer, int length)
		{
			for (int i = 0; i < length; i++)
			{
				byte b = buffer[i];
				if (b == global::ICSharpCode.SharpZipLib.Tar.TarExtendedHeaderReader.StateNext[this.state])
				{
					this.Flush();
					this.headerParts[this.state] = this.sb.ToString();
					this.sb.Clear();
					int num = this.state + 1;
					this.state = num;
					if (num == 3)
					{
						this.headers.Add(this.headerParts[1], this.headerParts[2]);
						this.headerParts = new string[3];
						this.state = 0;
					}
				}
				else
				{
					byte[] array = this.byteBuffer;
					int num = this.bbIndex;
					this.bbIndex = num + 1;
					array[num] = b;
					if (this.bbIndex == 4)
					{
						this.Flush();
					}
				}
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		private void Flush()
		{
			int num;
			int charCount;
			bool flag;
			this.decoder.Convert(this.byteBuffer, 0, this.bbIndex, this.charBuffer, 0, 4, false, out num, out charCount, out flag);
			this.sb.Append(this.charBuffer, 0, charCount);
			this.ResetBuffers();
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001003E File Offset: 0x0000E23E
		private void ResetBuffers()
		{
			this.charBuffer = new char[4];
			this.byteBuffer = new byte[4];
			this.bbIndex = 0;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0001005F File Offset: 0x0000E25F
		public global::System.Collections.Generic.Dictionary<string, string> Headers
		{
			get
			{
				return this.headers;
			}
		}

		// Token: 0x040001E1 RID: 481
		private const byte LENGTH = 0;

		// Token: 0x040001E2 RID: 482
		private const byte KEY = 1;

		// Token: 0x040001E3 RID: 483
		private const byte VALUE = 2;

		// Token: 0x040001E4 RID: 484
		private const byte END = 3;

		// Token: 0x040001E5 RID: 485
		private readonly global::System.Collections.Generic.Dictionary<string, string> headers = new global::System.Collections.Generic.Dictionary<string, string>();

		// Token: 0x040001E6 RID: 486
		private string[] headerParts = new string[3];

		// Token: 0x040001E7 RID: 487
		private int bbIndex;

		// Token: 0x040001E8 RID: 488
		private byte[] byteBuffer;

		// Token: 0x040001E9 RID: 489
		private char[] charBuffer;

		// Token: 0x040001EA RID: 490
		private readonly global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();

		// Token: 0x040001EB RID: 491
		private readonly global::System.Text.Decoder decoder = global::System.Text.Encoding.UTF8.GetDecoder();

		// Token: 0x040001EC RID: 492
		private int state;

		// Token: 0x040001ED RID: 493
		private static readonly byte[] StateNext = new byte[]
		{
			32,
			61,
			10
		};
	}
}
