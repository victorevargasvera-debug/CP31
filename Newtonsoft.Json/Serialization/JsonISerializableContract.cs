using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008E RID: 142
	public class JsonISerializableContract : global::Newtonsoft.Json.Serialization.JsonContainerContract
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0001CF49 File Offset: 0x0001B149
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0001CF51 File Offset: 0x0001B151
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		public global::Newtonsoft.Json.Serialization.ObjectConstructor<object> ISerializableCreator { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x060006F8 RID: 1784 RVA: 0x0001CF5A File Offset: 0x0001B15A
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public JsonISerializableContract(global::System.Type underlyingType) : base(underlyingType)
		{
			this.ContractType = global::Newtonsoft.Json.Serialization.JsonContractType.Serializable;
		}
	}
}
