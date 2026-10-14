using System;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000665 RID: 1637
	internal sealed class ParserOptions
	{
		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x00118215 File Offset: 0x00116415
		internal global::System.StringComparer NameComparer
		{
			get
			{
				if (!this.NameComparisonCaseInsensitive)
				{
					return global::System.StringComparer.Ordinal;
				}
				return global::System.StringComparer.OrdinalIgnoreCase;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06004E3D RID: 20029 RVA: 0x0011822A File Offset: 0x0011642A
		internal bool NameComparisonCaseInsensitive
		{
			get
			{
				return this.ParserCompilationMode != global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode.RestrictedViewGenerationMode;
			}
		}

		// Token: 0x04001C62 RID: 7266
		internal global::System.Data.Entity.Core.Common.EntitySql.ParserOptions.CompilationMode ParserCompilationMode;

		// Token: 0x02000C75 RID: 3189
		internal enum CompilationMode
		{
			// Token: 0x04003138 RID: 12600
			NormalMode,
			// Token: 0x04003139 RID: 12601
			RestrictedViewGenerationMode,
			// Token: 0x0400313A RID: 12602
			UserViewGenerationMode
		}
	}
}
