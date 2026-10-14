using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace Infragistics
{
	// Token: 0x02000049 RID: 73
	internal static class GetSetHelper
	{
		// Token: 0x060002CD RID: 717 RVA: 0x0000BCB0 File Offset: 0x00009EB0
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
					global::Infragistics.CoreUtilities.GetUnderlyingType(typeof(TOwner)).FullName
				}), "getter");
			}
			return global::Infragistics.GetSetHelper.Get<TOwner, TProperty>(member);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000BD44 File Offset: 0x00009F44
		public static global::Infragistics.GetSetProxy<TOwner, TProperty> Get<TOwner, TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TOwner, TProperty>> getter) where TOwner : class
		{
			global::System.Linq.Expressions.MemberExpression memberExpression = getter.Body as global::System.Linq.Expressions.MemberExpression;
			if (memberExpression == null)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_InvalidMemberExpression"), "getter");
			}
			return global::Infragistics.GetSetHelper.Get<TOwner, TProperty>(memberExpression.Member);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000BD80 File Offset: 0x00009F80
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

		// Token: 0x060002D0 RID: 720 RVA: 0x0000BE2C File Offset: 0x0000A02C
		public static global::Infragistics.GetSetProxy<TOwner, TProperty> Get<TOwner, TProperty>(global::System.Reflection.MemberInfo member) where TOwner : class
		{
			object obj;
			if (!global::Infragistics.GetSetHelper.CachedByMemberInfo.TryGetValue(member, out obj))
			{
				obj = (global::Infragistics.GetSetHelper.CachedByMemberInfo[member] = global::Infragistics.GetSetHelper.Create<TOwner, TProperty>(member));
			}
			return (global::Infragistics.GetSetProxy<TOwner, TProperty>)obj;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000BE64 File Offset: 0x0000A064
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
				global::Infragistics.CoreUtilities.GetUnderlyingType(typeof(TOwner)).FullName
			}));
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000BF20 File Offset: 0x0000A120
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
			global::System.Action<TOwner, TProperty> setter = null;
			global::System.Func<TOwner, TProperty> getter = null;
			try
			{
				setter = ((!includeSetter) ? null : global::System.Linq.Expressions.Expression.Lambda<global::System.Action<TOwner, TProperty>>(global::System.Linq.Expressions.Expression.Assign(memberExpression, right), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression2,
					parameterExpression
				}).Compile());
				getter = ((!includeGetter) ? null : global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TOwner, TProperty>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression2
				}).Compile());
			}
			catch (global::System.MissingMemberException)
			{
				if (!(memberExpression.Member is global::System.Reflection.PropertyInfo))
				{
					throw;
				}
				global::Infragistics.GetSetHelper.PropertyInfoWrapper<TOwner, TProperty> @object = new global::Infragistics.GetSetHelper.PropertyInfoWrapper<TOwner, TProperty>(memberExpression.Member as global::System.Reflection.PropertyInfo);
				if (includeSetter)
				{
					setter = new global::System.Action<TOwner, TProperty>(@object.SetValue);
				}
				if (includeGetter)
				{
					getter = new global::System.Func<TOwner, TProperty>(@object.GetValue);
				}
			}
			global::System.Reflection.MemberInfo member = memberExpression.Member;
			return new global::Infragistics.GetSetProxy<TOwner, TProperty>(getter, setter, member.Name, global::Infragistics.GetSetHelper.GetDisplayName(member));
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000C068 File Offset: 0x0000A268
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

		// Token: 0x060002D4 RID: 724 RVA: 0x0000C198 File Offset: 0x0000A398
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

		// Token: 0x040000E6 RID: 230
		private static global::System.Collections.Generic.Dictionary<global::System.Reflection.MemberInfo, object> CachedByMemberInfo = new global::System.Collections.Generic.Dictionary<global::System.Reflection.MemberInfo, object>();

		// Token: 0x040000E7 RID: 231
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.GetSetHelper.MemberNameKey, object> CachedByMemberName = new global::System.Collections.Generic.Dictionary<global::Infragistics.GetSetHelper.MemberNameKey, object>();

		// Token: 0x040000E8 RID: 232
		private static global::System.Reflection.MethodInfo _displayAttributeGetNameMethod = null;

		// Token: 0x040000E9 RID: 233
		private static bool _skipGetDisplayName;

		// Token: 0x0200004A RID: 74
		private class PropertyInfoWrapper<TOwner, TProperty>
		{
			// Token: 0x060002D6 RID: 726 RVA: 0x0000C210 File Offset: 0x0000A410
			internal PropertyInfoWrapper(global::System.Reflection.PropertyInfo property)
			{
				this._property = property;
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x0000C21F File Offset: 0x0000A41F
			public TProperty GetValue(TOwner owner)
			{
				return (TProperty)((object)this._property.GetValue(owner, null));
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x0000C238 File Offset: 0x0000A438
			public void SetValue(TOwner owner, TProperty property)
			{
				this._property.SetValue(owner, property, null);
			}

			// Token: 0x040000EA RID: 234
			private global::System.Reflection.PropertyInfo _property;
		}

		// Token: 0x0200004B RID: 75
		private struct MemberNameKey : global::System.IEquatable<global::Infragistics.GetSetHelper.MemberNameKey>
		{
			// Token: 0x060002D9 RID: 729 RVA: 0x0000C252 File Offset: 0x0000A452
			public override bool Equals(object obj)
			{
				return obj is global::Infragistics.GetSetHelper.MemberNameKey && this.Equals((global::Infragistics.GetSetHelper.MemberNameKey)obj);
			}

			// Token: 0x060002DA RID: 730 RVA: 0x0000C26A File Offset: 0x0000A46A
			public override int GetHashCode()
			{
				return this.OwnerType.GetHashCode() ^ this.MemberName.GetHashCode();
			}

			// Token: 0x060002DB RID: 731 RVA: 0x0000C283 File Offset: 0x0000A483
			public bool Equals(global::Infragistics.GetSetHelper.MemberNameKey other)
			{
				return other.OwnerType == this.OwnerType && string.CompareOrdinal(other.MemberName, this.MemberName) == 0;
			}

			// Token: 0x040000EB RID: 235
			public global::System.Type OwnerType;

			// Token: 0x040000EC RID: 236
			public string MemberName;
		}
	}
}
