using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000408 RID: 1032
	[global::System.Obsolete("This class has been replaced by System.Data.Entity.DbFunctions.")]
	public static class EntityFunctions
	{
		// Token: 0x060030BA RID: 12474 RVA: 0x0009B854 File Offset: 0x00099A54
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<decimal> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviation(collection);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x0009B85C File Offset: 0x00099A5C
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<decimal?> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviation(collection);
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x0009B864 File Offset: 0x00099A64
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<double> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviation(collection);
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x0009B86C File Offset: 0x00099A6C
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<double?> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviation(collection);
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x0009B874 File Offset: 0x00099A74
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<int> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviation(collection);
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x0009B87C File Offset: 0x00099A7C
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<int?> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviation(collection);
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x0009B884 File Offset: 0x00099A84
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<long> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviation(collection);
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0009B88C File Offset: 0x00099A8C
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<long?> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviation(collection);
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x0009B894 File Offset: 0x00099A94
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<decimal> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviationP(collection);
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x0009B89C File Offset: 0x00099A9C
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<decimal?> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviationP(collection);
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0009B8A4 File Offset: 0x00099AA4
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<double> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviationP(collection);
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x0009B8AC File Offset: 0x00099AAC
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<double?> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviationP(collection);
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x0009B8B4 File Offset: 0x00099AB4
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<int> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviationP(collection);
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x0009B8BC File Offset: 0x00099ABC
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<int?> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviationP(collection);
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x0009B8C4 File Offset: 0x00099AC4
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<long> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviationP(collection);
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x0009B8CC File Offset: 0x00099ACC
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<long?> collection)
		{
			return global::System.Data.Entity.DbFunctions.StandardDeviationP(collection);
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x0009B8D4 File Offset: 0x00099AD4
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<decimal> collection)
		{
			return global::System.Data.Entity.DbFunctions.Var(collection);
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x0009B8DC File Offset: 0x00099ADC
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<decimal?> collection)
		{
			return global::System.Data.Entity.DbFunctions.Var(collection);
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x0009B8E4 File Offset: 0x00099AE4
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<double> collection)
		{
			return global::System.Data.Entity.DbFunctions.Var(collection);
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x0009B8EC File Offset: 0x00099AEC
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<double?> collection)
		{
			return global::System.Data.Entity.DbFunctions.Var(collection);
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x0009B8F4 File Offset: 0x00099AF4
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<int> collection)
		{
			return global::System.Data.Entity.DbFunctions.Var(collection);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x0009B8FC File Offset: 0x00099AFC
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<int?> collection)
		{
			return global::System.Data.Entity.DbFunctions.Var(collection);
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x0009B904 File Offset: 0x00099B04
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<long> collection)
		{
			return global::System.Data.Entity.DbFunctions.Var(collection);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x0009B90C File Offset: 0x00099B0C
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<long?> collection)
		{
			return global::System.Data.Entity.DbFunctions.Var(collection);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x0009B914 File Offset: 0x00099B14
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<decimal> collection)
		{
			return global::System.Data.Entity.DbFunctions.VarP(collection);
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0009B91C File Offset: 0x00099B1C
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<decimal?> collection)
		{
			return global::System.Data.Entity.DbFunctions.VarP(collection);
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x0009B924 File Offset: 0x00099B24
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<double> collection)
		{
			return global::System.Data.Entity.DbFunctions.VarP(collection);
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x0009B92C File Offset: 0x00099B2C
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<double?> collection)
		{
			return global::System.Data.Entity.DbFunctions.VarP(collection);
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x0009B934 File Offset: 0x00099B34
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<int> collection)
		{
			return global::System.Data.Entity.DbFunctions.VarP(collection);
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x0009B93C File Offset: 0x00099B3C
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<int?> collection)
		{
			return global::System.Data.Entity.DbFunctions.VarP(collection);
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x0009B944 File Offset: 0x00099B44
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<long> collection)
		{
			return global::System.Data.Entity.DbFunctions.VarP(collection);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x0009B94C File Offset: 0x00099B4C
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<long?> collection)
		{
			return global::System.Data.Entity.DbFunctions.VarP(collection);
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x0009B954 File Offset: 0x00099B54
		[global::System.Data.Entity.DbFunction("Edm", "Left")]
		public static string Left(string stringArgument, long? length)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x0009B960 File Offset: 0x00099B60
		[global::System.Data.Entity.DbFunction("Edm", "Right")]
		public static string Right(string stringArgument, long? length)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x0009B96C File Offset: 0x00099B6C
		[global::System.Data.Entity.DbFunction("Edm", "Reverse")]
		public static string Reverse(string stringArgument)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x0009B978 File Offset: 0x00099B78
		[global::System.Data.Entity.DbFunction("Edm", "GetTotalOffsetMinutes")]
		public static int? GetTotalOffsetMinutes(global::System.DateTimeOffset? dateTimeOffsetArgument)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x0009B984 File Offset: 0x00099B84
		[global::System.Data.Entity.DbFunction("Edm", "TruncateTime")]
		public static global::System.DateTimeOffset? TruncateTime(global::System.DateTimeOffset? dateValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x0009B990 File Offset: 0x00099B90
		[global::System.Data.Entity.DbFunction("Edm", "TruncateTime")]
		public static global::System.DateTime? TruncateTime(global::System.DateTime? dateValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0009B99C File Offset: 0x00099B9C
		[global::System.Data.Entity.DbFunction("Edm", "CreateDateTime")]
		public static global::System.DateTime? CreateDateTime(int? year, int? month, int? day, int? hour, int? minute, double? second)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0009B9A8 File Offset: 0x00099BA8
		[global::System.Data.Entity.DbFunction("Edm", "CreateDateTimeOffset")]
		public static global::System.DateTimeOffset? CreateDateTimeOffset(int? year, int? month, int? day, int? hour, int? minute, double? second, int? timeZoneOffset)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x0009B9B4 File Offset: 0x00099BB4
		[global::System.Data.Entity.DbFunction("Edm", "CreateTime")]
		public static global::System.TimeSpan? CreateTime(int? hour, int? minute, double? second)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x0009B9C0 File Offset: 0x00099BC0
		[global::System.Data.Entity.DbFunction("Edm", "AddYears")]
		public static global::System.DateTimeOffset? AddYears(global::System.DateTimeOffset? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x0009B9CC File Offset: 0x00099BCC
		[global::System.Data.Entity.DbFunction("Edm", "AddYears")]
		public static global::System.DateTime? AddYears(global::System.DateTime? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0009B9D8 File Offset: 0x00099BD8
		[global::System.Data.Entity.DbFunction("Edm", "AddMonths")]
		public static global::System.DateTimeOffset? AddMonths(global::System.DateTimeOffset? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x0009B9E4 File Offset: 0x00099BE4
		[global::System.Data.Entity.DbFunction("Edm", "AddMonths")]
		public static global::System.DateTime? AddMonths(global::System.DateTime? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x0009B9F0 File Offset: 0x00099BF0
		[global::System.Data.Entity.DbFunction("Edm", "AddDays")]
		public static global::System.DateTimeOffset? AddDays(global::System.DateTimeOffset? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0009B9FC File Offset: 0x00099BFC
		[global::System.Data.Entity.DbFunction("Edm", "AddDays")]
		public static global::System.DateTime? AddDays(global::System.DateTime? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x0009BA08 File Offset: 0x00099C08
		[global::System.Data.Entity.DbFunction("Edm", "AddHours")]
		public static global::System.DateTimeOffset? AddHours(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x0009BA14 File Offset: 0x00099C14
		[global::System.Data.Entity.DbFunction("Edm", "AddHours")]
		public static global::System.DateTime? AddHours(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x0009BA20 File Offset: 0x00099C20
		[global::System.Data.Entity.DbFunction("Edm", "AddHours")]
		public static global::System.TimeSpan? AddHours(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x0009BA2C File Offset: 0x00099C2C
		[global::System.Data.Entity.DbFunction("Edm", "AddMinutes")]
		public static global::System.DateTimeOffset? AddMinutes(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x0009BA38 File Offset: 0x00099C38
		[global::System.Data.Entity.DbFunction("Edm", "AddMinutes")]
		public static global::System.DateTime? AddMinutes(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x0009BA44 File Offset: 0x00099C44
		[global::System.Data.Entity.DbFunction("Edm", "AddMinutes")]
		public static global::System.TimeSpan? AddMinutes(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x0009BA50 File Offset: 0x00099C50
		[global::System.Data.Entity.DbFunction("Edm", "AddSeconds")]
		public static global::System.DateTimeOffset? AddSeconds(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x0009BA5C File Offset: 0x00099C5C
		[global::System.Data.Entity.DbFunction("Edm", "AddSeconds")]
		public static global::System.DateTime? AddSeconds(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x0009BA68 File Offset: 0x00099C68
		[global::System.Data.Entity.DbFunction("Edm", "AddSeconds")]
		public static global::System.TimeSpan? AddSeconds(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x0009BA74 File Offset: 0x00099C74
		[global::System.Data.Entity.DbFunction("Edm", "AddMilliseconds")]
		public static global::System.DateTimeOffset? AddMilliseconds(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0009BA80 File Offset: 0x00099C80
		[global::System.Data.Entity.DbFunction("Edm", "AddMilliseconds")]
		public static global::System.DateTime? AddMilliseconds(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x0009BA8C File Offset: 0x00099C8C
		[global::System.Data.Entity.DbFunction("Edm", "AddMilliseconds")]
		public static global::System.TimeSpan? AddMilliseconds(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x0009BA98 File Offset: 0x00099C98
		[global::System.Data.Entity.DbFunction("Edm", "AddMicroseconds")]
		public static global::System.DateTimeOffset? AddMicroseconds(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x0009BAA4 File Offset: 0x00099CA4
		[global::System.Data.Entity.DbFunction("Edm", "AddMicroseconds")]
		public static global::System.DateTime? AddMicroseconds(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x0009BAB0 File Offset: 0x00099CB0
		[global::System.Data.Entity.DbFunction("Edm", "AddMicroseconds")]
		public static global::System.TimeSpan? AddMicroseconds(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x0009BABC File Offset: 0x00099CBC
		[global::System.Data.Entity.DbFunction("Edm", "AddNanoseconds")]
		public static global::System.DateTimeOffset? AddNanoseconds(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x0009BAC8 File Offset: 0x00099CC8
		[global::System.Data.Entity.DbFunction("Edm", "AddNanoseconds")]
		public static global::System.DateTime? AddNanoseconds(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0009BAD4 File Offset: 0x00099CD4
		[global::System.Data.Entity.DbFunction("Edm", "AddNanoseconds")]
		public static global::System.TimeSpan? AddNanoseconds(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x0009BAE0 File Offset: 0x00099CE0
		[global::System.Data.Entity.DbFunction("Edm", "DiffYears")]
		public static int? DiffYears(global::System.DateTimeOffset? dateValue1, global::System.DateTimeOffset? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x0009BAEC File Offset: 0x00099CEC
		[global::System.Data.Entity.DbFunction("Edm", "DiffYears")]
		public static int? DiffYears(global::System.DateTime? dateValue1, global::System.DateTime? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x0009BAF8 File Offset: 0x00099CF8
		[global::System.Data.Entity.DbFunction("Edm", "DiffMonths")]
		public static int? DiffMonths(global::System.DateTimeOffset? dateValue1, global::System.DateTimeOffset? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x0009BB04 File Offset: 0x00099D04
		[global::System.Data.Entity.DbFunction("Edm", "DiffMonths")]
		public static int? DiffMonths(global::System.DateTime? dateValue1, global::System.DateTime? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x0009BB10 File Offset: 0x00099D10
		[global::System.Data.Entity.DbFunction("Edm", "DiffDays")]
		public static int? DiffDays(global::System.DateTimeOffset? dateValue1, global::System.DateTimeOffset? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x0009BB1C File Offset: 0x00099D1C
		[global::System.Data.Entity.DbFunction("Edm", "DiffDays")]
		public static int? DiffDays(global::System.DateTime? dateValue1, global::System.DateTime? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x0009BB28 File Offset: 0x00099D28
		[global::System.Data.Entity.DbFunction("Edm", "DiffHours")]
		public static int? DiffHours(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x0009BB34 File Offset: 0x00099D34
		[global::System.Data.Entity.DbFunction("Edm", "DiffHours")]
		public static int? DiffHours(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x0009BB40 File Offset: 0x00099D40
		[global::System.Data.Entity.DbFunction("Edm", "DiffHours")]
		public static int? DiffHours(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x0009BB4C File Offset: 0x00099D4C
		[global::System.Data.Entity.DbFunction("Edm", "DiffMinutes")]
		public static int? DiffMinutes(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x0009BB58 File Offset: 0x00099D58
		[global::System.Data.Entity.DbFunction("Edm", "DiffMinutes")]
		public static int? DiffMinutes(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x0009BB64 File Offset: 0x00099D64
		[global::System.Data.Entity.DbFunction("Edm", "DiffMinutes")]
		public static int? DiffMinutes(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x0009BB70 File Offset: 0x00099D70
		[global::System.Data.Entity.DbFunction("Edm", "DiffSeconds")]
		public static int? DiffSeconds(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x0009BB7C File Offset: 0x00099D7C
		[global::System.Data.Entity.DbFunction("Edm", "DiffSeconds")]
		public static int? DiffSeconds(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x0009BB88 File Offset: 0x00099D88
		[global::System.Data.Entity.DbFunction("Edm", "DiffSeconds")]
		public static int? DiffSeconds(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x0009BB94 File Offset: 0x00099D94
		[global::System.Data.Entity.DbFunction("Edm", "DiffMilliseconds")]
		public static int? DiffMilliseconds(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x0009BBA0 File Offset: 0x00099DA0
		[global::System.Data.Entity.DbFunction("Edm", "DiffMilliseconds")]
		public static int? DiffMilliseconds(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x0009BBAC File Offset: 0x00099DAC
		[global::System.Data.Entity.DbFunction("Edm", "DiffMilliseconds")]
		public static int? DiffMilliseconds(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x0009BBB8 File Offset: 0x00099DB8
		[global::System.Data.Entity.DbFunction("Edm", "DiffMicroseconds")]
		public static int? DiffMicroseconds(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x0009BBC4 File Offset: 0x00099DC4
		[global::System.Data.Entity.DbFunction("Edm", "DiffMicroseconds")]
		public static int? DiffMicroseconds(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x0009BBD0 File Offset: 0x00099DD0
		[global::System.Data.Entity.DbFunction("Edm", "DiffMicroseconds")]
		public static int? DiffMicroseconds(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x0009BBDC File Offset: 0x00099DDC
		[global::System.Data.Entity.DbFunction("Edm", "DiffNanoseconds")]
		public static int? DiffNanoseconds(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x0009BBE8 File Offset: 0x00099DE8
		[global::System.Data.Entity.DbFunction("Edm", "DiffNanoseconds")]
		public static int? DiffNanoseconds(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x0009BBF4 File Offset: 0x00099DF4
		[global::System.Data.Entity.DbFunction("Edm", "DiffNanoseconds")]
		public static int? DiffNanoseconds(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x0009BC00 File Offset: 0x00099E00
		[global::System.Data.Entity.DbFunction("Edm", "Truncate")]
		public static double? Truncate(double? value, int? digits)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x0009BC0C File Offset: 0x00099E0C
		[global::System.Data.Entity.DbFunction("Edm", "Truncate")]
		public static decimal? Truncate(decimal? value, int? digits)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x0009BC18 File Offset: 0x00099E18
		public static bool Like(string searchString, string likeExpression)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x0009BC24 File Offset: 0x00099E24
		public static bool Like(string searchString, string likeExpression, string escapeCharacter)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x0009BC30 File Offset: 0x00099E30
		public static string AsUnicode(string value)
		{
			return value;
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0009BC33 File Offset: 0x00099E33
		public static string AsNonUnicode(string value)
		{
			return value;
		}
	}
}
