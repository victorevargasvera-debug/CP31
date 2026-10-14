using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002A RID: 42
	internal class InvalidOperationEventArgs : global::System.EventArgs
	{
		// Token: 0x06000131 RID: 305 RVA: 0x0000917D File Offset: 0x0000737D
		public InvalidOperationEventArgs(string message)
		{
			this.message = message;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00009193 File Offset: 0x00007393
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000091A9 File Offset: 0x000073A9
		// (set) Token: 0x06000134 RID: 308 RVA: 0x000091B1 File Offset: 0x000073B1
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
		private string message;

		// Token: 0x0400009F RID: 159
		private bool beep = true;
	}
}
