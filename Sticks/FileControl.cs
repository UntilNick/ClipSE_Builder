namespace ClipPurSEditionBuilder.Sticks
{
    using System;
    using System.IO;

    public static class FileControl
    {
        public static bool ExistsFile(string path) => File.Exists(path) ? true : false;
        public static bool ExistsDirectory(string path) => Directory.Exists(path) ? true : false;
        public static bool ExistsFileAndDirectory(string pathdir, string pathfile) => ExistsDirectory(pathdir) && ExistsFile(pathfile) ? true : false;
        public static bool CreateDirectory(string path, FileAttributes attributes = FileAttributes.Hidden)
        {
            try
            {
                var dir = new DirectoryInfo(path);
                dir.Create(); dir.Refresh();
                dir.Attributes = FileAttributes.Directory | attributes;
                return true;
            }
            catch (Exception) { return false; }
        }
        public static bool FileDelete(string path)
        {
            if (ExistsFile(path))
            {
                try
                {
                    File.Delete(path);
                    return true;
                }
                catch { return false; }
            }
            return false;
        }
        public static bool Move(string filepath, string dest)
        {
            try
            {
                File.Move(filepath, dest);
                return true;
            }
            catch (Exception) { return false; }

        }
        public static bool CopyFile(string source, string destfile, bool overwrite)
        {
            if (!ExistsFile(destfile))
            {
                try
                {
                    File.Copy(source, destfile, overwrite);
                    return true;
                }
                catch (Exception) { return false; }
            }
            return false;
        }
        public static bool CreateFile(string path, string content)
        {
            try
            {
                File.WriteAllText(path, content); return true;
            }
            catch (Exception) { return false; }
        }
        public static bool DirectoryDelete(string pathdir)
        {
            if (ExistsDirectory(pathdir))
            {
                try
                {
                    Directory.Delete(pathdir, true); return true;
                }
                catch (Exception) { return false; }
            }
            return false;
        }
        public static string CombinePath(params string[] paths)
        {
            try
            {
                return paths?.Length > 0 ? Path.Combine(paths) : string.Empty;
            }
            catch { return string.Empty; }
        }
        public static bool UnpackFromResources(string pathdir, byte[] bytes)
        {
            try
            {
                File.WriteAllBytes(pathdir, bytes);
                return true;
            }
            catch { return false; }
        }
        public static bool HideFile(string path, FileAttributes attributes)
        {
            try
            {
                if (ExistsFile(path))
                {
                    File.SetAttributes(path, attributes);
                    return true;
                }
                return false;
            }
            catch (Exception) { return false; }
        }
    }
}