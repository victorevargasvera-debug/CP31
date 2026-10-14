using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000109 RID: 265
	internal class InternalNestedPropertyEntry : global::System.Data.Entity.Internal.InternalPropertyEntry
	{
		// Token: 0x060012E7 RID: 4839 RVA: 0x00030ABE File Offset: 0x0002ECBE
		public InternalNestedPropertyEntry(global::System.Data.Entity.Internal.InternalPropertyEntry parentPropertyEntry, global::System.Data.Entity.Internal.PropertyEntryMetadata propertyMetadata) : base(parentPropertyEntry.InternalEntityEntry, propertyMetadata)
		{
			this._parentPropertyEntry = parentPropertyEntry;
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00030AD4 File Offset: 0x0002ECD4
		public override global::System.Data.Entity.Internal.InternalPropertyEntry ParentPropertyEntry
		{
			get
			{
				return this._parentPropertyEntry;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00030ADC File Offset: 0x0002ECDC
		public override global::System.Data.Entity.Internal.InternalPropertyValues ParentCurrentValues
		{
			get
			{
				global::System.Data.Entity.Internal.InternalPropertyValues parentCurrentValues = this._parentPropertyEntry.ParentCurrentValues;
				return (global::System.Data.Entity.Internal.InternalPropertyValues)((parentCurrentValues == null) ? null : parentCurrentValues[this._parentPropertyEntry.Name]);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x00030B14 File Offset: 0x0002ED14
		public override global::System.Data.Entity.Internal.InternalPropertyValues ParentOriginalValues
		{
			get
			{
				global::System.Data.Entity.Internal.InternalPropertyValues parentOriginalValues = this._parentPropertyEntry.ParentOriginalValues;
				return (global::System.Data.Entity.Internal.InternalPropertyValues)((parentOriginalValues == null) ? null : parentOriginalValues[this._parentPropertyEntry.Name]);
			}
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00030B4C File Offset: 0x0002ED4C
		protected override global::System.Func<object, object> CreateGetter()
		{
			global::System.Func<object, object> parentGetter = this._parentPropertyEntry.Getter;
			if (parentGetter == null)
			{
				return null;
			}
			global::System.Func<object, object> getter;
			if (!global::System.Data.Entity.Internal.DbHelpers.GetPropertyGetters(base.EntryMetadata.DeclaringType).TryGetValue(this.Name, out getter))
			{
				return null;
			}
			return delegate(object o)
			{
				object obj = parentGetter(o);
				if (obj != null)
				{
					return getter(obj);
				}
				return null;
			};
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00030BAC File Offset: 0x0002EDAC
		protected override global::System.Action<object, object> CreateSetter()
		{
			global::System.Func<object, object> parentGetter = this._parentPropertyEntry.Getter;
			if (parentGetter == null)
			{
				return null;
			}
			global::System.Action<object, object> setter;
			if (!global::System.Data.Entity.Internal.DbHelpers.GetPropertySetters(base.EntryMetadata.DeclaringType).TryGetValue(this.Name, out setter))
			{
				return null;
			}
			return delegate(object o, object v)
			{
				if (parentGetter(o) == null)
				{
					throw global::System.Data.Entity.Resources.Error.DbPropertyValues_CannotSetPropertyOnNullCurrentValue(this.Name, this.ParentPropertyEntry.Name);
				}
				setter(parentGetter(o), v);
			};
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00030C12 File Offset: 0x0002EE12
		public override bool EntityPropertyIsModified()
		{
			return this._parentPropertyEntry.EntityPropertyIsModified();
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00030C1F File Offset: 0x0002EE1F
		public override void SetEntityPropertyModified()
		{
			this._parentPropertyEntry.SetEntityPropertyModified();
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00030C2C File Offset: 0x0002EE2C
		public override void RejectEntityPropertyChanges()
		{
			this.CurrentValue = this.OriginalValue;
			this.UpdateComplexPropertyState();
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00030C40 File Offset: 0x0002EE40
		public override void UpdateComplexPropertyState()
		{
			this._parentPropertyEntry.UpdateComplexPropertyState();
		}

		// Token: 0x04000938 RID: 2360
		private readonly global::System.Data.Entity.Internal.InternalPropertyEntry _parentPropertyEntry;
	}
}
