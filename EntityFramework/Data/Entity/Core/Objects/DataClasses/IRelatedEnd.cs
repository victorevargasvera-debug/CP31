using System;
using System.Collections;
using System.Data.Entity.Core.Metadata.Edm;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x0200047E RID: 1150
	public interface IRelatedEnd
	{
		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x0600385E RID: 14430
		// (set) Token: 0x0600385F RID: 14431
		bool IsLoaded { get; set; }

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06003860 RID: 14432
		string RelationshipName { get; }

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06003861 RID: 14433
		string SourceRoleName { get; }

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06003862 RID: 14434
		string TargetRoleName { get; }

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06003863 RID: 14435
		global::System.Data.Entity.Core.Metadata.Edm.RelationshipSet RelationshipSet { get; }

		// Token: 0x06003864 RID: 14436
		void Load();

		// Token: 0x06003865 RID: 14437
		global::System.Threading.Tasks.Task LoadAsync(global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x06003866 RID: 14438
		void Load(global::System.Data.Entity.Core.Objects.MergeOption mergeOption);

		// Token: 0x06003867 RID: 14439
		global::System.Threading.Tasks.Task LoadAsync(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x06003868 RID: 14440
		void Add(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships entity);

		// Token: 0x06003869 RID: 14441
		void Add(object entity);

		// Token: 0x0600386A RID: 14442
		bool Remove(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships entity);

		// Token: 0x0600386B RID: 14443
		bool Remove(object entity);

		// Token: 0x0600386C RID: 14444
		void Attach(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships entity);

		// Token: 0x0600386D RID: 14445
		void Attach(object entity);

		// Token: 0x0600386E RID: 14446
		global::System.Collections.IEnumerable CreateSourceQuery();

		// Token: 0x0600386F RID: 14447
		global::System.Collections.IEnumerator GetEnumerator();
	}
}
