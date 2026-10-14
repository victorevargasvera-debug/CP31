using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NPOI.SS.Formula.Function;
using NPOI.SS.Formula.Functions;
using NPOI.SS.Formula.UDF;

namespace NPOI.SS.Formula.Atp
{
	// Token: 0x0200023B RID: 571
	public class AnalysisToolPak : global::NPOI.SS.Formula.UDF.UDFFinder
	{
		// Token: 0x06000DE3 RID: 3555 RVA: 0x00027021 File Offset: 0x00025221
		private AnalysisToolPak()
		{
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0002702C File Offset: 0x0002522C
		public override global::NPOI.SS.Formula.Functions.FreeRefFunction FindFunction(string name)
		{
			if (name.StartsWith("_xlfn."))
			{
				name = name.Substring(6);
			}
			string key = name.ToUpper();
			if (global::NPOI.SS.Formula.Atp.AnalysisToolPak._functionsByName.ContainsKey(key))
			{
				return global::NPOI.SS.Formula.Atp.AnalysisToolPak._functionsByName[key];
			}
			return null;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00027070 File Offset: 0x00025270
		private static global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Functions.FreeRefFunction> CreateFunctionsMap()
		{
			global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Functions.FreeRefFunction> dictionary = new global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Functions.FreeRefFunction>(120);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "ACCRINT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "ACCRINTM", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "AMORDEGRC", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "AMORLINC", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "AVERAGEIF", global::NPOI.SS.Formula.Functions.AverageIf.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "AVERAGEIFS", global::NPOI.SS.Formula.Functions.AverageIfs.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "BAHTTEXT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "BESSELI", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "BESSELJ", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "BESSELK", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "BESSELY", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "BIN2DEC", global::NPOI.SS.Formula.Functions.Bin2Dec.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "BIN2HEX", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "BIN2OCT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "COMPLEX", global::NPOI.SS.Formula.Functions.Complex.Instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "CONVERT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "COUNTIFS", global::NPOI.SS.Formula.Functions.Countifs.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "COUPDAYBS", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "COUPDAYS", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "COUPDAYSNC", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "COUPNCD", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "COUPNUM", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "COUPPCD", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "CUBEKPIMEMBER", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "CUBEMEMBER", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "CUBEMEMBERPROPERTY", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "CUBERANKEDMEMBER", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "CUBESET", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "CUBESETCOUNT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "CUBEVALUE", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "CUMIPMT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "CUMPRINC", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "DEC2BIN", global::NPOI.SS.Formula.Functions.Dec2Bin.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "DEC2HEX", global::NPOI.SS.Formula.Functions.Dec2Hex.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "DEC2OCT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "DELTA", global::NPOI.SS.Formula.Functions.Delta.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "DISC", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "DOLLARDE", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "DOLLARFR", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "DURATION", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "EDATE", global::NPOI.SS.Formula.Functions.EDate.Instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "EFFECT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "EOMONTH", global::NPOI.SS.Formula.Functions.EOMonth.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "ERF", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "ERFC", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "FACTDOUBLE", global::NPOI.SS.Formula.Functions.FactDouble.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "FVSCHEDULE", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "GCD", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "GESTEP", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "HEX2BIN", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "HEX2DEC", global::NPOI.SS.Formula.Functions.Hex2Dec.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "HEX2OCT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IFERROR", global::NPOI.SS.Formula.Atp.IfError.Instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IFNA", global::NPOI.SS.Formula.Atp.IfNa.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IFS", global::NPOI.SS.Formula.Atp.Ifs.Instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMABS", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMAGINARY", global::NPOI.SS.Formula.Functions.Imaginary.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMARGUMENT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMCONJUGATE", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMCOS", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMDIV", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMEXP", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMLN", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMLOG10", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMLOG2", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMPOWER", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMPRODUCT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMREAL", global::NPOI.SS.Formula.Functions.ImReal.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMSIN", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMSQRT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMSUB", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "IMSUM", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "INTRATE", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "ISEVEN", global::NPOI.SS.Formula.Atp.ParityFunction.IS_EVEN);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "ISODD", global::NPOI.SS.Formula.Atp.ParityFunction.IS_ODD);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "JIS", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "LCM", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "MAXIFS", global::NPOI.SS.Formula.Atp.Maxifs.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "MDURATION", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "MINIFS", global::NPOI.SS.Formula.Atp.Minifs.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "MROUND", global::NPOI.SS.Formula.Atp.MRound.Instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "MULTINOMIAL", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "NETWORKDAYS", global::NPOI.SS.Formula.Atp.NetworkdaysFunction.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "NOMINAL", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "OCT2BIN", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "OCT2DEC", global::NPOI.SS.Formula.Functions.Oct2Dec.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "OCT2HEX", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "ODDFPRICE", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "ODDFYIELD", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "ODDLPRICE", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "ODDLYIELD", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "PRICE", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "PRICEDISC", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "PRICEMAT", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "QUOTIENT", global::NPOI.SS.Formula.Functions.Quotient.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "RANDBETWEEN", global::NPOI.SS.Formula.Atp.RandBetween.Instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "RECEIVED", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "RTD", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "SERIESSUM", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "SQRTPI", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "SUMIFS", global::NPOI.SS.Formula.Functions.Sumifs.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "SWITCH", global::NPOI.SS.Formula.Atp.Switch.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "TBILLEQ", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "TBILLPRICE", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "TBILLYIELD", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "TEXTJOIN", global::NPOI.SS.Formula.Atp.TextJoinFunction.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "WEEKNUM", global::NPOI.SS.Formula.Functions.WeekNum.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "WORKDAY", global::NPOI.SS.Formula.Atp.WorkdayFunction.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "XIRR", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "XNPV", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "YEARFRAC", global::NPOI.SS.Formula.Atp.YearFrac.instance);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "YIELD", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "YIELDDISC", null);
			global::NPOI.SS.Formula.Atp.AnalysisToolPak.r(dictionary, "YIELDMAT", null);
			return dictionary;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0002765C File Offset: 0x0002585C
		private static void r(global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Functions.FreeRefFunction> m, string functionName, global::NPOI.SS.Formula.Functions.FreeRefFunction pFunc)
		{
			global::NPOI.SS.Formula.Functions.FreeRefFunction freeRefFunction;
			if (pFunc != null)
			{
				freeRefFunction = pFunc;
			}
			else
			{
				global::NPOI.SS.Formula.Functions.FreeRefFunction freeRefFunction2 = new global::NPOI.SS.Formula.Atp.NotImplemented(functionName);
				freeRefFunction = freeRefFunction2;
			}
			global::NPOI.SS.Formula.Functions.FreeRefFunction value = freeRefFunction;
			m[functionName] = value;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00027680 File Offset: 0x00025880
		public static bool IsATPFunction(string name)
		{
			return global::NPOI.SS.Formula.Atp.AnalysisToolPak._functionsByName.ContainsKey(name);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00027690 File Offset: 0x00025890
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<string> GetSupportedFunctionNames()
		{
			global::NPOI.SS.Formula.Atp.AnalysisToolPak analysisToolPak = (global::NPOI.SS.Formula.Atp.AnalysisToolPak)global::NPOI.SS.Formula.Atp.AnalysisToolPak.instance;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::NPOI.SS.Formula.Functions.FreeRefFunction> keyValuePair in global::NPOI.SS.Formula.Atp.AnalysisToolPak._functionsByName)
			{
				global::NPOI.SS.Formula.Functions.FreeRefFunction value = keyValuePair.Value;
				if (value != null && !(value is global::NPOI.SS.Formula.Atp.NotImplemented))
				{
					list.Add(keyValuePair.Key);
				}
			}
			return list.AsReadOnly();
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00027714 File Offset: 0x00025914
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<string> GetNotSupportedFunctionNames()
		{
			global::NPOI.SS.Formula.Atp.AnalysisToolPak analysisToolPak = (global::NPOI.SS.Formula.Atp.AnalysisToolPak)global::NPOI.SS.Formula.Atp.AnalysisToolPak.instance;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::NPOI.SS.Formula.Functions.FreeRefFunction> keyValuePair in global::NPOI.SS.Formula.Atp.AnalysisToolPak._functionsByName)
			{
				global::NPOI.SS.Formula.Functions.FreeRefFunction value = keyValuePair.Value;
				if (value != null && value is global::NPOI.SS.Formula.Atp.NotImplemented)
				{
					list.Add(keyValuePair.Key);
				}
			}
			return list.AsReadOnly();
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00027798 File Offset: 0x00025998
		public static void RegisterFunction(string name, global::NPOI.SS.Formula.Functions.FreeRefFunction func)
		{
			global::NPOI.SS.Formula.UDF.UDFFinder udffinder = (global::NPOI.SS.Formula.Atp.AnalysisToolPak)global::NPOI.SS.Formula.Atp.AnalysisToolPak.instance;
			if (!global::NPOI.SS.Formula.Atp.AnalysisToolPak.IsATPFunction(name))
			{
				if (global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetFunctionByName(name) != null)
				{
					throw new global::System.ArgumentException(name + " is a built-in Excel function. Use FunctoinEval.RegisterFunction(String name, Function func) instead.");
				}
				throw new global::System.ArgumentException(name + " is not a function from the Excel Analysis Toolpack.");
			}
			else
			{
				global::NPOI.SS.Formula.Functions.FreeRefFunction freeRefFunction = udffinder.FindFunction(name);
				if (freeRefFunction != null && !(freeRefFunction is global::NPOI.SS.Formula.Atp.NotImplemented))
				{
					throw new global::System.ArgumentException("POI already implememts " + name + ". You cannot override POI's implementations of Excel functions");
				}
				if (global::NPOI.SS.Formula.Atp.AnalysisToolPak._functionsByName.ContainsKey(name))
				{
					global::NPOI.SS.Formula.Atp.AnalysisToolPak._functionsByName[name] = func;
					return;
				}
				global::NPOI.SS.Formula.Atp.AnalysisToolPak._functionsByName.Add(name, func);
				return;
			}
		}

		// Token: 0x0400062D RID: 1581
		public static global::NPOI.SS.Formula.UDF.UDFFinder instance = new global::NPOI.SS.Formula.Atp.AnalysisToolPak();

		// Token: 0x0400062E RID: 1582
		private static global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.Formula.Functions.FreeRefFunction> _functionsByName = global::NPOI.SS.Formula.Atp.AnalysisToolPak.CreateFunctionsMap();
	}
}
