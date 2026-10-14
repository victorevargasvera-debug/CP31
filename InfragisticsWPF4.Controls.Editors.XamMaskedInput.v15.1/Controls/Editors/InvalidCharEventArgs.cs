using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002B RID: 43
	public class InvalidCharEventArgs : global::System.EventArgs
	{
		// Token: 0x06000135 RID: 309 RVA: 0x000091BA File Offset: 0x000073BA
		public InvalidCharEventArgs(char c, global::Infragistics.Controls.Editors.DisplayCharBase dc)
		{
			this.c = c;
			this.dc = dc;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000091D7 File Offset: 0x000073D7
		public char Char
		{
			get
			{
				return this.c;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000091DF File Offset: 0x000073DF
		public global::Infragistics.Controls.Editors.DisplayCharBase DisplayChar
		{
			get
			{
				return this.dc;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000091E7 File Offset: 0x000073E7
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000091EF File Offset: 0x000073EF
		public bool Beep
		{
			get
			{
				return this.beep;
			}
			set
			{
				this.beep = value;
			}
		}

		// Token: 0x040000A0 RID: 160
		private char c;

		// Token: 0x040000A1 RID: 161
		private bool beep = true;

		// Token: 0x040000A2 RID: 162
		private global::Infragistics.Controls.Editors.DisplayCharBase dc;
	}
}
