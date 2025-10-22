using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Pattern8Mediator
{
    internal class PostDialogBox : DialogBox
    {
        private ListBox _postsListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public PostDialogBox()
        {
            _postsListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
        }

        public void SimulateUserInteraction()
        {
            _postsListBox.SetSelection("Post 2");
            _titleTextBox.SetText("");
            Console.WriteLine($"Title text box: {_titleTextBox.GetText()}");
            Console.WriteLine($"Button enabled: {_saveButton.IsEnabled()}");
        }


        public override void Changed(UIControl uIControl)
        {
            if (uIControl == _postsListBox)
            {
                HandlePostChanged();
            }
            else if (uIControl == _titleTextBox)
            {
                HandleTitleChanged();
            }
        }

        private void HandlePostChanged()
        {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }

        private void HandleTitleChanged()
        {
            bool isTitleEmpty = (_titleTextBox.GetText() == "");
            _saveButton.SetEnabled(!isTitleEmpty);
        }
    }
}
