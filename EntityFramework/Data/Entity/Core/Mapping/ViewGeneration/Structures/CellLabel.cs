using System;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x0200059C RID: 1436
	internal class CellLabel
	{
		// Token: 0x06004593 RID: 17811 RVA: 0x000F48A1 File Offset: 0x000F2AA1
		internal CellLabel(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellLabel source)
		{
			this.m_startLineNumber = source.m_startLineNumber;
			this.m_startLinePosition = source.m_startLinePosition;
			this.m_sourceLocation = source.m_sourceLocation;
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x000F48CD File Offset: 0x000F2ACD
		internal CellLabel(global::System.Data.Entity.Core.Mapping.MappingFragment fragmentInfo) : this(fragmentInfo.StartLineNumber, fragmentInfo.StartLinePosition, fragmentInfo.SourceLocation)
		{
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x000F48E7 File Offset: 0x000F2AE7
		internal CellLabel(int startLineNumber, int startLinePosition, string sourceLocation)
		{
			this.m_startLineNumber = startLineNumber;
			this.m_startLinePosition = startLinePosition;
			this.m_sourceLocation = sourceLocation;
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x000F4904 File Offset: 0x000F2B04
		internal int StartLineNumber
		{
			get
			{
				return this.m_startLineNumber;
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x000F490C File Offset: 0x000F2B0C
		internal int StartLinePosition
		{
			get
			{
				return this.m_startLinePosition;
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x000F4914 File Offset: 0x000F2B14
		internal string SourceLocation
		{
			get
			{
				return this.m_sourceLocation;
			}
		}

		// Token: 0x040018F2 RID: 6386
		private readonly int m_startLineNumber;

		// Token: 0x040018F3 RID: 6387
		private readonly int m_startLinePosition;

		// Token: 0x040018F4 RID: 6388
		private readonly string m_sourceLocation;
	}
}
