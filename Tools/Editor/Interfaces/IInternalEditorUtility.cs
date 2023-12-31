﻿using System;
using System.Collections.Generic;

namespace CodeBox.Tools.Editor.Interfaces
{
    public interface IInternalEditorUtility
    {
        void AddTag(string tag) => UnityEditorInternal.InternalEditorUtility.AddTag(tag);
        void RemoveTag(string tag) => UnityEditorInternal.InternalEditorUtility.RemoveTag(tag);
        IEnumerable<string> GetAllTags()
        {
            return UnityEditorInternal.InternalEditorUtility.tags;
        }
    }
}
