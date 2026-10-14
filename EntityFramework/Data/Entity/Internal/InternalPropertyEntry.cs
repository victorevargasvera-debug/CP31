using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200010A RID: 266
	internal abstract class InternalPropertyEntry : global::System.Data.Entity.Internal.InternalMemberEntry
	{
		// Token: 0x060012F1 RID: 4849 RVA: 0x00030C4D File Offset: 0x0002EE4D
		protected InternalPropertyEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry, global::System.Data.Entity.Internal.PropertyEntryMetadata propertyMetadata) : base(internalEntityEntry, propertyMetadata)
		{
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060012F2 RID: 4850
		public abstract global::System.Data.Entity.Internal.InternalPropertyEntry ParentPropertyEntry { get; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060012F3 RID: 4851
		public abstract global::System.Data.Entity.Internal.InternalPropertyValues ParentCurrentValues { get; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060012F4 RID: 4852
		public abstract global::System.Data.Entity.Internal.InternalPropertyValues ParentOriginalValues { get; }

		// Token: 0x060012F5 RID: 4853
		protected abstract global::System.Func<object, object> CreateGetter();

		// Token: 0x060012F6 RID: 4854
		protected abstract global::System.Action<object, object> CreateSetter();

		// Token: 0x060012F7 RID: 4855
		public abstract bool EntityPropertyIsModified();

		// Token: 0x060012F8 RID: 4856
		public abstract void SetEntityPropertyModified();

		// Token: 0x060012F9 RID: 4857
		public abstract void RejectEntityPropertyChanges();

		// Token: 0x060012FA RID: 4858
		public abstract void UpdateComplexPropertyState();

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00030C57 File Offset: 0x0002EE57
		public global::System.Func<object, object> Getter
		{
			get
			{
				if (!this._getterIsCached)
				{
					this._getter = this.CreateGetter();
					this._getterIsCached = true;
				}
				return this._getter;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00030C7A File Offset: 0x0002EE7A
		public global::System.Action<object, object> Setter
		{
			get
			{
				if (!this._setterIsCached)
				{
					this._setter = this.CreateSetter();
					this._setterIsCached = true;
				}
				return this._setter;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00030CA0 File Offset: 0x0002EEA0
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x00030CE4 File Offset: 0x0002EEE4
		public virtual object OriginalValue
		{
			get
			{
				this.ValidateNotDetachedAndInModel("OriginalValue");
				global::System.Data.Entity.Internal.InternalPropertyValues parentOriginalValues = this.ParentOriginalValues;
				object obj = (parentOriginalValues == null) ? null : parentOriginalValues[this.Name];
				global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = obj as global::System.Data.Entity.Internal.InternalPropertyValues;
				if (internalPropertyValues != null)
				{
					obj = internalPropertyValues.ToObject();
				}
				return obj;
			}
			set
			{
				this.ValidateNotDetachedAndInModel("OriginalValue");
				this.CheckNotSettingComplexPropertyToNull(value);
				global::System.Data.Entity.Internal.InternalPropertyValues parentOriginalValues = this.ParentOriginalValues;
				if (parentOriginalValues == null)
				{
					throw global::System.Data.Entity.Resources.Error.DbPropertyValues_CannotSetPropertyOnNullOriginalValue(this.Name, this.ParentPropertyEntry.Name);
				}
				this.SetPropertyValueUsingValues(parentOriginalValues, value);
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00030D2C File Offset: 0x0002EF2C
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x00030DBC File Offset: 0x0002EFBC
		public override object CurrentValue
		{
			get
			{
				if (this.Getter != null)
				{
					return this.Getter(this.InternalEntityEntry.Entity);
				}
				if (!this.InternalEntityEntry.IsDetached && this.EntryMetadata.IsMapped)
				{
					global::System.Data.Entity.Internal.InternalPropertyValues parentCurrentValues = this.ParentCurrentValues;
					object obj = (parentCurrentValues == null) ? null : parentCurrentValues[this.Name];
					global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = obj as global::System.Data.Entity.Internal.InternalPropertyValues;
					if (internalPropertyValues != null)
					{
						obj = internalPropertyValues.ToObject();
					}
					return obj;
				}
				throw global::System.Data.Entity.Resources.Error.DbPropertyEntry_CannotGetCurrentValue(this.Name, base.EntryMetadata.DeclaringType.Name);
			}
			set
			{
				this.CheckNotSettingComplexPropertyToNull(value);
				if (!this.EntryMetadata.IsMapped || this.InternalEntityEntry.IsDetached || this.InternalEntityEntry.State == global::System.Data.Entity.EntityState.Deleted)
				{
					if (!this.SetCurrentValueOnClrObject(value))
					{
						throw global::System.Data.Entity.Resources.Error.DbPropertyEntry_CannotSetCurrentValue(this.Name, base.EntryMetadata.DeclaringType.Name);
					}
				}
				else
				{
					global::System.Data.Entity.Internal.InternalPropertyValues parentCurrentValues = this.ParentCurrentValues;
					if (parentCurrentValues == null)
					{
						throw global::System.Data.Entity.Resources.Error.DbPropertyValues_CannotSetPropertyOnNullCurrentValue(this.Name, this.ParentPropertyEntry.Name);
					}
					this.SetPropertyValueUsingValues(parentCurrentValues, value);
					if (this.EntryMetadata.IsComplex)
					{
						this.SetCurrentValueOnClrObject(value);
					}
				}
			}
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00030E5B File Offset: 0x0002F05B
		private void CheckNotSettingComplexPropertyToNull(object value)
		{
			if (value == null && this.EntryMetadata.IsComplex)
			{
				throw global::System.Data.Entity.Resources.Error.DbPropertyValues_ComplexObjectCannotBeNull(this.Name, base.EntryMetadata.DeclaringType.Name);
			}
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00030E8C File Offset: 0x0002F08C
		private bool SetCurrentValueOnClrObject(object value)
		{
			if (this.Setter == null)
			{
				return false;
			}
			if (this.Getter == null || !global::System.Data.Entity.Internal.DbHelpers.PropertyValuesEqual(value, this.Getter(this.InternalEntityEntry.Entity)))
			{
				this.Setter(this.InternalEntityEntry.Entity, value);
				if (this.EntryMetadata.IsMapped && (this.InternalEntityEntry.State == global::System.Data.Entity.EntityState.Modified || this.InternalEntityEntry.State == global::System.Data.Entity.EntityState.Unchanged))
				{
					this.IsModified = true;
				}
			}
			return true;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00030F14 File Offset: 0x0002F114
		private void SetPropertyValueUsingValues(global::System.Data.Entity.Internal.InternalPropertyValues internalValues, object value)
		{
			global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = internalValues[this.Name] as global::System.Data.Entity.Internal.InternalPropertyValues;
			if (internalPropertyValues == null)
			{
				internalValues[this.Name] = value;
				return;
			}
			if (!internalPropertyValues.ObjectType.IsAssignableFrom(value.GetType()))
			{
				throw global::System.Data.Entity.Resources.Error.DbPropertyValues_AttemptToSetValuesFromWrongObject(value.GetType().Name, internalPropertyValues.ObjectType.Name);
			}
			internalPropertyValues.SetValues(value);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00030F7A File Offset: 0x0002F17A
		public virtual global::System.Data.Entity.Internal.InternalPropertyEntry Property(string property, global::System.Type requestedType = null, bool requireComplex = false)
		{
			return this.InternalEntityEntry.Property(this, property, requestedType ?? typeof(object), requireComplex);
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00030F99 File Offset: 0x0002F199
		// (set) Token: 0x06001306 RID: 4870 RVA: 0x00030FBD File Offset: 0x0002F1BD
		public virtual bool IsModified
		{
			get
			{
				return !this.InternalEntityEntry.IsDetached && this.EntryMetadata.IsMapped && this.EntityPropertyIsModified();
			}
			set
			{
				this.ValidateNotDetachedAndInModel("IsModified");
				if (value)
				{
					this.SetEntityPropertyModified();
					return;
				}
				if (this.IsModified)
				{
					this.RejectEntityPropertyChanges();
				}
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00030FE4 File Offset: 0x0002F1E4
		private void ValidateNotDetachedAndInModel(string method)
		{
			if (!this.EntryMetadata.IsMapped)
			{
				throw global::System.Data.Entity.Resources.Error.DbPropertyEntry_NotSupportedForPropertiesNotInTheModel(method, base.EntryMetadata.MemberName, this.InternalEntityEntry.EntityType.Name);
			}
			if (this.InternalEntityEntry.IsDetached)
			{
				throw global::System.Data.Entity.Resources.Error.DbPropertyEntry_NotSupportedForDetached(method, base.EntryMetadata.MemberName, this.InternalEntityEntry.EntityType.Name);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0003104F File Offset: 0x0002F24F
		public new global::System.Data.Entity.Internal.PropertyEntryMetadata EntryMetadata
		{
			get
			{
				return (global::System.Data.Entity.Internal.PropertyEntryMetadata)base.EntryMetadata;
			}
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0003105C File Offset: 0x0002F25C
		public override global::System.Data.Entity.Infrastructure.DbMemberEntry CreateDbMemberEntry()
		{
			if (!this.EntryMetadata.IsComplex)
			{
				return new global::System.Data.Entity.Infrastructure.DbPropertyEntry(this);
			}
			return new global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry(this);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00031078 File Offset: 0x0002F278
		public override global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TProperty> CreateDbMemberEntry<TEntity, TProperty>()
		{
			if (!this.EntryMetadata.IsComplex)
			{
				return new global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TProperty>(this);
			}
			return new global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TProperty>(this);
		}

		// Token: 0x04000939 RID: 2361
		private bool _getterIsCached;

		// Token: 0x0400093A RID: 2362
		private global::System.Func<object, object> _getter;

		// Token: 0x0400093B RID: 2363
		private bool _setterIsCached;

		// Token: 0x0400093C RID: 2364
		private global::System.Action<object, object> _setter;
	}
}
