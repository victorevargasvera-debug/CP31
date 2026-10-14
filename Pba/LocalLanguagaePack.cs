using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000016 RID: 22
	[global::System.Serializable]
	public class LocalLanguagaePack
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000077C8 File Offset: 0x000059C8
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000787C File Offset: 0x00005A7C
		public byte[] LlpValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2098593792;
				short num2 = num;
				num = (short)1877671937;
				if (num != 0)
				{
				}
				num = (short)1485312685;
				short num3 = num;
				num = (short)1481380525;
				switch (num3 == num)
				{
				}
				num = (short)1306853376;
				if (num != 0)
				{
				}
				return this.<LlpValue>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1351548928;
				short num2 = num;
				num = (short)1226375169;
				if (num != 0)
				{
				}
				num = (short)138744394;
				short num3 = num;
				num = (short)1771508298;
				switch (num3 == num)
				{
				}
				num = (short)1065025536;
				if (num != 0)
				{
				}
				this.<LlpValue>k__BackingField = value;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007930 File Offset: 0x00005B30
		public LocalLanguagaePack()
		{
			this.LlpValue = null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000794C File Offset: 0x00005B4C
		public void Initialize(byte[] llpData)
		{
			short num = (short)2103246848;
			short num2 = num;
			num = (short)1511427219;
			short num3 = num;
			num = (short)774933651;
			switch (num3 == num)
			{
			}
			num = (short)1944584193;
			if (num != 0)
			{
			}
			num = (short)68812800;
			if (num != 0)
			{
			}
			this.LlpValue = new byte[llpData.Length];
			global::System.Array.Copy(llpData, this.LlpValue, llpData.Length);
		}
	}
}
