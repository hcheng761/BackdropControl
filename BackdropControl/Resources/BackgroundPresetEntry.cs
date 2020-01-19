﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackdropControl.Resources
{
    public class BackgroundPresetEntry
    {
        public BackgroundPresetEntry()
        {
            _DirectoryPath = string.Empty;
            TimeOfChange = TimeSpan.MinValue;
        }
        public BackgroundPresetEntry (string path, TimeSpan dt)
        {
            _DirectoryPath = path;
            TimeOfChange = dt;
            _PictureFileName = Path.GetFileName(path);
        }

        private string _PictureFileName;
        public string PictureFileName
        {
            get { return _PictureFileName; }
            set { _PictureFileName = value; }
        }

        private string _DirectoryPath;
        public string DirectoryPath 
        { 
            get { return _DirectoryPath; }
            set { 
                _DirectoryPath = value;
                _PictureFileName = Path.GetFileName(value);
            }
        }

        private TimeSpan _TimeOfChange;
        public TimeSpan TimeOfChange
        {
            get { return _TimeOfChange; }
            set { _TimeOfChange = value; }
        }

        public string GetPresetEntryFileName()
        {
            return Path.GetFileNameWithoutExtension(_DirectoryPath);
        }

        public bool BackgroundExists()
        {
            return (System.IO.Directory.Exists(_DirectoryPath));
        }
    }
}
