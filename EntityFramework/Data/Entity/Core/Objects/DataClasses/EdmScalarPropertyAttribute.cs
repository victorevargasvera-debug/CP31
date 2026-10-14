using System;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000473 RID: 1139
	[global::System.AttributeUsage(global::System.AttributeTargets.Property)]
	public sealed class EdmScalarPropertyAttribute : global::System.Data.Entity.Core.Objects.DataClasses.EdmPropertyAttribute
	{
		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x000B59F4 File Offset: 0x000B3BF4
		// (set) Token: 0x060037C1 RID: 14273 RVA: 0x000B59FC File Offset: 0x000B3BFC
		public bool IsNullable
		{
			get
			{
				return this._isNullable;
			}
			set
			{
				this._isNullable = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x000B5A05 File Offset: 0x000B3C05
		// (set) Token: 0x060037C3 RID: 14275 RVA: 0x000B5A0D File Offset: 0x000B3C0D
		public bool EntityKeyProperty { get; set; }

		// Token: 0x040012DF RID: 4831
		private bool _isNullable = true;
	}
}
