using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        static string[] text;
        static int countWords = 0;
        static int lenght;
        public class Node
        {
           int count=0;
            public string Value;
            int height = 1;
            public Node Father;
            public Node Left;
            public Node Right;

            public void build()
            {

                
                if (lenght > 1)
                {
                    if (Value == null)
                    {
                        Value = text[count];
                    }
                    Left = new Node();
                    Right = new Node();
                    Left.Value = text[count + 1];
                    if ((lenght - 1) % 2 == 0)
                    {
                     Right.Value = text[(lenght/2)+1];
                    }
                    else
                    {
                        Right.Value = text[(lenght / 2) + 2];
                    }
                    count++;
                    lenght /= 2;
                    Left.build();
                }

                //Value = text[countWords];
                //countWords++;
                //if (this.Left == null)
                //{
                //    Left = new Node();
                //    Left.Father = this;
                //    if (Left.Father.Right != null)
                //    {
                //        this.Left.build();
                //    }
                //    else {
                //        Right = new Node();
                //        Right.Father = this;
                //        this.Right.build();
                //    }
                //}
                //else 
                //{
                //    Right = new Node();
                //    Right.Father = this;
                //    this.Right.build();
                //}

            }
        }
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //TreeNode tovarNode = new TreeNode("Товари");
            //treeView1.Nodes.Add(tovarNode);
            //tovarNode.Nodes.Add(new TreeNode("Смартфони"));

            //TreeNode tovarNode2 = new TreeNode("Ресурси");
            //tovarNode.Nodes.Add(tovarNode2);
            //TreeNode tovarNode3 = new TreeNode("Повітр'я");
            //treeView1.Nodes.Add(tovarNode3);
            //label1.Text=tovarNode.NextNode.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayText();
            lenght = text.Length;
            Node node = new Node();
            node.build();
        }
        private void ArrayText() {
            text=textBox1.Text.Split(new Char[] { ' ', ',', '.', ':', '\t' });
           // label1.Text= text[1];
        }
    }
}
