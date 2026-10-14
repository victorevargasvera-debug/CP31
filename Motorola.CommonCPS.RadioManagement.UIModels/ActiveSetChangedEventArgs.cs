using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000038 RID: 56
	public class ActiveSetChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00013C30 File Offset: 0x00011E30
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00013CE0 File Offset: 0x00011EE0
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Set OldSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2121269249;
				if (num != 0)
				{
				}
				num = (short)1823604736;
				short num2 = num;
				num = (short)137286081;
				short num3 = num;
				num = (short)848024001;
				switch (num3 == num)
				{
				}
				num = (short)751960064;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)870726817;
				short num2 = num;
				num = (short)354499745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)877461504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)640942081;
				if (num != 0)
				{
				}
				num = (short)896532480;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00013D90 File Offset: 0x00011F90
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00013E44 File Offset: 0x00012044
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Set NewSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)363524719;
				short num2 = num;
				num = (short)1653994095;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1066205184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2025390081;
				if (num != 0)
				{
				}
				num = (short)1222901760;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1878720513;
				if (num != 0)
				{
				}
				num = (short)1589968896;
				short num2 = num;
				num = (short)871595179;
				short num3 = num;
				num = (short)1338473643;
				switch (num3 == num)
				{
				}
				num = (short)1297022976;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00013EF8 File Offset: 0x000120F8
		public ActiveSetChangedEventArgs(global::Motorola.CommonCPS.RadioManagement.UIModels.Set oldSet, global::Motorola.CommonCPS.RadioManagement.UIModels.Set newSet)
		{
			this.OldSet = oldSet;
			this.NewSet = newSet;
		}

		// Token: 0x04000098 RID: 152
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Set a;

		// Token: 0x04000099 RID: 153
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Set b;
	}
}
