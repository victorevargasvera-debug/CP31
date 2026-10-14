using System;
using System.Data.Entity.Core.Common.Utils;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x02000594 RID: 1428
	internal class CqlIdentifiers : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004518 RID: 17688 RVA: 0x000F354A File Offset: 0x000F174A
		internal CqlIdentifiers()
		{
			this.m_identifiers = new global::System.Data.Entity.Core.Common.Utils.Set<string>(global::System.StringComparer.Ordinal);
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x000F3562 File Offset: 0x000F1762
		internal string GetFromVariable(int num)
		{
			return this.GetNonConflictingName("_from", num);
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x000F3570 File Offset: 0x000F1770
		internal string GetBlockAlias(int num)
		{
			return this.GetNonConflictingName("T", num);
		}

		// Token: 0x0600451B RID: 17691 RVA: 0x000F357E File Offset: 0x000F177E
		internal string GetBlockAlias()
		{
			return this.GetNonConflictingName("T", -1);
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x000F358C File Offset: 0x000F178C
		internal void AddIdentifier(string identifier)
		{
			this.m_identifiers.Add(identifier.ToLower(global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x000F35A4 File Offset: 0x000F17A4
		private string GetNonConflictingName(string prefix, int number)
		{
			string text = (number < 0) ? prefix : global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}{1}", new object[]
			{
				prefix,
				number
			});
			if (!this.m_identifiers.Contains(text.ToLower(global::System.Globalization.CultureInfo.InvariantCulture)))
			{
				return text;
			}
			for (int i = 0; i < 2147483647; i++)
			{
				if (number < 0)
				{
					text = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}_{1}", new object[]
					{
						prefix,
						i
					});
				}
				else
				{
					text = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0}_{1}_{2}", new object[]
					{
						prefix,
						i,
						number
					});
				}
				if (!this.m_identifiers.Contains(text.ToLower(global::System.Globalization.CultureInfo.InvariantCulture)))
				{
					return text;
				}
			}
			return null;
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x000F3666 File Offset: 0x000F1866
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			this.m_identifiers.ToCompactString(builder);
		}

		// Token: 0x040018DA RID: 6362
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<string> m_identifiers;
	}
}
