using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity
{
	// Token: 0x0200005D RID: 93
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	public class DbFunctionAttribute : global::System.Attribute
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x0000968E File Offset: 0x0000788E
		public DbFunctionAttribute(string namespaceName, string functionName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(namespaceName, "namespaceName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(functionName, "functionName");
			this._namespaceName = namespaceName;
			this._functionName = functionName;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000096BC File Offset: 0x000078BC
		public string NamespaceName
		{
			get
			{
				return this._namespaceName;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000096C4 File Offset: 0x000078C4
		public string FunctionName
		{
			get
			{
				return this._functionName;
			}
		}

		// Token: 0x040000B6 RID: 182
		private readonly string _namespaceName;

		// Token: 0x040000B7 RID: 183
		private readonly string _functionName;
	}
}
