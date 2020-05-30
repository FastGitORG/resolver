namespace Resolver.Util
{
    public static class Converter
    {
        public static string ConvertToDownload(string org, string repo, string branch)
        {
            // Prev   => https://codeload.github.com/fastgitorg/PSFastGet/zip/master
            // Target => https://github.com/fastgitorg/PSFastGet/archive/master.zip
            return Combine(ConstText.FASTGIT_DOWNLOAD, org, repo, "archive", branch + ".zip");
        }

        private static string Combine(string pre, params string[] suf)
        {
            for (int loop = 0; loop < suf.Length; ++loop)
            {
                pre += "/" + suf[loop];
            }

            return pre;
        }
    }
}