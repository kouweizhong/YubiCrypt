﻿using System;

namespace YubiCrypt.ClientLibrary.Models
{
    public class YubiCryptFile
    {
        public string FileName { get; set; }
        public string Size { get; set; }
        public DateTime Modified { get; set; }
        public string InternalName { get; set; }

    }

    //public class MetadataContent
    //{
    //    public int bytes { get; set; }
    //    public bool thumb_exists { get; set; }
    //    public string rev { get; set; }
    //    public DateTime modified { get; set; }
    //    public string path { get; set; }
    //    public bool is_dir { get; set; }
    //    public string icon { get; set; }
    //    public string root { get; set; }
    //    public string mime_type { get; set; }
    //    public string size { get; set; }
    //    public string hash { get; set; }
    //}
}
