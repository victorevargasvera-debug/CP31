using System;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation
{
	// Token: 0x02000209 RID: 521
	internal class ConventionNavigationPropertyConfiguration
	{
		// Token: 0x06001B92 RID: 7058 RVA: 0x0004B114 File Offset: 0x00049314
		internal ConventionNavigationPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._configuration = configuration;
			this._modelConfiguration = modelConfiguration;
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x0004B12A File Offset: 0x0004932A
		public virtual global::System.Reflection.PropertyInfo ClrPropertyInfo
		{
			get
			{
				if (this._configuration == null)
				{
					return null;
				}
				return this._configuration.NavigationProperty;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001B94 RID: 7060 RVA: 0x0004B141 File Offset: 0x00049341
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration Configuration
		{
			get
			{
				return this._configuration;
			}
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0004B149 File Offset: 0x00049349
		public virtual void HasConstraint<T>() where T : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration
		{
			this.HasConstraintInternal<T>(null);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0004B152 File Offset: 0x00049352
		public virtual void HasConstraint<T>(global::System.Action<T> constraintConfigurationAction) where T : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<T>>(constraintConfigurationAction, "constraintConfigurationAction");
			this.HasConstraintInternal<T>(constraintConfigurationAction);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0004B168 File Offset: 0x00049368
		private void HasConstraintInternal<T>(global::System.Action<T> constraintConfigurationAction) where T : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration
		{
			if (this._configuration != null && !this.HasConfiguredConstraint())
			{
				global::System.Type typeFromHandle = typeof(T);
				if (this._configuration.Constraint == null)
				{
					if (typeFromHandle == typeof(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.IndependentConstraintConfiguration))
					{
						this._configuration.Constraint = global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.IndependentConstraintConfiguration.Instance;
					}
					else
					{
						this._configuration.Constraint = (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConstraintConfiguration)global::System.Activator.CreateInstance(typeFromHandle);
					}
				}
				else if (this._configuration.Constraint.GetType() != typeFromHandle)
				{
					return;
				}
				if (constraintConfigurationAction != null)
				{
					constraintConfigurationAction((T)((object)this._configuration.Constraint));
				}
			}
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0004B214 File Offset: 0x00049414
		private bool HasConfiguredConstraint()
		{
			if (this._configuration != null && this._configuration.Constraint != null && this._configuration.Constraint.IsFullySpecified)
			{
				return true;
			}
			if (this._configuration != null && this._configuration.InverseNavigationProperty != null)
			{
				global::System.Type targetType = this._configuration.NavigationProperty.PropertyType.GetTargetType();
				if (this._modelConfiguration.Entities.Contains(targetType))
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration = this._modelConfiguration.Entity(targetType);
					if (entityTypeConfiguration.IsNavigationPropertyConfigured(this._configuration.InverseNavigationProperty))
					{
						return entityTypeConfiguration.Navigation(this._configuration.InverseNavigationProperty).Constraint != null;
					}
				}
			}
			return false;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0004B2CC File Offset: 0x000494CC
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration HasInverseNavigationProperty(global::System.Func<global::System.Reflection.PropertyInfo, global::System.Reflection.PropertyInfo> inverseNavigationPropertyGetter)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Reflection.PropertyInfo, global::System.Reflection.PropertyInfo>>(inverseNavigationPropertyGetter, "inverseNavigationPropertyGetter");
			if (this._configuration != null && this._configuration.InverseNavigationProperty == null)
			{
				global::System.Reflection.PropertyInfo propertyInfo = inverseNavigationPropertyGetter(this.ClrPropertyInfo);
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "inverseNavigationProperty");
				if (!propertyInfo.IsValidEdmNavigationProperty())
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightEntityConfiguration_InvalidNavigationProperty(propertyInfo.Name));
				}
				if (!propertyInfo.DeclaringType.IsAssignableFrom(this._configuration.NavigationProperty.PropertyType.GetTargetType()))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightEntityConfiguration_MismatchedInverseNavigationProperty(this._configuration.NavigationProperty.PropertyType.GetTargetType().FullName, this._configuration.NavigationProperty.Name, propertyInfo.DeclaringType.FullName, propertyInfo.Name));
				}
				if (!this._configuration.NavigationProperty.DeclaringType.IsAssignableFrom(propertyInfo.PropertyType.GetTargetType()))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightEntityConfiguration_InvalidInverseNavigationProperty(this._configuration.NavigationProperty.DeclaringType.FullName, this._configuration.NavigationProperty.Name, propertyInfo.PropertyType.GetTargetType().FullName, propertyInfo.Name));
				}
				if (this._configuration.InverseEndKind != null)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration.VerifyMultiplicityCompatibility(this._configuration.InverseEndKind.Value, propertyInfo);
				}
				this._modelConfiguration.Entity(this._configuration.NavigationProperty.PropertyType.GetTargetType()).Navigation(propertyInfo);
				this._configuration.InverseNavigationProperty = propertyInfo;
			}
			return this;
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x0004B46C File Offset: 0x0004966C
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration HasInverseEndMultiplicity(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity)
		{
			if (this._configuration != null && this._configuration.InverseEndKind == null)
			{
				if (this._configuration.InverseNavigationProperty != null)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration.VerifyMultiplicityCompatibility(multiplicity, this._configuration.InverseNavigationProperty);
				}
				this._configuration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(multiplicity);
			}
			return this;
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0004B4CC File Offset: 0x000496CC
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration IsDeclaringTypePrincipal(bool isPrincipal)
		{
			if (this._configuration != null && this._configuration.IsNavigationPropertyDeclaringTypePrincipal == null)
			{
				this._configuration.IsNavigationPropertyDeclaringTypePrincipal = new bool?(isPrincipal);
			}
			return this;
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0004B508 File Offset: 0x00049708
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration HasDeleteAction(global::System.Data.Entity.Core.Metadata.Edm.OperationAction deleteAction)
		{
			if (this._configuration != null && this._configuration.DeleteAction == null)
			{
				this._configuration.DeleteAction = new global::System.Data.Entity.Core.Metadata.Edm.OperationAction?(deleteAction);
			}
			return this;
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0004B544 File Offset: 0x00049744
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration HasRelationshipMultiplicity(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity)
		{
			if (this._configuration != null && this._configuration.RelationshipMultiplicity == null)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration.VerifyMultiplicityCompatibility(multiplicity, this._configuration.NavigationProperty);
				this._configuration.RelationshipMultiplicity = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(multiplicity);
			}
			return this;
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0004B594 File Offset: 0x00049794
		private static void VerifyMultiplicityCompatibility(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity, global::System.Reflection.PropertyInfo propertyInfo)
		{
			bool flag;
			if (multiplicity > global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
			{
				if (multiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightNavigationPropertyConfiguration_InvalidMultiplicity(multiplicity));
				}
				flag = propertyInfo.PropertyType.IsCollection();
			}
			else
			{
				flag = !propertyInfo.PropertyType.IsCollection();
			}
			if (!flag)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.LightweightNavigationPropertyConfiguration_IncompatibleMultiplicity(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicityConverter.MultiplicityToString(multiplicity), propertyInfo.DeclaringType.Name + "." + propertyInfo.Name, propertyInfo.PropertyType));
			}
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0004B610 File Offset: 0x00049810
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0004B618 File Offset: 0x00049818
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0004B621 File Offset: 0x00049821
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0004B629 File Offset: 0x00049829
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000AC9 RID: 2761
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration _configuration;

		// Token: 0x04000ACA RID: 2762
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration _modelConfiguration;
	}
}
