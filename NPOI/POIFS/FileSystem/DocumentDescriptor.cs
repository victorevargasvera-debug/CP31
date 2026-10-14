using System;
using System.Text;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002E6 RID: 742
	public class DocumentDescriptor
	{
		// Token: 0x0600153B RID: 5435 RVA: 0x0003FD74 File Offset: 0x0003DF74
		public DocumentDescriptor(global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, string name)
		{
			if (path == null)
			{
				throw new global::System.NullReferenceException("path must not be null");
			}
			if (name == null)
			{
				throw new global::System.NullReferenceException("name must not be null");
			}
			if (name.Length == 0)
			{
				throw new global::System.ArgumentException("name cannot be empty");
			}
			this.path = path;
			this.name = name;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x0003FDC4 File Offset: 0x0003DFC4
		public string Path
		{
			get
			{
				return this.path.ToString();
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x0003FDD1 File Offset: 0x0003DFD1
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0003FDDC File Offset: 0x0003DFDC
		public override bool Equals(object o)
		{
			bool result = false;
			if (o != null && o.GetType() == base.GetType())
			{
				if (this == o)
				{
					result = true;
				}
				else
				{
					global::NPOI.POIFS.FileSystem.DocumentDescriptor documentDescriptor = (global::NPOI.POIFS.FileSystem.DocumentDescriptor)o;
					result = (this.path.Equals(documentDescriptor.path) && this.name.Equals(documentDescriptor.name));
				}
			}
			return result;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0003FE39 File Offset: 0x0003E039
		public override int GetHashCode()
		{
			if (this.hashcode == 0)
			{
				this.hashcode = (this.path.GetHashCode() ^ this.name.GetHashCode());
			}
			return this.hashcode;
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0003FE68 File Offset: 0x0003E068
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(40 * (this.path.Length + 1));
			for (int i = 0; i < this.path.Length; i++)
			{
				stringBuilder.Append(this.path.GetComponent(i)).Append("/");
			}
			stringBuilder.Append(this.name);
			return stringBuilder.ToString();
		}

		// Token: 0x04000896 RID: 2198
		private global::NPOI.POIFS.FileSystem.POIFSDocumentPath path;

		// Token: 0x04000897 RID: 2199
		private string name;

		// Token: 0x04000898 RID: 2200
		private int hashcode;
	}
}
