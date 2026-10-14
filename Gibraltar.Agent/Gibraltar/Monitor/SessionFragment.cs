using System;
using System.IO;
using Gibraltar.Data;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x020001A8 RID: 424
	internal class SessionFragment
	{
		// Token: 0x060012A2 RID: 4770 RVA: 0x00036390 File Offset: 0x00034590
		internal SessionFragment(global::Gibraltar.Data.GLFReader sessionFile)
		{
			if (sessionFile == null)
			{
				throw new global::System.ArgumentNullException("sessionFile");
			}
			if (!sessionFile.SessionHeader.HasFileInfo)
			{
				throw new global::System.ArgumentException("The session file is missing file information and can't be used as a session fragment.  This indicates a coding error in the framework.", "sessionFile");
			}
			this.m_SessionFile = sessionFile;
			this.m_Packet = new global::Gibraltar.Monitor.Internal.SessionFragmentPacket();
			this.m_Packet.ID = this.m_SessionFile.SessionHeader.FileId;
			this.m_Packet.FileStartDateTime = this.m_SessionFile.SessionHeader.FileStartDateTime;
			this.m_Packet.FileEndDateTime = this.m_SessionFile.SessionHeader.FileEndDateTime;
			this.m_Packet.IsLastFile = this.m_SessionFile.SessionHeader.IsLastFile;
			sessionFile.EnsureDataLoaded();
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0003645C File Offset: 0x0003465C
		internal SessionFragment(global::Gibraltar.Monitor.Internal.SessionFragmentPacket sessionFragmentPacket)
		{
			if (sessionFragmentPacket == null)
			{
				throw new global::System.ArgumentNullException("sessionFragmentPacket");
			}
			this.m_Packet = sessionFragmentPacket;
			this.Loaded = true;
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00036484 File Offset: 0x00034684
		public global::System.Guid Id
		{
			get
			{
				return this.m_Packet.ID;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00036494 File Offset: 0x00034694
		public global::System.DateTimeOffset StartDateTime
		{
			get
			{
				return this.m_Packet.FileStartDateTime;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x000364A4 File Offset: 0x000346A4
		public global::System.DateTimeOffset EndDateTime
		{
			get
			{
				return this.m_Packet.FileEndDateTime;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x000364B4 File Offset: 0x000346B4
		public bool IsLastFile
		{
			get
			{
				return this.m_Packet.IsLastFile;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000364C4 File Offset: 0x000346C4
		public int MessageCount
		{
			get
			{
				return this.m_SessionFile.SessionHeader.MessageCount;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x000364D8 File Offset: 0x000346D8
		public int CriticalCount
		{
			get
			{
				return this.m_SessionFile.SessionHeader.CriticalCount;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x000364EC File Offset: 0x000346EC
		public int ErrorCount
		{
			get
			{
				return this.m_SessionFile.SessionHeader.ErrorCount;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00036500 File Offset: 0x00034700
		public int WarningCount
		{
			get
			{
				return this.m_SessionFile.SessionHeader.WarningCount;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00036514 File Offset: 0x00034714
		public long Size
		{
			get
			{
				return this.m_SessionFile.FragmentStorageSummary.FragmentSize;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00036528 File Offset: 0x00034728
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x00036530 File Offset: 0x00034730
		internal bool Loaded { get; set; }

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0003653C File Offset: 0x0003473C
		private global::System.IO.Stream RawStream
		{
			get
			{
				return this.m_SessionFile.RawStream;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0003654C File Offset: 0x0003474C
		internal global::Gibraltar.Data.GLFReader Reader
		{
			get
			{
				return this.m_SessionFile;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00036554 File Offset: 0x00034754
		internal global::Gibraltar.Monitor.Internal.SessionFragmentPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x0400064C RID: 1612
		private readonly global::Gibraltar.Monitor.Internal.SessionFragmentPacket m_Packet;

		// Token: 0x0400064D RID: 1613
		private readonly global::Gibraltar.Data.GLFReader m_SessionFile;
	}
}
