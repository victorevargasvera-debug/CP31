using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005C7 RID: 1479
	internal abstract class ModificationFunctionMappingTranslator
	{
		// Token: 0x06004790 RID: 18320
		internal abstract global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand Translate(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry stateEntry);

		// Token: 0x06004791 RID: 18321 RVA: 0x000FC719 File Offset: 0x000FA919
		internal static global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator CreateEntitySetTranslator(global::System.Data.Entity.Core.Mapping.EntitySetMapping setMapping)
		{
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator.EntitySetTranslator(setMapping);
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x000FC721 File Offset: 0x000FA921
		internal static global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator CreateAssociationSetTranslator(global::System.Data.Entity.Core.Mapping.AssociationSetMapping setMapping)
		{
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator.AssociationSetTranslator(setMapping);
		}

		// Token: 0x02000BF7 RID: 3063
		private sealed class EntitySetTranslator : global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator
		{
			// Token: 0x060068D8 RID: 26840 RVA: 0x00164A78 File Offset: 0x00162C78
			internal EntitySetTranslator(global::System.Data.Entity.Core.Mapping.EntitySetMapping setMapping)
			{
				this.m_typeMappings = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping>();
				foreach (global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping in setMapping.ModificationFunctionMappings)
				{
					this.m_typeMappings.Add(entityTypeModificationFunctionMapping.EntityType, entityTypeModificationFunctionMapping);
				}
			}

			// Token: 0x060068D9 RID: 26841 RVA: 0x00164AE4 File Offset: 0x00162CE4
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand Translate(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry stateEntry)
			{
				global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping item = this.GetFunctionMapping(stateEntry).Item2;
				global::System.Data.Entity.Core.EntityKey entityKey = stateEntry.Source.EntityKey;
				global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.IEntityStateEntry> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.IEntityStateEntry>
				{
					stateEntry.Source
				};
				global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry>> enumerable = from end in item.CollocatedAssociationSetEnds
				join candidateEntry in translator.GetRelationships(entityKey) on end.CorrespondingAssociationEndMember.DeclaringType equals candidateEntry.EntitySet.ElementType
				select global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry>(end.CorrespondingAssociationEndMember, candidateEntry);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry>();
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry> dictionary2 = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry>();
				foreach (global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry> tuple in enumerable)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator.EntitySetTranslator.ProcessReferenceCandidate(entityKey, hashSet, dictionary, dictionary2, tuple.Item1, tuple.Item2);
				}
				global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand functionUpdateCommand;
				if (hashSet.All((global::System.Data.Entity.Core.IEntityStateEntry e) => e.State == global::System.Data.Entity.EntityState.Unchanged))
				{
					functionUpdateCommand = null;
				}
				else
				{
					functionUpdateCommand = new global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand(item, translator, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.IEntityStateEntry>(hashSet.ToList<global::System.Data.Entity.Core.IEntityStateEntry>()), stateEntry);
					global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator.EntitySetTranslator.BindFunctionParameters(translator, stateEntry, item, functionUpdateCommand, dictionary, dictionary2);
					if (item.ResultBindings != null)
					{
						foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding modificationFunctionResultBinding in item.ResultBindings)
						{
							global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult memberValue = stateEntry.Current.GetMemberValue(modificationFunctionResultBinding.Property);
							functionUpdateCommand.AddResultColumn(translator, modificationFunctionResultBinding.ColumnName, memberValue);
						}
					}
				}
				return functionUpdateCommand;
			}

			// Token: 0x060068DA RID: 26842 RVA: 0x00164CA4 File Offset: 0x00162EA4
			private static void ProcessReferenceCandidate(global::System.Data.Entity.Core.EntityKey source, global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.IEntityStateEntry> stateEntries, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry> currentReferenceEnd, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry> originalReferenceEnd, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember endMember, global::System.Data.Entity.Core.IEntityStateEntry candidateEntry)
			{
				global::System.Func<global::System.Data.Common.DbDataRecord, int, global::System.Data.Entity.Core.EntityKey> getEntityKey = (global::System.Data.Common.DbDataRecord record, int ordinal) => (global::System.Data.Entity.Core.EntityKey)record[ordinal];
				global::System.Action<global::System.Data.Common.DbDataRecord, global::System.Action<global::System.Data.Entity.Core.IEntityStateEntry>> action = delegate(global::System.Data.Common.DbDataRecord record, global::System.Action<global::System.Data.Entity.Core.IEntityStateEntry> registerTarget)
				{
					int ordinal = record.GetOrdinal(endMember.Name);
					int arg = (ordinal == 0) ? 1 : 0;
					if (getEntityKey(record, arg) == source)
					{
						stateEntries.Add(candidateEntry);
						registerTarget(candidateEntry);
					}
				};
				global::System.Data.Entity.EntityState state = candidateEntry.State;
				if (state == global::System.Data.Entity.EntityState.Unchanged)
				{
					action(candidateEntry.CurrentValues, delegate(global::System.Data.Entity.Core.IEntityStateEntry target)
					{
						currentReferenceEnd.Add(endMember, target);
						originalReferenceEnd.Add(endMember, target);
					});
					return;
				}
				if (state == global::System.Data.Entity.EntityState.Added)
				{
					action(candidateEntry.CurrentValues, delegate(global::System.Data.Entity.Core.IEntityStateEntry target)
					{
						currentReferenceEnd.Add(endMember, target);
					});
					return;
				}
				if (state != global::System.Data.Entity.EntityState.Deleted)
				{
					return;
				}
				action(candidateEntry.OriginalValues, delegate(global::System.Data.Entity.Core.IEntityStateEntry target)
				{
					originalReferenceEnd.Add(endMember, target);
				});
			}

			// Token: 0x060068DB RID: 26843 RVA: 0x00164D88 File Offset: 0x00162F88
			private global::System.Tuple<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping> GetFunctionMapping(global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry stateEntry)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType;
				if (stateEntry.Current != null)
				{
					entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)stateEntry.Current.StructuralType;
				}
				else
				{
					entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)stateEntry.Original.StructuralType;
				}
				global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping = this.m_typeMappings[entityType];
				global::System.Data.Entity.EntityState state = stateEntry.State;
				global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationFunctionMapping;
				if (state <= global::System.Data.Entity.EntityState.Added)
				{
					if (state != global::System.Data.Entity.EntityState.Unchanged)
					{
						if (state != global::System.Data.Entity.EntityState.Added)
						{
							goto IL_C8;
						}
						modificationFunctionMapping = entityTypeModificationFunctionMapping.InsertFunctionMapping;
						global::System.Data.Entity.Core.EntityUtil.ValidateNecessaryModificationFunctionMapping(modificationFunctionMapping, "Insert", stateEntry.Source, "EntityType", entityType.Name);
						goto IL_CA;
					}
				}
				else
				{
					if (state == global::System.Data.Entity.EntityState.Deleted)
					{
						modificationFunctionMapping = entityTypeModificationFunctionMapping.DeleteFunctionMapping;
						global::System.Data.Entity.Core.EntityUtil.ValidateNecessaryModificationFunctionMapping(modificationFunctionMapping, "Delete", stateEntry.Source, "EntityType", entityType.Name);
						goto IL_CA;
					}
					if (state != global::System.Data.Entity.EntityState.Modified)
					{
						goto IL_C8;
					}
				}
				modificationFunctionMapping = entityTypeModificationFunctionMapping.UpdateFunctionMapping;
				global::System.Data.Entity.Core.EntityUtil.ValidateNecessaryModificationFunctionMapping(modificationFunctionMapping, "Update", stateEntry.Source, "EntityType", entityType.Name);
				goto IL_CA;
				IL_C8:
				modificationFunctionMapping = null;
				IL_CA:
				return global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping>(entityTypeModificationFunctionMapping, modificationFunctionMapping);
			}

			// Token: 0x060068DC RID: 26844 RVA: 0x00164E68 File Offset: 0x00163068
			private static void BindFunctionParameters(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry stateEntry, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping functionMapping, global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand command, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry> currentReferenceEnds, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember, global::System.Data.Entity.Core.IEntityStateEntry> originalReferenceEnds)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding in functionMapping.ParameterBindings)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult;
					if (modificationFunctionParameterBinding.MemberPath.AssociationSetEnd != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember correspondingAssociationEndMember = modificationFunctionParameterBinding.MemberPath.AssociationSetEnd.CorrespondingAssociationEndMember;
						global::System.Data.Entity.Core.IEntityStateEntry stateEntry2;
						if (!(modificationFunctionParameterBinding.IsCurrent ? currentReferenceEnds.TryGetValue(correspondingAssociationEndMember, out stateEntry2) : originalReferenceEnds.TryGetValue(correspondingAssociationEndMember, out stateEntry2)))
						{
							if (correspondingAssociationEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One)
							{
								object name = stateEntry.Source.EntitySet.Name;
								string name2 = modificationFunctionParameterBinding.MemberPath.AssociationSetEnd.ParentAssociationSet.Name;
								throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_MissingRequiredRelationshipValue(name, name2), null, command.GetStateEntries(translator).Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
							}
							propagatorResult = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.CreateSimpleValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags, null);
						}
						else
						{
							global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult memberValue = (modificationFunctionParameterBinding.IsCurrent ? translator.RecordConverter.ConvertCurrentValuesToPropagatorResult(stateEntry2, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.AllModified) : translator.RecordConverter.ConvertOriginalValuesToPropagatorResult(stateEntry2, global::System.Data.Entity.Core.Mapping.Update.Internal.ModifiedPropertiesBehavior.AllModified)).GetMemberValue(correspondingAssociationEndMember);
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)modificationFunctionParameterBinding.MemberPath.Members[0];
							propagatorResult = memberValue.GetMemberValue(member);
						}
					}
					else
					{
						propagatorResult = (modificationFunctionParameterBinding.IsCurrent ? stateEntry.Current : stateEntry.Original);
						int i = modificationFunctionParameterBinding.MemberPath.Members.Count;
						while (i > 0)
						{
							i--;
							global::System.Data.Entity.Core.Metadata.Edm.EdmMember member2 = modificationFunctionParameterBinding.MemberPath.Members[i];
							propagatorResult = propagatorResult.GetMemberValue(member2);
						}
					}
					command.SetParameterValue(propagatorResult, modificationFunctionParameterBinding, translator);
				}
				command.RegisterRowsAffectedParameter(functionMapping.RowsAffectedParameter);
			}

			// Token: 0x04002F58 RID: 12120
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping> m_typeMappings;
		}

		// Token: 0x02000BF8 RID: 3064
		private sealed class AssociationSetTranslator : global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationFunctionMappingTranslator
		{
			// Token: 0x060068DD RID: 26845 RVA: 0x00165014 File Offset: 0x00163214
			internal AssociationSetTranslator(global::System.Data.Entity.Core.Mapping.AssociationSetMapping setMapping)
			{
				if (setMapping != null)
				{
					this.m_mapping = setMapping.ModificationFunctionMapping;
				}
			}

			// Token: 0x060068DE RID: 26846 RVA: 0x0016502C File Offset: 0x0016322C
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand Translate(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry stateEntry)
			{
				if (this.m_mapping == null)
				{
					return null;
				}
				bool flag = global::System.Data.Entity.EntityState.Added == stateEntry.State;
				global::System.Data.Entity.Core.EntityUtil.ValidateNecessaryModificationFunctionMapping(flag ? this.m_mapping.InsertFunctionMapping : this.m_mapping.DeleteFunctionMapping, flag ? "Insert" : "Delete", stateEntry.Source, "AssociationSet", this.m_mapping.AssociationSet.Name);
				global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationFunctionMapping = flag ? this.m_mapping.InsertFunctionMapping : this.m_mapping.DeleteFunctionMapping;
				global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand functionUpdateCommand = new global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand(modificationFunctionMapping, translator, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.IEntityStateEntry>(new global::System.Data.Entity.Core.IEntityStateEntry[]
				{
					stateEntry.Source
				}.ToList<global::System.Data.Entity.Core.IEntityStateEntry>()), stateEntry);
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult;
				if (flag)
				{
					propagatorResult = stateEntry.Current;
				}
				else
				{
					propagatorResult = stateEntry.Original;
				}
				foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding in modificationFunctionMapping.ParameterBindings)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)modificationFunctionParameterBinding.MemberPath.Members[0];
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember member2 = (global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)modificationFunctionParameterBinding.MemberPath.Members[1];
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult memberValue = propagatorResult.GetMemberValue(member2).GetMemberValue(member);
					functionUpdateCommand.SetParameterValue(memberValue, modificationFunctionParameterBinding, translator);
				}
				functionUpdateCommand.RegisterRowsAffectedParameter(modificationFunctionMapping.RowsAffectedParameter);
				return functionUpdateCommand;
			}

			// Token: 0x04002F59 RID: 12121
			private readonly global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping m_mapping;
		}
	}
}
