using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NPOI.SS.Formula.Atp;
using NPOI.SS.Formula.Function;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.Eval
{
	// Token: 0x0200020B RID: 523
	public sealed class FunctionEval
	{
		// Token: 0x06000D15 RID: 3349 RVA: 0x0000253E File Offset: 0x0000073E
		private FunctionEval()
		{
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00023881 File Offset: 0x00021A81
		private static global::NPOI.SS.Formula.Function.FunctionMetadataRegistry GetInstance()
		{
			if (global::NPOI.SS.Formula.Eval.FunctionEval._instance == null)
			{
				global::NPOI.SS.Formula.Eval.FunctionEval._instance = global::NPOI.SS.Formula.Function.FunctionMetadataReader.CreateRegistry();
			}
			return global::NPOI.SS.Formula.Eval.FunctionEval._instance;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00023899 File Offset: 0x00021A99
		public static global::NPOI.SS.Formula.Functions.Function GetBasicFunction(int functionIndex)
		{
			if (functionIndex == 148 || functionIndex == 255)
			{
				return null;
			}
			global::NPOI.SS.Formula.Functions.Function function = global::NPOI.SS.Formula.Eval.FunctionEval.functions[functionIndex];
			if (function == null)
			{
				throw new global::System.NotImplementedException("FuncIx=" + functionIndex.ToString());
			}
			return function;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000238D0 File Offset: 0x00021AD0
		private static global::NPOI.SS.Formula.Functions.Function[] ProduceFunctions()
		{
			return new global::NPOI.SS.Formula.Functions.Function[]
			{
				new global::NPOI.SS.Formula.Functions.Count(),
				new global::NPOI.SS.Formula.Functions.IfFunc(),
				global::NPOI.SS.Formula.Functions.LogicalFunction.ISNA,
				global::NPOI.SS.Formula.Functions.LogicalFunction.ISERROR,
				global::NPOI.SS.Formula.Functions.AggregateFunction.SUM,
				global::NPOI.SS.Formula.Functions.AggregateFunction.AVERAGE,
				global::NPOI.SS.Formula.Functions.AggregateFunction.MIN,
				global::NPOI.SS.Formula.Functions.AggregateFunction.MAX,
				new global::NPOI.SS.Formula.Functions.Row(),
				new global::NPOI.SS.Formula.Functions.Column(),
				new global::NPOI.SS.Formula.Functions.Na(),
				new global::NPOI.SS.Formula.Functions.Npv(),
				global::NPOI.SS.Formula.Functions.AggregateFunction.STDEV,
				global::NPOI.SS.Formula.Functions.NumericFunction.DOLLAR,
				new global::NPOI.SS.Formula.Functions.Fixed(),
				global::NPOI.SS.Formula.Functions.NumericFunction.SIN,
				global::NPOI.SS.Formula.Functions.NumericFunction.COS,
				global::NPOI.SS.Formula.Functions.NumericFunction.TAN,
				global::NPOI.SS.Formula.Functions.NumericFunction.ATAN,
				new global::NPOI.SS.Formula.Functions.Pi(),
				global::NPOI.SS.Formula.Functions.NumericFunction.SQRT,
				global::NPOI.SS.Formula.Functions.NumericFunction.EXP,
				global::NPOI.SS.Formula.Functions.NumericFunction.LN,
				global::NPOI.SS.Formula.Functions.NumericFunction.LOG10,
				global::NPOI.SS.Formula.Functions.NumericFunction.ABS,
				global::NPOI.SS.Formula.Functions.NumericFunction.INT,
				global::NPOI.SS.Formula.Functions.NumericFunction.SIGN,
				global::NPOI.SS.Formula.Functions.NumericFunction.ROUND,
				new global::NPOI.SS.Formula.Functions.Lookup(),
				new global::NPOI.SS.Formula.Functions.Index(),
				new global::NPOI.SS.Formula.Functions.Rept(),
				global::NPOI.SS.Formula.Functions.TextFunction.MID,
				global::NPOI.SS.Formula.Functions.TextFunction.LEN,
				new global::NPOI.SS.Formula.Functions.Value(),
				new global::NPOI.SS.Formula.Functions.True(),
				new global::NPOI.SS.Formula.Functions.False(),
				new global::NPOI.SS.Formula.Functions.And(),
				new global::NPOI.SS.Formula.Functions.Or(),
				new global::NPOI.SS.Formula.Functions.Not(),
				global::NPOI.SS.Formula.Functions.NumericFunction.MOD,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DCOUNT"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DSUM"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DAVERAGE"),
				new global::NPOI.SS.Formula.Functions.DStarRunner(global::NPOI.SS.Formula.Functions.DStarRunner.DStarAlgorithmEnum.DMIN),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DMAX"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DSTDEV"),
				global::NPOI.SS.Formula.Functions.AggregateFunction.VAR,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DVAR"),
				global::NPOI.SS.Formula.Functions.TextFunction.TEXT,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("LINEST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TREND"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("LOGEST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GROWTH"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GOTO"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("HALT"),
				null,
				global::NPOI.SS.Formula.Functions.FinanceFunction.PV,
				global::NPOI.SS.Formula.Functions.FinanceFunction.FV,
				global::NPOI.SS.Formula.Functions.FinanceFunction.NPER,
				global::NPOI.SS.Formula.Functions.FinanceFunction.PMT,
				new global::NPOI.SS.Formula.Functions.Rate(),
				new global::NPOI.SS.Formula.Functions.Mirr(),
				new global::NPOI.SS.Formula.Functions.Irr(),
				new global::NPOI.SS.Formula.Functions.Rand(),
				new global::NPOI.SS.Formula.Functions.Match(),
				global::NPOI.SS.Formula.Functions.DateFunc.instance,
				new global::NPOI.SS.Formula.Functions.TimeFunc(),
				global::NPOI.SS.Formula.Functions.CalendarFieldFunction.DAY,
				global::NPOI.SS.Formula.Functions.CalendarFieldFunction.MONTH,
				global::NPOI.SS.Formula.Functions.CalendarFieldFunction.YEAR,
				global::NPOI.SS.Formula.Functions.WeekdayFunc.instance,
				global::NPOI.SS.Formula.Functions.CalendarFieldFunction.HOUR,
				global::NPOI.SS.Formula.Functions.CalendarFieldFunction.MINUTE,
				global::NPOI.SS.Formula.Functions.CalendarFieldFunction.SECOND,
				new global::NPOI.SS.Formula.Functions.Now(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("AREAS"),
				new global::NPOI.SS.Formula.Functions.Rows(),
				new global::NPOI.SS.Formula.Functions.Columns(),
				new global::NPOI.SS.Formula.Functions.Offset(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("ABSREF"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("RELREF"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("ARGUMENT"),
				global::NPOI.SS.Formula.Functions.TextFunction.SEARCH,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TRANSPOSE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("ERROR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("STEP"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TYPE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("ECHO"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SetNAME"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CALLER"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DEREF"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("WINDOWS"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SERIES"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DOCUMENTS"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("ACTIVECELL"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SELECTION"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("RESULT"),
				global::NPOI.SS.Formula.Functions.NumericFunction.ATAN2,
				global::NPOI.SS.Formula.Functions.NumericFunction.ASIN,
				global::NPOI.SS.Formula.Functions.NumericFunction.ACOS,
				new global::NPOI.SS.Formula.Functions.Choose(),
				new global::NPOI.SS.Formula.Functions.Hlookup(),
				new global::NPOI.SS.Formula.Functions.Vlookup(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("LINKS"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("INPUT"),
				global::NPOI.SS.Formula.Functions.LogicalFunction.ISREF,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetFORMULA"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetNAME"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SetVALUE"),
				global::NPOI.SS.Formula.Functions.NumericFunction.LOG,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("EXEC"),
				global::NPOI.SS.Formula.Functions.TextFunction.CHAR,
				global::NPOI.SS.Formula.Functions.TextFunction.LOWER,
				global::NPOI.SS.Formula.Functions.TextFunction.UPPER,
				global::NPOI.SS.Formula.Functions.TextFunction.PROPER,
				global::NPOI.SS.Formula.Functions.TextFunction.LEFT,
				global::NPOI.SS.Formula.Functions.TextFunction.RIGHT,
				global::NPOI.SS.Formula.Functions.TextFunction.EXACT,
				global::NPOI.SS.Formula.Functions.TextFunction.TRIM,
				new global::NPOI.SS.Formula.Functions.Replace(),
				new global::NPOI.SS.Formula.Functions.Substitute(),
				new global::NPOI.SS.Formula.Functions.Code(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("NAMES"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DIRECTORY"),
				global::NPOI.SS.Formula.Functions.TextFunction.FIND,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CELL"),
				global::NPOI.SS.Formula.Functions.LogicalFunction.ISERR,
				global::NPOI.SS.Formula.Functions.LogicalFunction.ISTEXT,
				global::NPOI.SS.Formula.Functions.LogicalFunction.ISNUMBER,
				global::NPOI.SS.Formula.Functions.LogicalFunction.ISBLANK,
				new global::NPOI.SS.Formula.Functions.T(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("N"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FOPEN"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FCLOSE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FSIZE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FReadLN"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FRead"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FWriteLN"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FWrite"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FPOS"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DATEVALUE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TIMEVALUE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SLN"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SYD"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DDB"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetDEF"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("REFTEXT"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TEXTREF"),
				null,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("REGISTER"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CALL"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("AddBAR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("AddMENU"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("AddCOMMAND"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("ENABLECOMMAND"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CHECKCOMMAND"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("RenameCOMMAND"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SHOWBAR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DELETEMENU"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DELETECOMMAND"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetCHARTITEM"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DIALOGBOX"),
				global::NPOI.SS.Formula.Functions.TextFunction.CLEAN,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("MDETERM"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("MINVERSE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("MMULT"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FILES"),
				new global::NPOI.SS.Formula.Functions.IPMT(),
				new global::NPOI.SS.Formula.Functions.PPMT(),
				new global::NPOI.SS.Formula.Functions.Counta(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CANCELKEY"),
				null,
				null,
				null,
				null,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("INITIATE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("REQUEST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("POKE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("EXECUTE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TERMINATE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("RESTART"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("HELP"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetBAR"),
				global::NPOI.SS.Formula.Functions.AggregateFunction.PRODUCT,
				global::NPOI.SS.Formula.Functions.NumericFunction.FACT,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetCELL"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetWORKSPACE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetWINDOW"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetDOCUMENT"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DPRODUCT"),
				global::NPOI.SS.Formula.Functions.LogicalFunction.ISNONTEXT,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetNOTE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("NOTE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("STDEVP"),
				global::NPOI.SS.Formula.Functions.AggregateFunction.VARP,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DSTDEVP"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DVARP"),
				global::NPOI.SS.Formula.Functions.NumericFunction.TRUNC,
				global::NPOI.SS.Formula.Functions.LogicalFunction.ISLOGICAL,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DCOUNTA"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DELETEBAR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("UNREGISTER"),
				null,
				null,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("USDOLLAR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FindB"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SEARCHB"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("ReplaceB"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("LEFTB"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("RIGHTB"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("MIDB"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("LENB"),
				global::NPOI.SS.Formula.Functions.NumericFunction.ROUNDUP,
				global::NPOI.SS.Formula.Functions.NumericFunction.ROUNDDOWN,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("ASC"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DBCS"),
				new global::NPOI.SS.Formula.Functions.Rank(),
				null,
				null,
				new global::NPOI.SS.Formula.Functions.Address(),
				new global::NPOI.SS.Formula.Functions.Days360(),
				new global::NPOI.SS.Formula.Functions.Today(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("VDB"),
				null,
				null,
				null,
				null,
				global::NPOI.SS.Formula.Functions.AggregateFunction.MEDIAN,
				new global::NPOI.SS.Formula.Functions.Sumproduct(),
				global::NPOI.SS.Formula.Functions.NumericFunction.SINH,
				global::NPOI.SS.Formula.Functions.NumericFunction.COSH,
				global::NPOI.SS.Formula.Functions.NumericFunction.TANH,
				global::NPOI.SS.Formula.Functions.NumericFunction.ASINH,
				global::NPOI.SS.Formula.Functions.NumericFunction.ACOSH,
				global::NPOI.SS.Formula.Functions.NumericFunction.ATANH,
				new global::NPOI.SS.Formula.Functions.DStarRunner(global::NPOI.SS.Formula.Functions.DStarRunner.DStarAlgorithmEnum.DGET),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CreateOBJECT"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("VOLATILE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("LASTERROR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CUSTOMUNDO"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CUSTOMREPEAT"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FORMULAConvert"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetLINKINFO"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TEXTBOX"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("INFO"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GROUP"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetOBJECT"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DB"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("PAUSE"),
				null,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("RESUME"),
				null,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FREQUENCY"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("AddTOOLBAR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DELETETOOLBAR"),
				null,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("RESetTOOLBAR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("EVALUATE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetTOOLBAR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetTOOL"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SPELLINGCHECK"),
				new global::NPOI.SS.Formula.Functions.Errortype(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("APPTITLE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("WINDOWTITLE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SAVETOOLBAR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("ENABLETOOL"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("PRESSTOOL"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("REGISTERID"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetWORKBOOK"),
				global::NPOI.SS.Formula.Functions.AggregateFunction.AVEDEV,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("BETADIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GAMMALN"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("BETAINV"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("BINOMDIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CHIDIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CHIINV"),
				global::NPOI.SS.Formula.Functions.NumericFunction.COMBIN,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CONFIDENCE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CRITBINOM"),
				new global::NPOI.SS.Formula.Functions.Even(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("EXPONDIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FDIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FINV"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FISHER"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FISHERINV"),
				global::NPOI.SS.Formula.Functions.NumericFunction.FLOOR,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GAMMADIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GAMMAINV"),
				global::NPOI.SS.Formula.Functions.NumericFunction.CEILING,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("HYPGEOMDIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("LOGNORMDIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("LOGINV"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("NEGBINOMDIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("NORMDIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("NORMSDIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("NORMINV"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("NORMSINV"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("STANDARDIZE"),
				new global::NPOI.SS.Formula.Functions.Odd(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("PERMUT"),
				global::NPOI.SS.Formula.Functions.NumericFunction.POISSON,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TDIST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("WEIBULL"),
				new global::NPOI.SS.Formula.Functions.Sumxmy2(),
				new global::NPOI.SS.Formula.Functions.Sumx2my2(),
				new global::NPOI.SS.Formula.Functions.Sumx2py2(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CHITEST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("CORREL"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("COVAR"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FORECAST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("FTEST"),
				new global::NPOI.SS.Formula.Functions.Intercept(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("PEARSON"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("RSQ"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("STEYX"),
				new global::NPOI.SS.Formula.Functions.Slope(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TTEST"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("PROB"),
				global::NPOI.SS.Formula.Functions.AggregateFunction.DEVSQ,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GEOMEAN"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("HARMEAN"),
				global::NPOI.SS.Formula.Functions.AggregateFunction.SUMSQ,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("KURT"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SKEW"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("ZTEST"),
				global::NPOI.SS.Formula.Functions.AggregateFunction.LARGE,
				global::NPOI.SS.Formula.Functions.AggregateFunction.SMALL,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("QUARTILE"),
				global::NPOI.SS.Formula.Functions.AggregateFunction.PERCENTILE,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("PERCENTRANK"),
				new global::NPOI.SS.Formula.Functions.Mode(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TRIMMEAN"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("TINV"),
				null,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("MOVIECOMMAND"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetMOVIE"),
				global::NPOI.SS.Formula.Functions.TextFunction.CONCATENATE,
				global::NPOI.SS.Formula.Functions.NumericFunction.POWER,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("PIVOTAddDATA"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetPIVOTTABLE"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetPIVOTFIELD"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetPIVOTITEM"),
				global::NPOI.SS.Formula.Functions.NumericFunction.RADIANS,
				global::NPOI.SS.Formula.Functions.NumericFunction.DEGREES,
				new global::NPOI.SS.Formula.Functions.Subtotal(),
				new global::NPOI.SS.Formula.Functions.Sumif(),
				new global::NPOI.SS.Formula.Functions.Countif(),
				new global::NPOI.SS.Formula.Functions.Countblank(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SCENARIOGet"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("OPTIONSLISTSGet"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("IsPMT"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DATEDIF"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("DATESTRING"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("NUMBERSTRING"),
				new global::NPOI.SS.Formula.Functions.Roman(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("OPENDIALOG"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("SAVEDIALOG"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("VIEWGet"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("GetPIVOTDATA"),
				new global::NPOI.SS.Formula.Functions.Hyperlink(),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("PHONETIC"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("AVERAGEA"),
				global::NPOI.SS.Formula.Functions.MinaMaxa.MAXA,
				global::NPOI.SS.Formula.Functions.MinaMaxa.MINA,
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("STDEVPA"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("VARPA"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("STDEVA"),
				new global::NPOI.SS.Formula.Functions.NotImplementedFunction("VARA")
			};
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00024BD4 File Offset: 0x00022DD4
		public static void RegisterFunction(string name, global::NPOI.SS.Formula.Functions.Function func)
		{
			global::NPOI.SS.Formula.Function.FunctionMetadata functionByName = global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetFunctionByName(name);
			if (functionByName == null)
			{
				if (global::NPOI.SS.Formula.Atp.AnalysisToolPak.IsATPFunction(name))
				{
					throw new global::System.ArgumentException(name + " is a function from the Excel Analysis Toolpack. Use AnalysisToolpack.RegisterFunction(String name, FreeRefFunction func) instead.");
				}
				throw new global::System.ArgumentException("Unknown function: " + name);
			}
			else
			{
				int index = functionByName.Index;
				if (global::NPOI.SS.Formula.Eval.FunctionEval.functions[index] is global::NPOI.SS.Formula.Functions.NotImplementedFunction)
				{
					global::NPOI.SS.Formula.Eval.FunctionEval.functions[index] = func;
					return;
				}
				throw new global::System.ArgumentException("POI already implememts " + name + ". You cannot override POI's implementations of Excel functions");
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00024C48 File Offset: 0x00022E48
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<string> GetSupportedFunctionNames()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			for (int i = 0; i < global::NPOI.SS.Formula.Eval.FunctionEval.functions.Length; i++)
			{
				global::NPOI.SS.Formula.Functions.Function function = global::NPOI.SS.Formula.Eval.FunctionEval.functions[i];
				global::NPOI.SS.Formula.Function.FunctionMetadata functionByIndex = global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetFunctionByIndex(i);
				if (function != null && !(function is global::NPOI.SS.Formula.Functions.NotImplementedFunction))
				{
					list.Add(functionByIndex.Name);
				}
			}
			list.Add("INDIRECT");
			return list.AsReadOnly();
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00024CA4 File Offset: 0x00022EA4
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<string> GetNotSupportedFunctionNames()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			for (int i = 0; i < global::NPOI.SS.Formula.Eval.FunctionEval.functions.Length; i++)
			{
				global::NPOI.SS.Formula.Functions.Function function = global::NPOI.SS.Formula.Eval.FunctionEval.functions[i];
				if (function != null && function is global::NPOI.SS.Formula.Functions.NotImplementedFunction)
				{
					global::NPOI.SS.Formula.Function.FunctionMetadata functionByIndex = global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetFunctionByIndex(i);
					list.Add(functionByIndex.Name);
				}
			}
			list.Remove("INDIRECT");
			return list.AsReadOnly();
		}

		// Token: 0x040005F0 RID: 1520
		protected static global::NPOI.SS.Formula.Functions.Function[] functions = global::NPOI.SS.Formula.Eval.FunctionEval.ProduceFunctions();

		// Token: 0x040005F1 RID: 1521
		private static global::NPOI.SS.Formula.Function.FunctionMetadataRegistry _instance;

		// Token: 0x0200058F RID: 1423
		private class FunctionID
		{
			// Token: 0x040018F6 RID: 6390
			public const int IF = 1;

			// Token: 0x040018F7 RID: 6391
			public const int SUM = 4;

			// Token: 0x040018F8 RID: 6392
			public const int OFFSET = 78;

			// Token: 0x040018F9 RID: 6393
			public const int CHOOSE = 100;

			// Token: 0x040018FA RID: 6394
			public const int INDIRECT = 148;

			// Token: 0x040018FB RID: 6395
			public const int EXTERNAL_FUNC = 255;
		}
	}
}
