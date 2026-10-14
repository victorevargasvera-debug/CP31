using System;
using System.Collections.Generic;
using System.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000AC RID: 172
	[global::System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaModelBuilder
	{
		// Token: 0x06000945 RID: 2373 RVA: 0x00026CC5 File Offset: 0x00024EC5
		public global::Newtonsoft.Json.Schema.JsonSchemaModel Build(global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			this._nodes = new global::Newtonsoft.Json.Schema.JsonSchemaNodeCollection();
			this._node = this.AddSchema(null, schema);
			this._nodeModels = new global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Schema.JsonSchemaNode, global::Newtonsoft.Json.Schema.JsonSchemaModel>();
			return this.BuildNodeModel(this._node);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00026CF8 File Offset: 0x00024EF8
		public global::Newtonsoft.Json.Schema.JsonSchemaNode AddSchema(global::Newtonsoft.Json.Schema.JsonSchemaNode existingNode, global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			string id;
			if (existingNode != null)
			{
				if (existingNode.Schemas.Contains(schema))
				{
					return existingNode;
				}
				id = global::Newtonsoft.Json.Schema.JsonSchemaNode.GetId(existingNode.Schemas.Union(new global::Newtonsoft.Json.Schema.JsonSchema[]
				{
					schema
				}));
			}
			else
			{
				id = global::Newtonsoft.Json.Schema.JsonSchemaNode.GetId(new global::Newtonsoft.Json.Schema.JsonSchema[]
				{
					schema
				});
			}
			if (this._nodes.Contains(id))
			{
				return this._nodes[id];
			}
			global::Newtonsoft.Json.Schema.JsonSchemaNode jsonSchemaNode = (existingNode != null) ? existingNode.Combine(schema) : new global::Newtonsoft.Json.Schema.JsonSchemaNode(schema);
			this._nodes.Add(jsonSchemaNode);
			this.AddProperties(schema.Properties, jsonSchemaNode.Properties);
			this.AddProperties(schema.PatternProperties, jsonSchemaNode.PatternProperties);
			if (schema.Items != null)
			{
				for (int i = 0; i < schema.Items.Count; i++)
				{
					this.AddItem(jsonSchemaNode, i, schema.Items[i]);
				}
			}
			if (schema.AdditionalItems != null)
			{
				this.AddAdditionalItems(jsonSchemaNode, schema.AdditionalItems);
			}
			if (schema.AdditionalProperties != null)
			{
				this.AddAdditionalProperties(jsonSchemaNode, schema.AdditionalProperties);
			}
			if (schema.Extends != null)
			{
				foreach (global::Newtonsoft.Json.Schema.JsonSchema schema2 in schema.Extends)
				{
					jsonSchemaNode = this.AddSchema(jsonSchemaNode, schema2);
				}
			}
			return jsonSchemaNode;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00026E4C File Offset: 0x0002504C
		public void AddProperties(global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Schema.JsonSchema> source, global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Schema.JsonSchemaNode> target)
		{
			if (source != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Schema.JsonSchema> keyValuePair in source)
				{
					this.AddProperty(target, keyValuePair.Key, keyValuePair.Value);
				}
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00026EA8 File Offset: 0x000250A8
		public void AddProperty(global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Schema.JsonSchemaNode> target, string propertyName, global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			global::Newtonsoft.Json.Schema.JsonSchemaNode existingNode;
			target.TryGetValue(propertyName, out existingNode);
			target[propertyName] = this.AddSchema(existingNode, schema);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00026ED0 File Offset: 0x000250D0
		public void AddItem(global::Newtonsoft.Json.Schema.JsonSchemaNode parentNode, int index, global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			global::Newtonsoft.Json.Schema.JsonSchemaNode existingNode = (parentNode.Items.Count > index) ? parentNode.Items[index] : null;
			global::Newtonsoft.Json.Schema.JsonSchemaNode jsonSchemaNode = this.AddSchema(existingNode, schema);
			if (parentNode.Items.Count <= index)
			{
				parentNode.Items.Add(jsonSchemaNode);
				return;
			}
			parentNode.Items[index] = jsonSchemaNode;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00026F2C File Offset: 0x0002512C
		public void AddAdditionalProperties(global::Newtonsoft.Json.Schema.JsonSchemaNode parentNode, global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			parentNode.AdditionalProperties = this.AddSchema(parentNode.AdditionalProperties, schema);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00026F41 File Offset: 0x00025141
		public void AddAdditionalItems(global::Newtonsoft.Json.Schema.JsonSchemaNode parentNode, global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			parentNode.AdditionalItems = this.AddSchema(parentNode.AdditionalItems, schema);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00026F58 File Offset: 0x00025158
		private global::Newtonsoft.Json.Schema.JsonSchemaModel BuildNodeModel(global::Newtonsoft.Json.Schema.JsonSchemaNode node)
		{
			global::Newtonsoft.Json.Schema.JsonSchemaModel jsonSchemaModel;
			if (this._nodeModels.TryGetValue(node, out jsonSchemaModel))
			{
				return jsonSchemaModel;
			}
			jsonSchemaModel = global::Newtonsoft.Json.Schema.JsonSchemaModel.Create(node.Schemas);
			this._nodeModels[node] = jsonSchemaModel;
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Schema.JsonSchemaNode> keyValuePair in node.Properties)
			{
				if (jsonSchemaModel.Properties == null)
				{
					jsonSchemaModel.Properties = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchemaModel>();
				}
				jsonSchemaModel.Properties[keyValuePair.Key] = this.BuildNodeModel(keyValuePair.Value);
			}
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Schema.JsonSchemaNode> keyValuePair2 in node.PatternProperties)
			{
				if (jsonSchemaModel.PatternProperties == null)
				{
					jsonSchemaModel.PatternProperties = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchemaModel>();
				}
				jsonSchemaModel.PatternProperties[keyValuePair2.Key] = this.BuildNodeModel(keyValuePair2.Value);
			}
			foreach (global::Newtonsoft.Json.Schema.JsonSchemaNode node2 in node.Items)
			{
				if (jsonSchemaModel.Items == null)
				{
					jsonSchemaModel.Items = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchemaModel>();
				}
				jsonSchemaModel.Items.Add(this.BuildNodeModel(node2));
			}
			if (node.AdditionalProperties != null)
			{
				jsonSchemaModel.AdditionalProperties = this.BuildNodeModel(node.AdditionalProperties);
			}
			if (node.AdditionalItems != null)
			{
				jsonSchemaModel.AdditionalItems = this.BuildNodeModel(node.AdditionalItems);
			}
			return jsonSchemaModel;
		}

		// Token: 0x0400033B RID: 827
		private global::Newtonsoft.Json.Schema.JsonSchemaNodeCollection _nodes = new global::Newtonsoft.Json.Schema.JsonSchemaNodeCollection();

		// Token: 0x0400033C RID: 828
		private global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Schema.JsonSchemaNode, global::Newtonsoft.Json.Schema.JsonSchemaModel> _nodeModels = new global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Schema.JsonSchemaNode, global::Newtonsoft.Json.Schema.JsonSchemaModel>();

		// Token: 0x0400033D RID: 829
		private global::Newtonsoft.Json.Schema.JsonSchemaNode _node;
	}
}
