using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000406 RID: 1030
	internal static class DelegateFactory
	{
		// Token: 0x06003025 RID: 12325 RVA: 0x00096F6C File Offset: 0x0009516C
		internal static global::System.Func<object> GetConstructorDelegateForType(global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType clrType)
		{
			global::System.Func<object> result;
			if ((result = clrType.Constructor) == null)
			{
				result = (clrType.Constructor = global::System.Data.Entity.Core.Objects.DelegateFactory.CreateConstructor(clrType.ClrType));
			}
			return result;
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x00096F98 File Offset: 0x00095198
		internal static global::System.Func<object> GetConstructorDelegateForType(global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType clrType)
		{
			global::System.Func<object> result;
			if ((result = clrType.Constructor) == null)
			{
				result = (clrType.Constructor = global::System.Data.Entity.Core.Objects.DelegateFactory.CreateConstructor(clrType.ClrType));
			}
			return result;
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00096FC3 File Offset: 0x000951C3
		internal static object GetValue(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, object target)
		{
			return global::System.Data.Entity.Core.Objects.DelegateFactory.GetGetterDelegateForProperty(property)(target);
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x00096FD4 File Offset: 0x000951D4
		internal static global::System.Func<object, object> GetGetterDelegateForProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			global::System.Func<object, object> result;
			if ((result = property.ValueGetter) == null)
			{
				result = (property.ValueGetter = global::System.Data.Entity.Core.Objects.DelegateFactory.CreatePropertyGetter(property.EntityDeclaringType, property.PropertyInfo));
			}
			return result;
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x00097005 File Offset: 0x00095205
		internal static void SetValue(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, object target, object value)
		{
			global::System.Data.Entity.Core.Objects.DelegateFactory.GetSetterDelegateForProperty(property)(target, value);
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x00097014 File Offset: 0x00095214
		internal static global::System.Action<object, object> GetSetterDelegateForProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			global::System.Action<object, object> action = property.ValueSetter;
			if (action == null)
			{
				action = global::System.Data.Entity.Core.Objects.DelegateFactory.CreatePropertySetter(property.EntityDeclaringType, property.PropertyInfo, property.Nullable);
				property.ValueSetter = action;
			}
			return action;
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x0009704C File Offset: 0x0009524C
		internal static global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd GetRelatedEnd(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager sourceRelationshipManager, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd existingRelatedEnd)
		{
			global::System.Func<global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd> func = sourceMember.GetRelatedEnd;
			if (func == null)
			{
				func = global::System.Data.Entity.Core.Objects.DelegateFactory.CreateGetRelatedEndMethod(sourceMember, targetMember);
				sourceMember.GetRelatedEnd = func;
			}
			return func(sourceRelationshipManager, existingRelatedEnd);
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x0009707C File Offset: 0x0009527C
		internal static global::System.Action<object, object> CreateNavigationPropertySetter(global::System.Type declaringType, global::System.Reflection.PropertyInfo navigationProperty)
		{
			global::System.Reflection.PropertyInfo propertyInfoForSet = navigationProperty.GetPropertyInfoForSet();
			global::System.Reflection.MethodInfo methodInfo = propertyInfoForSet.Setter();
			if (methodInfo == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyNoSetter);
			}
			if (methodInfo.IsStatic)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyIsStatic);
			}
			if (methodInfo.DeclaringType.IsValueType())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyDeclaringTypeIsValueType);
			}
			global::System.Linq.Expressions.ParameterExpression parameterExpression;
			global::System.Linq.Expressions.ParameterExpression parameterExpression2;
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Action<object, object>>(global::System.Linq.Expressions.Expression.Assign(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Convert(parameterExpression, declaringType), propertyInfoForSet), global::System.Linq.Expressions.Expression.Convert(parameterExpression2, navigationProperty.PropertyType)), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile();
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x00097134 File Offset: 0x00095334
		internal static global::System.Reflection.ConstructorInfo GetConstructorForType(global::System.Type type)
		{
			global::System.Reflection.ConstructorInfo declaredConstructor = type.GetDeclaredConstructor(new global::System.Type[0]);
			if (null == declaredConstructor)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_ConstructorNoParameterless(type.FullName));
			}
			return declaredConstructor;
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x0009716C File Offset: 0x0009536C
		internal static global::System.Linq.Expressions.NewExpression GetNewExpressionForCollectionType(global::System.Type type)
		{
			if (type.IsGenericType() && type.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.HashSet<>))
			{
				return global::System.Linq.Expressions.Expression.New(type.GetDeclaredConstructor(new global::System.Type[]
				{
					typeof(global::System.Collections.Generic.IEqualityComparer<>).MakeGenericType(type.GetGenericArguments())
				}), new global::System.Linq.Expressions.Expression[]
				{
					global::System.Linq.Expressions.Expression.New(typeof(global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer))
				});
			}
			return global::System.Linq.Expressions.Expression.New(global::System.Data.Entity.Core.Objects.DelegateFactory.GetConstructorForType(type));
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x000971E5 File Offset: 0x000953E5
		internal static global::System.Func<object> CreateConstructor(global::System.Type type)
		{
			global::System.Data.Entity.Core.Objects.DelegateFactory.GetConstructorForType(type);
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object>>(global::System.Linq.Expressions.Expression.New(type), new global::System.Linq.Expressions.ParameterExpression[0]).Compile();
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x00097204 File Offset: 0x00095404
		internal static global::System.Func<object, object> CreatePropertyGetter(global::System.Type entityDeclaringType, global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Reflection.MethodInfo methodInfo = propertyInfo.Getter();
			if (methodInfo == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyNoGetter);
			}
			if (methodInfo.IsStatic)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyIsStatic);
			}
			if (propertyInfo.DeclaringType.IsValueType())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyDeclaringTypeIsValueType);
			}
			if (propertyInfo.GetIndexParameters().Any<global::System.Reflection.ParameterInfo>())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyIsIndexed);
			}
			global::System.Type propertyType = propertyInfo.PropertyType;
			if (propertyType.IsPointer)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyUnsupportedType);
			}
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "entity");
			global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Convert(parameterExpression, entityDeclaringType), propertyInfo);
			if (propertyType.IsValueType())
			{
				expression = global::System.Linq.Expressions.Expression.Convert(expression, typeof(object));
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object, object>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x000972D8 File Offset: 0x000954D8
		internal static global::System.Action<object, object> CreatePropertySetter(global::System.Type entityDeclaringType, global::System.Reflection.PropertyInfo propertyInfo, bool allowNull)
		{
			global::System.Reflection.PropertyInfo property = global::System.Data.Entity.Core.Objects.DelegateFactory.ValidateSetterProperty(propertyInfo);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "entity");
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "target");
			global::System.Type propertyType = propertyInfo.PropertyType;
			if (propertyType.IsValueType() && global::System.Nullable.GetUnderlyingType(propertyType) == null)
			{
				allowNull = false;
			}
			global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.TypeIs(parameterExpression2, propertyType);
			if (allowNull)
			{
				expression = global::System.Linq.Expressions.Expression.Or(global::System.Linq.Expressions.Expression.ReferenceEqual(parameterExpression2, global::System.Linq.Expressions.Expression.Constant(null)), expression);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Action<object, object>>(global::System.Linq.Expressions.Expression.IfThenElse(expression, global::System.Linq.Expressions.Expression.Assign(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Convert(parameterExpression, entityDeclaringType), property), global::System.Linq.Expressions.Expression.Convert(parameterExpression2, propertyInfo.PropertyType)), global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Objects.DelegateFactory._throwSetInvalidValue, parameterExpression2, global::System.Linq.Expressions.Expression.Constant(propertyType), global::System.Linq.Expressions.Expression.Constant(entityDeclaringType.Name), global::System.Linq.Expressions.Expression.Constant(propertyInfo.Name))), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile();
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x000973BC File Offset: 0x000955BC
		internal static global::System.Reflection.PropertyInfo ValidateSetterProperty(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Reflection.PropertyInfo propertyInfoForSet = propertyInfo.GetPropertyInfoForSet();
			global::System.Reflection.MethodInfo methodInfo = propertyInfoForSet.Setter();
			if (methodInfo == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyNoSetter);
			}
			if (methodInfo.IsStatic)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyIsStatic);
			}
			if (propertyInfoForSet.DeclaringType.IsValueType())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyDeclaringTypeIsValueType);
			}
			if (propertyInfoForSet.GetIndexParameters().Any<global::System.Reflection.ParameterInfo>())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyIsIndexed);
			}
			if (propertyInfoForSet.PropertyType.IsPointer)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.CodeGen_PropertyUnsupportedType);
			}
			return propertyInfoForSet;
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x00097444 File Offset: 0x00095644
		private static global::System.Func<global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd> CreateGetRelatedEndMethod(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityTypeForEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(sourceMember);
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityTypeForEnd2 = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntityTypeForEnd(targetMember);
			global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor navigationPropertyAccessor = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetNavigationPropertyAccessor(entityTypeForEnd2, targetMember, sourceMember);
			global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor navigationPropertyAccessor2 = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetNavigationPropertyAccessor(entityTypeForEnd, sourceMember, targetMember);
			return (global::System.Func<global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd>)typeof(global::System.Data.Entity.Core.Objects.DelegateFactory).GetDeclaredMethod("CreateGetRelatedEndMethod", new global::System.Type[]
			{
				typeof(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember),
				typeof(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember),
				typeof(global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor),
				typeof(global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor)
			}).MakeGenericMethod(new global::System.Type[]
			{
				entityTypeForEnd.ClrType,
				entityTypeForEnd2.ClrType
			}).Invoke(null, new object[]
			{
				sourceMember,
				targetMember,
				navigationPropertyAccessor,
				navigationPropertyAccessor2
			});
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x00097500 File Offset: 0x00095700
		private static global::System.Func<global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd> CreateGetRelatedEndMethod<TSource, TTarget>(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceMember, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetMember, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor sourceAccessor, global::System.Data.Entity.Core.Metadata.Edm.NavigationPropertyAccessor targetAccessor) where TSource : class where TTarget : class
		{
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = targetMember.RelationshipMultiplicity;
			global::System.Func<global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd> result;
			if (relationshipMultiplicity > global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
			{
				if (relationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					global::System.Type typeFromHandle = typeof(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity);
					throw new global::System.ArgumentOutOfRangeException(typeFromHandle.Name, global::System.Data.Entity.Resources.Strings.ADP_InvalidEnumerationValue(typeFromHandle.Name, ((int)targetMember.RelationshipMultiplicity).ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
				}
				result = ((global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager manager, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd) => manager.GetRelatedCollection<TSource, TTarget>(sourceMember, targetMember, sourceAccessor, targetAccessor, relatedEnd));
			}
			else
			{
				result = ((global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager manager, global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd) => manager.GetRelatedReference<TSource, TTarget>(sourceMember, targetMember, sourceAccessor, targetAccessor, relatedEnd));
			}
			return result;
		}

		// Token: 0x04001023 RID: 4131
		private static readonly global::System.Reflection.MethodInfo _throwSetInvalidValue = typeof(global::System.Data.Entity.Core.EntityUtil).GetDeclaredMethod("ThrowSetInvalidValue", new global::System.Type[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(string),
			typeof(string)
		});
	}
}
