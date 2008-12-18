﻿using System;
using System.Windows.Forms;
using Cecil.Decompiler.Gui.Actions;
using Cecil.Decompiler.Gui.Services;

namespace Cecil.Decompiler.Gui.Controls
{
    internal partial class StackedWindowControl : UserControl, IWindow
    {
        public WindowIdentifiers Identifier
        {
            get; set;
        }

        public string Caption
        {
            get { return label.Text; }
        }

        public Control Content
        {
            get
            {
                return contentPanel.Controls[0];
            }
        }

        public StackedWindowControl()
        {
            InitializeComponent();
        }

        public StackedWindowControl(Control content, string caption)
        {
            InitializeComponent();

            label.Text = caption;
            contentPanel.Controls.Add(content);
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
