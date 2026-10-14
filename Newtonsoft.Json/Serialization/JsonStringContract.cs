using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000098 RID: 152
	public class JsonStringContract : global::Newtonsoft.Json.Serialization.JsonPrimitiveContract
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x00023341 File Offset: 0x00021541
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public JsonStringContract(global::System.Type underlyingType) : base(underlyingType)
		{
			this.ContractType = global::Newtonsoft.Json.Serialization.JsonContractType.String;
		}
	}
}
