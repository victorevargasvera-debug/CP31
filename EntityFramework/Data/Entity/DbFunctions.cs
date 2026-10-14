using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Linq;
using System.Linq.Expressions;

namespace System.Data.Entity
{
	// Token: 0x0200005E RID: 94
	public static class DbFunctions
	{
		// Token: 0x060002AC RID: 684 RVA: 0x000096CC File Offset: 0x000078CC
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<decimal> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<decimal, double?>((global::System.Collections.Generic.IEnumerable<decimal> c) => global::System.Data.Entity.DbFunctions.StandardDeviation(c), collection);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00009724 File Offset: 0x00007924
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<decimal?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<decimal?, double?>((global::System.Collections.Generic.IEnumerable<decimal?> c) => global::System.Data.Entity.DbFunctions.StandardDeviation(c), collection);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000977C File Offset: 0x0000797C
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<double> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<double, double?>((global::System.Collections.Generic.IEnumerable<double> c) => global::System.Data.Entity.DbFunctions.StandardDeviation(c), collection);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000097D4 File Offset: 0x000079D4
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<double?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<double?, double?>((global::System.Collections.Generic.IEnumerable<double?> c) => global::System.Data.Entity.DbFunctions.StandardDeviation(c), collection);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000982C File Offset: 0x00007A2C
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<int> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<int, double?>((global::System.Collections.Generic.IEnumerable<int> c) => global::System.Data.Entity.DbFunctions.StandardDeviation(c), collection);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00009884 File Offset: 0x00007A84
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<int?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<int?, double?>((global::System.Collections.Generic.IEnumerable<int?> c) => global::System.Data.Entity.DbFunctions.StandardDeviation(c), collection);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000098DC File Offset: 0x00007ADC
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<long> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<long, double?>((global::System.Collections.Generic.IEnumerable<long> c) => global::System.Data.Entity.DbFunctions.StandardDeviation(c), collection);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00009934 File Offset: 0x00007B34
		[global::System.Data.Entity.DbFunction("Edm", "StDev")]
		public static double? StandardDeviation(global::System.Collections.Generic.IEnumerable<long?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<long?, double?>((global::System.Collections.Generic.IEnumerable<long?> c) => global::System.Data.Entity.DbFunctions.StandardDeviation(c), collection);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000998C File Offset: 0x00007B8C
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<decimal> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<decimal, double?>((global::System.Collections.Generic.IEnumerable<decimal> c) => global::System.Data.Entity.DbFunctions.StandardDeviationP(c), collection);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000099E4 File Offset: 0x00007BE4
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<decimal?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<decimal?, double?>((global::System.Collections.Generic.IEnumerable<decimal?> c) => global::System.Data.Entity.DbFunctions.StandardDeviationP(c), collection);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00009A3C File Offset: 0x00007C3C
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<double> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<double, double?>((global::System.Collections.Generic.IEnumerable<double> c) => global::System.Data.Entity.DbFunctions.StandardDeviationP(c), collection);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00009A94 File Offset: 0x00007C94
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<double?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<double?, double?>((global::System.Collections.Generic.IEnumerable<double?> c) => global::System.Data.Entity.DbFunctions.StandardDeviationP(c), collection);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00009AEC File Offset: 0x00007CEC
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<int> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<int, double?>((global::System.Collections.Generic.IEnumerable<int> c) => global::System.Data.Entity.DbFunctions.StandardDeviationP(c), collection);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00009B44 File Offset: 0x00007D44
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<int?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<int?, double?>((global::System.Collections.Generic.IEnumerable<int?> c) => global::System.Data.Entity.DbFunctions.StandardDeviationP(c), collection);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00009B9C File Offset: 0x00007D9C
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<long> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<long, double?>((global::System.Collections.Generic.IEnumerable<long> c) => global::System.Data.Entity.DbFunctions.StandardDeviationP(c), collection);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00009BF4 File Offset: 0x00007DF4
		[global::System.Data.Entity.DbFunction("Edm", "StDevP")]
		public static double? StandardDeviationP(global::System.Collections.Generic.IEnumerable<long?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<long?, double?>((global::System.Collections.Generic.IEnumerable<long?> c) => global::System.Data.Entity.DbFunctions.StandardDeviationP(c), collection);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00009C4C File Offset: 0x00007E4C
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<decimal> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<decimal, double?>((global::System.Collections.Generic.IEnumerable<decimal> c) => global::System.Data.Entity.DbFunctions.Var(c), collection);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00009CA4 File Offset: 0x00007EA4
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<decimal?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<decimal?, double?>((global::System.Collections.Generic.IEnumerable<decimal?> c) => global::System.Data.Entity.DbFunctions.Var(c), collection);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00009CFC File Offset: 0x00007EFC
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<double> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<double, double?>((global::System.Collections.Generic.IEnumerable<double> c) => global::System.Data.Entity.DbFunctions.Var(c), collection);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00009D54 File Offset: 0x00007F54
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<double?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<double?, double?>((global::System.Collections.Generic.IEnumerable<double?> c) => global::System.Data.Entity.DbFunctions.Var(c), collection);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00009DAC File Offset: 0x00007FAC
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<int> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<int, double?>((global::System.Collections.Generic.IEnumerable<int> c) => global::System.Data.Entity.DbFunctions.Var(c), collection);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00009E04 File Offset: 0x00008004
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<int?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<int?, double?>((global::System.Collections.Generic.IEnumerable<int?> c) => global::System.Data.Entity.DbFunctions.Var(c), collection);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00009E5C File Offset: 0x0000805C
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<long> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<long, double?>((global::System.Collections.Generic.IEnumerable<long> c) => global::System.Data.Entity.DbFunctions.Var(c), collection);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00009EB4 File Offset: 0x000080B4
		[global::System.Data.Entity.DbFunction("Edm", "Var")]
		public static double? Var(global::System.Collections.Generic.IEnumerable<long?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<long?, double?>((global::System.Collections.Generic.IEnumerable<long?> c) => global::System.Data.Entity.DbFunctions.Var(c), collection);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00009F0C File Offset: 0x0000810C
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<decimal> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<decimal, double?>((global::System.Collections.Generic.IEnumerable<decimal> c) => global::System.Data.Entity.DbFunctions.VarP(c), collection);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009F64 File Offset: 0x00008164
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<decimal?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<decimal?, double?>((global::System.Collections.Generic.IEnumerable<decimal?> c) => global::System.Data.Entity.DbFunctions.VarP(c), collection);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00009FBC File Offset: 0x000081BC
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<double> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<double, double?>((global::System.Collections.Generic.IEnumerable<double> c) => global::System.Data.Entity.DbFunctions.VarP(c), collection);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000A014 File Offset: 0x00008214
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<double?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<double?, double?>((global::System.Collections.Generic.IEnumerable<double?> c) => global::System.Data.Entity.DbFunctions.VarP(c), collection);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000A06C File Offset: 0x0000826C
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<int> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<int, double?>((global::System.Collections.Generic.IEnumerable<int> c) => global::System.Data.Entity.DbFunctions.VarP(c), collection);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000A0C4 File Offset: 0x000082C4
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<int?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<int?, double?>((global::System.Collections.Generic.IEnumerable<int?> c) => global::System.Data.Entity.DbFunctions.VarP(c), collection);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000A11C File Offset: 0x0000831C
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<long> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<long, double?>((global::System.Collections.Generic.IEnumerable<long> c) => global::System.Data.Entity.DbFunctions.VarP(c), collection);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000A174 File Offset: 0x00008374
		[global::System.Data.Entity.DbFunction("Edm", "VarP")]
		public static double? VarP(global::System.Collections.Generic.IEnumerable<long?> collection)
		{
			return global::System.Data.Entity.DbFunctions.BootstrapFunction<long?, double?>((global::System.Collections.Generic.IEnumerable<long?> c) => global::System.Data.Entity.DbFunctions.VarP(c), collection);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000A1CA File Offset: 0x000083CA
		[global::System.Data.Entity.DbFunction("Edm", "Left")]
		public static string Left(string stringArgument, long? length)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000A1D6 File Offset: 0x000083D6
		[global::System.Data.Entity.DbFunction("Edm", "Right")]
		public static string Right(string stringArgument, long? length)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000A1E2 File Offset: 0x000083E2
		[global::System.Data.Entity.DbFunction("Edm", "Reverse")]
		public static string Reverse(string stringArgument)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000A1EE File Offset: 0x000083EE
		[global::System.Data.Entity.DbFunction("Edm", "GetTotalOffsetMinutes")]
		public static int? GetTotalOffsetMinutes(global::System.DateTimeOffset? dateTimeOffsetArgument)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000A1FA File Offset: 0x000083FA
		[global::System.Data.Entity.DbFunction("Edm", "TruncateTime")]
		public static global::System.DateTimeOffset? TruncateTime(global::System.DateTimeOffset? dateValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000A206 File Offset: 0x00008406
		[global::System.Data.Entity.DbFunction("Edm", "TruncateTime")]
		public static global::System.DateTime? TruncateTime(global::System.DateTime? dateValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000A212 File Offset: 0x00008412
		[global::System.Data.Entity.DbFunction("Edm", "CreateDateTime")]
		public static global::System.DateTime? CreateDateTime(int? year, int? month, int? day, int? hour, int? minute, double? second)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000A21E File Offset: 0x0000841E
		[global::System.Data.Entity.DbFunction("Edm", "CreateDateTimeOffset")]
		public static global::System.DateTimeOffset? CreateDateTimeOffset(int? year, int? month, int? day, int? hour, int? minute, double? second, int? timeZoneOffset)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000A22A File Offset: 0x0000842A
		[global::System.Data.Entity.DbFunction("Edm", "CreateTime")]
		public static global::System.TimeSpan? CreateTime(int? hour, int? minute, double? second)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000A236 File Offset: 0x00008436
		[global::System.Data.Entity.DbFunction("Edm", "AddYears")]
		public static global::System.DateTimeOffset? AddYears(global::System.DateTimeOffset? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000A242 File Offset: 0x00008442
		[global::System.Data.Entity.DbFunction("Edm", "AddYears")]
		public static global::System.DateTime? AddYears(global::System.DateTime? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000A24E File Offset: 0x0000844E
		[global::System.Data.Entity.DbFunction("Edm", "AddMonths")]
		public static global::System.DateTimeOffset? AddMonths(global::System.DateTimeOffset? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000A25A File Offset: 0x0000845A
		[global::System.Data.Entity.DbFunction("Edm", "AddMonths")]
		public static global::System.DateTime? AddMonths(global::System.DateTime? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000A266 File Offset: 0x00008466
		[global::System.Data.Entity.DbFunction("Edm", "AddDays")]
		public static global::System.DateTimeOffset? AddDays(global::System.DateTimeOffset? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000A272 File Offset: 0x00008472
		[global::System.Data.Entity.DbFunction("Edm", "AddDays")]
		public static global::System.DateTime? AddDays(global::System.DateTime? dateValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000A27E File Offset: 0x0000847E
		[global::System.Data.Entity.DbFunction("Edm", "AddHours")]
		public static global::System.DateTimeOffset? AddHours(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000A28A File Offset: 0x0000848A
		[global::System.Data.Entity.DbFunction("Edm", "AddHours")]
		public static global::System.DateTime? AddHours(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000A296 File Offset: 0x00008496
		[global::System.Data.Entity.DbFunction("Edm", "AddHours")]
		public static global::System.TimeSpan? AddHours(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000A2A2 File Offset: 0x000084A2
		[global::System.Data.Entity.DbFunction("Edm", "AddMinutes")]
		public static global::System.DateTimeOffset? AddMinutes(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000A2AE File Offset: 0x000084AE
		[global::System.Data.Entity.DbFunction("Edm", "AddMinutes")]
		public static global::System.DateTime? AddMinutes(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000A2BA File Offset: 0x000084BA
		[global::System.Data.Entity.DbFunction("Edm", "AddMinutes")]
		public static global::System.TimeSpan? AddMinutes(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000A2C6 File Offset: 0x000084C6
		[global::System.Data.Entity.DbFunction("Edm", "AddSeconds")]
		public static global::System.DateTimeOffset? AddSeconds(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000A2D2 File Offset: 0x000084D2
		[global::System.Data.Entity.DbFunction("Edm", "AddSeconds")]
		public static global::System.DateTime? AddSeconds(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000A2DE File Offset: 0x000084DE
		[global::System.Data.Entity.DbFunction("Edm", "AddSeconds")]
		public static global::System.TimeSpan? AddSeconds(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000A2EA File Offset: 0x000084EA
		[global::System.Data.Entity.DbFunction("Edm", "AddMilliseconds")]
		public static global::System.DateTimeOffset? AddMilliseconds(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000A2F6 File Offset: 0x000084F6
		[global::System.Data.Entity.DbFunction("Edm", "AddMilliseconds")]
		public static global::System.DateTime? AddMilliseconds(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000A302 File Offset: 0x00008502
		[global::System.Data.Entity.DbFunction("Edm", "AddMilliseconds")]
		public static global::System.TimeSpan? AddMilliseconds(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000A30E File Offset: 0x0000850E
		[global::System.Data.Entity.DbFunction("Edm", "AddMicroseconds")]
		public static global::System.DateTimeOffset? AddMicroseconds(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000A31A File Offset: 0x0000851A
		[global::System.Data.Entity.DbFunction("Edm", "AddMicroseconds")]
		public static global::System.DateTime? AddMicroseconds(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000A326 File Offset: 0x00008526
		[global::System.Data.Entity.DbFunction("Edm", "AddMicroseconds")]
		public static global::System.TimeSpan? AddMicroseconds(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000A332 File Offset: 0x00008532
		[global::System.Data.Entity.DbFunction("Edm", "AddNanoseconds")]
		public static global::System.DateTimeOffset? AddNanoseconds(global::System.DateTimeOffset? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000A33E File Offset: 0x0000853E
		[global::System.Data.Entity.DbFunction("Edm", "AddNanoseconds")]
		public static global::System.DateTime? AddNanoseconds(global::System.DateTime? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000A34A File Offset: 0x0000854A
		[global::System.Data.Entity.DbFunction("Edm", "AddNanoseconds")]
		public static global::System.TimeSpan? AddNanoseconds(global::System.TimeSpan? timeValue, int? addValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000A356 File Offset: 0x00008556
		[global::System.Data.Entity.DbFunction("Edm", "DiffYears")]
		public static int? DiffYears(global::System.DateTimeOffset? dateValue1, global::System.DateTimeOffset? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000A362 File Offset: 0x00008562
		[global::System.Data.Entity.DbFunction("Edm", "DiffYears")]
		public static int? DiffYears(global::System.DateTime? dateValue1, global::System.DateTime? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000A36E File Offset: 0x0000856E
		[global::System.Data.Entity.DbFunction("Edm", "DiffMonths")]
		public static int? DiffMonths(global::System.DateTimeOffset? dateValue1, global::System.DateTimeOffset? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000A37A File Offset: 0x0000857A
		[global::System.Data.Entity.DbFunction("Edm", "DiffMonths")]
		public static int? DiffMonths(global::System.DateTime? dateValue1, global::System.DateTime? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000A386 File Offset: 0x00008586
		[global::System.Data.Entity.DbFunction("Edm", "DiffDays")]
		public static int? DiffDays(global::System.DateTimeOffset? dateValue1, global::System.DateTimeOffset? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000A392 File Offset: 0x00008592
		[global::System.Data.Entity.DbFunction("Edm", "DiffDays")]
		public static int? DiffDays(global::System.DateTime? dateValue1, global::System.DateTime? dateValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000A39E File Offset: 0x0000859E
		[global::System.Data.Entity.DbFunction("Edm", "DiffHours")]
		public static int? DiffHours(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000A3AA File Offset: 0x000085AA
		[global::System.Data.Entity.DbFunction("Edm", "DiffHours")]
		public static int? DiffHours(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000A3B6 File Offset: 0x000085B6
		[global::System.Data.Entity.DbFunction("Edm", "DiffHours")]
		public static int? DiffHours(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000A3C2 File Offset: 0x000085C2
		[global::System.Data.Entity.DbFunction("Edm", "DiffMinutes")]
		public static int? DiffMinutes(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000A3CE File Offset: 0x000085CE
		[global::System.Data.Entity.DbFunction("Edm", "DiffMinutes")]
		public static int? DiffMinutes(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000A3DA File Offset: 0x000085DA
		[global::System.Data.Entity.DbFunction("Edm", "DiffMinutes")]
		public static int? DiffMinutes(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000A3E6 File Offset: 0x000085E6
		[global::System.Data.Entity.DbFunction("Edm", "DiffSeconds")]
		public static int? DiffSeconds(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000A3F2 File Offset: 0x000085F2
		[global::System.Data.Entity.DbFunction("Edm", "DiffSeconds")]
		public static int? DiffSeconds(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000A3FE File Offset: 0x000085FE
		[global::System.Data.Entity.DbFunction("Edm", "DiffSeconds")]
		public static int? DiffSeconds(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000A40A File Offset: 0x0000860A
		[global::System.Data.Entity.DbFunction("Edm", "DiffMilliseconds")]
		public static int? DiffMilliseconds(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000A416 File Offset: 0x00008616
		[global::System.Data.Entity.DbFunction("Edm", "DiffMilliseconds")]
		public static int? DiffMilliseconds(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000A422 File Offset: 0x00008622
		[global::System.Data.Entity.DbFunction("Edm", "DiffMilliseconds")]
		public static int? DiffMilliseconds(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000A42E File Offset: 0x0000862E
		[global::System.Data.Entity.DbFunction("Edm", "DiffMicroseconds")]
		public static int? DiffMicroseconds(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000A43A File Offset: 0x0000863A
		[global::System.Data.Entity.DbFunction("Edm", "DiffMicroseconds")]
		public static int? DiffMicroseconds(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000A446 File Offset: 0x00008646
		[global::System.Data.Entity.DbFunction("Edm", "DiffMicroseconds")]
		public static int? DiffMicroseconds(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000A452 File Offset: 0x00008652
		[global::System.Data.Entity.DbFunction("Edm", "DiffNanoseconds")]
		public static int? DiffNanoseconds(global::System.DateTimeOffset? timeValue1, global::System.DateTimeOffset? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000A45E File Offset: 0x0000865E
		[global::System.Data.Entity.DbFunction("Edm", "DiffNanoseconds")]
		public static int? DiffNanoseconds(global::System.DateTime? timeValue1, global::System.DateTime? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000A46A File Offset: 0x0000866A
		[global::System.Data.Entity.DbFunction("Edm", "DiffNanoseconds")]
		public static int? DiffNanoseconds(global::System.TimeSpan? timeValue1, global::System.TimeSpan? timeValue2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000A476 File Offset: 0x00008676
		[global::System.Data.Entity.DbFunction("Edm", "Truncate")]
		public static double? Truncate(double? value, int? digits)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000A482 File Offset: 0x00008682
		[global::System.Data.Entity.DbFunction("Edm", "Truncate")]
		public static decimal? Truncate(decimal? value, int? digits)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000A48E File Offset: 0x0000868E
		public static bool Like(string searchString, string likeExpression)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000A49A File Offset: 0x0000869A
		public static bool Like(string searchString, string likeExpression, string escapeCharacter)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000A4A6 File Offset: 0x000086A6
		public static string AsUnicode(string value)
		{
			return value;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000A4A9 File Offset: 0x000086A9
		public static string AsNonUnicode(string value)
		{
			return value;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000A4AC File Offset: 0x000086AC
		private static TOut BootstrapFunction<TIn, TOut>(global::System.Linq.Expressions.Expression<global::System.Func<global::System.Collections.Generic.IEnumerable<TIn>, TOut>> methodExpression, global::System.Collections.Generic.IEnumerable<TIn> collection)
		{
			global::System.Linq.IQueryable queryable = collection as global::System.Linq.IQueryable;
			if (queryable != null)
			{
				return queryable.Provider.Execute<TOut>(global::System.Linq.Expressions.Expression.Call(((global::System.Linq.Expressions.MethodCallExpression)methodExpression.Body).Method, global::System.Linq.Expressions.Expression.Constant(collection)));
			}
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_DbFunctionDirectCall);
		}
	}
}
