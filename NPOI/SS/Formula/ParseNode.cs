using System;
using NPOI.SS.Formula.PTG;

namespace NPOI.SS.Formula
{
	// Token: 0x020000D8 RID: 216
	internal class ParseNode
	{
		// Token: 0x06000741 RID: 1857 RVA: 0x0001324C File Offset: 0x0001144C
		public ParseNode(global::NPOI.SS.Formula.PTG.Ptg token, global::NPOI.SS.Formula.ParseNode[] children)
		{
			this._token = token;
			this._children = (global::NPOI.SS.Formula.ParseNode[])children.Clone();
			this._isIf = global::NPOI.SS.Formula.ParseNode.IsIf(token);
			int num = 1;
			for (int i = 0; i < children.Length; i++)
			{
				num += children[i].TokenCount;
			}
			if (this._isIf)
			{
				num += children.Length;
			}
			this._tokenCount = num;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000132B3 File Offset: 0x000114B3
		public ParseNode(global::NPOI.SS.Formula.PTG.Ptg token) : this(token, global::NPOI.SS.Formula.ParseNode.EMPTY_ARRAY)
		{
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000132C1 File Offset: 0x000114C1
		public ParseNode(global::NPOI.SS.Formula.PTG.Ptg token, global::NPOI.SS.Formula.ParseNode child0) : this(token, new global::NPOI.SS.Formula.ParseNode[]
		{
			child0
		})
		{
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000132D4 File Offset: 0x000114D4
		public ParseNode(global::NPOI.SS.Formula.PTG.Ptg token, global::NPOI.SS.Formula.ParseNode child0, global::NPOI.SS.Formula.ParseNode child1) : this(token, new global::NPOI.SS.Formula.ParseNode[]
		{
			child0,
			child1
		})
		{
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x000132EB File Offset: 0x000114EB
		private int TokenCount
		{
			get
			{
				return this._tokenCount;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000132F4 File Offset: 0x000114F4
		public int EncodedSize
		{
			get
			{
				int num = (this._token is global::NPOI.SS.Formula.PTG.ArrayPtg) ? 8 : this._token.Size;
				for (int i = 0; i < this._children.Length; i++)
				{
					num += this._children[i].EncodedSize;
				}
				return num;
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00013344 File Offset: 0x00011544
		public static global::NPOI.SS.Formula.PTG.Ptg[] ToTokenArray(global::NPOI.SS.Formula.ParseNode rootNode)
		{
			global::NPOI.SS.Formula.ParseNode.TokenCollector tokenCollector = new global::NPOI.SS.Formula.ParseNode.TokenCollector(rootNode.TokenCount);
			rootNode.CollectPtgs(tokenCollector);
			return tokenCollector.GetResult();
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0001336C File Offset: 0x0001156C
		private void CollectPtgs(global::NPOI.SS.Formula.ParseNode.TokenCollector temp)
		{
			if (global::NPOI.SS.Formula.ParseNode.IsIf(this._token))
			{
				this.CollectIfPtgs(temp);
				return;
			}
			bool flag = this._token is global::NPOI.SS.Formula.PTG.MemFuncPtg || this._token is global::NPOI.SS.Formula.PTG.MemAreaPtg;
			if (flag)
			{
				temp.Add(this._token);
			}
			for (int i = 0; i < this.GetChildren().Length; i++)
			{
				this.GetChildren()[i].CollectPtgs(temp);
			}
			if (!flag)
			{
				temp.Add(this._token);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000133EC File Offset: 0x000115EC
		private void CollectIfPtgs(global::NPOI.SS.Formula.ParseNode.TokenCollector temp)
		{
			this.GetChildren()[0].CollectPtgs(temp);
			int num = temp.CreatePlaceholder();
			this.GetChildren()[1].CollectPtgs(temp);
			int num2 = temp.CreatePlaceholder();
			global::NPOI.SS.Formula.PTG.AttrPtg token = global::NPOI.SS.Formula.PTG.AttrPtg.CreateIf(temp.sumTokenSizes(num + 1, num2) + 4);
			if (this.GetChildren().Length > 2)
			{
				this.GetChildren()[2].CollectPtgs(temp);
				int num3 = temp.CreatePlaceholder();
				global::NPOI.SS.Formula.PTG.AttrPtg token2 = global::NPOI.SS.Formula.PTG.AttrPtg.CreateSkip(temp.sumTokenSizes(num2 + 1, num3) + 4 + 4 - 1);
				global::NPOI.SS.Formula.PTG.AttrPtg token3 = global::NPOI.SS.Formula.PTG.AttrPtg.CreateSkip(3);
				temp.SetPlaceholder(num, token);
				temp.SetPlaceholder(num2, token2);
				temp.SetPlaceholder(num3, token3);
			}
			else
			{
				global::NPOI.SS.Formula.PTG.AttrPtg token4 = global::NPOI.SS.Formula.PTG.AttrPtg.CreateSkip(3);
				temp.SetPlaceholder(num, token);
				temp.SetPlaceholder(num2, token4);
			}
			temp.Add(this.GetToken());
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000134B8 File Offset: 0x000116B8
		private static bool IsIf(global::NPOI.SS.Formula.PTG.Ptg token)
		{
			if (token is global::NPOI.SS.Formula.PTG.FuncVarPtg)
			{
				global::NPOI.SS.Formula.PTG.FuncVarPtg funcVarPtg = (global::NPOI.SS.Formula.PTG.FuncVarPtg)token;
				if ("IF".Equals(funcVarPtg.Name))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000134E9 File Offset: 0x000116E9
		public global::NPOI.SS.Formula.PTG.Ptg GetToken()
		{
			return this._token;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000134F1 File Offset: 0x000116F1
		public global::NPOI.SS.Formula.ParseNode[] GetChildren()
		{
			return this._children;
		}

		// Token: 0x040003DC RID: 988
		public static global::NPOI.SS.Formula.ParseNode[] EMPTY_ARRAY = new global::NPOI.SS.Formula.ParseNode[0];

		// Token: 0x040003DD RID: 989
		private global::NPOI.SS.Formula.PTG.Ptg _token;

		// Token: 0x040003DE RID: 990
		private global::NPOI.SS.Formula.ParseNode[] _children;

		// Token: 0x040003DF RID: 991
		private bool _isIf;

		// Token: 0x040003E0 RID: 992
		private int _tokenCount;

		// Token: 0x02000565 RID: 1381
		private class TokenCollector
		{
			// Token: 0x060033C0 RID: 13248 RVA: 0x000A190A File Offset: 0x0009FB0A
			public TokenCollector(int tokenCount)
			{
				this._ptgs = new global::NPOI.SS.Formula.PTG.Ptg[tokenCount];
				this._offset = 0;
			}

			// Token: 0x060033C1 RID: 13249 RVA: 0x000A1928 File Offset: 0x0009FB28
			public int sumTokenSizes(int fromIx, int ToIx)
			{
				int num = 0;
				for (int i = fromIx; i < ToIx; i++)
				{
					num += this._ptgs[i].Size;
				}
				return num;
			}

			// Token: 0x060033C2 RID: 13250 RVA: 0x000A1954 File Offset: 0x0009FB54
			public int CreatePlaceholder()
			{
				int offset = this._offset;
				this._offset = offset + 1;
				return offset;
			}

			// Token: 0x060033C3 RID: 13251 RVA: 0x000A1972 File Offset: 0x0009FB72
			public void Add(global::NPOI.SS.Formula.PTG.Ptg token)
			{
				if (token == null)
				{
					throw new global::System.ArgumentException("token must not be null");
				}
				this._ptgs[this._offset] = token;
				this._offset++;
			}

			// Token: 0x060033C4 RID: 13252 RVA: 0x000A199E File Offset: 0x0009FB9E
			public void SetPlaceholder(int index, global::NPOI.SS.Formula.PTG.Ptg token)
			{
				if (this._ptgs[index] != null)
				{
					throw new global::System.InvalidOperationException("Invalid placeholder index (" + index.ToString() + ")");
				}
				this._ptgs[index] = token;
			}

			// Token: 0x060033C5 RID: 13253 RVA: 0x000A19CF File Offset: 0x0009FBCF
			public global::NPOI.SS.Formula.PTG.Ptg[] GetResult()
			{
				return this._ptgs;
			}

			// Token: 0x04001895 RID: 6293
			private global::NPOI.SS.Formula.PTG.Ptg[] _ptgs;

			// Token: 0x04001896 RID: 6294
			private int _offset;
		}
	}
}
