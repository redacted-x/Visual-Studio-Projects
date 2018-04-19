using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MySqlBackupTestApp.Properties
{
	// Token: 0x0200001A RID: 26
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00012625 File Offset: 0x00010825
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00012730 File Offset: 0x00010930
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("MySqlBackupTestApp.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0001275C File Offset: 0x0001095C
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00012763 File Offset: 0x00010963
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0001276B File Offset: 0x0001096B
		internal static Bitmap bullet_cross
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("bullet_cross", Resources.resourceCulture);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00012786 File Offset: 0x00010986
		internal static Bitmap disk
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("disk", Resources.resourceCulture);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000127A1 File Offset: 0x000109A1
		internal static Bitmap disk_edit
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("disk_edit", Resources.resourceCulture);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000127BC File Offset: 0x000109BC
		internal static Bitmap folder
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("folder", Resources.resourceCulture);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000127D7 File Offset: 0x000109D7
		internal static Bitmap logo128
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("logo128", Resources.resourceCulture);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000127F2 File Offset: 0x000109F2
		internal static Bitmap q2
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("q2", Resources.resourceCulture);
			}
		}

		// Token: 0x04000149 RID: 329
		private static ResourceManager resourceMan;

		// Token: 0x0400014A RID: 330
		private static CultureInfo resourceCulture;
	}
}
