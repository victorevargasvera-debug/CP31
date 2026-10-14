using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005A0 RID: 1440
	internal abstract class Constant : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x060045E0 RID: 17888
		internal abstract bool IsNull();

		// Token: 0x060045E1 RID: 17889
		internal abstract bool IsNotNull();

		// Token: 0x060045E2 RID: 17890
		internal abstract bool IsUndefined();

		// Token: 0x060045E3 RID: 17891
		internal abstract bool HasNotNull();

		// Token: 0x060045E4 RID: 17892
		internal abstract global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias);

		// Token: 0x060045E5 RID: 17893
		internal abstract global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember);

		// Token: 0x060045E6 RID: 17894 RVA: 0x000F58A4 File Offset: 0x000F3AA4
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant = obj as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant;
			return constant != null && this.IsEqualTo(constant);
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x000F58C4 File Offset: 0x000F3AC4
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060045E8 RID: 17896
		protected abstract bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant right);

		// Token: 0x060045E9 RID: 17897
		internal abstract string ToUserString();

		// Token: 0x060045EA RID: 17898 RVA: 0x000F58CC File Offset: 0x000F3ACC
		internal static void ConstantsToUserString(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> constants)
		{
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in constants)
			{
				if (!flag)
				{
					builder.Append(global::System.Data.Entity.Resources.Strings.ViewGen_CommaBlank);
				}
				flag = false;
				string value = constant.ToUserString();
				builder.Append(value);
			}
		}

		// Token: 0x04001904 RID: 6404
		internal static readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> EqualityComparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.CellConstantComparer();

		// Token: 0x04001905 RID: 6405
		internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant Null = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NullConstant.Instance;

		// Token: 0x04001906 RID: 6406
		internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant NotNull = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.NegatedConstant(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant[]
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NullConstant.Instance
		});

		// Token: 0x04001907 RID: 6407
		internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant Undefined = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.UndefinedConstant.Instance;

		// Token: 0x04001908 RID: 6408
		internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant AllOtherConstants = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.AllOtherConstantsConstant.Instance;

		// Token: 0x02000BC5 RID: 3013
		private class CellConstantComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>
		{
			// Token: 0x060067E3 RID: 26595 RVA: 0x00161F37 File Offset: 0x00160137
			public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant left, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant right)
			{
				return left == right || (left != null && right != null && left.IsEqualTo(right));
			}

			// Token: 0x060067E4 RID: 26596 RVA: 0x00161F4E File Offset: 0x0016014E
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant key)
			{
				return key.GetHashCode();
			}
		}

		// Token: 0x02000BC6 RID: 3014
		private sealed class NullConstant : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant
		{
			// Token: 0x060067E6 RID: 26598 RVA: 0x00161F5E File Offset: 0x0016015E
			private NullConstant()
			{
			}

			// Token: 0x060067E7 RID: 26599 RVA: 0x00161F66 File Offset: 0x00160166
			internal override bool IsNull()
			{
				return true;
			}

			// Token: 0x060067E8 RID: 26600 RVA: 0x00161F69 File Offset: 0x00160169
			internal override bool IsNotNull()
			{
				return false;
			}

			// Token: 0x060067E9 RID: 26601 RVA: 0x00161F6C File Offset: 0x0016016C
			internal override bool IsUndefined()
			{
				return false;
			}

			// Token: 0x060067EA RID: 26602 RVA: 0x00161F6F File Offset: 0x0016016F
			internal override bool HasNotNull()
			{
				return false;
			}

			// Token: 0x060067EB RID: 26603 RVA: 0x00161F74 File Offset: 0x00160174
			internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(outputMember.LeafEdmMember).EdmType;
				builder.Append("CAST(NULL AS ");
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedTypeName(builder, edmType);
				builder.Append(')');
				return builder;
			}

			// Token: 0x060067EC RID: 26604 RVA: 0x00161FAF File Offset: 0x001601AF
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(outputMember.LeafEdmMember).EdmType).Null();
			}

			// Token: 0x060067ED RID: 26605 RVA: 0x00161FCB File Offset: 0x001601CB
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x060067EE RID: 26606 RVA: 0x00161FCE File Offset: 0x001601CE
			protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant right)
			{
				return this == right;
			}

			// Token: 0x060067EF RID: 26607 RVA: 0x00161FD4 File Offset: 0x001601D4
			internal override string ToUserString()
			{
				return global::System.Data.Entity.Resources.Strings.ViewGen_Null;
			}

			// Token: 0x060067F0 RID: 26608 RVA: 0x00161FDB File Offset: 0x001601DB
			internal override void ToCompactString(global::System.Text.StringBuilder builder)
			{
				builder.Append("NULL");
			}

			// Token: 0x04002EB3 RID: 11955
			internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant Instance = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.NullConstant();
		}

		// Token: 0x02000BC7 RID: 3015
		private sealed class UndefinedConstant : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant
		{
			// Token: 0x060067F2 RID: 26610 RVA: 0x00161FF5 File Offset: 0x001601F5
			private UndefinedConstant()
			{
			}

			// Token: 0x060067F3 RID: 26611 RVA: 0x00161FFD File Offset: 0x001601FD
			internal override bool IsNull()
			{
				return false;
			}

			// Token: 0x060067F4 RID: 26612 RVA: 0x00162000 File Offset: 0x00160200
			internal override bool IsNotNull()
			{
				return false;
			}

			// Token: 0x060067F5 RID: 26613 RVA: 0x00162003 File Offset: 0x00160203
			internal override bool IsUndefined()
			{
				return true;
			}

			// Token: 0x060067F6 RID: 26614 RVA: 0x00162006 File Offset: 0x00160206
			internal override bool HasNotNull()
			{
				return false;
			}

			// Token: 0x060067F7 RID: 26615 RVA: 0x00162009 File Offset: 0x00160209
			internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x060067F8 RID: 26616 RVA: 0x00162010 File Offset: 0x00160210
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x060067F9 RID: 26617 RVA: 0x00162017 File Offset: 0x00160217
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x060067FA RID: 26618 RVA: 0x0016201A File Offset: 0x0016021A
			protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant right)
			{
				return this == right;
			}

			// Token: 0x060067FB RID: 26619 RVA: 0x00162020 File Offset: 0x00160220
			internal override string ToUserString()
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x060067FC RID: 26620 RVA: 0x00162027 File Offset: 0x00160227
			internal override void ToCompactString(global::System.Text.StringBuilder builder)
			{
				builder.Append("?");
			}

			// Token: 0x04002EB4 RID: 11956
			internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant Instance = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.UndefinedConstant();
		}

		// Token: 0x02000BC8 RID: 3016
		private sealed class AllOtherConstantsConstant : global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant
		{
			// Token: 0x060067FE RID: 26622 RVA: 0x00162041 File Offset: 0x00160241
			private AllOtherConstantsConstant()
			{
			}

			// Token: 0x060067FF RID: 26623 RVA: 0x00162049 File Offset: 0x00160249
			internal override bool IsNull()
			{
				return false;
			}

			// Token: 0x06006800 RID: 26624 RVA: 0x0016204C File Offset: 0x0016024C
			internal override bool IsNotNull()
			{
				return false;
			}

			// Token: 0x06006801 RID: 26625 RVA: 0x0016204F File Offset: 0x0016024F
			internal override bool IsUndefined()
			{
				return false;
			}

			// Token: 0x06006802 RID: 26626 RVA: 0x00162052 File Offset: 0x00160252
			internal override bool HasNotNull()
			{
				return false;
			}

			// Token: 0x06006803 RID: 26627 RVA: 0x00162055 File Offset: 0x00160255
			internal override global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder builder, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember, string blockAlias)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x06006804 RID: 26628 RVA: 0x0016205C File Offset: 0x0016025C
			internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath outputMember)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x06006805 RID: 26629 RVA: 0x00162063 File Offset: 0x00160263
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06006806 RID: 26630 RVA: 0x00162066 File Offset: 0x00160266
			protected override bool IsEqualTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant right)
			{
				return this == right;
			}

			// Token: 0x06006807 RID: 26631 RVA: 0x0016206C File Offset: 0x0016026C
			internal override string ToUserString()
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x06006808 RID: 26632 RVA: 0x00162073 File Offset: 0x00160273
			internal override void ToCompactString(global::System.Text.StringBuilder builder)
			{
				builder.Append("AllOtherConstants");
			}

			// Token: 0x04002EB5 RID: 11957
			internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant Instance = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.AllOtherConstantsConstant();
		}
	}
}
