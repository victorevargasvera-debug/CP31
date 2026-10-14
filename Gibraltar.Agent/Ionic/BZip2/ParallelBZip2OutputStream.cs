using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Ionic.BZip2
{
	// Token: 0x02000447 RID: 1095
	internal class ParallelBZip2OutputStream : global::System.IO.Stream
	{
		// Token: 0x06002F82 RID: 12162 RVA: 0x000A9000 File Offset: 0x000A7200
		public ParallelBZip2OutputStream(global::System.IO.Stream output) : this(output, global::Ionic.BZip2.BZip2.MaxBlockSize, false)
		{
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x000A9010 File Offset: 0x000A7210
		public ParallelBZip2OutputStream(global::System.IO.Stream output, int blockSize) : this(output, blockSize, false)
		{
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x000A901C File Offset: 0x000A721C
		public ParallelBZip2OutputStream(global::System.IO.Stream output, bool leaveOpen) : this(output, global::Ionic.BZip2.BZip2.MaxBlockSize, leaveOpen)
		{
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x000A902C File Offset: 0x000A722C
		public ParallelBZip2OutputStream(global::System.IO.Stream output, int blockSize, bool leaveOpen)
		{
			if (blockSize < global::Ionic.BZip2.BZip2.MinBlockSize || blockSize > global::Ionic.BZip2.BZip2.MaxBlockSize)
			{
				throw new global::System.ArgumentException(string.Format("blockSize={0} is out of range; must be between {1} and {2}", blockSize, global::Ionic.BZip2.BZip2.MinBlockSize, global::Ionic.BZip2.BZip2.MaxBlockSize), "blockSize");
			}
			this.output = output;
			if (!this.output.CanWrite)
			{
				throw new global::System.ArgumentException("The stream is not writable.", "output");
			}
			this.bw = new global::Ionic.BZip2.BitWriter(this.output);
			this.blockSize100k = blockSize;
			this.leaveOpen = leaveOpen;
			this.combinedCRC = 0U;
			this.MaxWorkers = 16;
			this.EmitHeader();
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x000A910C File Offset: 0x000A730C
		private void InitializePoolOfWorkItems()
		{
			this.toWrite = new global::System.Collections.Generic.Queue<int>();
			this.toFill = new global::System.Collections.Generic.Queue<int>();
			this.pool = new global::System.Collections.Generic.List<global::Ionic.BZip2.WorkItem>();
			int num = global::Ionic.BZip2.ParallelBZip2OutputStream.BufferPairsPerCore * global::System.Environment.ProcessorCount;
			num = global::System.Math.Min(num, this.MaxWorkers);
			for (int i = 0; i < num; i++)
			{
				this.pool.Add(new global::Ionic.BZip2.WorkItem(i, this.blockSize100k));
				this.toFill.Enqueue(i);
			}
			this.newlyCompressedBlob = new global::System.Threading.AutoResetEvent(false);
			this.currentlyFilling = -1;
			this.lastFilled = -1;
			this.lastWritten = -1;
			this.latestCompressed = -1;
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x000A91B4 File Offset: 0x000A73B4
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x000A91BC File Offset: 0x000A73BC
		public int MaxWorkers
		{
			get
			{
				return this._maxWorkers;
			}
			set
			{
				if (value < 4)
				{
					throw new global::System.ArgumentException("MaxWorkers", "Value must be 4 or greater.");
				}
				this._maxWorkers = value;
			}
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x000A91DC File Offset: 0x000A73DC
		public override void Close()
		{
			if (this.pendingException != null)
			{
				this.handlingException = true;
				global::System.Exception ex = this.pendingException;
				this.pendingException = null;
				throw ex;
			}
			if (this.handlingException)
			{
				return;
			}
			if (this.output == null)
			{
				return;
			}
			global::System.IO.Stream stream = this.output;
			try
			{
				this.FlushOutput(true);
			}
			finally
			{
				this.output = null;
				this.bw = null;
			}
			if (!this.leaveOpen)
			{
				stream.Close();
			}
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x000A926C File Offset: 0x000A746C
		private void FlushOutput(bool lastInput)
		{
			if (this.emitting)
			{
				return;
			}
			if (this.currentlyFilling >= 0)
			{
				global::Ionic.BZip2.WorkItem wi = this.pool[this.currentlyFilling];
				this.CompressOne(wi);
				this.currentlyFilling = -1;
			}
			if (lastInput)
			{
				this.EmitPendingBuffers(true, false);
				this.EmitTrailer();
				return;
			}
			this.EmitPendingBuffers(false, false);
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x000A92D4 File Offset: 0x000A74D4
		public override void Flush()
		{
			if (this.output != null)
			{
				this.FlushOutput(false);
				this.bw.Flush();
				this.output.Flush();
			}
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x000A9300 File Offset: 0x000A7500
		private void EmitHeader()
		{
			byte[] array = new byte[]
			{
				66,
				90,
				104,
				0
			};
			this.output.Write(array, 0, array.Length);
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x000A9340 File Offset: 0x000A7540
		private void EmitTrailer()
		{
			this.bw.WriteByte(23);
			this.bw.WriteByte(114);
			this.bw.WriteByte(69);
			this.bw.WriteByte(56);
			this.bw.WriteByte(80);
			this.bw.WriteByte(144);
			this.bw.WriteInt(this.combinedCRC);
			this.bw.FinishAndPad();
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x000A93C0 File Offset: 0x000A75C0
		public int BlockSize
		{
			get
			{
				return this.blockSize100k;
			}
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x000A93C8 File Offset: 0x000A75C8
		public override void Write(byte[] buffer, int offset, int count)
		{
			bool mustWait = false;
			if (this.output == null)
			{
				throw new global::System.IO.IOException("the stream is not open");
			}
			if (this.pendingException != null)
			{
				this.handlingException = true;
				global::System.Exception ex = this.pendingException;
				this.pendingException = null;
				throw ex;
			}
			if (offset < 0)
			{
				throw new global::System.IndexOutOfRangeException(string.Format("offset ({0}) must be > 0", offset));
			}
			if (count < 0)
			{
				throw new global::System.IndexOutOfRangeException(string.Format("count ({0}) must be > 0", count));
			}
			if (offset + count > buffer.Length)
			{
				throw new global::System.IndexOutOfRangeException(string.Format("offset({0}) count({1}) bLength({2})", offset, count, buffer.Length));
			}
			if (count == 0)
			{
				return;
			}
			if (!this.firstWriteDone)
			{
				this.InitializePoolOfWorkItems();
				this.firstWriteDone = true;
			}
			int num = 0;
			int num2 = count;
			for (;;)
			{
				this.EmitPendingBuffers(false, mustWait);
				mustWait = false;
				int index;
				if (this.currentlyFilling >= 0)
				{
					index = this.currentlyFilling;
					goto IL_11F;
				}
				if (this.toFill.Count != 0)
				{
					index = this.toFill.Dequeue();
					this.lastFilled++;
					goto IL_11F;
				}
				mustWait = true;
				IL_199:
				if (num2 <= 0)
				{
					goto Block_12;
				}
				continue;
				IL_11F:
				global::Ionic.BZip2.WorkItem workItem = this.pool[index];
				workItem.ordinal = this.lastFilled;
				int num3 = workItem.Compressor.Fill(buffer, offset, num2);
				if (num3 != num2)
				{
					if (!global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.CompressOne), workItem))
					{
						break;
					}
					this.currentlyFilling = -1;
					offset += num3;
				}
				else
				{
					this.currentlyFilling = index;
				}
				num2 -= num3;
				num += num3;
				goto IL_199;
			}
			throw new global::System.Exception("Cannot enqueue workitem");
			Block_12:
			this.totalBytesWrittenIn += (long)num;
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x000A9588 File Offset: 0x000A7788
		private void EmitPendingBuffers(bool doAll, bool mustWait)
		{
			if (this.emitting)
			{
				return;
			}
			this.emitting = true;
			if (doAll || mustWait)
			{
				this.newlyCompressedBlob.WaitOne();
			}
			do
			{
				int num = -1;
				int num2 = doAll ? 200 : (mustWait ? -1 : 0);
				int num3 = -1;
				do
				{
					if (global::System.Threading.Monitor.TryEnter(this.toWrite, num2))
					{
						num3 = -1;
						try
						{
							if (this.toWrite.Count > 0)
							{
								num3 = this.toWrite.Dequeue();
							}
						}
						finally
						{
							global::System.Threading.Monitor.Exit(this.toWrite);
						}
						if (num3 >= 0)
						{
							global::Ionic.BZip2.WorkItem workItem = this.pool[num3];
							if (workItem.ordinal != this.lastWritten + 1)
							{
								global::System.Collections.Generic.Queue<int> obj = this.toWrite;
								lock (obj)
								{
									this.toWrite.Enqueue(num3);
								}
								if (num == num3)
								{
									this.newlyCompressedBlob.WaitOne();
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
								global::Ionic.BZip2.BitWriter bitWriter = workItem.bw;
								bitWriter.Flush();
								global::System.IO.MemoryStream ms = workItem.ms;
								ms.Seek(0L, global::System.IO.SeekOrigin.Begin);
								long num4 = 0L;
								byte[] array = new byte[1024];
								int num5;
								while ((num5 = ms.Read(array, 0, array.Length)) > 0)
								{
									for (int i = 0; i < num5; i++)
									{
										this.bw.WriteByte(array[i]);
									}
									num4 += (long)num5;
								}
								if (bitWriter.NumRemainingBits > 0)
								{
									this.bw.WriteBits(bitWriter.NumRemainingBits, (uint)bitWriter.RemainingBits);
								}
								this.combinedCRC = (this.combinedCRC << 1 | this.combinedCRC >> 31);
								this.combinedCRC ^= workItem.Compressor.Crc32;
								this.totalBytesWrittenOut += num4;
								bitWriter.Reset();
								this.lastWritten = workItem.ordinal;
								workItem.ordinal = -1;
								this.toFill.Enqueue(workItem.index);
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
			while (doAll && this.lastWritten != this.latestCompressed);
			this.emitting = false;
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x000A97F4 File Offset: 0x000A79F4
		private void CompressOne(object wi)
		{
			global::Ionic.BZip2.WorkItem workItem = (global::Ionic.BZip2.WorkItem)wi;
			try
			{
				workItem.Compressor.CompressAndWrite();
				object obj = this.latestLock;
				lock (obj)
				{
					if (workItem.ordinal > this.latestCompressed)
					{
						this.latestCompressed = workItem.ordinal;
					}
				}
				global::System.Collections.Generic.Queue<int> obj2 = this.toWrite;
				lock (obj2)
				{
					this.toWrite.Enqueue(workItem.index);
				}
				this.newlyCompressedBlob.Set();
			}
			catch (global::System.Exception ex)
			{
				object obj = this.eLock;
				lock (obj)
				{
					if (this.pendingException != null)
					{
						this.pendingException = ex;
					}
				}
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x000A98F0 File Offset: 0x000A7AF0
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002F93 RID: 12179 RVA: 0x000A98F4 File Offset: 0x000A7AF4
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06002F94 RID: 12180 RVA: 0x000A98F8 File Offset: 0x000A7AF8
		public override bool CanWrite
		{
			get
			{
				if (this.output == null)
				{
					throw new global::System.ObjectDisposedException("BZip2Stream");
				}
				return this.output.CanWrite;
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x000A991C File Offset: 0x000A7B1C
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x000A9924 File Offset: 0x000A7B24
		// (set) Token: 0x06002F97 RID: 12183 RVA: 0x000A992C File Offset: 0x000A7B2C
		public override long Position
		{
			get
			{
				return this.totalBytesWrittenIn;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x000A9934 File Offset: 0x000A7B34
		public long BytesWrittenOut
		{
			get
			{
				return this.totalBytesWrittenOut;
			}
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x000A993C File Offset: 0x000A7B3C
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x000A9944 File Offset: 0x000A7B44
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x000A994C File Offset: 0x000A7B4C
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x000A9954 File Offset: 0x000A7B54
		[global::System.Diagnostics.Conditional("Trace")]
		private void TraceOutput(global::Ionic.BZip2.ParallelBZip2OutputStream.TraceBits bits, string format, params object[] varParams)
		{
			if ((bits & this.desiredTrace) != global::Ionic.BZip2.ParallelBZip2OutputStream.TraceBits.None)
			{
				object obj = this.outputLock;
				lock (obj)
				{
					int hashCode = global::System.Threading.Thread.CurrentThread.GetHashCode();
					global::System.Console.ForegroundColor = hashCode % 8 + global::System.ConsoleColor.Green;
					global::System.Console.Write("{0:000} PBOS ", hashCode);
					global::System.Console.WriteLine(format, varParams);
					global::System.Console.ResetColor();
				}
			}
		}

		// Token: 0x04001136 RID: 4406
		private static readonly int BufferPairsPerCore = 4;

		// Token: 0x04001137 RID: 4407
		private int _maxWorkers;

		// Token: 0x04001138 RID: 4408
		private bool firstWriteDone;

		// Token: 0x04001139 RID: 4409
		private int lastFilled;

		// Token: 0x0400113A RID: 4410
		private int lastWritten;

		// Token: 0x0400113B RID: 4411
		private int latestCompressed;

		// Token: 0x0400113C RID: 4412
		private int currentlyFilling;

		// Token: 0x0400113D RID: 4413
		private volatile global::System.Exception pendingException;

		// Token: 0x0400113E RID: 4414
		private bool handlingException;

		// Token: 0x0400113F RID: 4415
		private bool emitting;

		// Token: 0x04001140 RID: 4416
		private global::System.Collections.Generic.Queue<int> toWrite;

		// Token: 0x04001141 RID: 4417
		private global::System.Collections.Generic.Queue<int> toFill;

		// Token: 0x04001142 RID: 4418
		private global::System.Collections.Generic.List<global::Ionic.BZip2.WorkItem> pool;

		// Token: 0x04001143 RID: 4419
		private object latestLock = new object();

		// Token: 0x04001144 RID: 4420
		private object eLock = new object();

		// Token: 0x04001145 RID: 4421
		private object outputLock = new object();

		// Token: 0x04001146 RID: 4422
		private global::System.Threading.AutoResetEvent newlyCompressedBlob;

		// Token: 0x04001147 RID: 4423
		private long totalBytesWrittenIn;

		// Token: 0x04001148 RID: 4424
		private long totalBytesWrittenOut;

		// Token: 0x04001149 RID: 4425
		private bool leaveOpen;

		// Token: 0x0400114A RID: 4426
		private uint combinedCRC;

		// Token: 0x0400114B RID: 4427
		private global::System.IO.Stream output;

		// Token: 0x0400114C RID: 4428
		private global::Ionic.BZip2.BitWriter bw;

		// Token: 0x0400114D RID: 4429
		private int blockSize100k;

		// Token: 0x0400114E RID: 4430
		private global::Ionic.BZip2.ParallelBZip2OutputStream.TraceBits desiredTrace = global::Ionic.BZip2.ParallelBZip2OutputStream.TraceBits.Crc | global::Ionic.BZip2.ParallelBZip2OutputStream.TraceBits.Write;

		// Token: 0x020004E5 RID: 1253
		[global::System.Flags]
		private enum TraceBits : uint
		{
			// Token: 0x0400145C RID: 5212
			None = 0U,
			// Token: 0x0400145D RID: 5213
			Crc = 1U,
			// Token: 0x0400145E RID: 5214
			Write = 2U,
			// Token: 0x0400145F RID: 5215
			All = 4294967295U
		}
	}
}
