using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Ionic.BZip2
{
	// Token: 0x02000068 RID: 104
	public class ParallelBZip2OutputStream : global::System.IO.Stream
	{
		// Token: 0x06000526 RID: 1318 RVA: 0x0001FE7F File Offset: 0x0001E07F
		public ParallelBZip2OutputStream(global::System.IO.Stream output) : this(output, global::Ionic.BZip2.BZip2.MaxBlockSize, false)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0001FE8E File Offset: 0x0001E08E
		public ParallelBZip2OutputStream(global::System.IO.Stream output, int blockSize) : this(output, blockSize, false)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0001FE99 File Offset: 0x0001E099
		public ParallelBZip2OutputStream(global::System.IO.Stream output, bool leaveOpen) : this(output, global::Ionic.BZip2.BZip2.MaxBlockSize, leaveOpen)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001FEA8 File Offset: 0x0001E0A8
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

		// Token: 0x0600052A RID: 1322 RVA: 0x0001FF7C File Offset: 0x0001E17C
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0002001A File Offset: 0x0001E21A
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00020022 File Offset: 0x0001E222
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

		// Token: 0x0600052D RID: 1325 RVA: 0x00020040 File Offset: 0x0001E240
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

		// Token: 0x0600052E RID: 1326 RVA: 0x000200C0 File Offset: 0x0001E2C0
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

		// Token: 0x0600052F RID: 1327 RVA: 0x00020119 File Offset: 0x0001E319
		public override void Flush()
		{
			if (this.output != null)
			{
				this.FlushOutput(false);
				this.bw.Flush();
				this.output.Flush();
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00020140 File Offset: 0x0001E340
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

		// Token: 0x06000531 RID: 1329 RVA: 0x0002017C File Offset: 0x0001E37C
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

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x000201F6 File Offset: 0x0001E3F6
		public int BlockSize
		{
			get
			{
				return this.blockSize100k;
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00020200 File Offset: 0x0001E400
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
					goto IL_101;
				}
				if (this.toFill.Count != 0)
				{
					index = this.toFill.Dequeue();
					this.lastFilled++;
					goto IL_101;
				}
				mustWait = true;
				IL_172:
				if (num2 <= 0)
				{
					goto Block_12;
				}
				continue;
				IL_101:
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
				goto IL_172;
			}
			throw new global::System.Exception("Cannot enqueue workitem");
			Block_12:
			this.totalBytesWrittenIn += (long)num;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00020398 File Offset: 0x0001E598
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

		// Token: 0x06000535 RID: 1333 RVA: 0x000205D8 File Offset: 0x0001E7D8
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x000206D4 File Offset: 0x0001E8D4
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

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x000060ED File Offset: 0x000042ED
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x000206F4 File Offset: 0x0001E8F4
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x000060ED File Offset: 0x000042ED
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x000206FC File Offset: 0x0001E8FC
		public long BytesWrittenOut
		{
			get
			{
				return this.totalBytesWrittenOut;
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000060ED File Offset: 0x000042ED
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000060ED File Offset: 0x000042ED
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000060ED File Offset: 0x000042ED
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00020704 File Offset: 0x0001E904
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

		// Token: 0x0400039A RID: 922
		private static readonly int BufferPairsPerCore = 4;

		// Token: 0x0400039B RID: 923
		private int _maxWorkers;

		// Token: 0x0400039C RID: 924
		private bool firstWriteDone;

		// Token: 0x0400039D RID: 925
		private int lastFilled;

		// Token: 0x0400039E RID: 926
		private int lastWritten;

		// Token: 0x0400039F RID: 927
		private int latestCompressed;

		// Token: 0x040003A0 RID: 928
		private int currentlyFilling;

		// Token: 0x040003A1 RID: 929
		private volatile global::System.Exception pendingException;

		// Token: 0x040003A2 RID: 930
		private bool handlingException;

		// Token: 0x040003A3 RID: 931
		private bool emitting;

		// Token: 0x040003A4 RID: 932
		private global::System.Collections.Generic.Queue<int> toWrite;

		// Token: 0x040003A5 RID: 933
		private global::System.Collections.Generic.Queue<int> toFill;

		// Token: 0x040003A6 RID: 934
		private global::System.Collections.Generic.List<global::Ionic.BZip2.WorkItem> pool;

		// Token: 0x040003A7 RID: 935
		private object latestLock = new object();

		// Token: 0x040003A8 RID: 936
		private object eLock = new object();

		// Token: 0x040003A9 RID: 937
		private object outputLock = new object();

		// Token: 0x040003AA RID: 938
		private global::System.Threading.AutoResetEvent newlyCompressedBlob;

		// Token: 0x040003AB RID: 939
		private long totalBytesWrittenIn;

		// Token: 0x040003AC RID: 940
		private long totalBytesWrittenOut;

		// Token: 0x040003AD RID: 941
		private bool leaveOpen;

		// Token: 0x040003AE RID: 942
		private uint combinedCRC;

		// Token: 0x040003AF RID: 943
		private global::System.IO.Stream output;

		// Token: 0x040003B0 RID: 944
		private global::Ionic.BZip2.BitWriter bw;

		// Token: 0x040003B1 RID: 945
		private int blockSize100k;

		// Token: 0x040003B2 RID: 946
		private global::Ionic.BZip2.ParallelBZip2OutputStream.TraceBits desiredTrace = global::Ionic.BZip2.ParallelBZip2OutputStream.TraceBits.Crc | global::Ionic.BZip2.ParallelBZip2OutputStream.TraceBits.Write;

		// Token: 0x02000080 RID: 128
		[global::System.Flags]
		private enum TraceBits : uint
		{
			// Token: 0x0400045E RID: 1118
			None = 0U,
			// Token: 0x0400045F RID: 1119
			Crc = 1U,
			// Token: 0x04000460 RID: 1120
			Write = 2U,
			// Token: 0x04000461 RID: 1121
			All = 4294967295U
		}
	}
}
