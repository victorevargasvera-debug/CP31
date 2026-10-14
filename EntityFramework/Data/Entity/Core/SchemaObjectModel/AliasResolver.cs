using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000318 RID: 792
	internal sealed class AliasResolver
	{
		// Token: 0x060025C2 RID: 9666 RVA: 0x0006AD6C File Offset: 0x00068F6C
		public AliasResolver(global::System.Data.Entity.Core.SchemaObjectModel.Schema schema)
		{
			this._definingSchema = schema;
			if (!string.IsNullOrEmpty(schema.Alias))
			{
				this._aliasToNamespaceMap.Add(schema.Alias, schema.Namespace);
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x0006ADC8 File Offset: 0x00068FC8
		public void Add(global::System.Data.Entity.Core.SchemaObjectModel.UsingElement usingElement)
		{
			string text = usingElement.NamespaceName;
			string text2 = usingElement.Alias;
			if (this.CheckForSystemNamespace(usingElement, text2, global::System.Data.Entity.Core.SchemaObjectModel.AliasResolver.NameKind.Alias))
			{
				text2 = null;
			}
			if (this.CheckForSystemNamespace(usingElement, text, global::System.Data.Entity.Core.SchemaObjectModel.AliasResolver.NameKind.Namespace))
			{
				text = null;
			}
			if (text2 != null && this._aliasToNamespaceMap.ContainsKey(text2))
			{
				usingElement.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AlreadyDefined, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.AliasNameIsAlreadyDefined(text2));
				text2 = null;
			}
			if (text2 != null)
			{
				this._aliasToNamespaceMap.Add(text2, text);
				this._usingElementCollection.Add(usingElement);
			}
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0006AE3B File Offset: 0x0006903B
		public bool TryResolveAlias(string alias, out string namespaceName)
		{
			return this._aliasToNamespaceMap.TryGetValue(alias, out namespaceName);
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x0006AE4C File Offset: 0x0006904C
		public void ResolveNamespaces()
		{
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.UsingElement usingElement in this._usingElementCollection)
			{
				if (!this._definingSchema.SchemaManager.IsValidNamespaceName(usingElement.NamespaceName))
				{
					usingElement.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidNamespaceInUsing, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidNamespaceInUsing(usingElement.NamespaceName));
				}
			}
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x0006AEC8 File Offset: 0x000690C8
		private bool CheckForSystemNamespace(global::System.Data.Entity.Core.SchemaObjectModel.UsingElement refSchema, string name, global::System.Data.Entity.Core.SchemaObjectModel.AliasResolver.NameKind nameKind)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection.IsSystemNamespace(this._definingSchema.ProviderManifest, name))
			{
				if (nameKind == global::System.Data.Entity.Core.SchemaObjectModel.AliasResolver.NameKind.Alias)
				{
					refSchema.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.CannotUseSystemNamespaceAsAlias, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.CannotUseSystemNamespaceAsAlias(name));
				}
				else
				{
					refSchema.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.NeedNotUseSystemNamespaceInUsing, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.NeedNotUseSystemNamespaceInUsing(name));
				}
				return true;
			}
			return false;
		}

		// Token: 0x04000D46 RID: 3398
		private readonly global::System.Collections.Generic.Dictionary<string, string> _aliasToNamespaceMap = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal);

		// Token: 0x04000D47 RID: 3399
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.UsingElement> _usingElementCollection = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.UsingElement>();

		// Token: 0x04000D48 RID: 3400
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.Schema _definingSchema;

		// Token: 0x020009BD RID: 2493
		private enum NameKind
		{
			// Token: 0x04002811 RID: 10257
			Alias,
			// Token: 0x04002812 RID: 10258
			Namespace
		}
	}
}
