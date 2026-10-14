using System;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000028 RID: 40
	public class PositionInParagraph
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00002FA4 File Offset: 0x000011A4
		public PositionInParagraph()
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00005018 File Offset: 0x00003218
		public PositionInParagraph(int posRun, int posText, int posChar)
		{
			this.posRun = posRun;
			this.posChar = posChar;
			this.posText = posText;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00005035 File Offset: 0x00003235
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0000503D File Offset: 0x0000323D
		public int Run
		{
			get
			{
				return this.posRun;
			}
			set
			{
				this.posRun = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00005046 File Offset: 0x00003246
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0000504E File Offset: 0x0000324E
		public int Text
		{
			get
			{
				return this.posText;
			}
			set
			{
				this.posText = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00005057 File Offset: 0x00003257
		// (set) Token: 0x06000135 RID: 309 RVA: 0x0000505F File Offset: 0x0000325F
		public int Char
		{
			get
			{
				return this.posChar;
			}
			set
			{
				this.posChar = value;
			}
		}

		// Token: 0x04000147 RID: 327
		private int posRun;

		// Token: 0x04000148 RID: 328
		private int posText;

		// Token: 0x04000149 RID: 329
		private int posChar;
	}
}
