using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x0200046A RID: 1130
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public abstract class ComplexObject : global::System.Data.Entity.Core.Objects.DataClasses.StructuralObject
	{
		// Token: 0x060037A3 RID: 14243 RVA: 0x000B57D4 File Offset: 0x000B39D4
		internal void AttachToParent(global::System.Data.Entity.Core.Objects.DataClasses.StructuralObject parent, string parentPropertyName)
		{
			if (this._parent != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ComplexObject_ComplexObjectAlreadyAttachedToParent);
			}
			this._parent = parent;
			this._parentPropertyName = parentPropertyName;
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x000B57F7 File Offset: 0x000B39F7
		internal void DetachFromParent()
		{
			this._parent = null;
			this._parentPropertyName = null;
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x000B5807 File Offset: 0x000B3A07
		protected sealed override void ReportPropertyChanging(string property)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(property, "property");
			base.ReportPropertyChanging(property);
			this.ReportComplexPropertyChanging(null, this, property);
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x000B5825 File Offset: 0x000B3A25
		protected sealed override void ReportPropertyChanged(string property)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(property, "property");
			this.ReportComplexPropertyChanged(null, this, property);
			base.ReportPropertyChanged(property);
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060037A7 RID: 14247 RVA: 0x000B5843 File Offset: 0x000B3A43
		internal sealed override bool IsChangeTracked
		{
			get
			{
				return this._parent != null && this._parent.IsChangeTracked;
			}
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x000B585A File Offset: 0x000B3A5A
		internal sealed override void ReportComplexPropertyChanging(string entityMemberName, global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject complexObject, string complexMemberName)
		{
			if (this._parent != null)
			{
				this._parent.ReportComplexPropertyChanging(this._parentPropertyName, complexObject, complexMemberName);
			}
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x000B5877 File Offset: 0x000B3A77
		internal sealed override void ReportComplexPropertyChanged(string entityMemberName, global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject complexObject, string complexMemberName)
		{
			if (this._parent != null)
			{
				this._parent.ReportComplexPropertyChanged(this._parentPropertyName, complexObject, complexMemberName);
			}
		}

		// Token: 0x040012D1 RID: 4817
		private global::System.Data.Entity.Core.Objects.DataClasses.StructuralObject _parent;

		// Token: 0x040012D2 RID: 4818
		private string _parentPropertyName;
	}
}
