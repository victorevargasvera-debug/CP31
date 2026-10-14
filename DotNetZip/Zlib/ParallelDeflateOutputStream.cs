using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Ionic.Crc;

namespace Ionic.Zlib
{
	// Token: 0x02000019 RID: 25
	public class ParallelDeflateOutputStream : global::System.IO.Stream
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00009E4E File Offset: 0x0000804E
		public ParallelDeflateOutputStream(global::System.IO.Stream stream) : this(stream, global::Ionic.Zlib.CompressionLevel.Default, global::Ionic.Zlib.CompressionStrategy.Default, false)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00009E5A File Offset: 0x0000805A
		public ParallelDeflateOutputStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionLevel level) : this(stream, level, global::Ionic.Zlib.CompressionStrategy.Default, false)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00009E66 File Offset: 0x00008066
		public ParallelDeflateOutputStream(global::System.IO.Stream stream, bool leaveOpen) : this(stream, global::Ionic.Zlib.CompressionLevel.Default, global::Ionic.Zlib.CompressionStrategy.Default, leaveOpen)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00009E72 File Offset: 0x00008072
		public ParallelDeflateOutputStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionLevel level, bool leaveOpen) : this(stream, global::Ionic.Zlib.CompressionLevel.Default, global::Ionic.Zlib.CompressionStrategy.Default, leaveOpen)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00009E80 File Offset: 0x00008080
		public ParallelDeflateOutputStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionLevel level, global::Ionic.Zlib.CompressionStrategy strategy, bool leaveOpen)
		{
			this._outStream = stream;
			this._compressLevel = level;
			this.Strategy = strategy;
			this._leaveOpen = leaveOpen;
			this.MaxBufferPairs = 16;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00009EEF File Offset: 0x000080EF
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00009EF7 File Offset: 0x000080F7
		public global::Ionic.Zlib.CompressionStrategy Strategy { get; private set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00009F00 File Offset: 0x00008100
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00009F08 File Offset: 0x00008108
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00009F25 File Offset: 0x00008125
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00009F2D File Offset: 0x0000812D
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

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00009F4E File Offset: 0x0000814E
		public int Crc32
		{
			get
			{
				return this._Crc32;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00009F56 File Offset: 0x00008156
		public long BytesProcessed
		{
			get
			{
				return this._totalBytesProcessed;
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00009F60 File Offset: 0x00008160
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

		// Token: 0x060000D4 RID: 212 RVA: 0x0000A018 File Offset: 0x00008218
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
					goto IL_98;
				}
				if (this._toFill.Count != 0)
				{
					num = this._toFill.Dequeue();
					this._lastFilled++;
					goto IL_98;
				}
				mustWait = true;
				IL_145:
				if (count <= 0)
				{
					return;
				}
				continue;
				IL_98:
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
				goto IL_145;
			}
			throw new global::System.Exception("Cannot enqueue workitem");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000A174 File Offset: 0x00008374
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

		// Token: 0x060000D6 RID: 214 RVA: 0x0000A230 File Offset: 0x00008430
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

		// Token: 0x060000D7 RID: 215 RVA: 0x0000A297 File Offset: 0x00008497
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

		// Token: 0x060000D8 RID: 216 RVA: 0x0000A2CC File Offset: 0x000084CC
		public override void Close()
		{
			this.InnerClose();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000A2D4 File Offset: 0x000084D4
		private void InnerClose()
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
				this._outStream.Dispose();
			}
			this._isClosed = true;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000A337 File Offset: 0x00008537
		public new void Dispose()
		{
			this._pool = null;
			this.Dispose(true);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000A347 File Offset: 0x00008547
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			this.InnerClose();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000A358 File Offset: 0x00008558
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

		// Token: 0x060000DD RID: 221 RVA: 0x0000A420 File Offset: 0x00008620
		private void EmitPendingBuffers(bool doAll, bool mustWait)
		{
			if (this.emitting)
			{
				return;
			}
			this.emitting = true;
			if ((doAll && this._latestCompressed != this._lastFilled) || mustWait)
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

		// Token: 0x060000DE RID: 222 RVA: 0x0000A5E8 File Offset: 0x000087E8
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

		// Token: 0x060000DF RID: 223 RVA: 0x0000A710 File Offset: 0x00008910
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

		// Token: 0x060000E0 RID: 224 RVA: 0x0000A784 File Offset: 0x00008984
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000A7FC File Offset: 0x000089FC
		public override bool CanWrite
		{
			get
			{
				return this._outStream.CanWrite;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000A810 File Offset: 0x00008A10
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000A809 File Offset: 0x00008A09
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

		// Token: 0x060000E7 RID: 231 RVA: 0x0000A809 File Offset: 0x00008A09
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000A809 File Offset: 0x00008A09
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040000E0 RID: 224
		private static readonly int IO_BUFFER_SIZE_DEFAULT = 65536;

		// Token: 0x040000E1 RID: 225
		private static readonly int BufferPairsPerCore = 4;

		// Token: 0x040000E2 RID: 226
		private global::System.Collections.Generic.List<global::Ionic.Zlib.WorkItem> _pool;

		// Token: 0x040000E3 RID: 227
		private bool _leaveOpen;

		// Token: 0x040000E4 RID: 228
		private bool emitting;

		// Token: 0x040000E5 RID: 229
		private global::System.IO.Stream _outStream;

		// Token: 0x040000E6 RID: 230
		private int _maxBufferPairs;

		// Token: 0x040000E7 RID: 231
		private int _bufferSize = global::Ionic.Zlib.ParallelDeflateOutputStream.IO_BUFFER_SIZE_DEFAULT;

		// Token: 0x040000E8 RID: 232
		private global::System.Threading.AutoResetEvent _newlyCompressedBlob;

		// Token: 0x040000E9 RID: 233
		private object _outputLock = new object();

		// Token: 0x040000EA RID: 234
		private bool _isClosed;

		// Token: 0x040000EB RID: 235
		private bool _firstWriteDone;

		// Token: 0x040000EC RID: 236
		private int _currentlyFilling;

		// Token: 0x040000ED RID: 237
		private int _lastFilled;

		// Token: 0x040000EE RID: 238
		private int _lastWritten;

		// Token: 0x040000EF RID: 239
		private int _latestCompressed;

		// Token: 0x040000F0 RID: 240
		private int _Crc32;

		// Token: 0x040000F1 RID: 241
		private global::Ionic.Crc.CRC32 _runningCrc;

		// Token: 0x040000F2 RID: 242
		private object _latestLock = new object();

		// Token: 0x040000F3 RID: 243
		private global::System.Collections.Generic.Queue<int> _toWrite;

		// Token: 0x040000F4 RID: 244
		private global::System.Collections.Generic.Queue<int> _toFill;

		// Token: 0x040000F5 RID: 245
		private long _totalBytesProcessed;

		// Token: 0x040000F6 RID: 246
		private global::Ionic.Zlib.CompressionLevel _compressLevel;

		// Token: 0x040000F7 RID: 247
		private volatile global::System.Exception _pendingException;

		// Token: 0x040000F8 RID: 248
		private bool _handlingException;

		// Token: 0x040000F9 RID: 249
		private object _eLock = new object();

		// Token: 0x040000FA RID: 250
		private global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits _DesiredTrace = global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.EmitLock | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.EmitEnter | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.EmitBegin | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.EmitDone | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.EmitSkip | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.Session | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.Compress | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.WriteEnter | global::Ionic.Zlib.ParallelDeflateOutputStream.TraceBits.WriteTake;

		// Token: 0x02000071 RID: 113
		[global::System.Flags]
		private enum TraceBits : uint
		{
			// Token: 0x040003F8 RID: 1016
			None = 0U,
			// Token: 0x040003F9 RID: 1017
			NotUsed1 = 1U,
			// Token: 0x040003FA RID: 1018
			EmitLock = 2U,
			// Token: 0x040003FB RID: 1019
			EmitEnter = 4U,
			// Token: 0x040003FC RID: 1020
			EmitBegin = 8U,
			// Token: 0x040003FD RID: 1021
			EmitDone = 16U,
			// Token: 0x040003FE RID: 1022
			EmitSkip = 32U,
			// Token: 0x040003FF RID: 1023
			EmitAll = 58U,
			// Token: 0x04000400 RID: 1024
			Flush = 64U,
			// Token: 0x04000401 RID: 1025
			Lifecycle = 128U,
			// Token: 0x04000402 RID: 1026
			Session = 256U,
			// Token: 0x04000403 RID: 1027
			Synch = 512U,
			// Token: 0x04000404 RID: 1028
			Instance = 1024U,
			// Token: 0x04000405 RID: 1029
			Compress = 2048U,
			// Token: 0x04000406 RID: 1030
			Write = 4096U,
			// Token: 0x04000407 RID: 1031
			WriteEnter = 8192U,
			// Token: 0x04000408 RID: 1032
			WriteTake = 16384U,
			// Token: 0x04000409 RID: 1033
			All = 4294967295U
		}
	}
}
