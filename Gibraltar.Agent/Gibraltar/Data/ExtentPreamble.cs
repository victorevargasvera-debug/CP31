using System;
using System.IO;

namespace Gibraltar.Data
{
	// Token: 0x020000DA RID: 218
	internal class ExtentPreamble
	{
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x060008FF RID: 2303 RVA: 0x000141D8 File Offset: 0x000123D8
		// (remove) Token: 0x06000900 RID: 2304 RVA: 0x00014214 File Offset: 0x00012414
		public event global::System.EventHandler PreambleDirty;

		// Token: 0x06000901 RID: 2305 RVA: 0x00014250 File Offset: 0x00012450
		private ExtentPreamble()
		{
			this.m_MemoryBufferLength = this.GetMemoryBufferLength();
			this.m_MemoryBuffer = new global::System.IO.MemoryStream(this.m_MemoryBufferLength);
			this.UpdateBuffer(0, new byte[this.m_MemoryBufferLength], 0, this.m_MemoryBufferLength, true);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000142AC File Offset: 0x000124AC
		internal ExtentPreamble(global::Gibraltar.Data.ExtentTypeCode typeCode, short majorVersion) : this()
		{
			this.m_TypeCode = typeCode;
			this.m_MajorVersion = majorVersion;
			this.m_Dirty = true;
			this.UpdateBuffer(0, global::Gibraltar.Data.BinarySerializer.SerializeValue((long)this.m_TypeCode));
			this.UpdateBuffer(8, global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_MajorVersion));
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000142FC File Offset: 0x000124FC
		public ExtentPreamble(byte[] sourceArray) : this()
		{
			if (sourceArray == null)
			{
				throw new global::System.ArgumentNullException("sourceArray");
			}
			if (sourceArray.Length < 20)
			{
				throw new global::System.ArgumentException(string.Format("The provided sourceArray is of insufficient length for a full {0}.", base.GetType().Name), "sourceArray");
			}
			this.UpdateBuffer(0, sourceArray, 0, this.m_MemoryBufferLength, false);
			this.m_MemoryBuffer.Position = 0L;
			long typeCode;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out typeCode);
			this.m_TypeCode = (global::Gibraltar.Data.ExtentTypeCode)typeCode;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out this.m_MajorVersion);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out this.m_MinorVersion);
			uint num;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out num);
			this.m_Offset = (long)((ulong)num);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out this.m_Checksum);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000143C8 File Offset: 0x000125C8
		public ExtentPreamble(global::System.IO.Stream sourceStream) : this()
		{
			if (sourceStream == null)
			{
				throw new global::System.ArgumentNullException("sourceStream");
			}
			byte[] array = new byte[this.m_MemoryBufferLength];
			if (sourceStream.Read(array, 0, this.m_MemoryBufferLength) < this.m_MemoryBufferLength)
			{
				throw new global::System.IO.EndOfStreamException(string.Format("The provided sourceStream ran out before the full {0} could be read.", base.GetType().Name));
			}
			this.UpdateBuffer(0, array);
			this.m_MemoryBuffer.Position = 0L;
			long typeCode;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out typeCode);
			this.m_TypeCode = (global::Gibraltar.Data.ExtentTypeCode)typeCode;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out this.m_MajorVersion);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out this.m_MinorVersion);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out this.m_Offset);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(this.m_MemoryBuffer, out this.m_Checksum);
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x000144A0 File Offset: 0x000126A0
		public int PreambleLength
		{
			get
			{
				return this.m_MemoryBufferLength;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x000144A8 File Offset: 0x000126A8
		public global::Gibraltar.Data.ExtentTypeCode TypeCode
		{
			get
			{
				return this.m_TypeCode;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x000144B0 File Offset: 0x000126B0
		public short MajorVersion
		{
			get
			{
				return this.m_MajorVersion;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x000144B8 File Offset: 0x000126B8
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x000144F8 File Offset: 0x000126F8
		public short MinorVersion
		{
			get
			{
				object @lock = this.m_Lock;
				short minorVersion;
				lock (@lock)
				{
					minorVersion = this.m_MinorVersion;
				}
				return minorVersion;
			}
			internal set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_MinorVersion == value)
					{
						return;
					}
					this.m_MinorVersion = value;
					this.UpdateBuffer(10, global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_MinorVersion));
				}
				this.SetDirty();
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00014560 File Offset: 0x00012760
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x000145A0 File Offset: 0x000127A0
		public long Offset
		{
			get
			{
				object @lock = this.m_Lock;
				long offset;
				lock (@lock)
				{
					offset = this.m_Offset;
				}
				return offset;
			}
			internal set
			{
				if (value < 0L || value > (long)((ulong)-1))
				{
					throw new global::System.OverflowException(string.Format("Supplied Offset value {0} is outside the range for Uint32 values.", value));
				}
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_Offset == value)
					{
						return;
					}
					this.m_Offset = value;
					uint hostValue = (uint)value;
					this.UpdateBuffer(12, global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue));
				}
				this.SetDirty();
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0001462C File Offset: 0x0001282C
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x0001466C File Offset: 0x0001286C
		public int Checksum
		{
			get
			{
				object @lock = this.m_Lock;
				int checksum;
				lock (@lock)
				{
					checksum = this.m_Checksum;
				}
				return checksum;
			}
			internal set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_Checksum != value)
					{
						this.m_Checksum = value;
						this.UpdateBuffer(16, global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_Checksum));
					}
					this.ClearDirty();
				}
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x000146D0 File Offset: 0x000128D0
		public bool IsDirty
		{
			get
			{
				object @lock = this.m_Lock;
				bool dirty;
				lock (@lock)
				{
					dirty = this.m_Dirty;
				}
				return dirty;
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00014710 File Offset: 0x00012910
		public byte[] ToArray()
		{
			object @lock = this.m_Lock;
			byte[] result;
			lock (@lock)
			{
				result = this.m_MemoryBuffer.ToArray();
			}
			return result;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00014754 File Offset: 0x00012954
		protected virtual int GetMemoryBufferLength()
		{
			return 20;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00014758 File Offset: 0x00012958
		protected void SetDirty()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Dirty)
				{
					return;
				}
				this.m_Dirty = true;
			}
			this.OnPreambleDirty();
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x000147AC File Offset: 0x000129AC
		protected void ClearDirty()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_Dirty = false;
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000147EC File Offset: 0x000129EC
		protected void OnPreambleDirty()
		{
			global::System.EventHandler preambleDirty = this.PreambleDirty;
			if (preambleDirty != null)
			{
				preambleDirty(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00014818 File Offset: 0x00012A18
		protected void UpdateBuffer(int position, byte[] sourceArray)
		{
			this.UpdateBuffer(position, sourceArray, 0, sourceArray.Length, false);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00014828 File Offset: 0x00012A28
		protected void UpdateBuffer(int position, byte[] sourceArray, int startIndex, int count, bool keepPosition)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				long position2 = this.m_MemoryBuffer.Position;
				this.m_MemoryBuffer.Position = (long)position;
				this.m_MemoryBuffer.Write(sourceArray, startIndex, count);
				if (keepPosition)
				{
					this.m_MemoryBuffer.Position = position2;
				}
			}
		}

		// Token: 0x040001F1 RID: 497
		private const int PositionOfTypeCode = 0;

		// Token: 0x040001F2 RID: 498
		private readonly global::Gibraltar.Data.ExtentTypeCode m_TypeCode;

		// Token: 0x040001F3 RID: 499
		private const int PositionOfMajorVersion = 8;

		// Token: 0x040001F4 RID: 500
		private readonly short m_MajorVersion;

		// Token: 0x040001F5 RID: 501
		private const int PositionOfMinorVersion = 10;

		// Token: 0x040001F6 RID: 502
		private short m_MinorVersion;

		// Token: 0x040001F7 RID: 503
		private const int PositionOfOffset = 12;

		// Token: 0x040001F8 RID: 504
		private long m_Offset;

		// Token: 0x040001F9 RID: 505
		private const int PositionOfChecksum = 16;

		// Token: 0x040001FA RID: 506
		private int m_Checksum;

		// Token: 0x040001FB RID: 507
		private bool m_Dirty;

		// Token: 0x040001FC RID: 508
		public const int ExtentPreambleLength = 20;

		// Token: 0x040001FD RID: 509
		protected readonly object m_Lock = new object();

		// Token: 0x040001FE RID: 510
		protected readonly global::System.IO.MemoryStream m_MemoryBuffer;

		// Token: 0x040001FF RID: 511
		private readonly int m_MemoryBufferLength;
	}
}
