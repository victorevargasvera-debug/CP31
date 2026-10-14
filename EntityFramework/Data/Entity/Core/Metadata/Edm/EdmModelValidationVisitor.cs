using System;
using System.Collections.Generic;
using System.Data.Entity.Edm;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004B0 RID: 1200
	internal sealed class EdmModelValidationVisitor : global::System.Data.Entity.Edm.EdmModelVisitor
	{
		// Token: 0x06003B03 RID: 15107 RVA: 0x000C222F File Offset: 0x000C042F
		internal EdmModelValidationVisitor(global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext context, global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet ruleSet)
		{
			this._context = context;
			this._ruleSet = ruleSet;
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x000C2250 File Offset: 0x000C0450
		protected internal override void VisitMetadataItem(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			if (this._visitedItems.Add(item))
			{
				this.EvaluateItem(item);
			}
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x000C2268 File Offset: 0x000C0468
		private void EvaluateItem(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.DataModelValidationRule dataModelValidationRule in this._ruleSet.GetRules(item))
			{
				dataModelValidationRule.Evaluate(this._context, item);
			}
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x000C22C0 File Offset: 0x000C04C0
		internal void Visit(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			this.EvaluateItem(model);
			this.VisitEdmModel(model);
		}

		// Token: 0x04001473 RID: 5235
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelValidationContext _context;

		// Token: 0x04001474 RID: 5236
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModelRuleSet _ruleSet;

		// Token: 0x04001475 RID: 5237
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem> _visitedItems = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem>();
	}
}
