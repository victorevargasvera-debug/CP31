using System;
using CefSharp.Core;

namespace CefSharp
{
	// Token: 0x0200000E RID: 14
	public class RequestContextSettings
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000033B6 File Offset: 0x000015B6
		// (set) Token: 0x06000110 RID: 272 RVA: 0x000033C3 File Offset: 0x000015C3
		public bool PersistSessionCookies
		{
			get
			{
				return this.settings.PersistSessionCookies;
			}
			set
			{
				this.settings.PersistSessionCookies = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000033D1 File Offset: 0x000015D1
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000033DE File Offset: 0x000015DE
		public bool PersistUserPreferences
		{
			get
			{
				return this.settings.PersistUserPreferences;
			}
			set
			{
				this.settings.PersistUserPreferences = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000033EC File Offset: 0x000015EC
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000033F9 File Offset: 0x000015F9
		public string CachePath
		{
			get
			{
				return this.settings.CachePath;
			}
			set
			{
				this.settings.CachePath = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00003407 File Offset: 0x00001607
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00003414 File Offset: 0x00001614
		public string AcceptLanguageList
		{
			get
			{
				return this.settings.AcceptLanguageList;
			}
			set
			{
				this.settings.AcceptLanguageList = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00003422 File Offset: 0x00001622
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000342F File Offset: 0x0000162F
		public string CookieableSchemesList
		{
			get
			{
				return this.settings.CookieableSchemesList;
			}
			set
			{
				this.settings.CookieableSchemesList = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000343D File Offset: 0x0000163D
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000344A File Offset: 0x0000164A
		public bool CookieableSchemesExcludeDefaults
		{
			get
			{
				return this.settings.CookieableSchemesExcludeDefaults;
			}
			set
			{
				this.settings.CookieableSchemesExcludeDefaults = value;
			}
		}

		// Token: 0x0400000C RID: 12
		internal global::CefSharp.Core.RequestContextSettings settings = new global::CefSharp.Core.RequestContextSettings();
	}
}
