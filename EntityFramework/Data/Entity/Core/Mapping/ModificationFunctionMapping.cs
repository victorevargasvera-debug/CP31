using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200054E RID: 1358
	public sealed class ModificationFunctionMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x060042CF RID: 17103 RVA: 0x000E4F84 File Offset: 0x000E3184
		public ModificationFunctionMapping(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> parameterBindings, global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter rowsAffectedParameter, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> resultBindings)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(entitySet, "entitySet");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(function, "function");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>>(parameterBindings, "parameterBindings");
			this._function = function;
			this._rowsAffectedParameter = rowsAffectedParameter;
			this._parameterBindings = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>(parameterBindings.ToList<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>());
			if (resultBindings != null)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> list = resultBindings.ToList<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding>();
				if (0 < list.Count)
				{
					this._resultBindings = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding>(list);
				}
			}
			this._collocatedAssociationSetEnds = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping.GetReferencedAssociationSetEnds(entitySet as global::System.Data.Entity.Core.Metadata.Edm.EntitySet, entityType as global::System.Data.Entity.Core.Metadata.Edm.EntityType, parameterBindings).ToList<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>());
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060042D0 RID: 17104 RVA: 0x000E5021 File Offset: 0x000E3221
		// (set) Token: 0x060042D1 RID: 17105 RVA: 0x000E5029 File Offset: 0x000E3229
		public global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter RowsAffectedParameter
		{
			get
			{
				return this._rowsAffectedParameter;
			}
			internal set
			{
				this._rowsAffectedParameter = value;
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060042D2 RID: 17106 RVA: 0x000E5032 File Offset: 0x000E3232
		internal string RowsAffectedParameterName
		{
			get
			{
				if (this.RowsAffectedParameter == null)
				{
					return null;
				}
				return this.RowsAffectedParameter.Name;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060042D3 RID: 17107 RVA: 0x000E5049 File Offset: 0x000E3249
		public global::System.Data.Entity.Core.Metadata.Edm.EdmFunction Function
		{
			get
			{
				return this._function;
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060042D4 RID: 17108 RVA: 0x000E5051 File Offset: 0x000E3251
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> ParameterBindings
		{
			get
			{
				return this._parameterBindings;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060042D5 RID: 17109 RVA: 0x000E5059 File Offset: 0x000E3259
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> CollocatedAssociationSetEnds
		{
			get
			{
				return this._collocatedAssociationSetEnds;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060042D6 RID: 17110 RVA: 0x000E5061 File Offset: 0x000E3261
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> ResultBindings
		{
			get
			{
				return this._resultBindings;
			}
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x000E5069 File Offset: 0x000E3269
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Func{{{0}}}: Prm={{{1}}}, Result={{{2}}}", new object[]
			{
				this.Function,
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedStringSorted(this.ParameterBindings),
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedStringSorted(this.ResultBindings)
			});
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x000E50A5 File Offset: 0x000E32A5
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._parameterBindings);
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._resultBindings);
			base.SetReadOnly();
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x000E50C4 File Offset: 0x000E32C4
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> GetReferencedAssociationSetEnds(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> parameterBindings)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>();
			if (entitySet != null && entityType != null)
			{
				foreach (global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding in parameterBindings)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = modificationFunctionParameterBinding.MemberPath.AssociationSetEnd;
					if (associationSetEnd != null)
					{
						hashSet.Add(associationSetEnd);
					}
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in entitySet.AssociationSets)
				{
					global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> referentialConstraints = associationSet.ElementType.ReferentialConstraints;
					if (referentialConstraints != null)
					{
						foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in referentialConstraints)
						{
							if (associationSet.AssociationSetEnds[referentialConstraint.ToRole.Name].EntitySet == entitySet && referentialConstraint.ToRole.GetEntityType().IsAssignableFrom(entityType))
							{
								hashSet.Add(associationSet.AssociationSetEnds[referentialConstraint.FromRole.Name]);
							}
						}
					}
				}
			}
			return hashSet;
		}

		// Token: 0x04001782 RID: 6018
		private global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter _rowsAffectedParameter;

		// Token: 0x04001783 RID: 6019
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmFunction _function;

		// Token: 0x04001784 RID: 6020
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> _parameterBindings;

		// Token: 0x04001785 RID: 6021
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd> _collocatedAssociationSetEnds;

		// Token: 0x04001786 RID: 6022
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> _resultBindings;
	}
}
