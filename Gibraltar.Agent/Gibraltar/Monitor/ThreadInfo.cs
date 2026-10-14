using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x020001D1 RID: 465
	[global::System.Diagnostics.DebuggerDisplay("(Thread #{ThreadIndex} : {Description})")]
	internal class ThreadInfo : global::Gibraltar.Monitor.Internal.IDisplayable, global::System.IComparable<global::Gibraltar.Monitor.ThreadInfo>, global::System.IEquatable<global::Gibraltar.Monitor.ThreadInfo>
	{
		// Token: 0x14000071 RID: 113
		// (add) Token: 0x06001606 RID: 5638 RVA: 0x000426A4 File Offset: 0x000408A4
		// (remove) Token: 0x06001607 RID: 5639 RVA: 0x000426E0 File Offset: 0x000408E0
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06001608 RID: 5640 RVA: 0x0004271C File Offset: 0x0004091C
		public ThreadInfo()
		{
			this.m_Packet = new global::Gibraltar.Monitor.Internal.ThreadInfoPacket();
			this.m_Packet.ThreadIndex = global::Gibraltar.Monitor.ThreadInfo.ThreadToken.GetCurrentThreadIndex();
			global::System.Threading.Thread currentThread = global::System.Threading.Thread.CurrentThread;
			this.m_Packet.ThreadId = currentThread.ManagedThreadId;
			this.m_Packet.ThreadName = (currentThread.Name ?? string.Empty);
			this.m_Packet.DomainId = global::System.Threading.Thread.GetDomainID();
			this.m_Packet.DomainName = global::System.Threading.Thread.GetDomain().FriendlyName;
			this.m_Packet.IsBackground = currentThread.IsBackground;
			this.m_Packet.IsThreadPoolThread = currentThread.IsThreadPoolThread;
			this.m_ThreadInstance = 0;
			this.m_Caption = null;
			this.m_Description = null;
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000427E4 File Offset: 0x000409E4
		internal ThreadInfo(global::Gibraltar.Monitor.Internal.ThreadInfoPacket packet)
		{
			this.m_Packet = packet;
			this.m_ThreadInstance = 0;
			this.m_Caption = null;
			this.m_Description = null;
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x00042810 File Offset: 0x00040A10
		public string Caption
		{
			get
			{
				if (this.m_Caption == null)
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					if (string.IsNullOrEmpty(this.m_Packet.ThreadName))
					{
						stringBuilder.AppendFormat("Thread {0}", this.m_Packet.ThreadId);
					}
					else
					{
						stringBuilder.Append(this.m_Packet.ThreadName);
					}
					if (this.m_ThreadInstance > 0)
					{
						stringBuilder.AppendFormat(" #{0}", this.m_ThreadInstance);
					}
					this.m_Caption = global::Gibraltar.StringReference.GetReference(stringBuilder.ToString());
				}
				return this.m_Caption;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x000428C0 File Offset: 0x00040AC0
		public string Description
		{
			get
			{
				if (this.m_Description == null)
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					if (this.m_Packet.IsBackground)
					{
						stringBuilder.Append(this.m_Packet.IsThreadPoolThread ? "ThreadPool Thread " : "Background Thread ");
					}
					else
					{
						stringBuilder.Append("Foreground Thread ");
					}
					stringBuilder.Append(this.m_Packet.ThreadId);
					if (!string.IsNullOrEmpty(this.m_Packet.ThreadName))
					{
						stringBuilder.AppendFormat(" {0}", this.m_Packet.ThreadName);
					}
					if (this.m_ThreadInstance > 0)
					{
						stringBuilder.AppendFormat(" #{0}", this.m_ThreadInstance);
					}
					this.m_Description = global::Gibraltar.StringReference.GetReference(stringBuilder.ToString());
				}
				return this.m_Description;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x000429AC File Offset: 0x00040BAC
		public global::System.Guid Id
		{
			get
			{
				return this.m_Packet.ID;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x000429BC File Offset: 0x00040BBC
		public int ThreadId
		{
			get
			{
				return this.m_Packet.ThreadId;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x000429CC File Offset: 0x00040BCC
		public int ThreadIndex
		{
			get
			{
				return this.m_Packet.ThreadIndex;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x000429DC File Offset: 0x00040BDC
		// (set) Token: 0x06001610 RID: 5648 RVA: 0x000429E8 File Offset: 0x00040BE8
		public int ThreadInstance
		{
			get
			{
				return this.m_ThreadInstance;
			}
			set
			{
				if (this.m_ThreadInstance != value)
				{
					this.m_ThreadInstance = value;
					this.m_Caption = null;
					this.m_Description = null;
				}
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x00042A14 File Offset: 0x00040C14
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x00042A24 File Offset: 0x00040C24
		public string ThreadName
		{
			get
			{
				return this.m_Packet.ThreadName;
			}
			set
			{
				if (this.m_Packet.ThreadName != value)
				{
					this.m_Packet.ThreadName = value;
					this.SendPropertyChanged("ThreadName");
				}
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x00042A54 File Offset: 0x00040C54
		public int DomainId
		{
			get
			{
				return this.m_Packet.DomainId;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x00042A64 File Offset: 0x00040C64
		public string DomainName
		{
			get
			{
				return this.m_Packet.DomainName;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00042A74 File Offset: 0x00040C74
		public bool IsBackground
		{
			get
			{
				return this.m_Packet.IsBackground;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x00042A84 File Offset: 0x00040C84
		public bool IsThreadPoolThread
		{
			get
			{
				return this.m_Packet.IsThreadPoolThread;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00042A94 File Offset: 0x00040C94
		internal global::Gibraltar.Monitor.Internal.ThreadInfoPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x00042A9C File Offset: 0x00040C9C
		internal bool IsStillAlive
		{
			get
			{
				return global::Gibraltar.Monitor.ThreadInfo.ThreadToken.IsThreadStillAlive(this.ThreadIndex);
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00042AAC File Offset: 0x00040CAC
		internal static bool IsThreadStillAlive(int threadIndex)
		{
			return global::Gibraltar.Monitor.ThreadInfo.ThreadToken.IsThreadStillAlive(threadIndex);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00042AB4 File Offset: 0x00040CB4
		internal static int GetCurrentThreadIndex()
		{
			return global::Gibraltar.Monitor.ThreadInfo.ThreadToken.GetCurrentThreadIndex();
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00042ABC File Offset: 0x00040CBC
		private void SendPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00042ADC File Offset: 0x00040CDC
		public int CompareTo(global::Gibraltar.Monitor.ThreadInfo other)
		{
			if (other == null)
			{
				return 1;
			}
			if (this == other)
			{
				return 0;
			}
			int num = this.ThreadId.CompareTo(other.ThreadId);
			if (num == 0)
			{
				num = this.m_Packet.ThreadIndex.CompareTo(other.ThreadIndex);
			}
			if (num == 0)
			{
				num = this.m_Packet.Timestamp.CompareTo(other.Packet.Timestamp);
			}
			if (num == 0)
			{
				num = this.m_Packet.Sequence.CompareTo(other.Packet.Sequence);
			}
			if (num == 0)
			{
				num = this.Id.CompareTo(other.Id);
			}
			return num;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00042B9C File Offset: 0x00040D9C
		public bool Equals(global::Gibraltar.Monitor.ThreadInfo other)
		{
			return this.CompareTo(other) == 0;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00042BB0 File Offset: 0x00040DB0
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.ThreadInfo other = obj as global::Gibraltar.Monitor.ThreadInfo;
			return this.Equals(other);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00042BD0 File Offset: 0x00040DD0
		public override int GetHashCode()
		{
			return this.Id.GetHashCode();
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00042BF8 File Offset: 0x00040DF8
		public static bool operator ==(global::Gibraltar.Monitor.ThreadInfo left, global::Gibraltar.Monitor.ThreadInfo right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00042C0C File Offset: 0x00040E0C
		public static bool operator !=(global::Gibraltar.Monitor.ThreadInfo left, global::Gibraltar.Monitor.ThreadInfo right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00042C24 File Offset: 0x00040E24
		public static bool operator <(global::Gibraltar.Monitor.ThreadInfo left, global::Gibraltar.Monitor.ThreadInfo right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00042C30 File Offset: 0x00040E30
		public static bool operator >(global::Gibraltar.Monitor.ThreadInfo left, global::Gibraltar.Monitor.ThreadInfo right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x04000715 RID: 1813
		private readonly global::Gibraltar.Monitor.Internal.ThreadInfoPacket m_Packet;

		// Token: 0x04000716 RID: 1814
		private volatile int m_ThreadInstance;

		// Token: 0x04000717 RID: 1815
		private volatile string m_Caption;

		// Token: 0x04000718 RID: 1816
		private volatile string m_Description;

		// Token: 0x020004A8 RID: 1192
		private class ThreadToken
		{
			// Token: 0x06003372 RID: 13170 RVA: 0x000BA748 File Offset: 0x000B8948
			private ThreadToken(int threadIndex)
			{
				this.m_ThreadIndex = threadIndex;
			}

			// Token: 0x17000EC3 RID: 3779
			// (get) Token: 0x06003373 RID: 13171 RVA: 0x000BA758 File Offset: 0x000B8958
			private int ThreadIndex
			{
				get
				{
					return this.m_ThreadIndex;
				}
			}

			// Token: 0x06003374 RID: 13172 RVA: 0x000BA760 File Offset: 0x000B8960
			internal static int GetCurrentThreadIndex()
			{
				int num;
				if (global::Gibraltar.Monitor.ThreadInfo.ThreadToken.t_ThreadToken == null)
				{
					num = global::Gibraltar.Monitor.ThreadInfo.ThreadToken.GetNextThreadIndex();
					global::Gibraltar.Monitor.ThreadInfo.ThreadToken target = new global::Gibraltar.Monitor.ThreadInfo.ThreadToken(num);
					object mapLock = global::Gibraltar.Monitor.ThreadInfo.ThreadToken.MapLock;
					lock (mapLock)
					{
						global::Gibraltar.Monitor.ThreadInfo.ThreadToken.ThreadTokenMap[num] = new global::System.WeakReference(target);
					}
					global::Gibraltar.Monitor.ThreadInfo.ThreadToken.t_ThreadToken = target;
				}
				else
				{
					num = global::Gibraltar.Monitor.ThreadInfo.ThreadToken.t_ThreadToken.ThreadIndex;
				}
				return num;
			}

			// Token: 0x06003375 RID: 13173 RVA: 0x000BA7D4 File Offset: 0x000B89D4
			internal static bool IsThreadStillAlive(int threadIndex)
			{
				object mapLock = global::Gibraltar.Monitor.ThreadInfo.ThreadToken.MapLock;
				global::System.WeakReference weakReference;
				bool flag;
				lock (mapLock)
				{
					flag = global::Gibraltar.Monitor.ThreadInfo.ThreadToken.ThreadTokenMap.TryGetValue(threadIndex, out weakReference);
				}
				if (flag)
				{
					flag = (weakReference != null && weakReference.IsAlive);
				}
				return flag;
			}

			// Token: 0x06003376 RID: 13174 RVA: 0x000BA834 File Offset: 0x000B8A34
			private static int GetNextThreadIndex()
			{
				return global::System.Threading.Interlocked.Increment(ref global::Gibraltar.Monitor.ThreadInfo.ThreadToken.s_LatestThreadIndex);
			}

			// Token: 0x0400138C RID: 5004
			[global::System.ThreadStatic]
			private static global::Gibraltar.Monitor.ThreadInfo.ThreadToken t_ThreadToken;

			// Token: 0x0400138D RID: 5005
			private static int s_LatestThreadIndex;

			// Token: 0x0400138E RID: 5006
			private static readonly global::System.Collections.Generic.Dictionary<int, global::System.WeakReference> ThreadTokenMap = new global::System.Collections.Generic.Dictionary<int, global::System.WeakReference>();

			// Token: 0x0400138F RID: 5007
			private static readonly object MapLock = new object();

			// Token: 0x04001390 RID: 5008
			private readonly int m_ThreadIndex;
		}
	}
}
