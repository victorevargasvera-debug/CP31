using System;
using System.Drawing;

namespace NPOI.SS.Format
{
	// Token: 0x02000248 RID: 584
	public class CellFormatResult
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00029B92 File Offset: 0x00027D92
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00029B9A File Offset: 0x00027D9A
		public bool Applies
		{
			get
			{
				return this._applies;
			}
			set
			{
				this._applies = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00029BA3 File Offset: 0x00027DA3
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00029BAB File Offset: 0x00027DAB
		public string Text
		{
			get
			{
				return this._text;
			}
			set
			{
				this._text = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00029BB4 File Offset: 0x00027DB4
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00029BBC File Offset: 0x00027DBC
		public global::System.Drawing.Color TextColor
		{
			get
			{
				return this._textcolor;
			}
			set
			{
				this._textcolor = value;
			}
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00029BC5 File Offset: 0x00027DC5
		public CellFormatResult(bool applies, string text, global::System.Drawing.Color textColor)
		{
			if (text == null)
			{
				throw new global::System.ArgumentException("CellFormatResult text may not be null");
			}
			this.Applies = applies;
			this.Text = text;
			this.TextColor = (applies ? textColor : global::System.Drawing.Color.Empty);
		}

		// Token: 0x04000681 RID: 1665
		private bool _applies;

		// Token: 0x04000682 RID: 1666
		private string _text;

		// Token: 0x04000683 RID: 1667
		private global::System.Drawing.Color _textcolor;
	}
}
