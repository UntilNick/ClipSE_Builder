namespace ClipPurSEditionBuilder.Sticks
{
    public static class ManifestLoader
    {
        public static void Inizialize()
        {
            if (!FileControl.ExistsDirectory(GlobalPath.ManifestDirectory))
            {
                FileControl.CreateDirectory(GlobalPath.ManifestDirectory);
                if (!FileControl.ExistsFile(GlobalPath.ManifestFile))
                {
                    FileControl.UnpackFromResources(GlobalPath.ManifestFile, Properties.Resources.app);
                }
            }
        }

        public static void Delete()
        {
            if (FileControl.ExistsFileAndDirectory(GlobalPath.ManifestDirectory, GlobalPath.ManifestFile))
            {
                FileControl.FileDelete(GlobalPath.ManifestFile);
                FileControl.DirectoryDelete(GlobalPath.ManifestDirectory);
            }
        }
    }
}