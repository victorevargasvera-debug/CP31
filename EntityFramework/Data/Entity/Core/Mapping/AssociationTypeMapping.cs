using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000520 RID: 1312
	public class AssociationTypeMapping : global::System.Data.Entity.Core.Mapping.TypeMapping
	{
		// Token: 0x060040B3 RID: 16563 RVA: 0x000D9525 File Offset: 0x000D7725
		public AssociationTypeMapping(global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.AssociationSetMapping>(associationSetMapping, "associationSetMapping");
			this._associationSetMapping = associationSetMapping;
			this.m_relation = associationSetMapping.AssociationSet.ElementType;
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x000D9551 File Offset: 0x000D7751
		internal AssociationTypeMapping(global::System.Data.Entity.Core.Metadata.Edm.AssociationType relation, global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping)
		{
			this._associationSetMapping = associationSetMapping;
			this.m_relation = relation;
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060040B5 RID: 16565 RVA: 0x000D9567 File Offset: 0x000D7767
		public global::System.Data.Entity.Core.Mapping.AssociationSetMapping AssociationSetMapping
		{
			get
			{
				return this._associationSetMapping;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x060040B6 RID: 16566 RVA: 0x000D956F File Offset: 0x000D776F
		internal override global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping SetMapping
		{
			get
			{
				return this.AssociationSetMapping;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x060040B7 RID: 16567 RVA: 0x000D9577 File Offset: 0x000D7777
		public global::System.Data.Entity.Core.Metadata.Edm.AssociationType AssociationType
		{
			get
			{
				return this.m_relation;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060040B8 RID: 16568 RVA: 0x000D957F File Offset: 0x000D777F
		// (set) Token: 0x060040B9 RID: 16569 RVA: 0x000D9587 File Offset: 0x000D7787
		public global::System.Data.Entity.Core.Mapping.MappingFragment MappingFragment
		{
			get
			{
				return this._mappingFragment;
			}
			internal set
			{
				this._mappingFragment = value;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x000D9590 File Offset: 0x000D7790
		internal override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.MappingFragment> MappingFragments
		{
			get
			{
				if (this._mappingFragment != null)
				{
					return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.MappingFragment>(new global::System.Data.Entity.Core.Mapping.MappingFragment[]
					{
						this._mappingFragment
					});
				}
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.MappingFragment>(new global::System.Data.Entity.Core.Mapping.MappingFragment[0]);
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060040BB RID: 16571 RVA: 0x000D95BA File Offset: 0x000D77BA
		internal override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> Types
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(new global::System.Data.Entity.Core.Metadata.Edm.AssociationType[]
				{
					this.m_relation
				});
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060040BC RID: 16572 RVA: 0x000D95D0 File Offset: 0x000D77D0
		internal override global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> IsOfTypes
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>());
			}
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x000D95DC File Offset: 0x000D77DC
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._mappingFragment);
			base.SetReadOnly();
		}

		// Token: 0x0400167F RID: 5759
		private readonly global::System.Data.Entity.Core.Mapping.AssociationSetMapping _associationSetMapping;

		// Token: 0x04001680 RID: 5760
		private global::System.Data.Entity.Core.Mapping.MappingFragment _mappingFragment;

		// Token: 0x04001681 RID: 5761
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationType m_relation;
	}
}
