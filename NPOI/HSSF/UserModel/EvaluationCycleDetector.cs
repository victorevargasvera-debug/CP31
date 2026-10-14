using System;
using System.Collections;
using System.Text;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000363 RID: 867
	internal class EvaluationCycleDetector
	{
		// Token: 0x06001A36 RID: 6710 RVA: 0x00050C16 File Offset: 0x0004EE16
		public EvaluationCycleDetector()
		{
			this._evaluationFrames = new global::System.Collections.ArrayList();
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00050C2C File Offset: 0x0004EE2C
		public bool StartEvaluate(global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, global::NPOI.HSSF.UserModel.HSSFSheet sheet, int srcRowNum, int srcColNum)
		{
			global::NPOI.HSSF.UserModel.EvaluationCycleDetector.CellEvaluationFrame value = new global::NPOI.HSSF.UserModel.EvaluationCycleDetector.CellEvaluationFrame(workbook, sheet, srcRowNum, srcColNum);
			if (this._evaluationFrames.Contains(value))
			{
				return false;
			}
			this._evaluationFrames.Add(value);
			return true;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00050C64 File Offset: 0x0004EE64
		public void EndEvaluate(global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, global::NPOI.HSSF.UserModel.HSSFSheet sheet, int srcRowNum, int srcColNum)
		{
			int num = this._evaluationFrames.Count;
			if (num < 1)
			{
				throw new global::System.InvalidOperationException("Call to endEvaluate without matching call to startEvaluate");
			}
			num--;
			global::NPOI.HSSF.UserModel.EvaluationCycleDetector.CellEvaluationFrame cellEvaluationFrame = (global::NPOI.HSSF.UserModel.EvaluationCycleDetector.CellEvaluationFrame)this._evaluationFrames[num];
			global::NPOI.HSSF.UserModel.EvaluationCycleDetector.CellEvaluationFrame cellEvaluationFrame2 = new global::NPOI.HSSF.UserModel.EvaluationCycleDetector.CellEvaluationFrame(workbook, sheet, srcRowNum, srcColNum);
			if (!cellEvaluationFrame2.Equals(cellEvaluationFrame))
			{
				throw new global::System.Exception(string.Concat(new string[]
				{
					"Wrong cell specified. Corresponding startEvaluate() call was for cell {",
					cellEvaluationFrame.FormatAsString(),
					"} this endEvaluate() call Is for cell {",
					cellEvaluationFrame2.FormatAsString(),
					"}"
				}));
			}
			this._evaluationFrames.Remove(num);
		}

		// Token: 0x04000B14 RID: 2836
		private global::System.Collections.IList _evaluationFrames;

		// Token: 0x020005FE RID: 1534
		private class CellEvaluationFrame
		{
			// Token: 0x06003619 RID: 13849 RVA: 0x000A5814 File Offset: 0x000A3A14
			public CellEvaluationFrame(global::NPOI.HSSF.UserModel.HSSFWorkbook workbook, global::NPOI.HSSF.UserModel.HSSFSheet sheet, int srcRowNum, int srcColNum)
			{
				if (workbook == null)
				{
					throw new global::System.ArgumentException("workbook must not be null");
				}
				if (sheet == null)
				{
					throw new global::System.ArgumentException("sheet must not be null");
				}
				this._workbook = workbook;
				this._sheet = sheet;
				this._srcRowNum = srcRowNum;
				this._srcColNum = srcColNum;
			}

			// Token: 0x0600361A RID: 13850 RVA: 0x000A5860 File Offset: 0x000A3A60
			public override bool Equals(object obj)
			{
				global::NPOI.HSSF.UserModel.EvaluationCycleDetector.CellEvaluationFrame cellEvaluationFrame = (global::NPOI.HSSF.UserModel.EvaluationCycleDetector.CellEvaluationFrame)obj;
				return this._workbook == cellEvaluationFrame._workbook && this._sheet == cellEvaluationFrame._sheet && this._srcRowNum == cellEvaluationFrame._srcRowNum && this._srcColNum == cellEvaluationFrame._srcColNum;
			}

			// Token: 0x0600361B RID: 13851 RVA: 0x000A58B5 File Offset: 0x000A3AB5
			public override int GetHashCode()
			{
				return this._workbook.GetHashCode() ^ this._sheet.GetHashCode() ^ this._srcRowNum ^ this._srcColNum;
			}

			// Token: 0x0600361C RID: 13852 RVA: 0x000A58DC File Offset: 0x000A3ADC
			public string FormatAsString()
			{
				return string.Concat(new string[]
				{
					"R=",
					this._srcRowNum.ToString(),
					" C=",
					this._srcColNum.ToString(),
					" ShIx=",
					this._workbook.GetSheetIndex(this._sheet).ToString()
				});
			}

			// Token: 0x0600361D RID: 13853 RVA: 0x000A5944 File Offset: 0x000A3B44
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
				stringBuilder.Append(base.GetType().Name).Append(" [");
				stringBuilder.Append(this.FormatAsString());
				stringBuilder.Append("]");
				return stringBuilder.ToString();
			}

			// Token: 0x04001A2F RID: 6703
			private global::NPOI.HSSF.UserModel.HSSFWorkbook _workbook;

			// Token: 0x04001A30 RID: 6704
			private global::NPOI.HSSF.UserModel.HSSFSheet _sheet;

			// Token: 0x04001A31 RID: 6705
			private int _srcRowNum;

			// Token: 0x04001A32 RID: 6706
			private int _srcColNum;
		}
	}
}
