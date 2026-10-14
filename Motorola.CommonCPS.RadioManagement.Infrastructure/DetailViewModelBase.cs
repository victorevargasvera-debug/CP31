using System;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000049 RID: 73
	public abstract class DetailViewModelBase<T> : global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewModelBase
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0001C8E0 File Offset: 0x0001AAE0
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0001C990 File Offset: 0x0001AB90
		public T Item
		{
			get
			{
				short num = (short)561137402;
				short num2 = num;
				num = (short)1034766074;
				switch (num2 == num)
				{
				}
				num = (short)2050359297;
				if (num != 0)
				{
				}
				num = (short)1912340480;
				if (num != 0)
				{
				}
				num = (short)357957632;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)127860737;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E5;
					case 1:
					{
						num = (short)1151139840;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					case 2:
						this.a = value;
						base.RaisePropertyChanged<T>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<T>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DetailViewModelBase<T>)), methodof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DetailViewModelBase<T>.get_Item())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)857407488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_59:
					if (!value.Equals(this.a))
					{
						num = (short)1556021250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E5:
					num = (short)1431474350;
					short num4 = num;
					num = (short)2040697006;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_119;
					}
				}
				IL_119:
				num = (short)333774849;
				if (num != 0)
				{
				}
				num = (short)1350303744;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x040000DB RID: 219
		private T a;
	}
}
