using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004FB RID: 1275
	public class SsdlSerializer
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06003F1E RID: 16158 RVA: 0x000D0E68 File Offset: 0x000CF068
		// (remove) Token: 0x06003F1F RID: 16159 RVA: 0x000D0EA0 File Offset: 0x000CF0A0
		public event global::System.EventHandler<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> OnError;

		// Token: 0x06003F20 RID: 16160 RVA: 0x000D0ED8 File Offset: 0x000CF0D8
		public virtual bool Serialize(global::System.Data.Entity.Core.Metadata.Edm.EdmModel dbDatabase, string provider, string providerManifestToken, global::System.Xml.XmlWriter xmlWriter, bool serializeDefaultNullability = true)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>(dbDatabase, "dbDatabase");
			global::System.Data.Entity.Utilities.Check.NotEmpty(provider, "provider");
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerManifestToken, "providerManifestToken");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Xml.XmlWriter>(xmlWriter, "xmlWriter");
			if (this.ValidateModel(dbDatabase))
			{
				global::System.Data.Entity.Core.Metadata.Edm.SsdlSerializer.CreateVisitor(xmlWriter, dbDatabase, serializeDefaultNullability).Visit(dbDatabase, provider, providerManifestToken);
				return true;
			}
			return false;
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x000D0F34 File Offset: 0x000CF134
		public virtual bool Serialize(global::System.Data.Entity.Core.Metadata.Edm.EdmModel dbDatabase, string namespaceName, string provider, string providerManifestToken, global::System.Xml.XmlWriter xmlWriter, bool serializeDefaultNullability = true)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>(dbDatabase, "dbDatabase");
			global::System.Data.Entity.Utilities.Check.NotEmpty(namespaceName, "namespaceName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(provider, "provider");
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerManifestToken, "providerManifestToken");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Xml.XmlWriter>(xmlWriter, "xmlWriter");
			if (this.ValidateModel(dbDatabase))
			{
				global::System.Data.Entity.Core.Metadata.Edm.SsdlSerializer.CreateVisitor(xmlWriter, dbDatabase, serializeDefaultNullability).Visit(dbDatabase, namespaceName, provider, providerManifestToken);
				return true;
			}
			return false;
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x000D0FA0 File Offset: 0x000CF1A0
		private bool ValidateModel(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			bool modelIsValid = true;
			global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> onErrorAction = delegate(global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs e)
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item = e.Item;
				if (item == null || !global::System.Data.Entity.Core.Metadata.Edm.MetadataItemHelper.IsInvalid(item))
				{
					modelIsValid = false;
					if (this.OnError != null)
					{
						this.OnError(this, e);
					}
				}
			};
			if (model.NamespaceNames.Count<string>() > 1 || model.Containers.Count<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>() != 1)
			{
				onErrorAction(new global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs
				{
					ErrorMessage = global::System.Data.Entity.Resources.Strings.Serializer_OneNamespaceAndOneContainer
				});
			}
			global::System.Data.Entity.Core.Metadata.Edm.DataModelValidator dataModelValidator = new global::System.Data.Entity.Core.Metadata.Edm.DataModelValidator();
			dataModelValidator.OnError += delegate(object _, global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs e)
			{
				onErrorAction(e);
			};
			dataModelValidator.Validate(model, true);
			return modelIsValid;
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x000D102E File Offset: 0x000CF22E
		private static global::System.Data.Entity.Core.Metadata.Edm.EdmSerializationVisitor CreateVisitor(global::System.Xml.XmlWriter xmlWriter, global::System.Data.Entity.Core.Metadata.Edm.EdmModel dbDatabase, bool serializeDefaultNullability)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.EdmSerializationVisitor(xmlWriter, dbDatabase.SchemaVersion, serializeDefaultNullability);
		}
	}
}
