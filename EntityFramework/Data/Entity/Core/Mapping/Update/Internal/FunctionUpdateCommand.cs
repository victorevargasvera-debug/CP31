using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005C8 RID: 1480
	internal class FunctionUpdateCommand : global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand
	{
		// Token: 0x06004794 RID: 18324 RVA: 0x000FC731 File Offset: 0x000FA931
		internal FunctionUpdateCommand(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping functionMapping, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.IEntityStateEntry> stateEntries, global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry stateEntry) : this(translator, stateEntries, stateEntry, translator.GenerateCommandDefinition(functionMapping).CreateCommand())
		{
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x000FC749 File Offset: 0x000FA949
		protected FunctionUpdateCommand(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.IEntityStateEntry> stateEntries, global::System.Data.Entity.Core.Mapping.Update.Internal.ExtractedStateEntry stateEntry, global::System.Data.Common.DbCommand dbCommand) : base(translator, stateEntry.Original, stateEntry.Current)
		{
			this._stateEntries = stateEntries;
			this._dbCommand = new global::System.Data.Entity.Internal.InterceptableDbCommand(dbCommand, translator.InterceptionContext, null);
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x000FC779 File Offset: 0x000FA979
		// (set) Token: 0x06004797 RID: 18327 RVA: 0x000FC781 File Offset: 0x000FA981
		protected virtual global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> ResultColumns { get; set; }

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x000FC78A File Offset: 0x000FA98A
		internal override global::System.Collections.Generic.IEnumerable<int> InputIdentifiers
		{
			get
			{
				if (this._inputIdentifiers == null)
				{
					yield break;
				}
				foreach (global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Common.DbParameter> keyValuePair in this._inputIdentifiers)
				{
					yield return keyValuePair.Key;
				}
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Common.DbParameter>>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Common.DbParameter>>.Enumerator);
				yield break;
				yield break;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06004799 RID: 18329 RVA: 0x000FC79A File Offset: 0x000FA99A
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

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x000FC7B5 File Offset: 0x000FA9B5
		internal override global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandKind Kind
		{
			get
			{
				return global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommandKind.Function;
			}
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x000FC7B8 File Offset: 0x000FA9B8
		internal override global::System.Collections.Generic.IList<global::System.Data.Entity.Core.IEntityStateEntry> GetStateEntries(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator)
		{
			return this._stateEntries;
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x000FC7C0 File Offset: 0x000FA9C0
		internal void SetParameterValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result, global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding parameterBinding, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator)
		{
			global::System.Data.Common.DbParameter dbParameter = this._dbCommand.Parameters[parameterBinding.Parameter.Name];
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = parameterBinding.Parameter.TypeUsage;
			object principalValue = translator.KeyManager.GetPrincipalValue(result);
			translator.SetParameterValue(dbParameter, typeUsage, principalValue);
			int identifier = result.Identifier;
			if (-1 != identifier)
			{
				if (this._inputIdentifiers == null)
				{
					this._inputIdentifiers = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Common.DbParameter>>(2);
				}
				foreach (int key in translator.KeyManager.GetPrincipals(identifier))
				{
					this._inputIdentifiers.Add(new global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Common.DbParameter>(key, dbParameter));
				}
			}
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x000FC884 File Offset: 0x000FAA84
		internal void RegisterRowsAffectedParameter(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter rowsAffectedParameter)
		{
			if (rowsAffectedParameter != null)
			{
				this._rowsAffectedParameter = this._dbCommand.Parameters[rowsAffectedParameter.Name];
			}
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x000FC8A8 File Offset: 0x000FAAA8
		internal void AddResultColumn(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, string columnName, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult result)
		{
			if (this.ResultColumns == null)
			{
				this.ResultColumns = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>>(2);
			}
			this.ResultColumns.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(columnName, result));
			int identifier = result.Identifier;
			if (-1 != identifier)
			{
				if (translator.KeyManager.HasPrincipals(identifier))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Update_GeneratedDependent(columnName));
				}
				this.AddOutputIdentifier(columnName, identifier);
			}
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x000FC908 File Offset: 0x000FAB08
		private void AddOutputIdentifier(string columnName, int identifier)
		{
			if (this._outputIdentifiers == null)
			{
				this._outputIdentifiers = new global::System.Collections.Generic.Dictionary<int, string>(2);
			}
			this._outputIdentifiers[identifier] = columnName;
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x000FC92C File Offset: 0x000FAB2C
		internal virtual void SetInputIdentifiers(global::System.Collections.Generic.Dictionary<int, object> identifierValues)
		{
			if (this._inputIdentifiers != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Common.DbParameter> keyValuePair in this._inputIdentifiers)
				{
					object value;
					if (identifierValues.TryGetValue(keyValuePair.Key, out value))
					{
						keyValuePair.Value.Value = value;
					}
				}
			}
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x000FC9A0 File Offset: 0x000FABA0
		internal override long Execute(global::System.Collections.Generic.Dictionary<int, object> identifierValues, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>> generatedValues)
		{
			global::System.Data.Entity.Core.EntityClient.EntityConnection connection = base.Translator.Connection;
			this._dbCommand.Transaction = ((connection.CurrentTransaction == null) ? null : connection.CurrentTransaction.StoreTransaction);
			this._dbCommand.Connection = connection.StoreConnection;
			if (base.Translator.CommandTimeout != null)
			{
				this._dbCommand.CommandTimeout = base.Translator.CommandTimeout.Value;
			}
			this.SetInputIdentifiers(identifierValues);
			long num;
			if (this.ResultColumns != null)
			{
				num = 0L;
				global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> allStructuralMembers = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(base.CurrentValues.StructuralType);
				using (global::System.Data.Common.DbDataReader reader = this._dbCommand.ExecuteReader(global::System.Data.CommandBehavior.SequentialAccess))
				{
					if (reader.Read())
					{
						num += 1L;
						global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> resultColumns = this.ResultColumns;
						global::System.Func<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>, global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> <>9__0;
						global::System.Func<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>, global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> selector;
						if ((selector = <>9__0) == null)
						{
							selector = (<>9__0 = ((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> r) => new global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(this.GetColumnOrdinal(this.Translator, reader, r.Key), r.Value)));
						}
						foreach (global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> keyValuePair in from r in resultColumns.Select(selector)
						orderby r.Key
						select r)
						{
							int key = keyValuePair.Key;
							if (key == -1)
							{
								break;
							}
							global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = allStructuralMembers[keyValuePair.Value.RecordOrdinal].TypeUsage;
							object value;
							if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(typeUsage) && !reader.IsDBNull(key))
							{
								value = global::System.Data.Entity.Spatial.SpatialHelpers.GetSpatialValue(base.Translator.MetadataWorkspace, reader, typeUsage, key);
							}
							else
							{
								value = reader.GetValue(key);
							}
							global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult value2 = keyValuePair.Value;
							generatedValues.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>(value2, value));
							int identifier = value2.Identifier;
							if (-1 != identifier)
							{
								identifierValues.Add(identifier, value);
							}
						}
					}
					global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReader(reader);
					goto IL_21C;
				}
			}
			num = (long)this._dbCommand.ExecuteNonQuery();
			IL_21C:
			return this.GetRowsAffected(num, base.Translator);
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x000FCC0C File Offset: 0x000FAE0C
		internal override async global::System.Threading.Tasks.Task<long> ExecuteAsync(global::System.Collections.Generic.Dictionary<int, object> identifierValues, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>> generatedValues, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand.<>c__DisplayClass24_0 CS$<>8__locals1 = new global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand.<>c__DisplayClass24_0();
			CS$<>8__locals1.<>4__this = this;
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Core.EntityClient.EntityConnection connection = base.Translator.Connection;
			this._dbCommand.Transaction = ((connection.CurrentTransaction == null) ? null : connection.CurrentTransaction.StoreTransaction);
			this._dbCommand.Connection = connection.StoreConnection;
			if (base.Translator.CommandTimeout != null)
			{
				this._dbCommand.CommandTimeout = base.Translator.CommandTimeout.Value;
			}
			this.SetInputIdentifiers(identifierValues);
			long rowsAffected;
			if (this.ResultColumns != null)
			{
				rowsAffected = 0L;
				global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> members = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(base.CurrentValues.StructuralType);
				global::System.Data.Common.DbDataReader reader = await this._dbCommand.ExecuteReaderAsync(global::System.Data.CommandBehavior.SequentialAccess, cancellationToken).WithCurrentCulture<global::System.Data.Common.DbDataReader>();
				CS$<>8__locals1.reader = reader;
				try
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = CS$<>8__locals1.reader.ReadAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (cultureAwaiter.GetResult())
					{
						rowsAffected += 1L;
						global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> resultColumns = this.ResultColumns;
						global::System.Func<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>, global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> selector;
						if ((selector = CS$<>8__locals1.<>9__0) == null)
						{
							global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand.<>c__DisplayClass24_0 CS$<>8__locals2 = CS$<>8__locals1;
							global::System.Func<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>, global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> func = (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> r) => new global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(CS$<>8__locals1.<>4__this.GetColumnOrdinal(CS$<>8__locals1.<>4__this.Translator, CS$<>8__locals1.reader, r.Key), r.Value);
							CS$<>8__locals2.<>9__0 = func;
							selector = func;
						}
						foreach (global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> resultColumn in from r in resultColumns.Select(selector)
						orderby r.Key
						select r)
						{
							int columnOrdinal = resultColumn.Key;
							global::System.Data.Entity.Core.Metadata.Edm.TypeUsage columnType = members[resultColumn.Value.RecordOrdinal].TypeUsage;
							bool flag = global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(columnType);
							if (flag)
							{
								cultureAwaiter = CS$<>8__locals1.reader.IsDBNullAsync(columnOrdinal, cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
								if (!cultureAwaiter.IsCompleted)
								{
									await cultureAwaiter;
									cultureAwaiter = cultureAwaiter2;
									cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
								}
								flag = !cultureAwaiter.GetResult();
							}
							object value = (!flag) ? (await CS$<>8__locals1.reader.GetFieldValueAsync<object>(columnOrdinal, cancellationToken).WithCurrentCulture<object>()) : (await global::System.Data.Entity.Spatial.SpatialHelpers.GetSpatialValueAsync(base.Translator.MetadataWorkspace, CS$<>8__locals1.reader, columnType, columnOrdinal, cancellationToken).WithCurrentCulture<object>());
							global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult value2 = resultColumn.Value;
							generatedValues.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, object>(value2, value));
							int identifier = value2.Identifier;
							if (-1 != identifier)
							{
								identifierValues.Add(identifier, value);
							}
							columnType = null;
							resultColumn = default(global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>);
						}
						global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>> enumerator = null;
					}
					await global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReaderAsync(CS$<>8__locals1.reader, cancellationToken).WithCurrentCulture();
				}
				finally
				{
					if (CS$<>8__locals1.reader != null)
					{
						((global::System.IDisposable)CS$<>8__locals1.reader).Dispose();
					}
				}
				members = null;
			}
			else
			{
				rowsAffected = await this._dbCommand.ExecuteNonQueryAsync(cancellationToken).WithCurrentCulture<int>();
			}
			return this.GetRowsAffected(rowsAffected, base.Translator);
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x000FCC6C File Offset: 0x000FAE6C
		protected virtual long GetRowsAffected(long rowsAffected, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator)
		{
			if (this._rowsAffectedParameter != null)
			{
				if (global::System.DBNull.Value.Equals(this._rowsAffectedParameter.Value))
				{
					rowsAffected = 0L;
				}
				else
				{
					try
					{
						rowsAffected = global::System.Convert.ToInt64(this._rowsAffectedParameter.Value, global::System.Globalization.CultureInfo.InvariantCulture);
					}
					catch (global::System.Exception ex)
					{
						if (ex.RequiresContext())
						{
							throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_UnableToConvertRowsAffectedParameter(this._rowsAffectedParameter.ParameterName, typeof(long).FullName), ex, this.GetStateEntries(translator).Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
						}
						throw;
					}
				}
			}
			return rowsAffected;
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x000FCD0C File Offset: 0x000FAF0C
		private int GetColumnOrdinal(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator, global::System.Data.Common.DbDataReader reader, string columnName)
		{
			int ordinal;
			try
			{
				ordinal = reader.GetOrdinal(columnName);
			}
			catch (global::System.IndexOutOfRangeException)
			{
				throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_MissingResultColumn(columnName), null, this.GetStateEntries(translator).Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
			}
			return ordinal;
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x000FCD54 File Offset: 0x000FAF54
		private static global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator GetModificationOperator(global::System.Data.Entity.EntityState state)
		{
			if (state <= global::System.Data.Entity.EntityState.Added)
			{
				if (state != global::System.Data.Entity.EntityState.Unchanged)
				{
					if (state != global::System.Data.Entity.EntityState.Added)
					{
						return global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update;
					}
					return global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert;
				}
			}
			else if (state == global::System.Data.Entity.EntityState.Deleted)
			{
				return global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Delete;
			}
			return global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update;
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x000FCD74 File Offset: 0x000FAF74
		internal override int CompareToType(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand otherCommand)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand functionUpdateCommand = (global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand)otherCommand;
			global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry = this._stateEntries[0];
			global::System.Data.Entity.Core.IEntityStateEntry entityStateEntry2 = functionUpdateCommand._stateEntries[0];
			int num = (int)(global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand.GetModificationOperator(entityStateEntry.State) - global::System.Data.Entity.Core.Mapping.Update.Internal.FunctionUpdateCommand.GetModificationOperator(entityStateEntry2.State));
			if (num != 0)
			{
				return num;
			}
			num = global::System.StringComparer.Ordinal.Compare(entityStateEntry.EntitySet.Name, entityStateEntry2.EntitySet.Name);
			if (num != 0)
			{
				return num;
			}
			num = global::System.StringComparer.Ordinal.Compare(entityStateEntry.EntitySet.EntityContainer.Name, entityStateEntry2.EntitySet.EntityContainer.Name);
			if (num != 0)
			{
				return num;
			}
			int num2 = (this._inputIdentifiers == null) ? 0 : this._inputIdentifiers.Count;
			int num3 = (functionUpdateCommand._inputIdentifiers == null) ? 0 : functionUpdateCommand._inputIdentifiers.Count;
			num = num2 - num3;
			if (num != 0)
			{
				return num;
			}
			for (int i = 0; i < num2; i++)
			{
				global::System.Data.Common.DbParameter value = this._inputIdentifiers[i].Value;
				global::System.Data.Common.DbParameter value2 = functionUpdateCommand._inputIdentifiers[i].Value;
				num = global::System.Data.Entity.Core.Common.Utils.ByValueComparer.Default.Compare(value.Value, value2.Value);
				if (num != 0)
				{
					return num;
				}
			}
			for (int j = 0; j < num2; j++)
			{
				int key = this._inputIdentifiers[j].Key;
				int key2 = functionUpdateCommand._inputIdentifiers[j].Key;
				num = key - key2;
				if (num != 0)
				{
					return num;
				}
			}
			return num;
		}

		// Token: 0x0400196A RID: 6506
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.IEntityStateEntry> _stateEntries;

		// Token: 0x0400196B RID: 6507
		private readonly global::System.Data.Common.DbCommand _dbCommand;

		// Token: 0x0400196C RID: 6508
		private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, global::System.Data.Common.DbParameter>> _inputIdentifiers;

		// Token: 0x0400196D RID: 6509
		private global::System.Collections.Generic.Dictionary<int, string> _outputIdentifiers;

		// Token: 0x0400196E RID: 6510
		private global::System.Data.Common.DbParameter _rowsAffectedParameter;
	}
}
