using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_izmereniy
{
    public partial class Component1 : Component
    {
        public Component1()
        {
            InitializeComponent();
        }

        public Component1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        class MyLine : System.Windows.Forms.Control
        {
            protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
            {
                System.Drawing.Pen pen = new System.Drawing.Pen(this.ForeColor, this.Width);
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width, this.Height);
                base.OnPaint(e);
            }
        }
    }
}
