using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x0200016E RID: 366
	internal static class NavigationPropertyExtensions
	{
		// Token: 0x0600169E RID: 5790 RVA: 0x0003AB98 File Offset: 0x00038D98
		public static object GetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty)
		{
			return navigationProperty.Annotations.GetConfiguration();
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0003ABA5 File Offset: 0x00038DA5
		public static void SetConfiguration(this global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty, object configuration)
		{
			navigationProperty.GetMetadataProperties().SetConfiguration(configuration);
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0003ABB3 File Offset: 0x00038DB3
		public static global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember GetFromEnd(this global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navProp)
		{
			if (navProp.Association.SourceEnd != navProp.ResultEnd)
			{
				return navProp.Association.SourceEnd;
			}
			return navProp.Association.TargetEnd;
		}
	}
}
