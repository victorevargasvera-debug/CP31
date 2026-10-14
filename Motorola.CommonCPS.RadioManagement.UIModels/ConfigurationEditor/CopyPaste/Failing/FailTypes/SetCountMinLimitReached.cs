using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes
{
	// Token: 0x0200010C RID: 268
	public class SetCountMinLimitReached : global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType
	{
		// Token: 0x06000CCB RID: 3275 RVA: 0x000BF6B0 File Offset: 0x000BD8B0
		public SetCountMinLimitReached(global::Motorola.CommonCPS.RadioManagement.UIModels.Set cannotBeRemoved)
		{
			this.a = cannotBeRemoved;
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x000BF6CC File Offset: 0x000BD8CC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase Model
		{
			get
			{
				short num = (short)1969094657;
				if (num != 0)
				{
				}
				num = (short)308643194;
				short num2 = num;
				num = (short)201819514;
				switch (num2 == num)
				{
				}
				num = (short)2045640704;
				if (num != 0)
				{
				}
				num = (short)41418752;
				short num3 = num;
				return this.CannotBeRemoved;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000BF778 File Offset: 0x000BD978
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Set CannotBeRemoved
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)264147672;
				short num2 = num;
				num = (short)1881051864;
				switch (num2 == num)
				{
				}
				num = (short)274268161;
				if (num != 0)
				{
				}
				num = (short)1990459392;
				if (num != 0)
				{
				}
				num = (short)974585856;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x000BF824 File Offset: 0x000BDA24
		public string InvalidValue
		{
			get
			{
				short num = (short)507772929;
				if (num != 0)
				{
				}
				num = (short)1743411916;
				short num2 = num;
				num = (short)79911628;
				switch (num2 == num)
				{
				}
				num = (short)1542324224;
				if (num != 0)
				{
				}
				num = (short)2130968576;
				short num3 = num;
				return null;
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x000BF8D0 File Offset: 0x000BDAD0
		public override string ToString()
		{
			short num = (short)807403521;
			if (num != 0)
			{
			}
			num = (short)813577044;
			short num2 = num;
			num = (short)164508500;
			switch (num2 == num)
			{
			}
			num = (short)245760000;
			if (num != 0)
			{
			}
			num = (short)574750720;
			short num3 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Cannot_paste_set_min_limit_reached;
		}

		// Token: 0x04000486 RID: 1158
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.Set a;
	}
}
