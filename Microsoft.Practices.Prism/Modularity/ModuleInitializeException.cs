using System;
using System.Globalization;
using System.Runtime.Serialization;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000095 RID: 149
	[global::System.Serializable]
	public class ModuleInitializeException : global::Microsoft.Practices.Prism.Modularity.ModularityException
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x0000B5C4 File Offset: 0x000097C4
		public ModuleInitializeException()
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000B5CC File Offset: 0x000097CC
		public ModuleInitializeException(string message) : base(message)
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000B5D5 File Offset: 0x000097D5
		public ModuleInitializeException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000B5DF File Offset: 0x000097DF
		public ModuleInitializeException(string moduleName, string moduleAssembly, string message) : this(moduleName, message, moduleAssembly, null)
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000B5EC File Offset: 0x000097EC
		public ModuleInitializeException(string moduleName, string moduleAssembly, string message, global::System.Exception innerException) : base(moduleName, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.FailedToLoadModule, new object[]
		{
			moduleName,
			moduleAssembly,
			message
		}), innerException)
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000B628 File Offset: 0x00009828
		public ModuleInitializeException(string moduleName, string message, global::System.Exception innerException) : base(moduleName, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.FailedToLoadModuleNoAssemblyInfo, new object[]
		{
			moduleName,
			message
		}), innerException)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000B65C File Offset: 0x0000985C
		protected ModuleInitializeException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
