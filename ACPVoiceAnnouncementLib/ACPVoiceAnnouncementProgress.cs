using System;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x0200000C RID: 12
	public class ACPVoiceAnnouncementProgress
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000028EC File Offset: 0x00000AEC
		internal ACPVoiceAnnouncementProgress(string A_0, global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes A_1, int A_2, int A_3)
		{
			this.a = new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementResult(A_0, A_1);
			this.b = A_2;
			this.c = A_3;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000291C File Offset: 0x00000B1C
		public string FileName
		{
			get
			{
				short num = (short)1628845181;
				short num2 = num;
				num = (short)1654862973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2125922304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)640090113;
				if (num != 0)
				{
				}
				num = (short)601620480;
				if (num != 0)
				{
				}
				return this.a.FileName;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000029D0 File Offset: 0x00000BD0
		public global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes Code
		{
			get
			{
				short num = (short)1130644570;
				short num2 = num;
				num = (short)1874609242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1540620288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)930152448;
				if (num != 0)
				{
				}
				num = (short)1957756929;
				if (num != 0)
				{
				}
				return this.a.Code;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002A84 File Offset: 0x00000C84
		public int TotalFileCount
		{
			get
			{
				short num = (short)46363854;
				short num2 = num;
				num = (short)1712288974;
				switch (num2 == num)
				{
				default:
				{
					num = (short)391839744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1533083649;
				if (num != 0)
				{
				}
				num = (short)860946432;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002B34 File Offset: 0x00000D34
		public int CurrentFileCount
		{
			get
			{
				short num = (short)1080016194;
				short num2 = num;
				num = (short)362659138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1069088768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)777519105;
				if (num != 0)
				{
				}
				num = (short)1564540928;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x04000028 RID: 40
		private global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementResult a;

		// Token: 0x04000029 RID: 41
		private int b;

		// Token: 0x0400002A RID: 42
		private int c;
	}
}
