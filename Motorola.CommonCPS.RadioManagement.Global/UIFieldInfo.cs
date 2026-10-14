using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Global
{
	// Token: 0x0200000B RID: 11
	public class UIFieldInfo
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00003010 File Offset: 0x00001210
		public UIFieldInfo(string fieldName, string uiLable, string numberScale, global::System.Windows.Data.IValueConverter fieldUIConverte = null)
		{
			this.FieldName = fieldName;
			this.UiLable = uiLable;
			this.NumberScale = numberScale;
			this.FieldUIConverter = fieldUIConverte;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003040 File Offset: 0x00001240
		public UIFieldInfo(string fieldName, string uiLable, string numberScale, global::System.Type fieldType)
		{
			this.FieldName = fieldName;
			this.UiLable = uiLable;
			this.NumberScale = numberScale;
			this.FieldType = fieldType;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003070 File Offset: 0x00001270
		public UIFieldInfo(global::System.Collections.Generic.List<string> fieldNameList, string uiLable, string numberScale, global::System.Type fieldType)
		{
			if (fieldNameList != null && fieldNameList.Count > 0)
			{
				this.FieldName = fieldNameList[0];
			}
			this.FieldNameList = fieldNameList;
			this.UiLable = uiLable;
			this.NumberScale = numberScale;
			this.FieldType = fieldType;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000030C0 File Offset: 0x000012C0
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003170 File Offset: 0x00001370
		public string FieldName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)224431484;
				short num2 = num;
				num = (short)2139196796;
				switch (num2 == num)
				{
				}
				num = (short)368640001;
				if (num != 0)
				{
				}
				num = (short)2010120192;
				short num3 = num;
				num = (short)1168310272;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1827215199;
				short num2 = num;
				num = (short)978851679;
				switch (num2 == num)
				{
				}
				num = (short)1439498241;
				if (num != 0)
				{
				}
				num = (short)1854078976;
				short num3 = num;
				num = (short)2123366400;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003224 File Offset: 0x00001424
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000032D4 File Offset: 0x000014D4
		public string UiLable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)299237377;
				if (num != 0)
				{
				}
				num = (short)41428329;
				short num2 = num;
				num = (short)1711613289;
				switch (num2 == num)
				{
				}
				num = (short)179765248;
				short num3 = num;
				num = (short)1115881472;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1357571850;
				short num2 = num;
				num = (short)1314514698;
				switch (num2 == num)
				{
				}
				num = (short)1216741376;
				if (num != 0)
				{
				}
				num = (short)1672478720;
				short num3 = num;
				num = (short)461766657;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003384 File Offset: 0x00001584
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00003438 File Offset: 0x00001638
		public string NumberScale
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)706717043;
				short num2 = num;
				num = (short)1271440755;
				switch (num2 == num)
				{
				}
				num = (short)979435520;
				if (num != 0)
				{
				}
				num = (short)317652992;
				short num3 = num;
				num = (short)2069823489;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)483000321;
				if (num != 0)
				{
				}
				num = (short)1194775191;
				short num2 = num;
				num = (short)1990251159;
				switch (num2 == num)
				{
				}
				num = (short)1272381440;
				short num3 = num;
				num = (short)1525481472;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000034EC File Offset: 0x000016EC
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00003598 File Offset: 0x00001798
		public global::System.Type FieldType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1626530568;
				short num2 = num;
				num = (short)1179640584;
				switch (num2 == num)
				{
				}
				num = (short)76021761;
				if (num != 0)
				{
				}
				num = (short)1283129344;
				short num3 = num;
				num = (short)1000865792;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)13942693;
				short num2 = num;
				num = (short)524795813;
				switch (num2 == num)
				{
				}
				num = (short)567017472;
				if (num != 0)
				{
				}
				num = (short)1678704640;
				short num3 = num;
				num = (short)670367745;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003648 File Offset: 0x00001848
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000036F8 File Offset: 0x000018F8
		public global::System.Collections.Generic.List<string> FieldNameList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)741539841;
				if (num != 0)
				{
				}
				num = (short)315948194;
				short num2 = num;
				num = (short)324271266;
				switch (num2 == num)
				{
				}
				num = (short)765001728;
				short num3 = num;
				num = (short)1488191488;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)25389734;
				short num2 = num;
				num = (short)1617848998;
				switch (num2 == num)
				{
				}
				num = (short)1144782848;
				if (num != 0)
				{
				}
				num = (short)1075183616;
				short num3 = num;
				num = (short)1313931265;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000037A8 File Offset: 0x000019A8
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00003858 File Offset: 0x00001A58
		public global::System.Windows.Data.IValueConverter FieldUIConverter
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1791026059;
				short num2 = num;
				num = (short)1524491147;
				switch (num2 == num)
				{
				}
				num = (short)164036609;
				if (num != 0)
				{
				}
				num = (short)345047040;
				short num3 = num;
				num = (short)1654784000;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1013645312;
				short num2 = num;
				num = (short)930283521;
				if (num != 0)
				{
				}
				num = (short)253104468;
				short num3 = num;
				num = (short)7803220;
				switch (num3 == num)
				{
				}
				num = (short)1491927040;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x04000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x04000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x0400001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x0400001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Type d;

		// Token: 0x0400001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<string> e;

		// Token: 0x0400001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Data.IValueConverter f;
	}
}
