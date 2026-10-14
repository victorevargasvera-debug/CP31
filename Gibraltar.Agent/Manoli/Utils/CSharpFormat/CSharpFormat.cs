using System;

namespace Manoli.Utils.CSharpFormat
{
	// Token: 0x0200047B RID: 1147
	internal class CSharpFormat : global::Manoli.Utils.CSharpFormat.CLikeFormat
	{
		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x060032AD RID: 12973 RVA: 0x000B90E8 File Offset: 0x000B72E8
		protected override string Keywords
		{
			get
			{
				return "abstract as base bool break byte case catch char checked class const continue decimal default delegate do double else enum event explicit extern false finally fixed float for foreach goto if implicit in int interface internal is lock long namespace new null object operator out override partial params private protected public readonly ref return sbyte sealed short sizeof stackalloc static string struct switch this throw true try typeof uint ulong unchecked unsafe ushort using value virtual void volatile where while yield";
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x000B90F0 File Offset: 0x000B72F0
		protected override string Preprocessors
		{
			get
			{
				return "#if #else #elif #endif #define #undef #warning #error #line #region #endregion #pragma";
			}
		}
	}
}
