using System;
using System.Threading;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003BB RID: 955
	public class ThreadedSeedGenerator
	{
		// Token: 0x060026B2 RID: 9906 RVA: 0x000A84B2 File Offset: 0x000A66B2
		public byte[] GenerateSeed(int numBytes, bool fast)
		{
			return new global::Org.BouncyCastle.Crypto.Prng.ThreadedSeedGenerator.SeedGenerator().GenerateSeed(numBytes, fast);
		}

		// Token: 0x0200080A RID: 2058
		private class SeedGenerator
		{
			// Token: 0x0600466D RID: 18029 RVA: 0x00136AD3 File Offset: 0x00134CD3
			private void Run(object ignored)
			{
				while (!this.stop)
				{
					this.counter++;
				}
			}

			// Token: 0x0600466E RID: 18030 RVA: 0x00136AF4 File Offset: 0x00134CF4
			public byte[] GenerateSeed(int numBytes, bool fast)
			{
				global::System.Threading.ThreadPriority originalPriority = global::System.Threading.Thread.CurrentThread.Priority;
				byte[] result;
				try
				{
					global::System.Threading.Thread.CurrentThread.Priority = global::System.Threading.ThreadPriority.Normal;
					result = this.DoGenerateSeed(numBytes, fast);
				}
				finally
				{
					global::System.Threading.Thread.CurrentThread.Priority = originalPriority;
				}
				return result;
			}

			// Token: 0x0600466F RID: 18031 RVA: 0x00136B40 File Offset: 0x00134D40
			private byte[] DoGenerateSeed(int numBytes, bool fast)
			{
				this.counter = 0;
				this.stop = false;
				byte[] result = new byte[numBytes];
				int last = 0;
				int end = fast ? numBytes : (numBytes * 8);
				global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.Run));
				for (int i = 0; i < end; i++)
				{
					while (this.counter == last)
					{
						try
						{
							global::System.Threading.Thread.Sleep(1);
						}
						catch (global::System.Exception)
						{
						}
					}
					last = this.counter;
					if (fast)
					{
						result[i] = (byte)last;
					}
					else
					{
						int bytepos = i / 8;
						result[bytepos] = (byte)((int)result[bytepos] << 1 | (last & 1));
					}
				}
				this.stop = true;
				return result;
			}

			// Token: 0x040024C6 RID: 9414
			private volatile int counter;

			// Token: 0x040024C7 RID: 9415
			private volatile bool stop;
		}
	}
}
