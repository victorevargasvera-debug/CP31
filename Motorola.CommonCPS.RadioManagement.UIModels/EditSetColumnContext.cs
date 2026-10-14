using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200006E RID: 110
	public class EditSetColumnContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0002E544 File Offset: 0x0002C744
		// (set) Token: 0x06000315 RID: 789 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Set Set
		{
			get
			{
				short num = (short)5078175;
				short num2 = num;
				num = (short)211451039;
				switch (num2 == num)
				{
				}
				num = (short)1418330113;
				if (num != 0)
				{
				}
				num = (short)1956839424;
				short num3 = num;
				num = (short)2129330176;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)423624708;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)492503043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						this.a = value;
						num = (short)1918894081;
						if (num != 0)
						{
						}
						num = (short)350229978;
						short num3 = num;
						num = (short)1323505114;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18A;
						default:
							num = (short)1911422976;
							if (num != 0)
							{
							}
							num = (short)1829896192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						return;
					case 3:
						goto IL_18A;
					case 4:
					{
						num = (short)1567555584;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					}
					IL_61:
					if (value != this.a)
					{
						num = (short)1224605697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_18A:
					base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.EditSetColumnContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.EditSetColumnContext.get_Set())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)2043281410;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0400016E RID: 366
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Set a;
	}
}
