using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment
{
    public partial class HintTextBox : TextBox
    {
        // source: https://stackoverflow.com/questions/2487104/how-do-i-implement-a-textbox-that-displays-type-here
        private Font oldFont = null;
        private Boolean waterMarkTextEnabled = false;

        #region Attributes 
            private Color _waterMarkColor = Color.Gray;
            public Color WaterMarkColor
            {
                get { return _waterMarkColor; }
                set { _waterMarkColor = value; Invalidate(); }
            }

            private string _waterMarkText = "Water Mark";
            public string WaterMarkText
            {
                get { return _waterMarkText; }
                set { _waterMarkText = value; Invalidate(); }
            }
        #endregion

        public HintTextBox()
        {
            JoinEvents(true);
        }

        protected override void OnCreateControl() 
        { 
            base.OnCreateControl();
            WaterMark_Toggel(null, null); 
        }

        protected override void OnPaint(PaintEventArgs args)
        {
            System.Drawing.Font drawFont = new System.Drawing.Font(Font.FontFamily,
                Font.Size, Font.Style, Font.Unit);
            SolidBrush drawBrush = new SolidBrush(WaterMarkColor);
            args.Graphics.DrawString((waterMarkTextEnabled ? WaterMarkText : Text),
                drawFont, drawBrush, new PointF(0.0F, 0.0F));
            base.OnPaint(args);
        }

        private void JoinEvents(Boolean join)
        {
            if (join)
            {
                this.TextChanged += new System.EventHandler(this.WaterMark_Toggel);
                this.LostFocus += new System.EventHandler(this.WaterMark_Toggel);
                this.FontChanged += new System.EventHandler(this.WaterMark_FontChanged);
            }
        }

        private void WaterMark_Toggel(object sender, EventArgs args )
        {
            if (this.Text.Length <= 0)
                EnableWaterMark();
            else
                DisbaleWaterMark();
        }

        private void EnableWaterMark()
        {
            oldFont = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style,
               Font.Unit);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.waterMarkTextEnabled = true;
            Refresh();
        }

        private void DisbaleWaterMark()
        {
            this.waterMarkTextEnabled = false;
            this.SetStyle(ControlStyles.UserPaint, false);
            if(oldFont != null)
                this.Font = new System.Drawing.Font(oldFont.FontFamily, oldFont.Size,
                    oldFont.Style, oldFont.Unit);
        }

        private void WaterMark_FontChanged(object sender, EventArgs args)
        {
            if (waterMarkTextEnabled)
            {
                oldFont = new System.Drawing.Font(Font.FontFamily,Font.Size,Font.Style,
                    Font.Unit);
                Refresh();
            }
        }
    }
}
