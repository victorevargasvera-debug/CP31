using System;
using System.Runtime.CompilerServices;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x020000AC RID: 172
	public class FieldItemSelectionEventArgs : global::System.EventArgs
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x00082E60 File Offset: 0x00081060
		internal FieldItemSelectionEventArgs(global::AcpCommonLib.FieldInfo A_0)
		{
			this.Field = A_0;
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00082E7C File Offset: 0x0008107C
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00082F2C File Offset: 0x0008112C
		public global::AcpCommonLib.FieldInfo Field
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1673986048;
				short num2 = num;
				num = (short)1188740706;
				short num3 = num;
				num = (short)1375518306;
				switch (num3 == num)
				{
				}
				num = (short)247267329;
				if (num != 0)
				{
				}
				num = (short)804323328;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)881065984;
				short num2 = num;
				num = (short)883064180;
				short num3 = num;
				num = (short)2145877364;
				switch (num3 == num)
				{
				}
				num = (short)972423169;
				if (num != 0)
				{
				}
				num = (short)602144768;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0400033E RID: 830
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.FieldInfo a;
	}
}
