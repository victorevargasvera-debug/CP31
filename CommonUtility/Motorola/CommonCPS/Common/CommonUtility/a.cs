using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x0200000D RID: 13
	internal class a : global::System.Linq.Expressions.ExpressionVisitor
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00005EB4 File Offset: 0x000040B4
		public a(global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ParameterExpression, global::System.Linq.Expressions.ParameterExpression> A_0)
		{
			this.a = (A_0 ?? new global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ParameterExpression, global::System.Linq.Expressions.ParameterExpression>());
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005EDC File Offset: 0x000040DC
		public static global::System.Linq.Expressions.Expression a(global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ParameterExpression, global::System.Linq.Expressions.ParameterExpression> A_0, global::System.Linq.Expressions.Expression A_1)
		{
			short num = (short)2051407872;
			short num2 = num;
			num = (short)1818946444;
			short num3 = num;
			num = (short)1861938060;
			switch (num3 == num)
			{
			}
			num = (short)610926593;
			if (num != 0)
			{
			}
			num = (short)1378746368;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Common.CommonUtility.a(A_0).Visit(A_1);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005F90 File Offset: 0x00004190
		protected override global::System.Linq.Expressions.Expression VisitParameter(global::System.Linq.Expressions.ParameterExpression p)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1647116288;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Linq.Expressions.ParameterExpression parameterExpression;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
					{
						num = (short)851181569;
						if (num != 0)
						{
						}
						p = parameterExpression;
						num = (short)248732108;
						short num3 = num;
						num = (short)1288919500;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)2103705600;
							if (num != 0)
							{
							}
							num = (short)1848115200;
							short num4 = num;
							num = (short)365166594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_113;
					}
					IL_31:
					if (!this.a.TryGetValue(p, out parameterExpression))
					{
						goto IL_115;
					}
					num = (short)464060417;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_113:
			IL_115:
			return base.VisitParameter(p);
		}

		// Token: 0x04000017 RID: 23
		private readonly global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ParameterExpression, global::System.Linq.Expressions.ParameterExpression> a;
	}
}
