using System;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x02000012 RID: 18
	public class ShowVAPacksViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000B148 File Offset: 0x00009348
		public ShowVAPacksViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext showTemplateVAPacksContext) : base(eventAggregator, commandHandler)
		{
			this.ShowTemplateVAPacksContext = showTemplateVAPacksContext;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000B164 File Offset: 0x00009364
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000B214 File Offset: 0x00009414
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext ShowTemplateVAPacksContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1967474284;
				short num2 = num;
				num = (short)807880300;
				switch (num2 == num)
				{
				}
				num = (short)1862336512;
				short num3 = num;
				num = (short)1071710209;
				if (num != 0)
				{
				}
				num = (short)126418944;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)364112855;
				short num2 = num;
				num = (short)1231940567;
				switch (num2 == num)
				{
				}
				num = (short)1688862720;
				short num3 = num;
				num = (short)1838219265;
				if (num != 0)
				{
				}
				num = (short)455344128;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000B2C4 File Offset: 0x000094C4
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1517795804 + A_1) + (global::System.IntPtr)15 + (global::System.IntPtr)8);
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

		// Token: 0x04000042 RID: 66
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext a;
	}
}
