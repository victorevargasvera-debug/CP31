using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000196 RID: 406
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	internal sealed class ContractAnnotationAttribute : global::System.Attribute
	{
		// Token: 0x06001157 RID: 4439 RVA: 0x0002DEF0 File Offset: 0x0002C0F0
		public ContractAnnotationAttribute([global::JetBrains.Annotations.NotNull] string contract) : this(contract, false)
		{
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0002DEFA File Offset: 0x0002C0FA
		public ContractAnnotationAttribute([global::JetBrains.Annotations.NotNull] string contract, bool forceFullStates)
		{
			this.Contract = contract;
			this.ForceFullStates = forceFullStates;
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0002DF10 File Offset: 0x0002C110
		// (set) Token: 0x0600115A RID: 4442 RVA: 0x0002DF18 File Offset: 0x0002C118
		public string Contract { get; private set; }

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x0002DF21 File Offset: 0x0002C121
		// (set) Token: 0x0600115C RID: 4444 RVA: 0x0002DF29 File Offset: 0x0002C129
		public bool ForceFullStates { get; private set; }
	}
}
