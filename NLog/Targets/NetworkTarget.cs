using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using NLog.Common;
using NLog.Internal;
using NLog.Internal.NetworkSenders;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000047 RID: 71
	[global::NLog.Targets.Target("Network")]
	public class NetworkTarget : global::NLog.Targets.TargetWithLayout
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x00010730 File Offset: 0x0000E930
		public NetworkTarget()
		{
			this.SenderFactory = global::NLog.Internal.NetworkSenders.NetworkSenderFactory.Default;
			this.Encoding = global::System.Text.Encoding.UTF8;
			this.OnOverflow = global::NLog.Targets.NetworkTargetOverflowAction.Split;
			this.KeepConnection = true;
			this.MaxMessageSize = 65000;
			this.ConnectionCacheSize = 5;
			this.LineEnding = global::NLog.Targets.LineEndingMode.CRLF;
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.NetworkTarget));
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000107C5 File Offset: 0x0000E9C5
		public NetworkTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x000107D4 File Offset: 0x0000E9D4
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x000107DC File Offset: 0x0000E9DC
		public global::NLog.Layouts.Layout Address { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x000107E5 File Offset: 0x0000E9E5
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x000107ED File Offset: 0x0000E9ED
		[global::System.ComponentModel.DefaultValue(true)]
		public bool KeepConnection { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x000107F6 File Offset: 0x0000E9F6
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x000107FE File Offset: 0x0000E9FE
		[global::System.ComponentModel.DefaultValue(false)]
		public bool NewLine { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00010807 File Offset: 0x0000EA07
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x0001080F File Offset: 0x0000EA0F
		[global::System.ComponentModel.DefaultValue("CRLF")]
		public global::NLog.Targets.LineEndingMode LineEnding { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00010818 File Offset: 0x0000EA18
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00010820 File Offset: 0x0000EA20
		[global::System.ComponentModel.DefaultValue(65000)]
		public int MaxMessageSize { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00010829 File Offset: 0x0000EA29
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00010831 File Offset: 0x0000EA31
		[global::System.ComponentModel.DefaultValue(5)]
		public int ConnectionCacheSize { get; set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0001083A File Offset: 0x0000EA3A
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00010842 File Offset: 0x0000EA42
		public int MaxConnections { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0001084B File Offset: 0x0000EA4B
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00010853 File Offset: 0x0000EA53
		public global::NLog.Targets.NetworkTargetConnectionsOverflowAction OnConnectionOverflow { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0001085C File Offset: 0x0000EA5C
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00010864 File Offset: 0x0000EA64
		[global::System.ComponentModel.DefaultValue(0)]
		public int MaxQueueSize { get; set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0001086D File Offset: 0x0000EA6D
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00010875 File Offset: 0x0000EA75
		[global::System.ComponentModel.DefaultValue(global::NLog.Targets.NetworkTargetOverflowAction.Split)]
		public global::NLog.Targets.NetworkTargetOverflowAction OnOverflow { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0001087E File Offset: 0x0000EA7E
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00010886 File Offset: 0x0000EA86
		[global::System.ComponentModel.DefaultValue("utf-8")]
		public global::System.Text.Encoding Encoding { get; set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0001088F File Offset: 0x0000EA8F
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00010897 File Offset: 0x0000EA97
		internal global::NLog.Internal.NetworkSenders.INetworkSenderFactory SenderFactory { get; set; }

		// Token: 0x060006C9 RID: 1737 RVA: 0x000108A0 File Offset: 0x0000EAA0
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			int remainingCount = 0;
			global::NLog.Common.AsyncContinuation continuation = delegate(global::System.Exception ex)
			{
				if (global::System.Threading.Interlocked.Decrement(ref remainingCount) == 0)
				{
					asyncContinuation(null);
				}
			};
			global::System.Collections.Generic.LinkedList<global::NLog.Internal.NetworkSenders.NetworkSender> openNetworkSenders = this._openNetworkSenders;
			lock (openNetworkSenders)
			{
				remainingCount = this._openNetworkSenders.Count;
				if (remainingCount == 0)
				{
					asyncContinuation(null);
				}
				else
				{
					foreach (global::NLog.Internal.NetworkSenders.NetworkSender networkSender in this._openNetworkSenders)
					{
						networkSender.FlushAsync(continuation);
					}
				}
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00010964 File Offset: 0x0000EB64
		protected override void CloseTarget()
		{
			base.CloseTarget();
			global::System.Collections.Generic.LinkedList<global::NLog.Internal.NetworkSenders.NetworkSender> openNetworkSenders = this._openNetworkSenders;
			lock (openNetworkSenders)
			{
				using (global::System.Collections.Generic.LinkedList<global::NLog.Internal.NetworkSenders.NetworkSender>.Enumerator enumerator = this._openNetworkSenders.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						enumerator.Current.Close(delegate(global::System.Exception ex)
						{
						});
					}
				}
				this._openNetworkSenders.Clear();
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00010A10 File Offset: 0x0000EC10
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			global::NLog.Targets.NetworkTarget.<>c__DisplayClass55_0 CS$<>8__locals1 = new global::NLog.Targets.NetworkTarget.<>c__DisplayClass55_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.logEvent = logEvent;
			string text = base.RenderLogEvent(this.Address, CS$<>8__locals1.logEvent.LogEvent);
			global::NLog.Common.InternalLogger.Trace<string, string>("NetworkTarget(Name={0}): Sending to address: '{1}'", base.Name, text);
			byte[] bytesToWrite = this.GetBytesToWrite(CS$<>8__locals1.logEvent.LogEvent);
			if (this.KeepConnection)
			{
				global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender> senderNode = this.GetCachedNetworkSender(text);
				this.ChunkedSend(senderNode.Value, bytesToWrite, delegate(global::System.Exception ex)
				{
					if (ex != null)
					{
						global::NLog.Common.InternalLogger.Error(ex, "NetworkTarget(Name={0}): Error when sending.", new object[]
						{
							CS$<>8__locals1.<>4__this.Name
						});
						CS$<>8__locals1.<>4__this.ReleaseCachedConnection(senderNode);
					}
					CS$<>8__locals1.logEvent.Continuation(ex);
				});
				return;
			}
			global::System.Collections.Generic.LinkedList<global::NLog.Internal.NetworkSenders.NetworkSender> openNetworkSenders = this._openNetworkSenders;
			global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender> linkedListNode;
			global::NLog.Internal.NetworkSenders.NetworkSender sender;
			lock (openNetworkSenders)
			{
				if (this._openNetworkSenders.Count >= this.MaxConnections && this.MaxConnections > 0)
				{
					switch (this.OnConnectionOverflow)
					{
					case global::NLog.Targets.NetworkTargetConnectionsOverflowAction.AllowNewConnnection:
						global::NLog.Common.InternalLogger.Debug<string>("NetworkTarget(Name={0}): Too may connections, but this is allowed", base.Name);
						break;
					case global::NLog.Targets.NetworkTargetConnectionsOverflowAction.DiscardMessage:
						global::NLog.Common.InternalLogger.Warn<string>("NetworkTarget(Name={0}): Discarding message otherwise to many connections.", base.Name);
						CS$<>8__locals1.logEvent.Continuation(null);
						return;
					case global::NLog.Targets.NetworkTargetConnectionsOverflowAction.Block:
						while (this._openNetworkSenders.Count >= this.MaxConnections)
						{
							global::NLog.Common.InternalLogger.Debug<string>("NetworkTarget(Name={0}): Blocking networktarget otherwhise too many connections.", base.Name);
							global::System.Threading.Monitor.Wait(this._openNetworkSenders);
							global::NLog.Common.InternalLogger.Trace<string>("NetworkTarget(Name={0}): Entered critical section.", base.Name);
						}
						global::NLog.Common.InternalLogger.Trace<string>("NetworkTarget(Name={0}): Limit ok.", base.Name);
						break;
					}
				}
				sender = this.SenderFactory.Create(text, this.MaxQueueSize);
				sender.Initialize();
				linkedListNode = this._openNetworkSenders.AddLast(sender);
			}
			this.ChunkedSend(sender, bytesToWrite, delegate(global::System.Exception ex)
			{
				global::System.Collections.Generic.LinkedList<global::NLog.Internal.NetworkSenders.NetworkSender> openNetworkSenders2 = CS$<>8__locals1.<>4__this._openNetworkSenders;
				lock (openNetworkSenders2)
				{
					global::NLog.Targets.NetworkTarget.TryRemove<global::NLog.Internal.NetworkSenders.NetworkSender>(CS$<>8__locals1.<>4__this._openNetworkSenders, linkedListNode);
					if (CS$<>8__locals1.<>4__this.OnConnectionOverflow == global::NLog.Targets.NetworkTargetConnectionsOverflowAction.Block)
					{
						global::System.Threading.Monitor.PulseAll(CS$<>8__locals1.<>4__this._openNetworkSenders);
					}
				}
				if (ex != null)
				{
					global::NLog.Common.InternalLogger.Error(ex, "NetworkTarget(Name={0}): Error when sending.", new object[]
					{
						CS$<>8__locals1.<>4__this.Name
					});
				}
				sender.Close(delegate(global::System.Exception ex2)
				{
				});
				CS$<>8__locals1.logEvent.Continuation(ex);
			});
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00010C28 File Offset: 0x0000EE28
		private static bool TryRemove<T>(global::System.Collections.Generic.LinkedList<T> list, global::System.Collections.Generic.LinkedListNode<T> node)
		{
			if (node == null || list != node.List)
			{
				return false;
			}
			list.Remove(node);
			return true;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00010C40 File Offset: 0x0000EE40
		protected virtual byte[] GetBytesToWrite(global::NLog.LogEventInfo logEvent)
		{
			if (base.OptimizeBufferReuse)
			{
				object obj;
				if (!this.NewLine && logEvent.TryGetCachedLayoutValue(this.Layout, out obj))
				{
					global::NLog.Common.InternalLogger.Trace<string, object>("NetworkTarget(Name={0}): Sending {1}", base.Name, obj);
					return this.Encoding.GetBytes(obj.ToString());
				}
				using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject = this.ReusableLayoutBuilder.Allocate())
				{
					this.Layout.RenderAppendBuilder(logEvent, lockOject.Result, false);
					if (this.NewLine)
					{
						lockOject.Result.Append(this.LineEnding.NewLineCharacters);
					}
					global::NLog.Common.InternalLogger.Trace<string, int>("NetworkTarget(Name={0}): Sending {1} chars", base.Name, lockOject.Result.Length);
					using (global::NLog.Internal.ReusableObjectCreator<char[]>.LockOject lockOject2 = this._reusableEncodingBuffer.Allocate())
					{
						if (lockOject.Result.Length <= lockOject2.Result.Length)
						{
							lockOject.Result.CopyTo(0, lockOject2.Result, 0, lockOject.Result.Length);
							return this.Encoding.GetBytes(lockOject2.Result, 0, lockOject.Result.Length);
						}
						string s = lockOject.Result.ToString();
						return this.Encoding.GetBytes(s);
					}
				}
			}
			string text = this.Layout.Render(logEvent);
			global::NLog.Common.InternalLogger.Trace<string, string>("NetworkTarget(Name={0}): Sending: {1}", base.Name, text);
			if (this.NewLine)
			{
				text += this.LineEnding.NewLineCharacters;
			}
			return this.Encoding.GetBytes(text);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		private global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender> GetCachedNetworkSender(string address)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender>> currentSenderCache = this._currentSenderCache;
			global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender> result;
			lock (currentSenderCache)
			{
				global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender> linkedListNode;
				if (this._currentSenderCache.TryGetValue(address, out linkedListNode))
				{
					linkedListNode.Value.CheckSocket();
					result = linkedListNode;
				}
				else
				{
					if (this._currentSenderCache.Count >= this.ConnectionCacheSize)
					{
						int num = int.MaxValue;
						global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender> linkedListNode2 = null;
						foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender>> keyValuePair in this._currentSenderCache)
						{
							global::NLog.Internal.NetworkSenders.NetworkSender value = keyValuePair.Value.Value;
							if (value.LastSendTime < num)
							{
								num = value.LastSendTime;
								linkedListNode2 = keyValuePair.Value;
							}
						}
						if (linkedListNode2 != null)
						{
							this.ReleaseCachedConnection(linkedListNode2);
						}
					}
					global::NLog.Internal.NetworkSenders.NetworkSender networkSender = this.SenderFactory.Create(address, this.MaxQueueSize);
					networkSender.Initialize();
					global::System.Collections.Generic.LinkedList<global::NLog.Internal.NetworkSenders.NetworkSender> openNetworkSenders = this._openNetworkSenders;
					lock (openNetworkSenders)
					{
						linkedListNode = this._openNetworkSenders.AddLast(networkSender);
					}
					this._currentSenderCache.Add(address, linkedListNode);
					result = linkedListNode;
				}
			}
			return result;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00010F68 File Offset: 0x0000F168
		private void ReleaseCachedConnection(global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender> senderNode)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender>> currentSenderCache = this._currentSenderCache;
			lock (currentSenderCache)
			{
				global::NLog.Internal.NetworkSenders.NetworkSender value = senderNode.Value;
				global::System.Collections.Generic.LinkedList<global::NLog.Internal.NetworkSenders.NetworkSender> openNetworkSenders = this._openNetworkSenders;
				lock (openNetworkSenders)
				{
					if (global::NLog.Targets.NetworkTarget.TryRemove<global::NLog.Internal.NetworkSenders.NetworkSender>(this._openNetworkSenders, senderNode))
					{
						value.Close(delegate(global::System.Exception ex)
						{
						});
					}
				}
				global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender> linkedListNode;
				if (this._currentSenderCache.TryGetValue(value.Address, out linkedListNode) && senderNode == linkedListNode)
				{
					this._currentSenderCache.Remove(value.Address);
				}
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00011038 File Offset: 0x0000F238
		private void ChunkedSend(global::NLog.Internal.NetworkSenders.NetworkSender sender, byte[] buffer, global::NLog.Common.AsyncContinuation continuation)
		{
			int tosend = buffer.Length;
			if (tosend > this.MaxMessageSize)
			{
				int pos = 0;
				global::NLog.Common.AsyncContinuation sendNextChunk = null;
				sendNextChunk = delegate(global::System.Exception ex)
				{
					if (ex != null)
					{
						continuation(ex);
						return;
					}
					int pos;
					global::NLog.Common.InternalLogger.Trace<string, int, int>("NetworkTarget(Name={0}): Sending chunk, position: {1}, length: {2}", this.Name, pos, tosend);
					if (tosend <= 0)
					{
						continuation(null);
						return;
					}
					int num = tosend;
					if (num > this.MaxMessageSize)
					{
						if (this.OnOverflow == global::NLog.Targets.NetworkTargetOverflowAction.Discard)
						{
							global::NLog.Common.InternalLogger.Trace<string>("NetworkTarget(Name={0}): Discard because chunksize > this.MaxMessageSize", this.Name);
							continuation(null);
							return;
						}
						if (this.OnOverflow == global::NLog.Targets.NetworkTargetOverflowAction.Error)
						{
							continuation(new global::System.OverflowException(string.Format("Attempted to send a message larger than MaxMessageSize ({0}). Actual size was: {1}. Adjust OnOverflow and MaxMessageSize parameters accordingly.", this.MaxMessageSize, buffer.Length)));
							return;
						}
						num = this.MaxMessageSize;
					}
					pos = pos;
					tosend -= num;
					pos += num;
					sender.Send(buffer, pos, num, sendNextChunk);
				};
				sendNextChunk(null);
				return;
			}
			global::NLog.Common.InternalLogger.Trace<int, int>("Sending chunk, position: {0}, length: {1}", 0, tosend);
			if (tosend <= 0)
			{
				continuation(null);
				return;
			}
			sender.Send(buffer, 0, tosend, continuation);
		}

		// Token: 0x0400013B RID: 315
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender>> _currentSenderCache = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.LinkedListNode<global::NLog.Internal.NetworkSenders.NetworkSender>>();

		// Token: 0x0400013C RID: 316
		private readonly global::System.Collections.Generic.LinkedList<global::NLog.Internal.NetworkSenders.NetworkSender> _openNetworkSenders = new global::System.Collections.Generic.LinkedList<global::NLog.Internal.NetworkSenders.NetworkSender>();

		// Token: 0x0400013D RID: 317
		private readonly global::NLog.Internal.ReusableBufferCreator _reusableEncodingBuffer = new global::NLog.Internal.ReusableBufferCreator(16384);
	}
}
