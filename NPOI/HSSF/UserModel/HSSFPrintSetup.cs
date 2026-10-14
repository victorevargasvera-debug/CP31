using System;
using NPOI.HSSF.Record;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000385 RID: 901
	public class HSSFPrintSetup : global::NPOI.SS.UserModel.IPrintSetup
	{
		// Token: 0x06001CD9 RID: 7385 RVA: 0x00057F44 File Offset: 0x00056144
		public HSSFPrintSetup(global::NPOI.HSSF.Record.PrintSetupRecord printSetupRecord)
		{
			this.printSetupRecord = printSetupRecord;
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x00057F53 File Offset: 0x00056153
		// (set) Token: 0x06001CDB RID: 7387 RVA: 0x00057F60 File Offset: 0x00056160
		public short PaperSize
		{
			get
			{
				return this.printSetupRecord.PaperSize;
			}
			set
			{
				this.printSetupRecord.PaperSize = value;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00057F6E File Offset: 0x0005616E
		// (set) Token: 0x06001CDD RID: 7389 RVA: 0x00057F7B File Offset: 0x0005617B
		public short Scale
		{
			get
			{
				return this.printSetupRecord.Scale;
			}
			set
			{
				this.printSetupRecord.Scale = value;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x00057F89 File Offset: 0x00056189
		// (set) Token: 0x06001CDF RID: 7391 RVA: 0x00057F96 File Offset: 0x00056196
		public short PageStart
		{
			get
			{
				return this.printSetupRecord.PageStart;
			}
			set
			{
				this.printSetupRecord.PageStart = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00057FA4 File Offset: 0x000561A4
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x00057FB1 File Offset: 0x000561B1
		public short FitWidth
		{
			get
			{
				return this.printSetupRecord.FitWidth;
			}
			set
			{
				this.printSetupRecord.FitWidth = value;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x00057FBF File Offset: 0x000561BF
		// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x00057FCC File Offset: 0x000561CC
		public short FitHeight
		{
			get
			{
				return this.printSetupRecord.FitHeight;
			}
			set
			{
				this.printSetupRecord.FitHeight = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00057FDA File Offset: 0x000561DA
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x00057FE7 File Offset: 0x000561E7
		public short Options
		{
			get
			{
				return this.printSetupRecord.Options;
			}
			set
			{
				this.printSetupRecord.Options = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00057FF5 File Offset: 0x000561F5
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x00058002 File Offset: 0x00056202
		public bool LeftToRight
		{
			get
			{
				return this.printSetupRecord.LeftToRight;
			}
			set
			{
				this.printSetupRecord.LeftToRight = value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x00058010 File Offset: 0x00056210
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x00058020 File Offset: 0x00056220
		public bool Landscape
		{
			get
			{
				return !this.printSetupRecord.Landscape;
			}
			set
			{
				this.printSetupRecord.Landscape = !value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x00058031 File Offset: 0x00056231
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x0005803E File Offset: 0x0005623E
		public bool ValidSettings
		{
			get
			{
				return this.printSetupRecord.ValidSettings;
			}
			set
			{
				this.printSetupRecord.ValidSettings = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x0005804C File Offset: 0x0005624C
		// (set) Token: 0x06001CED RID: 7405 RVA: 0x00058059 File Offset: 0x00056259
		public bool NoColor
		{
			get
			{
				return this.printSetupRecord.NoColor;
			}
			set
			{
				this.printSetupRecord.NoColor = value;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x00058067 File Offset: 0x00056267
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x00058074 File Offset: 0x00056274
		public bool EndNote
		{
			get
			{
				return this.printSetupRecord.EndNote;
			}
			set
			{
				this.printSetupRecord.EndNote = value;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00058082 File Offset: 0x00056282
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0005808F File Offset: 0x0005628F
		public global::NPOI.SS.UserModel.DisplayCellErrorType CellError
		{
			get
			{
				return (global::NPOI.SS.UserModel.DisplayCellErrorType)this.printSetupRecord.CellError;
			}
			set
			{
				this.printSetupRecord.CellError = (short)value;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0005809D File Offset: 0x0005629D
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x000580AA File Offset: 0x000562AA
		public bool Draft
		{
			get
			{
				return this.printSetupRecord.Draft;
			}
			set
			{
				this.printSetupRecord.Draft = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x000580B8 File Offset: 0x000562B8
		// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x000580C5 File Offset: 0x000562C5
		public bool Notes
		{
			get
			{
				return this.printSetupRecord.Notes;
			}
			set
			{
				this.printSetupRecord.Notes = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x000580D3 File Offset: 0x000562D3
		// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x000580E0 File Offset: 0x000562E0
		public bool NoOrientation
		{
			get
			{
				return this.printSetupRecord.NoOrientation;
			}
			set
			{
				this.printSetupRecord.NoOrientation = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x000580EE File Offset: 0x000562EE
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x000580FB File Offset: 0x000562FB
		public bool UsePage
		{
			get
			{
				return this.printSetupRecord.UsePage;
			}
			set
			{
				this.printSetupRecord.UsePage = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x00058109 File Offset: 0x00056309
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x00058116 File Offset: 0x00056316
		public short HResolution
		{
			get
			{
				return this.printSetupRecord.HResolution;
			}
			set
			{
				this.printSetupRecord.HResolution = value;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00058124 File Offset: 0x00056324
		// (set) Token: 0x06001CFD RID: 7421 RVA: 0x00058131 File Offset: 0x00056331
		public short VResolution
		{
			get
			{
				return this.printSetupRecord.VResolution;
			}
			set
			{
				this.printSetupRecord.VResolution = value;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001CFE RID: 7422 RVA: 0x0005813F File Offset: 0x0005633F
		// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0005814C File Offset: 0x0005634C
		public double HeaderMargin
		{
			get
			{
				return this.printSetupRecord.HeaderMargin;
			}
			set
			{
				this.printSetupRecord.HeaderMargin = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0005815A File Offset: 0x0005635A
		// (set) Token: 0x06001D01 RID: 7425 RVA: 0x00058167 File Offset: 0x00056367
		public double FooterMargin
		{
			get
			{
				return this.printSetupRecord.FooterMargin;
			}
			set
			{
				this.printSetupRecord.FooterMargin = value;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x00058175 File Offset: 0x00056375
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x00058182 File Offset: 0x00056382
		public short Copies
		{
			get
			{
				return this.printSetupRecord.Copies;
			}
			set
			{
				this.printSetupRecord.Copies = value;
			}
		}

		// Token: 0x04000B79 RID: 2937
		private global::NPOI.HSSF.Record.PrintSetupRecord printSetupRecord;
	}
}
