using System;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x02000195 RID: 405
	internal class LogMessage : global::Gibraltar.Monitor.Internal.IDisplayable, global::Gibraltar.Monitor.Internal.IDataObject, global::System.IComparable<global::Gibraltar.Monitor.LogMessage>, global::System.IEquatable<global::Gibraltar.Monitor.LogMessage>
	{
		// Token: 0x06001136 RID: 4406 RVA: 0x00031E14 File Offset: 0x00030014
		internal LogMessage(global::Gibraltar.Monitor.Session session, global::Gibraltar.Monitor.ThreadInfo threadInfo, global::Gibraltar.Monitor.ApplicationUser applicationUser, global::Gibraltar.Monitor.Internal.LogMessagePacket messagePacket)
		{
			this.m_Session = session;
			this.m_ThreadInfo = threadInfo;
			this.m_ApplicationUser = applicationUser;
			this.m_MessagePacket = messagePacket;
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x00031E40 File Offset: 0x00030040
		public global::System.Guid Id
		{
			get
			{
				return this.m_MessagePacket.Id;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x00031E50 File Offset: 0x00030050
		public int IndexOf
		{
			get
			{
				if (this.m_IndexOf == -1)
				{
					this.m_IndexOf = this.m_Session.Messages.IndexOf(this);
				}
				return this.m_IndexOf;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00031E7C File Offset: 0x0003007C
		public long Sequence
		{
			get
			{
				return this.m_MessagePacket.Sequence;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00031E8C File Offset: 0x0003008C
		public global::System.DateTimeOffset Timestamp
		{
			get
			{
				return this.m_MessagePacket.Timestamp;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x00031E9C File Offset: 0x0003009C
		public string LogSystem
		{
			get
			{
				return this.m_MessagePacket.LogSystem;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x00031EAC File Offset: 0x000300AC
		public global::Gibraltar.Monitor.ThreadInfo ThreadInfo
		{
			get
			{
				return this.m_ThreadInfo;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x00031EB4 File Offset: 0x000300B4
		public global::Gibraltar.Monitor.ApplicationUser User
		{
			get
			{
				return this.m_ApplicationUser;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x00031EBC File Offset: 0x000300BC
		public string UserName
		{
			get
			{
				return this.m_MessagePacket.UserName;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x00031ECC File Offset: 0x000300CC
		public int ThreadId
		{
			get
			{
				return this.m_ThreadInfo.ThreadId;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x00031EDC File Offset: 0x000300DC
		public string ThreadName
		{
			get
			{
				return this.m_ThreadInfo.Caption;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x00031EEC File Offset: 0x000300EC
		public bool HasMethodInfo
		{
			get
			{
				return !string.IsNullOrEmpty(this.m_MessagePacket.ClassName);
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x00031F04 File Offset: 0x00030104
		public string ClassName
		{
			get
			{
				return this.m_MessagePacket.ClassName;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x00031F14 File Offset: 0x00030114
		public string[] ClassNames
		{
			get
			{
				if (this.m_ClassNames == null)
				{
					this.m_ClassNames = global::Gibraltar.Monitor.TextParse.ClassName(this.ClassName);
				}
				return this.m_ClassNames;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x00031F38 File Offset: 0x00030138
		public string MethodName
		{
			get
			{
				return this.m_MessagePacket.MethodName;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x00031F48 File Offset: 0x00030148
		public bool HasSourceLocation
		{
			get
			{
				return !string.IsNullOrEmpty(this.m_MessagePacket.FileName);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x00031F60 File Offset: 0x00030160
		public bool HasThreadInfo
		{
			get
			{
				return this.m_MessagePacket.HasThreadInfo;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x00031F70 File Offset: 0x00030170
		public string FileName
		{
			get
			{
				return this.m_MessagePacket.FileName;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x00031F80 File Offset: 0x00030180
		public int LineNumber
		{
			get
			{
				return this.m_MessagePacket.LineNumber;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00031F90 File Offset: 0x00030190
		public string Caption
		{
			get
			{
				return this.m_MessagePacket.Caption;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00031FA0 File Offset: 0x000301A0
		public string Description
		{
			get
			{
				return this.m_MessagePacket.Description;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x00031FB0 File Offset: 0x000301B0
		public string Details
		{
			get
			{
				return this.m_MessagePacket.Details;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00031FC0 File Offset: 0x000301C0
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x00031FD0 File Offset: 0x000301D0
		public global::Loupe.Extensibility.Data.LogMessageSeverity Severity
		{
			get
			{
				return this.m_MessagePacket.Severity;
			}
			set
			{
				this.m_MessagePacket.Severity = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00031FE0 File Offset: 0x000301E0
		public string CategoryName
		{
			get
			{
				return this.m_MessagePacket.CategoryName;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00031FF0 File Offset: 0x000301F0
		public string[] CategoryNames
		{
			get
			{
				if (this.m_CategoryNames == null)
				{
					this.m_CategoryNames = global::Gibraltar.Monitor.TextParse.CategoryName(this.CategoryName);
				}
				return this.m_CategoryNames;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00032014 File Offset: 0x00030214
		public global::System.DateTime TimestampDateTime
		{
			get
			{
				return this.Timestamp.DateTime;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00032034 File Offset: 0x00030234
		public string Message
		{
			get
			{
				return this.m_MessagePacket.Message;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00032044 File Offset: 0x00030244
		public string MethodFullName
		{
			get
			{
				return this.m_MessagePacket.MethodFullName;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x00032054 File Offset: 0x00030254
		public string SourceCodeLocation
		{
			get
			{
				return this.m_MessagePacket.SourceCodeLocation;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00032064 File Offset: 0x00030264
		public global::Gibraltar.Monitor.Session Session
		{
			get
			{
				return this.m_Session;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0003206C File Offset: 0x0003026C
		public global::Gibraltar.Monitor.DataExtension Extension
		{
			get
			{
				if (this.m_Extension == null)
				{
					this.m_Session.Analysis.DataExtensions.TryGetValue(((global::Gibraltar.Monitor.Internal.IDataObject)this).Id, out this.m_Extension);
					if (this.m_Extension == null)
					{
						this.m_Extension = this.m_Session.Analysis.DataExtensions.Add(this);
					}
				}
				return this.m_Extension;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x000320D8 File Offset: 0x000302D8
		public bool HasException
		{
			get
			{
				return this.m_MessagePacket.HasException;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x000320E8 File Offset: 0x000302E8
		public global::Loupe.Extensibility.Data.IExceptionInfo Exception
		{
			get
			{
				return this.m_MessagePacket.Exception;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x000320F8 File Offset: 0x000302F8
		public global::Loupe.Extensibility.Data.IExceptionInfo[] Exceptions
		{
			get
			{
				return this.m_MessagePacket.Exceptions;
			}
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00032108 File Offset: 0x00030308
		public int CompareTo(global::Gibraltar.Monitor.LogMessage other)
		{
			return this.m_MessagePacket.Sequence.CompareTo(other.Sequence);
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00032134 File Offset: 0x00030334
		public bool Equals(global::Gibraltar.Monitor.LogMessage other)
		{
			return other != null && this.m_MessagePacket.Id.Equals(other.Id);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00032168 File Offset: 0x00030368
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.LogMessage other = obj as global::Gibraltar.Monitor.LogMessage;
			return this.Equals(other);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00032188 File Offset: 0x00030388
		public override int GetHashCode()
		{
			int num = 0;
			if (this.m_MessagePacket != null)
			{
				num ^= this.m_MessagePacket.Id.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x000321C4 File Offset: 0x000303C4
		public static bool operator ==(global::Gibraltar.Monitor.LogMessage left, global::Gibraltar.Monitor.LogMessage right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x000321D8 File Offset: 0x000303D8
		public static bool operator !=(global::Gibraltar.Monitor.LogMessage left, global::Gibraltar.Monitor.LogMessage right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000321F0 File Offset: 0x000303F0
		public static bool operator <(global::Gibraltar.Monitor.LogMessage left, global::Gibraltar.Monitor.LogMessage right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000321FC File Offset: 0x000303FC
		public static bool operator >(global::Gibraltar.Monitor.LogMessage left, global::Gibraltar.Monitor.LogMessage right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00032208 File Offset: 0x00030408
		public override string ToString()
		{
			return this.m_MessagePacket.Message;
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00032218 File Offset: 0x00030418
		internal global::Gibraltar.Monitor.Internal.LogMessagePacket MessagePacket
		{
			get
			{
				return this.m_MessagePacket;
			}
		}

		// Token: 0x040005D8 RID: 1496
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x040005D9 RID: 1497
		private readonly global::Gibraltar.Monitor.ThreadInfo m_ThreadInfo;

		// Token: 0x040005DA RID: 1498
		private readonly global::Gibraltar.Monitor.ApplicationUser m_ApplicationUser;

		// Token: 0x040005DB RID: 1499
		private readonly global::Gibraltar.Monitor.Internal.LogMessagePacket m_MessagePacket;

		// Token: 0x040005DC RID: 1500
		private global::Gibraltar.Monitor.DataExtension m_Extension;

		// Token: 0x040005DD RID: 1501
		private string[] m_CategoryNames;

		// Token: 0x040005DE RID: 1502
		private string[] m_ClassNames;

		// Token: 0x040005DF RID: 1503
		private int m_IndexOf = -1;
	}
}
