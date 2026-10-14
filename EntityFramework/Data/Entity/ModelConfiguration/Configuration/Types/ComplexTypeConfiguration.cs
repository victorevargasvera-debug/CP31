using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Configuration.Types
{
	// Token: 0x020001FD RID: 509
	internal class ComplexTypeConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration
	{
		// Token: 0x06001AD3 RID: 6867 RVA: 0x00047884 File Offset: 0x00045A84
		internal ComplexTypeConfiguration(global::System.Type structuralType) : base(structuralType)
		{
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0004788D File Offset: 0x00045A8D
		private ComplexTypeConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration source) : base(source)
		{
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00047896 File Offset: 0x00045A96
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration(this);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0004789E File Offset: 0x00045A9E
		internal virtual void Configure(global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			base.Configure(complexType.Name, complexType.Properties, complexType.GetMetadataProperties());
		}
	}
}
