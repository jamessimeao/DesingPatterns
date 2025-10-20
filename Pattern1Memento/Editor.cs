using Pattern1Memento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1Memento
{
    internal class Editor
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";

        public EditorState CreateState()
        {
            return new EditorState(Title, Content);
        }

        public void RestoreState(EditorState state)
        {
            Title = state.Title;
            Content = state.Content;
        }
    }
}
