using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using Gibraltar.Server.Data;

namespace Gibraltar.Data
{
	// Token: 0x02000255 RID: 597
	[global::System.Diagnostics.DebuggerDisplay("Opt In: {OptIn} Selection Made: {SelectionMade} Id: {Id}")]
	internal class AutoSendConsent
	{
		// Token: 0x06001DE6 RID: 7654 RVA: 0x0006ABC8 File Offset: 0x00068DC8
		public AutoSendConsent(global::System.Guid id, string productName, string applicationName, global::System.Version applicationVersion, int userPrompts, bool selectionMade, bool optIn, bool includeDetails, global::System.DateTimeOffset updatedDt, string updatedUser)
		{
			this.Id = id;
			this.ProductName = productName;
			this.ApplicationName = applicationName;
			this.ApplicationVersion = applicationVersion;
			this.UserPrompts = userPrompts;
			this.SelectionMade = selectionMade;
			this.OptIn = optIn;
			this.IncludeDetails = includeDetails;
			this.UpdatedDt = updatedDt;
			this.UpdatedUser = updatedUser;
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x0006AC2C File Offset: 0x00068E2C
		internal AutoSendConsent(string productName, string applicationName, global::System.Version applicationVersion, string auditUser)
		{
			this.Id = global::System.Guid.NewGuid();
			this.ProductName = productName;
			this.ApplicationName = applicationName;
			this.ApplicationVersion = applicationVersion;
			this.UserPrompts = 0;
			this.SelectionMade = false;
			this.OptIn = false;
			this.UpdatedDt = global::System.DateTimeOffset.Now;
			this.UpdatedUser = auditUser;
			this.IsNew = true;
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x0006AC94 File Offset: 0x00068E94
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x0006AC9C File Offset: 0x00068E9C
		public global::System.Guid Id { get; private set; }

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0006ACA8 File Offset: 0x00068EA8
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x0006ACB0 File Offset: 0x00068EB0
		public string ProductName { get; set; }

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x0006ACBC File Offset: 0x00068EBC
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x0006ACC4 File Offset: 0x00068EC4
		public string ApplicationName { get; set; }

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0006ACD0 File Offset: 0x00068ED0
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x0006ACD8 File Offset: 0x00068ED8
		public global::System.Version ApplicationVersion { get; set; }

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0006ACE4 File Offset: 0x00068EE4
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0006ACEC File Offset: 0x00068EEC
		public int UserPrompts { get; set; }

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0006ACF8 File Offset: 0x00068EF8
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x0006AD00 File Offset: 0x00068F00
		public bool SelectionMade { get; set; }

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x0006AD0C File Offset: 0x00068F0C
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x0006AD14 File Offset: 0x00068F14
		public bool OptIn { get; set; }

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x0006AD20 File Offset: 0x00068F20
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x0006AD28 File Offset: 0x00068F28
		public bool IncludeDetails { get; set; }

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x0006AD34 File Offset: 0x00068F34
		// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x0006AD3C File Offset: 0x00068F3C
		public global::System.DateTimeOffset UpdatedDt { get; set; }

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x0006AD48 File Offset: 0x00068F48
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x0006AD50 File Offset: 0x00068F50
		public string UpdatedUser { get; set; }

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x0006AD5C File Offset: 0x00068F5C
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x0006AD64 File Offset: 0x00068F64
		public bool IsNew { get; private set; }

		// Token: 0x06001DFE RID: 7678 RVA: 0x0006AD70 File Offset: 0x00068F70
		public static global::Gibraltar.Data.AutoSendConsent LoadFile(string fileNamePath)
		{
			global::Gibraltar.Data.AutoSendConsent result = null;
			using (global::System.IO.FileStream fileStream = global::Gibraltar.Data.Win32Helper.OpenFileStream(fileNamePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
			{
				if (fileStream != null)
				{
					try
					{
						byte[] array = new byte[10800];
						fileStream.Read(array, 0, 10800);
						result = global::Gibraltar.Server.Data.DataConverter.ByteArrayToAutoSendConsent(array);
					}
					catch (global::System.Exception obj)
					{
						global::System.GC.KeepAlive(obj);
					}
				}
			}
			return result;
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0006ADF0 File Offset: 0x00068FF0
		public void Save(string fileNamePath)
		{
			int i = 0;
			while (i < 4)
			{
				using (global::System.IO.FileStream fileStream = global::Gibraltar.Data.Win32Helper.OpenFileStream(fileNamePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.None))
				{
					if (fileStream != null)
					{
						byte[] array = global::Gibraltar.Server.Data.DataConverter.AutoSendConsentToByteArray(this);
						fileStream.SetLength(0L);
						fileStream.Write(array, 0, array.Length);
						break;
					}
					i++;
					global::System.Threading.Thread.Sleep(16);
				}
			}
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0006AE64 File Offset: 0x00069064
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
			if (this.SelectionMade)
			{
				stringBuilder.AppendFormat("Selection: {0}\r\n", this.OptIn ? "Opt In" : "Opt Out");
				if (this.OptIn)
				{
					stringBuilder.AppendFormat("Level: {0}\r\n", this.IncludeDetails ? "Include All" : "Anonymous Summary");
				}
			}
			else
			{
				stringBuilder.AppendFormat("No opt in selection made.  User has been prompted {0} times.\r\n", this.UserPrompts);
			}
			stringBuilder.AppendFormat("Applies to:\r\n  Product: {0}\r\n", this.ProductName);
			if (!string.IsNullOrEmpty(this.ApplicationName))
			{
				stringBuilder.AppendFormat("  Application: {0}\r\n", this.ApplicationName);
			}
			stringBuilder.AppendFormat("Last Updated {0:G} by {1}\r\n", this.UpdatedDt, this.UpdatedUser);
			return stringBuilder.ToString();
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0006AF58 File Offset: 0x00069158
		public static bool IsNullOrNoSelection(global::Gibraltar.Data.AutoSendConsent consent)
		{
			return consent == null || !consent.SelectionMade;
		}

		// Token: 0x04000B25 RID: 2853
		public const string LogCategory = "Loupe.Agent.Consent";
	}
}
