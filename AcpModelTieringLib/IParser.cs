using System;

namespace AcpModelTieringLib
{
	// Token: 0x0200000A RID: 10
	public interface IParser
	{
		// Token: 0x0600003D RID: 61
		global::AcpModelTieringLib.ExpTreeNode ParseExpression(string exp);

		// Token: 0x0600003E RID: 62
		string ReMakeExpression(global::AcpModelTieringLib.ExpTreeNode Tree);

		// Token: 0x0600003F RID: 63
		int Priority(string Operator);

		// Token: 0x06000040 RID: 64
		bool RegisterToken(string Token, global::AcpModelTieringLib.Token tk_type);

		// Token: 0x06000041 RID: 65
		void Clear();
	}
}
