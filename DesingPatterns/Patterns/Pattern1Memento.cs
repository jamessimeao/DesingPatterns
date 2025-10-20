using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.Patterns
{
    public class Editor
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

    public class EditorState
    {
        private readonly string _title;
        private readonly string _content;

        // State metadata
        private readonly DateTime _stateCreatedAt;

        public EditorState(string title, string context)
        {
            _title = title;
            _content = context;
            _stateCreatedAt = DateTime.Now;
        }

        public string Title { get { return _title; } }
        public string Content { get { return _content; } }

        public DateTime StateCreatedAt { get { return _stateCreatedAt; } }

        public override string ToString()
        {
            return $"{_title} / {_content}";
        }
    }

    public class History
    {
        private Stack<EditorState> _states = new Stack<EditorState>();
        private Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            _states.Push(_editor.CreateState());
        }

        public void Undo()
        {
            if(_states.Count >= 1)
            {
                EditorState previousState = _states.Pop();
                _editor.RestoreState(previousState);
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("\nHere is the list of mementos:");
            foreach(EditorState state in _states)
            {
                Console.WriteLine(state);
            }
        }
    }
}
