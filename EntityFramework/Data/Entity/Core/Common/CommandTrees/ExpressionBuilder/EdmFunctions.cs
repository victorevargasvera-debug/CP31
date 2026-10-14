using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
{
	// Token: 0x020006F8 RID: 1784
	public static class EdmFunctions
	{
		// Token: 0x060053A1 RID: 21409 RVA: 0x0012C01C File Offset: 0x0012A21C
		private static global::System.Data.Entity.Core.Metadata.Edm.EdmFunction ResolveCanonicalFunction(string functionName, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] argumentTypes)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(from func in global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetStoreFunctions()
			where string.Equals(func.Name, functionName, global::System.StringComparison.Ordinal)
			select func);
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = null;
			bool flag = false;
			if (list.Count > 0)
			{
				edmFunction = global::System.Data.Entity.Core.Common.EntitySql.FunctionOverloadResolver.ResolveFunctionOverloads(list, argumentTypes, false, out flag);
				if (flag)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Function_CanonicalFunction_AmbiguousMatch(functionName));
				}
			}
			if (edmFunction == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Function_CanonicalFunction_NotFound(functionName));
			}
			return edmFunction;
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x0012C098 File Offset: 0x0012A298
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression InvokeCanonicalFunction(string functionName, params global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] arguments)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] array = new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[arguments.Length];
			for (int i = 0; i < arguments.Length; i++)
			{
				array[i] = arguments[i].ResultType;
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.ResolveCanonicalFunction(functionName, array).Invoke(arguments);
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x0012C0D4 File Offset: 0x0012A2D4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Average(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(collection, "collection");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Avg", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				collection
			});
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x0012C0F6 File Offset: 0x0012A2F6
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Count(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(collection, "collection");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Count", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				collection
			});
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x0012C118 File Offset: 0x0012A318
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression LongCount(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(collection, "collection");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("BigCount", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				collection
			});
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x0012C13A File Offset: 0x0012A33A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Max(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(collection, "collection");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Max", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				collection
			});
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x0012C15C File Offset: 0x0012A35C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Min(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(collection, "collection");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Min", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				collection
			});
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x0012C17E File Offset: 0x0012A37E
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Sum(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(collection, "collection");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Sum", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				collection
			});
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x0012C1A0 File Offset: 0x0012A3A0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression StDev(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(collection, "collection");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("StDev", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				collection
			});
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x0012C1C2 File Offset: 0x0012A3C2
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression StDevP(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(collection, "collection");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("StDevP", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				collection
			});
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x0012C1E4 File Offset: 0x0012A3E4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Var(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(collection, "collection");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Var", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				collection
			});
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x0012C206 File Offset: 0x0012A406
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression VarP(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(collection, "collection");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("VarP", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				collection
			});
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x0012C228 File Offset: 0x0012A428
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Concat(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression string1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression string2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(string1, "string1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(string2, "string2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Concat", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				string1,
				string2
			});
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x0012C25A File Offset: 0x0012A45A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Contains(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression searchedString, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression searchedForString)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(searchedString, "searchedString");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(searchedForString, "searchedForString");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Contains", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				searchedString,
				searchedForString
			});
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x0012C28C File Offset: 0x0012A48C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression EndsWith(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression suffix)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(suffix, "suffix");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("EndsWith", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument,
				suffix
			});
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x0012C2BE File Offset: 0x0012A4BE
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression IndexOf(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression searchString, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringToFind)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(searchString, "searchString");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringToFind, "stringToFind");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("IndexOf", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringToFind,
				searchString
			});
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x0012C2F0 File Offset: 0x0012A4F0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Left(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression length)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(length, "length");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Left", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument,
				length
			});
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x0012C322 File Offset: 0x0012A522
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Length(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Length", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument
			});
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x0012C344 File Offset: 0x0012A544
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Replace(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression toReplace, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression replacement)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(toReplace, "toReplace");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(replacement, "replacement");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Replace", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument,
				toReplace,
				replacement
			});
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x0012C391 File Offset: 0x0012A591
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Reverse(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Reverse", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument
			});
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x0012C3B3 File Offset: 0x0012A5B3
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Right(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression length)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(length, "length");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Right", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument,
				length
			});
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x0012C3E5 File Offset: 0x0012A5E5
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression StartsWith(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression prefix)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(prefix, "prefix");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("StartsWith", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument,
				prefix
			});
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x0012C418 File Offset: 0x0012A618
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Substring(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression start, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression length)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(start, "start");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(length, "length");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Substring", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument,
				start,
				length
			});
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x0012C465 File Offset: 0x0012A665
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression ToLower(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("ToLower", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument
			});
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x0012C487 File Offset: 0x0012A687
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression ToUpper(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("ToUpper", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument
			});
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x0012C4A9 File Offset: 0x0012A6A9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Trim(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Trim", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument
			});
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x0012C4CB File Offset: 0x0012A6CB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression TrimEnd(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("RTrim", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument
			});
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x0012C4ED File Offset: 0x0012A6ED
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression TrimStart(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression stringArgument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(stringArgument, "stringArgument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("LTrim", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				stringArgument
			});
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x0012C50F File Offset: 0x0012A70F
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Year(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue, "dateValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Year", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue
			});
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x0012C531 File Offset: 0x0012A731
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Month(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue, "dateValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Month", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue
			});
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x0012C553 File Offset: 0x0012A753
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Day(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue, "dateValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Day", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue
			});
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x0012C575 File Offset: 0x0012A775
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression DayOfYear(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue, "dateValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("DayOfYear", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue
			});
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x0012C597 File Offset: 0x0012A797
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Hour(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue, "timeValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Hour", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue
			});
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x0012C5B9 File Offset: 0x0012A7B9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Minute(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue, "timeValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Minute", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue
			});
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x0012C5DB File Offset: 0x0012A7DB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Second(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue, "timeValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Second", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue
			});
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x0012C5FD File Offset: 0x0012A7FD
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Millisecond(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue, "timeValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Millisecond", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue
			});
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x0012C61F File Offset: 0x0012A81F
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GetTotalOffsetMinutes(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateTimeOffsetArgument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateTimeOffsetArgument, "dateTimeOffsetArgument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GetTotalOffsetMinutes", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateTimeOffsetArgument
			});
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x0012C641 File Offset: 0x0012A841
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression LocalDateTime(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateTimeOffsetArgument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateTimeOffsetArgument, "dateTimeOffsetArgument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("LocalDateTime", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateTimeOffsetArgument
			});
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x0012C663 File Offset: 0x0012A863
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression UtcDateTime(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateTimeOffsetArgument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateTimeOffsetArgument, "dateTimeOffsetArgument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("UtcDateTime", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateTimeOffsetArgument
			});
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x0012C685 File Offset: 0x0012A885
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression CurrentDateTime()
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("CurrentDateTime", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[0]);
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x0012C697 File Offset: 0x0012A897
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression CurrentDateTimeOffset()
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("CurrentDateTimeOffset", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[0]);
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x0012C6A9 File Offset: 0x0012A8A9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression CurrentUtcDateTime()
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("CurrentUtcDateTime", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[0]);
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x0012C6BB File Offset: 0x0012A8BB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression TruncateTime(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue, "dateValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("TruncateTime", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue
			});
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x0012C6E0 File Offset: 0x0012A8E0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression CreateDateTime(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression year, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression month, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression day, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression hour, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression minute, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression second)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(year, "year");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(month, "month");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(day, "day");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(hour, "hour");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(minute, "minute");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(second, "second");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("CreateDateTime", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				year,
				month,
				day,
				hour,
				minute,
				second
			});
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x0012C764 File Offset: 0x0012A964
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression CreateDateTimeOffset(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression year, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression month, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression day, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression hour, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression minute, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression second, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeZoneOffset)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(year, "year");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(month, "month");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(day, "day");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(hour, "hour");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(minute, "minute");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(second, "second");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeZoneOffset, "timeZoneOffset");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("CreateDateTimeOffset", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				year,
				month,
				day,
				hour,
				minute,
				second,
				timeZoneOffset
			});
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x0012C7F8 File Offset: 0x0012A9F8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression CreateTime(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression hour, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression minute, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression second)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(hour, "hour");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(minute, "minute");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(second, "second");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("CreateTime", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				hour,
				minute,
				second
			});
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x0012C845 File Offset: 0x0012AA45
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AddYears(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression addValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue, "dateValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(addValue, "addValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AddYears", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue,
				addValue
			});
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x0012C877 File Offset: 0x0012AA77
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AddMonths(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression addValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue, "dateValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(addValue, "addValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AddMonths", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue,
				addValue
			});
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x0012C8A9 File Offset: 0x0012AAA9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AddDays(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression addValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue, "dateValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(addValue, "addValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AddDays", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue,
				addValue
			});
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x0012C8DB File Offset: 0x0012AADB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AddHours(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression addValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue, "timeValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(addValue, "addValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AddHours", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue,
				addValue
			});
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x0012C90D File Offset: 0x0012AB0D
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AddMinutes(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression addValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue, "timeValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(addValue, "addValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AddMinutes", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue,
				addValue
			});
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x0012C93F File Offset: 0x0012AB3F
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AddSeconds(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression addValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue, "timeValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(addValue, "addValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AddSeconds", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue,
				addValue
			});
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x0012C971 File Offset: 0x0012AB71
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AddMilliseconds(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression addValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue, "timeValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(addValue, "addValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AddMilliseconds", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue,
				addValue
			});
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x0012C9A3 File Offset: 0x0012ABA3
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AddMicroseconds(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression addValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue, "timeValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(addValue, "addValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AddMicroseconds", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue,
				addValue
			});
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x0012C9D5 File Offset: 0x0012ABD5
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression AddNanoseconds(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression addValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue, "timeValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(addValue, "addValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("AddNanoseconds", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue,
				addValue
			});
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x0012CA07 File Offset: 0x0012AC07
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression DiffYears(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue1, "dateValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue2, "dateValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("DiffYears", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue1,
				dateValue2
			});
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x0012CA39 File Offset: 0x0012AC39
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression DiffMonths(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue1, "dateValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue2, "dateValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("DiffMonths", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue1,
				dateValue2
			});
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x0012CA6B File Offset: 0x0012AC6B
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression DiffDays(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dateValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue1, "dateValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(dateValue2, "dateValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("DiffDays", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				dateValue1,
				dateValue2
			});
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x0012CA9D File Offset: 0x0012AC9D
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression DiffHours(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue1, "timeValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue2, "timeValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("DiffHours", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue1,
				timeValue2
			});
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x0012CACF File Offset: 0x0012ACCF
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression DiffMinutes(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue1, "timeValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue2, "timeValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("DiffMinutes", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue1,
				timeValue2
			});
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x0012CB01 File Offset: 0x0012AD01
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression DiffSeconds(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue1, "timeValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue2, "timeValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("DiffSeconds", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue1,
				timeValue2
			});
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x0012CB33 File Offset: 0x0012AD33
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression DiffMilliseconds(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue1, "timeValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue2, "timeValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("DiffMilliseconds", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue1,
				timeValue2
			});
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x0012CB65 File Offset: 0x0012AD65
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression DiffMicroseconds(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue1, "timeValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue2, "timeValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("DiffMicroseconds", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue1,
				timeValue2
			});
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x0012CB97 File Offset: 0x0012AD97
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression DiffNanoseconds(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression timeValue2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue1, "timeValue1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(timeValue2, "timeValue2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("DiffNanoseconds", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				timeValue1,
				timeValue2
			});
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x0012CBC9 File Offset: 0x0012ADC9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Round(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value, "value");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Round", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				value
			});
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x0012CBEB File Offset: 0x0012ADEB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Round(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression digits)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value, "value");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(digits, "digits");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Round", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				value,
				digits
			});
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x0012CC1D File Offset: 0x0012AE1D
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Floor(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value, "value");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Floor", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				value
			});
		}

		// Token: 0x060053E4 RID: 21476 RVA: 0x0012CC3F File Offset: 0x0012AE3F
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Ceiling(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value, "value");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Ceiling", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				value
			});
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x0012CC61 File Offset: 0x0012AE61
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Abs(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value, "value");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Abs", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				value
			});
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x0012CC83 File Offset: 0x0012AE83
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Truncate(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression digits)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value, "value");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(digits, "digits");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Truncate", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				value,
				digits
			});
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x0012CCB5 File Offset: 0x0012AEB5
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Power(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression baseArgument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exponent)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(baseArgument, "baseArgument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(exponent, "exponent");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("Power", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				baseArgument,
				exponent
			});
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x0012CCE7 File Offset: 0x0012AEE7
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression BitwiseAnd(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value1, "value1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value2, "value2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("BitwiseAnd", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				value1,
				value2
			});
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x0012CD19 File Offset: 0x0012AF19
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression BitwiseOr(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value1, "value1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value2, "value2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("BitwiseOr", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				value1,
				value2
			});
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x0012CD4B File Offset: 0x0012AF4B
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression BitwiseNot(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value, "value");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("BitwiseNot", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				value
			});
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x0012CD6D File Offset: 0x0012AF6D
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression BitwiseXor(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value1, "value1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value2, "value2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("BitwiseXor", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				value1,
				value2
			});
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x0012CD9F File Offset: 0x0012AF9F
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression NewGuid()
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("NewGuid", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[0]);
		}
	}
}
