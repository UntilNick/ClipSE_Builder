using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipPurSEditionBuilder.Sticks
{
    internal class ControlActive
    {
        private static void Active(Label l, bool visible = false)
        {
            try
            {
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    l.Invoke((Action)(() => { l.Visible = visible; }));
                });
            }
            catch { }
        }

        public static void CheckMessage(Label MessageShow, string Text, bool True = true)
        {
            MessageShow.Visible = True;
            Active(MessageShow);
            MessageShow.Text = Text;
        }

        public static void ControlVisible(Panel Panl, UserControl Uc)
        {
            try
            {
               Panl.Controls.Add(Uc);
               Uc.BringToFront();
            }
            catch (Exception) { }
        }

        public static bool ShowAnima(IntPtr hWnd, int time, Enums.AnimateWindowFlags flags) => NativeMethods.AnimateWindow(hWnd, time, flags);

        public static void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;

                if (c.GetType() == typeof(GroupBox))
                    CleanAllTextBoxesIn(c);
            }
        }
    }
}