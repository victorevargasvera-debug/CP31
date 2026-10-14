using System;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x0200009F RID: 159
	public class InvalidCharEventArgs : global::System.EventArgs
	{
		// Token: 0x060008C8 RID: 2248 RVA: 0x00027934 File Offset: 0x00025B34
		public InvalidCharEventArgs(char c, global::Infragistics.Windows.Editors.DisplayCharBase dc)
		{
			this.c = c;
			this.dc = dc;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00027951 File Offset: 0x00025B51
		public char Char
		{
			get
			{
				return this.c;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00027959 File Offset: 0x00025B59
		public global::Infragistics.Windows.Editors.DisplayCharBase DisplayChar
		{
			get
			{
				return this.dc;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00027961 File Offset: 0x00025B61
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00027969 File Offset: 0x00025B69
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

		// Token: 0x0400032A RID: 810
		private char c;

		// Token: 0x0400032B RID: 811
		private bool beep = true;

		// Token: 0x0400032C RID: 812
		private global::Infragistics.Windows.Editors.DisplayCharBase dc;
	}
}
