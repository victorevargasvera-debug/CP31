using System;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000303 RID: 771
	internal sealed class PropertyRefElement : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x0600248A RID: 9354 RVA: 0x000668B4 File Offset: 0x00064AB4
		public PropertyRefElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x000668BE File Offset: 0x00064ABE
		public global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty Property
		{
			get
			{
				return this._property;
			}
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x000668C6 File Offset: 0x00064AC6
		internal override void ResolveTopLevelNames()
		{
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x000668C8 File Offset: 0x00064AC8
		internal bool ResolveNames(global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType entityType)
		{
			if (string.IsNullOrEmpty(this.Name))
			{
				return true;
			}
			this._property = entityType.FindProperty(this.Name);
			return this._property != null;
		}

		// Token: 0x04000CFB RID: 3323
		private global::System.Data.Entity.Core.SchemaObjectModel.StructuredProperty _property;
	}
}
