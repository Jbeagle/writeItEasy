﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteMeEasy_WindowsFormsApplication
{
    public class ReferencesConfig
    {
        public bool includeTitle;
        public string title;
        public string titleAlign;
        public bool boldTitle;
        public string titleFont;
        public int titleSize;
        public string titleColor;
        public bool hangingIndent;
        public int tabsHangingIndent;
        public bool emptyLineBetweenReferences;
        public string orderBy;
        public List<Reference> references;
        public ReferencesConfig()
        {
            includeTitle = true;
            title = "";
            titleAlign = "";
            boldTitle = true;
            titleFont = "";
            titleSize = 0;
            titleColor = "";
            hangingIndent = true;
            tabsHangingIndent = 0;
            emptyLineBetweenReferences = true;
            orderBy = "";
            references = new List<Reference>();
        }
    }
}
