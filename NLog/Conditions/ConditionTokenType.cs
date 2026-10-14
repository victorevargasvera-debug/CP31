using System;

namespace NLog.Conditions
{
	// Token: 0x02000188 RID: 392
	internal enum ConditionTokenType
	{
		// Token: 0x0400049D RID: 1181
		EndOfInput,
		// Token: 0x0400049E RID: 1182
		BeginningOfInput,
		// Token: 0x0400049F RID: 1183
		Number,
		// Token: 0x040004A0 RID: 1184
		String,
		// Token: 0x040004A1 RID: 1185
		Keyword,
		// Token: 0x040004A2 RID: 1186
		Whitespace,
		// Token: 0x040004A3 RID: 1187
		FirstPunct,
		// Token: 0x040004A4 RID: 1188
		LessThan,
		// Token: 0x040004A5 RID: 1189
		GreaterThan,
		// Token: 0x040004A6 RID: 1190
		LessThanOrEqualTo,
		// Token: 0x040004A7 RID: 1191
		GreaterThanOrEqualTo,
		// Token: 0x040004A8 RID: 1192
		EqualTo,
		// Token: 0x040004A9 RID: 1193
		NotEqual,
		// Token: 0x040004AA RID: 1194
		LeftParen,
		// Token: 0x040004AB RID: 1195
		RightParen,
		// Token: 0x040004AC RID: 1196
		Dot,
		// Token: 0x040004AD RID: 1197
		Comma,
		// Token: 0x040004AE RID: 1198
		Not,
		// Token: 0x040004AF RID: 1199
		And,
		// Token: 0x040004B0 RID: 1200
		Or,
		// Token: 0x040004B1 RID: 1201
		Minus,
		// Token: 0x040004B2 RID: 1202
		LastPunct,
		// Token: 0x040004B3 RID: 1203
		Invalid,
		// Token: 0x040004B4 RID: 1204
		ClosingCurlyBrace,
		// Token: 0x040004B5 RID: 1205
		Colon,
		// Token: 0x040004B6 RID: 1206
		Exclamation,
		// Token: 0x040004B7 RID: 1207
		Ampersand,
		// Token: 0x040004B8 RID: 1208
		Pipe
	}
}
