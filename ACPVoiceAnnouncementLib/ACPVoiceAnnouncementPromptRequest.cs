using System;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x0200000D RID: 13
	public class ACPVoiceAnnouncementPromptRequest
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002BE4 File Offset: 0x00000DE4
		internal ACPVoiceAnnouncementPromptRequest(string A_0)
		{
			this.a = A_0;
			this.b = global::ACPVoiceAnnouncementLib.ACPVoiceCompressPromptResponse.SKIP_FILE;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002C08 File Offset: 0x00000E08
		internal string Filename
		{
			get
			{
				short num = (short)595984385;
				if (num != 0)
				{
				}
				num = (short)1213923328;
				short num2 = num;
				num = (short)47135609;
				short num3 = num;
				num = (short)1774336889;
				switch (num3 == num)
				{
				}
				num = (short)284688384;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002D68 File Offset: 0x00000F68
		public global::ACPVoiceAnnouncementLib.ACPVoiceCompressPromptResponse ActionToTake
		{
			get
			{
				short num = (short)1389084093;
				short num2 = num;
				num = (short)1399766461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1359413248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1289551873;
				if (num != 0)
				{
				}
				num = (short)2076377088;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)801014724;
				short num2 = num;
				num = (short)1248428996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)226230272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)238616577;
				if (num != 0)
				{
				}
				num = (short)524419072;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0400002B RID: 43
		private string a;

		// Token: 0x0400002C RID: 44
		private global::ACPVoiceAnnouncementLib.ACPVoiceCompressPromptResponse b;
	}
}
