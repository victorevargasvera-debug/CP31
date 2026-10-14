using System;
using System.Threading;

namespace MassTransit
{
	// Token: 0x0200000C RID: 12
	public class NewIdGenerator : global::MassTransit.INewIdGenerator
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002ACC File Offset: 0x00000CCC
		public NewIdGenerator(global::MassTransit.ITickProvider tickProvider, global::MassTransit.IWorkerIdProvider workerIdProvider, global::MassTransit.IProcessIdProvider processIdProvider = null, int workerIndex = 0)
		{
			this._tickProvider = tickProvider;
			this._spinLock = new global::System.Threading.SpinLock(false);
			byte[] workerId = workerIdProvider.GetWorkerId(workerIndex);
			this._c = ((int)workerId[0] << 24 | (int)workerId[1] << 16 | (int)workerId[2] << 8 | (int)workerId[3]);
			if (processIdProvider != null)
			{
				byte[] processId = processIdProvider.GetProcessId();
				this._d = ((int)processId[0] << 24 | (int)processId[1] << 16);
			}
			else
			{
				this._d = ((int)workerId[4] << 24 | (int)workerId[5] << 16);
			}
			this._gb = (short)this._c;
			this._gc = (short)(this._c >> 16);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002B68 File Offset: 0x00000D68
		public global::MassTransit.NewId Next()
		{
			long ticks = this._tickProvider.Ticks;
			bool flag = false;
			int num;
			int a;
			int b;
			try
			{
				this._spinLock.Enter(ref flag);
				if (ticks > this._lastTick)
				{
					this.UpdateTimestamp(ticks);
				}
				else if (this._sequence == 65535)
				{
					this.UpdateTimestamp(this._lastTick + 1L);
				}
				int sequence = this._sequence;
				this._sequence = sequence + 1;
				num = sequence;
				a = this._a;
				b = this._b;
			}
			finally
			{
				if (flag)
				{
					this._spinLock.Exit();
				}
			}
			return new global::MassTransit.NewId(a, b, this._c, this._d | num);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002C1C File Offset: 0x00000E1C
		public global::System.Guid NextGuid()
		{
			long ticks = this._tickProvider.Ticks;
			bool flag = false;
			int num;
			int a;
			int b;
			try
			{
				this._spinLock.Enter(ref flag);
				if (ticks > this._lastTick)
				{
					this.UpdateTimestamp(ticks);
				}
				else if (this._sequence == 65535)
				{
					this.UpdateTimestamp(this._lastTick + 1L);
				}
				int sequence = this._sequence;
				this._sequence = sequence + 1;
				num = sequence;
				a = this._a;
				b = this._b;
			}
			finally
			{
				if (flag)
				{
					this._spinLock.Exit();
				}
			}
			byte d = (byte)(b >> 8);
			byte e = (byte)b;
			byte f = (byte)(a >> 24);
			byte g = (byte)(a >> 16);
			byte h = (byte)(a >> 8);
			byte i = (byte)a;
			byte j = (byte)(b >> 24);
			byte k = (byte)(b >> 16);
			int num2 = (num << 8 | (num >> 8 & 255)) & 65535;
			return new global::System.Guid(this._d | num2, this._gb, this._gc, d, e, f, g, h, i, j, k);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002D28 File Offset: 0x00000F28
		public global::System.ArraySegment<global::MassTransit.NewId> Next(global::MassTransit.NewId[] ids, int index, int count)
		{
			long ticks = this._tickProvider.Ticks;
			bool flag = false;
			try
			{
				this._spinLock.Enter(ref flag);
				if (ticks > this._lastTick)
				{
					this.UpdateTimestamp(ticks);
				}
				int num = index + count;
				for (int i = index; i < num; i++)
				{
					if (this._sequence == 65535)
					{
						this.UpdateTimestamp(this._lastTick + 1L);
					}
					int num2 = i;
					int a = this._a;
					int b = this._b;
					int c = this._c;
					int d = this._d;
					int sequence = this._sequence;
					this._sequence = sequence + 1;
					ids[num2] = new global::MassTransit.NewId(a, b, c, d | sequence);
				}
			}
			finally
			{
				if (flag)
				{
					this._spinLock.Exit();
				}
			}
			return new global::System.ArraySegment<global::MassTransit.NewId>(ids, index, count);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002DF0 File Offset: 0x00000FF0
		private void UpdateTimestamp(long tick)
		{
			this._b = (int)(tick & (long)((ulong)-1));
			this._a = (int)(tick >> 32);
			this._sequence = 0;
			this._lastTick = tick;
		}

		// Token: 0x04000010 RID: 16
		private readonly int _c;

		// Token: 0x04000011 RID: 17
		private readonly int _d;

		// Token: 0x04000012 RID: 18
		private readonly short _gb;

		// Token: 0x04000013 RID: 19
		private readonly short _gc;

		// Token: 0x04000014 RID: 20
		private readonly global::MassTransit.ITickProvider _tickProvider;

		// Token: 0x04000015 RID: 21
		private int _a;

		// Token: 0x04000016 RID: 22
		private int _b;

		// Token: 0x04000017 RID: 23
		private long _lastTick;

		// Token: 0x04000018 RID: 24
		private int _sequence;

		// Token: 0x04000019 RID: 25
		private global::System.Threading.SpinLock _spinLock;
	}
}
