using System;
using System.IO;
using System.Text;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002EE RID: 750
	public class POIFSDocumentPath
	{
		// Token: 0x06001578 RID: 5496 RVA: 0x0004044F File Offset: 0x0003E64F
		public POIFSDocumentPath()
		{
			this.components = new string[0];
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00040464 File Offset: 0x0003E664
		public POIFSDocumentPath(string[] components)
		{
			if (components == null)
			{
				this.components = new string[0];
				return;
			}
			this.components = new string[components.Length];
			for (int i = 0; i < components.Length; i++)
			{
				if (components[i] == null || components[i].Length == 0)
				{
					throw new global::System.ArgumentException("components cannot contain null or empty strings");
				}
				this.components[i] = components[i];
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x000404C8 File Offset: 0x0003E6C8
		public POIFSDocumentPath(global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, string[] components)
		{
			if (components == null)
			{
				this.components = new string[path.components.Length];
			}
			else
			{
				this.components = new string[path.components.Length + components.Length];
			}
			for (int i = 0; i < path.components.Length; i++)
			{
				this.components[i] = path.components[i];
			}
			if (components != null)
			{
				for (int j = 0; j < components.Length; j++)
				{
					if (components[j] == null)
					{
						throw new global::System.ArgumentException("components cannot contain null");
					}
					int length = components[j].Length;
					this.components[j + path.components.Length] = components[j];
				}
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x0004056C File Offset: 0x0003E76C
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
					global::NPOI.POIFS.FileSystem.POIFSDocumentPath poifsdocumentPath = (global::NPOI.POIFS.FileSystem.POIFSDocumentPath)o;
					if (poifsdocumentPath.components.Length == this.components.Length)
					{
						result = true;
						for (int i = 0; i < this.components.Length; i++)
						{
							if (!poifsdocumentPath.components[i].Equals(this.components[i]))
							{
								result = false;
								break;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x000405E3 File Offset: 0x0003E7E3
		public virtual string GetComponent(int n)
		{
			return this.components[n];
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x000405ED File Offset: 0x0003E7ED
		public override int GetHashCode()
		{
			if (this.hashcode == 0)
			{
				this.hashcode = this.ComputeHashCode();
			}
			return this.hashcode;
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0004060C File Offset: 0x0003E80C
		private int ComputeHashCode()
		{
			int num = 0;
			for (int i = 0; i < this.components.Length; i++)
			{
				num += this.components[i].GetHashCode();
			}
			return num;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00040640 File Offset: 0x0003E840
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int length = this.Length;
			stringBuilder.Append(global::System.IO.Path.DirectorySeparatorChar);
			for (int i = 0; i < length; i++)
			{
				stringBuilder.Append(this.GetComponent(i));
				if (i < length - 1)
				{
					stringBuilder.Append(global::System.IO.Path.DirectorySeparatorChar);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x00040698 File Offset: 0x0003E898
		public virtual int Length
		{
			get
			{
				return this.components.Length;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x000406A4 File Offset: 0x0003E8A4
		public virtual global::NPOI.POIFS.FileSystem.POIFSDocumentPath Parent
		{
			get
			{
				int num = this.components.Length - 1;
				if (num < 0)
				{
					return null;
				}
				string[] destinationArray = new string[num];
				global::System.Array.Copy(this.components, 0, destinationArray, 0, num);
				return new global::NPOI.POIFS.FileSystem.POIFSDocumentPath(destinationArray);
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x000406DE File Offset: 0x0003E8DE
		public string Name
		{
			get
			{
				if (this.components.Length == 0)
				{
					return "";
				}
				return this.components[this.components.Length - 1];
			}
		}

		// Token: 0x040008A8 RID: 2216
		private string[] components;

		// Token: 0x040008A9 RID: 2217
		private int hashcode;
	}
}
