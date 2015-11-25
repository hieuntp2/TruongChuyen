using System.Windows.Forms;

namespace NCKH3.Class
{
    /* Helper class to hold state and return value in order to call FileDialog.ShowDialog on a background thread.
  * Usage:
  *   DialogState state = new DialogState();
  *   state.dialog = // <any class that derives from FileDialog>
  *   System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowDialog);
  *   t.SetApartmentState(System.Threading.ApartmentState.STA);
  *   t.Start();
  *   t.Join();
  *   return state.result;
  */
    public class DialogState
    {
        public DialogResult result;
        public FileDialog dialog;


        public void ThreadProcShowDialog()
        {
            result = dialog.ShowDialog();
        }
    }
}
