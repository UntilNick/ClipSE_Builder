using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace ClipPurSEditionBuilder.Sticks
{
    public static class RunCheck
    {
        public static bool InstanceCheck()
        {
            Assembly assembly = typeof(Program).Assembly;
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            string id = attribute.Value;

            new Mutex(true, id, out bool isNew);
            return isNew;
        }
    }
}