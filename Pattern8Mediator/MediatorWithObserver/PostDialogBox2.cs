using Pattern8Mediator.MediatorWithObserver.UIFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern8Mediator.MediatorWithObserver
{
    internal class PostDialogBox2
    {
        private ListBox2 _postsListBox;
        private TextBox2 _titleTextBox;
        private Button2 _saveButton;

        public PostDialogBox2()
        {
            _postsListBox = new ListBox2();
            _titleTextBox = new TextBox2();
            _saveButton = new Button2();

            _postsListBox.AddEventHandler(PostSelected);
            _titleTextBox.AddEventHandler(TitleChanged);
        }

        private void PostSelected()
        {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }

        private void TitleChanged()
        {
            bool isTitleEmpty = (_titleTextBox.GetText() == "");
            _saveButton.SetEnabled(!isTitleEmpty);
        }

        public void SimulateUserInteraction()
        {
            _postsListBox.SetSelection("Post 2");
            //_titleTextBox.SetText("");
            Console.WriteLine($"Title text box: {_titleTextBox.GetText()}");
            Console.WriteLine($"Button enabled: {_saveButton.IsEnabled()}");
        }
    }
}
