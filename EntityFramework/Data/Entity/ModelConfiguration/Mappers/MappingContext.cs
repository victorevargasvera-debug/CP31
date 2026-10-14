using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Utilities;

namespace System.Data.Entity.ModelConfiguration.Mappers
{
	// Token: 0x02000159 RID: 345
	internal sealed class MappingContext
	{
		// Token: 0x060015F5 RID: 5621 RVA: 0x00037E38 File Offset: 0x00036038
		public MappingContext(global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.DbModelBuilderVersion modelBuilderVersion = global::System.Data.Entity.DbModelBuilderVersion.Latest, global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider attributeProvider = null)
		{
			this._modelConfiguration = modelConfiguration;
			this._conventionsConfiguration = conventionsConfiguration;
			this._model = model;
			this._modelBuilderVersion = modelBuilderVersion;
			this._attributeProvider = (attributeProvider ?? new global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider());
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x00037E6E File Offset: 0x0003606E
		public global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration ModelConfiguration
		{
			get
			{
				return this._modelConfiguration;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00037E76 File Offset: 0x00036076
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration ConventionsConfiguration
		{
			get
			{
				return this._conventionsConfiguration;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00037E7E File Offset: 0x0003607E
		public global::System.Data.Entity.Core.Metadata.Edm.EdmModel Model
		{
			get
			{
				return this._model;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00037E86 File Offset: 0x00036086
		public global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider AttributeProvider
		{
			get
			{
				return this._attributeProvider;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x00037E8E File Offset: 0x0003608E
		public global::System.Data.Entity.DbModelBuilderVersion ModelBuilderVersion
		{
			get
			{
				return this._modelBuilderVersion;
			}
		}

		// Token: 0x040009F6 RID: 2550
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration _modelConfiguration;

		// Token: 0x040009F7 RID: 2551
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration _conventionsConfiguration;

		// Token: 0x040009F8 RID: 2552
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModel _model;

		// Token: 0x040009F9 RID: 2553
		private readonly global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider _attributeProvider;

		// Token: 0x040009FA RID: 2554
		private readonly global::System.Data.Entity.DbModelBuilderVersion _modelBuilderVersion;
	}
}
