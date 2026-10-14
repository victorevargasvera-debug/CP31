using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Common.CommonUtility.CSV;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200000B RID: 11
	public abstract class ImportFileToGridBatchOpBase : global::Motorola.CommonCPS.RadioManagement.BatchOp.AbstractBatchOp<string>
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00004098 File Offset: 0x00002298
		protected ImportFileToGridBatchOpBase(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile, global::System.Globalization.CultureInfo cultureInfo)
		{
			this.csvFile = csvFile;
			this.cultureInfo = cultureInfo;
			base.SelectedItems = csvFile.Records.Select(delegate(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csv)
			{
				short num = (short)936310710;
				short num2 = num;
				num = (short)329381814;
				switch (num2 == num)
				{
				default:
				{
					num = (short)913440768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1160642561;
				if (num != 0)
				{
				}
				num = (short)662896640;
				if (num != 0)
				{
				}
				return string.Empty;
			}).ToList<string>();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000040F4 File Offset: 0x000022F4
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000041A4 File Offset: 0x000023A4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo DataGridInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)940121994;
				short num2 = num;
				num = (short)2117738378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1944125440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1397096448;
				if (num != 0)
				{
				}
				num = (short)996343809;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1652712102;
				short num2 = num;
				num = (short)1959486118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1100349440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1647640576;
				if (num != 0)
				{
				}
				num = (short)913899521;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00004254 File Offset: 0x00002454
		public override global::Motorola.CommonCPS.Server.CommonDBConstants.JobType Type
		{
			get
			{
				short num = (short)1313611161;
				short num2 = num;
				num = (short)1408572825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532217856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)35913729;
				if (num != 0)
				{
				}
				num = (short)592052224;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportCSV;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00004300 File Offset: 0x00002500
		public override string JobName
		{
			get
			{
				short num = (short)148341974;
				short num2 = num;
				num = (short)718570710;
				switch (num2 == num)
				{
				default:
				{
					num = (short)963117056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716046336;
				if (num != 0)
				{
				}
				num = (short)1521025025;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.General_ImportCsvFile_Title;
			}
		}

		// Token: 0x04000007 RID: 7
		protected readonly global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile;

		// Token: 0x04000008 RID: 8
		protected readonly global::System.Globalization.CultureInfo cultureInfo;

		// Token: 0x04000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo a;
	}
}
