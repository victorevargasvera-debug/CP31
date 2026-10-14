using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000AD RID: 173
	[global::System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaNode
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00027126 File Offset: 0x00025326
		public string Id { get; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0002712E File Offset: 0x0002532E
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Newtonsoft.Json.Schema.JsonSchema> Schemas { get; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00027136 File Offset: 0x00025336
		public global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchemaNode> Properties { get; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0002713E File Offset: 0x0002533E
		public global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchemaNode> PatternProperties { get; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00027146 File Offset: 0x00025346
		public global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchemaNode> Items { get; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0002714E File Offset: 0x0002534E
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x00027156 File Offset: 0x00025356
		public global::Newtonsoft.Json.Schema.JsonSchemaNode AdditionalProperties { get; set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0002715F File Offset: 0x0002535F
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00027167 File Offset: 0x00025367
		public global::Newtonsoft.Json.Schema.JsonSchemaNode AdditionalItems { get; set; }

		// Token: 0x06000957 RID: 2391 RVA: 0x00027170 File Offset: 0x00025370
		public JsonSchemaNode(global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			this.Schemas = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Newtonsoft.Json.Schema.JsonSchema>(new global::Newtonsoft.Json.Schema.JsonSchema[]
			{
				schema
			});
			this.Properties = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchemaNode>();
			this.PatternProperties = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchemaNode>();
			this.Items = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchemaNode>();
			this.Id = global::Newtonsoft.Json.Schema.JsonSchemaNode.GetId(this.Schemas);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x000271CC File Offset: 0x000253CC
		private JsonSchemaNode(global::Newtonsoft.Json.Schema.JsonSchemaNode source, global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			this.Schemas = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Newtonsoft.Json.Schema.JsonSchema>(source.Schemas.Union(new global::Newtonsoft.Json.Schema.JsonSchema[]
			{
				schema
			}).ToList<global::Newtonsoft.Json.Schema.JsonSchema>());
			this.Properties = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchemaNode>(source.Properties);
			this.PatternProperties = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchemaNode>(source.PatternProperties);
			this.Items = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchemaNode>(source.Items);
			this.AdditionalProperties = source.AdditionalProperties;
			this.AdditionalItems = source.AdditionalItems;
			this.Id = global::Newtonsoft.Json.Schema.JsonSchemaNode.GetId(this.Schemas);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00027260 File Offset: 0x00025460
		public global::Newtonsoft.Json.Schema.JsonSchemaNode Combine(global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			return new global::Newtonsoft.Json.Schema.JsonSchemaNode(this, schema);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0002726C File Offset: 0x0002546C
		public static string GetId(global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Schema.JsonSchema> schemata)
		{
			return string.Join("-", (from s in schemata
			select s.InternalId).OrderBy((string id) => id, global::System.StringComparer.Ordinal));
		}
	}
}
