using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200049A RID: 1178
	internal abstract class DataModelValidationRuleSet
	{
		// Token: 0x06003A30 RID: 14896 RVA: 0x000BFA4F File Offset: 0x000BDC4F
		protected void AddRule(global::System.Data.Entity.Core.Metadata.Edm.DataModelValidationRule rule)
		{
			this._rules.Add(rule);
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x000BFA5D File Offset: 0x000BDC5D
		protected void RemoveRule(global::System.Data.Entity.Core.Metadata.Edm.DataModelValidationRule rule)
		{
			this._rules.Remove(rule);
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x000BFA6C File Offset: 0x000BDC6C
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.DataModelValidationRule> GetRules(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem itemToValidate)
		{
			return from r in this._rules
			where r.ValidatedType.IsInstanceOfType(itemToValidate)
			select r;
		}

		// Token: 0x04001368 RID: 4968
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.DataModelValidationRule> _rules = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.DataModelValidationRule>();
	}
}
