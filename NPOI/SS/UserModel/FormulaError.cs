using System;
using System.Collections.Generic;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200006F RID: 111
	public class FormulaError
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x0000D5E0 File Offset: 0x0000B7E0
		static FormulaError()
		{
			global::NPOI.SS.UserModel.FormulaError._values = new global::NPOI.SS.UserModel.FormulaError[]
			{
				global::NPOI.SS.UserModel.FormulaError.NULL,
				global::NPOI.SS.UserModel.FormulaError.DIV0,
				global::NPOI.SS.UserModel.FormulaError.VALUE,
				global::NPOI.SS.UserModel.FormulaError.REF,
				global::NPOI.SS.UserModel.FormulaError.NAME,
				global::NPOI.SS.UserModel.FormulaError.NUM,
				global::NPOI.SS.UserModel.FormulaError.NA,
				global::NPOI.SS.UserModel.FormulaError.CIRCULAR_REF,
				global::NPOI.SS.UserModel.FormulaError.FUNCTION_NOT_IMPLEMENTED
			};
			foreach (global::NPOI.SS.UserModel.FormulaError formulaError in global::NPOI.SS.UserModel.FormulaError._values)
			{
				global::NPOI.SS.UserModel.FormulaError.bmap.Add(formulaError.Code, formulaError);
				global::NPOI.SS.UserModel.FormulaError.imap.Add(formulaError.LongCode, formulaError);
				global::NPOI.SS.UserModel.FormulaError.smap.Add(formulaError.String, formulaError);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000D783 File Offset: 0x0000B983
		private FormulaError(int type, string repr, string name)
		{
			this.type = (byte)type;
			this.longType = type;
			this.repr = repr;
			this.Name = name;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000D7A8 File Offset: 0x0000B9A8
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		public string Name { get; private set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000D7C1 File Offset: 0x0000B9C1
		public byte Code
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000D7C9 File Offset: 0x0000B9C9
		public int LongCode
		{
			get
			{
				return this.longType;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000D7D1 File Offset: 0x0000B9D1
		public string String
		{
			get
			{
				return this.repr;
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		public static bool IsValidCode(int errorCode)
		{
			foreach (global::NPOI.SS.UserModel.FormulaError formulaError in global::NPOI.SS.UserModel.FormulaError._values)
			{
				if ((int)formulaError.Code == errorCode)
				{
					return true;
				}
				if (formulaError.LongCode == errorCode)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000D818 File Offset: 0x0000BA18
		public static global::NPOI.SS.UserModel.FormulaError ForInt(byte type)
		{
			if (global::NPOI.SS.UserModel.FormulaError.bmap.ContainsKey(type))
			{
				return global::NPOI.SS.UserModel.FormulaError.bmap[type];
			}
			throw new global::System.ArgumentException("Unknown error type: " + type.ToString());
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000D84C File Offset: 0x0000BA4C
		public static global::NPOI.SS.UserModel.FormulaError ForInt(int type)
		{
			if (global::NPOI.SS.UserModel.FormulaError.imap.ContainsKey(type))
			{
				return global::NPOI.SS.UserModel.FormulaError.imap[type];
			}
			if (global::NPOI.SS.UserModel.FormulaError.bmap.ContainsKey((byte)type))
			{
				return global::NPOI.SS.UserModel.FormulaError.bmap[(byte)type];
			}
			throw new global::System.ArgumentException("Unknown error type: " + type.ToString());
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000D8A3 File Offset: 0x0000BAA3
		public static global::NPOI.SS.UserModel.FormulaError ForString(string code)
		{
			if (global::NPOI.SS.UserModel.FormulaError.smap.ContainsKey(code))
			{
				return global::NPOI.SS.UserModel.FormulaError.smap[code];
			}
			throw new global::System.ArgumentException("Unknown error code: " + code);
		}

		// Token: 0x04000205 RID: 517
		private static global::NPOI.SS.UserModel.FormulaError[] _values;

		// Token: 0x04000206 RID: 518
		internal static readonly global::NPOI.SS.UserModel.FormulaError _NO_ERROR = new global::NPOI.SS.UserModel.FormulaError(-1, "(no error)", "_NO_ERROR");

		// Token: 0x04000207 RID: 519
		public static readonly global::NPOI.SS.UserModel.FormulaError NULL = new global::NPOI.SS.UserModel.FormulaError(0, "#NULL!", "NULL");

		// Token: 0x04000208 RID: 520
		public static readonly global::NPOI.SS.UserModel.FormulaError DIV0 = new global::NPOI.SS.UserModel.FormulaError(7, "#DIV/0!", "DIV0");

		// Token: 0x04000209 RID: 521
		public static readonly global::NPOI.SS.UserModel.FormulaError VALUE = new global::NPOI.SS.UserModel.FormulaError(15, "#VALUE!", "VALUE");

		// Token: 0x0400020A RID: 522
		public static readonly global::NPOI.SS.UserModel.FormulaError REF = new global::NPOI.SS.UserModel.FormulaError(23, "#REF!", "REF");

		// Token: 0x0400020B RID: 523
		public static readonly global::NPOI.SS.UserModel.FormulaError NAME = new global::NPOI.SS.UserModel.FormulaError(29, "#NAME?", "NAME");

		// Token: 0x0400020C RID: 524
		public static readonly global::NPOI.SS.UserModel.FormulaError NUM = new global::NPOI.SS.UserModel.FormulaError(36, "#NUM!", "NUM");

		// Token: 0x0400020D RID: 525
		public static readonly global::NPOI.SS.UserModel.FormulaError NA = new global::NPOI.SS.UserModel.FormulaError(42, "#N/A", "NA");

		// Token: 0x0400020E RID: 526
		public static readonly global::NPOI.SS.UserModel.FormulaError CIRCULAR_REF = new global::NPOI.SS.UserModel.FormulaError(-60, "~CIRCULAR~REF~", "CIRCULAR_REF");

		// Token: 0x0400020F RID: 527
		public static readonly global::NPOI.SS.UserModel.FormulaError FUNCTION_NOT_IMPLEMENTED = new global::NPOI.SS.UserModel.FormulaError(-30, "~FUNCTION~NOT~IMPLEMENTED~", "FUNCTION_NOT_IMPLEMENTED");

		// Token: 0x04000210 RID: 528
		private byte type;

		// Token: 0x04000211 RID: 529
		private int longType;

		// Token: 0x04000212 RID: 530
		private string repr;

		// Token: 0x04000214 RID: 532
		private static global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.UserModel.FormulaError> smap = new global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.UserModel.FormulaError>();

		// Token: 0x04000215 RID: 533
		private static global::System.Collections.Generic.Dictionary<byte, global::NPOI.SS.UserModel.FormulaError> bmap = new global::System.Collections.Generic.Dictionary<byte, global::NPOI.SS.UserModel.FormulaError>();

		// Token: 0x04000216 RID: 534
		private static global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.UserModel.FormulaError> imap = new global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.UserModel.FormulaError>();
	}
}
