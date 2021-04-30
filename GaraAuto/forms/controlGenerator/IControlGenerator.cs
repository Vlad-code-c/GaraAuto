using System;
using System.Drawing;
using System.Windows.Forms;

namespace GaraAuto.forms.controlGenerator
{
    public interface IControlGenerator
    {
        public ControlBuilder Create(Control control);
        public ControlBuilder SetCursor(Cursor cursor);
        public ControlBuilder setChecked(bool check);
        public ControlBuilder SetFont(Font font);
        public ControlBuilder SetAutoSize(bool autoSize);
        public ControlBuilder SetLeft(int left);
        public ControlBuilder SetTop(int top);
        public ControlBuilder SetHeight(int height);
        public ControlBuilder SetWidth(int width);
        public ControlBuilder SetLocation(Point point);
        public ControlBuilder SetText(string text);
        public ControlBuilder SetVisible(bool visible);
        public ControlBuilder SetName(string name);
        public ControlBuilder SetBackColor(Color backColor);
        public ControlBuilder SetForeColor(Color foreColor);
        public ControlBuilder AddTextChangedEvent(EventHandler textChanged);
        public ControlBuilder AddClickEvent(EventHandler click);
        public ControlBuilder AddEnterEvent(EventHandler enter);
        public ControlBuilder AddLeaveEvent(EventHandler leave);
        public ControlBuilder AddKeyPressEvent(KeyPressEventHandler keyPress);
        public ControlBuilder AddMouseLeaveEvent(EventHandler mouseLeave);
        public Control Build();
    }
}
