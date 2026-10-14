using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006EF RID: 1775
	internal class ExpressionPrinter : global::System.Data.Entity.Core.Common.Utils.TreePrinter
	{
		// Token: 0x060052B2 RID: 21170 RVA: 0x00127E14 File Offset: 0x00126014
		internal string Print(global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree tree)
		{
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode;
			if (tree.Target != null)
			{
				treeNode = this._visitor.VisitBinding("Target", tree.Target);
			}
			else
			{
				treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Target", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			}
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2;
			if (tree.Predicate != null)
			{
				treeNode2 = this._visitor.VisitExpression("Predicate", tree.Predicate);
			}
			else
			{
				treeNode2 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Predicate", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			}
			return this.Print(new global::System.Data.Entity.Core.Common.Utils.TreeNode("DbDeleteCommandTree", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.CreateParametersNode(tree),
				treeNode,
				treeNode2
			}));
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x00127EAC File Offset: 0x001260AC
		internal string Print(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree tree)
		{
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("EdmFunction", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			if (tree.EdmFunction != null)
			{
				treeNode.Children.Add(this._visitor.VisitFunction(tree.EdmFunction, null));
			}
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("ResultType", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			if (tree.ResultType != null)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendTypeSpecifier(treeNode2, tree.ResultType);
			}
			return this.Print(new global::System.Data.Entity.Core.Common.Utils.TreeNode("DbFunctionCommandTree", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.CreateParametersNode(tree),
				treeNode,
				treeNode2
			}));
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x00127F3C File Offset: 0x0012613C
		internal string Print(global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree tree)
		{
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = null;
			if (tree.Target != null)
			{
				treeNode = this._visitor.VisitBinding("Target", tree.Target);
			}
			else
			{
				treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Target", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			}
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("SetClauses", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause dbModificationClause in tree.SetClauses)
			{
				if (dbModificationClause != null)
				{
					treeNode2.Children.Add(dbModificationClause.Print(this._visitor));
				}
			}
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode3;
			if (tree.Returning != null)
			{
				treeNode3 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Returning", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
				{
					this._visitor.VisitExpression(tree.Returning)
				});
			}
			else
			{
				treeNode3 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Returning", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			}
			return this.Print(new global::System.Data.Entity.Core.Common.Utils.TreeNode("DbInsertCommandTree", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.CreateParametersNode(tree),
				treeNode,
				treeNode2,
				treeNode3
			}));
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x00128054 File Offset: 0x00126254
		internal string Print(global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree tree)
		{
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = null;
			if (tree.Target != null)
			{
				treeNode = this._visitor.VisitBinding("Target", tree.Target);
			}
			else
			{
				treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Target", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			}
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("SetClauses", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause dbModificationClause in tree.SetClauses)
			{
				if (dbModificationClause != null)
				{
					treeNode2.Children.Add(dbModificationClause.Print(this._visitor));
				}
			}
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode3;
			if (tree.Predicate != null)
			{
				treeNode3 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Predicate", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
				{
					this._visitor.VisitExpression(tree.Predicate)
				});
			}
			else
			{
				treeNode3 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Predicate", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			}
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode4;
			if (tree.Returning != null)
			{
				treeNode4 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Returning", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
				{
					this._visitor.VisitExpression(tree.Returning)
				});
			}
			else
			{
				treeNode4 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Returning", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			}
			return this.Print(new global::System.Data.Entity.Core.Common.Utils.TreeNode("DbUpdateCommandTree", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.CreateParametersNode(tree),
				treeNode,
				treeNode2,
				treeNode3,
				treeNode4
			}));
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x001281B0 File Offset: 0x001263B0
		internal string Print(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree)
		{
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Query", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			if (tree.Query != null)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendTypeSpecifier(treeNode, tree.Query.ResultType);
				treeNode.Children.Add(this._visitor.VisitExpression(tree.Query));
			}
			return this.Print(new global::System.Data.Entity.Core.Common.Utils.TreeNode("DbQueryCommandTree", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.CreateParametersNode(tree),
				treeNode
			}));
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x00128228 File Offset: 0x00126428
		private static global::System.Data.Entity.Core.Common.Utils.TreeNode CreateParametersNode(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree tree)
		{
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Parameters", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> keyValuePair in tree.Parameters)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2 = new global::System.Data.Entity.Core.Common.Utils.TreeNode(keyValuePair.Key, new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendTypeSpecifier(treeNode2, keyValuePair.Value);
				treeNode.Children.Add(treeNode2);
			}
			return treeNode;
		}

		// Token: 0x04001DE6 RID: 7654
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor _visitor = new global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor();

		// Token: 0x02000C99 RID: 3225
		private class PrinterVisitor : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<global::System.Data.Entity.Core.Common.Utils.TreeNode>
		{
			// Token: 0x06006C16 RID: 27670 RVA: 0x00170034 File Offset: 0x0016E234
			private static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind, string> InitializeOpMap()
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind, string> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind, string>(12);
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Divide] = "/";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Modulo] = "%";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Multiply] = "*";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Plus] = "+";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Minus] = "-";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.UnaryMinus] = "-";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals] = "=";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThan] = "<";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThanOrEquals] = "<=";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThan] = ">";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThanOrEquals] = ">=";
				dictionary[global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NotEquals] = "<>";
				return dictionary;
			}

			// Token: 0x06006C17 RID: 27671 RVA: 0x001700E4 File Offset: 0x0016E2E4
			internal global::System.Data.Entity.Core.Common.Utils.TreeNode VisitExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
			{
				return expr.Accept<global::System.Data.Entity.Core.Common.Utils.TreeNode>(this);
			}

			// Token: 0x06006C18 RID: 27672 RVA: 0x001700ED File Offset: 0x0016E2ED
			internal global::System.Data.Entity.Core.Common.Utils.TreeNode VisitExpression(string name, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
			{
				return new global::System.Data.Entity.Core.Common.Utils.TreeNode(name, new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
				{
					expr.Accept<global::System.Data.Entity.Core.Common.Utils.TreeNode>(this)
				});
			}

			// Token: 0x06006C19 RID: 27673 RVA: 0x00170105 File Offset: 0x0016E305
			internal global::System.Data.Entity.Core.Common.Utils.TreeNode VisitBinding(string propName, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
			{
				return this.VisitWithLabel(propName, binding.VariableName, binding.Expression);
			}

			// Token: 0x06006C1A RID: 27674 RVA: 0x0017011C File Offset: 0x0016E31C
			internal global::System.Data.Entity.Core.Common.Utils.TreeNode VisitFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction func, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode();
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendFullName(treeNode.Text, func);
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendParameters(treeNode, from fp in func.Parameters
				select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(fp.Name, fp.TypeUsage));
				if (args != null)
				{
					this.AppendArguments(treeNode, (from fp in func.Parameters
					select fp.Name).ToArray<string>(), args);
				}
				return treeNode;
			}

			// Token: 0x06006C1B RID: 27675 RVA: 0x001701A6 File Offset: 0x0016E3A6
			private static global::System.Data.Entity.Core.Common.Utils.TreeNode NodeFromExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr)
			{
				return new global::System.Data.Entity.Core.Common.Utils.TreeNode(global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind), expr.ExpressionKind), new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			}

			// Token: 0x06006C1C RID: 27676 RVA: 0x001701D0 File Offset: 0x0016E3D0
			private static void AppendParameters(global::System.Data.Entity.Core.Common.Utils.TreeNode node, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> paramInfos)
			{
				node.Text.Append("(");
				int num = 0;
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> keyValuePair in paramInfos)
				{
					if (num > 0)
					{
						node.Text.Append(", ");
					}
					global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendType(node, keyValuePair.Value);
					node.Text.Append(" ");
					node.Text.Append(keyValuePair.Key);
					num++;
				}
				node.Text.Append(")");
			}

			// Token: 0x06006C1D RID: 27677 RVA: 0x00170280 File Offset: 0x0016E480
			internal static void AppendTypeSpecifier(global::System.Data.Entity.Core.Common.Utils.TreeNode node, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
			{
				node.Text.Append(" : ");
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendType(node, type);
			}

			// Token: 0x06006C1E RID: 27678 RVA: 0x0017029A File Offset: 0x0016E49A
			internal static void AppendType(global::System.Data.Entity.Core.Common.Utils.TreeNode node, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.BuildTypeName(node.Text, type);
			}

			// Token: 0x06006C1F RID: 27679 RVA: 0x001702A8 File Offset: 0x0016E4A8
			private static void BuildTypeName(global::System.Text.StringBuilder text, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = type.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RowType;
				global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType = type.EdmType as global::System.Data.Entity.Core.Metadata.Edm.CollectionType;
				global::System.Data.Entity.Core.Metadata.Edm.RefType refType = type.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RefType;
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type))
				{
					text.Append(type);
					return;
				}
				if (collectionType != null)
				{
					text.Append("Collection{");
					global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.BuildTypeName(text, collectionType.TypeUsage);
					text.Append("}");
					return;
				}
				if (refType != null)
				{
					text.Append("Ref<");
					global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendFullName(text, refType.ElementType);
					text.Append(">");
					return;
				}
				if (rowType != null)
				{
					text.Append("Record[");
					int num = 0;
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in rowType.Properties)
					{
						text.Append("'");
						text.Append(edmProperty.Name);
						text.Append("'");
						text.Append("=");
						global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.BuildTypeName(text, edmProperty.TypeUsage);
						num++;
						if (num < rowType.Properties.Count)
						{
							text.Append(", ");
						}
					}
					text.Append("]");
					return;
				}
				if (!string.IsNullOrEmpty(type.EdmType.NamespaceName))
				{
					text.Append(type.EdmType.NamespaceName);
					text.Append(".");
				}
				text.Append(type.EdmType.Name);
			}

			// Token: 0x06006C20 RID: 27680 RVA: 0x0017043C File Offset: 0x0016E63C
			private static void AppendFullName(global::System.Text.StringBuilder text, global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType != type.BuiltInTypeKind && !string.IsNullOrEmpty(type.NamespaceName))
				{
					text.Append(type.NamespaceName);
					text.Append(".");
				}
				text.Append(type.Name);
			}

			// Token: 0x06006C21 RID: 27681 RVA: 0x0017047C File Offset: 0x0016E67C
			private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode> VisitParams(global::System.Collections.Generic.IList<string> paramInfo, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode>();
				for (int i = 0; i < paramInfo.Count; i++)
				{
					list.Add(new global::System.Data.Entity.Core.Common.Utils.TreeNode(paramInfo[i], new global::System.Data.Entity.Core.Common.Utils.TreeNode[0])
					{
						Children = 
						{
							this.VisitExpression(args[i])
						}
					});
				}
				return list;
			}

			// Token: 0x06006C22 RID: 27682 RVA: 0x001704D3 File Offset: 0x0016E6D3
			private void AppendArguments(global::System.Data.Entity.Core.Common.Utils.TreeNode node, global::System.Collections.Generic.IList<string> paramNames, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args)
			{
				if (paramNames.Count > 0)
				{
					node.Children.Add(new global::System.Data.Entity.Core.Common.Utils.TreeNode("Arguments", this.VisitParams(paramNames, args)));
				}
			}

			// Token: 0x06006C23 RID: 27683 RVA: 0x001704FC File Offset: 0x0016E6FC
			private global::System.Data.Entity.Core.Common.Utils.TreeNode VisitWithLabel(string label, string name, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression def)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode(label, new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
				treeNode.Text.Append(" : '");
				treeNode.Text.Append(name);
				treeNode.Text.Append("'");
				treeNode.Children.Add(this.VisitExpression(def));
				return treeNode;
			}

			// Token: 0x06006C24 RID: 27684 RVA: 0x00170558 File Offset: 0x0016E758
			private global::System.Data.Entity.Core.Common.Utils.TreeNode VisitBindingList(string propName, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> bindings)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode>();
				for (int i = 0; i < bindings.Count; i++)
				{
					list.Add(this.VisitBinding(global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex(propName, i), bindings[i]));
				}
				return new global::System.Data.Entity.Core.Common.Utils.TreeNode(propName, list);
			}

			// Token: 0x06006C25 RID: 27685 RVA: 0x001705A0 File Offset: 0x0016E7A0
			private global::System.Data.Entity.Core.Common.Utils.TreeNode VisitGroupBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding groupBinding)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode item = this.VisitExpression(groupBinding.Expression);
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode();
				treeNode.Children.Add(item);
				treeNode.Text.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "Input : '{0}', '{1}'", new object[]
				{
					groupBinding.VariableName,
					groupBinding.GroupVariableName
				});
				return treeNode;
			}

			// Token: 0x06006C26 RID: 27686 RVA: 0x001705FC File Offset: 0x0016E7FC
			private global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(string name, params global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] exprs)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode(name, new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr in exprs)
				{
					treeNode.Children.Add(this.VisitExpression(expr));
				}
				return treeNode;
			}

			// Token: 0x06006C27 RID: 27687 RVA: 0x00170640 File Offset: 0x0016E840
			private global::System.Data.Entity.Core.Common.Utils.TreeNode VisitInfix(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, string name, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
			{
				if (this._infix)
				{
					return new global::System.Data.Entity.Core.Common.Utils.TreeNode("", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0])
					{
						Children = 
						{
							this.VisitExpression(left),
							new global::System.Data.Entity.Core.Common.Utils.TreeNode(name, new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]),
							this.VisitExpression(right)
						}
					};
				}
				return this.Visit(name, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					left,
					right
				});
			}

			// Token: 0x06006C28 RID: 27688 RVA: 0x001706B8 File Offset: 0x0016E8B8
			private global::System.Data.Entity.Core.Common.Utils.TreeNode VisitUnary(global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression expr)
			{
				return this.VisitUnary(expr, false);
			}

			// Token: 0x06006C29 RID: 27689 RVA: 0x001706C4 File Offset: 0x0016E8C4
			private global::System.Data.Entity.Core.Common.Utils.TreeNode VisitUnary(global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression expr, bool appendType)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(expr);
				if (appendType)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendTypeSpecifier(treeNode, expr.ResultType);
				}
				treeNode.Children.Add(this.VisitExpression(expr.Argument));
				return treeNode;
			}

			// Token: 0x06006C2A RID: 27690 RVA: 0x001706FF File Offset: 0x0016E8FF
			private global::System.Data.Entity.Core.Common.Utils.TreeNode VisitBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression expr)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(expr);
				treeNode.Children.Add(this.VisitExpression(expr.Left));
				treeNode.Children.Add(this.VisitExpression(expr.Right));
				return treeNode;
			}

			// Token: 0x06006C2B RID: 27691 RVA: 0x00170735 File Offset: 0x0016E935
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(e, "e");
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Cqt_General_UnsupportedExpression(e.GetType().FullName));
			}

			// Token: 0x06006C2C RID: 27692 RVA: 0x00170758 File Offset: 0x0016E958
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode();
				string text = e.Value as string;
				if (text != null)
				{
					text = text.Replace("\r\n", "\\r\\n");
					int num = text.Length;
					if (this._maxStringLength > 0)
					{
						num = global::System.Math.Min(text.Length, this._maxStringLength);
					}
					treeNode.Text.Append("'");
					treeNode.Text.Append(text, 0, num);
					if (text.Length > num)
					{
						treeNode.Text.Append("...");
					}
					treeNode.Text.Append("'");
				}
				else
				{
					treeNode.Text.Append(e.Value);
				}
				return treeNode;
			}

			// Token: 0x06006C2D RID: 27693 RVA: 0x0017081C File Offset: 0x0016EA1C
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(e, "e");
				return new global::System.Data.Entity.Core.Common.Utils.TreeNode("null", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			}

			// Token: 0x06006C2E RID: 27694 RVA: 0x0017083A File Offset: 0x0016EA3A
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode();
				treeNode.Text.AppendFormat("Var({0})", e.VariableName);
				return treeNode;
			}

			// Token: 0x06006C2F RID: 27695 RVA: 0x00170864 File Offset: 0x0016EA64
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode();
				treeNode.Text.AppendFormat("@{0}", e.ParameterName);
				return treeNode;
			}

			// Token: 0x06006C30 RID: 27696 RVA: 0x0017088E File Offset: 0x0016EA8E
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(e, "e");
				return this.VisitFunction(e.Function, e.Arguments);
			}

			// Token: 0x06006C31 RID: 27697 RVA: 0x001708B0 File Offset: 0x0016EAB0
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression>(expression, "expression");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode();
				treeNode.Text.Append("Lambda");
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendParameters(treeNode, from v in expression.Lambda.Variables
				select new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(v.VariableName, v.ResultType));
				this.AppendArguments(treeNode, (from v in expression.Lambda.Variables
				select v.VariableName).ToArray<string>(), expression.Arguments);
				treeNode.Children.Add(this.Visit("Body", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					expression.Lambda.Body
				}));
				return treeNode;
			}

			// Token: 0x06006C32 RID: 27698 RVA: 0x00170984 File Offset: 0x0016EB84
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = null;
				if (e.Instance != null)
				{
					treeNode = this.VisitExpression(e.Instance);
					if (e.Instance.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.VariableReference || (e.Instance.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Property && treeNode.Children.Count == 0))
					{
						treeNode.Text.Append(".");
						treeNode.Text.Append(e.Property.Name);
						return treeNode;
					}
				}
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2 = new global::System.Data.Entity.Core.Common.Utils.TreeNode(".", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = e.Property as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty;
				if (edmProperty != null && !(edmProperty.DeclaringType is global::System.Data.Entity.Core.Metadata.Edm.RowType))
				{
					global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendFullName(treeNode2.Text, edmProperty.DeclaringType);
					treeNode2.Text.Append(".");
				}
				treeNode2.Text.Append(e.Property.Name);
				if (treeNode != null)
				{
					treeNode2.Children.Add(new global::System.Data.Entity.Core.Common.Utils.TreeNode("Instance", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
					{
						treeNode
					}));
				}
				return treeNode2;
			}

			// Token: 0x06006C33 RID: 27699 RVA: 0x00170A92 File Offset: 0x0016EC92
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(e, "e");
				return this.VisitInfix(e.Left, global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor._opMap[e.ExpressionKind], e.Right);
			}

			// Token: 0x06006C34 RID: 27700 RVA: 0x00170AC2 File Offset: 0x0016ECC2
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression>(e, "e");
				return this.Visit("Like", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					e.Argument,
					e.Pattern,
					e.Escape
				});
			}

			// Token: 0x06006C35 RID: 27701 RVA: 0x00170AFC File Offset: 0x0016ECFC
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(e, "e");
				return this.Visit(e.WithTies ? "LimitWithTies" : "Limit", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					e.Argument,
					e.Limit
				});
			}

			// Token: 0x06006C36 RID: 27702 RVA: 0x00170B3C File Offset: 0x0016ED3C
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(e, "e");
				return this.VisitUnary(e);
			}

			// Token: 0x06006C37 RID: 27703 RVA: 0x00170B54 File Offset: 0x0016ED54
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression>(e, "e");
				if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.UnaryMinus == e.ExpressionKind)
				{
					return this.Visit(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor._opMap[e.ExpressionKind], new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						e.Arguments[0]
					});
				}
				return this.VisitInfix(e.Arguments[0], global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor._opMap[e.ExpressionKind], e.Arguments[1]);
			}

			// Token: 0x06006C38 RID: 27704 RVA: 0x00170BD1 File Offset: 0x0016EDD1
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(e, "e");
				return this.VisitInfix(e.Left, "And", e.Right);
			}

			// Token: 0x06006C39 RID: 27705 RVA: 0x00170BF6 File Offset: 0x0016EDF6
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(e, "e");
				return this.VisitInfix(e.Left, "Or", e.Right);
			}

			// Token: 0x06006C3A RID: 27706 RVA: 0x00170C1C File Offset: 0x0016EE1C
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode;
				if (this._infix)
				{
					treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode(string.Empty, new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
					treeNode.Children.Add(this.VisitExpression(e.Item));
					treeNode.Children.Add(new global::System.Data.Entity.Core.Common.Utils.TreeNode("In", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]));
				}
				else
				{
					treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("In", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
					treeNode.Children.Add(this.VisitExpression(e.Item));
				}
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr in e.List)
				{
					treeNode.Children.Add(this.VisitExpression(expr));
				}
				return treeNode;
			}

			// Token: 0x06006C3B RID: 27707 RVA: 0x00170CF8 File Offset: 0x0016EEF8
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(e, "e");
				return this.VisitUnary(e);
			}

			// Token: 0x06006C3C RID: 27708 RVA: 0x00170D0D File Offset: 0x0016EF0D
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(e, "e");
				return this.VisitUnary(e);
			}

			// Token: 0x06006C3D RID: 27709 RVA: 0x00170D22 File Offset: 0x0016EF22
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(e, "e");
				return this.VisitUnary(e, true);
			}

			// Token: 0x06006C3E RID: 27710 RVA: 0x00170D38 File Offset: 0x0016EF38
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(e, "e");
				return this.VisitUnary(e);
			}

			// Token: 0x06006C3F RID: 27711 RVA: 0x00170D4D File Offset: 0x0016EF4D
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(e, "e");
				return this.VisitBinary(e);
			}

			// Token: 0x06006C40 RID: 27712 RVA: 0x00170D62 File Offset: 0x0016EF62
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(e, "e");
				return this.VisitBinary(e);
			}

			// Token: 0x06006C41 RID: 27713 RVA: 0x00170D77 File Offset: 0x0016EF77
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(e, "e");
				return this.VisitBinary(e);
			}

			// Token: 0x06006C42 RID: 27714 RVA: 0x00170D8C File Offset: 0x0016EF8C
			private global::System.Data.Entity.Core.Common.Utils.TreeNode VisitCastOrTreat(string op, global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression e)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = this.VisitExpression(e.Argument);
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2;
				if (treeNode.Children.Count == 0)
				{
					treeNode.Text.Insert(0, op);
					treeNode.Text.Insert(op.Length, '(');
					treeNode.Text.Append(" As ");
					global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendType(treeNode, e.ResultType);
					treeNode.Text.Append(")");
					treeNode2 = treeNode;
				}
				else
				{
					treeNode2 = new global::System.Data.Entity.Core.Common.Utils.TreeNode(op, new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
					global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendTypeSpecifier(treeNode2, e.ResultType);
					treeNode2.Children.Add(treeNode);
				}
				return treeNode2;
			}

			// Token: 0x06006C43 RID: 27715 RVA: 0x00170E2F File Offset: 0x0016F02F
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(e, "e");
				return this.VisitCastOrTreat("Treat", e);
			}

			// Token: 0x06006C44 RID: 27716 RVA: 0x00170E49 File Offset: 0x0016F049
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(e, "e");
				return this.VisitCastOrTreat("Cast", e);
			}

			// Token: 0x06006C45 RID: 27717 RVA: 0x00170E64 File Offset: 0x0016F064
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode();
				if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOfOnly == e.ExpressionKind)
				{
					treeNode.Text.Append("IsOfOnly");
				}
				else
				{
					treeNode.Text.Append("IsOf");
				}
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendTypeSpecifier(treeNode, e.OfType);
				treeNode.Children.Add(this.VisitExpression(e.Argument));
				return treeNode;
			}

			// Token: 0x06006C46 RID: 27718 RVA: 0x00170ED8 File Offset: 0x0016F0D8
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode((e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OfTypeOnly) ? "OfTypeOnly" : "OfType", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendTypeSpecifier(treeNode, e.OfType);
				treeNode.Children.Add(this.VisitExpression(e.Argument));
				return treeNode;
			}

			// Token: 0x06006C47 RID: 27719 RVA: 0x00170F38 File Offset: 0x0016F138
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Case", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
				for (int i = 0; i < e.When.Count; i++)
				{
					treeNode.Children.Add(this.Visit("When", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						e.When[i]
					}));
					treeNode.Children.Add(this.Visit("Then", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						e.Then[i]
					}));
				}
				treeNode.Children.Add(this.Visit("Else", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					e.Else
				}));
				return treeNode;
			}

			// Token: 0x06006C48 RID: 27720 RVA: 0x00170FF4 File Offset: 0x0016F1F4
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendTypeSpecifier(treeNode, e.ResultType);
				if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == e.ResultType.EdmType.BuiltInTypeKind)
				{
					using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> enumerator = e.Arguments.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expr = enumerator.Current;
							treeNode.Children.Add(this.VisitExpression(expr));
						}
						return treeNode;
					}
				}
				string label = (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType == e.ResultType.EdmType.BuiltInTypeKind) ? "Column" : "Property";
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties = global::System.Data.Entity.Core.Common.TypeHelpers.GetProperties(e.ResultType);
				for (int i = 0; i < properties.Count; i++)
				{
					treeNode.Children.Add(this.VisitWithLabel(label, properties[i].Name, e.Arguments[i]));
				}
				if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType == e.ResultType.EdmType.BuiltInTypeKind && e.HasRelatedEntityReferences)
				{
					global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("RelatedEntityReferences", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
					foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef dbRelatedEntityRef in e.RelatedEntityReferences)
					{
						global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode3 = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.CreateNavigationNode(dbRelatedEntityRef.SourceEnd, dbRelatedEntityRef.TargetEnd);
						treeNode3.Children.Add(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.CreateRelationshipNode((global::System.Data.Entity.Core.Metadata.Edm.RelationshipType)dbRelatedEntityRef.SourceEnd.DeclaringType));
						treeNode3.Children.Add(this.VisitExpression(dbRelatedEntityRef.TargetEntityReference));
						treeNode2.Children.Add(treeNode3);
					}
					treeNode.Children.Add(treeNode2);
				}
				return treeNode;
			}

			// Token: 0x06006C49 RID: 27721 RVA: 0x001711D0 File Offset: 0x0016F3D0
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Ref", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
				treeNode.Text.Append("<");
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendFullName(treeNode.Text, global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(e.ResultType).ElementType);
				treeNode.Text.Append(">");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("EntitySet : ", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
				treeNode2.Text.Append(e.EntitySet.EntityContainer.Name);
				treeNode2.Text.Append(".");
				treeNode2.Text.Append(e.EntitySet.Name);
				treeNode.Children.Add(treeNode2);
				treeNode.Children.Add(this.Visit("Keys", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					e.Argument
				}));
				return treeNode;
			}

			// Token: 0x06006C4A RID: 27722 RVA: 0x001712BE File Offset: 0x0016F4BE
			private static global::System.Data.Entity.Core.Common.Utils.TreeNode CreateRelationshipNode(global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relType)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Relationship", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
				treeNode.Text.Append(" : ");
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.AppendFullName(treeNode.Text, relType);
				return treeNode;
			}

			// Token: 0x06006C4B RID: 27723 RVA: 0x001712F0 File Offset: 0x0016F4F0
			private static global::System.Data.Entity.Core.Common.Utils.TreeNode CreateNavigationNode(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromEnd, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode();
				treeNode.Text.Append("Navigation : ");
				treeNode.Text.Append(fromEnd.Name);
				treeNode.Text.Append(" -> ");
				treeNode.Text.Append(toEnd.Name);
				return treeNode;
			}

			// Token: 0x06006C4C RID: 27724 RVA: 0x00171348 File Offset: 0x0016F548
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode.Children.Add(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.CreateRelationshipNode(e.Relationship));
				treeNode.Children.Add(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.CreateNavigationNode(e.NavigateFrom, e.NavigateTo));
				treeNode.Children.Add(this.Visit("Source", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					e.NavigationSource
				}));
				return treeNode;
			}

			// Token: 0x06006C4D RID: 27725 RVA: 0x001713C0 File Offset: 0x0016F5C0
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression>(e, "e");
				return this.VisitUnary(e);
			}

			// Token: 0x06006C4E RID: 27726 RVA: 0x001713D5 File Offset: 0x0016F5D5
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(e, "e");
				return this.VisitUnary(e, true);
			}

			// Token: 0x06006C4F RID: 27727 RVA: 0x001713EB File Offset: 0x0016F5EB
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression>(e, "e");
				return this.VisitUnary(e, true);
			}

			// Token: 0x06006C50 RID: 27728 RVA: 0x00171404 File Offset: 0x0016F604
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode.Text.Append(" : ");
				treeNode.Text.Append(e.Target.EntityContainer.Name);
				treeNode.Text.Append(".");
				treeNode.Text.Append(e.Target.Name);
				return treeNode;
			}

			// Token: 0x06006C51 RID: 27729 RVA: 0x00171478 File Offset: 0x0016F678
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode.Children.Add(this.VisitBinding("Input", e.Input));
				treeNode.Children.Add(this.Visit("Predicate", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					e.Predicate
				}));
				return treeNode;
			}

			// Token: 0x06006C52 RID: 27730 RVA: 0x001714DC File Offset: 0x0016F6DC
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode.Children.Add(this.VisitBinding("Input", e.Input));
				treeNode.Children.Add(this.Visit("Projection", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					e.Projection
				}));
				return treeNode;
			}

			// Token: 0x06006C53 RID: 27731 RVA: 0x0017153E File Offset: 0x0016F73E
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode.Children.Add(this.VisitBindingList("Inputs", e.Inputs));
				return treeNode;
			}

			// Token: 0x06006C54 RID: 27732 RVA: 0x00171570 File Offset: 0x0016F770
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode.Children.Add(this.VisitBinding("Left", e.Left));
				treeNode.Children.Add(this.VisitBinding("Right", e.Right));
				treeNode.Children.Add(this.Visit("JoinCondition", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					e.JoinCondition
				}));
				return treeNode;
			}

			// Token: 0x06006C55 RID: 27733 RVA: 0x001715F0 File Offset: 0x0016F7F0
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode.Children.Add(this.VisitBinding("Input", e.Input));
				treeNode.Children.Add(this.VisitBinding("Apply", e.Apply));
				return treeNode;
			}

			// Token: 0x06006C56 RID: 27734 RVA: 0x00171648 File Offset: 0x0016F848
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression>(e, "e");
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode>();
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode>();
				global::System.Data.Entity.Core.Metadata.Edm.RowType edmType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RowType>(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(e.ResultType).TypeUsage);
				int num = 0;
				for (int i = 0; i < e.Keys.Count; i++)
				{
					list.Add(this.VisitWithLabel("Key", edmType.Properties[i].Name, e.Keys[num]));
					num++;
				}
				int num2 = 0;
				for (int j = e.Keys.Count; j < edmType.Properties.Count; j++)
				{
					global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Aggregate : '", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
					treeNode.Text.Append(edmType.Properties[j].Name);
					treeNode.Text.Append("'");
					global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate dbFunctionAggregate = e.Aggregates[num2] as global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate;
					if (dbFunctionAggregate != null)
					{
						global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2 = this.VisitFunction(dbFunctionAggregate.Function, dbFunctionAggregate.Arguments);
						if (dbFunctionAggregate.Distinct)
						{
							treeNode2 = new global::System.Data.Entity.Core.Common.Utils.TreeNode("Distinct", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
							{
								treeNode2
							});
						}
						treeNode.Children.Add(treeNode2);
					}
					else
					{
						global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate dbGroupAggregate = e.Aggregates[num2] as global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate;
						treeNode.Children.Add(this.Visit("GroupAggregate", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
						{
							dbGroupAggregate.Arguments[0]
						}));
					}
					list2.Add(treeNode);
					num2++;
				}
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode3 = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode3.Children.Add(this.VisitGroupBinding(e.Input));
				if (list.Count > 0)
				{
					treeNode3.Children.Add(new global::System.Data.Entity.Core.Common.Utils.TreeNode("Keys", list));
				}
				if (list2.Count > 0)
				{
					treeNode3.Children.Add(new global::System.Data.Entity.Core.Common.Utils.TreeNode("Aggregates", list2));
				}
				return treeNode3;
			}

			// Token: 0x06006C57 RID: 27735 RVA: 0x00171854 File Offset: 0x0016FA54
			private global::System.Data.Entity.Core.Common.Utils.TreeNode VisitSortOrder(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("SortOrder", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause in sortOrder)
				{
					global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode2 = this.Visit(dbSortClause.Ascending ? "Asc" : "Desc", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
					{
						dbSortClause.Expression
					});
					if (!string.IsNullOrEmpty(dbSortClause.Collation))
					{
						treeNode2.Text.Append(" : ");
						treeNode2.Text.Append(dbSortClause.Collation);
					}
					treeNode.Children.Add(treeNode2);
				}
				return treeNode;
			}

			// Token: 0x06006C58 RID: 27736 RVA: 0x00171910 File Offset: 0x0016FB10
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode.Children.Add(this.VisitBinding("Input", e.Input));
				treeNode.Children.Add(this.VisitSortOrder(e.SortOrder));
				treeNode.Children.Add(this.Visit("Count", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					e.Count
				}));
				return treeNode;
			}

			// Token: 0x06006C59 RID: 27737 RVA: 0x0017198C File Offset: 0x0016FB8C
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode.Children.Add(this.VisitBinding("Input", e.Input));
				treeNode.Children.Add(this.VisitSortOrder(e.SortOrder));
				return treeNode;
			}

			// Token: 0x06006C5A RID: 27738 RVA: 0x001719E0 File Offset: 0x0016FBE0
			public override global::System.Data.Entity.Core.Common.Utils.TreeNode Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression e)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression>(e, "e");
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.NodeFromExpression(e);
				treeNode.Children.Add(this.VisitBinding("Input", e.Input));
				treeNode.Children.Add(this.Visit("Predicate", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
				{
					e.Predicate
				}));
				return treeNode;
			}

			// Token: 0x040031C2 RID: 12738
			private static readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind, string> _opMap = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionPrinter.PrinterVisitor.InitializeOpMap();

			// Token: 0x040031C3 RID: 12739
			private int _maxStringLength = 80;

			// Token: 0x040031C4 RID: 12740
			private bool _infix = true;
		}
	}
}
