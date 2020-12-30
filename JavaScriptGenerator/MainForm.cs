using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace JavaScriptGenerator
{
    public partial class MainForm : Form
    {
        public Type[] nameSpaceList;
        string dllLocation = @"F:\MyProject\ProgrammingBasic\shohangithub\ProgrammingBasic\StaticKeyword\bin\Debug\netcoreapp3.1\StaticKeyword.dll";
        private Assembly assembly;
        public MainForm()
        {
            InitializeComponent();
            GetAllDLLClass(dllLocation);
        }
        private void GetAllDLLClass(string location)
        {
            try
            {
                assembly = File.ReadDLLFile(location);
                nameSpaceList = assembly.ExportedTypes.ToArray();
                comboClassName.Items.Clear();
                comboClassName.Items.AddRange(nameSpaceList);
                txtLocation.Text = location;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ModelGenerator.WriteJSClass((Type)comboClassName.SelectedItem);
            ModelGenerator.WriteTSClass((Type)comboClassName.SelectedItem);
        }
        private void srcBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            dllLocation = fileDialog.FileName;
            GetAllDLLClass(dllLocation);
        }
    }
}
