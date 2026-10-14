using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x0200016D RID: 365
	internal static class MetadataPropertyExtensions
	{
		// Token: 0x06001692 RID: 5778 RVA: 0x0003A9E7 File Offset: 0x00038BE7
		public static global::System.Collections.Generic.IList<global::System.Attribute> GetClrAttributes(this global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			return (global::System.Collections.Generic.IList<global::System.Attribute>)metadataProperties.GetAnnotation("ClrAttributes");
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0003A9F9 File Offset: 0x00038BF9
		public static void SetClrAttributes(this global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties, global::System.Collections.Generic.IList<global::System.Attribute> attributes)
		{
			metadataProperties.SetAnnotation("ClrAttributes", attributes);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0003AA07 File Offset: 0x00038C07
		public static global::System.Reflection.PropertyInfo GetClrPropertyInfo(this global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			return (global::System.Reflection.PropertyInfo)metadataProperties.GetAnnotation("ClrPropertyInfo");
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0003AA19 File Offset: 0x00038C19
		public static void SetClrPropertyInfo(this global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties, global::System.Reflection.PropertyInfo propertyInfo)
		{
			metadataProperties.SetAnnotation("ClrPropertyInfo", propertyInfo);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0003AA27 File Offset: 0x00038C27
		public static global::System.Type GetClrType(this global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			return (global::System.Type)metadataProperties.GetAnnotation("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:ClrType");
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0003AA39 File Offset: 0x00038C39
		public static void SetClrType(this global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties, global::System.Type type)
		{
			metadataProperties.SetAnnotation("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:ClrType", type);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0003AA47 File Offset: 0x00038C47
		public static object GetConfiguration(this global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			return metadataProperties.GetAnnotation("Configuration");
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0003AA54 File Offset: 0x00038C54
		public static void SetConfiguration(this global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties, object configuration)
		{
			metadataProperties.SetAnnotation("Configuration", configuration);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0003AA64 File Offset: 0x00038C64
		public static object GetAnnotation(this global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties, string name)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty in metadataProperties)
			{
				if (metadataProperty.Name.Equals(name, global::System.StringComparison.Ordinal))
				{
					return metadataProperty.Value;
				}
			}
			return null;
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0003AAC0 File Offset: 0x00038CC0
		public static void SetAnnotation(this global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties, string name, object value)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty = metadataProperties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty p) => p.Name.Equals(name, global::System.StringComparison.Ordinal));
			if (metadataProperty == null)
			{
				metadataProperty = global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty.CreateAnnotation(name, value);
				metadataProperties.Add(metadataProperty);
				return;
			}
			metadataProperty.Value = value;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0003AB0C File Offset: 0x00038D0C
		public static void RemoveAnnotation(this global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties, string name)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty = metadataProperties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty p) => p.Name.Equals(name, global::System.StringComparison.Ordinal));
			if (metadataProperty != null)
			{
				metadataProperties.Remove(metadataProperty);
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0003AB44 File Offset: 0x00038D44
		public static void Copy(this global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> sourceAnnotations, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> targetAnnotations)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty in sourceAnnotations)
			{
				targetAnnotations.SetAnnotation(metadataProperty.Name, metadataProperty.Value);
			}
		}

		// Token: 0x04000A0D RID: 2573
		private const string ClrPropertyInfoAnnotation = "ClrPropertyInfo";

		// Token: 0x04000A0E RID: 2574
		private const string ClrAttributesAnnotation = "ClrAttributes";

		// Token: 0x04000A0F RID: 2575
		private const string ConfiguationAnnotation = "Configuration";
	}
}
