using System;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Common.Utils;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006DF RID: 1759
	public sealed class DbSetClause : global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause
	{
		// Token: 0x060051A1 RID: 20897 RVA: 0x00123371 File Offset: 0x00121571
		internal DbSetClause(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression targetProperty, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression sourceValue)
		{
			this._prop = targetProperty;
			this._val = sourceValue;
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x060051A2 RID: 20898 RVA: 0x00123387 File Offset: 0x00121587
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Property
		{
			get
			{
				return this._prop;
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x060051A3 RID: 20899 RVA: 0x0012338F File Offset: 0x0012158F
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x00123398 File Offset: 0x00121598
		internal override void DumpStructure(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper dumper)
		{
			dumper.Begin("DbSetClause");
			if (this.Property != null)
			{
				dumper.Dump(this.Property, "Property");
			}
			if (this.Value != null)
			{
				dumper.Dump(this.Value, "Value");
			}
			dumper.End("DbSetClause");
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x001233F0 File Offset: 0x001215F0
		internal override global::System.Data.Entity.Core.Common.Utils.TreeNode Print(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<global::System.Data.Entity.Core.Common.Utils.TreeNode> visitor)
		{
			global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = new global::System.Data.Entity.Core.Common.Utils.TreeNode("DbSetClause", new global::System.Data.Entity.Core.Common.Utils.TreeNode[0]);
			if (this.Property != null)
			{
				treeNode.Children.Add(new global::System.Data.Entity.Core.Common.Utils.TreeNode("Property", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
				{
					this.Property.Accept<global::System.Data.Entity.Core.Common.Utils.TreeNode>(visitor)
				}));
			}
			if (this.Value != null)
			{
				treeNode.Children.Add(new global::System.Data.Entity.Core.Common.Utils.TreeNode("Value", new global::System.Data.Entity.Core.Common.Utils.TreeNode[]
				{
					this.Value.Accept<global::System.Data.Entity.Core.Common.Utils.TreeNode>(visitor)
				}));
			}
			return treeNode;
		}

		// Token: 0x04001DD1 RID: 7633
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _prop;

		// Token: 0x04001DD2 RID: 7634
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _val;
	}
}
