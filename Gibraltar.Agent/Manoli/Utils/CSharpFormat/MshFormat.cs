using System;

namespace Manoli.Utils.CSharpFormat
{
	// Token: 0x0200047E RID: 1150
	internal class MshFormat : global::Manoli.Utils.CSharpFormat.CodeFormat
	{
		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000B93A4 File Offset: 0x000B75A4
		protected override string CommentRegEx
		{
			get
			{
				return "#.*?(?=\\r|\\n)";
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x060032B7 RID: 12983 RVA: 0x000B93AC File Offset: 0x000B75AC
		protected override string StringRegEx
		{
			get
			{
				return "@?\"\"|@?\".*?(?!\\\\).\"|''|'.*?(?!\\\\).'";
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000B93B4 File Offset: 0x000B75B4
		protected override string Keywords
		{
			get
			{
				return "function filter global script local private if else elseif for foreach in while switch continue break return default param begin process end throw trap";
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x060032B9 RID: 12985 RVA: 0x000B93BC File Offset: 0x000B75BC
		protected override string Preprocessors
		{
			get
			{
				return "-band -bor -match -notmatch -like -notlike -eq -ne -gt -ge -lt -le -is -imatch -inotmatch -ilike -inotlike -ieq -ine -igt -ige -ilt -ile";
			}
		}
	}
}
