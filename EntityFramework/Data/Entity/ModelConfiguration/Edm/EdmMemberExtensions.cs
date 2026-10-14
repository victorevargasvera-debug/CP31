using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000163 RID: 355
	internal static class EdmMemberExtensions
	{
		// Token: 0x06001637 RID: 5687 RVA: 0x000397A3 File Offset: 0x000379A3
		public static global::System.Reflection.PropertyInfo GetClrPropertyInfo(this global::System.Data.Entity.Core.Metadata.Edm.EdmMember property)
		{
			return property.Annotations.GetClrPropertyInfo();
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x000397B0 File Offset: 0x000379B0
		public static void SetClrPropertyInfo(this global::System.Data.Entity.Core.Metadata.Edm.EdmMember property, global::System.Reflection.PropertyInfo propertyInfo)
		{
			property.GetMetadataProperties().SetClrPropertyInfo(propertyInfo);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x000397C0 File Offset: 0x000379C0
		public static global::System.Collections.Generic.IEnumerable<T> GetClrAttributes<T>(this global::System.Data.Entity.Core.Metadata.Edm.EdmMember property) where T : global::System.Attribute
		{
			global::System.Collections.Generic.IList<global::System.Attribute> clrAttributes = property.Annotations.GetClrAttributes();
			if (clrAttributes == null)
			{
				return global::System.Linq.Enumerable.Empty<T>();
			}
			return clrAttributes.OfType<T>();
		}
	}
}
