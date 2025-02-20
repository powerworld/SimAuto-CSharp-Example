using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using pwrworld;

namespace SimAuto_Example
{
    public partial class Form1 : Form
    {
        private ISimulatorAuto FSimAuto;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            gbOperations.Enabled = true;
            FSimAuto = new SimulatorAuto();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            gbOperations.Enabled = false;
            Marshal.FinalReleaseComObject(FSimAuto);
            FSimAuto = null;
        }

        private void btnOpenCase_Click(object sender, EventArgs e)
        {
            if (File.Exists(textCaseFileName.Text))
            {
                dynamic output = FSimAuto.OpenCase(textCaseFileName.Text);
                if (string.IsNullOrEmpty(output[0]))
                {
                    btnOpenCase.Enabled = false;
                    btnCloseCase.Enabled = true;
                    btnGetGenParams.Enabled = true;
                    btnOPF.Enabled = true;
                    btnScaleCase.Enabled = true;
                    btnSendGenToExcel.Enabled = true;
                    btnDisconnect.Enabled = false;
                    textLog.Text = textLog.Text + Environment.NewLine + "Opened case successfully!" + Environment.NewLine;
                }
                else
                {
                    MessageBox.Show("Error opening case", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseCase_Click(object sender, EventArgs e)
        {
            btnOpenCase.Enabled = true;
            btnCloseCase.Enabled = false;
            btnGetGenParams.Enabled = false;
            btnOPF.Enabled = false;
            btnScaleCase.Enabled = false;
            btnSendGenToExcel.Enabled = false;
            btnDisconnect.Enabled = true;
            FSimAuto.CloseCase();
        }

        private void btnGetGenParams_Click(object sender, EventArgs e)
        {
            object[] fieldarray = new object[] { "BusNum", "GenID", "GenStatus", "GenAGCAble", "GenMW", "GenMVR" };
            dynamic output = FSimAuto.GetParamsRectTyped("GEN", fieldarray, "", (ushort)VarEnum.VT_VARIANT);
            if (string.IsNullOrEmpty(output[0]))
            {
                textLog.Text = textLog.Text + Environment.NewLine;
                for (int i = 0; i < output[1].GetLength(0); i++)
                    textLog.Text = textLog.Text + output[1][i,0] + '\t' + output[1][i,1] + '\t' +
                         output[1][i,2] + '\t' + output[1][i,3] + '\t' + string.Format("{0,7:F1}", output[1][i,4]) +
                         '\t' + string.Format("{0,7:F1}", output[1][i,5]) + Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Error getting generator parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
            }
        }

        private void btnOPF_Click(object sender, EventArgs e)
        {
            dynamic output = FSimAuto.ListOfDevices("GEN", "");
            if (string.IsNullOrEmpty(output[0]))
            {
                object[] fieldlist = new object[] { "BusNum", "GenID", "GenAGCAble" };
                object[] objects = new object[output[1][0].Length];

                for (int i = 0; i < output[1][0].Length; i++)
                    objects[i] = new object[] { output[1][0][i], output[1][1][i], "YES" };

                output = FSimAuto.ChangeParametersMultipleElement("GEN", fieldlist, objects);
                if (!string.IsNullOrEmpty(output[0]))
                {
                    MessageBox.Show("Error setting generator GenAGCAble", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("Error getting generator list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
            }

            output = FSimAuto.ListOfDevices("AREA", "");
            if (string.IsNullOrEmpty(output[0]))
            {
                object[] fieldlist = new object[] { "AreaNum", "BGAGC", "OPFAreaLineLim" };
                object[] objects = new object[output[1][0].Length];

                for (int i = 0; i < output[1][0].Length; i++)
                    objects[i] = new object[] { output[1][0][i], "OPF", "YES" };

                output = FSimAuto.ChangeParametersMultipleElement("AREA", fieldlist, objects);
                if (!string.IsNullOrEmpty(output[0]))
                {
                    MessageBox.Show("Error setting area BGAGC and OPFAreaLineLim", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("Error getting area list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
            }

            output = FSimAuto.RunScriptCommand("Entermode(PowerFlow); SolvePowerFlow(DC); SolvePrimalLP; SolveFullSCOPF(OPF);");
            if (string.IsNullOrEmpty(output[0]))
                textLog.Text = textLog.Text + Environment.NewLine + "OPF executed successfully" + Environment.NewLine;
            else
                textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;

            object[] fieldarray = new object[] { "BusNum", "BusMCMW" };
            output = FSimAuto.GetParametersMultipleElement("BUS", fieldarray, "");
            if (string.IsNullOrEmpty(output[0]))
            {
                textLog.Text = textLog.Text + Environment.NewLine;
                for (int i = 0; i < output[1][0].Length; i++)
                    textLog.Text = textLog.Text + output[1][0][i] + '\t' + string.Format("{0,7:F1}", float.Parse(output[1][1][i])) +
                        Environment.NewLine;
            }
            else
            {
                MessageBox.Show("Error getting bus parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
            }
        }

        private void btnScaleCase_Click(object sender, EventArgs e)
        {
            dynamic output = FSimAuto.ListOfDevices("AREA", "");
            if (string.IsNullOrEmpty(output[0]))
            {
                object[] fieldlist = new object[] { "AreaNum", "BGScale" };
                object[] objects = new object[output[1][0].Length];

                for (int i = 0; i < output[1][0].Length; i++)
                    objects[i] = new object[] { output[1][0][i], "YES" };

                output = FSimAuto.ChangeParametersMultipleElement("AREA", fieldlist, objects);
                if (!string.IsNullOrEmpty(output[0]))
                {
                    MessageBox.Show("Error setting area BGScale", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("Error getting area list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
            }

            output = FSimAuto.RunScriptCommand("Entermode(Edit); Scale(LOAD, FACTOR, [0.9], AREA);");
            if (string.IsNullOrEmpty(output[0]))
                textLog.Text = textLog.Text + Environment.NewLine + "Case successfully scaled by 0.9" + Environment.NewLine;
            else
                textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
        }

        private void btnSendGenToExcel_Click(object sender, EventArgs e)
        {
            object[] fieldlist = new object[] { "BusNum", "GenID", "GenMW" };
            dynamic output = FSimAuto.SendToExcel("GEN", "", fieldlist);
            if (!string.IsNullOrEmpty(output[0]))
            {
                MessageBox.Show("Error sending data to Excel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textLog.Text = textLog.Text + Environment.NewLine + output[0] + Environment.NewLine;
            }
        }
    }
}
