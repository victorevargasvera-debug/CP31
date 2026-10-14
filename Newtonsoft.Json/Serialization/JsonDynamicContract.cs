using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008C RID: 140
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JsonDynamicContract : global::Newtonsoft.Json.Serialization.JsonContainerContract
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x0001CC9E File Offset: 0x0001AE9E
		public global::Newtonsoft.Json.Serialization.JsonPropertyCollection Properties { get; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0001CCA6 File Offset: 0x0001AEA6
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x0001CCAE File Offset: 0x0001AEAE
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public global::System.Func<string, string> PropertyNameResolver { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x060006DE RID: 1758 RVA: 0x0001CCB7 File Offset: 0x0001AEB7
		private static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> CreateCallSiteGetter(string name)
		{
			return global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>.Create(new global::Newtonsoft.Json.Utilities.NoThrowGetBinderMember((global::System.Dynamic.GetMemberBinder)global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper.GetMember(name, typeof(global::Newtonsoft.Json.Utilities.DynamicUtils))));
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			2,
			1
		})]
		private static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object, object>> CreateCallSiteSetter(string name)
		{
			return global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object, object>>.Create(new global::Newtonsoft.Json.Utilities.NoThrowSetBinderMember((global::System.Dynamic.SetMemberBinder)global::Newtonsoft.Json.Utilities.DynamicUtils.BinderWrapper.SetMember(name, typeof(global::Newtonsoft.Json.Utilities.DynamicUtils))));
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001CCFC File Offset: 0x0001AEFC
		public JsonDynamicContract(global::System.Type underlyingType) : base(underlyingType)
		{
			this.ContractType = global::Newtonsoft.Json.Serialization.JsonContractType.Dynamic;
			this.Properties = new global::Newtonsoft.Json.Serialization.JsonPropertyCollection(base.UnderlyingType);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001CD58 File Offset: 0x0001AF58
		internal bool TryGetMember(global::System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, [global::System.Runtime.CompilerServices.Nullable(2)] out object value)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(dynamicProvider, "dynamicProvider");
			global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>> callSite = this._callSiteGetters.Get(name);
			object obj = callSite.Target(callSite, dynamicProvider);
			if (obj != global::Newtonsoft.Json.Utilities.NoThrowExpressionVisitor.ErrorResult)
			{
				value = obj;
				return true;
			}
			value = null;
			return false;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001CD9C File Offset: 0x0001AF9C
		internal bool TrySetMember(global::System.Dynamic.IDynamicMetaObjectProvider dynamicProvider, string name, [global::System.Runtime.CompilerServices.Nullable(2)] object value)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(dynamicProvider, "dynamicProvider");
			global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object, object>> callSite = this._callSiteSetters.Get(name);
			return callSite.Target(callSite, dynamicProvider, value) != global::Newtonsoft.Json.Utilities.NoThrowExpressionVisitor.ErrorResult;
		}

		// Token: 0x04000272 RID: 626
		private readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<string, global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>> _callSiteGetters = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<string, global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>>(new global::System.Func<string, global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object>>>(global::Newtonsoft.Json.Serialization.JsonDynamicContract.CreateCallSiteGetter));

		// Token: 0x04000273 RID: 627
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			1,
			2,
			1
		})]
		private readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<string, global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object, object>>> _callSiteSetters = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<string, global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object, object>>>(new global::System.Func<string, global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, object, object>>>(global::Newtonsoft.Json.Serialization.JsonDynamicContract.CreateCallSiteSetter));
	}
}
