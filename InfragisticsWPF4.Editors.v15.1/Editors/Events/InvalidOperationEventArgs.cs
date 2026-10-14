using System;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x0200009E RID: 158
	internal class InvalidOperationEventArgs : global::System.EventArgs
	{
		// Token: 0x060008C4 RID: 2244 RVA: 0x000278F7 File Offset: 0x00025AF7
		public InvalidOperationEventArgs(string message)
		{
			this.message = message;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0002790D File Offset: 0x00025B0D
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00027923 File Offset: 0x00025B23
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x0002792B File Offset: 0x00025B2B
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

		// Token: 0x04000328 RID: 808
		private string message;

		// Token: 0x04000329 RID: 809
		private bool beep = true;
	}
}
