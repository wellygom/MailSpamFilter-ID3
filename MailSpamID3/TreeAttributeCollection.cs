using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication1
{
    public class TreeAttributeCollection : List<TreeAttribute>
    {
        public bool ContainsAttribute(TreeAttribute treeAttribute)
        {
            foreach (TreeAttribute a in this)
            {
                if (a.AttributeName.Trim().ToUpper() == treeAttribute.AttributeName.Trim().ToUpper())
                    return true;
            }
            return false;
        }


    }
}