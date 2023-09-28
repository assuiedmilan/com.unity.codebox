using System;
using CodeBox.Tools.Editor.Enumerations;
using CodeBox.Tools.Editor.Interfaces;
using UnityEngine;

namespace CodeBox.Tools.Editor.Tags {
    public class GameTagsManager<T> where T : IComparable, IFormattable, IConvertible
    {
        IInternalEditorUtility m_InternalEditorUtility;
    
        public GameTagsManager(IInternalEditorUtility internalEditorUtility)
        {
            m_InternalEditorUtility = internalEditorUtility;
            EnumHelper.VerifyTypeIsEnum<T>();
        }
   
        public void CleanTags()
        {
            foreach (var tag in m_InternalEditorUtility.GetAllTags())
            {
                if (!Enum.IsDefined(typeof(UnityTags), tag))
                {
                    m_InternalEditorUtility.RemoveTag(tag);
                }
            }
        }

        public void InitializeTags()
        {
            foreach (var tag in (T[])Enum.GetValues(typeof(T)))
            {
                m_InternalEditorUtility.AddTag(tag.GetEnumAsString());
            }
        }
    }
}