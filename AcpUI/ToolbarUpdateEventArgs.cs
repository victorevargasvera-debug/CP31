using System;

namespace AcpUI
{
	// Token: 0x02000054 RID: 84
	public class ToolbarUpdateEventArgs : global::System.EventArgs
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x0005A3F0 File Offset: 0x000585F0
		internal ToolbarUpdateEventArgs(global::AcpUI.UpdateToolbarEventType A_0)
		{
			this.a = A_0;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0005A40C File Offset: 0x0005860C
		internal global::AcpUI.UpdateToolbarEventType Event
		{
			get
			{
				short num = (short)1815336663;
				short num2 = num;
				num = (short)654300887;
				switch (num2 == num)
				{
				}
				num = (short)1909260289;
				if (num != 0)
				{
				}
				num = (short)1021050880;
				if (num != 0)
				{
				}
				num = (short)720044032;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x040002A6 RID: 678
		private global::AcpUI.UpdateToolbarEventType a;
	}
}
