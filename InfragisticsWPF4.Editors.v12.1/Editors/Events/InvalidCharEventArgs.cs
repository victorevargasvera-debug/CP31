using System;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x02000098 RID: 152
	public class InvalidCharEventArgs : global::System.EventArgs
	{
		// Token: 0x0600085B RID: 2139 RVA: 0x00025B98 File Offset: 0x00023D98
		public InvalidCharEventArgs(char c, global::Infragistics.Windows.Editors.DisplayCharBase dc)
		{
			this.c = c;
			this.dc = dc;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00025BB5 File Offset: 0x00023DB5
		public char Char
		{
			get
			{
				return this.c;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00025BBD File Offset: 0x00023DBD
		public global::Infragistics.Windows.Editors.DisplayCharBase DisplayChar
		{
			get
			{
				return this.dc;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00025BC5 File Offset: 0x00023DC5
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00025BCD File Offset: 0x00023DCD
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

		// Token: 0x040002F4 RID: 756
		private char c;

		// Token: 0x040002F5 RID: 757
		private bool beep = true;

		// Token: 0x040002F6 RID: 758
		private global::Infragistics.Windows.Editors.DisplayCharBase dc;
	}
}
