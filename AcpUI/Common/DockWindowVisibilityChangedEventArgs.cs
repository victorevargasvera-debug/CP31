using System;

namespace AcpUI.Common
{
	// Token: 0x020000AD RID: 173
	public class DockWindowVisibilityChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x0600068E RID: 1678 RVA: 0x00082FDC File Offset: 0x000811DC
		internal DockWindowVisibilityChangedEventArgs(bool A_0)
		{
			this.a = A_0;
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00082FF8 File Offset: 0x000811F8
		public bool IsVisible
		{
			get
			{
				short num = (short)97452032;
				short num2 = num;
				num = (short)1457589333;
				short num3 = num;
				num = (short)202443861;
				switch (num3 == num)
				{
				}
				num = (short)809304065;
				if (num != 0)
				{
				}
				num = (short)1804468224;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x0400033F RID: 831
		private bool a;
	}
}
