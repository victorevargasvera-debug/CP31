using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Ionic.Crc;

namespace Ionic.Zlib
{
	// Token: 0x02000431 RID: 1073
	internal class ParallelDeflateOutputStream : global::System.IO.Stream
	{
		// Token: 0x06002E94 RID: 11924 RVA: 0x000A2400 File Offset: 0x000A0600
		public ParallelDeflateOutputStream(global::System.IO.Stream stream) : this(stream, global::Ionic.Zlib.CompressionLevel.Default, global::Ionic.Zlib.CompressionStrategy.Default, false)
		{
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x000A240C File Offset: 0x000A060C
		public ParallelDeflateOutputStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionLevel level) : this(stream, level, global::Ionic.Zlib.CompressionStrategy.Default, false)
		{
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x000A2418 File Offset: 0x000A0618
		public ParallelDeflateOutputStream(global::System.IO.Stream stream, bool leaveOpen) : this(stream, global::Ionic.Zlib.CompressionLevel.Default, global::Ionic.Zlib.CompressionStrategy.Default, leaveOpen)
		{
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x000A2424 File Offset: 0x000A0624
		public ParallelDeflateOutputStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionLevel level, bool leaveOpen) : this(stream, global::Ionic.Zlib.CompressionLevel.Default, global::Ionic.Zlib.CompressionStrategy.Default, leaveOpen)
		{
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x000A2430 File Offset: 0x000A0630
		public ParallelDeflateOutputStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionLevel level, global::Ionic.Zlib.CompressionStrategy strategy, bool leaveOpen)
		{
			this._outStream = stream;
			this._compressLevel = level;
			this.Strategy = strategy;
			this._leaveOpen = leaveOpen;
			this.MaxBufferPairs = 16;
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x000A24A4 File Offset: 0x000A06A4
		// (set) Token: 0x06002E9A RID: 11930 RVA: 0x000A24AC File Offset: 0x000A06AC
		public global::Ionic.Zlib.CompressionStrategy Strategy { get; private set; }

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x000A24B8 File Offset: 0x000A06B8
		// (set) Token: 0x06002E9C RID: 11932 RVA: 0x000A24C0 File Offset: 0x000A06C0
		public int MaxBufferPairs
		{
			get
			{
				return this._maxBufferPairs;
			}
			set
			{
				if (value < 4)
				{
					throw new global::System.ArgumentException("MaxBufferPairs", "Value must be 4 or greater.");
				}
				this._maxBufferPairs = value;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x000A24E0 File Offset: 0x000A06E0
		// (set) Token: 0x06002E9E RID: 11934 RVA: 0x000A24E8 File Offset: 0x000A06E8
		public int BufferSize
		{
			get
			{
				return this._bufferSize;
			}
			set
			{
				if (value < 1024)
				{
					throw new global::System.ArgumentOutOfRangeException("BufferSize", "BufferSize must be greater than 1024 bytes");
				}
				this._bufferSize = value;
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x000A250C File Offset: 0x000A070C
		public int Crc32
		{
			get
			{
				return this._Crc32;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002EA0 RID: 11936 RVA: 0x000A2514 File Offset: 0x000A0714
		public long BytesProcessed
		{
			get
			{
				return this._totalBytesProcessed;
			}
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000A251C File Offset: 0x000A071C
		private void _InitializePoolOfWorkItems()
		{
			this._toWrite = new global::System.Collections.Generic.Queue<int>();
			this._toFill = new global::System.Collections.Generic.Queue<int>();
			this._pool = new global::System.Collections.Generic.List<global::Ionic.Zlib.WorkItem>();
			int num = global::Ionic.Zlib.ParallelDeflateOutputStream.BufferPairsPerCore * global::System.Environment.ProcessorCount;
			num = global::System.Math.Min(num, this._maxBufferPairs);
			for (int i = 0; i < num; i++)
			{
				this._pool.Add(new global::Ionic.Zlib.WorkItem(this._bufferSize, this._compressLevel, this.Strategy, i));
				this._toFill.Enqueue(i);
			}
			this._newlyCompressedBlob = new global::System.Threading.AutoResetEvent(false);
			this._runningCrc = new global::Ionic.Crc.CRC32();
			this._currentlyFilling = -1;
			this._lastFilled = -1;
			this._lastWritten = -1;
			this._latestCompressed = -1;
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000A25D8 File Offset: 0x000A07D8
		public override void Write(byte[] buffer, int offset, int count)
		{
			bool mustWait = false;
			if (this._isClosed)
			{
				throw new global::System.InvalidOperationException();
			}
			if (this._pendingException != null)
			{
				this._handlingException = true;
				global::System.Exception pendingException = this._pendingException;
				this._pendingException = null;
				throw pendingException;
			}
			if (count == 0)
			{
				return;
			}
			if (!this._firstWriteDone)
			{
				this._InitializePoolOfWorkItems();
				this._firstWriteDone = true;
			}
			for (;;)
			{
				this.EmitPendingBuffers(false, mustWait);
				mustWait = false;
				int num;
				if (this._currentlyFilling >= 0)
				{
					num = this._currentlyFilling;
					goto IL_AD;
				}
				if (this._toFill.Count != 0)
				{
					num = this._toFill.Dequeue();
					this._lastFilled++;
					goto IL_AD;
				}
				mustWait = true;
				IL_169:
				if (count <= 0)
				{
					return;
				}
				continue;
				IL_AD:
				global::Ionic.Zlib.WorkItem workItem = this._pool[num];
				int num2 = (workItem.buffer.Length - workItem.inputBytesAvailable > count) ? count : (workItem.buffer.Length - workItem.inputBytesAvailable);
				workItem.ordinal = this._lastFilled;
				global::System.Buffer.BlockCopy(buffer, offset, workItem.buffer, workItem.inputBytesAvailable, num2);
				count -= num2;
				offset += num2;
				workItem.inputBytesAvailable += num2;
				if (workItem.inputBytesAvailable == workItem.buffer.Length)
				{
					if (!global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this._DeflateOne), workItem))
					{
						break;
					}
					this._currentlyFilling = -1;
				}
				else
				{
					this._currentlyFilling = num;
				}
				goto IL_169;
			}
			throw new global::System.Exception("Cannot enqueue workitem");
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x000A275C File Offset: 0x000A095C
		private void _FlushFinish()
		{
			byte[] array = new byte[128];
			global::Ionic.Zlib.ZlibCodec zlibCodec = new global::Ionic.Zlib.ZlibCodec();
			int num = zlibCodec.InitializeDeflate(this._compressLevel, false);
			zlibCodec.InputBuffer = null;
			zlibCodec.NextIn = 0;
			zlibCodec.AvailableBytesIn = 0;
			zlibCodec.OutputBuffer = array;
			zlibCodec.NextOut = 0;
			zlibCodec.AvailableBytesOut = array.Length;
			num = zlibCodec.Deflate(global::Ionic.Zlib.FlushType.Finish);
			if (num != 1 && num != 0)
			{
				throw new global::System.Exception("deflating: " + zlibCodec.Message);
			}
			if (array.Length - zlibCodec.AvailableBytesOut > 0)
			{
				this._outStream.Write(array, 0, array.Length - zlibCodec.AvailableBytesOut);
			}
			zlibCodec.EndDeflate();
			this._Crc32 = this._runningCrc.Crc32Result;
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000A2824 File Offset: 0x000A0A24
		private void _Flush(bool lastInput)
		{
			if (this._isClosed)
			{
				throw new global::System.InvalidOperationException();
			}
			if (this.emitting)
			{
				return;
			}
			if (this._currentlyFilling >= 0)
			{
				global::Ionic.Zlib.WorkItem wi = this._pool[this._currentlyFilling];
				this._DeflateOne(wi);
				this._currentlyFilling = -1;
			}
			if (lastInput)
			{
				this.EmitPendingBuffers(true, false);
				this._FlushFinish();
				return;
			}
			this.EmitPendingBuffers(false, false);
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000A289C File Offset: 0x000A0A9C
		public override void Flush()
		{
			if (this._pendingException != null)
			{
				this._handlingException = true;
				global::System.Exception pendingException = this._pendingException;
				this._pendingException = null;
				throw pendingException;
			}
			if (this._handlingException)
			{
				return;
			}
			this._Flush(false);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000A28D8 File Offset: 0x000A0AD8
		public override void Close()
		{
			if (this._pendingException != null)
			{
				this._handlingException = true;
				global::System.Exception pendingException = this._pendingException;
				this._pendingException = null;
				throw pendingException;
			}
			if (this._handlingException)
			{
				return;
			}
			if (this._isClosed)
			{
				return;
			}
			this._Flush(true);
			if (!this._leaveOpen)
			{
				this._outStream.Close();
			}
			this._isClosed = true;
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000A294C File Offset: 0x000A0B4C
		public new void Dispose()
		{
			this.Close();
			this._pool = null;
			this.Dispose(true);
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x000A2964 File Offset: 0x000A0B64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x000A2970 File Offset: 0x000A0B70
		public void Reset(global::System.IO.Stream stream)
		{
			if (!this._firstWriteDone)
			{
				return;
			}
			this._toWrite.Clear();
			this._toFill.Clear();
			foreach (global::Ionic.Zlib.WorkItem workItem in this._pool)
			{
				this._toFill.Enqueue(workItem.index);
				workItem.ordinal = -1;
			}
			this._firstWriteDone = false;
			this._totalBytesProcessed = 0L;
			this._runningCrc = new global::Ionic.Crc.CRC32();
			this._isClosed = false;
			this._currentlyFilling = -1;
			this._lastFilled = -1;
			this._lastWritten = -1;
			this._latestCompressed = -1;
			this._outStream = stream;
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x000A2A40 File Offset: 0x000A0C40
		private void EmitPendingBuffers(bool doAll, bool mustWait)
		{
			if (this.emitting)
			{
				return;
			}
			this.emitting = true;
			if (doAll || mustWait)
			{
				this._newlyCompressedBlob.WaitOne();
			}
			do
			{
				int num = -1;
				int num2 = doAll ? 200 : (mustWait ? -1 : 0);
				int num3 = -1;
				do
				{
					if (global::System.Threading.Monitor.TryEnter(this._toWrite, num2))
					{
						num3 = -1;
						try
						{
							if (this._toWrite.Count > 0)
							{
								num3 = this._toWrite.Dequeue();
							}
						}
						finally
						{
							global::System.Threading.Monitor.Exit(this._toWrite);
						}
						if (num3 >= 0)
						{
							global::Ionic.Zlib.WorkItem workItem = this._pool[num3];
							if (workItem.ordinal != this._lastWritten + 1)
							{
								global::System.Collections.Generic.Queue<int> toWrite = this._toWrite;
								lock (toWrite)
								{
									this._toWrite.Enqueue(num3);
								}
								if (num == num3)
								{
									this._newlyCompressedBlob.WaitOne();
									num = -1;
								}
								else if (num == -1)
								{
									num = num3;
								}
							}
							else
							{
								num = -1;
								this._outStream.Write(workItem.compressed, 0, workItem.compressedBytesAvailable);
								this._runningCrc.Combine(workItem.crc, workItem.inputBytesAvailable);
								this._totalBytesProcessed += (long)workItem.inputBytesAvailable;
								workItem.inputBytesAvailable = 0;
								this._lastWritten = workItem.ordinal;
								this._toFill.Enqueue(workItem.index);
								if (num2 == -1)
								{
									num2 = 0;
								}
							}
						}
					}
					else
					{
						num3 = -1;
					}
				}
				while (num3 >= 0);
			}
			while (doAll && (this._lastWritten != this._latestCompressed || this._lastWritten != this._lastFilled));
			this.emitting = false;
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x000A2C1C File Offset: 0x000A0E1C
		private void _DeflateOne(object wi)
		{
			global::Ionic.Zlib.WorkItem workItem = (global::Ionic.Zlib.WorkItem)wi;
			try
			{
				int index = workItem.index;
				global::Ionic.Crc.CRC32 crc = new global::Ionic.Crc.CRC32();
				crc.SlurpBlock(workItem.buffer, 0, workItem.inputBytesAvailable);
				this.DeflateOneSegment(workItem);
				workItem.crc = crc.Crc32Result;
				object obj = this._latestLock;
				lock (obj)
				{
					if (workItem.ordinal > this._latestCompressed)
					{
						this._latestCompressed = workItem.ordinal;
					}
				}
				global::System.Collections.Generic.Queue<int> toWrite = this._toWrite;
				lock (toWrite)
				{
					this._toWrite.Enqueue(workItem.index);
				}
				this._newlyCompressedBlob.Set();
			}
			catch (global::System.Exception pendingException)
			{
				object obj = this._eLock;
				lock (obj)
				{
					if (this._pendingException != null)
					{
						this._pendingException = pendingException;
					}
				}
			}
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x000A2D40 File Offset: 0x000A0F40
		private bool DeflateOneSegment(global::Ionic.Zlib.WorkItem workitem)
		{
			global::Ionic.Zlib.ZlibCodec compressor = workitem.compressor;
			compressor.ResetDeflate();
			compressor.NextIn = 0;
			compressor.AvailableBytesIn = workitem.inputBytesAvailable;
			compressor.NextOut = 0;
			compressor.AvailableBytesOut = workitem.compressed.Length;
			do
			{
				compressor.Deflate(global::Ionic.Zlib.FlushType.None);
			}
			while (compressor.AvailableBytesIn > 0 || compressor.AvailableBytesOut == 0);
			compressor.Deflate(global::Ionic.Zlib.FlushType.Sync);
			workitem.compressedBytesAvailable = (int)compressor.TotalBytesOut;
			return true;
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x000A2DB8 File Offset: 0x000A0FB8
		[global::System.Diagnostics.Conditional("Trace")]
		private void TraceOutput(global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits bits, string format, params object[] varParams)
		{
			if ((bits & this._DesiredTrace) != global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.None)
			{
				object outputLock = this._outputLock;
				lock (outputLock)
				{
					int hashCode = global::System.Threading.Thread.CurrentThread.GetHashCode();
					global::System.Console.ForegroundColor = hashCode % 8 + global::System.ConsoleColor.DarkGray;
					global::System.Console.Write("{0:000} PDOS ", hashCode);
					global::System.Console.WriteLine(format, varParams);
					global::System.Console.ResetColor();
				}
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x000A2E2C File Offset: 0x000A102C
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x000A2E30 File Offset: 0x000A1030
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x000A2E34 File Offset: 0x000A1034
		public override bool CanWrite
		{
			get
			{
				return this._outStream.CanWrite;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002EB1 RID: 11953 RVA: 0x000A2E44 File Offset: 0x000A1044
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x000A2E4C File Offset: 0x000A104C
		// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x000A2E5C File Offset: 0x000A105C
		public override long Position
		{
			get
			{
				return this._outStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x000A2E64 File Offset: 0x000A1064
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x000A2E6C File Offset: 0x000A106C
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x000A2E74 File Offset: 0x000A1074
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x04001056 RID: 4182
		private static readonly int IO_BUFFER_SIZE_DEFAULT = 65536;

		// Token: 0x04001057 RID: 4183
		private static readonly int BufferPairsPerCore = 4;

		// Token: 0x04001058 RID: 4184
		private global::System.Collections.Generic.List<global::Ionic.Zlib.WorkItem> _pool;

		// Token: 0x04001059 RID: 4185
		private bool _leaveOpen;

		// Token: 0x0400105A RID: 4186
		private bool emitting;

		// Token: 0x0400105B RID: 4187
		private global::System.IO.Stream _outStream;

		// Token: 0x0400105C RID: 4188
		private int _maxBufferPairs;

		// Token: 0x0400105D RID: 4189
		private int _bufferSize = global::Ionic.Zlib.ParallelDeflateOutputStream.IO_BUFFER_SIZE_DEFAULT;

		// Token: 0x0400105E RID: 4190
		private global::System.Threading.AutoResetEvent _newlyCompressedBlob;

		// Token: 0x0400105F RID: 4191
		private object _outputLock = new object();

		// Token: 0x04001060 RID: 4192
		private bool _isClosed;

		// Token: 0x04001061 RID: 4193
		private bool _firstWriteDone;

		// Token: 0x04001062 RID: 4194
		private int _currentlyFilling;

		// Token: 0x04001063 RID: 4195
		private int _lastFilled;

		// Token: 0x04001064 RID: 4196
		private int _lastWritten;

		// Token: 0x04001065 RID: 4197
		private int _latestCompressed;

		// Token: 0x04001066 RID: 4198
		private int _Crc32;

		// Token: 0x04001067 RID: 4199
		private global::Ionic.Crc.CRC32 _runningCrc;

		// Token: 0x04001068 RID: 4200
		private object _latestLock = new object();

		// Token: 0x04001069 RID: 4201
		private global::System.Collections.Generic.Queue<int> _toWrite;

		// Token: 0x0400106A RID: 4202
		private global::System.Collections.Generic.Queue<int> _toFill;

		// Token: 0x0400106B RID: 4203
		private long _totalBytesProcessed;

		// Token: 0x0400106C RID: 4204
		private global::Ionic.Zlib.CompressionLevel _compressLevel;

		// Token: 0x0400106D RID: 4205
		private volatile global::System.Exception _pendingException;

		// Token: 0x0400106E RID: 4206
		private bool _handlingException;

		// Token: 0x0400106F RID: 4207
		private object _eLock = new object();

		// Token: 0x04001070 RID: 4208
		private global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits _DesiredTrace = global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.EmitLock | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.EmitEnter | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.EmitBegin | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.EmitDone | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.EmitSkip | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.Session | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.Compress | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.WriteEnter | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.WriteTake;

		// Token: 0x020004DF RID: 1247
		[global::System.Flags]
		private enum TraceBits : uint
		{
			// Token: 0x0400140D RID: 5133
			None = 0U,
			// Token: 0x0400140E RID: 5134
			NotUsed1 = 1U,
			// Token: 0x0400140F RID: 5135
			EmitLock = 2U,
			// Token: 0x04001410 RID: 5136
			EmitEnter = 4U,
			// Token: 0x04001411 RID: 5137
			EmitBegin = 8U,
			// Token: 0x04001412 RID: 5138
			EmitDone = 16U,
			// Token: 0x04001413 RID: 5139
			EmitSkip = 32U,
			// Token: 0x04001414 RID: 5140
			EmitAll = 58U,
			// Token: 0x04001415 RID: 5141
			Flush = 64U,
			// Token: 0x04001416 RID: 5142
			Lifecycle = 128U,
			// Token: 0x04001417 RID: 5143
			Session = 256U,
			// Token: 0x04001418 RID: 5144
			Synch = 512U,
			// Token: 0x04001419 RID: 5145
			Instance = 1024U,
			// Token: 0x0400141A RID: 5146
			Compress = 2048U,
			// Token: 0x0400141B RID: 5147
			Write = 4096U,
			// Token: 0x0400141C RID: 5148
			WriteEnter = 8192U,
			// Token: 0x0400141D RID: 5149
			WriteTake = 16384U,
			// Token: 0x0400141E RID: 5150
			All = 4294967295U
		}
	}
}
