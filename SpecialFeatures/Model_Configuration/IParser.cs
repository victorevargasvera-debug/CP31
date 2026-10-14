using System;

namespace SpecialFeatures.Model_Configuration
{
	// Token: 0x020000B5 RID: 181
	public interface IParser
	{
		// Token: 0x06000BFA RID: 3066
		global::SpecialFeatures.Model_Configuration.ExpTreeNode ParseExpression(string exp);

		// Token: 0x06000BFB RID: 3067
		string ReMakeExpression(global::SpecialFeatures.Model_Configuration.ExpTreeNode Tree);

		// Token: 0x06000BFC RID: 3068
		int Priority(string Operator);

		// Token: 0x06000BFD RID: 3069
		bool RegisterToken(string Token, global::SpecialFeatures.Model_Configuration.Token tk_type);

		// Token: 0x06000BFE RID: 3070
		void Clear();
	}
}
