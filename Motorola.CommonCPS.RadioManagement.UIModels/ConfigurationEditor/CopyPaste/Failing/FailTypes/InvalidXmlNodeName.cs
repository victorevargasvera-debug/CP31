using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes
{
	// Token: 0x0200010D RID: 269
	public class InvalidXmlNodeName : global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType
	{
		// Token: 0x06000CD0 RID: 3280 RVA: 0x000BF980 File Offset: 0x000BDB80
		public InvalidXmlNodeName(global::Motorola.CommonCPS.RadioManagement.UIModels.Set containingSet, string unexpectedXmlNodeName)
		{
			this.a = containingSet;
			this.b = unexpectedXmlNodeName;
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000BF9A4 File Offset: 0x000BDBA4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase Model
		{
			get
			{
				short num = (short)1243358268;
				short num2 = num;
				num = (short)1889150012;
				switch (num2 == num)
				{
				}
				num = (short)652869632;
				if (num != 0)
				{
				}
				num = (short)5832705;
				if (num != 0)
				{
				}
				num = (short)906756096;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x000BFA54 File Offset: 0x000BDC54
		public string InvalidValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)393427520;
				short num2 = num;
				num = (short)965622336;
				switch (num2 == num)
				{
				}
				num = (short)284491776;
				if (num != 0)
				{
				}
				num = (short)1243611137;
				if (num != 0)
				{
				}
				num = (short)808910848;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000BFB04 File Offset: 0x000BDD04
		public override string ToString()
		{
			short num = (short)49900899;
			short num2 = num;
			num = (short)2109304163;
			switch (num2 == num)
			{
			}
			num = (short)558301185;
			if (num != 0)
			{
			}
			num = (short)781582336;
			if (num != 0)
			{
			}
			num = (short)643301376;
			short num3 = num;
			return string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Cannot_paste_invlid_xml, this.InvalidValue);
		}

		// Token: 0x04000487 RID: 1159
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.Set a;

		// Token: 0x04000488 RID: 1160
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string b;
	}
}
