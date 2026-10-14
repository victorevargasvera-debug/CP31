using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Internal;
using System.Data.Entity.Utilities;

namespace System.Data.Entity
{
	// Token: 0x0200006B RID: 107
	public static class ObservableCollectionExtensions
	{
		// Token: 0x0600036F RID: 879 RVA: 0x0000B1E4 File Offset: 0x000093E4
		public static global::System.ComponentModel.BindingList<T> ToBindingList<T>(this global::System.Collections.ObjectModel.ObservableCollection<T> source) where T : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.ObjectModel.ObservableCollection<T>>(source, "source");
			global::System.Data.Entity.Internal.DbLocalView<T> dbLocalView = source as global::System.Data.Entity.Internal.DbLocalView<T>;
			if (dbLocalView == null)
			{
				return new global::System.Data.Entity.Internal.ObservableBackedBindingList<T>(source);
			}
			return dbLocalView.BindingList;
		}
	}
}
