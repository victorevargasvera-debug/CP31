using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200044B RID: 1099
	internal sealed class LazyLoadBehavior
	{
		// Token: 0x060035A2 RID: 13730 RVA: 0x000ABF4C File Offset: 0x000AA14C
		internal static global::System.Func<TProxy, TItem, bool> GetInterceptorDelegate<TProxy, TItem>(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, global::System.Func<object, object> getEntityWrapperDelegate) where TProxy : class where TItem : class
		{
			global::System.Func<TProxy, TItem, bool> result = (TProxy proxy, TItem item) => true;
			if (member.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty)
			{
				global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navProperty = (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)member;
				if (navProperty.ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					result = ((TProxy proxy, TItem item) => global::System.Data.Entity.Core.Objects.Internal.LazyLoadBehavior.LoadProperty<TItem>(item, navProperty.RelationshipType.Identity, navProperty.ToEndMember.Identity, false, getEntityWrapperDelegate(proxy)));
				}
				else
				{
					result = ((TProxy proxy, TItem item) => global::System.Data.Entity.Core.Objects.Internal.LazyLoadBehavior.LoadProperty<TItem>(item, navProperty.RelationshipType.Identity, navProperty.ToEndMember.Identity, true, getEntityWrapperDelegate(proxy)));
				}
			}
			return result;
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x000ABFCC File Offset: 0x000AA1CC
		internal static bool IsLazyLoadCandidate(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			bool result = false;
			if (member.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = ((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)member).ToEndMember.RelationshipMultiplicity;
				global::System.Type propertyType = ospaceEntityType.ClrType.GetTopProperty(member.Name).PropertyType;
				if (relationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					result = (propertyType.TryGetElementType(typeof(global::System.Collections.Generic.ICollection<>)) != null);
				}
				else if (relationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One || relationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne)
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x000AC034 File Offset: 0x000AA234
		private static bool LoadProperty<TItem>(TItem propertyValue, string relationshipName, string targetRoleName, bool mustBeNull, object wrapperObject) where TItem : class
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper)wrapperObject;
			if (entityWrapper != null && entityWrapper.Context != null)
			{
				global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager = entityWrapper.RelationshipManager;
				if (relationshipManager != null && (!mustBeNull || propertyValue == null))
				{
					relationshipManager.GetRelatedEndInternal(relationshipName, targetRoleName).DeferredLoad();
				}
			}
			return propertyValue != null;
		}
	}
}
