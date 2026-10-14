using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x0200016C RID: 364
	internal static class INamedDataModelItemExtensions
	{
		// Token: 0x06001691 RID: 5777 RVA: 0x0003A9BA File Offset: 0x00038BBA
		public static string UniquifyName(this global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.INamedDataModelItem> namedDataModelItems, string name)
		{
			return (from i in namedDataModelItems
			select i.Name).Uniquify(name);
		}
	}
}
