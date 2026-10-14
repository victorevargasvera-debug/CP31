using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x02000464 RID: 1124
	internal class LinqExpressionNormalizer : global::System.Linq.Expressions.EntityExpressionVisitor
	{
		// Token: 0x0600376A RID: 14186 RVA: 0x000B2C6C File Offset: 0x000B0E6C
		internal override global::System.Linq.Expressions.Expression VisitBinary(global::System.Linq.Expressions.BinaryExpression b)
		{
			b = (global::System.Linq.Expressions.BinaryExpression)base.VisitBinary(b);
			if (b.NodeType == global::System.Linq.Expressions.ExpressionType.Equal)
			{
				global::System.Linq.Expressions.Expression expression = global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.UnwrapObjectConvert(b.Left);
				global::System.Linq.Expressions.Expression expression2 = global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.UnwrapObjectConvert(b.Right);
				if (expression != b.Left || expression2 != b.Right)
				{
					b = global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.CreateRelationalOperator(global::System.Linq.Expressions.ExpressionType.Equal, expression, expression2);
				}
			}
			global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.Pattern pattern;
			if (this._patterns.TryGetValue(b.Left, out pattern) && pattern.Kind == global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.PatternKind.Compare && global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.IsConstantZero(b.Right))
			{
				global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.ComparePattern comparePattern = (global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.ComparePattern)pattern;
				global::System.Linq.Expressions.BinaryExpression binaryExpression;
				if (global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.TryCreateRelationalOperator(b.NodeType, comparePattern.Left, comparePattern.Right, out binaryExpression))
				{
					b = binaryExpression;
				}
			}
			return b;
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x000B2D18 File Offset: 0x000B0F18
		private static global::System.Linq.Expressions.Expression UnwrapObjectConvert(global::System.Linq.Expressions.Expression input)
		{
			if (input.NodeType == global::System.Linq.Expressions.ExpressionType.Constant && input.Type == typeof(object))
			{
				global::System.Linq.Expressions.ConstantExpression constantExpression = (global::System.Linq.Expressions.ConstantExpression)input;
				if (constantExpression.Value != null && constantExpression.Value.GetType() != typeof(object))
				{
					return global::System.Linq.Expressions.Expression.Constant(constantExpression.Value, constantExpression.Value.GetType());
				}
			}
			while (global::System.Linq.Expressions.ExpressionType.Convert == input.NodeType && typeof(object) == input.Type)
			{
				input = ((global::System.Linq.Expressions.UnaryExpression)input).Operand;
			}
			return input;
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x000B2DB7 File Offset: 0x000B0FB7
		private static bool IsConstantZero(global::System.Linq.Expressions.Expression expression)
		{
			return expression.NodeType == global::System.Linq.Expressions.ExpressionType.Constant && ((global::System.Linq.Expressions.ConstantExpression)expression).Value.Equals(0);
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x000B2DDC File Offset: 0x000B0FDC
		internal override global::System.Linq.Expressions.Expression VisitMethodCall(global::System.Linq.Expressions.MethodCallExpression m)
		{
			m = (global::System.Linq.Expressions.MethodCallExpression)base.VisitMethodCall(m);
			if (m.Method.IsStatic)
			{
				if (m.Method.Name.StartsWith("op_", global::System.StringComparison.Ordinal))
				{
					if (m.Arguments.Count == 2)
					{
						string name = m.Method.Name;
						if (name != null)
						{
							uint num = global::<PrivateImplementationDetails>.ComputeStringHash(name);
							if (num <= 1915672496U)
							{
								if (num <= 1195761148U)
								{
									if (num != 835846267U)
									{
										if (num != 906583475U)
										{
											if (num == 1195761148U)
											{
												if (name == "op_GreaterThan")
												{
													return global::System.Linq.Expressions.Expression.GreaterThan(m.Arguments[0], m.Arguments[1], false, m.Method);
												}
											}
										}
										else if (name == "op_Addition")
										{
											return global::System.Linq.Expressions.Expression.Add(m.Arguments[0], m.Arguments[1], m.Method);
										}
									}
									else if (name == "op_BitwiseAnd")
									{
										return global::System.Linq.Expressions.Expression.And(m.Arguments[0], m.Arguments[1], m.Method);
									}
								}
								else if (num <= 1258540185U)
								{
									if (num != 1234170120U)
									{
										if (num == 1258540185U)
										{
											if (name == "op_LessThan")
											{
												return global::System.Linq.Expressions.Expression.LessThan(m.Arguments[0], m.Arguments[1], false, m.Method);
											}
										}
									}
									else if (name == "op_LessThanOrEqual")
									{
										return global::System.Linq.Expressions.Expression.LessThanOrEqual(m.Arguments[0], m.Arguments[1], false, m.Method);
									}
								}
								else if (num != 1516143579U)
								{
									if (num == 1915672496U)
									{
										if (name == "op_Division")
										{
											return global::System.Linq.Expressions.Expression.Divide(m.Arguments[0], m.Arguments[1], m.Method);
										}
									}
								}
								else if (name == "op_Equality")
								{
									return global::System.Linq.Expressions.Expression.Equal(m.Arguments[0], m.Arguments[1], false, m.Method);
								}
							}
							else if (num <= 2459852411U)
							{
								if (num != 2366795836U)
								{
									if (num != 2429678952U)
									{
										if (num == 2459852411U)
										{
											if (name == "op_GreaterThanOrEqual")
											{
												return global::System.Linq.Expressions.Expression.GreaterThanOrEqual(m.Arguments[0], m.Arguments[1], false, m.Method);
											}
										}
									}
									else if (name == "op_Modulus")
									{
										return global::System.Linq.Expressions.Expression.Modulo(m.Arguments[0], m.Arguments[1], m.Method);
									}
								}
								else if (name == "op_ExclusiveOr")
								{
									return global::System.Linq.Expressions.Expression.ExclusiveOr(m.Arguments[0], m.Arguments[1], m.Method);
								}
							}
							else if (num <= 3279419199U)
							{
								if (num != 2958252495U)
								{
									if (num == 3279419199U)
									{
										if (name == "op_Subtraction")
										{
											return global::System.Linq.Expressions.Expression.Subtract(m.Arguments[0], m.Arguments[1], m.Method);
										}
									}
								}
								else if (name == "op_Multiply")
								{
									return global::System.Linq.Expressions.Expression.Multiply(m.Arguments[0], m.Arguments[1], m.Method);
								}
							}
							else if (num != 3492550567U)
							{
								if (num == 3794317784U)
								{
									if (name == "op_Inequality")
									{
										return global::System.Linq.Expressions.Expression.NotEqual(m.Arguments[0], m.Arguments[1], false, m.Method);
									}
								}
							}
							else if (name == "op_BitwiseOr")
							{
								return global::System.Linq.Expressions.Expression.Or(m.Arguments[0], m.Arguments[1], m.Method);
							}
						}
					}
					if (m.Arguments.Count == 1)
					{
						string name = m.Method.Name;
						if (name != null)
						{
							if (name == "op_UnaryNegation")
							{
								return global::System.Linq.Expressions.Expression.Negate(m.Arguments[0], m.Method);
							}
							if (name == "op_UnaryPlus")
							{
								return global::System.Linq.Expressions.Expression.UnaryPlus(m.Arguments[0], m.Method);
							}
							if (name == "op_Explicit" || name == "op_Implicit")
							{
								return global::System.Linq.Expressions.Expression.Convert(m.Arguments[0], m.Type, m.Method);
							}
							if (name == "op_OnesComplement" || name == "op_False")
							{
								return global::System.Linq.Expressions.Expression.Not(m.Arguments[0], m.Method);
							}
						}
					}
				}
				if (m.Method.Name == "Equals" && m.Arguments.Count > 1)
				{
					return global::System.Linq.Expressions.Expression.Equal(m.Arguments[0], m.Arguments[1], false, m.Method);
				}
				if (m.Method.Name == "CompareString" && (m.Method.DeclaringType.FullName == "Microsoft.VisualBasic.CompilerServices.Operators" || m.Method.DeclaringType.FullName == "Microsoft.VisualBasic.CompilerServices.EmbeddedOperators"))
				{
					return this.CreateCompareExpression(m.Arguments[0], m.Arguments[1]);
				}
				if (m.Method.Name == "Compare" && m.Arguments.Count > 1 && m.Method.ReturnType == typeof(int))
				{
					return this.CreateCompareExpression(m.Arguments[0], m.Arguments[1]);
				}
			}
			else
			{
				if (m.Method.Name == "Equals" && m.Arguments.Count > 0)
				{
					global::System.Type parameterType = m.Method.GetParameters()[0].ParameterType;
					if (parameterType != typeof(global::System.Data.Entity.Spatial.DbGeography) && parameterType != typeof(global::System.Data.Entity.Spatial.DbGeometry))
					{
						return global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.CreateRelationalOperator(global::System.Linq.Expressions.ExpressionType.Equal, m.Object, m.Arguments[0]);
					}
				}
				if (m.Method.Name == "CompareTo" && m.Arguments.Count == 1 && m.Method.ReturnType == typeof(int))
				{
					return this.CreateCompareExpression(m.Object, m.Arguments[0]);
				}
				if (m.Method.Name == "Contains" && m.Arguments.Count == 1)
				{
					global::System.Type declaringType = m.Method.DeclaringType;
					global::System.Reflection.MethodInfo methodInfo;
					if (declaringType.IsGenericType() && declaringType.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.List<>) && global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.TryLookupMethod(global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Contains, out methodInfo))
					{
						return global::System.Linq.Expressions.Expression.Call(methodInfo.MakeGenericMethod(declaringType.GetGenericArguments()), m.Object, m.Arguments[0]);
					}
				}
			}
			return global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.NormalizePredicateArgument(m);
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x000B3598 File Offset: 0x000B1798
		private static global::System.Linq.Expressions.MethodCallExpression NormalizePredicateArgument(global::System.Linq.Expressions.MethodCallExpression callExpression)
		{
			int index;
			global::System.Linq.Expressions.Expression value;
			global::System.Linq.Expressions.MethodCallExpression result;
			if (global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.HasPredicateArgument(callExpression, out index) && global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.TryMatchCoalescePattern(callExpression.Arguments[index], out value))
			{
				global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>(callExpression.Arguments);
				list[index] = value;
				result = global::System.Linq.Expressions.Expression.Call(callExpression.Object, callExpression.Method, list);
			}
			else
			{
				result = callExpression;
			}
			return result;
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x000B35F0 File Offset: 0x000B17F0
		private static bool HasPredicateArgument(global::System.Linq.Expressions.MethodCallExpression callExpression, out int argumentOrdinal)
		{
			argumentOrdinal = 0;
			bool result = false;
			global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod;
			if (2 <= callExpression.Arguments.Count && global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.TryIdentifySequenceMethod(callExpression.Method, out sequenceMethod))
			{
				if (sequenceMethod <= global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.TakeWhileOrdinal)
				{
					if (sequenceMethod > global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.WhereOrdinal && sequenceMethod - global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.TakeWhile > 1)
					{
						return result;
					}
				}
				else if (sequenceMethod - global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SkipWhile > 1)
				{
					switch (sequenceMethod)
					{
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstPredicate:
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstOrDefaultPredicate:
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LastPredicate:
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LastOrDefaultPredicate:
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SinglePredicate:
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SingleOrDefaultPredicate:
						break;
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstOrDefault:
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Last:
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LastOrDefault:
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Single:
					case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SingleOrDefault:
						return result;
					default:
						switch (sequenceMethod)
						{
						case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.AnyPredicate:
						case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.All:
						case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.CountPredicate:
						case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LongCountPredicate:
							break;
						case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.Count:
						case global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.LongCount:
							return result;
						default:
							return result;
						}
						break;
					}
				}
				argumentOrdinal = 1;
				result = true;
			}
			return result;
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x000B369C File Offset: 0x000B189C
		private static bool TryMatchCoalescePattern(global::System.Linq.Expressions.Expression expression, out global::System.Linq.Expressions.Expression normalized)
		{
			normalized = null;
			bool result = false;
			if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Quote)
			{
				if (global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.TryMatchCoalescePattern(((global::System.Linq.Expressions.UnaryExpression)expression).Operand, out normalized))
				{
					result = true;
					normalized = global::System.Linq.Expressions.Expression.Quote(normalized);
				}
			}
			else if (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Lambda)
			{
				global::System.Linq.Expressions.LambdaExpression lambdaExpression = (global::System.Linq.Expressions.LambdaExpression)expression;
				if (lambdaExpression.Body.NodeType == global::System.Linq.Expressions.ExpressionType.Coalesce && lambdaExpression.Body.Type == typeof(bool))
				{
					global::System.Linq.Expressions.BinaryExpression binaryExpression = (global::System.Linq.Expressions.BinaryExpression)lambdaExpression.Body;
					if (binaryExpression.Right.NodeType == global::System.Linq.Expressions.ExpressionType.Constant && false.Equals(((global::System.Linq.Expressions.ConstantExpression)binaryExpression.Right).Value))
					{
						normalized = global::System.Linq.Expressions.Expression.Lambda(lambdaExpression.Type, global::System.Linq.Expressions.Expression.Convert(binaryExpression.Left, typeof(bool)), lambdaExpression.Parameters);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x000B377D File Offset: 0x000B197D
		private static bool RelationalOperatorPlaceholder<TLeft, TRight>(TLeft left, TRight right)
		{
			return left == right;
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x000B3790 File Offset: 0x000B1990
		private static global::System.Linq.Expressions.BinaryExpression CreateRelationalOperator(global::System.Linq.Expressions.ExpressionType op, global::System.Linq.Expressions.Expression left, global::System.Linq.Expressions.Expression right)
		{
			global::System.Linq.Expressions.BinaryExpression result;
			global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.TryCreateRelationalOperator(op, left, right, out result);
			return result;
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x000B37AC File Offset: 0x000B19AC
		private static bool TryCreateRelationalOperator(global::System.Linq.Expressions.ExpressionType op, global::System.Linq.Expressions.Expression left, global::System.Linq.Expressions.Expression right, out global::System.Linq.Expressions.BinaryExpression result)
		{
			global::System.Reflection.MethodInfo method = global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.RelationalOperatorPlaceholderMethod.MakeGenericMethod(new global::System.Type[]
			{
				left.Type,
				right.Type
			});
			switch (op)
			{
			case global::System.Linq.Expressions.ExpressionType.Equal:
				result = global::System.Linq.Expressions.Expression.Equal(left, right, false, method);
				return true;
			case global::System.Linq.Expressions.ExpressionType.ExclusiveOr:
			case global::System.Linq.Expressions.ExpressionType.Invoke:
			case global::System.Linq.Expressions.ExpressionType.Lambda:
			case global::System.Linq.Expressions.ExpressionType.LeftShift:
				break;
			case global::System.Linq.Expressions.ExpressionType.GreaterThan:
				result = global::System.Linq.Expressions.Expression.GreaterThan(left, right, false, method);
				return true;
			case global::System.Linq.Expressions.ExpressionType.GreaterThanOrEqual:
				result = global::System.Linq.Expressions.Expression.GreaterThanOrEqual(left, right, false, method);
				return true;
			case global::System.Linq.Expressions.ExpressionType.LessThan:
				result = global::System.Linq.Expressions.Expression.LessThan(left, right, false, method);
				return true;
			case global::System.Linq.Expressions.ExpressionType.LessThanOrEqual:
				result = global::System.Linq.Expressions.Expression.LessThanOrEqual(left, right, false, method);
				return true;
			default:
				if (op == global::System.Linq.Expressions.ExpressionType.NotEqual)
				{
					result = global::System.Linq.Expressions.Expression.NotEqual(left, right, false, method);
					return true;
				}
				break;
			}
			result = null;
			return false;
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x000B3864 File Offset: 0x000B1A64
		private global::System.Linq.Expressions.Expression CreateCompareExpression(global::System.Linq.Expressions.Expression left, global::System.Linq.Expressions.Expression right)
		{
			global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.Condition(global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.CreateRelationalOperator(global::System.Linq.Expressions.ExpressionType.Equal, left, right), global::System.Linq.Expressions.Expression.Constant(0), global::System.Linq.Expressions.Expression.Condition(global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.CreateRelationalOperator(global::System.Linq.Expressions.ExpressionType.GreaterThan, left, right), global::System.Linq.Expressions.Expression.Constant(1), global::System.Linq.Expressions.Expression.Constant(-1)));
			this._patterns[expression] = new global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.ComparePattern(left, right);
			return expression;
		}

		// Token: 0x0400121C RID: 4636
		private const bool LiftToNull = false;

		// Token: 0x0400121D RID: 4637
		private readonly global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.Expression, global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.Pattern> _patterns = new global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.Expression, global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.Pattern>();

		// Token: 0x0400121E RID: 4638
		internal static readonly global::System.Reflection.MethodInfo RelationalOperatorPlaceholderMethod = typeof(global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer).GetOnlyDeclaredMethod("RelationalOperatorPlaceholder");

		// Token: 0x02000AAC RID: 2732
		private abstract class Pattern
		{
			// Token: 0x170010CB RID: 4299
			// (get) Token: 0x060062C3 RID: 25283
			internal abstract global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.PatternKind Kind { get; }
		}

		// Token: 0x02000AAD RID: 2733
		private enum PatternKind
		{
			// Token: 0x04002B56 RID: 11094
			Compare
		}

		// Token: 0x02000AAE RID: 2734
		private sealed class ComparePattern : global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.Pattern
		{
			// Token: 0x060062C5 RID: 25285 RVA: 0x00156155 File Offset: 0x00154355
			internal ComparePattern(global::System.Linq.Expressions.Expression left, global::System.Linq.Expressions.Expression right)
			{
				this.Left = left;
				this.Right = right;
			}

			// Token: 0x170010CC RID: 4300
			// (get) Token: 0x060062C6 RID: 25286 RVA: 0x0015616B File Offset: 0x0015436B
			internal override global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.PatternKind Kind
			{
				get
				{
					return global::System.Data.Entity.Core.Objects.ELinq.LinqExpressionNormalizer.PatternKind.Compare;
				}
			}

			// Token: 0x04002B57 RID: 11095
			internal readonly global::System.Linq.Expressions.Expression Left;

			// Token: 0x04002B58 RID: 11096
			internal readonly global::System.Linq.Expressions.Expression Right;
		}
	}
}
