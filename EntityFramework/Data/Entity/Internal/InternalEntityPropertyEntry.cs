using System;
using System.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000106 RID: 262
	internal class InternalEntityPropertyEntry : global::System.Data.Entity.Internal.InternalPropertyEntry
	{
		// Token: 0x060012C8 RID: 4808 RVA: 0x00030790 File Offset: 0x0002E990
		public InternalEntityPropertyEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry, global::System.Data.Entity.Internal.PropertyEntryMetadata propertyMetadata) : base(internalEntityEntry, propertyMetadata)
		{
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x0003079A File Offset: 0x0002E99A
		public override global::System.Data.Entity.Internal.InternalPropertyEntry ParentPropertyEntry
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x0003079D File Offset: 0x0002E99D
		public override global::System.Data.Entity.Internal.InternalPropertyValues ParentCurrentValues
		{
			get
			{
				return this.InternalEntityEntry.CurrentValues;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x000307AA File Offset: 0x0002E9AA
		public override global::System.Data.Entity.Internal.InternalPropertyValues ParentOriginalValues
		{
			get
			{
				return this.InternalEntityEntry.OriginalValues;
			}
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x000307B8 File Offset: 0x0002E9B8
		protected override global::System.Func<object, object> CreateGetter()
		{
			global::System.Func<object, object> result;
			global::System.Data.Entity.Internal.DbHelpers.GetPropertyGetters(this.InternalEntityEntry.EntityType).TryGetValue(this.Name, out result);
			return result;
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x000307E4 File Offset: 0x0002E9E4
		protected override global::System.Action<object, object> CreateSetter()
		{
			global::System.Action<object, object> result;
			global::System.Data.Entity.Internal.DbHelpers.GetPropertySetters(this.InternalEntityEntry.EntityType).TryGetValue(this.Name, out result);
			return result;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00030810 File Offset: 0x0002EA10
		public override bool EntityPropertyIsModified()
		{
			return this.InternalEntityEntry.ObjectStateEntry.GetModifiedProperties().Contains(this.Name);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0003082D File Offset: 0x0002EA2D
		public override void SetEntityPropertyModified()
		{
			this.InternalEntityEntry.ObjectStateEntry.SetModifiedProperty(this.Name);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00030845 File Offset: 0x0002EA45
		public override void RejectEntityPropertyChanges()
		{
			this.InternalEntityEntry.ObjectStateEntry.RejectPropertyChanges(this.Name);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0003085D File Offset: 0x0002EA5D
		public override void UpdateComplexPropertyState()
		{
			if (!this.InternalEntityEntry.ObjectStateEntry.IsPropertyChanged(this.Name))
			{
				this.RejectEntityPropertyChanges();
			}
		}
	}
}
