using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000455 RID: 1109
	internal sealed class PocoPropertyAccessorStrategy : global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy
	{
		// Token: 0x0600362C RID: 13868 RVA: 0x000AD826 File Offset: 0x000ABA26
		public PocoPropertyAccessorStrategy(object entity)
		{
			this._entity = entity;
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x000AD838 File Offset: 0x000ABA38
		public object GetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			object result = null;
			if (relatedEnd != null)
			{
				if (relatedEnd.TargetAccessor.ValueGetter == null)
				{
					global::System.Type declaringType = global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.GetDeclaringType(relatedEnd);
					global::System.Reflection.PropertyInfo topProperty = declaringType.GetTopProperty(relatedEnd.TargetAccessor.PropertyName);
					if (topProperty == null)
					{
						throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.PocoEntityWrapper_UnableToSetFieldOrProperty(relatedEnd.TargetAccessor.PropertyName, declaringType.FullName));
					}
					global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory entityProxyFactory = new global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory();
					relatedEnd.TargetAccessor.ValueGetter = entityProxyFactory.CreateBaseGetter(topProperty.DeclaringType, topProperty);
				}
				bool state = relatedEnd.DisableLazyLoading();
				try
				{
					result = relatedEnd.TargetAccessor.ValueGetter(this._entity);
				}
				catch (global::System.Exception innerException)
				{
					throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.PocoEntityWrapper_UnableToSetFieldOrProperty(relatedEnd.TargetAccessor.PropertyName, this._entity.GetType().FullName), innerException);
				}
				finally
				{
					relatedEnd.ResetLazyLoading(state);
				}
			}
			return result;
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x000AD928 File Offset: 0x000ABB28
		public void SetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
			if (relatedEnd != null)
			{
				if (relatedEnd.TargetAccessor.ValueSetter == null)
				{
					global::System.Type declaringType = global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.GetDeclaringType(relatedEnd);
					global::System.Reflection.PropertyInfo topProperty = declaringType.GetTopProperty(relatedEnd.TargetAccessor.PropertyName);
					if (topProperty == null)
					{
						throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.PocoEntityWrapper_UnableToSetFieldOrProperty(relatedEnd.TargetAccessor.PropertyName, declaringType.FullName));
					}
					global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory entityProxyFactory = new global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory();
					relatedEnd.TargetAccessor.ValueSetter = entityProxyFactory.CreateBaseSetter(topProperty.DeclaringType, topProperty);
				}
				try
				{
					relatedEnd.TargetAccessor.ValueSetter(this._entity, value);
				}
				catch (global::System.Exception innerException)
				{
					throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.PocoEntityWrapper_UnableToSetFieldOrProperty(relatedEnd.TargetAccessor.PropertyName, this._entity.GetType().FullName), innerException);
				}
			}
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x000AD9F8 File Offset: 0x000ABBF8
		private static global::System.Type GetDeclaringType(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			if (relatedEnd.NavigationProperty != null)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Util.GetObjectMapping((global::System.Data.Entity.Core.Metadata.Edm.EntityType)relatedEnd.NavigationProperty.DeclaringType, relatedEnd.WrappedOwner.Context.MetadataWorkspace).ClrType.ClrType;
			}
			return relatedEnd.WrappedOwner.IdentityType;
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x000ADA48 File Offset: 0x000ABC48
		private static global::System.Type GetNavigationPropertyType(global::System.Type entityType, string propertyName)
		{
			global::System.Reflection.PropertyInfo topProperty = entityType.GetTopProperty(propertyName);
			global::System.Type result;
			if (topProperty != null)
			{
				result = topProperty.PropertyType;
			}
			else
			{
				global::System.Reflection.FieldInfo field = entityType.GetField(propertyName);
				if (!(field != null))
				{
					throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.PocoEntityWrapper_UnableToSetFieldOrProperty(propertyName, entityType.FullName));
				}
				result = field.FieldType;
			}
			return result;
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x000ADA9C File Offset: 0x000ABC9C
		public void CollectionAdd(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
			object entity = this._entity;
			try
			{
				object obj = this.GetNavigationPropertyValue(relatedEnd);
				if (obj == null)
				{
					obj = this.CollectionCreate(relatedEnd);
					this.SetNavigationPropertyValue(relatedEnd, obj);
				}
				if (obj != relatedEnd)
				{
					if (relatedEnd.TargetAccessor.CollectionAdd == null)
					{
						relatedEnd.TargetAccessor.CollectionAdd = global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.CreateCollectionAddFunction(global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.GetDeclaringType(relatedEnd), relatedEnd.TargetAccessor.PropertyName);
					}
					relatedEnd.TargetAccessor.CollectionAdd(obj, value);
				}
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.PocoEntityWrapper_UnableToSetFieldOrProperty(relatedEnd.TargetAccessor.PropertyName, entity.GetType().FullName), innerException);
			}
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x000ADB48 File Offset: 0x000ABD48
		private static global::System.Action<object, object> CreateCollectionAddFunction(global::System.Type type, string propertyName)
		{
			global::System.Type collectionElementType = global::System.Data.Entity.Core.EntityUtil.GetCollectionElementType(global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.GetNavigationPropertyType(type, propertyName));
			return (global::System.Action<object, object>)global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.AddToCollectionGeneric.MakeGenericMethod(new global::System.Type[]
			{
				collectionElementType
			}).Invoke(null, null);
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x000ADB82 File Offset: 0x000ABD82
		private static global::System.Action<object, object> AddToCollection<T>()
		{
			return delegate(object collectionArg, object item)
			{
				global::System.Collections.Generic.ICollection<!0> collection = (global::System.Collections.Generic.ICollection<!0>)collectionArg;
				global::System.Array array = collection as global::System.Array;
				if (array != null && array.IsFixedSize)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_CannotAddToFixedSizeArray(array.GetType()));
				}
				collection.Add((T)((object)item));
			};
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x000ADBA4 File Offset: 0x000ABDA4
		public bool CollectionRemove(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value)
		{
			object entity = this._entity;
			try
			{
				object navigationPropertyValue = this.GetNavigationPropertyValue(relatedEnd);
				if (navigationPropertyValue != null)
				{
					if (navigationPropertyValue == relatedEnd)
					{
						return true;
					}
					if (relatedEnd.TargetAccessor.CollectionRemove == null)
					{
						relatedEnd.TargetAccessor.CollectionRemove = global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.CreateCollectionRemoveFunction(global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.GetDeclaringType(relatedEnd), relatedEnd.TargetAccessor.PropertyName);
					}
					return relatedEnd.TargetAccessor.CollectionRemove(navigationPropertyValue, value);
				}
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.PocoEntityWrapper_UnableToSetFieldOrProperty(relatedEnd.TargetAccessor.PropertyName, entity.GetType().FullName), innerException);
			}
			return false;
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x000ADC48 File Offset: 0x000ABE48
		private static global::System.Func<object, object, bool> CreateCollectionRemoveFunction(global::System.Type type, string propertyName)
		{
			global::System.Type collectionElementType = global::System.Data.Entity.Core.EntityUtil.GetCollectionElementType(global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.GetNavigationPropertyType(type, propertyName));
			return (global::System.Func<object, object, bool>)global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.RemoveFromCollectionGeneric.MakeGenericMethod(new global::System.Type[]
			{
				collectionElementType
			}).Invoke(null, null);
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x000ADC82 File Offset: 0x000ABE82
		private static global::System.Func<object, object, bool> RemoveFromCollection<T>()
		{
			return delegate(object collectionArg, object item)
			{
				global::System.Collections.Generic.ICollection<!0> collection = (global::System.Collections.Generic.ICollection<!0>)collectionArg;
				global::System.Array array = collection as global::System.Array;
				if (array != null && array.IsFixedSize)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.RelatedEnd_CannotRemoveFromFixedSizeArray(array.GetType()));
				}
				return collection.Remove((T)((object)item));
			};
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x000ADCA4 File Offset: 0x000ABEA4
		public object CollectionCreate(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd)
		{
			if (this._entity is global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships)
			{
				return relatedEnd;
			}
			if (relatedEnd.TargetAccessor.CollectionCreate == null)
			{
				global::System.Type declaringType = global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.GetDeclaringType(relatedEnd);
				string propertyName = relatedEnd.TargetAccessor.PropertyName;
				global::System.Type navigationPropertyType = global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.GetNavigationPropertyType(declaringType, propertyName);
				relatedEnd.TargetAccessor.CollectionCreate = global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy.CreateCollectionCreateDelegate(navigationPropertyType, propertyName);
			}
			return relatedEnd.TargetAccessor.CollectionCreate();
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x000ADD08 File Offset: 0x000ABF08
		private static global::System.Func<object> CreateCollectionCreateDelegate(global::System.Type navigationPropertyType, string propName)
		{
			global::System.Type type = global::System.Data.Entity.Core.EntityUtil.DetermineCollectionType(navigationPropertyType);
			if (type == null)
			{
				throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.PocoEntityWrapper_UnableToMaterializeArbitaryNavPropType(propName, navigationPropertyType));
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object>>(global::System.Data.Entity.Core.Objects.DelegateFactory.GetNewExpressionForCollectionType(type), new global::System.Linq.Expressions.ParameterExpression[0]).Compile();
		}

		// Token: 0x0400117F RID: 4479
		internal static readonly global::System.Reflection.MethodInfo AddToCollectionGeneric = typeof(global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy).GetOnlyDeclaredMethod("AddToCollection");

		// Token: 0x04001180 RID: 4480
		internal static readonly global::System.Reflection.MethodInfo RemoveFromCollectionGeneric = typeof(global::System.Data.Entity.Core.Objects.Internal.PocoPropertyAccessorStrategy).GetOnlyDeclaredMethod("RemoveFromCollection");

		// Token: 0x04001181 RID: 4481
		private readonly object _entity;
	}
}
