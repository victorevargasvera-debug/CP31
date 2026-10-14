using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200018B RID: 395
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class SummaryFieldDefinition : global::System.Attribute
	{
		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000E2270 File Offset: 0x000E0470
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x000E2324 File Offset: 0x000E0524
		public global::System.Type SourceEntityType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1467613184;
				short num2 = num;
				num = (short)650943819;
				short num3 = num;
				num = (short)551787851;
				switch (num3 == num)
				{
				}
				num = (short)211746817;
				if (num != 0)
				{
				}
				num = (short)713490432;
				if (num != 0)
				{
				}
				return this.<SourceEntityType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1459879936;
				short num2 = num;
				num = (short)135217106;
				short num3 = num;
				num = (short)147472338;
				switch (num3 == num)
				{
				}
				num = (short)1694171136;
				if (num != 0)
				{
				}
				num = (short)2037448705;
				if (num != 0)
				{
				}
				this.<SourceEntityType>k__BackingField = value;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x000E23D4 File Offset: 0x000E05D4
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x000E2488 File Offset: 0x000E0688
		public string SourceEntityPropertyName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1269039104;
				short num2 = num;
				num = (short)315621377;
				if (num != 0)
				{
				}
				num = (short)1402778053;
				short num3 = num;
				num = (short)920826309;
				switch (num3 == num)
				{
				}
				num = (short)1058537472;
				if (num != 0)
				{
				}
				return this.<SourceEntityPropertyName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)190119936;
				short num2 = num;
				num = (short)1539671000;
				short num3 = num;
				num = (short)471958488;
				switch (num3 == num)
				{
				}
				num = (short)1194328064;
				if (num != 0)
				{
				}
				num = (short)1011548161;
				if (num != 0)
				{
				}
				this.<SourceEntityPropertyName>k__BackingField = value;
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x000E2534 File Offset: 0x000E0734
		public SummaryFieldDefinition(string columnName, global::System.Type type)
		{
			this.SourceEntityPropertyName = columnName;
			this.SourceEntityType = type;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x000E2558 File Offset: 0x000E0758
		public bool IsTypeMatched(global::System.Type sourceEntityType)
		{
			short num = (short)104726529;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			int num2;
			bool result;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
				{
					num = (short)666118488;
					short num3 = num;
					num = (short)734669144;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F9;
					default:
						num = (short)351797248;
						if (num != 0)
						{
						}
						if (!(sourceEntityType == this.SourceEntityType))
						{
							num = (short)1989541889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FB;
					}
					break;
				}
				case 1:
					goto IL_F9;
				case 2:
					return result;
				case 3:
					goto IL_FB;
				case 4:
					if (sourceEntityType.IsSubclassOf(this.SourceEntityType))
					{
						num = (short)848822275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4B;
				IL_F9:
				num = (short)1668022276;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FB:
				result = true;
				num = (short)1858207746;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4B:
			num = (short)1532100608;
			short num4 = num;
			result = false;
			num = (short)360382464;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}
	}
}
