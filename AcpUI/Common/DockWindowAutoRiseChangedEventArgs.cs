using System;

namespace AcpUI.Common
{
	// Token: 0x020000AE RID: 174
	public class DockWindowAutoRiseChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x000830A8 File Offset: 0x000812A8
		internal DockWindowAutoRiseChangedEventArgs(bool A_0)
		{
			this.a = A_0;
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x000830C4 File Offset: 0x000812C4
		public bool IsAutoRiseEnabled
		{
			get
			{
				short num = (short)909115392;
				short num2 = num;
				num = (short)342806543;
				short num3 = num;
				num = (short)589156367;
				switch (num3 == num)
				{
				}
				num = (short)1228668929;
				if (num != 0)
				{
				}
				num = (short)1189675008;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x04000340 RID: 832
		private bool a;
	}
}
