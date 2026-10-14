using System;

namespace AcpUI
{
	// Token: 0x0200003C RID: 60
	public class PageReturnEventArgs : global::System.EventArgs
	{
		// Token: 0x060003AE RID: 942 RVA: 0x0003FC9C File Offset: 0x0003DE9C
		internal PageReturnEventArgs(bool A_0, object A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0003FCC0 File Offset: 0x0003DEC0
		internal bool Result
		{
			get
			{
				short num = (short)525400205;
				short num2 = num;
				num = (short)1380579469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1391394816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1825701888;
				if (num != 0)
				{
				}
				num = (short)1648558081;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0003FD70 File Offset: 0x0003DF70
		internal object Data
		{
			get
			{
				short num = (short)1581406180;
				short num2 = num;
				num = (short)1084839908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1309474816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109051905;
				if (num != 0)
				{
				}
				num = (short)1724645376;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0400022D RID: 557
		private bool a;

		// Token: 0x0400022E RID: 558
		private object b;
	}
}
