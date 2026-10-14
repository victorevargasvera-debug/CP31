using System;

namespace RMIBtnWrapperLib
{
	// Token: 0x02000003 RID: 3
	public class CommonDefs
	{
		// Token: 0x04000003 RID: 3
		public const string MOTO_BTN = "{BAFBC1A2BC3A4bfe9BBE147B0E341A180xbafbc1a2,0xbc3a0x4bfe{0x9b";

		// Token: 0x04000004 RID: 4
		public const string NONMOTO_BTN = "{6BCB32177E034B3CBDA0DDA9A6E8E4760xC3A4bfe1,0x4bfe1xAa7c{0xB9";

		// Token: 0x04000005 RID: 5
		public const string validFileNameChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$%&'-@^_`{}~";

		// Token: 0x04000006 RID: 6
		public readonly int[] dm = new int[]
		{
			0,
			0,
			31,
			59,
			90,
			120,
			151,
			181,
			212,
			243,
			273,
			304,
			334,
			365
		};

		// Token: 0x04000007 RID: 7
		public const string strLMP_1_2 = "cUN";

		// Token: 0x04000008 RID: 8
		public const string strLMP_2_2 = "AxA";

		// Token: 0x04000009 RID: 9
		public const int UDP_LENGTH = 32;

		// Token: 0x0400000A RID: 10
		public const int PAGE_SIZE = 32;

		// Token: 0x0400000B RID: 11
		public const int UDP_DATA_LENGTH = 28;

		// Token: 0x0400000C RID: 12
		public const int INVALID_SHANDLE = 0;

		// Token: 0x0400000D RID: 13
		public const int INVALID_FHANDLE = -1;

		// Token: 0x0400000E RID: 14
		public const int NUM_SECONDS_IN_DAY = 86400;

		// Token: 0x0400000F RID: 15
		public const int DS1994_FAMILY = 4;

		// Token: 0x04000010 RID: 16
		public const int DS1996_FAMILY = 12;

		// Token: 0x04000011 RID: 17
		public const int DS1963_FAMILY = 24;

		// Token: 0x04000012 RID: 18
		public const int MAX_FAMILY_TYPE = 127;

		// Token: 0x04000013 RID: 19
		public const int MAPF_VERSION_NUM_SZ = 6;

		// Token: 0x04000014 RID: 20
		public const int MAPF_DATA_SZ = 58;

		// Token: 0x04000015 RID: 21
		public const int MAPF_SN_START = 6;

		// Token: 0x04000016 RID: 22
		public const int MAPF_COMMUNITY_START = 14;

		// Token: 0x04000017 RID: 23
		public const int MAPF_COMMUNITY_LEN = 2;

		// Token: 0x04000018 RID: 24
		public const int MAPF_USERID_START = 16;

		// Token: 0x04000019 RID: 25
		public const int MAPF_USERID_LEN = 10;

		// Token: 0x0400001A RID: 26
		public const int MAPF_PASSWORD = 25;

		// Token: 0x0400001B RID: 27
		public const int MAPF_PASSWORD_LEN = 8;

		// Token: 0x0400001C RID: 28
		public const int NUM_WRITE_SCRATCH_CFG_BYTES = 3;

		// Token: 0x0400001D RID: 29
		public const int NUM_READ_SCRATCH_CFG_BYTES = 4;

		// Token: 0x0400001E RID: 30
		public const int NUM_COPY_SCRATCH_CFG_BYTES = 4;

		// Token: 0x0400001F RID: 31
		public const int NUM_READ_MEMORY_CFG_BYTES = 4;

		// Token: 0x04000020 RID: 32
		public const int CMD_READ_MEMORY = 240;

		// Token: 0x04000021 RID: 33
		public const int CMD_WRITE_SCRATCH = 15;

		// Token: 0x04000022 RID: 34
		public const int CMD_READ_SCRATCH = 170;

		// Token: 0x04000023 RID: 35
		public const int CMD_COPY_SCRATCH = 85;

		// Token: 0x04000024 RID: 36
		public const int CMD_SKIP_ROM = 204;

		// Token: 0x04000025 RID: 37
		public const int CMD_MATCH_ROM = 85;

		// Token: 0x04000026 RID: 38
		public const int CMD_ERASE_SCRATCH = 195;

		// Token: 0x04000027 RID: 39
		public const int DS1994_SCRATCHPAD_SZ = 32;

		// Token: 0x04000028 RID: 40
		public const int MAX_ERR_MSG_SZ = 512;

		// Token: 0x04000029 RID: 41
		public const int SERIAL_NUM_SZ = 8;

		// Token: 0x0400002A RID: 42
		public const int MAX_FILENAME_LENGTH = 4;

		// Token: 0x0400002B RID: 43
		public const int MAX_FILE_DATA_SZ_1994_1963 = 420;

		// Token: 0x0400002C RID: 44
		public const int MAX_FILE_DATA_SZ_1996 = 7057;

		// Token: 0x0400002D RID: 45
		public const int MIN_PORT_NUM = 0;

		// Token: 0x0400002E RID: 46
		public const int MAX_PORT_NUM = 15;

		// Token: 0x0400002F RID: 47
		public const byte STATUS_REG_ADDR_LSB = 0;

		// Token: 0x04000030 RID: 48
		public const byte STATUS_REG_ADDR_MSB = 2;

		// Token: 0x04000031 RID: 49
		public const byte STATUS_REG_SZ = 1;

		// Token: 0x04000032 RID: 50
		public const byte STATUS_REG_OFFSET = 0;

		// Token: 0x04000033 RID: 51
		public const byte CTRL_REG_ADDR_LSB = 1;

		// Token: 0x04000034 RID: 52
		public const byte CTRL_REG_ADDR_MSB = 2;

		// Token: 0x04000035 RID: 53
		public const byte CTRL_REG_SZ = 1;

		// Token: 0x04000036 RID: 54
		public const byte CTRL_REG_OFFSET = 1;

		// Token: 0x04000037 RID: 55
		public const byte RTC_CNTR_ADDR_LSB = 2;

		// Token: 0x04000038 RID: 56
		public const byte RTC_CNTR_ADDR_MSB = 2;

		// Token: 0x04000039 RID: 57
		public const byte RTC_CNTR_SZ = 5;

		// Token: 0x0400003A RID: 58
		public const byte RTC_CNTR_OFFSET = 2;

		// Token: 0x0400003B RID: 59
		public const byte RTC_ALARM_ADDR_LSB = 16;

		// Token: 0x0400003C RID: 60
		public const byte RTC_ALARM_ADDR_MSB = 2;

		// Token: 0x0400003D RID: 61
		public const byte RTC_ALARM_SZ = 5;

		// Token: 0x0400003E RID: 62
		public const byte RTC_ALARM_OFFSET = 16;

		// Token: 0x0400003F RID: 63
		public const byte INTERVAL_CNTR_ADDR_LSB = 7;

		// Token: 0x04000040 RID: 64
		public const byte INTERVAL_CNTR_ADDR_MSB = 2;

		// Token: 0x04000041 RID: 65
		public const byte INTERVAL_CNTR_SZ = 5;

		// Token: 0x04000042 RID: 66
		public const byte INTERVAL_CNTR_OFFSET = 7;

		// Token: 0x04000043 RID: 67
		public const byte INTERVAL_ALARM_ADDR_LSB = 21;

		// Token: 0x04000044 RID: 68
		public const byte INTERVAL_ALARM_ADDR_MSB = 2;

		// Token: 0x04000045 RID: 69
		public const byte INTERVAL_ALARM_SZ = 5;

		// Token: 0x04000046 RID: 70
		public const byte INTERVAL_ALARM_OFFSET = 21;

		// Token: 0x04000047 RID: 71
		public const byte TIMEKEEPING_PG_ADDR_LSB = 0;

		// Token: 0x04000048 RID: 72
		public const byte TIMEKEEPING_PG_ADDR_MSB = 2;

		// Token: 0x04000049 RID: 73
		public const byte TIMEKEEPING_PG_SZ = 30;

		// Token: 0x0400004A RID: 74
		public const int MIN_RETRY_CNT = 0;

		// Token: 0x0400004B RID: 75
		public const int DEFAULT_RETRY_CNT = 5;

		// Token: 0x0400004C RID: 76
		public const int MAX_RETRY_CNT = 10;

		// Token: 0x0400004D RID: 77
		public ushort CRC16;

		// Token: 0x0400004E RID: 78
		public byte DOWCRC;

		// Token: 0x0400004F RID: 79
		public int[] in_overdrive = new int[2];
	}
}
