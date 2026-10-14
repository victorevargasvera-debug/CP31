using System;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x0200046F RID: 1135
	[global::System.Obsolete("This attribute has been replaced by System.Data.Entity.DbFunctionAttribute.")]
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	public sealed class EdmFunctionAttribute : global::System.Data.Entity.DbFunctionAttribute
	{
		// Token: 0x060037AF RID: 14255 RVA: 0x000B58BC File Offset: 0x000B3ABC
		public EdmFunctionAttribute(string namespaceName, string functionName) : base(namespaceName, functionName)
		{
		}
	}
}
