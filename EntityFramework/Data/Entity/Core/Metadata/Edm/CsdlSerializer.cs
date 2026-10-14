using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000496 RID: 1174
	public class CsdlSerializer
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06003A1F RID: 14879 RVA: 0x000BF88C File Offset: 0x000BDA8C
		// (remove) Token: 0x06003A20 RID: 14880 RVA: 0x000BF8C4 File Offset: 0x000BDAC4
		public event global::System.EventHandler<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> OnError;

		// Token: 0x06003A21 RID: 14881 RVA: 0x000BF8FC File Offset: 0x000BDAFC
		public bool Serialize(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Xml.XmlWriter xmlWriter, string modelNamespace = null)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>(model, "model");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Xml.XmlWriter>(xmlWriter, "xmlWriter");
			bool modelIsValid = true;
			global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> onErrorAction = delegate(global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs e)
			{
				modelIsValid = false;
				if (this.OnError != null)
				{
					this.OnError(this, e);
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
			if (modelIsValid)
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmSerializationVisitor(xmlWriter, model.SchemaVersion, false).Visit(model, modelNamespace);
				return true;
			}
			return false;
		}
	}
}
