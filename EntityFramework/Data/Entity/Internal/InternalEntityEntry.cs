using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Internal.Validation;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000105 RID: 261
	internal class InternalEntityEntry
	{
		// Token: 0x060012A4 RID: 4772 RVA: 0x0002FC6E File Offset: 0x0002DE6E
		public InternalEntityEntry(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Data.Entity.Internal.IEntityStateEntry stateEntry)
		{
			this._internalContext = internalContext;
			this._stateEntry = stateEntry;
			this._entity = stateEntry.Entity;
			this._entityType = global::System.Data.Entity.Internal.ObjectContextTypeCache.GetObjectType(this._entity.GetType());
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0002FCA8 File Offset: 0x0002DEA8
		public InternalEntityEntry(global::System.Data.Entity.Internal.InternalContext internalContext, object entity)
		{
			this._internalContext = internalContext;
			this._entity = entity;
			this._entityType = global::System.Data.Entity.Internal.ObjectContextTypeCache.GetObjectType(this._entity.GetType());
			this._stateEntry = this._internalContext.GetStateEntry(entity);
			if (this._stateEntry == null)
			{
				this._internalContext.Set(this._entityType).InternalSet.Initialize();
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0002FD14 File Offset: 0x0002DF14
		public virtual object Entity
		{
			get
			{
				return this._entity;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0002FD1C File Offset: 0x0002DF1C
		// (set) Token: 0x060012A8 RID: 4776 RVA: 0x0002FD34 File Offset: 0x0002DF34
		public virtual global::System.Data.Entity.EntityState State
		{
			get
			{
				if (!this.IsDetached)
				{
					return this._stateEntry.State;
				}
				return global::System.Data.Entity.EntityState.Detached;
			}
			set
			{
				if (!this.IsDetached)
				{
					if (this._stateEntry.State == global::System.Data.Entity.EntityState.Modified && value == global::System.Data.Entity.EntityState.Unchanged)
					{
						this.CurrentValues.SetValues(this.OriginalValues);
					}
					this._stateEntry.ChangeState(value);
					return;
				}
				if (value <= global::System.Data.Entity.EntityState.Added)
				{
					if (value == global::System.Data.Entity.EntityState.Unchanged)
					{
						this._internalContext.Set(this._entityType).InternalSet.Attach(this._entity);
						return;
					}
					if (value != global::System.Data.Entity.EntityState.Added)
					{
						return;
					}
					this._internalContext.Set(this._entityType).InternalSet.Add(this._entity);
					return;
				}
				else
				{
					if (value != global::System.Data.Entity.EntityState.Deleted && value != global::System.Data.Entity.EntityState.Modified)
					{
						return;
					}
					this._internalContext.Set(this._entityType).InternalSet.Attach(this._entity);
					this._stateEntry = this._internalContext.GetStateEntry(this._entity);
					this._stateEntry.ChangeState(value);
					return;
				}
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x0002FE19 File Offset: 0x0002E019
		public virtual global::System.Data.Entity.Internal.InternalPropertyValues CurrentValues
		{
			get
			{
				this.ValidateStateToGetValues("CurrentValues", global::System.Data.Entity.EntityState.Deleted);
				return new global::System.Data.Entity.Internal.DbDataRecordPropertyValues(this._internalContext, this._entityType, this._stateEntry.CurrentValues, true);
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x0002FE44 File Offset: 0x0002E044
		public virtual global::System.Data.Entity.Internal.InternalPropertyValues OriginalValues
		{
			get
			{
				this.ValidateStateToGetValues("OriginalValues", global::System.Data.Entity.EntityState.Added);
				return new global::System.Data.Entity.Internal.DbDataRecordPropertyValues(this._internalContext, this._entityType, this._stateEntry.GetUpdatableOriginalValues(), true);
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0002FE70 File Offset: 0x0002E070
		public virtual global::System.Data.Entity.Internal.InternalPropertyValues GetDatabaseValues()
		{
			this.ValidateStateToGetValues("GetDatabaseValues", global::System.Data.Entity.EntityState.Added);
			global::System.Data.Common.DbDataRecord dbDataRecord = this.GetDatabaseValuesQuery().SingleOrDefault<global::System.Data.Common.DbDataRecord>();
			if (dbDataRecord != null)
			{
				return new global::System.Data.Entity.Internal.ClonedPropertyValues(this.OriginalValues, dbDataRecord);
			}
			return null;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0002FEA8 File Offset: 0x0002E0A8
		public virtual async global::System.Threading.Tasks.Task<global::System.Data.Entity.Internal.InternalPropertyValues> GetDatabaseValuesAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			this.ValidateStateToGetValues("GetDatabaseValuesAsync", global::System.Data.Entity.EntityState.Added);
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Common.DbDataRecord dbDataRecord = await this.GetDatabaseValuesQuery().SingleOrDefaultAsync(cancellationToken).WithCurrentCulture<global::System.Data.Common.DbDataRecord>();
			return (dbDataRecord == null) ? null : new global::System.Data.Entity.Internal.ClonedPropertyValues(this.OriginalValues, dbDataRecord);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0002FEF8 File Offset: 0x0002E0F8
		private global::System.Data.Entity.Core.Objects.ObjectQuery<global::System.Data.Common.DbDataRecord> GetDatabaseValuesQuery()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("SELECT ");
			this.AppendEntitySqlRow(stringBuilder, "X", this.OriginalValues);
			string text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
			{
				global::System.Data.Entity.Internal.DbHelpers.QuoteIdentifier(this._stateEntry.EntitySet.EntityContainer.Name),
				global::System.Data.Entity.Internal.DbHelpers.QuoteIdentifier(this._stateEntry.EntitySet.Name)
			});
			string text2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
			{
				global::System.Data.Entity.Internal.DbHelpers.QuoteIdentifier(this.EntityType.NestingNamespace()),
				global::System.Data.Entity.Internal.DbHelpers.QuoteIdentifier(this.EntityType.Name)
			});
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, " FROM (SELECT VALUE TREAT (Y AS {0}) FROM {1} AS Y) AS X WHERE ", new object[]
			{
				text2,
				text
			});
			global::System.Data.Entity.Core.EntityKeyMember[] entityKeyValues = this._stateEntry.EntityKey.EntityKeyValues;
			global::System.Data.Entity.Core.Objects.ObjectParameter[] array = new global::System.Data.Entity.Core.Objects.ObjectParameter[entityKeyValues.Length];
			for (int i = 0; i < entityKeyValues.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(" AND ");
				}
				string text3 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "p{0}", new object[]
				{
					i.ToString(global::System.Globalization.CultureInfo.InvariantCulture)
				});
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "X.{0} = @{1}", new object[]
				{
					global::System.Data.Entity.Internal.DbHelpers.QuoteIdentifier(entityKeyValues[i].Key),
					text3
				});
				array[i] = new global::System.Data.Entity.Core.Objects.ObjectParameter(text3, entityKeyValues[i].Value);
			}
			return this._internalContext.ObjectContext.CreateQuery<global::System.Data.Common.DbDataRecord>(stringBuilder.ToString(), array);
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00030090 File Offset: 0x0002E290
		private void AppendEntitySqlRow(global::System.Text.StringBuilder queryBuilder, string prefix, global::System.Data.Entity.Internal.InternalPropertyValues templateValues)
		{
			bool flag = false;
			foreach (string text in templateValues.PropertyNames)
			{
				if (flag)
				{
					queryBuilder.Append(", ");
				}
				else
				{
					flag = true;
				}
				string text2 = global::System.Data.Entity.Internal.DbHelpers.QuoteIdentifier(text);
				global::System.Data.Entity.Internal.IPropertyValuesItem item = templateValues.GetItem(text);
				if (item.IsComplex)
				{
					global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = item.Value as global::System.Data.Entity.Internal.InternalPropertyValues;
					if (internalPropertyValues == null)
					{
						throw global::System.Data.Entity.Resources.Error.DbPropertyValues_CannotGetStoreValuesWhenComplexPropertyIsNull(text, this.EntityType.Name);
					}
					queryBuilder.Append("ROW(");
					this.AppendEntitySqlRow(queryBuilder, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
					{
						prefix,
						text2
					}), internalPropertyValues);
					queryBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, ") AS {0}", new object[]
					{
						text2
					});
				}
				else
				{
					queryBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1} ", new object[]
					{
						prefix,
						text2
					});
				}
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0003019C File Offset: 0x0002E39C
		private void ValidateStateToGetValues(string method, global::System.Data.Entity.EntityState invalidState)
		{
			this.ValidateNotDetachedAndInitializeRelatedEnd(method);
			if (this.State == invalidState)
			{
				throw global::System.Data.Entity.Resources.Error.DbPropertyValues_CannotGetValuesForState(method, this.State);
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000301C0 File Offset: 0x0002E3C0
		public virtual void Reload()
		{
			this.ValidateStateToGetValues("Reload", global::System.Data.Entity.EntityState.Added);
			this._internalContext.ObjectContext.Refresh(global::System.Data.Entity.Core.Objects.RefreshMode.StoreWins, this.Entity);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x000301E5 File Offset: 0x0002E3E5
		public virtual global::System.Threading.Tasks.Task ReloadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			this.ValidateStateToGetValues("ReloadAsync", global::System.Data.Entity.EntityState.Added);
			return this._internalContext.ObjectContext.RefreshAsync(global::System.Data.Entity.Core.Objects.RefreshMode.StoreWins, this.Entity, cancellationToken);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0003020B File Offset: 0x0002E40B
		public virtual global::System.Data.Entity.Internal.InternalReferenceEntry Reference(string navigationProperty, global::System.Type requestedType = null)
		{
			return (global::System.Data.Entity.Internal.InternalReferenceEntry)this.ValidateAndGetNavigationMetadata(navigationProperty, requestedType ?? typeof(object), false).CreateMemberEntry(this, null);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00030230 File Offset: 0x0002E430
		public virtual global::System.Data.Entity.Internal.InternalCollectionEntry Collection(string navigationProperty, global::System.Type requestedType = null)
		{
			return (global::System.Data.Entity.Internal.InternalCollectionEntry)this.ValidateAndGetNavigationMetadata(navigationProperty, requestedType ?? typeof(object), true).CreateMemberEntry(this, null);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00030258 File Offset: 0x0002E458
		public virtual global::System.Data.Entity.Internal.InternalMemberEntry Member(string propertyName, global::System.Type requestedType = null)
		{
			requestedType = (requestedType ?? typeof(object));
			global::System.Collections.Generic.IList<string> list = global::System.Data.Entity.Internal.InternalEntityEntry.SplitName(propertyName);
			if (list.Count > 1)
			{
				return this.Property(null, propertyName, list, requestedType, false);
			}
			global::System.Data.Entity.Internal.MemberEntryMetadata memberEntryMetadata = this.GetNavigationMetadata(propertyName) ?? this.ValidateAndGetPropertyMetadata(propertyName, this.EntityType, requestedType);
			if (memberEntryMetadata == null)
			{
				throw global::System.Data.Entity.Resources.Error.DbEntityEntry_NotAProperty(propertyName, this.EntityType.Name);
			}
			if (memberEntryMetadata.MemberEntryType != global::System.Data.Entity.Internal.MemberEntryType.CollectionNavigationProperty && !requestedType.IsAssignableFrom(memberEntryMetadata.MemberType))
			{
				throw global::System.Data.Entity.Resources.Error.DbEntityEntry_WrongGenericForNavProp(propertyName, this.EntityType.Name, requestedType.Name, memberEntryMetadata.MemberType.Name);
			}
			return memberEntryMetadata.CreateMemberEntry(this, null);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00030303 File Offset: 0x0002E503
		public virtual global::System.Data.Entity.Internal.InternalPropertyEntry Property(string property, global::System.Type requestedType = null, bool requireComplex = false)
		{
			return this.Property(null, property, requestedType ?? typeof(object), requireComplex);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0003031D File Offset: 0x0002E51D
		public global::System.Data.Entity.Internal.InternalPropertyEntry Property(global::System.Data.Entity.Internal.InternalPropertyEntry parentProperty, string propertyName, global::System.Type requestedType, bool requireComplex)
		{
			return this.Property(parentProperty, propertyName, global::System.Data.Entity.Internal.InternalEntityEntry.SplitName(propertyName), requestedType, requireComplex);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00030330 File Offset: 0x0002E530
		private global::System.Data.Entity.Internal.InternalPropertyEntry Property(global::System.Data.Entity.Internal.InternalPropertyEntry parentProperty, string propertyName, global::System.Collections.Generic.IList<string> properties, global::System.Type requestedType, bool requireComplex)
		{
			bool flag = properties.Count > 1;
			global::System.Type requestedType2 = flag ? typeof(object) : requestedType;
			global::System.Type type = (parentProperty != null) ? parentProperty.EntryMetadata.ElementType : this.EntityType;
			global::System.Data.Entity.Internal.PropertyEntryMetadata propertyEntryMetadata = this.ValidateAndGetPropertyMetadata(properties[0], type, requestedType2);
			if (propertyEntryMetadata == null || ((flag || requireComplex) && !propertyEntryMetadata.IsComplex))
			{
				if (flag)
				{
					throw global::System.Data.Entity.Resources.Error.DbEntityEntry_DottedPartNotComplex(properties[0], propertyName, type.Name);
				}
				throw requireComplex ? global::System.Data.Entity.Resources.Error.DbEntityEntry_NotAComplexProperty(properties[0], type.Name) : global::System.Data.Entity.Resources.Error.DbEntityEntry_NotAScalarProperty(properties[0], type.Name);
			}
			else
			{
				global::System.Data.Entity.Internal.InternalPropertyEntry internalPropertyEntry = (global::System.Data.Entity.Internal.InternalPropertyEntry)propertyEntryMetadata.CreateMemberEntry(this, parentProperty);
				if (!flag)
				{
					return internalPropertyEntry;
				}
				return this.Property(internalPropertyEntry, propertyName, properties.Skip(1).ToList<string>(), requestedType, requireComplex);
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00030404 File Offset: 0x0002E604
		private global::System.Data.Entity.Internal.NavigationEntryMetadata ValidateAndGetNavigationMetadata(string navigationProperty, global::System.Type requestedType, bool requireCollection)
		{
			if (global::System.Data.Entity.Internal.InternalEntityEntry.SplitName(navigationProperty).Count != 1)
			{
				throw global::System.Data.Entity.Resources.Error.DbEntityEntry_DottedPathMustBeProperty(navigationProperty);
			}
			global::System.Data.Entity.Internal.NavigationEntryMetadata navigationMetadata = this.GetNavigationMetadata(navigationProperty);
			if (navigationMetadata == null)
			{
				throw global::System.Data.Entity.Resources.Error.DbEntityEntry_NotANavigationProperty(navigationProperty, this.EntityType.Name);
			}
			if (requireCollection)
			{
				if (navigationMetadata.MemberEntryType == global::System.Data.Entity.Internal.MemberEntryType.ReferenceNavigationProperty)
				{
					throw global::System.Data.Entity.Resources.Error.DbEntityEntry_UsedCollectionForReferenceProp(navigationProperty, this.EntityType.Name);
				}
			}
			else if (navigationMetadata.MemberEntryType == global::System.Data.Entity.Internal.MemberEntryType.CollectionNavigationProperty)
			{
				throw global::System.Data.Entity.Resources.Error.DbEntityEntry_UsedReferenceForCollectionProp(navigationProperty, this.EntityType.Name);
			}
			if (!requestedType.IsAssignableFrom(navigationMetadata.ElementType))
			{
				throw global::System.Data.Entity.Resources.Error.DbEntityEntry_WrongGenericForNavProp(navigationProperty, this.EntityType.Name, requestedType.Name, navigationMetadata.ElementType.Name);
			}
			return navigationMetadata;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000304B0 File Offset: 0x0002E6B0
		public virtual global::System.Data.Entity.Internal.NavigationEntryMetadata GetNavigationMetadata(string propertyName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember;
			this.EdmEntityType.Members.TryGetValue(propertyName, false, out edmMember);
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = edmMember as global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty;
			if (navigationProperty != null)
			{
				return new global::System.Data.Entity.Internal.NavigationEntryMetadata(this.EntityType, this.GetNavigationTargetType(navigationProperty), propertyName, navigationProperty.ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many);
			}
			return null;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00030500 File Offset: 0x0002E700
		private global::System.Type GetNavigationTargetType(global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace = this._internalContext.ObjectContext.MetadataWorkspace;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = navigationProperty.RelationshipType.RelationshipEndMembers.Single((global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember e) => navigationProperty.ToEndMember.Name == e.Name).GetEntityType();
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType objectSpaceType = metadataWorkspace.GetObjectSpaceType(entityType);
			return ((global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection)metadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)).GetClrType(objectSpaceType);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0003056C File Offset: 0x0002E76C
		public virtual global::System.Data.Entity.Core.Objects.DataClasses.IRelatedEnd GetRelatedEnd(string navigationProperty)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember;
			this.EdmEntityType.Members.TryGetValue(navigationProperty, false, out edmMember);
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty2 = (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)edmMember;
			return this._internalContext.ObjectContext.ObjectStateManager.GetRelationshipManager(this.Entity).GetRelatedEnd(navigationProperty2.RelationshipType.FullName, navigationProperty2.ToEndMember.Name);
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x000305CB File Offset: 0x0002E7CB
		public virtual global::System.Data.Entity.Internal.PropertyEntryMetadata ValidateAndGetPropertyMetadata(string propertyName, global::System.Type declaringType, global::System.Type requestedType)
		{
			return global::System.Data.Entity.Internal.PropertyEntryMetadata.ValidateNameAndGetMetadata(this._internalContext, declaringType, requestedType, propertyName);
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000305DB File Offset: 0x0002E7DB
		private static global::System.Collections.Generic.IList<string> SplitName(string propertyName)
		{
			return propertyName.Split(new char[]
			{
				'.'
			});
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000305EE File Offset: 0x0002E7EE
		private void ValidateNotDetachedAndInitializeRelatedEnd(string method)
		{
			if (this.IsDetached)
			{
				throw global::System.Data.Entity.Resources.Error.DbEntityEntry_NotSupportedForDetached(method, this._entityType.Name);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x0003060A File Offset: 0x0002E80A
		public virtual bool IsDetached
		{
			get
			{
				if (this._stateEntry == null || this._stateEntry.State == global::System.Data.Entity.EntityState.Detached)
				{
					this._stateEntry = this._internalContext.GetStateEntry(this._entity);
					if (this._stateEntry == null)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x00030644 File Offset: 0x0002E844
		public virtual global::System.Type EntityType
		{
			get
			{
				return this._entityType;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x0003064C File Offset: 0x0002E84C
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EntityType EdmEntityType
		{
			get
			{
				if (this._edmEntityType == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace = this._internalContext.ObjectContext.MetadataWorkspace;
					global::System.Data.Entity.Core.Metadata.Edm.EntityType item = metadataWorkspace.GetItem<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(this._entityType.FullNameWithNesting(), global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
					this._edmEntityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)metadataWorkspace.GetEdmSpaceType(item);
				}
				return this._edmEntityType;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x0003069D File Offset: 0x0002E89D
		public global::System.Data.Entity.Internal.IEntityStateEntry ObjectStateEntry
		{
			get
			{
				return this._stateEntry;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x000306A5 File Offset: 0x0002E8A5
		public global::System.Data.Entity.Internal.InternalContext InternalContext
		{
			get
			{
				return this._internalContext;
			}
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x000306B0 File Offset: 0x0002E8B0
		public virtual global::System.Data.Entity.Validation.DbEntityValidationResult GetValidationResult(global::System.Collections.Generic.IDictionary<object, object> items)
		{
			global::System.Data.Entity.Internal.Validation.EntityValidator entityValidator = this.InternalContext.ValidationProvider.GetEntityValidator(this);
			bool lazyLoadingEnabled = this.InternalContext.LazyLoadingEnabled;
			this.InternalContext.LazyLoadingEnabled = false;
			global::System.Data.Entity.Validation.DbEntityValidationResult result;
			try
			{
				result = ((entityValidator != null) ? entityValidator.Validate(this.InternalContext.ValidationProvider.GetEntityValidationContext(this, items)) : new global::System.Data.Entity.Validation.DbEntityValidationResult(this, global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Validation.DbValidationError>()));
			}
			finally
			{
				this.InternalContext.LazyLoadingEnabled = lazyLoadingEnabled;
			}
			return result;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00030730 File Offset: 0x0002E930
		public override bool Equals(object obj)
		{
			return obj != null && !(obj.GetType() != typeof(global::System.Data.Entity.Internal.InternalEntityEntry)) && this.Equals((global::System.Data.Entity.Internal.InternalEntityEntry)obj);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0003075A File Offset: 0x0002E95A
		public bool Equals(global::System.Data.Entity.Internal.InternalEntityEntry other)
		{
			return this == other || (other != null && this._entity == other._entity && this._internalContext == other._internalContext);
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x00030783 File Offset: 0x0002E983
		public override int GetHashCode()
		{
			return global::System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(this._entity);
		}

		// Token: 0x0400092C RID: 2348
		private readonly global::System.Type _entityType;

		// Token: 0x0400092D RID: 2349
		private readonly global::System.Data.Entity.Internal.InternalContext _internalContext;

		// Token: 0x0400092E RID: 2350
		private readonly object _entity;

		// Token: 0x0400092F RID: 2351
		private global::System.Data.Entity.Internal.IEntityStateEntry _stateEntry;

		// Token: 0x04000930 RID: 2352
		private global::System.Data.Entity.Core.Metadata.Edm.EntityType _edmEntityType;
	}
}
