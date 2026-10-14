using System;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes
{
	// Token: 0x0200010B RID: 267
	public class SetAddingFailed : global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType
	{
		// Token: 0x06000CC7 RID: 3271 RVA: 0x000BF430 File Offset: 0x000BD630
		public SetAddingFailed(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory, string setIdentifier)
		{
			int a_ = 11;
			base..ctor();
			this.a = setCategory;
			if (setCategory == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㕅ⵇ㹉ཋ⽍⑏㝑㍓㥕⩗⍙", a_));
			}
			this.b = setIdentifier;
			if (setIdentifier == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㕅ⵇ㹉Ջ⩍㕏㱑⁓㽕㹗㍙㥛ⱝ", a_));
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x000BF490 File Offset: 0x000BD690
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase Model
		{
			get
			{
				short num = (short)946470913;
				if (num != 0)
				{
				}
				num = (short)1482009234;
				short num2 = num;
				num = (short)1605413522;
				switch (num2 == num)
				{
				}
				num = (short)568000512;
				if (num != 0)
				{
				}
				num = (short)252837888;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x000BF53C File Offset: 0x000BD73C
		public string InvalidValue
		{
			get
			{
				short num = (short)661683620;
				short num2 = num;
				num = (short)1800306084;
				switch (num2 == num)
				{
				}
				num = (short)11534336;
				if (num != 0)
				{
				}
				num = (short)988413953;
				if (num != 0)
				{
				}
				num = (short)1374289920;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x000BF5EC File Offset: 0x000BD7EC
		public override string ToString()
		{
			short num = (short)1979275355;
			short num2 = num;
			num = (short)779442267;
			switch (num2 == num)
			{
			}
			num = (short)1377501185;
			if (num != 0)
			{
			}
			num = (short)1129447424;
			if (num != 0)
			{
			}
			num = (short)1406533632;
			short num3 = num;
			return string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Cannot_paste_set_into, this.a.UIName);
		}

		// Token: 0x04000484 RID: 1156
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory a;

		// Token: 0x04000485 RID: 1157
		private readonly string b;
	}
}
