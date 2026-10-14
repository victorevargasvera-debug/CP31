using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql.AST;
using System.Data.Entity.Resources;
using System.IO;
using System.Text.RegularExpressions;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000647 RID: 1607
	internal sealed class CqlLexer
	{
		// Token: 0x06004D53 RID: 19795 RVA: 0x0011072A File Offset: 0x0010E92A
		internal CqlLexer(global::System.IO.TextReader reader) : this()
		{
			if (reader == null)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.EntityRes.GetString("ParserInputError"));
			}
			this.yy_reader = reader;
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x0011074C File Offset: 0x0010E94C
		internal CqlLexer(global::System.IO.FileStream instream) : this()
		{
			if (instream == null)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.EntityRes.GetString("ParserInputError"));
			}
			this.yy_reader = new global::System.IO.StreamReader(instream);
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x00110774 File Offset: 0x0010E974
		private CqlLexer()
		{
			this.yy_buffer = new char[512];
			this.yy_buffer_read = 0;
			this.yy_buffer_index = 0;
			this.yy_buffer_start = 0;
			this.yy_buffer_end = 0;
			this.yychar = 0;
			this.yyline = 0;
			this.yy_at_bol = true;
			this.yy_lexical_state = 0;
			this.accept_dispatch = new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod[]
			{
				null,
				null,
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_2),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_3),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_4),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_5),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_6),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_7),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_8),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_9),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_10),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_11),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_12),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_13),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_14),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_15),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_16),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_17),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_18),
				null,
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_20),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_21),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_22),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_23),
				null,
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_25),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_26),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_27),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_28),
				null,
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_30),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_31),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_32),
				null,
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_34),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_35),
				null,
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_37),
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_53),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_54),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_55),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_56),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_57),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_58),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_59),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_60),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_61),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_62),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_63),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_64),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_65),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_66),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_67),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_68),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_69),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_70),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_71),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_72),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_73),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_74),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_75),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_76),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_77),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_78),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_79),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_80),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_81),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_82),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_83),
				new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod(this.Accept_84)
			};
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x00110BC5 File Offset: 0x0010EDC5
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_2()
		{
			return this.HandleEscapedIdentifiers();
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x00110BCD File Offset: 0x0010EDCD
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_3()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x00110BDB File Offset: 0x0010EDDB
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_4()
		{
			this.AdvanceIPos();
			this.ResetSymbolAsIdentifierState(false);
			return null;
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x00110BEC File Offset: 0x0010EDEC
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_5()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Number);
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x00110BFB File Offset: 0x0010EDFB
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_6()
		{
			return this.MapPunctuator(this.YYText);
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00110C09 File Offset: 0x0010EE09
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_7()
		{
			return this.MapOperator(this.YYText);
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x00110C17 File Offset: 0x0010EE17
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_8()
		{
			this._lineNumber++;
			this.AdvanceIPos();
			this.ResetSymbolAsIdentifierState(false);
			return null;
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x00110C36 File Offset: 0x0010EE36
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_9()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.String);
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x00110C45 File Offset: 0x0010EE45
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_10()
		{
			return this.MapDoubleQuotedString(this.YYText);
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00110C53 File Offset: 0x0010EE53
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_11()
		{
			return this.NewParameterToken(this.YYText);
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x00110C61 File Offset: 0x0010EE61
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_12()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Binary);
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x00110C70 File Offset: 0x0010EE70
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_13()
		{
			this._lineNumber++;
			this.AdvanceIPos();
			this.ResetSymbolAsIdentifierState(false);
			return null;
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x00110C8F File Offset: 0x0010EE8F
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_14()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Boolean);
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00110C9E File Offset: 0x0010EE9E
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_15()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Time);
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00110CAD File Offset: 0x0010EEAD
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_16()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Guid);
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x00110CBC File Offset: 0x0010EEBC
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_17()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.DateTime);
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x00110CCB File Offset: 0x0010EECB
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_18()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.DateTimeOffset);
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x00110CDA File Offset: 0x0010EEDA
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_20()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x00110CE8 File Offset: 0x0010EEE8
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_21()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Number);
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x00110CF7 File Offset: 0x0010EEF7
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_22()
		{
			return this.MapPunctuator(this.YYText);
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00110D05 File Offset: 0x0010EF05
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_23()
		{
			return this.MapOperator(this.YYText);
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x00110D13 File Offset: 0x0010EF13
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_25()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x00110D21 File Offset: 0x0010EF21
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_26()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Number);
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x00110D30 File Offset: 0x0010EF30
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_27()
		{
			return this.MapPunctuator(this.YYText);
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x00110D3E File Offset: 0x0010EF3E
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_28()
		{
			return this.MapOperator(this.YYText);
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x00110D4C File Offset: 0x0010EF4C
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_30()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x00110D5A File Offset: 0x0010EF5A
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_31()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Number);
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x00110D69 File Offset: 0x0010EF69
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_32()
		{
			return this.MapOperator(this.YYText);
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00110D77 File Offset: 0x0010EF77
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_34()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x00110D85 File Offset: 0x0010EF85
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_35()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Number);
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x00110D94 File Offset: 0x0010EF94
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_37()
		{
			return this.NewLiteralToken(this.YYText, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Number);
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x00110DA3 File Offset: 0x0010EFA3
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_53()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00110DB1 File Offset: 0x0010EFB1
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_54()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x00110DBF File Offset: 0x0010EFBF
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_55()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00110DCD File Offset: 0x0010EFCD
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_56()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x00110DDB File Offset: 0x0010EFDB
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_57()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x00110DE9 File Offset: 0x0010EFE9
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_58()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x00110DF7 File Offset: 0x0010EFF7
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_59()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x00110E05 File Offset: 0x0010F005
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_60()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x00110E13 File Offset: 0x0010F013
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_61()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00110E21 File Offset: 0x0010F021
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_62()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x00110E2F File Offset: 0x0010F02F
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_63()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x00110E3D File Offset: 0x0010F03D
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_64()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x00110E4B File Offset: 0x0010F04B
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_65()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x00110E59 File Offset: 0x0010F059
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_66()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x00110E67 File Offset: 0x0010F067
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_67()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x00110E75 File Offset: 0x0010F075
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_68()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x00110E83 File Offset: 0x0010F083
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_69()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x00110E91 File Offset: 0x0010F091
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_70()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x00110E9F File Offset: 0x0010F09F
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_71()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x00110EAD File Offset: 0x0010F0AD
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_72()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x00110EBB File Offset: 0x0010F0BB
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_73()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x00110EC9 File Offset: 0x0010F0C9
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_74()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x00110ED7 File Offset: 0x0010F0D7
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_75()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x00110EE5 File Offset: 0x0010F0E5
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_76()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x00110EF3 File Offset: 0x0010F0F3
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_77()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x00110F01 File Offset: 0x0010F101
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_78()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x00110F0F File Offset: 0x0010F10F
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_79()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00110F1D File Offset: 0x0010F11D
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_80()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x00110F2B File Offset: 0x0010F12B
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_81()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x00110F39 File Offset: 0x0010F139
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_82()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x00110F47 File Offset: 0x0010F147
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_83()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x00110F55 File Offset: 0x0010F155
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token Accept_84()
		{
			return this.MapIdentifierOrKeyword(this.YYText);
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00110F63 File Offset: 0x0010F163
		private void yybegin(int state)
		{
			this.yy_lexical_state = state;
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x00110F6C File Offset: 0x0010F16C
		private char yy_advance()
		{
			int num;
			if (this.yy_buffer_index < this.yy_buffer_read)
			{
				char[] array = this.yy_buffer;
				num = this.yy_buffer_index;
				this.yy_buffer_index = num + 1;
				return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_translate.translate(array[num]);
			}
			if (this.yy_buffer_start != 0)
			{
				int i = this.yy_buffer_start;
				int num2 = 0;
				while (i < this.yy_buffer_read)
				{
					this.yy_buffer[num2] = this.yy_buffer[i];
					i++;
					num2++;
				}
				this.yy_buffer_end -= this.yy_buffer_start;
				this.yy_buffer_start = 0;
				this.yy_buffer_read = num2;
				this.yy_buffer_index = num2;
				int num3 = this.yy_reader.Read(this.yy_buffer, this.yy_buffer_read, this.yy_buffer.Length - this.yy_buffer_read);
				if (num3 <= 0)
				{
					return '\u0081';
				}
				this.yy_buffer_read += num3;
			}
			while (this.yy_buffer_index >= this.yy_buffer_read)
			{
				if (this.yy_buffer_index >= this.yy_buffer.Length)
				{
					this.yy_buffer = this.yy_double(this.yy_buffer);
				}
				int num3 = this.yy_reader.Read(this.yy_buffer, this.yy_buffer_read, this.yy_buffer.Length - this.yy_buffer_read);
				if (num3 <= 0)
				{
					return '\u0081';
				}
				this.yy_buffer_read += num3;
			}
			char[] array2 = this.yy_buffer;
			num = this.yy_buffer_index;
			this.yy_buffer_index = num + 1;
			return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_translate.translate(array2[num]);
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x001110D4 File Offset: 0x0010F2D4
		private void yy_move_end()
		{
			if (this.yy_buffer_end > this.yy_buffer_start && '\n' == this.yy_buffer[this.yy_buffer_end - 1])
			{
				this.yy_buffer_end--;
			}
			if (this.yy_buffer_end > this.yy_buffer_start && '\r' == this.yy_buffer[this.yy_buffer_end - 1])
			{
				this.yy_buffer_end--;
			}
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x00111140 File Offset: 0x0010F340
		private void yy_mark_start()
		{
			for (int i = this.yy_buffer_start; i < this.yy_buffer_index; i++)
			{
				if (this.yy_buffer[i] == '\n' && !this.yy_last_was_cr)
				{
					this.yyline++;
				}
				if (this.yy_buffer[i] == '\r')
				{
					this.yyline++;
					this.yy_last_was_cr = true;
				}
				else
				{
					this.yy_last_was_cr = false;
				}
			}
			this.yychar = this.yychar + this.yy_buffer_index - this.yy_buffer_start;
			this.yy_buffer_start = this.yy_buffer_index;
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x001111D5 File Offset: 0x0010F3D5
		private void yy_mark_end()
		{
			this.yy_buffer_end = this.yy_buffer_index;
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x001111E4 File Offset: 0x0010F3E4
		private void yy_to_mark()
		{
			this.yy_buffer_index = this.yy_buffer_end;
			this.yy_at_bol = (this.yy_buffer_end > this.yy_buffer_start && (this.yy_buffer[this.yy_buffer_end - 1] == '\r' || this.yy_buffer[this.yy_buffer_end - 1] == '\n'));
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x0011123D File Offset: 0x0010F43D
		internal string yytext()
		{
			return new string(this.yy_buffer, this.yy_buffer_start, this.yy_buffer_end - this.yy_buffer_start);
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x0011125D File Offset: 0x0010F45D
		internal int yy_char()
		{
			return this.yychar;
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00111265 File Offset: 0x0010F465
		private int yylength()
		{
			return this.yy_buffer_end - this.yy_buffer_start;
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x00111274 File Offset: 0x0010F474
		private char[] yy_double(char[] buf)
		{
			char[] array = new char[2 * buf.Length];
			for (int i = 0; i < buf.Length; i++)
			{
				array[i] = buf[i];
			}
			return array;
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x001112A1 File Offset: 0x0010F4A1
		private void yy_error(int code, bool fatal)
		{
			if (fatal)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.EntityRes.GetString("ParserFatalError"));
			}
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x001112B8 File Offset: 0x0010F4B8
		internal global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token yylex()
		{
			int num = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_state_dtrans[this.yy_lexical_state];
			int num2 = -1;
			bool flag = true;
			this.yy_mark_start();
			int num3 = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_acpt[num];
			if (num3 != 0)
			{
				num2 = num;
				this.yy_mark_end();
			}
			for (;;)
			{
				char c;
				if (flag && this.yy_at_bol)
				{
					c = '\u0080';
				}
				else
				{
					c = this.yy_advance();
				}
				int num4 = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_nxt[global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_rmap[num], global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_cmap[(int)c]];
				if ('\u0081' == c && flag)
				{
					break;
				}
				if (-1 != num4)
				{
					num = num4;
					flag = false;
					num3 = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_acpt[num];
					if (num3 != 0)
					{
						num2 = num;
						this.yy_mark_end();
					}
				}
				else
				{
					if (-1 == num2)
					{
						goto Block_7;
					}
					int num5 = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_acpt[num2];
					if ((2 & num5) != 0)
					{
						this.yy_move_end();
					}
					this.yy_to_mark();
					if (num2 < 0)
					{
						if (num2 < 85)
						{
							this.yy_error(0, false);
						}
					}
					else
					{
						global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod acceptMethod = this.accept_dispatch[num2];
						if (acceptMethod != null)
						{
							global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token token = acceptMethod();
							if (token != null)
							{
								return token;
							}
						}
					}
					flag = true;
					num = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_state_dtrans[this.yy_lexical_state];
					num2 = -1;
					this.yy_mark_start();
					num3 = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.yy_acpt[num];
					if (num3 != 0)
					{
						num2 = num;
						this.yy_mark_end();
					}
				}
			}
			return null;
			Block_7:
			throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Core.EntitySqlException.GetGenericErrorMessage(this._query, this.yychar));
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x001113FE File Offset: 0x0010F5FE
		internal CqlLexer(string query, global::System.Data.Entity.Core.Common.EntitySql.ParserOptions parserOptions) : this()
		{
			this._query = query;
			this._parserOptions = parserOptions;
			this.yy_reader = new global::System.IO.StringReader(this._query);
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x00111425 File Offset: 0x0010F625
		internal static global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token NewToken(short tokenId, global::System.Data.Entity.Core.Common.EntitySql.AST.Node tokenvalue)
		{
			return new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token(tokenId, tokenvalue);
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x0011142E File Offset: 0x0010F62E
		internal static global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token NewToken(short tokenId, global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.TerminalToken termToken)
		{
			return new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token(tokenId, termToken);
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06004DA4 RID: 19876 RVA: 0x00111437 File Offset: 0x0010F637
		internal string YYText
		{
			get
			{
				return this.yytext();
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06004DA5 RID: 19877 RVA: 0x0011143F File Offset: 0x0010F63F
		internal int IPos
		{
			get
			{
				return this._iPos;
			}
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x00111447 File Offset: 0x0010F647
		internal int AdvanceIPos()
		{
			this._iPos += this.YYText.Length;
			return this._iPos;
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00111467 File Offset: 0x0010F667
		internal static bool IsReservedKeyword(string term)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.InternalKeywordDictionary.ContainsKey(term);
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x00111474 File Offset: 0x0010F674
		internal global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token MapIdentifierOrKeyword(string symbol)
		{
			global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token result;
			if (this.IsEscapedIdentifier(symbol, out result))
			{
				return result;
			}
			if (this.IsKeyword(symbol, out result))
			{
				return result;
			}
			return this.MapUnescapedIdentifier(symbol);
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x001114A4 File Offset: 0x0010F6A4
		private bool IsEscapedIdentifier(string symbol, out global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token identifierToken)
		{
			if (symbol.Length <= 1 || symbol[0] != '[')
			{
				identifierToken = null;
				return false;
			}
			if (symbol[symbol.Length - 1] == ']')
			{
				global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier = new global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier(symbol.Substring(1, symbol.Length - 2), true, this._query, this._iPos);
				identifier.ErrCtx.ErrorContextInfo = "CtxEscapedIdentifier";
				identifierToken = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.NewToken(global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ESCAPED_IDENTIFIER, identifier);
				return true;
			}
			string errorDescription = global::System.Data.Entity.Resources.Strings.InvalidEscapedIdentifier(symbol);
			throw global::System.Data.Entity.Core.EntitySqlException.Create(this._query, errorDescription, this._iPos, null, false, null);
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x0011153C File Offset: 0x0010F73C
		private bool IsKeyword(string symbol, out global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token terminalToken)
		{
			char lookAheadChar = this.GetLookAheadChar();
			if (!this.IsInSymbolAsIdentifierState(lookAheadChar) && !this.IsCanonicalFunctionCall(symbol, lookAheadChar) && global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.InternalKeywordDictionary.ContainsKey(symbol))
			{
				this.ResetSymbolAsIdentifierState(true);
				short num = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.InternalKeywordDictionary[symbol];
				if (num == global::System.Data.Entity.Core.Common.EntitySql.CqlParser.AS)
				{
					this._symbolAsAliasIdentifierState = true;
				}
				else if (num == global::System.Data.Entity.Core.Common.EntitySql.CqlParser.FUNCTION)
				{
					this._symbolAsInlineFunctionNameState = true;
				}
				terminalToken = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.NewToken(num, new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.TerminalToken(symbol, this._iPos));
				return true;
			}
			terminalToken = null;
			return false;
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x001115BD File Offset: 0x0010F7BD
		private bool IsCanonicalFunctionCall(string symbol, char lookAheadChar)
		{
			return lookAheadChar == '(' && global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.InternalCanonicalFunctionNames.Contains(symbol);
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x001115D4 File Offset: 0x0010F7D4
		private global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token MapUnescapedIdentifier(string symbol)
		{
			bool flag = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.InternalInvalidAliasNames.Contains(symbol);
			if (this._symbolAsInlineFunctionNameState)
			{
				flag |= global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.InternalInvalidInlineFunctionNames.Contains(symbol);
			}
			this.ResetSymbolAsIdentifierState(true);
			if (flag)
			{
				string errorDescription = global::System.Data.Entity.Resources.Strings.InvalidAliasName(symbol);
				throw global::System.Data.Entity.Core.EntitySqlException.Create(this._query, errorDescription, this._iPos, null, false, null);
			}
			global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier identifier = new global::System.Data.Entity.Core.Common.EntitySql.AST.Identifier(symbol, false, this._query, this._iPos);
			identifier.ErrCtx.ErrorContextInfo = "CtxIdentifier";
			return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.NewToken(global::System.Data.Entity.Core.Common.EntitySql.CqlParser.IDENTIFIER, identifier);
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x0011165C File Offset: 0x0010F85C
		private char GetLookAheadChar()
		{
			this.yy_mark_end();
			char c = this.yy_advance();
			while (c != '\u0081' && (char.IsWhiteSpace(c) || global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsNewLine(c)))
			{
				c = this.yy_advance();
			}
			this.yy_to_mark();
			return c;
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x0011169E File Offset: 0x0010F89E
		private bool IsInSymbolAsIdentifierState(char lookAheadChar)
		{
			return this._symbolAsIdentifierState || this._symbolAsAliasIdentifierState || this._symbolAsInlineFunctionNameState || lookAheadChar == '.';
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x001116BF File Offset: 0x0010F8BF
		private void ResetSymbolAsIdentifierState(bool significant)
		{
			this._symbolAsIdentifierState = false;
			if (significant)
			{
				this._symbolAsAliasIdentifierState = false;
				this._symbolAsInlineFunctionNameState = false;
			}
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x001116DC File Offset: 0x0010F8DC
		internal global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token MapOperator(string oper)
		{
			if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.InternalOperatorDictionary.ContainsKey(oper))
			{
				return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.NewToken(global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.InternalOperatorDictionary[oper], new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.TerminalToken(oper, this._iPos));
			}
			string invalidOperatorSymbol = global::System.Data.Entity.Resources.Strings.InvalidOperatorSymbol;
			throw global::System.Data.Entity.Core.EntitySqlException.Create(this._query, invalidOperatorSymbol, this._iPos, null, false, null);
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x00111730 File Offset: 0x0010F930
		internal global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token MapPunctuator(string punct)
		{
			if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.InternalPunctuatorDictionary.ContainsKey(punct))
			{
				this.ResetSymbolAsIdentifierState(true);
				if (punct.Equals(".", global::System.StringComparison.OrdinalIgnoreCase))
				{
					this._symbolAsIdentifierState = true;
				}
				return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.NewToken(global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.InternalPunctuatorDictionary[punct], new global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.TerminalToken(punct, this._iPos));
			}
			string invalidPunctuatorSymbol = global::System.Data.Entity.Resources.Strings.InvalidPunctuatorSymbol;
			throw global::System.Data.Entity.Core.EntitySqlException.Create(this._query, invalidPunctuatorSymbol, this._iPos, null, false, null);
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x0011179E File Offset: 0x0010F99E
		internal global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token MapDoubleQuotedString(string symbol)
		{
			return this.NewLiteralToken(symbol, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.String);
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x001117A8 File Offset: 0x0010F9A8
		internal global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token NewLiteralToken(string literal, global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind literalKind)
		{
			string text = literal;
			switch (literalKind)
			{
			case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.String:
				if ('N' == literal[0])
				{
					literalKind = global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.UnicodeString;
				}
				break;
			case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Binary:
				text = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.GetLiteralSingleQuotePayload(literal);
				if (!global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsValidBinaryValue(text))
				{
					string errorDescription = global::System.Data.Entity.Resources.Strings.InvalidLiteralFormat("binary", text);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(this._query, errorDescription, this._iPos, null, false, null);
				}
				break;
			case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.DateTime:
				text = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.GetLiteralSingleQuotePayload(literal);
				if (!global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsValidDateTimeValue(text))
				{
					string errorDescription2 = global::System.Data.Entity.Resources.Strings.InvalidLiteralFormat("datetime", text);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(this._query, errorDescription2, this._iPos, null, false, null);
				}
				break;
			case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Time:
				text = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.GetLiteralSingleQuotePayload(literal);
				if (!global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsValidTimeValue(text))
				{
					string errorDescription3 = global::System.Data.Entity.Resources.Strings.InvalidLiteralFormat("time", text);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(this._query, errorDescription3, this._iPos, null, false, null);
				}
				break;
			case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.DateTimeOffset:
				text = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.GetLiteralSingleQuotePayload(literal);
				if (!global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsValidDateTimeOffsetValue(text))
				{
					string errorDescription4 = global::System.Data.Entity.Resources.Strings.InvalidLiteralFormat("datetimeoffset", text);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(this._query, errorDescription4, this._iPos, null, false, null);
				}
				break;
			case global::System.Data.Entity.Core.Common.EntitySql.AST.LiteralKind.Guid:
				text = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.GetLiteralSingleQuotePayload(literal);
				if (!global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsValidGuidValue(text))
				{
					string errorDescription5 = global::System.Data.Entity.Resources.Strings.InvalidLiteralFormat("guid", text);
					throw global::System.Data.Entity.Core.EntitySqlException.Create(this._query, errorDescription5, this._iPos, null, false, null);
				}
				break;
			}
			return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.NewToken(global::System.Data.Entity.Core.Common.EntitySql.CqlParser.LITERAL, new global::System.Data.Entity.Core.Common.EntitySql.AST.Literal(text, literalKind, this._query, this._iPos));
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x00111919 File Offset: 0x0010FB19
		internal global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token NewParameterToken(string param)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.NewToken(global::System.Data.Entity.Core.Common.EntitySql.CqlParser.PARAMETER, new global::System.Data.Entity.Core.Common.EntitySql.AST.QueryParameter(param, this._query, this._iPos));
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00111938 File Offset: 0x0010FB38
		internal global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token HandleEscapedIdentifiers()
		{
			for (char c = this.YYText[0]; c != '\u0081'; c = this.yy_advance())
			{
				if (c == ']')
				{
					this.yy_mark_end();
					c = this.yy_advance();
					if (c != ']')
					{
						this.yy_to_mark();
						this.ResetSymbolAsIdentifierState(true);
						return this.MapIdentifierOrKeyword(this.YYText.Replace("]]", "]"));
					}
				}
			}
			string errorDescription = global::System.Data.Entity.Resources.Strings.InvalidEscapedIdentifierUnbalanced(this.YYText);
			throw global::System.Data.Entity.Core.EntitySqlException.Create(this._query, errorDescription, this._iPos, null, false, null);
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x001119C4 File Offset: 0x0010FBC4
		internal static bool IsLetterOrDigitOrUnderscore(string symbol, out bool isIdentifierASCII)
		{
			isIdentifierASCII = true;
			for (int i = 0; i < symbol.Length; i++)
			{
				isIdentifierASCII = (isIdentifierASCII && symbol[i] < '\u0080');
				if (!isIdentifierASCII && !global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsLetter(symbol[i]) && !global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsDigit(symbol[i]) && symbol[i] != '_')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x00111A2A File Offset: 0x0010FC2A
		private static bool IsLetter(char c)
		{
			return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x00111A47 File Offset: 0x0010FC47
		private static bool IsDigit(char c)
		{
			return c >= '0' && c <= '9';
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x00111A58 File Offset: 0x0010FC58
		private static bool isHexDigit(char c)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsDigit(c) || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x00111A80 File Offset: 0x0010FC80
		internal static bool IsNewLine(char c)
		{
			for (int i = 0; i < global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._newLineCharacters.Length; i++)
			{
				if (c == global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._newLineCharacters[i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004DBB RID: 19899 RVA: 0x00111AAC File Offset: 0x0010FCAC
		private static string GetLiteralSingleQuotePayload(string literal)
		{
			if (literal.Split(new char[]
			{
				'\''
			}).Length != 3 || -1 == literal.IndexOf('\'') || -1 == literal.LastIndexOf('\''))
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.MalformedSingleQuotePayload);
			}
			int num = literal.IndexOf('\'');
			string text = literal.Substring(num + 1, literal.Length - (num + 2));
			if (text.Split(new char[]
			{
				'\''
			}).Length != 1)
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.MalformedSingleQuotePayload);
			}
			return text;
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x00111B30 File Offset: 0x0010FD30
		private static bool IsValidGuidValue(string guidValue)
		{
			int num = 0;
			if (guidValue.Length - 1 - num + 1 != 36)
			{
				return false;
			}
			int num2 = 0;
			bool flag = true;
			while (flag && num2 < 36)
			{
				if (num2 == 8 || num2 == 13 || num2 == 18 || num2 == 23)
				{
					flag = (guidValue[num + num2] == '-');
				}
				else
				{
					flag = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.isHexDigit(guidValue[num + num2]);
				}
				num2++;
			}
			return flag;
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x00111B98 File Offset: 0x0010FD98
		private static bool IsValidBinaryValue(string binaryValue)
		{
			if (string.IsNullOrEmpty(binaryValue))
			{
				return true;
			}
			int num = 0;
			bool flag;
			for (flag = (binaryValue.Length > 0); flag && num < binaryValue.Length; flag = global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.isHexDigit(binaryValue[num++]))
			{
			}
			return flag;
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x00111BDB File Offset: 0x0010FDDB
		private static bool IsValidDateTimeValue(string datetimeValue)
		{
			if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._reDateTimeValue == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._reDateTimeValue = new global::System.Text.RegularExpressions.Regex("^[0-9]{4}-[0-9]{1,2}-[0-9]{1,2}([ ])+[0-9]{1,2}:[0-9]{1,2}(:[0-9]{1,2}(\\.[0-9]{1,7})?)?$", global::System.Text.RegularExpressions.RegexOptions.Singleline | global::System.Text.RegularExpressions.RegexOptions.CultureInvariant);
			}
			return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._reDateTimeValue.IsMatch(datetimeValue);
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x00111C03 File Offset: 0x0010FE03
		private static bool IsValidTimeValue(string timeValue)
		{
			if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._reTimeValue == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._reTimeValue = new global::System.Text.RegularExpressions.Regex("^[0-9]{1,2}:[0-9]{1,2}(:[0-9]{1,2}(\\.[0-9]{1,7})?)?$", global::System.Text.RegularExpressions.RegexOptions.Singleline | global::System.Text.RegularExpressions.RegexOptions.CultureInvariant);
			}
			return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._reTimeValue.IsMatch(timeValue);
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x00111C2B File Offset: 0x0010FE2B
		private static bool IsValidDateTimeOffsetValue(string datetimeOffsetValue)
		{
			if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._reDateTimeOffsetValue == null)
			{
				global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._reDateTimeOffsetValue = new global::System.Text.RegularExpressions.Regex("^[0-9]{4}-[0-9]{1,2}-[0-9]{1,2}([ ])+[0-9]{1,2}:[0-9]{1,2}(:[0-9]{1,2}(\\.[0-9]{1,7})?)?([ ])*[\\+-][0-9]{1,2}:[0-9]{1,2}$", global::System.Text.RegularExpressions.RegexOptions.Singleline | global::System.Text.RegularExpressions.RegexOptions.CultureInvariant);
			}
			return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._reDateTimeOffsetValue.IsMatch(datetimeOffsetValue);
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06004DC1 RID: 19905 RVA: 0x00111C54 File Offset: 0x0010FE54
		private static global::System.Collections.Generic.Dictionary<string, short> InternalKeywordDictionary
		{
			get
			{
				if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._keywords == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._keywords = new global::System.Collections.Generic.Dictionary<string, short>(60, global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._stringComparer)
					{
						{
							"all",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ALL
						},
						{
							"and",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.AND
						},
						{
							"anyelement",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ANYELEMENT
						},
						{
							"apply",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.APPLY
						},
						{
							"as",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.AS
						},
						{
							"asc",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ASC
						},
						{
							"between",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.BETWEEN
						},
						{
							"by",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.BY
						},
						{
							"case",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.CASE
						},
						{
							"cast",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.CAST
						},
						{
							"collate",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.COLLATE
						},
						{
							"collection",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.COLLECTION
						},
						{
							"createref",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.CREATEREF
						},
						{
							"cross",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.CROSS
						},
						{
							"deref",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.DEREF
						},
						{
							"desc",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.DESC
						},
						{
							"distinct",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.DISTINCT
						},
						{
							"element",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ELEMENT
						},
						{
							"else",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ELSE
						},
						{
							"end",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.END
						},
						{
							"escape",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ESCAPE
						},
						{
							"except",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.EXCEPT
						},
						{
							"exists",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.EXISTS
						},
						{
							"false",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.LITERAL
						},
						{
							"flatten",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.FLATTEN
						},
						{
							"from",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.FROM
						},
						{
							"full",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.FULL
						},
						{
							"function",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.FUNCTION
						},
						{
							"group",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.GROUP
						},
						{
							"grouppartition",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.GROUPPARTITION
						},
						{
							"having",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.HAVING
						},
						{
							"in",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.IN
						},
						{
							"inner",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.INNER
						},
						{
							"intersect",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.INTERSECT
						},
						{
							"is",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.IS
						},
						{
							"join",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.JOIN
						},
						{
							"key",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.KEY
						},
						{
							"left",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.LEFT
						},
						{
							"like",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.LIKE
						},
						{
							"limit",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.LIMIT
						},
						{
							"multiset",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.MULTISET
						},
						{
							"navigate",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.NAVIGATE
						},
						{
							"not",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.NOT
						},
						{
							"null",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.NULL
						},
						{
							"of",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OF
						},
						{
							"oftype",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OFTYPE
						},
						{
							"on",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ON
						},
						{
							"only",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ONLY
						},
						{
							"or",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OR
						},
						{
							"order",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ORDER
						},
						{
							"outer",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OUTER
						},
						{
							"overlaps",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OVERLAPS
						},
						{
							"ref",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.REF
						},
						{
							"relationship",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.RELATIONSHIP
						},
						{
							"right",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.RIGHT
						},
						{
							"row",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.ROW
						},
						{
							"select",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.SELECT
						},
						{
							"set",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.SET
						},
						{
							"skip",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.SKIP
						},
						{
							"then",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.THEN
						},
						{
							"top",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.TOP
						},
						{
							"treat",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.TREAT
						},
						{
							"true",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.LITERAL
						},
						{
							"union",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.UNION
						},
						{
							"using",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.USING
						},
						{
							"value",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.VALUE
						},
						{
							"when",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.WHEN
						},
						{
							"where",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.WHERE
						},
						{
							"with",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.WITH
						}
					};
				}
				return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._keywords;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06004DC2 RID: 19906 RVA: 0x001120D4 File Offset: 0x001102D4
		private static global::System.Collections.Generic.HashSet<string> InternalInvalidAliasNames
		{
			get
			{
				if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._invalidAliasNames == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._invalidAliasNames = new global::System.Collections.Generic.HashSet<string>(global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._stringComparer)
					{
						"all",
						"and",
						"apply",
						"as",
						"asc",
						"between",
						"by",
						"case",
						"cast",
						"collate",
						"createref",
						"deref",
						"desc",
						"distinct",
						"element",
						"else",
						"end",
						"escape",
						"except",
						"exists",
						"flatten",
						"from",
						"group",
						"having",
						"in",
						"inner",
						"intersect",
						"is",
						"join",
						"like",
						"multiset",
						"navigate",
						"not",
						"null",
						"of",
						"oftype",
						"on",
						"only",
						"or",
						"overlaps",
						"ref",
						"relationship",
						"select",
						"set",
						"then",
						"treat",
						"union",
						"using",
						"when",
						"where",
						"with"
					};
				}
				return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._invalidAliasNames;
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06004DC3 RID: 19907 RVA: 0x00112364 File Offset: 0x00110564
		private static global::System.Collections.Generic.HashSet<string> InternalInvalidInlineFunctionNames
		{
			get
			{
				if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._invalidInlineFunctionNames == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._invalidInlineFunctionNames = new global::System.Collections.Generic.HashSet<string>(global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._stringComparer)
					{
						"anyelement",
						"element",
						"function",
						"grouppartition",
						"key",
						"ref",
						"row",
						"skip",
						"top",
						"value"
					};
				}
				return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._invalidInlineFunctionNames;
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06004DC4 RID: 19908 RVA: 0x00112408 File Offset: 0x00110608
		private static global::System.Collections.Generic.Dictionary<string, short> InternalOperatorDictionary
		{
			get
			{
				if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._operators == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._operators = new global::System.Collections.Generic.Dictionary<string, short>(16, global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._stringComparer)
					{
						{
							"==",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OP_EQ
						},
						{
							"!=",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OP_NEQ
						},
						{
							"<>",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OP_NEQ
						},
						{
							"<",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OP_LT
						},
						{
							"<=",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OP_LE
						},
						{
							">",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OP_GT
						},
						{
							">=",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OP_GE
						},
						{
							"&&",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.AND
						},
						{
							"||",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.OR
						},
						{
							"!",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.NOT
						},
						{
							"+",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.PLUS
						},
						{
							"-",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.MINUS
						},
						{
							"*",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.STAR
						},
						{
							"/",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.FSLASH
						},
						{
							"%",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.PERCENT
						}
					};
				}
				return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._operators;
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06004DC5 RID: 19909 RVA: 0x00112528 File Offset: 0x00110728
		private static global::System.Collections.Generic.Dictionary<string, short> InternalPunctuatorDictionary
		{
			get
			{
				if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._punctuators == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._punctuators = new global::System.Collections.Generic.Dictionary<string, short>(16, global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._stringComparer)
					{
						{
							",",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.COMMA
						},
						{
							":",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.COLON
						},
						{
							".",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.DOT
						},
						{
							"?",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.QMARK
						},
						{
							"(",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.L_PAREN
						},
						{
							")",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.R_PAREN
						},
						{
							"[",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.L_BRACE
						},
						{
							"]",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.R_BRACE
						},
						{
							"{",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.L_CURLY
						},
						{
							"}",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.R_CURLY
						},
						{
							";",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.SCOLON
						},
						{
							"=",
							global::System.Data.Entity.Core.Common.EntitySql.CqlParser.EQUAL
						}
					};
				}
				return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._punctuators;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06004DC6 RID: 19910 RVA: 0x00112615 File Offset: 0x00110815
		private static global::System.Collections.Generic.HashSet<string> InternalCanonicalFunctionNames
		{
			get
			{
				if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._canonicalFunctionNames == null)
				{
					global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._canonicalFunctionNames = new global::System.Collections.Generic.HashSet<string>(global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._stringComparer)
					{
						"left",
						"right"
					};
				}
				return global::System.Data.Entity.Core.Common.EntitySql.CqlLexer._canonicalFunctionNames;
			}
		}

		// Token: 0x04001B74 RID: 7028
		private const int YY_BUFFER_SIZE = 512;

		// Token: 0x04001B75 RID: 7029
		private const int YY_F = -1;

		// Token: 0x04001B76 RID: 7030
		private const int YY_NO_STATE = -1;

		// Token: 0x04001B77 RID: 7031
		private const int YY_NOT_ACCEPT = 0;

		// Token: 0x04001B78 RID: 7032
		private const int YY_START = 1;

		// Token: 0x04001B79 RID: 7033
		private const int YY_END = 2;

		// Token: 0x04001B7A RID: 7034
		private const int YY_NO_ANCHOR = 4;

		// Token: 0x04001B7B RID: 7035
		private readonly global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.AcceptMethod[] accept_dispatch;

		// Token: 0x04001B7C RID: 7036
		private const int YY_BOL = 128;

		// Token: 0x04001B7D RID: 7037
		private const int YY_EOF = 129;

		// Token: 0x04001B7E RID: 7038
		private readonly global::System.IO.TextReader yy_reader;

		// Token: 0x04001B7F RID: 7039
		private int yy_buffer_index;

		// Token: 0x04001B80 RID: 7040
		private int yy_buffer_read;

		// Token: 0x04001B81 RID: 7041
		private int yy_buffer_start;

		// Token: 0x04001B82 RID: 7042
		private int yy_buffer_end;

		// Token: 0x04001B83 RID: 7043
		private char[] yy_buffer;

		// Token: 0x04001B84 RID: 7044
		private int yychar;

		// Token: 0x04001B85 RID: 7045
		private int yyline;

		// Token: 0x04001B86 RID: 7046
		private bool yy_at_bol;

		// Token: 0x04001B87 RID: 7047
		private int yy_lexical_state;

		// Token: 0x04001B88 RID: 7048
		private const int YYINITIAL = 0;

		// Token: 0x04001B89 RID: 7049
		private static readonly int[] yy_state_dtrans = new int[1];

		// Token: 0x04001B8A RID: 7050
		private bool yy_last_was_cr;

		// Token: 0x04001B8B RID: 7051
		private const int YY_E_INTERNAL = 0;

		// Token: 0x04001B8C RID: 7052
		private const int YY_E_MATCH = 1;

		// Token: 0x04001B8D RID: 7053
		private static string[] yy_error_string = new string[]
		{
			"Error: Internal error.\n",
			"Error: Unmatched input.\n"
		};

		// Token: 0x04001B8E RID: 7054
		private static readonly int[] yy_acpt = new int[]
		{
			0,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			2,
			4,
			4,
			4,
			4,
			4,
			0,
			4,
			4,
			4,
			4,
			0,
			4,
			4,
			4,
			4,
			0,
			4,
			4,
			4,
			0,
			4,
			4,
			0,
			4,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4,
			4
		};

		// Token: 0x04001B8F RID: 7055
		private static readonly int[] yy_cmap = new int[]
		{
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			27,
			11,
			11,
			8,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			12,
			33,
			28,
			11,
			11,
			39,
			36,
			10,
			40,
			40,
			39,
			38,
			40,
			25,
			24,
			39,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			40,
			40,
			34,
			32,
			35,
			40,
			29,
			5,
			2,
			30,
			13,
			15,
			18,
			20,
			30,
			3,
			30,
			30,
			23,
			16,
			26,
			17,
			30,
			30,
			6,
			19,
			14,
			21,
			30,
			30,
			9,
			7,
			30,
			1,
			11,
			40,
			11,
			31,
			11,
			5,
			2,
			30,
			13,
			15,
			18,
			20,
			30,
			3,
			30,
			30,
			23,
			16,
			4,
			17,
			30,
			30,
			6,
			19,
			14,
			21,
			30,
			30,
			9,
			7,
			30,
			40,
			37,
			40,
			11,
			11,
			0,
			41
		};

		// Token: 0x04001B90 RID: 7056
		private static readonly int[] yy_rmap = new int[]
		{
			0,
			1,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			10,
			1,
			1,
			11,
			1,
			1,
			1,
			1,
			12,
			13,
			1,
			14,
			14,
			15,
			16,
			17,
			1,
			18,
			10,
			19,
			20,
			1,
			21,
			22,
			23,
			24,
			25,
			26,
			27,
			5,
			28,
			29,
			30,
			31,
			32,
			33,
			34,
			35,
			36,
			37,
			38,
			39,
			40,
			41,
			42,
			43,
			44,
			45,
			46,
			47,
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			58,
			59,
			60,
			61,
			62,
			63,
			11,
			64,
			65,
			66,
			67,
			68,
			11,
			69
		};

		// Token: 0x04001B91 RID: 7057
		private static readonly int[,] yy_nxt = new int[,]
		{
			{
				1,
				2,
				3,
				83,
				83,
				83,
				83,
				83,
				4,
				20,
				19,
				-1,
				4,
				84,
				64,
				83,
				83,
				83,
				71,
				83,
				72,
				83,
				5,
				83,
				6,
				7,
				25,
				8,
				24,
				29,
				83,
				83,
				22,
				23,
				28,
				23,
				33,
				36,
				32,
				32,
				27,
				1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				76,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				4,
				-1,
				-1,
				-1,
				4,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				21,
				-1,
				39,
				21,
				-1,
				21,
				-1,
				-1,
				26,
				5,
				31,
				40,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				35,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				41,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				8,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				19,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				24,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				11,
				11,
				11,
				11,
				11,
				11,
				-1,
				11,
				-1,
				-1,
				-1,
				11,
				11,
				11,
				11,
				11,
				11,
				11,
				11,
				11,
				11,
				11,
				-1,
				-1,
				11,
				-1,
				-1,
				-1,
				11,
				11,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				9,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				19,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				38,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				32,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				10,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				24,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				19,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				24,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				21,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				32,
				-1,
				-1,
				32,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				14,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				21,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				32,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				44,
				83,
				45,
				-1,
				44,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				21,
				-1,
				39,
				21,
				-1,
				21,
				-1,
				-1,
				-1,
				35,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				32,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				21,
				-1,
				-1,
				-1,
				-1,
				21,
				-1,
				-1,
				-1,
				37,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				-1,
				38,
				12,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				-1,
				-1,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				38,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				37,
				-1,
				-1,
				42,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				42,
				-1,
				-1,
				-1
			},
			{
				-1,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				43,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				13,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				41,
				13
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				37,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				13,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				44,
				-1,
				45,
				-1,
				44,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				-1,
				45,
				15,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				-1,
				-1,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				45,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				46,
				-1,
				47,
				-1,
				46,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				-1,
				47,
				16,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				-1,
				-1,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				47,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				48,
				-1,
				38,
				-1,
				48,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				49,
				-1,
				50,
				-1,
				49,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				-1,
				50,
				17,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				-1,
				-1,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				50,
				-1
			},
			{
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				51,
				-1,
				52,
				-1,
				51,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				-1,
				52,
				18,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				-1,
				-1,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				52,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				30,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				46,
				83,
				47,
				-1,
				46,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				34,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				48,
				83,
				38,
				-1,
				48,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				30,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				49,
				83,
				50,
				-1,
				49,
				83,
				83,
				83,
				83,
				81,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				54,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				51,
				83,
				52,
				-1,
				51,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				56,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				58,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				60,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				65,
				83,
				83,
				53,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				55,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				57,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				59,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				61,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				62,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				63,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				66,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				67,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				68,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				69,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				70,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				73,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				73,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				79,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				80,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				74,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				82,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				75,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			},
			{
				-1,
				-1,
				83,
				83,
				83,
				78,
				83,
				83,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				83,
				77,
				83,
				-1,
				-1,
				83,
				-1,
				-1,
				-1,
				83,
				77,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1,
				-1
			}
		};

		// Token: 0x04001B92 RID: 7058
		private static readonly global::System.StringComparer _stringComparer = global::System.StringComparer.OrdinalIgnoreCase;

		// Token: 0x04001B93 RID: 7059
		private static global::System.Collections.Generic.Dictionary<string, short> _keywords;

		// Token: 0x04001B94 RID: 7060
		private static global::System.Collections.Generic.HashSet<string> _invalidAliasNames;

		// Token: 0x04001B95 RID: 7061
		private static global::System.Collections.Generic.HashSet<string> _invalidInlineFunctionNames;

		// Token: 0x04001B96 RID: 7062
		private static global::System.Collections.Generic.Dictionary<string, short> _operators;

		// Token: 0x04001B97 RID: 7063
		private static global::System.Collections.Generic.Dictionary<string, short> _punctuators;

		// Token: 0x04001B98 RID: 7064
		private static global::System.Collections.Generic.HashSet<string> _canonicalFunctionNames;

		// Token: 0x04001B99 RID: 7065
		private static global::System.Text.RegularExpressions.Regex _reDateTimeValue;

		// Token: 0x04001B9A RID: 7066
		private static global::System.Text.RegularExpressions.Regex _reTimeValue;

		// Token: 0x04001B9B RID: 7067
		private static global::System.Text.RegularExpressions.Regex _reDateTimeOffsetValue;

		// Token: 0x04001B9C RID: 7068
		private const string _datetimeValueRegularExpression = "^[0-9]{4}-[0-9]{1,2}-[0-9]{1,2}([ ])+[0-9]{1,2}:[0-9]{1,2}(:[0-9]{1,2}(\\.[0-9]{1,7})?)?$";

		// Token: 0x04001B9D RID: 7069
		private const string _timeValueRegularExpression = "^[0-9]{1,2}:[0-9]{1,2}(:[0-9]{1,2}(\\.[0-9]{1,7})?)?$";

		// Token: 0x04001B9E RID: 7070
		private const string _datetimeOffsetValueRegularExpression = "^[0-9]{4}-[0-9]{1,2}-[0-9]{1,2}([ ])+[0-9]{1,2}:[0-9]{1,2}(:[0-9]{1,2}(\\.[0-9]{1,7})?)?([ ])*[\\+-][0-9]{1,2}:[0-9]{1,2}$";

		// Token: 0x04001B9F RID: 7071
		private int _iPos;

		// Token: 0x04001BA0 RID: 7072
		private int _lineNumber;

		// Token: 0x04001BA1 RID: 7073
		private global::System.Data.Entity.Core.Common.EntitySql.ParserOptions _parserOptions;

		// Token: 0x04001BA2 RID: 7074
		private readonly string _query;

		// Token: 0x04001BA3 RID: 7075
		private bool _symbolAsIdentifierState;

		// Token: 0x04001BA4 RID: 7076
		private bool _symbolAsAliasIdentifierState;

		// Token: 0x04001BA5 RID: 7077
		private bool _symbolAsInlineFunctionNameState;

		// Token: 0x04001BA6 RID: 7078
		private static readonly char[] _newLineCharacters = new char[]
		{
			'\n',
			'\u0085',
			'\v',
			'\u2028',
			'\u2029'
		};

		// Token: 0x02000C6B RID: 3179
		// (Invoke) Token: 0x06006B49 RID: 27465
		private delegate global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.Token AcceptMethod();

		// Token: 0x02000C6C RID: 3180
		internal class Token
		{
			// Token: 0x06006B4C RID: 27468 RVA: 0x0016E5C2 File Offset: 0x0016C7C2
			internal Token(short tokenId, global::System.Data.Entity.Core.Common.EntitySql.AST.Node tokenValue)
			{
				this._tokenId = tokenId;
				this._tokenValue = tokenValue;
			}

			// Token: 0x06006B4D RID: 27469 RVA: 0x0016E5D8 File Offset: 0x0016C7D8
			internal Token(short tokenId, global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.TerminalToken terminal)
			{
				this._tokenId = tokenId;
				this._tokenValue = terminal;
			}

			// Token: 0x17001193 RID: 4499
			// (get) Token: 0x06006B4E RID: 27470 RVA: 0x0016E5EE File Offset: 0x0016C7EE
			internal short TokenId
			{
				get
				{
					return this._tokenId;
				}
			}

			// Token: 0x17001194 RID: 4500
			// (get) Token: 0x06006B4F RID: 27471 RVA: 0x0016E5F6 File Offset: 0x0016C7F6
			internal object Value
			{
				get
				{
					return this._tokenValue;
				}
			}

			// Token: 0x0400311E RID: 12574
			private readonly short _tokenId;

			// Token: 0x0400311F RID: 12575
			private readonly object _tokenValue;
		}

		// Token: 0x02000C6D RID: 3181
		internal class TerminalToken
		{
			// Token: 0x06006B50 RID: 27472 RVA: 0x0016E5FE File Offset: 0x0016C7FE
			internal TerminalToken(string token, int iPos)
			{
				this._token = token;
				this._iPos = iPos;
			}

			// Token: 0x17001195 RID: 4501
			// (get) Token: 0x06006B51 RID: 27473 RVA: 0x0016E614 File Offset: 0x0016C814
			internal int IPos
			{
				get
				{
					return this._iPos;
				}
			}

			// Token: 0x17001196 RID: 4502
			// (get) Token: 0x06006B52 RID: 27474 RVA: 0x0016E61C File Offset: 0x0016C81C
			internal string Token
			{
				get
				{
					return this._token;
				}
			}

			// Token: 0x04003120 RID: 12576
			private readonly string _token;

			// Token: 0x04003121 RID: 12577
			private readonly int _iPos;
		}

		// Token: 0x02000C6E RID: 3182
		internal static class yy_translate
		{
			// Token: 0x06006B53 RID: 27475 RVA: 0x0016E624 File Offset: 0x0016C824
			internal static char translate(char c)
			{
				if (char.IsWhiteSpace(c) || char.IsControl(c))
				{
					if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsNewLine(c))
					{
						return '\n';
					}
					return ' ';
				}
				else
				{
					if (c < '\u007f')
					{
						return c;
					}
					if (char.IsLetter(c) || char.IsSymbol(c) || char.IsNumber(c))
					{
						return 'a';
					}
					return '`';
				}
			}
		}
	}
}
