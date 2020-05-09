using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg4_xxy180008
{
    /**
     * Class for the Line object
     * which stores number of lines and text content of each line
     *
     * Written by Xizhen Yang for CS6326.001, Assignment 4, starting April 13, 2020
     * NetID: XXY180008
     */
    class Line
    {
        private long lineNum;
        private String lineContent;

        public Line(long num, String content)
        {
            lineNum = num;
            lineContent = content;
        }

        public long getNum()
        {
            return lineNum;
        }

        public String getContent()
        {
            return lineContent;
        }
    }
}
