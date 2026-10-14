using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000076 RID: 118
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class DefaultReferenceResolver : global::Newtonsoft.Json.Serialization.IReferenceResolver
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x0001B5BC File Offset: 0x000197BC
		private global::Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> GetMappings(object context)
		{
			global::Newtonsoft.Json.Serialization.JsonSerializerInternalBase jsonSerializerInternalBase = context as global::Newtonsoft.Json.Serialization.JsonSerializerInternalBase;
			if (jsonSerializerInternalBase == null)
			{
				global::Newtonsoft.Json.Serialization.JsonSerializerProxy jsonSerializerProxy = context as global::Newtonsoft.Json.Serialization.JsonSerializerProxy;
				if (jsonSerializerProxy == null)
				{
					throw new global::Newtonsoft.Json.JsonException("The DefaultReferenceResolver can only be used internally.");
				}
				jsonSerializerInternalBase = jsonSerializerProxy.GetInternalSerializer();
			}
			return jsonSerializerInternalBase.DefaultReferenceMappings;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0001B5F8 File Offset: 0x000197F8
		public object ResolveReference(object context, string reference)
		{
			object result;
			this.GetMappings(context).TryGetByFirst(reference, out result);
			return result;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0001B618 File Offset: 0x00019818
		public string GetReference(object context, object value)
		{
			global::Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> mappings = this.GetMappings(context);
			string text;
			if (!mappings.TryGetBySecond(value, out text))
			{
				this._referenceCount++;
				text = this._referenceCount.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				mappings.Set(text, value);
			}
			return text;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0001B660 File Offset: 0x00019860
		public void AddReference(object context, string reference, object value)
		{
			this.GetMappings(context).Set(reference, value);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0001B670 File Offset: 0x00019870
		public bool IsReferenced(object context, object value)
		{
			string text;
			return this.GetMappings(context).TryGetBySecond(value, out text);
		}

		// Token: 0x0400021F RID: 543
		private int _referenceCount;
	}
}
