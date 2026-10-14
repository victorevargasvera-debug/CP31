using System;
using NPOI.SS.Formula.PTG;

namespace NPOI.HSSF.Model
{
	// Token: 0x02000333 RID: 819
	internal class ParseNode
	{
		// Token: 0x06001757 RID: 5975 RVA: 0x00045E08 File Offset: 0x00044008
		public ParseNode(global::NPOI.SS.Formula.PTG.Ptg token, global::NPOI.HSSF.Model.ParseNode[] children)
		{
			this._token = token;
			this._children = children;
			this._isIf = global::NPOI.HSSF.Model.ParseNode.IsIf(token);
			int num = 1;
			for (int i = 0; i < children.Length; i++)
			{
				num += children[i].GetTokenCount();
			}
			if (this._isIf)
			{
				num += children.Length;
			}
			this._tokenCount = num;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00045E65 File Offset: 0x00044065
		public ParseNode(global::NPOI.SS.Formula.PTG.Ptg token) : this(token, global::NPOI.HSSF.Model.ParseNode.EMPTY_ARRAY)
		{
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00045E73 File Offset: 0x00044073
		public ParseNode(global::NPOI.SS.Formula.PTG.Ptg token, global::NPOI.HSSF.Model.ParseNode child0) : this(token, new global::NPOI.HSSF.Model.ParseNode[]
		{
			child0
		})
		{
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00045E86 File Offset: 0x00044086
		public ParseNode(global::NPOI.SS.Formula.PTG.Ptg token, global::NPOI.HSSF.Model.ParseNode child0, global::NPOI.HSSF.Model.ParseNode child1) : this(token, new global::NPOI.HSSF.Model.ParseNode[]
		{
			child0,
			child1
		})
		{
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00045E9D File Offset: 0x0004409D
		private int GetTokenCount()
		{
			return this._tokenCount;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00045EA8 File Offset: 0x000440A8
		public static global::NPOI.SS.Formula.PTG.Ptg[] ToTokenArray(global::NPOI.HSSF.Model.ParseNode rootNode)
		{
			global::NPOI.HSSF.Model.ParseNode.TokenCollector tokenCollector = new global::NPOI.HSSF.Model.ParseNode.TokenCollector(rootNode.GetTokenCount());
			rootNode.CollectPtgs(tokenCollector);
			return tokenCollector.Result;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00045ED0 File Offset: 0x000440D0
		private void CollectPtgs(global::NPOI.HSSF.Model.ParseNode.TokenCollector temp)
		{
			if (global::NPOI.HSSF.Model.ParseNode.IsIf(this.Token))
			{
				this.CollectIfPtgs(temp);
				return;
			}
			for (int i = 0; i < this.Children.Length; i++)
			{
				this.Children[i].CollectPtgs(temp);
			}
			temp.Add(this.Token);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00045F20 File Offset: 0x00044120
		private void CollectIfPtgs(global::NPOI.HSSF.Model.ParseNode.TokenCollector temp)
		{
			this.Children[0].CollectPtgs(temp);
			int num = temp.CreatePlaceholder();
			this.Children[1].CollectPtgs(temp);
			int num2 = temp.CreatePlaceholder();
			global::NPOI.SS.Formula.PTG.AttrPtg token = global::NPOI.SS.Formula.PTG.AttrPtg.CreateIf(temp.SumTokenSizes(num + 1, num2) + 4);
			if (this.Children.Length > 2)
			{
				this.Children[2].CollectPtgs(temp);
				int num3 = temp.CreatePlaceholder();
				global::NPOI.SS.Formula.PTG.AttrPtg token2 = global::NPOI.SS.Formula.PTG.AttrPtg.CreateSkip(temp.SumTokenSizes(num2 + 1, num3) + 4 + 4 - 1);
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
			temp.Add(this._token);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00045FEC File Offset: 0x000441EC
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

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0004601D File Offset: 0x0004421D
		public global::NPOI.SS.Formula.PTG.Ptg Token
		{
			get
			{
				return this._token;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x00046025 File Offset: 0x00044225
		public global::NPOI.HSSF.Model.ParseNode[] Children
		{
			get
			{
				return this._children;
			}
		}

		// Token: 0x0400099C RID: 2460
		public static global::NPOI.HSSF.Model.ParseNode[] EMPTY_ARRAY = new global::NPOI.HSSF.Model.ParseNode[0];

		// Token: 0x0400099D RID: 2461
		private global::NPOI.SS.Formula.PTG.Ptg _token;

		// Token: 0x0400099E RID: 2462
		private global::NPOI.HSSF.Model.ParseNode[] _children;

		// Token: 0x0400099F RID: 2463
		private bool _isIf;

		// Token: 0x040009A0 RID: 2464
		private int _tokenCount;

		// Token: 0x020005C5 RID: 1477
		private class TokenCollector
		{
			// Token: 0x060034F3 RID: 13555 RVA: 0x000A4A88 File Offset: 0x000A2C88
			public TokenCollector(int tokenCount)
			{
				this._ptgs = new global::NPOI.SS.Formula.PTG.Ptg[tokenCount];
				this._offset = 0;
			}

			// Token: 0x060034F4 RID: 13556 RVA: 0x000A4AA4 File Offset: 0x000A2CA4
			public int SumTokenSizes(int fromIx, int toIx)
			{
				int num = 0;
				for (int i = fromIx; i < toIx; i++)
				{
					num += this._ptgs[i].Size;
				}
				return num;
			}

			// Token: 0x060034F5 RID: 13557 RVA: 0x000A4AD0 File Offset: 0x000A2CD0
			public int CreatePlaceholder()
			{
				int offset = this._offset;
				this._offset = offset + 1;
				return offset;
			}

			// Token: 0x060034F6 RID: 13558 RVA: 0x000A4AEE File Offset: 0x000A2CEE
			public void Add(global::NPOI.SS.Formula.PTG.Ptg token)
			{
				if (token == null)
				{
					throw new global::System.ArgumentException("token must not be null");
				}
				this._ptgs[this._offset] = token;
				this._offset++;
			}

			// Token: 0x060034F7 RID: 13559 RVA: 0x000A4B1A File Offset: 0x000A2D1A
			public void SetPlaceholder(int index, global::NPOI.SS.Formula.PTG.Ptg token)
			{
				if (this._ptgs[index] != null)
				{
					throw new global::System.InvalidOperationException("Invalid placeholder index (" + index.ToString() + ")");
				}
				this._ptgs[index] = token;
			}

			// Token: 0x17000DC1 RID: 3521
			// (get) Token: 0x060034F8 RID: 13560 RVA: 0x000A4B4B File Offset: 0x000A2D4B
			public global::NPOI.SS.Formula.PTG.Ptg[] Result
			{
				get
				{
					return this._ptgs;
				}
			}

			// Token: 0x0400197C RID: 6524
			private global::NPOI.SS.Formula.PTG.Ptg[] _ptgs;

			// Token: 0x0400197D RID: 6525
			private int _offset;
		}
	}
}
