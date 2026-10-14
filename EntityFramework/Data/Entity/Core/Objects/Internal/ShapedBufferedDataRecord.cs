using System;
using System.Collections;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000457 RID: 1111
	internal class ShapedBufferedDataRecord : global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord
	{
		// Token: 0x0600363F RID: 13887 RVA: 0x000AE250 File Offset: 0x000AC450
		protected ShapedBufferedDataRecord()
		{
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x000AE260 File Offset: 0x000AC460
		internal static global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord Initialize(string providerManifestToken, global::System.Data.Entity.Core.Common.DbProviderServices providerServices, global::System.Data.Common.DbDataReader reader, global::System.Type[] columnTypes, bool[] nullableColumns)
		{
			global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord shapedBufferedDataRecord = new global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord();
			shapedBufferedDataRecord.ReadMetadata(providerManifestToken, providerServices, reader);
			global::System.Data.Entity.Spatial.DbSpatialDataReader spatialDataReader = null;
			if (columnTypes.Any((global::System.Type t) => t == typeof(global::System.Data.Entity.Spatial.DbGeography) || t == typeof(global::System.Data.Entity.Spatial.DbGeometry)))
			{
				spatialDataReader = providerServices.GetSpatialDataReader(reader, providerManifestToken);
			}
			return shapedBufferedDataRecord.Initialize(reader, spatialDataReader, columnTypes, nullableColumns);
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x000AE2B8 File Offset: 0x000AC4B8
		internal static global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord> InitializeAsync(string providerManifestToken, global::System.Data.Entity.Core.Common.DbProviderServices providerServices, global::System.Data.Common.DbDataReader reader, global::System.Type[] columnTypes, bool[] nullableColumns, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord shapedBufferedDataRecord = new global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord();
			shapedBufferedDataRecord.ReadMetadata(providerManifestToken, providerServices, reader);
			global::System.Data.Entity.Spatial.DbSpatialDataReader spatialDataReader = null;
			if (columnTypes.Any((global::System.Type t) => t == typeof(global::System.Data.Entity.Spatial.DbGeography) || t == typeof(global::System.Data.Entity.Spatial.DbGeometry)))
			{
				spatialDataReader = providerServices.GetSpatialDataReader(reader, providerManifestToken);
			}
			return shapedBufferedDataRecord.InitializeAsync(reader, spatialDataReader, columnTypes, nullableColumns, cancellationToken);
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x000AE318 File Offset: 0x000AC518
		private global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord Initialize(global::System.Data.Common.DbDataReader reader, global::System.Data.Entity.Spatial.DbSpatialDataReader spatialDataReader, global::System.Type[] columnTypes, bool[] nullableColumns)
		{
			this.InitializeFields(columnTypes, nullableColumns);
			while (reader.Read())
			{
				this._currentRowNumber++;
				if (this._rowCapacity == this._currentRowNumber)
				{
					this.DoubleBufferCapacity();
				}
				int num = global::System.Math.Max(columnTypes.Length, nullableColumns.Length);
				for (int i = 0; i < num; i++)
				{
					if (i < this._columnTypeCases.Length)
					{
						switch (this._columnTypeCases[i])
						{
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Empty:
							if (nullableColumns[i])
							{
								this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Bool:
							if (!nullableColumns[i])
							{
								this.ReadBool(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadBool(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Byte:
							if (!nullableColumns[i])
							{
								this.ReadByte(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadByte(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Char:
							if (!nullableColumns[i])
							{
								this.ReadChar(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadChar(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DateTime:
							if (!nullableColumns[i])
							{
								this.ReadDateTime(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadDateTime(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Decimal:
							if (!nullableColumns[i])
							{
								this.ReadDecimal(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadDecimal(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Double:
							if (!nullableColumns[i])
							{
								this.ReadDouble(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadDouble(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Float:
							if (!nullableColumns[i])
							{
								this.ReadFloat(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadFloat(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Guid:
							if (!nullableColumns[i])
							{
								this.ReadGuid(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadGuid(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Short:
							if (!nullableColumns[i])
							{
								this.ReadShort(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadShort(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Int:
							if (!nullableColumns[i])
							{
								this.ReadInt(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadInt(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Long:
							if (!nullableColumns[i])
							{
								this.ReadLong(reader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadLong(reader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DbGeography:
							if (!nullableColumns[i])
							{
								this.ReadGeography(spatialDataReader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadGeography(spatialDataReader, i);
								goto IL_51A;
							}
							goto IL_51A;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DbGeometry:
							if (!nullableColumns[i])
							{
								this.ReadGeometry(spatialDataReader, i);
								goto IL_51A;
							}
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadGeometry(spatialDataReader, i);
								goto IL_51A;
							}
							goto IL_51A;
						}
						if (nullableColumns[i])
						{
							if (!(this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i)))
							{
								this.ReadObject(reader, i);
							}
						}
						else
						{
							this.ReadObject(reader, i);
						}
					}
					else if (nullableColumns[i])
					{
						this._tempNulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i]] = reader.IsDBNull(i);
					}
					IL_51A:;
				}
			}
			this._bools = new global::System.Collections.BitArray(this._tempBools);
			this._tempBools = null;
			this._nulls = new global::System.Collections.BitArray(this._tempNulls);
			this._tempNulls = null;
			this._rowCount = this._currentRowNumber + 1;
			this._currentRowNumber = -1;
			return this;
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x000AE89C File Offset: 0x000ACA9C
		private async global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord> InitializeAsync(global::System.Data.Common.DbDataReader reader, global::System.Data.Entity.Spatial.DbSpatialDataReader spatialDataReader, global::System.Type[] columnTypes, bool[] nullableColumns, global::System.Threading.CancellationToken cancellationToken)
		{
			this.InitializeFields(columnTypes, nullableColumns);
			for (;;)
			{
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = reader.ReadAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (!cultureAwaiter.GetResult())
				{
					break;
				}
				cancellationToken.ThrowIfCancellationRequested();
				this._currentRowNumber++;
				if (this._rowCapacity == this._currentRowNumber)
				{
					this.DoubleBufferCapacity();
				}
				int columnCount = (columnTypes.Length > nullableColumns.Length) ? columnTypes.Length : nullableColumns.Length;
				int num;
				for (int i = 0; i < columnCount; i = num + 1)
				{
					if (i < this._columnTypeCases.Length)
					{
						switch (this._columnTypeCases[i])
						{
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Empty:
							if (nullableColumns[i])
							{
								bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
								bool[] tempNulls = this._tempNulls;
								num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
								tempNulls[num] = flag;
								goto IL_1B66;
							}
							goto IL_1B66;
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Bool:
						{
							if (!nullableColumns[i])
							{
								await this.ReadBoolAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls2 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num2 = num;
							bool flag2 = flag;
							tempNulls2[num2] = flag2;
							if (!flag2)
							{
								await this.ReadBoolAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Byte:
						{
							if (!nullableColumns[i])
							{
								await this.ReadByteAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls3 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num3 = num;
							bool flag3 = flag;
							tempNulls3[num3] = flag3;
							if (!flag3)
							{
								await this.ReadByteAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Char:
						{
							if (!nullableColumns[i])
							{
								await this.ReadCharAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls4 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num4 = num;
							bool flag4 = flag;
							tempNulls4[num4] = flag4;
							if (!flag4)
							{
								await this.ReadCharAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DateTime:
						{
							if (!nullableColumns[i])
							{
								await this.ReadDateTimeAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls5 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num5 = num;
							bool flag5 = flag;
							tempNulls5[num5] = flag5;
							if (!flag5)
							{
								await this.ReadDateTimeAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Decimal:
						{
							if (!nullableColumns[i])
							{
								await this.ReadDecimalAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls6 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num6 = num;
							bool flag6 = flag;
							tempNulls6[num6] = flag6;
							if (!flag6)
							{
								await this.ReadDecimalAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Double:
						{
							if (!nullableColumns[i])
							{
								await this.ReadDoubleAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls7 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num7 = num;
							bool flag7 = flag;
							tempNulls7[num7] = flag7;
							if (!flag7)
							{
								await this.ReadDoubleAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Float:
						{
							if (!nullableColumns[i])
							{
								await this.ReadFloatAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls8 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num8 = num;
							bool flag8 = flag;
							tempNulls8[num8] = flag8;
							if (!flag8)
							{
								await this.ReadFloatAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Guid:
						{
							if (!nullableColumns[i])
							{
								await this.ReadGuidAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls9 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num9 = num;
							bool flag9 = flag;
							tempNulls9[num9] = flag9;
							if (!flag9)
							{
								await this.ReadGuidAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Short:
						{
							if (!nullableColumns[i])
							{
								await this.ReadShortAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls10 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num10 = num;
							bool flag10 = flag;
							tempNulls10[num10] = flag10;
							if (!flag10)
							{
								await this.ReadShortAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Int:
						{
							if (!nullableColumns[i])
							{
								await this.ReadIntAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls11 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num11 = num;
							bool flag11 = flag;
							tempNulls11[num11] = flag11;
							if (!flag11)
							{
								await this.ReadIntAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Long:
						{
							if (!nullableColumns[i])
							{
								await this.ReadLongAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls12 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num12 = num;
							bool flag12 = flag;
							tempNulls12[num12] = flag12;
							if (!flag12)
							{
								await this.ReadLongAsync(reader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DbGeography:
						{
							if (!nullableColumns[i])
							{
								await this.ReadGeographyAsync(spatialDataReader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls13 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num13 = num;
							bool flag13 = flag;
							tempNulls13[num13] = flag13;
							if (!flag13)
							{
								await this.ReadGeographyAsync(spatialDataReader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DbGeometry:
						{
							if (!nullableColumns[i])
							{
								await this.ReadGeometryAsync(spatialDataReader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls14 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num14 = num;
							bool flag14 = flag;
							tempNulls14[num14] = flag14;
							if (!flag14)
							{
								await this.ReadGeometryAsync(spatialDataReader, i, cancellationToken).WithCurrentCulture();
								goto IL_1B66;
							}
							goto IL_1B66;
						}
						}
						if (nullableColumns[i])
						{
							bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
							bool[] tempNulls15 = this._tempNulls;
							num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
							int num15 = num;
							bool flag15 = flag;
							tempNulls15[num15] = flag15;
							if (!flag15)
							{
								await this.ReadObjectAsync(reader, i, cancellationToken).WithCurrentCulture();
							}
						}
						else
						{
							await this.ReadObjectAsync(reader, i, cancellationToken).WithCurrentCulture();
						}
					}
					else if (nullableColumns[i])
					{
						bool flag = await reader.IsDBNullAsync(i, cancellationToken).WithCurrentCulture<bool>();
						bool[] tempNulls16 = this._tempNulls;
						num = this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[i];
						tempNulls16[num] = flag;
					}
					IL_1B66:
					num = i;
				}
			}
			this._bools = new global::System.Collections.BitArray(this._tempBools);
			this._tempBools = null;
			this._nulls = new global::System.Collections.BitArray(this._tempNulls);
			this._tempNulls = null;
			this._rowCount = this._currentRowNumber + 1;
			this._currentRowNumber = -1;
			return this;
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x000AE90C File Offset: 0x000ACB0C
		private void InitializeFields(global::System.Type[] columnTypes, bool[] nullableColumns)
		{
			this._columnTypeCases = global::System.Linq.Enumerable.Repeat<global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase>(global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Empty, columnTypes.Length).ToArray<global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase>();
			int count = global::System.Math.Max(base.FieldCount, global::System.Math.Max(columnTypes.Length, nullableColumns.Length));
			this._ordinalToIndexMap = global::System.Linq.Enumerable.Repeat<int>(-1, count).ToArray<int>();
			for (int i = 0; i < columnTypes.Length; i++)
			{
				global::System.Type left = columnTypes[i];
				if (!(left == null))
				{
					if (left == typeof(bool))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Bool;
						this._ordinalToIndexMap[i] = this._boolCount;
						this._boolCount++;
					}
					else if (left == typeof(byte))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Byte;
						this._ordinalToIndexMap[i] = this._byteCount;
						this._byteCount++;
					}
					else if (left == typeof(char))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Char;
						this._ordinalToIndexMap[i] = this._charCount;
						this._charCount++;
					}
					else if (left == typeof(global::System.DateTime))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DateTime;
						this._ordinalToIndexMap[i] = this._dateTimeCount;
						this._dateTimeCount++;
					}
					else if (left == typeof(decimal))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Decimal;
						this._ordinalToIndexMap[i] = this._decimalCount;
						this._decimalCount++;
					}
					else if (left == typeof(double))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Double;
						this._ordinalToIndexMap[i] = this._doubleCount;
						this._doubleCount++;
					}
					else if (left == typeof(float))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Float;
						this._ordinalToIndexMap[i] = this._floatCount;
						this._floatCount++;
					}
					else if (left == typeof(global::System.Guid))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Guid;
						this._ordinalToIndexMap[i] = this._guidCount;
						this._guidCount++;
					}
					else if (left == typeof(short))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Short;
						this._ordinalToIndexMap[i] = this._shortCount;
						this._shortCount++;
					}
					else if (left == typeof(int))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Int;
						this._ordinalToIndexMap[i] = this._intCount;
						this._intCount++;
					}
					else if (left == typeof(long))
					{
						this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Long;
						this._ordinalToIndexMap[i] = this._longCount;
						this._longCount++;
					}
					else
					{
						if (left == typeof(global::System.Data.Entity.Spatial.DbGeography))
						{
							this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DbGeography;
						}
						else if (left == typeof(global::System.Data.Entity.Spatial.DbGeometry))
						{
							this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DbGeometry;
						}
						else
						{
							this._columnTypeCases[i] = global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Object;
						}
						this._ordinalToIndexMap[i] = this._objectCount;
						this._objectCount++;
					}
				}
			}
			this._tempBools = new bool[this._rowCapacity * this._boolCount];
			this._bytes = new byte[this._rowCapacity * this._byteCount];
			this._chars = new char[this._rowCapacity * this._charCount];
			this._dateTimes = new global::System.DateTime[this._rowCapacity * this._dateTimeCount];
			this._decimals = new decimal[this._rowCapacity * this._decimalCount];
			this._doubles = new double[this._rowCapacity * this._doubleCount];
			this._floats = new float[this._rowCapacity * this._floatCount];
			this._guids = new global::System.Guid[this._rowCapacity * this._guidCount];
			this._shorts = new short[this._rowCapacity * this._shortCount];
			this._ints = new int[this._rowCapacity * this._intCount];
			this._longs = new long[this._rowCapacity * this._longCount];
			this._objects = new object[this._rowCapacity * this._objectCount];
			this._nullOrdinalToIndexMap = global::System.Linq.Enumerable.Repeat<int>(-1, count).ToArray<int>();
			for (int j = 0; j < nullableColumns.Length; j++)
			{
				if (nullableColumns[j])
				{
					this._nullOrdinalToIndexMap[j] = this._nullCount;
					this._nullCount++;
				}
			}
			this._tempNulls = new bool[this._rowCapacity * this._nullCount];
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x000AEDEC File Offset: 0x000ACFEC
		private void DoubleBufferCapacity()
		{
			this._rowCapacity <<= 1;
			bool[] array = new bool[this._tempBools.Length << 1];
			global::System.Array.Copy(this._tempBools, array, this._tempBools.Length);
			this._tempBools = array;
			byte[] array2 = new byte[this._bytes.Length << 1];
			global::System.Array.Copy(this._bytes, array2, this._bytes.Length);
			this._bytes = array2;
			char[] array3 = new char[this._chars.Length << 1];
			global::System.Array.Copy(this._chars, array3, this._chars.Length);
			this._chars = array3;
			global::System.DateTime[] array4 = new global::System.DateTime[this._dateTimes.Length << 1];
			global::System.Array.Copy(this._dateTimes, array4, this._dateTimes.Length);
			this._dateTimes = array4;
			decimal[] array5 = new decimal[this._decimals.Length << 1];
			global::System.Array.Copy(this._decimals, array5, this._decimals.Length);
			this._decimals = array5;
			double[] array6 = new double[this._doubles.Length << 1];
			global::System.Array.Copy(this._doubles, array6, this._doubles.Length);
			this._doubles = array6;
			float[] array7 = new float[this._floats.Length << 1];
			global::System.Array.Copy(this._floats, array7, this._floats.Length);
			this._floats = array7;
			global::System.Guid[] array8 = new global::System.Guid[this._guids.Length << 1];
			global::System.Array.Copy(this._guids, array8, this._guids.Length);
			this._guids = array8;
			short[] array9 = new short[this._shorts.Length << 1];
			global::System.Array.Copy(this._shorts, array9, this._shorts.Length);
			this._shorts = array9;
			int[] array10 = new int[this._ints.Length << 1];
			global::System.Array.Copy(this._ints, array10, this._ints.Length);
			this._ints = array10;
			long[] array11 = new long[this._longs.Length << 1];
			global::System.Array.Copy(this._longs, array11, this._longs.Length);
			this._longs = array11;
			object[] array12 = new object[this._objects.Length << 1];
			global::System.Array.Copy(this._objects, array12, this._objects.Length);
			this._objects = array12;
			bool[] array13 = new bool[this._tempNulls.Length << 1];
			global::System.Array.Copy(this._tempNulls, array13, this._tempNulls.Length);
			this._tempNulls = array13;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x000AF051 File Offset: 0x000AD251
		private void ReadBool(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._tempBools[this._currentRowNumber * this._boolCount + this._ordinalToIndexMap[ordinal]] = reader.GetBoolean(ordinal);
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x000AF078 File Offset: 0x000AD278
		private async global::System.Threading.Tasks.Task ReadBoolAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			bool flag = await reader.GetFieldValueAsync<bool>(ordinal, cancellationToken).WithCurrentCulture<bool>();
			bool[] tempBools = this._tempBools;
			int num = this._currentRowNumber * this._boolCount + this._ordinalToIndexMap[ordinal];
			tempBools[num] = flag;
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x000AF0D5 File Offset: 0x000AD2D5
		private void ReadByte(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._bytes[this._currentRowNumber * this._byteCount + this._ordinalToIndexMap[ordinal]] = reader.GetByte(ordinal);
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x000AF0FC File Offset: 0x000AD2FC
		private async global::System.Threading.Tasks.Task ReadByteAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			byte b = await reader.GetFieldValueAsync<byte>(ordinal, cancellationToken).WithCurrentCulture<byte>();
			byte[] bytes = this._bytes;
			int num = this._currentRowNumber * this._byteCount + this._ordinalToIndexMap[ordinal];
			bytes[num] = b;
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x000AF159 File Offset: 0x000AD359
		private void ReadChar(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._chars[this._currentRowNumber * this._charCount + this._ordinalToIndexMap[ordinal]] = reader.GetChar(ordinal);
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x000AF180 File Offset: 0x000AD380
		private async global::System.Threading.Tasks.Task ReadCharAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			char c = await reader.GetFieldValueAsync<char>(ordinal, cancellationToken).WithCurrentCulture<char>();
			char[] chars = this._chars;
			int num = this._currentRowNumber * this._charCount + this._ordinalToIndexMap[ordinal];
			chars[num] = c;
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x000AF1DD File Offset: 0x000AD3DD
		private void ReadDateTime(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._dateTimes[this._currentRowNumber * this._dateTimeCount + this._ordinalToIndexMap[ordinal]] = reader.GetDateTime(ordinal);
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x000AF208 File Offset: 0x000AD408
		private async global::System.Threading.Tasks.Task ReadDateTimeAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.DateTime dateTime = await reader.GetFieldValueAsync<global::System.DateTime>(ordinal, cancellationToken).WithCurrentCulture<global::System.DateTime>();
			global::System.DateTime[] dateTimes = this._dateTimes;
			int num = this._currentRowNumber * this._dateTimeCount + this._ordinalToIndexMap[ordinal];
			dateTimes[num] = dateTime;
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x000AF265 File Offset: 0x000AD465
		private void ReadDecimal(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._decimals[this._currentRowNumber * this._decimalCount + this._ordinalToIndexMap[ordinal]] = reader.GetDecimal(ordinal);
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x000AF290 File Offset: 0x000AD490
		private async global::System.Threading.Tasks.Task ReadDecimalAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			decimal num = await reader.GetFieldValueAsync<decimal>(ordinal, cancellationToken).WithCurrentCulture<decimal>();
			decimal[] decimals = this._decimals;
			int num2 = this._currentRowNumber * this._decimalCount + this._ordinalToIndexMap[ordinal];
			decimals[num2] = num;
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x000AF2ED File Offset: 0x000AD4ED
		private void ReadDouble(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._doubles[this._currentRowNumber * this._doubleCount + this._ordinalToIndexMap[ordinal]] = reader.GetDouble(ordinal);
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x000AF314 File Offset: 0x000AD514
		private async global::System.Threading.Tasks.Task ReadDoubleAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			double num = await reader.GetFieldValueAsync<double>(ordinal, cancellationToken).WithCurrentCulture<double>();
			double[] doubles = this._doubles;
			int num2 = this._currentRowNumber * this._doubleCount + this._ordinalToIndexMap[ordinal];
			doubles[num2] = num;
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x000AF371 File Offset: 0x000AD571
		private void ReadFloat(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._floats[this._currentRowNumber * this._floatCount + this._ordinalToIndexMap[ordinal]] = reader.GetFloat(ordinal);
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x000AF398 File Offset: 0x000AD598
		private async global::System.Threading.Tasks.Task ReadFloatAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			float num = await reader.GetFieldValueAsync<float>(ordinal, cancellationToken).WithCurrentCulture<float>();
			float[] floats = this._floats;
			int num2 = this._currentRowNumber * this._floatCount + this._ordinalToIndexMap[ordinal];
			floats[num2] = num;
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x000AF3F5 File Offset: 0x000AD5F5
		private void ReadGuid(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._guids[this._currentRowNumber * this._guidCount + this._ordinalToIndexMap[ordinal]] = reader.GetGuid(ordinal);
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x000AF420 File Offset: 0x000AD620
		private async global::System.Threading.Tasks.Task ReadGuidAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Guid guid = await reader.GetFieldValueAsync<global::System.Guid>(ordinal, cancellationToken).WithCurrentCulture<global::System.Guid>();
			global::System.Guid[] guids = this._guids;
			int num = this._currentRowNumber * this._guidCount + this._ordinalToIndexMap[ordinal];
			guids[num] = guid;
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x000AF47D File Offset: 0x000AD67D
		private void ReadShort(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._shorts[this._currentRowNumber * this._shortCount + this._ordinalToIndexMap[ordinal]] = reader.GetInt16(ordinal);
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x000AF4A4 File Offset: 0x000AD6A4
		private async global::System.Threading.Tasks.Task ReadShortAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			short num = await reader.GetFieldValueAsync<short>(ordinal, cancellationToken).WithCurrentCulture<short>();
			short[] shorts = this._shorts;
			int num2 = this._currentRowNumber * this._shortCount + this._ordinalToIndexMap[ordinal];
			shorts[num2] = num;
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x000AF501 File Offset: 0x000AD701
		private void ReadInt(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._ints[this._currentRowNumber * this._intCount + this._ordinalToIndexMap[ordinal]] = reader.GetInt32(ordinal);
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x000AF528 File Offset: 0x000AD728
		private async global::System.Threading.Tasks.Task ReadIntAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			int num = await reader.GetFieldValueAsync<int>(ordinal, cancellationToken).WithCurrentCulture<int>();
			int[] ints = this._ints;
			int num2 = this._currentRowNumber * this._intCount + this._ordinalToIndexMap[ordinal];
			ints[num2] = num;
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x000AF585 File Offset: 0x000AD785
		private void ReadLong(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._longs[this._currentRowNumber * this._longCount + this._ordinalToIndexMap[ordinal]] = reader.GetInt64(ordinal);
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x000AF5AC File Offset: 0x000AD7AC
		private async global::System.Threading.Tasks.Task ReadLongAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			long num = await reader.GetFieldValueAsync<long>(ordinal, cancellationToken).WithCurrentCulture<long>();
			long[] longs = this._longs;
			int num2 = this._currentRowNumber * this._longCount + this._ordinalToIndexMap[ordinal];
			longs[num2] = num;
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x000AF609 File Offset: 0x000AD809
		private void ReadObject(global::System.Data.Common.DbDataReader reader, int ordinal)
		{
			this._objects[this._currentRowNumber * this._objectCount + this._ordinalToIndexMap[ordinal]] = reader.GetValue(ordinal);
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x000AF630 File Offset: 0x000AD830
		private async global::System.Threading.Tasks.Task ReadObjectAsync(global::System.Data.Common.DbDataReader reader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			object obj = await reader.GetFieldValueAsync<object>(ordinal, cancellationToken).WithCurrentCulture<object>();
			object[] objects = this._objects;
			int num = this._currentRowNumber * this._objectCount + this._ordinalToIndexMap[ordinal];
			objects[num] = obj;
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x000AF68D File Offset: 0x000AD88D
		private void ReadGeography(global::System.Data.Entity.Spatial.DbSpatialDataReader spatialReader, int ordinal)
		{
			this._objects[this._currentRowNumber * this._objectCount + this._ordinalToIndexMap[ordinal]] = spatialReader.GetGeography(ordinal);
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x000AF6B4 File Offset: 0x000AD8B4
		private async global::System.Threading.Tasks.Task ReadGeographyAsync(global::System.Data.Entity.Spatial.DbSpatialDataReader spatialReader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Spatial.DbGeography dbGeography = await spatialReader.GetGeographyAsync(ordinal, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Spatial.DbGeography>();
			object[] objects = this._objects;
			int num = this._currentRowNumber * this._objectCount + this._ordinalToIndexMap[ordinal];
			objects[num] = dbGeography;
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x000AF711 File Offset: 0x000AD911
		private void ReadGeometry(global::System.Data.Entity.Spatial.DbSpatialDataReader spatialReader, int ordinal)
		{
			this._objects[this._currentRowNumber * this._objectCount + this._ordinalToIndexMap[ordinal]] = spatialReader.GetGeometry(ordinal);
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x000AF738 File Offset: 0x000AD938
		private async global::System.Threading.Tasks.Task ReadGeometryAsync(global::System.Data.Entity.Spatial.DbSpatialDataReader spatialReader, int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Spatial.DbGeometry dbGeometry = await spatialReader.GetGeometryAsync(ordinal, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Spatial.DbGeometry>();
			object[] objects = this._objects;
			int num = this._currentRowNumber * this._objectCount + this._ordinalToIndexMap[ordinal];
			objects[num] = dbGeometry;
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x000AF795 File Offset: 0x000AD995
		public override bool GetBoolean(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Bool)
			{
				return this._bools[this._currentRowNumber * this._boolCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<bool>(ordinal);
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x000AF7CB File Offset: 0x000AD9CB
		public override byte GetByte(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Byte)
			{
				return this._bytes[this._currentRowNumber * this._byteCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<byte>(ordinal);
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x000AF7FD File Offset: 0x000AD9FD
		public override char GetChar(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Char)
			{
				return this._chars[this._currentRowNumber * this._charCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<char>(ordinal);
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x000AF82F File Offset: 0x000ADA2F
		public override global::System.DateTime GetDateTime(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DateTime)
			{
				return this._dateTimes[this._currentRowNumber * this._dateTimeCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<global::System.DateTime>(ordinal);
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x000AF865 File Offset: 0x000ADA65
		public override decimal GetDecimal(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Decimal)
			{
				return this._decimals[this._currentRowNumber * this._decimalCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<decimal>(ordinal);
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x000AF89B File Offset: 0x000ADA9B
		public override double GetDouble(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Double)
			{
				return this._doubles[this._currentRowNumber * this._doubleCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<double>(ordinal);
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x000AF8CD File Offset: 0x000ADACD
		public override float GetFloat(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Float)
			{
				return this._floats[this._currentRowNumber * this._floatCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<float>(ordinal);
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x000AF8FF File Offset: 0x000ADAFF
		public override global::System.Guid GetGuid(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Guid)
			{
				return this._guids[this._currentRowNumber * this._guidCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<global::System.Guid>(ordinal);
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x000AF936 File Offset: 0x000ADB36
		public override short GetInt16(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Short)
			{
				return this._shorts[this._currentRowNumber * this._shortCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<short>(ordinal);
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x000AF969 File Offset: 0x000ADB69
		public override int GetInt32(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Int)
			{
				return this._ints[this._currentRowNumber * this._intCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<int>(ordinal);
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x000AF99C File Offset: 0x000ADB9C
		public override long GetInt64(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Long)
			{
				return this._longs[this._currentRowNumber * this._longCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<long>(ordinal);
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x000AF9CF File Offset: 0x000ADBCF
		public override string GetString(int ordinal)
		{
			if (this._columnTypeCases[ordinal] == global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Object)
			{
				return (string)this._objects[this._currentRowNumber * this._objectCount + this._ordinalToIndexMap[ordinal]];
			}
			return this.GetFieldValue<string>(ordinal);
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x000AFA06 File Offset: 0x000ADC06
		public override object GetValue(int ordinal)
		{
			return this.GetFieldValue<object>(ordinal);
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x000AFA0F File Offset: 0x000ADC0F
		public override int GetValues(object[] values)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x000AFA18 File Offset: 0x000ADC18
		public override T GetFieldValue<T>(int ordinal)
		{
			switch (this._columnTypeCases[ordinal])
			{
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Empty:
				return default(T);
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Bool:
				return (T)((object)this.GetBoolean(ordinal));
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Byte:
				return (T)((object)this.GetByte(ordinal));
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Char:
				return (T)((object)this.GetChar(ordinal));
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.DateTime:
				return (T)((object)this.GetDateTime(ordinal));
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Decimal:
				return (T)((object)this.GetDecimal(ordinal));
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Double:
				return (T)((object)this.GetDouble(ordinal));
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Float:
				return (T)((object)this.GetFloat(ordinal));
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Guid:
				return (T)((object)this.GetGuid(ordinal));
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Short:
				return (T)((object)this.GetInt16(ordinal));
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Int:
				return (T)((object)this.GetInt32(ordinal));
			case global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase.Long:
				return (T)((object)this.GetInt64(ordinal));
			}
			return (T)((object)this._objects[this._currentRowNumber * this._objectCount + this._ordinalToIndexMap[ordinal]]);
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x000AFB5F File Offset: 0x000ADD5F
		public override global::System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			return global::System.Threading.Tasks.Task.FromResult<T>(this.GetFieldValue<T>(ordinal));
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x000AFB6D File Offset: 0x000ADD6D
		public override bool IsDBNull(int ordinal)
		{
			return this._nulls[this._currentRowNumber * this._nullCount + this._nullOrdinalToIndexMap[ordinal]];
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x000AFB90 File Offset: 0x000ADD90
		public override global::System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			return global::System.Threading.Tasks.Task.FromResult<bool>(this.IsDBNull(ordinal));
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x000AFBA0 File Offset: 0x000ADDA0
		public override bool Read()
		{
			int num = this._currentRowNumber + 1;
			this._currentRowNumber = num;
			return base.IsDataReady = (num < this._rowCount);
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x000AFBCF File Offset: 0x000ADDCF
		public override global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return global::System.Threading.Tasks.Task.FromResult<bool>(this.Read());
		}

		// Token: 0x0400118A RID: 4490
		private int _rowCapacity = 1;

		// Token: 0x0400118B RID: 4491
		private global::System.Collections.BitArray _bools;

		// Token: 0x0400118C RID: 4492
		private bool[] _tempBools;

		// Token: 0x0400118D RID: 4493
		private int _boolCount;

		// Token: 0x0400118E RID: 4494
		private byte[] _bytes;

		// Token: 0x0400118F RID: 4495
		private int _byteCount;

		// Token: 0x04001190 RID: 4496
		private char[] _chars;

		// Token: 0x04001191 RID: 4497
		private int _charCount;

		// Token: 0x04001192 RID: 4498
		private global::System.DateTime[] _dateTimes;

		// Token: 0x04001193 RID: 4499
		private int _dateTimeCount;

		// Token: 0x04001194 RID: 4500
		private decimal[] _decimals;

		// Token: 0x04001195 RID: 4501
		private int _decimalCount;

		// Token: 0x04001196 RID: 4502
		private double[] _doubles;

		// Token: 0x04001197 RID: 4503
		private int _doubleCount;

		// Token: 0x04001198 RID: 4504
		private float[] _floats;

		// Token: 0x04001199 RID: 4505
		private int _floatCount;

		// Token: 0x0400119A RID: 4506
		private global::System.Guid[] _guids;

		// Token: 0x0400119B RID: 4507
		private int _guidCount;

		// Token: 0x0400119C RID: 4508
		private short[] _shorts;

		// Token: 0x0400119D RID: 4509
		private int _shortCount;

		// Token: 0x0400119E RID: 4510
		private int[] _ints;

		// Token: 0x0400119F RID: 4511
		private int _intCount;

		// Token: 0x040011A0 RID: 4512
		private long[] _longs;

		// Token: 0x040011A1 RID: 4513
		private int _longCount;

		// Token: 0x040011A2 RID: 4514
		private object[] _objects;

		// Token: 0x040011A3 RID: 4515
		private int _objectCount;

		// Token: 0x040011A4 RID: 4516
		private int[] _ordinalToIndexMap;

		// Token: 0x040011A5 RID: 4517
		private global::System.Collections.BitArray _nulls;

		// Token: 0x040011A6 RID: 4518
		private bool[] _tempNulls;

		// Token: 0x040011A7 RID: 4519
		private int _nullCount;

		// Token: 0x040011A8 RID: 4520
		private int[] _nullOrdinalToIndexMap;

		// Token: 0x040011A9 RID: 4521
		private global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.TypeCase[] _columnTypeCases;

		// Token: 0x02000A5C RID: 2652
		private enum TypeCase
		{
			// Token: 0x04002A93 RID: 10899
			Empty,
			// Token: 0x04002A94 RID: 10900
			Object,
			// Token: 0x04002A95 RID: 10901
			Bool,
			// Token: 0x04002A96 RID: 10902
			Byte,
			// Token: 0x04002A97 RID: 10903
			Char,
			// Token: 0x04002A98 RID: 10904
			DateTime,
			// Token: 0x04002A99 RID: 10905
			Decimal,
			// Token: 0x04002A9A RID: 10906
			Double,
			// Token: 0x04002A9B RID: 10907
			Float,
			// Token: 0x04002A9C RID: 10908
			Guid,
			// Token: 0x04002A9D RID: 10909
			Short,
			// Token: 0x04002A9E RID: 10910
			Int,
			// Token: 0x04002A9F RID: 10911
			Long,
			// Token: 0x04002AA0 RID: 10912
			DbGeography,
			// Token: 0x04002AA1 RID: 10913
			DbGeometry
		}
	}
}
