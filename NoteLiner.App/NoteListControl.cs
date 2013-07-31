﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoteLiner.App
{
    public partial class NoteListControl : UserControl
    {

        internal List<Note> NoteList { get; private set; }

        public NoteListControl()
        {
            InitializeComponent();
            this.NoteList = new List<Note>();
        }

        //
        // TODO: Events
        //

        // SelectedNoteChanged(Note note)

        public void UpdateSelectedNote(string contents)
        {
            // NOTE: Update DateTime as well...
            // NOTE: Mark as Dirty...
        }

        private void lstMenuDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete");
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            // TODO: filter the list

            // TODO: change list selection if no longer valid

            // TODO: fire selected changed event if needed
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TODO: check for ENTER key and create new entry. fire event 
            // so that main form can set focus to text entry field.
        }

    }
}
