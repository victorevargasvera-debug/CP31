using System;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004AE RID: 1198
	internal sealed class EdmModelValidationContext
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06003AFA RID: 15098 RVA: 0x000C2140 File Offset: 0x000C0340
		// (remove) Token: 0x06003AFB RID: 15099 RVA: 0x000C2178 File Offset: 0x000C0378
		public event global::System.EventHandler<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> OnError;

		// Token: 0x06003AFC RID: 15100 RVA: 0x000C21AD File Offset: 0x000C03AD
		public EdmModelValidationContext(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, bool validateSyntax)
		{
			this._model = model;
			this._validateSyntax = validateSyntax;
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06003AFD RID: 15101 RVA: 0x000C21C3 File Offset: 0x000C03C3
		public bool ValidateSyntax
		{
			get
			{
				return this._validateSyntax;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06003AFE RID: 15102 RVA: 0x000C21CB File Offset: 0x000C03CB
		public global::System.Data.Entity.Core.Metadata.Edm.EdmModel Model
		{
			get
			{
				return this._model;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06003AFF RID: 15103 RVA: 0x000C21D3 File Offset: 0x000C03D3
		public bool IsCSpace
		{
			get
			{
				return this._model.Containers.First<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace;
			}
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x000C21ED File Offset: 0x000C03ED
		public void AddError(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item, string propertyName, string errorMessage)
		{
			this.RaiseDataModelValidationEvent(new global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs
			{
				ErrorMessage = errorMessage,
				Item = item,
				PropertyName = propertyName
			});
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x000C220F File Offset: 0x000C040F
		private void RaiseDataModelValidationEvent(global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs error)
		{
			if (this.OnError != null)
			{
				this.OnError(this, error);
			}
		}

		// Token: 0x04001471 RID: 5233
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModel _model;

		// Token: 0x04001472 RID: 5234
		private readonly bool _validateSyntax;
	}
}
