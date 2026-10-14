using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200039E RID: 926
	internal class Dump : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor, global::System.IDisposable
	{
		// Token: 0x06002CFF RID: 11519 RVA: 0x0008F535 File Offset: 0x0008D735
		private Dump(global::System.IO.Stream stream) : this(stream, global::System.Data.Entity.Core.Query.InternalTrees.Dump.DefaultEncoding)
		{
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x0008F544 File Offset: 0x0008D744
		private Dump(global::System.IO.Stream stream, global::System.Text.Encoding encoding)
		{
			this._writer = global::System.Xml.XmlWriter.Create(stream, new global::System.Xml.XmlWriterSettings
			{
				CheckCharacters = false,
				Indent = true,
				Encoding = encoding
			});
			this._writer.WriteStartDocument(true);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x0008F58B File Offset: 0x0008D78B
		internal static string ToXml(global::System.Data.Entity.Core.Query.InternalTrees.Command itree)
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.Dump.ToXml(itree.Root);
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x0008F598 File Offset: 0x0008D798
		internal static string ToXml(global::System.Data.Entity.Core.Query.InternalTrees.Node subtree)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			using (global::System.Data.Entity.Core.Query.InternalTrees.Dump dump = new global::System.Data.Entity.Core.Query.InternalTrees.Dump(memoryStream))
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dump, "nodes"))
				{
					dump.VisitNode(subtree);
				}
			}
			return global::System.Data.Entity.Core.Query.InternalTrees.Dump.DefaultEncoding.GetString(memoryStream.ToArray());
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x0008F60C File Offset: 0x0008D80C
		void global::System.IDisposable.Dispose()
		{
			global::System.GC.SuppressFinalize(this);
			try
			{
				this._writer.WriteEndDocument();
				this._writer.Flush();
				this._writer.Close();
			}
			catch (global::System.Exception e)
			{
				if (!e.IsCatchableExceptionType())
				{
					throw;
				}
			}
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x0008F660 File Offset: 0x0008D860
		internal void Begin(string name, global::System.Collections.Generic.Dictionary<string, object> attrs)
		{
			this._writer.WriteStartElement(name);
			if (attrs != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in attrs)
				{
					this._writer.WriteAttributeString(keyValuePair.Key, keyValuePair.Value.ToString());
				}
			}
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x0008F6D4 File Offset: 0x0008D8D4
		internal void BeginExpression()
		{
			this.WriteString("(");
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x0008F6E1 File Offset: 0x0008D8E1
		internal void EndExpression()
		{
			this.WriteString(")");
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x0008F6EE File Offset: 0x0008D8EE
		internal void End()
		{
			this._writer.WriteEndElement();
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x0008F6FB File Offset: 0x0008D8FB
		internal void WriteString(string value)
		{
			this._writer.WriteString(value);
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x0008F70C File Offset: 0x0008D90C
		protected override void VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, n.Op))
			{
				base.VisitDefault(n);
			}
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x0008F750 File Offset: 0x0008D950
		protected override void VisitScalarOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoString(this, op))
			{
				string value = string.Empty;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
				{
					this.WriteString(value);
					this.VisitNode(n2);
					value = ",";
				}
			}
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x0008F7DC File Offset: 0x0008D9DC
		protected override void VisitJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op))
			{
				if (n.Children.Count > 2)
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "condition"))
					{
						this.VisitNode(n.Child2);
					}
				}
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "input"))
				{
					this.VisitNode(n.Child0);
				}
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "input"))
				{
					this.VisitNode(n.Child1);
				}
			}
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x0008F8BC File Offset: 0x0008DABC
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op))
			{
				int i = 0;
				while (i < n.Children.Count)
				{
					if (i + 1 < n.Children.Count)
					{
						using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "when"))
						{
							this.VisitNode(n.Children[i++]);
						}
						using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "then"))
						{
							this.VisitNode(n.Children[i++]);
							continue;
						}
					}
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "else"))
					{
						this.VisitNode(n.Children[i++]);
					}
				}
			}
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x0008F9D4 File Offset: 0x0008DBD4
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op))
			{
				this.VisitChildren(n);
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x0008FA14 File Offset: 0x0008DC14
		protected override void VisitConstantOp(global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoString(this, op))
			{
				if (op.Value == null)
				{
					this.WriteString("null");
				}
				else
				{
					this.WriteString("(");
					this.WriteString(op.Type.EdmType.FullName);
					this.WriteString(")");
					this.WriteString(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
					{
						op.Value
					}));
				}
				this.VisitChildren(n);
			}
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x0008FAB8 File Offset: 0x0008DCB8
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string value = string.Empty;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in op.Keys)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(var.Id);
				value = ",";
			}
			if (stringBuilder.Length != 0)
			{
				dictionary.Add("Keys", stringBuilder.ToString());
			}
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op, dictionary))
			{
				this.VisitChildren(n);
			}
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x0008FB74 File Offset: 0x0008DD74
		protected override void VisitGroupByOp(global::System.Data.Entity.Core.Query.InternalTrees.GroupByBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string value = string.Empty;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in op.Keys)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(var.Id);
				value = ",";
			}
			if (stringBuilder.Length != 0)
			{
				dictionary.Add("Keys", stringBuilder.ToString());
			}
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op, dictionary))
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "outputs"))
				{
					foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in op.Outputs)
					{
						this.DumpVar(v);
					}
				}
				this.VisitChildren(n);
			}
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x0008FC94 File Offset: 0x0008DE94
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op.IsOfOnly ? "IsOfOnly" : "IsOf"))
			{
				string value = string.Empty;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
				{
					this.WriteString(value);
					this.VisitNode(n2);
					value = ",";
				}
			}
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x0008FD30 File Offset: 0x0008DF30
		protected override void VisitNestOp(global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp singleStreamNestOp = op as global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp;
			if (singleStreamNestOp != null)
			{
				dictionary.Add("Discriminator", (singleStreamNestOp.Discriminator == null) ? "<null>" : singleStreamNestOp.Discriminator.ToString());
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (singleStreamNestOp != null)
			{
				stringBuilder.Length = 0;
				string value = string.Empty;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in singleStreamNestOp.Keys)
				{
					stringBuilder.Append(value);
					stringBuilder.Append(var.Id);
					value = ",";
				}
				if (stringBuilder.Length != 0)
				{
					dictionary.Add("Keys", stringBuilder.ToString());
				}
			}
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op, dictionary))
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "outputs"))
				{
					foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in op.Outputs)
					{
						this.DumpVar(v);
					}
				}
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo in op.CollectionInfo)
				{
					global::System.Collections.Generic.Dictionary<string, object> dictionary2 = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary2.Add("CollectionVar", collectionInfo.CollectionVar);
					if (collectionInfo.DiscriminatorValue != null)
					{
						dictionary2.Add("DiscriminatorValue", collectionInfo.DiscriminatorValue);
					}
					if (collectionInfo.FlattenedElementVars.Count != 0)
					{
						dictionary2.Add("FlattenedElementVars", global::System.Data.Entity.Core.Query.InternalTrees.Dump.FormatVarList(stringBuilder, collectionInfo.FlattenedElementVars));
					}
					if (collectionInfo.Keys.Count != 0)
					{
						dictionary2.Add("Keys", collectionInfo.Keys);
					}
					if (collectionInfo.SortKeys.Count != 0)
					{
						dictionary2.Add("SortKeys", global::System.Data.Entity.Core.Query.InternalTrees.Dump.FormatVarList(stringBuilder, collectionInfo.SortKeys));
					}
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "collection", dictionary2))
					{
						collectionInfo.ColumnMap.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Dump>(global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.Instance, this);
					}
				}
				this.VisitChildren(n);
			}
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00090000 File Offset: 0x0008E200
		private static string FormatVarList(global::System.Text.StringBuilder sb, global::System.Data.Entity.Core.Query.InternalTrees.VarList varList)
		{
			sb.Length = 0;
			string value = string.Empty;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in varList)
			{
				sb.Append(value);
				sb.Append(var.Id);
				value = ",";
			}
			return sb.ToString();
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00090078 File Offset: 0x0008E278
		private static string FormatVarList(global::System.Text.StringBuilder sb, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> varList)
		{
			sb.Length = 0;
			string value = string.Empty;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in varList)
			{
				sb.Append(value);
				sb.Append(sortKey.Var.Id);
				value = ",";
			}
			return sb.ToString();
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000900F4 File Offset: 0x0008E2F4
		private void VisitNewOp(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op))
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "argument", null))
					{
						this.VisitNode(n2);
					}
				}
			}
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x00090194 File Offset: 0x0008E394
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitNewOp(op, n);
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x0009019E File Offset: 0x0008E39E
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewInstanceOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitNewOp(op, n);
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x000901A8 File Offset: 0x0008E3A8
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitNewOp(op, n);
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x000901B2 File Offset: 0x0008E3B2
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewMultisetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitNewOp(op, n);
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x000901BC File Offset: 0x0008E3BC
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitNewOp(op, n);
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000901C8 File Offset: 0x0008E3C8
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op))
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "outputs"))
				{
					foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in op.Outputs)
					{
						this.DumpVar(v);
					}
				}
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "columnMap"))
				{
					op.ColumnMap.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Dump>(global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.Instance, this);
				}
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "input"))
				{
					this.VisitChildren(n);
				}
			}
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000902CC File Offset: 0x0008E4CC
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op))
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "outputs"))
				{
					foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in op.Outputs)
					{
						this.DumpVar(v);
					}
				}
				this.VisitChildren(n);
			}
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x0009036C File Offset: 0x0008E56C
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoString(this, op))
			{
				this.VisitChildren(n);
				this.WriteString(".");
				this.WriteString(op.PropertyInfo.Name);
			}
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000903C8 File Offset: 0x0008E5C8
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoString(this, op))
			{
				this.VisitChildren(n);
				this.WriteString(".NAVIGATE(");
				this.WriteString(op.PropertyInfo.Relationship.Name);
				this.WriteString(",");
				this.WriteString(op.PropertyInfo.FromEnd.Name);
				this.WriteString(",");
				this.WriteString(op.PropertyInfo.ToEnd.Name);
				this.WriteString(")");
			}
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00090474 File Offset: 0x0008E674
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op))
			{
				this.DumpTable(op.Table);
				this.VisitChildren(n);
			}
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000904C0 File Offset: 0x0008E6C0
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op))
			{
				this.DumpTable(op.Table);
				this.VisitChildren(n);
			}
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x0009050C File Offset: 0x0008E70C
		protected override void VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll == op.OpType)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp unionAllOp = (global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp)op;
				if (unionAllOp.BranchDiscriminator != null)
				{
					dictionary.Add("branchDiscriminator", unionAllOp.BranchDiscriminator);
				}
			}
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op, dictionary))
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "outputs"))
				{
					foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in op.Outputs)
					{
						this.DumpVar(v);
					}
				}
				int num = 0;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "input", new global::System.Collections.Generic.Dictionary<string, object>
					{
						{
							"VarMap",
							op.VarMap[num++].ToString()
						}
					}))
					{
						this.VisitNode(n2);
					}
				}
			}
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x00090674 File Offset: 0x0008E874
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op))
			{
				base.Visit(op, n);
			}
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x000906B4 File Offset: 0x0008E8B4
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op, new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					"WithTies",
					op.WithTies
				}
			}))
			{
				base.Visit(op, n);
			}
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00090710 File Offset: 0x0008E910
		protected override void VisitSortOp(global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "keys"))
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in op.Keys)
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "sortKey", new global::System.Collections.Generic.Dictionary<string, object>
					{
						{
							"Var",
							sortKey.Var
						},
						{
							"Ascending",
							sortKey.AscendingSort
						},
						{
							"Collation",
							sortKey.Collation
						}
					}))
					{
					}
				}
			}
			this.VisitChildren(n);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x000907F4 File Offset: 0x0008E9F4
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (op.Var != null)
			{
				dictionary.Add("Var", op.Var.Id);
			}
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op, dictionary))
			{
				this.DumpTable(op.Table);
				this.VisitChildren(n);
			}
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00090868 File Offset: 0x0008EA68
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, op, new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					"Var",
					op.Var.Id
				}
			}))
			{
				this.VisitChildren(n);
			}
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x000908C8 File Offset: 0x0008EAC8
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoString(this, op))
			{
				this.VisitChildren(n);
				if (op.Type != null)
				{
					this.WriteString("Type=");
					this.WriteString(op.Type.ToString());
					this.WriteString(", ");
				}
				this.WriteString("Var=");
				this.WriteString(op.Var.Id.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			}
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x00090960 File Offset: 0x0008EB60
		private void DumpVar(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("Var", v.Id);
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar columnVar = v as global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar;
			if (columnVar != null)
			{
				dictionary.Add("Name", columnVar.ColumnMetadata.Name);
				dictionary.Add("Type", columnVar.ColumnMetadata.Type.ToString());
			}
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, v.GetType().Name, dictionary))
			{
			}
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x000909F8 File Offset: 0x0008EBF8
		private void DumpVars(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> vars)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in vars)
			{
				this.DumpVar(v);
			}
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00090A48 File Offset: 0x0008EC48
		private void DumpTable(global::System.Data.Entity.Core.Query.InternalTrees.Table table)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("Table", table.TableId);
			if (table.TableMetadata.Extent != null)
			{
				dictionary.Add("Extent", table.TableMetadata.Extent.Name);
			}
			using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(this, "Table", dictionary))
			{
				this.DumpVars(table.Columns);
			}
		}

		// Token: 0x04000F1E RID: 3870
		private readonly global::System.Xml.XmlWriter _writer;

		// Token: 0x04000F1F RID: 3871
		internal static readonly global::System.Text.Encoding DefaultEncoding = global::System.Text.Encoding.UTF8;

		// Token: 0x02000A03 RID: 2563
		internal class ColumnMapDumper : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<global::System.Data.Entity.Core.Query.InternalTrees.Dump>
		{
			// Token: 0x06006093 RID: 24723 RVA: 0x0014AB43 File Offset: 0x00148D43
			private ColumnMapDumper()
			{
			}

			// Token: 0x06006094 RID: 24724 RVA: 0x0014AB4C File Offset: 0x00148D4C
			private void DumpCollection(global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				if (columnMap.ForeignKeys.Length != 0)
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "foreignKeys"))
					{
						base.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.ForeignKeys, dumper);
					}
				}
				if (columnMap.Keys.Length != 0)
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "keys"))
					{
						base.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.Keys, dumper);
					}
				}
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "element"))
				{
					columnMap.Element.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Dump>(this, dumper);
				}
			}

			// Token: 0x06006095 RID: 24725 RVA: 0x0014AC14 File Offset: 0x00148E14
			private static global::System.Collections.Generic.Dictionary<string, object> GetAttributes(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap)
			{
				return new global::System.Collections.Generic.Dictionary<string, object>
				{
					{
						"Type",
						columnMap.Type.ToString()
					}
				};
			}

			// Token: 0x06006096 RID: 24726 RVA: 0x0014AC34 File Offset: 0x00148E34
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComplexTypeColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "ComplexType", global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.GetAttributes(columnMap)))
				{
					if (columnMap.NullSentinel != null)
					{
						using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "nullSentinel"))
						{
							columnMap.NullSentinel.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Dump>(this, dumper);
						}
					}
					base.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, dumper);
				}
			}

			// Token: 0x06006097 RID: 24727 RVA: 0x0014ACC0 File Offset: 0x00148EC0
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedCollectionColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "DiscriminatedCollection", global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.GetAttributes(columnMap)))
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "discriminator", new global::System.Collections.Generic.Dictionary<string, object>
					{
						{
							"Value",
							columnMap.DiscriminatorValue
						}
					}))
					{
						columnMap.Discriminator.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Dump>(this, dumper);
					}
					this.DumpCollection(columnMap, dumper);
				}
			}

			// Token: 0x06006098 RID: 24728 RVA: 0x0014AD58 File Offset: 0x00148F58
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.EntityColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "Entity", global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.GetAttributes(columnMap)))
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "entityIdentity"))
					{
						base.VisitEntityIdentity(columnMap.EntityIdentity, dumper);
					}
					base.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, dumper);
				}
			}

			// Token: 0x06006099 RID: 24729 RVA: 0x0014ADDC File Offset: 0x00148FDC
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimplePolymorphicColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "SimplePolymorphic", global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.GetAttributes(columnMap)))
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "typeDiscriminator"))
					{
						columnMap.TypeDiscriminator.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Dump>(this, dumper);
					}
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> keyValuePair in columnMap.TypeChoices)
					{
						dictionary.Clear();
						dictionary.Add("DiscriminatorValue", keyValuePair.Key);
						using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "choice", dictionary))
						{
							keyValuePair.Value.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Dump>(this, dumper);
						}
					}
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "default"))
					{
						base.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, dumper);
					}
				}
			}

			// Token: 0x0600609A RID: 24730 RVA: 0x0014AF18 File Offset: 0x00149118
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultipleDiscriminatorPolymorphicColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "MultipleDiscriminatorPolymorphic", global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.GetAttributes(columnMap)))
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "typeDiscriminators"))
					{
						base.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(columnMap.TypeDiscriminators, dumper);
					}
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Query.InternalTrees.TypedColumnMap> keyValuePair in columnMap.TypeChoices)
					{
						dictionary.Clear();
						dictionary.Add("EntityType", keyValuePair.Key);
						using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "choice", dictionary))
						{
							keyValuePair.Value.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Dump>(this, dumper);
						}
					}
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "default"))
					{
						base.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, dumper);
					}
				}
			}

			// Token: 0x0600609B RID: 24731 RVA: 0x0014B054 File Offset: 0x00149254
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.RecordColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "Record", global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.GetAttributes(columnMap)))
				{
					if (columnMap.NullSentinel != null)
					{
						using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "nullSentinel"))
						{
							columnMap.NullSentinel.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Dump>(this, dumper);
						}
					}
					base.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap>(columnMap.Properties, dumper);
				}
			}

			// Token: 0x0600609C RID: 24732 RVA: 0x0014B0E0 File Offset: 0x001492E0
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "Ref", global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.GetAttributes(columnMap)))
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "entityIdentity"))
					{
						base.VisitEntityIdentity(columnMap.EntityIdentity, dumper);
					}
				}
			}

			// Token: 0x0600609D RID: 24733 RVA: 0x0014B154 File Offset: 0x00149354
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "SimpleCollection", global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.GetAttributes(columnMap)))
				{
					this.DumpCollection(columnMap, dumper);
				}
			}

			// Token: 0x0600609E RID: 24734 RVA: 0x0014B19C File Offset: 0x0014939C
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				global::System.Collections.Generic.Dictionary<string, object> attributes = global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.GetAttributes(columnMap);
				attributes.Add("CommandId", columnMap.CommandId);
				attributes.Add("ColumnPos", columnMap.ColumnPos);
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "AssignedSimple", attributes))
				{
				}
			}

			// Token: 0x0600609F RID: 24735 RVA: 0x0014B20C File Offset: 0x0014940C
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				global::System.Collections.Generic.Dictionary<string, object> attributes = global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper.GetAttributes(columnMap);
				attributes.Add("Var", columnMap.Var.Id);
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "VarRef", attributes))
				{
				}
			}

			// Token: 0x060060A0 RID: 24736 RVA: 0x0014B26C File Offset: 0x0014946C
			protected override void VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedEntityIdentity entityIdentity, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "DiscriminatedEntityIdentity"))
				{
					using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "entitySetId"))
					{
						entityIdentity.EntitySetColumnMap.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Dump>(this, dumper);
					}
					if (entityIdentity.Keys.Length != 0)
					{
						using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "keys"))
						{
							base.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(entityIdentity.Keys, dumper);
						}
					}
				}
			}

			// Token: 0x060060A1 RID: 24737 RVA: 0x0014B31C File Offset: 0x0014951C
			protected override void VisitEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.SimpleEntityIdentity entityIdentity, global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper)
			{
				using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "SimpleEntityIdentity"))
				{
					if (entityIdentity.Keys.Length != 0)
					{
						using (new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, "keys"))
						{
							base.VisitList<global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap>(entityIdentity.Keys, dumper);
						}
					}
				}
			}

			// Token: 0x04002905 RID: 10501
			internal static global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper Instance = new global::System.Data.Entity.Core.Query.InternalTrees.Dump.ColumnMapDumper();
		}

		// Token: 0x02000A04 RID: 2564
		internal struct AutoString : global::System.IDisposable
		{
			// Token: 0x060060A3 RID: 24739 RVA: 0x0014B3A0 File Offset: 0x001495A0
			internal AutoString(global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper, global::System.Data.Entity.Core.Query.InternalTrees.Op op)
			{
				this._dumper = dumper;
				this._dumper.WriteString(global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoString.ToString(op.OpType));
				this._dumper.BeginExpression();
			}

			// Token: 0x060060A4 RID: 24740 RVA: 0x0014B3CC File Offset: 0x001495CC
			public void Dispose()
			{
				try
				{
					this._dumper.EndExpression();
				}
				catch (global::System.Exception e)
				{
					if (!e.IsCatchableExceptionType())
					{
						throw;
					}
				}
			}

			// Token: 0x060060A5 RID: 24741 RVA: 0x0014B404 File Offset: 0x00149604
			internal static string ToString(global::System.Data.Entity.Core.Query.InternalTrees.OpType op)
			{
				switch (op)
				{
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant:
					return "Constant";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.InternalConstant:
					return "InternalConstant";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel:
					return "NullSentinel";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null:
					return "Null";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstantPredicate:
					return "ConstantPredicate";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef:
					return "VarRef";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.GT:
					return "GT";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.GE:
					return "GE";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.LE:
					return "LE";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.LT:
					return "LT";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ:
					return "EQ";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.NE:
					return "NE";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Like:
					return "Like";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Plus:
					return "Plus";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Minus:
					return "Minus";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Multiply:
					return "Multiply";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Divide:
					return "Divide";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Modulo:
					return "Modulo";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnaryMinus:
					return "UnaryMinus";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.And:
					return "And";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Or:
					return "Or";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.In:
					return "In";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not:
					return "Not";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull:
					return "IsNull";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Case:
					return "Case";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Treat:
					return "Treat";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsOf:
					return "IsOf";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Cast:
					return "Cast";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.SoftCast:
					return "SoftCast";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Aggregate:
					return "Aggregate";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Function:
					return "Function";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.RelProperty:
					return "RelProperty";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Property:
					return "Property";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewEntity:
					return "NewEntity";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewInstance:
					return "NewInstance";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.DiscriminatedNewEntity:
					return "DiscriminatedNewEntity";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewMultiset:
					return "NewMultiset";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewRecord:
					return "NewRecord";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetRefKey:
					return "GetRefKey";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetEntityRef:
					return "GetEntityRef";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Ref:
					return "Ref";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Exists:
					return "Exists";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Element:
					return "Element";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Collect:
					return "Collect";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Deref:
					return "Deref";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Navigate:
					return "Navigate";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable:
					return "ScanTable";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanView:
					return "ScanView";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Filter:
					return "Filter";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project:
					return "Project";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin:
					return "InnerJoin";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin:
					return "LeftOuterJoin";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.FullOuterJoin:
					return "FullOuterJoin";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin:
					return "CrossJoin";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossApply:
					return "CrossApply";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.OuterApply:
					return "OuterApply";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Unnest:
					return "Unnest";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort:
					return "Sort";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort:
					return "ConstrainedSort";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupBy:
					return "GroupBy";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupByInto:
					return "GroupByInto";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll:
					return "UnionAll";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect:
					return "Intersect";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except:
					return "Except";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Distinct:
					return "Distinct";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleRow:
					return "SingleRow";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleRowTable:
					return "SingleRowTable";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarDef:
					return "VarDef";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarDefList:
					return "VarDefList";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Leaf:
					return "Leaf";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject:
					return "PhysicalProject";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleStreamNest:
					return "SingleStreamNest";
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.MultiStreamNest:
					return "MultiStreamNest";
				default:
					return op.ToString();
				}
			}

			// Token: 0x04002906 RID: 10502
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.Dump _dumper;
		}

		// Token: 0x02000A05 RID: 2565
		internal struct AutoXml : global::System.IDisposable
		{
			// Token: 0x060060A6 RID: 24742 RVA: 0x0014B704 File Offset: 0x00149904
			internal AutoXml(global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper, global::System.Data.Entity.Core.Query.InternalTrees.Op op)
			{
				this._dumper = dumper;
				this._nodeName = global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoString.ToString(op.OpType);
				global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				if (op.Type != null)
				{
					dictionary.Add("Type", op.Type.ToString());
				}
				this._dumper.Begin(this._nodeName, dictionary);
			}

			// Token: 0x060060A7 RID: 24743 RVA: 0x0014B760 File Offset: 0x00149960
			internal AutoXml(global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper, global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Collections.Generic.Dictionary<string, object> attrs)
			{
				this._dumper = dumper;
				this._nodeName = global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoString.ToString(op.OpType);
				global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				if (op.Type != null)
				{
					dictionary.Add("Type", op.Type.ToString());
				}
				foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in attrs)
				{
					dictionary.Add(keyValuePair.Key, keyValuePair.Value);
				}
				this._dumper.Begin(this._nodeName, dictionary);
			}

			// Token: 0x060060A8 RID: 24744 RVA: 0x0014B80C File Offset: 0x00149A0C
			internal AutoXml(global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper, string nodeName)
			{
				this = new global::System.Data.Entity.Core.Query.InternalTrees.Dump.AutoXml(dumper, nodeName, null);
			}

			// Token: 0x060060A9 RID: 24745 RVA: 0x0014B817 File Offset: 0x00149A17
			internal AutoXml(global::System.Data.Entity.Core.Query.InternalTrees.Dump dumper, string nodeName, global::System.Collections.Generic.Dictionary<string, object> attrs)
			{
				this._dumper = dumper;
				this._nodeName = nodeName;
				this._dumper.Begin(this._nodeName, attrs);
			}

			// Token: 0x060060AA RID: 24746 RVA: 0x0014B839 File Offset: 0x00149A39
			public void Dispose()
			{
				this._dumper.End();
			}

			// Token: 0x04002907 RID: 10503
			private readonly string _nodeName;

			// Token: 0x04002908 RID: 10504
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.Dump _dumper;
		}
	}
}
