using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace Infragistics
{
	// Token: 0x02000036 RID: 54
	internal static class GetSetHelper
	{
		// Token: 0x0600023F RID: 575 RVA: 0x0000A2D0 File Offset: 0x000084D0
		public static global::Infragistics.GetSetProxy<TOwner, TProperty> Get<TOwner, TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TProperty>> getter) where TOwner : class
		{
			global::System.Linq.Expressions.MemberExpression memberExpression = getter.Body as global::System.Linq.Expressions.MemberExpression;
			if (memberExpression == null)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_InvalidMemberExpression"), "getter");
			}
			global::System.Reflection.MemberInfo member = memberExpression.Member;
			if (!member.DeclaringType.IsAssignableFrom(typeof(TOwner)))
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_InvalidMemberForTarget", new object[]
				{
					member.Name,
					typeof(TOwner).FullName
				}), "getter");
			}
			return global::Infragistics.GetSetHelper.Get<TOwner, TProperty>(member);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000A360 File Offset: 0x00008560
		public static global::Infragistics.GetSetProxy<TOwner, TProperty> Get<TOwner, TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TOwner, TProperty>> getter) where TOwner : class
		{
			global::System.Linq.Expressions.MemberExpression memberExpression = getter.Body as global::System.Linq.Expressions.MemberExpression;
			if (memberExpression == null)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_InvalidMemberExpression"), "getter");
			}
			return global::Infragistics.GetSetHelper.Get<TOwner, TProperty>(memberExpression.Member);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000A39C File Offset: 0x0000859C
		public static global::Infragistics.GetSetProxy<TOwner, TProperty> Get<TOwner, TProperty>(string memberName) where TOwner : class
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(memberName, "memberName");
			global::Infragistics.GetSetHelper.MemberNameKey key = new global::Infragistics.GetSetHelper.MemberNameKey
			{
				OwnerType = typeof(TOwner),
				MemberName = memberName
			};
			object obj;
			if (!global::Infragistics.GetSetHelper.CachedByMemberName.TryGetValue(key, out obj))
			{
				global::System.Reflection.MemberInfo member = global::Infragistics.GetSetHelper.GetMember<TOwner>(memberName);
				if (member == null)
				{
					throw new global::System.ArgumentException(global::SR.GetString("LE_InvalidMemberForTarget", new object[]
					{
						memberName,
						typeof(TOwner).FullName
					}), "memberName");
				}
				obj = (global::Infragistics.GetSetHelper.CachedByMemberName[key] = global::Infragistics.GetSetHelper.Get<TOwner, TProperty>(member));
			}
			return (global::Infragistics.GetSetProxy<TOwner, TProperty>)obj;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000A448 File Offset: 0x00008648
		public static global::Infragistics.GetSetProxy<TOwner, TProperty> Get<TOwner, TProperty>(global::System.Reflection.MemberInfo member) where TOwner : class
		{
			object obj;
			if (!global::Infragistics.GetSetHelper.CachedByMemberInfo.TryGetValue(member, out obj))
			{
				obj = (global::Infragistics.GetSetHelper.CachedByMemberInfo[member] = global::Infragistics.GetSetHelper.Create<TOwner, TProperty>(member));
			}
			return (global::Infragistics.GetSetProxy<TOwner, TProperty>)obj;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000A480 File Offset: 0x00008680
		private static global::Infragistics.GetSetProxy<TOwner, TProperty> Create<TOwner, TProperty>(global::System.Reflection.MemberInfo memberInfo)
		{
			global::System.Reflection.PropertyInfo propertyInfo = memberInfo as global::System.Reflection.PropertyInfo;
			global::System.Linq.Expressions.ParameterExpression expression = global::System.Linq.Expressions.Expression.Parameter(memberInfo.DeclaringType, "i");
			if (null != propertyInfo)
			{
				global::System.Linq.Expressions.MemberExpression memberExpression = global::System.Linq.Expressions.Expression.Property(expression, propertyInfo);
				return global::Infragistics.GetSetHelper.Create<TOwner, TProperty>(memberExpression, propertyInfo.CanRead, propertyInfo.CanWrite);
			}
			global::System.Reflection.FieldInfo fieldInfo = memberInfo as global::System.Reflection.FieldInfo;
			if (null != fieldInfo)
			{
				global::System.Linq.Expressions.MemberExpression memberExpression2 = global::System.Linq.Expressions.Expression.Field(expression, fieldInfo);
				return global::Infragistics.GetSetHelper.Create<TOwner, TProperty>(memberExpression2, true, !fieldInfo.IsInitOnly && !fieldInfo.IsLiteral);
			}
			throw new global::System.ArgumentException(global::SR.GetString("LE_InvalidMemberForTarget", new object[]
			{
				memberInfo.Name,
				typeof(TOwner).FullName
			}));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000A538 File Offset: 0x00008738
		private static global::Infragistics.GetSetProxy<TOwner, TProperty> Create<TOwner, TProperty>(global::System.Linq.Expressions.MemberExpression memberExpression, bool includeGetter, bool includeSetter)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(memberExpression, "memberExpression");
			global::System.Type typeFromHandle = typeof(TProperty);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeFromHandle, "v");
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = memberExpression.Expression as global::System.Linq.Expressions.ParameterExpression;
			global::System.Linq.Expressions.Expression right = parameterExpression;
			global::System.Linq.Expressions.Expression expression = memberExpression;
			if (memberExpression.Type != typeFromHandle && typeFromHandle.IsAssignableFrom(memberExpression.Type))
			{
				right = global::System.Linq.Expressions.Expression.Convert(parameterExpression, memberExpression.Type);
				expression = global::System.Linq.Expressions.Expression.Convert(expression, typeFromHandle);
			}
			global::System.Action<TOwner, TProperty> setter = (!includeSetter) ? null : global::System.Linq.Expressions.Expression.Lambda<global::System.Action<TOwner, TProperty>>(global::System.Linq.Expressions.Expression.Assign(memberExpression, right), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression2,
				parameterExpression
			}).Compile();
			global::System.Func<TOwner, TProperty> getter = (!includeGetter) ? null : global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TOwner, TProperty>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression2
			}).Compile();
			global::System.Reflection.MemberInfo member = memberExpression.Member;
			return new global::Infragistics.GetSetProxy<TOwner, TProperty>(getter, setter, member.Name, global::Infragistics.GetSetHelper.GetDisplayName(member));
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000A620 File Offset: 0x00008820
		private static string GetDisplayName(global::System.Reflection.MemberInfo member)
		{
			try
			{
				if (!global::Infragistics.GetSetHelper._skipGetDisplayName)
				{
					if (global::Infragistics.GetSetHelper._displayAttributeGetNameMethod != null)
					{
						object[] customAttributes = member.GetCustomAttributes(global::Infragistics.GetSetHelper._displayAttributeGetNameMethod.DeclaringType, true);
						if (customAttributes != null && customAttributes.Length > 0)
						{
							return global::Infragistics.GetSetHelper._displayAttributeGetNameMethod.Invoke(customAttributes[0], global::System.Type.EmptyTypes) as string;
						}
					}
					else
					{
						object[] customAttributes2 = member.GetCustomAttributes(true);
						if (customAttributes2 != null && customAttributes2.Length > 0)
						{
							foreach (object obj in customAttributes2)
							{
								if (!(obj.GetType().FullName != "System.ComponentModel.DataAnnotations.DisplayAttribute"))
								{
									try
									{
										global::Infragistics.GetSetHelper._displayAttributeGetNameMethod = obj.GetType().GetMethod("GetName");
										return global::Infragistics.GetSetHelper._displayAttributeGetNameMethod.Invoke(obj, global::System.Type.EmptyTypes) as string;
									}
									catch
									{
										global::Infragistics.GetSetHelper._skipGetDisplayName = true;
									}
								}
							}
						}
					}
				}
				object[] customAttributes3 = member.GetCustomAttributes(typeof(global::System.ComponentModel.DisplayNameAttribute), true);
				if (customAttributes3 != null && customAttributes3.Length > 0)
				{
					return ((global::System.ComponentModel.DisplayNameAttribute)customAttributes3[0]).DisplayName;
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000A750 File Offset: 0x00008950
		private static global::System.Reflection.MemberInfo GetMember<TOwner>(string memberName)
		{
			global::System.Type typeFromHandle = typeof(TOwner);
			global::System.Reflection.MemberInfo memberInfo = typeFromHandle.GetProperty(memberName, global::System.Reflection.BindingFlags.IgnoreCase | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
			if (null == memberInfo)
			{
				memberInfo = typeFromHandle.GetField(memberName, global::System.Reflection.BindingFlags.IgnoreCase | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
				if (null == memberInfo)
				{
					memberInfo = typeFromHandle.GetProperty(memberName, global::System.Reflection.BindingFlags.IgnoreCase | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.FlattenHierarchy);
					if (null == memberInfo)
					{
						memberInfo = typeFromHandle.GetField(memberName, global::System.Reflection.BindingFlags.IgnoreCase | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.FlattenHierarchy);
					}
				}
			}
			return memberInfo;
		}

		// Token: 0x0400008C RID: 140
		private static global::System.Collections.Generic.Dictionary<global::System.Reflection.MemberInfo, object> CachedByMemberInfo = new global::System.Collections.Generic.Dictionary<global::System.Reflection.MemberInfo, object>();

		// Token: 0x0400008D RID: 141
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.GetSetHelper.MemberNameKey, object> CachedByMemberName = new global::System.Collections.Generic.Dictionary<global::Infragistics.GetSetHelper.MemberNameKey, object>();

		// Token: 0x0400008E RID: 142
		private static global::System.Reflection.MethodInfo _displayAttributeGetNameMethod = null;

		// Token: 0x0400008F RID: 143
		private static bool _skipGetDisplayName;

		// Token: 0x02000037 RID: 55
		private struct MemberNameKey : global::System.IEquatable<global::Infragistics.GetSetHelper.MemberNameKey>
		{
			// Token: 0x06000248 RID: 584 RVA: 0x0000A7C8 File Offset: 0x000089C8
			public override bool Equals(object obj)
			{
				return obj is global::Infragistics.GetSetHelper.MemberNameKey && this.Equals((global::Infragistics.GetSetHelper.MemberNameKey)obj);
			}

			// Token: 0x06000249 RID: 585 RVA: 0x0000A7E0 File Offset: 0x000089E0
			public override int GetHashCode()
			{
				return this.OwnerType.GetHashCode() ^ this.MemberName.GetHashCode();
			}

			// Token: 0x0600024A RID: 586 RVA: 0x0000A7F9 File Offset: 0x000089F9
			public bool Equals(global::Infragistics.GetSetHelper.MemberNameKey other)
			{
				return other.OwnerType == this.OwnerType && string.CompareOrdinal(other.MemberName, this.MemberName) == 0;
			}

			// Token: 0x04000090 RID: 144
			public global::System.Type OwnerType;

			// Token: 0x04000091 RID: 145
			public string MemberName;
		}
	}
}
