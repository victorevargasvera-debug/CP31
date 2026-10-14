using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes
{
	// Token: 0x02000110 RID: 272
	public class SetCountMaxLimitReached : global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType
	{
		// Token: 0x06000CDC RID: 3292 RVA: 0x000C0034 File Offset: 0x000BE234
		public SetCountMaxLimitReached(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory parent)
		{
			this.a = parent;
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x000C0050 File Offset: 0x000BE250
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory ParentCategory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1752340744;
				short num2 = num;
				num = (short)1630312712;
				switch (num2 == num)
				{
				}
				num = (short)1514078209;
				if (num != 0)
				{
				}
				num = (short)691666944;
				if (num != 0)
				{
				}
				num = (short)536084480;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x000C0100 File Offset: 0x000BE300
		global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType.Model
		{
			get
			{
				short num = (short)1502517820;
				short num2 = num;
				num = (short)137468476;
				switch (num2 == num)
				{
				}
				num = (short)2058485761;
				if (num != 0)
				{
				}
				num = (short)134414336;
				if (num != 0)
				{
				}
				num = (short)80347136;
				short num3 = num;
				return this.ParentCategory;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x000C01B0 File Offset: 0x000BE3B0
		public string InvalidValue
		{
			get
			{
				short num = (short)98304001;
				if (num != 0)
				{
				}
				num = (short)407009763;
				short num2 = num;
				num = (short)2096855523;
				switch (num2 == num)
				{
				}
				num = (short)1039597568;
				if (num != 0)
				{
				}
				num = (short)1337589760;
				short num3 = num;
				return null;
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000C025C File Offset: 0x000BE45C
		public override string ToString()
		{
			short num = (short)1968963679;
			short num2 = num;
			num = (short)1284178015;
			switch (num2 == num)
			{
			}
			num = (short)1991311361;
			if (num != 0)
			{
			}
			num = (short)1651769344;
			if (num != 0)
			{
			}
			num = (short)814678016;
			short num3 = num;
			return string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Cannot_paste_set_max_limit_reached, this.ParentCategory.UIName);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000C031C File Offset: 0x000BE51C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1257772710 + A_1) + (global::System.IntPtr)71 + (global::System.IntPtr)77);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}

		// Token: 0x0400048D RID: 1165
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory a;
	}
}
