/*
MDLib_TestLauncher: simple dialog to launch the various UIs contained in the MDLib project

Copyright (c) 2015 Hugues Johnson

MDLib_TestLauncher is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License version 2 
as published by the Free Software Foundation.

MDLib_TestLauncher is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>. 
*/

using com.huguesjohnson.IPSCreator;
using com.huguesjohnson.MegaDriveIO;
using com.huguesjohnson.PaletteEditor;
using com.huguesjohnson.TileEditor;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDLib_TestLauncher
{
    public partial class TestLauncher:Form
    {
        private IMegaDriveIO romio=null; 

        public TestLauncher()
        {
            InitializeComponent();
        }

        private void buttonIPSFilePathBrowse_Click(object sender,EventArgs e)
        {
            System.Windows.Forms.DialogResult result=this.openFileDialog.ShowDialog(this);
            if(result.Equals(System.Windows.Forms.DialogResult.OK))
            {
                this.textBoxIPSFilePath.Text=this.openFileDialog.FileName;
            }
        }

        private void buttonLaunchIPSCreator_Click(object sender,EventArgs e)
        {
            if(this.textBoxIPSFilePath.Text.Length<1)
            {
                IPSCreatorForm ipsCreatorForm=new IPSCreatorForm();
                ipsCreatorForm.ShowDialog(this);
            }
            else
            {
                IPSCreatorForm ipsCreatorForm=new IPSCreatorForm(this.textBoxIPSFilePath.Text);
                ipsCreatorForm.ShowDialog(this);
            }
        }

        private void buttonPaletteEditorRomPathBrowse_Click(object sender,EventArgs e)
        {
            System.Windows.Forms.DialogResult result=this.openFileDialog.ShowDialog(this);
            if(result.Equals(System.Windows.Forms.DialogResult.OK))
            {
                this.textBoxPaletteEditorRomPath.Text=this.openFileDialog.FileName;
            }
        }

        private void buttonLaunchPaletteEditor_Click(object sender,EventArgs e)
        {
            if(this.romio!=null){this.romio.Dispose();}
            this.romio=new MDBinaryRomIO(this.textBoxPaletteEditorRomPath.Text);
            PaletteEditorForm paletteEditor=new PaletteEditorForm(this.romio,int.Parse(this.textBoxPaletteAddress.Text));
            paletteEditor.ShowDialog(this);
        }

        private void buttonTileEditorRomPathBrowse_Click(object sender,EventArgs e)
        {
            System.Windows.Forms.DialogResult result=this.openFileDialog.ShowDialog(this);
            if(result.Equals(System.Windows.Forms.DialogResult.OK))
            {
                this.textBoxTileEditorRomPath.Text=this.openFileDialog.FileName;
            }
        }

        private void buttonLaunchTileEditor_Click(object sender,EventArgs e)
        {
            if(this.romio!=null){this.romio.Dispose();}
            this.romio=new MDBinaryRomIO(this.textBoxTileEditorRomPath.Text);
            TileEditorForm tileEditor=new TileEditorForm(this.romio,int.Parse(this.textBoxTileEditorStartAddress.Text),int.Parse(this.textBoxTileEditorEndAddress.Text),int.Parse(this.textBoxTileEditorColumns.Text),int.Parse(this.textBoxTileEditorRows.Text),new LookupValueCollection());
            tileEditor.ShowDialog(this);
        }
    }
}
