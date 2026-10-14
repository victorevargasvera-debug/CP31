using System;
using System.Data.Entity.Infrastructure;
using System.Xml;
using System.Xml.Linq;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000076 RID: 118
	internal static class DbModelExtensions
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x0000EAF4 File Offset: 0x0000CCF4
		public static global::System.Xml.Linq.XDocument GetModel(this global::System.Data.Entity.Infrastructure.DbModel model)
		{
			return global::System.Data.Entity.Utilities.DbContextExtensions.GetModel(delegate(global::System.Xml.XmlWriter w)
			{
				global::System.Data.Entity.Infrastructure.EdmxWriter.WriteEdmx(model, w);
			});
		}
	}
}
