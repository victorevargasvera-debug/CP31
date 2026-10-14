using System;
using System.Collections.Generic;
using System.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000AF RID: 175
	[global::System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonSchemaResolver
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x000272E1 File Offset: 0x000254E1
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x000272E9 File Offset: 0x000254E9
		public global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchema> LoadedSchemas { get; protected set; }

		// Token: 0x0600095F RID: 2399 RVA: 0x000272F2 File Offset: 0x000254F2
		public JsonSchemaResolver()
		{
			this.LoadedSchemas = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchema>();
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00027308 File Offset: 0x00025508
		public virtual global::Newtonsoft.Json.Schema.JsonSchema GetSchema(string reference)
		{
			global::Newtonsoft.Json.Schema.JsonSchema jsonSchema = this.LoadedSchemas.SingleOrDefault((global::Newtonsoft.Json.Schema.JsonSchema s) => string.Equals(s.Id, reference, global::System.StringComparison.Ordinal));
			if (jsonSchema == null)
			{
				jsonSchema = this.LoadedSchemas.SingleOrDefault((global::Newtonsoft.Json.Schema.JsonSchema s) => string.Equals(s.Location, reference, global::System.StringComparison.Ordinal));
			}
			return jsonSchema;
		}
	}
}
