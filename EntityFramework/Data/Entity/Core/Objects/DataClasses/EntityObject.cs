using System;
using System.ComponentModel;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000477 RID: 1143
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public abstract class EntityObject : global::System.Data.Entity.Core.Objects.DataClasses.StructuralObject, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker, global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships
	{
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x000B661F File Offset: 0x000B481F
		// (set) Token: 0x06003800 RID: 14336 RVA: 0x000B663A File Offset: 0x000B483A
		private global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker EntityChangeTracker
		{
			get
			{
				if (this._entityChangeTracker == null)
				{
					this._entityChangeTracker = global::System.Data.Entity.Core.Objects.DataClasses.EntityObject._detachedEntityChangeTracker;
				}
				return this._entityChangeTracker;
			}
			set
			{
				this._entityChangeTracker = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06003801 RID: 14337 RVA: 0x000B6643 File Offset: 0x000B4843
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Data.Entity.EntityState EntityState
		{
			get
			{
				return this.EntityChangeTracker.EntityState;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06003802 RID: 14338 RVA: 0x000B6650 File Offset: 0x000B4850
		// (set) Token: 0x06003803 RID: 14339 RVA: 0x000B6658 File Offset: 0x000B4858
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Data.Entity.Core.EntityKey EntityKey
		{
			get
			{
				return this._entityKey;
			}
			set
			{
				this.EntityChangeTracker.EntityMemberChanging("-EntityKey-");
				this._entityKey = value;
				this.EntityChangeTracker.EntityMemberChanged("-EntityKey-");
			}
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x000B6684 File Offset: 0x000B4884
		void global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker.SetChangeTracker(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker changeTracker)
		{
			if (changeTracker != null && this.EntityChangeTracker != global::System.Data.Entity.Core.Objects.DataClasses.EntityObject._detachedEntityChangeTracker && changeTracker != this.EntityChangeTracker)
			{
				global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.EntityChangeTracker as global::System.Data.Entity.Core.Objects.EntityEntry;
				if (entityEntry == null || !entityEntry.ObjectStateManager.IsDisposed)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Entity_EntityCantHaveMultipleChangeTrackers);
				}
			}
			this.EntityChangeTracker = changeTracker;
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x000B66D8 File Offset: 0x000B48D8
		global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships.RelationshipManager
		{
			get
			{
				if (this._relationships == null)
				{
					this._relationships = global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.Create(this);
				}
				return this._relationships;
			}
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x000B66F4 File Offset: 0x000B48F4
		protected sealed override void ReportPropertyChanging(string property)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(property, "property");
			base.ReportPropertyChanging(property);
			this.EntityChangeTracker.EntityMemberChanging(property);
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x000B6715 File Offset: 0x000B4915
		protected sealed override void ReportPropertyChanged(string property)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(property, "property");
			this.EntityChangeTracker.EntityMemberChanged(property);
			base.ReportPropertyChanged(property);
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x000B6736 File Offset: 0x000B4936
		internal sealed override bool IsChangeTracked
		{
			get
			{
				return this.EntityState != global::System.Data.Entity.EntityState.Detached;
			}
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x000B6744 File Offset: 0x000B4944
		internal sealed override void ReportComplexPropertyChanging(string entityMemberName, global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject complexObject, string complexMemberName)
		{
			this.EntityChangeTracker.EntityComplexMemberChanging(entityMemberName, complexObject, complexMemberName);
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x000B6754 File Offset: 0x000B4954
		internal sealed override void ReportComplexPropertyChanged(string entityMemberName, global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject complexObject, string complexMemberName)
		{
			this.EntityChangeTracker.EntityComplexMemberChanged(entityMemberName, complexObject, complexMemberName);
		}

		// Token: 0x040012E6 RID: 4838
		private global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager _relationships;

		// Token: 0x040012E7 RID: 4839
		private global::System.Data.Entity.Core.EntityKey _entityKey;

		// Token: 0x040012E8 RID: 4840
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker _entityChangeTracker = global::System.Data.Entity.Core.Objects.DataClasses.EntityObject._detachedEntityChangeTracker;

		// Token: 0x040012E9 RID: 4841
		[global::System.NonSerialized]
		private static readonly global::System.Data.Entity.Core.Objects.DataClasses.EntityObject.DetachedEntityChangeTracker _detachedEntityChangeTracker = new global::System.Data.Entity.Core.Objects.DataClasses.EntityObject.DetachedEntityChangeTracker();

		// Token: 0x02000AB5 RID: 2741
		private class DetachedEntityChangeTracker : global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker
		{
			// Token: 0x060062E0 RID: 25312 RVA: 0x00156443 File Offset: 0x00154643
			void global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker.EntityMemberChanging(string entityMemberName)
			{
			}

			// Token: 0x060062E1 RID: 25313 RVA: 0x00156445 File Offset: 0x00154645
			void global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker.EntityMemberChanged(string entityMemberName)
			{
			}

			// Token: 0x060062E2 RID: 25314 RVA: 0x00156447 File Offset: 0x00154647
			void global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker.EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexMemberName)
			{
			}

			// Token: 0x060062E3 RID: 25315 RVA: 0x00156449 File Offset: 0x00154649
			void global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker.EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexMemberName)
			{
			}

			// Token: 0x170010CD RID: 4301
			// (get) Token: 0x060062E4 RID: 25316 RVA: 0x0015644B File Offset: 0x0015464B
			global::System.Data.Entity.EntityState global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker.EntityState
			{
				get
				{
					return global::System.Data.Entity.EntityState.Detached;
				}
			}
		}
	}
}
