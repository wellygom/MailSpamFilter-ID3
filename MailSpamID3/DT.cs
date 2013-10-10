using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{

    public class DecisionTree
    {
        private DataTable _sampleData;
        private int mTotalPositives = 0;
        private int mTotal = 0;
        private string mTargetAttribute = "result";
        private double mEntropySet = 0.0;
        private int countTotalPositives(DataTable samples)
        {
            int result = 0;

            foreach (DataRow aRow in samples.Rows)
            {
                if (aRow[mTargetAttribute].ToString().ToUpper().Trim() == "HAM")
                    result++;
            }

            return result;
        }

        // -p+log2p+ - p-log2p-
        private double getCalculatedEntropy(int positives, int negatives)
        {
            int total = positives + negatives;
            double ratioPositive = (double)positives / total;
            double ratioNegative = (double)negatives / total;

            if (ratioPositive != 0)
                ratioPositive = -(ratioPositive) * System.Math.Log(ratioPositive, 2);
            if (ratioNegative != 0)
                ratioNegative = -(ratioNegative) * System.Math.Log(ratioNegative, 2);

            double result = ratioPositive + ratioNegative;

            return result;
        }


        private void getValuesToAttribute(DataTable samples, TreeAttribute attribute, string value, out int positives, out int negatives)
        {
            positives = 0;
            negatives = 0;

            foreach (DataRow aRow in samples.Rows)
            {
                if (((string)aRow[attribute.AttributeName] == value))
                    if (aRow[mTargetAttribute].ToString().Trim().ToUpper() == "HAM")
                        positives++;
                    else
                        negatives++;
            }
        }

        private double gain(DataTable samples, TreeAttribute attribute)
        {
            PossibleValueCollection values = attribute.PossibleValues;
            double sum = 0.0;

            for (int i = 0; i < values.Count; i++)
            {
                int positives, negatives;

                positives = negatives = 0;

                getValuesToAttribute(samples, attribute, values[i], out positives, out negatives);

                double entropy = getCalculatedEntropy(positives, negatives);
                sum += -(double)(positives + negatives) / mTotal * entropy;
            }
            return mEntropySet + sum;
        }

        private TreeAttribute getBestAttribute(DataTable samples, TreeAttributeCollection attributes)
        {
            double maxGain = 0.0;
            TreeAttribute result = null;

            foreach (TreeAttribute attribute in attributes)
            {
                double aux = gain(samples, attribute);
                if (aux > maxGain)
                {
                    maxGain = aux;
                    result = attribute;
                }
            }
            return result;
        }

        private bool allSamplesArePositive(DataTable samples, string targetAttribute)
        {
            foreach (DataRow row in samples.Rows)
            {
                if (row[targetAttribute].ToString().ToUpper().Trim() == "SPAM")
                    return false;
            }

            return true;
        }

        private bool allSamplesAreNegative(DataTable samples, string targetAttribute)
        {
            foreach (DataRow row in samples.Rows)
            {
                if (row[targetAttribute].ToString().ToUpper().Trim() == "HAM")
                    return false;
            }

            return true;
        }

        private ArrayList getDistinctValues(DataTable samples, string targetAttribute)
        {
            ArrayList distinctValues = new ArrayList(samples.Rows.Count);

            foreach (DataRow row in samples.Rows)
            {
                if (distinctValues.IndexOf(row[targetAttribute]) == -1)
                    distinctValues.Add(row[targetAttribute]);
            }

            return distinctValues;
        }

        private object getMostCommonValue(DataTable samples, string targetAttribute)
        {
            ArrayList distinctValues = getDistinctValues(samples, targetAttribute);
            int[] count = new int[distinctValues.Count];

            foreach (DataRow row in samples.Rows)
            {
                int index = distinctValues.IndexOf(row[targetAttribute]);
                count[index]++;
            }

            int MaxIndex = 0;
            int MaxCount = 0;

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > MaxCount)
                {
                    MaxCount = count[i];
                    MaxIndex = i;
                }
            }

            return distinctValues[MaxIndex];
        }

        private TreeNode internalMountTree(DataTable samples, string targetAttribute, TreeAttributeCollection attributes)
        {
            if (allSamplesArePositive(samples, targetAttribute) == true)
                return new TreeNode(new OutcomeTreeAttribute("ham"));

            if (allSamplesAreNegative(samples, targetAttribute) == true)
                return new TreeNode(new OutcomeTreeAttribute("spam"));

            if (attributes.Count == 0)
                return new TreeNode(new OutcomeTreeAttribute(getMostCommonValue(samples, targetAttribute)));

            mTotal = samples.Rows.Count;
            mTargetAttribute = targetAttribute;
            mTotalPositives = countTotalPositives(samples);

            mEntropySet = getCalculatedEntropy(mTotalPositives, mTotal - mTotalPositives);

            TreeAttribute bestAttribute = getBestAttribute(samples, attributes);

            TreeNode root = new TreeNode(bestAttribute);

            if (bestAttribute == null)
                return root;

            DataTable aSample = samples.Clone();

            foreach (string value in bestAttribute.PossibleValues)
            {
  			
                aSample.Rows.Clear();

                DataRow[] rows = samples.Select(bestAttribute.AttributeName + " = " + "'" + value + "'");

                foreach (DataRow row in rows)
                {
                    aSample.Rows.Add(row.ItemArray);
                }
	
                TreeAttributeCollection aAttributes = new TreeAttributeCollection();

                for (int i = 0; i < attributes.Count; i++)
                {
                    if (attributes[i].AttributeName != bestAttribute.AttributeName)
                        aAttributes.Add(attributes[i]);
                }

                if (aSample.Rows.Count == 0)
                {
                    return new TreeNode(new OutcomeTreeAttribute(getMostCommonValue(aSample, targetAttribute)));
                }
                else
                {
                    DecisionTree dc3 = new DecisionTree();
                    TreeNode ChildNode = dc3.mountTree(aSample, targetAttribute, aAttributes);
                    root.AddTreeNode(ChildNode, value);
                }
            }

            return root;
        }

        public TreeNode mountTree(DataTable samples, string targetAttribute, TreeAttributeCollection attributes)
        {
            _sampleData = samples;
            return internalMountTree(_sampleData, targetAttribute, attributes);
        }
    }

    public class DecisionTreeImplementation
    {

        string _sourceFile;
        
        public System.Windows.Forms.TreeNode GetTree(string sourceFile)
        {
            _sourceFile = sourceFile;
            RawDataSource samples = new RawDataSource(_sourceFile);

            TreeAttributeCollection attributes = samples.GetValidAttributeCollection(); //term

            DecisionTree id3 = new DecisionTree();
            TreeNode root = id3.mountTree(samples, "result", attributes);

            return PrintNode(root,"");
            
        }
        public System.Windows.Forms.TreeNode PrintNode(TreeNode root,string agg)
        {
            var hasil = new System.Windows.Forms.TreeNode();
            hasil.Text = agg + " : " + root.Attribute;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                if (root.GetChildAt(i)!=null)
                {
                    hasil.Nodes.Add(PrintNode(root.GetChildAt(i),root.Attribute.PossibleValues[i])); 
                }
            }



            return hasil;
        }

    }

    // TESTING
    public class DecisionTreeTesting
    {

        string _sourceFile;
        List<string> _dataInv = new List<string>();
        List<string> _term = new List<string>();
        string result = String.Empty;

        public string GetResult(string sourceFile, List<string> dataInv, List<string> term)
        {
            _sourceFile = sourceFile;
            RawDataSource samples = new RawDataSource(_sourceFile);

            TreeAttributeCollection attributes = samples.GetValidAttributeCollection();

            DecisionTree id3 = new DecisionTree();
            TreeNode root = id3.mountTree(samples, "result", attributes);

            return PrintResult(root, dataInv, term);

        }
        public string PrintResult(TreeNode root, List<string> dataInv, List<string> term)
        {
            if (root.Attribute.PossibleValues == null)
            {
                result += root.Attribute;
            }
            else
            {
                for (int i = 0; i < term.Count; i++)
                {
                    if (term[i].Equals(root.Attribute.AttributeName))
                    {

                        if (root.Attribute.PossibleValues != null)
                        {
                            for (int j = 0; j < root.Attribute.PossibleValues.Count; j++)
                            {
                                if (dataInv[i].Equals(root.Attribute.PossibleValues[j]))
                                {
                                    TreeNode childNode = root.GetChildByBranchName(root.Attribute.PossibleValues[j]);
                                    if (childNode.Attribute!=null)
                                    {
                                        result = PrintResult(childNode, dataInv, term); 
                                    }
                                }
                            }
                            if (result == String.Empty)
                                return "spam";
                        }
                    }
                }
            }

            return result;
        }

    }
}
