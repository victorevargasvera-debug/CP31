using System;

namespace Manoli.Utils.CSharpFormat
{
	// Token: 0x0200047D RID: 1149
	internal class JavaScriptFormat : global::Manoli.Utils.CSharpFormat.CLikeFormat
	{
		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x060032B3 RID: 12979 RVA: 0x000B938C File Offset: 0x000B758C
		protected override string Keywords
		{
			get
			{
				return "var function abstract as base bool break byte case catch char checked class const continue decimal default delegate do double else enum event explicit extern false finally fixed float for foreach goto if implicit in int interface internal is lock long namespace new null object operator out override params private protected public readonly ref return sbyte sealed short sizeof stackalloc static string struct switch this throw true try typeof uint ulong unchecked unsafe ushort using virtual void while";
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000B9394 File Offset: 0x000B7594
		protected override string Preprocessors
		{
			get
			{
				return "@\\w*";
			}
		}
	}
}
