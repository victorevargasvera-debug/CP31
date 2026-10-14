using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005C4 RID: 1476
	internal class DynamicUpdateCommand : global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand
	{
		// Token: 0x0600477B RID: 18299 RVA: 0x000FB968 File Offset: 0x000F9B68
		internal DynamicUpdateCommand(global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor processor, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator modificationOperator, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult originalValues, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult currentValues, global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree tree, global::System.Collections.Generic.Dictionary<int, string> outputIdentifiers) : base(translator, originalValues, currentValues)
		{
			this._processor = processor;
			this._operator = modificationOperator;
			this._modificationCommandTree = tree;
			this._outputIdentifiers = outputIdentifiers;
			if (global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert == modificationOperator || modificationOperator == global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update)
			{
				this._inputIdentifiers = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause>>(2);
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> keyValuePair in global::System.Data.Entity.Core.Metadata.Edm.Helper.PairEnumerations<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(base.CurrentValues.StructuralType), base.CurrentValues.GetMemberValues()))
				{
					int identifier = keyValuePair.Value.Identifier;
					global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause value;
					if (-1 != identifier && global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand.TryGetSetterExpression(tree, keyValuePair.Key, modificationOperator, out value))
					{
						foreach (int key in translator.KeyManager.GetPrincipals(identifier))
						{
							this._inputIdentifiers.Add(new global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause>(key, value));
						}
					}
				}
			}
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x000FBA80 File Offset: 0x000F9C80
		private static bool TryGetSetterExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree tree, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator op, out global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause setter)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> setClauses;
			if (global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert == op)
			{
				setClauses = ((global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree)tree).SetClauses;
			}
			else
			{
				setClauses = ((global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree)tree).SetClauses;
			}
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause dbModificationClause in setClauses)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause dbSetClause = (global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause)dbModificationClause;
				if (((global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)dbSetClause.Property).Property.EdmEquals(member))
				{
					setter = dbSetClause;
					return true;
				}
			}
			setter = null;
			return false;
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x000FBB0C File Offset: 0x000F9D0C
		internal override long Execute(global::System.Collections.Generic.Dictionary<int, object> identifierValues, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>> generatedValues)
		{
			long result;
			using (global::System.Data.Common.DbCommand dbCommand = this.CreateCommand(identifierValues))
			{
				global::System.Data.Entity.Core.EntityClient.EntityConnection connection = base.Translator.Connection;
				dbCommand.Transaction = ((connection.CurrentTransaction == null) ? null : connection.CurrentTransaction.StoreTransaction);
				dbCommand.Connection = connection.StoreConnection;
				if (base.Translator.CommandTimeout != null)
				{
					dbCommand.CommandTimeout = base.Translator.CommandTimeout.Value;
				}
				int num;
				if (this._modificationCommandTree.HasReader)
				{
					num = 0;
					using (global::System.Data.Common.DbDataReader dbDataReader = dbCommand.ExecuteReader(global::System.Data.CommandBehavior.SequentialAccess))
					{
						if (dbDataReader.Read())
						{
							num++;
							global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> allStructuralMembers = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(base.CurrentValues.StructuralType);
							for (int i = 0; i < dbDataReader.FieldCount; i++)
							{
								string name = dbDataReader.GetName(i);
								global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = allStructuralMembers[name];
								object value;
								if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(edmMember.TypeUsage) && !dbDataReader.IsDBNull(i))
								{
									value = global::System.Data.Entity.Spatial.SpatialHelpers.GetSpatialValue(base.Translator.MetadataWorkspace, dbDataReader, edmMember.TypeUsage, i);
								}
								else
								{
									value = dbDataReader.GetValue(i);
								}
								int ordinal = allStructuralMembers.IndexOf(edmMember);
								global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult memberValue = base.CurrentValues.GetMemberValue(ordinal);
								generatedValues.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>(memberValue, value));
								int identifier = memberValue.Identifier;
								if (-1 != identifier)
								{
									identifierValues.Add(identifier, value);
								}
							}
						}
						global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReader(dbDataReader);
						goto IL_17A;
					}
				}
				num = dbCommand.ExecuteNonQuery();
				IL_17A:
				result = (long)num;
			}
			return result;
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x000FBCDC File Offset: 0x000F9EDC
		internal override async global::System.Threading.Tasks.Task<long> ExecuteAsync(global::System.Collections.Generic.Dictionary<int, object> identifierValues, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>> generatedValues, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long result;
			using (global::System.Data.Common.DbCommand command = this.CreateCommand(identifierValues))
			{
				global::System.Data.Entity.Core.EntityClient.EntityConnection connection = base.Translator.Connection;
				command.Transaction = ((connection.CurrentTransaction == null) ? null : connection.CurrentTransaction.StoreTransaction);
				command.Connection = connection.StoreConnection;
				if (base.Translator.CommandTimeout != null)
				{
					command.CommandTimeout = base.Translator.CommandTimeout.Value;
				}
				int rowsAffected;
				if (this._modificationCommandTree.HasReader)
				{
					rowsAffected = 0;
					global::System.Data.Common.DbDataReader dbDataReader = await command.ExecuteReaderAsync(global::System.Data.CommandBehavior.SequentialAccess, cancellationToken).WithCurrentCulture<global::System.Data.Common.DbDataReader>();
					using (global::System.Data.Common.DbDataReader reader = dbDataReader)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = reader.ReadAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (cultureAwaiter.GetResult())
						{
							rowsAffected++;
							global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> members = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(base.CurrentValues.StructuralType);
							for (int ordinal = 0; ordinal < reader.FieldCount; ordinal++)
							{
								global::System.Data.Entity.Core.Metadata.Edm.EdmMember member = members[reader.GetName(ordinal)];
								bool flag = global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(member.TypeUsage);
								if (flag)
								{
									cultureAwaiter = reader.IsDBNullAsync(ordinal, cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
									if (!cultureAwaiter.IsCompleted)
									{
										await cultureAwaiter;
										cultureAwaiter = cultureAwaiter2;
										cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
									}
									flag = !cultureAwaiter.GetResult();
								}
								object value = (!flag) ? (await reader.GetFieldValueAsync<object>(ordinal, cancellationToken).WithCurrentCulture<object>()) : (await global::System.Data.Entity.Spatial.SpatialHelpers.GetSpatialValueAsync(base.Translator.MetadataWorkspace, reader, member.TypeUsage, ordinal, cancellationToken).WithCurrentCulture<object>());
								int ordinal2 = members.IndexOf(member);
								global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult memberValue = base.CurrentValues.GetMemberValue(ordinal2);
								generatedValues.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>(memberValue, value));
								int identifier = memberValue.Identifier;
								if (-1 != identifier)
								{
									identifierValues.Add(identifier, value);
								}
								member = null;
							}
							members = null;
						}
						await global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReaderAsync(reader, cancellationToken).WithCurrentCulture();
					}
					global::System.Data.Common.DbDataReader reader = null;
				}
				else
				{
					rowsAffected = await command.ExecuteNonQueryAsync(cancellationToken).WithCurrentCulture<int>();
				}
				result = (long)rowsAffected;
			}
			return result;
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x000FBD3C File Offset: 0x000F9F3C
		protected virtual global::System.Data.Common.DbCommand CreateCommand(global::System.Collections.Generic.Dictionary<int, object> identifierValues)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree dbModificationCommandTree = this._modificationCommandTree;
			if (this._inputIdentifiers != null)
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause>();
				for (int i = 0; i < this._inputIdentifiers.Count; i++)
				{
					global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause> keyValuePair = this._inputIdentifiers[i];
					object value;
					if (identifierValues.TryGetValue(keyValuePair.Key, out value))
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause value2 = new global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause(keyValuePair.Value.Property, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value));
						dictionary[keyValuePair.Value] = value2;
						this._inputIdentifiers[i] = new global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause>(keyValuePair.Key, value2);
					}
				}
				dbModificationCommandTree = global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand.RebuildCommandTree(dbModificationCommandTree, dictionary);
			}
			return base.Translator.CreateCommand(dbModificationCommandTree);
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x000FBDEC File Offset: 0x000F9FEC
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree RebuildCommandTree(global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree originalTree, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause> clauseMappings)
		{
			if (clauseMappings.Count == 0)
			{
				return originalTree;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree result;
			if (originalTree.CommandTreeKind == global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Insert)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree dbInsertCommandTree = (global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree)originalTree;
				result = new global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree(dbInsertCommandTree.MetadataWorkspace, dbInsertCommandTree.DataSpace, dbInsertCommandTree.Target, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>(global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand.ReplaceClauses(dbInsertCommandTree.SetClauses, clauseMappings)), dbInsertCommandTree.Returning);
			}
			else
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree dbUpdateCommandTree = (global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree)originalTree;
				result = new global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree(dbUpdateCommandTree.MetadataWorkspace, dbUpdateCommandTree.DataSpace, dbUpdateCommandTree.Target, dbUpdateCommandTree.Predicate, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>(global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand.ReplaceClauses(dbUpdateCommandTree.SetClauses, clauseMappings)), dbUpdateCommandTree.Returning);
			}
			return result;
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x000FBE84 File Offset: 0x000FA084
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> ReplaceClauses(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> originalClauses, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause> mappings)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>(originalClauses.Count);
			for (int i = 0; i < originalClauses.Count; i++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause item;
				if (mappings.TryGetValue((global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause)originalClauses[i], out item))
				{
					list.Add(item);
				}
				else
				{
					list.Add(originalClauses[i]);
				}
			}
			return list;
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06004782 RID: 18306 RVA: 0x000FBEDB File Offset: 0x000FA0DB
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator Operator
		{
			get
			{
				return this._operator;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06004783 RID: 18307 RVA: 0x000FBEE3 File Offset: 0x000FA0E3
		internal override global::System.Data.Entity.Core.Metadata.Edm.EntitySet Table
		{
			get
			{
				return this._processor.Table;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x000FBEF0 File Offset: 0x000FA0F0
		internal override global::System.Collections.Generic.IEnumerable<int> InputIdentifiers
		{
			get
			{
				if (this._inputIdentifiers == null)
				{
					yield break;
				}
				foreach (global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause> keyValuePair in this._inputIdentifiers)
				{
					yield return keyValuePair.Key;
				}
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause>>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause>>.Enumerator);
				yield break;
				yield break;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06004785 RID: 18309 RVA: 0x000FBF00 File Offset: 0x000FA100
		internal override global::System.Collections.Generic.IEnumerable<int> OutputIdentifiers
		{
			get
			{
				if (this._outputIdentifiers == null)
				{
					return global::System.Linq.Enumerable.Empty<int>();
				}
				return this._outputIdentifiers.Keys;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x000FBF1B File Offset: 0x000FA11B
		internal override global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandKind Kind
		{
			get
			{
				return global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandKind.Dynamic;
			}
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x000FBF20 File Offset: 0x000FA120
		internal override global::System.Collections.Generic.IList<global::System.Data.Entity.Core.IEntityStateEntry> GetStateEntries(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry>(2);
			if (base.OriginalValues != null)
			{
				foreach (global::System.Data.Entity.Core.IEntityStateEntry item in global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter.GetAllStateEntries(base.OriginalValues, translator, this.Table))
				{
					list.Add(item);
				}
			}
			if (base.CurrentValues != null)
			{
				foreach (global::System.Data.Entity.Core.IEntityStateEntry item2 in global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter.GetAllStateEntries(base.CurrentValues, translator, this.Table))
				{
					list.Add(item2);
				}
			}
			return list;
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x000FBFDC File Offset: 0x000FA1DC
		internal override int CompareToType(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand otherCommand)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand dynamicUpdateCommand = (global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand)otherCommand;
			int num = (int)(this.Operator - dynamicUpdateCommand.Operator);
			if (num != 0)
			{
				return num;
			}
			num = global::System.StringComparer.Ordinal.Compare(this._processor.Table.Name, dynamicUpdateCommand._processor.Table.Name);
			if (num != 0)
			{
				return num;
			}
			num = global::System.StringComparer.Ordinal.Compare(this._processor.Table.EntityContainer.Name, dynamicUpdateCommand._processor.Table.EntityContainer.Name);
			if (num != 0)
			{
				return num;
			}
			global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = (this.Operator == global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Delete) ? base.OriginalValues : base.CurrentValues;
			global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2 = (dynamicUpdateCommand.Operator == global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Delete) ? dynamicUpdateCommand.OriginalValues : dynamicUpdateCommand.CurrentValues;
			for (int i = 0; i < this._processor.KeyOrdinals.Length; i++)
			{
				int ordinal = this._processor.KeyOrdinals[i];
				object simpleValue = propagatorResult.GetMemberValue(ordinal).GetSimpleValue();
				object simpleValue2 = propagatorResult2.GetMemberValue(ordinal).GetSimpleValue();
				num = global::System.Data.Entity.Core.Common.Utils.ByValueComparer.Default.Compare(simpleValue, simpleValue2);
				if (num != 0)
				{
					return num;
				}
			}
			for (int j = 0; j < this._processor.KeyOrdinals.Length; j++)
			{
				int ordinal2 = this._processor.KeyOrdinals[j];
				int identifier = propagatorResult.GetMemberValue(ordinal2).Identifier;
				int identifier2 = propagatorResult2.GetMemberValue(ordinal2).Identifier;
				num = identifier - identifier2;
				if (num != 0)
				{
					return num;
				}
			}
			return num;
		}

		// Token: 0x0400195E RID: 6494
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator _operator;

		// Token: 0x0400195F RID: 6495
		private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor _processor;

		// Token: 0x04001960 RID: 6496
		private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause>> _inputIdentifiers;

		// Token: 0x04001961 RID: 6497
		private readonly global::System.Collections.Generic.Dictionary<int, string> _outputIdentifiers;

		// Token: 0x04001962 RID: 6498
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree _modificationCommandTree;
	}
}
