using System;
using System.Drawing;
using System.Windows.Forms;

namespace GaraAuto.forms.controlGenerator
{
    public interface IControl
    {
        public void SetCursor(Cursor cursor);
        public void setChecked(bool check);
        public void SetFont(Font font);
        public void SetAutoSize(bool autoSize);
        public void SetLeft(int left);
        public void SetTop(int top);
        public void SetHeight(int height);
        public void SetWidth(int width);
        public void SetLocation(Point point);
        public void SetText(string text);
        public void SetVisible(bool visible);
        public void SetName(string name);
        public void SetBackColor(Color backColor);
        public void SetForeColor(Color foreColor);
        public void AddTextChangedEvent(EventHandler textChanged);
        public void AddClickEvent(EventHandler click);
        public void AddEnterEvent(EventHandler enter);
        public void AddLeaveEvent(EventHandler leave);
        public void AddKeyPressEvent(KeyPressEventHandler keyPress);
        public void AddMouseLeaveEvent(EventHandler mouseLeave);
    }
}