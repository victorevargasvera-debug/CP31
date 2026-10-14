using System;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes
{
	// Token: 0x0200010F RID: 271
	public class FieldNotFound : global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType
	{
		// Token: 0x06000CD8 RID: 3288 RVA: 0x000BFDF8 File Offset: 0x000BDFF8
		public FieldNotFound(global::Motorola.CommonCPS.RadioManagement.UIModels.Set containingSet, string missingFieldName)
		{
			this.a = containingSet;
			this.b = missingFieldName;
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x000BFE1C File Offset: 0x000BE01C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase Model
		{
			get
			{
				short num = (short)1913675903;
				short num2 = num;
				num = (short)236281983;
				switch (num2 == num)
				{
				}
				num = (short)1833631744;
				if (num != 0)
				{
				}
				num = (short)453771265;
				if (num != 0)
				{
				}
				num = (short)184418304;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x000BFECC File Offset: 0x000BE0CC
		public string InvalidValue
		{
			get
			{
				short num = (short)2130706433;
				if (num != 0)
				{
				}
				num = (short)1917407968;
				short num2 = num;
				num = (short)138236640;
				switch (num2 == num)
				{
				}
				num = (short)1570635776;
				if (num != 0)
				{
				}
				num = (short)644022272;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x000BFF7C File Offset: 0x000BE17C
		public override string ToString()
		{
			short num = (short)1959723009;
			if (num != 0)
			{
			}
			num = (short)252954183;
			short num2 = num;
			num = (short)347326023;
			switch (num2 == num)
			{
			}
			num = (short)2076770304;
			if (num != 0)
			{
			}
			num = (short)2140078080;
			short num3 = num;
			return string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Cannot_paste_field_not_found, this.b);
		}

		// Token: 0x0400048B RID: 1163
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.Set a;

		// Token: 0x0400048C RID: 1164
		private readonly string b;
	}
}
