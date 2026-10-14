using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x0200000E RID: 14
	public static class LINQUtility
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000060BC File Offset: 0x000042BC
		public static global::System.Linq.Expressions.Expression<T> Compose<T>(this global::System.Linq.Expressions.Expression<T> left, global::System.Linq.Expressions.Expression<T> right, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression> merge)
		{
			short num = (short)2034761728;
			short num2 = num;
			num = (short)1835788851;
			short num3 = num;
			num = (short)1516890675;
			switch (num3 == num)
			{
			}
			num = (short)663945217;
			if (num != 0)
			{
			}
			num = (short)133890048;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Common.CommonUtility.LINQUtility<T>.a a = new global::Motorola.CommonCPS.Common.CommonUtility.LINQUtility<T>.a();
			a.a = right;
			global::System.Linq.Expressions.Expression arg = global::Motorola.CommonCPS.Common.CommonUtility.a.a(left.Parameters.Select(new global::System.Func<global::System.Linq.Expressions.ParameterExpression, int, global::e<global::System.Linq.Expressions.ParameterExpression, global::System.Linq.Expressions.ParameterExpression>>(a.b)).ToDictionary(new global::System.Func<global::e<global::System.Linq.Expressions.ParameterExpression, global::System.Linq.Expressions.ParameterExpression>, global::System.Linq.Expressions.ParameterExpression>(global::Motorola.CommonCPS.Common.CommonUtility.LINQUtility.<>c__0<T>.<>9.a), new global::System.Func<global::e<global::System.Linq.Expressions.ParameterExpression, global::System.Linq.Expressions.ParameterExpression>, global::System.Linq.Expressions.ParameterExpression>(global::Motorola.CommonCPS.Common.CommonUtility.LINQUtility.<>c__0<T>.<>9.b)), a.a.Body);
			return global::System.Linq.Expressions.Expression.Lambda<T>(merge(left.Body, arg), left.Parameters);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006200 File Offset: 0x00004400
		public static global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> And<T>(this global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> right)
		{
			short num = (short)2081882112;
			short num2 = num;
			num = (short)268894209;
			if (num != 0)
			{
			}
			num = (short)26431504;
			short num3 = num;
			num = (short)1726697488;
			switch (num3 == num)
			{
			}
			num = (short)306839552;
			if (num != 0)
			{
			}
			return left.Compose(right, new global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>(global::System.Linq.Expressions.Expression.And));
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000062BC File Offset: 0x000044BC
		public static global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> And<T, T2>(this global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> right)
		{
			short num = (short)1931083776;
			short num2 = num;
			num = (short)405045379;
			short num3 = num;
			num = (short)741769347;
			switch (num3 == num)
			{
			}
			num = (short)1219756032;
			if (num != 0)
			{
			}
			num = (short)932773889;
			if (num != 0)
			{
			}
			return left.Compose(right, new global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>(global::System.Linq.Expressions.Expression.And));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006378 File Offset: 0x00004578
		public static global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> AndAlso<T>(this global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> right)
		{
			short num = (short)604045312;
			short num2 = num;
			num = (short)438110931;
			short num3 = num;
			num = (short)2040597203;
			switch (num3 == num)
			{
			}
			num = (short)806944768;
			if (num != 0)
			{
			}
			num = (short)1019412481;
			if (num != 0)
			{
			}
			return left.Compose(right, new global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>(global::System.Linq.Expressions.Expression.AndAlso));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006434 File Offset: 0x00004634
		public static global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> AndAlso<T, T2>(this global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> right)
		{
			short num = (short)1588264960;
			short num2 = num;
			num = (short)1978546038;
			short num3 = num;
			num = (short)1434793846;
			switch (num3 == num)
			{
			}
			num = (short)969932801;
			if (num != 0)
			{
			}
			num = (short)1493827584;
			if (num != 0)
			{
			}
			return left.Compose(right, new global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>(global::System.Linq.Expressions.Expression.AndAlso));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000064F0 File Offset: 0x000046F0
		public static global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> Or<T>(this global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> right)
		{
			short num = (short)1799028736;
			short num2 = num;
			num = (short)1301866364;
			short num3 = num;
			num = (short)1792141180;
			switch (num3 == num)
			{
			}
			num = (short)1694564353;
			if (num != 0)
			{
			}
			num = (short)1541668864;
			if (num != 0)
			{
			}
			return left.Compose(right, new global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>(global::System.Linq.Expressions.Expression.Or));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000065AC File Offset: 0x000047AC
		public static global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> Or<T, T2>(this global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> right)
		{
			short num = (short)1301610496;
			short num2 = num;
			num = (short)1029795392;
			short num3 = num;
			num = (short)1973579328;
			switch (num3 == num)
			{
			}
			num = (short)1988034561;
			if (num != 0)
			{
			}
			num = (short)378798080;
			if (num != 0)
			{
			}
			return left.Compose(right, new global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>(global::System.Linq.Expressions.Expression.Or));
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000666C File Offset: 0x0000486C
		public static global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> OrElse<T>(this global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<T, bool>> right)
		{
			short num = (short)1881800704;
			short num2 = num;
			num = (short)372136986;
			short num3 = num;
			num = (short)943021082;
			switch (num3 == num)
			{
			}
			num = (short)1033371649;
			if (num != 0)
			{
			}
			num = (short)127598592;
			if (num != 0)
			{
			}
			return left.Compose(right, new global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>(global::System.Linq.Expressions.Expression.OrElse));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006728 File Offset: 0x00004928
		public static global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> OrElse<T, T2>(this global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> left, global::System.Linq.Expressions.Expression<global::System.Func<T, T2, bool>> right)
		{
			short num = (short)1818165248;
			short num2 = num;
			num = (short)1135194449;
			short num3 = num;
			num = (short)65253713;
			switch (num3 == num)
			{
			}
			num = (short)1769537537;
			if (num != 0)
			{
			}
			num = (short)1522401280;
			if (num != 0)
			{
			}
			return left.Compose(right, new global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>(global::System.Linq.Expressions.Expression.OrElse));
		}

		// Token: 0x0200000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a<a>
		{
			// Token: 0x06000043 RID: 67 RVA: 0x000067F8 File Offset: 0x000049F8
			internal global::e<global::System.Linq.Expressions.ParameterExpression, global::System.Linq.Expressions.ParameterExpression> b(global::System.Linq.Expressions.ParameterExpression A_0, int A_1)
			{
				short num = (short)2105606144;
				short num2 = num;
				num = (short)1670905857;
				if (num != 0)
				{
				}
				num = (short)1076705328;
				short num3 = num;
				num = (short)100153392;
				switch (num3 == num)
				{
				}
				num = (short)457703424;
				if (num != 0)
				{
				}
				return new global::e<global::System.Linq.Expressions.ParameterExpression, global::System.Linq.Expressions.ParameterExpression>(A_0, this.a.Parameters[A_1]);
			}

			// Token: 0x04000018 RID: 24
			public global::System.Linq.Expressions.Expression<a> a;
		}
	}
}
