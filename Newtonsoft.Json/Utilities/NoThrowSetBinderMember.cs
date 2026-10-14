using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000054 RID: 84
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class NoThrowSetBinderMember : global::System.Dynamic.SetMemberBinder
	{
		// Token: 0x06000504 RID: 1284 RVA: 0x000151D6 File Offset: 0x000133D6
		public NoThrowSetBinderMember(global::System.Dynamic.SetMemberBinder innerBinder) : base(innerBinder.Name, innerBinder.IgnoreCase)
		{
			this._innerBinder = innerBinder;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000151F4 File Offset: 0x000133F4
		public override global::System.Dynamic.DynamicMetaObject FallbackSetMember(global::System.Dynamic.DynamicMetaObject target, global::System.Dynamic.DynamicMetaObject value, global::System.Dynamic.DynamicMetaObject errorSuggestion)
		{
			global::System.Dynamic.DynamicMetaObject dynamicMetaObject = this._innerBinder.Bind(target, new global::System.Dynamic.DynamicMetaObject[]
			{
				value
			});
			return new global::System.Dynamic.DynamicMetaObject(new global::Newtonsoft.Json.Utilities.NoThrowExpressionVisitor().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
		}

		// Token: 0x040001C0 RID: 448
		private readonly global::System.Dynamic.SetMemberBinder _innerBinder;
	}
}
