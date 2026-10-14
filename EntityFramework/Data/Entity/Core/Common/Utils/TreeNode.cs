using System;
using System.Collections.Generic;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x02000601 RID: 1537
	internal class TreeNode
	{
		// Token: 0x06004B4C RID: 19276 RVA: 0x00109790 File Offset: 0x00107990
		internal TreeNode()
		{
			this._text = new global::System.Text.StringBuilder();
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x001097B0 File Offset: 0x001079B0
		internal TreeNode(string text, params global::System.Data.Entity.Core.Common.Utils.TreeNode[] children)
		{
			if (string.IsNullOrEmpty(text))
			{
				this._text = new global::System.Text.StringBuilder();
			}
			else
			{
				this._text = new global::System.Text.StringBuilder(text);
			}
			if (children != null)
			{
				this._children.AddRange(children);
			}
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x001097FE File Offset: 0x001079FE
		internal TreeNode(string text, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode> children) : this(text, new global::System.Data.Entity.Core.Common.Utils.TreeNode[0])
		{
			if (children != null)
			{
				this._children.AddRange(children);
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06004B4F RID: 19279 RVA: 0x0010981C File Offset: 0x00107A1C
		internal global::System.Text.StringBuilder Text
		{
			get
			{
				return this._text;
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06004B50 RID: 19280 RVA: 0x00109824 File Offset: 0x00107A24
		internal global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.Utils.TreeNode> Children
		{
			get
			{
				return this._children;
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06004B51 RID: 19281 RVA: 0x0010982C File Offset: 0x00107A2C
		// (set) Token: 0x06004B52 RID: 19282 RVA: 0x00109834 File Offset: 0x00107A34
		internal int Position { get; set; }

		// Token: 0x04001A55 RID: 6741
		private readonly global::System.Text.StringBuilder _text;

		// Token: 0x04001A56 RID: 6742
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode> _children = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.TreeNode>();
	}
}
