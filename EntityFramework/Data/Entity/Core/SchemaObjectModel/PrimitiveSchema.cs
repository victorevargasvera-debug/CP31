using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000301 RID: 769
	internal class PrimitiveSchema : global::System.Data.Entity.Core.SchemaObjectModel.Schema
	{
		// Token: 0x06002483 RID: 9347 RVA: 0x00066758 File Offset: 0x00064958
		public PrimitiveSchema(global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager schemaManager) : base(schemaManager)
		{
			base.Schema = this;
			global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest = base.ProviderManifest;
			if (providerManifest == null)
			{
				base.AddError(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(global::System.Data.Entity.Resources.Strings.FailedToRetrieveProviderManifest, 168, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error));
				return;
			}
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> list = providerManifest.GetStoreTypes();
			if (schemaManager.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel && schemaManager.SchemaVersion < 3.0)
			{
				list = (from t in list
				where !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(t)
				select t).ToList<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>();
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType in list)
			{
				base.TryAddType(new global::System.Data.Entity.Core.SchemaObjectModel.ScalarType(this, primitiveType.Name, primitiveType), false);
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x00066828 File Offset: 0x00064A28
		internal override string Alias
		{
			get
			{
				return base.ProviderManifest.NamespaceName;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x00066835 File Offset: 0x00064A35
		internal override string Namespace
		{
			get
			{
				if (base.ProviderManifest != null)
				{
					return base.ProviderManifest.NamespaceName;
				}
				return string.Empty;
			}
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x00066850 File Offset: 0x00064A50
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			return false;
		}
	}
}
