using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Validation;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x0200059A RID: 1434
	internal class Cell : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004576 RID: 17782 RVA: 0x000F4449 File Offset: 0x000F2649
		private Cell(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery sQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellLabel label, int cellNumber)
		{
			this.m_cQuery = cQuery;
			this.m_sQuery = sQuery;
			this.m_label = label;
			this.m_cellNumber = cellNumber;
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x000F4470 File Offset: 0x000F2670
		internal Cell(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell source)
		{
			this.m_cQuery = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery(source.m_cQuery);
			this.m_sQuery = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery(source.m_sQuery);
			this.m_label = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellLabel(source.m_label);
			this.m_cellNumber = source.m_cellNumber;
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x000F44C2 File Offset: 0x000F26C2
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery CQuery
		{
			get
			{
				return this.m_cQuery;
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x000F44CA File Offset: 0x000F26CA
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery SQuery
		{
			get
			{
				return this.m_sQuery;
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x000F44D2 File Offset: 0x000F26D2
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellLabel CellLabel
		{
			get
			{
				return this.m_label;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x000F44DA File Offset: 0x000F26DA
		internal int CellNumber
		{
			get
			{
				return this.m_cellNumber;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x000F44E2 File Offset: 0x000F26E2
		internal string CellNumberAsString
		{
			get
			{
				return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("V{0}", new object[]
				{
					this.CellNumber
				});
			}
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x000F4502 File Offset: 0x000F2702
		internal void GetIdentifiers(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers)
		{
			this.m_cQuery.GetIdentifiers(identifiers);
			this.m_sQuery.GetIdentifiers(identifiers);
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x000F451C File Offset: 0x000F271C
		internal global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetCSlotsForTableColumns(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> columns)
		{
			global::System.Collections.Generic.List<int> projectedPositions = this.SQuery.GetProjectedPositions(columns);
			if (projectedPositions == null)
			{
				return null;
			}
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			foreach (int slotNum in projectedPositions)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot memberProjectedSlot = this.CQuery.ProjectedSlotAt(slotNum) as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot;
				if (memberProjectedSlot == null)
				{
					return null;
				}
				set.Add((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)memberProjectedSlot.MemberPath.LeafEdmMember);
			}
			return set;
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x000F45B4 File Offset: 0x000F27B4
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery GetLeftQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget side)
		{
			if (side != global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
			{
				return this.m_sQuery;
			}
			return this.m_cQuery;
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x000F45C6 File Offset: 0x000F27C6
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery GetRightQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget side)
		{
			if (side != global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
			{
				return this.m_cQuery;
			}
			return this.m_sQuery;
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x000F45D8 File Offset: 0x000F27D8
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellRelation CreateViewCellRelation(int cellNumber)
		{
			if (this.m_viewCellRelation != null)
			{
				return this.m_viewCellRelation;
			}
			this.GenerateCellRelations(cellNumber);
			return this.m_viewCellRelation;
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x000F45F8 File Offset: 0x000F27F8
		private void GenerateCellRelations(int cellNumber)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot>();
			for (int i = 0; i < this.CQuery.NumProjectedSlots; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot = this.CQuery.ProjectedSlotAt(i);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot projectedSlot2 = this.SQuery.ProjectedSlotAt(i);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot cSlot = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)projectedSlot;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot sSlot = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectedSlot)projectedSlot2;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot item = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellSlot(i, cSlot, sSlot);
				list.Add(item);
			}
			this.m_viewCellRelation = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellRelation(this, list, cellNumber);
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x000F4669 File Offset: 0x000F2869
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			this.CQuery.ToCompactString(builder);
			builder.Append(" = ");
			this.SQuery.ToCompactString(builder);
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x000F468F File Offset: 0x000F288F
		internal override void ToFullString(global::System.Text.StringBuilder builder)
		{
			this.CQuery.ToFullString(builder);
			builder.Append(" = ");
			this.SQuery.ToFullString(builder);
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x000F46B5 File Offset: 0x000F28B5
		public override string ToString()
		{
			return this.ToFullString();
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x000F46C0 File Offset: 0x000F28C0
		internal static void CellsToBuilder(global::System.Text.StringBuilder builder, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells)
		{
			builder.AppendLine();
			builder.AppendLine("=========================================================================");
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				builder.AppendLine();
				global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatStringBuilder(builder, "Mapping Cell V{0}:", new object[]
				{
					cell.CellNumber
				});
				builder.AppendLine();
				builder.Append("C: ");
				cell.CQuery.ToFullString(builder);
				builder.AppendLine();
				builder.AppendLine();
				builder.Append("S: ");
				cell.SQuery.ToFullString(builder);
				builder.AppendLine();
			}
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x000F478C File Offset: 0x000F298C
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell CreateCS(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery cQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery sQuery, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellLabel label, int cellNumber)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell(cQuery, sQuery, label, cellNumber);
		}

		// Token: 0x040018EB RID: 6379
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery m_cQuery;

		// Token: 0x040018EC RID: 6380
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery m_sQuery;

		// Token: 0x040018ED RID: 6381
		private readonly int m_cellNumber;

		// Token: 0x040018EE RID: 6382
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellLabel m_label;

		// Token: 0x040018EF RID: 6383
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewCellRelation m_viewCellRelation;
	}
}
