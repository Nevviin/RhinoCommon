using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Rhino.Commands;

namespace WpfDialog
{
    [Guid("abfcfcd5-7559-40ea-bad6-410712160f99")]
    [CommandStyle(Style.ScriptRunner)]
    public partial class DockPanel : UserControl
    {
        public static Guid PanelId { get { return typeof(DockPanel).GUID; } }
        public DockPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogBox dialog = new DialogBox();
            dialog.ShowDialog();
        }
    }
}
