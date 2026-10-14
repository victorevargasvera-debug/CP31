using System;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001F6 RID: 502
	public class PropertyMappingConfiguration
	{
		// Token: 0x06001A4C RID: 6732 RVA: 0x00045F26 File Offset: 0x00044126
		internal PropertyMappingConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration configuration)
		{
			this._configuration = configuration;
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x00045F35 File Offset: 0x00044135
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration Configuration
		{
			get
			{
				return this._configuration;
			}
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00045F3D File Offset: 0x0004413D
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration HasColumnName(string columnName)
		{
			this.Configuration.ColumnName = columnName;
			return this;
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00045F4C File Offset: 0x0004414C
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration HasColumnAnnotation(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.Configuration.SetAnnotation(name, value);
			return this;
		}

		// Token: 0x04000A90 RID: 2704
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration _configuration;
	}
}
