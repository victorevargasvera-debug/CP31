using System;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x020000A8 RID: 168
	public class RecordNavigationEventArgs : global::System.EventArgs
	{
		// Token: 0x06000682 RID: 1666 RVA: 0x00082A7C File Offset: 0x00080C7C
		internal RecordNavigationEventArgs(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			this.a = A_0;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00082A98 File Offset: 0x00080C98
		internal global::AcpCommonLib.IAcpFeatureNode FeatureNodeRecord
		{
			get
			{
				short num = (short)1952776192;
				short num2 = num;
				num = (short)267785326;
				short num3 = num;
				num = (short)1502942318;
				switch (num3 == num)
				{
				}
				num = (short)17235969;
				if (num != 0)
				{
				}
				num = (short)1981612032;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x04000339 RID: 825
		private global::AcpCommonLib.IAcpFeatureNode a;
	}
}
