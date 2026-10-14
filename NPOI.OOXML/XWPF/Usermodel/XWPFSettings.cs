using System;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200004C RID: 76
	public class XWPFSettings : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000325 RID: 805 RVA: 0x0000A97A File Offset: 0x00008B7A
		public XWPFSettings(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000CB99 File Offset: 0x0000AD99
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public XWPFSettings(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000CBA2 File Offset: 0x0000ADA2
		public XWPFSettings()
		{
			this.ctSettings = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Settings();
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000CBB5 File Offset: 0x0000ADB5
		internal override void OnDocumentRead()
		{
			base.OnDocumentRead();
			this.ReadFrom(base.GetPackagePart().GetInputStream());
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		public long GetZoomPercent()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Zoom ct_Zoom = this.ctSettings.zoom;
			if (!this.ctSettings.IsSetZoom())
			{
				ct_Zoom = this.ctSettings.AddNewZoom();
			}
			else
			{
				ct_Zoom = this.ctSettings.zoom;
			}
			return long.Parse(ct_Zoom.percent);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000CC1B File Offset: 0x0000AE1B
		public void SetZoomPercent(long zoomPercent)
		{
			if (!this.ctSettings.IsSetZoom())
			{
				this.ctSettings.AddNewZoom();
			}
			this.ctSettings.zoom.percent = zoomPercent.ToString();
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000CC50 File Offset: 0x0000AE50
		public bool IsEnforcedWith()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect documentProtection = this.ctSettings.documentProtection;
			return documentProtection != null && documentProtection.enforcement.Equals(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.on);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000CC88 File Offset: 0x0000AE88
		public bool IsEnforcedWith(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect editValue)
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect documentProtection = this.ctSettings.documentProtection;
			return documentProtection != null && documentProtection.enforcement.Equals(global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.on) && documentProtection.edit.Equals(editValue);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000CCDE File Offset: 0x0000AEDE
		public void SetEnforcementEditValue(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocProtect editValue)
		{
			this.SafeGetDocumentProtection().enforcement = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.on;
			this.SafeGetDocumentProtection().edit = editValue;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000CCF8 File Offset: 0x0000AEF8
		public void RemoveEnforcement()
		{
			this.SafeGetDocumentProtection().enforcement = global::NPOI.OpenXmlFormats.Wordprocessing.ST_OnOff.off;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000CD08 File Offset: 0x0000AF08
		public void SetUpdateFields()
		{
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			ct_OnOff.val = true;
			this.ctSettings.updateFields = ct_OnOff;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000CD2E File Offset: 0x0000AF2E
		public bool IsUpdateFields()
		{
			return this.ctSettings.IsSetUpdateFields() && this.ctSettings.updateFields.val;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000CD4F File Offset: 0x0000AF4F
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0000CD5C File Offset: 0x0000AF5C
		public bool IsTrackRevisions
		{
			get
			{
				return this.ctSettings.IsSetTrackRevisions();
			}
			set
			{
				if (value)
				{
					if (!this.ctSettings.IsSetTrackRevisions())
					{
						this.ctSettings.AddNewTrackRevisions();
						return;
					}
				}
				else if (this.ctSettings.IsSetTrackRevisions())
				{
					this.ctSettings.UnsetTrackRevisions();
				}
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000CD94 File Offset: 0x0000AF94
		protected internal override void Commit()
		{
			if (this.ctSettings == null)
			{
				throw new global::System.InvalidOperationException("Unable to write out settings that were never read in!");
			}
			using (global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream())
			{
				new global::NPOI.OpenXmlFormats.Wordprocessing.SettingsDocument(this.ctSettings).Save(outputStream);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000CDF0 File Offset: 0x0000AFF0
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect SafeGetDocumentProtection()
		{
			if (this.ctSettings.documentProtection == null)
			{
				global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect documentProtection = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocProtect();
				this.ctSettings.documentProtection = documentProtection;
			}
			return this.ctSettings.documentProtection;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000CE2C File Offset: 0x0000B02C
		private void ReadFrom(global::System.IO.Stream inputStream)
		{
			try
			{
				global::System.Xml.XmlDocument doc = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(inputStream);
				this.ctSettings = global::NPOI.OpenXmlFormats.Wordprocessing.SettingsDocument.Parse(doc, global::NPOI.POIXMLDocumentPart.NamespaceManager).Settings;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.Exception("SettingsDocument parse failed", innerException);
			}
		}

		// Token: 0x04000221 RID: 545
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Settings ctSettings;
	}
}
