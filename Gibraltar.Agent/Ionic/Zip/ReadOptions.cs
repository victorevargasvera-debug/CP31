using System;
using System.IO;
using System.Text;

namespace Ionic.Zip
{
	// Token: 0x0200046F RID: 1135
	internal class ReadOptions
	{
		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x000B6C2C File Offset: 0x000B4E2C
		// (set) Token: 0x060031E8 RID: 12776 RVA: 0x000B6C34 File Offset: 0x000B4E34
		public global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> ReadProgress { get; set; }

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x060031E9 RID: 12777 RVA: 0x000B6C40 File Offset: 0x000B4E40
		// (set) Token: 0x060031EA RID: 12778 RVA: 0x000B6C48 File Offset: 0x000B4E48
		public global::System.IO.TextWriter StatusMessageWriter { get; set; }

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x000B6C54 File Offset: 0x000B4E54
		// (set) Token: 0x060031EC RID: 12780 RVA: 0x000B6C5C File Offset: 0x000B4E5C
		public global::System.Text.Encoding Encoding { get; set; }
	}
}
