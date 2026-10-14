using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes
{
	// Token: 0x0200010E RID: 270
	public class InvalidFieldValue : global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType
	{
		// Token: 0x06000CD4 RID: 3284 RVA: 0x000BFBC0 File Offset: 0x000BDDC0
		public InvalidFieldValue(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase field, string fieldValueToPaste)
		{
			this.a = field;
			this.b = fieldValueToPaste;
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000BFBE4 File Offset: 0x000BDDE4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase Model
		{
			get
			{
				short num = (short)1220967357;
				short num2 = num;
				num = (short)1063222205;
				switch (num2 == num)
				{
				}
				num = (short)216072192;
				if (num != 0)
				{
				}
				num = (short)305725441;
				if (num != 0)
				{
				}
				num = (short)1068564480;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x000BFC94 File Offset: 0x000BDE94
		public string InvalidValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)203993227;
				short num2 = num;
				num = (short)2098573451;
				switch (num2 == num)
				{
				}
				num = (short)2121400320;
				if (num != 0)
				{
				}
				num = (short)1116012545;
				if (num != 0)
				{
				}
				num = (short)584581120;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000BFD40 File Offset: 0x000BDF40
		public override string ToString()
		{
			short num = (short)922877953;
			if (num != 0)
			{
			}
			num = (short)2027591853;
			short num2 = num;
			num = (short)1270913197;
			switch (num2 == num)
			{
			}
			num = (short)440532992;
			if (num != 0)
			{
			}
			num = (short)93650944;
			short num3 = num;
			return string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Cannot_paste_invlid_value, this.InvalidValue);
		}

		// Token: 0x04000489 RID: 1161
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase a;

		// Token: 0x0400048A RID: 1162
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string b;
	}
}
