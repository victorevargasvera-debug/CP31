using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006F5 RID: 1781
	internal class ViewSimplifier
	{
		// Token: 0x060052E6 RID: 21222 RVA: 0x001289B0 File Offset: 0x00126BB0
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree SimplifyView(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree view)
		{
			view = new global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier(extent).Simplify(view);
			return view;
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x001289C1 File Offset: 0x00126BC1
		private ViewSimplifier(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase viewTarget)
		{
			this.extent = viewTarget;
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x001289D0 File Offset: 0x00126BD0
		private global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree Simplify(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree view)
		{
			global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> func = global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRuleProcessor.Create(new global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule[]
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule.Create(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier._patternCollapseNestedProjection, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.CollapseNestedProjection)),
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule.Create(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier._patternCase, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.SimplifyCaseStatement)),
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule.Create(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier._patternNestedTphDiscriminator, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.SimplifyNestedTphDiscriminator)),
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule.Create(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier._patternEntityConstructor, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this.AddFkRelatedEntityRefs))
			});
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = view.Query;
			dbExpression = func(dbExpression);
			view = global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(view.MetadataWorkspace, view.DataSpace, dbExpression, view.UseDatabaseNullSemantics, view.DisableFilterOverProjectionSimplificationForCustomFunctions);
			return view;
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x00128A7C File Offset: 0x00126C7C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AddFkRelatedEntityRefs(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression viewConstructor)
		{
			if (this.doNotProcess)
			{
				return null;
			}
			if (this.extent.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet || this.extent.EntityContainer.DataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				this.doNotProcess = true;
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet targetSet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)this.extent;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, bool> <>9__2;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> list = (from es in targetSet.EntityContainer.BaseEntitySets
			where es.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet
			select es).Cast<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>().Where(delegate(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet assocSet)
			{
				if (assocSet.ElementType.IsForeignKey)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> associationSetEnds = assocSet.AssociationSetEnds;
					global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, bool> predicate;
					if ((predicate = <>9__2) == null)
					{
						predicate = (<>9__2 = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd se) => se.EntitySet == targetSet));
					}
					return associationSetEnds.Any(predicate);
				}
				return false;
			}).ToList<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>();
			if (list.Count == 0)
			{
				this.doNotProcess = true;
				return null;
			}
			global::System.Collections.Generic.HashSet<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> hashSet = new global::System.Collections.Generic.HashSet<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in list)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = associationSet.ElementType.ReferentialConstraints[0];
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = associationSet.AssociationSetEnds[referentialConstraint.ToRole.Name];
				if (associationSetEnd.EntitySet == targetSet)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType item = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(associationSetEnd.CorrespondingAssociationEndMember.TypeUsage).ElementType;
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd item2 = associationSet.AssociationSetEnds[referentialConstraint.FromRole.Name];
					hashSet.Add(global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(item, item2, referentialConstraint));
				}
			}
			if (hashSet.Count == 0)
			{
				this.doNotProcess = true;
				return null;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)viewConstructor;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list3 = null;
			if (dbProjectExpression.Projection.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Case)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression dbCaseExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression)dbProjectExpression.Projection;
				list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbCaseExpression.When.Count);
				for (int i = 0; i < dbCaseExpression.When.Count; i++)
				{
					list3.Add(dbCaseExpression.When[i]);
					list2.Add((global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbCaseExpression.Then[i]);
				}
				list2.Add((global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbCaseExpression.Else);
			}
			else
			{
				list2.Add((global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbProjectExpression.Projection);
			}
			bool flag = false;
			for (int j = 0; j < list2.Count; j++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression entityConstructor = list2[j];
				global::System.Data.Entity.Core.Metadata.Edm.EntityType constructedEntityType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityConstructor.ResultType);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> list4 = (from psdt in hashSet
				where constructedEntityType == psdt.Item1 || constructedEntityType.IsSubtypeOf(psdt.Item1)
				select global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.RelatedEntityRefFromAssociationSetEnd(constructedEntityType, entityConstructor, psdt.Item2, psdt.Item3)).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef>();
				if (list4.Count > 0)
				{
					if (entityConstructor.HasRelatedEntityReferences)
					{
						list4 = entityConstructor.RelatedEntityReferences.Concat(list4).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef>();
					}
					entityConstructor = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateNewEntityWithRelationshipsExpression(constructedEntityType, entityConstructor.Arguments, list4);
					list2[j] = entityConstructor;
					flag = true;
				}
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result = null;
			if (flag)
			{
				if (list3 != null)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list5 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(list3.Count);
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list6 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(list3.Count);
					for (int k = 0; k < list3.Count; k++)
					{
						list5.Add(list3[k]);
						list6.Add(list2[k]);
					}
					result = dbProjectExpression.Input.Project(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(list5, list6, list2[list3.Count]));
				}
				else
				{
					result = dbProjectExpression.Input.Project(list2[0]);
				}
			}
			this.doNotProcess = true;
			return result;
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x00128E4C File Offset: 0x0012704C
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef RelatedEntityRefFromAssociationSetEnd(global::System.Data.Entity.Core.Metadata.Edm.EntityType constructedEntityType, global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression entityConstructor, global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd principalSetEnd, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint fkConstraint)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(fkConstraint.FromRole.TypeUsage).ElementType;
			global::System.Collections.Generic.IEnumerable<global::System.Tuple<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> source = from pv in constructedEntityType.Properties.Select((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p, int idx) => global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(p, entityConstructor.Arguments[idx]))
			join ft in fkConstraint.FromProperties.Select((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty fp, int idx) => global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(fp, fkConstraint.ToProperties[idx])) on pv.Item1 equals ft.Item2
			select global::System.Tuple.Create<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(ft.Item1.Name, pv.Item2);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValues;
			if (fkConstraint.FromProperties.Count == 1)
			{
				global::System.Tuple<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> tuple = source.Single<global::System.Tuple<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
				keyValues = new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					tuple.Item2
				};
			}
			else
			{
				global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValueMap = source.ToDictionary((global::System.Tuple<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pav) => pav.Item1, (global::System.Tuple<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> pav) => pav.Item2, global::System.StringComparer.Ordinal);
				keyValues = (from memberName in entityType.KeyMemberNames
				select keyValueMap[memberName]).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression targetEntity = principalSetEnd.EntitySet.CreateRef(entityType, keyValues);
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateRelatedEntityRef(fkConstraint.ToRole, fkConstraint.FromRole, targetEntity);
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00128FF4 File Offset: 0x001271F4
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression SimplifyNestedTphDiscriminator(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression booleanColumnFilter = (global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression)dbProjectExpression.Input.Expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)booleanColumnFilter.Input.Expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression dbFilterExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression)dbProjectExpression2.Input.Expression;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.FlattenOr(booleanColumnFilter.Predicate).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression> list2 = (from px in list.OfType<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>()
			where px.Instance.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference && ((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)px.Instance).VariableName == booleanColumnFilter.Input.VariableName
			select px).ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>();
			if (list.Count != list2.Count)
			{
				return null;
			}
			global::System.Collections.Generic.List<string> list3 = (from px in list2
			select px.Property.Name).ToList<string>();
			global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression> discriminatorPredicates = new global::System.Collections.Generic.Dictionary<object, global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>();
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(dbFilterExpression.Input.VariableType) || !global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.TryMatchDiscriminatorPredicate(dbFilterExpression, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression compEx, object discValue)
			{
				discriminatorPredicates.Add(discValue, compEx);
			}))
			{
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)discriminatorPredicates.First<global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>>().Value.Left).Property;
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbProjectExpression2.Projection;
			global::System.Data.Entity.Core.Metadata.Edm.RowType edmType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RowType>(dbNewInstanceExpression.ResultType);
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>();
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression> dictionary2 = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>();
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> dictionary3 = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbNewInstanceExpression.Arguments.Count);
			for (int i = 0; i < dbNewInstanceExpression.Arguments.Count; i++)
			{
				string name = edmType.Properties[i].Name;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = dbNewInstanceExpression.Arguments[i];
				if (list3.Contains(name))
				{
					if (dbExpression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Case)
					{
						return null;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression dbCaseExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression)dbExpression;
					if (dbCaseExpression.When.Count != 1 || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsBooleanType(dbCaseExpression.Then[0].ResultType) || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsBooleanType(dbCaseExpression.Else.ResultType) || dbCaseExpression.Then[0].ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant || dbCaseExpression.Else.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant || !(bool)((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)dbCaseExpression.Then[0]).Value || (bool)((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)dbCaseExpression.Else).Value)
					{
						return null;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression;
					object key;
					if (!global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.TryMatchPropertyEqualsValue(dbCaseExpression.When[0], dbProjectExpression2.Input.VariableName, out dbPropertyExpression, out key) || dbPropertyExpression.Property != edmProperty || !discriminatorPredicates.ContainsKey(key))
					{
						return null;
					}
					dictionary.Add(name, discriminatorPredicates[key]);
					dictionary2.Add(name, (global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression)dbCaseExpression.When[0]);
				}
				else
				{
					dictionary3.Add(name, dbExpression);
				}
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate = global::System.Data.Entity.Core.Common.Utils.Helpers.BuildBalancedTreeInPlace<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dictionary.Values), (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right) => left.Or(right));
			dbFilterExpression = dbFilterExpression.Input.Filter(predicate);
			global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression dbCaseExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression)dbProjectExpression.Projection;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list4 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbCaseExpression2.When.Count);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list5 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbCaseExpression2.Then.Count);
			for (int j = 0; j < dbCaseExpression2.When.Count; j++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)dbCaseExpression2.When[j];
				global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression original = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbCaseExpression2.Then[j];
				global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression item;
				if (!dictionary2.TryGetValue(dbPropertyExpression2.Property.Name, out item))
				{
					return null;
				}
				list4.Add(item);
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression item2 = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.ValueSubstituter.Substitute(original, dbProjectExpression.Input.VariableName, dictionary3);
				list5.Add(item2);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression elseExpression = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.ValueSubstituter.Substitute(dbCaseExpression2.Else, dbProjectExpression.Input.VariableName, dictionary3);
			global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression projection = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(list4, list5, elseExpression);
			return dbFilterExpression.BindAs(dbProjectExpression2.Input.VariableName).Project(projection);
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00129410 File Offset: 0x00127610
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression SimplifyCaseStatement(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression dbCaseExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression)expression;
			bool flag = false;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbCaseExpression.When.Count);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in dbCaseExpression.When)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression item;
				if (global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.TrySimplifyPredicate(dbExpression, out item))
				{
					list.Add(item);
					flag = true;
				}
				else
				{
					list.Add(dbExpression);
				}
			}
			if (!flag)
			{
				return null;
			}
			dbCaseExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Case(list, dbCaseExpression.Then, dbCaseExpression.Else);
			return dbCaseExpression;
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x001294AC File Offset: 0x001276AC
		private static bool TrySimplifyPredicate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression simplified)
		{
			simplified = null;
			if (predicate.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Case)
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression dbCaseExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression)predicate;
			if (dbCaseExpression.Then.Count != 1 && dbCaseExpression.Then[0].ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)dbCaseExpression.Then[0];
			if (!true.Equals(dbConstantExpression.Value))
			{
				return false;
			}
			if (dbCaseExpression.Else != null)
			{
				if (dbCaseExpression.Else.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
				{
					return false;
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)dbCaseExpression.Else;
				if (true.Equals(dbConstantExpression2.Value))
				{
					return false;
				}
			}
			simplified = dbCaseExpression.When[0];
			return true;
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x00129560 File Offset: 0x00127760
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CollapseNestedProjection(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection = dbProjectExpression.Projection;
			global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression2 = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)dbProjectExpression.Input.Expression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)dbProjectExpression2.Projection;
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dbNewInstanceExpression.Arguments.Count);
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)dbNewInstanceExpression.ResultType.EdmType;
			for (int i = 0; i < rowType.Members.Count; i++)
			{
				dictionary[rowType.Members[i].Name] = dbNewInstanceExpression.Arguments[i];
			}
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.ProjectionCollapser projectionCollapser = new global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.ProjectionCollapser(dictionary, dbProjectExpression.Input);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection2 = projectionCollapser.CollapseProjection(projection);
			if (projectionCollapser.IsDoomed)
			{
				return null;
			}
			return dbProjectExpression2.Input.Project(projection2);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x0012962C File Offset: 0x0012782C
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> FlattenOr(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			return global::System.Data.Entity.Core.Common.Utils.Helpers.GetLeafNodes<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(expression, (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp) => exp.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Or, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression dbOrExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression)exp;
				return new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					dbOrExpression.Left,
					dbOrExpression.Right
				};
			});
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x00129680 File Offset: 0x00127880
		internal static bool TryMatchDiscriminatorPredicate(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression filter, global::System.Action<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression, object> onMatchedComparison)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = null;
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.FlattenOr(filter.Predicate))
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression;
				object arg;
				if (!global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.TryMatchPropertyEqualsValue(dbExpression, filter.Input.VariableName, out dbPropertyExpression, out arg))
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
				onMatchedComparison((global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression)dbExpression, arg);
			}
			return true;
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x0012971C File Offset: 0x0012791C
		internal static bool TryMatchPropertyEqualsValue(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, string propertyVariable, out global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression property, out object value)
		{
			property = null;
			value = null;
			if (expression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals)
			{
				return false;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression dbBinaryExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression)expression;
			if (dbBinaryExpression.Left.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)
			{
				return false;
			}
			property = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)dbBinaryExpression.Left;
			return global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.TryMatchConstant(dbBinaryExpression.Right, out value) && property.Instance.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference && !(((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)property.Instance).VariableName != propertyVariable);
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x0012979C File Offset: 0x0012799C
		private static bool TryMatchConstant(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, out object value)
		{
			if (expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant)
			{
				value = ((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)expression).Value;
				return true;
			}
			if (expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Cast && expression.ResultType.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType && global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.TryMatchConstant(((global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression)expression).Argument, out value))
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)expression.ResultType.EdmType;
				value = global::System.Convert.ChangeType(value, primitiveType.ClrEquivalentType, global::System.Globalization.CultureInfo.InvariantCulture);
				return true;
			}
			value = null;
			return false;
		}

		// Token: 0x04001DF2 RID: 7666
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent;

		// Token: 0x04001DF3 RID: 7667
		private static readonly global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> _patternEntityConstructor = global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchProject(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.AnyExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.And(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchEntityType, global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.Or(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchNewInstance(), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchCase(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.AnyExpressions, global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchForAll(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchNewInstance()), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchNewInstance()))));

		// Token: 0x04001DF4 RID: 7668
		private bool doNotProcess;

		// Token: 0x04001DF5 RID: 7669
		private static readonly global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> _patternNestedTphDiscriminator = global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchProject(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchFilter(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchProject(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchFilter(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.AnyExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.Or(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Or))), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.And(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchRowType, global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchNewInstance(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchForAll(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.Or(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.And(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchNewInstance(), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchComplexType), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Case)))))), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.Or(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Or))), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.And(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchEntityType, global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchCase(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchForAll(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property)), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchForAll(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance)), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance))));

		// Token: 0x04001DF6 RID: 7670
		private static readonly global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> _patternCase = global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Case);

		// Token: 0x04001DF7 RID: 7671
		private static readonly global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> _patternCollapseNestedProjection = global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchProject(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchProject(global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.AnyExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance)), global::System.Data.Entity.Core.Common.CommandTrees.Internal.Patterns.AnyExpression);

		// Token: 0x02000CA7 RID: 3239
		private class ValueSubstituter : global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor
		{
			// Token: 0x06006C85 RID: 27781 RVA: 0x00171D7E File Offset: 0x0016FF7E
			internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Substitute(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression original, string referencedVariable, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> propertyValues)
			{
				return new global::System.Data.Entity.Core.Common.CommandTrees.Internal.ViewSimplifier.ValueSubstituter(referencedVariable, propertyValues).VisitExpression(original);
			}

			// Token: 0x06006C86 RID: 27782 RVA: 0x00171D8D File Offset: 0x0016FF8D
			private ValueSubstituter(string varName, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> replValues)
			{
				this.variableName = varName;
				this.replacements = replValues;
			}

			// Token: 0x06006C87 RID: 27783 RVA: 0x00171DA4 File Offset: 0x0016FFA4
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(expression, "expression");
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result;
				if (expression.Instance.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference && ((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)expression.Instance).VariableName == this.variableName && this.replacements.TryGetValue(expression.Property.Name, out dbExpression))
				{
					result = dbExpression;
				}
				else
				{
					result = base.Visit(expression);
				}
				return result;
			}

			// Token: 0x040031EA RID: 12778
			private readonly string variableName;

			// Token: 0x040031EB RID: 12779
			private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> replacements;
		}

		// Token: 0x02000CA8 RID: 3240
		private class ProjectionCollapser : global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor
		{
			// Token: 0x06006C88 RID: 27784 RVA: 0x00171E12 File Offset: 0x00170012
			internal ProjectionCollapser(global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> varRefMemberBindings, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding outerBinding)
			{
				this.m_varRefMemberBindings = varRefMemberBindings;
				this.m_outerBinding = outerBinding;
			}

			// Token: 0x06006C89 RID: 27785 RVA: 0x00171E28 File Offset: 0x00170028
			internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CollapseProjection(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
			{
				return this.VisitExpression(expression);
			}

			// Token: 0x06006C8A RID: 27786 RVA: 0x00171E34 File Offset: 0x00170034
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression property)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(property, "property");
				if (property.Instance.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference && this.IsOuterBindingVarRef((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)property.Instance))
				{
					return this.m_varRefMemberBindings[property.Property.Name];
				}
				return base.Visit(property);
			}

			// Token: 0x06006C8B RID: 27787 RVA: 0x00171E8D File Offset: 0x0017008D
			public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varRef)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(varRef, "varRef");
				if (this.IsOuterBindingVarRef(varRef))
				{
					this.m_doomed = true;
				}
				return base.Visit(varRef);
			}

			// Token: 0x06006C8C RID: 27788 RVA: 0x00171EB2 File Offset: 0x001700B2
			private bool IsOuterBindingVarRef(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varRef)
			{
				return varRef.VariableName == this.m_outerBinding.VariableName;
			}

			// Token: 0x1700119B RID: 4507
			// (get) Token: 0x06006C8D RID: 27789 RVA: 0x00171ECA File Offset: 0x001700CA
			internal bool IsDoomed
			{
				get
				{
					return this.m_doomed;
				}
			}

			// Token: 0x040031EC RID: 12780
			private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> m_varRefMemberBindings;

			// Token: 0x040031ED RID: 12781
			private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding m_outerBinding;

			// Token: 0x040031EE RID: 12782
			private bool m_doomed;
		}
	}
}
