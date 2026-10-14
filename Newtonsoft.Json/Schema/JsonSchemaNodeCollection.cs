using System;
using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000AE RID: 174
	[global::System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaNodeCollection : global::System.Collections.ObjectModel.KeyedCollection<string, global::Newtonsoft.Json.Schema.JsonSchemaNode>
	{
		// Token: 0x0600095B RID: 2395 RVA: 0x000272D1 File Offset: 0x000254D1
		protected override string GetKeyForItem(global::Newtonsoft.Json.Schema.JsonSchemaNode item)
		{
			return item.Id;
		}
	}
}
