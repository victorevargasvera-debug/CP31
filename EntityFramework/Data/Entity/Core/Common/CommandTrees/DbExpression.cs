using System;
using System.ComponentModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Globalization;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006B6 RID: 1718
	public abstract class DbExpression
	{
		// Token: 0x06005057 RID: 20567 RVA: 0x001213BA File Offset: 0x0011F5BA
		internal DbExpression()
		{
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x001213C4 File Offset: 0x0011F5C4
		internal DbExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, bool forceNullable = true)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.CheckExpressionKind(kind);
			this._kind = kind;
			if (forceNullable && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNullable(type))
			{
				type = type.ShallowCopy(new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
				{
					Nullable = new bool?(true)
				});
			}
			this._type = type;
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06005059 RID: 20569 RVA: 0x00121414 File Offset: 0x0011F614
		public virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ResultType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x0600505A RID: 20570 RVA: 0x0012141C File Offset: 0x0011F61C
		public virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind ExpressionKind
		{
			get
			{
				return this._kind;
			}
		}

		// Token: 0x0600505B RID: 20571
		public abstract void Accept(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor visitor);

		// Token: 0x0600505C RID: 20572
		public abstract TResultType Accept<TResultType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor);

		// Token: 0x0600505D RID: 20573 RVA: 0x00121424 File Offset: 0x0011F624
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x0012142D File Offset: 0x0011F62D
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x00121435 File Offset: 0x0011F635
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromBinary(byte[] value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value);
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x00121447 File Offset: 0x0011F647
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(byte[] value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromBinary(value);
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x0012144F File Offset: 0x0011F64F
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromBoolean(bool? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean);
			}
			if (!value.Value)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.False;
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.True;
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x00121475 File Offset: 0x0011F675
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(bool? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromBoolean(value);
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x0012147D File Offset: 0x0011F67D
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromByte(byte? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value.Value);
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x001214A0 File Offset: 0x0011F6A0
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(byte? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromByte(value);
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x001214A8 File Offset: 0x0011F6A8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromDateTime(global::System.DateTime? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value.Value);
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x001214CB File Offset: 0x0011F6CB
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(global::System.DateTime? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromDateTime(value);
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x001214D3 File Offset: 0x0011F6D3
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromDateTimeOffset(global::System.DateTimeOffset? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value.Value);
		}

		// Token: 0x06005068 RID: 20584 RVA: 0x001214F7 File Offset: 0x0011F6F7
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(global::System.DateTimeOffset? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromDateTimeOffset(value);
		}

		// Token: 0x06005069 RID: 20585 RVA: 0x001214FF File Offset: 0x0011F6FF
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromDecimal(decimal? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value.Value);
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x00121522 File Offset: 0x0011F722
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(decimal? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromDecimal(value);
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x0012152A File Offset: 0x0011F72A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromDouble(double? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value.Value);
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x0012154D File Offset: 0x0011F74D
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(double? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromDouble(value);
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00121555 File Offset: 0x0011F755
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromGeography(global::System.Data.Entity.Spatial.DbGeography value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value);
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x00121568 File Offset: 0x0011F768
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(global::System.Data.Entity.Spatial.DbGeography value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromGeography(value);
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x00121570 File Offset: 0x0011F770
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromGeometry(global::System.Data.Entity.Spatial.DbGeometry value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value);
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x00121583 File Offset: 0x0011F783
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(global::System.Data.Entity.Spatial.DbGeometry value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromGeometry(value);
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x0012158B File Offset: 0x0011F78B
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromGuid(global::System.Guid? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value.Value);
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x001215AE File Offset: 0x0011F7AE
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(global::System.Guid? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromGuid(value);
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x001215B6 File Offset: 0x0011F7B6
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromInt16(short? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value.Value);
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x001215DA File Offset: 0x0011F7DA
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(short? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromInt16(value);
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x001215E2 File Offset: 0x0011F7E2
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromInt32(int? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value.Value);
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00121606 File Offset: 0x0011F806
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(int? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromInt32(value);
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x0012160E File Offset: 0x0011F80E
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromInt64(long? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value.Value);
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00121632 File Offset: 0x0011F832
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(long? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromInt64(value);
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x0012163A File Offset: 0x0011F83A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromSingle(float? value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value.Value);
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x0012165D File Offset: 0x0011F85D
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(float? value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromSingle(value);
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x00121665 File Offset: 0x0011F865
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression FromString(string value)
		{
			if (value == null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(value);
		}

		// Token: 0x0600507C RID: 20604 RVA: 0x00121678 File Offset: 0x0011F878
		public static implicit operator global::System.Data.Entity.Core.Common.CommandTrees.DbExpression(string value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbExpression.FromString(value);
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00121680 File Offset: 0x0011F880
		internal static void CheckExpressionKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind)
		{
			if (kind < global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.All || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKindHelper.Last < kind)
			{
				string name = typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind).Name;
				int num = (int)kind;
				throw new global::System.ArgumentOutOfRangeException(name, global::System.Data.Entity.Resources.Strings.ADP_InvalidEnumerationValue(name, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
		}

		// Token: 0x04001D56 RID: 7510
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _type;

		// Token: 0x04001D57 RID: 7511
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind _kind;
	}
}
