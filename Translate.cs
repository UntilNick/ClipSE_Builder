using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using ClipPurSEditionBuilder.Sticks;

namespace ClipPurSEditionBuilder
{
    public static class Translate
    {
        public static void Inizialize(string lang)
        {
            foreach (Form frm in Application.OpenForms)
            {
                LocalizeForm(frm, lang);
            }
        }

        private static void LocalizeForm(Form frm, string lang)
        {
            try
            {
                var manager = new ComponentResourceManager(frm.GetType());
                var culture = CultureInfo.CreateSpecificCulture(lang);
                Thread.CurrentThread.CurrentCulture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;
                manager.ApplyResources(frm, "$this");
                ApplyResources(manager, frm.Controls);
            }
            catch (Exception ex)
            {
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                {
                    FileControl.CreateFile("Translate_Error.txt", $"Error Translate: {ex.Message}\r\n");
                }
                else
                {
                    FileControl.CreateFile("Translate_Error.txt", $"Ошибка перевода: {ex.Message}\r\n");
                }
            }
        }

        private static void ApplyResources(ComponentResourceManager manager, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                try
                {
                    manager.ApplyResources(ctl, ctl.Name);
                    ApplyResources(manager, ctl.Controls);
                }
                catch { }
            }
        }
    }
}