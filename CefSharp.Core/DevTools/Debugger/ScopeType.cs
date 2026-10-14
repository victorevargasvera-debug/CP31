using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200007A RID: 122
	public enum ScopeType
	{
		// Token: 0x040001AE RID: 430
		[global::System.Runtime.Serialization.EnumMember(Value = "global")]
		Global,
		// Token: 0x040001AF RID: 431
		[global::System.Runtime.Serialization.EnumMember(Value = "local")]
		Local,
		// Token: 0x040001B0 RID: 432
		[global::System.Runtime.Serialization.EnumMember(Value = "with")]
		With,
		// Token: 0x040001B1 RID: 433
		[global::System.Runtime.Serialization.EnumMember(Value = "closure")]
		Closure,
		// Token: 0x040001B2 RID: 434
		[global::System.Runtime.Serialization.EnumMember(Value = "catch")]
		Catch,
		// Token: 0x040001B3 RID: 435
		[global::System.Runtime.Serialization.EnumMember(Value = "block")]
		Block,
		// Token: 0x040001B4 RID: 436
		[global::System.Runtime.Serialization.EnumMember(Value = "script")]
		Script,
		// Token: 0x040001B5 RID: 437
		[global::System.Runtime.Serialization.EnumMember(Value = "eval")]
		Eval,
		// Token: 0x040001B6 RID: 438
		[global::System.Runtime.Serialization.EnumMember(Value = "module")]
		Module,
		// Token: 0x040001B7 RID: 439
		[global::System.Runtime.Serialization.EnumMember(Value = "wasm-expression-stack")]
		WasmExpressionStack
	}
}
