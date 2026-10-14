using System;
using System.Collections;
using NPOI.DDF;

namespace NPOI.HSSF.Model
{
	// Token: 0x02000330 RID: 816
	public class DrawingManager2
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x00045138 File Offset: 0x00043338
		public DrawingManager2(global::NPOI.DDF.EscherDggRecord dgg)
		{
			this.dgg = dgg;
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00045152 File Offset: 0x00043352
		public void ClearDrawingGroups()
		{
			this.drawingGroups.Clear();
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00045160 File Offset: 0x00043360
		public virtual global::NPOI.DDF.EscherDgRecord CreateDgRecord()
		{
			global::NPOI.DDF.EscherDgRecord escherDgRecord = new global::NPOI.DDF.EscherDgRecord();
			escherDgRecord.RecordId = -4088;
			short num = this.FindNewDrawingGroupId();
			escherDgRecord.Options = (short)(num << 4);
			escherDgRecord.NumShapes = 0;
			escherDgRecord.LastMSOSPID = -1;
			this.drawingGroups.Add(escherDgRecord);
			this.dgg.AddCluster((int)num, 0);
			this.dgg.DrawingsSaved = this.dgg.DrawingsSaved + 1;
			return escherDgRecord;
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000451D0 File Offset: 0x000433D0
		public virtual int AllocateShapeId(short drawingGroupId)
		{
			global::NPOI.DDF.EscherDgRecord drawingGroup = this.GetDrawingGroup((int)drawingGroupId);
			return this.AllocateShapeId(drawingGroupId, drawingGroup);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x000451F0 File Offset: 0x000433F0
		public virtual int AllocateShapeId(short drawingGroupId, global::NPOI.DDF.EscherDgRecord dg)
		{
			this.dgg.NumShapesSaved = this.dgg.NumShapesSaved + 1;
			for (int i = 0; i < this.dgg.FileIdClusters.Length; i++)
			{
				global::NPOI.DDF.EscherDggRecord.FileIdCluster fileIdCluster = this.dgg.FileIdClusters[i];
				if (fileIdCluster.DrawingGroupId == (int)drawingGroupId && fileIdCluster.NumShapeIdsUsed != 1024)
				{
					int num = fileIdCluster.NumShapeIdsUsed + 1024 * (i + 1);
					fileIdCluster.IncrementShapeId();
					dg.NumShapes++;
					dg.LastMSOSPID = num;
					if (num >= this.dgg.ShapeIdMax)
					{
						this.dgg.ShapeIdMax = num + 1;
					}
					return num;
				}
			}
			this.dgg.AddCluster((int)drawingGroupId, 0);
			this.dgg.FileIdClusters[this.dgg.FileIdClusters.Length - 1].IncrementShapeId();
			dg.NumShapes++;
			int num2 = 1024 * this.dgg.FileIdClusters.Length;
			dg.LastMSOSPID = num2;
			if (num2 >= this.dgg.ShapeIdMax)
			{
				this.dgg.ShapeIdMax = num2 + 1;
			}
			return num2;
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00045314 File Offset: 0x00043514
		public short FindNewDrawingGroupId()
		{
			short num = 1;
			while (this.DrawingGroupExists(num))
			{
				num += 1;
			}
			return num;
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00045334 File Offset: 0x00043534
		private global::NPOI.DDF.EscherDgRecord GetDrawingGroup(int drawingGroupId)
		{
			return (global::NPOI.DDF.EscherDgRecord)this.drawingGroups[drawingGroupId - 1];
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0004534C File Offset: 0x0004354C
		private bool DrawingGroupExists(short dgId)
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

		// Token: 0x06001732 RID: 5938 RVA: 0x00045389 File Offset: 0x00043589
		private int FindFreeSPIDBlock()
		{
			return (this.dgg.ShapeIdMax / 1024 + 1) * 1024;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000453A4 File Offset: 0x000435A4
		public global::NPOI.DDF.EscherDggRecord GetDgg()
		{
			return this.dgg;
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x000453AC File Offset: 0x000435AC
		public void IncrementDrawingsSaved()
		{
			this.dgg.DrawingsSaved = this.dgg.DrawingsSaved + 1;
		}

		// Token: 0x04000995 RID: 2453
		private global::NPOI.DDF.EscherDggRecord dgg;

		// Token: 0x04000996 RID: 2454
		private global::System.Collections.IList drawingGroups = new global::System.Collections.ArrayList();
	}
}
