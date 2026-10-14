using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006F4 RID: 1780
	internal sealed class DbExpressionValidator : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionRebinder
	{
		// Token: 0x060052D7 RID: 21207 RVA: 0x001285D4 File Offset: 0x001267D4
		internal DbExpressionValidator(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace expectedDataSpace) : base(metadata)
		{
			this.requiredSpace = expectedDataSpace;
			this.allowedFunctionSpaces = new global::System.Data.Entity.Core.Metadata.Edm.DataSpace[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace,
				global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace
			};
			if (expectedDataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace)
			{
				this.allowedMetadataSpaces = new global::System.Data.Entity.Core.Metadata.Edm.DataSpace[]
				{
					global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace,
					global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace
				};
				return;
			}
			this.allowedMetadataSpaces = new global::System.Data.Entity.Core.Metadata.Edm.DataSpace[]
			{
				global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace
			};
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x00128642 File Offset: 0x00126842
		internal global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> Parameters
		{
			get
			{
				return this.paramMappings;
			}
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x0012864A File Offset: 0x0012684A
		internal void ValidateExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, string argumentName)
		{
			this.expressionArgumentName = argumentName;
			this.VisitExpression(expression);
			this.expressionArgumentName = null;
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00128662 File Offset: 0x00126862
		protected override global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase VisitEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet)
		{
			return this.ValidateMetadata<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(entitySet, new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(base.VisitEntitySet), (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase es) => es.EntityContainer.DataSpace, this.allowedMetadataSpaces);
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x0012869C File Offset: 0x0012689C
		protected override global::System.Data.Entity.Core.Metadata.Edm.EdmFunction VisitFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			return this.ValidateMetadata<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(function, new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(base.VisitFunction), (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction func) => func.DataSpace, this.allowedFunctionSpaces);
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x001286D6 File Offset: 0x001268D6
		protected override global::System.Data.Entity.Core.Metadata.Edm.EdmType VisitType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return this.ValidateMetadata<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(type, new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType>(base.VisitType), (global::System.Data.Entity.Core.Metadata.Edm.EdmType et) => et.DataSpace, this.allowedMetadataSpaces);
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x00128710 File Offset: 0x00126910
		protected override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage VisitTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return this.ValidateMetadata<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(type, new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(base.VisitTypeUsage), (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage tu) => tu.EdmType.DataSpace, this.allowedMetadataSpaces);
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x0012874C File Offset: 0x0012694C
		protected override void OnEnterScope(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> scopeVariables)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> item = scopeVariables.ToDictionary((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression var) => var.VariableName, (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression var) => var.ResultType, global::System.StringComparer.Ordinal);
			this.variableScopes.Push(item);
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x001287AF File Offset: 0x001269AF
		protected override void OnExitScope()
		{
			this.variableScopes.Pop();
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x001287C0 File Offset: 0x001269C0
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = base.Visit(expression);
			if (dbExpression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)dbExpression;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = null;
				using (global::System.Collections.Generic.Stack<global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>.Enumerator enumerator = this.variableScopes.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.TryGetValue(dbVariableReferenceExpression.VariableName, out typeUsage))
						{
							break;
						}
					}
				}
				if (typeUsage == null)
				{
					this.ThrowInvalid(global::System.Data.Entity.Resources.Strings.Cqt_Validator_VarRefInvalid(dbVariableReferenceExpression.VariableName));
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqual(dbVariableReferenceExpression.ResultType, typeUsage))
				{
					this.ThrowInvalid(global::System.Data.Entity.Resources.Strings.Cqt_Validator_VarRefTypeMismatch(dbVariableReferenceExpression.VariableName));
				}
			}
			return dbExpression;
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x00128878 File Offset: 0x00126A78
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(expression, "expression");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = base.Visit(expression);
			if (dbExpression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression dbParameterReferenceExpression = dbExpression as global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression;
				global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression dbParameterReferenceExpression2;
				if (this.paramMappings.TryGetValue(dbParameterReferenceExpression.ParameterName, out dbParameterReferenceExpression2))
				{
					if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqual(dbParameterReferenceExpression.ResultType, dbParameterReferenceExpression2.ResultType))
					{
						this.ThrowInvalid(global::System.Data.Entity.Resources.Strings.Cqt_Validator_InvalidIncompatibleParameterReferences(dbParameterReferenceExpression.ParameterName));
					}
				}
				else
				{
					this.paramMappings.Add(dbParameterReferenceExpression.ParameterName, dbParameterReferenceExpression);
				}
			}
			return dbExpression;
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x001288F8 File Offset: 0x00126AF8
		private TMetadata ValidateMetadata<TMetadata>(TMetadata metadata, global::System.Func<TMetadata, TMetadata> map, global::System.Func<TMetadata, global::System.Data.Entity.Core.Metadata.Edm.DataSpace> getDataSpace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace[] allowedSpaces)
		{
			TMetadata tmetadata = map(metadata);
			if (metadata != tmetadata)
			{
				this.ThrowInvalidMetadata<TMetadata>();
			}
			global::System.Data.Entity.Core.Metadata.Edm.DataSpace resultSpace = getDataSpace(tmetadata);
			if (!allowedSpaces.Any((global::System.Data.Entity.Core.Metadata.Edm.DataSpace ds) => ds == resultSpace))
			{
				this.ThrowInvalidSpace<TMetadata>();
			}
			return tmetadata;
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00128950 File Offset: 0x00126B50
		private void ThrowInvalidMetadata<TMetadata>()
		{
			this.ThrowInvalid(global::System.Data.Entity.Resources.Strings.Cqt_Validator_InvalidOtherWorkspaceMetadata(typeof(TMetadata).Name));
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x0012896C File Offset: 0x00126B6C
		private void ThrowInvalidSpace<TMetadata>()
		{
			this.ThrowInvalid(global::System.Data.Entity.Resources.Strings.Cqt_Validator_InvalidIncorrectDataSpaceMetadata(typeof(TMetadata).Name, global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.DataSpace), this.requiredSpace)));
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x001289A2 File Offset: 0x00126BA2
		private void ThrowInvalid(string message)
		{
			throw new global::System.ArgumentException(message, this.expressionArgumentName);
		}

		// Token: 0x04001DEC RID: 7660
		private readonly global::System.Data.Entity.Core.Metadata.Edm.DataSpace requiredSpace;

		// Token: 0x04001DED RID: 7661
		private readonly global::System.Data.Entity.Core.Metadata.Edm.DataSpace[] allowedMetadataSpaces;

		// Token: 0x04001DEE RID: 7662
		private readonly global::System.Data.Entity.Core.Metadata.Edm.DataSpace[] allowedFunctionSpaces;

		// Token: 0x04001DEF RID: 7663
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> paramMappings = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>();

		// Token: 0x04001DF0 RID: 7664
		private readonly global::System.Collections.Generic.Stack<global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> variableScopes = new global::System.Collections.Generic.Stack<global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>();

		// Token: 0x04001DF1 RID: 7665
		private string expressionArgumentName;
	}
}
