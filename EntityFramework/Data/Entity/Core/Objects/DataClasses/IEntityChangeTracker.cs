using System;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x0200047A RID: 1146
	public interface IEntityChangeTracker
	{
		// Token: 0x06003855 RID: 14421
		void EntityMemberChanging(string entityMemberName);

		// Token: 0x06003856 RID: 14422
		void EntityMemberChanged(string entityMemberName);

		// Token: 0x06003857 RID: 14423
		void EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName);

		// Token: 0x06003858 RID: 14424
		void EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName);

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06003859 RID: 14425
		global::System.Data.Entity.EntityState EntityState { get; }
	}
}
