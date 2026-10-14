using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x0200057A RID: 1402
	internal class ConditionComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>
	{
		// Token: 0x06004407 RID: 17415 RVA: 0x000ECAB4 File Offset: 0x000EACB4
		public bool Equals(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> one, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> two)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(one.Keys, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> equals = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(two.Keys, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			if (!set.SetEquals(equals))
			{
				return false;
			}
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath key in set)
			{
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> set2 = one[key];
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> equals2 = two[key];
				if (!set2.SetEquals(equals2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x000ECB4C File Offset: 0x000EAD4C
		public int GetHashCode(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> obj)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath value in obj.Keys)
			{
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString().GetHashCode();
		}
	}
}
