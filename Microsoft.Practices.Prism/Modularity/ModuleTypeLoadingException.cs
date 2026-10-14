using System;
using System.Globalization;
using System.Runtime.Serialization;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000045 RID: 69
	[global::System.Serializable]
	public class ModuleTypeLoadingException : global::Microsoft.Practices.Prism.Modularity.ModularityException
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x0000647F File Offset: 0x0000467F
		public ModuleTypeLoadingException()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00006487 File Offset: 0x00004687
		public ModuleTypeLoadingException(string message) : base(message)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00006490 File Offset: 0x00004690
		public ModuleTypeLoadingException(string message, global::System.Exception exception) : base(message, exception)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000649A File Offset: 0x0000469A
		public ModuleTypeLoadingException(string moduleName, string message) : this(moduleName, message, null)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000064A8 File Offset: 0x000046A8
		public ModuleTypeLoadingException(string moduleName, string message, global::System.Exception innerException) : base(moduleName, string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.FailedToRetrieveModule, new object[]
		{
			moduleName,
			message
		}), innerException)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000064DC File Offset: 0x000046DC
		protected ModuleTypeLoadingException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
