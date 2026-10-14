using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000098 RID: 152
	[global::System.Serializable]
	public class PictureParameter : global::System.ICloneable
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00040064 File Offset: 0x0003E264
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00040110 File Offset: 0x0003E310
		public string FolderPath
		{
			get
			{
				short num = (short)1384151609;
				short num2 = num;
				num = (short)1051687481;
				switch (num2 == num)
				{
				}
				num = (short)1594490880;
				if (num != 0)
				{
				}
				num = (short)1586364417;
				if (num != 0)
				{
				}
				num = (short)202833920;
				short num3 = num;
				return this._folderPath;
			}
			set
			{
				short num = (short)458543833;
				short num2 = num;
				num = (short)122147545;
				switch (num2 == num)
				{
				}
				num = (short)216072193;
				if (num != 0)
				{
				}
				num = (short)566296576;
				if (num != 0)
				{
				}
				num = (short)1110507520;
				short num3 = num;
				this._folderPath = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000401C4 File Offset: 0x0003E3C4
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00040270 File Offset: 0x0003E470
		public string ArchiveFile
		{
			get
			{
				short num = (short)902454629;
				short num2 = num;
				num = (short)1526357349;
				switch (num2 == num)
				{
				}
				num = (short)702414849;
				if (num != 0)
				{
				}
				num = (short)795213824;
				if (num != 0)
				{
				}
				num = (short)1233321984;
				short num3 = num;
				return this._archiveFile;
			}
			set
			{
				short num = (short)1573787892;
				short num2 = num;
				num = (short)890575092;
				switch (num2 == num)
				{
				}
				num = (short)683671552;
				if (num != 0)
				{
				}
				num = (short)1816068097;
				if (num != 0)
				{
				}
				num = (short)644349952;
				short num3 = num;
				this._archiveFile = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00040324 File Offset: 0x0003E524
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000403D4 File Offset: 0x0003E5D4
		public bool bFlag
		{
			get
			{
				short num = (short)845415585;
				short num2 = num;
				num = (short)1051985057;
				switch (num2 == num)
				{
				}
				num = (short)3604480;
				if (num != 0)
				{
				}
				num = (short)490471425;
				if (num != 0)
				{
				}
				num = (short)481886208;
				short num3 = num;
				return this._bFlag;
			}
			set
			{
				short num = (short)378829432;
				short num2 = num;
				num = (short)394820216;
				switch (num2 == num)
				{
				}
				num = (short)1997209601;
				if (num != 0)
				{
				}
				num = (short)1949433856;
				if (num != 0)
				{
				}
				num = (short)348258304;
				short num3 = num;
				this._bFlag = value;
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00040484 File Offset: 0x0003E684
		public object Clone()
		{
			short num = (short)499081962;
			short num2 = num;
			num = (short)868180714;
			switch (num2 == num)
			{
			}
			num = (short)615710720;
			if (num != 0)
			{
			}
			num = (short)905576449;
			if (num != 0)
			{
			}
			num = (short)821690368;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.PictureParameter pictureParameter = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.PictureParameter;
			pictureParameter.FolderPath = this.FolderPath;
			pictureParameter.ArchiveFile = this.ArchiveFile;
			pictureParameter.bFlag = this.bFlag;
			return pictureParameter;
		}

		// Token: 0x040004A6 RID: 1190
		private string _folderPath = string.Empty;

		// Token: 0x040004A7 RID: 1191
		private string _archiveFile = string.Empty;

		// Token: 0x040004A8 RID: 1192
		private bool _bFlag;
	}
}
