using System;

namespace CefSharp
{
	// Token: 0x02000091 RID: 145
	public class ProxyOptions
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00003C6D File Offset: 0x00001E6D
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00003C75 File Offset: 0x00001E75
		public string IP { get; private set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00003C7E File Offset: 0x00001E7E
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00003C86 File Offset: 0x00001E86
		public string Port { get; private set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00003C8F File Offset: 0x00001E8F
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003C97 File Offset: 0x00001E97
		public string Username { get; set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00003CA0 File Offset: 0x00001EA0
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003CA8 File Offset: 0x00001EA8
		public string Password { get; set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00003CB1 File Offset: 0x00001EB1
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00003CB9 File Offset: 0x00001EB9
		public string BypassList { get; private set; }

		// Token: 0x06000402 RID: 1026 RVA: 0x00003CC2 File Offset: 0x00001EC2
		public bool HasUsernameAndPassword()
		{
			return !string.IsNullOrEmpty(this.Username) && !string.IsNullOrEmpty(this.Password);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00003CE1 File Offset: 0x00001EE1
		public ProxyOptions(string ip, string port, string username = "", string password = "", string bypassList = "")
		{
			this.IP = ip;
			this.Port = port;
			this.Username = username;
			this.Password = password;
			this.BypassList = bypassList;
		}
	}
}
