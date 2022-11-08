using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outside
{
    public class Tree
    {
        public string TreeType { get; set; }
        public string Color { get; set; }
        public char Size { get; set; }
        public bool ContainsFruit { get; set; }

        public Tree()
        {
            var color = new[] {"Brown", "Red", "Orange", "Green", "Purple"};
            var size = new char[] { 'S', 'M', 'L', 'X' };
            var treeTypes = new string[] {"Maple", "Oak", "Dark Oak", "Birch", "Spruce", "Bamboo", "Palm", "Apple"};

            var random = new Random();

            this.TreeType = treeTypes[random.Next(treeTypes.Length)];
            this.Color = color[random.Next(color.Length)];
            this.Size = size[random.Next(size.Length)];
            
            if (TreeType == "Apple" || TreeType == "Palm")
            {
                this.ContainsFruit = true;
            }
            else
            {
                this.ContainsFruit = false;
            }
        }
        public override string ToString()
        {
            string msg = $"I am a {TreeType} tree.";

            switch (Size)
            {
                case 'S':
                    msg += "\nI am a small tree.";
                    break;
                case 'M':
                    msg += "\nI am a slightly larger tree, but not big enough!";
                    break;
                case 'L':
                    msg += "\nI am one of the biggest trees, but not the biggest of them all.";
                    break;
                case 'X':
                    msg += "\nI AM THE BIGGEST TREE HAHA";
                    break;
            }
            switch (Color)
            {
                case "Maple":
                    msg += "Maple";
                    break;
                case "Oak":
                    msg += "Oak";
                    break;
                case "Dark Oak":
                    msg += "Dark Oak";
                    break;
                case "Birch":
                    msg += "Birch";
                    break;
                case "Spruce":
                    msg += "Spruce";
                    break;
                case "Bamboo":
                    msg += "Bamboo";
                    break;
                case "Palm":
                    msg += "Palm";
                    break;
                case "Apple":
                    msg += "Apple";
                    break;
            }
            if (ContainsFruit)
            {
                msg += "\nOoo piece of candy!";
            }
            else
            {
                msg += "\nAw. No candy. :(";
            }
            return msg;
        }
    }
}
