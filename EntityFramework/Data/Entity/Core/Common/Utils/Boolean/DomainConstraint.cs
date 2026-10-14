using System;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200060E RID: 1550
	internal class DomainConstraint<T_Variable, T_Element>
	{
		// Token: 0x06004B92 RID: 19346 RVA: 0x00109F80 File Offset: 0x00108180
		internal DomainConstraint(global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element> variable, global::System.Data.Entity.Core.Common.Utils.Set<T_Element> range)
		{
			this._variable = variable;
			this._range = range.AsReadOnly();
			this._hashCode = (this._variable.GetHashCode() ^ this._range.GetElementsHashCode());
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x00109FB8 File Offset: 0x001081B8
		internal DomainConstraint(global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element> variable, T_Element element) : this(variable, new global::System.Data.Entity.Core.Common.Utils.Set<T_Element>(new T_Element[]
		{
			element
		}).MakeReadOnly())
		{
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06004B94 RID: 19348 RVA: 0x00109FD9 File Offset: 0x001081D9
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element> Variable
		{
			get
			{
				return this._variable;
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06004B95 RID: 19349 RVA: 0x00109FE1 File Offset: 0x001081E1
		internal global::System.Data.Entity.Core.Common.Utils.Set<T_Element> Range
		{
			get
			{
				return this._range;
			}
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x00109FE9 File Offset: 0x001081E9
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element> InvertDomainConstraint()
		{
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>(this._variable, this._variable.Domain.Difference(this._range).AsReadOnly());
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x0010A014 File Offset: 0x00108214
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element> domainConstraint = obj as global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>;
			return domainConstraint != null && this._hashCode == domainConstraint._hashCode && this._range.SetEquals(domainConstraint._range) && this._variable.Equals(domainConstraint._variable);
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x0010A069 File Offset: 0x00108269
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x0010A071 File Offset: 0x00108271
		public override string ToString()
		{
			return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0} in [{1}]", new object[]
			{
				this._variable,
				this._range
			});
		}

		// Token: 0x04001A64 RID: 6756
		private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element> _variable;

		// Token: 0x04001A65 RID: 6757
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<T_Element> _range;

		// Token: 0x04001A66 RID: 6758
		private readonly int _hashCode;
	}
}
