using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1Memento
{
    internal class History
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
            if (_states.Count >= 1)
            {
                EditorState previousState = _states.Pop();
                _editor.RestoreState(previousState);
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("\nHere is the stack of mementos:");
            foreach (EditorState state in _states)
            {
                Console.WriteLine(state);
            }
        }
    }
}
