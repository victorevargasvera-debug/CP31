using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x0200063C RID: 1596
	internal class RecordState
	{
		// Token: 0x06004CDE RID: 19678 RVA: 0x0010E8E4 File Offset: 0x0010CAE4
		internal RecordState(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory recordStateFactory, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory coordinatorFactory)
		{
			this.RecordStateFactory = recordStateFactory;
			this.CoordinatorFactory = coordinatorFactory;
			this.CurrentColumnValues = new object[this.RecordStateFactory.ColumnCount];
			this.PendingColumnValues = new object[this.RecordStateFactory.ColumnCount];
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x0010E934 File Offset: 0x0010CB34
		internal void AcceptPendingValues()
		{
			object[] currentColumnValues = this.CurrentColumnValues;
			this.CurrentColumnValues = this.PendingColumnValues;
			this.PendingColumnValues = currentColumnValues;
			this._currentEntityRecordInfo = this._pendingEntityRecordInfo;
			this._pendingEntityRecordInfo = null;
			this._currentIsNull = this._pendingIsNull;
			if (this.RecordStateFactory.HasNestedColumns)
			{
				for (int i = 0; i < this.CurrentColumnValues.Length; i++)
				{
					if (this.RecordStateFactory.IsColumnNested[i])
					{
						global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState recordState = this.CurrentColumnValues[i] as global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState;
						if (recordState != null)
						{
							recordState.AcceptPendingValues();
						}
					}
				}
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x0010E9C4 File Offset: 0x0010CBC4
		internal int ColumnCount
		{
			get
			{
				return this.RecordStateFactory.ColumnCount;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06004CE1 RID: 19681 RVA: 0x0010E9D4 File Offset: 0x0010CBD4
		internal global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo
		{
			get
			{
				global::System.Data.Entity.Core.Common.DataRecordInfo dataRecordInfo = this._currentEntityRecordInfo;
				if (dataRecordInfo == null)
				{
					dataRecordInfo = this.RecordStateFactory.DataRecordInfo;
				}
				return dataRecordInfo;
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x0010E9F8 File Offset: 0x0010CBF8
		internal bool IsNull
		{
			get
			{
				return this._currentIsNull;
			}
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x0010EA00 File Offset: 0x0010CC00
		internal long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
		{
			byte[] array = (byte[])this.CurrentColumnValues[ordinal];
			int num = array.Length;
			int num2 = (int)dataOffset;
			int num3 = num - num2;
			if (buffer != null)
			{
				num3 = global::System.Math.Min(num3, length);
				if (0 < num3)
				{
					global::System.Buffer.BlockCopy(array, num2, buffer, bufferOffset, num3);
				}
			}
			return (long)global::System.Math.Max(0, num3);
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x0010EA48 File Offset: 0x0010CC48
		internal long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
		{
			string text = this.CurrentColumnValues[ordinal] as string;
			char[] array;
			if (text != null)
			{
				array = text.ToCharArray();
			}
			else
			{
				array = (char[])this.CurrentColumnValues[ordinal];
			}
			int num = array.Length;
			int num2 = (int)dataOffset;
			int num3 = num - num2;
			if (buffer != null)
			{
				num3 = global::System.Math.Min(num3, length);
				if (0 < num3)
				{
					global::System.Buffer.BlockCopy(array, num2 * 2, buffer, bufferOffset * 2, num3 * 2);
				}
			}
			return (long)global::System.Math.Max(0, num3);
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x0010EAAF File Offset: 0x0010CCAF
		internal string GetName(int ordinal)
		{
			if (ordinal < 0 || ordinal >= this.RecordStateFactory.ColumnCount)
			{
				throw new global::System.ArgumentOutOfRangeException("ordinal");
			}
			return this.RecordStateFactory.ColumnNames[ordinal];
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x0010EADF File Offset: 0x0010CCDF
		internal int GetOrdinal(string name)
		{
			return this.RecordStateFactory.FieldNameLookup.GetOrdinal(name);
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x0010EAF2 File Offset: 0x0010CCF2
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage(int ordinal)
		{
			return this.RecordStateFactory.TypeUsages[ordinal];
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x0010EB05 File Offset: 0x0010CD05
		internal bool IsNestedObject(int ordinal)
		{
			return this.RecordStateFactory.IsColumnNested[ordinal];
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x0010EB18 File Offset: 0x0010CD18
		internal void ResetToDefaultState()
		{
			this._currentEntityRecordInfo = null;
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x0010EB21 File Offset: 0x0010CD21
		internal global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState GatherData(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper shaper)
		{
			this.RecordStateFactory.GatherData(shaper);
			this._pendingIsNull = false;
			return this;
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x0010EB3D File Offset: 0x0010CD3D
		internal bool SetColumnValue(int ordinal, object value)
		{
			this.PendingColumnValues[ordinal] = value;
			return true;
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x0010EB49 File Offset: 0x0010CD49
		internal bool SetEntityRecordInfo(global::System.Data.Entity.Core.EntityKey entityKey, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			this._pendingEntityRecordInfo = new global::System.Data.Entity.Core.Common.EntityRecordInfo(this.RecordStateFactory.DataRecordInfo, entityKey, entitySet);
			return true;
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x0010EB64 File Offset: 0x0010CD64
		internal global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState SetNullRecord()
		{
			for (int i = 0; i < this.PendingColumnValues.Length; i++)
			{
				this.PendingColumnValues[i] = global::System.DBNull.Value;
			}
			this._pendingEntityRecordInfo = null;
			this._pendingIsNull = true;
			return this;
		}

		// Token: 0x04001B42 RID: 6978
		private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory RecordStateFactory;

		// Token: 0x04001B43 RID: 6979
		internal readonly global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory CoordinatorFactory;

		// Token: 0x04001B44 RID: 6980
		private bool _pendingIsNull;

		// Token: 0x04001B45 RID: 6981
		private bool _currentIsNull;

		// Token: 0x04001B46 RID: 6982
		private global::System.Data.Entity.Core.Common.EntityRecordInfo _currentEntityRecordInfo;

		// Token: 0x04001B47 RID: 6983
		private global::System.Data.Entity.Core.Common.EntityRecordInfo _pendingEntityRecordInfo;

		// Token: 0x04001B48 RID: 6984
		internal object[] CurrentColumnValues;

		// Token: 0x04001B49 RID: 6985
		internal object[] PendingColumnValues;
	}
}
