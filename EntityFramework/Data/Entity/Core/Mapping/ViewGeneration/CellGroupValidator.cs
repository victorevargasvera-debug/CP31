using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Validation;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x0200056C RID: 1388
	internal class CellGroupValidator
	{
		// Token: 0x060043B1 RID: 17329 RVA: 0x000EA04F File Offset: 0x000E824F
		internal CellGroupValidator(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			this.m_cells = cells;
			this.m_config = config;
			this.m_errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x000EA070 File Offset: 0x000E8270
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog Validate()
		{
			if (this.m_config.IsValidationEnabled)
			{
				if (!this.PerformSingleCellChecks())
				{
					return this.m_errorLog;
				}
			}
			else if (!this.CheckCellsWithDistinctFlag())
			{
				return this.m_errorLog;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> schemaConstraints = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint>();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> schemaConstraints2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint>();
			this.ConstructCellRelationsWithConstraints(schemaConstraints, schemaConstraints2);
			if (this.m_config.IsVerboseTracing)
			{
				global::System.Diagnostics.Trace.WriteLine(string.Empty);
				global::System.Diagnostics.Trace.WriteLine("C-Level Basic Constraints");
				global::System.Diagnostics.Trace.WriteLine(schemaConstraints);
				global::System.Diagnostics.Trace.WriteLine("S-Level Basic Constraints");
				global::System.Diagnostics.Trace.WriteLine(schemaConstraints2);
			}
			this.m_cViewConstraints = global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.PropagateConstraints(schemaConstraints);
			this.m_sViewConstraints = global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.PropagateConstraints(schemaConstraints2);
			if (this.m_config.IsVerboseTracing)
			{
				global::System.Diagnostics.Trace.WriteLine(string.Empty);
				global::System.Diagnostics.Trace.WriteLine("C-Level View Constraints");
				global::System.Diagnostics.Trace.WriteLine(this.m_cViewConstraints);
				global::System.Diagnostics.Trace.WriteLine("S-Level View Constraints");
				global::System.Diagnostics.Trace.WriteLine(this.m_sViewConstraints);
			}
			if (this.m_config.IsValidationEnabled)
			{
				this.CheckImplication(this.m_cViewConstraints, this.m_sViewConstraints);
			}
			return this.m_errorLog;
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x000EA174 File Offset: 0x000E8374
		private void ConstructCellRelationsWithConstraints(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> cConstraints, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> sConstraints)
		{
			int num = 0;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in this.m_cells)
			{
				cell.CreateViewCellRelation(num);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicCellRelation basicCellRelation = cell.CQuery.BasicCellRelation;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicCellRelation basicCellRelation2 = cell.SQuery.BasicCellRelation;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.PopulateBaseConstraints(basicCellRelation, cConstraints);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.PopulateBaseConstraints(basicCellRelation2, sConstraints);
				num++;
			}
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell2 in this.m_cells)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell3 in this.m_cells)
				{
				}
			}
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x000EA260 File Offset: 0x000E8460
		private static void PopulateBaseConstraints(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicCellRelation baseRelation, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> constraints)
		{
			baseRelation.PopulateKeyConstraints(constraints);
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x000EA26C File Offset: 0x000E846C
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> PropagateConstraints(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> baseConstraints)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> schemaConstraints = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint basicKeyConstraint in baseConstraints.KeyConstraints)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint viewKeyConstraint = basicKeyConstraint.Propagate();
				if (viewKeyConstraint != null)
				{
					schemaConstraints.Add(viewKeyConstraint);
				}
			}
			return schemaConstraints;
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x000EA2C8 File Offset: 0x000E84C8
		private void CheckImplication(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> cViewConstraints, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> sViewConstraints)
		{
			this.CheckImplicationKeyConstraints(cViewConstraints, sViewConstraints);
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.ExtentPair, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.ExtentPair, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.ExtentPair>.Default);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint viewKeyConstraint in cViewConstraints.KeyConstraints)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.ExtentPair key = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.ExtentPair(viewKeyConstraint.Cell.CQuery.Extent, viewKeyConstraint.Cell.SQuery.Extent);
				keyToListMap.Add(key, viewKeyConstraint);
			}
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.ExtentPair key2 in keyToListMap.Keys)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> readOnlyCollection = keyToListMap.ListForKey(key2);
				bool flag = false;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint second in readOnlyCollection)
				{
					using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> enumerator3 = sViewConstraints.KeyConstraints.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							if (enumerator3.Current.Implies(second))
							{
								flag = true;
								break;
							}
						}
					}
				}
				if (!flag)
				{
					this.m_errorLog.AddEntry(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint.GetErrorRecord(readOnlyCollection));
				}
			}
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x000EA42C File Offset: 0x000E862C
		private void CheckImplicationKeyConstraints(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> leftViewConstraints, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> rightViewConstraints)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint viewKeyConstraint in rightViewConstraints.KeyConstraints)
			{
				bool flag = false;
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> enumerator2 = leftViewConstraints.KeyConstraints.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.Implies(viewKeyConstraint))
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					this.m_errorLog.AddEntry(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint.GetErrorRecord(viewKeyConstraint));
				}
			}
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x000EA4C8 File Offset: 0x000E86C8
		private bool CheckCellsWithDistinctFlag()
		{
			int count = this.m_errorLog.Count;
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> enumerator = this.m_cells.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell = enumerator.Current;
					if (cell.SQuery.SelectDistinctFlag == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.Yes)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase cExtent = cell.CQuery.Extent;
						global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase sExtent = cell.SQuery.Extent;
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> enumerable = from otherCell in this.m_cells
						where otherCell != cell
						where otherCell.CQuery.Extent == cExtent && otherCell.SQuery.Extent == sExtent
						select otherCell;
						if (enumerable.Any<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>())
						{
							global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> sourceCells = global::System.Linq.Enumerable.Repeat<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>(cell, 1).Union(enumerable);
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.MultipleFragmentsBetweenCandSExtentWithDistinct, global::System.Data.Entity.Resources.Strings.Viewgen_MultipleFragmentsBetweenCandSExtentWithDistinct(cExtent.Name, sExtent.Name), sourceCells, string.Empty);
							this.m_errorLog.AddEntry(record);
						}
					}
				}
			}
			return this.m_errorLog.Count == count;
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x000EA604 File Offset: 0x000E8804
		private bool PerformSingleCellChecks()
		{
			int count = this.m_errorLog.Count;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in this.m_cells)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = cell.SQuery.CheckForDuplicateFields(cell.CQuery, cell);
				if (record != null)
				{
					this.m_errorLog.AddEntry(record);
				}
				record = cell.CQuery.VerifyKeysPresent(cell, new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.ViewGen_EntitySetKey_Missing), new global::System.Func<object, object, object, string>(global::System.Data.Entity.Resources.Strings.ViewGen_AssociationSetKey_Missing), global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.KeyNotMappedForCSideExtent);
				if (record != null)
				{
					this.m_errorLog.AddEntry(record);
				}
				record = cell.SQuery.VerifyKeysPresent(cell, new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.ViewGen_TableKey_Missing), null, global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.KeyNotMappedForTable);
				if (record != null)
				{
					this.m_errorLog.AddEntry(record);
				}
				record = cell.CQuery.CheckForProjectedNotNullSlots(cell, from c in this.m_cells
				where c.SQuery.Extent is global::System.Data.Entity.Core.Metadata.Edm.AssociationSet
				select c);
				if (record != null)
				{
					this.m_errorLog.AddEntry(record);
				}
				record = cell.SQuery.CheckForProjectedNotNullSlots(cell, from c in this.m_cells
				where c.CQuery.Extent is global::System.Data.Entity.Core.Metadata.Edm.AssociationSet
				select c);
				if (record != null)
				{
					this.m_errorLog.AddEntry(record);
				}
			}
			return this.m_errorLog.Count == count;
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x000EA78C File Offset: 0x000E898C
		[global::System.Diagnostics.Conditional("DEBUG")]
		private static void CheckConstraintSanity(global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> cConstraints, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.BasicKeyConstraint> sConstraints, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> cViewConstraints, global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> sViewConstraints)
		{
		}

		// Token: 0x04001840 RID: 6208
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> m_cells;

		// Token: 0x04001841 RID: 6209
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator m_config;

		// Token: 0x04001842 RID: 6210
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog m_errorLog;

		// Token: 0x04001843 RID: 6211
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> m_cViewConstraints;

		// Token: 0x04001844 RID: 6212
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.SchemaConstraints<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ViewKeyConstraint> m_sViewConstraints;

		// Token: 0x02000B7B RID: 2939
		private class ExtentPair
		{
			// Token: 0x0600667C RID: 26236 RVA: 0x0015F01F File Offset: 0x0015D21F
			internal ExtentPair(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase acExtent, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase asExtent)
			{
				this.cExtent = acExtent;
				this.sExtent = asExtent;
			}

			// Token: 0x0600667D RID: 26237 RVA: 0x0015F038 File Offset: 0x0015D238
			public override bool Equals(object obj)
			{
				if (this == obj)
				{
					return true;
				}
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.ExtentPair extentPair = obj as global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator.ExtentPair;
				return extentPair != null && extentPair.cExtent.Equals(this.cExtent) && extentPair.sExtent.Equals(this.sExtent);
			}

			// Token: 0x0600667E RID: 26238 RVA: 0x0015F07D File Offset: 0x0015D27D
			public override int GetHashCode()
			{
				return this.cExtent.GetHashCode() ^ this.sExtent.GetHashCode();
			}

			// Token: 0x04002DEF RID: 11759
			internal readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase cExtent;

			// Token: 0x04002DF0 RID: 11760
			internal readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase sExtent;
		}
	}
}
