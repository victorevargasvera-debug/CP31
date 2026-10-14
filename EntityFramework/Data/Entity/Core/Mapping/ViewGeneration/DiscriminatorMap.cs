using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x02000569 RID: 1385
	internal class DiscriminatorMap
	{
		// Token: 0x060043A3 RID: 17315 RVA: 0x000E95FC File Offset: 0x000E77FC
		private DiscriminatorMap(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression discriminator, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> typeMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> propertyMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> relPropertyMap, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			this.Discriminator = discriminator;
			this.TypeMap = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType>>(typeMap);
			this.PropertyMap = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(propertyMap.ToList<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>());
			this.RelPropertyMap = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(relPropertyMap.ToList<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>());
			this.EntitySet = entitySet;
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x000E9650 File Offset: 0x000E7850
		internal static bool TryCreateDiscriminatorMap(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression queryView, out global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap discriminatorMap)
		{
			discriminatorMap = null;
			if (queryView.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)queryView;
			if (dbProjectExpression.Projection.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Case)
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression dbCaseExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression)dbProjectExpression.Projection;
			if (dbProjectExpression.Projection.ResultType.EdmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
			{
				return false;
			}
			if (dbProjectExpression.Input.Expression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter)
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter = (global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression)dbProjectExpression.Input.Expression;
			global::System.Collections.Generic.HashSet<object> discriminatorDomain = new global::System.Collections.Generic.HashSet<object>();
			if (!global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.TryMatchDiscriminatorPredicate(filter, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression equalsExp, object discriminatorValue)
			{
				discriminatorDomain.Add(discriminatorValue);
			}))
			{
				return false;
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType>>();
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> propertyMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> relPropertyMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>> typeToRelPropertyMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>>();
			global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression discriminator = null;
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = null;
			for (int i = 0; i < dbCaseExpression.When.Count; i++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression = dbCaseExpression.When[i];
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression then = dbCaseExpression.Then[i];
				string variableName = dbProjectExpression.Input.VariableName;
				global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression;
				object obj;
				if (!global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.TryMatchPropertyEqualsValue(expression, variableName, out dbPropertyExpression, out obj))
				{
					return false;
				}
				if (edmProperty == null)
				{
					edmProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)dbPropertyExpression.Property;
				}
				else if (edmProperty != dbPropertyExpression.Property)
				{
					return false;
				}
				discriminator = dbPropertyExpression;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType value;
				if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.TryMatchEntityTypeConstructor(then, propertyMap, relPropertyMap, typeToRelPropertyMap, out value))
				{
					return false;
				}
				list.Add(new global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(obj, value));
				discriminatorDomain.Remove(obj);
			}
			if (1 != discriminatorDomain.Count)
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType value2;
			if (dbCaseExpression.Else == null || !global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.TryMatchEntityTypeConstructor(dbCaseExpression.Else, propertyMap, relPropertyMap, typeToRelPropertyMap, out value2))
			{
				return false;
			}
			list.Add(new global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(discriminatorDomain.Single<object>(), value2));
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.CheckForMissingRelProperties(relPropertyMap, typeToRelPropertyMap))
			{
				return false;
			}
			int num = (from map in list
			select map.Key).Distinct(global::System.Data.Entity.Core.Common.Utils.TrailingSpaceComparer.Instance).Count<object>();
			int count = list.Count;
			if (num != count)
			{
				return false;
			}
			discriminatorMap = new global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap(discriminator, list, propertyMap, relPropertyMap, entitySet);
			return true;
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x000E986C File Offset: 0x000E7A6C
		private static bool CheckForMissingRelProperties(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> relPropertyMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>> typeToRelPropertyMap)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty in relPropertyMap.Keys)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>> keyValuePair in typeToRelPropertyMap)
				{
					if (keyValuePair.Key.IsSubtypeOf(relProperty.FromEnd.TypeUsage.EdmType) && !keyValuePair.Value.Contains(relProperty))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x000E9924 File Offset: 0x000E7B24
		private static bool TryMatchEntityTypeConstructor(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression then, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> propertyMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> relPropertyMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>> typeToRelPropertyMap, out global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			if (then.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance)
			{
				entityType = null;
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)then;
			entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)dbNewInstanceExpression.ResultType.EdmType;
			for (int i = 0; i < entityType.Properties.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty key = entityType.Properties[i];
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = dbNewInstanceExpression.Arguments[i];
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression y;
				if (propertyMap.TryGetValue(key, out y))
				{
					if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.ExpressionsCompatible(dbExpression, y))
					{
						return false;
					}
				}
				else
				{
					propertyMap.Add(key, dbExpression);
				}
			}
			if (dbNewInstanceExpression.HasRelatedEntityReferences)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> list;
				if (!typeToRelPropertyMap.TryGetValue(entityType, out list))
				{
					list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>();
					typeToRelPropertyMap[entityType] = list;
				}
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef dbRelatedEntityRef in dbNewInstanceExpression.RelatedEntityReferences)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty = new global::System.Data.Entity.Core.Query.InternalTrees.RelProperty((global::System.Data.Entity.Core.Metadata.Edm.RelationshipType)dbRelatedEntityRef.TargetEnd.DeclaringType, dbRelatedEntityRef.SourceEnd, dbRelatedEntityRef.TargetEnd);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression targetEntityReference = dbRelatedEntityRef.TargetEntityReference;
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression y2;
					if (relPropertyMap.TryGetValue(relProperty, out y2))
					{
						if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.ExpressionsCompatible(targetEntityReference, y2))
						{
							return false;
						}
					}
					else
					{
						relPropertyMap.Add(relProperty, targetEntityReference);
					}
					list.Add(relProperty);
				}
				return true;
			}
			return true;
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x000E9A7C File Offset: 0x000E7C7C
		private static bool ExpressionsCompatible(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression x, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression y)
		{
			if (x.ExpressionKind != y.ExpressionKind)
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind expressionKind = x.ExpressionKind;
			if (expressionKind <= global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
			{
				if (expressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance)
				{
					if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)x;
						global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)y;
						return dbPropertyExpression.Property == dbPropertyExpression2.Property && global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.ExpressionsCompatible(dbPropertyExpression.Instance, dbPropertyExpression2.Instance);
					}
				}
				else
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)x;
					global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)y;
					if (!dbNewInstanceExpression.ResultType.EdmType.EdmEquals(dbNewInstanceExpression2.ResultType.EdmType))
					{
						return false;
					}
					for (int i = 0; i < dbNewInstanceExpression.Arguments.Count; i++)
					{
						if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.ExpressionsCompatible(dbNewInstanceExpression.Arguments[i], dbNewInstanceExpression2.Arguments[i]))
						{
							return false;
						}
					}
					return true;
				}
			}
			else
			{
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Ref)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression dbRefExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression)x;
					global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression dbRefExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression)y;
					return dbRefExpression.EntitySet.EdmEquals(dbRefExpression2.EntitySet) && global::System.Data.Entity.Core.Mapping.ViewGeneration.DiscriminatorMap.ExpressionsCompatible(dbRefExpression.Argument, dbRefExpression2.Argument);
				}
				if (expressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference)
				{
					return ((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)x).VariableName == ((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)y).VariableName;
				}
			}
			return false;
		}

		// Token: 0x04001825 RID: 6181
		internal readonly global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression Discriminator;

		// Token: 0x04001826 RID: 6182
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> TypeMap;

		// Token: 0x04001827 RID: 6183
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> PropertyMap;

		// Token: 0x04001828 RID: 6184
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> RelPropertyMap;

		// Token: 0x04001829 RID: 6185
		internal readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet;
	}
}
