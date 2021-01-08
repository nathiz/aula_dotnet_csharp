namespace DigitalInnovation.Interfaces
{
    public interface inter
    {
        interface IControl
        {
            void Paint();
        }         
        interface IListBox
        {
            void SetText(string text);
        }
        interface IComboBox: IControl, IListBox {}

        /*interface IDataBound
        {
            void Bind(Binder b);
        }

        public class EditBox: IComboBox, IDataBound
        {
            public void Paint() {}
            public void SetText(string text) {}
            public void Bind(Binder b) {}
        }*/
    }
}