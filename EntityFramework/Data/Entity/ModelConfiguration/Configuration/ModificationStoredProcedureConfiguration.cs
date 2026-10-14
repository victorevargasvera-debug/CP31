using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001D9 RID: 473
	internal class ModificationStoredProcedureConfiguration
	{
		// Token: 0x060018C3 RID: 6339 RVA: 0x00041B91 File Offset: 0x0003FD91
		public ModificationStoredProcedureConfiguration()
		{
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00041BB0 File Offset: 0x0003FDB0
		private ModificationStoredProcedureConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration source)
		{
			this._name = source._name;
			this._schema = source._schema;
			this._rowsAffectedParameter = source._rowsAffectedParameter;
			source._parameterNames.Each(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey, global::System.Tuple<string, string>> c)
			{
				this._parameterNames.Add(c.Key, global::System.Tuple.Create<string, string>(c.Value.Item1, c.Value.Item2));
			});
			source._resultBindings.Each(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, string> r)
			{
				this._resultBindings.Add(r.Key, r.Value);
			});
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00041C2B File Offset: 0x0003FE2B
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration(this);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00041C34 File Offset: 0x0003FE34
		public void HasName(string name)
		{
			global::System.Data.Entity.Utilities.DatabaseName databaseName = global::System.Data.Entity.Utilities.DatabaseName.Parse(name);
			this._name = databaseName.Name;
			this._schema = databaseName.Schema;
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00041C60 File Offset: 0x0003FE60
		public void HasName(string name, string schema)
		{
			this._name = name;
			this._schema = schema;
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x00041C70 File Offset: 0x0003FE70
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x00041C78 File Offset: 0x0003FE78
		public string Schema
		{
			get
			{
				return this._schema;
			}
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00041C80 File Offset: 0x0003FE80
		public void RowsAffectedParameter(string name)
		{
			this._rowsAffectedParameter = name;
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x00041C89 File Offset: 0x0003FE89
		public string RowsAffectedParameterName
		{
			get
			{
				return this._rowsAffectedParameter;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00041C91 File Offset: 0x0003FE91
		public global::System.Collections.Generic.IEnumerable<global::System.Tuple<string, string>> ParameterNames
		{
			get
			{
				return this._parameterNames.Values;
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00041C9E File Offset: 0x0003FE9E
		public void ClearParameterNames()
		{
			this._parameterNames.Clear();
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x00041CAB File Offset: 0x0003FEAB
		public global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, string> ResultBindings
		{
			get
			{
				return this._resultBindings;
			}
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00041CB3 File Offset: 0x0003FEB3
		public void Parameter(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath, string parameterName, string originalValueParameterName = null, bool rightKey = false)
		{
			this._parameterNames[new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey(propertyPath, rightKey)] = global::System.Tuple.Create<string, string>(parameterName, originalValueParameterName);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00041CCF File Offset: 0x0003FECF
		public void Result(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath, string columnName)
		{
			this._resultBindings[propertyPath.Single<global::System.Reflection.PropertyInfo>()] = columnName;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00041CE3 File Offset: 0x0003FEE3
		public virtual void Configure(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationStoredProcedureMapping, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			this._configuredParameters = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>();
			this.ConfigureName(modificationStoredProcedureMapping);
			this.ConfigureSchema(modificationStoredProcedureMapping);
			this.ConfigureRowsAffectedParameter(modificationStoredProcedureMapping, providerManifest);
			this.ConfigureParameters(modificationStoredProcedureMapping);
			this.ConfigureResultBindings(modificationStoredProcedureMapping);
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00041D14 File Offset: 0x0003FF14
		private void ConfigureName(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationStoredProcedureMapping)
		{
			if (!string.IsNullOrWhiteSpace(this._name))
			{
				modificationStoredProcedureMapping.Function.StoreFunctionNameAttribute = this._name;
			}
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00041D34 File Offset: 0x0003FF34
		private void ConfigureSchema(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationStoredProcedureMapping)
		{
			if (!string.IsNullOrWhiteSpace(this._schema))
			{
				modificationStoredProcedureMapping.Function.Schema = this._schema;
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00041D54 File Offset: 0x0003FF54
		private void ConfigureRowsAffectedParameter(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationStoredProcedureMapping, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			if (!string.IsNullOrWhiteSpace(this._rowsAffectedParameter))
			{
				if (modificationStoredProcedureMapping.RowsAffectedParameter == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter("_RowsAffected_", providerManifest.GetStoreType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32))), global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.Out);
					modificationStoredProcedureMapping.Function.AddParameter(functionParameter);
					modificationStoredProcedureMapping.RowsAffectedParameter = functionParameter;
				}
				modificationStoredProcedureMapping.RowsAffectedParameter.Name = this._rowsAffectedParameter;
				this._configuredParameters.Add(modificationStoredProcedureMapping.RowsAffectedParameter);
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00041DCC File Offset: 0x0003FFCC
		private void ConfigureParameters(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationStoredProcedureMapping)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey, global::System.Tuple<string, string>> keyValuePair in this._parameterNames)
			{
				global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath = keyValuePair.Key.PropertyPath;
				string item = keyValuePair.Value.Item1;
				string item2 = keyValuePair.Value.Item2;
				global::System.Func<global::System.Reflection.PropertyInfo, bool> <>9__4;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> list = modificationStoredProcedureMapping.ParameterBindings.Where(delegate(global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding pb)
				{
					if (pb.MemberPath.AssociationSetEnd == null || pb.MemberPath.AssociationSetEnd.ParentAssociationSet.ElementType.IsManyToMany())
					{
						if (propertyPath.Equals(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(from m in pb.MemberPath.Members.OfType<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>()
						select m.GetClrPropertyInfo())))
						{
							return true;
						}
					}
					if (propertyPath.Count == 2 && pb.MemberPath.AssociationSetEnd != null && pb.MemberPath.Members.First<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>().GetClrPropertyInfo().IsSameAs(propertyPath.Last<global::System.Reflection.PropertyInfo>()))
					{
						global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> source = from ae in pb.MemberPath.AssociationSetEnd.ParentAssociationSet.AssociationSetEnds
						select ae.CorrespondingAssociationEndMember.GetClrPropertyInfo() into pi
						where pi != null
						select pi;
						global::System.Func<global::System.Reflection.PropertyInfo, bool> predicate;
						if ((predicate = <>9__4) == null)
						{
							predicate = (<>9__4 = ((global::System.Reflection.PropertyInfo pi) => pi.IsSameAs(propertyPath.First<global::System.Reflection.PropertyInfo>())));
						}
						return source.Any(predicate);
					}
					return false;
				}).ToList<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>();
				if (list.Count == 1)
				{
					global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding = list.Single<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>();
					if (!string.IsNullOrWhiteSpace(item2) && modificationFunctionParameterBinding.IsCurrent)
					{
						throw global::System.Data.Entity.Resources.Error.ModificationFunctionParameterNotFoundOriginal(propertyPath, modificationStoredProcedureMapping.Function.FunctionName);
					}
					modificationFunctionParameterBinding.Parameter.Name = item;
					this._configuredParameters.Add(modificationFunctionParameterBinding.Parameter);
				}
				else
				{
					if (list.Count == 2)
					{
						if ((from pb in list
						select pb.IsCurrent).Distinct<bool>().Count<bool>() != 1)
						{
							goto IL_132;
						}
						if (!list.All((global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding pb) => pb.MemberPath.AssociationSetEnd != null))
						{
							goto IL_132;
						}
						global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding2 = (!keyValuePair.Key.IsRightKey) ? list.First<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>() : list.Last<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>();
						IL_178:
						global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding3 = modificationFunctionParameterBinding2;
						modificationFunctionParameterBinding3.Parameter.Name = item;
						this._configuredParameters.Add(modificationFunctionParameterBinding3.Parameter);
						if (!string.IsNullOrWhiteSpace(item2))
						{
							modificationFunctionParameterBinding3 = list.Single((global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding pb) => !pb.IsCurrent);
							modificationFunctionParameterBinding3.Parameter.Name = item2;
							this._configuredParameters.Add(modificationFunctionParameterBinding3.Parameter);
							continue;
						}
						continue;
						IL_132:
						modificationFunctionParameterBinding2 = list.Single((global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding pb) => pb.IsCurrent);
						goto IL_178;
					}
					throw global::System.Data.Entity.Resources.Error.ModificationFunctionParameterNotFound(propertyPath, modificationStoredProcedureMapping.Function.FunctionName);
				}
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in modificationStoredProcedureMapping.Function.Parameters.Except(this._configuredParameters))
			{
				functionParameter.Name = modificationStoredProcedureMapping.Function.Parameters.Except(new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[]
				{
					functionParameter
				}).UniquifyName(functionParameter.Name);
			}
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0004209C File Offset: 0x0004029C
		private void ConfigureResultBindings(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping modificationStoredProcedureMapping)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, string> keyValuePair in this._resultBindings)
			{
				global::System.Reflection.PropertyInfo propertyInfo = keyValuePair.Key;
				string value = keyValuePair.Value;
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> resultBindings = modificationStoredProcedureMapping.ResultBindings;
				global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding modificationFunctionResultBinding = (resultBindings ?? global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding>()).SingleOrDefault((global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding rb) => propertyInfo.IsSameAs(rb.Property.GetClrPropertyInfo()));
				if (modificationFunctionResultBinding == null)
				{
					throw global::System.Data.Entity.Resources.Error.ResultBindingNotFound(propertyInfo.Name, modificationStoredProcedureMapping.Function.FunctionName);
				}
				modificationFunctionResultBinding.ColumnName = value;
			}
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0004214C File Offset: 0x0004034C
		public bool IsCompatibleWith(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration other)
		{
			if (this._name != null && other._name != null && !string.Equals(this._name, other._name, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			if (this._schema != null && other._schema != null && !string.Equals(this._schema, other._schema, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			return !(from kv1 in this._parameterNames
			join kv2 in other._parameterNames on kv1.Key equals kv2.Key
			select !object.Equals(kv1.Value, kv2.Value)).Any((bool j) => j);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0004223C File Offset: 0x0004043C
		public void Merge(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration modificationStoredProcedureConfiguration, bool allowOverride)
		{
			if (allowOverride || string.IsNullOrWhiteSpace(this._name))
			{
				this._name = (modificationStoredProcedureConfiguration.Name ?? this._name);
			}
			if (allowOverride || string.IsNullOrWhiteSpace(this._schema))
			{
				this._schema = (modificationStoredProcedureConfiguration.Schema ?? this._schema);
			}
			if (allowOverride || string.IsNullOrWhiteSpace(this._rowsAffectedParameter))
			{
				this._rowsAffectedParameter = (modificationStoredProcedureConfiguration.RowsAffectedParameterName ?? this._rowsAffectedParameter);
			}
			global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey, global::System.Tuple<string, string>>> parameterNames = modificationStoredProcedureConfiguration._parameterNames;
			global::System.Func<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey, global::System.Tuple<string, string>>, bool> <>9__0;
			global::System.Func<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey, global::System.Tuple<string, string>>, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey, global::System.Tuple<string, string>> parameterName) => allowOverride || !this._parameterNames.ContainsKey(parameterName.Key)));
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey, global::System.Tuple<string, string>> keyValuePair in parameterNames.Where(predicate))
			{
				this._parameterNames[keyValuePair.Key] = keyValuePair.Value;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, string>> resultBindings = modificationStoredProcedureConfiguration.ResultBindings;
			global::System.Func<global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, string>, bool> <>9__1;
			global::System.Func<global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, string>, bool> predicate2;
			if ((predicate2 = <>9__1) == null)
			{
				predicate2 = (<>9__1 = ((global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, string> resultBinding) => allowOverride || !this._resultBindings.ContainsKey(resultBinding.Key)));
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, string> keyValuePair2 in resultBindings.Where(predicate2))
			{
				this._resultBindings[keyValuePair2.Key] = keyValuePair2.Value;
			}
		}

		// Token: 0x04000A69 RID: 2665
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey, global::System.Tuple<string, string>> _parameterNames = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey, global::System.Tuple<string, string>>();

		// Token: 0x04000A6A RID: 2666
		private readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, string> _resultBindings = new global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, string>();

		// Token: 0x04000A6B RID: 2667
		private string _name;

		// Token: 0x04000A6C RID: 2668
		private string _schema;

		// Token: 0x04000A6D RID: 2669
		private string _rowsAffectedParameter;

		// Token: 0x04000A6E RID: 2670
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> _configuredParameters;

		// Token: 0x020008AC RID: 2220
		private sealed class ParameterKey
		{
			// Token: 0x06005BB6 RID: 23478 RVA: 0x0013DC6E File Offset: 0x0013BE6E
			public ParameterKey(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath, bool rightKey)
			{
				this._propertyPath = propertyPath;
				this._rightKey = rightKey;
			}

			// Token: 0x17001075 RID: 4213
			// (get) Token: 0x06005BB7 RID: 23479 RVA: 0x0013DC84 File Offset: 0x0013BE84
			public global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath PropertyPath
			{
				get
				{
					return this._propertyPath;
				}
			}

			// Token: 0x17001076 RID: 4214
			// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x0013DC8C File Offset: 0x0013BE8C
			public bool IsRightKey
			{
				get
				{
					return this._rightKey;
				}
			}

			// Token: 0x06005BB9 RID: 23481 RVA: 0x0013DC94 File Offset: 0x0013BE94
			public override bool Equals(object obj)
			{
				if (obj == null)
				{
					return false;
				}
				if (this == obj)
				{
					return true;
				}
				global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey parameterKey = (global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration.ParameterKey)obj;
				return this._propertyPath.Equals(parameterKey._propertyPath) && this._rightKey.Equals(parameterKey._rightKey);
			}

			// Token: 0x06005BBA RID: 23482 RVA: 0x0013DCDC File Offset: 0x0013BEDC
			public override int GetHashCode()
			{
				return this._propertyPath.GetHashCode() * 397 ^ this._rightKey.GetHashCode();
			}

			// Token: 0x040023DF RID: 9183
			private readonly global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath _propertyPath;

			// Token: 0x040023E0 RID: 9184
			private readonly bool _rightKey;
		}
	}
}
