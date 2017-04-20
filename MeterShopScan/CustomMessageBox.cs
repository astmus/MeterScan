using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MeterShopScan
{
	public enum CustomMessageBoxButtons
	{
		Ok,
		OkCancel,
		YesNo
	}

	public partial class CustomMessageBox : Form
	{
		public CustomMessageBox(CustomMessageBoxButtons buttons)
		{
			InitializeComponent();
			switch (buttons)
			{
				case CustomMessageBoxButtons.Ok:
					btnLeft.Text = "Ok";
					btnLeft.DialogResult = DialogResult.OK;
					btnRight.Visible = false;					
					break;
				case CustomMessageBoxButtons.OkCancel:
					btnLeft.Text = "Ok";
					btnLeft.DialogResult = DialogResult.OK;
					btnRight.Text = "Cancel";
					btnRight.DialogResult = DialogResult.Cancel;
					break;
				case CustomMessageBoxButtons.YesNo:
					btnLeft.Text = "Yes";
					btnLeft.DialogResult = DialogResult.Yes;
					btnRight.Text = "No";
					btnRight.DialogResult = DialogResult.No;
					break;
			}
		}

		public static DialogResult Show(string message)
		{
			return Show(message, CustomMessageBoxButtons.Ok);
		}

		public static DialogResult Show(string message, CustomMessageBoxButtons buttons)
		{
			var form = new CustomMessageBox(buttons);			
			form.messageLabel.Text = message;
			return form.ShowDialog();
		}

		public static DialogResult Show(string message, CustomMessageBoxButtons buttons, Bitmap image)
		{
			var form = new CustomMessageBox(buttons);
			if (image != null)
			{
				form.pictureBox.Image = image;
				form.messageLabel.Width = Screen.PrimaryScreen.Bounds.Width - form.pictureBox.Image.Width - 5;
				form.messageLabel.Location = new Point(form.pictureBox.Image.Width+10, 0);
			}

			form.messageLabel.Text = message;
			return form.ShowDialog();
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{

		}

		private void btnRight_Click(object sender, EventArgs e)
		{

		}


	}
}