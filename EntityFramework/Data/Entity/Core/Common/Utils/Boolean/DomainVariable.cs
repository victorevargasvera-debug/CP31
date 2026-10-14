using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000610 RID: 1552
	internal class DomainVariable<T_Variable, T_Element>
	{
		// Token: 0x06004B9E RID: 19358 RVA: 0x0010A1F4 File Offset: 0x001083F4
		internal DomainVariable(T_Variable identifier, global::System.Data.Entity.Core.Common.Utils.Set<T_Element> domain, global::System.Collections.Generic.IEqualityComparer<T_Variable> identifierComparer)
		{
			this._identifier = identifier;
			this._domain = domain.AsReadOnly();
			this._identifierComparer = (identifierComparer ?? global::System.Collections.Generic.EqualityComparer<T_Variable>.Default);
			int elementsHashCode = this._domain.GetElementsHashCode();
			int hashCode = this._identifierComparer.GetHashCode(this._identifier);
			this._hashCode = (elementsHashCode ^ hashCode);
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x0010A251 File Offset: 0x00108451
		internal DomainVariable(T_Variable identifier, global::System.Data.Entity.Core.Common.Utils.Set<T_Element> domain) : this(identifier, domain, null)
		{
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06004BA0 RID: 19360 RVA: 0x0010A25C File Offset: 0x0010845C
		internal T_Variable Identifier
		{
			get
			{
				return this._identifier;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x0010A264 File Offset: 0x00108464
		internal global::System.Data.Entity.Core.Common.Utils.Set<T_Element> Domain
		{
			get
			{
				return this._domain;
			}
		}

		// Token: 0x06004BA2 RID: 19362 RVA: 0x0010A26C File Offset: 0x0010846C
		public override int GetHashCode()
		{
			return this._hashCode;
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x0010A274 File Offset: 0x00108474
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element> domainVariable = obj as global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<T_Variable, T_Element>;
			return domainVariable != null && this._hashCode == domainVariable._hashCode && this._identifierComparer.Equals(this._identifier, domainVariable._identifier) && this._domain.SetEquals(domainVariable._domain);
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x0010A2D0 File Offset: 0x001084D0
		public override string ToString()
		{
			string format = "{0}{{{1}}}";
			object[] array = new object[2];
			int num = 0;
			T_Variable identifier = this._identifier;
			array[num] = identifier.ToString();
			array[1] = this._domain;
			return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant(format, array);
		}

		// Token: 0x04001A69 RID: 6761
		private readonly T_Variable _identifier;

		// Token: 0x04001A6A RID: 6762
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<T_Element> _domain;

		// Token: 0x04001A6B RID: 6763
		private readonly int _hashCode;

		// Token: 0x04001A6C RID: 6764
		private readonly global::System.Collections.Generic.IEqualityComparer<T_Variable> _identifierComparer;
	}
}
