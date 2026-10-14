using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x02000586 RID: 1414
	internal class FragmentQueryKB : global::System.Data.Entity.Core.Common.Utils.Boolean.KnowledgeBase<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>
	{
		// Token: 0x06004472 RID: 17522 RVA: 0x000EFA8E File Offset: 0x000EDC8E
		internal override void AddFact(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> fact)
		{
			base.AddFact(fact);
			this._kbExpression = new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>[]
			{
				this._kbExpression,
				fact
			});
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06004473 RID: 17523 RVA: 0x000EFAB5 File Offset: 0x000EDCB5
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> KbExpression
		{
			get
			{
				return this._kbExpression;
			}
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x000EFABD File Offset: 0x000EDCBD
		internal void CreateVariableConstraints(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			this.CreateVariableConstraintsRecursion(extent.ElementType, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(extent), domainMap, edmItemCollection);
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x000EFAD4 File Offset: 0x000EDCD4
		internal void CreateAssociationConstraints(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = extent as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
			if (associationSet != null)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean(associationSet), domainMap);
				global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> associationkeys = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Metadata.Edm.EntityType>>();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember in associationSet.ElementType.AssociationEndMembers)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType type = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)associationEndMember.TypeUsage.EdmType).ElementType;
					type.KeyMembers.All((global::System.Data.Entity.Core.Metadata.Edm.EdmMember member) => associationkeys.Add(new global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(member, type)) || true);
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSet.AssociationSetEnds)
				{
					global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmType> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmType>();
					hashSet.UnionWith(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(associationSetEnd.CorrespondingAssociationEndMember.TypeUsage.EdmType, edmItemCollection, false));
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKB.CreateIsOfTypeCondition(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(associationSetEnd.EntitySet), hashSet, domainMap);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression3 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean(associationSetEnd), domainMap);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression4 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean(associationSetEnd.EntitySet), domainMap),
						boolExpression2
					});
					base.AddImplication(boolExpression3.Tree, boolExpression4.Tree);
					if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsEveryOtherEndAtLeastOne(associationSet, associationSetEnd.CorrespondingAssociationEndMember))
					{
						base.AddImplication(boolExpression4.Tree, boolExpression3.Tree);
					}
					if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.DoesEndKeySubsumeAssociationSetKey(associationSet, associationSetEnd.CorrespondingAssociationEndMember, associationkeys))
					{
						base.AddEquivalence(boolExpression3.Tree, boolExpression.Tree);
					}
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in associationSet.ElementType.ReferentialConstraints)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)referentialConstraint.ToRole;
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetAtEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntitySetAtEnd(associationSet, endMember);
					if (global::System.Data.Entity.Core.Common.Utils.Helpers.IsSetEqual<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(global::System.Data.Entity.Core.Common.Utils.Helpers.AsSuperTypeList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(referentialConstraint.ToProperties), entitySetAtEnd.ElementType.KeyMembers, global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Default) && referentialConstraint.FromRole.RelationshipMultiplicity.Equals(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One))
					{
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression5 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean(associationSet.AssociationSetEnds[0]), domainMap);
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression6 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean(associationSet.AssociationSetEnds[1]), domainMap);
						base.AddEquivalence(boolExpression5.Tree, boolExpression6.Tree);
					}
				}
			}
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x000EFDA4 File Offset: 0x000EDFA4
		internal void CreateEquivalenceConstraintForOneToOneForeignKeyAssociation(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet assocSet, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in assocSet.ElementType.ReferentialConstraints)
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)referentialConstraint.ToRole;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember2 = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)referentialConstraint.FromRole;
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetAtEnd = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntitySetAtEnd(assocSet, endMember);
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetAtEnd2 = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntitySetAtEnd(assocSet, endMember2);
				if (global::System.Data.Entity.Core.Common.Utils.Helpers.IsSetEqual<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(global::System.Data.Entity.Core.Common.Utils.Helpers.AsSuperTypeList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(referentialConstraint.ToProperties), entitySetAtEnd.ElementType.KeyMembers, global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Default))
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean(entitySetAtEnd2), domainMap);
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.RoleBoolean(entitySetAtEnd), domainMap);
					base.AddEquivalence(boolExpression.Tree, boolExpression2.Tree);
				}
			}
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x000EFE78 File Offset: 0x000EE078
		private void CreateVariableConstraintsRecursion(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmType> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmType>();
			hashSet.UnionWith(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(edmType, edmItemCollection, true));
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 in hashSet)
			{
				global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmType> hashSet2 = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmType>();
				hashSet2.UnionWith(global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(edmType2, edmItemCollection, false));
				if (hashSet2.Count != 0)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateNot(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKB.CreateIsOfTypeCondition(currentPath, hashSet2, domainMap));
					if (boolExpression.IsSatisfiable())
					{
						foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in ((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)edmType2).GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
						{
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(currentPath, edmProperty);
							bool flag = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsNonRefSimpleMember(edmProperty);
							if (domainMap.IsConditionMember(memberPath) || domainMap.IsProjectedConditionMember(memberPath))
							{
								global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> possibleDiscreteValues = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(domainMap.GetDomain(memberPath));
								global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression2;
								if (flag)
								{
									boolExpression2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ScalarRestriction(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(memberPath), new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined, possibleDiscreteValues)), domainMap);
								}
								else
								{
									boolExpression2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(memberPath), new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.Undefined, possibleDiscreteValues)), domainMap);
								}
								base.AddEquivalence(boolExpression.Tree, boolExpression2.Tree);
							}
							if (!flag)
							{
								this.CreateVariableConstraintsRecursion(memberPath.EdmType, memberPath, domainMap, edmItemCollection);
							}
						}
					}
				}
			}
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x000F0018 File Offset: 0x000EE218
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression CreateIsOfTypeCondition(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath currentPath, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmType> derivedTypes, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain domain = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Domain(from derivedType in derivedTypes
			select new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeConstant(derivedType), domainMap.GetDomain(currentPath));
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateLiteral(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.TypeRestriction(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot(currentPath), domain), domainMap);
		}

		// Token: 0x040018A4 RID: 6308
		private global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> _kbExpression = global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Value;
	}
}
