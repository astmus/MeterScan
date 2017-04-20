using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace MeterShopScan.Controls
{
	public partial class AnimatedPicture : UserControl
	{
		public AnimatedPicture()
		{
			InitializeComponent();
			_timer = new Timer();
			_timer.Enabled = false;
			_timer.Interval = 350;
			_timer.Tick += new EventHandler(onTimerTick);
		}

		private void onTimerTick(object sender, EventArgs e)
		{
			if (_currentFrameNum == _images.Count - 1)
				_currentFrameNum = 0;
			else
				_currentFrameNum++;
			this.Refresh();
		}

		private ImageAttributes _drawAttrib;
		private List<Image> _images = new List<Image>();
		private int _currentFrameNum = 0;
		private Timer _timer;

		public bool AnimationEnabled
		{
			get { return _timer.Enabled; }
			set { _timer.Enabled = value; }
		}

		public void AddImageFrame(Image image)
		{
			if (_images.Count == 0)
			{
				Color trns = new Bitmap(image).GetPixel(0, 0);
				_drawAttrib = new ImageAttributes();
				_drawAttrib.SetColorKey(trns, trns);
			}
			_images.Add(image);
		}

		protected override void OnPaint(PaintEventArgs e)
		{			
			//base.OnPaint(e);	
			var frame = _images[_currentFrameNum];
			if (frame != null)
				e.Graphics.DrawImage(frame,
						 new Rectangle(0, 0, Width, Height),
						 0, 0, frame.Width, frame.Height,
						 GraphicsUnit.Pixel,
						 _drawAttrib);
		}
	}
}
