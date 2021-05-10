using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExploradordeArchivos
{
    public partial class explorador : Form
    {
        public explorador()
        {
            InitializeComponent();
            PopulateTreeView();
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                vistaArbol.Nodes.Add(rootNode);
            }
        }
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            try
            {
                foreach (DirectoryInfo subDir in subDirs)
                {
                    aNode = new TreeNode(subDir.Name, 0, 0);
                    aNode.Tag = subDir;
                    aNode.ImageKey = "Folder";
                    subSubDirs = subDir.GetDirectories();
                    if (subSubDirs.Length != 0)
                    {
                        GetDirectories(subSubDirs, aNode);
                    }
                    nodeToAddTo.Nodes.Add(aNode);
                }
            }catch(System.UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void vistaArbol_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            vistaArchivos.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                {new ListViewItem.ListViewSubItem(item, "Directorio"),new ListViewItem.ListViewSubItem(item,dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                vistaArchivos.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                if (file.Extension.Equals(".pdf"))
                {
                    item = new ListViewItem(file.Name, 8);
                    subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Documento PDF"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    vistaArchivos.Items.Add(item);
                }
                else if (file.Extension.Equals(".png") || file.Extension.Equals(".jpeg") || file.Extension.Equals(".jpg") || file.Extension.Equals(".jpe") || file.Extension.Equals(".jfif"))
                {
                    item = new ListViewItem(file.Name, 2);
                    subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Imagen"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    vistaArchivos.Items.Add(item);
                }
                else if (file.Extension.Equals(".doc") || file.Extension.Equals(".xml") || file.Extension.Equals(".rtf") || file.Extension.Equals(".docx"))
                {
                    item = new ListViewItem(file.Name, 3);
                    subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Documento de Texto"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    vistaArchivos.Items.Add(item);
                }
                else if (file.Extension.Equals(".exe"))
                {
                    item = new ListViewItem(file.Name, 4);
                    subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Archivo ejecutable"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    vistaArchivos.Items.Add(item);
                }
                else if (file.Extension.Equals(".txt"))
                {
                    item = new ListViewItem(file.Name, 5);
                    subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Archivo de texto"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    vistaArchivos.Items.Add(item);
                }
                else if (file.Extension.Equals(".java"))
                {
                    item = new ListViewItem(file.Name, 6);
                    subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Archivo de java"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    vistaArchivos.Items.Add(item);
                }
                else if (file.Extension.Equals(".mp3"))
                {
                    item = new ListViewItem(file.Name, 7);
                    subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Archivo de música"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    vistaArchivos.Items.Add(item);
                }
                else if (file.Extension.Equals(".rar") || file.Extension.Equals(".zip"))
                {
                    item = new ListViewItem(file.Name, 9);
                    subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Archivo comprimido"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    vistaArchivos.Items.Add(item);
                }
                else if (file.Extension.Equals(".mp4") || file.Extension.Equals(".avi") || file.Extension.Equals(".mpg") || file.Extension.Equals(".mov"))
                {
                    item = new ListViewItem(file.Name, 10);
                    subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Archivo de vídeo"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    vistaArchivos.Items.Add(item);
                }
                else
                {
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "Fichero"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    vistaArchivos.Items.Add(item);
                }
            }
            vistaArchivos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconosPequeñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vistaArchivos.View = View.SmallIcon;
        }

        private void iconosGrandesTSMI_Click(object sender, EventArgs e)
        {
            vistaArchivos.View = View.LargeIcon;
        }

        private void listaTSMI_Click(object sender, EventArgs e)
        {
            vistaArchivos.View = View.List;
        }

        private void detalleTSMI_Click(object sender, EventArgs e)
        {
            vistaArchivos.View = View.Details;
        }
    }
    }
