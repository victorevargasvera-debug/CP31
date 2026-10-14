using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000053 RID: 83
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class NoThrowGetBinderMember : global::System.Dynamic.GetMemberBinder
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x00015180 File Offset: 0x00013380
		public NoThrowGetBinderMember(global::System.Dynamic.GetMemberBinder innerBinder) : base(innerBinder.Name, innerBinder.IgnoreCase)
		{
			this._innerBinder = innerBinder;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001519C File Offset: 0x0001339C
		public override global::System.Dynamic.DynamicMetaObject FallbackGetMember(global::System.Dynamic.DynamicMetaObject target, global::System.Dynamic.DynamicMetaObject errorSuggestion)
		{
			global::System.Dynamic.DynamicMetaObject dynamicMetaObject = this._innerBinder.Bind(target, global::Newtonsoft.Json.Utilities.CollectionUtils.ArrayEmpty<global::System.Dynamic.DynamicMetaObject>());
			return new global::System.Dynamic.DynamicMetaObject(new global::Newtonsoft.Json.Utilities.NoThrowExpressionVisitor().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
		}

		// Token: 0x040001BF RID: 447
		private readonly global::System.Dynamic.GetMemberBinder _innerBinder;
	}
}
