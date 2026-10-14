using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000CE RID: 206
	internal class DynamicToFunctionModificationCommandConverter : global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor
	{
		// Token: 0x06000FEE RID: 4078 RVA: 0x00020410 File Offset: 0x0001E610
		public DynamicToFunctionModificationCommandConverter(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			this._entityTypeModificationFunctionMapping = entityTypeModificationFunctionMapping;
			this._entityContainerMapping = entityContainerMapping;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00020426 File Offset: 0x0001E626
		public DynamicToFunctionModificationCommandConverter(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping associationSetModificationFunctionMapping, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			this._associationSetModificationFunctionMapping = associationSetModificationFunctionMapping;
			this._entityContainerMapping = entityContainerMapping;
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0002043C File Offset: 0x0001E63C
		public global::System.Collections.Generic.IEnumerable<TCommandTree> Convert<TCommandTree>(global::System.Collections.Generic.IEnumerable<TCommandTree> modificationCommandTrees) where TCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree
		{
			this._currentFunctionMapping = null;
			this._currentProperty = null;
			this._storeGeneratedKeys = null;
			this._nextStoreGeneratedKey = 0;
			return modificationCommandTrees.Select(delegate(TCommandTree modificationCommandTree)
			{
				if (global::System.Data.Entity.Migrations.Infrastructure.DynamicToFunctionModificationCommandConverter.<>o__10<TCommandTree>.<>p__0 == null)
				{
					global::System.Data.Entity.Migrations.Infrastructure.DynamicToFunctionModificationCommandConverter.<>o__10<TCommandTree>.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Infrastructure.DynamicToFunctionModificationCommandConverter, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName, "ConvertInternal", null, typeof(global::System.Data.Entity.Migrations.Infrastructure.DynamicToFunctionModificationCommandConverter), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				return global::System.Data.Entity.Migrations.Infrastructure.DynamicToFunctionModificationCommandConverter.<>o__10<TCommandTree>.<>p__0.Target(global::System.Data.Entity.Migrations.Infrastructure.DynamicToFunctionModificationCommandConverter.<>o__10<TCommandTree>.<>p__0, this, modificationCommandTree);
			}).Cast<TCommandTree>();
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00020474 File Offset: 0x0001E674
		private global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree ConvertInternal(global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree commandTree)
		{
			if (this._currentFunctionMapping == null)
			{
				this._currentFunctionMapping = ((this._entityTypeModificationFunctionMapping != null) ? this._entityTypeModificationFunctionMapping.InsertFunctionMapping : this._associationSetModificationFunctionMapping.InsertFunctionMapping);
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType = ((global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression)commandTree.Target.Expression).Target.ElementType;
				this._storeGeneratedKeys = (from p in elementType.KeyProperties
				where p.IsStoreGeneratedIdentity
				select p).ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			}
			this._nextStoreGeneratedKey = 0;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree(commandTree.MetadataWorkspace, commandTree.DataSpace, commandTree.Target, this.VisitSetClauses(commandTree.SetClauses), (commandTree.Returning != null) ? commandTree.Returning.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this) : null);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00020540 File Offset: 0x0001E740
		private global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree ConvertInternal(global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree commandTree)
		{
			this._currentFunctionMapping = this._entityTypeModificationFunctionMapping.UpdateFunctionMapping;
			this._useOriginalValues = true;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate = commandTree.Predicate.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this);
			this._useOriginalValues = false;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree(commandTree.MetadataWorkspace, commandTree.DataSpace, commandTree.Target, predicate, this.VisitSetClauses(commandTree.SetClauses), (commandTree.Returning != null) ? commandTree.Returning.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this) : null);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x000205B4 File Offset: 0x0001E7B4
		private global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree ConvertInternal(global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree commandTree)
		{
			this._currentFunctionMapping = ((this._entityTypeModificationFunctionMapping != null) ? this._entityTypeModificationFunctionMapping.DeleteFunctionMapping : this._associationSetModificationFunctionMapping.DeleteFunctionMapping);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree(commandTree.MetadataWorkspace, commandTree.DataSpace, commandTree.Target, commandTree.Predicate.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this));
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0002060A File Offset: 0x0001E80A
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> VisitSetClauses(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> setClauses)
		{
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>((from global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause s in setClauses
			select new global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause(s.Property.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this), s.Value.Accept<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(this))).Cast<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>().ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>());
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00020634 File Offset: 0x0001E834
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression dbComparisonExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression)base.Visit(expression);
			global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression)dbComparisonExpression.Left;
			if (((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)dbPropertyExpression.Property).Nullable)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression right = dbPropertyExpression.IsNull().And(dbComparisonExpression.Right.IsNull());
				return dbComparisonExpression.Or(right);
			}
			return dbComparisonExpression;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0002068C File Offset: 0x0001E88C
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression expression)
		{
			this._currentProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)expression.Property;
			return base.Visit(expression);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x000206A8 File Offset: 0x0001E8A8
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression expression)
		{
			if (this._currentProperty != null)
			{
				global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter, bool> parameter = this.GetParameter(this._currentProperty, this._useOriginalValues);
				if (parameter != null)
				{
					return new global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression(parameter.Item1.TypeUsage, parameter.Item1.Name);
				}
			}
			return base.Visit(expression);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x000206F8 File Offset: 0x0001E8F8
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.VisitExpression(expression.Left);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.VisitExpression(expression.Right);
			if (dbExpression != null && dbExpression2 != null)
			{
				return dbExpression.And(dbExpression2);
			}
			return dbExpression ?? dbExpression2;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00020734 File Offset: 0x0001E934
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = expression.Argument as global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression;
			if (dbPropertyExpression != null)
			{
				global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter, bool> parameter = this.GetParameter((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)dbPropertyExpression.Property, true);
				if (parameter != null)
				{
					if (parameter.Item2)
					{
						return null;
					}
					global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression dbParameterReferenceExpression = new global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression(parameter.Item1.TypeUsage, parameter.Item1.Name);
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left = dbPropertyExpression.Equal(dbParameterReferenceExpression);
					global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression right = dbPropertyExpression.IsNull().And(dbParameterReferenceExpression.IsNull());
					return left.Or(right);
				}
			}
			return base.Visit(expression);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x000207B4 File Offset: 0x0001E9B4
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression expression)
		{
			if (this._currentProperty != null)
			{
				global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter, bool> parameter = this.GetParameter(this._currentProperty, false);
				if (parameter != null)
				{
					return new global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression(parameter.Item1.TypeUsage, parameter.Item1.Name);
				}
			}
			return base.Visit(expression);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00020800 File Offset: 0x0001EA00
		public override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression expression)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow((from <>h__TransparentIdentifier0 in expression.Arguments.Cast<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>().Select(delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression propertyExpression)
			{
				global::System.Func<global::<>f__AnonymousType13<global::<>f__AnonymousType12<global::<>f__AnonymousType11<global::System.Data.Entity.Core.Mapping.EntitySetMapping, global::System.Data.Entity.Core.Mapping.EntityTypeMapping>, global::System.Data.Entity.Core.Mapping.MappingFragment>, global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>, bool> <>9__9;
				return new
				{
					propertyExpression = propertyExpression,
					resultBinding = this._currentFunctionMapping.ResultBindings.Single(delegate(global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding rb)
					{
						var source = from esm in this._entityContainerMapping.EntitySetMappings
						from etm in esm.EntityTypeMappings
						from mf in etm.MappingFragments
						from pm in mf.PropertyMappings.OfType<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping>()
						select new
						{
							<>h__TransparentIdentifier1,
							pm
						};
						var predicate;
						if ((predicate = <>9__9) == null)
						{
							predicate = (<>9__9 = (<>h__TransparentIdentifier2 => <>h__TransparentIdentifier2.pm.Column.EdmEquals(propertyExpression.Property) && <>h__TransparentIdentifier2.pm.Column.DeclaringType.EdmEquals(propertyExpression.Property.DeclaringType)));
						}
						return (from <>h__TransparentIdentifier2 in source.Where(predicate)
						select <>h__TransparentIdentifier2.pm.Property).Contains(rb.Property);
					})
				};
			})
			select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(<>h__TransparentIdentifier0.resultBinding.ColumnName, <>h__TransparentIdentifier0.propertyExpression)).ToList<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>());
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00020858 File Offset: 0x0001EA58
		private global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter, bool> GetParameter(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, bool originalValue = false)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> columnMappings = (from esm in this._entityContainerMapping.EntitySetMappings
			from etm in esm.EntityTypeMappings
			from mf in etm.MappingFragments
			from cm in mf.FlattenedProperties
			where cm.ColumnProperty.EdmEquals(column) && cm.ColumnProperty.DeclaringType.EdmEquals(column.DeclaringType)
			select cm).ToList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> list = (from pb in this._currentFunctionMapping.ParameterBindings
			where columnMappings.Any((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder cm) => pb.MemberPath.Members.Reverse<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>().SequenceEqual(cm.PropertyPath))
			select pb).ToList<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>();
			if (!list.Any<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>())
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember[]> iaColumnMappings = (from asm in this._entityContainerMapping.AssociationSetMappings
				from tm in asm.TypeMappings
				from mf in tm.MappingFragments
				from epm in mf.PropertyMappings.OfType<global::System.Data.Entity.Core.Mapping.EndPropertyMapping>()
				from pm in epm.PropertyMappings
				where pm.Column.EdmEquals(column) && pm.Column.DeclaringType.EdmEquals(column.DeclaringType)
				select new global::System.Data.Entity.Core.Metadata.Edm.EdmMember[]
				{
					pm.Property,
					epm.AssociationEnd
				}).ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember[]>();
				list = (from pb in this._currentFunctionMapping.ParameterBindings
				where iaColumnMappings.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmMember[] epm) => pb.MemberPath.Members.SequenceEqual(epm))
				select pb).ToList<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>();
			}
			if (list.Count == 0 && column.IsPrimaryKeyColumn)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> storeGeneratedKeys = this._storeGeneratedKeys;
				int nextStoreGeneratedKey = this._nextStoreGeneratedKey;
				this._nextStoreGeneratedKey = nextStoreGeneratedKey + 1;
				return global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter, bool>(new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter(storeGeneratedKeys[nextStoreGeneratedKey].Name, column.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In), true);
			}
			if (list.Count == 1)
			{
				return global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter, bool>(list[0].Parameter, list[0].IsCurrent);
			}
			if (list.Count == 0)
			{
				return null;
			}
			global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding;
			if (!originalValue)
			{
				modificationFunctionParameterBinding = list.Single((global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding pb) => pb.IsCurrent);
			}
			else
			{
				modificationFunctionParameterBinding = list.Single((global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding pb) => !pb.IsCurrent);
			}
			global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding modificationFunctionParameterBinding2 = modificationFunctionParameterBinding;
			return global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter, bool>(modificationFunctionParameterBinding2.Parameter, modificationFunctionParameterBinding2.IsCurrent);
		}

		// Token: 0x04000898 RID: 2200
		private readonly global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping _entityTypeModificationFunctionMapping;

		// Token: 0x04000899 RID: 2201
		private readonly global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping _associationSetModificationFunctionMapping;

		// Token: 0x0400089A RID: 2202
		private readonly global::System.Data.Entity.Core.Mapping.EntityContainerMapping _entityContainerMapping;

		// Token: 0x0400089B RID: 2203
		private global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping _currentFunctionMapping;

		// Token: 0x0400089C RID: 2204
		private global::System.Data.Entity.Core.Metadata.Edm.EdmProperty _currentProperty;

		// Token: 0x0400089D RID: 2205
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> _storeGeneratedKeys;

		// Token: 0x0400089E RID: 2206
		private int _nextStoreGeneratedKey;

		// Token: 0x0400089F RID: 2207
		private bool _useOriginalValues;
	}
}
