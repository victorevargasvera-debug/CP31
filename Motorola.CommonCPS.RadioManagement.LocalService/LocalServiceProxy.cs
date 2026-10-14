using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000037 RID: 55
	public class LocalServiceProxy
	{
		// Token: 0x0600020E RID: 526 RVA: 0x000244CC File Offset: 0x000226CC
		private LocalServiceProxy()
		{
			this.UpdateLocalService();
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600020F RID: 527 RVA: 0x000244E8 File Offset: 0x000226E8
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00024594 File Offset: 0x00022794
		public global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService LocalService
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1461559402;
				short num2 = num;
				num = (short)9347178;
				switch (num2 == num)
				{
				}
				num = (short)631373825;
				if (num != 0)
				{
				}
				num = (short)686882816;
				short num3 = num;
				num = (short)1245839360;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)240254977;
				if (num != 0)
				{
				}
				num = (short)1690460547;
				short num2 = num;
				num = (short)811491715;
				switch (num2 == num)
				{
				}
				num = (short)924254208;
				short num3 = num;
				num = (short)1435566080;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00024644 File Offset: 0x00022844
		public static global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy GetInstance()
		{
			short num = (short)953679874;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_110;
				case 1:
				{
					num = (short)1728970752;
					short num3 = num;
					global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.a = new global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy();
					num = (short)1272905728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)1710403233;
				short num4 = num;
				num = (short)1385868961;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)950272000;
					if (num != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.a != null)
					{
						goto IL_112;
					}
					break;
				}
				num = (short)362348545;
				if (num != 0)
				{
				}
				num = (short)119865345;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			IL_112:
			return global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.a;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00024768 File Offset: 0x00022968
		public void UpdateLocalService()
		{
			short num = (short)1535520372;
			short num2 = num;
			num = (short)50474612;
			switch (num2 == num)
			{
			}
			num = (short)506986497;
			if (num != 0)
			{
			}
			num = (short)663224320;
			short num3 = num;
			num = (short)2121531392;
			if (num != 0)
			{
			}
			this.LocalService = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService();
		}

		// Token: 0x04000066 RID: 102
		private static global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy a;

		// Token: 0x04000067 RID: 103
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService b;
	}
}
