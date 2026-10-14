using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000521 RID: 1313
	internal abstract class BaseMetadataMappingVisitor
	{
		// Token: 0x060040BE RID: 16574 RVA: 0x000D95EF File Offset: 0x000D77EF
		protected BaseMetadataMappingVisitor(bool sortSequence)
		{
			this._sortSequence = sortSequence;
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x000D9600 File Offset: 0x000D7800
		protected virtual void Visit(global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			this.Visit(entityContainerMapping.EdmEntityContainer);
			this.Visit(entityContainerMapping.StorageEntityContainer);
			foreach (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping in this.GetSequence<global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping>(entityContainerMapping.EntitySetMaps, (global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping it) => global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(it)))
			{
				this.Visit(setMapping);
			}
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x000D968C File Offset: 0x000D788C
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase)
		{
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = entitySetBase.BuiltInTypeKind;
			if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet)
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet)
				{
					this.Visit((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)entitySetBase);
					return;
				}
			}
			else
			{
				this.Visit((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)entitySetBase);
			}
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x000D96C4 File Offset: 0x000D78C4
		protected virtual void Visit(global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping setMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping in this.GetSequence<global::System.Data.Entity.Core.Mapping.TypeMapping>(setMapping.TypeMappings, (global::System.Data.Entity.Core.Mapping.TypeMapping it) => global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(it)))
			{
				this.Visit(typeMapping);
			}
			this.Visit(setMapping.EntityContainerMapping);
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x000D9744 File Offset: 0x000D7944
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(entityContainer.BaseEntitySets, (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase it) => it.Identity))
			{
				this.Visit(entitySetBase);
			}
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x000D97B8 File Offset: 0x000D79B8
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			this.Visit(entitySet.ElementType);
			this.Visit(entitySet.EntityContainer);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x000D97D4 File Offset: 0x000D79D4
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet)
		{
			this.Visit(associationSet.ElementType);
			this.Visit(associationSet.EntityContainer);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>(associationSet.AssociationSetEnds, (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd it) => it.Identity))
			{
				this.Visit(associationSetEnd);
			}
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x000D9860 File Offset: 0x000D7A60
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(entityType.KeyMembers, (global::System.Data.Entity.Core.Metadata.Edm.EdmMember it) => it.Identity))
			{
				this.Visit(edmMember);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember2 in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(entityType.GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(), (global::System.Data.Entity.Core.Metadata.Edm.EdmMember it) => it.Identity))
			{
				this.Visit(edmMember2);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(entityType.NavigationProperties, (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty it) => it.Identity))
			{
				this.Visit(navigationProperty);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(entityType.Properties, (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty it) => it.Identity))
			{
				this.Visit(edmProperty);
			}
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x000D9A00 File Offset: 0x000D7C00
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(associationType.AssociationEndMembers, (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember it) => it.Identity))
			{
				this.Visit(associationEndMember);
			}
			this.Visit(associationType.BaseType);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(associationType.KeyMembers, (global::System.Data.Entity.Core.Metadata.Edm.EdmMember it) => it.Identity))
			{
				this.Visit(edmMember);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember2 in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(associationType.GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(), (global::System.Data.Entity.Core.Metadata.Edm.EdmMember it) => it.Identity))
			{
				this.Visit(edmMember2);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>(associationType.ReferentialConstraints, (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint it) => it.Identity))
			{
				this.Visit(referentialConstraint);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>(associationType.RelationshipEndMembers, (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember it) => it.Identity))
			{
				this.Visit(relationshipEndMember);
			}
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x000D9C14 File Offset: 0x000D7E14
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd)
		{
			this.Visit(associationSetEnd.CorrespondingAssociationEndMember);
			this.Visit(associationSetEnd.EntitySet);
			this.Visit(associationSetEnd.ParentAssociationSet);
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x000D9C3A File Offset: 0x000D7E3A
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty)
		{
			this.Visit(edmProperty.TypeUsage);
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x000D9C48 File Offset: 0x000D7E48
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty)
		{
			this.Visit(navigationProperty.FromEndMember);
			this.Visit(navigationProperty.RelationshipType);
			this.Visit(navigationProperty.ToEndMember);
			this.Visit(navigationProperty.TypeUsage);
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x000D9C7A File Offset: 0x000D7E7A
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember)
		{
			this.Visit(edmMember.TypeUsage);
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x000D9C88 File Offset: 0x000D7E88
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember)
		{
			this.Visit(associationEndMember.TypeUsage);
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x000D9C98 File Offset: 0x000D7E98
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(referentialConstraint.FromProperties, (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty it) => it.Identity))
			{
				this.Visit(edmProperty);
			}
			this.Visit(referentialConstraint.FromRole);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(referentialConstraint.ToProperties, (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty it) => it.Identity))
			{
				this.Visit(edmProperty2);
			}
			this.Visit(referentialConstraint.ToRole);
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x000D9D84 File Offset: 0x000D7F84
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember)
		{
			this.Visit(relationshipEndMember.TypeUsage);
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x000D9D94 File Offset: 0x000D7F94
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			this.Visit(typeUsage.EdmType);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.Facet facet in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.Facet>(typeUsage.Facets, (global::System.Data.Entity.Core.Metadata.Edm.Facet it) => it.Identity))
			{
				this.Visit(facet);
			}
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x000D9E14 File Offset: 0x000D8014
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType)
		{
			if (relationshipType == null)
			{
				return;
			}
			if (relationshipType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType)
			{
				this.Visit((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)relationshipType);
			}
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x000D9E30 File Offset: 0x000D8030
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			if (edmType == null)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = edmType.BuiltInTypeKind;
			if (builtInTypeKind > global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
			{
				switch (builtInTypeKind)
				{
				case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType:
					this.Visit((global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType);
					return;
				case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType:
					this.Visit((global::System.Data.Entity.Core.Metadata.Edm.EnumType)edmType);
					break;
				case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumMember:
				case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Facet:
					break;
				case global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmFunction:
					this.Visit((global::System.Data.Entity.Core.Metadata.Edm.EdmFunction)edmType);
					return;
				default:
					if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
					{
						this.Visit((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType);
						return;
					}
					if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType)
					{
						return;
					}
					this.Visit((global::System.Data.Entity.Core.Metadata.Edm.RefType)edmType);
					return;
				}
				return;
			}
			if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType)
			{
				this.Visit((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)edmType);
				return;
			}
			if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
			{
				this.Visit((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)edmType);
				return;
			}
			if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
			{
				return;
			}
			this.Visit((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)edmType);
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x000D9EE8 File Offset: 0x000D80E8
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.Facet facet)
		{
			this.Visit(facet.FacetType);
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x000D9EF8 File Offset: 0x000D80F8
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction)
		{
			this.Visit(edmFunction.BaseType);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(edmFunction.EntitySets, (global::System.Data.Entity.Core.Metadata.Edm.EntitySet it) => it.Identity))
			{
				if (entitySet != null)
				{
					this.Visit(entitySet);
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(edmFunction.Parameters, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter it) => it.Identity))
			{
				this.Visit(functionParameter);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter2 in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(edmFunction.ReturnParameters, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter it) => it.Identity))
			{
				this.Visit(functionParameter2);
			}
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x000DA040 File Offset: 0x000D8240
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x000DA044 File Offset: 0x000D8244
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			this.Visit(complexType.BaseType);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(complexType.Members, (global::System.Data.Entity.Core.Metadata.Edm.EdmMember it) => it.Identity))
			{
				this.Visit(edmMember);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(complexType.Properties, (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty it) => it.Identity))
			{
				this.Visit(edmProperty);
			}
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x000DA124 File Offset: 0x000D8324
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.RefType refType)
		{
			this.Visit(refType.BaseType);
			this.Visit(refType.ElementType);
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x000DA140 File Offset: 0x000D8340
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EnumMember>(enumType.Members, (global::System.Data.Entity.Core.Metadata.Edm.EnumMember it) => it.Identity))
			{
				this.Visit(enumMember);
			}
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x000DA1B4 File Offset: 0x000D83B4
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember)
		{
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x000DA1B6 File Offset: 0x000D83B6
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType)
		{
			this.Visit(collectionType.BaseType);
			this.Visit(collectionType.TypeUsage);
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x000DA1D0 File Offset: 0x000D83D0
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase)
		{
			if (entityTypeBase == null)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = entityTypeBase.BuiltInTypeKind;
			if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType)
			{
				this.Visit((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)entityTypeBase);
				return;
			}
			if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
			{
				return;
			}
			this.Visit((global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityTypeBase);
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x000DA20B File Offset: 0x000D840B
		protected virtual void Visit(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter)
		{
			this.Visit(functionParameter.DeclaringFunction);
			this.Visit(functionParameter.TypeUsage);
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x000DA225 File Offset: 0x000D8425
		protected virtual void Visit(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x000DA228 File Offset: 0x000D8428
		protected virtual void Visit(global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(typeMapping.IsOfTypes, (global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase it) => it.Identity))
			{
				this.Visit(entityTypeBase);
			}
			foreach (global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment in this.GetSequence<global::System.Data.Entity.Core.Mapping.MappingFragment>(typeMapping.MappingFragments, (global::System.Data.Entity.Core.Mapping.MappingFragment it) => global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(it)))
			{
				this.Visit(mappingFragment);
			}
			this.Visit(typeMapping.SetMapping);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase2 in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(typeMapping.Types, (global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase it) => it.Identity))
			{
				this.Visit(entityTypeBase2);
			}
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x000DA36C File Offset: 0x000D856C
		protected virtual void Visit(global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment)
		{
			foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping in this.GetSequence<global::System.Data.Entity.Core.Mapping.PropertyMapping>(mappingFragment.AllProperties, (global::System.Data.Entity.Core.Mapping.PropertyMapping it) => global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(it)))
			{
				this.Visit(propertyMapping);
			}
			this.Visit(mappingFragment.TableSet);
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x000DA3EC File Offset: 0x000D85EC
		protected virtual void Visit(global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping)
		{
			if (propertyMapping.GetType() == typeof(global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping))
			{
				this.Visit((global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping)propertyMapping);
				return;
			}
			if (propertyMapping.GetType() == typeof(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping))
			{
				this.Visit((global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping)propertyMapping);
				return;
			}
			if (propertyMapping.GetType() == typeof(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping))
			{
				this.Visit((global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping)propertyMapping);
			}
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x000DA464 File Offset: 0x000D8664
		protected virtual void Visit(global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping)
		{
			this.Visit(complexPropertyMapping.Property);
			foreach (global::System.Data.Entity.Core.Mapping.ComplexTypeMapping complexTypeMapping in this.GetSequence<global::System.Data.Entity.Core.Mapping.ComplexTypeMapping>(complexPropertyMapping.TypeMappings, (global::System.Data.Entity.Core.Mapping.ComplexTypeMapping it) => global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(it)))
			{
				this.Visit(complexTypeMapping);
			}
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x000DA4E4 File Offset: 0x000D86E4
		protected virtual void Visit(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping)
		{
			this.Visit(conditionPropertyMapping.Column);
			this.Visit(conditionPropertyMapping.Property);
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x000DA4FE File Offset: 0x000D86FE
		protected virtual void Visit(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping)
		{
			this.Visit(scalarPropertyMapping.Column);
			this.Visit(scalarPropertyMapping.Property);
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x000DA518 File Offset: 0x000D8718
		protected virtual void Visit(global::System.Data.Entity.Core.Mapping.ComplexTypeMapping complexTypeMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping in this.GetSequence<global::System.Data.Entity.Core.Mapping.PropertyMapping>(complexTypeMapping.AllProperties, (global::System.Data.Entity.Core.Mapping.PropertyMapping it) => global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(it)))
			{
				this.Visit(propertyMapping);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(complexTypeMapping.IsOfTypes, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType it) => it.Identity))
			{
				this.Visit(complexType);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType2 in this.GetSequence<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(complexTypeMapping.Types, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType it) => it.Identity))
			{
				this.Visit(complexType2);
			}
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x000DA650 File Offset: 0x000D8850
		protected global::System.Collections.Generic.IEnumerable<T> GetSequence<T>(global::System.Collections.Generic.IEnumerable<T> sequence, global::System.Func<T, string> keySelector)
		{
			if (!this._sortSequence)
			{
				return sequence;
			}
			return sequence.OrderBy(keySelector, global::System.StringComparer.Ordinal);
		}

		// Token: 0x04001682 RID: 5762
		private readonly bool _sortSequence;

		// Token: 0x02000B2E RID: 2862
		internal static class IdentityHelper
		{
			// Token: 0x06006516 RID: 25878 RVA: 0x0015B80B File Offset: 0x00159A0B
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping mapping)
			{
				return mapping.Set.Identity;
			}

			// Token: 0x06006517 RID: 25879 RVA: 0x0015B818 File Offset: 0x00159A18
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.TypeMapping mapping)
			{
				global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = mapping as global::System.Data.Entity.Core.Mapping.EntityTypeMapping;
				if (entityTypeMapping != null)
				{
					return global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(entityTypeMapping);
				}
				return global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity((global::System.Data.Entity.Core.Mapping.AssociationTypeMapping)mapping);
			}

			// Token: 0x06006518 RID: 25880 RVA: 0x0015B844 File Offset: 0x00159A44
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.EntityTypeMapping mapping)
			{
				global::System.Linq.IOrderedEnumerable<string> first = (from it in mapping.Types
				select it.Identity).OrderBy((string it) => it, global::System.StringComparer.Ordinal);
				global::System.Linq.IOrderedEnumerable<string> second = (from it in mapping.IsOfTypes
				select it.Identity).OrderBy((string it) => it, global::System.StringComparer.Ordinal);
				return string.Join(",", first.Concat(second));
			}

			// Token: 0x06006519 RID: 25881 RVA: 0x0015B90A File Offset: 0x00159B0A
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.AssociationTypeMapping mapping)
			{
				return mapping.AssociationType.Identity;
			}

			// Token: 0x0600651A RID: 25882 RVA: 0x0015B918 File Offset: 0x00159B18
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.ComplexTypeMapping mapping)
			{
				global::System.Linq.IOrderedEnumerable<string> first = (from it in mapping.AllProperties
				select global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(it)).OrderBy((string it) => it, global::System.StringComparer.Ordinal);
				global::System.Linq.IOrderedEnumerable<string> second = (from it in mapping.Types
				select it.Identity).OrderBy((string it) => it, global::System.StringComparer.Ordinal);
				global::System.Linq.IOrderedEnumerable<string> second2 = (from it in mapping.IsOfTypes
				select it.Identity).OrderBy((string it) => it, global::System.StringComparer.Ordinal);
				return string.Join(",", first.Concat(second).Concat(second2));
			}

			// Token: 0x0600651B RID: 25883 RVA: 0x0015BA38 File Offset: 0x00159C38
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.MappingFragment mapping)
			{
				return mapping.TableSet.Identity;
			}

			// Token: 0x0600651C RID: 25884 RVA: 0x0015BA48 File Offset: 0x00159C48
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.PropertyMapping mapping)
			{
				global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping scalarPropertyMapping = mapping as global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping;
				if (scalarPropertyMapping != null)
				{
					return global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(scalarPropertyMapping);
				}
				global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping complexPropertyMapping = mapping as global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping;
				if (complexPropertyMapping != null)
				{
					return global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(complexPropertyMapping);
				}
				global::System.Data.Entity.Core.Mapping.EndPropertyMapping endPropertyMapping = mapping as global::System.Data.Entity.Core.Mapping.EndPropertyMapping;
				if (endPropertyMapping != null)
				{
					return global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity(endPropertyMapping);
				}
				return global::System.Data.Entity.Core.Mapping.BaseMetadataMappingVisitor.IdentityHelper.GetIdentity((global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping)mapping);
			}

			// Token: 0x0600651D RID: 25885 RVA: 0x0015BA94 File Offset: 0x00159C94
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping mapping)
			{
				return string.Concat(new string[]
				{
					"ScalarProperty(Identity=",
					mapping.Property.Identity,
					",ColumnIdentity=",
					mapping.Column.Identity,
					")"
				});
			}

			// Token: 0x0600651E RID: 25886 RVA: 0x0015BAE0 File Offset: 0x00159CE0
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.ComplexPropertyMapping mapping)
			{
				return "ComplexProperty(Identity=" + mapping.Property.Identity + ")";
			}

			// Token: 0x0600651F RID: 25887 RVA: 0x0015BAFC File Offset: 0x00159CFC
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping mapping)
			{
				if (mapping.Property == null)
				{
					return "ConditionProperty(ColumnIdentity=" + mapping.Column.Identity + ")";
				}
				return "ConditionProperty(Identity=" + mapping.Property.Identity + ")";
			}

			// Token: 0x06006520 RID: 25888 RVA: 0x0015BB3B File Offset: 0x00159D3B
			public static string GetIdentity(global::System.Data.Entity.Core.Mapping.EndPropertyMapping mapping)
			{
				return "EndProperty(Identity=" + mapping.AssociationEnd.Identity + ")";
			}
		}
	}
}
