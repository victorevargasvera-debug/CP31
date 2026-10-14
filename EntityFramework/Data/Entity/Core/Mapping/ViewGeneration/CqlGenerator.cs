using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x02000568 RID: 1384
	internal sealed class CqlGenerator : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004395 RID: 17301 RVA: 0x000E8E87 File Offset: 0x000E7087
		internal CqlGenerator(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode view, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement> caseStatements, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, int numCellsInView, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression topLevelWhereClause, global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection mappingItemCollection)
		{
			this.m_view = view;
			this.m_caseStatements = caseStatements;
			this.m_projectedSlotMap = projectedSlotMap;
			this.m_numBools = numCellsInView;
			this.m_topLevelWhereClause = topLevelWhereClause;
			this.m_identifiers = identifiers;
			this.m_mappingItemCollection = mappingItemCollection;
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06004396 RID: 17302 RVA: 0x000E8EC4 File Offset: 0x000E70C4
		private int TotalSlots
		{
			get
			{
				return this.m_projectedSlotMap.Count + this.m_numBools;
			}
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x000E8ED8 File Offset: 0x000E70D8
		internal string GenerateEsql()
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock = this.GenerateCqlBlockTree();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
			cqlBlock.AsEsql(stringBuilder, true, 1);
			return stringBuilder.ToString();
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x000E8F08 File Offset: 0x000E7108
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree GenerateCqt()
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query = this.GenerateCqlBlockTree().AsCqt(true);
			return global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(this.m_mappingItemCollection.Workspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, query, true, false);
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x000E8F38 File Offset: 0x000E7138
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock GenerateCqlBlockTree()
		{
			bool[] requiredSlots = this.GetRequiredSlots();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship>();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock viewBlock = this.m_view.ToCqlBlock(requiredSlots, this.m_identifiers, ref this.m_currentBlockNum, ref withRelationships);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement in this.m_caseStatements.Values)
			{
				caseStatement.Simplify();
			}
			return this.ConstructCaseBlocks(viewBlock, withRelationships);
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x000E8FC0 File Offset: 0x000E71C0
		private bool[] GetRequiredSlots()
		{
			bool[] array = new bool[this.TotalSlots];
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement in this.m_caseStatements.Values)
			{
				this.GetRequiredSlotsForCaseMember(caseStatement.MemberPath, array);
			}
			for (int i = this.TotalSlots - this.m_numBools; i < this.TotalSlots; i++)
			{
				array[i] = true;
			}
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement2 in this.m_caseStatements.Values)
			{
				if (!caseStatement2.MemberPath.IsPartOfKey && !caseStatement2.DependsOnMemberValue)
				{
					array[this.m_projectedSlotMap.IndexOf(caseStatement2.MemberPath)] = false;
				}
			}
			return array;
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x000E90C0 File Offset: 0x000E72C0
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock ConstructCaseBlocks(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock viewBlock, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships)
		{
			bool[] array = new bool[this.TotalSlots];
			array[0] = true;
			this.m_topLevelWhereClause.GetRequiredSlots(this.m_projectedSlotMap, array);
			return this.ConstructCaseBlocks(viewBlock, 0, array, withRelationships);
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x000E90FC File Offset: 0x000E72FC
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock ConstructCaseBlocks(global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock viewBlock, int startSlotNum, bool[] parentRequiredSlots, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships)
		{
			int count = this.m_projectedSlotMap.Count;
			int num = this.FindNextCaseStatementSlot(startSlotNum, parentRequiredSlots, count);
			if (num == -1)
			{
				return viewBlock;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = this.m_projectedSlotMap[num];
			bool[] array = new bool[this.TotalSlots];
			this.GetRequiredSlotsForCaseMember(memberPath, array);
			for (int i = 0; i < this.TotalSlots; i++)
			{
				if (parentRequiredSlots[i])
				{
					array[i] = true;
				}
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement = this.m_caseStatements[memberPath];
			array[num] = caseStatement.DependsOnMemberValue;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock cqlBlock = this.ConstructCaseBlocks(viewBlock, num + 1, array, null);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] array2 = this.CreateSlotInfosForCaseStatement(parentRequiredSlots, num, cqlBlock, caseStatement, withRelationships);
			this.m_currentBlockNum++;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression whereClause = (startSlotNum == 0) ? this.m_topLevelWhereClause : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
			if (startSlotNum == 0)
			{
				for (int j = 1; j < array2.Length; j++)
				{
					array2[j].ResetIsRequiredByParent();
				}
			}
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CaseCqlBlock(array2, num, cqlBlock, whereClause, this.m_identifiers, this.m_currentBlockNum);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x000E91F4 File Offset: 0x000E73F4
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] CreateSlotInfosForCaseStatement(bool[] parentRequiredSlots, int foundSlot, global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlBlock childBlock, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement thisCaseStatement, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.WithRelationship> withRelationships)
		{
			int num = childBlock.Slots.Count - this.TotalSlots;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[] array = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo[this.TotalSlots + num];
			for (int i = 0; i < this.TotalSlots; i++)
			{
				bool flag = childBlock.IsProjected(i);
				bool flag2 = parentRequiredSlots[i];
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot slotValue = childBlock.SlotValue(i);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMemberPath = this.GetOutputMemberPath(i);
				if (i == foundSlot)
				{
					slotValue = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatementProjectedSlot(thisCaseStatement.DeepQualify(childBlock), withRelationships);
					flag = true;
				}
				else if (flag && flag2)
				{
					slotValue = childBlock.QualifySlotWithBlockAlias(i);
				}
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo slotInfo = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(flag2 && flag, flag, slotValue, outputMemberPath);
				array[i] = slotInfo;
			}
			for (int j = this.TotalSlots; j < this.TotalSlots + num; j++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.QualifiedSlot slotValue2 = childBlock.QualifySlotWithBlockAlias(j);
				array[j] = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.SlotInfo(true, true, slotValue2, childBlock.MemberPath(j));
			}
			return array;
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x000E92CC File Offset: 0x000E74CC
		private int FindNextCaseStatementSlot(int startSlotNum, bool[] parentRequiredSlots, int numMembers)
		{
			int result = -1;
			for (int i = startSlotNum; i < numMembers; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath key = this.m_projectedSlotMap[i];
				if (parentRequiredSlots[i] && this.m_caseStatements.ContainsKey(key))
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x000E930C File Offset: 0x000E750C
		private void GetRequiredSlotsForCaseMember(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath caseMemberPath, bool[] requiredSlots)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement caseStatement = this.m_caseStatements[caseMemberPath];
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement.WhenThen whenThen in caseStatement.Clauses)
			{
				whenThen.Condition.GetRequiredSlots(this.m_projectedSlotMap, requiredSlots);
				if (!(whenThen.Value is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ConstantProjectedSlot))
				{
					flag = true;
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = caseMemberPath.EdmType;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmType))
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmType> enumerator2 = caseStatement.InstantiatedTypes.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = enumerator2.Current;
						foreach (object obj in global::System.Data.Entity.Core.Metadata.Edm.Helper.GetAllStructuralMembers(edmType2))
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmMember child = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
							int slotIndex = this.GetSlotIndex(caseMemberPath, child);
							requiredSlots[slotIndex] = true;
						}
					}
					return;
				}
			}
			if (caseMemberPath.IsScalarType())
			{
				if (flag)
				{
					int num = this.m_projectedSlotMap.IndexOf(caseMemberPath);
					requiredSlots[num] = true;
					return;
				}
			}
			else
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssociationType(edmType))
				{
					using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>.Enumerator enumerator4 = ((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)caseMemberPath.Extent).ElementType.AssociationEndMembers.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember child2 = enumerator4.Current;
							int slotIndex2 = this.GetSlotIndex(caseMemberPath, child2);
							requiredSlots[slotIndex2] = true;
						}
						return;
					}
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember child3 in (edmType as global::System.Data.Entity.Core.Metadata.Edm.RefType).ElementType.KeyMembers)
				{
					int slotIndex3 = this.GetSlotIndex(caseMemberPath, child3);
					requiredSlots[slotIndex3] = true;
				}
			}
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x000E9510 File Offset: 0x000E7710
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath GetOutputMemberPath(int slotNum)
		{
			return this.m_projectedSlotMap.GetMemberPath(slotNum, this.TotalSlots - this.m_projectedSlotMap.Count);
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x000E9530 File Offset: 0x000E7730
		private int GetSlotIndex(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member, global::System.Data.Entity.Core.Metadata.Edm.EdmMember child)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath member2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(member, child);
			return this.m_projectedSlotMap.IndexOf(member2);
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x000E9554 File Offset: 0x000E7754
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append("View: ");
			this.m_view.ToCompactString(builder);
			builder.Append("ProjectedSlotMap: ");
			this.m_projectedSlotMap.ToCompactString(builder);
			builder.Append("Case statements: ");
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath key in this.m_caseStatements.Keys)
			{
				this.m_caseStatements[key].ToCompactString(builder);
				builder.AppendLine();
			}
		}

		// Token: 0x0400181D RID: 6173
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode m_view;

		// Token: 0x0400181E RID: 6174
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CaseStatement> m_caseStatements;

		// Token: 0x0400181F RID: 6175
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex m_projectedSlotMap;

		// Token: 0x04001820 RID: 6176
		private readonly int m_numBools;

		// Token: 0x04001821 RID: 6177
		private int m_currentBlockNum;

		// Token: 0x04001822 RID: 6178
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression m_topLevelWhereClause;

		// Token: 0x04001823 RID: 6179
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers m_identifiers;

		// Token: 0x04001824 RID: 6180
		private readonly global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection m_mappingItemCollection;
	}
}
