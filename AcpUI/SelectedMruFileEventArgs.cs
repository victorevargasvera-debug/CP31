using System;
using System.Runtime.CompilerServices;
using System.Windows;

namespace AcpUI
{
	// Token: 0x0200001D RID: 29
	public class SelectedMruFileEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0001E138 File Offset: 0x0001C338
		internal SelectedMruFileEventArgs(string A_0)
		{
			this.FilePath = A_0;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0001E154 File Offset: 0x0001C354
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0001E208 File Offset: 0x0001C408
		public string FilePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1337065472;
				short num2 = num;
				num = (short)402260970;
				short num3 = num;
				num = (short)1553662954;
				switch (num3 == num)
				{
				}
				num = (short)207683585;
				if (num != 0)
				{
				}
				num = (short)1704460288;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)232914944;
				short num2 = num;
				num = (short)1507150127;
				short num3 = num;
				num = (short)1851738415;
				switch (num3 == num)
				{
				}
				num = (short)1146224641;
				if (num != 0)
				{
				}
				num = (short)1878851584;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0400015E RID: 350
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
