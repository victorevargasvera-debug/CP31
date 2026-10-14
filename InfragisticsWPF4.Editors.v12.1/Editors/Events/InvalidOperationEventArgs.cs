using System;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x02000097 RID: 151
	internal class InvalidOperationEventArgs : global::System.EventArgs
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x00025B5B File Offset: 0x00023D5B
		public InvalidOperationEventArgs(string message)
		{
			this.message = message;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00025B71 File Offset: 0x00023D71
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

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00025B87 File Offset: 0x00023D87
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00025B8F File Offset: 0x00023D8F
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

		// Token: 0x040002F2 RID: 754
		private string message;

		// Token: 0x040002F3 RID: 755
		private bool beep = true;
	}
}
