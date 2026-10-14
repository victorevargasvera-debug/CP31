using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200051E RID: 1310
	public class AssociationSetMapping : global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping
	{
		// Token: 0x06004097 RID: 16535 RVA: 0x000D9250 File Offset: 0x000D7450
		public AssociationSetMapping(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet storeEntitySet, global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping) : base(containerMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(associationSet, "associationSet");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(storeEntitySet, "storeEntitySet");
			this._associationSet = associationSet;
			this._associationTypeMapping = new global::System.Data.Entity.Core.Mapping.AssociationTypeMapping(associationSet.ElementType, this);
			this._associationTypeMapping.MappingFragment = new global::System.Data.Entity.Core.Mapping.MappingFragment(storeEntitySet, this._associationTypeMapping, false);
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x000D92AD File Offset: 0x000D74AD
		internal AssociationSetMapping(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet storeEntitySet) : this(associationSet, storeEntitySet, null)
		{
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x000D92B8 File Offset: 0x000D74B8
		internal AssociationSetMapping(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet, global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping) : base(containerMapping)
		{
			this._associationSet = associationSet;
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x0600409A RID: 16538 RVA: 0x000D92C8 File Offset: 0x000D74C8
		public global::System.Data.Entity.Core.Metadata.Edm.AssociationSet AssociationSet
		{
			get
			{
				return this._associationSet;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600409B RID: 16539 RVA: 0x000D92D0 File Offset: 0x000D74D0
		internal override global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase Set
		{
			get
			{
				return this.AssociationSet;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600409C RID: 16540 RVA: 0x000D92D8 File Offset: 0x000D74D8
		// (set) Token: 0x0600409D RID: 16541 RVA: 0x000D92E0 File Offset: 0x000D74E0
		public global::System.Data.Entity.Core.Mapping.AssociationTypeMapping AssociationTypeMapping
		{
			get
			{
				return this._associationTypeMapping;
			}
			internal set
			{
				this._associationTypeMapping = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600409E RID: 16542 RVA: 0x000D92E9 File Offset: 0x000D74E9
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.TypeMapping> TypeMappings
		{
			get
			{
				yield return this._associationTypeMapping;
				yield break;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x000D92F9 File Offset: 0x000D74F9
		// (set) Token: 0x060040A0 RID: 16544 RVA: 0x000D9301 File Offset: 0x000D7501
		public global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping ModificationFunctionMapping
		{
			get
			{
				return this._modificationFunctionMapping;
			}
			set
			{
				base.ThrowIfReadOnly();
				this._modificationFunctionMapping = value;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060040A1 RID: 16545 RVA: 0x000D9310 File Offset: 0x000D7510
		// (set) Token: 0x060040A2 RID: 16546 RVA: 0x000D9327 File Offset: 0x000D7527
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySet StoreEntitySet
		{
			get
			{
				if (this.SingleFragment == null)
				{
					return null;
				}
				return this.SingleFragment.StoreEntitySet;
			}
			internal set
			{
				this.SingleFragment.StoreEntitySet = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x000D9335 File Offset: 0x000D7535
		internal global::System.Data.Entity.Core.Metadata.Edm.EntityType Table
		{
			get
			{
				if (this.StoreEntitySet == null)
				{
					return null;
				}
				return this.StoreEntitySet.ElementType;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x000D934C File Offset: 0x000D754C
		// (set) Token: 0x060040A5 RID: 16549 RVA: 0x000D936D File Offset: 0x000D756D
		public global::System.Data.Entity.Core.Mapping.EndPropertyMapping SourceEndMapping
		{
			get
			{
				if (this.SingleFragment == null)
				{
					return null;
				}
				return this.SingleFragment.PropertyMappings.OfType<global::System.Data.Entity.Core.Mapping.EndPropertyMapping>().FirstOrDefault<global::System.Data.Entity.Core.Mapping.EndPropertyMapping>();
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EndPropertyMapping>(value, "value");
				base.ThrowIfReadOnly();
				this.SingleFragment.AddPropertyMapping(value);
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060040A6 RID: 16550 RVA: 0x000D938D File Offset: 0x000D758D
		// (set) Token: 0x060040A7 RID: 16551 RVA: 0x000D93AF File Offset: 0x000D75AF
		public global::System.Data.Entity.Core.Mapping.EndPropertyMapping TargetEndMapping
		{
			get
			{
				if (this.SingleFragment == null)
				{
					return null;
				}
				return this.SingleFragment.PropertyMappings.OfType<global::System.Data.Entity.Core.Mapping.EndPropertyMapping>().ElementAtOrDefault(1);
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.EndPropertyMapping>(value, "value");
				base.ThrowIfReadOnly();
				this.SingleFragment.AddPropertyMapping(value);
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060040A8 RID: 16552 RVA: 0x000D93CF File Offset: 0x000D75CF
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> Conditions
		{
			get
			{
				if (this.SingleFragment == null)
				{
					return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>());
				}
				return this.SingleFragment.Conditions;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x000D93EF File Offset: 0x000D75EF
		private global::System.Data.Entity.Core.Mapping.MappingFragment SingleFragment
		{
			get
			{
				if (this._associationTypeMapping == null)
				{
					return null;
				}
				return this._associationTypeMapping.MappingFragment;
			}
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x000D9406 File Offset: 0x000D7606
		public void AddCondition(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(condition, "condition");
			base.ThrowIfReadOnly();
			if (this.SingleFragment != null)
			{
				this.SingleFragment.AddCondition(condition);
			}
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x000D942E File Offset: 0x000D762E
		public void RemoveCondition(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(condition, "condition");
			base.ThrowIfReadOnly();
			if (this.SingleFragment != null)
			{
				this.SingleFragment.RemoveCondition(condition);
			}
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x000D9456 File Offset: 0x000D7656
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._associationTypeMapping);
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._modificationFunctionMapping);
			base.SetReadOnly();
		}

		// Token: 0x04001679 RID: 5753
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationSet _associationSet;

		// Token: 0x0400167A RID: 5754
		private global::System.Data.Entity.Core.Mapping.AssociationTypeMapping _associationTypeMapping;

		// Token: 0x0400167B RID: 5755
		private global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping _modificationFunctionMapping;
	}
}
