namespace MDLib_TestLauncher
{
    partial class TestLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components=null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing&&(components!=null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestLauncher));
            this.groupBoxLaunchIPSCreator = new System.Windows.Forms.GroupBox();
            this.buttonLaunchIPSCreator = new System.Windows.Forms.Button();
            this.buttonIPSFilePathBrowse = new System.Windows.Forms.Button();
            this.textBoxIPSFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxLaunchPaletteEditor = new System.Windows.Forms.GroupBox();
            this.buttonLaunchPaletteEditor = new System.Windows.Forms.Button();
            this.textBoxPaletteAddress = new System.Windows.Forms.TextBox();
            this.labelPaletteAddress = new System.Windows.Forms.Label();
            this.buttonPaletteEditorRomPathBrowse = new System.Windows.Forms.Button();
            this.textBoxPaletteEditorRomPath = new System.Windows.Forms.TextBox();
            this.labelPaletteEditorRomPath = new System.Windows.Forms.Label();
            this.groupBoxLaunchTileEditor = new System.Windows.Forms.GroupBox();
            this.buttonLaunchTileEditor = new System.Windows.Forms.Button();
            this.textBoxTileEditorStartAddress = new System.Windows.Forms.TextBox();
            this.labelTileEditorStartAddress = new System.Windows.Forms.Label();
            this.buttonTileEditorRomPathBrowse = new System.Windows.Forms.Button();
            this.textBoxTileEditorRomPath = new System.Windows.Forms.TextBox();
            this.labelTileEditorRomPath = new System.Windows.Forms.Label();
            this.textBoxTileEditorEndAddress = new System.Windows.Forms.TextBox();
            this.labelTileEditorEndAddres = new System.Windows.Forms.Label();
            this.textBoxTileEditorRows = new System.Windows.Forms.TextBox();
            this.labelTileEditorRows = new System.Windows.Forms.Label();
            this.textBoxTileEditorColumns = new System.Windows.Forms.TextBox();
            this.labelTileEditorColumns = new System.Windows.Forms.Label();
            this.groupBoxLaunchIPSCreator.SuspendLayout();
            this.groupBoxLaunchPaletteEditor.SuspendLayout();
            this.groupBoxLaunchTileEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLaunchIPSCreator
            // 
            this.groupBoxLaunchIPSCreator.Controls.Add(this.buttonLaunchIPSCreator);
            this.groupBoxLaunchIPSCreator.Controls.Add(this.buttonIPSFilePathBrowse);
            this.groupBoxLaunchIPSCreator.Controls.Add(this.textBoxIPSFilePath);
            this.groupBoxLaunchIPSCreator.Controls.Add(this.label1);
            this.groupBoxLaunchIPSCreator.Location = new System.Drawing.Point(13, 23);
            this.groupBoxLaunchIPSCreator.Name = "groupBoxLaunchIPSCreator";
            this.groupBoxLaunchIPSCreator.Size = new System.Drawing.Size(532, 130);
            this.groupBoxLaunchIPSCreator.TabIndex = 0;
            this.groupBoxLaunchIPSCreator.TabStop = false;
            this.groupBoxLaunchIPSCreator.Text = "IPS Creator";
            // 
            // buttonLaunchIPSCreator
            // 
            this.buttonLaunchIPSCreator.Location = new System.Drawing.Point(21, 67);
            this.buttonLaunchIPSCreator.Name = "buttonLaunchIPSCreator";
            this.buttonLaunchIPSCreator.Size = new System.Drawing.Size(152, 45);
            this.buttonLaunchIPSCreator.TabIndex = 3;
            this.buttonLaunchIPSCreator.Text = "Launch IPS Creator";
            this.buttonLaunchIPSCreator.UseVisualStyleBackColor = true;
            this.buttonLaunchIPSCreator.Click += new System.EventHandler(this.buttonLaunchIPSCreator_Click);
            // 
            // buttonIPSFilePathBrowse
            // 
            this.buttonIPSFilePathBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIPSFilePathBrowse.Image = ((System.Drawing.Image)(resources.GetObject("buttonIPSFilePathBrowse.Image")));
            this.buttonIPSFilePathBrowse.Location = new System.Drawing.Point(491, 28);
            this.buttonIPSFilePathBrowse.Name = "buttonIPSFilePathBrowse";
            this.buttonIPSFilePathBrowse.Size = new System.Drawing.Size(22, 22);
            this.buttonIPSFilePathBrowse.TabIndex = 2;
            this.buttonIPSFilePathBrowse.UseVisualStyleBackColor = true;
            this.buttonIPSFilePathBrowse.Click += new System.EventHandler(this.buttonIPSFilePathBrowse_Click);
            // 
            // textBoxIPSFilePath
            // 
            this.textBoxIPSFilePath.Location = new System.Drawing.Point(146, 30);
            this.textBoxIPSFilePath.Name = "textBoxIPSFilePath";
            this.textBoxIPSFilePath.Size = new System.Drawing.Size(339, 22);
            this.textBoxIPSFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modified File Path:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBoxLaunchPaletteEditor
            // 
            this.groupBoxLaunchPaletteEditor.Controls.Add(this.buttonLaunchPaletteEditor);
            this.groupBoxLaunchPaletteEditor.Controls.Add(this.textBoxPaletteAddress);
            this.groupBoxLaunchPaletteEditor.Controls.Add(this.labelPaletteAddress);
            this.groupBoxLaunchPaletteEditor.Controls.Add(this.buttonPaletteEditorRomPathBrowse);
            this.groupBoxLaunchPaletteEditor.Controls.Add(this.textBoxPaletteEditorRomPath);
            this.groupBoxLaunchPaletteEditor.Controls.Add(this.labelPaletteEditorRomPath);
            this.groupBoxLaunchPaletteEditor.Location = new System.Drawing.Point(13, 173);
            this.groupBoxLaunchPaletteEditor.Name = "groupBoxLaunchPaletteEditor";
            this.groupBoxLaunchPaletteEditor.Size = new System.Drawing.Size(532, 149);
            this.groupBoxLaunchPaletteEditor.TabIndex = 1;
            this.groupBoxLaunchPaletteEditor.TabStop = false;
            this.groupBoxLaunchPaletteEditor.Text = "Palette Editor";
            // 
            // buttonLaunchPaletteEditor
            // 
            this.buttonLaunchPaletteEditor.Location = new System.Drawing.Point(21, 91);
            this.buttonLaunchPaletteEditor.Name = "buttonLaunchPaletteEditor";
            this.buttonLaunchPaletteEditor.Size = new System.Drawing.Size(152, 45);
            this.buttonLaunchPaletteEditor.TabIndex = 8;
            this.buttonLaunchPaletteEditor.Text = "Launch Palette Editor";
            this.buttonLaunchPaletteEditor.UseVisualStyleBackColor = true;
            this.buttonLaunchPaletteEditor.Click += new System.EventHandler(this.buttonLaunchPaletteEditor_Click);
            // 
            // textBoxPaletteAddress
            // 
            this.textBoxPaletteAddress.Location = new System.Drawing.Point(134, 58);
            this.textBoxPaletteAddress.Name = "textBoxPaletteAddress";
            this.textBoxPaletteAddress.Size = new System.Drawing.Size(351, 22);
            this.textBoxPaletteAddress.TabIndex = 7;
            // 
            // labelPaletteAddress
            // 
            this.labelPaletteAddress.AutoSize = true;
            this.labelPaletteAddress.Location = new System.Drawing.Point(16, 61);
            this.labelPaletteAddress.Name = "labelPaletteAddress";
            this.labelPaletteAddress.Size = new System.Drawing.Size(112, 17);
            this.labelPaletteAddress.TabIndex = 6;
            this.labelPaletteAddress.Text = "Palette Address:";
            this.labelPaletteAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPaletteEditorRomPathBrowse
            // 
            this.buttonPaletteEditorRomPathBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaletteEditorRomPathBrowse.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaletteEditorRomPathBrowse.Image")));
            this.buttonPaletteEditorRomPathBrowse.Location = new System.Drawing.Point(491, 28);
            this.buttonPaletteEditorRomPathBrowse.Name = "buttonPaletteEditorRomPathBrowse";
            this.buttonPaletteEditorRomPathBrowse.Size = new System.Drawing.Size(22, 22);
            this.buttonPaletteEditorRomPathBrowse.TabIndex = 5;
            this.buttonPaletteEditorRomPathBrowse.UseVisualStyleBackColor = true;
            this.buttonPaletteEditorRomPathBrowse.Click += new System.EventHandler(this.buttonPaletteEditorRomPathBrowse_Click);
            // 
            // textBoxPaletteEditorRomPath
            // 
            this.textBoxPaletteEditorRomPath.Location = new System.Drawing.Point(134, 30);
            this.textBoxPaletteEditorRomPath.Name = "textBoxPaletteEditorRomPath";
            this.textBoxPaletteEditorRomPath.Size = new System.Drawing.Size(351, 22);
            this.textBoxPaletteEditorRomPath.TabIndex = 4;
            // 
            // labelPaletteEditorRomPath
            // 
            this.labelPaletteEditorRomPath.AutoSize = true;
            this.labelPaletteEditorRomPath.Location = new System.Drawing.Point(51, 33);
            this.labelPaletteEditorRomPath.Name = "labelPaletteEditorRomPath";
            this.labelPaletteEditorRomPath.Size = new System.Drawing.Size(77, 17);
            this.labelPaletteEditorRomPath.TabIndex = 3;
            this.labelPaletteEditorRomPath.Text = "ROM Path:";
            this.labelPaletteEditorRomPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxLaunchTileEditor
            // 
            this.groupBoxLaunchTileEditor.Controls.Add(this.textBoxTileEditorRows);
            this.groupBoxLaunchTileEditor.Controls.Add(this.labelTileEditorRows);
            this.groupBoxLaunchTileEditor.Controls.Add(this.textBoxTileEditorColumns);
            this.groupBoxLaunchTileEditor.Controls.Add(this.labelTileEditorColumns);
            this.groupBoxLaunchTileEditor.Controls.Add(this.textBoxTileEditorEndAddress);
            this.groupBoxLaunchTileEditor.Controls.Add(this.labelTileEditorEndAddres);
            this.groupBoxLaunchTileEditor.Controls.Add(this.buttonLaunchTileEditor);
            this.groupBoxLaunchTileEditor.Controls.Add(this.textBoxTileEditorStartAddress);
            this.groupBoxLaunchTileEditor.Controls.Add(this.labelTileEditorStartAddress);
            this.groupBoxLaunchTileEditor.Controls.Add(this.buttonTileEditorRomPathBrowse);
            this.groupBoxLaunchTileEditor.Controls.Add(this.textBoxTileEditorRomPath);
            this.groupBoxLaunchTileEditor.Controls.Add(this.labelTileEditorRomPath);
            this.groupBoxLaunchTileEditor.Location = new System.Drawing.Point(13, 342);
            this.groupBoxLaunchTileEditor.Name = "groupBoxLaunchTileEditor";
            this.groupBoxLaunchTileEditor.Size = new System.Drawing.Size(532, 169);
            this.groupBoxLaunchTileEditor.TabIndex = 9;
            this.groupBoxLaunchTileEditor.TabStop = false;
            this.groupBoxLaunchTileEditor.Text = "Tile Editor";
            // 
            // buttonLaunchTileEditor
            // 
            this.buttonLaunchTileEditor.Location = new System.Drawing.Point(19, 114);
            this.buttonLaunchTileEditor.Name = "buttonLaunchTileEditor";
            this.buttonLaunchTileEditor.Size = new System.Drawing.Size(152, 45);
            this.buttonLaunchTileEditor.TabIndex = 11;
            this.buttonLaunchTileEditor.Text = "Launch Tile Editor";
            this.buttonLaunchTileEditor.UseVisualStyleBackColor = true;
            this.buttonLaunchTileEditor.Click += new System.EventHandler(this.buttonLaunchTileEditor_Click);
            // 
            // textBoxTileEditorStartAddress
            // 
            this.textBoxTileEditorStartAddress.Location = new System.Drawing.Point(134, 58);
            this.textBoxTileEditorStartAddress.Name = "textBoxTileEditorStartAddress";
            this.textBoxTileEditorStartAddress.Size = new System.Drawing.Size(132, 22);
            this.textBoxTileEditorStartAddress.TabIndex = 7;
            this.textBoxTileEditorStartAddress.Text = "425984";
            // 
            // labelTileEditorStartAddress
            // 
            this.labelTileEditorStartAddress.AutoSize = true;
            this.labelTileEditorStartAddress.Location = new System.Drawing.Point(30, 61);
            this.labelTileEditorStartAddress.Name = "labelTileEditorStartAddress";
            this.labelTileEditorStartAddress.Size = new System.Drawing.Size(98, 17);
            this.labelTileEditorStartAddress.TabIndex = 6;
            this.labelTileEditorStartAddress.Text = "Start Address:";
            this.labelTileEditorStartAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonTileEditorRomPathBrowse
            // 
            this.buttonTileEditorRomPathBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTileEditorRomPathBrowse.Image = ((System.Drawing.Image)(resources.GetObject("buttonTileEditorRomPathBrowse.Image")));
            this.buttonTileEditorRomPathBrowse.Location = new System.Drawing.Point(491, 28);
            this.buttonTileEditorRomPathBrowse.Name = "buttonTileEditorRomPathBrowse";
            this.buttonTileEditorRomPathBrowse.Size = new System.Drawing.Size(22, 22);
            this.buttonTileEditorRomPathBrowse.TabIndex = 5;
            this.buttonTileEditorRomPathBrowse.UseVisualStyleBackColor = true;
            this.buttonTileEditorRomPathBrowse.Click += new System.EventHandler(this.buttonTileEditorRomPathBrowse_Click);
            // 
            // textBoxTileEditorRomPath
            // 
            this.textBoxTileEditorRomPath.Location = new System.Drawing.Point(134, 30);
            this.textBoxTileEditorRomPath.Name = "textBoxTileEditorRomPath";
            this.textBoxTileEditorRomPath.Size = new System.Drawing.Size(351, 22);
            this.textBoxTileEditorRomPath.TabIndex = 4;
            // 
            // labelTileEditorRomPath
            // 
            this.labelTileEditorRomPath.AutoSize = true;
            this.labelTileEditorRomPath.Location = new System.Drawing.Point(51, 33);
            this.labelTileEditorRomPath.Name = "labelTileEditorRomPath";
            this.labelTileEditorRomPath.Size = new System.Drawing.Size(77, 17);
            this.labelTileEditorRomPath.TabIndex = 3;
            this.labelTileEditorRomPath.Text = "ROM Path:";
            this.labelTileEditorRomPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTileEditorEndAddress
            // 
            this.textBoxTileEditorEndAddress.Location = new System.Drawing.Point(381, 58);
            this.textBoxTileEditorEndAddress.Name = "textBoxTileEditorEndAddress";
            this.textBoxTileEditorEndAddress.Size = new System.Drawing.Size(132, 22);
            this.textBoxTileEditorEndAddress.TabIndex = 8;
            this.textBoxTileEditorEndAddress.Text = "429055";
            // 
            // labelTileEditorEndAddres
            // 
            this.labelTileEditorEndAddres.AutoSize = true;
            this.labelTileEditorEndAddres.Location = new System.Drawing.Point(277, 61);
            this.labelTileEditorEndAddres.Name = "labelTileEditorEndAddres";
            this.labelTileEditorEndAddres.Size = new System.Drawing.Size(93, 17);
            this.labelTileEditorEndAddres.TabIndex = 9;
            this.labelTileEditorEndAddres.Text = "End Address:";
            this.labelTileEditorEndAddres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTileEditorRows
            // 
            this.textBoxTileEditorRows.Location = new System.Drawing.Point(381, 86);
            this.textBoxTileEditorRows.Name = "textBoxTileEditorRows";
            this.textBoxTileEditorRows.Size = new System.Drawing.Size(132, 22);
            this.textBoxTileEditorRows.TabIndex = 10;
            this.textBoxTileEditorRows.Text = "4";
            // 
            // labelTileEditorRows
            // 
            this.labelTileEditorRows.AutoSize = true;
            this.labelTileEditorRows.Location = new System.Drawing.Point(324, 89);
            this.labelTileEditorRows.Name = "labelTileEditorRows";
            this.labelTileEditorRows.Size = new System.Drawing.Size(46, 17);
            this.labelTileEditorRows.TabIndex = 13;
            this.labelTileEditorRows.Text = "Rows:";
            this.labelTileEditorRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTileEditorColumns
            // 
            this.textBoxTileEditorColumns.Location = new System.Drawing.Point(134, 86);
            this.textBoxTileEditorColumns.Name = "textBoxTileEditorColumns";
            this.textBoxTileEditorColumns.Size = new System.Drawing.Size(132, 22);
            this.textBoxTileEditorColumns.TabIndex = 9;
            this.textBoxTileEditorColumns.Text = "24";
            // 
            // labelTileEditorColumns
            // 
            this.labelTileEditorColumns.AutoSize = true;
            this.labelTileEditorColumns.Location = new System.Drawing.Point(62, 89);
            this.labelTileEditorColumns.Name = "labelTileEditorColumns";
            this.labelTileEditorColumns.Size = new System.Drawing.Size(66, 17);
            this.labelTileEditorColumns.TabIndex = 10;
            this.labelTileEditorColumns.Text = "Columns:";
            this.labelTileEditorColumns.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TestLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 525);
            this.Controls.Add(this.groupBoxLaunchTileEditor);
            this.Controls.Add(this.groupBoxLaunchPaletteEditor);
            this.Controls.Add(this.groupBoxLaunchIPSCreator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TestLauncher";
            this.Text = "MDLib Test Launcher";
            this.groupBoxLaunchIPSCreator.ResumeLayout(false);
            this.groupBoxLaunchIPSCreator.PerformLayout();
            this.groupBoxLaunchPaletteEditor.ResumeLayout(false);
            this.groupBoxLaunchPaletteEditor.PerformLayout();
            this.groupBoxLaunchTileEditor.ResumeLayout(false);
            this.groupBoxLaunchTileEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLaunchIPSCreator;
        private System.Windows.Forms.Button buttonIPSFilePathBrowse;
        private System.Windows.Forms.TextBox textBoxIPSFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLaunchIPSCreator;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBoxLaunchPaletteEditor;
        private System.Windows.Forms.Button buttonPaletteEditorRomPathBrowse;
        private System.Windows.Forms.TextBox textBoxPaletteEditorRomPath;
        private System.Windows.Forms.Label labelPaletteEditorRomPath;
        private System.Windows.Forms.Button buttonLaunchPaletteEditor;
        private System.Windows.Forms.TextBox textBoxPaletteAddress;
        private System.Windows.Forms.Label labelPaletteAddress;
        private System.Windows.Forms.GroupBox groupBoxLaunchTileEditor;
        private System.Windows.Forms.TextBox textBoxTileEditorEndAddress;
        private System.Windows.Forms.Label labelTileEditorEndAddres;
        private System.Windows.Forms.Button buttonLaunchTileEditor;
        private System.Windows.Forms.TextBox textBoxTileEditorStartAddress;
        private System.Windows.Forms.Label labelTileEditorStartAddress;
        private System.Windows.Forms.Button buttonTileEditorRomPathBrowse;
        private System.Windows.Forms.TextBox textBoxTileEditorRomPath;
        private System.Windows.Forms.Label labelTileEditorRomPath;
        private System.Windows.Forms.TextBox textBoxTileEditorRows;
        private System.Windows.Forms.Label labelTileEditorRows;
        private System.Windows.Forms.TextBox textBoxTileEditorColumns;
        private System.Windows.Forms.Label labelTileEditorColumns;
    }
}

