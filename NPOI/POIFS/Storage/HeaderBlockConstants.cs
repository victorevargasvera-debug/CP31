using System;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002AC RID: 684
	public class HeaderBlockConstants
	{
		// Token: 0x040007CC RID: 1996
		public const long _signature = -2226271756974174256L;

		// Token: 0x040007CD RID: 1997
		public const int _bat_array_offset = 76;

		// Token: 0x040007CE RID: 1998
		public const int _max_bats_in_header = 109;

		// Token: 0x040007CF RID: 1999
		public const int _signature_offset = 0;

		// Token: 0x040007D0 RID: 2000
		public const int _bat_count_offset = 44;

		// Token: 0x040007D1 RID: 2001
		public const int _property_start_offset = 48;

		// Token: 0x040007D2 RID: 2002
		public const int _sbat_start_offset = 60;

		// Token: 0x040007D3 RID: 2003
		public const int _sbat_block_count_offset = 64;

		// Token: 0x040007D4 RID: 2004
		public const int _xbat_start_offset = 68;

		// Token: 0x040007D5 RID: 2005
		public const int _xbat_count_offset = 72;
	}
}
