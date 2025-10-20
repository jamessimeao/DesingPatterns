using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1Memento
{
    internal class EditorState
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
}
