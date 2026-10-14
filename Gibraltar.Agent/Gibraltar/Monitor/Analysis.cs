using System;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x02000183 RID: 387
	internal class Analysis : global::Gibraltar.Monitor.Internal.IDisplayable
	{
		// Token: 0x0600102E RID: 4142 RVA: 0x0002CD74 File Offset: 0x0002AF74
		public Analysis()
		{
			this.m_Packet = new global::Gibraltar.Monitor.Internal.AnalysisPacket();
			this.m_Packet.Caption = string.Empty;
			this.m_Packet.Description = string.Empty;
			this.m_Markers = new global::Gibraltar.Monitor.MarkerCollection(this);
			this.m_DataExtensions = new global::Gibraltar.Monitor.DataExtensionCollection(this);
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x0002CDD0 File Offset: 0x0002AFD0
		public global::Gibraltar.Monitor.DataExtensionCollection DataExtensions
		{
			get
			{
				return this.m_DataExtensions;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		public global::Gibraltar.Monitor.MarkerCollection Markers
		{
			get
			{
				return this.m_Markers;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x0002CDE0 File Offset: 0x0002AFE0
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x0002CDF0 File Offset: 0x0002AFF0
		public string Caption
		{
			get
			{
				return this.m_Packet.Caption;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					this.m_Packet.Caption = value;
					return;
				}
				this.m_Packet.Caption = value.Trim();
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x0002CE1C File Offset: 0x0002B01C
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x0002CE2C File Offset: 0x0002B02C
		public string Description
		{
			get
			{
				return this.m_Packet.Description;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					this.m_Packet.Description = value;
					return;
				}
				this.m_Packet.Description = value.Trim();
			}
		}

		// Token: 0x04000572 RID: 1394
		private readonly global::Gibraltar.Monitor.Internal.AnalysisPacket m_Packet;

		// Token: 0x04000573 RID: 1395
		private readonly global::Gibraltar.Monitor.MarkerCollection m_Markers;

		// Token: 0x04000574 RID: 1396
		private readonly global::Gibraltar.Monitor.DataExtensionCollection m_DataExtensions;
	}
}
