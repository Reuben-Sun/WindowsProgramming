using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLRegedit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RegistryKey test;
        private void createButton_Click(object sender, EventArgs e)
        {
            test = Registry.CurrentUser.CreateSubKey("reuben9999");
            using (RegistryKey
            testName = test.CreateSubKey("TestName"),
            testSettings = test.CreateSubKey("TestSettings"))
            {
                // Create data for the TestSettings subkey.
                testSettings.SetValue("Language", "Chinese");
                testSettings.SetValue("Level", "Intermediate");
                testSettings.SetValue("ID", 999);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (RegistryKey
            testSettings = test.OpenSubKey("TestSettings", true))
            {
                // Delete the ID value.
                testSettings.DeleteValue("id");

                // Verify the deletion.
                Console.WriteLine((string)testSettings.GetValue(
                    "id", "ID not found."));
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (RegistryKey
            testName = test.CreateSubKey("TestName"),
            testSettings = test.CreateSubKey("TestSettings"))
            {
                // Create data for the TestSettings subkey.
                testSettings.SetValue("Language", "English");
                testSettings.SetValue("Level", "Intermediate");
                testSettings.SetValue("ID", 888);
            }
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            foreach (string subKeyName in test.GetSubKeyNames())
            {
                using (RegistryKey
                    tempKey = test.OpenSubKey(subKeyName))
                {
                    Console.WriteLine("\nThere are {0} values for {1}.",
                        tempKey.ValueCount.ToString(), tempKey.Name);
                    foreach (string valueName in tempKey.GetValueNames())
                    {
                        Console.WriteLine("{0,-8}: {1}", valueName,
                            tempKey.GetValue(valueName).ToString());
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
