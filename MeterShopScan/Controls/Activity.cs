using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing.Imaging;

namespace MeterShopScan.Controls
{
	public partial class Activity : UserControl
	{
		private static Form currentForm;
		public Activity()
		{
			InitializeComponent();
		}

		public static void Show(string message)
		{
			if (currentForm != null)
				Hide();
			Activity control = new Activity();
			control.messageLabel.Text = message;
			currentForm = new Form();
			Rectangle rect = Screen.PrimaryScreen.Bounds;//new Rectangle(0,0,parent.Width,parent.Height);
			rect.Inflate(-30, -60);
			currentForm.FormBorderStyle = FormBorderStyle.None;
			currentForm.Size = control.Size = rect.Size;			
			currentForm.Location = rect.Location;
			currentForm.BackColor = control.BackColor = Settings.Instance.BackColor;
			control.ForeColor = Settings.Instance.ActiveColor;
			
			string sourceFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), "Source");
			string path = Path.Combine(sourceFolder, "activity.png");									
			control.animatedPicture1.AddImageFrame(new Bitmap(path));
			path = Path.Combine(sourceFolder, "activity2.png");
			control.animatedPicture1.AddImageFrame(new Bitmap(path));
			path = Path.Combine(sourceFolder, "activity3.png");
			control.animatedPicture1.AddImageFrame(new Bitmap(path));
			path = Path.Combine(sourceFolder, "activity4.png");
			control.animatedPicture1.AddImageFrame(new Bitmap(path));
			control.animatedPicture1.AnimationEnabled = true;
			currentForm.Controls.Add(control);			
			currentForm.Show();
		}

		public static new void Hide()
		{
			currentForm.Close();
			currentForm.Dispose();
			currentForm = null;
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			animatedPicture1.Location = new Point((int)((this.Width * 0.5) - (animatedPicture1.Width * 0.5)), animatedPicture1.Location.Y);
		}
	}
}
