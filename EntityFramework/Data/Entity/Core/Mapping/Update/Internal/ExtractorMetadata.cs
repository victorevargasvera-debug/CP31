using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005C6 RID: 1478
	internal class ExtractorMetadata
	{
		// Token: 0x0600478B RID: 18315 RVA: 0x000FC244 File Offset: 0x000FA444
		internal ExtractorMetadata(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, global::System.Data.Entity.Core.Metadata.Edm.StructuralType type, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator)
		{
			this.m_type = type;
			this.m_translator = translator;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = null;
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = type.BuiltInTypeKind;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> set;
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> set2;
			if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
				{
					set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(((global::System.Data.Entity.Core.Metadata.Edm.RowType)type).Properties).MakeReadOnly();
					set2 = global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Empty;
				}
				else
				{
					set = global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Empty;
					set2 = global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Empty;
				}
			}
			else
			{
				entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)type;
				set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(entityType.KeyMembers).MakeReadOnly();
				set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)entitySetBase).ForeignKeyDependents.SelectMany((global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> fk) => fk.Item2.ToProperties)).MakeReadOnly();
			}
			global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> allStructuralMembers = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(type);
			this.m_memberMap = new global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata.MemberInformation[allStructuralMembers.Count];
			for (int i = 0; i < allStructuralMembers.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = allStructuralMembers[i];
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags propagatorFlags = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags;
				int? entityKeyOrdinal = null;
				if (set.Contains(edmMember))
				{
					propagatorFlags |= global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Key;
					if (entityType != null)
					{
						entityKeyOrdinal = new int?(entityType.KeyMembers.IndexOf(edmMember));
					}
				}
				if (set2.Contains(edmMember))
				{
					propagatorFlags |= global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.ForeignKey;
				}
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetConcurrencyMode(edmMember) == global::System.Data.Entity.Core.Metadata.Edm.ConcurrencyMode.Fixed)
				{
					propagatorFlags |= global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.ConcurrencyValue;
				}
				bool isServerGenerated = this.m_translator.ViewLoader.IsServerGen(entitySetBase, this.m_translator.MetadataWorkspace, edmMember);
				bool isNullConditionMember = this.m_translator.ViewLoader.IsNullConditionMember(entitySetBase, this.m_translator.MetadataWorkspace, edmMember);
				this.m_memberMap[i] = new global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata.MemberInformation(i, entityKeyOrdinal, propagatorFlags, edmMember, isServerGenerated, isNullConditionMember);
			}
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x000FC3E4 File Offset: 0x000FA5E4
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult RetrieveMember(global::System.Data.Entity.Core.IEntityStateEntry stateEntry, global::System.Data.Entity.Core.IExtendedDataRecord record, bool useCurrentValues, global::System.Data.Entity.Core.EntityKey key, int ordinal, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior modifiedPropertiesBehavior)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata.MemberInformation memberInformation = this.m_memberMap[ordinal];
			int identifier;
			if (memberInformation.IsKeyMember)
			{
				int value = memberInformation.EntityKeyOrdinal.Value;
				identifier = this.m_translator.KeyManager.GetKeyIdentifierForMemberOffset(key, value, ((global::System.Data.Entity.Core.Metadata.Edm.EntityType)this.m_type).KeyMembers.Count);
			}
			else if (memberInformation.IsForeignKeyMember)
			{
				identifier = this.m_translator.KeyManager.GetKeyIdentifierForMember(key, record.GetName(ordinal), useCurrentValues);
			}
			else
			{
				identifier = -1;
			}
			bool flag = modifiedPropertiesBehavior == global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.AllModified || (modifiedPropertiesBehavior == global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.SomeModified && stateEntry.ModifiedProperties != null && stateEntry.ModifiedProperties[memberInformation.Ordinal]);
			if (memberInformation.CheckIsNotNull && record.IsDBNull(ordinal))
			{
				throw global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_NullValue(record.GetName(ordinal)), null, new global::System.Data.Entity.Core.IEntityStateEntry[]
				{
					stateEntry
				});
			}
			object value2 = record.GetValue(ordinal);
			global::System.Data.Entity.Core.EntityKey entityKey = value2 as global::System.Data.Entity.Core.EntityKey;
			if (entityKey != null)
			{
				return this.CreateEntityKeyResult(stateEntry, entityKey);
			}
			global::System.Data.Entity.Core.IExtendedDataRecord extendedDataRecord = value2 as global::System.Data.Entity.Core.IExtendedDataRecord;
			if (extendedDataRecord != null)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior modifiedPropertiesBehavior2 = flag ? global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.AllModified : global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.NoneModified;
				global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator = this.m_translator;
				return global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata.ExtractResultFromRecord(stateEntry, flag, extendedDataRecord, useCurrentValues, translator, modifiedPropertiesBehavior2);
			}
			return this.CreateSimpleResult(stateEntry, record, memberInformation, identifier, flag, ordinal, value2);
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x000FC518 File Offset: 0x000FA718
		private global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateEntityKeyResult(global::System.Data.Entity.Core.IEntityStateEntry stateEntry, global::System.Data.Entity.Core.EntityKey entityKey)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RowType keyRowType = entityKey.GetEntitySet(this.m_translator.MetadataWorkspace).ElementType.GetKeyRowType();
			global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata extractorMetadata = this.m_translator.GetExtractorMetadata(stateEntry.EntitySet, keyRowType);
			global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[keyRowType.Properties.Count];
			for (int i = 0; i < keyRowType.Properties.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = keyRowType.Properties[i];
				global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata.MemberInformation memberInformation = extractorMetadata.m_memberMap[i];
				int keyIdentifierForMemberOffset = this.m_translator.KeyManager.GetKeyIdentifierForMemberOffset(entityKey, i, keyRowType.Properties.Count);
				object value;
				if (entityKey.IsTemporary)
				{
					value = stateEntry.StateManager.GetEntityStateEntry(entityKey).CurrentValues[edmMember.Name];
				}
				else
				{
					value = entityKey.FindValueByName(edmMember.Name);
				}
				array[i] = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateKeyValue(memberInformation.Flags, value, stateEntry, keyIdentifierForMemberOffset);
			}
			return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateStructuralValue(array, extractorMetadata.m_type, false);
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x000FC614 File Offset: 0x000FA814
		private global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateSimpleResult(global::System.Data.Entity.Core.IEntityStateEntry stateEntry, global::System.Data.Entity.Core.IExtendedDataRecord record, global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata.MemberInformation memberInformation, int identifier, bool isModified, int recordOrdinal, object value)
		{
			global::System.Data.Entity.Core.Objects.CurrentValueRecord currentValueRecord = record as global::System.Data.Entity.Core.Objects.CurrentValueRecord;
			global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags propagatorFlags = memberInformation.Flags;
			if (!isModified)
			{
				propagatorFlags |= global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve;
			}
			if (-1 != identifier)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult;
				if ((memberInformation.IsServerGenerated || memberInformation.IsForeignKeyMember) && currentValueRecord != null)
				{
					propagatorResult = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateServerGenKeyValue(propagatorFlags, value, stateEntry, identifier, recordOrdinal);
				}
				else
				{
					propagatorResult = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateKeyValue(propagatorFlags, value, stateEntry, identifier);
				}
				this.m_translator.KeyManager.RegisterIdentifierOwner(propagatorResult);
				return propagatorResult;
			}
			if ((memberInformation.IsServerGenerated || memberInformation.IsForeignKeyMember) && currentValueRecord != null)
			{
				return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateServerGenSimpleValue(propagatorFlags, value, currentValueRecord, recordOrdinal);
			}
			return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateSimpleValue(propagatorFlags, value);
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x000FC6A8 File Offset: 0x000FA8A8
		internal static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ExtractResultFromRecord(global::System.Data.Entity.Core.IEntityStateEntry stateEntry, bool isModified, global::System.Data.Entity.Core.IExtendedDataRecord record, bool useCurrentValues, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior modifiedPropertiesBehavior)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = (global::System.Data.Entity.Core.Metadata.Edm.StructuralType)record.DataRecordInfo.RecordType.EdmType;
			global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata extractorMetadata = translator.GetExtractorMetadata(stateEntry.EntitySet, structuralType);
			global::System.Data.Entity.Core.EntityKey entityKey = stateEntry.EntityKey;
			global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[record.FieldCount];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = extractorMetadata.RetrieveMember(stateEntry, record, useCurrentValues, entityKey, i, modifiedPropertiesBehavior);
			}
			return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateStructuralValue(array, structuralType, isModified);
		}

		// Token: 0x04001967 RID: 6503
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractorMetadata.MemberInformation[] m_memberMap;

		// Token: 0x04001968 RID: 6504
		private readonly global::System.Data.Entity.Core.Metadata.Edm.StructuralType m_type;

		// Token: 0x04001969 RID: 6505
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator m_translator;

		// Token: 0x02000BF5 RID: 3061
		private class MemberInformation
		{
			// Token: 0x1700113B RID: 4411
			// (get) Token: 0x060068D2 RID: 26834 RVA: 0x001649CF File Offset: 0x00162BCF
			internal bool IsKeyMember
			{
				get
				{
					return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Key == (this.Flags & global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Key);
				}
			}

			// Token: 0x1700113C RID: 4412
			// (get) Token: 0x060068D3 RID: 26835 RVA: 0x001649DE File Offset: 0x00162BDE
			internal bool IsForeignKeyMember
			{
				get
				{
					return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.ForeignKey == (this.Flags & global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.ForeignKey);
				}
			}

			// Token: 0x060068D4 RID: 26836 RVA: 0x001649F0 File Offset: 0x00162BF0
			internal MemberInformation(int ordinal, int? entityKeyOrdinal, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, bool isServerGenerated, bool isNullConditionMember)
			{
				this.Ordinal = ordinal;
				this.EntityKeyOrdinal = entityKeyOrdinal;
				this.Flags = flags;
				this.Member = member;
				this.IsServerGenerated = isServerGenerated;
				this.CheckIsNotNull = (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNullable(member) && (isNullConditionMember || member.TypeUsage.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType));
			}

			// Token: 0x04002F50 RID: 12112
			internal readonly int Ordinal;

			// Token: 0x04002F51 RID: 12113
			internal readonly int? EntityKeyOrdinal;

			// Token: 0x04002F52 RID: 12114
			internal readonly global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags Flags;

			// Token: 0x04002F53 RID: 12115
			internal readonly bool IsServerGenerated;

			// Token: 0x04002F54 RID: 12116
			internal readonly bool CheckIsNotNull;

			// Token: 0x04002F55 RID: 12117
			internal readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember Member;
		}
	}
}
