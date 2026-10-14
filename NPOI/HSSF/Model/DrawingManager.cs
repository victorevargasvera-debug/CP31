using System;
using System.Collections;
using NPOI.DDF;

namespace NPOI.HSSF.Model
{
	// Token: 0x0200032F RID: 815
	[global::System.Obsolete("deprecated in POI 3.15-beta2, scheduled for removal in 3.17, use DrawingManager2 instead")]
	public class DrawingManager
	{
		// Token: 0x06001723 RID: 5923 RVA: 0x00044F36 File Offset: 0x00043136
		public DrawingManager(global::NPOI.DDF.EscherDggRecord dgg)
		{
			this.dgg = dgg;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00044F50 File Offset: 0x00043150
		public global::NPOI.DDF.EscherDgRecord CreateDgRecord()
		{
			global::NPOI.DDF.EscherDgRecord escherDgRecord = new global::NPOI.DDF.EscherDgRecord();
			escherDgRecord.RecordId = -4088;
			short num = this.FindNewDrawingGroupId();
			escherDgRecord.Options = (short)(num << 4);
			escherDgRecord.NumShapes = 0;
			escherDgRecord.LastMSOSPID = -1;
			this.dgg.AddCluster((int)num, 0);
			this.dgg.DrawingsSaved = this.dgg.DrawingsSaved + 1;
			this.dgMap[num] = escherDgRecord;
			return escherDgRecord;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00044FC8 File Offset: 0x000431C8
		public int AllocateShapeId(short drawingGroupId)
		{
			global::NPOI.DDF.EscherDgRecord escherDgRecord = (global::NPOI.DDF.EscherDgRecord)this.dgMap[drawingGroupId];
			int lastMSOSPID = escherDgRecord.LastMSOSPID;
			int num = 0;
			if (lastMSOSPID % 1024 == 1023)
			{
				num = this.FindFreeSPIDBlock();
				this.dgg.AddCluster((int)drawingGroupId, 1);
			}
			else
			{
				for (int i = 0; i < this.dgg.FileIdClusters.Length; i++)
				{
					global::NPOI.DDF.EscherDggRecord.FileIdCluster fileIdCluster = this.dgg.FileIdClusters[i];
					if (fileIdCluster.DrawingGroupId == (int)drawingGroupId && fileIdCluster.NumShapeIdsUsed != 1024)
					{
						fileIdCluster.IncrementShapeId();
					}
					if (escherDgRecord.LastMSOSPID == -1)
					{
						num = this.FindFreeSPIDBlock();
					}
					else
					{
						num = escherDgRecord.LastMSOSPID + 1;
					}
				}
			}
			this.dgg.NumShapesSaved = this.dgg.NumShapesSaved + 1;
			if (num >= this.dgg.ShapeIdMax)
			{
				this.dgg.ShapeIdMax = num + 1;
			}
			escherDgRecord.LastMSOSPID = num;
			escherDgRecord.IncrementShapeCount();
			return num;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x000450B8 File Offset: 0x000432B8
		public short FindNewDrawingGroupId()
		{
			short num = 1;
			while (this.DrawingGroupExists(num))
			{
				num += 1;
			}
			return num;
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x000450D8 File Offset: 0x000432D8
		public bool DrawingGroupExists(short dgId)
		{
			for (int i = 0; i < this.dgg.FileIdClusters.Length; i++)
			{
				if (this.dgg.FileIdClusters[i].DrawingGroupId == (int)dgId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00045115 File Offset: 0x00043315
		public int FindFreeSPIDBlock()
		{
			return (this.dgg.ShapeIdMax / 1024 + 1) * 1024;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x00045130 File Offset: 0x00043330
		public global::NPOI.DDF.EscherDggRecord Dgg
		{
			get
			{
				return this.dgg;
			}
		}

		// Token: 0x04000993 RID: 2451
		private global::NPOI.DDF.EscherDggRecord dgg;

		// Token: 0x04000994 RID: 2452
		private global::System.Collections.Hashtable dgMap = new global::System.Collections.Hashtable();
	}
}
