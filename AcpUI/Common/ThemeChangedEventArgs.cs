using System;

namespace AcpUI.Common
{
	// Token: 0x020000B0 RID: 176
	public class ThemeChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x0600069B RID: 1691 RVA: 0x000838DC File Offset: 0x00081ADC
		internal ThemeChangedEventArgs(string A_0)
		{
			this.a = A_0;
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x000838F8 File Offset: 0x00081AF8
		public string ThemeName
		{
			get
			{
				short num = (short)786890752;
				short num2 = num;
				num = (short)673202685;
				short num3 = num;
				num = (short)522142205;
				switch (num3 == num)
				{
				}
				num = (short)1263599616;
				if (num != 0)
				{
				}
				num = (short)553844737;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x04000343 RID: 835
		private string a;
	}
}
