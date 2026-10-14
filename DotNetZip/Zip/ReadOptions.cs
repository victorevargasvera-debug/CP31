using System;
using System.IO;
using System.Text;

namespace Ionic.Zip
{
	// Token: 0x02000053 RID: 83
	public class ReadOptions
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00019346 File Offset: 0x00017546
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0001934E File Offset: 0x0001754E
		public global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> ReadProgress { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00019357 File Offset: 0x00017557
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0001935F File Offset: 0x0001755F
		public global::System.IO.TextWriter StatusMessageWriter { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00019368 File Offset: 0x00017568
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00019370 File Offset: 0x00017570
		public global::System.Text.Encoding Encoding { get; set; }
	}
}
