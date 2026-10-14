using System;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200002A RID: 42
	public class TextSegment
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00005068 File Offset: 0x00003268
		public TextSegment()
		{
			this.beginPos = new global::NPOI.XWPF.UserModel.PositionInParagraph();
			this.endPos = new global::NPOI.XWPF.UserModel.PositionInParagraph();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00005088 File Offset: 0x00003288
		public TextSegment(int beginRun, int endRun, int beginText, int endText, int beginChar, int endChar)
		{
			global::NPOI.XWPF.UserModel.PositionInParagraph positionInParagraph = new global::NPOI.XWPF.UserModel.PositionInParagraph(beginRun, beginText, beginChar);
			global::NPOI.XWPF.UserModel.PositionInParagraph positionInParagraph2 = new global::NPOI.XWPF.UserModel.PositionInParagraph(endRun, endText, endChar);
			this.beginPos = positionInParagraph;
			this.endPos = positionInParagraph2;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000050BE File Offset: 0x000032BE
		public TextSegment(global::NPOI.XWPF.UserModel.PositionInParagraph beginPos, global::NPOI.XWPF.UserModel.PositionInParagraph endPos)
		{
			this.beginPos = beginPos;
			this.endPos = endPos;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000050D4 File Offset: 0x000032D4
		// (set) Token: 0x0600013A RID: 314 RVA: 0x000050DC File Offset: 0x000032DC
		public global::NPOI.XWPF.UserModel.PositionInParagraph BeginPos
		{
			get
			{
				return this.beginPos;
			}
			set
			{
				this.beginPos = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000050E5 File Offset: 0x000032E5
		public global::NPOI.XWPF.UserModel.PositionInParagraph EndPos
		{
			get
			{
				return this.endPos;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000050ED File Offset: 0x000032ED
		// (set) Token: 0x0600013D RID: 317 RVA: 0x000050FA File Offset: 0x000032FA
		public int BeginRun
		{
			get
			{
				return this.beginPos.Run;
			}
			set
			{
				this.beginPos.Run = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00005108 File Offset: 0x00003308
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00005115 File Offset: 0x00003315
		public int BeginText
		{
			get
			{
				return this.beginPos.Text;
			}
			set
			{
				this.beginPos.Text = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00005123 File Offset: 0x00003323
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00005130 File Offset: 0x00003330
		public int BeginChar
		{
			get
			{
				return this.beginPos.Char;
			}
			set
			{
				this.beginPos.Char = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000513E File Offset: 0x0000333E
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0000514B File Offset: 0x0000334B
		public int EndRun
		{
			get
			{
				return this.endPos.Run;
			}
			set
			{
				this.endPos.Run = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00005159 File Offset: 0x00003359
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00005166 File Offset: 0x00003366
		public int EndText
		{
			get
			{
				return this.endPos.Text;
			}
			set
			{
				this.endPos.Text = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00005174 File Offset: 0x00003374
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00005181 File Offset: 0x00003381
		public int EndChar
		{
			get
			{
				return this.endPos.Char;
			}
			set
			{
				this.endPos.Char = value;
			}
		}

		// Token: 0x04000150 RID: 336
		private global::NPOI.XWPF.UserModel.PositionInParagraph beginPos;

		// Token: 0x04000151 RID: 337
		private global::NPOI.XWPF.UserModel.PositionInParagraph endPos;
	}
}
