using System;

namespace System.Windows.Interactivity
{
	// Token: 0x0200001C RID: 28
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class TypeConstraintAttribute : global::System.Attribute
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000042DD File Offset: 0x000024DD
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000042E5 File Offset: 0x000024E5
		public global::System.Type Constraint { get; private set; }

		// Token: 0x060000D7 RID: 215 RVA: 0x000042EE File Offset: 0x000024EE
		public TypeConstraintAttribute(global::System.Type constraint)
		{
			this.Constraint = constraint;
		}
	}
}
