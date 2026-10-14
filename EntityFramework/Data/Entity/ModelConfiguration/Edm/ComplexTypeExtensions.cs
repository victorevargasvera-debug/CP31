using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000160 RID: 352
	internal static class ComplexTypeExtensions
	{
		// Token: 0x06001625 RID: 5669 RVA: 0x00039120 File Offset: 0x00037320
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty AddComplexProperty(this global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType, string name, global::System.Data.Entity.Core.Metadata.Edm.ComplexType targetComplexType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = global::System.Data.Entity.Core.Metadata.Edm.EdmProperty.CreateComplex(name, targetComplexType);
			complexType.AddMember(edmProperty);
			return edmProperty;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0003913D File Offset: 0x0003733D
		public static object GetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			return complexType.Annotations.GetConfiguration();
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0003914A File Offset: 0x0003734A
		public static global::System.Type GetClrType(this global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			return complexType.Annotations.GetClrType();
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00039157 File Offset: 0x00037357
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ComplexType> ToHierarchy(this global::System.Data.Entity.Core.Metadata.Edm.ComplexType edmType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.EdmType.SafeTraverseHierarchy<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(edmType);
		}
	}
}
