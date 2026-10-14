using System;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200044A RID: 1098
	internal interface IPropertyAccessorStrategy
	{
		// Token: 0x0600359D RID: 13725
		object GetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd);

		// Token: 0x0600359E RID: 13726
		void SetNavigationPropertyValue(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x0600359F RID: 13727
		void CollectionAdd(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x060035A0 RID: 13728
		bool CollectionRemove(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd, object value);

		// Token: 0x060035A1 RID: 13729
		object CollectionCreate(global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd relatedEnd);
	}
}
