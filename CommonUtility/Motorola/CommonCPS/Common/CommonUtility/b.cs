using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using CommonUtility;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x02000015 RID: 21
	internal class b<a> : global::Motorola.CommonCPS.Common.CommonUtility.IAccessor
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000912C File Offset: 0x0000732C
		public object GetValue(object instance, string memberName)
		{
			short num = (short)252789911;
			short num2 = num;
			num = (short)498484375;
			switch (num2 == num)
			{
			}
			num = (short)1107034112;
			if (num != 0)
			{
			}
			num = (short)1199767552;
			short num3 = num;
			num = (short)1846476801;
			if (num != 0)
			{
			}
			return this.a(instance, memberName);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000091E4 File Offset: 0x000073E4
		public void SetValue(object instance, string memberName, object newValue)
		{
			short num = (short)102760448;
			short num2 = num;
			num = (short)60408122;
			short num3 = num;
			num = (short)1621475642;
			switch (num3 == num)
			{
			}
			num = (short)1779826689;
			if (num != 0)
			{
			}
			num = (short)373817344;
			if (num != 0)
			{
			}
			this.b(instance, memberName, newValue);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000092A0 File Offset: 0x000074A0
		public b()
		{
			this.a = this.b();
			this.b = this.a();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000092CC File Offset: 0x000074CC
		private global::System.Func<object, string, object> b()
		{
			int a_ = 8;
			short num = (short)1310720;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				int num3;
				global::System.Reflection.PropertyInfo[] properties;
				global::System.Linq.Expressions.ParameterExpression parameterExpression;
				global::System.Collections.Generic.List<global::System.Linq.Expressions.SwitchCase> list;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_129;
					case 1:
						goto IL_1AC;
					case 2:
						if (num3 >= properties.Length)
						{
							num = (short)1631780865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B1;
					case 3:
						goto IL_129;
					}
					goto IL_47;
					IL_129:
					num = (short)386391134;
					short num4 = num;
					num = (short)112581726;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_1B1:
						global::System.Reflection.PropertyInfo propertyInfo = properties[num3];
						global::System.Linq.Expressions.MemberExpression expression = global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Convert(parameterExpression, typeof(a)), propertyInfo.Name);
						global::System.Linq.Expressions.ConstantExpression constantExpression = global::System.Linq.Expressions.Expression.Constant(propertyInfo.Name.GetHashCode(), typeof(int));
						list.Add(global::System.Linq.Expressions.Expression.SwitchCase(global::System.Linq.Expressions.Expression.Convert(expression, typeof(object)), new global::System.Linq.Expressions.Expression[]
						{
							constantExpression
						}));
						num3++;
						num = (short)1122697216;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					default:
						num = (short)168820736;
						if (num != 0)
						{
						}
						num = (short)2112749570;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1AC:
				num = (short)17432576;
				short num5 = num;
				global::System.Linq.Expressions.ParameterExpression parameterExpression2;
				global::System.Linq.Expressions.SwitchExpression switchExpression = global::System.Linq.Expressions.Expression.Switch(parameterExpression2, global::System.Linq.Expressions.Expression.Constant(null), list.ToArray());
				global::System.Linq.Expressions.BinaryExpression binaryExpression;
				global::System.Linq.Expressions.ParameterExpression parameterExpression3;
				return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object, string, object>>(global::System.Linq.Expressions.Expression.Block(typeof(object), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression2
				}, new global::System.Linq.Expressions.Expression[]
				{
					binaryExpression,
					switchExpression
				}), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression,
					parameterExpression3
				}).Compile();
				IL_47:
				num = (short)926810113;
				if (num != 0)
				{
				}
				global::System.Type typeFromHandle = typeof(a);
				parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), global::CommonUtility.VersionUtility.b("倸唺丼䬾⁀ⵂ♄≆", a_));
				parameterExpression3 = global::System.Linq.Expressions.Expression.Parameter(typeof(string), global::CommonUtility.VersionUtility.b("吸帺值崾⑀ㅂୄ♆⑈⹊", a_));
				parameterExpression2 = global::System.Linq.Expressions.Expression.Variable(typeof(int), global::CommonUtility.VersionUtility.b("圸娺值娾ी≂㙄⽆", a_));
				binaryExpression = global::System.Linq.Expressions.Expression.Assign(parameterExpression2, global::System.Linq.Expressions.Expression.Call(parameterExpression3, typeof(object).GetMethod(global::CommonUtility.VersionUtility.b("縸帺䤼眾⁀あⵄц♈⽊⡌", a_))));
				list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.SwitchCase>();
				properties = typeFromHandle.GetProperties();
				num3 = 0;
				num = (short)541065219;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000959C File Offset: 0x0000779C
		private global::System.Action<object, string, object> a()
		{
			int a_ = 3;
			short num = (short)1779171328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				int num3;
				global::System.Reflection.PropertyInfo[] properties;
				global::System.Linq.Expressions.ParameterExpression parameterExpression;
				global::System.Linq.Expressions.ParameterExpression parameterExpression2;
				global::System.Collections.Generic.List<global::System.Linq.Expressions.SwitchCase> list;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_122;
					case 1:
						goto IL_1D0;
					case 2:
						if (num3 >= properties.Length)
						{
							num = (short)1794506753;
							if (num != 0)
							{
							}
							num = (short)353566721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D5;
					case 3:
						goto IL_122;
					}
					goto IL_47;
					IL_122:
					num = (short)1248602261;
					short num4 = num;
					num = (short)1339566229;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_1D5:
						global::System.Reflection.PropertyInfo propertyInfo = properties[num3];
						global::System.Linq.Expressions.BinaryExpression expression = global::System.Linq.Expressions.Expression.Assign(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Convert(parameterExpression, typeof(a)), propertyInfo.Name), global::System.Linq.Expressions.Expression.Convert(parameterExpression2, propertyInfo.PropertyType));
						global::System.Linq.Expressions.ConstantExpression constantExpression = global::System.Linq.Expressions.Expression.Constant(propertyInfo.Name.GetHashCode(), typeof(int));
						list.Add(global::System.Linq.Expressions.Expression.SwitchCase(global::System.Linq.Expressions.Expression.Convert(expression, typeof(object)), new global::System.Linq.Expressions.Expression[]
						{
							constantExpression
						}));
						num3++;
						num = (short)1801846784;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					default:
						num = (short)1293287424;
						if (num != 0)
						{
						}
						num = (short)1848967170;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1D0:
				num = (short)369819648;
				short num5 = num;
				global::System.Linq.Expressions.ParameterExpression parameterExpression3;
				global::System.Linq.Expressions.SwitchExpression switchExpression = global::System.Linq.Expressions.Expression.Switch(parameterExpression3, global::System.Linq.Expressions.Expression.Constant(null), list.ToArray());
				global::System.Linq.Expressions.BinaryExpression binaryExpression;
				global::System.Linq.Expressions.ParameterExpression parameterExpression4;
				return global::System.Linq.Expressions.Expression.Lambda<global::System.Action<object, string, object>>(global::System.Linq.Expressions.Expression.Block(typeof(object), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression3
				}, new global::System.Linq.Expressions.Expression[]
				{
					binaryExpression,
					switchExpression
				}), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression,
					parameterExpression4,
					parameterExpression2
				}).Compile();
				IL_47:
				global::System.Type typeFromHandle = typeof(a);
				parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), global::CommonUtility.VersionUtility.b("崳堵䬷丹崻倽⌿❁", a_));
				parameterExpression4 = global::System.Linq.Expressions.Expression.Parameter(typeof(string), global::CommonUtility.VersionUtility.b("夳匵唷堹夻䰽฿⍁⥃⍅", a_));
				parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(object), global::CommonUtility.VersionUtility.b("娳匵伷氹崻刽㔿❁", a_));
				parameterExpression3 = global::System.Linq.Expressions.Expression.Variable(typeof(int), global::CommonUtility.VersionUtility.b("娳圵唷弹琻弽㌿⩁", a_));
				binaryExpression = global::System.Linq.Expressions.Expression.Assign(parameterExpression3, global::System.Linq.Expressions.Expression.Call(parameterExpression4, typeof(object).GetMethod(global::CommonUtility.VersionUtility.b("猳匵䰷爹崻䴽⠿Ł⭃≅ⵇ", a_))));
				list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.SwitchCase>();
				properties = typeFromHandle.GetProperties();
				num3 = 0;
				num = (short)1231224835;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0400001F RID: 31
		private global::System.Func<object, string, object> a;

		// Token: 0x04000020 RID: 32
		private global::System.Action<object, string, object> b;
	}
}
