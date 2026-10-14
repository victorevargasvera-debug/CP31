using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E4 RID: 228
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class DiscriminatedUnionConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C40 RID: 3136 RVA: 0x0003138C File Offset: 0x0002F58C
		private static global::System.Type CreateUnionTypeLookup(global::System.Type t)
		{
			global::Newtonsoft.Json.Utilities.MethodCall<object, object> getUnionCases = global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.GetUnionCases;
			object target = null;
			object[] array = new object[2];
			array[0] = t;
			object arg = ((object[])getUnionCases(target, array)).First<object>();
			return (global::System.Type)global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.GetUnionCaseInfoDeclaringType(arg);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x000313D4 File Offset: 0x0002F5D4
		private static global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union CreateUnion(global::System.Type t)
		{
			global::Newtonsoft.Json.Utilities.MethodCall<object, object> preComputeUnionTagReader = global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.PreComputeUnionTagReader;
			object target = null;
			object[] array = new object[2];
			array[0] = t;
			global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union union = new global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union((global::Newtonsoft.Json.Utilities.FSharpFunction)preComputeUnionTagReader(target, array), new global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase>());
			global::Newtonsoft.Json.Utilities.MethodCall<object, object> getUnionCases = global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.GetUnionCases;
			object target2 = null;
			object[] array2 = new object[2];
			array2[0] = t;
			foreach (object obj in (object[])getUnionCases(target2, array2))
			{
				int tag = (int)global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.GetUnionCaseInfoTag(obj);
				string name = (string)global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.GetUnionCaseInfoName(obj);
				global::System.Reflection.PropertyInfo[] fields = (global::System.Reflection.PropertyInfo[])global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.GetUnionCaseInfoFields(obj, new object[0]);
				global::Newtonsoft.Json.Utilities.MethodCall<object, object> preComputeUnionReader = global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.PreComputeUnionReader;
				object target3 = null;
				object[] array4 = new object[2];
				array4[0] = obj;
				global::Newtonsoft.Json.Utilities.FSharpFunction fieldReader = (global::Newtonsoft.Json.Utilities.FSharpFunction)preComputeUnionReader(target3, array4);
				global::Newtonsoft.Json.Utilities.MethodCall<object, object> preComputeUnionConstructor = global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.PreComputeUnionConstructor;
				object target4 = null;
				object[] array5 = new object[2];
				array5[0] = obj;
				global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase item = new global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase(tag, name, fields, fieldReader, (global::Newtonsoft.Json.Utilities.FSharpFunction)preComputeUnionConstructor(target4, array5));
				union.Cases.Add(item);
			}
			return union;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x000314DC File Offset: 0x0002F6DC
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			global::Newtonsoft.Json.Serialization.DefaultContractResolver defaultContractResolver = serializer.ContractResolver as global::Newtonsoft.Json.Serialization.DefaultContractResolver;
			global::System.Type key = global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionTypeLookupCache.Get(value.GetType());
			global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union union = global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCache.Get(key);
			int tag = (int)union.TagReader.Invoke(new object[]
			{
				value
			});
			global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase unionCase = union.Cases.Single((global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c) => c.Tag == tag);
			writer.WriteStartObject();
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Case") : "Case");
			writer.WriteValue(unionCase.Name);
			if (unionCase.Fields != null && unionCase.Fields.Length != 0)
			{
				object[] array = (object[])unionCase.FieldReader.Invoke(new object[]
				{
					value
				});
				writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Fields") : "Fields");
				writer.WriteStartArray();
				foreach (object value2 in array)
				{
					serializer.Serialize(writer, value2);
				}
				writer.WriteEndArray();
			}
			writer.WriteEndObject();
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0003160C File Offset: 0x0002F80C
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Null)
			{
				return null;
			}
			global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase unionCase = null;
			string caseName = null;
			global::Newtonsoft.Json.Linq.JArray jarray = null;
			reader.ReadAndAssert();
			global::System.Func<global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase, bool> <>9__0;
			while (reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
			{
				string text = reader.Value.ToString();
				if (string.Equals(text, "Case", global::System.StringComparison.OrdinalIgnoreCase))
				{
					reader.ReadAndAssert();
					global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union union = global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCache.Get(objectType);
					caseName = reader.Value.ToString();
					global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases = union.Cases;
					global::System.Func<global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase, bool> predicate;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase c) => c.Name == caseName));
					}
					unionCase = cases.SingleOrDefault(predicate);
					if (unionCase == null)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "No union type found with the name '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, caseName));
					}
				}
				else
				{
					if (!string.Equals(text, "Fields", global::System.StringComparison.OrdinalIgnoreCase))
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected property '{0}' found when reading union.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text));
					}
					reader.ReadAndAssert();
					if (reader.TokenType != global::Newtonsoft.Json.JsonToken.StartArray)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Union fields must been an array.");
					}
					jarray = (global::Newtonsoft.Json.Linq.JArray)global::Newtonsoft.Json.Linq.JToken.ReadFrom(reader);
				}
				reader.ReadAndAssert();
			}
			if (unionCase == null)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "No '{0}' property with union name found.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, "Case"));
			}
			object[] array = new object[unionCase.Fields.Length];
			if (unionCase.Fields.Length != 0 && jarray == null)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "No '{0}' property with union fields found.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, "Fields"));
			}
			if (jarray != null)
			{
				if (unionCase.Fields.Length != jarray.Count)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "The number of field values does not match the number of properties defined by union '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, caseName));
				}
				for (int i = 0; i < jarray.Count; i++)
				{
					global::Newtonsoft.Json.Linq.JToken jtoken = jarray[i];
					global::System.Reflection.PropertyInfo propertyInfo = unionCase.Fields[i];
					array[i] = jtoken.ToObject(propertyInfo.PropertyType, serializer);
				}
			}
			object[] args = new object[]
			{
				array
			};
			return unionCase.Constructor.Invoke(args);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00031808 File Offset: 0x0002FA08
		public override bool CanConvert(global::System.Type objectType)
		{
			if (typeof(global::System.Collections.IEnumerable).IsAssignableFrom(objectType))
			{
				return false;
			}
			object[] customAttributes = objectType.GetCustomAttributes(true);
			bool flag = false;
			object[] array = customAttributes;
			for (int i = 0; i < array.Length; i++)
			{
				global::System.Type type = array[i].GetType();
				if (type.FullName == "Microsoft.FSharp.Core.CompilationMappingAttribute")
				{
					global::Newtonsoft.Json.Utilities.FSharpUtils.EnsureInitialized(type.Assembly());
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
			global::Newtonsoft.Json.Utilities.MethodCall<object, object> isUnion = global::Newtonsoft.Json.Utilities.FSharpUtils.Instance.IsUnion;
			object target = null;
			object[] array2 = new object[2];
			array2[0] = objectType;
			return (bool)isUnion(target, array2);
		}

		// Token: 0x040003D3 RID: 979
		private const string CasePropertyName = "Case";

		// Token: 0x040003D4 RID: 980
		private const string FieldsPropertyName = "Fields";

		// Token: 0x040003D5 RID: 981
		private static readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union> UnionCache = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union>(new global::System.Func<global::System.Type, global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.Union>(global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.CreateUnion));

		// Token: 0x040003D6 RID: 982
		private static readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::System.Type> UnionTypeLookupCache = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::System.Type>(new global::System.Func<global::System.Type, global::System.Type>(global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.CreateUnionTypeLookup));

		// Token: 0x020001DE RID: 478
		[global::System.Runtime.CompilerServices.Nullable(0)]
		internal class Union
		{
			// Token: 0x0600103D RID: 4157 RVA: 0x0004792F File Offset: 0x00045B2F
			public Union(global::Newtonsoft.Json.Utilities.FSharpFunction tagReader, global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> cases)
			{
				this.TagReader = tagReader;
				this.Cases = cases;
			}

			// Token: 0x04000852 RID: 2130
			public readonly global::Newtonsoft.Json.Utilities.FSharpFunction TagReader;

			// Token: 0x04000853 RID: 2131
			public readonly global::System.Collections.Generic.List<global::Newtonsoft.Json.Converters.DiscriminatedUnionConverter.UnionCase> Cases;
		}

		// Token: 0x020001DF RID: 479
		[global::System.Runtime.CompilerServices.Nullable(0)]
		internal class UnionCase
		{
			// Token: 0x0600103E RID: 4158 RVA: 0x00047945 File Offset: 0x00045B45
			public UnionCase(int tag, string name, global::System.Reflection.PropertyInfo[] fields, global::Newtonsoft.Json.Utilities.FSharpFunction fieldReader, global::Newtonsoft.Json.Utilities.FSharpFunction constructor)
			{
				this.Tag = tag;
				this.Name = name;
				this.Fields = fields;
				this.FieldReader = fieldReader;
				this.Constructor = constructor;
			}

			// Token: 0x04000854 RID: 2132
			public readonly int Tag;

			// Token: 0x04000855 RID: 2133
			public readonly string Name;

			// Token: 0x04000856 RID: 2134
			public readonly global::System.Reflection.PropertyInfo[] Fields;

			// Token: 0x04000857 RID: 2135
			public readonly global::Newtonsoft.Json.Utilities.FSharpFunction FieldReader;

			// Token: 0x04000858 RID: 2136
			public readonly global::Newtonsoft.Json.Utilities.FSharpFunction Constructor;
		}
	}
}
