using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200054F RID: 1359
	public sealed class ModificationFunctionMemberPath : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x060042DA RID: 17114 RVA: 0x000E520C File Offset: 0x000E340C
		public ModificationFunctionMemberPath(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> members, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>>(members, "members");
			this._members = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(members));
			if (associationSet != null)
			{
				this._associationSetEnd = associationSet.AssociationSetEnds[this.Members[1].Name];
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060042DB RID: 17115 RVA: 0x000E5261 File Offset: 0x000E3461
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> Members
		{
			get
			{
				return this._members;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x000E5269 File Offset: 0x000E3469
		public global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd AssociationSetEnd
		{
			get
			{
				return this._associationSetEnd;
			}
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x000E5274 File Offset: 0x000E3474
		public override string ToString()
		{
			global::System.IFormatProvider invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
			string format = "{0}{1}";
			object[] array = new object[2];
			int num = 0;
			object obj;
			if (this.AssociationSetEnd != null)
			{
				string str = "[";
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet parentAssociationSet = this.AssociationSetEnd.ParentAssociationSet;
				obj = str + ((parentAssociationSet != null) ? parentAssociationSet.ToString() : null) + "]";
			}
			else
			{
				obj = string.Empty;
			}
			array[num] = obj;
			array[1] = global::System.Data.Entity.Core.Common.Utils.StringUtil.BuildDelimitedList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(this.Members, null, ".");
			return string.Format(invariantCulture, format, array);
		}

		// Token: 0x04001787 RID: 6023
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> _members;

		// Token: 0x04001788 RID: 6024
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd _associationSetEnd;
	}
}
