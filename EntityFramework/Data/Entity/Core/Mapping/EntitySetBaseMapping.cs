using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200052C RID: 1324
	public abstract class EntitySetBaseMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x06004169 RID: 16745 RVA: 0x000DC681 File Offset: 0x000DA881
		internal EntitySetBaseMapping(global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping)
		{
			this._containerMapping = containerMapping;
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x0600416A RID: 16746 RVA: 0x000DC6A0 File Offset: 0x000DA8A0
		public global::System.Data.Entity.Core.Mapping.EntityContainerMapping ContainerMapping
		{
			get
			{
				return this._containerMapping;
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x000DC6A8 File Offset: 0x000DA8A8
		internal global::System.Data.Entity.Core.Mapping.EntityContainerMapping EntityContainerMapping
		{
			get
			{
				return this.ContainerMapping;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x000DC6B0 File Offset: 0x000DA8B0
		// (set) Token: 0x0600416D RID: 16749 RVA: 0x000DC6B8 File Offset: 0x000DA8B8
		public string QueryView
		{
			get
			{
				return this._queryView;
			}
			set
			{
				base.ThrowIfReadOnly();
				this._queryView = value;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x0600416E RID: 16750
		internal abstract global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase Set { get; }

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x0600416F RID: 16751
		internal abstract global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.TypeMapping> TypeMappings { get; }

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x000DC6C8 File Offset: 0x000DA8C8
		internal virtual bool HasNoContent
		{
			get
			{
				if (this.QueryView != null)
				{
					return false;
				}
				foreach (global::System.Data.Entity.Core.Mapping.TypeMapping typeMapping in this.TypeMappings)
				{
					using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.MappingFragment> enumerator2 = typeMapping.MappingFragments.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.AllProperties.Any<global::System.Data.Entity.Core.Mapping.PropertyMapping>())
							{
								return false;
							}
						}
					}
				}
				return true;
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x000DC760 File Offset: 0x000DA960
		// (set) Token: 0x06004172 RID: 16754 RVA: 0x000DC768 File Offset: 0x000DA968
		internal int StartLineNumber { get; set; }

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06004173 RID: 16755 RVA: 0x000DC771 File Offset: 0x000DA971
		// (set) Token: 0x06004174 RID: 16756 RVA: 0x000DC779 File Offset: 0x000DA979
		internal int StartLinePosition { get; set; }

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06004175 RID: 16757 RVA: 0x000DC782 File Offset: 0x000DA982
		// (set) Token: 0x06004176 RID: 16758 RVA: 0x000DC78A File Offset: 0x000DA98A
		internal bool HasModificationFunctionMapping { get; set; }

		// Token: 0x06004177 RID: 16759 RVA: 0x000DC793 File Offset: 0x000DA993
		internal bool ContainsTypeSpecificQueryView(global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>> key)
		{
			return this._typeSpecificQueryViews.ContainsKey(key);
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x000DC7A1 File Offset: 0x000DA9A1
		internal void AddTypeSpecificQueryView(global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>> key, string viewString)
		{
			this._typeSpecificQueryViews.Add(key, viewString);
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x000DC7B0 File Offset: 0x000DA9B0
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>> GetTypeSpecificQVKeys()
		{
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>>(this._typeSpecificQueryViews.Keys.ToList<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>>());
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x000DC7C7 File Offset: 0x000DA9C7
		internal string GetTypeSpecificQueryView(global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>> key)
		{
			return this._typeSpecificQueryViews[key];
		}

		// Token: 0x040016AD RID: 5805
		private readonly global::System.Data.Entity.Core.Mapping.EntityContainerMapping _containerMapping;

		// Token: 0x040016AE RID: 5806
		private string _queryView;

		// Token: 0x040016AF RID: 5807
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>, string> _typeSpecificQueryViews = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>, string>(global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Pair<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase, bool>>.PairComparer.Instance);
	}
}
