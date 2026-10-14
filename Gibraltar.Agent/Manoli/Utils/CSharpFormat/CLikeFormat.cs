using System;

namespace Manoli.Utils.CSharpFormat
{
	// Token: 0x0200047A RID: 1146
	internal abstract class CLikeFormat : global::Manoli.Utils.CSharpFormat.CodeFormat
	{
		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x000B90D0 File Offset: 0x000B72D0
		protected override string CommentRegEx
		{
			get
			{
				return "/\\*.*?\\*/|//.*?(?=\\r|\\n)";
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x060032AB RID: 12971 RVA: 0x000B90D8 File Offset: 0x000B72D8
		protected override string StringRegEx
		{
			get
			{
				return "@?\"\"|@?\".*?(?!\\\\).\"|''|'.*?(?!\\\\).'";
			}
		}
	}
}
