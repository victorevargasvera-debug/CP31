using System;

namespace Manoli.Utils.CSharpFormat
{
	// Token: 0x02000480 RID: 1152
	internal class VisualBasicFormat : global::Manoli.Utils.CSharpFormat.CodeFormat
	{
		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x060032C1 RID: 12993 RVA: 0x000B93F8 File Offset: 0x000B75F8
		public override bool CaseSensitive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x000B93FC File Offset: 0x000B75FC
		protected override string CommentRegEx
		{
			get
			{
				return "(?:'|REM\\s).*?(?=\\r|\\n)";
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x060032C3 RID: 12995 RVA: 0x000B9404 File Offset: 0x000B7604
		protected override string StringRegEx
		{
			get
			{
				return "\"\"|\".*?\"";
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x000B940C File Offset: 0x000B760C
		protected override string Keywords
		{
			get
			{
				return "AddHandler AddressOf AndAlso Alias And Ansi As Assembly Auto Boolean ByRef Byte ByVal Call Case Catch CBool CByte CChar CDate CDec CDbl Char CInt Class CLng CObj Const CShort CSng CStr CType Date Decimal Declare Default Delegate Dim DirectCast Do Double Each Else ElseIf End EndIf Enum Erase Error Event Exit False Finally For Friend Function Get GetType Global GoSub GoTo Handles If Implements Imports In Inherits Integer Interface Is Let Lib Like Long Loop Me Mod Module MustInherit MustOverride MyBase MyClass Namespace Narrowing New Next Not Nothing NotInheritable NotOverridable Object On Operator Option Optional Or OrElse Overloads Overridable Overrides ParamArray Preserve Private Property Protected Public RaiseEvent ReadOnly ReDim REM RemoveHandler Resume Return Select Set Shadows Shared Short Single Static Step Stop String Structure Sub SyncLock Then Throw To True Try TryCast TypeOf Unicode Until Variant Wend When While With Widening WithEvents WriteOnly Xor";
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x060032C5 RID: 12997 RVA: 0x000B9414 File Offset: 0x000B7614
		protected override string Preprocessors
		{
			get
			{
				return "#\\s*Const #\\s*If #\\s*Else #\\s*ElseIf #\\s*End\\s+If #\\s*ExternalSource #\\s*End\\s+ExternalSource #\\s*Region #\\s*End\\s+Region";
			}
		}
	}
}
