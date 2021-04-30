using System;
using System.Drawing;
using System.Windows.Forms;

namespace GaraAuto.forms.controlGenerator.controls
{
    public class CheckboxControl : CheckBox, IControl
    {
        public void SetCursor(Cursor cursor)
        {
            this.Cursor = cursor;
        }

        public void setChecked(bool check)
        {
            this.Checked = check;
        }
        public void SetFont(Font font)
        {
            this.Font = font;
        }

        public void SetAutoSize(bool autoSize)
        {
            this.AutoSize = autoSize;
        }

        public void SetLeft(int left)
        {
            this.Left = left;
        }

        public void SetTop(int top)
        {
            this.Top = top;
        }

        public void SetHeight(int height)
        {
            this.Height = height;
        }

        public void SetWidth(int width)
        {
            this.Width = width;
        }

        public void SetLocation(Point point)
        {
            this.Location = point;
        }

        public void SetText(string text)
        {
            this.Text = text;
        }

        public void SetVisible(bool visible)
        {
            this.Visible = visible;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetBackColor(Color backColor)
        {
            this.BackColor = backColor;
        }

        public void SetForeColor(Color foreColor)
        {
            this.ForeColor = foreColor;
        }

        public void AddTextChangedEvent(EventHandler textChanged)
        {
            this.TextChanged += textChanged;
        }

        public void AddClickEvent(EventHandler click)
        {
            this.Click += click;
        }

        public void AddEnterEvent(EventHandler enter)
        {
            this.Enter += enter;
        }

        public void AddLeaveEvent(EventHandler leave)
        {
            this.Leave += leave;
        }

        public void AddKeyPressEvent(KeyPressEventHandler keyPress)
        {
            this.KeyPress += keyPress;
        }

        public void AddMouseLeaveEvent(EventHandler mouseLeave)
        {
            this.MouseLeave += mouseLeave;
        }
    }
}