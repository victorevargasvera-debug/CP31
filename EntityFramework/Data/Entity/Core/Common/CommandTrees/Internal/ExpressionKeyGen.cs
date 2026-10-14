using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006ED RID: 1773
	internal sealed class ExpressionKeyGen : global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor
	{
		// Token: 0x06005277 RID: 21111 RVA: 0x00126574 File Offset: 0x00124774
		internal static bool TryGenerateKey(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression tree, out string key)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionKeyGen expressionKeyGen = new global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionKeyGen();
			bool result;
			try
			{
				tree.Accept(expressionKeyGen);
				key = expressionKeyGen._key.ToString();
				result = true;
			}
			catch (global::System.NotSupportedException)
			{
				key = null;
				result = false;
			}
			return result;
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x001265B8 File Offset: 0x001247B8
		internal ExpressionKeyGen()
		{
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x001265CC File Offset: 0x001247CC
		private static string[] InitializeExprKindNames()
		{
			string[] names = global::System.Enum.GetNames(typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind));
			names[10] = "/";
			names[33] = "%";
			names[34] = "*";
			names[44] = "+";
			names[32] = "-";
			names[54] = "-";
			names[13] = "=";
			names[28] = "<";
			names[29] = "<=";
			names[18] = ">";
			names[19] = ">=";
			names[37] = "<>";
			names[46] = ".";
			names[21] = "IJ";
			names[16] = "FOJ";
			names[27] = "LOJ";
			names[6] = "CA";
			names[42] = "OA";
			return names;
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x0600527A RID: 21114 RVA: 0x00126689 File Offset: 0x00124889
		internal string Key
		{
			get
			{
				return this._key.ToString();
			}
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x00126696 File Offset: 0x00124896
		private void VisitVariableName(string varName)
		{
			this._key.Append('\'');
			this._key.Append(varName.Replace("'", "''"));
			this._key.Append('\'');
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x001266D0 File Offset: 0x001248D0
		private void VisitBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding)
		{
			this._key.Append("BV");
			this.VisitVariableName(binding.VariableName);
			this._key.Append("=(");
			binding.Expression.Accept(this);
			this._key.Append(')');
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x00126728 File Offset: 0x00124928
		private void VisitGroupBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding groupBinding)
		{
			this._key.Append("GBVV");
			this.VisitVariableName(groupBinding.VariableName);
			this._key.Append(",");
			this.VisitVariableName(groupBinding.GroupVariableName);
			this._key.Append("=(");
			groupBinding.Expression.Accept(this);
			this._key.Append(')');
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x0012679C File Offset: 0x0012499C
		private void VisitFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction func, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args)
		{
			this._key.Append("FUNC<");
			this._key.Append(func.Identity);
			this._key.Append(">:ARGS(");
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in args)
			{
				this._key.Append('(');
				dbExpression.Accept(this);
				this._key.Append(')');
			}
			this._key.Append(')');
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x00126840 File Offset: 0x00124A40
		private void VisitExprKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind)
		{
			this._key.Append('[');
			this._key.Append(global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionKeyGen._exprKindNames[(int)kind]);
			this._key.Append(']');
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x00126871 File Offset: 0x00124A71
		private void VisitUnary(global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression expr)
		{
			this.VisitExprKind(expr.ExpressionKind);
			this._key.Append('(');
			expr.Argument.Accept(this);
			this._key.Append(')');
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x001268A8 File Offset: 0x00124AA8
		private void VisitBinary(global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression expr)
		{
			this.VisitExprKind(expr.ExpressionKind);
			this._key.Append('(');
			expr.Left.Accept(this);
			this._key.Append(',');
			expr.Right.Accept(this);
			this._key.Append(')');
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x00126904 File Offset: 0x00124B04
		private void VisitCastOrTreat(global::System.Data.Entity.Core.Common.CommandTrees.DbUnaryExpression e)
		{
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			e.Argument.Accept(this);
			this._key.Append(":");
			this._key.Append(e.ResultType.Identity);
			this._key.Append(')');
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x0012696D File Offset: 0x00124B6D
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(e, "e");
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Cqt_General_UnsupportedExpression(e.GetType().FullName));
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x00126990 File Offset: 0x00124B90
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>(e, "e");
			switch (((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)global::System.Data.Entity.Core.Common.TypeHelpers.GetPrimitiveTypeUsageForScalar(e.ResultType).EdmType).PrimitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
			{
				byte[] array = e.Value as byte[];
				if (array == null)
				{
					throw new global::System.NotSupportedException();
				}
				this._key.Append("'");
				foreach (byte b in array)
				{
					this._key.AppendFormat("{0:X2}", b);
				}
				this._key.Append("'");
				break;
			}
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
				this._key.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
				{
					e.Value
				});
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
				this._key.Append(((global::System.DateTime)e.Value).ToString("o", global::System.Globalization.CultureInfo.InvariantCulture));
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
			{
				string text = e.Value as string;
				if (text == null)
				{
					throw new global::System.NotSupportedException();
				}
				this._key.Append("'");
				this._key.Append(text.Replace("'", "''"));
				this._key.Append("'");
				break;
			}
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
				this._key.Append(((global::System.DateTimeOffset)e.Value).ToString("o", global::System.Globalization.CultureInfo.InvariantCulture));
				break;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryMultiPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeometryCollection:
			{
				global::System.Data.Entity.Spatial.DbGeometry dbGeometry = e.Value as global::System.Data.Entity.Spatial.DbGeometry;
				if (dbGeometry == null)
				{
					throw new global::System.NotSupportedException();
				}
				this._key.Append(dbGeometry.AsText());
				break;
			}
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPoint:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiLineString:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyMultiPolygon:
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.GeographyCollection:
			{
				global::System.Data.Entity.Spatial.DbGeography dbGeography = e.Value as global::System.Data.Entity.Spatial.DbGeography;
				if (dbGeography == null)
				{
					throw new global::System.NotSupportedException();
				}
				this._key.Append(dbGeography.AsText());
				break;
			}
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId:
			{
				global::System.Data.Entity.Hierarchy.HierarchyId hierarchyId = e.Value as global::System.Data.Entity.Hierarchy.HierarchyId;
				if (!(hierarchyId != null))
				{
					throw new global::System.NotSupportedException();
				}
				this._key.Append(hierarchyId);
				break;
			}
			default:
				throw new global::System.NotSupportedException();
			}
			this._key.Append(":");
			this._key.Append(e.ResultType.Identity);
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x00126C4F File Offset: 0x00124E4F
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression>(e, "e");
			this._key.Append("NULL:");
			this._key.Append(e.ResultType.Identity);
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x00126C85 File Offset: 0x00124E85
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(e, "e");
			this._key.Append("Var(");
			this.VisitVariableName(e.VariableName);
			this._key.Append(")");
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x00126CC4 File Offset: 0x00124EC4
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(e, "e");
			this._key.Append("@");
			this._key.Append(e.ParameterName);
			this._key.Append(":");
			this._key.Append(e.ResultType.Identity);
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x00126D28 File Offset: 0x00124F28
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression>(e, "e");
			this.VisitFunction(e.Function, e.Arguments);
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x00126D48 File Offset: 0x00124F48
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression>(expression, "expression");
			this._key.Append("Lambda(");
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression dbVariableReferenceExpression in expression.Lambda.Variables)
			{
				this._key.Append("(V");
				this.VisitVariableName(dbVariableReferenceExpression.VariableName);
				this._key.Append(":");
				this._key.Append(dbVariableReferenceExpression.ResultType.Identity);
				this._key.Append(')');
			}
			this._key.Append("=");
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in expression.Arguments)
			{
				this._key.Append('(');
				dbExpression.Accept(this);
				this._key.Append(')');
			}
			this._key.Append(")Body(");
			expression.Lambda.Body.Accept(this);
			this._key.Append(")");
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00126EA0 File Offset: 0x001250A0
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression>(e, "e");
			e.Instance.Accept(this);
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append(e.Property.Name);
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00126EDD File Offset: 0x001250DD
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression>(e, "e");
			this.VisitBinary(e);
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00126EF4 File Offset: 0x001250F4
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			e.Argument.Accept(this);
			this._key.Append(")(");
			e.Pattern.Accept(this);
			this._key.Append(")(");
			if (e.Escape != null)
			{
				e.Escape.Accept(this);
			}
			e.Argument.Accept(this);
			this._key.Append(')');
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00126F90 File Offset: 0x00125190
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			if (e.WithTies)
			{
				this._key.Append("WithTies");
			}
			this._key.Append('(');
			e.Argument.Accept(this);
			this._key.Append(")(");
			e.Limit.Accept(this);
			this._key.Append(')');
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x00127013 File Offset: 0x00125213
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression>(e, "e");
			this.VisitUnary(e);
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x00127028 File Offset: 0x00125228
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in e.Arguments)
			{
				this._key.Append('(');
				dbExpression.Accept(this);
				this._key.Append(')');
			}
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x001270A8 File Offset: 0x001252A8
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression>(e, "e");
			this.VisitBinary(e);
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x001270BD File Offset: 0x001252BD
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression>(e, "e");
			this.VisitBinary(e);
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x001270D4 File Offset: 0x001252D4
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			e.Item.Accept(this);
			this._key.Append(",(");
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in e.List)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					this._key.Append(',');
				}
				dbExpression.Accept(this);
			}
			this._key.Append("))");
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x0012718C File Offset: 0x0012538C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression>(e, "e");
			this.VisitUnary(e);
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x001271A1 File Offset: 0x001253A1
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(e, "e");
			this.VisitUnary(e);
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x001271B6 File Offset: 0x001253B6
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(e, "e");
			this.VisitUnary(e);
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x001271CB File Offset: 0x001253CB
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(e, "e");
			this.VisitUnary(e);
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x001271E0 File Offset: 0x001253E0
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(e, "e");
			this.VisitBinary(e);
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x001271F5 File Offset: 0x001253F5
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(e, "e");
			this.VisitBinary(e);
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x0012720A File Offset: 0x0012540A
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(e, "e");
			this.VisitBinary(e);
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x0012721F File Offset: 0x0012541F
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression>(e, "e");
			this.VisitCastOrTreat(e);
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00127234 File Offset: 0x00125434
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression>(e, "e");
			this.VisitCastOrTreat(e);
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x0012724C File Offset: 0x0012544C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			e.Argument.Accept(this);
			this._key.Append(":");
			this._key.Append(e.OfType.EdmType.Identity);
			this._key.Append(')');
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x001272C8 File Offset: 0x001254C8
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			e.Argument.Accept(this);
			this._key.Append(":");
			this._key.Append(e.OfType.EdmType.Identity);
			this._key.Append(')');
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00127344 File Offset: 0x00125544
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			for (int i = 0; i < e.When.Count; i++)
			{
				this._key.Append("WHEN:(");
				e.When[i].Accept(this);
				this._key.Append(")THEN:(");
				e.Then[i].Accept(this);
			}
			this._key.Append("ELSE:(");
			e.Else.Accept(this);
			this._key.Append("))");
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x00127404 File Offset: 0x00125604
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append(':');
			this._key.Append(e.ResultType.EdmType.Identity);
			this._key.Append('(');
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in e.Arguments)
			{
				this._key.Append('(');
				dbExpression.Accept(this);
				this._key.Append(')');
			}
			if (e.HasRelatedEntityReferences)
			{
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef dbRelatedEntityRef in e.RelatedEntityReferences)
				{
					this._key.Append("RE(A(");
					this._key.Append(dbRelatedEntityRef.SourceEnd.DeclaringType.Identity);
					this._key.Append(")(");
					this._key.Append(dbRelatedEntityRef.SourceEnd.Name);
					this._key.Append("->");
					this._key.Append(dbRelatedEntityRef.TargetEnd.Name);
					this._key.Append(")(");
					dbRelatedEntityRef.TargetEntityReference.Accept(this);
					this._key.Append("))");
				}
			}
			this._key.Append(')');
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x001275BC File Offset: 0x001257BC
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append("(ESET(");
			this._key.Append(e.EntitySet.EntityContainer.Name);
			this._key.Append('.');
			this._key.Append(e.EntitySet.Name);
			this._key.Append(")T(");
			this._key.Append(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(e.ResultType).ElementType.FullName);
			this._key.Append(")(");
			e.Argument.Accept(this);
			this._key.Append(')');
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x00127690 File Offset: 0x00125890
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			e.NavigationSource.Accept(this);
			this._key.Append(")A(");
			this._key.Append(e.NavigateFrom.DeclaringType.Identity);
			this._key.Append(")(");
			this._key.Append(e.NavigateFrom.Name);
			this._key.Append("->");
			this._key.Append(e.NavigateTo.Name);
			this._key.Append("))");
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x0012775D File Offset: 0x0012595D
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression>(e, "e");
			this.VisitUnary(e);
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00127772 File Offset: 0x00125972
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression>(e, "e");
			this.VisitUnary(e);
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x00127787 File Offset: 0x00125987
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression>(e, "e");
			this.VisitUnary(e);
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x0012779C File Offset: 0x0012599C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			this._key.Append(e.Target.EntityContainer.Name);
			this._key.Append('.');
			this._key.Append(e.Target.Name);
			this._key.Append(':');
			this._key.Append(e.ResultType.EdmType.Identity);
			this._key.Append(')');
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x00127848 File Offset: 0x00125A48
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			this.VisitBinding(e.Input);
			this._key.Append('(');
			e.Predicate.Accept(this);
			this._key.Append("))");
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x001278B4 File Offset: 0x00125AB4
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			this.VisitBinding(e.Input);
			this._key.Append('(');
			e.Projection.Accept(this);
			this._key.Append("))");
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x00127920 File Offset: 0x00125B20
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding binding in e.Inputs)
			{
				this.VisitBinding(binding);
			}
			this._key.Append(')');
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x001279A4 File Offset: 0x00125BA4
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			this.VisitBinding(e.Left);
			this.VisitBinding(e.Right);
			this._key.Append('(');
			e.JoinCondition.Accept(this);
			this._key.Append("))");
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x00127A1C File Offset: 0x00125C1C
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			this.VisitBinding(e.Input);
			this.VisitBinding(e.Apply);
			this._key.Append(')');
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x00127A78 File Offset: 0x00125C78
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			this.VisitGroupBinding(e.Input);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression in e.Keys)
			{
				this._key.Append("K(");
				dbExpression.Accept(this);
				this._key.Append(')');
			}
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate dbAggregate in e.Aggregates)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate dbGroupAggregate = dbAggregate as global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate;
				if (dbGroupAggregate != null)
				{
					this._key.Append("GA(");
					dbGroupAggregate.Arguments[0].Accept(this);
					this._key.Append(')');
				}
				else
				{
					this._key.Append("A:");
					global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate dbFunctionAggregate = (global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate)dbAggregate;
					if (dbFunctionAggregate.Distinct)
					{
						this._key.Append("D:");
					}
					this.VisitFunction(dbFunctionAggregate.Function, dbFunctionAggregate.Arguments);
				}
			}
			this._key.Append(')');
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x00127BE4 File Offset: 0x00125DE4
		private void VisitSortOrder(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder)
		{
			this._key.Append("SO(");
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause in sortOrder)
			{
				this._key.Append(dbSortClause.Ascending ? "ASC(" : "DESC(");
				dbSortClause.Expression.Accept(this);
				this._key.Append(')');
				if (!string.IsNullOrEmpty(dbSortClause.Collation))
				{
					this._key.Append(":(");
					this._key.Append(dbSortClause.Collation);
					this._key.Append(')');
				}
			}
			this._key.Append(')');
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x00127CC0 File Offset: 0x00125EC0
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			this.VisitBinding(e.Input);
			this.VisitSortOrder(e.SortOrder);
			this._key.Append('(');
			e.Count.Accept(this);
			this._key.Append("))");
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x00127D38 File Offset: 0x00125F38
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			this.VisitBinding(e.Input);
			this.VisitSortOrder(e.SortOrder);
			this._key.Append(')');
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x00127D94 File Offset: 0x00125F94
		public override void Visit(global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression e)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression>(e, "e");
			this.VisitExprKind(e.ExpressionKind);
			this._key.Append('(');
			this.VisitBinding(e.Input);
			this._key.Append('(');
			e.Predicate.Accept(this);
			this._key.Append("))");
		}

		// Token: 0x04001DE4 RID: 7652
		private readonly global::System.Text.StringBuilder _key = new global::System.Text.StringBuilder();

		// Token: 0x04001DE5 RID: 7653
		private static readonly string[] _exprKindNames = global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionKeyGen.InitializeExprKindNames();
	}
}
