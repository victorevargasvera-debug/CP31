using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005D7 RID: 1495
	internal sealed class UpdateCompiler
	{
		// Token: 0x0600481D RID: 18461 RVA: 0x000FF3C4 File Offset: 0x000FD5C4
		internal UpdateCompiler(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator translator)
		{
			this.m_translator = translator;
		}

		// Token: 0x0600481E RID: 18462 RVA: 0x000FF3D4 File Offset: 0x000FD5D4
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand BuildDeleteCommand(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult oldRow, global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor processor)
		{
			bool flag = true;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target = global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler.GetTarget(processor);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate = this.BuildPredicate(target, oldRow, null, processor, ref flag);
			global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree tree = new global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree(this.m_translator.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, target, predicate);
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand(processor, this.m_translator, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Delete, oldRow, null, tree, null);
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x000FF41C File Offset: 0x000FD61C
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand BuildUpdateCommand(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult oldRow, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult newRow, global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor processor)
		{
			bool flag = false;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target = global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler.GetTarget(processor);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>();
			global::System.Collections.Generic.Dictionary<int, string> outputIdentifiers;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression returning;
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause item in this.BuildSetClauses(target, newRow, oldRow, processor, false, out outputIdentifiers, out returning, ref flag))
			{
				list.Add(item);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate = this.BuildPredicate(target, oldRow, newRow, processor, ref flag);
			if (list.Count == 0)
			{
				if (flag)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry>();
					list2.AddRange(global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter.GetAllStateEntries(oldRow, this.m_translator, processor.Table));
					list2.AddRange(global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter.GetAllStateEntries(newRow, this.m_translator, processor.Table));
					if (list2.All((global::System.Data.Entity.Core.IEntityStateEntry it) => it.State == global::System.Data.Entity.EntityState.Unchanged))
					{
						flag = false;
					}
				}
				if (!flag)
				{
					return null;
				}
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree tree = new global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree(this.m_translator.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, target, predicate, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>(list), returning);
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand(processor, this.m_translator, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Update, oldRow, newRow, tree, outputIdentifiers);
		}

		// Token: 0x06004820 RID: 18464 RVA: 0x000FF538 File Offset: 0x000FD738
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand BuildInsertCommand(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult newRow, global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor processor)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target = global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler.GetTarget(processor);
			bool flag = true;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>();
			global::System.Collections.Generic.Dictionary<int, string> outputIdentifiers;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression returning;
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause item in this.BuildSetClauses(target, newRow, null, processor, true, out outputIdentifiers, out returning, ref flag))
			{
				list.Add(item);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree tree = new global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree(this.m_translator.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace, target, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>(list), returning);
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.DynamicUpdateCommand(processor, this.m_translator, global::System.Data.Entity.Core.Mapping.Update.Internal.ModificationOperator.Insert, null, newRow, tree, outputIdentifiers);
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x000FF5D8 File Offset: 0x000FD7D8
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> BuildSetClauses(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult row, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult originalRow, global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor processor, bool insertMode, out global::System.Collections.Generic.Dictionary<int, string> outputIdentifiers, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression returning, ref bool rowMustBeTouched)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>();
			outputIdentifiers = new global::System.Collections.Generic.Dictionary<int, string>();
			global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags propagatorFlags = insertMode ? global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags : (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve | global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Unknown);
			for (int i = 0; i < processor.Table.ElementType.Properties.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = processor.Table.ElementType.Properties[i];
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = row.GetMemberValue(i);
				if (-1 != propagatorResult.Identifier)
				{
					propagatorResult = propagatorResult.ReplicateResultWithNewValue(this.m_translator.KeyManager.GetPrincipalValue(propagatorResult));
				}
				bool flag = false;
				bool flag2 = false;
				for (int j = 0; j < processor.KeyOrdinals.Length; j++)
				{
					if (processor.KeyOrdinals[j] == i)
					{
						flag2 = true;
						break;
					}
				}
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags propagatorFlags2 = global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags;
				if (!insertMode && flag2)
				{
					flag = true;
				}
				else
				{
					propagatorFlags2 |= propagatorResult.PropagatorFlags;
				}
				global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern storeGeneratedPattern = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetStoreGeneratedPattern(edmProperty);
				bool flag3 = storeGeneratedPattern == global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Computed || (insertMode && storeGeneratedPattern == global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity);
				if (flag3)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression value = target.Variable.Property(edmProperty);
					list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(edmProperty.Name, value));
					int identifier = propagatorResult.Identifier;
					if (-1 != identifier)
					{
						if (this.m_translator.KeyManager.HasPrincipals(identifier))
						{
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Update_GeneratedDependent(edmProperty.Name));
						}
						outputIdentifiers.Add(identifier, edmProperty.Name);
						if (storeGeneratedPattern != global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity && processor.IsKeyProperty(i))
						{
							throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Update_NotSupportedComputedKeyColumn("StoreGeneratedPattern", "Computed", "Identity", edmProperty.Name, edmProperty.DeclaringType.FullName));
						}
					}
				}
				if ((propagatorFlags2 & propagatorFlags) != global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags)
				{
					flag = true;
				}
				else if (flag3)
				{
					flag = true;
					rowMustBeTouched = true;
				}
				if (!flag && !insertMode && storeGeneratedPattern == global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult memberValue = originalRow.GetMemberValue(i);
					if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(memberValue.GetSimpleValue(), propagatorResult.GetSimpleValue()))
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Update_ModifyingIdentityColumn("Identity", edmProperty.Name, edmProperty.DeclaringType.FullName));
					}
					flag = true;
				}
				if (!flag)
				{
					dictionary.Add(edmProperty, propagatorResult);
				}
			}
			if (0 < list.Count)
			{
				returning = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(list);
			}
			else
			{
				returning = null;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>(dictionary.Count);
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> keyValuePair in dictionary)
			{
				list2.Add(new global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler.GeneratePropertyExpression(target, keyValuePair.Key), this.GenerateValueExpression(keyValuePair.Key, keyValuePair.Value)));
			}
			return list2;
		}

		// Token: 0x06004822 RID: 18466 RVA: 0x000FF89C File Offset: 0x000FDA9C
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression BuildPredicate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult referenceRow, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult current, global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor processor, ref bool rowMustBeTouched)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>();
			int num = 0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty key in processor.Table.ElementType.Properties)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult memberValue = referenceRow.GetMemberValue(num);
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult input = (current == null) ? null : current.GetMemberValue(num);
				if (!rowMustBeTouched && (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler.HasFlag(memberValue, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.ConcurrencyValue) || global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler.HasFlag(input, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.ConcurrencyValue)))
				{
					rowMustBeTouched = true;
				}
				if (!dictionary.ContainsKey(key) && (global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler.HasFlag(memberValue, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.ConcurrencyValue | global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Key) || global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler.HasFlag(input, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.ConcurrencyValue | global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Key)))
				{
					dictionary.Add(key, memberValue);
				}
				num++;
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = null;
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> keyValuePair in dictionary)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.GenerateEqualityExpression(target, keyValuePair.Key, keyValuePair.Value);
				if (dbExpression == null)
				{
					dbExpression = dbExpression2;
				}
				else
				{
					dbExpression = dbExpression.And(dbExpression2);
				}
			}
			return dbExpression;
		}

		// Token: 0x06004823 RID: 18467 RVA: 0x000FF9C4 File Offset: 0x000FDBC4
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GenerateEqualityExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult value)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler.GeneratePropertyExpression(target, property);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression2 = this.GenerateValueExpression(property, value);
			if (dbExpression2.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Null)
			{
				return dbExpression.IsNull();
			}
			return dbExpression.Equal(dbExpression2);
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x000FF9FA File Offset: 0x000FDBFA
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GeneratePropertyExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding target, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			return target.Variable.Property(property);
		}

		// Token: 0x06004825 RID: 18469 RVA: 0x000FFA08 File Offset: 0x000FDC08
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GenerateValueExpression(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult value)
		{
			if (value.IsNull)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(property).Null();
			}
			object obj = this.m_translator.KeyManager.GetPrincipalValue(value);
			if (global::System.Convert.IsDBNull(obj))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(property).Null();
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(property);
			global::System.Type type = obj.GetType();
			if (type.IsEnum())
			{
				obj = global::System.Convert.ChangeType(obj, type.GetEnumUnderlyingType(), global::System.Globalization.CultureInfo.InvariantCulture);
			}
			global::System.Type clrEquivalentType = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)modelTypeUsage.EdmType).ClrEquivalentType;
			if (type != clrEquivalentType)
			{
				obj = global::System.Convert.ChangeType(obj, clrEquivalentType, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			return modelTypeUsage.Constant(obj);
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x000FFAA3 File Offset: 0x000FDCA3
		private static bool HasFlag(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult input, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags)
		{
			return input != null && (flags & input.PropagatorFlags) > global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags;
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x000FFAB5 File Offset: 0x000FDCB5
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding GetTarget(global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor processor)
		{
			return processor.Table.Scan().BindAs("target");
		}

		// Token: 0x040019A4 RID: 6564
		internal readonly global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateTranslator m_translator;

		// Token: 0x040019A5 RID: 6565
		private const string s_targetVarName = "target";
	}
}
