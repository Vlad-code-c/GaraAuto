using System;
using System.Drawing;
using System.Windows.Forms;

namespace GaraAuto.forms.controlGenerator
{
    public class ControlBuilder : IControlGenerator
    {
        private Control _control;

        public ControlBuilder(Control control)
        {
            Create(control);
        } 
        
        public ControlBuilder Create(Control control)
        {
            _control = control;
            return this;
        }

        public ControlBuilder SetCursor(Cursor cursor)
        {
            _control.Cursor = cursor;
            return this;
        }

        public ControlBuilder setChecked(bool check)
        {
            ((IControl)_control).setChecked(check);
            return this;
        }

        public ControlBuilder SetFont(Font font)
        {
            _control.Font = font;
            return this;
        }

        public ControlBuilder SetAutoSize(bool autoSize)
        {
            _control.AutoSize = autoSize;
            return this;
        }

        public ControlBuilder SetLeft(int left)
        {
            _control.Left = left;
            return this;
        }

        public ControlBuilder SetTop(int top)
        {
            _control.Top = top;
            return this;
        }

        public ControlBuilder SetHeight(int height)
        {
            _control.Height = height;
            return this;
        }

        public ControlBuilder SetWidth(int width)
        {
            _control.Width = width;
            return this;
        }

        public ControlBuilder SetLocation(Point point)
        {
            _control.Location = point;
            return this;
        }

        public ControlBuilder SetText(string text)
        {
            _control.Text = text;
            return this;
        }

        public ControlBuilder SetVisible(bool visible)
        {
            _control.Visible = visible;
            return this;
        }

        public ControlBuilder SetName(string name)
        {
            _control.Name = name;
            return this;
        }

        public ControlBuilder SetBackColor(Color backColor)
        {
            _control.BackColor = backColor;
            return this;
        }

        public ControlBuilder SetForeColor(Color foreColor)
        {
            _control.ForeColor = foreColor;
            return this;
        }

        public ControlBuilder AddTextChangedEvent(EventHandler textChanged)
        {
            _control.TextChanged += textChanged;
            return this;
        }

        public ControlBuilder AddClickEvent(EventHandler click)
        {
            _control.Click += click;
            return this;
        }

        public ControlBuilder AddEnterEvent(EventHandler enter)
        {
            _control.Enter += enter;
            return this;
        }

        public ControlBuilder AddLeaveEvent(EventHandler leave)
        {
            _control.Leave += leave;
            return this;
        }

        public ControlBuilder AddKeyPressEvent(KeyPressEventHandler keyPress)
        {
            _control.KeyPress += keyPress;
            return this;
        }

        public ControlBuilder AddMouseLeaveEvent(EventHandler mouseLeave)
        {
            _control.MouseLeave += mouseLeave;
            return this;
        }

        public Control Build()
        {
            return _control;
        }
    }
}