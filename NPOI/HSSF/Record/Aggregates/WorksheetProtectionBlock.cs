using System;
using NPOI.HSSF.Model;
using NPOI.POIFS.Crypt;
using NPOI.Util;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004CB RID: 1227
	public class WorksheetProtectionBlock : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002E5F RID: 11871 RVA: 0x00088EA3 File Offset: 0x000870A3
		public static bool IsComponentRecord(int sid)
		{
			return sid - 18 <= 1 || sid == 99 || sid == 221;
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00088EBC File Offset: 0x000870BC
		private bool ReadARecord(global::NPOI.HSSF.Model.RecordStream rs)
		{
			int num = rs.PeekNextSid();
			if (num <= 19)
			{
				if (num == 18)
				{
					this.CheckNotPresent(this._protectRecord);
					this._protectRecord = (rs.GetNext() as global::NPOI.HSSF.Record.ProtectRecord);
					return true;
				}
				if (num == 19)
				{
					this.CheckNotPresent(this._passwordRecord);
					this._passwordRecord = (rs.GetNext() as global::NPOI.HSSF.Record.PasswordRecord);
					return true;
				}
			}
			else
			{
				if (num == 99)
				{
					this.CheckNotPresent(this._objectProtectRecord);
					this._objectProtectRecord = (rs.GetNext() as global::NPOI.HSSF.Record.ObjectProtectRecord);
					return true;
				}
				if (num == 221)
				{
					this.CheckNotPresent(this._scenarioProtectRecord);
					this._scenarioProtectRecord = (rs.GetNext() as global::NPOI.HSSF.Record.ScenarioProtectRecord);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x00088F72 File Offset: 0x00087172
		private void CheckNotPresent(global::NPOI.HSSF.Record.Record rec)
		{
			if (rec != null)
			{
				throw new global::NPOI.Util.RecordFormatException("Duplicate WorksheetProtectionBlock record (sid=0x" + global::NPOI.Util.StringUtil.ToHexString(rec.Sid) + ")");
			}
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00088F97 File Offset: 0x00087197
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock.VisitIfPresent(this._protectRecord, rv);
			global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock.VisitIfPresent(this._objectProtectRecord, rv);
			global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock.VisitIfPresent(this._scenarioProtectRecord, rv);
			global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock.VisitIfPresent(this._passwordRecord, rv);
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00088FC9 File Offset: 0x000871C9
		private static void VisitIfPresent(global::NPOI.HSSF.Record.Record r, global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (r != null)
			{
				rv.VisitRecord(r);
			}
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00088FD5 File Offset: 0x000871D5
		public global::NPOI.HSSF.Record.PasswordRecord GetPasswordRecord()
		{
			return this._passwordRecord;
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00088FDD File Offset: 0x000871DD
		public global::NPOI.HSSF.Record.ScenarioProtectRecord GetHCenter()
		{
			return this._scenarioProtectRecord;
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00088FE5 File Offset: 0x000871E5
		public void AddRecords(global::NPOI.HSSF.Model.RecordStream rs)
		{
			while (this.ReadARecord(rs))
			{
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x00088FF0 File Offset: 0x000871F0
		private global::NPOI.HSSF.Record.ProtectRecord Protect
		{
			get
			{
				if (this._protectRecord == null)
				{
					this._protectRecord = new global::NPOI.HSSF.Record.ProtectRecord(false);
				}
				return this._protectRecord;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x0008900C File Offset: 0x0008720C
		public global::NPOI.HSSF.Record.PasswordRecord Password
		{
			get
			{
				if (this._passwordRecord == null)
				{
					this._passwordRecord = global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock.CreatePassword();
				}
				return this._passwordRecord;
			}
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00089028 File Offset: 0x00087228
		public void ProtectSheet(string password, bool shouldProtectObjects, bool shouldProtectScenarios)
		{
			if (password == null)
			{
				this._passwordRecord = null;
				this._protectRecord = null;
				this._objectProtectRecord = null;
				this._scenarioProtectRecord = null;
				return;
			}
			global::NPOI.HSSF.Record.ProtectRecord protect = this.Protect;
			global::NPOI.HSSF.Record.PasswordRecord password2 = this.Password;
			protect.Protect = true;
			password2.Password = (int)((short)global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorVerifier1(password));
			if (this._objectProtectRecord == null && shouldProtectObjects)
			{
				global::NPOI.HSSF.Record.ObjectProtectRecord objectProtectRecord = global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock.CreateObjectProtect();
				objectProtectRecord.Protect = true;
				this._objectProtectRecord = objectProtectRecord;
			}
			if (this._scenarioProtectRecord == null && shouldProtectScenarios)
			{
				global::NPOI.HSSF.Record.ScenarioProtectRecord scenarioProtectRecord = global::NPOI.HSSF.Record.Aggregates.WorksheetProtectionBlock.CreateScenarioProtect();
				scenarioProtectRecord.Protect = true;
				this._scenarioProtectRecord = scenarioProtectRecord;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x000890B7 File Offset: 0x000872B7
		public bool IsSheetProtected
		{
			get
			{
				return this._protectRecord != null && this._protectRecord.Protect;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x000890CE File Offset: 0x000872CE
		public bool IsObjectProtected
		{
			get
			{
				return this._objectProtectRecord != null && this._objectProtectRecord.Protect;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002E6C RID: 11884 RVA: 0x000890E5 File Offset: 0x000872E5
		public bool IsScenarioProtected
		{
			get
			{
				return this._scenarioProtectRecord != null && this._scenarioProtectRecord.Protect;
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00047F80 File Offset: 0x00046180
		private static global::NPOI.HSSF.Record.ObjectProtectRecord CreateObjectProtect()
		{
			return new global::NPOI.HSSF.Record.ObjectProtectRecord
			{
				Protect = false
			};
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x00047F8E File Offset: 0x0004618E
		private static global::NPOI.HSSF.Record.ScenarioProtectRecord CreateScenarioProtect()
		{
			return new global::NPOI.HSSF.Record.ScenarioProtectRecord
			{
				Protect = false
			};
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x00047F70 File Offset: 0x00046170
		private static global::NPOI.HSSF.Record.PasswordRecord CreatePassword()
		{
			return new global::NPOI.HSSF.Record.PasswordRecord(0);
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002E70 RID: 11888 RVA: 0x000890FC File Offset: 0x000872FC
		public int PasswordHash
		{
			get
			{
				if (this._passwordRecord == null)
				{
					return 0;
				}
				return this._passwordRecord.Password;
			}
		}

		// Token: 0x04001459 RID: 5209
		private global::NPOI.HSSF.Record.ProtectRecord _protectRecord;

		// Token: 0x0400145A RID: 5210
		private global::NPOI.HSSF.Record.ObjectProtectRecord _objectProtectRecord;

		// Token: 0x0400145B RID: 5211
		private global::NPOI.HSSF.Record.ScenarioProtectRecord _scenarioProtectRecord;

		// Token: 0x0400145C RID: 5212
		private global::NPOI.HSSF.Record.PasswordRecord _passwordRecord;
	}
}
