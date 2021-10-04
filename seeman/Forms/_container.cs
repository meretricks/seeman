using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//70, 70, 75 - color

namespace winct
{
    public partial class _container : Form
    {
        public enum SyncStatus : int
        {
            Connected = 0,
            Local_Only = 1,
            Disconnected = 2

        }

        public Dictionary<int, Color> SyncDict = new Dictionary<int, Color>(3);

        public void setConnectionStatus(SyncStatus status)
        {
            label_SyncStatus.Text = Convert.ToString(status).Replace('_', ' ');

            Task.Run(() => {                                                              //Fade Status Bar
                Color c = SyncDict[(int)status];
                while (!panel_status.BackColor.IsCompared(c))
                {
                    Color bc = panel_status.BackColor;

                    int r = bc.R;
                    int g = bc.G;
                    int b = bc.B;

                    int r2 = c.R;
                    int g2 = c.G;
                    int b2 = c.B;

                    if (r < r2)
                        r += 1;
                    if (r > r2)
                        r -= 1;

                    if (g < g2)
                        g += 1;
                    if (g > g2)
                        g -= 1;

                    if (b < b2)
                        b += 1;
                    if (b > b2)
                        b -= 1;

                    Color newC = Color.FromArgb(r, g, b);

                    panel_status.BackColor = newC;
                    System.Threading.Thread.Sleep(1);
                }
            });
        }

        public _container()
        {
            InitializeComponent();

            SyncDict.Add((int)SyncStatus.Connected, Color.DodgerBlue);
            SyncDict.Add((int)SyncStatus.Local_Only, Color.Goldenrod);
            SyncDict.Add((int)SyncStatus.Disconnected, Color.Red);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            int y = btn_Edit.Height;
            contextMenuStrip1.Show(PointToScreen(new Point(btn_Edit.Location.X, y)));
        }

        private void newContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setConnectionStatus(SyncStatus.Connected);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            //parse container file

            //need to parse each line to find the following elements:
            //name, dir, encoding, parent, size, index, node_type

            foreach (var line in textBox1.Lines)
            {
                ContainerItem ci = new ContainerItem("");
                Regex r = new Regex(@"(\S*?)='(.*?)'");
                var m = r.Matches(line);

                string element = "";
                string value = "";
                string parent = "";

                //foreach (var m1 in m)
                for (int i = 0; i < m.Count; i++)
                {
                    var m1 = m[i];
                    string[] r2 = m1.ToString().Split('=');
                    element = r2[0];
                    value = r2[1].Replace("'", "");

                    tConsole.Text += element + ":" + value + "\r\n";

                    switch (element.ToLower())
                    {
                        case "name":
                            ci.Name = value;
                            ci.ElementName = value;
                            ci.Text = value;
                            break;
                        case "dir":
                            ci.ElementDir = value;
                            break;
                        case "encoding":
                            ci.ElementEncoding = value;
                            break;
                        case "size":
                            ci.ElementSize = Convert.ToInt32(value);
                            break;
                        case "index":
                            ci.ElementIndex = Convert.ToInt32(value);
                            break;
                        case "node_type":
                            ci.ElementNodeType = value;
                            break;
                        case "parent":
                            parent = value;
                            break;
                    }
                }

                if (parent != "" && treeView1.Nodes.Find(parent, true).Count() > 0)
                    treeView1.Nodes.Find(parent, true)[0].Nodes.Add(ci);
                else
                    treeView1.Nodes.Add(ci);
            }

        }
    }

    public class ContainerItem : TreeNode
    {
        public string ElementName { get; set; }
        public string ElementDir { get; set; }
        public string ElementEncoding { get; set; }
        public int ElementSize { get; set; }
        private int _index = 0;
        public int ElementIndex { get; set; }
        private string _type = "";
        public string ElementNodeType { get; set; }

        public ContainerItem(string name, string dir = "", string encoding = "", string parent = "", int size = 0, int index = 0, string nodeType = "")
        {
            Name = name.Replace(" ", "");
            ElementName = name;
            ElementDir = dir;
            ElementEncoding = encoding;
            if (parent != "")
                TreeView.Nodes[parent].Nodes.Add(this);
            _index = index;
            _type = nodeType;
        }
    }

    public static class ColorCompare
    {
        public static bool IsCompared(this Color c, Color col)
        {
            return (c.R == col.R && c.B == col.B && c.G == col.G);
        }
    }

    public class iData
    {

    }

}
