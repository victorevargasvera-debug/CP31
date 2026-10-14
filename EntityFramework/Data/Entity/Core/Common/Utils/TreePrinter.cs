using System;
using System.Collections.Generic;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x02000602 RID: 1538
	internal abstract class TreePrinter
	{
		// Token: 0x06004B53 RID: 19283 RVA: 0x00109840 File Offset: 0x00107A40
		internal virtual string Print(global::System.Data.Entity.Core.Common.Utils.TreeNode node)
		{
			this.PreProcess(node);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this.PrintNode(stringBuilder, node);
			return stringBuilder.ToString();
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x00109868 File Offset: 0x00107A68
		internal virtual void PreProcess(global::System.Data.Entity.Core.Common.Utils.TreeNode node)
		{
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x0010986A File Offset: 0x00107A6A
		internal virtual void AfterAppend(global::System.Data.Entity.Core.Common.Utils.TreeNode node, global::System.Text.StringBuilder text)
		{
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x0010986C File Offset: 0x00107A6C
		internal virtual void BeforeAppend(global::System.Data.Entity.Core.Common.Utils.TreeNode node, global::System.Text.StringBuilder text)
		{
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x0010986E File Offset: 0x00107A6E
		internal virtual void PrintNode(global::System.Text.StringBuilder text, global::System.Data.Entity.Core.Common.Utils.TreeNode node)
		{
			this.IndentLine(text);
			this.BeforeAppend(node, text);
			text.Append(node.Text);
			this.AfterAppend(node, text);
			this.PrintChildren(text, node);
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x0010989C File Offset: 0x00107A9C
		internal virtual void PrintChildren(global::System.Text.StringBuilder text, global::System.Data.Entity.Core.Common.Utils.TreeNode node)
		{
			this._scopes.Add(node);
			node.Position = 0;
			foreach (global::System.Data.Entity.Core.Common.Utils.TreeNode node2 in node.Children)
			{
				text.AppendLine();
				int position = node.Position;
				node.Position = position + 1;
				this.PrintNode(text, node2);
			}
			this._scopes.RemoveAt(this._scopes.Count - 1);
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x0010992C File Offset: 0x00107B2C
		private void IndentLine(global::System.Text.StringBuilder text)
		{
			int num = 0;
			for (int i = 0; i < this._scopes.Count; i++)
			{
				global::System.Data.Entity.Core.Common.Utils.TreeNode treeNode = this._scopes[i];
				if (!this._showLines || (treeNode.Position == treeNode.Children.Count && i != this._scopes.Count - 1))
				{
					text.Append(' ');
				}
				else
				{
					text.Append(this._verticals);
				}
				num++;
				if (this._scopes.Count == num && this._showLines)
				{
					text.Append(this._horizontals);
				}
				else
				{
					text.Append(' ');
				}
			}
		}

		// Token: 0x04001A58 RID: 6744
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode> _scopes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode>();

		// Token: 0x04001A59 RID: 6745
		private bool _showLines = true;

		// Token: 0x04001A5A RID: 6746
		private char _horizontals = '_';

		// Token: 0x04001A5B RID: 6747
		private char _verticals = '|';
	}
}
