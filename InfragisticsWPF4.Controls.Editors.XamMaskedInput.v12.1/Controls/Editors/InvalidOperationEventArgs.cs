using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002B RID: 43
	internal class InvalidOperationEventArgs : global::System.EventArgs
	{
		// Token: 0x06000132 RID: 306 RVA: 0x0000959D File Offset: 0x0000779D
		public InvalidOperationEventArgs(string message)
		{
			this.message = message;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000095B3 File Offset: 0x000077B3
		public string Message
		{
			get
			{
				if (this.message == null)
				{
					return string.Empty;
				}
				return this.message;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000095C9 File Offset: 0x000077C9
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000095D1 File Offset: 0x000077D1
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

		// Token: 0x0400009C RID: 156
		private string message;

		// Token: 0x0400009D RID: 157
		private bool beep = true;
	}
}
