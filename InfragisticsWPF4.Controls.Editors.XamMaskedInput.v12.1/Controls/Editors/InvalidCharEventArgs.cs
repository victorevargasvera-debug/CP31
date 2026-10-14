using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002C RID: 44
	public class InvalidCharEventArgs : global::System.EventArgs
	{
		// Token: 0x06000136 RID: 310 RVA: 0x000095DA File Offset: 0x000077DA
		public InvalidCharEventArgs(char c, global::Infragistics.Controls.Editors.DisplayCharBase dc)
		{
			this.c = c;
			this.dc = dc;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000095F7 File Offset: 0x000077F7
		public char Char
		{
			get
			{
				return this.c;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000095FF File Offset: 0x000077FF
		public global::Infragistics.Controls.Editors.DisplayCharBase DisplayChar
		{
			get
			{
				return this.dc;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00009607 File Offset: 0x00007807
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000960F File Offset: 0x0000780F
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

		// Token: 0x0400009E RID: 158
		private char c;

		// Token: 0x0400009F RID: 159
		private bool beep = true;

		// Token: 0x040000A0 RID: 160
		private global::Infragistics.Controls.Editors.DisplayCharBase dc;
	}
}
