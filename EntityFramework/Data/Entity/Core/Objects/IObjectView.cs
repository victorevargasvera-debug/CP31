using System;
using System.ComponentModel;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200040F RID: 1039
	internal interface IObjectView
	{
		// Token: 0x06003147 RID: 12615
		void EntityPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e);

		// Token: 0x06003148 RID: 12616
		void CollectionChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e);
	}
}
