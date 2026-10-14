using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006CA RID: 1738
	public sealed class DbLambda
	{
		// Token: 0x06005124 RID: 20772 RVA: 0x00121C7D File Offset: 0x0011FE7D
		internal DbLambda(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression bodyExp)
		{
			this._variables = variables;
			this._body = bodyExp;
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06005125 RID: 20773 RVA: 0x00121C93 File Offset: 0x0011FE93
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Body
		{
			get
			{
				return this._body;
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x00121C9B File Offset: 0x0011FE9B
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> Variables
		{
			get
			{
				return this._variables;
			}
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x00121CA3 File Offset: 0x0011FEA3
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression body, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(body, variables);
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x00121CAC File Offset: 0x0011FEAC
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression body, params global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] variables)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(body, variables);
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x00121CB8 File Offset: 0x0011FEB8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0]), array);
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x00121D04 File Offset: 0x0011FF04
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1]), array);
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x00121D64 File Offset: 0x0011FF64
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2]), array);
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x00121DD4 File Offset: 0x0011FFD4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3]), array);
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x00121E5C File Offset: 0x0012005C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4]), array);
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x00121EF8 File Offset: 0x001200F8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5]), array);
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x00121FA8 File Offset: 0x001201A8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument7Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument7Type, "argument7Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type,
				argument7Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5], array[6]), array);
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x00122070 File Offset: 0x00120270
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument7Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument8Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument7Type, "argument7Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument8Type, "argument8Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type,
				argument7Type,
				argument8Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7]), array);
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x0012214C File Offset: 0x0012034C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument7Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument8Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument9Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument7Type, "argument7Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument8Type, "argument8Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument9Type, "argument9Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type,
				argument7Type,
				argument8Type,
				argument9Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8]), array);
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x0012223C File Offset: 0x0012043C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument7Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument8Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument9Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument10Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument7Type, "argument7Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument8Type, "argument8Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument9Type, "argument9Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument10Type, "argument10Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type,
				argument7Type,
				argument8Type,
				argument9Type,
				argument10Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9]), array);
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x00122344 File Offset: 0x00120544
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument7Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument8Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument9Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument10Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument11Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument7Type, "argument7Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument8Type, "argument8Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument9Type, "argument9Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument10Type, "argument10Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument11Type, "argument11Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type,
				argument7Type,
				argument8Type,
				argument9Type,
				argument10Type,
				argument11Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9], array[10]), array);
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x00122464 File Offset: 0x00120664
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument7Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument8Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument9Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument10Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument11Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument12Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument7Type, "argument7Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument8Type, "argument8Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument9Type, "argument9Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument10Type, "argument10Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument11Type, "argument11Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument12Type, "argument12Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type,
				argument7Type,
				argument8Type,
				argument9Type,
				argument10Type,
				argument11Type,
				argument12Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9], array[10], array[11]), array);
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x0012259C File Offset: 0x0012079C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument7Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument8Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument9Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument10Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument11Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument12Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument13Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument7Type, "argument7Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument8Type, "argument8Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument9Type, "argument9Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument10Type, "argument10Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument11Type, "argument11Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument12Type, "argument12Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument13Type, "argument13Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type,
				argument7Type,
				argument8Type,
				argument9Type,
				argument10Type,
				argument11Type,
				argument12Type,
				argument13Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9], array[10], array[11], array[12]), array);
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x001226E8 File Offset: 0x001208E8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument7Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument8Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument9Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument10Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument11Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument12Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument13Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument14Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument7Type, "argument7Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument8Type, "argument8Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument9Type, "argument9Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument10Type, "argument10Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument11Type, "argument11Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument12Type, "argument12Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument13Type, "argument13Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument14Type, "argument14Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type,
				argument7Type,
				argument8Type,
				argument9Type,
				argument10Type,
				argument11Type,
				argument12Type,
				argument13Type,
				argument14Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9], array[10], array[11], array[12], array[13]), array);
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x0012284C File Offset: 0x00120A4C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument7Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument8Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument9Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument10Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument11Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument12Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument13Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument14Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument15Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument7Type, "argument7Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument8Type, "argument8Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument9Type, "argument9Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument10Type, "argument10Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument11Type, "argument11Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument12Type, "argument12Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument13Type, "argument13Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument14Type, "argument14Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument15Type, "argument15Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type,
				argument7Type,
				argument8Type,
				argument9Type,
				argument10Type,
				argument11Type,
				argument12Type,
				argument13Type,
				argument14Type,
				argument15Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9], array[10], array[11], array[12], array[13], array[14]), array);
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x001229C8 File Offset: 0x00120BC8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Create(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument1Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument2Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument3Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument4Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument5Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument6Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument7Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument8Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument9Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument10Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument11Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument12Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument13Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument14Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument15Type, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argument16Type, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> lambdaFunction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument1Type, "argument1Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument2Type, "argument2Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument3Type, "argument3Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument4Type, "argument4Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument5Type, "argument5Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument6Type, "argument6Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument7Type, "argument7Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument8Type, "argument8Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument9Type, "argument9Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument10Type, "argument10Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument11Type, "argument11Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument12Type, "argument12Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument13Type, "argument13Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument14Type, "argument14Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument15Type, "argument15Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argument16Type, "argument16Type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(lambdaFunction, "lambdaFunction");
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array = global::System.Data.Entity.Core.Common.CommandTrees.DbLambda.CreateVariables(lambdaFunction.Method, new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
			{
				argument1Type,
				argument2Type,
				argument3Type,
				argument4Type,
				argument5Type,
				argument6Type,
				argument7Type,
				argument8Type,
				argument9Type,
				argument10Type,
				argument11Type,
				argument12Type,
				argument13Type,
				argument14Type,
				argument15Type,
				argument16Type
			});
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Lambda(lambdaFunction(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9], array[10], array[11], array[12], array[13], array[14], array[15]), array);
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x00122B5C File Offset: 0x00120D5C
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] CreateVariables(global::System.Reflection.MethodInfo lambdaMethod, params global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] argumentTypes)
		{
			string[] array = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ExtractAliases(lambdaMethod);
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] array2 = new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[argumentTypes.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = argumentTypes[i].Variable(array[i]);
			}
			return array2;
		}

		// Token: 0x04001DB0 RID: 7600
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> _variables;

		// Token: 0x04001DB1 RID: 7601
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _body;
	}
}
