using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000091 RID: 145
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JsonPrimitiveContract : global::Newtonsoft.Json.Serialization.JsonContract
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x0001D1AC File Offset: 0x0001B3AC
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x0001D1B4 File Offset: 0x0001B3B4
		internal global::Newtonsoft.Json.Utilities.PrimitiveTypeCode TypeCode { get; set; }

		// Token: 0x06000715 RID: 1813 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
		public JsonPrimitiveContract(global::System.Type underlyingType) : base(underlyingType)
		{
			this.ContractType = global::Newtonsoft.Json.Serialization.JsonContractType.Primitive;
			this.TypeCode = global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(underlyingType);
			this.IsReadOnlyOrFixedSize = true;
			global::Newtonsoft.Json.ReadType internalReadType;
			if (global::Newtonsoft.Json.Serialization.JsonPrimitiveContract.ReadTypeMap.TryGetValue(this.NonNullableUnderlyingType, out internalReadType))
			{
				this.InternalReadType = internalReadType;
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0001D20C File Offset: 0x0001B40C
		// Note: this type is marked as 'beforefieldinit'.
		static JsonPrimitiveContract()
		{
			global::System.Collections.Generic.Dictionary<global::System.Type, global::Newtonsoft.Json.ReadType> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Newtonsoft.Json.ReadType>();
			global::System.Type typeFromHandle = typeof(byte[]);
			dictionary[typeFromHandle] = global::Newtonsoft.Json.ReadType.ReadAsBytes;
			global::System.Type typeFromHandle2 = typeof(byte);
			dictionary[typeFromHandle2] = global::Newtonsoft.Json.ReadType.ReadAsInt32;
			global::System.Type typeFromHandle3 = typeof(short);
			dictionary[typeFromHandle3] = global::Newtonsoft.Json.ReadType.ReadAsInt32;
			global::System.Type typeFromHandle4 = typeof(int);
			dictionary[typeFromHandle4] = global::Newtonsoft.Json.ReadType.ReadAsInt32;
			global::System.Type typeFromHandle5 = typeof(decimal);
			dictionary[typeFromHandle5] = global::Newtonsoft.Json.ReadType.ReadAsDecimal;
			global::System.Type typeFromHandle6 = typeof(bool);
			dictionary[typeFromHandle6] = global::Newtonsoft.Json.ReadType.ReadAsBoolean;
			global::System.Type typeFromHandle7 = typeof(string);
			dictionary[typeFromHandle7] = global::Newtonsoft.Json.ReadType.ReadAsString;
			global::System.Type typeFromHandle8 = typeof(global::System.DateTime);
			dictionary[typeFromHandle8] = global::Newtonsoft.Json.ReadType.ReadAsDateTime;
			global::System.Type typeFromHandle9 = typeof(global::System.DateTimeOffset);
			dictionary[typeFromHandle9] = global::Newtonsoft.Json.ReadType.ReadAsDateTimeOffset;
			global::System.Type typeFromHandle10 = typeof(float);
			dictionary[typeFromHandle10] = global::Newtonsoft.Json.ReadType.ReadAsDouble;
			global::System.Type typeFromHandle11 = typeof(double);
			dictionary[typeFromHandle11] = global::Newtonsoft.Json.ReadType.ReadAsDouble;
			global::System.Type typeFromHandle12 = typeof(long);
			dictionary[typeFromHandle12] = global::Newtonsoft.Json.ReadType.ReadAsInt64;
			global::Newtonsoft.Json.Serialization.JsonPrimitiveContract.ReadTypeMap = dictionary;
		}

		// Token: 0x04000287 RID: 647
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::Newtonsoft.Json.ReadType> ReadTypeMap;
	}
}
