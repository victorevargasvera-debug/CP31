using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006AE RID: 1710
	public class DbConstantExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x06005035 RID: 20533 RVA: 0x00121141 File Offset: 0x0011F341
		internal DbConstantExpression()
		{
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x0012114C File Offset: 0x0011F34C
		internal DbConstantExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, object value) : base(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant, resultType, true)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
			this._shouldCloneValue = (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(resultType, out primitiveType) && primitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary);
			if (this._shouldCloneValue)
			{
				this._value = ((byte[])value).Clone();
				return;
			}
			this._value = value;
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x0012119F File Offset: 0x0011F39F
		internal object GetValue()
		{
			return this._value;
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06005038 RID: 20536 RVA: 0x001211A7 File Offset: 0x0011F3A7
		public virtual object Value
		{
			get
			{
				if (this._shouldCloneValue)
				{
					return ((byte[])this._value).Clone();
				}
				return this._value;
			}
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x001211C8 File Offset: 0x0011F3C8
		public override void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor>(visitor, "visitor");
			visitor.Visit(this);
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x001211DD File Offset: 0x0011F3DD
		public override TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType>>(visitor, "visitor");
			return visitor.Visit(this);
		}

		// Token: 0x04001D51 RID: 7505
		private readonly bool _shouldCloneValue;

		// Token: 0x04001D52 RID: 7506
		private readonly object _value;
	}
}
