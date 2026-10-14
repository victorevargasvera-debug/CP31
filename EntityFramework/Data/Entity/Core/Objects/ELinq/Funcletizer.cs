using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x02000461 RID: 1121
	internal sealed class Funcletizer
	{
		// Token: 0x06003748 RID: 14152 RVA: 0x000B2734 File Offset: 0x000B0934
		private Funcletizer(global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Mode mode, global::System.Data.Entity.Core.Objects.ObjectContext rootContext, global::System.Linq.Expressions.ParameterExpression rootContextParameter, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Linq.Expressions.ParameterExpression> compiledQueryParameters)
		{
			this._mode = mode;
			this._rootContext = rootContext;
			this._rootContextParameter = rootContextParameter;
			this._compiledQueryParameters = compiledQueryParameters;
			if (this._rootContextParameter != null && this._rootContext != null)
			{
				this._rootContextExpression = global::System.Linq.Expressions.Expression.Constant(this._rootContext);
			}
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x000B2790 File Offset: 0x000B0990
		internal static global::System.Data.Entity.Core.Objects.ELinq.Funcletizer CreateCompiledQueryEvaluationFuncletizer(global::System.Data.Entity.Core.Objects.ObjectContext rootContext, global::System.Linq.Expressions.ParameterExpression rootContextParameter, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Linq.Expressions.ParameterExpression> compiledQueryParameters)
		{
			return new global::System.Data.Entity.Core.Objects.ELinq.Funcletizer(global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Mode.CompiledQueryEvaluation, rootContext, rootContextParameter, compiledQueryParameters);
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x000B279B File Offset: 0x000B099B
		internal static global::System.Data.Entity.Core.Objects.ELinq.Funcletizer CreateCompiledQueryLockdownFuncletizer()
		{
			return new global::System.Data.Entity.Core.Objects.ELinq.Funcletizer(global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Mode.CompiledQueryLockdown, null, null, null);
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x000B27A6 File Offset: 0x000B09A6
		internal static global::System.Data.Entity.Core.Objects.ELinq.Funcletizer CreateQueryFuncletizer(global::System.Data.Entity.Core.Objects.ObjectContext rootContext)
		{
			return new global::System.Data.Entity.Core.Objects.ELinq.Funcletizer(global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Mode.ConventionalQuery, rootContext, null, null);
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x000B27B1 File Offset: 0x000B09B1
		internal global::System.Data.Entity.Core.Objects.ObjectContext RootContext
		{
			get
			{
				return this._rootContext;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x000B27B9 File Offset: 0x000B09B9
		internal global::System.Linq.Expressions.ParameterExpression RootContextParameter
		{
			get
			{
				return this._rootContextParameter;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x000B27C1 File Offset: 0x000B09C1
		internal global::System.Linq.Expressions.ConstantExpression RootContextExpression
		{
			get
			{
				return this._rootContextExpression;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x0600374F RID: 14159 RVA: 0x000B27C9 File Offset: 0x000B09C9
		internal bool IsCompiledQuery
		{
			get
			{
				return this._mode == global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Mode.CompiledQueryEvaluation || this._mode == global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Mode.CompiledQueryLockdown;
			}
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x000B27E0 File Offset: 0x000B09E0
		internal global::System.Linq.Expressions.Expression Funcletize(global::System.Linq.Expressions.Expression expression, out global::System.Func<bool> recompileRequired)
		{
			expression = this.ReplaceRootContextParameter(expression);
			global::System.Func<global::System.Linq.Expressions.Expression, bool> isClientConstant;
			global::System.Func<global::System.Linq.Expressions.Expression, bool> isClientVariable;
			if (this._mode == global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Mode.CompiledQueryEvaluation)
			{
				isClientConstant = global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Nominate(expression, new global::System.Func<global::System.Linq.Expressions.Expression, bool>(this.IsClosureExpression));
				isClientVariable = global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Nominate(expression, new global::System.Func<global::System.Linq.Expressions.Expression, bool>(this.IsCompiledQueryParameterVariable));
			}
			else if (this._mode == global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Mode.CompiledQueryLockdown)
			{
				isClientConstant = global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Nominate(expression, new global::System.Func<global::System.Linq.Expressions.Expression, bool>(this.IsClosureExpression));
				isClientVariable = ((global::System.Linq.Expressions.Expression exp) => false);
			}
			else
			{
				isClientConstant = global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Nominate(expression, new global::System.Func<global::System.Linq.Expressions.Expression, bool>(this.IsImmutable));
				isClientVariable = global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Nominate(expression, new global::System.Func<global::System.Linq.Expressions.Expression, bool>(this.IsClosureExpression));
			}
			global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.FuncletizingVisitor funcletizingVisitor = new global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.FuncletizingVisitor(this, isClientConstant, isClientVariable);
			global::System.Linq.Expressions.Expression result = funcletizingVisitor.Visit(expression);
			recompileRequired = funcletizingVisitor.GetRecompileRequiredFunction();
			return result;
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x000B28A2 File Offset: 0x000B0AA2
		private global::System.Linq.Expressions.Expression ReplaceRootContextParameter(global::System.Linq.Expressions.Expression expression)
		{
			if (this._rootContextExpression != null)
			{
				return global::System.Linq.Expressions.EntityExpressionVisitor.Visit(expression, delegate(global::System.Linq.Expressions.Expression exp, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression> baseVisit)
				{
					if (exp != this._rootContextParameter)
					{
						return baseVisit(exp);
					}
					return this._rootContextExpression;
				});
			}
			return expression;
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x000B28C0 File Offset: 0x000B0AC0
		private static global::System.Func<global::System.Linq.Expressions.Expression, bool> Nominate(global::System.Linq.Expressions.Expression expression, global::System.Func<global::System.Linq.Expressions.Expression, bool> localCriterion)
		{
			global::System.Collections.Generic.HashSet<global::System.Linq.Expressions.Expression> candidates = new global::System.Collections.Generic.HashSet<global::System.Linq.Expressions.Expression>();
			bool cannotBeNominated = false;
			global::System.Func<global::System.Linq.Expressions.Expression, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>, global::System.Linq.Expressions.Expression> visit = delegate(global::System.Linq.Expressions.Expression exp, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression> baseVisit)
			{
				if (exp != null)
				{
					bool cannotBeNominated = cannotBeNominated;
					cannotBeNominated = false;
					baseVisit(exp);
					if (!cannotBeNominated)
					{
						if (localCriterion(exp))
						{
							candidates.Add(exp);
						}
						else
						{
							cannotBeNominated = true;
						}
					}
					cannotBeNominated = (cannotBeNominated || cannotBeNominated);
				}
				return exp;
			};
			global::System.Linq.Expressions.EntityExpressionVisitor.Visit(expression, visit);
			return new global::System.Func<global::System.Linq.Expressions.Expression, bool>(candidates.Contains);
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x000B2914 File Offset: 0x000B0B14
		private bool IsImmutable(global::System.Linq.Expressions.Expression expression)
		{
			if (expression == null)
			{
				return false;
			}
			global::System.Linq.Expressions.ExpressionType nodeType = expression.NodeType;
			if (nodeType <= global::System.Linq.Expressions.ExpressionType.Convert)
			{
				if (nodeType == global::System.Linq.Expressions.ExpressionType.Constant)
				{
					return true;
				}
				if (nodeType == global::System.Linq.Expressions.ExpressionType.Convert)
				{
					return true;
				}
			}
			else
			{
				if (nodeType == global::System.Linq.Expressions.ExpressionType.New)
				{
					global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
					return global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.Instance.TryGetPrimitiveType(global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetNonNullableType(expression.Type), out primitiveType);
				}
				if (nodeType == global::System.Linq.Expressions.ExpressionType.NewArrayInit)
				{
					return typeof(byte[]) == expression.Type;
				}
			}
			return false;
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x000B2984 File Offset: 0x000B0B84
		private bool IsClosureExpression(global::System.Linq.Expressions.Expression expression)
		{
			if (expression == null)
			{
				return false;
			}
			if (this.IsImmutable(expression))
			{
				return true;
			}
			if (global::System.Linq.Expressions.ExpressionType.MemberAccess == expression.NodeType)
			{
				global::System.Linq.Expressions.MemberExpression memberExpression = (global::System.Linq.Expressions.MemberExpression)expression;
				return memberExpression.Member.MemberType != global::System.Reflection.MemberTypes.Property || global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter.CanFuncletizePropertyInfo((global::System.Reflection.PropertyInfo)memberExpression.Member);
			}
			return false;
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x000B29D8 File Offset: 0x000B0BD8
		private bool IsCompiledQueryParameterVariable(global::System.Linq.Expressions.Expression expression)
		{
			if (expression == null)
			{
				return false;
			}
			if (this.IsClosureExpression(expression))
			{
				return true;
			}
			if (global::System.Linq.Expressions.ExpressionType.Parameter == expression.NodeType)
			{
				global::System.Linq.Expressions.ParameterExpression value = (global::System.Linq.Expressions.ParameterExpression)expression;
				return this._compiledQueryParameters.Contains(value);
			}
			return false;
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x000B2A14 File Offset: 0x000B0C14
		private bool TryGetTypeUsageForTerminal(global::System.Linq.Expressions.Expression expression, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Type type = expression.Type;
			if (this._rootContext.Perspective.TryGetTypeByName(global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetNonNullableType(type).FullNameWithNesting(), false, out typeUsage) && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(typeUsage))
			{
				if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Convert)
				{
					type = ((global::System.Linq.Expressions.UnaryExpression)expression).Operand.Type;
				}
				if (type.IsValueType && global::System.Nullable.GetUnderlyingType(type) == null && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNullable(typeUsage))
				{
					typeUsage = typeUsage.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
					{
						Nullable = new bool?(false)
					});
				}
				return true;
			}
			typeUsage = null;
			return false;
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x000B2AB0 File Offset: 0x000B0CB0
		internal string GenerateParameterName()
		{
			global::System.IFormatProvider invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
			string format = "{0}{1}";
			object[] array = new object[2];
			array[0] = "p__linq__";
			int num = 1;
			long parameterNumber = this._parameterNumber;
			this._parameterNumber = parameterNumber + 1L;
			array[num] = parameterNumber;
			return string.Format(invariantCulture, format, array);
		}

		// Token: 0x0400120B RID: 4619
		private readonly global::System.Linq.Expressions.ParameterExpression _rootContextParameter;

		// Token: 0x0400120C RID: 4620
		private readonly global::System.Data.Entity.Core.Objects.ObjectContext _rootContext;

		// Token: 0x0400120D RID: 4621
		private readonly global::System.Linq.Expressions.ConstantExpression _rootContextExpression;

		// Token: 0x0400120E RID: 4622
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Linq.Expressions.ParameterExpression> _compiledQueryParameters;

		// Token: 0x0400120F RID: 4623
		private readonly global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Mode _mode;

		// Token: 0x04001210 RID: 4624
		private readonly global::System.Collections.Generic.HashSet<global::System.Linq.Expressions.Expression> _linqExpressionStack = new global::System.Collections.Generic.HashSet<global::System.Linq.Expressions.Expression>();

		// Token: 0x04001211 RID: 4625
		private const string s_parameterPrefix = "p__linq__";

		// Token: 0x04001212 RID: 4626
		private long _parameterNumber;

		// Token: 0x02000AA1 RID: 2721
		private enum Mode
		{
			// Token: 0x04002B41 RID: 11073
			CompiledQueryLockdown,
			// Token: 0x04002B42 RID: 11074
			CompiledQueryEvaluation,
			// Token: 0x04002B43 RID: 11075
			ConventionalQuery
		}

		// Token: 0x02000AA2 RID: 2722
		private sealed class FuncletizingVisitor : global::System.Linq.Expressions.EntityExpressionVisitor
		{
			// Token: 0x06006291 RID: 25233 RVA: 0x0015560B File Offset: 0x0015380B
			internal FuncletizingVisitor(global::System.Data.Entity.Core.Objects.ELinq.Funcletizer funcletizer, global::System.Func<global::System.Linq.Expressions.Expression, bool> isClientConstant, global::System.Func<global::System.Linq.Expressions.Expression, bool> isClientVariable)
			{
				this._funcletizer = funcletizer;
				this._isClientConstant = isClientConstant;
				this._isClientVariable = isClientVariable;
			}

			// Token: 0x06006292 RID: 25234 RVA: 0x00155633 File Offset: 0x00153833
			internal global::System.Func<bool> GetRecompileRequiredFunction()
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Func<bool>> recompileRequiredDelegates = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Func<bool>>(this._recompileRequiredDelegates);
				return () => recompileRequiredDelegates.Any((global::System.Func<bool> d) => d());
			}

			// Token: 0x06006293 RID: 25235 RVA: 0x00155658 File Offset: 0x00153858
			internal override global::System.Linq.Expressions.Expression Visit(global::System.Linq.Expressions.Expression exp)
			{
				if (exp != null)
				{
					if (!this._funcletizer._linqExpressionStack.Add(exp))
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ELinq_CycleDetected);
					}
					try
					{
						if (this._isClientConstant(exp))
						{
							return this.InlineValue(exp, false);
						}
						if (!this._isClientVariable(exp))
						{
							return base.Visit(exp);
						}
						global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type;
						if (this._funcletizer.TryGetTypeUsageForTerminal(exp, out type))
						{
							return new global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression(type.Parameter(this._funcletizer.GenerateParameterName()), exp, this._funcletizer._compiledQueryParameters);
						}
						if (this._funcletizer.IsCompiledQuery)
						{
							throw global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.FuncletizingVisitor.InvalidCompiledQueryParameterException(exp);
						}
						return this.InlineValue(exp, true);
					}
					finally
					{
						this._funcletizer._linqExpressionStack.Remove(exp);
					}
				}
				return base.Visit(exp);
			}

			// Token: 0x06006294 RID: 25236 RVA: 0x00155740 File Offset: 0x00153940
			private static global::System.NotSupportedException InvalidCompiledQueryParameterException(global::System.Linq.Expressions.Expression expression)
			{
				global::System.Linq.Expressions.ParameterExpression parameterExpression;
				if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Parameter)
				{
					parameterExpression = (global::System.Linq.Expressions.ParameterExpression)expression;
				}
				else
				{
					global::System.Collections.Generic.HashSet<global::System.Linq.Expressions.ParameterExpression> parameters = new global::System.Collections.Generic.HashSet<global::System.Linq.Expressions.ParameterExpression>();
					global::System.Linq.Expressions.EntityExpressionVisitor.Visit(expression, delegate(global::System.Linq.Expressions.Expression exp, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression> baseVisit)
					{
						if (exp != null && exp.NodeType == global::System.Linq.Expressions.ExpressionType.Parameter)
						{
							parameters.Add((global::System.Linq.Expressions.ParameterExpression)exp);
						}
						return baseVisit(exp);
					});
					if (parameters.Count != 1)
					{
						return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.CompiledELinq_UnsupportedParameterTypes(expression.Type.FullName));
					}
					parameterExpression = parameters.Single<global::System.Linq.Expressions.ParameterExpression>();
				}
				if (parameterExpression.Type.Equals(expression.Type))
				{
					return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.CompiledELinq_UnsupportedNamedParameterType(parameterExpression.Name, parameterExpression.Type.FullName));
				}
				return new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.CompiledELinq_UnsupportedNamedParameterUseAsType(parameterExpression.Name, expression.Type.FullName));
			}

			// Token: 0x06006295 RID: 25237 RVA: 0x001557FE File Offset: 0x001539FE
			private static global::System.Func<object> CompileExpression(global::System.Linq.Expressions.Expression expression)
			{
				return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object>>(global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.EnsureType(expression, typeof(object)), new global::System.Linq.Expressions.ParameterExpression[0]).Compile();
			}

			// Token: 0x06006296 RID: 25238 RVA: 0x00155820 File Offset: 0x00153A20
			private global::System.Linq.Expressions.Expression InlineValue(global::System.Linq.Expressions.Expression expression, bool recompileOnChange)
			{
				global::System.Func<object> func = null;
				object obj = null;
				if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Constant)
				{
					obj = ((global::System.Linq.Expressions.ConstantExpression)expression).Value;
				}
				else
				{
					bool flag = false;
					if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Convert)
					{
						global::System.Linq.Expressions.UnaryExpression unaryExpression = (global::System.Linq.Expressions.UnaryExpression)expression;
						if (!recompileOnChange && unaryExpression.Operand.NodeType == global::System.Linq.Expressions.ExpressionType.Constant && typeof(global::System.Linq.IQueryable).IsAssignableFrom(unaryExpression.Operand.Type))
						{
							obj = ((global::System.Linq.Expressions.ConstantExpression)unaryExpression.Operand).Value;
							flag = true;
						}
					}
					if (!flag)
					{
						func = global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.FuncletizingVisitor.CompileExpression(expression);
						obj = func();
					}
				}
				global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = (obj as global::System.Linq.IQueryable).TryGetObjectQuery();
				global::System.Linq.Expressions.Expression result;
				if (objectQuery != null)
				{
					result = this.InlineObjectQuery(objectQuery, objectQuery.GetType());
				}
				else
				{
					global::System.Linq.Expressions.LambdaExpression lambdaExpression = obj as global::System.Linq.Expressions.LambdaExpression;
					if (lambdaExpression != null)
					{
						result = this.InlineExpression(global::System.Linq.Expressions.Expression.Quote(lambdaExpression));
					}
					else
					{
						result = ((expression.NodeType == global::System.Linq.Expressions.ExpressionType.Constant) ? expression : global::System.Linq.Expressions.Expression.Constant(obj, expression.Type));
					}
				}
				if (recompileOnChange)
				{
					this.AddRecompileRequiredDelegates(func, obj);
				}
				return result;
			}

			// Token: 0x06006297 RID: 25239 RVA: 0x00155918 File Offset: 0x00153B18
			private void AddRecompileRequiredDelegates(global::System.Func<object> getValue, object value)
			{
				global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.FuncletizingVisitor.<>c__DisplayClass10_0 CS$<>8__locals1 = new global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.FuncletizingVisitor.<>c__DisplayClass10_0();
				CS$<>8__locals1.getValue = getValue;
				CS$<>8__locals1.value = value;
				CS$<>8__locals1.originalQuery = (CS$<>8__locals1.value as global::System.Linq.IQueryable).TryGetObjectQuery();
				if (CS$<>8__locals1.originalQuery == null)
				{
					if (CS$<>8__locals1.getValue != null)
					{
						this._recompileRequiredDelegates.Add(() => CS$<>8__locals1.value != CS$<>8__locals1.getValue());
					}
					return;
				}
				global::System.Data.Entity.Core.Objects.MergeOption? originalMergeOption = CS$<>8__locals1.originalQuery.QueryState.UserSpecifiedMergeOption;
				if (CS$<>8__locals1.getValue == null)
				{
					this._recompileRequiredDelegates.Add(delegate
					{
						global::System.Data.Entity.Core.Objects.MergeOption? userSpecifiedMergeOption = CS$<>8__locals1.originalQuery.QueryState.UserSpecifiedMergeOption;
						global::System.Data.Entity.Core.Objects.MergeOption? originalMergeOption = originalMergeOption;
						return !(userSpecifiedMergeOption.GetValueOrDefault() == originalMergeOption.GetValueOrDefault() & userSpecifiedMergeOption != null == (originalMergeOption != null));
					});
					return;
				}
				this._recompileRequiredDelegates.Add(delegate
				{
					global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = (CS$<>8__locals1.getValue() as global::System.Linq.IQueryable).TryGetObjectQuery();
					if (CS$<>8__locals1.originalQuery == objectQuery)
					{
						global::System.Data.Entity.Core.Objects.MergeOption? userSpecifiedMergeOption = objectQuery.QueryState.UserSpecifiedMergeOption;
						global::System.Data.Entity.Core.Objects.MergeOption? originalMergeOption = originalMergeOption;
						return !(userSpecifiedMergeOption.GetValueOrDefault() == originalMergeOption.GetValueOrDefault() & userSpecifiedMergeOption != null == (originalMergeOption != null));
					}
					return true;
				});
			}

			// Token: 0x06006298 RID: 25240 RVA: 0x001559DC File Offset: 0x00153BDC
			private global::System.Linq.Expressions.Expression InlineObjectQuery(global::System.Data.Entity.Core.Objects.ObjectQuery inlineQuery, global::System.Type expressionType)
			{
				global::System.Linq.Expressions.Expression expression;
				if (this._funcletizer._mode == global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.Mode.CompiledQueryLockdown)
				{
					expression = global::System.Linq.Expressions.Expression.Constant(inlineQuery, expressionType);
				}
				else
				{
					if (this._funcletizer._rootContext != inlineQuery.QueryState.ObjectContext)
					{
						throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ELinq_UnsupportedDifferentContexts);
					}
					expression = inlineQuery.GetExpression();
					if (!(inlineQuery.QueryState is global::System.Data.Entity.Core.Objects.EntitySqlQueryState))
					{
						expression = this.InlineExpression(expression);
					}
					expression = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.EnsureType(expression, expressionType);
				}
				return expression;
			}

			// Token: 0x06006299 RID: 25241 RVA: 0x00155A48 File Offset: 0x00153C48
			private global::System.Linq.Expressions.Expression InlineExpression(global::System.Linq.Expressions.Expression exp)
			{
				global::System.Func<bool> item;
				exp = this._funcletizer.Funcletize(exp, out item);
				if (!this._funcletizer.IsCompiledQuery)
				{
					this._recompileRequiredDelegates.Add(item);
				}
				return exp;
			}

			// Token: 0x04002B44 RID: 11076
			private readonly global::System.Data.Entity.Core.Objects.ELinq.Funcletizer _funcletizer;

			// Token: 0x04002B45 RID: 11077
			private readonly global::System.Func<global::System.Linq.Expressions.Expression, bool> _isClientConstant;

			// Token: 0x04002B46 RID: 11078
			private readonly global::System.Func<global::System.Linq.Expressions.Expression, bool> _isClientVariable;

			// Token: 0x04002B47 RID: 11079
			private readonly global::System.Collections.Generic.List<global::System.Func<bool>> _recompileRequiredDelegates = new global::System.Collections.Generic.List<global::System.Func<bool>>();
		}
	}
}
