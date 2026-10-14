using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005CF RID: 1487
	internal abstract class PropagatorResult
	{
		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x060047CE RID: 18382
		internal abstract bool IsNull { get; }

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x060047CF RID: 18383
		internal abstract bool IsSimple { get; }

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x000FDBD0 File Offset: 0x000FBDD0
		internal virtual global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags PropagatorFlags
		{
			get
			{
				return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.NoFlags;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x060047D1 RID: 18385 RVA: 0x000FDBD3 File Offset: 0x000FBDD3
		internal virtual global::System.Data.Entity.Core.IEntityStateEntry StateEntry
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x000FDBD6 File Offset: 0x000FBDD6
		internal virtual global::System.Data.Entity.Core.Objects.CurrentValueRecord Record
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x060047D3 RID: 18387 RVA: 0x000FDBD9 File Offset: 0x000FBDD9
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.StructuralType StructuralType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x060047D4 RID: 18388 RVA: 0x000FDBDC File Offset: 0x000FBDDC
		internal virtual int RecordOrdinal
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x060047D5 RID: 18389 RVA: 0x000FDBDF File Offset: 0x000FBDDF
		internal virtual int Identifier
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x060047D6 RID: 18390 RVA: 0x000FDBE2 File Offset: 0x000FBDE2
		internal virtual global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Next
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x000FDBE5 File Offset: 0x000FBDE5
		internal virtual object GetSimpleValue()
		{
			throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.UpdatePipelineResultRequestInvalid, 0, "PropagatorResult.GetSimpleValue");
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x000FDBF7 File Offset: 0x000FBDF7
		internal virtual global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult GetMemberValue(int ordinal)
		{
			throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.UpdatePipelineResultRequestInvalid, 0, "PropagatorResult.GetMemberValue");
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x000FDC0C File Offset: 0x000FBE0C
		internal global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult GetMemberValue(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			int ordinal = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(this.StructuralType).IndexOf(member);
			return this.GetMemberValue(ordinal);
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x000FDC32 File Offset: 0x000FBE32
		internal virtual global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] GetMemberValues()
		{
			throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.UpdatePipelineResultRequestInvalid, 0, "PropagatorResult.GetMembersValues");
		}

		// Token: 0x060047DB RID: 18395
		internal abstract global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewFlags(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags);

		// Token: 0x060047DC RID: 18396 RVA: 0x000FDC44 File Offset: 0x000FBE44
		internal virtual global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewValue(object value)
		{
			throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.UpdatePipelineResultRequestInvalid, 0, "PropagatorResult.ReplicateResultWithNewValue");
		}

		// Token: 0x060047DD RID: 18397
		internal abstract global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Replace(global::System.Func<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> map);

		// Token: 0x060047DE RID: 18398 RVA: 0x000FDC56 File Offset: 0x000FBE56
		internal virtual global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Merge(global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager keyManager, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult other)
		{
			throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.UpdatePipelineResultRequestInvalid, 0, "PropagatorResult.Merge");
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x000FDC68 File Offset: 0x000FBE68
		internal virtual void SetServerGenValue(object value)
		{
			if (this.RecordOrdinal != -1)
			{
				global::System.Data.Entity.Core.Objects.CurrentValueRecord record = this.Record;
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember fieldType = ((global::System.Data.Entity.Core.IExtendedDataRecord)record).DataRecordInfo.FieldMetadata[this.RecordOrdinal].FieldType;
				value = (value ?? global::System.DBNull.Value);
				value = this.AlignReturnValue(value, fieldType);
				record.SetValue(this.RecordOrdinal, value);
			}
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x000FDCC8 File Offset: 0x000FBEC8
		internal object AlignReturnValue(object value, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			if (global::System.DBNull.Value.Equals(value))
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty == member.BuiltInTypeKind && !((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)member).Nullable)
				{
					throw global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_NullReturnValueForNonNullableMember(member.Name, member.DeclaringType.FullName), null, new global::System.Data.Entity.Core.IEntityStateEntry[0]);
				}
			}
			else if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(member.TypeUsage))
			{
				global::System.Type type = null;
				global::System.Type clrEquivalentType;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(member.TypeUsage.EdmType))
				{
					global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = global::System.Data.Entity.Core.Metadata.Edm.Helper.AsPrimitive(member.TypeUsage.EdmType);
					type = this.Record.GetFieldType(this.RecordOrdinal);
					clrEquivalentType = primitiveType.ClrEquivalentType;
				}
				else
				{
					clrEquivalentType = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)member.TypeUsage.EdmType).ClrEquivalentType;
				}
				try
				{
					value = global::System.Convert.ChangeType(value, clrEquivalentType, global::System.Globalization.CultureInfo.InvariantCulture);
					if (type != null)
					{
						value = global::System.Enum.ToObject(type, value);
					}
				}
				catch (global::System.Exception ex)
				{
					if (ex.RequiresContext())
					{
						global::System.Type type2 = type ?? clrEquivalentType;
						throw global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_ReturnValueHasUnexpectedType(value.GetType().FullName, type2.FullName, member.Name, member.DeclaringType.FullName), ex, new global::System.Data.Entity.Core.IEntityStateEntry[0]);
					}
					throw;
				}
			}
			return value;
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x000FDE00 File Offset: 0x000FC000
		internal static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateSimpleValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags, object value)
		{
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.SimpleValue(flags, value);
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x000FDE09 File Offset: 0x000FC009
		internal static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateServerGenSimpleValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags, object value, global::System.Data.Entity.Core.Objects.CurrentValueRecord record, int recordOrdinal)
		{
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.ServerGenSimpleValue(flags, value, record, recordOrdinal);
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x000FDE14 File Offset: 0x000FC014
		internal static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateKeyValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags, object value, global::System.Data.Entity.Core.IEntityStateEntry stateEntry, int identifier)
		{
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue(flags, value, stateEntry, identifier, null);
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x000FDE20 File Offset: 0x000FC020
		internal static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateServerGenKeyValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags, object value, global::System.Data.Entity.Core.IEntityStateEntry stateEntry, int identifier, int recordOrdinal)
		{
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.ServerGenKeyValue(flags, value, stateEntry, identifier, recordOrdinal, null);
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x000FDE2E File Offset: 0x000FC02E
		internal static global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult CreateStructuralValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] values, global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType, bool isModified)
		{
			if (isModified)
			{
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.StructuralValue(values, structuralType);
			}
			return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.UnmodifiedStructuralValue(values, structuralType);
		}

		// Token: 0x0400198D RID: 6541
		internal const int NullIdentifier = -1;

		// Token: 0x0400198E RID: 6542
		internal const int NullOrdinal = -1;

		// Token: 0x02000C08 RID: 3080
		private class SimpleValue : global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult
		{
			// Token: 0x06006948 RID: 26952 RVA: 0x001674EA File Offset: 0x001656EA
			internal SimpleValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags, object value)
			{
				this.m_flags = flags;
				this.m_value = (value ?? global::System.DBNull.Value);
			}

			// Token: 0x17001146 RID: 4422
			// (get) Token: 0x06006949 RID: 26953 RVA: 0x00167509 File Offset: 0x00165709
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags PropagatorFlags
			{
				get
				{
					return this.m_flags;
				}
			}

			// Token: 0x17001147 RID: 4423
			// (get) Token: 0x0600694A RID: 26954 RVA: 0x00167511 File Offset: 0x00165711
			internal override bool IsSimple
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17001148 RID: 4424
			// (get) Token: 0x0600694B RID: 26955 RVA: 0x00167514 File Offset: 0x00165714
			internal override bool IsNull
			{
				get
				{
					return -1 == this.Identifier && global::System.DBNull.Value == this.m_value;
				}
			}

			// Token: 0x0600694C RID: 26956 RVA: 0x0016752E File Offset: 0x0016572E
			internal override object GetSimpleValue()
			{
				return this.m_value;
			}

			// Token: 0x0600694D RID: 26957 RVA: 0x00167536 File Offset: 0x00165736
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewFlags(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags)
			{
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.SimpleValue(flags, this.m_value);
			}

			// Token: 0x0600694E RID: 26958 RVA: 0x00167544 File Offset: 0x00165744
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewValue(object value)
			{
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.SimpleValue(this.PropagatorFlags, value);
			}

			// Token: 0x0600694F RID: 26959 RVA: 0x00167552 File Offset: 0x00165752
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Replace(global::System.Func<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> map)
			{
				return map(this);
			}

			// Token: 0x04002FB1 RID: 12209
			private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags m_flags;

			// Token: 0x04002FB2 RID: 12210
			protected readonly object m_value;
		}

		// Token: 0x02000C09 RID: 3081
		private class ServerGenSimpleValue : global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.SimpleValue
		{
			// Token: 0x06006950 RID: 26960 RVA: 0x0016755B File Offset: 0x0016575B
			internal ServerGenSimpleValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags, object value, global::System.Data.Entity.Core.Objects.CurrentValueRecord record, int recordOrdinal) : base(flags, value)
			{
				this.m_record = record;
				this.m_recordOrdinal = recordOrdinal;
			}

			// Token: 0x17001149 RID: 4425
			// (get) Token: 0x06006951 RID: 26961 RVA: 0x00167574 File Offset: 0x00165774
			internal override global::System.Data.Entity.Core.Objects.CurrentValueRecord Record
			{
				get
				{
					return this.m_record;
				}
			}

			// Token: 0x1700114A RID: 4426
			// (get) Token: 0x06006952 RID: 26962 RVA: 0x0016757C File Offset: 0x0016577C
			internal override int RecordOrdinal
			{
				get
				{
					return this.m_recordOrdinal;
				}
			}

			// Token: 0x06006953 RID: 26963 RVA: 0x00167584 File Offset: 0x00165784
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewFlags(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags)
			{
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.ServerGenSimpleValue(flags, this.m_value, this.Record, this.RecordOrdinal);
			}

			// Token: 0x06006954 RID: 26964 RVA: 0x0016759E File Offset: 0x0016579E
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewValue(object value)
			{
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.ServerGenSimpleValue(this.PropagatorFlags, value, this.Record, this.RecordOrdinal);
			}

			// Token: 0x04002FB3 RID: 12211
			private readonly global::System.Data.Entity.Core.Objects.CurrentValueRecord m_record;

			// Token: 0x04002FB4 RID: 12212
			private readonly int m_recordOrdinal;
		}

		// Token: 0x02000C0A RID: 3082
		private class KeyValue : global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.SimpleValue
		{
			// Token: 0x06006955 RID: 26965 RVA: 0x001675B8 File Offset: 0x001657B8
			internal KeyValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags, object value, global::System.Data.Entity.Core.IEntityStateEntry stateEntry, int identifier, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue next) : base(flags, value)
			{
				this.m_stateEntry = stateEntry;
				this.m_identifier = identifier;
				this.m_next = next;
			}

			// Token: 0x1700114B RID: 4427
			// (get) Token: 0x06006956 RID: 26966 RVA: 0x001675D9 File Offset: 0x001657D9
			internal override global::System.Data.Entity.Core.IEntityStateEntry StateEntry
			{
				get
				{
					return this.m_stateEntry;
				}
			}

			// Token: 0x1700114C RID: 4428
			// (get) Token: 0x06006957 RID: 26967 RVA: 0x001675E1 File Offset: 0x001657E1
			internal override int Identifier
			{
				get
				{
					return this.m_identifier;
				}
			}

			// Token: 0x1700114D RID: 4429
			// (get) Token: 0x06006958 RID: 26968 RVA: 0x001675E9 File Offset: 0x001657E9
			internal override global::System.Data.Entity.Core.Objects.CurrentValueRecord Record
			{
				get
				{
					return this.m_stateEntry.CurrentValues;
				}
			}

			// Token: 0x1700114E RID: 4430
			// (get) Token: 0x06006959 RID: 26969 RVA: 0x001675F6 File Offset: 0x001657F6
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Next
			{
				get
				{
					return this.m_next;
				}
			}

			// Token: 0x0600695A RID: 26970 RVA: 0x001675FE File Offset: 0x001657FE
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewFlags(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags)
			{
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue(flags, this.m_value, this.StateEntry, this.Identifier, this.m_next);
			}

			// Token: 0x0600695B RID: 26971 RVA: 0x0016761E File Offset: 0x0016581E
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewValue(object value)
			{
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue(this.PropagatorFlags, value, this.StateEntry, this.Identifier, this.m_next);
			}

			// Token: 0x0600695C RID: 26972 RVA: 0x0016763E File Offset: 0x0016583E
			internal virtual global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue ReplicateResultWithNewNext(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue next)
			{
				if (this.m_next != null)
				{
					next = this.m_next.ReplicateResultWithNewNext(next);
				}
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue(this.PropagatorFlags, this.m_value, this.m_stateEntry, this.m_identifier, next);
			}

			// Token: 0x0600695D RID: 26973 RVA: 0x00167674 File Offset: 0x00165874
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Merge(global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager keyManager, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult other)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue keyValue = other as global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue;
				if (keyValue == null)
				{
					global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.UpdatePipelineResultRequestInvalid, 0, "KeyValue.Merge");
				}
				if (this.Identifier != keyValue.Identifier)
				{
					if (keyManager.GetPrincipals(keyValue.Identifier).Contains(this.Identifier))
					{
						return this.ReplicateResultWithNewNext(keyValue);
					}
					return keyValue.ReplicateResultWithNewNext(this);
				}
				else
				{
					if (this.m_stateEntry == null || this.m_stateEntry.IsRelationship)
					{
						return keyValue.ReplicateResultWithNewNext(this);
					}
					return this.ReplicateResultWithNewNext(keyValue);
				}
			}

			// Token: 0x04002FB5 RID: 12213
			private readonly global::System.Data.Entity.Core.IEntityStateEntry m_stateEntry;

			// Token: 0x04002FB6 RID: 12214
			private readonly int m_identifier;

			// Token: 0x04002FB7 RID: 12215
			protected readonly global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue m_next;
		}

		// Token: 0x02000C0B RID: 3083
		private class ServerGenKeyValue : global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue
		{
			// Token: 0x0600695E RID: 26974 RVA: 0x001676F7 File Offset: 0x001658F7
			internal ServerGenKeyValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags, object value, global::System.Data.Entity.Core.IEntityStateEntry stateEntry, int identifier, int recordOrdinal, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue next) : base(flags, value, stateEntry, identifier, next)
			{
				this.m_recordOrdinal = recordOrdinal;
			}

			// Token: 0x1700114F RID: 4431
			// (get) Token: 0x0600695F RID: 26975 RVA: 0x0016770E File Offset: 0x0016590E
			internal override int RecordOrdinal
			{
				get
				{
					return this.m_recordOrdinal;
				}
			}

			// Token: 0x06006960 RID: 26976 RVA: 0x00167716 File Offset: 0x00165916
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewFlags(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags)
			{
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.ServerGenKeyValue(flags, this.m_value, this.StateEntry, this.Identifier, this.RecordOrdinal, this.m_next);
			}

			// Token: 0x06006961 RID: 26977 RVA: 0x0016773C File Offset: 0x0016593C
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewValue(object value)
			{
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.ServerGenKeyValue(this.PropagatorFlags, value, this.StateEntry, this.Identifier, this.RecordOrdinal, this.m_next);
			}

			// Token: 0x06006962 RID: 26978 RVA: 0x00167762 File Offset: 0x00165962
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue ReplicateResultWithNewNext(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.KeyValue next)
			{
				if (this.m_next != null)
				{
					next = this.m_next.ReplicateResultWithNewNext(next);
				}
				return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.ServerGenKeyValue(this.PropagatorFlags, this.m_value, this.StateEntry, this.Identifier, this.RecordOrdinal, next);
			}

			// Token: 0x04002FB8 RID: 12216
			private readonly int m_recordOrdinal;
		}

		// Token: 0x02000C0C RID: 3084
		private class StructuralValue : global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult
		{
			// Token: 0x06006963 RID: 26979 RVA: 0x0016779E File Offset: 0x0016599E
			internal StructuralValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] values, global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType)
			{
				this.m_values = values;
				this.m_structuralType = structuralType;
			}

			// Token: 0x17001150 RID: 4432
			// (get) Token: 0x06006964 RID: 26980 RVA: 0x001677B4 File Offset: 0x001659B4
			internal override bool IsSimple
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17001151 RID: 4433
			// (get) Token: 0x06006965 RID: 26981 RVA: 0x001677B7 File Offset: 0x001659B7
			internal override bool IsNull
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17001152 RID: 4434
			// (get) Token: 0x06006966 RID: 26982 RVA: 0x001677BA File Offset: 0x001659BA
			internal override global::System.Data.Entity.Core.Metadata.Edm.StructuralType StructuralType
			{
				get
				{
					return this.m_structuralType;
				}
			}

			// Token: 0x06006967 RID: 26983 RVA: 0x001677C2 File Offset: 0x001659C2
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult GetMemberValue(int ordinal)
			{
				return this.m_values[ordinal];
			}

			// Token: 0x06006968 RID: 26984 RVA: 0x001677CC File Offset: 0x001659CC
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] GetMemberValues()
			{
				return this.m_values;
			}

			// Token: 0x06006969 RID: 26985 RVA: 0x001677D4 File Offset: 0x001659D4
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult ReplicateResultWithNewFlags(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags flags)
			{
				throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.UpdatePipelineResultRequestInvalid, 0, "StructuralValue.ReplicateResultWithNewFlags");
			}

			// Token: 0x0600696A RID: 26986 RVA: 0x001677E8 File Offset: 0x001659E8
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Replace(global::System.Func<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> map)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = this.ReplaceValues(map);
				if (array != null)
				{
					return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.StructuralValue(array, this.m_structuralType);
				}
				return this;
			}

			// Token: 0x0600696B RID: 26987 RVA: 0x00167810 File Offset: 0x00165A10
			protected global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] ReplaceValues(global::System.Func<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> map)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[this.m_values.Length];
				bool flag = false;
				for (int i = 0; i < array.Length; i++)
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult = this.m_values[i].Replace(map);
					if (propagatorResult != this.m_values[i])
					{
						flag = true;
					}
					array[i] = propagatorResult;
				}
				if (!flag)
				{
					return null;
				}
				return array;
			}

			// Token: 0x04002FB9 RID: 12217
			private readonly global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] m_values;

			// Token: 0x04002FBA RID: 12218
			protected readonly global::System.Data.Entity.Core.Metadata.Edm.StructuralType m_structuralType;
		}

		// Token: 0x02000C0D RID: 3085
		private class UnmodifiedStructuralValue : global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.StructuralValue
		{
			// Token: 0x0600696C RID: 26988 RVA: 0x00167861 File Offset: 0x00165A61
			internal UnmodifiedStructuralValue(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] values, global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType) : base(values, structuralType)
			{
			}

			// Token: 0x17001153 RID: 4435
			// (get) Token: 0x0600696D RID: 26989 RVA: 0x0016786B File Offset: 0x00165A6B
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags PropagatorFlags
			{
				get
				{
					return global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorFlags.Preserve;
				}
			}

			// Token: 0x0600696E RID: 26990 RVA: 0x00167870 File Offset: 0x00165A70
			internal override global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult Replace(global::System.Func<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> map)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = base.ReplaceValues(map);
				if (array != null)
				{
					return new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult.UnmodifiedStructuralValue(array, this.m_structuralType);
				}
				return this;
			}
		}
	}
}
