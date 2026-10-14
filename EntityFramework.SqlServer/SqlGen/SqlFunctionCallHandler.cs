using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Spatial;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.Utilities;
using System.Linq;
using System.Text;

namespace System.Data.Entity.SqlServer.SqlGen
{
	// Token: 0x02000036 RID: 54
	internal static class SqlFunctionCallHandler
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x00012588 File Offset: 0x00010788
		private static global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> InitializeStoreFunctionHandlers()
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler>(19, global::System.StringComparer.Ordinal);
			dictionary.Add("CONCAT", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleConcatFunction));
			dictionary.Add("DATEADD", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleDatepartDateFunction));
			dictionary.Add("DATEDIFF", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleDatepartDateFunction));
			dictionary.Add("DATENAME", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleDatepartDateFunction));
			dictionary.Add("DATEPART", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleDatepartDateFunction));
			dictionary.Add("Parse", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "hierarchyid::Parse"));
			dictionary.Add("GetRoot", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "hierarchyid::GetRoot"));
			dictionary.Add("POINTGEOGRAPHY", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::Point"));
			dictionary.Add("POINTGEOMETRY", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::Point"));
			dictionary.Add("ASTEXTZM", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, "AsTextZM", functionExpression, false));
			dictionary.Add("BUFFERWITHTOLERANCE", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, "BufferWithTolerance", functionExpression, false));
			dictionary.Add("ENVELOPEANGLE", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, "EnvelopeAngle", functionExpression, false));
			dictionary.Add("ENVELOPECENTER", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, "EnvelopeCenter", functionExpression, false));
			dictionary.Add("INSTANCEOF", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, "InstanceOf", functionExpression, false));
			dictionary.Add("FILTER", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, "Filter", functionExpression, false));
			dictionary.Add("MAKEVALID", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, "MakeValid", functionExpression, false));
			dictionary.Add("REDUCE", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, "Reduce", functionExpression, false));
			dictionary.Add("NUMRINGS", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, "NumRings", functionExpression, false));
			dictionary.Add("RINGN", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, "RingN", functionExpression, false));
			return dictionary;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00012860 File Offset: 0x00010A60
		private static global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> InitializeCanonicalFunctionHandlers()
		{
			return new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler>(16, global::System.StringComparer.Ordinal)
			{
				{
					"IndexOf",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionIndexOf)
				},
				{
					"Length",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionLength)
				},
				{
					"NewGuid",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionNewGuid)
				},
				{
					"Round",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionRound)
				},
				{
					"Truncate",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionTruncate)
				},
				{
					"Abs",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionAbs)
				},
				{
					"ToLower",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionToLower)
				},
				{
					"ToUpper",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionToUpper)
				},
				{
					"Trim",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionTrim)
				},
				{
					"Contains",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionContains)
				},
				{
					"StartsWith",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionStartsWith)
				},
				{
					"EndsWith",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionEndsWith)
				},
				{
					"Year",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDatepart)
				},
				{
					"Month",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDatepart)
				},
				{
					"Day",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDatepart)
				},
				{
					"Hour",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDatepart)
				},
				{
					"Minute",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDatepart)
				},
				{
					"Second",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDatepart)
				},
				{
					"Millisecond",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDatepart)
				},
				{
					"DayOfYear",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDatepart)
				},
				{
					"CurrentDateTime",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionCurrentDateTime)
				},
				{
					"CurrentUtcDateTime",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionCurrentUtcDateTime)
				},
				{
					"CurrentDateTimeOffset",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionCurrentDateTimeOffset)
				},
				{
					"GetTotalOffsetMinutes",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionGetTotalOffsetMinutes)
				},
				{
					"LocalDateTime",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionLocalDateTime)
				},
				{
					"UtcDateTime",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionUtcDateTime)
				},
				{
					"TruncateTime",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionTruncateTime)
				},
				{
					"CreateDateTime",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionCreateDateTime)
				},
				{
					"CreateDateTimeOffset",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionCreateDateTimeOffset)
				},
				{
					"CreateTime",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionCreateTime)
				},
				{
					"AddYears",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateAdd)
				},
				{
					"AddMonths",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateAdd)
				},
				{
					"AddDays",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateAdd)
				},
				{
					"AddHours",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateAdd)
				},
				{
					"AddMinutes",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateAdd)
				},
				{
					"AddSeconds",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateAdd)
				},
				{
					"AddMilliseconds",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateAdd)
				},
				{
					"AddMicroseconds",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateAddKatmaiOrNewer)
				},
				{
					"AddNanoseconds",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateAddKatmaiOrNewer)
				},
				{
					"DiffYears",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateDiff)
				},
				{
					"DiffMonths",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateDiff)
				},
				{
					"DiffDays",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateDiff)
				},
				{
					"DiffHours",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateDiff)
				},
				{
					"DiffMinutes",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateDiff)
				},
				{
					"DiffSeconds",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateDiff)
				},
				{
					"DiffMilliseconds",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateDiff)
				},
				{
					"DiffMicroseconds",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateDiffKatmaiOrNewer)
				},
				{
					"DiffNanoseconds",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateDiffKatmaiOrNewer)
				},
				{
					"Concat",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleConcatFunction)
				},
				{
					"BitwiseAnd",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionBitwise)
				},
				{
					"BitwiseNot",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionBitwise)
				},
				{
					"BitwiseOr",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionBitwise)
				},
				{
					"BitwiseXor",
					new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionBitwise)
				}
			};
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00012D3C File Offset: 0x00010F3C
		private static global::System.Collections.Generic.Dictionary<string, string> InitializeFunctionNameToOperatorDictionary()
		{
			return new global::System.Collections.Generic.Dictionary<string, string>(5, global::System.StringComparer.Ordinal)
			{
				{
					"Concat",
					"+"
				},
				{
					"CONCAT",
					"+"
				},
				{
					"BitwiseAnd",
					"&"
				},
				{
					"BitwiseNot",
					"~"
				},
				{
					"BitwiseOr",
					"|"
				},
				{
					"BitwiseXor",
					"^"
				}
			};
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00012DB4 File Offset: 0x00010FB4
		private static global::System.Collections.Generic.Dictionary<string, string> InitializeDateAddFunctionNameToDatepartDictionary()
		{
			return new global::System.Collections.Generic.Dictionary<string, string>(5, global::System.StringComparer.Ordinal)
			{
				{
					"AddYears",
					"year"
				},
				{
					"AddMonths",
					"month"
				},
				{
					"AddDays",
					"day"
				},
				{
					"AddHours",
					"hour"
				},
				{
					"AddMinutes",
					"minute"
				},
				{
					"AddSeconds",
					"second"
				},
				{
					"AddMilliseconds",
					"millisecond"
				},
				{
					"AddMicroseconds",
					"microsecond"
				},
				{
					"AddNanoseconds",
					"nanosecond"
				}
			};
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00012E5C File Offset: 0x0001105C
		private static global::System.Collections.Generic.Dictionary<string, string> InitializeDateDiffFunctionNameToDatepartDictionary()
		{
			return new global::System.Collections.Generic.Dictionary<string, string>(5, global::System.StringComparer.Ordinal)
			{
				{
					"DiffYears",
					"year"
				},
				{
					"DiffMonths",
					"month"
				},
				{
					"DiffDays",
					"day"
				},
				{
					"DiffHours",
					"hour"
				},
				{
					"DiffMinutes",
					"minute"
				},
				{
					"DiffSeconds",
					"second"
				},
				{
					"DiffMilliseconds",
					"millisecond"
				},
				{
					"DiffMicroseconds",
					"microsecond"
				},
				{
					"DiffNanoseconds",
					"nanosecond"
				}
			};
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00012F04 File Offset: 0x00011104
		private static global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> InitializeHierarchyIdStaticMethodFunctionsDictionary()
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler>();
			dictionary.Add("HierarchyIdGetRoot", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "hierarchyid::GetRoot"));
			dictionary.Add("HierarchyIdParse", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "hierarchyid::Parse"));
			return dictionary;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00012F6C File Offset: 0x0001116C
		private static global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> InitializeGeographyStaticMethodFunctionsDictionary()
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler>();
			dictionary.Add("GeographyFromText", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialFromTextFunction));
			dictionary.Add("GeographyPointFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STPointFromText"));
			dictionary.Add("GeographyLineFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STLineFromText"));
			dictionary.Add("GeographyPolygonFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STPolyFromText"));
			dictionary.Add("GeographyMultiPointFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STMPointFromText"));
			dictionary.Add("GeographyMultiLineFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STMLineFromText"));
			dictionary.Add("GeographyMultiPolygonFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STMPolyFromText"));
			dictionary.Add("GeographyCollectionFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STGeomCollFromText"));
			dictionary.Add("GeographyFromBinary", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialFromBinaryFunction));
			dictionary.Add("GeographyPointFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STPointFromWKB"));
			dictionary.Add("GeographyLineFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STLineFromWKB"));
			dictionary.Add("GeographyPolygonFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STPolyFromWKB"));
			dictionary.Add("GeographyMultiPointFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STMPointFromWKB"));
			dictionary.Add("GeographyMultiLineFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STMLineFromWKB"));
			dictionary.Add("GeographyMultiPolygonFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STMPolyFromWKB"));
			dictionary.Add("GeographyCollectionFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geography::STGeomCollFromWKB"));
			dictionary.Add("GeographyFromGml", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialFromGmlFunction));
			return dictionary;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00013210 File Offset: 0x00011410
		private static global::System.Collections.Generic.Dictionary<string, string> InitializeGeographyInstancePropertyFunctionsDictionary()
		{
			return new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"CoordinateSystemId",
					"STSrid"
				},
				{
					"Latitude",
					"Lat"
				},
				{
					"Longitude",
					"Long"
				},
				{
					"Measure",
					"M"
				},
				{
					"Elevation",
					"Z"
				}
			};
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00013274 File Offset: 0x00011474
		private static global::System.Collections.Generic.Dictionary<string, string> InitializeRenamedGeographyInstanceMethodFunctions()
		{
			return new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"AsText",
					"STAsText"
				},
				{
					"AsBinary",
					"STAsBinary"
				},
				{
					"SpatialTypeName",
					"STGeometryType"
				},
				{
					"SpatialDimension",
					"STDimension"
				},
				{
					"IsEmptySpatial",
					"STIsEmpty"
				},
				{
					"SpatialEquals",
					"STEquals"
				},
				{
					"SpatialDisjoint",
					"STDisjoint"
				},
				{
					"SpatialIntersects",
					"STIntersects"
				},
				{
					"SpatialBuffer",
					"STBuffer"
				},
				{
					"Distance",
					"STDistance"
				},
				{
					"SpatialUnion",
					"STUnion"
				},
				{
					"SpatialIntersection",
					"STIntersection"
				},
				{
					"SpatialDifference",
					"STDifference"
				},
				{
					"SpatialSymmetricDifference",
					"STSymDifference"
				},
				{
					"SpatialElementCount",
					"STNumGeometries"
				},
				{
					"SpatialElementAt",
					"STGeometryN"
				},
				{
					"SpatialLength",
					"STLength"
				},
				{
					"StartPoint",
					"STStartPoint"
				},
				{
					"EndPoint",
					"STEndPoint"
				},
				{
					"IsClosedSpatial",
					"STIsClosed"
				},
				{
					"PointCount",
					"STNumPoints"
				},
				{
					"PointAt",
					"STPointN"
				},
				{
					"Area",
					"STArea"
				}
			};
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000133F8 File Offset: 0x000115F8
		private static global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> InitializeGeometryStaticMethodFunctionsDictionary()
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler>();
			dictionary.Add("GeometryFromText", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialFromTextFunction));
			dictionary.Add("GeometryPointFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STPointFromText"));
			dictionary.Add("GeometryLineFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STLineFromText"));
			dictionary.Add("GeometryPolygonFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STPolyFromText"));
			dictionary.Add("GeometryMultiPointFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STMPointFromText"));
			dictionary.Add("GeometryMultiLineFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STMLineFromText"));
			dictionary.Add("GeometryMultiPolygonFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STMPolyFromText"));
			dictionary.Add("GeometryCollectionFromText", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STGeomCollFromText"));
			dictionary.Add("GeometryFromBinary", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialFromBinaryFunction));
			dictionary.Add("GeometryPointFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STPointFromWKB"));
			dictionary.Add("GeometryLineFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STLineFromWKB"));
			dictionary.Add("GeometryPolygonFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STPolyFromWKB"));
			dictionary.Add("GeometryMultiPointFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STMPointFromWKB"));
			dictionary.Add("GeometryMultiLineFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STMLineFromWKB"));
			dictionary.Add("GeometryMultiPolygonFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STMPolyFromWKB"));
			dictionary.Add("GeometryCollectionFromBinary", (global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, "geometry::STGeomCollFromWKB"));
			dictionary.Add("GeometryFromGml", new global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialFromGmlFunction));
			return dictionary;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001369C File Offset: 0x0001189C
		private static global::System.Collections.Generic.Dictionary<string, string> InitializeGeometryInstancePropertyFunctionsDictionary()
		{
			return new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"CoordinateSystemId",
					"STSrid"
				},
				{
					"Measure",
					"M"
				},
				{
					"XCoordinate",
					"STX"
				},
				{
					"YCoordinate",
					"STY"
				},
				{
					"Elevation",
					"Z"
				}
			};
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00013700 File Offset: 0x00011900
		private static global::System.Collections.Generic.Dictionary<string, string> InitializeRenamedGeometryInstanceMethodFunctions()
		{
			return new global::System.Collections.Generic.Dictionary<string, string>
			{
				{
					"AsText",
					"STAsText"
				},
				{
					"AsBinary",
					"STAsBinary"
				},
				{
					"SpatialTypeName",
					"STGeometryType"
				},
				{
					"SpatialDimension",
					"STDimension"
				},
				{
					"IsEmptySpatial",
					"STIsEmpty"
				},
				{
					"IsSimpleGeometry",
					"STIsSimple"
				},
				{
					"IsValidGeometry",
					"STIsValid"
				},
				{
					"SpatialBoundary",
					"STBoundary"
				},
				{
					"SpatialEnvelope",
					"STEnvelope"
				},
				{
					"SpatialEquals",
					"STEquals"
				},
				{
					"SpatialDisjoint",
					"STDisjoint"
				},
				{
					"SpatialIntersects",
					"STIntersects"
				},
				{
					"SpatialTouches",
					"STTouches"
				},
				{
					"SpatialCrosses",
					"STCrosses"
				},
				{
					"SpatialWithin",
					"STWithin"
				},
				{
					"SpatialContains",
					"STContains"
				},
				{
					"SpatialOverlaps",
					"STOverlaps"
				},
				{
					"SpatialRelate",
					"STRelate"
				},
				{
					"SpatialBuffer",
					"STBuffer"
				},
				{
					"SpatialConvexHull",
					"STConvexHull"
				},
				{
					"Distance",
					"STDistance"
				},
				{
					"SpatialUnion",
					"STUnion"
				},
				{
					"SpatialIntersection",
					"STIntersection"
				},
				{
					"SpatialDifference",
					"STDifference"
				},
				{
					"SpatialSymmetricDifference",
					"STSymDifference"
				},
				{
					"SpatialElementCount",
					"STNumGeometries"
				},
				{
					"SpatialElementAt",
					"STGeometryN"
				},
				{
					"SpatialLength",
					"STLength"
				},
				{
					"StartPoint",
					"STStartPoint"
				},
				{
					"EndPoint",
					"STEndPoint"
				},
				{
					"IsClosedSpatial",
					"STIsClosed"
				},
				{
					"IsRing",
					"STIsRing"
				},
				{
					"PointCount",
					"STNumPoints"
				},
				{
					"PointAt",
					"STPointN"
				},
				{
					"Area",
					"STArea"
				},
				{
					"Centroid",
					"STCentroid"
				},
				{
					"PointOnSurface",
					"STPointOnSurface"
				},
				{
					"ExteriorRing",
					"STExteriorRing"
				},
				{
					"InteriorRingCount",
					"STNumInteriorRing"
				},
				{
					"InteriorRingAt",
					"STInteriorRingN"
				}
			};
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00013994 File Offset: 0x00011B94
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleSpatialFromTextFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression)
		{
			string functionName = functionExpression.ResultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry) ? "geometry::STGeomFromText" : "geography::STGeomFromText";
			string functionName2 = functionExpression.ResultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry) ? "geometry::Parse" : "geography::Parse";
			if (functionExpression.Arguments.Count == 2)
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, functionName);
			}
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, functionName2);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000139F8 File Offset: 0x00011BF8
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleSpatialFromGmlFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialStaticMethodFunctionAppendSrid(sqlgen, functionExpression, functionExpression.ResultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry) ? "geometry::GeomFromGml" : "geography::GeomFromGml");
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00013A1C File Offset: 0x00011C1C
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleSpatialFromBinaryFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialStaticMethodFunctionAppendSrid(sqlgen, functionExpression, functionExpression.ResultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry) ? "geometry::STGeomFromWKB" : "geography::STGeomFromWKB");
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00013A40 File Offset: 0x00011C40
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleSpatialStaticMethodFunctionAppendSrid(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression, string functionName)
		{
			if (functionExpression.Arguments.Count == 2)
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, functionExpression, functionName);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = functionExpression.ResultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry) ? global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._defaultGeometrySridExpression : global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._defaultGeographySridExpression;
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append(functionName);
			global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteFunctionArguments(sqlgen, functionExpression.Arguments.Concat(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dbExpression
			}), sqlBuilder);
			return sqlBuilder;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00013AAC File Offset: 0x00011CAC
		internal static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment GenerateFunctionCallSql(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression)
		{
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.IsSpecialCanonicalFunction(functionExpression))
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpecialCanonicalFunction(sqlgen, functionExpression);
			}
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.IsSpecialStoreFunction(functionExpression))
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpecialStoreFunction(sqlgen, functionExpression);
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind spatialTypeKind;
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.IsSpatialCanonicalFunction(functionExpression, out spatialTypeKind))
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialCanonicalFunction(sqlgen, functionExpression, spatialTypeKind);
			}
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.IsHierarchyCanonicalFunction(functionExpression))
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleHierarchyIdCanonicalFunction(sqlgen, functionExpression);
			}
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefault(sqlgen, functionExpression);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00013B03 File Offset: 0x00011D03
		private static bool IsSpecialStoreFunction(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.IsStoreFunction(e.Function) && global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._storeFunctionHandlers.ContainsKey(e.Function.Name);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00013B29 File Offset: 0x00011D29
		private static bool IsSpecialCanonicalFunction(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return e.Function.IsCanonicalFunction() && global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._canonicalFunctionHandlers.ContainsKey(e.Function.Name);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00013B50 File Offset: 0x00011D50
		private static bool IsHierarchyCanonicalFunction(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			if (e.Function.IsCanonicalFunction())
			{
				if (e.ResultType.IsHierarchyIdType())
				{
					return true;
				}
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>.Enumerator enumerator = e.Function.Parameters.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.TypeUsage.IsHierarchyIdType())
						{
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00013BD0 File Offset: 0x00011DD0
		private static bool IsSpatialCanonicalFunction(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind spatialTypeKind)
		{
			if (e.Function.IsCanonicalFunction())
			{
				if (e.ResultType.IsSpatialType(out spatialTypeKind))
				{
					return true;
				}
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>.Enumerator enumerator = e.Function.Parameters.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.TypeUsage.IsSpatialType(out spatialTypeKind))
						{
							return true;
						}
					}
				}
			}
			spatialTypeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary;
			return false;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00013C54 File Offset: 0x00011E54
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleFunctionDefault(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, e, null);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00013C60 File Offset: 0x00011E60
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleFunctionDefaultGivenName(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e, string functionName)
		{
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.CastReturnTypeToInt64(e))
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultCastReturnValue(sqlgen, e, functionName, "bigint");
			}
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.CastReturnTypeToInt32(sqlgen, e))
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultCastReturnValue(sqlgen, e, functionName, "int");
			}
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.CastReturnTypeToInt16(e))
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultCastReturnValue(sqlgen, e, functionName, "smallint");
			}
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.CastReturnTypeToSingle(e))
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultCastReturnValue(sqlgen, e, functionName, "real");
			}
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultCastReturnValue(sqlgen, e, functionName, null);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00013CD0 File Offset: 0x00011ED0
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleFunctionDefaultCastReturnValue(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e, string functionName, string returnType)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WrapWithCast(returnType, delegate(global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result)
			{
				if (functionName == null)
				{
					global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteFunctionName(result, e.Function);
				}
				else
				{
					result.Append(functionName);
				}
				global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionArgumentsDefault(sqlgen, e, result);
			});
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00013D0C File Offset: 0x00011F0C
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment WrapWithCast(string returnType, global::System.Action<global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder> toWrap)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			if (returnType != null)
			{
				sqlBuilder.Append(" CAST(");
			}
			toWrap(sqlBuilder);
			if (returnType != null)
			{
				sqlBuilder.Append(" AS ");
				sqlBuilder.Append(returnType);
				sqlBuilder.Append(")");
			}
			return sqlBuilder;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00013D55 File Offset: 0x00011F55
		private static void HandleFunctionArgumentsDefault(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result)
		{
			bool niladicFunctionAttribute = e.Function.NiladicFunctionAttribute;
			if (niladicFunctionAttribute && e.Arguments.Count > 0)
			{
				throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_NiladicFunctionsCannotHaveParameters);
			}
			if (!niladicFunctionAttribute)
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteFunctionArguments(sqlgen, e.Arguments, result);
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00013D90 File Offset: 0x00011F90
		private static void WriteFunctionArguments(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> functionArguments, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result)
		{
			result.Append("(");
			string s = "";
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in functionArguments)
			{
				result.Append(s);
				result.Append(dbExpression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
				s = ", ";
			}
			result.Append(")");
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00013E08 File Offset: 0x00012008
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleFunctionGivenNameBasedOnVersion(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e, string preKatmaiName, string katmaiName)
		{
			if (sqlgen.IsPreKatmai)
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, e, preKatmaiName);
			}
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, e, katmaiName);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00013E23 File Offset: 0x00012023
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleSpecialStoreFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpecialFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._storeFunctionHandlers, sqlgen, e);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00013E34 File Offset: 0x00012034
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleHierarchyIdCanonicalFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler functionHandler;
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._hierarchyIdFunctionNameToStaticMethodHandlerDictionary.TryGetValue(functionExpression.Function.Name, out functionHandler))
			{
				return functionHandler(sqlgen, functionExpression);
			}
			string name = functionExpression.Function.Name;
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, name, functionExpression, false);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00013E78 File Offset: 0x00012078
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleSpecialCanonicalFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpecialFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._canonicalFunctionHandlers, sqlgen, e);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00013E86 File Offset: 0x00012086
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleSpecialFunction(global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> handlers, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return handlers[e.Function.Name](sqlgen, e);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00013EA0 File Offset: 0x000120A0
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleSpatialCanonicalFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind spatialTypeKind)
		{
			if (spatialTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography)
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialCanonicalFunction(sqlgen, functionExpression, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._geographyFunctionNameToStaticMethodHandlerDictionary, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._geographyFunctionNameToInstancePropertyNameDictionary, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._geographyRenamedInstanceMethodFunctionDictionary);
			}
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpatialCanonicalFunction(sqlgen, functionExpression, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._geometryFunctionNameToStaticMethodHandlerDictionary, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._geometryFunctionNameToInstancePropertyNameDictionary, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._geometryRenamedInstanceMethodFunctionDictionary);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00013ED4 File Offset: 0x000120D4
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleSpatialCanonicalFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression, global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> staticMethodsMap, global::System.Collections.Generic.Dictionary<string, string> instancePropertiesMap, global::System.Collections.Generic.Dictionary<string, string> renamedInstanceMethodsMap)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler functionHandler;
			if (staticMethodsMap.TryGetValue(functionExpression.Function.Name, out functionHandler))
			{
				return functionHandler(sqlgen, functionExpression);
			}
			string functionName;
			if (instancePropertiesMap.TryGetValue(functionExpression.Function.Name, out functionName))
			{
				return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, functionName, functionExpression, true, null);
			}
			string name;
			if (!renamedInstanceMethodsMap.TryGetValue(functionExpression.Function.Name, out name))
			{
				name = functionExpression.Function.Name;
			}
			string castReturnTypeTo = null;
			if (name == "AsGml")
			{
				castReturnTypeTo = "nvarchar(max)";
			}
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, name, functionExpression, false, castReturnTypeTo);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00013F60 File Offset: 0x00012160
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment WriteInstanceFunctionCall(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, string functionName, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression, bool isPropertyAccess)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteInstanceFunctionCall(sqlgen, functionName, functionExpression, isPropertyAccess, null);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00013F6C File Offset: 0x0001216C
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment WriteInstanceFunctionCall(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, string functionName, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpression, bool isPropertyAccess, string castReturnTypeTo)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WrapWithCast(castReturnTypeTo, delegate(global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = functionExpression.Arguments[0];
				if (dbExpression.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Function)
				{
					sqlgen.ParenthesizeExpressionIfNeeded(dbExpression, result);
				}
				else
				{
					result.Append(dbExpression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
				}
				result.Append(".");
				result.Append(functionName);
				if (!isPropertyAccess)
				{
					global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteFunctionArguments(sqlgen, functionExpression.Arguments.Skip(1), result);
				}
			});
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00013FB0 File Offset: 0x000121B0
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleSpecialFunctionToOperator(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e, bool parenthesizeArguments)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			if (e.Arguments.Count > 1)
			{
				if (parenthesizeArguments)
				{
					sqlBuilder.Append("(");
				}
				sqlBuilder.Append(e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
				if (parenthesizeArguments)
				{
					sqlBuilder.Append(")");
				}
			}
			sqlBuilder.Append(" ");
			sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._functionNameToOperatorDictionary[e.Function.Name]);
			sqlBuilder.Append(" ");
			if (parenthesizeArguments)
			{
				sqlBuilder.Append("(");
			}
			sqlBuilder.Append(e.Arguments[e.Arguments.Count - 1].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			if (parenthesizeArguments)
			{
				sqlBuilder.Append(")");
			}
			return sqlBuilder;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00014077 File Offset: 0x00012277
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleConcatFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpecialFunctionToOperator(sqlgen, e, false);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00014081 File Offset: 0x00012281
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionBitwise(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleSpecialFunctionToOperator(sqlgen, e, true);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0001408C File Offset: 0x0001228C
		internal static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleDatepartDateFunction(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = e.Arguments[0] as global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression;
			if (dbConstantExpression == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_InvalidDatePartArgumentExpression(e.Function.NamespaceName, e.Function.Name));
			}
			string text = dbConstantExpression.Value as string;
			if (text == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_InvalidDatePartArgumentExpression(e.Function.NamespaceName, e.Function.Name));
			}
			if (!global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._datepartKeywords.Contains(text))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_InvalidDatePartArgumentValue(text, e.Function.NamespaceName, e.Function.Name));
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WriteFunctionName(sqlBuilder, e.Function);
			sqlBuilder.Append("(");
			sqlBuilder.Append(text);
			for (int i = 1; i < e.Arguments.Count; i++)
			{
				sqlBuilder.Append(", ");
				sqlBuilder.Append(e.Arguments[i].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			}
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00014197 File Offset: 0x00012397
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionDatepart(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDatepart(sqlgen, e.Function.Name.ToLowerInvariant(), e);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000141B0 File Offset: 0x000123B0
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionGetTotalOffsetMinutes(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDatepart(sqlgen, "tzoffset", e);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000141BE File Offset: 0x000123BE
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionLocalDateTime(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			sqlgen.AssertKatmaiOrNewer(e);
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("CAST (");
			sqlBuilder.Append(e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			sqlBuilder.Append(" AS DATETIME2)");
			return sqlBuilder;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000141FA File Offset: 0x000123FA
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionUtcDateTime(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			sqlgen.AssertKatmaiOrNewer(e);
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("CONVERT (DATETIME2, ");
			sqlBuilder.Append(e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			sqlBuilder.Append(", 1)");
			return sqlBuilder;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00014238 File Offset: 0x00012438
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionDatepart(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, string datepart, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("DATEPART (");
			sqlBuilder.Append(datepart);
			sqlBuilder.Append(", ");
			sqlBuilder.Append(e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001428A File Offset: 0x0001248A
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionCurrentDateTime(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionGivenNameBasedOnVersion(sqlgen, e, "GetDate", "SysDateTime");
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001429D File Offset: 0x0001249D
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionCurrentUtcDateTime(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionGivenNameBasedOnVersion(sqlgen, e, "GetUtcDate", "SysUtcDateTime");
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000142B0 File Offset: 0x000124B0
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionCurrentDateTimeOffset(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			sqlgen.AssertKatmaiOrNewer(e);
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, e, "SysDateTimeOffset");
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000142C8 File Offset: 0x000124C8
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionCreateDateTime(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			string typeName = sqlgen.IsPreKatmai ? "datetime" : "datetime2";
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateTimeTypeCreation(sqlgen, typeName, e.Arguments, true, false);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000142F9 File Offset: 0x000124F9
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionCreateDateTimeOffset(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			sqlgen.AssertKatmaiOrNewer(e);
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateTimeTypeCreation(sqlgen, "datetimeoffset", e.Arguments, true, true);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00014315 File Offset: 0x00012515
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionCreateTime(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			sqlgen.AssertKatmaiOrNewer(e);
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateTimeTypeCreation(sqlgen, "time", e.Arguments, false, false);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00014334 File Offset: 0x00012534
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionDateTimeTypeCreation(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, string typeName, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args, bool hasDatePart, bool hasTimeZonePart)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			int index = 0;
			sqlBuilder.Append("convert (");
			sqlBuilder.Append(typeName);
			sqlBuilder.Append(",");
			if (hasDatePart)
			{
				sqlBuilder.Append("right('000' + ");
				global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.AppendConvertToVarchar(sqlgen, sqlBuilder, args[index++]);
				sqlBuilder.Append(", 4)");
				sqlBuilder.Append(" + '-' + ");
				global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.AppendConvertToVarchar(sqlgen, sqlBuilder, args[index++]);
				sqlBuilder.Append(" + '-' + ");
				global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.AppendConvertToVarchar(sqlgen, sqlBuilder, args[index++]);
				sqlBuilder.Append(" + ' ' + ");
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.AppendConvertToVarchar(sqlgen, sqlBuilder, args[index++]);
			sqlBuilder.Append(" + ':' + ");
			global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.AppendConvertToVarchar(sqlgen, sqlBuilder, args[index++]);
			sqlBuilder.Append(" + ':' + str(");
			sqlBuilder.Append(args[index++].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			if (sqlgen.IsPreKatmai)
			{
				sqlBuilder.Append(", 6, 3)");
			}
			else
			{
				sqlBuilder.Append(", 10, 7)");
			}
			if (hasTimeZonePart)
			{
				sqlBuilder.Append(" + (CASE WHEN ");
				sqlgen.ParenthesizeExpressionIfNeeded(args[index], sqlBuilder);
				sqlBuilder.Append(" >= 0 THEN '+' ELSE '-' END) + convert(varchar(255), ABS(");
				sqlgen.ParenthesizeExpressionIfNeeded(args[index], sqlBuilder);
				sqlBuilder.Append("/60)) + ':' + convert(varchar(255), ABS(");
				sqlgen.ParenthesizeExpressionIfNeeded(args[index], sqlBuilder);
				sqlBuilder.Append("%60))");
			}
			sqlBuilder.Append(", 121)");
			return sqlBuilder;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000144AD File Offset: 0x000126AD
		private static void AppendConvertToVarchar(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			result.Append("convert(varchar(255), ");
			result.Append(e.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			result.Append(")");
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000144D4 File Offset: 0x000126D4
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionTruncateTime(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			bool flag = e.Arguments[0].ResultType.GetPrimitiveTypeKind() == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset;
			if (sqlgen.IsPreKatmai && flag)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.SqlGen_CanonicalFunctionNotSupportedPriorSql10(e.Function.Name));
			}
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment s = e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen);
			if (sqlgen.IsPreKatmai)
			{
				sqlBuilder.Append("dateadd(d, datediff(d, 0, ");
				sqlBuilder.Append(s);
				sqlBuilder.Append("), 0)");
			}
			else if (!flag)
			{
				sqlBuilder.Append("cast(cast(");
				sqlBuilder.Append(s);
				sqlBuilder.Append(" as date) as datetime2)");
			}
			else
			{
				sqlBuilder.Append("todatetimeoffset(cast(");
				sqlBuilder.Append(s);
				sqlBuilder.Append(" as date), datepart(tz, ");
				sqlBuilder.Append(s);
				sqlBuilder.Append("))");
			}
			return sqlBuilder;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000145AE File Offset: 0x000127AE
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionDateAddKatmaiOrNewer(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			sqlgen.AssertKatmaiOrNewer(e);
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateAdd(sqlgen, e);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000145C0 File Offset: 0x000127C0
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionDateAdd(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("DATEADD (");
			sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._dateAddFunctionNameToDatepartDictionary[e.Function.Name]);
			sqlBuilder.Append(", ");
			sqlBuilder.Append(e.Arguments[1].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			sqlBuilder.Append(", ");
			sqlBuilder.Append(e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00014649 File Offset: 0x00012849
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionDateDiffKatmaiOrNewer(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			sqlgen.AssertKatmaiOrNewer(e);
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionDateDiff(sqlgen, e);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0001465C File Offset: 0x0001285C
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionDateDiff(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("DATEDIFF (");
			sqlBuilder.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._dateDiffFunctionNameToDatepartDictionary[e.Function.Name]);
			sqlBuilder.Append(", ");
			sqlBuilder.Append(e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			sqlBuilder.Append(", ");
			sqlBuilder.Append(e.Arguments[1].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			sqlBuilder.Append(")");
			return sqlBuilder;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000146E5 File Offset: 0x000128E5
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionIndexOf(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, e, "CHARINDEX");
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000146F3 File Offset: 0x000128F3
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionNewGuid(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, e, "NEWID");
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00014701 File Offset: 0x00012901
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionLength(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, e, "LEN");
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0001470F File Offset: 0x0001290F
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionRound(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionRoundOrTruncate(sqlgen, e, true);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00014719 File Offset: 0x00012919
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionTruncate(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionRoundOrTruncate(sqlgen, e, false);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00014724 File Offset: 0x00012924
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionRoundOrTruncate(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e, bool round)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			bool flag = false;
			if (e.Arguments.Count == 1)
			{
				flag = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.CastReturnTypeToSingle(e);
				if (flag)
				{
					sqlBuilder.Append(" CAST(");
				}
			}
			sqlBuilder.Append("ROUND(");
			sqlBuilder.Append(e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			sqlBuilder.Append(", ");
			if (e.Arguments.Count > 1)
			{
				sqlBuilder.Append(e.Arguments[1].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			}
			else
			{
				sqlBuilder.Append("0");
			}
			if (!round)
			{
				sqlBuilder.Append(", 1");
			}
			sqlBuilder.Append(")");
			if (flag)
			{
				sqlBuilder.Append(" AS real)");
			}
			return sqlBuilder;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000147E5 File Offset: 0x000129E5
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionAbs(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			if (e.Arguments[0].ResultType.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte))
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
				sqlBuilder.Append(e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
				return sqlBuilder;
			}
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefault(sqlgen, e);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00014825 File Offset: 0x00012A25
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionTrim(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("LTRIM(RTRIM(");
			sqlBuilder.Append(e.Arguments[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			sqlBuilder.Append("))");
			return sqlBuilder;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0001485A File Offset: 0x00012A5A
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionToLower(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, e, "LOWER");
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00014868 File Offset: 0x00012A68
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionToUpper(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleFunctionDefaultGivenName(sqlgen, e, "UPPER");
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00014878 File Offset: 0x00012A78
		private static void TranslateConstantParameterForLike(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression targetExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression constSearchParamExpression, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result, bool insertPercentStart, bool insertPercentEnd)
		{
			result.Append(targetExpression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			result.Append(" LIKE ");
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (insertPercentStart)
			{
				stringBuilder.Append("%");
			}
			bool flag;
			stringBuilder.Append(global::System.Data.Entity.SqlServer.SqlProviderManifest.EscapeLikeText(constSearchParamExpression.Value as string, false, out flag));
			if (insertPercentEnd)
			{
				stringBuilder.Append("%");
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = constSearchParamExpression.ResultType.Constant(stringBuilder.ToString());
			result.Append(dbConstantExpression.Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
			if (flag)
			{
				result.Append(" ESCAPE '~'");
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001490A File Offset: 0x00012B0A
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionContains(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WrapPredicate(new global::System.Func<global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder>(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionContains), sqlgen, e);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00014920 File Offset: 0x00012B20
		private static global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder HandleCanonicalFunctionContains(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = args[1] as global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression;
			if (dbConstantExpression != null && !string.IsNullOrEmpty(dbConstantExpression.Value as string))
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.TranslateConstantParameterForLike(sqlgen, args[0], dbConstantExpression, result, true, true);
			}
			else
			{
				result.Append("CHARINDEX( ");
				result.Append(args[1].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
				result.Append(", ");
				result.Append(args[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
				result.Append(") > 0");
			}
			return result;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000149AA File Offset: 0x00012BAA
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionStartsWith(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WrapPredicate(new global::System.Func<global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder>(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionStartsWith), sqlgen, e);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000149C0 File Offset: 0x00012BC0
		private static global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder HandleCanonicalFunctionStartsWith(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = args[1] as global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression;
			if (dbConstantExpression != null && !string.IsNullOrEmpty(dbConstantExpression.Value as string))
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.TranslateConstantParameterForLike(sqlgen, args[0], dbConstantExpression, result, false, true);
			}
			else
			{
				result.Append("CHARINDEX( ");
				result.Append(args[1].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
				result.Append(", ");
				result.Append(args[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
				result.Append(") = 1");
			}
			return result;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00014A4A File Offset: 0x00012C4A
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment HandleCanonicalFunctionEndsWith(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.WrapPredicate(new global::System.Func<global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder>(global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.HandleCanonicalFunctionEndsWith), sqlgen, e);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00014A60 File Offset: 0x00012C60
		private static global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder HandleCanonicalFunctionEndsWith(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression = args[1] as global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression;
			global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression dbPropertyExpression = args[0] as global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression;
			if (dbConstantExpression != null && dbPropertyExpression != null && !string.IsNullOrEmpty(dbConstantExpression.Value as string))
			{
				global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.TranslateConstantParameterForLike(sqlgen, args[0], dbConstantExpression, result, true, false);
			}
			else
			{
				result.Append("CHARINDEX( REVERSE(");
				result.Append(args[1].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
				result.Append("), REVERSE(");
				result.Append(args[0].Accept<global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment>(sqlgen));
				result.Append(")) = 1");
			}
			return result;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00014AFC File Offset: 0x00012CFC
		private static global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment WrapPredicate(global::System.Func<global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder, global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder> predicateTranslator, global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder sqlBuilder = new global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder();
			sqlBuilder.Append("CASE WHEN (");
			predicateTranslator(sqlgen, e.Arguments, sqlBuilder);
			sqlBuilder.Append(") THEN cast(1 as bit) WHEN ( NOT (");
			predicateTranslator(sqlgen, e.Arguments, sqlBuilder);
			sqlBuilder.Append(")) THEN cast(0 as bit) END");
			return sqlBuilder;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00014B50 File Offset: 0x00012D50
		internal static void WriteFunctionName(global::System.Data.Entity.SqlServer.SqlGen.SqlBuilder result, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			string text;
			if (function.StoreFunctionNameAttribute != null)
			{
				text = function.StoreFunctionNameAttribute;
			}
			else
			{
				text = function.Name;
			}
			if (function.IsCanonicalFunction())
			{
				result.Append(text.ToUpperInvariant());
				return;
			}
			if (global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.IsStoreFunction(function))
			{
				result.Append(text);
				return;
			}
			if (string.IsNullOrEmpty(function.Schema))
			{
				result.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(function.NamespaceName));
			}
			else
			{
				result.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(function.Schema));
			}
			result.Append(".");
			result.Append(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(text));
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00014BE2 File Offset: 0x00012DE2
		internal static bool IsStoreFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			return function.BuiltInAttribute && !function.IsCanonicalFunction();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00014BF7 File Offset: 0x00012DF7
		internal static bool CastReturnTypeToInt64(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.CastReturnTypeToGivenType(e, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._functionRequiresReturnTypeCastToInt64, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00014C08 File Offset: 0x00012E08
		internal static bool CastReturnTypeToInt32(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			if (!global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._functionRequiresReturnTypeCastToInt32.Contains(e.Function.FullName))
			{
				return false;
			}
			return (from t in e.Arguments
			select sqlgen.StoreItemCollection.ProviderManifest.GetStoreType(t.ResultType)).Any((global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType) => global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._maxTypeNames.Contains(storeType.EdmType.Name));
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00014C76 File Offset: 0x00012E76
		internal static bool CastReturnTypeToInt16(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.CastReturnTypeToGivenType(e, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._functionRequiresReturnTypeCastToInt16, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00014C85 File Offset: 0x00012E85
		internal static bool CastReturnTypeToSingle(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			return global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.CastReturnTypeToGivenType(e, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler._functionRequiresReturnTypeCastToSingle, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00014C94 File Offset: 0x00012E94
		private static bool CastReturnTypeToGivenType(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e, global::System.Collections.Generic.ISet<string> functionsRequiringReturnTypeCast, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind type)
		{
			return functionsRequiringReturnTypeCast.Contains(e.Function.FullName) && e.Arguments.Any((global::System.Data.Entity.Core.Common.CommandTrees.DbExpression t) => t.ResultType.IsPrimitiveType(type));
		}

		// Token: 0x040000E6 RID: 230
		private static readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> _storeFunctionHandlers = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeStoreFunctionHandlers();

		// Token: 0x040000E7 RID: 231
		private static readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> _canonicalFunctionHandlers = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeCanonicalFunctionHandlers();

		// Token: 0x040000E8 RID: 232
		private static readonly global::System.Collections.Generic.Dictionary<string, string> _functionNameToOperatorDictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeFunctionNameToOperatorDictionary();

		// Token: 0x040000E9 RID: 233
		private static readonly global::System.Collections.Generic.Dictionary<string, string> _dateAddFunctionNameToDatepartDictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeDateAddFunctionNameToDatepartDictionary();

		// Token: 0x040000EA RID: 234
		private static readonly global::System.Collections.Generic.Dictionary<string, string> _dateDiffFunctionNameToDatepartDictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeDateDiffFunctionNameToDatepartDictionary();

		// Token: 0x040000EB RID: 235
		private static readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> _hierarchyIdFunctionNameToStaticMethodHandlerDictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeHierarchyIdStaticMethodFunctionsDictionary();

		// Token: 0x040000EC RID: 236
		private static readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> _geographyFunctionNameToStaticMethodHandlerDictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeGeographyStaticMethodFunctionsDictionary();

		// Token: 0x040000ED RID: 237
		private static readonly global::System.Collections.Generic.Dictionary<string, string> _geographyFunctionNameToInstancePropertyNameDictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeGeographyInstancePropertyFunctionsDictionary();

		// Token: 0x040000EE RID: 238
		private static readonly global::System.Collections.Generic.Dictionary<string, string> _geographyRenamedInstanceMethodFunctionDictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeRenamedGeographyInstanceMethodFunctions();

		// Token: 0x040000EF RID: 239
		private static readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.FunctionHandler> _geometryFunctionNameToStaticMethodHandlerDictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeGeometryStaticMethodFunctionsDictionary();

		// Token: 0x040000F0 RID: 240
		private static readonly global::System.Collections.Generic.Dictionary<string, string> _geometryFunctionNameToInstancePropertyNameDictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeGeometryInstancePropertyFunctionsDictionary();

		// Token: 0x040000F1 RID: 241
		private static readonly global::System.Collections.Generic.Dictionary<string, string> _geometryRenamedInstanceMethodFunctionDictionary = global::System.Data.Entity.SqlServer.SqlGen.SqlFunctionCallHandler.InitializeRenamedGeometryInstanceMethodFunctions();

		// Token: 0x040000F2 RID: 242
		private static readonly global::System.Collections.Generic.ISet<string> _datepartKeywords = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase)
		{
			"year",
			"yy",
			"yyyy",
			"quarter",
			"qq",
			"q",
			"month",
			"mm",
			"m",
			"dayofyear",
			"dy",
			"y",
			"day",
			"dd",
			"d",
			"week",
			"wk",
			"ww",
			"weekday",
			"dw",
			"w",
			"hour",
			"hh",
			"minute",
			"mi",
			"n",
			"second",
			"ss",
			"s",
			"millisecond",
			"ms",
			"microsecond",
			"mcs",
			"nanosecond",
			"ns",
			"tzoffset",
			"tz",
			"iso_week",
			"isoww",
			"isowk"
		};

		// Token: 0x040000F3 RID: 243
		private static readonly global::System.Collections.Generic.ISet<string> _functionRequiresReturnTypeCastToInt64 = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase)
		{
			"SqlServer.CHARINDEX"
		};

		// Token: 0x040000F4 RID: 244
		private static readonly global::System.Collections.Generic.ISet<string> _functionRequiresReturnTypeCastToInt32 = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase)
		{
			"SqlServer.LEN",
			"SqlServer.PATINDEX",
			"SqlServer.DATALENGTH",
			"SqlServer.CHARINDEX",
			"Edm.IndexOf",
			"Edm.Length"
		};

		// Token: 0x040000F5 RID: 245
		private static readonly global::System.Collections.Generic.ISet<string> _functionRequiresReturnTypeCastToInt16 = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase)
		{
			"Edm.Abs"
		};

		// Token: 0x040000F6 RID: 246
		private static readonly global::System.Collections.Generic.ISet<string> _functionRequiresReturnTypeCastToSingle = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase)
		{
			"Edm.Abs",
			"Edm.Round",
			"Edm.Floor",
			"Edm.Ceiling"
		};

		// Token: 0x040000F7 RID: 247
		private static readonly global::System.Collections.Generic.ISet<string> _maxTypeNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase)
		{
			"varchar(max)",
			"nvarchar(max)",
			"text",
			"ntext",
			"varbinary(max)",
			"image",
			"xml"
		};

		// Token: 0x040000F8 RID: 248
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _defaultGeographySridExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(global::System.Data.Entity.Spatial.DbGeography.DefaultCoordinateSystemId);

		// Token: 0x040000F9 RID: 249
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _defaultGeometrySridExpression = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(global::System.Data.Entity.Spatial.DbGeometry.DefaultCoordinateSystemId);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000701 RID: 1793
		private delegate global::System.Data.Entity.SqlServer.SqlGen.ISqlFragment FunctionHandler(global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator sqlgen, global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression functionExpr);
	}
}
