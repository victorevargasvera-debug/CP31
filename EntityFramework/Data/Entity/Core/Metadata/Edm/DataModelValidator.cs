using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200049C RID: 1180
	internal class DataModelValidator
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06003A37 RID: 14903 RVA: 0x000BFAE4 File Offset: 0x000BDCE4
		// (remove) Token: 0x06003A38 RID: 14904 RVA: 0x000BFB1C File Offset: 0x000BDD1C
		public event global::System.EventHandler<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> OnError;

		// Token: 0x06003A39 RID: 14905 RVA: 0x000BFB51 File Offset: 0x000BDD51
		public void Validate(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, bool validateSyntax)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext edmModelValidationContext = new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext(model, validateSyntax);
			edmModelValidationContext.OnError += this.OnError;
			new global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationVisitor(edmModelValidationContext, global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet.CreateEdmModelRuleSet(model.SchemaVersion, validateSyntax)).Visit(model);
		}
	}
}
