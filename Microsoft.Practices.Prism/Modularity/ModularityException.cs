using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x0200002B RID: 43
	[global::System.Serializable]
	public class ModularityException : global::System.Exception
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0000468A File Offset: 0x0000288A
		public ModularityException() : this(null)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004693 File Offset: 0x00002893
		public ModularityException(string message) : this(null, message)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000469D File Offset: 0x0000289D
		public ModularityException(string message, global::System.Exception innerException) : this(null, message, innerException)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000046A8 File Offset: 0x000028A8
		public ModularityException(string moduleName, string message) : this(moduleName, message, null)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000046B3 File Offset: 0x000028B3
		public ModularityException(string moduleName, string message, global::System.Exception innerException) : base(message, innerException)
		{
			this.ModuleName = moduleName;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000046C4 File Offset: 0x000028C4
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000046CC File Offset: 0x000028CC
		public string ModuleName { get; set; }

		// Token: 0x060000E4 RID: 228 RVA: 0x000046D5 File Offset: 0x000028D5
		protected ModularityException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.ModuleName = (info.GetValue("ModuleName", typeof(string)) as string);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000046FF File Offset: 0x000028FF
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Demand, Flags = global::System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ModuleName", this.ModuleName);
		}
	}
}
