using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Edm.Services;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation
{
	// Token: 0x0200020C RID: 524
	internal class NavigationPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration
	{
		// Token: 0x06001BB3 RID: 7091 RVA: 0x0004BA02 File Offset: 0x00049C02
		internal NavigationPropertyConfiguration(global::System.Reflection.PropertyInfo navigationProperty)
		{
			this._navigationProperty = navigationProperty;
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0004BA14 File Offset: 0x00049C14
		private NavigationPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration source)
		{
			this._navigationProperty = source._navigationProperty;
			this._endKind = source._endKind;
			this._inverseNavigationProperty = source._inverseNavigationProperty;
			this._inverseEndKind = source._inverseEndKind;
			this._constraint = ((source._constraint == null) ? null : source._constraint.Clone());
			this._associationMappingConfiguration = ((source._associationMappingConfiguration == null) ? null : source._associationMappingConfiguration.Clone());
			this.DeleteAction = source.DeleteAction;
			this.IsNavigationPropertyDeclaringTypePrincipal = source.IsNavigationPropertyDeclaringTypePrincipal;
			this._modificationStoredProceduresConfiguration = ((source._modificationStoredProceduresConfiguration == null) ? null : source._modificationStoredProceduresConfiguration.Clone());
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0004BAC3 File Offset: 0x00049CC3
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration(this);
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0004BACB File Offset: 0x00049CCB
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x0004BAD3 File Offset: 0x00049CD3
		public global::System.Data.Entity.Core.Metadata.Edm.OperationAction? DeleteAction { get; set; }

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0004BADC File Offset: 0x00049CDC
		internal global::System.Reflection.PropertyInfo NavigationProperty
		{
			get
			{
				return this._navigationProperty;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x0004BAE4 File Offset: 0x00049CE4
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0004BAEC File Offset: 0x00049CEC
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? RelationshipMultiplicity
		{
			get
			{
				return this._endKind;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity>(value, "value");
				this._endKind = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x0004BB01 File Offset: 0x00049D01
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x0004BB09 File Offset: 0x00049D09
		internal global::System.Reflection.PropertyInfo InverseNavigationProperty
		{
			get
			{
				return this._inverseNavigationProperty;
			}
			set
			{
				if (value == this._navigationProperty)
				{
					throw global::System.Data.Entity.Resources.Error.NavigationInverseItself(value.Name, value.ReflectedType);
				}
				this._inverseNavigationProperty = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x0004BB32 File Offset: 0x00049D32
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x0004BB3A File Offset: 0x00049D3A
		internal global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? InverseEndKind
		{
			get
			{
				return this._inverseEndKind;
			}
			set
			{
				this._inverseEndKind = value;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x0004BB43 File Offset: 0x00049D43
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x0004BB4B File Offset: 0x00049D4B
		public global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration Constraint
		{
			get
			{
				return this._constraint;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration>(value, "value");
				this._constraint = value;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x0004BB60 File Offset: 0x00049D60
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x0004BB68 File Offset: 0x00049D68
		internal bool? IsNavigationPropertyDeclaringTypePrincipal { get; set; }

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x0004BB71 File Offset: 0x00049D71
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x0004BB79 File Offset: 0x00049D79
		internal global::System.Data.Entity.ModelConfiguration.Configuration.AssociationMappingConfiguration AssociationMappingConfiguration
		{
			get
			{
				return this._associationMappingConfiguration;
			}
			set
			{
				this._associationMappingConfiguration = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x0004BB82 File Offset: 0x00049D82
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x0004BB8A File Offset: 0x00049D8A
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration ModificationStoredProceduresConfiguration
		{
			get
			{
				return this._modificationStoredProceduresConfiguration;
			}
			set
			{
				this._modificationStoredProceduresConfiguration = value;
			}
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0004BB94 File Offset: 0x00049D94
		internal void Configure(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration)
		{
			navigationProperty.SetConfiguration(this);
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType association = navigationProperty.Association;
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration = association.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration;
			if (navigationPropertyConfiguration == null)
			{
				association.SetConfiguration(this);
			}
			else
			{
				this.EnsureConsistency(navigationPropertyConfiguration);
			}
			this.ConfigureInverse(association, model);
			this.ConfigureEndKinds(association, navigationPropertyConfiguration);
			this.ConfigureDependentBehavior(association, model, entityTypeConfiguration);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0004BBE8 File Offset: 0x00049DE8
		internal void Configure(global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			if (this.AssociationMappingConfiguration != null)
			{
				associationSetMapping.SetConfiguration(this);
				this.AssociationMappingConfiguration.Configure(associationSetMapping, databaseMapping.Database, this._navigationProperty);
			}
			if (this._modificationStoredProceduresConfiguration != null)
			{
				if (associationSetMapping.ModificationFunctionMapping == null)
				{
					new global::System.Data.Entity.ModelConfiguration.Edm.Services.ModificationFunctionMappingGenerator(providerManifest).Generate(associationSetMapping, databaseMapping);
				}
				this._modificationStoredProceduresConfiguration.Configure(associationSetMapping.ModificationFunctionMapping, providerManifest);
			}
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0004BC4C File Offset: 0x00049E4C
		private void ConfigureInverse(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			if (this._inverseNavigationProperty == null)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = model.GetNavigationProperty(this._inverseNavigationProperty);
			if (navigationProperty != null && navigationProperty.Association != associationType)
			{
				associationType.SourceEnd.RelationshipMultiplicity = navigationProperty.Association.TargetEnd.RelationshipMultiplicity;
				if (associationType.Constraint == null && this._constraint == null && navigationProperty.Association.Constraint != null)
				{
					associationType.Constraint = navigationProperty.Association.Constraint;
					associationType.Constraint.FromRole = associationType.SourceEnd;
					associationType.Constraint.ToRole = associationType.TargetEnd;
				}
				model.RemoveAssociationType(navigationProperty.Association);
				navigationProperty.RelationshipType = associationType;
				navigationProperty.FromEndMember = associationType.TargetEnd;
				navigationProperty.ToEndMember = associationType.SourceEnd;
			}
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0004BD20 File Offset: 0x00049F20
		private void ConfigureEndKinds(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration configuration)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = associationType.SourceEnd;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2 = associationType.TargetEnd;
			if (configuration != null && configuration.InverseNavigationProperty != null)
			{
				associationEndMember = associationType.TargetEnd;
				associationEndMember2 = associationType.SourceEnd;
			}
			if (this._inverseEndKind != null)
			{
				associationEndMember.RelationshipMultiplicity = this._inverseEndKind.Value;
			}
			if (this._endKind != null)
			{
				associationEndMember2.RelationshipMultiplicity = this._endKind.Value;
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0004BD98 File Offset: 0x00049F98
		private void EnsureConsistency(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration)
		{
			if (this.RelationshipMultiplicity != null)
			{
				if (navigationPropertyConfiguration.InverseEndKind == null)
				{
					navigationPropertyConfiguration.InverseEndKind = this.RelationshipMultiplicity;
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? inverseEndKind = navigationPropertyConfiguration.InverseEndKind;
					global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? relationshipMultiplicity = this.RelationshipMultiplicity;
					if (!(inverseEndKind.GetValueOrDefault() == relationshipMultiplicity.GetValueOrDefault() & inverseEndKind != null == (relationshipMultiplicity != null)))
					{
						throw global::System.Data.Entity.Resources.Error.ConflictingMultiplicities(this.NavigationProperty.Name, this.NavigationProperty.ReflectedType);
					}
				}
			}
			if (this.InverseEndKind != null)
			{
				if (navigationPropertyConfiguration.RelationshipMultiplicity == null)
				{
					navigationPropertyConfiguration.RelationshipMultiplicity = this.InverseEndKind;
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? relationshipMultiplicity = navigationPropertyConfiguration.RelationshipMultiplicity;
					global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? inverseEndKind = this.InverseEndKind;
					if (!(relationshipMultiplicity.GetValueOrDefault() == inverseEndKind.GetValueOrDefault() & relationshipMultiplicity != null == (inverseEndKind != null)))
					{
						if (this.InverseNavigationProperty == null)
						{
							throw global::System.Data.Entity.Resources.Error.ConflictingMultiplicities(this.NavigationProperty.Name, this.NavigationProperty.ReflectedType);
						}
						throw global::System.Data.Entity.Resources.Error.ConflictingMultiplicities(this.InverseNavigationProperty.Name, this.InverseNavigationProperty.ReflectedType);
					}
				}
			}
			if (this.DeleteAction != null)
			{
				if (navigationPropertyConfiguration.DeleteAction == null)
				{
					navigationPropertyConfiguration.DeleteAction = this.DeleteAction;
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.OperationAction? deleteAction = navigationPropertyConfiguration.DeleteAction;
					global::System.Data.Entity.Core.Metadata.Edm.OperationAction? deleteAction2 = this.DeleteAction;
					if (!(deleteAction.GetValueOrDefault() == deleteAction2.GetValueOrDefault() & deleteAction != null == (deleteAction2 != null)))
					{
						throw global::System.Data.Entity.Resources.Error.ConflictingCascadeDeleteOperation(this.NavigationProperty.Name, this.NavigationProperty.ReflectedType);
					}
				}
			}
			if (this.Constraint != null)
			{
				if (navigationPropertyConfiguration.Constraint == null)
				{
					navigationPropertyConfiguration.Constraint = this.Constraint;
				}
				else if (!object.Equals(navigationPropertyConfiguration.Constraint, this.Constraint))
				{
					throw global::System.Data.Entity.Resources.Error.ConflictingConstraint(this.NavigationProperty.Name, this.NavigationProperty.ReflectedType);
				}
			}
			if (this.IsNavigationPropertyDeclaringTypePrincipal != null)
			{
				if (navigationPropertyConfiguration.IsNavigationPropertyDeclaringTypePrincipal == null)
				{
					navigationPropertyConfiguration.IsNavigationPropertyDeclaringTypePrincipal = !this.IsNavigationPropertyDeclaringTypePrincipal;
				}
				else
				{
					bool? isNavigationPropertyDeclaringTypePrincipal = navigationPropertyConfiguration.IsNavigationPropertyDeclaringTypePrincipal;
					bool? isNavigationPropertyDeclaringTypePrincipal2 = this.IsNavigationPropertyDeclaringTypePrincipal;
					if (isNavigationPropertyDeclaringTypePrincipal.GetValueOrDefault() == isNavigationPropertyDeclaringTypePrincipal2.GetValueOrDefault() & isNavigationPropertyDeclaringTypePrincipal != null == (isNavigationPropertyDeclaringTypePrincipal2 != null))
					{
						throw global::System.Data.Entity.Resources.Error.ConflictingConstraint(this.NavigationProperty.Name, this.NavigationProperty.ReflectedType);
					}
				}
			}
			if (this.AssociationMappingConfiguration != null)
			{
				if (navigationPropertyConfiguration.AssociationMappingConfiguration == null)
				{
					navigationPropertyConfiguration.AssociationMappingConfiguration = this.AssociationMappingConfiguration;
				}
				else if (!object.Equals(navigationPropertyConfiguration.AssociationMappingConfiguration, this.AssociationMappingConfiguration))
				{
					throw global::System.Data.Entity.Resources.Error.ConflictingMapping(this.NavigationProperty.Name, this.NavigationProperty.ReflectedType);
				}
			}
			if (this.ModificationStoredProceduresConfiguration != null)
			{
				if (navigationPropertyConfiguration.ModificationStoredProceduresConfiguration == null)
				{
					navigationPropertyConfiguration.ModificationStoredProceduresConfiguration = this.ModificationStoredProceduresConfiguration;
					return;
				}
				if (!navigationPropertyConfiguration.ModificationStoredProceduresConfiguration.IsCompatibleWith(this.ModificationStoredProceduresConfiguration))
				{
					throw global::System.Data.Entity.Resources.Error.ConflictingFunctionsMapping(this.NavigationProperty.Name, this.NavigationProperty.ReflectedType);
				}
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0004C0D4 File Offset: 0x0004A2D4
		private void ConfigureDependentBehavior(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2;
			if (!associationType.TryGuessPrincipalAndDependentEnds(out associationEndMember, out associationEndMember2))
			{
				if (this.IsNavigationPropertyDeclaringTypePrincipal != null)
				{
					associationType.MarkPrincipalConfigured();
					global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = model.EntityTypes.SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => et.DeclaredNavigationProperties).Single((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty np) => np.RelationshipType.Equals(associationType) && np.GetClrPropertyInfo().IsSameAs(this.NavigationProperty));
					associationEndMember = (this.IsNavigationPropertyDeclaringTypePrincipal.Value ? associationType.GetOtherEnd(navigationProperty.ResultEnd) : navigationProperty.ResultEnd);
					associationEndMember2 = associationType.GetOtherEnd(associationEndMember);
					if (associationType.SourceEnd != associationEndMember)
					{
						associationType.SourceEnd = associationEndMember;
						associationType.TargetEnd = associationEndMember2;
						global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = model.Containers.SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EntityContainer ct) => ct.AssociationSets).Single((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet aset) => aset.ElementType == associationType);
						global::System.Data.Entity.Core.Metadata.Edm.EntitySet sourceSet = associationSet.SourceSet;
						associationSet.SourceSet = associationSet.TargetSet;
						associationSet.TargetSet = sourceSet;
					}
				}
				if (associationEndMember == null)
				{
					associationEndMember2 = associationType.TargetEnd;
				}
			}
			this.ConfigureConstraint(associationType, associationEndMember2, entityTypeConfiguration);
			this.ConfigureDeleteAction(associationType.GetOtherEnd(associationEndMember2));
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0004C248 File Offset: 0x0004A448
		private void ConfigureConstraint(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentEnd, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration)
		{
			if (this._constraint != null)
			{
				this._constraint.Configure(associationType, dependentEnd, entityTypeConfiguration);
				global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint = associationType.Constraint;
				if (constraint != null && constraint.ToProperties.SequenceEqual(constraint.ToRole.GetEntityType().KeyProperties) && this._inverseEndKind == null && associationType.SourceEnd.IsMany())
				{
					associationType.SourceEnd.RelationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne;
					associationType.TargetEnd.RelationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
				}
			}
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0004C2C4 File Offset: 0x0004A4C4
		private void ConfigureDeleteAction(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember principalEnd)
		{
			if (this.DeleteAction != null)
			{
				principalEnd.DeleteBehavior = this.DeleteAction.Value;
			}
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0004C2F5 File Offset: 0x0004A4F5
		internal void Reset()
		{
			this._endKind = null;
			this._inverseNavigationProperty = null;
			this._inverseEndKind = null;
			this._constraint = null;
			this._associationMappingConfiguration = null;
		}

		// Token: 0x04000ACE RID: 2766
		private readonly global::System.Reflection.PropertyInfo _navigationProperty;

		// Token: 0x04000ACF RID: 2767
		private global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? _endKind;

		// Token: 0x04000AD0 RID: 2768
		private global::System.Reflection.PropertyInfo _inverseNavigationProperty;

		// Token: 0x04000AD1 RID: 2769
		private global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity? _inverseEndKind;

		// Token: 0x04000AD2 RID: 2770
		private global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration _constraint;

		// Token: 0x04000AD3 RID: 2771
		private global::System.Data.Entity.ModelConfiguration.Configuration.AssociationMappingConfiguration _associationMappingConfiguration;

		// Token: 0x04000AD4 RID: 2772
		private global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration _modificationStoredProceduresConfiguration;
	}
}
