using System;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000054 RID: 84
	public class PreloadFieldInfo
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0002467C File Offset: 0x0002287C
		public PreloadFieldInfo(string refFieldName, string uiResourceID, string uiControlType)
		{
			this.a = refFieldName;
			this.b = uiResourceID;
			this.c = uiControlType;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000246C8 File Offset: 0x000228C8
		public string FieldName
		{
			get
			{
				short num = (short)600920957;
				short num2 = num;
				num = (short)1889424253;
				switch (num2 == num)
				{
				}
				num = (short)354287617;
				if (num != 0)
				{
				}
				num = (short)1277427712;
				if (num != 0)
				{
				}
				num = (short)1562247168;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00024778 File Offset: 0x00022978
		public string ResourceID
		{
			get
			{
				short num = (short)473974004;
				short num2 = num;
				num = (short)670778612;
				switch (num2 == num)
				{
				}
				num = (short)1383792641;
				if (num != 0)
				{
				}
				num = (short)570621952;
				if (num != 0)
				{
				}
				num = (short)118947840;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00024828 File Offset: 0x00022A28
		public string ControlType
		{
			get
			{
				short num = (short)1612630085;
				short num2 = num;
				num = (short)1292683333;
				switch (num2 == num)
				{
				}
				num = (short)987365376;
				if (num != 0)
				{
				}
				num = (short)1041104897;
				if (num != 0)
				{
				}
				num = (short)33751040;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x040000FC RID: 252
		private string a = string.Empty;

		// Token: 0x040000FD RID: 253
		private string b = string.Empty;

		// Token: 0x040000FE RID: 254
		private string c = string.Empty;
	}
}
