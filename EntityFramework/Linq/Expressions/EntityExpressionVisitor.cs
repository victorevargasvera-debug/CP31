using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions.Internal;

namespace System.Linq.Expressions
{
	// Token: 0x02000054 RID: 84
	internal abstract class EntityExpressionVisitor
	{
		// Token: 0x060001FC RID: 508 RVA: 0x000076A4 File Offset: 0x000058A4
		internal virtual global::System.Linq.Expressions.Expression Visit(global::System.Linq.Expressions.Expression exp)
		{
			if (exp == null)
			{
				return exp;
			}
			switch (exp.NodeType)
			{
			case (global::System.Linq.Expressions.ExpressionType)(-1):
				return this.VisitExtension(exp);
			case global::System.Linq.Expressions.ExpressionType.Add:
			case global::System.Linq.Expressions.ExpressionType.AddChecked:
			case global::System.Linq.Expressions.ExpressionType.And:
			case global::System.Linq.Expressions.ExpressionType.AndAlso:
			case global::System.Linq.Expressions.ExpressionType.ArrayIndex:
			case global::System.Linq.Expressions.ExpressionType.Coalesce:
			case global::System.Linq.Expressions.ExpressionType.Divide:
			case global::System.Linq.Expressions.ExpressionType.ExclusiveOr:
			case global::System.Linq.Expressions.ExpressionType.LeftShift:
			case global::System.Linq.Expressions.ExpressionType.Modulo:
			case global::System.Linq.Expressions.ExpressionType.Multiply:
			case global::System.Linq.Expressions.ExpressionType.MultiplyChecked:
			case global::System.Linq.Expressions.ExpressionType.Or:
			case global::System.Linq.Expressions.ExpressionType.OrElse:
			case global::System.Linq.Expressions.ExpressionType.Power:
			case global::System.Linq.Expressions.ExpressionType.RightShift:
			case global::System.Linq.Expressions.ExpressionType.Subtract:
			case global::System.Linq.Expressions.ExpressionType.SubtractChecked:
				return this.VisitBinary((global::System.Linq.Expressions.BinaryExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.ArrayLength:
			case global::System.Linq.Expressions.ExpressionType.Convert:
			case global::System.Linq.Expressions.ExpressionType.ConvertChecked:
			case global::System.Linq.Expressions.ExpressionType.Negate:
			case global::System.Linq.Expressions.ExpressionType.UnaryPlus:
			case global::System.Linq.Expressions.ExpressionType.NegateChecked:
			case global::System.Linq.Expressions.ExpressionType.Not:
			case global::System.Linq.Expressions.ExpressionType.Quote:
			case global::System.Linq.Expressions.ExpressionType.TypeAs:
				return this.VisitUnary((global::System.Linq.Expressions.UnaryExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.Call:
				return this.VisitMethodCall((global::System.Linq.Expressions.MethodCallExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.Conditional:
				return this.VisitConditional((global::System.Linq.Expressions.ConditionalExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.Constant:
				return this.VisitConstant((global::System.Linq.Expressions.ConstantExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.Equal:
			case global::System.Linq.Expressions.ExpressionType.GreaterThan:
			case global::System.Linq.Expressions.ExpressionType.GreaterThanOrEqual:
			case global::System.Linq.Expressions.ExpressionType.LessThan:
			case global::System.Linq.Expressions.ExpressionType.LessThanOrEqual:
			case global::System.Linq.Expressions.ExpressionType.NotEqual:
				return this.VisitComparison((global::System.Linq.Expressions.BinaryExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.Invoke:
				return this.VisitInvocation((global::System.Linq.Expressions.InvocationExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.Lambda:
				return this.VisitLambda((global::System.Linq.Expressions.LambdaExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.ListInit:
				return this.VisitListInit((global::System.Linq.Expressions.ListInitExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.MemberAccess:
				return this.VisitMemberAccess((global::System.Linq.Expressions.MemberExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.MemberInit:
				return this.VisitMemberInit((global::System.Linq.Expressions.MemberInitExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.New:
				return this.VisitNew((global::System.Linq.Expressions.NewExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.NewArrayInit:
			case global::System.Linq.Expressions.ExpressionType.NewArrayBounds:
				return this.VisitNewArray((global::System.Linq.Expressions.NewArrayExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.Parameter:
				return this.VisitParameter((global::System.Linq.Expressions.ParameterExpression)exp);
			case global::System.Linq.Expressions.ExpressionType.TypeIs:
				return this.VisitTypeIs((global::System.Linq.Expressions.TypeBinaryExpression)exp);
			default:
				throw global::System.Linq.Expressions.Internal.Error.UnhandledExpressionType(exp.NodeType);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000785C File Offset: 0x00005A5C
		internal virtual global::System.Linq.Expressions.MemberBinding VisitBinding(global::System.Linq.Expressions.MemberBinding binding)
		{
			switch (binding.BindingType)
			{
			case global::System.Linq.Expressions.MemberBindingType.Assignment:
				return this.VisitMemberAssignment((global::System.Linq.Expressions.MemberAssignment)binding);
			case global::System.Linq.Expressions.MemberBindingType.MemberBinding:
				return this.VisitMemberMemberBinding((global::System.Linq.Expressions.MemberMemberBinding)binding);
			case global::System.Linq.Expressions.MemberBindingType.ListBinding:
				return this.VisitMemberListBinding((global::System.Linq.Expressions.MemberListBinding)binding);
			default:
				throw global::System.Linq.Expressions.Internal.Error.UnhandledBindingType(binding.BindingType);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000078B8 File Offset: 0x00005AB8
		internal virtual global::System.Linq.Expressions.ElementInit VisitElementInitializer(global::System.Linq.Expressions.ElementInit initializer)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Linq.Expressions.Expression> readOnlyCollection = this.VisitExpressionList(initializer.Arguments);
			if (readOnlyCollection != initializer.Arguments)
			{
				return global::System.Linq.Expressions.Expression.ElementInit(initializer.AddMethod, readOnlyCollection);
			}
			return initializer;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000078EC File Offset: 0x00005AEC
		internal virtual global::System.Linq.Expressions.Expression VisitUnary(global::System.Linq.Expressions.UnaryExpression u)
		{
			global::System.Linq.Expressions.Expression expression = this.Visit(u.Operand);
			if (expression != u.Operand)
			{
				return global::System.Linq.Expressions.Expression.MakeUnary(u.NodeType, expression, u.Type, u.Method);
			}
			return u;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000792C File Offset: 0x00005B2C
		internal virtual global::System.Linq.Expressions.Expression VisitBinary(global::System.Linq.Expressions.BinaryExpression b)
		{
			global::System.Linq.Expressions.Expression expression = this.Visit(b.Left);
			global::System.Linq.Expressions.Expression expression2 = this.Visit(b.Right);
			global::System.Linq.Expressions.Expression expression3 = this.Visit(b.Conversion);
			if (expression == b.Left && expression2 == b.Right && expression3 == b.Conversion)
			{
				return b;
			}
			if (b.NodeType == global::System.Linq.Expressions.ExpressionType.Coalesce && b.Conversion != null)
			{
				return global::System.Linq.Expressions.Expression.Coalesce(expression, expression2, expression3 as global::System.Linq.Expressions.LambdaExpression);
			}
			return global::System.Linq.Expressions.Expression.MakeBinary(b.NodeType, expression, expression2, b.IsLiftedToNull, b.Method);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000079B5 File Offset: 0x00005BB5
		internal virtual global::System.Linq.Expressions.Expression VisitComparison(global::System.Linq.Expressions.BinaryExpression expression)
		{
			return this.VisitBinary(global::System.Linq.Expressions.EntityExpressionVisitor.RemoveUnnecessaryConverts(expression));
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000079C4 File Offset: 0x00005BC4
		internal virtual global::System.Linq.Expressions.Expression VisitTypeIs(global::System.Linq.Expressions.TypeBinaryExpression b)
		{
			global::System.Linq.Expressions.Expression expression = this.Visit(b.Expression);
			if (expression != b.Expression)
			{
				return global::System.Linq.Expressions.Expression.TypeIs(expression, b.TypeOperand);
			}
			return b;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000079F5 File Offset: 0x00005BF5
		internal virtual global::System.Linq.Expressions.Expression VisitConstant(global::System.Linq.Expressions.ConstantExpression c)
		{
			return c;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000079F8 File Offset: 0x00005BF8
		internal virtual global::System.Linq.Expressions.Expression VisitConditional(global::System.Linq.Expressions.ConditionalExpression c)
		{
			global::System.Linq.Expressions.Expression expression = this.Visit(c.Test);
			global::System.Linq.Expressions.Expression expression2 = this.Visit(c.IfTrue);
			global::System.Linq.Expressions.Expression expression3 = this.Visit(c.IfFalse);
			if (expression != c.Test || expression2 != c.IfTrue || expression3 != c.IfFalse)
			{
				return global::System.Linq.Expressions.Expression.Condition(expression, expression2, expression3);
			}
			return c;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00007A51 File Offset: 0x00005C51
		internal virtual global::System.Linq.Expressions.Expression VisitParameter(global::System.Linq.Expressions.ParameterExpression p)
		{
			return p;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00007A54 File Offset: 0x00005C54
		internal virtual global::System.Linq.Expressions.Expression VisitMemberAccess(global::System.Linq.Expressions.MemberExpression m)
		{
			global::System.Linq.Expressions.Expression expression = this.Visit(m.Expression);
			if (expression != m.Expression)
			{
				return global::System.Linq.Expressions.Expression.MakeMemberAccess(expression, m.Member);
			}
			return m;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00007A88 File Offset: 0x00005C88
		internal virtual global::System.Linq.Expressions.Expression VisitMethodCall(global::System.Linq.Expressions.MethodCallExpression m)
		{
			global::System.Linq.Expressions.Expression expression = this.Visit(m.Object);
			global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> enumerable = this.VisitExpressionList(m.Arguments);
			if (expression != m.Object || enumerable != m.Arguments)
			{
				return global::System.Linq.Expressions.Expression.Call(expression, m.Method, enumerable);
			}
			return m;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00007AD0 File Offset: 0x00005CD0
		internal virtual global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Linq.Expressions.Expression> VisitExpressionList(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Linq.Expressions.Expression> original)
		{
			global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> list = null;
			int i = 0;
			int count = original.Count;
			while (i < count)
			{
				global::System.Linq.Expressions.Expression expression = this.Visit(original[i]);
				if (list != null)
				{
					list.Add(expression);
				}
				else if (expression != original[i])
				{
					list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>(count);
					for (int j = 0; j < i; j++)
					{
						list.Add(original[j]);
					}
					list.Add(expression);
				}
				i++;
			}
			if (list != null)
			{
				return list.ToReadOnlyCollection<global::System.Linq.Expressions.Expression>();
			}
			return original;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00007B50 File Offset: 0x00005D50
		internal virtual global::System.Linq.Expressions.MemberAssignment VisitMemberAssignment(global::System.Linq.Expressions.MemberAssignment assignment)
		{
			global::System.Linq.Expressions.Expression expression = this.Visit(assignment.Expression);
			if (expression != assignment.Expression)
			{
				return global::System.Linq.Expressions.Expression.Bind(assignment.Member, expression);
			}
			return assignment;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00007B84 File Offset: 0x00005D84
		internal virtual global::System.Linq.Expressions.MemberMemberBinding VisitMemberMemberBinding(global::System.Linq.Expressions.MemberMemberBinding binding)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.MemberBinding> enumerable = this.VisitBindingList(binding.Bindings);
			if (enumerable != binding.Bindings)
			{
				return global::System.Linq.Expressions.Expression.MemberBind(binding.Member, enumerable);
			}
			return binding;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00007BB8 File Offset: 0x00005DB8
		internal virtual global::System.Linq.Expressions.MemberListBinding VisitMemberListBinding(global::System.Linq.Expressions.MemberListBinding binding)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.ElementInit> enumerable = this.VisitElementInitializerList(binding.Initializers);
			if (enumerable != binding.Initializers)
			{
				return global::System.Linq.Expressions.Expression.ListBind(binding.Member, enumerable);
			}
			return binding;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00007BEC File Offset: 0x00005DEC
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.MemberBinding> VisitBindingList(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Linq.Expressions.MemberBinding> original)
		{
			global::System.Collections.Generic.List<global::System.Linq.Expressions.MemberBinding> list = null;
			int i = 0;
			int count = original.Count;
			while (i < count)
			{
				global::System.Linq.Expressions.MemberBinding memberBinding = this.VisitBinding(original[i]);
				if (list != null)
				{
					list.Add(memberBinding);
				}
				else if (memberBinding != original[i])
				{
					list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.MemberBinding>(count);
					for (int j = 0; j < i; j++)
					{
						list.Add(original[j]);
					}
					list.Add(memberBinding);
				}
				i++;
			}
			if (list != null)
			{
				return list;
			}
			return original;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00007C64 File Offset: 0x00005E64
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.ElementInit> VisitElementInitializerList(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Linq.Expressions.ElementInit> original)
		{
			global::System.Collections.Generic.List<global::System.Linq.Expressions.ElementInit> list = null;
			int i = 0;
			int count = original.Count;
			while (i < count)
			{
				global::System.Linq.Expressions.ElementInit elementInit = this.VisitElementInitializer(original[i]);
				if (list != null)
				{
					list.Add(elementInit);
				}
				else if (elementInit != original[i])
				{
					list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.ElementInit>(count);
					for (int j = 0; j < i; j++)
					{
						list.Add(original[j]);
					}
					list.Add(elementInit);
				}
				i++;
			}
			if (list != null)
			{
				return list;
			}
			return original;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00007CDC File Offset: 0x00005EDC
		internal virtual global::System.Linq.Expressions.Expression VisitLambda(global::System.Linq.Expressions.LambdaExpression lambda)
		{
			global::System.Linq.Expressions.Expression expression = this.Visit(lambda.Body);
			if (expression != lambda.Body)
			{
				return global::System.Linq.Expressions.Expression.Lambda(lambda.Type, expression, lambda.Parameters);
			}
			return lambda;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00007D14 File Offset: 0x00005F14
		internal virtual global::System.Linq.Expressions.NewExpression VisitNew(global::System.Linq.Expressions.NewExpression nex)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> enumerable = this.VisitExpressionList(nex.Arguments);
			if (enumerable == nex.Arguments)
			{
				return nex;
			}
			if (nex.Members != null)
			{
				return global::System.Linq.Expressions.Expression.New(nex.Constructor, enumerable, nex.Members);
			}
			return global::System.Linq.Expressions.Expression.New(nex.Constructor, enumerable);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00007D60 File Offset: 0x00005F60
		internal virtual global::System.Linq.Expressions.Expression VisitMemberInit(global::System.Linq.Expressions.MemberInitExpression init)
		{
			global::System.Linq.Expressions.NewExpression newExpression = this.VisitNew(init.NewExpression);
			global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.MemberBinding> enumerable = this.VisitBindingList(init.Bindings);
			if (newExpression != init.NewExpression || enumerable != init.Bindings)
			{
				return global::System.Linq.Expressions.Expression.MemberInit(newExpression, enumerable);
			}
			return init;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00007DA4 File Offset: 0x00005FA4
		internal virtual global::System.Linq.Expressions.Expression VisitListInit(global::System.Linq.Expressions.ListInitExpression init)
		{
			global::System.Linq.Expressions.NewExpression newExpression = this.VisitNew(init.NewExpression);
			global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.ElementInit> enumerable = this.VisitElementInitializerList(init.Initializers);
			if (newExpression != init.NewExpression || enumerable != init.Initializers)
			{
				return global::System.Linq.Expressions.Expression.ListInit(newExpression, enumerable);
			}
			return init;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00007DE8 File Offset: 0x00005FE8
		internal virtual global::System.Linq.Expressions.Expression VisitNewArray(global::System.Linq.Expressions.NewArrayExpression na)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> enumerable = this.VisitExpressionList(na.Expressions);
			if (enumerable == na.Expressions)
			{
				return na;
			}
			if (na.NodeType == global::System.Linq.Expressions.ExpressionType.NewArrayInit)
			{
				return global::System.Linq.Expressions.Expression.NewArrayInit(na.Type.GetElementType(), enumerable);
			}
			return global::System.Linq.Expressions.Expression.NewArrayBounds(na.Type.GetElementType(), enumerable);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00007E3C File Offset: 0x0000603C
		internal virtual global::System.Linq.Expressions.Expression VisitInvocation(global::System.Linq.Expressions.InvocationExpression iv)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> enumerable = this.VisitExpressionList(iv.Arguments);
			global::System.Linq.Expressions.Expression expression = this.Visit(iv.Expression);
			if (enumerable != iv.Arguments || expression != iv.Expression)
			{
				return global::System.Linq.Expressions.Expression.Invoke(expression, enumerable);
			}
			return iv;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00007E7E File Offset: 0x0000607E
		internal virtual global::System.Linq.Expressions.Expression VisitExtension(global::System.Linq.Expressions.Expression ext)
		{
			return ext;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00007E81 File Offset: 0x00006081
		internal static global::System.Linq.Expressions.Expression Visit(global::System.Linq.Expressions.Expression exp, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>, global::System.Linq.Expressions.Expression> visit)
		{
			return new global::System.Linq.Expressions.EntityExpressionVisitor.BasicExpressionVisitor(visit).Visit(exp);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00007E90 File Offset: 0x00006090
		private static global::System.Linq.Expressions.BinaryExpression RemoveUnnecessaryConverts(global::System.Linq.Expressions.BinaryExpression expression)
		{
			if (expression.Method != null || expression.Left.Type != expression.Right.Type)
			{
				return expression;
			}
			global::System.Linq.Expressions.ExpressionType nodeType = expression.Left.NodeType;
			if (nodeType != global::System.Linq.Expressions.ExpressionType.Constant)
			{
				if (nodeType == global::System.Linq.Expressions.ExpressionType.Convert)
				{
					global::System.Linq.Expressions.UnaryExpression unaryExpression = (global::System.Linq.Expressions.UnaryExpression)expression.Left;
					global::System.Linq.Expressions.ExpressionType nodeType2 = expression.Right.NodeType;
					if (nodeType2 != global::System.Linq.Expressions.ExpressionType.Constant)
					{
						if (nodeType2 == global::System.Linq.Expressions.ExpressionType.Convert)
						{
							global::System.Linq.Expressions.UnaryExpression unaryExpression2 = (global::System.Linq.Expressions.UnaryExpression)expression.Right;
							if (global::System.Linq.Expressions.EntityExpressionVisitor.CanRemoveConverts(unaryExpression, unaryExpression2))
							{
								return global::System.Linq.Expressions.EntityExpressionVisitor.MakeBinaryExpression(expression.NodeType, unaryExpression.Operand, unaryExpression2.Operand);
							}
						}
					}
					else
					{
						global::System.Linq.Expressions.ConstantExpression right = (global::System.Linq.Expressions.ConstantExpression)expression.Right;
						if (global::System.Linq.Expressions.EntityExpressionVisitor.TryConvertConstant(ref right, unaryExpression.Operand.Type))
						{
							return global::System.Linq.Expressions.EntityExpressionVisitor.MakeBinaryExpression(expression.NodeType, unaryExpression.Operand, right);
						}
					}
				}
			}
			else
			{
				global::System.Linq.Expressions.ConstantExpression left = (global::System.Linq.Expressions.ConstantExpression)expression.Left;
				if (expression.Right.NodeType == global::System.Linq.Expressions.ExpressionType.Convert)
				{
					global::System.Linq.Expressions.UnaryExpression unaryExpression3 = (global::System.Linq.Expressions.UnaryExpression)expression.Right;
					if (global::System.Linq.Expressions.EntityExpressionVisitor.TryConvertConstant(ref left, unaryExpression3.Operand.Type))
					{
						return global::System.Linq.Expressions.EntityExpressionVisitor.MakeBinaryExpression(expression.NodeType, left, unaryExpression3.Operand);
					}
				}
			}
			return expression;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00007FC8 File Offset: 0x000061C8
		private static bool CanRemoveConverts(global::System.Linq.Expressions.UnaryExpression leftConvert, global::System.Linq.Expressions.UnaryExpression rightConvert)
		{
			if (leftConvert.Method != null || rightConvert.Method != null)
			{
				return false;
			}
			if (global::System.Type.GetTypeCode(leftConvert.Type) != global::System.TypeCode.Int32)
			{
				return false;
			}
			global::System.TypeCode typeCode = global::System.Type.GetTypeCode(leftConvert.Operand.Type);
			return typeCode - global::System.TypeCode.Byte <= 1 && leftConvert.Operand.Type == rightConvert.Operand.Type;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00008038 File Offset: 0x00006238
		private static bool TryConvertConstant(ref global::System.Linq.Expressions.ConstantExpression constant, global::System.Type type)
		{
			if (global::System.Type.GetTypeCode(constant.Type) != global::System.TypeCode.Int32)
			{
				return false;
			}
			int num = (int)constant.Value;
			global::System.TypeCode typeCode = global::System.Type.GetTypeCode(type);
			if (typeCode != global::System.TypeCode.Byte)
			{
				if (typeCode == global::System.TypeCode.Int16)
				{
					if (num >= -32768 && num <= 32767)
					{
						constant = global::System.Linq.Expressions.Expression.Constant((short)num);
						return true;
					}
				}
			}
			else if (num >= 0 && num <= 255)
			{
				constant = global::System.Linq.Expressions.Expression.Constant((byte)num);
				return true;
			}
			return false;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000080B4 File Offset: 0x000062B4
		private static global::System.Linq.Expressions.BinaryExpression MakeBinaryExpression(global::System.Linq.Expressions.ExpressionType expressionType, global::System.Linq.Expressions.Expression left, global::System.Linq.Expressions.Expression right)
		{
			if (left.Type.IsEnum)
			{
				left = global::System.Linq.Expressions.Expression.Convert(left, left.Type.GetEnumUnderlyingType());
			}
			if (right.Type.IsEnum)
			{
				right = global::System.Linq.Expressions.Expression.Convert(right, right.Type.GetEnumUnderlyingType());
			}
			return global::System.Linq.Expressions.Expression.MakeBinary(expressionType, left, right);
		}

		// Token: 0x040000A8 RID: 168
		internal const global::System.Linq.Expressions.ExpressionType CustomExpression = (global::System.Linq.Expressions.ExpressionType)(-1);

		// Token: 0x020006FF RID: 1791
		private sealed class BasicExpressionVisitor : global::System.Linq.Expressions.EntityExpressionVisitor
		{
			// Token: 0x0600549D RID: 21661 RVA: 0x0012F588 File Offset: 0x0012D788
			internal BasicExpressionVisitor(global::System.Func<global::System.Linq.Expressions.Expression, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>, global::System.Linq.Expressions.Expression> visit)
			{
				global::System.Func<global::System.Linq.Expressions.Expression, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>, global::System.Linq.Expressions.Expression> visit2 = visit;
				if (visit == null && (visit2 = global::System.Linq.Expressions.EntityExpressionVisitor.BasicExpressionVisitor.<>c.<>9__1_0) == null)
				{
					visit2 = (global::System.Linq.Expressions.EntityExpressionVisitor.BasicExpressionVisitor.<>c.<>9__1_0 = ((global::System.Linq.Expressions.Expression exp, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression> baseVisit) => baseVisit(exp)));
				}
				this._visit = visit2;
			}

			// Token: 0x0600549E RID: 21662 RVA: 0x0012F5BA File Offset: 0x0012D7BA
			internal override global::System.Linq.Expressions.Expression Visit(global::System.Linq.Expressions.Expression exp)
			{
				return this._visit(exp, new global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>(base.Visit));
			}

			// Token: 0x04001E3F RID: 7743
			private readonly global::System.Func<global::System.Linq.Expressions.Expression, global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression>, global::System.Linq.Expressions.Expression> _visit;
		}
	}
}
