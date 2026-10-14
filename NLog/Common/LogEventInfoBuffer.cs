using System;
using NLog.Internal;

namespace NLog.Common
{
	// Token: 0x02000190 RID: 400
	public class LogEventInfoBuffer
	{
		// Token: 0x06001149 RID: 4425 RVA: 0x0002DC6C File Offset: 0x0002BE6C
		public LogEventInfoBuffer(int size, bool growAsNeeded, int growLimit)
		{
			this._growAsNeeded = growAsNeeded;
			this._buffer = new global::NLog.Common.AsyncLogEventInfo[size];
			this._growLimit = growLimit;
			this._getPointer = 0;
			this._putPointer = 0;
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0002DC9C File Offset: 0x0002BE9C
		public int Size
		{
			get
			{
				return this._buffer.Length;
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0002DCA8 File Offset: 0x0002BEA8
		public int Append(global::NLog.Common.AsyncLogEventInfo eventInfo)
		{
			int count;
			lock (this)
			{
				if (this._count >= this._buffer.Length)
				{
					if (this._growAsNeeded && this._buffer.Length < this._growLimit)
					{
						int num = this._buffer.Length * 2;
						if (num >= this._growLimit)
						{
							num = this._growLimit;
						}
						global::NLog.Common.InternalLogger.Trace<int, int>("Enlarging LogEventInfoBuffer from {0} to {1}", this._buffer.Length, num);
						global::NLog.Common.AsyncLogEventInfo[] array = new global::NLog.Common.AsyncLogEventInfo[num];
						global::System.Array.Copy(this._buffer, 0, array, 0, this._buffer.Length);
						this._buffer = array;
					}
					else
					{
						this._getPointer++;
					}
				}
				this._putPointer %= this._buffer.Length;
				this._buffer[this._putPointer] = eventInfo;
				this._putPointer++;
				this._count++;
				if (this._count >= this._buffer.Length)
				{
					this._count = this._buffer.Length;
				}
				count = this._count;
			}
			return count;
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x0002DDD4 File Offset: 0x0002BFD4
		public global::NLog.Common.AsyncLogEventInfo[] GetEventsAndClear()
		{
			global::NLog.Common.AsyncLogEventInfo[] result;
			lock (this)
			{
				int count = this._count;
				if (count == 0)
				{
					result = global::NLog.Internal.ArrayHelper.Empty<global::NLog.Common.AsyncLogEventInfo>();
				}
				else
				{
					global::NLog.Common.AsyncLogEventInfo[] array = new global::NLog.Common.AsyncLogEventInfo[count];
					for (int i = 0; i < count; i++)
					{
						int num = (this._getPointer + i) % this._buffer.Length;
						global::NLog.Common.AsyncLogEventInfo asyncLogEventInfo = this._buffer[num];
						this._buffer[num] = default(global::NLog.Common.AsyncLogEventInfo);
						array[i] = asyncLogEventInfo;
					}
					this._count = 0;
					this._getPointer = 0;
					this._putPointer = 0;
					result = array;
				}
			}
			return result;
		}

		// Token: 0x040004C4 RID: 1220
		private readonly bool _growAsNeeded;

		// Token: 0x040004C5 RID: 1221
		private readonly int _growLimit;

		// Token: 0x040004C6 RID: 1222
		private global::NLog.Common.AsyncLogEventInfo[] _buffer;

		// Token: 0x040004C7 RID: 1223
		private int _getPointer;

		// Token: 0x040004C8 RID: 1224
		private int _putPointer;

		// Token: 0x040004C9 RID: 1225
		private int _count;
	}
}
